using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace HuaweiCloud.SDK.Ecs.V2
{
    public partial class EcsAsyncClient : Client
    {
        public static ClientBuilder<EcsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EcsAsyncClient>();
        }

        
        /// <summary>
        /// 弹性云服务器挂载磁盘
        /// </summary>
        public async Task<AttachServerVolumeResponse> AttachServerVolumeAsync(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器网卡
        /// </summary>
        public async Task<BatchAddServerNicsResponse> BatchAddServerNicsAsync(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchAddServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器标签
        /// </summary>
        public async Task<BatchCreateServerTagsResponse> BatchCreateServerTagsAsync(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchCreateServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器网卡
        /// </summary>
        public async Task<BatchDeleteServerNicsResponse> BatchDeleteServerNicsAsync(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器标签
        /// </summary>
        public async Task<BatchDeleteServerTagsResponse> BatchDeleteServerTagsAsync(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量重启云服务器
        /// </summary>
        public async Task<BatchRebootServersResponse> BatchRebootServersAsync(BatchRebootServersRequest batchRebootServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
        }
        
        /// <summary>
        /// 批量启动云服务器
        /// </summary>
        public async Task<BatchStartServersResponse> BatchStartServersAsync(BatchStartServersRequest batchStartServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
        }
        
        /// <summary>
        /// 批量关闭云服务器
        /// </summary>
        public async Task<BatchStopServersResponse> BatchStopServersAsync(BatchStopServersRequest batchStopServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器(按需)
        /// </summary>
        public async Task<CreatePostPaidServersResponse> CreatePostPaidServersAsync(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public async Task<CreateServersResponse> CreateServersAsync(CreateServersRequest createServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public async Task<DeleteServersResponse> DeleteServersAsync(DeleteServersRequest deleteServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
        }
        
        /// <summary>
        /// 弹性云服务器卸载磁盘
        /// </summary>
        public async Task<DetachServerVolumeResponse> DetachServerVolumeAsync(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id" , detachServerVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, detachServerVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFlavorsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性云服务器磁盘信息
        /// </summary>
        public async Task<ListServerBlockDevicesResponse> ListServerBlockDevicesAsync(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerBlockDevicesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerBlockDevicesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器网卡信息
        /// </summary>
        public async Task<ListServerInterfacesResponse> ListServerInterfacesAsync(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerInterfacesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerInterfacesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public async Task<ListServersDetailsResponse> ListServersDetailsAsync(ListServersDetailsRequest listServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServersDetailsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public async Task<NovaCreateServersResponse> NovaCreateServersAsync(NovaCreateServersRequest novaCreateServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public async Task<NovaDeleteServerResponse> NovaDeleteServerAsync(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDeleteServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaDeleteServerRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public async Task<NovaListServersDetailsResponse> NovaListServersDetailsAsync(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServersDetailsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public async Task<NovaShowServerResponse> NovaShowServerAsync(NovaShowServerRequest novaShowServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaShowServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaShowServerRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }
        
        /// <summary>
        /// 变更云服务器规格(按需)
        /// </summary>
        public async Task<ResizePostPaidServerResponse> ResizePostPaidServerAsync(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizePostPaidServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public async Task<ShowServerResponse> ShowServerAsync(ShowServerRequest showServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器标签
        /// </summary>
        public async Task<ShowServerTagsResponse> ShowServerTagsAsync(ShowServerTagsRequest showServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务器
        /// </summary>
        public async Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest updateServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
    }
}