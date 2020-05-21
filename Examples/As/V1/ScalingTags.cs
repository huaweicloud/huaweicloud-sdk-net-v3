using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingTags
    {
        private static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var asClient = AsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // tags test
            ListScalingTagInfosByTenantId(asClient);
            ListScalingTagInfosByResourceId(asClient);
            OperateScalingTagInfo(asClient);
            ListResourceInstances(asClient);
        }

        // Tags
        // queryTagsByTenantId
        private static void ListScalingTagInfosByTenantId(AsClient asClient)
        {
            var listScalingTagInfosByTenantIdRequest = new ListScalingTagInfosByTenantIdRequest
            {
                ResourceType = ListScalingTagInfosByTenantIdRequest.ResourceTypeEnum.SCALING_GROUP_TAG
            };
            try
            {
                var listScalingTagInfosByTenantIdResponse =
                    asClient.ListScalingTagInfosByTenantId(listScalingTagInfosByTenantIdRequest);
                Console.WriteLine(listScalingTagInfosByTenantIdResponse.Tags);
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

        // queryTagsByResourceId
        private static void ListScalingTagInfosByResourceId(AsClient asClient)
        {
            var listScalingTagInfosByResourceIdRequest = new ListScalingTagInfosByResourceIdRequest
            {
                ResourceType = ListScalingTagInfosByResourceIdRequest.ResourceTypeEnum.SCALING_GROUP_TAG,
                ResourceId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listScalingTagInfosByResourceIdResponse =
                    asClient.ListScalingTagInfosByResourceId(listScalingTagInfosByResourceIdRequest);
                Console.WriteLine(listScalingTagInfosByResourceIdResponse.GetHttpBody());
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

        // operateTags
        private static void OperateScalingTagInfo(AsClient asClient)
        {
            var operateScalingTagInfoRequest = new CreateScalingTagsRequest
            {
                ResourceType = CreateScalingTagsRequest.ResourceTypeEnum.SCALING_GROUP_TAG,
                ResourceId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                Body = new CreateScalingTagsRequestBody
                {
                    Action = CreateScalingTagsRequestBody.ActionEnum.CREATE,
                    Tags = new List<TagsSingleValue>
                    {
                        new TagsSingleValue
                        {
                            Key = "key",
                            Value = "value"
                        }
                    }
                }
            };
            try
            {
                var operateScalingTagInfoResponse = asClient.CreateScalingTags(operateScalingTagInfoRequest);
                Console.WriteLine(operateScalingTagInfoResponse.HttpStatusCode);
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

        // ListResourceInstances
        private static void ListResourceInstances(AsClient asClient)
        {
            var listResourceInstancesRequest = new ListResourceInstancesRequest
            {
                ResourceType = ListResourceInstancesRequest.ResourceTypeEnum.SCALING_GROUP_TAG,
                Body = new ShowTagsRequestBody
                {
                    Action = ShowTagsRequestBody.ActionEnum.FILTER,
                    Tags = new List<TagsMultiValue>
                    {
                        new TagsMultiValue
                        {
                            Key = "key",
                            Values = new List<string>
                            {
                                "value"
                            }
                        }
                    }
                }
            };
            try
            {
                var listResourceInstancesResponse = asClient.ListResourceInstances(listResourceInstancesRequest);
                Console.WriteLine(listResourceInstancesResponse.Resources);
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