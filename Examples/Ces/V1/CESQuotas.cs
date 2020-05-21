using System;
using HuaweiCloud.SDK.Ces.V1;
using HuaweiCloud.SDK.Ces.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCSharpSDK
{
    public class CESQuotas
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;

            var auth = new BasicCredentials(ak, sk, projectId);
            var cesClient = CesClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ShowQuotas(cesClient);
        }

        /// <summary>
        /// 查询用户可以创建的资源配额总数及当前使用量，当前仅有告警规则一种资源类型。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ShowQuotas(CesClient cesClient)
        {
            ShowQuotasRequest showQuotasRequest = new ShowQuotasRequest(){ };

            try
            {
                ShowQuotasResponse showQuotasResponse = cesClient.ShowQuotas(showQuotasRequest);
                foreach (var resource in showQuotasResponse.Quotas.Resources)
                {
                    Console.WriteLine(resource.ToString());
                }
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