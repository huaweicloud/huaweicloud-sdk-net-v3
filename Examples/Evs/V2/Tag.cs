using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Evs.V2.Model;
using HuaweiCloud.SDK.Evs.V2;

namespace Examples.Evs.V2
{
    public class Tag
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var evsClient = EvsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            BatchCreateVolumeTags(evsClient);
            BatchDeleteVolumeTags(evsClient);
            ListVolumeTags(evsClient);
            ShowVolumeTags(evsClient);
            ListVolumesByTags(evsClient);
        }

        private static void BatchCreateVolumeTags(EvsClient client)
        {
            var req = new BatchCreateVolumeTagsRequest()
            {
                VolumeId = "04495fb2-f1e8-40aa-8725-c197a246376d",
                Body = new BatchCreateVolumeTagsRequestBody()
                {
                    Action = BatchCreateVolumeTagsRequestBody.ActionEnum.CREATE,
                    Tags = new List<HuaweiCloud.SDK.Evs.V2.Model.Tag>
                    {
                        new HuaweiCloud.SDK.Evs.V2.Model.Tag()
                        {
                            Key = "123",
                            Value = "456"
                        }
                    }
                }
            };

            try
            {
                var resp = client.BatchCreateVolumeTags(req);
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

        private static void BatchDeleteVolumeTags(EvsClient client)
        {
            var req = new BatchDeleteVolumeTagsRequest()
            {
                VolumeId = "04495fb2-f1e8-40aa-8725-c197a246376d",
                Body = new BatchDeleteVolumeTagsRequestBody()
                {
                    Action = BatchDeleteVolumeTagsRequestBody.ActionEnum.DELETE,
                    Tags = new List<DeleteTagsOption>()
                    {
                        new DeleteTagsOption()
                        {
                            Key = "123"
                        }
                    }
                }
            };

            try
            {
                var resp = client.BatchDeleteVolumeTags(req);
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

        private static void ListVolumeTags(EvsClient client)
        {
            var req = new ListVolumeTagsRequest();

            try
            {
                var resp = client.ListVolumeTags(req);
                Console.WriteLine(resp.Tags);
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

        private static void ShowVolumeTags(EvsClient client)
        {
            var req = new ShowVolumeTagsRequest()
            {
                VolumeId = "04495fb2-f1e8-40aa-8725-c197a246376d"
            };

            try
            {
                var resp = client.ShowVolumeTags(req);
                Console.WriteLine(resp.Tags);
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

        private static void ListVolumesByTags(EvsClient client)
        {
            ListVolumesByTagsRequest req = new ListVolumesByTagsRequest()
            {
                Body = new ListVolumesByTagsRequestBody()
                {
                    Action = ListVolumesByTagsRequestBody.ActionEnum.FILTER,
                    Limit = 10,
                    Offset = 0,
                    Tags = new List<TagsForListVolumes>
                    {
                        new TagsForListVolumes
                        {
                            Key = "123",
                            Values = new List<string>() {"456"}
                        }
                    }
                }
            };

            try
            {
                ListVolumesByTagsResponse resp = client.ListVolumesByTags(req);
                Console.WriteLine(resp.TotalCount);
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