using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kafka.V2;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace Examples.Kafka.V2
{
    public class InstanceMgt
    {
        private const string ak = "{your ak string}";
        private const string sk = "{your sk string}";
        private const string endpoint = "{your endpoint}";
        private const string projectId = "{your project id}";
        private const string instanceId = "{instance id}";
        
        private static void InstanceMgtMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var kafkaClient = KafkaClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            resetPassword(kafkaClient);
        }

        private static void resetPassword(KafkaClient client)
        {
            var req = new ResetPasswordRequest
            {
                InstanceId = instanceId,
                Body = new ResetPasswordReq
                {
                    NewPassword = "xxxxxxxxxx",
                }
            };
            try
            {
                var resp = client.ResetPassword(req);
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