using System;
using HuaweiCloud.SDK.Ces.V1;
using HuaweiCloud.SDK.Ces.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCSharpSDK
{
    public class CESMetrics
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

            ListMetrics(cesClient);
        }

        /// <summary>
        /// 查询系统当前可监控指标列表，可以指定指标命名空间、指标名称、维度、排序方式，起始记录和最大记录条数过滤查询结果。
        /// </summary>
        /// <param name="cesV1Client"></param>
        private static void ListMetrics(CesClient cesClient)
        {
            ListMetricsRequest listMetricsRequest = new ListMetricsRequest()
            {
                MetricName = "cpu_util",
                Namespace = "SYS.ECS",
                // Dim0 = "",
                // Dim1 = "",
                // Dim2 = "",
                // Start = "",
                Limit = 100,
                Order = ListMetricsRequest.OrderEnum.ASC
            };

            try
            {
                ListMetricsResponse metricList = cesClient.ListMetrics(listMetricsRequest);
                foreach (var metric in metricList.Metrics)
                {
                    Console.WriteLine(metric.ToString());
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
    }
}