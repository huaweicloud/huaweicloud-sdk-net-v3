using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bms.V1.Model;

namespace HuaweiCloud.SDK.Bms.V1
{
    public partial class BmsClient : Client
    {
        public static ClientBuilder<BmsClient> NewBuilder()
        {
            return new ClientBuilder<BmsClient>();
        }

        
        /// <summary>
        /// 裸金属服务器挂载云硬盘
        /// </summary>
        public AttachBaremetalServerVolumeResponse AttachBaremetalServerVolume(AttachBaremetalServerVolumeRequest attachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachBaremetalServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBaremetalServerVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AttachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 重启裸金属服务器
        /// </summary>
        public BatchRebootBaremetalServersResponse BatchRebootBaremetalServers(BatchRebootBaremetalServersRequest batchRebootBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootBaremetalServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 启动裸金属服务器
        /// </summary>
        public BatchStartBaremetalServersResponse BatchStartBaremetalServers(BatchStartBaremetalServersRequest batchStartBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartBaremetalServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchStartBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 关闭裸金属服务器
        /// </summary>
        public BatchStopBaremetalServersResponse BatchStopBaremetalServers(BatchStopBaremetalServersRequest batchStopBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopBaremetalServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchStopBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 修改裸金属服务器名称
        /// </summary>
        public ChangeBaremetalServerNameResponse ChangeBaremetalServerName(ChangeBaremetalServerNameRequest changeBaremetalServerNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeBaremetalServerNameRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerNameResponse>(response);
        }
        
        /// <summary>
        /// 创建裸金属服务器
        /// </summary>
        public CreateBareMetalServersResponse CreateBareMetalServers(CreateBareMetalServersRequest createBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBareMetalServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// 裸金属服务器卸载云磁盘
        /// </summary>
        public DetachBaremetalServerVolumeResponse DetachBaremetalServerVolume(DetachBaremetalServerVolumeRequest detachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachBaremetalServerVolumeRequest.ServerId.ToString());
            urlParam.Add("attachment_id" , detachBaremetalServerVolumeRequest.AttachmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/detachvolume/{attachment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, detachBaremetalServerVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DetachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情
        /// </summary>
        public ListBareMetalServerDetailsResponse ListBareMetalServerDetails(ListBareMetalServerDetailsRequest listBareMetalServerDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listBareMetalServerDetailsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBareMetalServerDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServerDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情列表
        /// </summary>
        public ListBareMetalServersResponse ListBareMetalServers(ListBareMetalServersRequest listBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBareMetalServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        /// </summary>
        public ListBaremetalFlavorDetailExtendsResponse ListBaremetalFlavorDetailExtends(ListBaremetalFlavorDetailExtendsRequest listBaremetalFlavorDetailExtendsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBaremetalFlavorDetailExtendsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBaremetalFlavorDetailExtendsResponse>(response);
        }
        
        /// <summary>
        /// 重装裸金属服务器操作系统
        /// </summary>
        public ReinstallBaremetalServerOsResponse ReinstallBaremetalServerOs(ReinstallBaremetalServerOsRequest reinstallBaremetalServerOsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallBaremetalServerOsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallBaremetalServerOsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ReinstallBaremetalServerOsResponse>(response);
        }
        
        /// <summary>
        /// 一键重置裸金属服务器密码
        /// </summary>
        public ResetPwdOneClickResponse ResetPwdOneClick(ResetPwdOneClickRequest resetPwdOneClickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetPwdOneClickRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdOneClickRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetPwdOneClickResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器网卡信息
        /// </summary>
        public ShowBaremetalServerInterfaceAttachmentsResponse ShowBaremetalServerInterfaceAttachments(ShowBaremetalServerInterfaceAttachmentsRequest showBaremetalServerInterfaceAttachmentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBaremetalServerInterfaceAttachmentsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerInterfaceAttachmentsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器挂载的云硬盘信息
        /// </summary>
        public ShowBaremetalServerVolumeInfoResponse ShowBaremetalServerVolumeInfo(ShowBaremetalServerVolumeInfoRequest showBaremetalServerVolumeInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerVolumeInfoRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-volume_attachments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBaremetalServerVolumeInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerVolumeInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        /// </summary>
        public ShowResetPwdResponse ShowResetPwd(ShowResetPwdRequest showResetPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showResetPwdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPwdResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public ShowTenantQuotaResponse ShowTenantQuota(ShowTenantQuotaRequest showTenantQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showTenantQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTenantQuotaResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器获取密码
        /// </summary>
        public ShowWindowsBaremetalServerPwdResponse ShowWindowsBaremetalServerPwd(ShowWindowsBaremetalServerPwdRequest showWindowsBaremetalServerPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showWindowsBaremetalServerPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showWindowsBaremetalServerPwdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWindowsBaremetalServerPwdResponse>(response);
        }
        
        /// <summary>
        /// 更新裸金属服务器元数据
        /// </summary>
        public UpdateBaremetalServerMetadataResponse UpdateBaremetalServerMetadata(UpdateBaremetalServerMetadataRequest updateBaremetalServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateBaremetalServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateBaremetalServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器清除密码
        /// </summary>
        public WindowsBaremetalServerCleanPwdResponse WindowsBaremetalServerCleanPwd(WindowsBaremetalServerCleanPwdRequest windowsBaremetalServerCleanPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , windowsBaremetalServerCleanPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, windowsBaremetalServerCleanPwdRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<WindowsBaremetalServerCleanPwdResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        /// </summary>
        public ShowSpecifiedVersionResponse ShowSpecifiedVersion(ShowSpecifiedVersionRequest showSpecifiedVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showSpecifiedVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSpecifiedVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSpecifiedVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询Job状态
        /// </summary>
        public ShowJobInfosResponse ShowJobInfos(ShowJobInfosRequest showJobInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobInfosRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobInfosRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobInfosResponse>(response);
        }
        
    }
}