using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class Vpc
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

            ListVpc(vpcClient);
            ShowVpc(vpcClient);
            CreateVpc(vpcClient);
            UpdateVpc(vpcClient);
            DeleteVpc(vpcClient);
        }

        private static void CreateVpc(VpcClient client)
        {
            CreateVpcRequest req = new CreateVpcRequest
            {
                Body = new CreateVpcRequestBody
                {
                    Vpc = new CreateVpcOption
                    {
                        Name = "test-vpc",
                        Description = "Test vpc",
                        Cidr = "192.168.0.0/24",
                        EnterpriseProjectId = "0"
                    }
                }
            };
            try
            {
                var resp = client.CreateVpc(req);
                Console.WriteLine(resp.Vpc.Id);
                Console.WriteLine(resp.HttpStatusCode);
                foreach (var route in resp.Vpc.Routes)
                {
                    Console.WriteLine(route.Destination);
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

        private static void UpdateVpc(VpcClient client)
        {
            UpdateVpcRequest req = new UpdateVpcRequest
            {
                VpcId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c",
                Body = new UpdateVpcRequestBody
                {
                    Vpc = new UpdateVpcOption
                    {
                        Description = "Updated test vpc"
                    }
                }
            };
            try
            {
                var resp = client.UpdateVpc(req);
                Console.WriteLine(resp.Vpc.Description);
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

        private static void ListVpc(VpcClient client)
        {
            ListVpcsRequest req = new ListVpcsRequest
            {
                Limit = 1,
            };

            try
            {
                ListVpcsResponse resp = client.ListVpcs(req);
                foreach (var vpc in resp.Vpcs)
                {
                    Console.WriteLine(vpc.Id);
                    Console.WriteLine(vpc.Name);
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


        private static void ShowVpc(VpcClient client)
        {
            ShowVpcRequest req = new ShowVpcRequest
            {
                VpcId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowVpc(req);
                Console.WriteLine(resp.Vpc.Id);
                Console.WriteLine(resp.Vpc.Name);
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

        private static void DeleteVpc(VpcClient client)
        {
            var req = new DeleteVpcRequest
            {
                VpcId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeleteVpcResponse resp = client.DeleteVpc(req);
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