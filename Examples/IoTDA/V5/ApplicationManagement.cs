﻿using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class ApplicationManagement
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

            getApplication(iotdaClient);
            getApplications(iotdaClient);
            addApplication(iotdaClient);
            deleteApplication(iotdaClient);
        }

        private static void getApplications(IoTDAClient client)
        {
            ShowApplicationsRequest req = new ShowApplicationsRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowApplications(req);
                Console.WriteLine(resp.HttpStatusCode);
                foreach (var App in resp.Applications)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(App));
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


        private static void getApplication(IoTDAClient client)
        {
            ShowApplicationRequest req = new ShowApplicationRequest
            {
                AppId = "de8647c30bb8493b9adce4319cfa1c64",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowApplication(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp));
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


        private static void addApplication(IoTDAClient client)
        {
            AddApplicationRequest req = new AddApplicationRequest
            {
                Body = new AddApplication()
                {
                    AppName="testApp3"
                },
            };
            try
            {
                var resp = client.AddApplication(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp));
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

        private static void deleteApplication(IoTDAClient client)
        {
            DeleteApplicationRequest req = new DeleteApplicationRequest
            {
                AppId = "b761d59418fd4221871137e486f64d22",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteApplication(req);
                Console.WriteLine(resp.HttpStatusCode);
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
    }
}