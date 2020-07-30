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
            return new ClientBuilder<IoTDAAsyncClient>();
        }

        
        /// <summary>
        /// 创建资源空间
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
        /// </summary>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteApplicationResponse deleteApplicationResponse = JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
            return deleteApplicationResponse;
        }
        
        /// <summary>
        /// 查询资源空间
        /// </summary>
        public async Task<ShowApplicationResponse> ShowApplicationAsync(ShowApplicationRequest showApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
        }
        
        /// <summary>
        /// 查询资源空间列表
        /// </summary>
        public async Task<ShowApplicationsResponse> ShowApplicationsAsync(ShowApplicationsRequest showApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApplicationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
        }
        
        /// <summary>
        /// 创建批量任务
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
        /// </summary>
        public async Task<ListBatchTasksResponse> ListBatchTasksAsync(ListBatchTasksRequest listBatchTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBatchTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBatchTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询批量任务
        /// </summary>
        public async Task<ShowBatchTaskResponse> ShowBatchTaskAsync(ShowBatchTaskRequest showBatchTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showBatchTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBatchTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
        }
        
        /// <summary>
        /// 上传设备CA证书
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
        /// </summary>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteCertificateResponse deleteCertificateResponse = JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
            return deleteCertificateResponse;
        }
        
        /// <summary>
        /// 获取设备CA证书列表
        /// </summary>
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 下发设备命令
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
        /// </summary>
        public async Task<CreateOrDeleteDeviceInGroupResponse> CreateOrDeleteDeviceInGroupAsync(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createOrDeleteDeviceInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, createOrDeleteDeviceInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateOrDeleteDeviceInGroupResponse createOrDeleteDeviceInGroupResponse = JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
            return createOrDeleteDeviceInGroupResponse;
        }
        
        /// <summary>
        /// 删除设备组
        /// </summary>
        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupAsync(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteDeviceGroupResponse deleteDeviceGroupResponse = JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
            return deleteDeviceGroupResponse;
        }
        
        /// <summary>
        /// 查询设备组列表
        /// </summary>
        public async Task<ListDeviceGroupsResponse> ListDeviceGroupsAsync(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDeviceGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询设备组
        /// </summary>
        public async Task<ShowDeviceGroupResponse> ShowDeviceGroupAsync(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeviceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询设备组设备列表
        /// </summary>
        public async Task<ShowDevicesInGroupResponse> ShowDevicesInGroupAsync(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDevicesInGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDevicesInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDevicesInGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改设备组
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
        /// </summary>
        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest deleteDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , deleteDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteDeviceResponse deleteDeviceResponse = JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
            return deleteDeviceResponse;
        }
        
        /// <summary>
        /// 冻结设备
        /// </summary>
        public async Task<FreezeDeviceResponse> FreezeDeviceAsync(FreezeDeviceRequest freezeDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , freezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, freezeDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            FreezeDeviceResponse freezeDeviceResponse = JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
            return freezeDeviceResponse;
        }
        
        /// <summary>
        /// 查询设备列表
        /// </summary>
        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest listDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDevicesResponse>(response);
        }
        
        /// <summary>
        /// 重置设备密钥
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
        /// 查询设备
        /// </summary>
        public async Task<ShowDeviceResponse> ShowDeviceAsync(ShowDeviceRequest showDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceResponse>(response);
        }
        
        /// <summary>
        /// 解冻设备
        /// </summary>
        public async Task<UnfreezeDeviceResponse> UnfreezeDeviceAsync(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , unfreezeDeviceRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, unfreezeDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            UnfreezeDeviceResponse unfreezeDeviceResponse = JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
            return unfreezeDeviceResponse;
        }
        
        /// <summary>
        /// 修改设备
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
        /// </summary>
        public async Task<ShowDeviceShadowResponse> ShowDeviceShadowAsync(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceShadowRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceShadowRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceShadowResponse>(response);
        }
        
        /// <summary>
        /// 配置设备影子预期数据
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
        /// </summary>
        public async Task<ListDeviceMessagesResponse> ListDeviceMessagesAsync(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listDeviceMessagesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDeviceMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeviceMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定消息id的消息
        /// </summary>
        public async Task<ShowDeviceMessageResponse> ShowDeviceMessageAsync(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , showDeviceMessageRequest.DeviceId.ToString());
            urlParam.Add("message_id" , showDeviceMessageRequest.MessageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDeviceMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeviceMessageResponse>(response);
        }
        
        /// <summary>
        /// 创建产品
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
        /// </summary>
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , deleteProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteProductResponse deleteProductResponse = JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
            return deleteProductResponse;
        }
        
        /// <summary>
        /// 查询产品列表
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProductsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }
        
        /// <summary>
        /// 查询产品
        /// </summary>
        public async Task<ShowProductResponse> ShowProductAsync(ShowProductRequest showProductRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id" , showProductRequest.ProductId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProductRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }
        
        /// <summary>
        /// 修改产品
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
        /// </summary>
        public async Task<ListPropertiesResponse> ListPropertiesAsync(ListPropertiesRequest listPropertiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("device_id" , listPropertiesRequest.DeviceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPropertiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPropertiesResponse>(response);
        }
        
        /// <summary>
        /// 修改设备属性
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
        /// 修改规则状态
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
        /// </summary>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest deleteRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , deleteRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteRuleResponse deleteRuleResponse = JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
            return deleteRuleResponse;
        }
        
        /// <summary>
        /// 查询规则列表
        /// </summary>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest listRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询规则
        /// </summary>
        public async Task<ShowRuleResponse> ShowRuleAsync(ShowRuleRequest showRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改规则
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
        /// 创建订阅
        /// </summary>
        public async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest createSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 删除订阅
        /// </summary>
        public async Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest deleteSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , deleteSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteSubscriptionResponse deleteSubscriptionResponse = JsonUtils.DeSerializeNull<DeleteSubscriptionResponse>(response);
            return deleteSubscriptionResponse;
        }
        
        /// <summary>
        /// 查询订阅列表
        /// </summary>
        public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSubscriptionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }
        
        /// <summary>
        /// 查询订阅
        /// </summary>
        public async Task<ShowSubscriptionResponse> ShowSubscriptionAsync(ShowSubscriptionRequest showSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , showSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 修改订阅
        /// </summary>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_id" , updateSubscriptionRequest.SubscriptionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/subscriptions/{subscription_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询资源
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