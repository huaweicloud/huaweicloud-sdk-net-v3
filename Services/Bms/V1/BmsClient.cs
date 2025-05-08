using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bms.V1.Model;

namespace HuaweiCloud.SDK.Bms.V1
{
    public partial class BmsClient : Client
    {
        public static ClientBuilder<BmsClient> NewBuilder()
        {
            return new ClientBuilder<BmsClient>();
        }

        
        /// <summary>
        /// 裸金属服务器绑定弹性网卡
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServerNicsResponse AddServerNics(AddServerNicsRequest addServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", addServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerNicsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddServerNicsResponse>(response);
        }

        public SyncInvoker<AddServerNicsResponse> AddServerNicsInvoker(AddServerNicsRequest addServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", addServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/nics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerNicsRequest);
            return new SyncInvoker<AddServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServerNicsResponse>);
        }
        
        /// <summary>
        /// 裸金属服务器挂载云硬盘
        ///
        /// 裸金属服务器创建成功后，如果发现磁盘不够用或者当前磁盘不满足要求，可以将已有云硬盘挂载给裸金属服务器，作为数据盘使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachBaremetalServerVolumeResponse AttachBaremetalServerVolume(AttachBaremetalServerVolumeRequest attachBaremetalServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachBaremetalServerVolumeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBaremetalServerVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachBaremetalServerVolumeResponse>(response);
        }

        public SyncInvoker<AttachBaremetalServerVolumeResponse> AttachBaremetalServerVolumeInvoker(AttachBaremetalServerVolumeRequest attachBaremetalServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachBaremetalServerVolumeRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/attachvolume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBaremetalServerVolumeRequest);
            return new SyncInvoker<AttachBaremetalServerVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachBaremetalServerVolumeResponse>);
        }
        
        /// <summary>
        /// 批量添加裸金属服务器标签
        ///
        /// - 为指定裸金属服务器批量添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateBaremetalServerTagsResponse BatchCreateBaremetalServerTags(BatchCreateBaremetalServerTagsRequest batchCreateBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchCreateBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateBaremetalServerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateBaremetalServerTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateBaremetalServerTagsResponse> BatchCreateBaremetalServerTagsInvoker(BatchCreateBaremetalServerTagsRequest batchCreateBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchCreateBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateBaremetalServerTagsRequest);
            return new SyncInvoker<BatchCreateBaremetalServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateBaremetalServerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除裸金属服务器标签
        ///
        /// - 为指定云服务器批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteBaremetalServerTagsResponse BatchDeleteBaremetalServerTags(BatchDeleteBaremetalServerTagsRequest batchDeleteBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteBaremetalServerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteBaremetalServerTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteBaremetalServerTagsResponse> BatchDeleteBaremetalServerTagsInvoker(BatchDeleteBaremetalServerTagsRequest batchDeleteBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", batchDeleteBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteBaremetalServerTagsRequest);
            return new SyncInvoker<BatchDeleteBaremetalServerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteBaremetalServerTagsResponse>);
        }
        
        /// <summary>
        /// 重启裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量重启裸金属服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRebootBaremetalServersResponse BatchRebootBaremetalServers(BatchRebootBaremetalServersRequest batchRebootBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootBaremetalServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRebootBaremetalServersResponse>(response);
        }

        public SyncInvoker<BatchRebootBaremetalServersResponse> BatchRebootBaremetalServersInvoker(BatchRebootBaremetalServersRequest batchRebootBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootBaremetalServersRequest);
            return new SyncInvoker<BatchRebootBaremetalServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebootBaremetalServersResponse>);
        }
        
        /// <summary>
        /// 启动裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量启动裸金属服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStartBaremetalServersResponse BatchStartBaremetalServers(BatchStartBaremetalServersRequest batchStartBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartBaremetalServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStartBaremetalServersResponse>(response);
        }

        public SyncInvoker<BatchStartBaremetalServersResponse> BatchStartBaremetalServersInvoker(BatchStartBaremetalServersRequest batchStartBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartBaremetalServersRequest);
            return new SyncInvoker<BatchStartBaremetalServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStartBaremetalServersResponse>);
        }
        
        /// <summary>
        /// 关闭裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量关闭裸金属服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopBaremetalServersResponse BatchStopBaremetalServers(BatchStopBaremetalServersRequest batchStopBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopBaremetalServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopBaremetalServersResponse>(response);
        }

        public SyncInvoker<BatchStopBaremetalServersResponse> BatchStopBaremetalServersInvoker(BatchStopBaremetalServersRequest batchStopBaremetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopBaremetalServersRequest);
            return new SyncInvoker<BatchStopBaremetalServersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopBaremetalServersResponse>);
        }
        
        /// <summary>
        /// 修改裸金属服务器名称
        ///
        /// 修改裸金属服务器名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeBaremetalServerNameResponse ChangeBaremetalServerName(ChangeBaremetalServerNameRequest changeBaremetalServerNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeBaremetalServerNameRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerNameResponse>(response);
        }

        public SyncInvoker<ChangeBaremetalServerNameResponse> ChangeBaremetalServerNameInvoker(ChangeBaremetalServerNameRequest changeBaremetalServerNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeBaremetalServerNameRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerNameRequest);
            return new SyncInvoker<ChangeBaremetalServerNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeBaremetalServerNameResponse>);
        }
        
        /// <summary>
        /// 切换裸金属服务器的操作系统
        ///
        /// 切换裸金属服务器的操作系统。切换操作系统支持密码或者密钥注入，该接口支持企业项目细粒度权限的校验，具体细粒度请参见 bms:servers:changeOS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeBaremetalServerOsResponse ChangeBaremetalServerOs(ChangeBaremetalServerOsRequest changeBaremetalServerOsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeBaremetalServerOsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerOsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerOsResponse>(response);
        }

        public SyncInvoker<ChangeBaremetalServerOsResponse> ChangeBaremetalServerOsInvoker(ChangeBaremetalServerOsRequest changeBaremetalServerOsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeBaremetalServerOsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/changeos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerOsRequest);
            return new SyncInvoker<ChangeBaremetalServerOsResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeBaremetalServerOsResponse>);
        }
        
        /// <summary>
        /// 创建裸金属服务器
        ///
        /// 创建一台或多台裸金属服务器,裸金属服务器的登录鉴权方式包括两种：密钥对、密码。为安全起见，推荐使用密钥对方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBareMetalServersResponse CreateBareMetalServers(CreateBareMetalServersRequest createBareMetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBareMetalServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBareMetalServersResponse>(response);
        }

        public SyncInvoker<CreateBareMetalServersResponse> CreateBareMetalServersInvoker(CreateBareMetalServersRequest createBareMetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBareMetalServersRequest);
            return new SyncInvoker<CreateBareMetalServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBareMetalServersResponse>);
        }
        
        /// <summary>
        /// 删除裸金属服务器裸金属服务器物理机
        ///
        /// 删除裸金属服务器裸金属服务器物理机
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBaremetalServerResponse DeleteBaremetalServer(DeleteBaremetalServerRequest deleteBaremetalServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBaremetalServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteBaremetalServerResponse>(response);
        }

        public SyncInvoker<DeleteBaremetalServerResponse> DeleteBaremetalServerInvoker(DeleteBaremetalServerRequest deleteBaremetalServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBaremetalServerRequest);
            return new SyncInvoker<DeleteBaremetalServerResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteBaremetalServerResponse>);
        }
        
        /// <summary>
        /// 裸金属服务器解绑弹性网卡
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerNicsResponse DeleteServerNics(DeleteServerNicsRequest deleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerNicsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteServerNicsResponse>(response);
        }

        public SyncInvoker<DeleteServerNicsResponse> DeleteServerNicsInvoker(DeleteServerNicsRequest deleteServerNicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerNicsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/nics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerNicsRequest);
            return new SyncInvoker<DeleteServerNicsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteServerNicsResponse>);
        }
        
        /// <summary>
        /// Windows裸金属服务器清除密码
        ///
        /// 清除Windows裸金属服务器初始安装时系统生成的密码记录。清除密码后，不影响裸金属服务器密码登录功能，但不能再使用获取密码功能来查询该裸金属服务器密码。如果裸金属服务器是通过私有镜像创建的，请确保已安装Cloudbase-init。公共镜像默认已安装该软件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWindowsBareMetalServerPasswordResponse DeleteWindowsBareMetalServerPassword(DeleteWindowsBareMetalServerPasswordRequest deleteWindowsBareMetalServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteWindowsBareMetalServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWindowsBareMetalServerPasswordRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWindowsBareMetalServerPasswordResponse>(response);
        }

        public SyncInvoker<DeleteWindowsBareMetalServerPasswordResponse> DeleteWindowsBareMetalServerPasswordInvoker(DeleteWindowsBareMetalServerPasswordRequest deleteWindowsBareMetalServerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteWindowsBareMetalServerPasswordRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWindowsBareMetalServerPasswordRequest);
            return new SyncInvoker<DeleteWindowsBareMetalServerPasswordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWindowsBareMetalServerPasswordResponse>);
        }
        
        /// <summary>
        /// 裸金属服务器卸载云磁盘
        ///
        /// 将挂载至裸金属服务器中的磁盘卸载；对于挂载在系统盘盘位（也就是“/dev/sda”挂载点）上的磁盘，不允许执行卸载操作；对于挂载在数据盘盘位（非“/dev/sda”挂载点）上的磁盘，支持离线卸载和在线卸载（裸金属服务器处于“运行中”状态）磁盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachBaremetalServerVolumeResponse DetachBaremetalServerVolume(DetachBaremetalServerVolumeRequest detachBaremetalServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", detachBaremetalServerVolumeRequest.ServerId.ToString());
            urlParam.Add("attachment_id", detachBaremetalServerVolumeRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/detachvolume/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachBaremetalServerVolumeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DetachBaremetalServerVolumeResponse>(response);
        }

        public SyncInvoker<DetachBaremetalServerVolumeResponse> DetachBaremetalServerVolumeInvoker(DetachBaremetalServerVolumeRequest detachBaremetalServerVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", detachBaremetalServerVolumeRequest.ServerId.ToString());
            urlParam.Add("attachment_id", detachBaremetalServerVolumeRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/detachvolume/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachBaremetalServerVolumeRequest);
            return new SyncInvoker<DetachBaremetalServerVolumeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DetachBaremetalServerVolumeResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情
        ///
        /// 获取裸金属服务器详细信息，该接口支持查询裸金属服务器的计费方式，以及是否被冻结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBareMetalServerDetailsResponse ListBareMetalServerDetails(ListBareMetalServerDetailsRequest listBareMetalServerDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listBareMetalServerDetailsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServerDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBareMetalServerDetailsResponse>(response);
        }

        public SyncInvoker<ListBareMetalServerDetailsResponse> ListBareMetalServerDetailsInvoker(ListBareMetalServerDetailsRequest listBareMetalServerDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listBareMetalServerDetailsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServerDetailsRequest);
            return new SyncInvoker<ListBareMetalServerDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBareMetalServerDetailsResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情列表
        ///
        /// 用户根据设置的请求条件筛选裸金属服务器，并获取裸金属服务器的详细信息。该接口支持查询裸金属服务器计费方式，以及是否被冻结。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBareMetalServersResponse ListBareMetalServers(ListBareMetalServersRequest listBareMetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBareMetalServersResponse>(response);
        }

        public SyncInvoker<ListBareMetalServersResponse> ListBareMetalServersInvoker(ListBareMetalServersRequest listBareMetalServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersRequest);
            return new SyncInvoker<ListBareMetalServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBareMetalServersResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器列表
        ///
        /// 用户根据设置的请求条件筛选裸金属服务器，并获取裸金属服务器的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBareMetalServersDetailResponse ListBareMetalServersDetail(ListBareMetalServersDetailRequest listBareMetalServersDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/baremetalservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBareMetalServersDetailResponse>(response);
        }

        public SyncInvoker<ListBareMetalServersDetailResponse> ListBareMetalServersDetailInvoker(ListBareMetalServersDetailRequest listBareMetalServersDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/baremetalservers/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersDetailRequest);
            return new SyncInvoker<ListBareMetalServersDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBareMetalServersDetailResponse>);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        ///
        /// 查询裸金属服务器的规格详情和规格的扩展信息。您可以调用此接口查询“baremetal:extBootType”参数取值，以确认某个规格是否支持快速发放
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBaremetalFlavorDetailExtendsResponse ListBaremetalFlavorDetailExtends(ListBaremetalFlavorDetailExtendsRequest listBaremetalFlavorDetailExtendsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBaremetalFlavorDetailExtendsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBaremetalFlavorDetailExtendsResponse>(response);
        }

        public SyncInvoker<ListBaremetalFlavorDetailExtendsResponse> ListBaremetalFlavorDetailExtendsInvoker(ListBaremetalFlavorDetailExtendsRequest listBaremetalFlavorDetailExtendsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBaremetalFlavorDetailExtendsRequest);
            return new SyncInvoker<ListBaremetalFlavorDetailExtendsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBaremetalFlavorDetailExtendsResponse>);
        }
        
        /// <summary>
        /// 重装裸金属服务器操作系统
        ///
        /// 重装裸金属服务器的操作系统。快速发放裸金属服务器支持裸金属服务器数据盘不变的情况下，使用原镜像重装系统盘。重装操作系统支持密码或者密钥注入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ReinstallBaremetalServerOsResponse ReinstallBaremetalServerOs(ReinstallBaremetalServerOsRequest reinstallBaremetalServerOsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallBaremetalServerOsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallBaremetalServerOsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReinstallBaremetalServerOsResponse>(response);
        }

        public SyncInvoker<ReinstallBaremetalServerOsResponse> ReinstallBaremetalServerOsInvoker(ReinstallBaremetalServerOsRequest reinstallBaremetalServerOsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallBaremetalServerOsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/reinstallos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallBaremetalServerOsRequest);
            return new SyncInvoker<ReinstallBaremetalServerOsResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallBaremetalServerOsResponse>);
        }
        
        /// <summary>
        /// 一键重置裸金属服务器密码
        ///
        /// 在裸金属服务器支持一键重置密码功能的前提下，重置裸金属服务器管理帐号（root用户或Administrator用户）的密码。可以通过6.10.1-查询是否支持一键重置密码API查询是否支持一键重置密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdOneClickResponse ResetPwdOneClick(ResetPwdOneClickRequest resetPwdOneClickRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resetPwdOneClickRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdOneClickRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPwdOneClickResponse>(response);
        }

        public SyncInvoker<ResetPwdOneClickResponse> ResetPwdOneClickInvoker(ResetPwdOneClickRequest resetPwdOneClickRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", resetPwdOneClickRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdOneClickRequest);
            return new SyncInvoker<ResetPwdOneClickResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPwdOneClickResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器网卡信息
        ///
        /// 查询裸金属服务器的网卡信息，比如网卡的IP地址、MAC地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBaremetalServerInterfaceAttachmentsResponse ShowBaremetalServerInterfaceAttachments(ShowBaremetalServerInterfaceAttachmentsRequest showBaremetalServerInterfaceAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerInterfaceAttachmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBaremetalServerInterfaceAttachmentsResponse>(response);
        }

        public SyncInvoker<ShowBaremetalServerInterfaceAttachmentsResponse> ShowBaremetalServerInterfaceAttachmentsInvoker(ShowBaremetalServerInterfaceAttachmentsRequest showBaremetalServerInterfaceAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerInterfaceAttachmentsRequest);
            return new SyncInvoker<ShowBaremetalServerInterfaceAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBaremetalServerInterfaceAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器标签
        ///
        /// - 查询指定云服务器的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBaremetalServerTagsResponse ShowBaremetalServerTags(ShowBaremetalServerTagsRequest showBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBaremetalServerTagsResponse>(response);
        }

        public SyncInvoker<ShowBaremetalServerTagsResponse> ShowBaremetalServerTagsInvoker(ShowBaremetalServerTagsRequest showBaremetalServerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerTagsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerTagsRequest);
            return new SyncInvoker<ShowBaremetalServerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBaremetalServerTagsResponse>);
        }
        
        /// <summary>
        /// 查询裸金属服务器挂载的云硬盘信息
        ///
        /// 查询裸金属服务器挂载的磁盘信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBaremetalServerVolumeInfoResponse ShowBaremetalServerVolumeInfo(ShowBaremetalServerVolumeInfoRequest showBaremetalServerVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerVolumeInfoRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-volume_attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerVolumeInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBaremetalServerVolumeInfoResponse>(response);
        }

        public SyncInvoker<ShowBaremetalServerVolumeInfoResponse> ShowBaremetalServerVolumeInfoInvoker(ShowBaremetalServerVolumeInfoRequest showBaremetalServerVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showBaremetalServerVolumeInfoRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-volume_attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerVolumeInfoRequest);
            return new SyncInvoker<ShowBaremetalServerVolumeInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBaremetalServerVolumeInfoResponse>);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        ///
        /// 查询是否支持一键重置密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResetPwdResponse ShowResetPwd(ShowResetPwdRequest showResetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showResetPwdRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPwdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResetPwdResponse>(response);
        }

        public SyncInvoker<ShowResetPwdResponse> ShowResetPwdInvoker(ShowResetPwdRequest showResetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showResetPwdRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-resetpwd-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPwdRequest);
            return new SyncInvoker<ShowResetPwdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResetPwdResponse>);
        }
        
        /// <summary>
        /// 获取裸金属服务器远程登录地址
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerRemoteConsoleResponse ShowServerRemoteConsole(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRemoteConsoleRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
        }

        public SyncInvoker<ShowServerRemoteConsoleResponse> ShowServerRemoteConsoleInvoker(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRemoteConsoleRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/remote_console", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            return new SyncInvoker<ShowServerRemoteConsoleResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询该租户下，所有资源的配额信息，包括已使用配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTenantQuotaResponse ShowTenantQuota(ShowTenantQuotaRequest showTenantQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTenantQuotaResponse>(response);
        }

        public SyncInvoker<ShowTenantQuotaResponse> ShowTenantQuotaInvoker(ShowTenantQuotaRequest showTenantQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantQuotaRequest);
            return new SyncInvoker<ShowTenantQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTenantQuotaResponse>);
        }
        
        /// <summary>
        /// Windows裸金属服务器获取密码
        ///
        /// 获取Windows裸金属服务器初始安装时系统生成的管理员帐户（Administrator帐户或Cloudbase-init设置的帐户）随机密码。如果裸金属服务器是通过私有镜像创建的，请确保已安装Cloudbase-init。公共镜像默认已安装该软件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWindowsBaremetalServerPwdResponse ShowWindowsBaremetalServerPwd(ShowWindowsBaremetalServerPwdRequest showWindowsBaremetalServerPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showWindowsBaremetalServerPwdRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWindowsBaremetalServerPwdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWindowsBaremetalServerPwdResponse>(response);
        }

        public SyncInvoker<ShowWindowsBaremetalServerPwdResponse> ShowWindowsBaremetalServerPwdInvoker(ShowWindowsBaremetalServerPwdRequest showWindowsBaremetalServerPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showWindowsBaremetalServerPwdRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWindowsBaremetalServerPwdRequest);
            return new SyncInvoker<ShowWindowsBaremetalServerPwdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWindowsBaremetalServerPwdResponse>);
        }
        
        /// <summary>
        /// 修改裸金属服务器弹性网卡的属性
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBaremetalServerInterfaceAttachmentsResponse UpdateBaremetalServerInterfaceAttachments(UpdateBaremetalServerInterfaceAttachmentsRequest updateBaremetalServerInterfaceAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", updateBaremetalServerInterfaceAttachmentsRequest.PortId.ToString());
            urlParam.Add("server_id", updateBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerInterfaceAttachmentsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBaremetalServerInterfaceAttachmentsResponse>(response);
        }

        public SyncInvoker<UpdateBaremetalServerInterfaceAttachmentsResponse> UpdateBaremetalServerInterfaceAttachmentsInvoker(UpdateBaremetalServerInterfaceAttachmentsRequest updateBaremetalServerInterfaceAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", updateBaremetalServerInterfaceAttachmentsRequest.PortId.ToString());
            urlParam.Add("server_id", updateBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerInterfaceAttachmentsRequest);
            return new SyncInvoker<UpdateBaremetalServerInterfaceAttachmentsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBaremetalServerInterfaceAttachmentsResponse>);
        }
        
        /// <summary>
        /// 更新裸金属服务器元数据
        ///
        /// 更新裸金属服务器元数据。如果元数据中没有待更新字段，则自动添加该字段。如果元数据中已存在待更新字段，则直接更新字段值；如果元数据中的字段不再请求参数中，则保持不变
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBaremetalServerMetadataResponse UpdateBaremetalServerMetadata(UpdateBaremetalServerMetadataRequest updateBaremetalServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateBaremetalServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateBaremetalServerMetadataResponse>(response);
        }

        public SyncInvoker<UpdateBaremetalServerMetadataResponse> UpdateBaremetalServerMetadataInvoker(UpdateBaremetalServerMetadataRequest updateBaremetalServerMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateBaremetalServerMetadataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerMetadataRequest);
            return new SyncInvoker<UpdateBaremetalServerMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateBaremetalServerMetadataResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询裸金属服务指定接口版本的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSpecifiedVersionResponse ShowSpecifiedVersion(ShowSpecifiedVersionRequest showSpecifiedVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showSpecifiedVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecifiedVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSpecifiedVersionResponse>(response);
        }

        public SyncInvoker<ShowSpecifiedVersionResponse> ShowSpecifiedVersionInvoker(ShowSpecifiedVersionRequest showSpecifiedVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showSpecifiedVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecifiedVersionRequest);
            return new SyncInvoker<ShowSpecifiedVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpecifiedVersionResponse>);
        }
        
        /// <summary>
        /// 查询Job状态
        ///
        /// 查询Job的执行状态。对于创建裸金属服务器物理机、挂卸卷等异步API，命令下发后，会返回job_id，通过job_id可以查询任务的执行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobInfosResponse ShowJobInfos(ShowJobInfosRequest showJobInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfosRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobInfosResponse>(response);
        }

        public SyncInvoker<ShowJobInfosResponse> ShowJobInfosInvoker(ShowJobInfosRequest showJobInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfosRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfosRequest);
            return new SyncInvoker<ShowJobInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobInfosResponse>);
        }
        
    }
}