# POC SNS Filter Policy for multiple consumers

POC for discovery SNS with Filter Policy

## Pre-Requisite

* [SAM CLI](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-sam-cli-install.html)
* [.NET Core](https://www.microsoft.com/net/download)
* [AWS CLI](https://aws.amazon.com/cli/)
* [Node.JS 14.x](https://nodejs.org/en/download/)

## Goals

This test is for sns filter policy to send messages to different consumers, in this case, lambda functions.
For this POC, we created two consumers (Consumer A and Consumer B). Theses consumers receive only message when Message Attributes 
`schema` is equal: *schema_a* or *schema_b*.

## Running the project on your AWS account

Create a new S3 bucket.
Configure your AWS account on AWS Cli with `aws configure` command.

In the directory .\AwsPoc run the commands:
PS: Replace {{s3_bucket}} with your S3 bucket name.

```
sam validate
sam build
sam package --s3-bucket {{s3_bucket}} --output-template-file package.yml
sam deploy --template-file package.yml --stack-name snsPoc --capabilities CAPABILITY_IAM
```

### Send message to SNS


## Remove stack from your account

After completing the tests, remove the created objects from your account by running the command:
```
aws cloudformation delete-stack --stack-name snsPoc
```

## References
> [Designing durable serverless apps with DLQs for Amazon SNS, Amazon SQS, AWS Lambda](https://aws.amazon.com/blogs/compute/designing-durable-serverless-apps-with-dlqs-for-amazon-sns-amazon-sqs-aws-lambda/)