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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAccessCodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddQueueResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<BatchShowQueueResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteQueueResponse deleteQueueResponse = JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
            return deleteQueueResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddApplicationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteApplicationResponse deleteApplicationResponse = JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
            return deleteApplicationResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createAsyncCommandRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAsyncCommandResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showAsyncDeviceCommandRequest.DeviceId.ToString());
            urlParam.Add("command_id" , showAsyncDeviceCommandRequest.CommandId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateBatchTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBatchTasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showBatchTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id" , deleteBatchTaskFileRequest.FileId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteBatchTaskFileResponse deleteBatchTaskFileResponse = JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>(response);
            return deleteBatchTaskFileResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBatchTaskFilesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBatchTaskFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadBatchTaskFileResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/broadcast-messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BroadcastMessageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddCertificateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , checkCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CheckCertificateResponse checkCertificateResponse = JsonUtils.DeSerializeNull<CheckCertificateResponse>(response);
            return checkCertificateResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteCertificateResponse deleteCertificateResponse = JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
            return deleteCertificateResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createCommandRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCommandResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddDeviceGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createOrDeleteDeviceInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateOrDeleteDeviceInGroupResponse createOrDeleteDeviceInGroupResponse = JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
            return createOrDeleteDeviceInGroupResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteDeviceGroupResponse deleteDeviceGroupResponse = JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
            return deleteDeviceGroupResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDevicesInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDevicesInGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , deleteDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteDeviceResponse deleteDeviceResponse = JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
            return deleteDeviceResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , freezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            FreezeDeviceResponse freezeDeviceResponse = JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
            return freezeDeviceResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDevicesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , resetDeviceSecretRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResetDeviceSecretResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , resetFingerprintRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/reset-fingerprint",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetFingerprintRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResetFingerprintResponse>(response);
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
        /// | device_id   | string | 设备ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合，建议不少于4个字符。 |
        /// | gateway_id  | string | 网关ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | product_id  | string | 设备关联的产品ID | 长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | device_name | string | 设备名称         | 长度不超过256，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合，建议不少于4个字符。 |
        /// | node_id     | string | 设备标识码       | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）的组合，建议不少于4个字符 |
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/search/query-devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchDevicesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , unfreezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            UnfreezeDeviceResponse unfreezeDeviceResponse = JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
            return unfreezeDeviceResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updateDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceShadowRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceShadowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updateDeviceShadowDesiredDataRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createMessageRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listDeviceMessagesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceMessagesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceMessageRequest.DeviceId.ToString());
            urlParam.Add("message_id" , showDeviceMessageRequest.MessageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceMessageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaPackageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateOtaPackageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , deleteOtaPackageRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaPackageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteOtaPackageResponse deleteOtaPackageResponse = JsonUtils.DeSerializeNull<DeleteOtaPackageResponse>(response);
            return deleteOtaPackageResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaPackageInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOtaPackageInfoResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , showOtaPackageRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaPackageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOtaPackageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , deleteProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteProductResponse deleteProductResponse = JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
            return deleteProductResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , showProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , updateProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProductResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listPropertiesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPropertiesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updatePropertiesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePropertiesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRoutingRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRuleActionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , deleteRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteRoutingRuleResponse deleteRoutingRuleResponse = JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>(response);
            return deleteRoutingRuleResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , deleteRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteRuleActionResponse deleteRuleActionResponse = JsonUtils.DeSerializeNull<DeleteRuleActionResponse>(response);
            return deleteRuleActionResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRoutingRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRuleActionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRoutingRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , showRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRuleActionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , updateRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRoutingRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , updateRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleActionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , changeRuleStatusRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ChangeRuleStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , deleteRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteRuleResponse deleteRuleResponse = JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
            return deleteRuleResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , updateRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourcesByTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            TagDeviceResponse tagDeviceResponse = JsonUtils.DeSerializeNull<TagDeviceResponse>(response);
            return tagDeviceResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            UntagDeviceResponse untagDeviceResponse = JsonUtils.DeSerializeNull<UntagDeviceResponse>(response);
            return untagDeviceResponse;
        }
        
    }
}