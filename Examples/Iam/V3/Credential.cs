using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Iam.V3;
using HuaweiCloud.SDK.Iam.V3.Model;
using Newtonsoft.Json;

namespace Examples.Iam.V3
{
    public class CredentialDemo
    {
        static void Main1(string[] args)
        {
            // 华为云
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string domainId = "{your domainID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new GlobalCredentials(ak, sk, domainId);
            var iamDomainClient = IamClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();
            // Credential管理

            // 通过委托获取临时访问秘钥和securitytoken POST /v3.0/OS-CREDENTIAL/securitytokens
            CreateTemporaryAccessKeyByAgency(iamDomainClient);

            // 通过token来获取临时AK/SK和securitytoken POST /v3.0/OS-CREDENTIAL/securitytokens
            CreateTemporaryAccessKeyByToken(iamDomainClient);
        }

        // Credential管理

        private static void CreateTemporaryAccessKeyByAgency(IamClient iamClient)
        {
            var createTemporaryAccessKeyByAgencyRequest = new CreateTemporaryAccessKeyByAgencyRequest()
            {

                Body = new CreateTemporaryAccessKeyByAgencyRequestBody()
                {
                    Auth = new AgencyAuth()
                    {
                        Identity = new AgencyAuthIdentity()
                        {
                            Methods = new List<AgencyAuthIdentity.MethodsEnum>() {AgencyAuthIdentity.MethodsEnum.ASSUME_ROLE},
                            AssumeRole = new IdentityAssumerole()
                            {
                                DomainName = "",
                                AgencyName = "",
                                DomainId = "",
                                DurationSeconds = 900,
                                SessionUser = new AssumeroleSessionuser()
                                {
                                    Name = ""
                                }
                            }
                        }
                    }
                }
            };
            try
            {
                var createTemporaryAccessKeyByAgencyResponse =
                    iamClient.CreateTemporaryAccessKeyByAgency(createTemporaryAccessKeyByAgencyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(createTemporaryAccessKeyByAgencyResponse.Credential));
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

        private static void CreateTemporaryAccessKeyByToken(IamClient iamClient)
        {
            var createTemporaryAccessKeyByTokenRequest = new CreateTemporaryAccessKeyByTokenRequest()
            {
                Body = new CreateTemporaryAccessKeyByTokenRequestBody()
                {
                    Auth = new TokenAuth()
                    {
                        Identity = new TokenAuthIdentity()
                        {
                            Methods = new List<TokenAuthIdentity.MethodsEnum>() {TokenAuthIdentity.MethodsEnum.TOKEN},
                            Token = new IdentityToken()
                            {
                                Id = "",
                                DurationSeconds = 900
                            }
                        }
                    }
                }
            };
            try
            {
                var createTemporaryAccessKeyByTokenResponse =
                    iamClient.CreateTemporaryAccessKeyByToken(createTemporaryAccessKeyByTokenRequest);
                Console.WriteLine(JsonConvert.SerializeObject(createTemporaryAccessKeyByTokenResponse.Credential));
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