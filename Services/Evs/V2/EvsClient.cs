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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchCreateVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateVolumeTagsResponse> BatchCreateVolumeTagsInvoker(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchCreateVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            return new SyncInvoker<BatchCreateVolumeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchDeleteVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteVolumeTagsResponse> BatchDeleteVolumeTagsInvoker(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchDeleteVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            return new SyncInvoker<BatchDeleteVolumeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderAcceptVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>(response);
        }

        public SyncInvoker<CinderAcceptVolumeTransferResponse> CinderAcceptVolumeTransferInvoker(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderAcceptVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            return new SyncInvoker<CinderAcceptVolumeTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>(response);
        }

        public SyncInvoker<CinderCreateVolumeTransferResponse> CinderCreateVolumeTransferInvoker(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            return new SyncInvoker<CinderCreateVolumeTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderDeleteVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>(response);
        }

        public SyncInvoker<CinderDeleteVolumeTransferResponse> CinderDeleteVolumeTransferInvoker(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderDeleteVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            return new SyncInvoker<CinderDeleteVolumeTransferResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }

        public SyncInvoker<CinderListAvailabilityZonesResponse> CinderListAvailabilityZonesInvoker(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            return new SyncInvoker<CinderListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id", cinderListQuotasRequest.TargetProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }

        public SyncInvoker<CinderListQuotasResponse> CinderListQuotasInvoker(CinderListQuotasRequest cinderListQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id", cinderListQuotasRequest.TargetProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            return new SyncInvoker<CinderListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListQuotasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>(response);
        }

        public SyncInvoker<CinderListVolumeTransfersResponse> CinderListVolumeTransfersInvoker(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            return new SyncInvoker<CinderListVolumeTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }

        public SyncInvoker<CinderListVolumeTypesResponse> CinderListVolumeTypesInvoker(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            return new SyncInvoker<CinderListVolumeTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListVolumeTypesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderShowVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>(response);
        }

        public SyncInvoker<CinderShowVolumeTransferResponse> CinderShowVolumeTransferInvoker(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderShowVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            return new SyncInvoker<CinderShowVolumeTransferResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }

        public SyncInvoker<CreateSnapshotResponse> CreateSnapshotInvoker(CreateSnapshotRequest createSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            return new SyncInvoker<CreateSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSnapshotResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }

        public SyncInvoker<CreateVolumeResponse> CreateVolumeInvoker(CreateVolumeRequest createVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            return new SyncInvoker<CreateVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", deleteSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }

        public SyncInvoker<DeleteSnapshotResponse> DeleteSnapshotInvoker(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", deleteSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            return new SyncInvoker<DeleteSnapshotResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSnapshotResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", deleteVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }

        public SyncInvoker<DeleteVolumeResponse> DeleteVolumeInvoker(DeleteVolumeRequest deleteVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", deleteVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            return new SyncInvoker<DeleteVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSnapshotsResponse>(response);
        }

        public SyncInvoker<ListSnapshotsResponse> ListSnapshotsInvoker(ListSnapshotsRequest listSnapshotsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            return new SyncInvoker<ListSnapshotsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }

        public SyncInvoker<ListVolumeTagsResponse> ListVolumeTagsInvoker(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            return new SyncInvoker<ListVolumeTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVolumesResponse>(response);
        }

        public SyncInvoker<ListVolumesResponse> ListVolumesInvoker(ListVolumesRequest listVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            return new SyncInvoker<ListVolumesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }

        public SyncInvoker<ListVolumesByTagsResponse> ListVolumesByTagsInvoker(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            return new SyncInvoker<ListVolumesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListVolumesByTagsResponse>);
        }
        
        /// <summary>
        /// 修改云硬盘QoS
        ///
        /// 调整云硬盘的iops或者吞吐量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyVolumeQoSResponse ModifyVolumeQoS(ModifyVolumeQoSRequest modifyVolumeQoSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", modifyVolumeQoSRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/cloudvolumes/{volume_id}/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyVolumeQoSRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyVolumeQoSResponse>(response);
        }

        public SyncInvoker<ModifyVolumeQoSResponse> ModifyVolumeQoSInvoker(ModifyVolumeQoSRequest modifyVolumeQoSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", modifyVolumeQoSRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/cloudvolumes/{volume_id}/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyVolumeQoSRequest);
            return new SyncInvoker<ModifyVolumeQoSResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyVolumeQoSResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", resizeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }

        public SyncInvoker<ResizeVolumeResponse> ResizeVolumeInvoker(ResizeVolumeRequest resizeVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", resizeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            return new SyncInvoker<ResizeVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeVolumeResponse>);
        }
        
        /// <summary>
        /// 磁盘类型变更
        ///
        /// 对按需或者包周期云硬盘进行磁盘类型变更。
        /// [在磁盘类型变更包周期云硬盘的场景下：](tag:hws)
        /// - [如果您需要查看订单可用的优惠券，请参考\&quot;[查询订单可用优惠券](https://support.huaweicloud.com/api-oce/zh-cn_topic_0092953630.html)\&quot;。](tag:hws)
        /// - [如果您需要支付订单，请参考\&quot;[支付包周期产品订单](https://support.huaweicloud.com/api-oce/api_order_00030.html)\&quot;。](tag:hws)
        /// - [如果您需要查询订单的资源开通详情，请参考\&quot;[查询订单的资源开通详情](https://support.huaweicloud.com/api-oce/api_order_00001.html)\&quot;。](tag:hws)
        /// - [如果您需要退订该包周期资源，请参考“[退订包周期资源](https://support.huaweicloud.com/api-oce/zh-cn_topic_0082522030.html)”。](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetypeVolumeResponse RetypeVolume(RetypeVolumeRequest retypeVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", retypeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/{volume_id}/retype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retypeVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetypeVolumeResponse>(response);
        }

        public SyncInvoker<RetypeVolumeResponse> RetypeVolumeInvoker(RetypeVolumeRequest retypeVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", retypeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/{volume_id}/retype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retypeVolumeRequest);
            return new SyncInvoker<RetypeVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<RetypeVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", rollbackSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
        }

        public SyncInvoker<RollbackSnapshotResponse> RollbackSnapshotInvoker(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", rollbackSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            return new SyncInvoker<RollbackSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackSnapshotResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public SyncInvoker<ShowJobResponse> ShowJobInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new SyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", showSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }

        public SyncInvoker<ShowSnapshotResponse> ShowSnapshotInvoker(ShowSnapshotRequest showSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", showSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            return new SyncInvoker<ShowSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSnapshotResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }

        public SyncInvoker<ShowVolumeResponse> ShowVolumeInvoker(ShowVolumeRequest showVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            return new SyncInvoker<ShowVolumeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }

        public SyncInvoker<ShowVolumeTagsResponse> ShowVolumeTagsInvoker(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            return new SyncInvoker<ShowVolumeTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVolumeTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", updateSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }

        public SyncInvoker<UpdateSnapshotResponse> UpdateSnapshotInvoker(UpdateSnapshotRequest updateSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", updateSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            return new SyncInvoker<UpdateSnapshotResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSnapshotResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", updateVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }

        public SyncInvoker<UpdateVolumeResponse> UpdateVolumeInvoker(UpdateVolumeRequest updateVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", updateVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            return new SyncInvoker<UpdateVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }

        public SyncInvoker<ListVersionsResponse> ListVersionsInvoker(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            return new SyncInvoker<ListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public SyncInvoker<ShowVersionResponse> ShowVersionInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new SyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
    }
}