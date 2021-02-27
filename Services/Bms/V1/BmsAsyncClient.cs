using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bms.V1.Model;

namespace HuaweiCloud.SDK.Bms.V1
{
    public partial class BmsAsyncClient : Client
    {
        public static ClientBuilder<BmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<BmsAsyncClient>();
        }

        
        /// <summary>
        /// 裸金属服务器挂载云硬盘
        /// </summary>
        public async Task<AttachBaremetalServerVolumeResponse> AttachBaremetalServerVolumeAsync(AttachBaremetalServerVolumeRequest attachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachBaremetalServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBaremetalServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 重启裸金属服务器
        /// </summary>
        public async Task<BatchRebootBaremetalServersResponse> BatchRebootBaremetalServersAsync(BatchRebootBaremetalServersRequest batchRebootBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 启动裸金属服务器
        /// </summary>
        public async Task<BatchStartBaremetalServersResponse> BatchStartBaremetalServersAsync(BatchStartBaremetalServersRequest batchStartBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 关闭裸金属服务器
        /// </summary>
        public async Task<BatchStopBaremetalServersResponse> BatchStopBaremetalServersAsync(BatchStopBaremetalServersRequest batchStopBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 修改裸金属服务器名称
        /// </summary>
        public async Task<ChangeBaremetalServerNameResponse> ChangeBaremetalServerNameAsync(ChangeBaremetalServerNameRequest changeBaremetalServerNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeBaremetalServerNameRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerNameResponse>(response);
        }
        
        /// <summary>
        /// 创建裸金属服务器
        /// </summary>
        public async Task<CreateBareMetalServersResponse> CreateBareMetalServersAsync(CreateBareMetalServersRequest createBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBareMetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器清除密码
        /// </summary>
        public async Task<DeleteWindowsBareMetalServerPasswordResponse> DeleteWindowsBareMetalServerPasswordAsync(DeleteWindowsBareMetalServerPasswordRequest deleteWindowsBareMetalServerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , deleteWindowsBareMetalServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWindowsBareMetalServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWindowsBareMetalServerPasswordResponse>(response);
        }
        
        /// <summary>
        /// 裸金属服务器卸载云磁盘
        /// </summary>
        public async Task<DetachBaremetalServerVolumeResponse> DetachBaremetalServerVolumeAsync(DetachBaremetalServerVolumeRequest detachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachBaremetalServerVolumeRequest.ServerId.ToString());
            urlParam.Add("attachment_id" , detachBaremetalServerVolumeRequest.AttachmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/detachvolume/{attachment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachBaremetalServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DetachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情
        /// </summary>
        public async Task<ListBareMetalServerDetailsResponse> ListBareMetalServerDetailsAsync(ListBareMetalServerDetailsRequest listBareMetalServerDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listBareMetalServerDetailsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServerDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServerDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情列表
        /// </summary>
        public async Task<ListBareMetalServersResponse> ListBareMetalServersAsync(ListBareMetalServersRequest listBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        /// </summary>
        public async Task<ListBaremetalFlavorDetailExtendsResponse> ListBaremetalFlavorDetailExtendsAsync(ListBaremetalFlavorDetailExtendsRequest listBaremetalFlavorDetailExtendsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBaremetalFlavorDetailExtendsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBaremetalFlavorDetailExtendsResponse>(response);
        }
        
        /// <summary>
        /// 重装裸金属服务器操作系统
        /// </summary>
        public async Task<ReinstallBaremetalServerOsResponse> ReinstallBaremetalServerOsAsync(ReinstallBaremetalServerOsRequest reinstallBaremetalServerOsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallBaremetalServerOsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallBaremetalServerOsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ReinstallBaremetalServerOsResponse>(response);
        }
        
        /// <summary>
        /// 一键重置裸金属服务器密码
        /// </summary>
        public async Task<ResetPwdOneClickResponse> ResetPwdOneClickAsync(ResetPwdOneClickRequest resetPwdOneClickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetPwdOneClickRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdOneClickRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetPwdOneClickResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器网卡信息
        /// </summary>
        public async Task<ShowBaremetalServerInterfaceAttachmentsResponse> ShowBaremetalServerInterfaceAttachmentsAsync(ShowBaremetalServerInterfaceAttachmentsRequest showBaremetalServerInterfaceAttachmentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerInterfaceAttachmentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerInterfaceAttachmentsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器挂载的云硬盘信息
        /// </summary>
        public async Task<ShowBaremetalServerVolumeInfoResponse> ShowBaremetalServerVolumeInfoAsync(ShowBaremetalServerVolumeInfoRequest showBaremetalServerVolumeInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerVolumeInfoRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-volume_attachments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerVolumeInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerVolumeInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        /// </summary>
        public async Task<ShowResetPwdResponse> ShowResetPwdAsync(ShowResetPwdRequest showResetPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPwdResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public async Task<ShowTenantQuotaResponse> ShowTenantQuotaAsync(ShowTenantQuotaRequest showTenantQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTenantQuotaResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器获取密码
        /// </summary>
        public async Task<ShowWindowsBaremetalServerPwdResponse> ShowWindowsBaremetalServerPwdAsync(ShowWindowsBaremetalServerPwdRequest showWindowsBaremetalServerPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showWindowsBaremetalServerPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWindowsBaremetalServerPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWindowsBaremetalServerPwdResponse>(response);
        }
        
        /// <summary>
        /// 更新裸金属服务器元数据
        /// </summary>
        public async Task<UpdateBaremetalServerMetadataResponse> UpdateBaremetalServerMetadataAsync(UpdateBaremetalServerMetadataRequest updateBaremetalServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateBaremetalServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateBaremetalServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        /// </summary>
        public async Task<ShowSpecifiedVersionResponse> ShowSpecifiedVersionAsync(ShowSpecifiedVersionRequest showSpecifiedVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showSpecifiedVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecifiedVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSpecifiedVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询Job状态
        /// </summary>
        public async Task<ShowJobInfosResponse> ShowJobInfosAsync(ShowJobInfosRequest showJobInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobInfosRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobInfosResponse>(response);
        }
        
    }
}