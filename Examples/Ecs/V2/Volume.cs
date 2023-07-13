using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class Volume
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

            AttachServerVolume(ecsClient);
            DetachServerVolume(ecsClient);
        }

        private static void AttachServerVolume(EcsClient clint)
        {
            var req = new AttachServerVolumeRequest
            {
                ServerId = "f0a34dd7-a103-400b-a448-9baad3077af2",
                Body = new AttachServerVolumeRequestBody
                {
                    VolumeAttachment = new AttachServerVolumeOption
                    {
                        VolumeId = "87e52ada-278f-43dd-aac2-9dc3c2876f6f"
                    }
                }
            };

            try
            {
                var resp = clint.AttachServerVolume(req);
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

        private static void DetachServerVolume(EcsClient clint)
        {
            var req = new DetachServerVolumeRequest
            {
                ServerId = "f0a34dd7-a103-400b-a448-9baad3077af2",
                VolumeId = "87e52ada-278f-43dd-aac2-9dc3c2876f6f",
                DeleteFlag = DetachServerVolumeRequest.DeleteFlagEnum._1
            };

            try
            {
                var resp = clint.DetachServerVolume(req);
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