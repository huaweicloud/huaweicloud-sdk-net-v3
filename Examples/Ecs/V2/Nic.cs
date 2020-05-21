using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class Nic
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            //for example endpoint = "https://ecs.XXXXXX.myhuaweicloud.com"
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var ecsClient = EcsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            BatchAddServerNics(ecsClient);
            BatchDeleteServerNics(ecsClient);
        }

        private static void BatchAddServerNics(EcsClient client)
        {
            var req = new BatchAddServerNicsRequest
            {
                ServerId = "5d78e6e5-1d8f-444c-a9e4-81d3b78e80f5",
                Body = new BatchAddServerNicsRequestBody
                {
                    Nics = new List<BatchAddServerNicOption>
                    {
                        new BatchAddServerNicOption
                        {
                            SubnetId = "97da9f05-77d2-468b-b40a-ee7b90cd0b1e",
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchAddServerNics(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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

        private static void BatchDeleteServerNics(EcsClient client)
        {
            var req = new BatchDeleteServerNicsRequest
            {
                ServerId = "5d78e6e5-1d8f-444c-a9e4-81d3b78e80f5",
                Body = new BatchDeleteServerNicsRequestBody
                {
                    Nics = new List<BatchDeleteServerNicOption>
                    {
                        new BatchDeleteServerNicOption
                        {
                            Id = "af473b9c-b66d-4f8a-b172-97d595283799"
                        }
                    }
                }
            };
            try
            {
                var resp = client.BatchDeleteServerNics(req);
                var respStatusCode = resp.HttpStatusCode;
                var jobId = resp.JobId;
                Console.WriteLine(respStatusCode);
                Console.WriteLine(jobId);
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