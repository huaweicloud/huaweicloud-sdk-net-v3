using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Dms.V2;
using HuaweiCloud.SDK.Dms.V2.Model;

namespace Examples.Dms.V2
{
    public class ConsumeGroup
    {
        private const string ak = "{your ak string}";
        private const string sk = "{your sk string}";
        private const string endpoint = "{your endpoint}";
        private const string projectId = "{your project id}";
        private const string queueId = "{your queue id}";
        
        private static void ConsumeGroupMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var dmsClient = DmsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // CreateConsumerGroup(dmsClient);
            listConsumerGroups(dmsClient);
        }

        private static void CreateConsumerGroup(DmsClient client)
        {
            var groupEntity = new GroupEntity
            {
                Name = "gourp-test",
            };
            var req = new CreateConsumerGroupRequest()
            {
                QueueId = queueId,
                Body = new CreateConsumerGroupReq
                {
                    Groups = new List<GroupEntity>() {groupEntity}
                }
            };
            
            try
            {
                var resp = client.CreateConsumerGroup(req);
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
        
        private static void listConsumerGroups(DmsClient client)
        {
            var req = new ListConsumerGroupsRequest
            {
                QueueId = queueId,
            };
            
            try
            {
                var resp = client.ListConsumerGroups(req);
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