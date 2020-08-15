using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class QueryFunction
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);

            var kmsClient = KmsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();
            
            DescribeKey(kmsClient);
            GetInstances(kmsClient);
            GetQuotas(kmsClient);
            GetVersion(kmsClient);
            GetVersions(kmsClient);
        }

        private static void DescribeKey(KmsClient kmsClient)
        {
            try
            {
                var req = new ListKeyDetailRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.ListKeyDetail(req);
                Console.WriteLine(resp.ToString());
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
        
        private static void GetVersions(KmsClient kmsClient)
        {
            try
            {
                var req = new ShowVersionsRequest();
                var resp = kmsClient.ShowVersions(req);

                Console.WriteLine(resp.HttpStatusCode);


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
        
        private static void GetVersion(KmsClient kmsClient)
        {
            try
            {
                var req = new ShowVersionRequest
                {
                    VersionId = "v1.0"
                };
                var resp = kmsClient.ShowVersion(req);
                Console.WriteLine(resp.ToString());
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
        
        private static void GetInstances(KmsClient kmsClient)
        {
            try
            {
                var req = new ShowUserInstancesRequest
                {
                    VersionId = "v1.0"
                };
                var resp = kmsClient.ShowUserInstances(req);
                Console.WriteLine(resp.ToString());
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
        
        private static void GetQuotas(KmsClient kmsClient)
        {
            try
            {
                var req = new ShowUserQuotasRequest
                {
                    VersionId = "v1.0"
                };
                var resp = kmsClient.ShowUserQuotas(req);
                Console.WriteLine(resp.ToString());
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