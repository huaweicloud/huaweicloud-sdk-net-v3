using System;
using System.Net.Http;
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
        /// 接受并授权执行计划事件操作
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptScheduledEventResponse> AcceptScheduledEventAsync(AcceptScheduledEventRequest acceptScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptScheduledEventRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events/{id}/actions/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptScheduledEventRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AcceptScheduledEventResponse>(response);
        }

        public AsyncInvoker<AcceptScheduledEventResponse> AcceptScheduledEventAsyncInvoker(AcceptScheduledEventRequest acceptScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptScheduledEventRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events/{id}/actions/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptScheduledEventRequest);
            return new AsyncInvoker<AcceptScheduledEventResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AcceptScheduledEventResponse>);
        }
        
        /// <summary>
        /// 添加云服务器组成员
        ///
        /// 将云服务器加入云服务器组。添加成功后，如果该云服务器组是反亲和性策略的，则该云服务器与云服务器组中的其他成员尽量分散地创建在不同主机上。如果该云服务器时故障域类型的，则该云服务器会拥有故障域属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddServerGroupMemberResponse> AddServerGroupMemberAsync(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addServerGroupMemberRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>(response);
        }

        public AsyncInvoker<AddServerGroupMemberResponse> AddServerGroupMemberAsyncInvoker(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addServerGroupMemberRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            return new AsyncInvoker<AddServerGroupMemberResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>);
        }
        
        /// <summary>
        /// 云服务器网卡配置虚拟IP地址
        ///
        /// 虚拟IP地址用于为网卡提供第二个IP地址，同时支持与多个弹性云服务器的网卡绑定，从而实现多个弹性云服务器之间的高可用性。
        /// 
        /// 该接口用于给云服务器网卡配置虚拟IP地址：
        /// 
        /// - 当指定的IP地址是一个不存在的虚拟IP地址时，系统会创建该虚拟IP，并绑定至对应网卡。
        /// 
        /// - 当指定的IP地址是一个已经创建好的私有IP时，系统会将指定的网卡和虚拟IP绑定。如果该IP的device_owner为空，则仅支持VPC内二三层通信；如果该IP的device_owner为neutron:VIP_PORT，则支持VPC内二三层通信、VPC之间对等连接访问，以及弹性公网IP、VPN、云专线等Internet接入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateServerVirtualIpResponse> AssociateServerVirtualIpAsync(AssociateServerVirtualIpRequest associateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateServerVirtualIpRequest.NicId, out var valueOfNicId)) urlParam.Add("nic_id", valueOfNicId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateServerVirtualIpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AssociateServerVirtualIpResponse>(response);
        }

        public AsyncInvoker<AssociateServerVirtualIpResponse> AssociateServerVirtualIpAsyncInvoker(AssociateServerVirtualIpRequest associateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateServerVirtualIpRequest.NicId, out var valueOfNicId)) urlParam.Add("nic_id", valueOfNicId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateServerVirtualIpRequest);
            return new AsyncInvoker<AssociateServerVirtualIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<AssociateServerVirtualIpResponse>);
        }
        
        /// <summary>
        /// 弹性云服务器挂载磁盘
        ///
        /// 把磁盘挂载到弹性云服务器上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachServerVolumeResponse> AttachServerVolumeAsync(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachServerVolumeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
        }

        public AsyncInvoker<AttachServerVolumeResponse> AttachServerVolumeAsyncInvoker(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachServerVolumeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            return new AsyncInvoker<AttachServerVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachServerVolumeResponse>);
        }
        
        /// <summary>
        /// 批量添加云服务器网卡
        ///
        /// 给云服务器添加一张或多张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddServerNicsResponse> BatchAddServerNicsAsync(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddServerNicsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
        }

        public AsyncInvoker<BatchAddServerNicsResponse> BatchAddServerNicsAsyncInvoker(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddServerNicsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            return new AsyncInvoker<BatchAddServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddServerNicsResponse>);
        }
        
        /// <summary>
        /// 批量挂载指定共享盘
        ///
        /// 将指定的共享磁盘一次性挂载到多个弹性云服务器，实现批量挂载。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAttachSharableVolumesResponse> BatchAttachSharableVolumesAsync(BatchAttachSharableVolumesRequest batchAttachSharableVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAttachSharableVolumesRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/attachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAttachSharableVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachSharableVolumesResponse>(response);
        }

        public AsyncInvoker<BatchAttachSharableVolumesResponse> BatchAttachSharableVolumesAsyncInvoker(BatchAttachSharableVolumesRequest batchAttachSharableVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAttachSharableVolumesRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/attachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAttachSharableVolumesRequest);
            return new AsyncInvoker<BatchAttachSharableVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachSharableVolumesResponse>);
        }
        
        /// <summary>
        /// 批量添加云服务器标签
        ///
        /// - 为指定云服务器批量添加标签。
        /// 
        /// - 标签管理服务TMS使用该接口批量管理云服务器的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateServerTagsResponse> BatchCreateServerTagsAsync(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateServerTagsResponse> BatchCreateServerTagsAsyncInvoker(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            return new AsyncInvoker<BatchCreateServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除云服务器网卡
        ///
        /// 卸载并删除云服务器中的一张或多张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteServerNicsResponse> BatchDeleteServerNicsAsync(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteServerNicsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteServerNicsResponse> BatchDeleteServerNicsAsyncInvoker(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteServerNicsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            return new AsyncInvoker<BatchDeleteServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>);
        }
        
        /// <summary>
        /// 批量删除云服务器标签
        ///
        /// - 为指定云服务器批量删除标签。
        /// 
        /// - 标签管理服务TMS使用该接口批量管理云服务器的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteServerTagsResponse> BatchDeleteServerTagsAsync(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteServerTagsResponse> BatchDeleteServerTagsAsyncInvoker(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            return new AsyncInvoker<BatchDeleteServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>);
        }
        
        /// <summary>
        /// 批量卸载卷
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDetachVolumesResponse> BatchDetachVolumesAsync(BatchDetachVolumesRequest batchDetachVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDetachVolumesRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/detachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDetachVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDetachVolumesResponse>(response);
        }

        public AsyncInvoker<BatchDetachVolumesResponse> BatchDetachVolumesAsyncInvoker(BatchDetachVolumesRequest batchDetachVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDetachVolumesRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/detachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDetachVolumesRequest);
            return new AsyncInvoker<BatchDetachVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDetachVolumesResponse>);
        }
        
        /// <summary>
        /// 批量重启云服务器
        ///
        /// 根据给定的云服务器ID列表，批量重启云服务器，一次最多可以重启1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRebootServersResponse> BatchRebootServersAsync(BatchRebootServersRequest batchRebootServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
        }

        public AsyncInvoker<BatchRebootServersResponse> BatchRebootServersAsyncInvoker(BatchRebootServersRequest batchRebootServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            return new AsyncInvoker<BatchRebootServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebootServersResponse>);
        }
        
        /// <summary>
        /// 批量重置弹性云服务器密码
        ///
        /// 批量重置弹性云服务器管理帐号（root用户或Administrator用户）的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResetServersPasswordResponse> BatchResetServersPasswordAsync(BatchResetServersPasswordRequest batchResetServersPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-reset-passwords", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResetServersPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchResetServersPasswordResponse>(response);
        }

        public AsyncInvoker<BatchResetServersPasswordResponse> BatchResetServersPasswordAsyncInvoker(BatchResetServersPasswordRequest batchResetServersPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-reset-passwords", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResetServersPasswordRequest);
            return new AsyncInvoker<BatchResetServersPasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchResetServersPasswordResponse>);
        }
        
        /// <summary>
        /// 批量变更云服务器规格
        ///
        /// 批量变更云服务器规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResizeServersResponse> BatchResizeServersAsync(BatchResizeServersRequest batchResizeServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/batch-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResizeServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchResizeServersResponse>(response);
        }

        public AsyncInvoker<BatchResizeServersResponse> BatchResizeServersAsyncInvoker(BatchResizeServersRequest batchResizeServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/batch-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResizeServersRequest);
            return new AsyncInvoker<BatchResizeServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchResizeServersResponse>);
        }
        
        /// <summary>
        /// 批量启动云服务器
        ///
        /// 根据给定的云服务器ID列表，批量启动云服务器，一次最多可以启动1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStartServersResponse> BatchStartServersAsync(BatchStartServersRequest batchStartServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
        }

        public AsyncInvoker<BatchStartServersResponse> BatchStartServersAsyncInvoker(BatchStartServersRequest batchStartServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            return new AsyncInvoker<BatchStartServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStartServersResponse>);
        }
        
        /// <summary>
        /// 批量关闭云服务器
        ///
        /// 根据给定的云服务器ID列表，批量关闭云服务器，一次最多可以关闭1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopServersResponse> BatchStopServersAsync(BatchStopServersRequest batchStopServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }

        public AsyncInvoker<BatchStopServersResponse> BatchStopServersAsyncInvoker(BatchStopServersRequest batchStopServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            return new AsyncInvoker<BatchStopServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopServersResponse>);
        }
        
        /// <summary>
        /// 批量修改弹性云服务器
        ///
        /// 批量修改弹性云服务器信息。
        /// 当前仅支持批量修改云服务器名称，一次最多可以修改1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateServersNameResponse> BatchUpdateServersNameAsync(BatchUpdateServersNameRequest batchUpdateServersNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/server-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateServersNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateServersNameResponse>(response);
        }

        public AsyncInvoker<BatchUpdateServersNameResponse> BatchUpdateServersNameAsyncInvoker(BatchUpdateServersNameRequest batchUpdateServersNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/server-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateServersNameRequest);
            return new AsyncInvoker<BatchUpdateServersNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateServersNameResponse>);
        }
        
        /// <summary>
        /// 更换云服务器计费模式
        ///
        /// 更换云服务器的计费模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeServerChargeModeResponse> ChangeServerChargeModeAsync(ChangeServerChargeModeRequest changeServerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/actions/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerChargeModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerChargeModeResponse>(response);
        }

        public AsyncInvoker<ChangeServerChargeModeResponse> ChangeServerChargeModeAsyncInvoker(ChangeServerChargeModeRequest changeServerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/actions/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerChargeModeRequest);
            return new AsyncInvoker<ChangeServerChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerChargeModeResponse>);
        }
        
        /// <summary>
        /// 更新云服务器指定网卡属性
        ///
        /// 更新云服务器指定网卡属性，当前仅支持更新网卡IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeServerNetworkInterfaceResponse> ChangeServerNetworkInterfaceAsync(ChangeServerNetworkInterfaceRequest changeServerNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerNetworkInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            if (StringUtils.TryConvertToNonEmptyString(changeServerNetworkInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}/change-network-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<ChangeServerNetworkInterfaceResponse> ChangeServerNetworkInterfaceAsyncInvoker(ChangeServerNetworkInterfaceRequest changeServerNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerNetworkInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            if (StringUtils.TryConvertToNonEmptyString(changeServerNetworkInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}/change-network-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerNetworkInterfaceRequest);
            return new AsyncInvoker<ChangeServerNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 切换弹性云服务器操作系统(安装Cloud init)
        ///
        /// 切换弹性云服务器操作系统。支持弹性云服务器数据盘不变的情况下，使用新镜像重装系统盘。
        /// 
        /// 调用该接口后，系统将卸载系统盘，然后使用新镜像重新创建系统盘，并挂载至弹性云服务器，实现切换操作系统功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeServerOsWithCloudInitResponse> ChangeServerOsWithCloudInitAsync(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerOsWithCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>(response);
        }

        public AsyncInvoker<ChangeServerOsWithCloudInitResponse> ChangeServerOsWithCloudInitAsyncInvoker(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerOsWithCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            return new AsyncInvoker<ChangeServerOsWithCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>);
        }
        
        /// <summary>
        /// 切换弹性云服务器操作系统(未安装Cloud init)
        ///
        /// 切换弹性云服务器操作系统。
        /// 
        /// 该接口支持未安装Cloud-init或Cloudbase-init的镜像使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeServerOsWithoutCloudInitResponse> ChangeServerOsWithoutCloudInitAsync(ChangeServerOsWithoutCloudInitRequest changeServerOsWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerOsWithoutCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithoutCloudInitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerOsWithoutCloudInitResponse>(response);
        }

        public AsyncInvoker<ChangeServerOsWithoutCloudInitResponse> ChangeServerOsWithoutCloudInitAsyncInvoker(ChangeServerOsWithoutCloudInitRequest changeServerOsWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerOsWithoutCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithoutCloudInitRequest);
            return new AsyncInvoker<ChangeServerOsWithoutCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerOsWithoutCloudInitResponse>);
        }
        
        /// <summary>
        /// 云服务器切换虚拟私有云
        ///
        /// 云服务器切换虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeVpcResponse> ChangeVpcAsync(ChangeVpcRequest changeVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeVpcRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changevpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVpcRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeVpcResponse>(response);
        }

        public AsyncInvoker<ChangeVpcResponse> ChangeVpcAsyncInvoker(ChangeVpcRequest changeVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeVpcRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changevpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVpcRequest);
            return new AsyncInvoker<ChangeVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeVpcResponse>);
        }
        
        /// <summary>
        /// 创建模板
        ///
        /// 创建启动模板。将创建一个全新的模板，并自动生成版本号为1的作为默认版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest createLaunchTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLaunchTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLaunchTemplateResponse>(response);
        }

        public AsyncInvoker<CreateLaunchTemplateResponse> CreateLaunchTemplateAsyncInvoker(CreateLaunchTemplateRequest createLaunchTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLaunchTemplateRequest);
            return new AsyncInvoker<CreateLaunchTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLaunchTemplateResponse>);
        }
        
        /// <summary>
        /// 创建云服务器(按需)
        ///
        /// 创建一台或多台[按需付费](https://support.huaweicloud.com/productdesc-ecs/ecs_01_0065.html)方式的云服务器。
        /// 
        /// 弹性云服务器的登录鉴权方式包括两种：密钥对、密码。为安全起见，推荐使用密钥对方式。
        /// 
        /// - 密钥对
        /// 密钥对指使用密钥对作为弹性云服务器的鉴权方式。
        /// 接口调用方法：使用key_name字段，指定弹性云服务器登录时使用的密钥文件。
        /// 
        /// - 密码
        /// 密码指使用设置初始密码方式作为弹性云服务器的鉴权方式，此时，您可以通过用户名密码方式登录弹性云服务器，Linux操作系统时为root用户的初始密码，Windows操作系统时为Administrator用户的初始密码。
        /// 
        /// 接口调用方法：使用adminPass字段，指定管理员帐号的初始登录密码。对于镜像已安装Cloud-init的Linux云服务器，如果需要使用密文密码，可以使用user_data字段进行密码注入。
        /// 
        /// &gt; 对于安装Cloud-init镜像的Linux云服务器云主机，若指定user_data字段，则adminPass字段无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostPaidServersResponse> CreatePostPaidServersAsync(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }

        public AsyncInvoker<CreatePostPaidServersResponse> CreatePostPaidServersAsyncInvoker(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            return new AsyncInvoker<CreatePostPaidServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidServersResponse>);
        }
        
        /// <summary>
        /// 创建云服务器组
        ///
        /// 创建弹性云服务器组。
        /// 
        /// 与原生的创建云服务器组接口不同之处在于该接口支持企业项目细粒度权限的校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateServerGroupResponse> CreateServerGroupAsync(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }

        public AsyncInvoker<CreateServerGroupResponse> CreateServerGroupAsyncInvoker(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            return new AsyncInvoker<CreateServerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServerGroupResponse>);
        }
        
        /// <summary>
        /// 创建云服务器
        ///
        /// 创建一台或多台云服务器。
        /// 
        /// 指该接口兼容《弹性云服务器接口参考》创建云服务器v1的功能，同时合入新功能，支持创建[包年/包月](https://support.huaweicloud.com/productdesc-ecs/ecs_01_0065.html)的弹性云服务器。
        /// 
        /// 弹性云服务器的登录鉴权方式包括两种：密钥对、密码。为安全起见，推荐使用密钥对方式。
        /// 
        /// - 密钥对
        /// 
        /// 指使用密钥对作为弹性云服务器的鉴权方式。
        /// 
        /// 接口调用方法：使用key_name字段，指定弹性云服务器登录时使用的密钥文件。
        /// 
        /// - 密码
        /// 
        /// 指使用设置初始密码方式作为弹性云服务器的鉴权方式，此时，您可以通过用户名密码方式登录弹性云服务器，Linux操作系统时为root用户的初始密码，Windows操作系统时为Administrator用户的初始密码。
        /// 
        /// 接口调用方法：使用adminPass字段，指定管理员帐号的初始登录密码。对于镜像已安装Cloud-init的Linux云服务器，如果需要使用密文密码，可以使用user_data字段进行密码注入。
        /// 
        /// &gt; 对于安装Cloud-init镜像的Linux云服务器云主机，若指定user_data字段，则adminPass字段无效。
        /// 
        /// 购买操作示例：
        /// - [使用API购买ECS过程中常见问题及处理方法](https://support.huaweicloud.com/api-ecs/ecs_04_0007.html)
        /// - [获取Token并检验Token的有效期 ](https://support.huaweicloud.com/api-ecs/ecs_04_0008.html)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateServersResponse> CreateServersAsync(CreateServersRequest createServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
        }

        public AsyncInvoker<CreateServersResponse> CreateServersAsyncInvoker(CreateServersRequest createServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            return new AsyncInvoker<CreateServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServersResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除启动模板。删除一个启动模板。并同时删除模板下所有的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLaunchTemplatesResponse> DeleteLaunchTemplatesAsync(DeleteLaunchTemplatesRequest deleteLaunchTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLaunchTemplatesRequest.LaunchTemplateId, out var valueOfLaunchTemplateId)) urlParam.Add("launch_template_id", valueOfLaunchTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates/{launch_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLaunchTemplatesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLaunchTemplatesResponse>(response);
        }

        public AsyncInvoker<DeleteLaunchTemplatesResponse> DeleteLaunchTemplatesAsyncInvoker(DeleteLaunchTemplatesRequest deleteLaunchTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLaunchTemplatesRequest.LaunchTemplateId, out var valueOfLaunchTemplateId)) urlParam.Add("launch_template_id", valueOfLaunchTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates/{launch_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLaunchTemplatesRequest);
            return new AsyncInvoker<DeleteLaunchTemplatesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLaunchTemplatesResponse>);
        }
        
        /// <summary>
        /// 删除回收站中虚拟机
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecycleBinServerResponse> DeleteRecycleBinServerAsync(DeleteRecycleBinServerRequest deleteRecycleBinServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleBinServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleBinServerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecycleBinServerResponse>(response);
        }

        public AsyncInvoker<DeleteRecycleBinServerResponse> DeleteRecycleBinServerAsyncInvoker(DeleteRecycleBinServerRequest deleteRecycleBinServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleBinServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleBinServerRequest);
            return new AsyncInvoker<DeleteRecycleBinServerResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecycleBinServerResponse>);
        }
        
        /// <summary>
        /// 删除云服务器组
        ///
        /// 删除云服务器组。
        /// 
        /// 与原生的删除云服务器组接口不同之处在于该接口支持企业项目细粒度权限的校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerGroupResponse> DeleteServerGroupAsync(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupResponse>(response);
        }

        public AsyncInvoker<DeleteServerGroupResponse> DeleteServerGroupAsyncInvoker(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupRequest);
            return new AsyncInvoker<DeleteServerGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupResponse>);
        }
        
        /// <summary>
        /// 删除云服务器组成员
        ///
        /// 将弹性云服务器移出云服务器组。移出后，该云服务器与云服务器组中的成员不再遵从反亲和策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerGroupMemberResponse> DeleteServerGroupMemberAsync(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupMemberRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>(response);
        }

        public AsyncInvoker<DeleteServerGroupMemberResponse> DeleteServerGroupMemberAsyncInvoker(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupMemberRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            return new AsyncInvoker<DeleteServerGroupMemberResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>);
        }
        
        /// <summary>
        /// 删除云服务器指定元数据
        ///
        /// 删除云服务器指定元数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerMetadataResponse> DeleteServerMetadataAsync(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerMetadataRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteServerMetadataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerMetadataRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>(response);
        }

        public AsyncInvoker<DeleteServerMetadataResponse> DeleteServerMetadataAsyncInvoker(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerMetadataRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteServerMetadataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerMetadataRequest);
            return new AsyncInvoker<DeleteServerMetadataResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>);
        }
        
        /// <summary>
        /// 云服务器清除密码(企业项目)
        ///
        /// 清除Windows云服务器初始安装时系统生成的密码记录。清除密码后，不影响云服务器密码登录功能，但不能再使用获取密码功能来查询该云服务器密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerPasswordResponse> DeleteServerPasswordAsync(DeleteServerPasswordRequest deleteServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerPasswordRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerPasswordResponse>(response);
        }

        public AsyncInvoker<DeleteServerPasswordResponse> DeleteServerPasswordAsyncInvoker(DeleteServerPasswordRequest deleteServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerPasswordRequest);
            return new AsyncInvoker<DeleteServerPasswordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerPasswordResponse>);
        }
        
        /// <summary>
        /// 删除云服务器
        ///
        /// 根据指定的云服务器ID列表，删除云服务器。
        /// 
        /// 系统支持删除单台云服务器和批量删除多台云服务器操作，批量删除云服务器时，一次最多可以删除1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServersResponse> DeleteServersAsync(DeleteServersRequest deleteServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
        }

        public AsyncInvoker<DeleteServersResponse> DeleteServersAsyncInvoker(DeleteServersRequest deleteServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            return new AsyncInvoker<DeleteServersResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteServersResponse>);
        }
        
        /// <summary>
        /// 弹性云服务器卸载磁盘
        ///
        /// 从弹性云服务器中卸载磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachServerVolumeResponse> DetachServerVolumeAsync(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachServerVolumeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(detachServerVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachServerVolumeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
        }

        public AsyncInvoker<DetachServerVolumeResponse> DetachServerVolumeAsyncInvoker(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachServerVolumeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(detachServerVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachServerVolumeRequest);
            return new AsyncInvoker<DetachServerVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DetachServerVolumeResponse>);
        }
        
        /// <summary>
        /// 云服务器网卡解绑虚拟IP地址
        ///
        /// 虚拟IP地址用于为网卡提供第二个IP地址，同时支持与多个弹性云服务器的网卡绑定，从而实现多个弹性云服务器之间的高可用性。
        /// 
        /// 该接口用于解绑定弹性云服务器网卡的虚拟IP地址。解绑后，网卡不会被删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateServerVirtualIpResponse> DisassociateServerVirtualIpAsync(DisassociateServerVirtualIpRequest disassociateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateServerVirtualIpRequest.NicId, out var valueOfNicId)) urlParam.Add("nic_id", valueOfNicId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateServerVirtualIpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<DisassociateServerVirtualIpResponse>(response);
        }

        public AsyncInvoker<DisassociateServerVirtualIpResponse> DisassociateServerVirtualIpAsyncInvoker(DisassociateServerVirtualIpRequest disassociateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateServerVirtualIpRequest.NicId, out var valueOfNicId)) urlParam.Add("nic_id", valueOfNicId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateServerVirtualIpRequest);
            return new AsyncInvoker<DisassociateServerVirtualIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisassociateServerVirtualIpResponse>);
        }
        
        /// <summary>
        /// 触发云服务器内核dump
        ///
        /// 触发云服务器内核dump
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteServerDumpResponse> ExecuteServerDumpAsync(ExecuteServerDumpRequest executeServerDumpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeServerDumpRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/trigger-crash-dump", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeServerDumpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExecuteServerDumpResponse>(response);
        }

        public AsyncInvoker<ExecuteServerDumpResponse> ExecuteServerDumpAsyncInvoker(ExecuteServerDumpRequest executeServerDumpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeServerDumpRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/trigger-crash-dump", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeServerDumpRequest);
            return new AsyncInvoker<ExecuteServerDumpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteServerDumpResponse>);
        }
        
        /// <summary>
        /// 重部署云服务器
        ///
        /// 重部署云服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteServerRedeployResponse> ExecuteServerRedeployAsync(ExecuteServerRedeployRequest executeServerRedeployRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeServerRedeployRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/redeploy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeServerRedeployRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteServerRedeployResponse>(response);
        }

        public AsyncInvoker<ExecuteServerRedeployResponse> ExecuteServerRedeployAsyncInvoker(ExecuteServerRedeployRequest executeServerRedeployRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeServerRedeployRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/redeploy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeServerRedeployRequest);
            return new AsyncInvoker<ExecuteServerRedeployResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteServerRedeployResponse>);
        }
        
        /// <summary>
        /// 查询云服务器列表接口
        ///
        /// 查询云服务器列表接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudServersResponse> ListCloudServersAsync(ListCloudServersRequest listCloudServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudServersResponse>(response);
        }

        public AsyncInvoker<ListCloudServersResponse> ListCloudServersAsyncInvoker(ListCloudServersRequest listCloudServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServersRequest);
            return new AsyncInvoker<ListCloudServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudServersResponse>);
        }
        
        /// <summary>
        /// 查询规格销售策略
        ///
        /// 查询规格销售策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorSellPoliciesResponse> ListFlavorSellPoliciesAsync(ListFlavorSellPoliciesRequest listFlavorSellPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavor-sell-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorSellPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorSellPoliciesResponse>(response);
        }

        public AsyncInvoker<ListFlavorSellPoliciesResponse> ListFlavorSellPoliciesAsyncInvoker(ListFlavorSellPoliciesRequest listFlavorSellPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavor-sell-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorSellPoliciesRequest);
            return new AsyncInvoker<ListFlavorSellPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorSellPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        ///
        /// 查询云服务器规格详情信息和规格扩展信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询模板版本列表
        ///
        /// 根据用户请求条件从数据库筛选、查询启动模板的版本相关信息，支持按照image_id和flavor_id进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLaunchTemplateVersionsResponse> ListLaunchTemplateVersionsAsync(ListLaunchTemplateVersionsRequest listLaunchTemplateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-template-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLaunchTemplateVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLaunchTemplateVersionsResponse>(response);
        }

        public AsyncInvoker<ListLaunchTemplateVersionsResponse> ListLaunchTemplateVersionsAsyncInvoker(ListLaunchTemplateVersionsRequest listLaunchTemplateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-template-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLaunchTemplateVersionsRequest);
            return new AsyncInvoker<ListLaunchTemplateVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLaunchTemplateVersionsResponse>);
        }
        
        /// <summary>
        /// 查询回收站中虚拟机列表
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleBinServersResponse> ListRecycleBinServersAsync(ListRecycleBinServersRequest listRecycleBinServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleBinServersResponse>(response);
        }

        public AsyncInvoker<ListRecycleBinServersResponse> ListRecycleBinServersAsyncInvoker(ListRecycleBinServersRequest listRecycleBinServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinServersRequest);
            return new AsyncInvoker<ListRecycleBinServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleBinServersResponse>);
        }
        
        /// <summary>
        /// 查询云服务器规格变更支持列表
        ///
        /// 变更规格时，部分规格的云服务器之间不能互相变更。您可以通过本接口，通过指定弹性云服务器规格，查询该规格可以变更的规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResizeFlavorsResponse> ListResizeFlavorsAsync(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResizeFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResizeFlavorsResponse>(response);
        }

        public AsyncInvoker<ListResizeFlavorsResponse> ListResizeFlavorsAsyncInvoker(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResizeFlavorsRequest);
            return new AsyncInvoker<ListResizeFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResizeFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询计划事件列表
        ///
        /// 查询计划事件列表
        /// 支持查看过去7天内计划事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledEventsResponse> ListScheduledEventsAsync(ListScheduledEventsRequest listScheduledEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledEventsResponse>(response);
        }

        public AsyncInvoker<ListScheduledEventsResponse> ListScheduledEventsAsyncInvoker(ListScheduledEventsRequest listScheduledEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledEventsRequest);
            return new AsyncInvoker<ListScheduledEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledEventsResponse>);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 查询可用区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerAzInfoResponse> ListServerAzInfoAsync(ListServerAzInfoRequest listServerAzInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerAzInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerAzInfoResponse>(response);
        }

        public AsyncInvoker<ListServerAzInfoResponse> ListServerAzInfoAsyncInvoker(ListServerAzInfoRequest listServerAzInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerAzInfoRequest);
            return new AsyncInvoker<ListServerAzInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerAzInfoResponse>);
        }
        
        /// <summary>
        /// 查询弹性云服务器挂载磁盘列表详情信息
        ///
        /// 查询弹性云服务器挂载的磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerBlockDevicesResponse> ListServerBlockDevicesAsync(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerBlockDevicesRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerBlockDevicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
        }

        public AsyncInvoker<ListServerBlockDevicesResponse> ListServerBlockDevicesAsyncInvoker(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerBlockDevicesRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerBlockDevicesRequest);
            return new AsyncInvoker<ListServerBlockDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerBlockDevicesResponse>);
        }
        
        /// <summary>
        /// 查询云服务器组列表
        ///
        /// 查询弹性云服务器组。
        /// 
        /// 与原生的创建云服务器组接口不同之处在于该接口支持企业项目细粒度权限的校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerGroupsResponse> ListServerGroupsAsync(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupsResponse>(response);
        }

        public AsyncInvoker<ListServerGroupsResponse> ListServerGroupsAsyncInvoker(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            return new AsyncInvoker<ListServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器网卡信息
        ///
        /// 查询云服务器网卡信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerInterfacesResponse> ListServerInterfacesAsync(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerInterfacesRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerInterfacesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
        }

        public AsyncInvoker<ListServerInterfacesResponse> ListServerInterfacesAsyncInvoker(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerInterfacesRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerInterfacesRequest);
            return new AsyncInvoker<ListServerInterfacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerInterfacesResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 项目（Project）用于将OpenStack的资源（计算资源、存储资源和网络资源）进行分组和隔离。项目可以是一个部门或者一个项目组。一个帐户中可以创建多个项目。
        /// 
        /// 该接口用于查询用户在指定项目所使用的全部标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerTagsResponse> ListServerTagsAsync(ListServerTagsRequest listServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerTagsResponse>(response);
        }

        public AsyncInvoker<ListServerTagsResponse> ListServerTagsAsyncInvoker(ListServerTagsRequest listServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerTagsRequest);
            return new AsyncInvoker<ListServerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerTagsResponse>);
        }
        
        /// <summary>
        /// 查询弹性云服务器挂载磁盘列表信息
        ///
        /// 查询弹性云服务器挂载的磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerVolumeAttachmentsResponse> ListServerVolumeAttachmentsAsync(ListServerVolumeAttachmentsRequest listServerVolumeAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerVolumeAttachmentsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-volume_attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerVolumeAttachmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerVolumeAttachmentsResponse>(response);
        }

        public AsyncInvoker<ListServerVolumeAttachmentsResponse> ListServerVolumeAttachmentsAsyncInvoker(ListServerVolumeAttachmentsRequest listServerVolumeAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerVolumeAttachmentsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-volume_attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerVolumeAttachmentsRequest);
            return new AsyncInvoker<ListServerVolumeAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerVolumeAttachmentsResponse>);
        }
        
        /// <summary>
        /// 按标签查询云服务器列表
        ///
        /// 使用标签过滤弹性云服务器，并返回云服务器使用的所有标签和资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListServersByTagResponse> ListServersByTagAsync(ListServersByTagRequest listServersByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listServersByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListServersByTagResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListServersByTagResponse> ListServersByTagAsyncInvoker(ListServersByTagRequest listServersByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listServersByTagRequest);
            return new AsyncInvoker<ListServersByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListServersByTagResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        ///
        /// 根据用户请求条件从数据库筛选、查询所有的弹性云服务器，并关联相关表获取到弹性云服务器的详细信息。
        /// 
        /// 该接口支持查询弹性云服务器计费方式，以及是否被冻结。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServersDetailsResponse> ListServersDetailsAsync(ListServersDetailsRequest listServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }

        public AsyncInvoker<ListServersDetailsResponse> ListServersDetailsAsyncInvoker(ListServersDetailsRequest listServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersDetailsRequest);
            return new AsyncInvoker<ListServersDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersDetailsResponse>);
        }
        
        /// <summary>
        /// 查询模板列表
        ///
        /// 根据用户请求条件从数据库筛选、查询启动模板相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTemplatesResponse> ListTemplatesAsyncInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/launch-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new AsyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 冷迁移云服务器
        ///
        /// - 将部署在专属主机上的弹性云服务器迁移至其他专属主机。
        /// - 将部署在专属主机上的弹性云服务器迁移至公共资源池，即不再部署在专属主机上。
        /// - 将公共资源池的弹性云服务器迁移至专属主机上，成为专属主机上部署的弹性云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateServerResponse> MigrateServerAsync(MigrateServerRequest migrateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<MigrateServerResponse>(response);
        }

        public AsyncInvoker<MigrateServerResponse> MigrateServerAsyncInvoker(MigrateServerRequest migrateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateServerRequest);
            return new AsyncInvoker<MigrateServerResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateServerResponse>);
        }
        
        /// <summary>
        /// 添加安全组
        ///
        /// 为弹性云服务器添加一个安全组。
        /// 
        /// 添加多个安全组时，建议最多为弹性云服务器添加5个安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaAssociateSecurityGroupResponse> NovaAssociateSecurityGroupAsync(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaAssociateSecurityGroupRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NovaAssociateSecurityGroupResponse> NovaAssociateSecurityGroupAsyncInvoker(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaAssociateSecurityGroupRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            return new AsyncInvoker<NovaAssociateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 添加云服务器网卡
        ///
        /// 给云服务器添加一张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaAttachInterfaceResponse> NovaAttachInterfaceAsync(NovaAttachInterfaceRequest novaAttachInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaAttachInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAttachInterfaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NovaAttachInterfaceResponse>(response);
        }

        public AsyncInvoker<NovaAttachInterfaceResponse> NovaAttachInterfaceAsyncInvoker(NovaAttachInterfaceRequest novaAttachInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaAttachInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAttachInterfaceRequest);
            return new AsyncInvoker<NovaAttachInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaAttachInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥
        ///
        /// 创建SSH密钥，或把公钥导入系统，生成密钥对。
        /// 
        /// 创建SSH密钥成功后，请把响应数据中的私钥内容保存到本地文件，用户使用该私钥登录云服务器云主机。为保证云服务器云主机器安全，私钥数据只能读取一次，请妥善保管。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaCreateKeypairResponse> NovaCreateKeypairAsync(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NovaCreateKeypairResponse>(response);
        }

        public AsyncInvoker<NovaCreateKeypairResponse> NovaCreateKeypairAsyncInvoker(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            return new AsyncInvoker<NovaCreateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaCreateKeypairResponse>);
        }
        
        /// <summary>
        /// 创建云服务器
        ///
        /// 创建一台弹性云服务器。
        /// 
        /// 弹性云服务器创建完成后，如需开启自动恢复功能，可以调用配置云服务器自动恢复的接口，具体使用请参见管理云服务器自动恢复动作。
        /// 
        /// 该接口在云服务器创建失败后不支持自动回滚。若需要自动回滚能力，可以调用POST /v1/{project_id}/cloudservers接口，具体使用请参见创建云服务器（按需）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaCreateServersResponse> NovaCreateServersAsync(NovaCreateServersRequest novaCreateServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }

        public AsyncInvoker<NovaCreateServersResponse> NovaCreateServersAsyncInvoker(NovaCreateServersRequest novaCreateServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            return new AsyncInvoker<NovaCreateServersResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaCreateServersResponse>);
        }
        
        /// <summary>
        /// 删除SSH密钥
        ///
        /// 根据SSH密钥的名称，删除指定SSH密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaDeleteKeypairResponse> NovaDeleteKeypairAsync(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDeleteKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteKeypairRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>(response);
        }

        public AsyncInvoker<NovaDeleteKeypairResponse> NovaDeleteKeypairAsyncInvoker(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDeleteKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteKeypairRequest);
            return new AsyncInvoker<NovaDeleteKeypairResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>);
        }
        
        /// <summary>
        /// 删除云服务器
        ///
        /// 删除一台云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaDeleteServerResponse> NovaDeleteServerAsync(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDeleteServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteServerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }

        public AsyncInvoker<NovaDeleteServerResponse> NovaDeleteServerAsyncInvoker(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDeleteServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteServerRequest);
            return new AsyncInvoker<NovaDeleteServerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NovaDeleteServerResponse>);
        }
        
        /// <summary>
        /// 移除安全组
        ///
        /// 移除弹性云服务器中的安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaDisassociateSecurityGroupResponse> NovaDisassociateSecurityGroupAsync(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDisassociateSecurityGroupRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NovaDisassociateSecurityGroupResponse> NovaDisassociateSecurityGroupAsyncInvoker(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaDisassociateSecurityGroupRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            return new AsyncInvoker<NovaDisassociateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 查询可用域列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<NovaListAvailabilityZonesResponse> NovaListAvailabilityZonesAsync(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListAvailabilityZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<NovaListAvailabilityZonesResponse> NovaListAvailabilityZonesAsyncInvoker(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListAvailabilityZonesRequest);
            return new AsyncInvoker<NovaListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥列表
        ///
        /// 查询SSH密钥信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListKeypairsResponse> NovaListKeypairsAsync(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListKeypairsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListKeypairsResponse>(response);
        }

        public AsyncInvoker<NovaListKeypairsResponse> NovaListKeypairsAsyncInvoker(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListKeypairsRequest);
            return new AsyncInvoker<NovaListKeypairsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListKeypairsResponse>);
        }
        
        /// <summary>
        /// 查询指定云服务器安全组列表
        ///
        /// 查询指定弹性云服务器的安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListServerSecurityGroupsResponse> NovaListServerSecurityGroupsAsync(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaListServerSecurityGroupsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServerSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<NovaListServerSecurityGroupsResponse> NovaListServerSecurityGroupsAsyncInvoker(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaListServerSecurityGroupsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServerSecurityGroupsRequest);
            return new AsyncInvoker<NovaListServerSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器列表
        ///
        /// 查询云服务器信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListServersResponse> NovaListServersAsync(NovaListServersRequest novaListServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListServersResponse>(response);
        }

        public AsyncInvoker<NovaListServersResponse> NovaListServersAsyncInvoker(NovaListServersRequest novaListServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersRequest);
            return new AsyncInvoker<NovaListServersResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListServersResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        ///
        /// 查询云服务器详情信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListServersDetailsResponse> NovaListServersDetailsAsync(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
        }

        public AsyncInvoker<NovaListServersDetailsResponse> NovaListServersDetailsAsyncInvoker(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersDetailsRequest);
            return new AsyncInvoker<NovaListServersDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListServersDetailsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器规格extra_specs的详情
        ///
        /// 查询指定的规格的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaShowFlavorExtraSpecsResponse> NovaShowFlavorExtraSpecsAsync(NovaShowFlavorExtraSpecsRequest novaShowFlavorExtraSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowFlavorExtraSpecsRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/flavors/{flavor_id}/os-extra_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowFlavorExtraSpecsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaShowFlavorExtraSpecsResponse>(response);
        }

        public AsyncInvoker<NovaShowFlavorExtraSpecsResponse> NovaShowFlavorExtraSpecsAsyncInvoker(NovaShowFlavorExtraSpecsRequest novaShowFlavorExtraSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowFlavorExtraSpecsRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/flavors/{flavor_id}/os-extra_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowFlavorExtraSpecsRequest);
            return new AsyncInvoker<NovaShowFlavorExtraSpecsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowFlavorExtraSpecsResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥详情
        ///
        /// 根据SSH密钥名称查询指定SSH密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaShowKeypairResponse> NovaShowKeypairAsync(NovaShowKeypairRequest novaShowKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowKeypairRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaShowKeypairResponse>(response);
        }

        public AsyncInvoker<NovaShowKeypairResponse> NovaShowKeypairAsyncInvoker(NovaShowKeypairRequest novaShowKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowKeypairRequest);
            return new AsyncInvoker<NovaShowKeypairResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowKeypairResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情
        ///
        /// 根据云服务器ID，查询云服务器的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaShowServerResponse> NovaShowServerAsync(NovaShowServerRequest novaShowServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }

        public AsyncInvoker<NovaShowServerResponse> NovaShowServerAsyncInvoker(NovaShowServerRequest novaShowServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerRequest);
            return new AsyncInvoker<NovaShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowServerResponse>);
        }
        
        /// <summary>
        /// 查询指定云服务器网卡信息
        ///
        /// 根据网卡ID，查询云服务器网卡信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaShowServerInterfaceResponse> NovaShowServerInterfaceAsync(NovaShowServerInterfaceRequest novaShowServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerInterfaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaShowServerInterfaceResponse>(response);
        }

        public AsyncInvoker<NovaShowServerInterfaceResponse> NovaShowServerInterfaceAsyncInvoker(NovaShowServerInterfaceRequest novaShowServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            if (StringUtils.TryConvertToNonEmptyString(novaShowServerInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerInterfaceRequest);
            return new AsyncInvoker<NovaShowServerInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowServerInterfaceResponse>);
        }
        
        /// <summary>
        /// 注册云服务器监控
        ///
        /// 将云服务器添加到监控表中。
        /// 
        /// 注册到监控表中的云服务会被ceilometer周期性采集监控数据，包括平台的版本、cpu信息、内存、网卡、磁盘、硬件平台等信息，这些数据上报给云监控。例如SAP云服务器内部的插件会周期性从云监控中查询监控数据，以报表形式呈现给SAP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterServerMonitorResponse> RegisterServerMonitorAsync(RegisterServerMonitorRequest registerServerMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerServerMonitorRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerMonitorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterServerMonitorResponse>(response);
        }

        public AsyncInvoker<RegisterServerMonitorResponse> RegisterServerMonitorAsyncInvoker(RegisterServerMonitorRequest registerServerMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerServerMonitorRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerMonitorRequest);
            return new AsyncInvoker<RegisterServerMonitorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterServerMonitorResponse>);
        }
        
        /// <summary>
        /// 重装弹性云服务器操作系统(安装Cloud-init)
        ///
        /// 重装弹性云服务器的操作系统。支持弹性云服务器数据盘不变的情况下，使用原镜像重装系统盘。
        /// 
        /// 调用该接口后，系统将卸载系统盘，然后使用原镜像重新创建系统盘，并挂载至弹性云服务器，实现重装操作系统功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReinstallServerWithCloudInitResponse> ReinstallServerWithCloudInitAsync(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerWithCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>(response);
        }

        public AsyncInvoker<ReinstallServerWithCloudInitResponse> ReinstallServerWithCloudInitAsyncInvoker(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerWithCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            return new AsyncInvoker<ReinstallServerWithCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>);
        }
        
        /// <summary>
        /// 重装弹性云服务器操作系统(未安装Cloud init)
        ///
        /// 重装弹性云服务器的操作系统。
        /// 
        /// 该接口支持未安装Cloud-init或Cloudbase-init的镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReinstallServerWithoutCloudInitResponse> ReinstallServerWithoutCloudInitAsync(ReinstallServerWithoutCloudInitRequest reinstallServerWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerWithoutCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithoutCloudInitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerWithoutCloudInitResponse>(response);
        }

        public AsyncInvoker<ReinstallServerWithoutCloudInitResponse> ReinstallServerWithoutCloudInitAsyncInvoker(ReinstallServerWithoutCloudInitRequest reinstallServerWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerWithoutCloudInitRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithoutCloudInitRequest);
            return new AsyncInvoker<ReinstallServerWithoutCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerWithoutCloudInitResponse>);
        }
        
        /// <summary>
        /// 一键重置弹性云服务器密码(企业项目)
        ///
        /// 重置弹性云服务器管理帐号（root用户或Administrator用户）的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetServerPasswordResponse> ResetServerPasswordAsync(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetServerPasswordResponse>(response);
        }

        public AsyncInvoker<ResetServerPasswordResponse> ResetServerPasswordAsyncInvoker(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            return new AsyncInvoker<ResetServerPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetServerPasswordResponse>);
        }
        
        /// <summary>
        /// 变更云服务器规格(按需)
        ///
        /// 当您创建的弹性云服务器规格无法满足业务需要时，可以变更云服务器规格，升级vCPU、内存。具体接口的使用，请参见本节内容。
        /// 
        /// 变更规格时，部分规格的云服务器之间不能互相变更。
        /// 
        /// 您可以通过接口“/v1/{project_id}/cloudservers/resize_flavors?{instance_uuid,source_flavor_id,source_flavor_name}”查询支持列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizePostPaidServerResponse> ResizePostPaidServerAsync(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizePostPaidServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }

        public AsyncInvoker<ResizePostPaidServerResponse> ResizePostPaidServerAsyncInvoker(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizePostPaidServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            return new AsyncInvoker<ResizePostPaidServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizePostPaidServerResponse>);
        }
        
        /// <summary>
        /// 变更云服务器规格
        ///
        /// 变更云服务器规格。
        /// 
        /// v1.1版本：指该接口兼容v1接口的功能，同时合入新功能，支持变更包年/包月弹性云服务器的规格。
        /// 
        /// 注意事项：
        /// 
        /// - 该接口可以使用合作伙伴自身的AK/SK或者token调用，也可以用合作伙伴子客户的AK/SK或者token来调用。
        /// - 如果使用AK/SK认证方式，示例代码中region请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)中“弹性云服务 ECS”下“区域”的内容，，serviceName（英文服务名称缩写）请指定为ECS。
        /// - Endpoint请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)中“弹性云服务 ECS”下“终端节点（Endpoint）”的内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeServerResponse> ResizeServerAsync(ResizeServerRequest resizeServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeServerResponse>(response);
        }

        public AsyncInvoker<ResizeServerResponse> ResizeServerAsyncInvoker(ResizeServerRequest resizeServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            return new AsyncInvoker<ResizeServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeServerResponse>);
        }
        
        /// <summary>
        /// 恢复回收站中虚拟机
        ///
        /// 回收站中的虚拟机从回收站中恢复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevertRecycleBinServerResponse> RevertRecycleBinServerAsync(RevertRecycleBinServerRequest revertRecycleBinServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revertRecycleBinServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers/{server_id}/actions/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revertRecycleBinServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RevertRecycleBinServerResponse>(response);
        }

        public AsyncInvoker<RevertRecycleBinServerResponse> RevertRecycleBinServerAsyncInvoker(RevertRecycleBinServerRequest revertRecycleBinServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revertRecycleBinServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/cloudservers/{server_id}/actions/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revertRecycleBinServerRequest);
            return new AsyncInvoker<RevertRecycleBinServerResponse>(this, "POST", request, JsonUtils.DeSerialize<RevertRecycleBinServerResponse>);
        }
        
        /// <summary>
        /// 查询包周期虚拟机可以追加卷数量
        ///
        /// 查询包周期虚拟机可以追加卷数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppendableVolumeQuotaResponse> ShowAppendableVolumeQuotaAsync(ShowAppendableVolumeQuotaRequest showAppendableVolumeQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppendableVolumeQuotaRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/appendvolumequota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppendableVolumeQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppendableVolumeQuotaResponse>(response);
        }

        public AsyncInvoker<ShowAppendableVolumeQuotaResponse> ShowAppendableVolumeQuotaAsyncInvoker(ShowAppendableVolumeQuotaRequest showAppendableVolumeQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppendableVolumeQuotaRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/appendvolumequota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppendableVolumeQuotaRequest);
            return new AsyncInvoker<ShowAppendableVolumeQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppendableVolumeQuotaResponse>);
        }
        
        /// <summary>
        /// 查询flavor的容量
        ///
        /// 查询flavor的容量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlavorCapacityResponse> ShowFlavorCapacityAsync(ShowFlavorCapacityRequest showFlavorCapacityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlavorCapacityRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors/{flavor_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorCapacityRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlavorCapacityResponse>(response);
        }

        public AsyncInvoker<ShowFlavorCapacityResponse> ShowFlavorCapacityAsyncInvoker(ShowFlavorCapacityRequest showFlavorCapacityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlavorCapacityRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors/{flavor_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorCapacityRequest);
            return new AsyncInvoker<ShowFlavorCapacityResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlavorCapacityResponse>);
        }
        
        /// <summary>
        /// 查询云服务器元数据配置
        ///
        /// 查询云服务器元数据配置，通过本接口，您可以查询指定云服务器的元数据配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMetadataOptionsResponse> ShowMetadataOptionsAsync(ShowMetadataOptionsRequest showMetadataOptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMetadataOptionsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata-options", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataOptionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMetadataOptionsResponse>(response);
        }

        public AsyncInvoker<ShowMetadataOptionsResponse> ShowMetadataOptionsAsyncInvoker(ShowMetadataOptionsRequest showMetadataOptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMetadataOptionsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata-options", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataOptionsRequest);
            return new AsyncInvoker<ShowMetadataOptionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetadataOptionsResponse>);
        }
        
        /// <summary>
        /// 查询回收站配置
        ///
        /// 查询回收站配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecycleBinResponse> ShowRecycleBinAsync(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecycleBinResponse>(response);
        }

        public AsyncInvoker<ShowRecycleBinResponse> ShowRecycleBinAsyncInvoker(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            return new AsyncInvoker<ShowRecycleBinResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecycleBinResponse>);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        ///
        /// 查询弹性云服务器是否支持一键重置密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResetPasswordFlagResponse> ShowResetPasswordFlagAsync(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResetPasswordFlagRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPasswordFlagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>(response);
        }

        public AsyncInvoker<ShowResetPasswordFlagResponse> ShowResetPasswordFlagAsyncInvoker(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResetPasswordFlagRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPasswordFlagRequest);
            return new AsyncInvoker<ShowResetPasswordFlagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情
        ///
        /// 查询弹性云服务器的详细信息。
        /// 
        /// 该接口支持查询弹性云服务器的计费方式，以及是否被冻结。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerResponse> ShowServerAsync(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public AsyncInvoker<ShowServerResponse> ShowServerAsyncInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new AsyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询虚拟机可挂载网卡
        ///
        /// 查询虚拟机可挂载网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerAttachableNicNumResponse> ShowServerAttachableNicNumAsync(ShowServerAttachableNicNumRequest showServerAttachableNicNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerAttachableNicNumRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface_extension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerAttachableNicNumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerAttachableNicNumResponse>(response);
        }

        public AsyncInvoker<ShowServerAttachableNicNumResponse> ShowServerAttachableNicNumAsyncInvoker(ShowServerAttachableNicNumRequest showServerAttachableNicNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerAttachableNicNumRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface_extension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerAttachableNicNumRequest);
            return new AsyncInvoker<ShowServerAttachableNicNumResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerAttachableNicNumResponse>);
        }
        
        /// <summary>
        /// 查询弹性云服务器单个磁盘信息
        ///
        /// 查询弹性云服务器挂载的单个磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerBlockDeviceResponse> ShowServerBlockDeviceAsync(ShowServerBlockDeviceRequest showServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerBlockDeviceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(showServerBlockDeviceRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerBlockDeviceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerBlockDeviceResponse>(response);
        }

        public AsyncInvoker<ShowServerBlockDeviceResponse> ShowServerBlockDeviceAsyncInvoker(ShowServerBlockDeviceRequest showServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerBlockDeviceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(showServerBlockDeviceRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerBlockDeviceRequest);
            return new AsyncInvoker<ShowServerBlockDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerBlockDeviceResponse>);
        }
        
        /// <summary>
        /// 查询云服务器组详情
        ///
        /// 查询弹性云服务器组详情。
        /// 
        /// 与原生的创建云服务器组接口不同之处在于该接口支持企业项目细粒度权限的校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerGroupResponse> ShowServerGroupAsync(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupResponse>(response);
        }

        public AsyncInvoker<ShowServerGroupResponse> ShowServerGroupAsyncInvoker(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            return new AsyncInvoker<ShowServerGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerLimitsResponse> ShowServerLimitsAsync(ShowServerLimitsRequest showServerLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerLimitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerLimitsResponse>(response);
        }

        public AsyncInvoker<ShowServerLimitsResponse> ShowServerLimitsAsyncInvoker(ShowServerLimitsRequest showServerLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerLimitsRequest);
            return new AsyncInvoker<ShowServerLimitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerLimitsResponse>);
        }
        
        /// <summary>
        /// 云服务器获取密码(企业项目)
        ///
        /// 当通过支持Cloudbase-init功能的镜像创建Windows云服务器时，获取云服务器初始安装时系统生成的管理员帐户（Administrator帐户或Cloudbase-init设置的帐户）随机密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerPasswordResponse> ShowServerPasswordAsync(ShowServerPasswordRequest showServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerPasswordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerPasswordResponse>(response);
        }

        public AsyncInvoker<ShowServerPasswordResponse> ShowServerPasswordAsyncInvoker(ShowServerPasswordRequest showServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerPasswordRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerPasswordRequest);
            return new AsyncInvoker<ShowServerPasswordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerPasswordResponse>);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        ///
        /// 获取弹性云服务器VNC远程登录地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerRemoteConsoleResponse> ShowServerRemoteConsoleAsync(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRemoteConsoleRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
        }

        public AsyncInvoker<ShowServerRemoteConsoleResponse> ShowServerRemoteConsoleAsyncInvoker(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRemoteConsoleRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            return new AsyncInvoker<ShowServerRemoteConsoleResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>);
        }
        
        /// <summary>
        /// 查询云服务器标签
        ///
        /// - 查询指定云服务器的标签信息。
        /// 
        /// - 标签管理服务TMS使用该接口查询指定云服务器的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerTagsResponse> ShowServerTagsAsync(ShowServerTagsRequest showServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
        }

        public AsyncInvoker<ShowServerTagsResponse> ShowServerTagsAsyncInvoker(ShowServerTagsRequest showServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerTagsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerTagsRequest);
            return new AsyncInvoker<ShowServerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerTagsResponse>);
        }
        
        /// <summary>
        /// 更新云服务器元数据配置
        ///
        /// 更新云服务器元数据配置，通过本接口，您可以选择启用或关闭IMDS服务，也可以选择IMDS服务的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMetadataOptionsResponse> UpdateMetadataOptionsAsync(UpdateMetadataOptionsRequest updateMetadataOptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMetadataOptionsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata-options", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetadataOptionsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMetadataOptionsResponse>(response);
        }

        public AsyncInvoker<UpdateMetadataOptionsResponse> UpdateMetadataOptionsAsyncInvoker(UpdateMetadataOptionsRequest updateMetadataOptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMetadataOptionsRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata-options", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetadataOptionsRequest);
            return new AsyncInvoker<UpdateMetadataOptionsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMetadataOptionsResponse>);
        }
        
        /// <summary>
        /// 更新回收站配置
        ///
        /// 更新回收站属性信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecycleBinResponse> UpdateRecycleBinAsync(UpdateRecycleBinRequest updateRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRecycleBinRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRecycleBinResponse>(response);
        }

        public AsyncInvoker<UpdateRecycleBinResponse> UpdateRecycleBinAsyncInvoker(UpdateRecycleBinRequest updateRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRecycleBinRequest);
            return new AsyncInvoker<UpdateRecycleBinResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRecycleBinResponse>);
        }
        
        /// <summary>
        /// 更新回收站策略
        ///
        /// 更新回收站策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecycleBinPolicyResponse> UpdateRecycleBinPolicyAsync(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRecycleBinPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRecycleBinPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateRecycleBinPolicyResponse> UpdateRecycleBinPolicyAsyncInvoker(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRecycleBinPolicyRequest);
            return new AsyncInvoker<UpdateRecycleBinPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRecycleBinPolicyResponse>);
        }
        
        /// <summary>
        /// 更新计划事件
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScheduledEventResponse> UpdateScheduledEventAsync(UpdateScheduledEventRequest updateScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledEventRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScheduledEventRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScheduledEventResponse>(response);
        }

        public AsyncInvoker<UpdateScheduledEventResponse> UpdateScheduledEventAsyncInvoker(UpdateScheduledEventRequest updateScheduledEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledEventRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-scheduled-events/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScheduledEventRequest);
            return new AsyncInvoker<UpdateScheduledEventResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScheduledEventResponse>);
        }
        
        /// <summary>
        /// 修改云服务器
        ///
        /// 修改云服务器信息，目前支持修改云服务器名称及描述和hostname。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }

        public AsyncInvoker<UpdateServerResponse> UpdateServerAsyncInvoker(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            return new AsyncInvoker<UpdateServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServerResponse>);
        }
        
        /// <summary>
        /// 修改云服务器定时删除时间
        ///
        /// 修改按需服务器，设置定时删除时间。如果设置的定时删除时间为空字符串，表示取消定时删除。
        /// 
        /// 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ecs:cloudServers:put。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerAutoTerminateTimeResponse> UpdateServerAutoTerminateTimeAsync(UpdateServerAutoTerminateTimeRequest updateServerAutoTerminateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerAutoTerminateTimeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/update-auto-terminate-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerAutoTerminateTimeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateServerAutoTerminateTimeResponse>(response);
        }

        public AsyncInvoker<UpdateServerAutoTerminateTimeResponse> UpdateServerAutoTerminateTimeAsyncInvoker(UpdateServerAutoTerminateTimeRequest updateServerAutoTerminateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerAutoTerminateTimeRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/update-auto-terminate-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerAutoTerminateTimeRequest);
            return new AsyncInvoker<UpdateServerAutoTerminateTimeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateServerAutoTerminateTimeResponse>);
        }
        
        /// <summary>
        /// 修改云服务器挂载的单个磁盘信息
        ///
        /// 修改云服务器云主机挂载的单个磁盘信息。&#39;当前仅支持修改delete_on_termination字段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerBlockDeviceResponse> UpdateServerBlockDeviceAsync(UpdateServerBlockDeviceRequest updateServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerBlockDeviceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(updateServerBlockDeviceRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerBlockDeviceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateServerBlockDeviceResponse>(response);
        }

        public AsyncInvoker<UpdateServerBlockDeviceResponse> UpdateServerBlockDeviceAsyncInvoker(UpdateServerBlockDeviceRequest updateServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerBlockDeviceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(updateServerBlockDeviceRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerBlockDeviceRequest);
            return new AsyncInvoker<UpdateServerBlockDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateServerBlockDeviceResponse>);
        }
        
        /// <summary>
        /// 更新云服务器网卡挂载信息
        ///
        /// 更新云服务器网卡挂载信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerInterfaceResponse> UpdateServerInterfaceAsync(UpdateServerInterfaceRequest updateServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(updateServerInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerInterfaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateServerInterfaceResponse>(response);
        }

        public AsyncInvoker<UpdateServerInterfaceResponse> UpdateServerInterfaceAsyncInvoker(UpdateServerInterfaceRequest updateServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerInterfaceRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            if (StringUtils.TryConvertToNonEmptyString(updateServerInterfaceRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerInterfaceRequest);
            return new AsyncInvoker<UpdateServerInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateServerInterfaceResponse>);
        }
        
        /// <summary>
        /// 更新云服务器元数据
        ///
        /// 更新云服务器元数据。
        /// 
        /// - 如果元数据中没有待更新字段，则自动添加该字段。
        /// 
        /// - 如果元数据中已存在待更新字段，则直接更新字段值。
        /// 
        /// - 如果元数据中的字段不再请求参数中，则保持不变
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerMetadataResponse> UpdateServerMetadataAsync(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerMetadataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateServerMetadataResponse>(response);
        }

        public AsyncInvoker<UpdateServerMetadataResponse> UpdateServerMetadataAsyncInvoker(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerMetadataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            return new AsyncInvoker<UpdateServerMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateServerMetadataResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 返回Nova当前所有可用的版本。
        /// 
        /// 为了支持功能不断扩展，Nova API支持版本号区分。Nova中有两种形式的版本号：
        /// 
        /// - \&quot;主版本号\&quot;: 具有独立的url。
        /// - \&quot;微版本号\&quot;: 通过Http请求头X-OpenStack-Nova-API-Version来使用，从2.27版本后更改为OpenStack-API-Version。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListVersionsResponse> NovaListVersionsAsync(NovaListVersionsRequest novaListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaListVersionsResponse>(response);
        }

        public AsyncInvoker<NovaListVersionsResponse> NovaListVersionsAsyncInvoker(NovaListVersionsRequest novaListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListVersionsRequest);
            return new AsyncInvoker<NovaListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListVersionsResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 返回指定版本的信息。
        /// 为了支持功能不断扩展，Nova API支持版本号区分。Nova中有两种形式的版本号：
        /// 
        /// - \&quot;主版本号\&quot;: 具有独立的url。
        /// - \&quot;微版本号\&quot;: 通过Http请求头X-OpenStack-Nova-API-Version来使用，从2.27版本后更改为OpenStack-API-Version。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaShowVersionResponse> NovaShowVersionAsync(NovaShowVersionRequest novaShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NovaShowVersionResponse>(response);
        }

        public AsyncInvoker<NovaShowVersionResponse> NovaShowVersionAsyncInvoker(NovaShowVersionRequest novaShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(novaShowVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowVersionRequest);
            return new AsyncInvoker<NovaShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowVersionResponse>);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        ///
        /// 查询Job的执行状态。
        /// 
        /// 对于创建云服务器、删除云服务器、云服务器批量操作和网卡操作等异步API，命令下发后，会返回job_id，通过job_id可以查询任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
    }
}