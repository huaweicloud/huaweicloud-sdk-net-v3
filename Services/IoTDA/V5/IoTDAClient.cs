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
        /// 创建资源空间
        /// </summary>
        public AddApplicationResponse AddApplication(AddApplicationRequest addApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteApplicationRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteApplicationResponse deleteApplicationResponse = JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
            deleteApplicationResponse.Body = response.GetHttpBody();
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApplicationRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
        }
        
        /// <summary>
        /// 查询资源空间列表
        /// </summary>
        public ShowApplicationsResponse ShowApplications(ShowApplicationsRequest showApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApplicationsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
        }
        
        /// <summary>
        /// 创建批量任务
        /// </summary>
        public CreateBatchTaskResponse CreateBatchTask(CreateBatchTaskRequest createBatchTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateBatchTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询批量任务列表
        /// </summary>
        public ListBatchTasksResponse ListBatchTasks(ListBatchTasksRequest listBatchTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBatchTasksRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBatchTaskRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
        }
        
        /// <summary>
        /// 上传设备CA证书
        /// </summary>
        public AddCertificateResponse AddCertificate(AddCertificateRequest addCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
            CheckCertificateResponse checkCertificateResponse = JsonUtils.DeSerializeNull<CheckCertificateResponse>(response);
            checkCertificateResponse.Body = response.GetHttpBody();
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteCertificateRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteCertificateResponse deleteCertificateResponse = JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
            deleteCertificateResponse.Body = response.GetHttpBody();
            return deleteCertificateResponse;
        }
        
        /// <summary>
        /// 获取设备CA证书列表
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCertificatesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, createOrDeleteDeviceInGroupRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            CreateOrDeleteDeviceInGroupResponse createOrDeleteDeviceInGroupResponse = JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
            createOrDeleteDeviceInGroupResponse.Body = response.GetHttpBody();
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteDeviceGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteDeviceGroupResponse deleteDeviceGroupResponse = JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
            deleteDeviceGroupResponse.Body = response.GetHttpBody();
            return deleteDeviceGroupResponse;
        }
        
        /// <summary>
        /// 查询设备组列表
        /// </summary>
        public ListDeviceGroupsResponse ListDeviceGroups(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDeviceGroupsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDevicesInGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteDeviceRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteDeviceResponse deleteDeviceResponse = JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
            deleteDeviceResponse.Body = response.GetHttpBody();
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, freezeDeviceRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            FreezeDeviceResponse freezeDeviceResponse = JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
            freezeDeviceResponse.Body = response.GetHttpBody();
            return freezeDeviceResponse;
        }
        
        /// <summary>
        /// 查询设备列表
        /// </summary>
        public ListDevicesResponse ListDevices(ListDevicesRequest listDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDevicesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, unfreezeDeviceRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            UnfreezeDeviceResponse unfreezeDeviceResponse = JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
            unfreezeDeviceResponse.Body = response.GetHttpBody();
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceShadowRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDeviceMessagesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceMessageRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteProductRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteProductResponse deleteProductResponse = JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
            deleteProductResponse.Body = response.GetHttpBody();
            return deleteProductResponse;
        }
        
        /// <summary>
        /// 查询产品列表
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProductsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProductRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPropertiesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePropertiesResponse>(response);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteRuleRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteRuleResponse deleteRuleResponse = JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
            deleteRuleResponse.Body = response.GetHttpBody();
            return deleteRuleResponse;
        }
        
        /// <summary>
        /// 查询规则列表
        /// </summary>
        public ListRulesResponse ListRules(ListRulesRequest listRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listRulesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showRuleRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建订阅
        /// </summary>
        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest createSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 删除订阅
        /// </summary>
        public DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest deleteSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , deleteSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSubscriptionRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            DeleteSubscriptionResponse deleteSubscriptionResponse = JsonUtils.DeSerializeNull<DeleteSubscriptionResponse>(response);
            deleteSubscriptionResponse.Body = response.GetHttpBody();
            return deleteSubscriptionResponse;
        }
        
        /// <summary>
        /// 查询订阅列表
        /// </summary>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSubscriptionsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }
        
        /// <summary>
        /// 查询订阅
        /// </summary>
        public ShowSubscriptionResponse ShowSubscription(ShowSubscriptionRequest showSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , showSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSubscriptionRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 修改订阅
        /// </summary>
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , updateSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询资源
        /// </summary>
        public ListResourcesByTagsResponse ListResourcesByTags(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
            TagDeviceResponse tagDeviceResponse = JsonUtils.DeSerializeNull<TagDeviceResponse>(response);
            tagDeviceResponse.Body = response.GetHttpBody();
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
            SdkResponse response = DoHttpRequestSync("POST",request);
            UntagDeviceResponse untagDeviceResponse = JsonUtils.DeSerializeNull<UntagDeviceResponse>(response);
            untagDeviceResponse.Body = response.GetHttpBody();
            return untagDeviceResponse;
        }
        
    }
}