using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Evs.V2.Model;

namespace HuaweiCloud.SDK.Evs.V2
{
    public partial class EvsAsyncClient : Client
    {
        public static ClientBuilder<EvsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EvsAsyncClient>();
        }

        
        /// <summary>
        /// 为指定云硬盘批量添加标签
        /// </summary>
        public async Task<BatchCreateVolumeTagsResponse> BatchCreateVolumeTagsAsync(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchCreateVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateVolumeTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 为指定云硬盘批量删除标签
        /// </summary>
        public async Task<BatchDeleteVolumeTagsResponse> BatchDeleteVolumeTagsAsync(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchDeleteVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteVolumeTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 将云硬盘导出为镜像
        /// </summary>
        public async Task<CinderExportToImageResponse> CinderExportToImageAsync(CinderExportToImageRequest cinderExportToImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , cinderExportToImageRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderExportToImageRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CinderExportToImageResponse>(response);
        }
        
        /// <summary>
        /// 查询所有的可用分区信息
        /// </summary>
        public async Task<CinderListAvailabilityZonesResponse> CinderListAvailabilityZonesAsync(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListAvailabilityZonesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的详细配额
        /// </summary>
        public async Task<CinderListQuotasResponse> CinderListQuotasAsync(CinderListQuotasRequest cinderListQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id" , cinderListQuotasRequest.TargetProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListQuotasRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘类型列表
        /// </summary>
        public async Task<CinderListVolumeTypesResponse> CinderListVolumeTypesAsync(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListVolumeTypesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘快照
        /// </summary>
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSnapshotRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘
        /// </summary>
        public async Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest createVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘快照
        /// </summary>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , deleteSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSnapshotRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘
        /// </summary>
        public async Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest deleteVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , deleteVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘快照详细列表信息
        /// </summary>
        public async Task<ListSnapshotsDetailsResponse> ListSnapshotsDetailsAsync(ListSnapshotsDetailsRequest listSnapshotsDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSnapshotsDetailsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取云硬盘资源的所有标签
        /// </summary>
        public async Task<ListVolumeTagsResponse> ListVolumeTagsAsync(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVolumeTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 通过标签查询云硬盘资源实例详情
        /// </summary>
        public async Task<ListVolumesByTagsResponse> ListVolumesByTagsAsync(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesByTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有云硬盘详情
        /// </summary>
        public async Task<ListVolumesDetailsResponse> ListVolumesDetailsAsync(ListVolumesDetailsRequest listVolumesDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVolumesDetailsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesDetailsResponse>(response);
        }
        
        /// <summary>
        /// 扩容云硬盘
        /// </summary>
        public async Task<ResizeVolumeResponse> ResizeVolumeAsync(ResizeVolumeRequest resizeVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , resizeVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }
        
        /// <summary>
        /// 回滚快照到云硬盘
        /// </summary>
        public async Task<RollbackSnapshotResponse> RollbackSnapshotAsync(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , rollbackSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackSnapshotRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询job的状态
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
        
        /// <summary>
        /// 查询单个云硬盘快照详细信息
        /// </summary>
        public async Task<ShowSnapshotResponse> ShowSnapshotAsync(ShowSnapshotRequest showSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , showSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSnapshotRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘详情
        /// </summary>
        public async Task<ShowVolumeResponse> ShowVolumeAsync(ShowVolumeRequest showVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘标签
        /// </summary>
        public async Task<ShowVolumeTagsResponse> ShowVolumeTagsAsync(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVolumeTagsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘快照
        /// </summary>
        public async Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest updateSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , updateSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSnapshotRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘
        /// </summary>
        public async Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest updateVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , updateVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVolumeRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }
        
    }
}