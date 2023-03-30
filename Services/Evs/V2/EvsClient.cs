using System;
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
        ///
        /// 为指定云硬盘批量添加标签。
        /// 
        /// 添加标签时，如果云硬盘的标签已存在相同key，则会覆盖已有标签。
        /// 单个云硬盘最多支持创建10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateVolumeTagsResponse BatchCreateVolumeTags(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchCreateVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 为指定云硬盘批量删除标签
        ///
        /// 为指定云硬盘批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteVolumeTagsResponse BatchDeleteVolumeTags(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchDeleteVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 接受云硬盘过户
        ///
        /// 通过云硬盘过户记录ID以及身份认证密钥来接受云硬盘过户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderAcceptVolumeTransferResponse CinderAcceptVolumeTransfer(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderAcceptVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘过户
        ///
        /// 指定云硬盘来创建云硬盘过户记录，创建成功后，会返回过户记录ID以及身份认证密钥。
        /// 云硬盘在过户过程中的状态变化如下：创建云硬盘过户后，云硬盘状态由“available”变为“awaiting-transfer”。当云硬盘过户被接收后，云硬盘状态变为“available”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderCreateVolumeTransferResponse CinderCreateVolumeTransfer(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘过户
        ///
        /// 当云硬盘过户未被接受时，您可以删除云硬盘过户记录，接受后则无法执行删除操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderDeleteVolumeTransferResponse CinderDeleteVolumeTransfer(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderDeleteVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>(response);
        }
        
        /// <summary>
        /// 查询所有的可用分区信息
        ///
        /// 查询所有的可用分区信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderListAvailabilityZonesResponse CinderListAvailabilityZones(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的详细配额
        ///
        /// 查询租户的详细配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderListQuotasResponse CinderListQuotas(CinderListQuotasRequest cinderListQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id" , cinderListQuotasRequest.TargetProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘过户记录列表概要
        ///
        /// 查询当前租户下所有云硬盘的过户记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderListVolumeTransfersResponse CinderListVolumeTransfers(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘类型列表
        ///
        /// 查询云硬盘类型列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderListVolumeTypesResponse CinderListVolumeTypes(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘过户记录详情
        ///
        /// 查询单个云硬盘的过户记录详情，比如过户记录创建时间、ID以及名称等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CinderShowVolumeTransferResponse CinderShowVolumeTransfer(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderShowVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘快照
        ///
        /// 创建云硬盘快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 创建云硬盘
        ///
        /// 创建按需或包周期云硬盘。
        /// 在创建包周期云硬盘的场景下：
        /// - 如果您需要查看订单可用的优惠券，请参考\&quot;[查询订单可用优惠券](https://support.huaweicloud.com/api-oce/zh-cn_topic_0092953630.html)\&quot;。
        /// - 如果您需要支付订单，请参考\&quot;[支付包周期产品订单](https://support.huaweicloud.com/api-oce/zh-cn_topic_0075746561.html)\&quot;。
        /// - 如果您需要查询订单的资源开通详情，请参考\&quot;[查询订单的资源开通详情](https://support.huaweicloud.com/api-oce/api_order_00001.html)\&quot;。
        /// - 如果您需要退订该包周期资源，请参考“[退订包周期资源](https://support.huaweicloud.com/api-oce/zh-cn_topic_0082522030.html)”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest createVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘快照
        ///
        /// 删除云硬盘快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , deleteSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 删除云硬盘
        ///
        /// 删除一个云硬盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , deleteVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘快照详情列表
        ///
        /// 查询云硬盘快照详细列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest listSnapshotsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsResponse>(response);
        }
        
        /// <summary>
        /// 获取云硬盘资源的所有标签
        ///
        /// 获取某个租户的所有云硬盘资源的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumeTagsResponse ListVolumeTags(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有云硬盘详情
        ///
        /// 查询所有云硬盘的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumesResponse ListVolumes(ListVolumesRequest listVolumesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesResponse>(response);
        }
        
        /// <summary>
        /// 通过标签查询云硬盘资源实例详情
        ///
        /// 通过标签查询云硬盘资源实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumesByTagsResponse ListVolumesByTags(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }
        
        /// <summary>
        /// 扩容云硬盘
        ///
        /// 对按需或者包周期云硬盘进行扩容。
        /// 在扩容包周期云硬盘的场景下：
        /// - 如果您需要查看订单可用的优惠券，请参考\&quot;[查询订单可用优惠券](https://support.huaweicloud.com/api-oce/zh-cn_topic_0092953630.html)\&quot;。
        /// - 如果您需要支付订单，请参考\&quot;[支付包周期产品订单](https://support.huaweicloud.com/api-oce/zh-cn_topic_0075746561.html)\&quot;。
        /// - 如果您需要查询订单的资源开通详情，请参考\&quot;[查询订单的资源开通详情](https://support.huaweicloud.com/api-oce/api_order_00001.html)\&quot;。
        /// - 如果您需要退订该包周期资源，请参考“[退订包周期资源](https://support.huaweicloud.com/api-oce/zh-cn_topic_0082522030.html)”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeVolumeResponse ResizeVolume(ResizeVolumeRequest resizeVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , resizeVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }
        
        /// <summary>
        /// 回滚快照到云硬盘
        ///
        /// 将快照数据回滚到云硬盘。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollbackSnapshotResponse RollbackSnapshot(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , rollbackSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询job的状态
        ///
        /// 查询Job的执行状态。
        /// 可用于查询创建云硬盘，扩容云硬盘，删除云硬盘等API的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘快照详情
        ///
        /// 查询单个云硬盘快照信息。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSnapshotResponse ShowSnapshot(ShowSnapshotRequest showSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , showSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 查询单个云硬盘详情
        ///
        /// 查询单个云硬盘的详细信息。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVolumeResponse ShowVolume(ShowVolumeRequest showVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询云硬盘标签
        ///
        /// 查询指定云硬盘的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVolumeTagsResponse ShowVolumeTags(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘快照
        ///
        /// 更新云硬盘快照。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest updateSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , updateSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 更新云硬盘
        ///
        /// 更新一个云硬盘的名称和描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest updateVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , updateVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询接口版本信息列表
        ///
        /// 查询接口版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<ListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询API接口的版本信息
        ///
        /// 查询接口的指定版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
    }
}