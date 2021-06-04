using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IoTDA.V5.Model;

namespace HuaweiCloud.SDK.IoTDA.V5
{
    public partial class IoTDAClient : Client
    {
        public static ClientBuilder<IoTDAClient> NewBuilder()
        {
            return new ClientBuilder<IoTDAClient>();
        }

        
        /// <summary>
        /// 生成接入凭证
        /// </summary>
        public CreateAccessCodeResponse CreateAccessCode(CreateAccessCodeRequest createAccessCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAccessCodeResponse>(response);
        }
        
        /// <summary>
        /// 创建AMQP队列
        /// </summary>
        public AddQueueResponse AddQueue(AddQueueRequest addQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddQueueResponse>(response);
        }
        
        /// <summary>
        /// 查询AMQP列表
        /// </summary>
        public BatchShowQueueResponse BatchShowQueue(BatchShowQueueRequest batchShowQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<BatchShowQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除AMQP队列
        /// </summary>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest deleteQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteQueueResponse deleteQueueResponse = JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
            return deleteQueueResponse;
        }
        
        /// <summary>
        /// 查询单个AMQP队列
        /// </summary>
        public ShowQueueResponse ShowQueue(ShowQueueRequest showQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }
        
        /// <summary>
        /// 创建资源空间
        /// </summary>
        public AddApplicationResponse AddApplication(AddApplicationRequest addApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddApplicationResponse>(response);
        }
        
        /// <summary>
        /// 删除资源空间
        /// </summary>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteApplicationResponse deleteApplicationResponse = JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
            return deleteApplicationResponse;
        }
        
        /// <summary>
        /// 查询资源空间
        /// </summary>
        public ShowApplicationResponse ShowApplication(ShowApplicationRequest showApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
        }
        
        /// <summary>
        /// 查询资源空间列表
        /// </summary>
        public ShowApplicationsResponse ShowApplications(ShowApplicationsRequest showApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
        }
        
        /// <summary>
        /// 下发异步设备命令
        /// </summary>
        public CreateAsyncCommandResponse CreateAsyncCommand(CreateAsyncCommandRequest createAsyncCommandRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createAsyncCommandRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAsyncCommandResponse>(response);
        }
        
        /// <summary>
        /// 查询指定id的命令
        /// </summary>
        public ShowAsyncDeviceCommandResponse ShowAsyncDeviceCommand(ShowAsyncDeviceCommandRequest showAsyncDeviceCommandRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showAsyncDeviceCommandRequest.DeviceId.ToString());
            urlParam.Add("command_id" , showAsyncDeviceCommandRequest.CommandId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>(response);
        }
        
        /// <summary>
        /// 创建批量任务
        /// </summary>
        public CreateBatchTaskResponse CreateBatchTask(CreateBatchTaskRequest createBatchTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateBatchTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询批量任务列表
        /// </summary>
        public ListBatchTasksResponse ListBatchTasks(ListBatchTasksRequest listBatchTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBatchTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询批量任务
        /// </summary>
        public ShowBatchTaskResponse ShowBatchTask(ShowBatchTaskRequest showBatchTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showBatchTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除批量任务文件
        /// </summary>
        public DeleteBatchTaskFileResponse DeleteBatchTaskFile(DeleteBatchTaskFileRequest deleteBatchTaskFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id" , deleteBatchTaskFileRequest.FileId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteBatchTaskFileResponse deleteBatchTaskFileResponse = JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>(response);
            return deleteBatchTaskFileResponse;
        }
        
        /// <summary>
        /// 查询批量任务文件列表
        /// </summary>
        public ListBatchTaskFilesResponse ListBatchTaskFiles(ListBatchTaskFilesRequest listBatchTaskFilesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBatchTaskFilesResponse>(response);
        }
        
        /// <summary>
        /// 上传设备CA证书
        /// </summary>
        public AddCertificateResponse AddCertificate(AddCertificateRequest addCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddCertificateResponse>(response);
        }
        
        /// <summary>
        /// 验证设备CA证书
        /// </summary>
        public CheckCertificateResponse CheckCertificate(CheckCertificateRequest checkCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , checkCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CheckCertificateResponse checkCertificateResponse = JsonUtils.DeSerializeNull<CheckCertificateResponse>(response);
            return checkCertificateResponse;
        }
        
        /// <summary>
        /// 删除设备CA证书
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteCertificateResponse deleteCertificateResponse = JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
            return deleteCertificateResponse;
        }
        
        /// <summary>
        /// 获取设备CA证书列表
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 下发设备命令
        /// </summary>
        public CreateCommandResponse CreateCommand(CreateCommandRequest createCommandRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createCommandRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCommandResponse>(response);
        }
        
        /// <summary>
        /// 添加设备组
        /// </summary>
        public AddDeviceGroupResponse AddDeviceGroup(AddDeviceGroupRequest addDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddDeviceGroupResponse>(response);
        }
        
        /// <summary>
        /// 管理设备组中的设备
        /// </summary>
        public CreateOrDeleteDeviceInGroupResponse CreateOrDeleteDeviceInGroup(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createOrDeleteDeviceInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateOrDeleteDeviceInGroupResponse createOrDeleteDeviceInGroupResponse = JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
            return createOrDeleteDeviceInGroupResponse;
        }
        
        /// <summary>
        /// 删除设备组
        /// </summary>
        public DeleteDeviceGroupResponse DeleteDeviceGroup(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteDeviceGroupResponse deleteDeviceGroupResponse = JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
            return deleteDeviceGroupResponse;
        }
        
        /// <summary>
        /// 查询设备组列表
        /// </summary>
        public ListDeviceGroupsResponse ListDeviceGroups(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询设备组
        /// </summary>
        public ShowDeviceGroupResponse ShowDeviceGroup(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询设备组设备列表
        /// </summary>
        public ShowDevicesInGroupResponse ShowDevicesInGroup(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDevicesInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDevicesInGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改设备组
        /// </summary>
        public UpdateDeviceGroupResponse UpdateDeviceGroup(UpdateDeviceGroupRequest updateDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建设备
        /// </summary>
        public AddDeviceResponse AddDevice(AddDeviceRequest addDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
        }
        
        /// <summary>
        /// 删除设备
        /// </summary>
        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest deleteDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , deleteDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteDeviceResponse deleteDeviceResponse = JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
            return deleteDeviceResponse;
        }
        
        /// <summary>
        /// 冻结设备
        /// </summary>
        public FreezeDeviceResponse FreezeDevice(FreezeDeviceRequest freezeDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , freezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            FreezeDeviceResponse freezeDeviceResponse = JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
            return freezeDeviceResponse;
        }
        
        /// <summary>
        /// 查询设备列表
        /// </summary>
        public ListDevicesResponse ListDevices(ListDevicesRequest listDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDevicesResponse>(response);
        }
        
        /// <summary>
        /// 重置设备密钥
        /// </summary>
        public ResetDeviceSecretResponse ResetDeviceSecret(ResetDeviceSecretRequest resetDeviceSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , resetDeviceSecretRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResetDeviceSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询设备
        /// </summary>
        public ShowDeviceResponse ShowDevice(ShowDeviceRequest showDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceResponse>(response);
        }
        
        /// <summary>
        /// 解冻设备
        /// </summary>
        public UnfreezeDeviceResponse UnfreezeDevice(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , unfreezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            UnfreezeDeviceResponse unfreezeDeviceResponse = JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
            return unfreezeDeviceResponse;
        }
        
        /// <summary>
        /// 修改设备
        /// </summary>
        public UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest updateDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updateDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceResponse>(response);
        }
        
        /// <summary>
        /// 查询设备影子数据
        /// </summary>
        public ShowDeviceShadowResponse ShowDeviceShadow(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceShadowRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceShadowResponse>(response);
        }
        
        /// <summary>
        /// 配置设备影子预期数据
        /// </summary>
        public UpdateDeviceShadowDesiredDataResponse UpdateDeviceShadowDesiredData(UpdateDeviceShadowDesiredDataRequest updateDeviceShadowDesiredDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updateDeviceShadowDesiredDataRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>(response);
        }
        
        /// <summary>
        /// 下发设备消息
        /// </summary>
        public CreateMessageResponse CreateMessage(CreateMessageRequest createMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , createMessageRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询设备消息
        /// </summary>
        public ListDeviceMessagesResponse ListDeviceMessages(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listDeviceMessagesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定消息id的消息
        /// </summary>
        public ShowDeviceMessageResponse ShowDeviceMessage(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceMessageRequest.DeviceId.ToString());
            urlParam.Add("message_id" , showDeviceMessageRequest.MessageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceMessageResponse>(response);
        }
        
        /// <summary>
        /// 创建产品
        /// </summary>
        public CreateProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
        }
        
        /// <summary>
        /// 删除产品
        /// </summary>
        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , deleteProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteProductResponse deleteProductResponse = JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
            return deleteProductResponse;
        }
        
        /// <summary>
        /// 查询产品列表
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }
        
        /// <summary>
        /// 查询产品
        /// </summary>
        public ShowProductResponse ShowProduct(ShowProductRequest showProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , showProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }
        
        /// <summary>
        /// 修改产品
        /// </summary>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , updateProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProductResponse>(response);
        }
        
        /// <summary>
        /// 查询设备属性
        /// </summary>
        public ListPropertiesResponse ListProperties(ListPropertiesRequest listPropertiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listPropertiesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPropertiesResponse>(response);
        }
        
        /// <summary>
        /// 修改设备属性
        /// </summary>
        public UpdatePropertiesResponse UpdateProperties(UpdatePropertiesRequest updatePropertiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , updatePropertiesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePropertiesResponse>(response);
        }
        
        /// <summary>
        /// 创建规则触发条件
        /// </summary>
        public CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest createRoutingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRoutingRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建规则动作
        /// </summary>
        public CreateRuleActionResponse CreateRuleAction(CreateRuleActionRequest createRuleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRuleActionResponse>(response);
        }
        
        /// <summary>
        /// 删除规则触发条件
        /// </summary>
        public DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest deleteRoutingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , deleteRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteRoutingRuleResponse deleteRoutingRuleResponse = JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>(response);
            return deleteRoutingRuleResponse;
        }
        
        /// <summary>
        /// 删除规则动作
        /// </summary>
        public DeleteRuleActionResponse DeleteRuleAction(DeleteRuleActionRequest deleteRuleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , deleteRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteRuleActionResponse deleteRuleActionResponse = JsonUtils.DeSerializeNull<DeleteRuleActionResponse>(response);
            return deleteRuleActionResponse;
        }
        
        /// <summary>
        /// 查询规则条件列表
        /// </summary>
        public ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest listRoutingRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRoutingRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询规则动作列表
        /// </summary>
        public ListRuleActionsResponse ListRuleActions(ListRuleActionsRequest listRuleActionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRuleActionsResponse>(response);
        }
        
        /// <summary>
        /// 查询规则条件
        /// </summary>
        public ShowRoutingRuleResponse ShowRoutingRule(ShowRoutingRuleRequest showRoutingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRoutingRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询规则动作
        /// </summary>
        public ShowRuleActionResponse ShowRuleAction(ShowRuleActionRequest showRuleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , showRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRuleActionResponse>(response);
        }
        
        /// <summary>
        /// 修改规则触发条件
        /// </summary>
        public UpdateRoutingRuleResponse UpdateRoutingRule(UpdateRoutingRuleRequest updateRoutingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , updateRoutingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRoutingRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改规则动作
        /// </summary>
        public UpdateRuleActionResponse UpdateRuleAction(UpdateRuleActionRequest updateRuleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("action_id" , updateRuleActionRequest.ActionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleActionResponse>(response);
        }
        
        /// <summary>
        /// 修改规则状态
        /// </summary>
        public ChangeRuleStatusResponse ChangeRuleStatus(ChangeRuleStatusRequest changeRuleStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , changeRuleStatusRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ChangeRuleStatusResponse>(response);
        }
        
        /// <summary>
        /// 创建规则
        /// </summary>
        public CreateRuleResponse CreateRule(CreateRuleRequest createRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除规则
        /// </summary>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest deleteRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , deleteRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteRuleResponse deleteRuleResponse = JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
            return deleteRuleResponse;
        }
        
        /// <summary>
        /// 查询规则列表
        /// </summary>
        public ListRulesResponse ListRules(ListRulesRequest listRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询规则
        /// </summary>
        public ShowRuleResponse ShowRule(ShowRuleRequest showRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改规则
        /// </summary>
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest updateRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , updateRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询资源
        /// </summary>
        public ListResourcesByTagsResponse ListResourcesByTags(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourcesByTagsResponse>(response);
        }
        
        /// <summary>
        /// 绑定标签
        /// </summary>
        public TagDeviceResponse TagDevice(TagDeviceRequest tagDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            TagDeviceResponse tagDeviceResponse = JsonUtils.DeSerializeNull<TagDeviceResponse>(response);
            return tagDeviceResponse;
        }
        
        /// <summary>
        /// 解绑标签
        /// </summary>
        public UntagDeviceResponse UntagDevice(UntagDeviceRequest untagDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            UntagDeviceResponse untagDeviceResponse = JsonUtils.DeSerializeNull<UntagDeviceResponse>(response);
            return untagDeviceResponse;
        }
        
    }
}