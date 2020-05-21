using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class Tag
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

            BatchCreateServerTags(ecsClient);
            ShowServerTags(ecsClient);
            BatchDeleteServerTags(ecsClient);
        }

        private static void BatchCreateServerTags(EcsClient client)
        {
            var req = new BatchCreateServerTagsRequest()
            {
                ServerId = "f0a34dd7-a103-400b-a448-9baad3077af2",
                Body = new BatchCreateServerTagsRequestBody
                {
                    Action = BatchCreateServerTagsRequestBody.ActionEnum.CREATE,
                    Tags = new List<ServerTag>
                    {
                        new ServerTag
                        {
                            Key = "key-5",
                            Value = "value-5"
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchCreateServerTags(req);
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

        private static void ShowServerTags(EcsClient client)
        {
            var req = new ShowServerTagsRequest()
            {
                ServerId = "f0a34dd7-a103-400b-a448-9baad3077af2"
            };
            try
            {
                var resp = client.ShowServerTags(req);
                var respStatusCode = resp.HttpStatusCode;
                var tags = resp.Tags;
                Console.WriteLine(respStatusCode);
                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Key);
                    Console.WriteLine(tag.Value);
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

        private static void BatchDeleteServerTags(EcsClient client)
        {
            var req = new BatchDeleteServerTagsRequest()
            {
                ServerId = "f0a34dd7-a103-400b-a448-9baad3077af2",
                Body = new BatchDeleteServerTagsRequestBody
                {
                    Action = BatchDeleteServerTagsRequestBody.ActionEnum.DELETE,
                    Tags = new List<ServerTag>
                    {
                        new ServerTag
                        {
                            Key = "key-5",
                            Value = "value-5"
                        },
                        new ServerTag
                        {
                            Key = "csharp-sdk-test-key1",
                            Value = "csharp-sdk-test-value1"
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchDeleteServerTags(req);
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