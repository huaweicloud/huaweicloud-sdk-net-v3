using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class GrantFunction
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

            ListGrant(kmsClient);
            ListRetirableGrants(kmsClient);
            RetireGrant(kmsClient);
            RevokeGrant(kmsClient);
        }

        private static string CreateGrant (KmsClient kmsClient)
        {
            var operations = new List<string>{"describe-key", "create-datakey"};
            try
            {
                var request = new CreateGrantRequest
                {
                    VersionId = "v1.0",
                    Body = new CreateGrantRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        GranteePrincipal = "99104bff46109531b9ac70e606d3ffdf",
                        GranteePrincipalType = CreateGrantRequestBody.GranteePrincipalTypeEnum.DOMAIN,
                        Operations = operations
                        
                    }
                };
                var resp = kmsClient.CreateGrant(request);
                Console.WriteLine(resp.GrantId);
                return resp.GrantId;
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

        private static void ListGrant(KmsClient kmsClient)
        {
            try
            {
                var request = new ListGrantsRequest
                {
                    VersionId = "v1.0",
                    Body = new ListGrantsRequestBody()
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")
                    }
                };
                var resp = kmsClient.ListGrants(request);
                
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
        
        private static void ListRetirableGrants(KmsClient kmsClient)
        {
            try
            {
                var request = new ListRetirableGrantsRequest
                {
                    VersionId = "v1.0",
                    Body = new ListRetirableGrantsRequestBody()

                };
                var resp = kmsClient.ListRetirableGrants(request);
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

        private static void RetireGrant(KmsClient kmsClient)
        {
            try
            {
                var request = new CancelSelfGrantRequest
                {
                    VersionId = "v1.0",
                    Body = new RevokeGrantRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        GrantId = CreateGrant(kmsClient)
                    }

                };
                var resp = kmsClient.CancelSelfGrant(request);
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
        
        private static void RevokeGrant(KmsClient kmsClient)
        {
            try
            {
                var request = new CancelGrantRequest
                {
                    VersionId = "v1.0",
                    Body = new RevokeGrantRequestBody
                    {
                        KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                        GrantId = CreateGrant(kmsClient)
                    }

                };
                var resp = kmsClient.CancelGrant(request);
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