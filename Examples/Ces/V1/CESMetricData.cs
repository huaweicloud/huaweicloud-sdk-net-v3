using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Ces.V1;
using HuaweiCloud.SDK.Ces.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCSharpSDK
{
    public class CESMetricData
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
            
            ShowMetricData(cesClient);
            BatchListMetricData(cesClient);
            ShowEventData(cesClient);
            CreateMetricData(cesClient);
        }

        /// <summary>
        /// 查询指定时间范围指定指标的指定粒度的监控数据，可以通过参数指定需要查询的数据维度。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ShowMetricData(CesClient cesClient)
        {
            ShowMetricDataRequest showMetricDataRequest = new ShowMetricDataRequest()
            {
                Namespace = "SYS.ECS",
                MetricName = "cpu_util",
                Dim0 = "instance_id,1639371e-066f-4782-924c-40bd2db3ba07",
                //Dim1 = "",
                //Dim2 = "",
                From = 1587014357000,
                To = 1587017957000,
                Period = 1,
                Filter = ShowMetricDataRequest.FilterEnum.AVERAGE
            };

            try
            {
                ShowMetricDataResponse showMetricDataResponse = cesClient.ShowMetricData(showMetricDataRequest);
                foreach (var datapoint in showMetricDataResponse.Datapoints)
                {
                    Console.WriteLine(datapoint.ToString());
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
        /// 批量查询指定时间范围内指定指标的指定粒度的监控数据，目前最多支持10指标的批量查询。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void BatchListMetricData(CesClient cesClient)
        {
            BatchListMetricDataRequest batchShowMetricDataRequest = new BatchListMetricDataRequest()
            {
                Body = new BatchListMetricDataRequestBody()
                {
                    Metrics = new List<MetricInfo>()
                    {
                        new MetricInfo()
                        {
                            Namespace = "SYS.ECS",
                            Dimensions = new List<MetricsDimension>()
                            {
                                new MetricsDimension()
                                {
                                    Name = "instance_id",
                                    Value = "1639371e-066f-4782-924c-40bd2db3ba07"
                                }
                            },
                            MetricName = "cpu_util"
                        }
                    },
                    From = 1587014357000,
                    To = 1587017957000,
                    Period = "300",
                    Filter = "average"
                }
            };

            try
            {
                BatchListMetricDataResponse batchListMetricDataResponse =
                    cesClient.BatchListMetricData(batchShowMetricDataRequest);
                foreach (var batchMetricData in batchListMetricDataResponse.Metrics)
                {
                    foreach (var datapoint in batchMetricData.Datapoints)
                    {
                        Console.WriteLine(datapoint.ToString());
                    }
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
        /// 查询指定时间范围指定事件类型的主机配置数据，可以通过参数指定需要查询的数据维度。
        /// 注意：该接口提供给HANA场景下SAP Monitor查询主机配置数据，其他场景下查不到主机配置数据。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ShowEventData(CesClient cesClient)
        {
            ShowEventDataRequest showEventDataRequest = new ShowEventDataRequest()
            {
                Namespace = "SYS.ECS",
                Dim0 = "instance_id,22d98f6c-16d2-4c2d-b424-50e79d82838f",
                //Dim1 = "",
                //Dim2 = "",
                Type = "instance_host_info",
                From = 1587014357000,
                To = 1587017957000,
            };

            try
            {
                ShowEventDataResponse showEventDataResponse = cesClient.ShowEventData(showEventDataRequest);
                foreach (var eventDataInfo in showEventDataResponse.Datapoints)
                {
                    Console.WriteLine(eventDataInfo.ToString());
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
        /// 添加一条或多条自定义指标监控数据，解决系统监控指标不能满足具体业务需求的场景。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void CreateMetricData(CesClient cesClient)
        {
            CreateMetricDataRequest createMetricDataRequest = new CreateMetricDataRequest()
            {
                Body = new List<MetricDataItem>()
                {
                    new MetricDataItem()
                    {
                        Metric = new MetricInfo()
                        {
                            Namespace = "AGT.ECS",
                            Dimensions = new List<MetricsDimension>()
                            {
                                new MetricsDimension()
                                {
                                    Name = "instance_id",
                                    Value = "1639371e-066f-4782-924c-40bd2db3ba07"
                                }
                            },
                            MetricName = "mem_usedPercent"
                        },
                        Ttl = 172800,
                        CollectTime = 1587017957000,
                        Type = "float",
                        Value = 10.45,
                        Unit = "%"
                    }
                }
            };

            try
            {
                CreateMetricDataResponse createMetricDataResponse = cesClient.CreateMetricData(createMetricDataRequest);
                Console.WriteLine(createMetricDataResponse.HttpStatusCode);
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