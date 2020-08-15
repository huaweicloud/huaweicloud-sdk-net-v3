using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class RotationFunction
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
            EnableKeyRotation(kmsClient);
            UpdateKeyRotationInterval(kmsClient);
            DisableKeyRotation(kmsClient);
            
        }

        private static ShowKeyRotationStatusResponse GetKeyRotationStatus(KmsClient kmsClient)
        {
            try
            {
                var request = new ShowKeyRotationStatusRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.ShowKeyRotationStatus(request);
                Console.WriteLine(resp);
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

        private static void EnableKeyRotation(KmsClient kmsClient)
        {
            try
            {
                if (GetKeyRotationStatus(kmsClient).KeyRotationEnabled.GetValueOrDefault())
                {
                    DisableKeyRotation(kmsClient);
                }
                var request = new EnableKeyRotationRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.EnableKeyRotation(request);
                Console.WriteLine(resp);
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
        
        private static void UpdateKeyRotationInterval(KmsClient kmsClient)
        {
            try
            {
                if (!GetKeyRotationStatus(kmsClient).KeyRotationEnabled.GetValueOrDefault())
                { 
                    EnableKeyRotation(kmsClient);
                }
                var request = new UpdateKeyRotationIntervalRequest
                {
                    VersionId = "v1.0",
                    Body = new UpdateKeyRotationIntervalRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        RotationInterval = 30
                    }
                };
                var resp = kmsClient.UpdateKeyRotationInterval(request);
                Console.WriteLine(resp);
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
        
        private static void DisableKeyRotation(KmsClient kmsClient)
        {
            try
            {
                if (!GetKeyRotationStatus(kmsClient).KeyRotationEnabled.GetValueOrDefault())
                { 
                    EnableKeyRotation(kmsClient);
                }
                var request = new DisableKeyRotationRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.DisableKeyRotation(request);
                Console.WriteLine(resp);
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