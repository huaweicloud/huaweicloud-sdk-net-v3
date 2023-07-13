using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class SecurityGroupRule
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
            var vpcClient = VpcClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListSecurityGroupRules(vpcClient);
            ShowSecurityGroupRule(vpcClient);
            CreateSecurityGroupRule(vpcClient);
            DeleteSecurityGroupRule(vpcClient);
        }

        private static void CreateSecurityGroupRule(VpcClient client)
        {
            CreateSecurityGroupRuleRequest req = new CreateSecurityGroupRuleRequest
            {
                Body = new CreateSecurityGroupRuleRequestBody
                {
                    SecurityGroupRule = new CreateSecurityGroupRuleOption
                    {
                        Description = "test-security-group-rule",
                        SecurityGroupId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c",
                        Direction = "ingress",
                        Ethertype = "IPv4",
                        PortRangeMin = 50,
                        PortRangeMax = 100,
                        Protocol = "udp"
                    }
                }
            };
            try
            {
                var resp = client.CreateSecurityGroupRule(req);
                Console.WriteLine(resp.SecurityGroupRule.Id);
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

        private static void ListSecurityGroupRules(VpcClient client)
        {
            ListSecurityGroupRulesRequest req = new ListSecurityGroupRulesRequest
            {
                Limit = 1,
            };

            try
            {
                ListSecurityGroupRulesResponse resp = client.ListSecurityGroupRules(req);
                foreach (var securityGroupRule in resp.SecurityGroupRules)
                {
                    Console.WriteLine(securityGroupRule.Id);
                    Console.WriteLine(securityGroupRule.Protocol);
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


        private static void ShowSecurityGroupRule(VpcClient client)
        {
            ShowSecurityGroupRuleRequest req = new ShowSecurityGroupRuleRequest
            {
                SecurityGroupRuleId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowSecurityGroupRule(req);
                Console.WriteLine(resp.SecurityGroupRule.Id);
                Console.WriteLine(resp.SecurityGroupRule.Protocol);
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

        private static void DeleteSecurityGroupRule(VpcClient client)
        {
            var req = new DeleteSecurityGroupRuleRequest
            {
                SecurityGroupRuleId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeleteSecurityGroupRuleResponse resp = client.DeleteSecurityGroupRule(req);
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
    }
}