using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IoTDA.V5.Model;

namespace HuaweiCloud.SDK.IoTDA.V5
{
    public partial class IoTDAAsyncClient : Client
    {
        public static ClientBuilder<IoTDAAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IoTDAAsyncClient>().WithDerivedAuthServiceName("iotdm");
        }

        
        /// <summary>
        /// 生成接入凭证
        ///
        /// 接入凭证是用于客户端使用AMQP等协议与平台建链的一个认证凭据。只保留一条记录，如果重复调用只会重置接入凭证，使得之前的失效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessCodeResponse> CreateAccessCodeAsync(CreateAccessCodeRequest createAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessCodeResponse>(response);
        }

        public AsyncInvoker<CreateAccessCodeResponse> CreateAccessCodeAsyncInvoker(CreateAccessCodeRequest createAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            return new AsyncInvoker<CreateAccessCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessCodeResponse>);
        }
        
        /// <summary>
        /// 创建AMQP队列
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个AMQP队列。每个租户只能创建100个队列，若超过规格，则创建失败，若队列名称与已有的队列名称相同，则创建失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddQueueResponse> AddQueueAsync(AddQueueRequest addQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddQueueResponse>(response);
        }

        public AsyncInvoker<AddQueueResponse> AddQueueAsyncInvoker(AddQueueRequest addQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            return new AsyncInvoker<AddQueueResponse>(this, "POST", request, JsonUtils.DeSerialize<AddQueueResponse>);
        }
        
        /// <summary>
        /// 查询AMQP列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的AMQP队列信息列表。可通过队列名称作模糊查询，支持分页。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowQueueResponse> BatchShowQueueAsync(BatchShowQueueRequest batchShowQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<BatchShowQueueResponse>(response);
        }

        public AsyncInvoker<BatchShowQueueResponse> BatchShowQueueAsyncInvoker(BatchShowQueueRequest batchShowQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            return new AsyncInvoker<BatchShowQueueResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowQueueResponse>);
        }
        
        /// <summary>
        /// 删除AMQP队列
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定AMQP队列。若当前队列正在使用，则会删除失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest deleteQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id", deleteQueueRequest.QueueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
        }

        public AsyncInvoker<DeleteQueueResponse> DeleteQueueAsyncInvoker(DeleteQueueRequest deleteQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id", deleteQueueRequest.QueueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            return new AsyncInvoker<DeleteQueueResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteQueueResponse>);
        }
        
        /// <summary>
        /// 查询单个AMQP队列
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定队列的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQueueResponse> ShowQueueAsync(ShowQueueRequest showQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id", showQueueRequest.QueueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }

        public AsyncInvoker<ShowQueueResponse> ShowQueueAsyncInvoker(ShowQueueRequest showQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id", showQueueRequest.QueueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            return new AsyncInvoker<ShowQueueResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQueueResponse>);
        }
        
        /// <summary>
        /// 创建资源空间
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口创建资源空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddApplicationResponse> AddApplicationAsync(AddApplicationRequest addApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddApplicationResponse>(response);
        }

        public AsyncInvoker<AddApplicationResponse> AddApplicationAsyncInvoker(AddApplicationRequest addApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            return new AsyncInvoker<AddApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<AddApplicationResponse>);
        }
        
        /// <summary>
        /// 删除资源空间
        ///
        /// 删除指定资源空间。删除资源空间属于高危操作，删除资源空间后，该空间下的产品、设备等资源将不可用，请谨慎操作！
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
        }

        public AsyncInvoker<DeleteApplicationResponse> DeleteApplicationAsyncInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new AsyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 查询资源空间
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口查询指定资源空间详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplicationResponse> ShowApplicationAsync(ShowApplicationRequest showApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
        }

        public AsyncInvoker<ShowApplicationResponse> ShowApplicationAsyncInvoker(ShowApplicationRequest showApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            return new AsyncInvoker<ShowApplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicationResponse>);
        }
        
        /// <summary>
        /// 查询资源空间列表
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口查询资源空间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplicationsResponse> ShowApplicationsAsync(ShowApplicationsRequest showApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
        }

        public AsyncInvoker<ShowApplicationsResponse> ShowApplicationsAsyncInvoker(ShowApplicationsRequest showApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            return new AsyncInvoker<ShowApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicationsResponse>);
        }
        
        /// <summary>
        /// 更新资源空间
        ///
        /// 应用服务器可以调用此接口更新资源空间的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationResponse> UpdateApplicationAsyncInvoker(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationRequest);
            return new AsyncInvoker<UpdateApplicationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationResponse>);
        }
        
        /// <summary>
        /// 下发异步设备命令
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的命令，应用服务器可调用此接口向指定设备下发异步命令，以实现对设备的控制。平台负责将命令发送给设备，并将设备执行命令结果异步通知应用服务器。 命令执行结果支持灵活的数据流转，应用服务器通过调用物联网平台的创建规则触发条件（Resource:device.command.status，Event:update）、创建规则动作并激活规则后，当命令状态变更时，物联网平台会根据规则将结果发送到规则指定的服务器，如用户自定义的HTTP服务器，AMQP服务器，以及华为云的其他储存服务器等, 详情参考[[设备命令状态变更通知](https://support.huaweicloud.com/api-iothub/iot_06_v5_01212.html)](tag:hws)[[设备命令状态变更通知](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_01212.html)](tag:hws_hk)。
        /// 注意：
        /// - 此接口适用于NB设备异步命令下发，暂不支持其他协议类型设备命令下发。
        /// - 此接口仅支持单个设备异步命令下发，如需多个设备异步命令下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAsyncCommandResponse> CreateAsyncCommandAsync(CreateAsyncCommandRequest createAsyncCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createAsyncCommandRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAsyncCommandResponse>(response);
        }

        public AsyncInvoker<CreateAsyncCommandResponse> CreateAsyncCommandAsyncInvoker(CreateAsyncCommandRequest createAsyncCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createAsyncCommandRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            return new AsyncInvoker<CreateAsyncCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAsyncCommandResponse>);
        }
        
        /// <summary>
        /// 查询指定id的命令
        ///
        /// 物联网平台可查询指定id的命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAsyncDeviceCommandResponse> ShowAsyncDeviceCommandAsync(ShowAsyncDeviceCommandRequest showAsyncDeviceCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showAsyncDeviceCommandRequest.DeviceId.ToString());
            urlParam.Add("command_id", showAsyncDeviceCommandRequest.CommandId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>(response);
        }

        public AsyncInvoker<ShowAsyncDeviceCommandResponse> ShowAsyncDeviceCommandAsyncInvoker(ShowAsyncDeviceCommandRequest showAsyncDeviceCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showAsyncDeviceCommandRequest.DeviceId.ToString());
            urlParam.Add("command_id", showAsyncDeviceCommandRequest.CommandId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            return new AsyncInvoker<ShowAsyncDeviceCommandResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>);
        }
        
        /// <summary>
        /// 创建批量任务
        ///
        /// 应用服务器可调用此接口为创建批量处理任务，对多个设备进行批量操作。当前支持批量软固件升级、批量创建设备、批量删除设备、批量冻结设备、批量解冻设备、批量创建命令、批量创建消息任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBatchTaskResponse> CreateBatchTaskAsync(CreateBatchTaskRequest createBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBatchTaskResponse>(response);
        }

        public AsyncInvoker<CreateBatchTaskResponse> CreateBatchTaskAsyncInvoker(CreateBatchTaskRequest createBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            return new AsyncInvoker<CreateBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBatchTaskResponse>);
        }
        
        /// <summary>
        /// 删除批量任务
        ///
        /// 应用服务器可调用此接口删除物联网平台中已经完成（状态为成功，失败，部分成功，已停止）的批量任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBatchTaskResponse> DeleteBatchTaskAsync(DeleteBatchTaskRequest deleteBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBatchTaskResponse>(response);
        }

        public AsyncInvoker<DeleteBatchTaskResponse> DeleteBatchTaskAsyncInvoker(DeleteBatchTaskRequest deleteBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskRequest);
            return new AsyncInvoker<DeleteBatchTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBatchTaskResponse>);
        }
        
        /// <summary>
        /// 查询批量任务列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中批量任务列表，每一个任务又包括具体的任务内容、任务状态、任务完成情况统计等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBatchTasksResponse> ListBatchTasksAsync(ListBatchTasksRequest listBatchTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBatchTasksResponse>(response);
        }

        public AsyncInvoker<ListBatchTasksResponse> ListBatchTasksAsyncInvoker(ListBatchTasksRequest listBatchTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            return new AsyncInvoker<ListBatchTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBatchTasksResponse>);
        }
        
        /// <summary>
        /// 重试批量任务
        ///
        /// 应用服务器可调用此接口重试批量任务，目前只支持task_type为firmwareUpgrade，softwareUpgrade。如果task_id对应任务已经成功、停止、正在停止、等待中或初始化中，则不可以调用该接口。如果请求Body为{}，则调用该接口后会重新执行所有状态为失败、失败待重试和已停止的子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryBatchTaskResponse> RetryBatchTaskAsync(RetryBatchTaskRequest retryBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", retryBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryBatchTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RetryBatchTaskResponse>(response);
        }

        public AsyncInvoker<RetryBatchTaskResponse> RetryBatchTaskAsyncInvoker(RetryBatchTaskRequest retryBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", retryBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryBatchTaskRequest);
            return new AsyncInvoker<RetryBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryBatchTaskResponse>);
        }
        
        /// <summary>
        /// 查询批量任务
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定批量任务的信息，包括任务内容、任务状态、任务完成情况统计以及子任务列表等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBatchTaskResponse> ShowBatchTaskAsync(ShowBatchTaskRequest showBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
        }

        public AsyncInvoker<ShowBatchTaskResponse> ShowBatchTaskAsyncInvoker(ShowBatchTaskRequest showBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            return new AsyncInvoker<ShowBatchTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBatchTaskResponse>);
        }
        
        /// <summary>
        /// 停止批量任务
        ///
        /// 应用服务器可调用此接口停止批量任务，目前只支持task_type为firmwareUpgrade，softwareUpgrade。如果task_id对应任务已经完成（成功、失败、部分成功，已经停止）或正在停止中，则不可以调用该接口。如果请求Body为{}，则调用该接口后会停止所有正在执行中、等待中和失败待重试状态的子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBatchTaskResponse> StopBatchTaskAsync(StopBatchTaskRequest stopBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBatchTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopBatchTaskResponse>(response);
        }

        public AsyncInvoker<StopBatchTaskResponse> StopBatchTaskAsyncInvoker(StopBatchTaskRequest stopBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopBatchTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBatchTaskRequest);
            return new AsyncInvoker<StopBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBatchTaskResponse>);
        }
        
        /// <summary>
        /// 删除批量任务文件
        ///
        /// 应用服务器可调用此接口删除批量任务文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBatchTaskFileResponse> DeleteBatchTaskFileAsync(DeleteBatchTaskFileRequest deleteBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteBatchTaskFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>(response);
        }

        public AsyncInvoker<DeleteBatchTaskFileResponse> DeleteBatchTaskFileAsyncInvoker(DeleteBatchTaskFileRequest deleteBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteBatchTaskFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            return new AsyncInvoker<DeleteBatchTaskFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>);
        }
        
        /// <summary>
        /// 查询批量任务文件列表
        ///
        /// 应用服务器可调用此接口查询批量任务文件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBatchTaskFilesResponse> ListBatchTaskFilesAsync(ListBatchTaskFilesRequest listBatchTaskFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBatchTaskFilesResponse>(response);
        }

        public AsyncInvoker<ListBatchTaskFilesResponse> ListBatchTaskFilesAsyncInvoker(ListBatchTaskFilesRequest listBatchTaskFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            return new AsyncInvoker<ListBatchTaskFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBatchTaskFilesResponse>);
        }
        
        /// <summary>
        /// 上传批量任务文件
        ///
        /// 应用服务器可调用此接口上传批量任务文件，用于创建批量任务。当前支持批量创建设备任务、批量删除设备任务、批量冻结设备任务、批量解冻设备任务的文件上传。
        /// - [批量注册设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchCreateDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量删除设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchDeleteDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量冻结设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchFreezeDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量解冻设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchUnfreezeDevices_Template.xlsx)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadBatchTaskFileResponse> UploadBatchTaskFileAsync(UploadBatchTaskFileRequest uploadBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBatchTaskFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadBatchTaskFileResponse>(response);
        }

        public AsyncInvoker<UploadBatchTaskFileResponse> UploadBatchTaskFileAsyncInvoker(UploadBatchTaskFileRequest uploadBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBatchTaskFileRequest);
            return new AsyncInvoker<UploadBatchTaskFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadBatchTaskFileResponse>);
        }
        
        /// <summary>
        /// 下发广播消息
        ///
        /// 应用服务器可调用此接口向订阅了指定Topic的所有在线设备发布广播消息。应用将广播消息下发给平台后，平台会先返回应用响应结果，再将消息广播给设备。
        /// 注意：
        /// - 此接口只适用于使用MQTT协议接入的设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BroadcastMessageResponse> BroadcastMessageAsync(BroadcastMessageRequest broadcastMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/broadcast-messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BroadcastMessageResponse>(response);
        }

        public AsyncInvoker<BroadcastMessageResponse> BroadcastMessageAsyncInvoker(BroadcastMessageRequest broadcastMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/broadcast-messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastMessageRequest);
            return new AsyncInvoker<BroadcastMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<BroadcastMessageResponse>);
        }
        
        /// <summary>
        /// 上传设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台上传设备CA证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddCertificateResponse> AddCertificateAsync(AddCertificateRequest addCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddCertificateResponse>(response);
        }

        public AsyncInvoker<AddCertificateResponse> AddCertificateAsyncInvoker(AddCertificateRequest addCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            return new AsyncInvoker<AddCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCertificateResponse>);
        }
        
        /// <summary>
        /// 验证设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台验证设备的CA证书，目的是为了验证用户持有设备CA证书的私钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckCertificateResponse> CheckCertificateAsync(CheckCertificateRequest checkCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", checkCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CheckCertificateResponse>(response);
        }

        public AsyncInvoker<CheckCertificateResponse> CheckCertificateAsyncInvoker(CheckCertificateRequest checkCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", checkCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            return new AsyncInvoker<CheckCertificateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckCertificateResponse>);
        }
        
        /// <summary>
        /// 删除设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台删除设备CA证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteCertificateResponse> DeleteCertificateAsyncInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new AsyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
        }
        
        /// <summary>
        /// 获取设备CA证书列表
        ///
        /// 应用服务器可调用此接口在物联网平台获取设备CA证书列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public AsyncInvoker<ListCertificatesResponse> ListCertificatesAsyncInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new AsyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 下发设备命令
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的命令，应用服务器可调用此接口向指定设备下发命令，以实现对设备的同步控制。平台负责将命令以同步方式发送给设备，并将设备执行命令结果同步返回, 如果设备没有响应，平台会返回给应用服务器超时，平台超时时间是20秒。如果命令下发需要超过20秒，建议采用[[消息下发](https://support.huaweicloud.com/api-iothub/iot_06_v5_0059.html)](tag:hws)[[消息下发](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0059.html)](tag:hws_hk)。
        /// 注意：
        /// - 此接口适用于MQTT设备同步命令下发，暂不支持NB-IoT设备命令下发。
        /// - 此接口仅支持单个设备同步命令下发，如需多个设备同步命令下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCommandResponse> CreateCommandAsync(CreateCommandRequest createCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createCommandRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCommandResponse>(response);
        }

        public AsyncInvoker<CreateCommandResponse> CreateCommandAsyncInvoker(CreateCommandRequest createCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createCommandRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            return new AsyncInvoker<CreateCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommandResponse>);
        }
        
        /// <summary>
        /// 添加设备组
        ///
        /// 应用服务器可调用此接口新建设备组，一个华为云账号下最多可有1,000个设备组，包括父设备组和子设备组。设备组的最大层级关系不超过5层，即群组形成的关系树最大深度不超过5。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDeviceGroupResponse> AddDeviceGroupAsync(AddDeviceGroupRequest addDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceGroupResponse>(response);
        }

        public AsyncInvoker<AddDeviceGroupResponse> AddDeviceGroupAsyncInvoker(AddDeviceGroupRequest addDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            return new AsyncInvoker<AddDeviceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 管理设备组中的设备
        ///
        /// 应用服务器可调用此接口管理设备组中的设备。单个设备组内最多添加20,000个设备，一个设备最多可以被添加到10个设备组中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrDeleteDeviceInGroupResponse> CreateOrDeleteDeviceInGroupAsync(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createOrDeleteDeviceInGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
        }

        public AsyncInvoker<CreateOrDeleteDeviceInGroupResponse> CreateOrDeleteDeviceInGroupAsyncInvoker(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createOrDeleteDeviceInGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            return new AsyncInvoker<CreateOrDeleteDeviceInGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>);
        }
        
        /// <summary>
        /// 删除设备组
        ///
        /// 应用服务器可调用此接口删除指定设备组，如果该设备组存在子设备组或者该设备组中存在设备，必须先删除子设备组并将设备从该设备组移除，才能删除该设备组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupAsync(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
        }

        public AsyncInvoker<DeleteDeviceGroupResponse> DeleteDeviceGroupAsyncInvoker(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            return new AsyncInvoker<DeleteDeviceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 查询设备组列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的设备组信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDeviceGroupsResponse> ListDeviceGroupsAsync(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceGroupsResponse>(response);
        }

        public AsyncInvoker<ListDeviceGroupsResponse> ListDeviceGroupsAsyncInvoker(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            return new AsyncInvoker<ListDeviceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceGroupsResponse>);
        }
        
        /// <summary>
        /// 查询设备组
        ///
        /// 应用服务器可调用此接口查询指定设备组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceGroupResponse> ShowDeviceGroupAsync(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceGroupResponse>(response);
        }

        public AsyncInvoker<ShowDeviceGroupResponse> ShowDeviceGroupAsyncInvoker(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            return new AsyncInvoker<ShowDeviceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 查询设备组设备列表
        ///
        /// 应用服务器可调用此接口查询指定设备组下的设备列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDevicesInGroupResponse> ShowDevicesInGroupAsync(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDevicesInGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDevicesInGroupResponse>(response);
        }

        public AsyncInvoker<ShowDevicesInGroupResponse> ShowDevicesInGroupAsyncInvoker(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDevicesInGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            return new AsyncInvoker<ShowDevicesInGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDevicesInGroupResponse>);
        }
        
        /// <summary>
        /// 修改设备组
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定设备组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroupAsync(UpdateDeviceGroupRequest updateDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceGroupResponse>(response);
        }

        public AsyncInvoker<UpdateDeviceGroupResponse> UpdateDeviceGroupAsyncInvoker(UpdateDeviceGroupRequest updateDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeviceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            return new AsyncInvoker<UpdateDeviceGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 创建设备
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个设备，仅在创建后设备才可以接入物联网平台。
        /// 
        /// - 该接口支持使用gateway_id参数指定在父设备下创建一个子设备，并且支持多级子设备，当前最大支持二级子设备。
        /// - 该接口同时还支持对设备进行初始配置，接口会读取创建设备请求参数product_id对应的产品详情，如果产品的属性有定义默认值，则会将该属性默认值写入该设备的设备影子中。
        /// - 用户还可以使用创建设备请求参数shadow字段为设备指定初始配置，指定后将会根据service_id和desired设置的属性值与产品中对应属性的默认值比对，如果不同，则将以shadow字段中设置的属性值为准写入到设备影子中。
        /// - 该接口仅支持创建单个设备，如需批量注册设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
        }

        public AsyncInvoker<AddDeviceResponse> AddDeviceAsyncInvoker(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            return new AsyncInvoker<AddDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceResponse>);
        }
        
        /// <summary>
        /// 删除设备
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定设备。若设备下连接了非直连设备，则必须把设备下的非直连设备都删除后，才能删除该设备。该接口仅支持删除单个设备，如需批量删除设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest deleteDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", deleteDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
        }

        public AsyncInvoker<DeleteDeviceResponse> DeleteDeviceAsyncInvoker(DeleteDeviceRequest deleteDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", deleteDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            return new AsyncInvoker<DeleteDeviceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceResponse>);
        }
        
        /// <summary>
        /// 冻结设备
        ///
        /// 应用服务器可调用此接口冻结设备，设备冻结后不能再连接上线，可以通过解冻设备接口解除设备冻结。注意，当前仅支持冻结与平台直连的设备。该接口仅支持冻结单个设备，如需批量冻结设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<FreezeDeviceResponse> FreezeDeviceAsync(FreezeDeviceRequest freezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", freezeDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
        }

        public AsyncInvoker<FreezeDeviceResponse> FreezeDeviceAsyncInvoker(FreezeDeviceRequest freezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", freezeDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            return new AsyncInvoker<FreezeDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<FreezeDeviceResponse>);
        }
        
        /// <summary>
        /// 查询设备列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的设备信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest listDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDevicesResponse>(response);
        }

        public AsyncInvoker<ListDevicesResponse> ListDevicesAsyncInvoker(ListDevicesRequest listDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            return new AsyncInvoker<ListDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevicesResponse>);
        }
        
        /// <summary>
        /// 重置设备密钥
        ///
        /// 应用服务器可调用此接口重置设备密钥，携带指定密钥时平台将设备密钥重置为指定的密钥，不携带密钥时平台将自动生成一个新的随机密钥返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetDeviceSecretResponse> ResetDeviceSecretAsync(ResetDeviceSecretRequest resetDeviceSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", resetDeviceSecretRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetDeviceSecretResponse>(response);
        }

        public AsyncInvoker<ResetDeviceSecretResponse> ResetDeviceSecretAsyncInvoker(ResetDeviceSecretRequest resetDeviceSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", resetDeviceSecretRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            return new AsyncInvoker<ResetDeviceSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDeviceSecretResponse>);
        }
        
        /// <summary>
        /// 重置设备指纹
        ///
        /// 应用服务器可调用此接口重置设备指纹。携带指定设备指纹时将之重置为指定值；不携带时将之置空，后续设备第一次接入时，该设备指纹的值将设置为第一次接入时的证书指纹。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetFingerprintResponse> ResetFingerprintAsync(ResetFingerprintRequest resetFingerprintRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", resetFingerprintRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/reset-fingerprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetFingerprintRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetFingerprintResponse>(response);
        }

        public AsyncInvoker<ResetFingerprintResponse> ResetFingerprintAsyncInvoker(ResetFingerprintRequest resetFingerprintRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", resetFingerprintRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/reset-fingerprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetFingerprintRequest);
            return new AsyncInvoker<ResetFingerprintResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetFingerprintResponse>);
        }
        
        /// <summary>
        /// 灵活搜索设备列表
        ///
        /// #### 接口说明
        /// 
        /// 应用服务器使用SQL语句调用该接口，灵活的搜索所需要的设备资源列表
        /// 
        /// #### 限制
        /// 
        /// - 仅**标准版实例、企业版实例**支持该接口调用，基础版不支持。
        /// - 单账号调用该接口的 TPS 限制最大为1/S(每秒1次请求数)
        /// 
        /// #### 类SQL语法使用说明
        /// 
        /// 类SQL语句有select、from、where(可选)、order by(可选)、limit子句(可选)组成，长度限制为400个字符。子句里的内容大小写敏感，SQL语句的关键字大小写不敏感。
        /// 
        /// 示例：
        /// 
        /// &#x60;&#x60;&#x60;
        /// select * from device where device_id &#x3D; &#39;as********&#39; limit 0,5
        /// &#x60;&#x60;&#x60;
        /// 
        /// ##### SELECT子句
        /// 
        /// &#x60;&#x60;&#x60;
        /// select [field]/[count(*)/count(1)] from device
        /// &#x60;&#x60;&#x60;
        /// 
        /// 其中field为需要获取的字段，请参考响应参数字段名称，也可填*，获取所有字段。
        /// 
        /// 如果需要统计搜索的设备个数，请填count(*)或者count(1).
        /// 
        /// ##### FROM子句
        /// 
        /// &#x60;&#x60;&#x60;
        /// from device
        /// &#x60;&#x60;&#x60;
        /// 
        /// from后为要查询的资源名，当前支持\&quot;device\&quot;
        /// 
        /// ##### WHERE子句(可选)
        /// 
        /// &#x60;&#x60;&#x60;
        /// WHERE [condition1] AND [condition2]
        /// &#x60;&#x60;&#x60;
        /// 
        /// 最多支持5个condition，不支持嵌套；支持的检索字段请参见下面的**搜索条件字段说明**和**支持的运算符**章节
        /// 
        /// 连接词支持AND、OR，优先级参考标准SQL语法，默认AND优先级高于OR。
        /// 
        /// ##### LIMIT子句(可选)
        /// 
        /// &#x60;&#x60;&#x60;
        /// limit [offset,] rows
        /// &#x60;&#x60;&#x60;
        /// 
        /// offset标识搜索的偏移量，rows标识返回搜索结果的最大行数，例如：
        /// 
        /// - limit n ;示例(select * from device limit 10)
        /// 
        ///   最大返回n条结果数据
        ///   
        /// - limit m,n; 示例(select * from device limit 20,10) 
        ///   搜索偏移量为m，最大返回n条结果数据
        /// 
        /// ###### 限制
        /// 
        ///  offset 最大 500， rows最大50，如果不填写limit子句，默认为limit 10
        /// 
        /// ##### ORDER BY子句(可选)
        /// 
        /// 用于实现自定义排序，当前支持自定义排序的字段为：\&quot;marker\&quot;。
        /// 
        /// &#x60;&#x60;&#x60;
        /// order by marker [asc]/[desc]
        /// &#x60;&#x60;&#x60;
        /// 
        /// 子句不填写时默认逻辑为随机排序
        /// 
        /// #### 搜索条件字段说明
        /// 
        /// | 字段名      | 类型   | 说明             | 取值范围                                                     |
        /// | :- -- -- -- -- - | :- -- -- | :- -- -- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |
        /// | app_id      | string | 资源空间ID       | 长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | device_id   | string | 设备ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | gateway_id  | string | 网关ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | product_id  | string | 设备关联的产品ID | 长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | device_name | string | 设备名称         | 长度不超过256，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合符。 |
        /// | node_id     | string | 设备标识码       | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）的组合 |
        /// | status      | string | 设备的状态       | ONLINE(在线)、OFFLINE(离线)、ABNORMAL(异常)、INACTIVE(未激活)、FROZEN(冻结) |
        /// | node_type   | string | 设备节点类型     | GATEWAY(直连设备或网关)、ENDPOINT(非直连设备)                |
        /// | tag_key     | string | 标签键           | 长度不超过64，只允许中文、字母、数字、以及_.-等字符的组合。  |
        /// | tag_value   | string | 标签值           | 长度不超过128，只允许中文、字母、数字、以及_.-等字符的组合。 |
        /// | sw_version  | string | 软件版本         | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）、英文点(.)的组合。 |
        /// | fw_version  | string | 固件版本         | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）、英文点(.)的组合。 |
        /// | group_id    | string | 群组Id           | 长度不超过36，十六进制字符串和连接符（-）的组合              |
        /// | create_time | string | 设备注册时间     | 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;，如：2015-06-06T12:10:10.000Z |
        /// | marker      | string | 结果记录ID       | 长度为24的十六进制字符串，如ffffffffffffffffffffffff         |
        /// 
        /// #### 支持的运算符
        /// 
        /// | 运算符  | 支持的字段                               |
        /// | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |
        /// | &#x3D;       | 所有                                     |
        /// | !&#x3D;      | 所有                                     |
        /// | &gt;       | create_time、marker                      |
        /// | &lt;       | create_time、marker                      |
        /// | like    | device_name、node_id、tag_key、tag_value |
        /// | in      | 除tag_key、tag_value以外字段             |
        /// | not  in | 除tag_key、tag_value以外字段             |
        /// 
        /// #### SQL 限制
        /// 
        /// - like: 只支持前缀匹配，不支持后缀匹配或者通配符匹配。前缀匹配不得少于4个字符，且不能包含任何特殊字符(只允许中文、字母、数字、下划线（_）、连接符（-）). 前缀后必须跟上\&quot;%\&quot;结尾。
        /// - 不支持除了count(*)/count(1)以外的其他任何函数。
        /// - 不支持其他SQL用法，如嵌套SQL、union、join、别名(Alias)等用法
        /// - SQL长度限制为400个字符，单个请求条件最大支持5个。
        /// - 不支持\&quot;null\&quot;和空字符串等条件值匹配
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/search/query-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchDevicesResponse>(response);
        }

        public AsyncInvoker<SearchDevicesResponse> SearchDevicesAsyncInvoker(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/search/query-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            return new AsyncInvoker<SearchDevicesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDevicesResponse>);
        }
        
        /// <summary>
        /// 查询设备
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定设备的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceResponse> ShowDeviceAsync(ShowDeviceRequest showDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceResponse>(response);
        }

        public AsyncInvoker<ShowDeviceResponse> ShowDeviceAsyncInvoker(ShowDeviceRequest showDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            return new AsyncInvoker<ShowDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceResponse>);
        }
        
        /// <summary>
        /// 解冻设备
        ///
        /// 应用服务器可调用此接口解冻设备，解除冻结后，设备可以连接上线。该接口仅支持解冻单个设备，如需批量解冻设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnfreezeDeviceResponse> UnfreezeDeviceAsync(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", unfreezeDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
        }

        public AsyncInvoker<UnfreezeDeviceResponse> UnfreezeDeviceAsyncInvoker(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", unfreezeDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            return new AsyncInvoker<UnfreezeDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>);
        }
        
        /// <summary>
        /// 修改设备
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定设备的基本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updateDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceResponse>(response);
        }

        public AsyncInvoker<UpdateDeviceResponse> UpdateDeviceAsyncInvoker(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updateDeviceRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            return new AsyncInvoker<UpdateDeviceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceResponse>);
        }
        
        /// <summary>
        /// 查询设备影子数据
        ///
        /// 应用服务器可调用此接口查询指定设备的设备影子信息，包括对设备的期望属性信息（desired区）和设备最新上报的属性信息（reported区）。
        /// 
        /// 设备影子介绍：
        /// 设备影子是一个用于存储和检索设备当前状态信息的JSON文档。
        /// - 每个设备有且只有一个设备影子，由设备ID唯一标识
        /// - 设备影子用于存储设备上报的(状态)属性和应用程序期望的设备(状态)属性
        /// - 无论该设备是否在线，都可以通过该影子获取和设置设备的属性
        /// - 设备上线或者设备上报属性时，如果desired区和reported区存在差异，则将差异部分下发给设备，配置的预期属性需在产品模型中定义且method具有可写属性“W”才可下发
        /// 
        /// 限制：
        /// 设备影子JSON文档中的key不允许特殊字符：点(.)、dollar符号($)、空char(十六进制的ASCII码为00)。如果包含了以上特殊字符则无法正常刷新影子文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceShadowResponse> ShowDeviceShadowAsync(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceShadowRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceShadowResponse>(response);
        }

        public AsyncInvoker<ShowDeviceShadowResponse> ShowDeviceShadowAsyncInvoker(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceShadowRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            return new AsyncInvoker<ShowDeviceShadowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceShadowResponse>);
        }
        
        /// <summary>
        /// 配置设备影子预期数据
        ///
        /// 应用服务器可调用此接口配置设备影子的预期属性（desired区），当设备上线或者设备上报属性时把属性下发给设备。
        /// 
        /// 设备影子介绍：
        /// 设备影子是一个用于存储和检索设备当前状态信息的JSON文档。
        /// - 每个设备有且只有一个设备影子，由设备ID唯一标识
        /// - 设备影子用于存储设备上报的(状态)属性和应用程序期望的设备(状态)属性
        /// - 无论该设备是否在线，都可以通过该影子获取和设置设备的属性
        /// - 设备上线或者设备上报属性时，如果desired区和reported区存在差异，则将差异部分下发给设备，配置的预期属性需在产品模型中定义且method具有可写属性“W”才可下发
        /// - 该接口仅支持配置单个设备的设备影子的预期数据，如需多个设备的设备影子配置，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// 限制：
        /// 设备影子JSON文档中的key不允许特殊字符：点(.)、dollar符号($)、空char(十六进制的ASCII码为00)。如果包含了以上特殊字符则无法正常刷新影子文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeviceShadowDesiredDataResponse> UpdateDeviceShadowDesiredDataAsync(UpdateDeviceShadowDesiredDataRequest updateDeviceShadowDesiredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updateDeviceShadowDesiredDataRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>(response);
        }

        public AsyncInvoker<UpdateDeviceShadowDesiredDataResponse> UpdateDeviceShadowDesiredDataAsyncInvoker(UpdateDeviceShadowDesiredDataRequest updateDeviceShadowDesiredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updateDeviceShadowDesiredDataRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            return new AsyncInvoker<UpdateDeviceShadowDesiredDataResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>);
        }
        
        /// <summary>
        /// 下发设备消息
        ///
        /// 物联网平台可向设备下发消息，应用服务器可调用此接口向指定设备下发消息，以实现对设备的控制。应用将消息下发给平台后，平台返回应用响应结果，平台再将消息发送给设备。平台返回应用响应结果不一定是设备接收结果，建议用户应用通过订阅[[设备消息状态变更通知](https://support.huaweicloud.com/api-iothub/iot_06_v5_01203.html)](tag:hws)[[设备消息状态变更通知](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_01203.html)](tag:hws_hk)，订阅后平台会将设备接收结果推送给订阅的应用。
        /// 注意：
        /// - 此接口适用于MQTT设备消息下发，暂不支持其他协议接入的设备消息下发。
        /// - 此接口仅支持单个设备消息下发，如需多个设备消息下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMessageResponse> CreateMessageAsync(CreateMessageRequest createMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createMessageRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMessageResponse>(response);
        }

        public AsyncInvoker<CreateMessageResponse> CreateMessageAsyncInvoker(CreateMessageRequest createMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", createMessageRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            return new AsyncInvoker<CreateMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMessageResponse>);
        }
        
        /// <summary>
        /// 查询设备消息
        ///
        /// 应用服务器可调用此接口查询平台下发给设备的消息，平台为每个设备默认最多保存20条消息，超过20条后， 后续的消息会替换下发最早的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDeviceMessagesResponse> ListDeviceMessagesAsync(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", listDeviceMessagesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceMessagesResponse>(response);
        }

        public AsyncInvoker<ListDeviceMessagesResponse> ListDeviceMessagesAsyncInvoker(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", listDeviceMessagesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            return new AsyncInvoker<ListDeviceMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceMessagesResponse>);
        }
        
        /// <summary>
        /// 查询指定消息id的消息
        ///
        /// 应用服务器可调用此接口查询平台下发给设备的指定消息id的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceMessageResponse> ShowDeviceMessageAsync(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceMessageRequest.DeviceId.ToString());
            urlParam.Add("message_id", showDeviceMessageRequest.MessageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceMessageResponse>(response);
        }

        public AsyncInvoker<ShowDeviceMessageResponse> ShowDeviceMessageAsyncInvoker(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", showDeviceMessageRequest.DeviceId.ToString());
            urlParam.Add("message_id", showDeviceMessageRequest.MessageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            return new AsyncInvoker<ShowDeviceMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceMessageResponse>);
        }
        
        /// <summary>
        /// 创建OTA升级包
        ///
        /// 用户可调用此接口创建升级包关联OBS对象
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOtaPackageResponse> CreateOtaPackageAsync(CreateOtaPackageRequest createOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOtaPackageResponse>(response);
        }

        public AsyncInvoker<CreateOtaPackageResponse> CreateOtaPackageAsyncInvoker(CreateOtaPackageRequest createOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaPackageRequest);
            return new AsyncInvoker<CreateOtaPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOtaPackageResponse>);
        }
        
        /// <summary>
        /// 删除OTA升级包
        ///
        /// 用户可调用此接口删除关联OBS对象的升级包信息，不会删除OBS上对象
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOtaPackageResponse> DeleteOtaPackageAsync(DeleteOtaPackageRequest deleteOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", deleteOtaPackageRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaPackageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOtaPackageResponse>(response);
        }

        public AsyncInvoker<DeleteOtaPackageResponse> DeleteOtaPackageAsyncInvoker(DeleteOtaPackageRequest deleteOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", deleteOtaPackageRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaPackageRequest);
            return new AsyncInvoker<DeleteOtaPackageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOtaPackageResponse>);
        }
        
        /// <summary>
        /// 查询OTA升级包列表
        ///
        /// 用户可调用此接口查询关联OBS对象的升级包列表
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOtaPackageInfoResponse> ListOtaPackageInfoAsync(ListOtaPackageInfoRequest listOtaPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaPackageInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOtaPackageInfoResponse>(response);
        }

        public AsyncInvoker<ListOtaPackageInfoResponse> ListOtaPackageInfoAsyncInvoker(ListOtaPackageInfoRequest listOtaPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaPackageInfoRequest);
            return new AsyncInvoker<ListOtaPackageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOtaPackageInfoResponse>);
        }
        
        /// <summary>
        /// 获取OTA升级包详情
        ///
        /// 用户可调用此接口查询关联OBS对象的升级包详情
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOtaPackageResponse> ShowOtaPackageAsync(ShowOtaPackageRequest showOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", showOtaPackageRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaPackageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOtaPackageResponse>(response);
        }

        public AsyncInvoker<ShowOtaPackageResponse> ShowOtaPackageAsyncInvoker(ShowOtaPackageRequest showOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", showOtaPackageRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaPackageRequest);
            return new AsyncInvoker<ShowOtaPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOtaPackageResponse>);
        }
        
        /// <summary>
        /// 创建产品
        ///
        /// 应用服务器可调用此接口创建产品。此接口仅创建了产品，没有创建和安装插件，如果需要对数据进行编解码，还需要在平台开发和安装插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
        }

        public AsyncInvoker<CreateProductResponse> CreateProductAsyncInvoker(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            return new AsyncInvoker<CreateProductResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProductResponse>);
        }
        
        /// <summary>
        /// 删除产品
        ///
        /// 应用服务器可调用此接口删除已导入物联网平台的指定产品模型。此接口仅删除了产品，未删除关联的插件，在产品下存在设备时，该产品不允许删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
        }

        public AsyncInvoker<DeleteProductResponse> DeleteProductAsyncInvoker(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            return new AsyncInvoker<DeleteProductResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProductResponse>);
        }
        
        /// <summary>
        /// 查询产品列表
        ///
        /// 应用服务器可调用此接口查询已导入物联网平台的产品模型信息列表，了解产品模型的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public AsyncInvoker<ListProductsResponse> ListProductsAsyncInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new AsyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 查询产品
        ///
        /// 应用服务器可调用此接口查询已导入物联网平台的指定产品模型详细信息，包括产品模型的服务、属性、命令等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProductResponse> ShowProductAsync(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }

        public AsyncInvoker<ShowProductResponse> ShowProductAsyncInvoker(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            return new AsyncInvoker<ShowProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProductResponse>);
        }
        
        /// <summary>
        /// 修改产品
        ///
        /// 应用服务器可调用此接口修改已导入物联网平台的指定产品模型，包括产品模型的服务、属性、命令等。此接口仅修改了产品，未修改和安装插件，如果修改了产品中的service定义，且在平台中有对应的插件，请修改并重新安装插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProductResponse>(response);
        }

        public AsyncInvoker<UpdateProductResponse> UpdateProductAsyncInvoker(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            return new AsyncInvoker<UpdateProductResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProductResponse>);
        }
        
        /// <summary>
        /// 查询设备属性
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的属性，应用服务器可调用此接口向设备发送指令用以查询设备的实时属性, 并由设备将属性查询的结果同步返回给应用服务器。
        /// 注意：此接口适用于MQTT设备，暂不支持NB-IoT设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPropertiesResponse> ListPropertiesAsync(ListPropertiesRequest listPropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", listPropertiesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPropertiesResponse>(response);
        }

        public AsyncInvoker<ListPropertiesResponse> ListPropertiesAsyncInvoker(ListPropertiesRequest listPropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", listPropertiesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            return new AsyncInvoker<ListPropertiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPropertiesResponse>);
        }
        
        /// <summary>
        /// 修改设备属性
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的属性，应用服务器可调用此接口向指定设备下发属性。平台负责将属性以同步方式发送给设备，并将设备执行属性结果同步返回。
        /// 注意：此接口适用于MQTT设备，暂不支持NB-IoT设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePropertiesResponse> UpdatePropertiesAsync(UpdatePropertiesRequest updatePropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updatePropertiesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePropertiesResponse>(response);
        }

        public AsyncInvoker<UpdatePropertiesResponse> UpdatePropertiesAsyncInvoker(UpdatePropertiesRequest updatePropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id", updatePropertiesRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            return new AsyncInvoker<UpdatePropertiesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePropertiesResponse>);
        }
        
        /// <summary>
        /// 创建规则触发条件
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则触发条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRoutingRuleResponse> CreateRoutingRuleAsync(CreateRoutingRuleRequest createRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRoutingRuleResponse>(response);
        }

        public AsyncInvoker<CreateRoutingRuleResponse> CreateRoutingRuleAsyncInvoker(CreateRoutingRuleRequest createRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            return new AsyncInvoker<CreateRoutingRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 创建规则动作
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRuleActionResponse> CreateRuleActionAsync(CreateRuleActionRequest createRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleActionResponse>(response);
        }

        public AsyncInvoker<CreateRuleActionResponse> CreateRuleActionAsyncInvoker(CreateRuleActionRequest createRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            return new AsyncInvoker<CreateRuleActionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleActionResponse>);
        }
        
        /// <summary>
        /// 删除规则触发条件
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRoutingRuleResponse> DeleteRoutingRuleAsync(DeleteRoutingRuleRequest deleteRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRoutingRuleResponse> DeleteRoutingRuleAsyncInvoker(DeleteRoutingRuleRequest deleteRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            return new AsyncInvoker<DeleteRoutingRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则动作
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleActionResponse> DeleteRuleActionAsync(DeleteRuleActionRequest deleteRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", deleteRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleActionResponse>(response);
        }

        public AsyncInvoker<DeleteRuleActionResponse> DeleteRuleActionAsyncInvoker(DeleteRuleActionRequest deleteRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", deleteRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            return new AsyncInvoker<DeleteRuleActionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleActionResponse>);
        }
        
        /// <summary>
        /// 查询规则条件列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则条件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRoutingRulesResponse> ListRoutingRulesAsync(ListRoutingRulesRequest listRoutingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRoutingRulesResponse>(response);
        }

        public AsyncInvoker<ListRoutingRulesResponse> ListRoutingRulesAsyncInvoker(ListRoutingRulesRequest listRoutingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            return new AsyncInvoker<ListRoutingRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRoutingRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则动作列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则动作列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleActionsResponse> ListRuleActionsAsync(ListRuleActionsRequest listRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRuleActionsResponse>(response);
        }

        public AsyncInvoker<ListRuleActionsResponse> ListRuleActionsAsyncInvoker(ListRuleActionsRequest listRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            return new AsyncInvoker<ListRuleActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleActionsResponse>);
        }
        
        /// <summary>
        /// 查询规则条件
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则条件的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRoutingRuleResponse> ShowRoutingRuleAsync(ShowRoutingRuleRequest showRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRoutingRuleResponse>(response);
        }

        public AsyncInvoker<ShowRoutingRuleResponse> ShowRoutingRuleAsyncInvoker(ShowRoutingRuleRequest showRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            return new AsyncInvoker<ShowRoutingRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 查询规则动作
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则动作的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRuleActionResponse> ShowRuleActionAsync(ShowRuleActionRequest showRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", showRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleActionResponse>(response);
        }

        public AsyncInvoker<ShowRuleActionResponse> ShowRuleActionAsyncInvoker(ShowRuleActionRequest showRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", showRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            return new AsyncInvoker<ShowRuleActionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleActionResponse>);
        }
        
        /// <summary>
        /// 修改规则触发条件
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则条件的配置参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRoutingRuleResponse> UpdateRoutingRuleAsync(UpdateRoutingRuleRequest updateRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRoutingRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRoutingRuleResponse> UpdateRoutingRuleAsyncInvoker(UpdateRoutingRuleRequest updateRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateRoutingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            return new AsyncInvoker<UpdateRoutingRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 修改规则动作
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则动作的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleActionResponse> UpdateRuleActionAsync(UpdateRuleActionRequest updateRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", updateRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleActionResponse>(response);
        }

        public AsyncInvoker<UpdateRuleActionResponse> UpdateRuleActionAsyncInvoker(UpdateRuleActionRequest updateRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id", updateRuleActionRequest.ActionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            return new AsyncInvoker<UpdateRuleActionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleActionResponse>);
        }
        
        /// <summary>
        /// 修改规则状态
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则的状态，激活或者去激活规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeRuleStatusResponse> ChangeRuleStatusAsync(ChangeRuleStatusRequest changeRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", changeRuleStatusRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeRuleStatusResponse>(response);
        }

        public AsyncInvoker<ChangeRuleStatusResponse> ChangeRuleStatusAsyncInvoker(ChangeRuleStatusRequest changeRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", changeRuleStatusRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            return new AsyncInvoker<ChangeRuleStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeRuleStatusResponse>);
        }
        
        /// <summary>
        /// 创建规则
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public AsyncInvoker<CreateRuleResponse> CreateRuleAsyncInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            return new AsyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRuleResponse> DeleteRuleAsyncInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new AsyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 查询规则列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }

        public AsyncInvoker<ListRulesResponse> ListRulesAsyncInvoker(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            return new AsyncInvoker<ListRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRuleResponse> ShowRuleAsync(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }

        public AsyncInvoker<ShowRuleResponse> ShowRuleAsyncInvoker(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            return new AsyncInvoker<ShowRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleResponse>);
        }
        
        /// <summary>
        /// 修改规则
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRuleResponse> UpdateRuleAsyncInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            return new AsyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 按标签查询资源
        ///
        /// 应用服务器可调用此接口查询绑定了指定标签的资源。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourcesByTagsResponse> ListResourcesByTagsAsync(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagsResponse>(response);
        }

        public AsyncInvoker<ListResourcesByTagsResponse> ListResourcesByTagsAsyncInvoker(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            return new AsyncInvoker<ListResourcesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagsResponse>);
        }
        
        /// <summary>
        /// 绑定标签
        ///
        /// 应用服务器可调用此接口为指定资源绑定标签。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagDeviceResponse> TagDeviceAsync(TagDeviceRequest tagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagDeviceResponse>(response);
        }

        public AsyncInvoker<TagDeviceResponse> TagDeviceAsyncInvoker(TagDeviceRequest tagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            return new AsyncInvoker<TagDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagDeviceResponse>);
        }
        
        /// <summary>
        /// 解绑标签
        ///
        /// 应用服务器可调用此接口为指定资源解绑标签。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UntagDeviceResponse> UntagDeviceAsync(UntagDeviceRequest untagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UntagDeviceResponse>(response);
        }

        public AsyncInvoker<UntagDeviceResponse> UntagDeviceAsyncInvoker(UntagDeviceRequest untagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            return new AsyncInvoker<UntagDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagDeviceResponse>);
        }
        
        /// <summary>
        /// 创建设备隧道
        ///
        /// 用户可以通过该接口创建隧道（WebSocket协议），应用服务器和设备可以通过该隧道进行数据传输。
        /// 
        /// - 该API接口在基础版不支持。
        /// - 该API调用后平台会向对应的MQTT/MQTTS设备下发隧道地址及密钥，同时给应用服务器也返回隧道地址及密钥，设备可以通过该地址及密钥创建WebSocket协议连接。
        /// - 一个设备无法创建多个隧道。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddTunnelResponse> AddTunnelAsync(AddTunnelRequest addTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTunnelRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddTunnelResponse>(response);
        }

        public AsyncInvoker<AddTunnelResponse> AddTunnelAsyncInvoker(AddTunnelRequest addTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTunnelRequest);
            return new AsyncInvoker<AddTunnelResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTunnelResponse>);
        }
        
        /// <summary>
        /// 关闭设备隧道
        ///
        /// 应用服务器可通过该接口关闭某个设备隧道。关闭后可以再次连接。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CloseDeviceTunnelResponse> CloseDeviceTunnelAsync(CloseDeviceTunnelRequest closeDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", closeDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeDeviceTunnelRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CloseDeviceTunnelResponse>(response);
        }

        public AsyncInvoker<CloseDeviceTunnelResponse> CloseDeviceTunnelAsyncInvoker(CloseDeviceTunnelRequest closeDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", closeDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeDeviceTunnelRequest);
            return new AsyncInvoker<CloseDeviceTunnelResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CloseDeviceTunnelResponse>);
        }
        
        /// <summary>
        /// 删除设备隧道
        ///
        /// 用户可通过该接口删除某个设备隧道。删除后该通道不存在，无法再次连接。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeviceTunnelResponse> DeleteDeviceTunnelAsync(DeleteDeviceTunnelRequest deleteDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", deleteDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceTunnelRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceTunnelResponse>(response);
        }

        public AsyncInvoker<DeleteDeviceTunnelResponse> DeleteDeviceTunnelAsyncInvoker(DeleteDeviceTunnelRequest deleteDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", deleteDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceTunnelRequest);
            return new AsyncInvoker<DeleteDeviceTunnelResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceTunnelResponse>);
        }
        
        /// <summary>
        /// 查询设备所有隧道
        ///
        /// 用户可通过该接口查询某项目下的所有设备隧道，以实现对设备管理。应用服务器可通过此接口向平台查询设备隧道建立的情况。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDeviceTunnelsResponse> ListDeviceTunnelsAsync(ListDeviceTunnelsRequest listDeviceTunnelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceTunnelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceTunnelsResponse>(response);
        }

        public AsyncInvoker<ListDeviceTunnelsResponse> ListDeviceTunnelsAsyncInvoker(ListDeviceTunnelsRequest listDeviceTunnelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceTunnelsRequest);
            return new AsyncInvoker<ListDeviceTunnelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceTunnelsResponse>);
        }
        
        /// <summary>
        /// 查询设备隧道
        ///
        /// 用户可通过该接口查询某项目中的某个设备隧道，查看该设备隧道的信息与连接情况。应用服务器可调用此接口向平台查询设备隧道建立情况。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceTunnelResponse> ShowDeviceTunnelAsync(ShowDeviceTunnelRequest showDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", showDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTunnelRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceTunnelResponse>(response);
        }

        public AsyncInvoker<ShowDeviceTunnelResponse> ShowDeviceTunnelAsyncInvoker(ShowDeviceTunnelRequest showDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tunnel_id", showDeviceTunnelRequest.TunnelId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTunnelRequest);
            return new AsyncInvoker<ShowDeviceTunnelResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceTunnelResponse>);
        }
        
    }
}