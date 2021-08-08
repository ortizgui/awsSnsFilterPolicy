using System;
using Amazon.Lambda.SNSEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace HelloWorld
{

    public class Function
    {
       public string FunctionHandler(SNSEvent snsEvent)
       {
           foreach (var record in snsEvent.Records)
           {
               var snsRecord = record.Sns;
               Console.WriteLine($"[{record.EventSource} {snsRecord.Timestamp}] Message = {snsRecord.Message}");
           }
           
           return String.Empty;
       }
    }
}
