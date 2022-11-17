using System;
using System.Collections;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class BatchTask
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

            createBatchTask(iotdaClient);
            queryBatchTask(iotdaClient);
            queryBatchTasks(iotdaClient);
        }

        private static void createBatchTask(IoTDAClient client)
        {
            CreateBatchTaskRequest req = new CreateBatchTaskRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                Body = new CreateBatchTask()
                {
                   Document = new Hashtable()
                   {
                       {"package_id","24381244be486f8b3a89ad07"}
                   },
                   Targets = new List<String>()
                   {
                       "5e19ca2b16b09003ca4dbd98_ggghg"
                   },
                   TaskName = "BatchCommandTask_test1",
                   TaskType = "softwareUpgrade",
                   AppId = "vWT2abBX135ioL_D028b7NRYJfYa"
                }
            };
            try
            {
                var resp = client.CreateBatchTask(req);
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
        
        
        private static void queryBatchTask(IoTDAClient client)
        {
            ShowBatchTaskRequest req = new ShowBatchTaskRequest
            {
                TaskId = "5ea7eb66251c3e02075b1525",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowBatchTask(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp.Batchtask));
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
        
        
        private static void queryBatchTasks(IoTDAClient client)
        {
            ListBatchTasksRequest req = new ListBatchTasksRequest
            {
                TaskType = "softwareUpgrade",
                Marker = "ffffffffffffffffffffffff",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ListBatchTasks(req);
                Console.WriteLine(resp.HttpStatusCode);
                foreach (var task in resp.Batchtasks)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(task));
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