using System;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class Quota
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
            ShowResourceQuota(asClient);
            ShowPolicyAndInstanceQuota(asClient);
        }

        // Quota
        // ShowResourceQuota
        private static void ShowResourceQuota(AsClient asClient)
        {
            var showResourceQuotaRequest = new ShowResourceQuotaRequest();
            try
            {
                var showResourceQuotaResponse = asClient.ShowResourceQuota(showResourceQuotaRequest);
                Console.WriteLine(showResourceQuotaResponse.Quotas);
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

        // ShowPolicyAndInstanceQuota
        private static void ShowPolicyAndInstanceQuota(AsClient asClient)
        {
            var showPolicyAndInstanceQuotaRequest = new ShowPolicyAndInstanceQuotaRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var showPolicyAndInstanceQuotaResponse =
                    asClient.ShowPolicyAndInstanceQuota(showPolicyAndInstanceQuotaRequest);
                Console.WriteLine(showPolicyAndInstanceQuotaResponse.AllQuotas);
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