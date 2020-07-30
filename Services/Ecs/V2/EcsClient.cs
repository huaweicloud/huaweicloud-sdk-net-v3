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
        /// 云服务器组添加成员
        /// </summary>
        public AddServerGroupMemberResponse AddServerGroupMember(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , addServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }
        
        /// <summary>
        /// 切换弹性云服务器操作系统(安装Cloud init)
        /// </summary>
        public ChangeServerOsWithCloudInitResponse ChangeServerOsWithCloudInit(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeServerOsWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器(按需)
        /// </summary>
        public CreatePostPaidServersResponse CreatePostPaidServers(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器组
        /// </summary>
        public CreateServerGroupResponse CreateServerGroup(CreateServerGroupRequest createServerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public CreateServersResponse CreateServers(CreateServersRequest createServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器组
        /// </summary>
        public DeleteServerGroupResponse DeleteServerGroup(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteServerGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupResponse>(response);
        }
        
        /// <summary>
        /// 云服务器组删除成员
        /// </summary>
        public DeleteServerGroupMemberResponse DeleteServerGroupMember(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器指定元数据
        /// </summary>
        public DeleteServerMetadataResponse DeleteServerMetadata(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteServerMetadataRequest.Key.ToString());
            urlParam.Add("server_id" , deleteServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteServerMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public DeleteServersResponse DeleteServers(DeleteServersRequest deleteServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器规格变更支持列表
        /// </summary>
        public ListResizeFlavorsResponse ListResizeFlavors(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listResizeFlavorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListResizeFlavorsResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 添加安全组
        /// </summary>
        public NovaAssociateSecurityGroupResponse NovaAssociateSecurityGroup(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaAssociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥
        /// </summary>
        public NovaCreateKeypairResponse NovaCreateKeypair(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public NovaCreateServersResponse NovaCreateServers(NovaCreateServersRequest novaCreateServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除SSH密钥
        /// </summary>
        public NovaDeleteKeypairResponse NovaDeleteKeypair(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , novaDeleteKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaDeleteKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }
        
        /// <summary>
        /// 移除安全组
        /// </summary>
        public NovaDisassociateSecurityGroupResponse NovaDisassociateSecurityGroup(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDisassociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区列表
        /// </summary>
        public NovaListAvailabilityZonesResponse NovaListAvailabilityZones(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListAvailabilityZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥列表
        /// </summary>
        public NovaListKeypairsResponse NovaListKeypairs(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListKeypairsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NovaListKeypairsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定云服务器安全组列表
        /// </summary>
        public NovaListServerSecurityGroupsResponse NovaListServerSecurityGroups(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaListServerSecurityGroupsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServerSecurityGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public NovaListServersDetailsResponse NovaListServersDetails(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServersDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }
        
        /// <summary>
        /// 重装弹性云服务器操作系统(安装Cloud-init)
        /// </summary>
        public ReinstallServerWithCloudInitResponse ReinstallServerWithCloudInit(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallServerWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>(response);
        }
        
        /// <summary>
        /// 一键重置弹性云服务器密码(企业项目)
        /// </summary>
        public ResetServerPasswordResponse ResetServerPassword(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetServerPasswordResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }
        
        /// <summary>
        /// 变更云服务器规格
        /// </summary>
        public ResizeServerResponse ResizeServer(ResizeServerRequest resizeServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizeServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeServerResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        /// </summary>
        public ShowResetPasswordFlagResponse ShowResetPasswordFlag(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPasswordFlagRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showResetPasswordFlagRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public ShowServerLimitsResponse ShowServerLimits(ShowServerLimitsRequest showServerLimitsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerLimitsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowServerLimitsResponse>(response);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        /// </summary>
        public ShowServerRemoteConsoleResponse ShowServerRemoteConsole(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRemoteConsoleRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
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
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }
        
        /// <summary>
        /// 更新云服务器元数据
        /// </summary>
        public UpdateServerMetadataResponse UpdateServerMetadata(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateServerMetadataResponse>(response);
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
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
    }
}