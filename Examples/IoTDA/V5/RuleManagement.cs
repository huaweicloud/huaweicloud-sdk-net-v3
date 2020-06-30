using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Examples.IoTDA.V5
{
    static class RuleManagement
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

            getRuleById(iotdaClient);
            findRule(iotdaClient);
            createRule(iotdaClient);
            updateRule(iotdaClient);
            deleteRule(iotdaClient);
            changeRuleStatus(iotdaClient);
        }

        private static void findRule(IoTDAClient client)
        {
            ListRulesRequest req = new ListRulesRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ListRules(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Count);
                Console.WriteLine(resp.Marker);
                foreach (var rule in resp.Rules)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(rule));
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
        
        
        private static void getRuleById(IoTDAClient client)
        {
            ShowRuleRequest req = new ShowRuleRequest
            {
                RuleId = "5ea8ebe75d6efc01e5a022c8",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowRule(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp));
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
        
        
        private static void createRule(IoTDAClient client)
        {
            CreateRuleRequest req = new CreateRuleRequest
            {
               Body = new Rule()
               {
                   Actions = new List<RuleAction>()
                   {
                       new RuleAction()
                       {
                           Type = "IoTA_FORWARDING",
                           Addition = new List<string>()
                           {
                               "88cce89f943646cfbda057aed55c4841"
                           },
                           IotaForwarding = new ActionIoTAForwarding()
                           {
                               ProjectId = "88cce89f943646cfbda057aed55c4841",
                               RegionName = "cn-north-7"
                           }
                       }
                   },
                   ConditionGroup = new ConditionGroup()
                   {
                       Conditions = new List<RuleCondition>()
                       {
                           new RuleCondition()
                           {
                               DevicePropertyCondition = new DeviceDataCondition()
                               {
                                   Filters = new List<PropertyFilter>()
                                   {
                                       new PropertyFilter()
                                       {
                                           Operator = ">",
                                           Path = "Meter/signalStrength",
                                           Value = "0"
                                       }
                                   }
                               },
                               Type = "DEVICE_DATA"
                           }
                       },
                       TimeRange = new TimeRange()
                       {
                           EndTime = "12:02",
                           StartTime = "12:00"
                       }
                   },
                   Name = "test_createRule_Success",
                   RuleType = "DATA_FORWARDING",
                   Status = "inactive"
               }
            };
            try
            {
                var resp = client.CreateRule(req);
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
        
        private static void updateRule(IoTDAClient client)
        {
            UpdateRuleRequest req = new UpdateRuleRequest
            {
                RuleId = "5ea8ebe75d6efc01e5a022c8",
                Body = new Rule()
               {
                   Actions = new List<RuleAction>()
                   {
                       new RuleAction()
                       {
                           Type = "IoTA_FORWARDING",
                           Addition = new List<string>()
                           {
                               "88cce89f943646cfbda057aed55c4841"
                           },
                           IotaForwarding = new ActionIoTAForwarding()
                           {
                               ProjectId = "88cce89f943646cfbda057aed55c4841",
                               RegionName = "update"
                           },
                       }
                   },
                   ConditionGroup = new ConditionGroup()
                   {
                       Conditions = new List<RuleCondition>()
                       {
                           new RuleCondition()
                           {
                               DevicePropertyCondition = new DeviceDataCondition()
                               {
                                   Filters = new List<PropertyFilter>()
                                   {
                                       new PropertyFilter()
                                       {
                                           Operator = ">",
                                           Path = "Meter/signalStrength",
                                           Value = "0"
                                       }
                                   }
                               },
                               Type = "DEVICE_DATA"
                           }
                       },
                       TimeRange = new TimeRange()
                       {
                           EndTime = "12:02",
                           StartTime = "12:00"
                       }
                   },
                   Name = "test_createRule_Success",
                   RuleType = "DATA_FORWARDING",
                   Status = "inactive"
               }
                
            };
            try
            {
                var resp = client.UpdateRule(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp));
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
        
        
        private static void deleteRule(IoTDAClient client)
        {
            DeleteRuleRequest req = new DeleteRuleRequest
            {
                RuleId = "5ea8ebe75d6efc01e5a022c8",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteRule(req);
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
        
        private static void changeRuleStatus(IoTDAClient client)
        {
            ChangeRuleStatusRequest req = new ChangeRuleStatusRequest
            {
                Body =new RuleStatus()
                {
                    Status = "active"
                },
                RuleId= "5ea8ebe75d6efc01e5a022c8",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ChangeRuleStatus(req);
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