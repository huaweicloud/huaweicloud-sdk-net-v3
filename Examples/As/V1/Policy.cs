using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class Policy
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

            //scaling policy v1 test
            ActionScalingPolicy(asClient);
            DeleteScalingPolicy(asClient);
            CreateScalingPolicy(asClient);
            ShowScalingPolicy(asClient);
            ListScalingPolicies(asClient);
            UpdateScalingPolicy(asClient);
        }

        // Scaling Policy V1
        // actionScalingPolicy
        private static void ActionScalingPolicy(AsClient asClient)
        {
            var operateScalingPolicyRequest = new ExecuteScalingPolicyRequest
            {
                ScalingPolicyId = "0d930a61-3c83-43c9-a820-8686d0d4d42d",
                Body = new ExecuteScalingPolicyRequestBody
                {
                    Action = ExecuteScalingPolicyRequestBody.ActionEnum.PAUSE
                }
            };
            try
            {
                var actionScalingPolicyResponse = asClient.ExecuteScalingPolicy(operateScalingPolicyRequest);
                Console.WriteLine(actionScalingPolicyResponse.HttpStatusCode);
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

        // DeleteScalingPolicy
        private static void DeleteScalingPolicy(AsClient asClient)
        {
            var deleteScalingPolicyRequest = new DeleteScalingPolicyRequest
            {
                ScalingPolicyId = "2e216c3a-406e-4c35-bc41-237664357932"
            };
            try
            {
                var deleteScalingPolicyResponse = asClient.DeleteScalingPolicy(deleteScalingPolicyRequest);
                Console.WriteLine(deleteScalingPolicyResponse.HttpStatusCode);
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

        // Scaling Policy V1
         // createScalingPolicyV1
         private static void CreateScalingPolicy(AsClient asClient)
         {
             var createScalingPolicyRequest = new CreateScalingPolicyRequest()
             {
                 Body = new CreateScalingPolicyRequestBody
                 {
                     ScalingPolicyName = "test_policy",
                     ScalingGroupId = "fa07d522-6794-4c1c-98be-c1c2c4d43fbe",
                     ScalingPolicyType = CreateScalingPolicyRequestBody.ScalingPolicyTypeEnum.ALARM,
                     AlarmId = "al1584674706316rxR3Rjz7x",
                     ScalingPolicyAction = new ScalingPolicyAction()
                     {
                         Operation = ScalingPolicyAction.OperationEnum.ADD,
                         InstanceNumber = 1
                     }
                 }
             };
             try
             {
                 var createScalingPolicyResponse = asClient.CreateScalingPolicy(createScalingPolicyRequest);
                 Console.WriteLine(createScalingPolicyResponse.ScalingPolicyId);
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
         // showScalingPolicyV1
         private static void ShowScalingPolicy(AsClient asClient)
         {
             var showScalingPolicyRequest = new ShowScalingPolicyRequest()
             {
                 ScalingPolicyId = "0d930a61-3c83-43c9-a820-8686d0d4d42d",
             };
             try
             {
                 var showScalingPolicyResponse = asClient.ShowScalingPolicy(showScalingPolicyRequest);
                 Console.WriteLine(showScalingPolicyResponse.ScalingPolicy);
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
         // ListScalingPoliciesV1
         private static void ListScalingPolicies(AsClient asClient)
         {
             var listScalingPoliciesRequest = new ListScalingPoliciesRequest()
             {
                 ScalingGroupId = "fa07d522-6794-4c1c-98be-c1c2c4d43fbe"
             };
             try
             {
                 var listScalingPoliciesResponse = asClient.ListScalingPolicies(listScalingPoliciesRequest);
                 Console.WriteLine(listScalingPoliciesResponse.ScalingPolicies);
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
         // updateScalingPolicyV1
         private static void UpdateScalingPolicy(AsClient asClient)
         {
             var updateScalingPolicyRequest = new UpdateScalingPolicyRequest()
             {
                 ScalingPolicyId = "0d930a61-3c83-43c9-a820-8686d0d4d42d",
                 Body = new UpdateScalingPolicyRequestBody
                 {
                     ScalingPolicyName = "test_policyss",
                 }
             };
             try
             {
                 var updateScalingPolicyResponse = asClient.UpdateScalingPolicy(updateScalingPolicyRequest);
                 Console.WriteLine(updateScalingPolicyResponse.ScalingPolicyId);
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