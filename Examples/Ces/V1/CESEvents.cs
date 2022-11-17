using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Ces.V1;
using HuaweiCloud.SDK.Ces.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCSharpSDK
{
    public class CESEvents
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
            
            CreateEvents(cesClient);
        }

        /// <summary>
        /// 上报自定义事件。
        /// </summary>
        /// <param name="cesClient"></param>
        private static void CreateEvents(CesClient cesClient)
        {
            CreateEventsRequest createEventsRequest = new CreateEventsRequest()
            {
                Body = new List<EventItem>()
                {
                    new EventItem()
                    {
                        EventName = "ces_sdk_005",
                        EventSource = "SYS.ECS",
                        Time = 1587017957000,
                        Detail = new EventItemDetail()
                        {
                            Content = "The ECS alarm",
                            //GroupId = "rg15845342115453jqdPjrxA",
                            ResourceId = "50596679-553d-4280-80a5-1919b117e4cc",
                            ResourceName = "ecs-agent-nodelete",
                            EventState = EventItemDetail.EventStateEnum.NORMAL,
                            EventLevel = EventItemDetail.EventLevelEnum.MAJOR,
                            EventUser = "YYYY"
                        }
                    },
                    new EventItem()
                    {
                        EventName = "ces_sdk_006",
                        EventSource = "SYS.ECS",
                        Time = 1587017957000,
                        Detail = new EventItemDetail()
                        {
                            Content = "The ECS alarm",
                            //GroupId = "rg15845342115453jqdPjrxA",
                            ResourceId = "326277f5-ee01-4751-959e-8e9a364b6b3c",
                            ResourceName = "ecs-zhanfan1129",
                            EventState = EventItemDetail.EventStateEnum.NORMAL,
                            EventLevel = EventItemDetail.EventLevelEnum.MAJOR,
                            EventUser = "YYYY"
                        }
                    }
                }
            };

            try
            {
                CreateEventsResponse createEventsResponse = cesClient.CreateEvents(createEventsRequest);
                foreach (var createEventsResponseBody in createEventsResponse.Body)
                {
                    Console.WriteLine(createEventsResponseBody.ToString());
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