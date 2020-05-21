using System;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingActivityLog
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

            //scaling group test
            ListScalingActivityLogsV1(asClient);
        }

        // List Scaling Activity Log V1
        private static void ListScalingActivityLogsV1(AsClient asClient)
        {
            var listScalingActivityLogsRequest = new ListScalingActivityLogsRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listScalingActivityLogsResponse = asClient.ListScalingActivityLogs(listScalingActivityLogsRequest);
                Console.WriteLine(listScalingActivityLogsResponse.ScalingActivityLog);
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