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
        /// 添加云服务器组成员
        ///
        /// 将云服务器加入云服务器组。添加成功后，如果该云服务器组是反亲和性策略的，则该云服务器与云服务器组中的其他成员尽量分散地创建在不同主机上。如果该云服务器时故障域类型的，则该云服务器会拥有故障域属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddServerGroupMemberResponse> AddServerGroupMemberAsync(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , addServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id" , associateServerVirtualIpRequest.NicId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateServerVirtualIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AssociateServerVirtualIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchAddServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchAttachSharableVolumesRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/batchaction/attachvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAttachSharableVolumesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAttachSharableVolumesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchCreateServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-reset-passwords",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResetServersPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchResetServersPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/server-name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateServersNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateServersNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/actions/change-charge-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerChargeModeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeServerChargeModeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeServerOsWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeServerOsWithoutCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/changeos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithoutCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeServerOsWithoutCloudInitResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteServerMetadataRequest.Key.ToString());
            urlParam.Add("server_id" , deleteServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , deleteServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id" , detachServerVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nic_id" , disassociateServerVirtualIpRequest.NicId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/nics/{nic_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateServerVirtualIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<DisassociateServerVirtualIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavor-sell-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorSellPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorSellPoliciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResizeFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResizeFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性云服务器磁盘信息
        ///
        /// 查询弹性云服务器挂载的磁盘信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerBlockDevicesResponse> ListServerBlockDevicesAsync(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerBlockDevicesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerBlockDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerInterfacesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerInterfacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询云服务器列表
        ///
        /// 使用标签过滤弹性云服务器，并返回云服务器使用的所有标签和资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServersByTagResponse> ListServersByTagAsync(ListServersByTagRequest listServersByTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listServersByTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListServersByTagResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , migrateServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<MigrateServerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaAssociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaAttachInterfaceRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAttachInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaAttachInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateKeypairResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , novaDeleteKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDeleteServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaDeleteServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDisassociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 查询可用域列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NovaListAvailabilityZonesResponse> NovaListAvailabilityZonesAsync(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListAvailabilityZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListKeypairsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListKeypairsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaListServerSecurityGroupsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServerSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaListServersDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , novaShowKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaShowKeypairResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaShowServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", novaShowServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }
        
        /// <summary>
        /// 管理云服务器自动恢复动作
        ///
        /// 配置、删除云服务器自动恢复动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterServerAutoRecoveryResponse> RegisterServerAutoRecoveryAsync(RegisterServerAutoRecoveryRequest registerServerAutoRecoveryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , registerServerAutoRecoveryRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/autorecovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerAutoRecoveryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<RegisterServerAutoRecoveryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , registerServerMonitorRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerServerMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RegisterServerMonitorResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallServerWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallServerWithoutCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithoutCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ReinstallServerWithoutCloudInitResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetServerPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizePostPaidServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizeServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeServerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPasswordFlagRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPasswordFlagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器是否配置了自动恢复动作
        ///
        /// 查询云服务器是否配置了自动恢复动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerAutoRecoveryResponse> ShowServerAutoRecoveryAsync(ShowServerAutoRecoveryRequest showServerAutoRecoveryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerAutoRecoveryRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/autorecovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerAutoRecoveryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerAutoRecoveryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id" , showServerBlockDeviceRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerBlockDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerBlockDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , showServerGroupRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerLimitsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerLimitsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRemoteConsoleRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务器销毁时间
        ///
        /// 修改按需服务器，设置定时销毁时间。如果设置的销毁时间为空，表示取消销毁时间。
        /// 
        /// 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ecs:cloudServers:put。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerAutoTerminateTimeResponse> UpdateServerAutoTerminateTimeAsync(UpdateServerAutoTerminateTimeRequest updateServerAutoTerminateTimeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerAutoTerminateTimeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/actions/update-auto-terminate-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerAutoTerminateTimeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateServerAutoTerminateTimeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerBlockDeviceRequest.ServerId.ToString());
            urlParam.Add("volume_id" , updateServerBlockDeviceRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerBlockDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateServerBlockDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateServerMetadataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
    }
}