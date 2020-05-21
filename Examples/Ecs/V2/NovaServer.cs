using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class NovaServer
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            //for example endpoint = "https://ecs.XXXXXX.myhuaweicloud.com"
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var ecsClient = EcsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            NovaCreateServers(ecsClient);
            NovaShowServer(ecsClient);
            NovaListServersDetails(ecsClient);
            NovaDeleteServer(ecsClient);
        }

        private static void NovaCreateServers(EcsClient client)
        {
            var req = new NovaCreateServersRequest()
            {
                Body = new NovaCreateServersRequestBody()
                {
                    Server = new NovaCreateServersOption()
                    {
                        ImageRef = "9f9886b8-5b6c-4f78-97b4-24ab2e76a425",
                        FlavorRef = "s2.medium.4",
                        Name = "csharp-sdk-test",
                        AvailabilityZone = "xxxxxx",
                        Networks = new List<NovaServerNetwork>
                        {
                            new NovaServerNetwork
                            {
                                Uuid = "38f3b970-594c-489a-aadc-ac565f1f5b5d",
                            }
                        }
                    }
                }
            };

            try
            {
                var resp = client.NovaCreateServers(req);
                var statusCode = resp.HttpStatusCode;
                var server = resp.Server;
                Console.WriteLine(statusCode);
                Console.WriteLine(server.Id);
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

        private static void NovaShowServer(EcsClient client)
        {
            var req = new NovaShowServerRequest
            {
                ServerId = "2bae7f47-d49f-4d9d-b415-f53e6835bb4b",
                OpenStackAPIVersion = "compute 2.26"
            };

            try
            {
                var resp = client.NovaShowServer(req);
                var respStatusCode = resp.HttpStatusCode;
                var respServer = resp.Server;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(respServer.Id);
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

        private static void NovaListServersDetails(EcsClient client)
        {
            var req = new NovaListServersDetailsRequest
            {
                OpenStackAPIVersion = "compute 2.26"
            };
            try
            {
                var resp = client.NovaListServersDetails(req);
                Console.WriteLine(resp.HttpStatusCode);
                var respServers = resp.Servers;
                foreach (var server in respServers)
                {
                    Console.WriteLine(server.Id);
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

        private static void NovaDeleteServer(EcsClient client)
        {
            var req = new NovaDeleteServerRequest()
            {
                ServerId = "43bf7fb9-01d9-4967-854e-be93d8e28476"
            };

            try
            {
                var resp = client.NovaDeleteServer(req);
                var respStatusCode = resp.HttpStatusCode;
                Console.WriteLine(respStatusCode);
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