using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace Examples.VPC.V2
{
    static class Privateip
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

            ListPrivateips(vpcClient);
            ShowPrivateIp(vpcClient);
            ApplyPrivateip(vpcClient);
            DeletePrivateip(vpcClient);
        }

        private static void ApplyPrivateip(VpcClient client)
        {
            var req = new CreatePrivateipRequest()
            {
                Body = new CreatePrivateipRequestBody()
                {
                    Privateips = new List<CreatePrivateipOption>
                    {
                        new CreatePrivateipOption
                        {
                            IpAddress = "192.168.50.2",
                            SubnetId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c"
                        },
                        new CreatePrivateipOption
                        {
                            IpAddress = "192.168.50.10",
                            SubnetId = "c11800b4-9ae2-40fb-b8c6-51242fbb300c"
                        }
                    }
                }
            };
            try
            {
                var resp = client.CreatePrivateip(req);
                foreach (var privateip in resp.Privateips)
                {
                    Console.WriteLine(privateip.Id);
                    Console.WriteLine(privateip.IpAddress);
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

        private static void ListPrivateips(VpcClient client)
        {
            ListPrivateipsRequest req = new ListPrivateipsRequest
            {
                SubnetId = "0fae9377-f51c-430e-ba16-9bdd619b1d97",
                Limit = 1,
            };

            try
            {
                var resp = client.ListPrivateips(req);
                foreach (var privateIp in resp.Privateips)
                {
                    Console.WriteLine(privateIp.Id);
                    Console.WriteLine(privateIp.IpAddress);
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


        private static void ShowPrivateIp(VpcClient client)
        {
            ShowPrivateipRequest req = new ShowPrivateipRequest
            {
                PrivateipId = "58117ec1-4581-4d26-b6db-a4f4e7b50de5"
            };

            try
            {
                var resp = client.ShowPrivateip(req);
                Console.WriteLine(resp.Privateip.Id);
                Console.WriteLine(resp.Privateip.IpAddress);
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

        private static void DeletePrivateip(VpcClient client)
        {
            var req = new DeletePrivateipRequest
            {
                PrivateipId = "efa0d2e2-314f-44f2-99f6-ecfeaab3ba9d"
            };

            try
            {
                DeletePrivateipResponse resp = client.DeletePrivateip(req);
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