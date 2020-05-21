using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Fgs.V2;
using HuaweiCloud.SDK.Fgs.V2.Model;
using Newtonsoft.Json;

namespace Examples.Fgs.V2
{
    public class Fgs
    {
        static void FgsMain(string[] args) 
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var fgsClient = FgsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            //elapsed time
            //System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //stopwatch.Stop();
            //TimeSpan timespan = stopwatch.Elapsed;
            //Console.WriteLine("elapsed="+timespan.TotalSeconds);

            // ListFunctions
            //ListFunctions(fgsClient);
            
            //CreateFunction
            //CreateFunction(fgsClient);

            //ShowFunctionConfig
            //ShowFunctionConfig(fgsClient);

            //ShowFunctionCode
            //ShowFunctionCode(fgsClient);

            //UpdateFunctionCode
            //UpdateFunctionCode(fgsClient);

            //UpdateFunctionConfig
            //UpdateFunctionConfig(fgsClient);

            //CreateFunctionVersion
            //CreateFunctionVersion(fgsClient);

            //ListFunctionVersions
            //ListFunctionVersions(fgsClient);

            //CreateVersionAlias
            //CreateVersionAlias(fgsClient);

            //UpdateVersionAlias
            //UpdateVersionAlias(fgsClient);

            //ShowVersionAlias
            //ShowVersionAlias(fgsClient);

            //ListVersionAliases
            //ListVersionAliases(fgsClient);
            
            //DeleteVersionAlias
            //DeleteVersionAlias(fgsClient);

            //CreateFunctionTrigger
            //CreateFunctionTrigger(fgsClient);

            //ShowFunctionTrigger
            //ShowFunctionTrigger(fgsClient);

            //ListFunctionTriggers
            //ListFunctionTriggers(fgsClient);
            
            //DeleteFunctionTrigger
            //DeleteFunctionTrigger(fgsClient);
            
            //DeleteFunctionTriggers
            //BatchDeleteFunctionTriggers(fgsClient);

            //InvokeFunction
            //InvokeFunction(fgsClient);

            //InvokeFunctionAsync
            //InvokeFunctionAsync(fgsClient);
            
            //DeleteFunction
            //DeleteFunction(fgsClient);
        }

        /// <summary>
        /// 查询函数列表
        /// </summary>
        public static void ListFunctions(FgsClient client)
        {
            ListFunctionsRequest req = new ListFunctionsRequest
            {
                Marker = "0",
                Maxitems = "3"
            };
            try
            {
                ListFunctionsResponse resp = client.ListFunctions(req);
                Console.WriteLine("List Function Body="+JsonConvert.SerializeObject(resp));
                foreach (var func in resp.Functions)
                {
                    Console.WriteLine("name="+func.FuncName);
                    Console.WriteLine("func_urn="+func.FuncUrn);
                }
                Console.WriteLine("List Function statusCode="+resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 查询函数meatadata
        /// </summary>
        public static void ShowFunctionConfig(FgsClient client)
        {
            ShowFunctionConfigRequest req = new ShowFunctionConfigRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest"
            };
            try
            {
                ShowFunctionConfigResponse resp = client.ShowFunctionConfig(req);
                Console.WriteLine("ShowFunctionConfig Body="+JsonConvert.SerializeObject(resp));
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("ShowFunctionConfig statusCode="+resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询函数代码
        /// </summary>
        public static void ShowFunctionCode(FgsClient client)
        {
            ShowFunctionCodeRequest req = new ShowFunctionCodeRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest"
            };
            try
            {
                ShowFunctionCodeResponse resp = client.ShowFunctionCode(req);
                Console.WriteLine("ShowFunctionCode Body="+JsonConvert.SerializeObject(resp));
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("ShowFunctionCode statusCode="+resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 创建函数
        /// </summary>
        public static void CreateFunction(FgsClient client)
        {
            CreateFunctionRequest req = new CreateFunctionRequest
            {
                Body = new CreateFunctionRequestBody
                {
                    FuncName = "csharpSdkTest",
                    Handler = "index.handler",
                    MemorySize = 128,
                    Timeout = 3,
                    Runtime = CreateFunctionRequestBody.RuntimeEnum.NODE_JS6_10,
                    Package = "CsharpSdkTest",
                    CodeType = CreateFunctionRequestBody.CodeTypeEnum.INLINE,
                    CodeFilename = "index.zip",
                    FuncCode = new FuncCode
                    {
                        File = "UEsDBAoAAAAAAHYLfU2fZFKzsAAAALAAAAAIAAAAaW5kZXguanNleHBvcnRzLmhhbmRsZXIgPSBmdW5jdGlvbiAoZXZlbnQsIGNvbnRleHQsIGNhbGxiYWNrKSB7DQogICAgY29uc3QgZXJyb3IgPSBudWxsOw0KICAgIGNvbnN0IG91dHB1dCA9IGBIZWxsbyBtZXNzYWdlOiAke0pTT04uc3RyaW5naWZ5KGV2ZW50KX1gOw0KICAgIGNhbGxiYWNrKGVycm9yLCBvdXRwdXQpOw0KfVBLAQIeAwoAAAAAAHYLfU2fZFKzsAAAALAAAAAIAAAAAAAAAAAAAAC0gQAAAABpbmRleC5qc1BLBQYAAAAAAQABADYAAADWAAAAAAA="
                    }
                }
            };
            try
            {
                CreateFunctionResponse resp = client.CreateFunction(req);
                Console.WriteLine("Create Function Body="+JsonConvert.SerializeObject(resp));
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("Create Function StatusCode="+resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);

            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 删除函数/版本
        /// </summary>
        public static void DeleteFunction(FgsClient client)
        {
            DeleteFunctionRequest req = new DeleteFunctionRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest"
            };
            try
            {
                DeleteFunctionResponse resp = client.DeleteFunction(req);
                Console.WriteLine("DeleteFunction StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 修改指定函数代码
        /// </summary>
        public static void UpdateFunctionCode(FgsClient client)
        {
            UpdateFunctionCodeRequest req = new UpdateFunctionCodeRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Body = new UpdateFunctionCodeRequestBody
                {
                    CodeType = UpdateFunctionCodeRequestBody.CodeTypeEnum.INLINE,
                    CodeFilename = "index.zip",
                    FuncCode = new FuncCode
                    {
                        File = "UEsDBAoAAAAAAGIXhk0Ac1L2tgAAALYAAAAIAAAAaW5kZXguanNleHBvcnRzLmhhbmRsZXIgPSBmdW5jdGlvbiAoZXZlbnQsIGNvbnRleHQsIGNhbGxiYWNrKSB7DQogICAgY29uc3QgZXJyb3IgPSBudWxsOw0KICAgIGNvbnN0IG91dHB1dCA9IGBIZWxsbyB3b3JsZCBtZXNzYWdlOiAke0pTT04uc3RyaW5naWZ5KGV2ZW50KX1gOw0KICAgIGNhbGxiYWNrKGVycm9yLCBvdXRwdXQpOw0KfVBLAQIeAwoAAAAAAGIXhk0Ac1L2tgAAALYAAAAIAAAAAAAAAAAAAAC0gQAAAABpbmRleC5qc1BLBQYAAAAAAQABADYAAADcAAAAAAA="
                    }
                }
            };
            try
            {
                UpdateFunctionCodeResponse resp = client.UpdateFunctionCode(req);
                Console.WriteLine("UpdateFunctionCode Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("UpdateFunctionCode StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 修改指定函数metadata
        /// </summary>
        public static void UpdateFunctionConfig(FgsClient client)
        {
            UpdateFunctionConfigRequest req = new UpdateFunctionConfigRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Body = new UpdateFunctionConfigRequestBody
                {
                    FuncName = "csharpSdkTest",
                    Handler = "index.handler",
                    MemorySize =  512,
                    Timeout =  30,
                    Runtime = UpdateFunctionConfigRequestBody.RuntimeEnum.NODE_JS6_10,
                }
            };
            try
            {
                UpdateFunctionConfigResponse resp = client.UpdateFunctionConfig(req);
                Console.WriteLine("UpdateFunctionConfig Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("UpdateFunctionConfig StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 发布函数版本
        /// </summary>
        public static void CreateFunctionVersion(FgsClient client)
        {
            CreateFunctionVersionRequest req = new CreateFunctionVersionRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Body = new CreateFunctionVersionRequestBody
                {
                    Version = "v1",
                    Description = "发布v1版本"
                }
            };
            try
            {
                CreateFunctionVersionResponse resp = client.CreateFunctionVersion(req);
                Console.WriteLine("CreateFunctionVersion StatusCode=" + resp.HttpStatusCode);
                Console.WriteLine("func_name="+resp.FuncName);
                Console.WriteLine("func_urn="+resp.FuncUrn);
                Console.WriteLine("CreateFunctionVersion Body="+JsonConvert.SerializeObject(resp));
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询指定函数版本列表
        /// </summary>
        public static void ListFunctionVersions(FgsClient client)
        {
            ListFunctionVersionsRequest req = new ListFunctionVersionsRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest"
            };
            try
            {
                ListFunctionVersionsResponse resp = client.ListFunctionVersions(req);
                Console.WriteLine("ListFunctionVersions Body=" + JsonConvert.SerializeObject(resp));
                foreach (var funcVersion in resp.Versions)
                {
                    Console.WriteLine("func_name="+funcVersion.FuncName);
                    Console.WriteLine("func_urn="+funcVersion.FuncUrn);
                }
                Console.WriteLine("ListFunctionVersions StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 创建函数版本别名
        /// </summary>
        public static void CreateVersionAlias(FgsClient client)
        {
            Dictionary<string, int?> addtionalVersionWeights = new Dictionary<string, int?>();
            addtionalVersionWeights.Add("v1", 10);
            CreateVersionAliasRequest req = new CreateVersionAliasRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Body = new CreateVersionAliasRequestBody
                {
                    Name = "a1",
                    Version = "latest",
                    Description = "函数版本别名a1",
                    AdditionalVersionWeights = addtionalVersionWeights
                }
            };
            try
            {
                CreateVersionAliasResponse resp = client.CreateVersionAlias(req);
                Console.WriteLine("CreateVersionAlias Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("name="+resp.Name);
                Console.WriteLine("version="+resp.Version);
                Console.WriteLine("CreateVersionAlias StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 修改函数版本别名信息
        /// </summary>
        public static void UpdateVersionAlias(FgsClient client)
        {
            Dictionary<string, int?> addtionalVersionWeights = new Dictionary<string, int?>();
            addtionalVersionWeights.Add("v1", 20);
            UpdateVersionAliasRequest req = new UpdateVersionAliasRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Name = "a1",
                Body = new UpdateVersionAliasRequestBody
                {
                    Version = "latest",
                    Description = "修改函数版本别名a1",
                    AdditionalVersionWeights = addtionalVersionWeights
                }
            };
            try
            {
                UpdateVersionAliasResponse resp = client.UpdateVersionAlias(req);
                Console.WriteLine("UpdateVersionAlias Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("name="+resp.Name);
                Console.WriteLine("version="+resp.Version);
                Console.WriteLine("UpdateVersionAlias StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 删除函数版本别名
        /// </summary>
        public static void DeleteVersionAlias(FgsClient client)
        {
            DeleteVersionAliasRequest req = new DeleteVersionAliasRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Name = "a1",
            };
            try
            {
                DeleteVersionAliasResponse resp = client.DeleteVersionAlias(req);
                Console.WriteLine("DeleteVersionAlias StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询指定函数版本别名信息
        /// </summary>
        public static void ShowVersionAlias(FgsClient client)
        {
            ShowVersionAliasRequest req = new ShowVersionAliasRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Name = "a1",
            };
            try
            {
                ShowVersionAliasResponse resp = client.ShowVersionAlias(req);
                Console.WriteLine("ShowVersionAlias Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("name="+resp.Name);
                Console.WriteLine("version="+resp.Version);
                Console.WriteLine("ShowVersionAlias StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询指定函数版本别名列表
        /// </summary>
        public static void ListVersionAliases(FgsClient client)
        {
            ListVersionAliasesRequest req = new ListVersionAliasesRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest"
            };
            try
            {
                ListVersionAliasesResponse resp = client.ListVersionAliases(req);
                Console.WriteLine("ListVersionAliases Body=" + JsonConvert.SerializeObject(resp));
                foreach (var alias in resp.Body)
                {
                    Console.WriteLine("name="+alias.Name);
                    Console.WriteLine("version="+alias.Version);
                }
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 创建指定函数触发器
        /// </summary>
        public static void CreateFunctionTrigger(FgsClient client)
        {
            CreateFunctionTriggerRequest req = new CreateFunctionTriggerRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest",
                Body = new CreateFunctionTriggerRequestBody
                {
                    TriggerTypeCode = CreateFunctionTriggerRequestBody.TriggerTypeCodeEnum.TIMER,
                    EventTypeCode = "MessageCreated",
                    TriggerStatus = CreateFunctionTriggerRequestBody.TriggerStatusEnum.ACTIVE,
                    EventData = new Dictionary<string, string>
                    {
                        {"name", "Timer-vcc70"},
                        {"schedule_type", "Rate"},
                        {"schedule", "1m"}
                    }
                }
            };
            try
            {
                CreateFunctionTriggerResponse resp = client.CreateFunctionTrigger(req);
                Console.WriteLine("CreateFunctionTrigger Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("id="+resp.TriggerId);
                Console.WriteLine("trigger_type_code="+resp.TriggerTypeCode);
                Console.WriteLine("CreateFunctionTrigger StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询指定触发器
        /// </summary>
        public static void ShowFunctionTrigger(FgsClient client)
        {
            ShowFunctionTriggerRequest req = new ShowFunctionTriggerRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:nction:CsharpSdkTest:csharpSdkTest:latest",
                TriggerTypeCode = ShowFunctionTriggerRequest.TriggerTypeCodeEnum.TIMER,
                TriggerId = "cec41eba-bd7c-48d9-8644-08948b66f415"
                
            };
            try
            {
                ShowFunctionTriggerResponse resp = client.ShowFunctionTrigger(req);
                Console.WriteLine("ShowFunctionTrigger Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("id="+resp.TriggerId);
                Console.WriteLine("trigger_type_code="+resp.TriggerTypeCode);
                Console.WriteLine("ShowFunctionTrigger StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 查询指定函数触发器列表
        /// </summary>
        public static void ListFunctionTriggers(FgsClient client)
        {
            ListFunctionTriggersRequest req = new ListFunctionTriggersRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:nction:CsharpSdkTest:csharpSdkTest:latest"

            };
            try
            {
                ListFunctionTriggersResponse resp = client.ListFunctionTriggers(req);
                Console.WriteLine("ListFunctionTriggers Body=" + JsonConvert.SerializeObject(resp));
                foreach (var trigger in resp.Body)
                {
                    Console.WriteLine("id="+trigger.TriggerId);
                    Console.WriteLine("trigger_type_code="+trigger.TriggerTypeCode);
                }
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 删除指定函数所有触发器
        /// </summary>
        public static void BatchDeleteFunctionTriggers(FgsClient client)
        {
            BatchDeleteFunctionTriggersRequest req = new BatchDeleteFunctionTriggersRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:function:CsharpSdkTest:csharpSdkTest:latest"
            };
            try
            {
                BatchDeleteFunctionTriggersResponse resp = client.BatchDeleteFunctionTriggers(req);
                Console.WriteLine("BatchDeleteFunctionTriggers StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 删除指定触发器
        /// </summary>
        public static void DeleteFunctionTrigger(FgsClient client)
        {
            DeleteFunctionTriggerRequest req = new DeleteFunctionTriggerRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:nction:CsharpSdkTest:csharpSdkTest:latest",
                TriggerTypeCode = DeleteFunctionTriggerRequest.TriggerTypeCodeEnum.TIMER,
                TriggerId = "cec41eba-bd7c-48d9-8644-08948b66f415"
            };
            try
            {
                DeleteFunctionTriggerResponse resp = client.DeleteFunctionTrigger(req);
                Console.WriteLine("DeleteFunctionTrigger StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 同步执行函数
        /// </summary>
        public static void InvokeFunction(FgsClient client)
        {
            InvokeFunctionRequest req = new InvokeFunctionRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:nction:CsharpSdkTest:csharpSdkTest",
                XCffLogType = "tail",
                XCFFRequestVersion = "v1",
                Body = new Dictionary<string, object>
                {
                    {"k", "v"}
                }
            };
            try
            {
                InvokeFunctionResponse resp = client.InvokeFunction(req);
                Console.WriteLine("InvokeFunction Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("InvokeFunction StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// 异步执行函数
        /// </summary>
        public static void InvokeFunctionAsync(FgsClient client)
        {
            AsyncInvokeFunctionRequest req = new AsyncInvokeFunctionRequest
            {
                FunctionUrn = "urn:fss:cn-north-7:46b6f338fc3445b8846c71dfb1fbd9e8:nction:CsharpSdkTest:csharpSdkTest",
                Body = new Dictionary<string, object>
                {
                    {"k", "v"}
                }
            };
            try
            {
                AsyncInvokeFunctionResponse resp = client.AsyncInvokeFunction(req);
                Console.WriteLine("InvokeFunctionAsync Body=" + JsonConvert.SerializeObject(resp));
                Console.WriteLine("InvokeFunctionAsync StatusCode=" + resp.HttpStatusCode);
            }
            catch (ClientRequestException e)
            {
                Console.WriteLine(e.HttpStatusCode);
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMsg);
     
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ErrorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}