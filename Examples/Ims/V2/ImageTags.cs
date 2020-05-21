using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace Examples.Ims.V2
{
    public class ImageTags
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
            var imsClient = ImsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListTags(imsClient);
            CreateOrUpdateTags(imsClient);
            GlanceCreateTag(imsClient);
            GlanceDeleteTag(imsClient);
        }


        //query user image tags
        private static void ListTags(ImsClient imsV1Client)
        {
            ListTagsRequest tenantTagsListRequest = new ListTagsRequest()
            {
                Id = "d70af0f0-515d-41d7-9c9f-bc4e2b233ee6"
            };

            try
            {
                var tenantTagsListResponse = imsV1Client.ListTags(tenantTagsListRequest);
                Console.WriteLine(tenantTagsListResponse.Tags);
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

        //add or update image tags
        private static void CreateOrUpdateTags(ImsClient imsV1Client)
        {
            CreateOrUpdateTagsRequest addOrUpdateTagsRequest = new CreateOrUpdateTagsRequest()
            {
                Body = new AddOrUpdateTagsRequestBody()
                {
                    ImageId = "d70af0f0-515d-41d7-9c9f-bc4e2b233ee6",
                    ImageTag = new ResourceTag()
                    {
                        Key = "test-key",
                        Value = "test-value"
                    }
                }
            };

            try
            {
                var addOrUpdateTagsResponse = imsV1Client.CreateOrUpdateTags(addOrUpdateTagsRequest);
                Console.WriteLine(addOrUpdateTagsResponse.HttpStatusCode);
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

        //add image tag(openstack)
        private static void GlanceCreateTag(ImsClient glanceV2Client)
        {
            var addTagRequest = new GlanceCreateTagRequest()
            {

                ImageId = "951da790-3091-4320-886d-52edca1b5b2c",
                Tag = "aaaa"

            };

            try
            {
                var addTagResponse = glanceV2Client.GlanceCreateTag(addTagRequest);
                Console.WriteLine(addTagResponse.HttpStatusCode);
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

        //delete tag(openstack)
         private static void GlanceDeleteTag(ImsClient glanceV2Client)
             {
                 var deleteTagRequest = new GlanceDeleteTagRequest()
                 {
                     ImageId = "111",
                     Tag = "test"
                 };

                 try
                 {
                    var deleteTagResponse = glanceV2Client.GlanceDeleteTag(deleteTagRequest);
                    Console.WriteLine(deleteTagResponse.HttpStatusCode);
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