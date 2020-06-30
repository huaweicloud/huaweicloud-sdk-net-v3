using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class TagManagement
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
            var iotdaClient = IoTDAClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            getResourcesByTags(iotdaClient);
            bindTagsToResource(iotdaClient);
            unbindTagsToResource(iotdaClient);
        }

        private static void getResourcesByTags(IoTDAClient client)
        {
           ListResourcesByTagsRequest req = new ListResourcesByTagsRequest
            {
                Marker = "ffffffffffffffffffffffff",
                Body = new QueryResourceByTagsDTO()
                {
                    ResourceType = "device",
                    Tags = new List<TagV5DTO>()
                    {
                        new TagV5DTO()
                        {
                            TagKey =  "testTagName",
                            TagValue = "testTagValue"
                        }
                    }
                    
                }
            };
            try
            {
                var resp = client.ListResourcesByTags(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Page);
                foreach (var Resource in resp.Resources)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(Resource));
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
        
        
        private static void bindTagsToResource(IoTDAClient client)
        {
            TagDeviceRequest req = new TagDeviceRequest
            {
                Body = new BindTagsDTO()
                {
                    ResourceId = "5e25d39a3b7c24fa3638804b_nb_0403_1",
                    ResourceType = "device",
                    Tags = new List<TagV5DTO>()
                    {
                        new TagV5DTO()
                        {
                            TagKey =  "testTagName",
                            TagValue = "testTagValue"
                        }
                    }
                }
            };
            try
            {
                var resp = client.TagDevice(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp);
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
        
        
        private static void unbindTagsToResource(IoTDAClient client)
        {
            UntagDeviceRequest req = new UntagDeviceRequest
            {
               Body = new UnbindTagsDTO()
               {
                   ResourceId = "5e25d39a3b7c24fa3638804b_nb_0403_1",
                   ResourceType = "device",
                   TagKeys = new List<string>()
                   {
                       "testTagName"
                   }
               }
            };
            try
            {
                var resp = client.UntagDevice(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp);
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