using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kafka.V2;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace Examples.Kafka.V2
{
    public class TopicMgt
    {
        private const string ak = "{your ak string}";
        private const string sk = "{your sk string}";
        private const string endpoint = "{your endpoint}";
        private const string projectId = "{your project id}";
        private const string instanceId = "{instance id}";
        
        private static void TopicMgtMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var kafkaClient = KafkaClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            //listInstanceTopics(kafkaClient);
            //createInstanceTopic(kafkaClient);
            batchDeleteInstanceTopic(kafkaClient);
        }

        private static void listInstanceTopics(KafkaClient client)
        {
            var req = new ListInstanceTopicsRequest()
            {
                InstanceId = instanceId
            };
            try
            {
                var resp = client.ListInstanceTopics(req);
                Console.WriteLine(resp.GetHttpBody());
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
        
        private static void createInstanceTopic(KafkaClient client)
        {
            var req = new CreateInstanceTopicRequest
            {
                InstanceId = instanceId,
                Body = new CreateInstanceTopicReq
                {
                    Name = "topic-test",
                }
            };
            try
            {
                var resp = client.CreateInstanceTopic(req);
                Console.WriteLine(resp.GetHttpBody());
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
        
        private static void batchDeleteInstanceTopic(KafkaClient client)
        {
            var req = new BatchDeleteInstanceTopicRequest()
            {
                InstanceId = instanceId,
                Body = new BatchDeleteInstanceTopicReq
                {
                    Topics = new List<string>() {"topic-test"},
                }
            };
            try
            {
                var resp = client.BatchDeleteInstanceTopic(req);
                Console.WriteLine(resp.GetHttpBody());
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