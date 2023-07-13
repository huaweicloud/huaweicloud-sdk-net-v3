using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class Subnet
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

            ListSubnets(vpcClient);
            ShowSubnet(vpcClient);
            CreateSubnet(vpcClient);
            UpdateSubnet(vpcClient);
            DeleteSubnet(vpcClient);
        }

        private static void CreateSubnet(VpcClient client)
        {
            CreateSubnetRequest req = new CreateSubnetRequest
            {
                Body = new CreateSubnetRequestBody
                {
                    Subnet = new CreateSubnetOption
                    {
                        Name = "test-subnet",
                        Description = "Test subnet",
                        Cidr = "192.168.0.0/24",
                        GatewayIp = "192.168.0.1",
                        VpcId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c"
                    }
                }
            };
            try
            {
                var resp = client.CreateSubnet(req);
                Console.WriteLine(resp.Subnet.Id);
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

        private static void UpdateSubnet(VpcClient client)
        {
            UpdateSubnetRequest req = new UpdateSubnetRequest
            {
                VpcId = "0fae9377-f51c-430e-ba16-9bdd619b1d97",
                SubnetId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c",
                Body = new UpdateSubnetRequestBody
                {
                    Subnet = new UpdateSubnetOption
                    {
                        Description = "Updated test subnet"
                    }
                }
            };
            try
            {
                var resp = client.UpdateSubnet(req);
                Console.WriteLine(resp.Subnet.Id);
                Console.WriteLine(resp.Subnet.Status);
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

        private static void ListSubnets(VpcClient client)
        {
            ListSubnetsRequest req = new ListSubnetsRequest
            {
                Limit = 1,
            };

            try
            {
                ListSubnetsResponse resp = client.ListSubnets(req);
                foreach (var subnet in resp.Subnets)
                {
                    Console.WriteLine(subnet.Id);
                    Console.WriteLine(subnet.Name);
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


        private static void ShowSubnet(VpcClient client)
        {
            ShowSubnetRequest req = new ShowSubnetRequest
            {
                SubnetId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowSubnet(req);
                Console.WriteLine(resp.Subnet.Id);
                Console.WriteLine(resp.Subnet.Status);
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

        private static void DeleteSubnet(VpcClient client)
        {
            var req = new DeleteSubnetRequest
            {
                VpcId = "0fae9377-f51c-430e-ba16-9bdd619b1d97",
                SubnetId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeleteSubnetResponse resp = client.DeleteSubnet(req);
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