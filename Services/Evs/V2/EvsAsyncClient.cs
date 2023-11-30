using System;
using System.Net.Http;
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
        ///
        /// 为指定云硬盘批量添加标签。
        /// 
        /// 添加标签时，如果云硬盘的标签已存在相同key，则会覆盖已有标签。
        /// 单个云硬盘最多支持创建10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateVolumeTagsResponse> BatchCreateVolumeTagsAsync(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchCreateVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateVolumeTagsResponse> BatchCreateVolumeTagsAsyncInvoker(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchCreateVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            return new AsyncInvoker<BatchCreateVolumeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>);
        }
        
        /// <summary>
        /// 为指定云硬盘批量删除标签
        ///
        /// 为指定云硬盘批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteVolumeTagsResponse> BatchDeleteVolumeTagsAsync(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchDeleteVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteVolumeTagsResponse> BatchDeleteVolumeTagsAsyncInvoker(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchDeleteVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            return new AsyncInvoker<BatchDeleteVolumeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>);
        }
        
        /// <summary>
        /// 接受云硬盘过户
        ///
        /// 通过云硬盘过户记录ID以及身份认证密钥来接受云硬盘过户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderAcceptVolumeTransferResponse> CinderAcceptVolumeTransferAsync(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderAcceptVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>(response);
        }

        public AsyncInvoker<CinderAcceptVolumeTransferResponse> CinderAcceptVolumeTransferAsyncInvoker(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderAcceptVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            return new AsyncInvoker<CinderAcceptVolumeTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>);
        }
        
        /// <summary>
        /// 创建云硬盘过户
        ///
        /// 指定云硬盘来创建云硬盘过户记录，创建成功后，会返回过户记录ID以及身份认证密钥。
        /// 云硬盘在过户过程中的状态变化如下：创建云硬盘过户后，云硬盘状态由“available”变为“awaiting-transfer”。当云硬盘过户被接收后，云硬盘状态变为“available”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderCreateVolumeTransferResponse> CinderCreateVolumeTransferAsync(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>(response);
        }

        public AsyncInvoker<CinderCreateVolumeTransferResponse> CinderCreateVolumeTransferAsyncInvoker(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            return new AsyncInvoker<CinderCreateVolumeTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>);
        }
        
        /// <summary>
        /// 删除云硬盘过户
        ///
        /// 当云硬盘过户未被接受时，您可以删除云硬盘过户记录，接受后则无法执行删除操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderDeleteVolumeTransferResponse> CinderDeleteVolumeTransferAsync(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderDeleteVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>(response);
        }

        public AsyncInvoker<CinderDeleteVolumeTransferResponse> CinderDeleteVolumeTransferAsyncInvoker(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderDeleteVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            return new AsyncInvoker<CinderDeleteVolumeTransferResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>);
        }
        
        /// <summary>
        /// 查询所有的可用分区信息
        ///
        /// 查询所有的可用分区信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderListAvailabilityZonesResponse> CinderListAvailabilityZonesAsync(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }

        public AsyncInvoker<CinderListAvailabilityZonesResponse> CinderListAvailabilityZonesAsyncInvoker(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            return new AsyncInvoker<CinderListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询租户的详细配额
        ///
        /// 查询租户的详细配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderListQuotasResponse> CinderListQuotasAsync(CinderListQuotasRequest cinderListQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id", cinderListQuotasRequest.TargetProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }

        public AsyncInvoker<CinderListQuotasResponse> CinderListQuotasAsyncInvoker(CinderListQuotasRequest cinderListQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id", cinderListQuotasRequest.TargetProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            return new AsyncInvoker<CinderListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询云硬盘过户记录列表概要
        ///
        /// 查询当前租户下所有云硬盘的过户记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderListVolumeTransfersResponse> CinderListVolumeTransfersAsync(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>(response);
        }

        public AsyncInvoker<CinderListVolumeTransfersResponse> CinderListVolumeTransfersAsyncInvoker(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            return new AsyncInvoker<CinderListVolumeTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>);
        }
        
        /// <summary>
        /// 查询云硬盘类型列表
        ///
        /// 查询云硬盘类型列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderListVolumeTypesResponse> CinderListVolumeTypesAsync(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }

        public AsyncInvoker<CinderListVolumeTypesResponse> CinderListVolumeTypesAsyncInvoker(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            return new AsyncInvoker<CinderListVolumeTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderListVolumeTypesResponse>);
        }
        
        /// <summary>
        /// 查询单个云硬盘过户记录详情
        ///
        /// 查询单个云硬盘的过户记录详情，比如过户记录创建时间、ID以及名称等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CinderShowVolumeTransferResponse> CinderShowVolumeTransferAsync(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderShowVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>(response);
        }

        public AsyncInvoker<CinderShowVolumeTransferResponse> CinderShowVolumeTransferAsyncInvoker(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id", cinderShowVolumeTransferRequest.TransferId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            return new AsyncInvoker<CinderShowVolumeTransferResponse>(this, "GET", request, JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>);
        }
        
        /// <summary>
        /// 创建云硬盘快照
        ///
        /// 创建云硬盘快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }

        public AsyncInvoker<CreateSnapshotResponse> CreateSnapshotAsyncInvoker(CreateSnapshotRequest createSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            return new AsyncInvoker<CreateSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSnapshotResponse>);
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
        public async Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest createVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }

        public AsyncInvoker<CreateVolumeResponse> CreateVolumeAsyncInvoker(CreateVolumeRequest createVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            return new AsyncInvoker<CreateVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVolumeResponse>);
        }
        
        /// <summary>
        /// 删除云硬盘快照
        ///
        /// 删除云硬盘快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", deleteSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }

        public AsyncInvoker<DeleteSnapshotResponse> DeleteSnapshotAsyncInvoker(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", deleteSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            return new AsyncInvoker<DeleteSnapshotResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSnapshotResponse>);
        }
        
        /// <summary>
        /// 删除云硬盘
        ///
        /// 删除一个云硬盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest deleteVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", deleteVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }

        public AsyncInvoker<DeleteVolumeResponse> DeleteVolumeAsyncInvoker(DeleteVolumeRequest deleteVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", deleteVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            return new AsyncInvoker<DeleteVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteVolumeResponse>);
        }
        
        /// <summary>
        /// 查询云硬盘快照详情列表
        ///
        /// 查询云硬盘快照详细列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest listSnapshotsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsResponse>(response);
        }

        public AsyncInvoker<ListSnapshotsResponse> ListSnapshotsAsyncInvoker(ListSnapshotsRequest listSnapshotsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            return new AsyncInvoker<ListSnapshotsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotsResponse>);
        }
        
        /// <summary>
        /// 获取云硬盘资源的所有标签
        ///
        /// 获取某个租户的所有云硬盘资源的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumeTagsResponse> ListVolumeTagsAsync(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }

        public AsyncInvoker<ListVolumeTagsResponse> ListVolumeTagsAsyncInvoker(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            return new AsyncInvoker<ListVolumeTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeTagsResponse>);
        }
        
        /// <summary>
        /// 查询所有云硬盘详情
        ///
        /// 查询所有云硬盘的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest listVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesResponse>(response);
        }

        public AsyncInvoker<ListVolumesResponse> ListVolumesAsyncInvoker(ListVolumesRequest listVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            return new AsyncInvoker<ListVolumesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumesResponse>);
        }
        
        /// <summary>
        /// 通过标签查询云硬盘资源实例详情
        ///
        /// 通过标签查询云硬盘资源实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumesByTagsResponse> ListVolumesByTagsAsync(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }

        public AsyncInvoker<ListVolumesByTagsResponse> ListVolumesByTagsAsyncInvoker(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            return new AsyncInvoker<ListVolumesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListVolumesByTagsResponse>);
        }
        
        /// <summary>
        /// 修改云硬盘QoS
        ///
        /// 调整云硬盘的iops或者吞吐量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyVolumeQoSResponse> ModifyVolumeQoSAsync(ModifyVolumeQoSRequest modifyVolumeQoSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", modifyVolumeQoSRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/cloudvolumes/{volume_id}/qos",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyVolumeQoSRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifyVolumeQoSResponse>(response);
        }

        public AsyncInvoker<ModifyVolumeQoSResponse> ModifyVolumeQoSAsyncInvoker(ModifyVolumeQoSRequest modifyVolumeQoSRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", modifyVolumeQoSRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/cloudvolumes/{volume_id}/qos",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyVolumeQoSRequest);
            return new AsyncInvoker<ModifyVolumeQoSResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyVolumeQoSResponse>);
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
        public async Task<ResizeVolumeResponse> ResizeVolumeAsync(ResizeVolumeRequest resizeVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", resizeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }

        public AsyncInvoker<ResizeVolumeResponse> ResizeVolumeAsyncInvoker(ResizeVolumeRequest resizeVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", resizeVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            return new AsyncInvoker<ResizeVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeVolumeResponse>);
        }
        
        /// <summary>
        /// 回滚快照到云硬盘
        ///
        /// 将快照数据回滚到云硬盘。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollbackSnapshotResponse> RollbackSnapshotAsync(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", rollbackSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
        }

        public AsyncInvoker<RollbackSnapshotResponse> RollbackSnapshotAsyncInvoker(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", rollbackSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            return new AsyncInvoker<RollbackSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<RollbackSnapshotResponse>);
        }
        
        /// <summary>
        /// 查询job的状态
        ///
        /// 查询Job的执行状态。
        /// 可用于查询创建云硬盘，扩容云硬盘，删除云硬盘等API的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 查询单个云硬盘快照详情
        ///
        /// 查询单个云硬盘快照信息。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSnapshotResponse> ShowSnapshotAsync(ShowSnapshotRequest showSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", showSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }

        public AsyncInvoker<ShowSnapshotResponse> ShowSnapshotAsyncInvoker(ShowSnapshotRequest showSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", showSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            return new AsyncInvoker<ShowSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSnapshotResponse>);
        }
        
        /// <summary>
        /// 查询单个云硬盘详情
        ///
        /// 查询单个云硬盘的详细信息。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVolumeResponse> ShowVolumeAsync(ShowVolumeRequest showVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }

        public AsyncInvoker<ShowVolumeResponse> ShowVolumeAsyncInvoker(ShowVolumeRequest showVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            return new AsyncInvoker<ShowVolumeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVolumeResponse>);
        }
        
        /// <summary>
        /// 查询云硬盘标签
        ///
        /// 查询指定云硬盘的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVolumeTagsResponse> ShowVolumeTagsAsync(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }

        public AsyncInvoker<ShowVolumeTagsResponse> ShowVolumeTagsAsyncInvoker(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", showVolumeTagsRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            return new AsyncInvoker<ShowVolumeTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVolumeTagsResponse>);
        }
        
        /// <summary>
        /// 更新云硬盘快照
        ///
        /// 更新云硬盘快照。支持企业项目授权功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest updateSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", updateSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }

        public AsyncInvoker<UpdateSnapshotResponse> UpdateSnapshotAsyncInvoker(UpdateSnapshotRequest updateSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id", updateSnapshotRequest.SnapshotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            return new AsyncInvoker<UpdateSnapshotResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSnapshotResponse>);
        }
        
        /// <summary>
        /// 更新云硬盘
        ///
        /// 更新一个云硬盘的名称和描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest updateVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", updateVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }

        public AsyncInvoker<UpdateVolumeResponse> UpdateVolumeAsyncInvoker(UpdateVolumeRequest updateVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", updateVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            return new AsyncInvoker<UpdateVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVolumeResponse>);
        }
        
        /// <summary>
        /// 查询接口版本信息列表
        ///
        /// 查询接口版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }

        public AsyncInvoker<ListVersionsResponse> ListVersionsAsyncInvoker(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            return new AsyncInvoker<ListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionsResponse>);
        }
        
        /// <summary>
        /// 查询API接口的版本信息
        ///
        /// 查询接口的指定版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public AsyncInvoker<ShowVersionResponse> ShowVersionAsyncInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new AsyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
    }
}