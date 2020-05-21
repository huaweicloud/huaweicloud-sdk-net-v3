using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingInstance
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

            //scaling group test
            ListScalingInstances(asClient);
            DeleteScalingInstance(asClient);
            BatchDeleteScalingInstances(asClient);
        }

        // Scaling Instance
        // ListScalingInstances
        private static void ListScalingInstances(AsClient asClient)
        {
            var listScalingInstancesRequest = new ListScalingInstancesRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listScalingInstancesResponse = asClient.ListScalingInstances(listScalingInstancesRequest);
                Console.WriteLine(listScalingInstancesResponse.ScalingGroupInstances);
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

        // deleteScalingInstances
        private static void DeleteScalingInstance(AsClient asClient)
        {
            var deleteScalingInstanceRequest = new DeleteScalingInstanceRequest
            {
                InstanceId = "a38d0579-2e93-461a-9a70-bc84660b215c",
                InstanceDelete = DeleteScalingInstanceRequest.InstanceDeleteEnum.YES
            };
            try
            {
                var deleteScalingInstanceResponse = asClient.DeleteScalingInstance(deleteScalingInstanceRequest);
                Console.WriteLine(deleteScalingInstanceResponse.HttpStatusCode);
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

        // BatchDeleteScalingInstance
        private static void BatchDeleteScalingInstances(AsClient asClient)
        {
            var batchOperateScalingInstancesRequest = new UpdateScalingGroupInstanceRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                Body = new UpdateScalingGroupInstanceRequestBody()
                {
                    InstancesId = new List<string>
                    {
                        "8277a5cb-25c8-4026-98ca-f6fda3fa18ec"
                    },
                    InstanceDelete = "yes",
                    Action = UpdateScalingGroupInstanceRequestBody.ActionEnum.REMOVE
                }
            };
            try
            {
                var batchOperateScalingInstancesResponse =
                    asClient.UpdateScalingGroupInstance(batchOperateScalingInstancesRequest);
                Console.WriteLine(batchOperateScalingInstancesResponse.HttpStatusCode);
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