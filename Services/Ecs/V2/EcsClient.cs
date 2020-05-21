using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace HuaweiCloud.SDK.Ecs.V2
{
    public partial class EcsClient : Client
    {
        public static ClientBuilder<EcsClient> NewBuilder()
        {
            return new ClientBuilder<EcsClient>();
        }

        
        /// <summary>
        /// 弹性云服务器挂载磁盘
        /// </summary>
        public AttachServerVolumeResponse AttachServerVolume(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器网卡
        /// </summary>
        public BatchAddServerNicsResponse BatchAddServerNics(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchAddServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器标签
        /// </summary>
        public BatchCreateServerTagsResponse BatchCreateServerTags(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchCreateServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器网卡
        /// </summary>
        public BatchDeleteServerNicsResponse BatchDeleteServerNics(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器标签
        /// </summary>
        public BatchDeleteServerTagsResponse BatchDeleteServerTags(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量重启云服务器
        /// </summary>
        public BatchRebootServersResponse BatchRebootServers(BatchRebootServersRequest batchRebootServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
        }
        
        /// <summary>
        /// 批量启动云服务器
        /// </summary>
        public BatchStartServersResponse BatchStartServers(BatchStartServersRequest batchStartServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
        }
        
        /// <summary>
        /// 批量关闭云服务器
        /// </summary>
        public BatchStopServersResponse BatchStopServers(BatchStopServersRequest batchStopServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器(按需)
        /// </summary>
        public CreatePostPaidServersResponse CreatePostPaidServers(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public DeleteServersResponse DeleteServers(DeleteServersRequest deleteServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
        }
        
        /// <summary>
        /// 弹性云服务器卸载磁盘
        /// </summary>
        public DetachServerVolumeResponse DetachServerVolume(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id" , detachServerVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, detachServerVolumeRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFlavorsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性云服务器磁盘信息
        /// </summary>
        public ListServerBlockDevicesResponse ListServerBlockDevices(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerBlockDevicesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerBlockDevicesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器网卡信息
        /// </summary>
        public ListServerInterfacesResponse ListServerInterfaces(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerInterfacesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerInterfacesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public ListServersDetailsResponse ListServersDetails(ListServersDetailsRequest listServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServersDetailsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public NovaCreateServersResponse NovaCreateServers(NovaCreateServersRequest novaCreateServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public NovaDeleteServerResponse NovaDeleteServer(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDeleteServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaDeleteServerRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public NovaListServersDetailsResponse NovaListServersDetails(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServersDetailsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public NovaShowServerResponse NovaShowServer(NovaShowServerRequest novaShowServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaShowServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaShowServerRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }
        
        /// <summary>
        /// 变更云服务器规格(按需)
        /// </summary>
        public ResizePostPaidServerResponse ResizePostPaidServer(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizePostPaidServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public ShowServerResponse ShowServer(ShowServerRequest showServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器标签
        /// </summary>
        public ShowServerTagsResponse ShowServerTags(ShowServerTagsRequest showServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerTagsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务器
        /// </summary>
        public UpdateServerResponse UpdateServer(UpdateServerRequest updateServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
    }
}