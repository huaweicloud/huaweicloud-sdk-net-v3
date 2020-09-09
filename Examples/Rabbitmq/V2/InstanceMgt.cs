using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Rabbitmq.V2;
using HuaweiCloud.SDK.Rabbitmq.V2.Model;

namespace Examples.Rabbitmq.V2
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
            var rabbitmqClient = RabbitmqClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // listPlugins(rabbitmqClient);
            // updatePlugins(rabbitmqClient);
            resetPassword(rabbitmqClient);
        }

        private static void listPlugins(RabbitmqClient client)
        {
            var req = new ListPluginsRequest
            {
                InstanceId = instanceId,
            };
            try
            {
                var resp = client.ListPlugins(req);
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

        private static void updatePlugins(RabbitmqClient client)
        {
            var req = new UpdatePluginsRequest()
            {
                InstanceId = instanceId,
                Body = new UpdatePluginsReq
                {
                    Enable = true,
                    Plugins = "rabbitmq_sharding,rabbitmq_federation",
                }
            };
            try
            {
                var resp = client.UpdatePlugins(req);
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

        private static void resetPassword(RabbitmqClient client)
        {
            var req = new ResetPasswordRequest
            {
                InstanceId = instanceId,
                Body = new ResetPasswordReq
                {
                    NewPassword = "Cloud@123abc",
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