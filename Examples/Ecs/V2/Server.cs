using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    static class Server
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

            CreatePostPaidServers(ecsClient);
            ShowServer(ecsClient);
            ListServersDetails(ecsClient);
            UpdateServer(ecsClient);
            ResizePostPaidServer(ecsClient);
            DeleteServers(ecsClient);
            BatchStopServers(ecsClient);
            BatchStartServers(ecsClient);
            BatchRebootServers(ecsClient);
        }

        private static void CreatePostPaidServers(EcsClient client)
        {
            var req = new CreatePostPaidServersRequest
            {
                Body = new CreatePostPaidServersRequestBody
                {
                    Server = new PostPaidServer
                    {
                        ImageRef = "700d66bc-62e3-4ebd-a07c-2a9b5caaf792",
                        FlavorRef = "s2.small.1",
                        AvailabilityZone = "br-iaas-odin1a",
                        Name = "net-sdk-test",
                        Vpcid = "175cbaaa-cfc7-4f4b-8b58-3878cfd9a8d9",
                        Nics = new List<PostPaidServerNic>
                        {
                            new PostPaidServerNic
                            {
                                SubnetId = "38f3b970-594c-489a-aadc-ac565f1f5b5d",
                            }
                        },
                        RootVolume = new PostPaidServerRootVolume
                        {
                            Volumetype = PostPaidServerRootVolume.VolumetypeEnum.SATA
                        }
                    }
                }
            };
            try
            {
                var resp = client.CreatePostPaidServers(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void ShowServer(EcsClient client)
        {
            var req = new ShowServerRequest
            {
                ServerId = "ed5e2af6-c539-42ee-b3dd-3048f140499c"
            };

            try
            {
                var resp = client.ShowServer(req);
                var respStatusCode = resp.HttpStatusCode;
                var server = resp.Server;
                Console.WriteLine(respStatusCode);
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

        private static void UpdateServer(EcsClient client)
        {
            var req = new UpdateServerRequest
            {
                ServerId = "0bfacb9f-148a-4e39-8f6f-095a0600f141",
                Body = new UpdateServerRequestBody
                {
                    Server = new UpdateServerOption
                    {
                        Name = "net_sdk-test-update",
                        Hostname = "net.sdk.test.update.hostname",
                        Description = "net-sdk test"
                    }
                }
            };
            try
            {
                var resp = client.UpdateServer(req);
                var respStatusCode = resp.HttpStatusCode;
                var server = resp.Server;
                Console.WriteLine(respStatusCode);
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

        private static void ResizePostPaidServer(EcsClient client)
        {
            var req = new ResizePostPaidServerRequest
            {
                ServerId = "0bfacb9f-148a-4e39-8f6f-095a0600f141",
                Body = new ResizePostPaidServerRequestBody
                {
                    Resize = new ResizePostPaidServerOption
                    {
                        FlavorRef = "s2.medium.4",
                        Mode = "withStopServer"
                    }
                }
            };
            try
            {
                var resp = client.ResizePostPaidServer(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void DeleteServers(EcsClient client)
        {
            var req = new DeleteServersRequest
            {
                Body = new DeleteServersRequestBody
                {
                    Servers = new List<ServerId>
                    {
                        new ServerId
                        {
                            Id = "ed5e2af6-c539-42ee-b3dd-3048f140499c"
                        }
                    }
                }
            };
            try
            {
                var resp = client.DeleteServers(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void ListServersDetails(EcsClient client)
        {
            var req = new ListServersDetailsRequest
            {
                Offset = 1
            };
            try
            {
                var resp = client.ListServersDetails(req);
                var respStatusCode = resp.HttpStatusCode;
                var servers = resp.Servers;
                Console.WriteLine(respStatusCode);
                foreach (var server in servers)
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

        private static void BatchStartServers(EcsClient client)
        {
            var req = new BatchStartServersRequest
            {
                Body = new BatchStartServersRequestBody
                {
                    OsStart = new BatchStartServersOption
                    {
                        Servers = new List<ServerId>
                        {
                            new ServerId
                            {
                                Id = "f0a34dd7-a103-400b-a448-9baad3077af2"
                            }
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchStartServers(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void BatchStopServers(EcsClient client)
        {
            var req = new BatchStopServersRequest
            {
                Body = new BatchStopServersRequestBody
                {
                    OsStop = new BatchStopServersOption
                    {
                        Type = BatchStopServersOption.TypeEnum.SOFT,
                        Servers = new List<ServerId>
                        {
                            new ServerId
                            {
                                Id = "f0a34dd7-a103-400b-a448-9baad3077af2"
                            }
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchStopServers(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void BatchRebootServers(EcsClient client)
        {
            var req = new BatchRebootServersRequest
            {
                Body = new BatchRebootServersRequestBody
                {
                    Reboot = new BatchRebootSeversOption
                    {
                        Type = BatchRebootSeversOption.TypeEnum.SOFT,
                        Servers = new List<ServerId>
                        {
                            new ServerId
                            {
                                Id = "f0a34dd7-a103-400b-a448-9baad3077af2"
                            }
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchRebootServers(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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