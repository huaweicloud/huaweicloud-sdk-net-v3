using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class Port
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

            ListPorts(vpcClient);
            ShowPort(vpcClient);
            CreatePort(vpcClient);
            UpdatePort(vpcClient);
            DeletePort(vpcClient);
        }

        private static void CreatePort(VpcClient client)
        {
            CreatePortRequest req = new CreatePortRequest
            {
                Body = new CreatePortRequestBody
                {
                    Port = new CreatePortOption
                    {
                        Name = "test-port",
                        NetworkId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c"
                    }
                }
            };
            try
            {
                var resp = client.CreatePort(req);
                Console.WriteLine(resp.Port.Id);
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

        private static void UpdatePort(VpcClient client)
        {
            UpdatePortRequest req = new UpdatePortRequest
            {
                PortId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c",
                Body = new UpdatePortRequestBody
                {
                    Port = new UpdatePortOption
                    {
                        Name = "Updated-test-port"
                    }
                }
            };
            try
            {
                var resp = client.UpdatePort(req);
                Console.WriteLine(resp.Port.Name);
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

        private static void ListPorts(VpcClient client)
        {
            ListPortsRequest req = new ListPortsRequest
            {
                Limit = 1,
            };

            try
            {
                ListPortsResponse resp = client.ListPorts(req);
                foreach (var port in resp.Ports)
                {
                    Console.WriteLine(port.Id);
                    Console.WriteLine(port.Name);
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


        private static void ShowPort(VpcClient client)
        {
            ShowPortRequest req = new ShowPortRequest
            {
                PortId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowPort(req);
                Console.WriteLine(resp.Port.Id);
                Console.WriteLine(resp.Port.Name);
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

        private static void DeletePort(VpcClient client)
        {
            var req = new DeletePortRequest
            {
                PortId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeletePortResponse resp = client.DeletePort(req);
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