using System;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingPolicyExecuteLog
    {
        private static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var asClient = AsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();


            //scaling policy test
            ListScalingPolicyExecuteLogs(asClient);
        }

        // Scaling Policy Execute Log
        // ListScalingPolicyExecuteLogs
        private static void ListScalingPolicyExecuteLogs(AsClient asClient)
        {
            var listScalingPolicyExecuteLogsRequest = new ListScalingPolicyExecuteLogsRequest
            {
                ScalingPolicyId = "19a06b0b-66cc-4059-95fa-ad35f7a33998"
            };
            try
            {
                var listScalingPolicyExecuteLogsResponse =
                    asClient.ListScalingPolicyExecuteLogs(listScalingPolicyExecuteLogsRequest);
                Console.WriteLine(listScalingPolicyExecuteLogsResponse.ScalingPolicyExecuteLog);
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.ErrorCode);
                Console.WriteLine(clientRequestException.ErrorMsg);
            }
            catch (ConnectionException connectionException)
            {
                Console.WriteLine(connectionException.ErrorMessage);
            }
        }
    }
}