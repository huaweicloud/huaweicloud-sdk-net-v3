using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.Kms.V1
{
    public class MasterKeyManagement
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

            CreateKey(kmsClient);
            DeleteKey(kmsClient);
            CancelKeyDeletion(kmsClient);
            EnableKey(kmsClient);
            DisableKey(kmsClient);
            EnableKey(kmsClient);
            UpdateKeyAlias(kmsClient);
            UpdateKeyDescription(kmsClient);
        }

        private static void CreateKey(KmsClient kmsClient)
        {
            var req = new CreateKeyRequest
            {
                VersionId = "v1.0",
                Body = new CreateKeyRequestBody()
                {
                    KeyAlias = "0000"
                }
            };
            try
            {
                var resp = kmsClient.CreateKey(req);
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

        private static void DeleteKey(KmsClient kmsClient)
        {
            try
            {
                var req = new DeleteKeyRequest
                {
                    VersionId = "v1.0",
                    Body = new ScheduleKeyDeletionRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        PendingDays = "365"
                    }
                };
                var resp = kmsClient.DeleteKey(req);
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

        private static void CancelKeyDeletion(KmsClient kmsClient)
        {
            try
            {
                var req = new CancelKeyDeletionRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "4")
                    }
                };
                var resp = kmsClient.CancelKeyDeletion(req);
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

        private static void EnableKey(KmsClient kmsClient)
        {
            try
            {
                var req = new EnableKeyRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "3")
                    }
                };
                var resp = kmsClient.EnableKey(req);
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

        private static void DisableKey(KmsClient kmsClient)
        {
            try
            {
                var req = new DisableKeyRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.DisableKey(req);
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

        private static void UpdateKeyAlias(KmsClient kmsClient)
        {
            try
            {
                var req = new UpdateKeyAliasRequest
                {
                    VersionId = "v1.0",
                    Body = new UpdateKeyAliasRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        KeyAlias = "0000"
                    }
                };
                var resp = kmsClient.UpdateKeyAlias(req);
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

        private static void UpdateKeyDescription(KmsClient kmsClient)
        {
            try
            {
                var req = new UpdateKeyDescriptionRequest
                {
                    VersionId = "v1.0",
                    Body = new UpdateKeyDescriptionRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        KeyDescription = "0000"
                    }
                };
                var resp = kmsClient.UpdateKeyDescription(req);
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