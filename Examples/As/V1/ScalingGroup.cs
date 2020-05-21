using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingGroup
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
            ShowScalingGroup(asClient);
            ListScalingGroups(asClient);
            CreateScalingGroup(asClient);
            UpdateScalingGroup(asClient);
            ActionScalingGroup(asClient);
            DeleteScalingGroup(asClient);
        }

        // Scaling Group
        // showScalingGroup
        private static void ShowScalingGroup(AsClient asClient)
        {
            var showScalingGroupRequest = new ShowScalingGroupRequest
            {
                ScalingGroupId = "76411642-56e5-47b2-89a5-78578d91a3b2"
            };
            try
            {
                var showScalingGroupResponse = asClient.ShowScalingGroup(showScalingGroupRequest);
                Console.WriteLine(showScalingGroupResponse.ScalingGroup);
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

        // ListScalingGroups
        private static void ListScalingGroups(AsClient asClient)
        {
            var listScalingGroupsRequest = new ListScalingGroupsRequest
            {
                ScalingGroupName = "as-group-x2wd"
            };
            try
            {
                var listScalingGroupsResponse = asClient.ListScalingGroups(listScalingGroupsRequest);
                Console.WriteLine(listScalingGroupsResponse.ScalingGroups);
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

        // CreateScalingGroup
        private static void CreateScalingGroup(AsClient asClient)
        {
            var createScalingGroupRequest = new CreateScalingGroupRequest
            {
                Body = new CreateScalingGroupRequestBody
                {
                    ScalingGroupName = "test",
                    DesireInstanceNumber = 0,
                    MinInstanceNumber = 0,
                    MaxInstanceNumber = 1,
                    AvailableZones = new List<string>
                    {
                        "br-iaas-odin1a"
                    },
                    Networks = new List<Networks>
                    {
                        new Networks
                        {
                            Id = "d26f9090-09ef-4159-9414-db5a84d496ab"
                        }
                    },
                    VpcId = "46ffdfe9-4154-4d68-875d-d52409c03e2b"
                }
            };
            try
            {
                var createScalingGroupsResponse = asClient.CreateScalingGroup(createScalingGroupRequest);
                Console.WriteLine(createScalingGroupsResponse.ScalingGroupId);
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

        //UpdateScalingGroup
        private static void UpdateScalingGroup(AsClient asClient)
        {
            var updateScalingGroupRequest = new UpdateScalingGroupRequest
            {
                ScalingGroupId = "76411642-56e5-47b2-89a5-78578d91a3b2",
                Body = new UpdateScalingGroupRequestBody
                {
                    ScalingGroupName = "test111",
                    DesireInstanceNumber = 0,
                    ScalingConfigurationId = "d62a8ec6-3f97-43f3-82a3-b62141ac3a87"
                }
            };
            try
            {
                var updateScalingGroupsResponse = asClient.UpdateScalingGroup(updateScalingGroupRequest);
                Console.WriteLine(updateScalingGroupsResponse.ScalingGroupId);
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

        //ActionScalingGroup
        private static void ActionScalingGroup(AsClient asClient)
        {
            var enableOrDisableScalingGroupRequest = new EnableOrDisableScalingGroupRequest
            {
                ScalingGroupId = "76411642-56e5-47b2-89a5-78578d91a3b2",
                Body = new EnableOrDisableScalingGroupRequestBody
                {
                    Action = EnableOrDisableScalingGroupRequestBody.ActionEnum.PAUSE
                }
            };
            try
            {
                var actionScalingGroupsResponse = asClient.EnableOrDisableScalingGroup(enableOrDisableScalingGroupRequest);
                Console.WriteLine(actionScalingGroupsResponse);
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

        //DeleteScalingGroup
        private static void DeleteScalingGroup(AsClient asClient)
        {
            var deleteScalingGroupRequest = new DeleteScalingGroupRequest
            {
                ScalingGroupId = "76411642-56e5-47b2-89a5-78578d91a3b2"
            };
            try
            {
                var deleteScalingGroupsResponse = asClient.DeleteScalingGroup(deleteScalingGroupRequest);
                Console.WriteLine(deleteScalingGroupsResponse.HttpStatusCode);
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