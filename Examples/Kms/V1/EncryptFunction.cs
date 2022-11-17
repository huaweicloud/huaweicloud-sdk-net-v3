using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class EncryptFunction
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
            
            DecryptData(kmsClient);
        }

        private static EncryptDataResponse EncryptData(KmsClient kmsClient)
        {
            try
            {
                var request = new EncryptDataRequest
                {
                    VersionId = "v1.0",
                    Body = new EncryptDataRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        PlainText = "hello world"
                    }
                };
                var resp = kmsClient.EncryptData(request);
                Console.WriteLine(resp.ToString());
                return resp;
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

            return null;
        }
        
        private static void DecryptData(KmsClient kmsClient)
        {
            try
            {
                var request = new DecryptDataRequest
                {
                    VersionId = "v1.0",
                    Body = new DecryptDataRequestBody()
                    {
                        CipherText = EncryptData(kmsClient).CipherText
                    }
                };
                var resp = kmsClient.DecryptData(request);
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