using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Ces.V1;
using HuaweiCloud.SDK.Ces.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCSharpSDK
{
    public class CESAlarm
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
            var cesClient = CesClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();
            
            ListAlarms(cesClient);
            ShowAlarmByID(cesClient);
            UpdateAlarmAction(cesClient);
            DeleteAlarm(cesClient);
            CreateAlarm(cesClient);
        }

        /// <summary>
        /// 查询告警规则列表，可以指定分页条件限制结果数量，可以指定排序规则。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ListAlarms(CesClient cesClient)
        {
            ListAlarmsRequest listAlarmRequest = new ListAlarmsRequest()
            {
                //Start = "",
                Limit = 100,
                Order = "asc"
            };

            try
            {
                ListAlarmsResponse listAlarmsResponse = cesClient.ListAlarms(listAlarmRequest);
                foreach (var metricAlarm in listAlarmsResponse.MetricAlarms)
                {
                    Console.WriteLine("alarm_id: {0}, alarm_name: {1}", metricAlarm.AlarmId, metricAlarm.AlarmName);
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

        /// <summary>
        /// 根据告警ID查询告警规则信息。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ShowAlarmByID(CesClient cesClient)
        {
            ShowAlarmRequest showAlarmRequest = new ShowAlarmRequest()
            {
                AlarmId = "al1587000139213PNj4Pw2dZ"
            };

            try
            {
                ShowAlarmResponse showAlarmResponse = cesClient.ShowAlarm(showAlarmRequest);
                foreach (var metricAlarm in showAlarmResponse.MetricAlarms)
                {
                    Console.WriteLine("alarm_id: {0}, alarm_name: {1}", metricAlarm.AlarmId, metricAlarm.AlarmName);
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

        /// <summary>
        /// 启动或停止一条告警规则。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void UpdateAlarmAction(CesClient cesClient)
        {
            UpdateAlarmActionRequest updateAlarmActionRequest = new UpdateAlarmActionRequest()
            {
                AlarmId = "al1587007900469Eylrzy8GW",
                Body = new ModifyAlarmActionReq()
                {
                    AlarmEnabled = false
                }
            };

            try
            {
                UpdateAlarmActionResponse updateAlarmActionResponse =
                    cesClient.UpdateAlarmAction(updateAlarmActionRequest);
                Console.WriteLine(updateAlarmActionResponse.HttpStatusCode);
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

        /// <summary>
        /// 删除一条告警规则。
        /// </summary>
        /// <param name="cesClient"></param>
        private static void DeleteAlarm(CesClient cesClient)
        {
            DeleteAlarmRequest deleteAlarmRequest = new DeleteAlarmRequest()
            {
                AlarmId = "al1587007900469Eylrzy8GW"
            };

            try
            {
                DeleteAlarmResponse deleteAlarmResponse = cesClient.DeleteAlarm(deleteAlarmRequest);
                Console.WriteLine(deleteAlarmResponse.HttpStatusCode);
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

        /// <summary>
        /// 创建一条告警规则。
        /// </summary>
        /// <param name="cesClient"></param>
        private static void CreateAlarm(CesClient cesClient)
        {
            CreateAlarmRequest createAlarmRequest = new CreateAlarmRequest()
            {
                Body = new CreateAlarmRequestBody()
                {
                    AlarmName = "ces-sdk-02",
                    AlarmDescription = "create ECS alram",
                    Metric = new MetricInfoExt()
                    {
                        Namespace = "AGT.ECS",
                        Dimensions = new List<MetricsDimension>()
                        {
                            new MetricsDimension()
                            {
                                Name = "instance_id",
                                Value = "326277f5-ee01-4751-959e-8e9a364b6b3c"
                            }
                        },
                        MetricName = "cpu_usage_idle"
                    },
                    Condition = new Condition()
                    {
                        Period = 1,
                        Filter = "average",
                        ComparisonOperator = "<",
                        Value = 20,
                        Unit = "%",
                        Count = 3
                    },
                    AlarmEnabled = true,
                    AlarmActionEnabled = true,
                    AlarmLevel = 2,
                    AlarmActions = new List<AlarmActions>()
                    {
                        new AlarmActions()
                        {
                            Type = "notification",
                            NotificationList = new List<string>()
                            {
                                "urn:smn:br-iaas-odin1:0605767fc300d5762ffdc01c5bba0cce:ces_test"
                            }
                        }
                    },
                    OkActions = new List<AlarmActions>()
                    {
                        new AlarmActions()
                        {
                            Type = "notification",
                            NotificationList = new List<string>()
                            {
                                "urn:smn:br-iaas-odin1:0605767fc300d5762ffdc01c5bba0cce:ces_test"
                            }
                        }
                    },
                    InsufficientdataActions = new List<AlarmActions>()
                    {
                        new AlarmActions()
                        {
                            Type = "notification",
                            NotificationList = new List<string>()
                            {
                                "urn:smn:br-iaas-odin1:0605767fc300d5762ffdc01c5bba0cce:ces_test"
                            }
                        }
                    }
                }
            };

            try
            {
                CreateAlarmResponse createAlarmResponse = cesClient.CreateAlarm(createAlarmRequest);
                Console.WriteLine("alarm_id: {0}", createAlarmResponse.AlarmId);
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