using System;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class LifecycleHook
    {
        private static void Main(string[] args)
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

            // lifecycle hook test
            CreateLifeCycleHook(asClient);
            ListLifeCycleHooks(asClient);
            ShowLifeCycleHook(asClient);
            UpdateLifeCycleHook(asClient);
            ListHookInstances(asClient);
            DeleteLifecycleHook(asClient);
        }

        // CreateLifeCycleHook
        private static void CreateLifeCycleHook(AsClient asClient)
        {
            var createLifyCycleHookRequest = new CreateLifyCycleHookRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                Body = new CreateLifeCycleHookRequestBody
                {
                    LifecycleHookName = "test_hook",
                    LifecycleHookType = CreateLifeCycleHookRequestBody.LifecycleHookTypeEnum.INSTANCE_TERMINATING,
                    NotificationTopicUrn = "urn:smn:br-iaas-odin1:0605767fb000d5762ffcc00b78d8b511:TESTAS"
                }
            };
            try
            {
                var createLifeCycleHookResponse = asClient.CreateLifyCycleHook(createLifyCycleHookRequest);
                Console.WriteLine(createLifeCycleHookResponse.GetHttpBody());
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

        // ListLifeCycleHooks
        private static void ListLifeCycleHooks(AsClient asClient)
        {
            var listLifeCycleHooksRequest = new ListLifeCycleHooksRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listLifeCycleHooksResponse = asClient.ListLifeCycleHooks(listLifeCycleHooksRequest);
                Console.WriteLine(listLifeCycleHooksResponse.LifecycleHooks);
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

        // ShowLifeCycleHook
        private static void ShowLifeCycleHook(AsClient asClient)
        {
            var showLifeCycleHookRequest = new ShowLifeCycleHookRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                LifecycleHookName = "test_hook"
            };
            try
            {
                var showLifeCycleHookResponse = asClient.ShowLifeCycleHook(showLifeCycleHookRequest);
                Console.WriteLine(showLifeCycleHookResponse.GetHttpBody());
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

        // UpdateLifeCycleHook
        private static void UpdateLifeCycleHook(AsClient asClient)
        {
            var updateLifeCycleHookRequest = new UpdateLifeCycleHookRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                LifecycleHookName = "test_hook",
                Body = new UpdateLifeCycleHookRequestBody
                {
                    LifecycleHookType = UpdateLifeCycleHookRequestBody.LifecycleHookTypeEnum.INSTANCE_LAUNCHING
                }
            };
            try
            {
                var updateLifeCycleHookResponse = asClient.UpdateLifeCycleHook(updateLifeCycleHookRequest);
                Console.WriteLine(updateLifeCycleHookResponse.GetHttpBody());
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

        // ListHookInstances
        private static void ListHookInstances(AsClient asClient)
        {
            var listHookInstancesRequest = new ListHookInstancesRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listHookInstancesResponse = asClient.ListHookInstances(listHookInstancesRequest);
                Console.WriteLine(listHookInstancesResponse.InstanceHangingInfo);
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

        // DeleteLifeCycleHook
        private static void DeleteLifecycleHook(AsClient asClient)
        {
            var deleteLifecycleHookRequest = new DeleteLifecycleHookRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                LifecycleHookName = "test_hook"
            };
            try
            {
                var deleteLifecycleHookResponse = asClient.DeleteLifecycleHook(deleteLifecycleHookRequest);
                Console.WriteLine(deleteLifecycleHookResponse.HttpStatusCode);
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