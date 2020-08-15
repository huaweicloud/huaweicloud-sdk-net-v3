using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class TagsFunction
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

            var kmsClient = KmsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();
            
            CreateTag(kmsClient);
            DeleteTag(kmsClient);
            BatchCreateTags(kmsClient);
            BatchDeleteTags(kmsClient);
            GetKeyTag(kmsClient);
            GetProjectTags(kmsClient);
            GetResourceInstance(kmsClient);
            
        }

        private static void CreateTag(KmsClient kmsClient)
        {
            var tagItem = new TagItem();
            tagItem.Key = "key";
            tagItem.Value = "value";
            try
            {
                var req = new CreateKmsTagRequest
                {
                    VersionId = "v1.0",
                    KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                    Body = new CreateKmsTagRequestBody
                    {
                        Tag = tagItem
                    }
                };
                var resp = kmsClient.CreateKmsTag(req);
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
        
        private static void DeleteTag(KmsClient kmsClient)
        {
            try
            {
                var req = new DeleteTagRequest
                {
                    VersionId = "v1.0",
                    KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                    Key = "key"

                };
                var resp = kmsClient.DeleteTag(req);
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
        
        private static void BatchCreateTags(KmsClient kmsClient)
        {
            var tagItems = new List<TagItem>();
            var tagItem1 = new TagItem();
            tagItem1.Key = "key1";
            tagItem1.Value = "value1";
            var tagItem2 = new TagItem();
            tagItem2.Key = "key2";
            tagItem2.Value = "value2";
            tagItems.Add(tagItem1);
            tagItems.Add(tagItem2);
            try
            {
                var req = new BatchCreateKmsTagsRequest
                {
                    VersionId = "v1.0",
                    KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                    Body = new BatchCreateKmsTagsRequestBody
                    {
                        Action = "create",
                        Tags = tagItems
                    }

                };
                var resp = kmsClient.BatchCreateKmsTags(req);
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
        
        private static void BatchDeleteTags(KmsClient kmsClient)
        {
            var tagItems = new List<TagItem>();
            var tagItem1 = new TagItem();
            tagItem1.Key = "key1";
            tagItem1.Value = "value1";
            var tagItem2 = new TagItem();
            tagItem2.Key = "key2";
            tagItem2.Value = "value2";
            tagItems.Add(tagItem1);
            tagItems.Add(tagItem2);
            try
            {
                var req = new BatchCreateKmsTagsRequest
                {
                    VersionId = "v1.0",
                    KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2"),
                    Body = new BatchCreateKmsTagsRequestBody
                    {
                        Action = "delete",
                        Tags = tagItems
                    }

                };
                var resp = kmsClient.BatchCreateKmsTags(req);
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
        
        private static void GetKeyTag(KmsClient kmsClient)
        {
            try
            {
                var req = new ShowKmsTagsRequest
                {
                    VersionId = "v1.0",
                    KeyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "2")

                };
                var resp = kmsClient.ShowKmsTags(req);
                Console.WriteLine(resp.ToString());
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
        
        private static void GetProjectTags(KmsClient kmsClient)
        {
            try
            {
                var req = new ListKmsTagsRequest
                {
                    VersionId = "v1.0"
                };
                var resp = kmsClient.ListKmsTags(req);
                foreach (var tag in resp.Tags)
                {
                    Console.Write("key: " + tag.Key + " ");
                    Console.Write("value: ");
                    foreach (var value in tag.Values)
                    {
                        Console.Write(" " + value + " ");
                    }
                    Console.WriteLine();
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
        
        private static void GetResourceInstance(KmsClient kmsClient)
        {
            try
            {
                var req = new ListKmsByTagsRequest
                {
                    VersionId = "v1.0",
                    ResourceInstances = "resource_instances",
                    Body = new ListKmsByTagsRequestBody
                    {
                        Action = "filter"
                    }
                };
                var resp = kmsClient.ListKmsByTags(req);
                foreach (var resource in resp.Resources)
                {
                    Console.WriteLine(resource.ResourceId);
                    Console.WriteLine(resource.ResourceName);
                    Console.WriteLine(resource.ResourceDetail.ToString());
                    Console.WriteLine(resource.Tags);
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
    }
}