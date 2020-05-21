using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class SecurityGroup
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

            ListSecurityGroups(vpcClient);
            ShowSecurityGroup(vpcClient);
            CreateSecurityGroup(vpcClient);
            DeleteSecurityGroup(vpcClient);
        }

        private static void CreateSecurityGroup(VpcClient client)
        {
            CreateSecurityGroupRequest req = new CreateSecurityGroupRequest
            {
                Body = new CreateSecurityGroupRequestBody
                {
                    SecurityGroup = new CreateSecurityGroupOption
                    {
                        Name = "test-security-group",
                        VpcId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c"
                    }
                }
            };
            try
            {
                var resp = client.CreateSecurityGroup(req);
                Console.WriteLine(resp.SecurityGroup.Id);
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

        private static void ListSecurityGroups(VpcClient client)
        {
            ListSecurityGroupsRequest req = new ListSecurityGroupsRequest
            {
                Limit = 1,
            };

            try
            {
                ListSecurityGroupsResponse resp = client.ListSecurityGroups(req);
                foreach (var securityGroup in resp.SecurityGroups)
                {
                    Console.WriteLine(securityGroup.Id);
                    Console.WriteLine(securityGroup.Name);
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


        private static void ShowSecurityGroup(VpcClient client)
        {
            ShowSecurityGroupRequest req = new ShowSecurityGroupRequest
            {
                SecurityGroupId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowSecurityGroup(req);
                Console.WriteLine(resp.SecurityGroup.Id);
                Console.WriteLine(resp.SecurityGroup.Name);
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

        private static void DeleteSecurityGroup(VpcClient client)
        {
            var req = new DeleteSecurityGroupRequest
            {
                SecurityGroupId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeleteSecurityGroupResponse resp = client.DeleteSecurityGroup(req);
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