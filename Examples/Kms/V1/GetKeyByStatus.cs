using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class GetKeyByStatus
    {
        public static string GetKeyByKeyStatus(KmsClient kmsClient, string status)
        {
            var request = new ListKeysRequest
            {
                VersionId = "v1.0",
                Body = new ListKeysRequestBody
                {
                    KeyState = status
                }
            };
            
            try
            {
                var resp = kmsClient.ListKeys(request);
                if (resp.Keys.Count != 0)
                {
                    return resp.Keys[0];
                }
                
                var req = new CreateKeyRequest
                {
                    VersionId = "v1.0",
                    Body = new CreateKeyRequestBody()
                    {
                        KeyAlias = "0000"
                    }
                };
                var createKeyResponse = kmsClient.CreateKey(req);
                return createKeyResponse.KeyInfo.KeyId;
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
    }
}