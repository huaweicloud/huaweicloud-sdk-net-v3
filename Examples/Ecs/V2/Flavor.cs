﻿using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class Flavor
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

            ListFlavors(ecsClient);
        }

        private static void ListFlavors(EcsClient client)
        {
            var req = new ListFlavorsRequest
            {
                AvailabilityZone = "br-iaas-odin1a"
            };

            try
            {
                var resp = client.ListFlavors(req);
                var respStatusCode = resp.HttpStatusCode;
                Console.WriteLine(respStatusCode);
                var flavors = resp.Flavors;
                foreach (var flavor in flavors)
                {
                    Console.WriteLine(flavor.Id);
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