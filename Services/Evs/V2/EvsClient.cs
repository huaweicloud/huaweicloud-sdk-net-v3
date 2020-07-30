using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Evs.V2.Model;

namespace HuaweiCloud.SDK.Evs.V2
{
    public partial class EvsClient : Client
    {
        public static ClientBuilder<EvsClient> NewBuilder()
        {
            return new ClientBuilder<EvsClient>();
        }

        
        /// <summary>
        /// 为指定云硬盘批量添加标签
        /// </summary>
        public BatchCreateVolumeTagsResponse BatchCreateVolumeTags(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchCreateVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 为指定云硬盘批量删除标签
        /// </summary>
        public BatchDeleteVolumeTagsResponse BatchDeleteVolumeTags(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchDeleteVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 将云硬盘导出为镜像
        /// </summary>
        public CinderExportToImageResponse CinderExportToImage(CinderExportToImageRequest cinderExportToImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , cinderExportToImageRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderExportToImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CinderExportToImageResponse>(response);
        }
        
        /// <summary>
        /// 查询所有的可用分区信息
        /// </summary>
        public CinderListAvailabilityZonesResponse CinderListAvailabilityZones(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListAvailabilityZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的详细配额
        /// </summary>
        public CinderListQuotasResponse CinderListQuotas(CinderListQuotasRequest cinderListQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id" , cinderListQuotasRequest.TargetProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘类型列表
        /// </summary>
        public CinderListVolumeTypesResponse CinderListVolumeTypes(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, cinderListVolumeTypesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘快照
        /// </summary>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘
        /// </summary>
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest createVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘快照
        /// </summary>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , deleteSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘
        /// </summary>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , deleteVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘快照详细列表信息
        /// </summary>
        public ListSnapshotsDetailsResponse ListSnapshotsDetails(ListSnapshotsDetailsRequest listSnapshotsDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSnapshotsDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取云硬盘资源的所有标签
        /// </summary>
        public ListVolumeTagsResponse ListVolumeTags(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 通过标签查询云硬盘资源实例详情
        /// </summary>
        public ListVolumesByTagsResponse ListVolumesByTags(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有云硬盘详情
        /// </summary>
        public ListVolumesDetailsResponse ListVolumesDetails(ListVolumesDetailsRequest listVolumesDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVolumesDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesDetailsResponse>(response);
        }
        
        /// <summary>
        /// 扩容云硬盘
        /// </summary>
        public ResizeVolumeResponse ResizeVolume(ResizeVolumeRequest resizeVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , resizeVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }
        
        /// <summary>
        /// 回滚快照到云硬盘
        /// </summary>
        public RollbackSnapshotResponse RollbackSnapshot(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , rollbackSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询job的状态
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘快照详细信息
        /// </summary>
        public ShowSnapshotResponse ShowSnapshot(ShowSnapshotRequest showSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , showSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘详情
        /// </summary>
        public ShowVolumeResponse ShowVolume(ShowVolumeRequest showVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘标签
        /// </summary>
        public ShowVolumeTagsResponse ShowVolumeTags(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘快照
        /// </summary>
        public UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest updateSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , updateSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘
        /// </summary>
        public UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest updateVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , updateVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }
        
    }
}