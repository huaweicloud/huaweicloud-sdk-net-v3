using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class DataKeyFunction
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

            GenRandom(kmsClient);
            CreateDataKeyWithoutPlaintext(kmsClient);
            EncryptDataKey(kmsClient);
        }

        private static void GenRandom(KmsClient kmsClient)
        {
            var request = new CreateRandomRequest
            {
                VersionId = "v1.0",
                Body = new GenRandomRequestBody()
                {
                    RandomDataLength = "512"
                }
            };

            try
            {
                var resp = kmsClient.CreateRandom(request);
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

        private static CreateDatakeyResponse CreateDataKey(KmsClient kmsClient)
        {
            try
            {
                var request = new CreateDatakeyRequest
                {
                    VersionId = "v1.0",
                    Body = new CreateDatakeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        DatakeyLength = "512"
                    }
                };
                var resp = kmsClient.CreateDatakey(request);
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

        private static void CreateDataKeyWithoutPlaintext(KmsClient kmsClient)
        {
            try
            {
                var request = new CreateDatakeyWithoutPlaintextRequest
                {
                    VersionId = "v1.0",
                    Body = new CreateDatakeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        DatakeyLength = "512"
                    }
                };
                var resp = kmsClient.CreateDatakeyWithoutPlaintext(request);
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

        private static DecryptDatakeyResponse DecryptDataKey(KmsClient kmsClient)
        {
            try
            {
                var cipherText = CreateDataKey(kmsClient).CipherText;
                var request = new DecryptDatakeyRequest
                {
                    VersionId = "v1.0",
                    Body = new DecryptDatakeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        CipherText = cipherText,
                        DatakeyCipherLength = "64"
                    }
                };
                var resp = kmsClient.DecryptDatakey(request);
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

        private static void EncryptDataKey(KmsClient kmsClient)
        {
            try
            {
                var data = DecryptDataKey(kmsClient);
                var plainText = data.DataKey + data.DatakeyDgst;
                var request = new EncryptDatakeyRequest
                {
                    VersionId = "v1.0",
                    Body = new EncryptDatakeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        DatakeyPlainLength = "64",
                        PlainText = plainText
                    }
                };
                var resp = kmsClient.EncryptDatakey(request);
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