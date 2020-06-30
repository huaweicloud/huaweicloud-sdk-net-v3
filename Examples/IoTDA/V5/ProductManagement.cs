using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class ProductManagement
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

            queryProduct(iotdaClient);
            queryProducts(iotdaClient);
            addProduct(iotdaClient);
            updateProduct(iotdaClient);
            deleteProduct(iotdaClient);
        }

        private static void queryProducts(IoTDAClient client)
        {
            ListProductsRequest req = new ListProductsRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ListProducts(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Page);
                foreach (var Product in resp.Products)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(Product));
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
        
        
        private static void queryProduct(IoTDAClient client)
        {
            ShowProductRequest req = new ShowProductRequest
            {
                ProductId = "5ea4f9fdda687b03370ad348",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowProduct(req);
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
        
        
        private static void addProduct(IoTDAClient client)
        {
            CreateProductRequest req = new CreateProductRequest
            {
                Body = new AddProduct()
                {
                    DataFormat = "binary",
                    Description = "this is a thermometer produced by Huawei",
                    DeviceType = "Thermometer",
                    Name = "Thermometer_test",
                    ProtocolType = "CoAP",
                    ServiceCapabilities = new List<ServiceCapability>()
                    {
                        new ServiceCapability()
                        {
                            Commands = new List<ServiceCommand>()
                            {
                                new ServiceCommand()
                                {
                                    CommandName = "reboot",
                                    Paras = new List<ServiceCommandPara>()
                                    {
                                        new ServiceCommandPara()
                                        {
                                            DataType = "int",
                                            Max = "100",
                                            MaxLength =  100,
                                            Min =  "1",
                                            ParaName = "force",
                                            Step =  0.1,
                                            Unit = "km/h"
                                        }
                                    },
                                    Responses = new List<ServiceCommandResponse>()
                                    {
                                        new ServiceCommandResponse()
                                        {
                                            Paras = new List<ServiceCommandPara>()
                                            {
                                                new ServiceCommandPara()
                                                {
                                                    DataType = "int",
                                                    Max = "100",
                                                    MaxLength =  100,
                                                    Min =  "1",
                                                    ParaName = "force",
                                                    Step =  0.1,
                                                    Unit = "km/h"
                                                }
                                            },
                                            ResponseName =  "ACK"
                                        }
                                    }
                                }
                            },
                            Description = "temperature",
                            Events = new List<ServiceEvent>()
                            {
                                new ServiceEvent()
                                {
                                    EventType = "reboot",
                                    Paras = new List<ServiceCommandPara>()
                                    {
                                        new ServiceCommandPara()
                                        {
                                            DataType = "int",
                                            Max = "100",
                                            MaxLength =  100,
                                            Min =  "1",
                                            ParaName = "force",
                                            Step =  0.1,
                                            Unit = "km/h"
                                        }
                                    }
                                }
                            },
                            Option = "Mandatory",
                            Properties = new List<ServiceProperty>()
                            {
                                new ServiceProperty()
                                {
                                    DataType = "decimal",
                                    Method = "R",
                                    PropertyName = "temperature"
                                }
                            },
                            ServiceId = "temperature",
                            ServiceType = "temperature"
                        }
                    }
                }
            };
            try
            {
                var resp = client.CreateProduct(req);
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
        
        private static void updateProduct(IoTDAClient client)
        {
            UpdateProductRequest req = new UpdateProductRequest
            {
                ProductId = "5ea80e4395fbb903e2b2bf28",
                Body = new UpdateProduct()
                {
                    DataFormat = "binary",
                    Description = "this is a thermometer produced by Huawei",
                    DeviceType = "Thermometer",
                    Name = "Thermometer_test",
                    ProtocolType = "CoAP",
                    ServiceCapabilities = new List<ServiceCapability>()
                    {
                        new ServiceCapability()
                        {
                            Commands = new List<ServiceCommand>()
                            {
                                new ServiceCommand()
                                {
                                    CommandName = "reboot",
                                    Paras = new List<ServiceCommandPara>()
                                    {
                                        new ServiceCommandPara()
                                        {
                                            DataType = "int",
                                            Max = "100",
                                            MaxLength =  100,
                                            Min =  "1",
                                            ParaName = "force",
                                            Step =  0.1,
                                            Unit = "km/h"
                                        }
                                    },
                                    Responses = new List<ServiceCommandResponse>()
                                    {
                                        new ServiceCommandResponse()
                                        {
                                            Paras = new List<ServiceCommandPara>()
                                            {
                                                new ServiceCommandPara()
                                                {
                                                    DataType = "int",
                                                    Max = "100",
                                                    MaxLength =  100,
                                                    Min =  "1",
                                                    ParaName = "force",
                                                    Step =  0.1,
                                                    Unit = "km/h"
                                                }
                                            },
                                            ResponseName =  "ACK"
                                        }
                                    }
                                }
                            },
                            Description = "temperature",
                            Events = new List<ServiceEvent>()
                            {
                                new ServiceEvent()
                                {
                                    EventType = "reboot",
                                    Paras = new List<ServiceCommandPara>()
                                    {
                                        new ServiceCommandPara()
                                        {
                                            DataType = "int",
                                            Max = "100",
                                            MaxLength =  100,
                                            Min =  "1",
                                            ParaName = "force",
                                            Step =  0.1,
                                            Unit = "km/h"
                                        }
                                    }
                                }
                            },
                            Option = "Mandatory",
                            Properties = new List<ServiceProperty>()
                            {
                                new ServiceProperty()
                                {
                                    DataType = "decimal",
                                    Method = "RW",
                                    PropertyName = "temperature"
                                }
                            },
                            ServiceId = "temperature",
                            ServiceType = "temperature"
                        }
                    }
                }
            };
            try
            {
                var resp = client.UpdateProduct(req);
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
        
        
        private static void deleteProduct(IoTDAClient client)
        {
            DeleteProductRequest req = new DeleteProductRequest
            {
                ProductId = "5ea80e4395fbb903e2b2bf28",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteProduct(req);
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