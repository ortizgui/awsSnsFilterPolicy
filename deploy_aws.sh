#!/bin/sh

s3_bucket="PLEASE_INSERT_A_NEW_GUID_HERE_TO_CREATE_A_UNIQUE_BUCKET_NAME"
stack_name="SET_A_NEW_NAME_FOR_YOUR_CLOUDFORMATION_STACK"

sam validate
sam build
sam package --s3-bucket $s3_bucket --output-template-file package.yml
sam deploy --template-file package.yml --stack-name $stack_name --capabilities CAPABILITY_IAM