using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
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
        /// 添加云服务器组成员
        ///
        /// 将云服务器加入云服务器组。添加成功后，如果该云服务器组是反亲和性策略的，则该云服务器与云服务器组中的其他成员尽量分散地创建在不同主机上。如果该云服务器时故障域类型的，则该云服务器会拥有故障域属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServerGroupMemberResponse AddServerGroupMember(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", addServerGroupMemberRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>(response);
        }

        public SyncInvoker<AddServerGroupMemberResponse> AddServerGroupMemberInvoker(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", addServerGroupMemberRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            return new SyncInvoker<AddServerGroupMemberResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>);
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
        public AssociateServerVirtualIpResponse AssociateServerVirtualIp(AssociateServerVirtualIpRequest associateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id", associateServerVirtualIpRequest.NicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateServerVirtualIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AssociateServerVirtualIpResponse>(response);
        }

        public SyncInvoker<AssociateServerVirtualIpResponse> AssociateServerVirtualIpInvoker(AssociateServerVirtualIpRequest associateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id", associateServerVirtualIpRequest.NicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateServerVirtualIpRequest);
            return new SyncInvoker<AssociateServerVirtualIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<AssociateServerVirtualIpResponse>);
        }
        
        /// <summary>
        /// 弹性云服务器挂载磁盘
        ///
        /// 把磁盘挂载到弹性云服务器上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachServerVolumeResponse AttachServerVolume(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachServerVolumeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
        }

        public SyncInvoker<AttachServerVolumeResponse> AttachServerVolumeInvoker(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachServerVolumeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            return new SyncInvoker<AttachServerVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachServerVolumeResponse>);
        }
        
        /// <summary>
        /// 批量添加云服务器网卡
        ///
        /// 给云服务器添加一张或多张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddServerNicsResponse BatchAddServerNics(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchAddServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
        }

        public SyncInvoker<BatchAddServerNicsResponse> BatchAddServerNicsInvoker(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchAddServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            return new SyncInvoker<BatchAddServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddServerNicsResponse>);
        }
        
        /// <summary>
        /// 批量挂载指定共享盘
        ///
        /// 将指定的共享磁盘一次性挂载到多个弹性云服务器，实现批量挂载。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAttachSharableVolumesResponse BatchAttachSharableVolumes(BatchAttachSharableVolumesRequest batchAttachSharableVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchAttachSharableVolumesRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/attachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAttachSharableVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachSharableVolumesResponse>(response);
        }

        public SyncInvoker<BatchAttachSharableVolumesResponse> BatchAttachSharableVolumesInvoker(BatchAttachSharableVolumesRequest batchAttachSharableVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id", batchAttachSharableVolumesRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/attachvolumes/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAttachSharableVolumesRequest);
            return new SyncInvoker<BatchAttachSharableVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachSharableVolumesResponse>);
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
        public BatchCreateServerTagsResponse BatchCreateServerTags(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchCreateServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateServerTagsResponse> BatchCreateServerTagsInvoker(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchCreateServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            return new SyncInvoker<BatchCreateServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除云服务器网卡
        ///
        /// 卸载并删除云服务器中的一张或多张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServerNicsResponse BatchDeleteServerNics(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServerNicsResponse> BatchDeleteServerNicsInvoker(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            return new SyncInvoker<BatchDeleteServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>);
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
        public BatchDeleteServerTagsResponse BatchDeleteServerTags(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServerTagsResponse> BatchDeleteServerTagsInvoker(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            return new SyncInvoker<BatchDeleteServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>);
        }
        
        /// <summary>
        /// 批量重启云服务器
        ///
        /// 根据给定的云服务器ID列表，批量重启云服务器，一次最多可以重启1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRebootServersResponse BatchRebootServers(BatchRebootServersRequest batchRebootServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
        }

        public SyncInvoker<BatchRebootServersResponse> BatchRebootServersInvoker(BatchRebootServersRequest batchRebootServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            return new SyncInvoker<BatchRebootServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebootServersResponse>);
        }
        
        /// <summary>
        /// 批量重置弹性云服务器密码
        ///
        /// 批量重置弹性云服务器管理帐号（root用户或Administrator用户）的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchResetServersPasswordResponse BatchResetServersPassword(BatchResetServersPasswordRequest batchResetServersPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-reset-passwords", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResetServersPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchResetServersPasswordResponse>(response);
        }

        public SyncInvoker<BatchResetServersPasswordResponse> BatchResetServersPasswordInvoker(BatchResetServersPasswordRequest batchResetServersPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-reset-passwords", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResetServersPasswordRequest);
            return new SyncInvoker<BatchResetServersPasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchResetServersPasswordResponse>);
        }
        
        /// <summary>
        /// 批量启动云服务器
        ///
        /// 根据给定的云服务器ID列表，批量启动云服务器，一次最多可以启动1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStartServersResponse BatchStartServers(BatchStartServersRequest batchStartServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
        }

        public SyncInvoker<BatchStartServersResponse> BatchStartServersInvoker(BatchStartServersRequest batchStartServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            return new SyncInvoker<BatchStartServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStartServersResponse>);
        }
        
        /// <summary>
        /// 批量关闭云服务器
        ///
        /// 根据给定的云服务器ID列表，批量关闭云服务器，一次最多可以关闭1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopServersResponse BatchStopServers(BatchStopServersRequest batchStopServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }

        public SyncInvoker<BatchStopServersResponse> BatchStopServersInvoker(BatchStopServersRequest batchStopServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            return new SyncInvoker<BatchStopServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopServersResponse>);
        }
        
        /// <summary>
        /// 批量修改弹性云服务器
        ///
        /// 批量修改弹性云服务器信息。
        /// 当前仅支持批量修改云服务器名称，一次最多可以修改1000台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateServersNameResponse BatchUpdateServersName(BatchUpdateServersNameRequest batchUpdateServersNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/server-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateServersNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateServersNameResponse>(response);
        }

        public SyncInvoker<BatchUpdateServersNameResponse> BatchUpdateServersNameInvoker(BatchUpdateServersNameRequest batchUpdateServersNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/server-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateServersNameRequest);
            return new SyncInvoker<BatchUpdateServersNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateServersNameResponse>);
        }
        
        /// <summary>
        /// 更换云服务器计费模式
        ///
        /// 更换云服务器的计费模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeServerChargeModeResponse ChangeServerChargeMode(ChangeServerChargeModeRequest changeServerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/actions/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerChargeModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerChargeModeResponse>(response);
        }

        public SyncInvoker<ChangeServerChargeModeResponse> ChangeServerChargeModeInvoker(ChangeServerChargeModeRequest changeServerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/actions/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerChargeModeRequest);
            return new SyncInvoker<ChangeServerChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerChargeModeResponse>);
        }
        
        /// <summary>
        /// 更新云服务器指定网卡属性
        ///
        /// 更新云服务器指定网卡属性，当前仅支持更新网卡IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeServerNetworkInterfaceResponse ChangeServerNetworkInterface(ChangeServerNetworkInterfaceRequest changeServerNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", changeServerNetworkInterfaceRequest.PortId.ToString());
            urlParam.Add("server_id", changeServerNetworkInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}/change-network-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerNetworkInterfaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<ChangeServerNetworkInterfaceResponse> ChangeServerNetworkInterfaceInvoker(ChangeServerNetworkInterfaceRequest changeServerNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", changeServerNetworkInterfaceRequest.PortId.ToString());
            urlParam.Add("server_id", changeServerNetworkInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}/change-network-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerNetworkInterfaceRequest);
            return new SyncInvoker<ChangeServerNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerNetworkInterfaceResponse>);
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
        public ChangeServerOsWithCloudInitResponse ChangeServerOsWithCloudInit(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerOsWithCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>(response);
        }

        public SyncInvoker<ChangeServerOsWithCloudInitResponse> ChangeServerOsWithCloudInitInvoker(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerOsWithCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            return new SyncInvoker<ChangeServerOsWithCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>);
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
        public ChangeServerOsWithoutCloudInitResponse ChangeServerOsWithoutCloudInit(ChangeServerOsWithoutCloudInitRequest changeServerOsWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerOsWithoutCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithoutCloudInitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerOsWithoutCloudInitResponse>(response);
        }

        public SyncInvoker<ChangeServerOsWithoutCloudInitResponse> ChangeServerOsWithoutCloudInitInvoker(ChangeServerOsWithoutCloudInitRequest changeServerOsWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerOsWithoutCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithoutCloudInitRequest);
            return new SyncInvoker<ChangeServerOsWithoutCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerOsWithoutCloudInitResponse>);
        }
        
        /// <summary>
        /// 云服务器切换虚拟私有云
        ///
        /// 云服务器切换虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeVpcResponse ChangeVpc(ChangeVpcRequest changeVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeVpcRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changevpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVpcRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeVpcResponse>(response);
        }

        public SyncInvoker<ChangeVpcResponse> ChangeVpcInvoker(ChangeVpcRequest changeVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeVpcRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changevpc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVpcRequest);
            return new SyncInvoker<ChangeVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeVpcResponse>);
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
        public CreatePostPaidServersResponse CreatePostPaidServers(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }

        public SyncInvoker<CreatePostPaidServersResponse> CreatePostPaidServersInvoker(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            return new SyncInvoker<CreatePostPaidServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidServersResponse>);
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
        public CreateServerGroupResponse CreateServerGroup(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }

        public SyncInvoker<CreateServerGroupResponse> CreateServerGroupInvoker(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            return new SyncInvoker<CreateServerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServerGroupResponse>);
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
        public CreateServersResponse CreateServers(CreateServersRequest createServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
        }

        public SyncInvoker<CreateServersResponse> CreateServersInvoker(CreateServersRequest createServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            return new SyncInvoker<CreateServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServersResponse>);
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
        public DeleteServerGroupResponse DeleteServerGroup(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupResponse>(response);
        }

        public SyncInvoker<DeleteServerGroupResponse> DeleteServerGroupInvoker(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupRequest);
            return new SyncInvoker<DeleteServerGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupResponse>);
        }
        
        /// <summary>
        /// 删除云服务器组成员
        ///
        /// 将弹性云服务器移出云服务器组。移出后，该云服务器与云服务器组中的成员不再遵从反亲和策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerGroupMemberResponse DeleteServerGroupMember(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupMemberRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>(response);
        }

        public SyncInvoker<DeleteServerGroupMemberResponse> DeleteServerGroupMemberInvoker(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupMemberRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            return new SyncInvoker<DeleteServerGroupMemberResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>);
        }
        
        /// <summary>
        /// 删除云服务器指定元数据
        ///
        /// 删除云服务器指定元数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerMetadataResponse DeleteServerMetadata(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteServerMetadataRequest.Key.ToString());
            urlParam.Add("server_id", deleteServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerMetadataRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>(response);
        }

        public SyncInvoker<DeleteServerMetadataResponse> DeleteServerMetadataInvoker(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteServerMetadataRequest.Key.ToString());
            urlParam.Add("server_id", deleteServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerMetadataRequest);
            return new SyncInvoker<DeleteServerMetadataResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>);
        }
        
        /// <summary>
        /// 云服务器清除密码(企业项目)
        ///
        /// 清除Windows云服务器初始安装时系统生成的密码记录。清除密码后，不影响云服务器密码登录功能，但不能再使用获取密码功能来查询该云服务器密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerPasswordResponse DeleteServerPassword(DeleteServerPasswordRequest deleteServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerPasswordRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerPasswordResponse>(response);
        }

        public SyncInvoker<DeleteServerPasswordResponse> DeleteServerPasswordInvoker(DeleteServerPasswordRequest deleteServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerPasswordRequest);
            return new SyncInvoker<DeleteServerPasswordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerPasswordResponse>);
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
        public DeleteServersResponse DeleteServers(DeleteServersRequest deleteServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
        }

        public SyncInvoker<DeleteServersResponse> DeleteServersInvoker(DeleteServersRequest deleteServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            return new SyncInvoker<DeleteServersResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteServersResponse>);
        }
        
        /// <summary>
        /// 弹性云服务器卸载磁盘
        ///
        /// 从弹性云服务器中卸载磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachServerVolumeResponse DetachServerVolume(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id", detachServerVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachServerVolumeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
        }

        public SyncInvoker<DetachServerVolumeResponse> DetachServerVolumeInvoker(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id", detachServerVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachServerVolumeRequest);
            return new SyncInvoker<DetachServerVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DetachServerVolumeResponse>);
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
        public DisassociateServerVirtualIpResponse DisassociateServerVirtualIp(DisassociateServerVirtualIpRequest disassociateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id", disassociateServerVirtualIpRequest.NicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateServerVirtualIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<DisassociateServerVirtualIpResponse>(response);
        }

        public SyncInvoker<DisassociateServerVirtualIpResponse> DisassociateServerVirtualIpInvoker(DisassociateServerVirtualIpRequest disassociateServerVirtualIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id", disassociateServerVirtualIpRequest.NicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateServerVirtualIpRequest);
            return new SyncInvoker<DisassociateServerVirtualIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisassociateServerVirtualIpResponse>);
        }
        
        /// <summary>
        /// 查询云服务器列表接口
        ///
        /// 查询云服务器列表接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudServersResponse ListCloudServers(ListCloudServersRequest listCloudServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudServersResponse>(response);
        }

        public SyncInvoker<ListCloudServersResponse> ListCloudServersInvoker(ListCloudServersRequest listCloudServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServersRequest);
            return new SyncInvoker<ListCloudServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudServersResponse>);
        }
        
        /// <summary>
        /// 查询规格销售策略
        ///
        /// 查询规格销售策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorSellPoliciesResponse ListFlavorSellPolicies(ListFlavorSellPoliciesRequest listFlavorSellPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavor-sell-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorSellPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorSellPoliciesResponse>(response);
        }

        public SyncInvoker<ListFlavorSellPoliciesResponse> ListFlavorSellPoliciesInvoker(ListFlavorSellPoliciesRequest listFlavorSellPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavor-sell-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorSellPoliciesRequest);
            return new SyncInvoker<ListFlavorSellPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorSellPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        ///
        /// 查询云服务器规格详情信息和规格扩展信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public SyncInvoker<ListFlavorsResponse> ListFlavorsInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new SyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器规格变更支持列表
        ///
        /// 变更规格时，部分规格的云服务器之间不能互相变更。您可以通过本接口，通过指定弹性云服务器规格，查询该规格可以变更的规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResizeFlavorsResponse ListResizeFlavors(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResizeFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResizeFlavorsResponse>(response);
        }

        public SyncInvoker<ListResizeFlavorsResponse> ListResizeFlavorsInvoker(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResizeFlavorsRequest);
            return new SyncInvoker<ListResizeFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResizeFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 查询可用区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerAzInfoResponse ListServerAzInfo(ListServerAzInfoRequest listServerAzInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerAzInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerAzInfoResponse>(response);
        }

        public SyncInvoker<ListServerAzInfoResponse> ListServerAzInfoInvoker(ListServerAzInfoRequest listServerAzInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerAzInfoRequest);
            return new SyncInvoker<ListServerAzInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerAzInfoResponse>);
        }
        
        /// <summary>
        /// 查询弹性云服务器挂载磁盘列表详情信息
        ///
        /// 查询弹性云服务器挂载的磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerBlockDevicesResponse ListServerBlockDevices(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerBlockDevicesRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerBlockDevicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
        }

        public SyncInvoker<ListServerBlockDevicesResponse> ListServerBlockDevicesInvoker(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerBlockDevicesRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerBlockDevicesRequest);
            return new SyncInvoker<ListServerBlockDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerBlockDevicesResponse>);
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
        public ListServerGroupsResponse ListServerGroups(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupsResponse>(response);
        }

        public SyncInvoker<ListServerGroupsResponse> ListServerGroupsInvoker(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            return new SyncInvoker<ListServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器网卡信息
        ///
        /// 查询云服务器网卡信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerInterfacesResponse ListServerInterfaces(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerInterfacesRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerInterfacesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
        }

        public SyncInvoker<ListServerInterfacesResponse> ListServerInterfacesInvoker(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerInterfacesRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerInterfacesRequest);
            return new SyncInvoker<ListServerInterfacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerInterfacesResponse>);
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
        public ListServerTagsResponse ListServerTags(ListServerTagsRequest listServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerTagsResponse>(response);
        }

        public SyncInvoker<ListServerTagsResponse> ListServerTagsInvoker(ListServerTagsRequest listServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerTagsRequest);
            return new SyncInvoker<ListServerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerTagsResponse>);
        }
        
        /// <summary>
        /// 按标签查询云服务器列表
        ///
        /// 使用标签过滤弹性云服务器，并返回云服务器使用的所有标签和资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListServersByTagResponse ListServersByTag(ListServersByTagRequest listServersByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listServersByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListServersByTagResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListServersByTagResponse> ListServersByTagInvoker(ListServersByTagRequest listServersByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listServersByTagRequest);
            return new SyncInvoker<ListServersByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListServersByTagResponse>);
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
        public ListServersDetailsResponse ListServersDetails(ListServersDetailsRequest listServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }

        public SyncInvoker<ListServersDetailsResponse> ListServersDetailsInvoker(ListServersDetailsRequest listServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersDetailsRequest);
            return new SyncInvoker<ListServersDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersDetailsResponse>);
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
        public MigrateServerResponse MigrateServer(MigrateServerRequest migrateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", migrateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<MigrateServerResponse>(response);
        }

        public SyncInvoker<MigrateServerResponse> MigrateServerInvoker(MigrateServerRequest migrateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", migrateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateServerRequest);
            return new SyncInvoker<MigrateServerResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateServerResponse>);
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
        public NovaAssociateSecurityGroupResponse NovaAssociateSecurityGroup(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaAssociateSecurityGroupRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>(response);
        }

        public SyncInvoker<NovaAssociateSecurityGroupResponse> NovaAssociateSecurityGroupInvoker(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaAssociateSecurityGroupRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            return new SyncInvoker<NovaAssociateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 添加云服务器网卡
        ///
        /// 给云服务器添加一张网卡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaAttachInterfaceResponse NovaAttachInterface(NovaAttachInterfaceRequest novaAttachInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaAttachInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAttachInterfaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NovaAttachInterfaceResponse>(response);
        }

        public SyncInvoker<NovaAttachInterfaceResponse> NovaAttachInterfaceInvoker(NovaAttachInterfaceRequest novaAttachInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaAttachInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAttachInterfaceRequest);
            return new SyncInvoker<NovaAttachInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaAttachInterfaceResponse>);
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
        public NovaCreateKeypairResponse NovaCreateKeypair(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NovaCreateKeypairResponse>(response);
        }

        public SyncInvoker<NovaCreateKeypairResponse> NovaCreateKeypairInvoker(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            return new SyncInvoker<NovaCreateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaCreateKeypairResponse>);
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
        public NovaCreateServersResponse NovaCreateServers(NovaCreateServersRequest novaCreateServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }

        public SyncInvoker<NovaCreateServersResponse> NovaCreateServersInvoker(NovaCreateServersRequest novaCreateServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            return new SyncInvoker<NovaCreateServersResponse>(this, "POST", request, JsonUtils.DeSerialize<NovaCreateServersResponse>);
        }
        
        /// <summary>
        /// 删除SSH密钥
        ///
        /// 根据SSH密钥的名称，删除指定SSH密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaDeleteKeypairResponse NovaDeleteKeypair(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", novaDeleteKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteKeypairRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>(response);
        }

        public SyncInvoker<NovaDeleteKeypairResponse> NovaDeleteKeypairInvoker(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", novaDeleteKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteKeypairRequest);
            return new SyncInvoker<NovaDeleteKeypairResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>);
        }
        
        /// <summary>
        /// 删除云服务器
        ///
        /// 删除一台云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaDeleteServerResponse NovaDeleteServer(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaDeleteServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteServerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }

        public SyncInvoker<NovaDeleteServerResponse> NovaDeleteServerInvoker(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaDeleteServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteServerRequest);
            return new SyncInvoker<NovaDeleteServerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NovaDeleteServerResponse>);
        }
        
        /// <summary>
        /// 移除安全组
        ///
        /// 移除弹性云服务器中的安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaDisassociateSecurityGroupResponse NovaDisassociateSecurityGroup(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaDisassociateSecurityGroupRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>(response);
        }

        public SyncInvoker<NovaDisassociateSecurityGroupResponse> NovaDisassociateSecurityGroupInvoker(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaDisassociateSecurityGroupRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            return new SyncInvoker<NovaDisassociateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 查询可用域列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public NovaListAvailabilityZonesResponse NovaListAvailabilityZones(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListAvailabilityZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<NovaListAvailabilityZonesResponse> NovaListAvailabilityZonesInvoker(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListAvailabilityZonesRequest);
            return new SyncInvoker<NovaListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥列表
        ///
        /// 查询SSH密钥信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaListKeypairsResponse NovaListKeypairs(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListKeypairsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaListKeypairsResponse>(response);
        }

        public SyncInvoker<NovaListKeypairsResponse> NovaListKeypairsInvoker(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListKeypairsRequest);
            return new SyncInvoker<NovaListKeypairsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListKeypairsResponse>);
        }
        
        /// <summary>
        /// 查询指定云服务器安全组列表
        ///
        /// 查询指定弹性云服务器的安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaListServerSecurityGroupsResponse NovaListServerSecurityGroups(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaListServerSecurityGroupsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServerSecurityGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>(response);
        }

        public SyncInvoker<NovaListServerSecurityGroupsResponse> NovaListServerSecurityGroupsInvoker(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaListServerSecurityGroupsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServerSecurityGroupsRequest);
            return new SyncInvoker<NovaListServerSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        ///
        /// 查询云服务器详情信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaListServersDetailsResponse NovaListServersDetails(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
        }

        public SyncInvoker<NovaListServersDetailsResponse> NovaListServersDetailsInvoker(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersDetailsRequest);
            return new SyncInvoker<NovaListServersDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListServersDetailsResponse>);
        }
        
        /// <summary>
        /// 查询云服务器规格extra_specs的详情
        ///
        /// 查询指定的规格的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaShowFlavorExtraSpecsResponse NovaShowFlavorExtraSpecs(NovaShowFlavorExtraSpecsRequest novaShowFlavorExtraSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id", novaShowFlavorExtraSpecsRequest.FlavorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/flavors/{flavor_id}/os-extra_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowFlavorExtraSpecsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaShowFlavorExtraSpecsResponse>(response);
        }

        public SyncInvoker<NovaShowFlavorExtraSpecsResponse> NovaShowFlavorExtraSpecsInvoker(NovaShowFlavorExtraSpecsRequest novaShowFlavorExtraSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id", novaShowFlavorExtraSpecsRequest.FlavorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/flavors/{flavor_id}/os-extra_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowFlavorExtraSpecsRequest);
            return new SyncInvoker<NovaShowFlavorExtraSpecsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowFlavorExtraSpecsResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥详情
        ///
        /// 根据SSH密钥名称查询指定SSH密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaShowKeypairResponse NovaShowKeypair(NovaShowKeypairRequest novaShowKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", novaShowKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowKeypairRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaShowKeypairResponse>(response);
        }

        public SyncInvoker<NovaShowKeypairResponse> NovaShowKeypairInvoker(NovaShowKeypairRequest novaShowKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", novaShowKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowKeypairRequest);
            return new SyncInvoker<NovaShowKeypairResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowKeypairResponse>);
        }
        
        /// <summary>
        /// 查询云服务器详情
        ///
        /// 根据云服务器ID，查询云服务器的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaShowServerResponse NovaShowServer(NovaShowServerRequest novaShowServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaShowServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }

        public SyncInvoker<NovaShowServerResponse> NovaShowServerInvoker(NovaShowServerRequest novaShowServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", novaShowServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerRequest);
            return new SyncInvoker<NovaShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowServerResponse>);
        }
        
        /// <summary>
        /// 查询指定云服务器网卡信息
        ///
        /// 根据网卡ID，查询云服务器网卡信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NovaShowServerInterfaceResponse NovaShowServerInterface(NovaShowServerInterfaceRequest novaShowServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", novaShowServerInterfaceRequest.PortId.ToString());
            urlParam.Add("server_id", novaShowServerInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerInterfaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaShowServerInterfaceResponse>(response);
        }

        public SyncInvoker<NovaShowServerInterfaceResponse> NovaShowServerInterfaceInvoker(NovaShowServerInterfaceRequest novaShowServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", novaShowServerInterfaceRequest.PortId.ToString());
            urlParam.Add("server_id", novaShowServerInterfaceRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerInterfaceRequest);
            return new SyncInvoker<NovaShowServerInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowServerInterfaceResponse>);
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
        public RegisterServerMonitorResponse RegisterServerMonitor(RegisterServerMonitorRequest registerServerMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", registerServerMonitorRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerMonitorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterServerMonitorResponse>(response);
        }

        public SyncInvoker<RegisterServerMonitorResponse> RegisterServerMonitorInvoker(RegisterServerMonitorRequest registerServerMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", registerServerMonitorRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/servers/{server_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerMonitorRequest);
            return new SyncInvoker<RegisterServerMonitorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterServerMonitorResponse>);
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
        public ReinstallServerWithCloudInitResponse ReinstallServerWithCloudInit(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerWithCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>(response);
        }

        public SyncInvoker<ReinstallServerWithCloudInitResponse> ReinstallServerWithCloudInitInvoker(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerWithCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            return new SyncInvoker<ReinstallServerWithCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>);
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
        public ReinstallServerWithoutCloudInitResponse ReinstallServerWithoutCloudInit(ReinstallServerWithoutCloudInitRequest reinstallServerWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerWithoutCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithoutCloudInitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerWithoutCloudInitResponse>(response);
        }

        public SyncInvoker<ReinstallServerWithoutCloudInitResponse> ReinstallServerWithoutCloudInitInvoker(ReinstallServerWithoutCloudInitRequest reinstallServerWithoutCloudInitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerWithoutCloudInitRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithoutCloudInitRequest);
            return new SyncInvoker<ReinstallServerWithoutCloudInitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerWithoutCloudInitResponse>);
        }
        
        /// <summary>
        /// 一键重置弹性云服务器密码(企业项目)
        ///
        /// 重置弹性云服务器管理帐号（root用户或Administrator用户）的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetServerPasswordResponse ResetServerPassword(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resetServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetServerPasswordResponse>(response);
        }

        public SyncInvoker<ResetServerPasswordResponse> ResetServerPasswordInvoker(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resetServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            return new SyncInvoker<ResetServerPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetServerPasswordResponse>);
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
        public ResizePostPaidServerResponse ResizePostPaidServer(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resizePostPaidServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }

        public SyncInvoker<ResizePostPaidServerResponse> ResizePostPaidServerInvoker(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resizePostPaidServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            return new SyncInvoker<ResizePostPaidServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizePostPaidServerResponse>);
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
        public ResizeServerResponse ResizeServer(ResizeServerRequest resizeServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resizeServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeServerResponse>(response);
        }

        public SyncInvoker<ResizeServerResponse> ResizeServerInvoker(ResizeServerRequest resizeServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resizeServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            return new SyncInvoker<ResizeServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeServerResponse>);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        ///
        /// 查询弹性云服务器是否支持一键重置密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResetPasswordFlagResponse ShowResetPasswordFlag(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showResetPasswordFlagRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPasswordFlagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>(response);
        }

        public SyncInvoker<ShowResetPasswordFlagResponse> ShowResetPasswordFlagInvoker(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showResetPasswordFlagRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPasswordFlagRequest);
            return new SyncInvoker<ShowResetPasswordFlagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>);
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
        public ShowServerResponse ShowServer(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public SyncInvoker<ShowServerResponse> ShowServerInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new SyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询弹性云服务器单个磁盘信息
        ///
        /// 查询弹性云服务器挂载的单个磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerBlockDeviceResponse ShowServerBlockDevice(ShowServerBlockDeviceRequest showServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id", showServerBlockDeviceRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerBlockDeviceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerBlockDeviceResponse>(response);
        }

        public SyncInvoker<ShowServerBlockDeviceResponse> ShowServerBlockDeviceInvoker(ShowServerBlockDeviceRequest showServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id", showServerBlockDeviceRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerBlockDeviceRequest);
            return new SyncInvoker<ShowServerBlockDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerBlockDeviceResponse>);
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
        public ShowServerGroupResponse ShowServerGroup(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupResponse>(response);
        }

        public SyncInvoker<ShowServerGroupResponse> ShowServerGroupInvoker(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            return new SyncInvoker<ShowServerGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerLimitsResponse ShowServerLimits(ShowServerLimitsRequest showServerLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerLimitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerLimitsResponse>(response);
        }

        public SyncInvoker<ShowServerLimitsResponse> ShowServerLimitsInvoker(ShowServerLimitsRequest showServerLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerLimitsRequest);
            return new SyncInvoker<ShowServerLimitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerLimitsResponse>);
        }
        
        /// <summary>
        /// 云服务器获取密码(企业项目)
        ///
        /// 当通过支持Cloudbase-init功能的镜像创建Windows云服务器时，获取云服务器初始安装时系统生成的管理员帐户（Administrator帐户或Cloudbase-init设置的帐户）随机密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerPasswordResponse ShowServerPassword(ShowServerPasswordRequest showServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerPasswordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerPasswordResponse>(response);
        }

        public SyncInvoker<ShowServerPasswordResponse> ShowServerPasswordInvoker(ShowServerPasswordRequest showServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerPasswordRequest);
            return new SyncInvoker<ShowServerPasswordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerPasswordResponse>);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        ///
        /// 获取弹性云服务器VNC远程登录地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerRemoteConsoleResponse ShowServerRemoteConsole(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRemoteConsoleRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
        }

        public SyncInvoker<ShowServerRemoteConsoleResponse> ShowServerRemoteConsoleInvoker(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRemoteConsoleRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            return new SyncInvoker<ShowServerRemoteConsoleResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>);
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
        public ShowServerTagsResponse ShowServerTags(ShowServerTagsRequest showServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
        }

        public SyncInvoker<ShowServerTagsResponse> ShowServerTagsInvoker(ShowServerTagsRequest showServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerTagsRequest);
            return new SyncInvoker<ShowServerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerTagsResponse>);
        }
        
        /// <summary>
        /// 修改云服务器
        ///
        /// 修改云服务器信息，目前支持修改云服务器名称及描述和hostname。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServerResponse UpdateServer(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }

        public SyncInvoker<UpdateServerResponse> UpdateServerInvoker(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            return new SyncInvoker<UpdateServerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServerResponse>);
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
        public UpdateServerAutoTerminateTimeResponse UpdateServerAutoTerminateTime(UpdateServerAutoTerminateTimeRequest updateServerAutoTerminateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerAutoTerminateTimeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/update-auto-terminate-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerAutoTerminateTimeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateServerAutoTerminateTimeResponse>(response);
        }

        public SyncInvoker<UpdateServerAutoTerminateTimeResponse> UpdateServerAutoTerminateTimeInvoker(UpdateServerAutoTerminateTimeRequest updateServerAutoTerminateTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerAutoTerminateTimeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/update-auto-terminate-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerAutoTerminateTimeRequest);
            return new SyncInvoker<UpdateServerAutoTerminateTimeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateServerAutoTerminateTimeResponse>);
        }
        
        /// <summary>
        /// 修改云服务器挂载的单个磁盘信息
        ///
        /// 修改云服务器云主机挂载的单个磁盘信息。&#39;当前仅支持修改delete_on_termination字段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServerBlockDeviceResponse UpdateServerBlockDevice(UpdateServerBlockDeviceRequest updateServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id", updateServerBlockDeviceRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerBlockDeviceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateServerBlockDeviceResponse>(response);
        }

        public SyncInvoker<UpdateServerBlockDeviceResponse> UpdateServerBlockDeviceInvoker(UpdateServerBlockDeviceRequest updateServerBlockDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id", updateServerBlockDeviceRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerBlockDeviceRequest);
            return new SyncInvoker<UpdateServerBlockDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateServerBlockDeviceResponse>);
        }
        
        /// <summary>
        /// 更新云服务器网卡挂载信息
        ///
        /// 更新云服务器网卡挂载信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServerInterfaceResponse UpdateServerInterface(UpdateServerInterfaceRequest updateServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerInterfaceRequest.ServerId.ToString());
            urlParam.Add("port_id", updateServerInterfaceRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerInterfaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateServerInterfaceResponse>(response);
        }

        public SyncInvoker<UpdateServerInterfaceResponse> UpdateServerInterfaceInvoker(UpdateServerInterfaceRequest updateServerInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerInterfaceRequest.ServerId.ToString());
            urlParam.Add("port_id", updateServerInterfaceRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerInterfaceRequest);
            return new SyncInvoker<UpdateServerInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateServerInterfaceResponse>);
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
        public UpdateServerMetadataResponse UpdateServerMetadata(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateServerMetadataResponse>(response);
        }

        public SyncInvoker<UpdateServerMetadataResponse> UpdateServerMetadataInvoker(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            return new SyncInvoker<UpdateServerMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateServerMetadataResponse>);
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
        public NovaListVersionsResponse NovaListVersions(NovaListVersionsRequest novaListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaListVersionsResponse>(response);
        }

        public SyncInvoker<NovaListVersionsResponse> NovaListVersionsInvoker(NovaListVersionsRequest novaListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListVersionsRequest);
            return new SyncInvoker<NovaListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaListVersionsResponse>);
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
        public NovaShowVersionResponse NovaShowVersion(NovaShowVersionRequest novaShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", novaShowVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NovaShowVersionResponse>(response);
        }

        public SyncInvoker<NovaShowVersionResponse> NovaShowVersionInvoker(NovaShowVersionRequest novaShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", novaShowVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowVersionRequest);
            return new SyncInvoker<NovaShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<NovaShowVersionResponse>);
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
        
    }
}