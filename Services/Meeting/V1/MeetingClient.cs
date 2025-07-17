using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Meeting.V1.Model;

namespace HuaweiCloud.SDK.Meeting.V1
{
    public partial class MeetingClient : Client
    {
        public static ClientBuilder<MeetingClient> NewBuilder()
        {
            return new ClientBuilder<MeetingClient>("MeetingCredentials");
        }

        
        /// <summary>
        /// 添加企业应用
        ///
        /// 企业默认管理员添加应用，添加应用后，记录返回信息，后续可通过[[执行App ID鉴权](https://support.huaweicloud.com/api-meeting/meeting_21_0311.html)](tag:hws) [[执行App ID鉴权](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0311.html)](tag:hk)获取accessToken
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAppIdResponse AddAppId(AddAppIdRequest addAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", addAppIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAppIdResponse>(response);
        }

        public SyncInvoker<AddAppIdResponse> AddAppIdInvoker(AddAppIdRequest addAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", addAppIdRequest);
            return new SyncInvoker<AddAppIdResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAppIdResponse>);
        }
        
        /// <summary>
        /// SP管理员创建企业
        ///
        /// 创建企业，默认管理员及分配资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddCorpResponse AddCorp(AddCorpRequest addCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddCorpResponse>(response);
        }

        public SyncInvoker<AddCorpResponse> AddCorpInvoker(AddCorpRequest addCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpRequest);
            return new SyncInvoker<AddCorpResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCorpResponse>);
        }
        
        /// <summary>
        /// 添加企业管理员
        ///
        /// 企业默认管理员添加企业普通管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddCorpAdminResponse AddCorpAdmin(AddCorpAdminRequest addCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpAdminRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddCorpAdminResponse>(response);
        }

        public SyncInvoker<AddCorpAdminResponse> AddCorpAdminInvoker(AddCorpAdminRequest addCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpAdminRequest);
            return new SyncInvoker<AddCorpAdminResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddCorpAdminResponse>);
        }
        
        /// <summary>
        /// 添加部门
        ///
        /// 企业管理员通过该接口添加部门，最多支持10级部门，每级子部门最多支持100个，默认企业最大部门数量为10000个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDepartmentResponse AddDepartment(AddDepartmentRequest addDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDepartmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDepartmentResponse>(response);
        }

        public SyncInvoker<AddDepartmentResponse> AddDepartmentInvoker(AddDepartmentRequest addDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDepartmentRequest);
            return new SyncInvoker<AddDepartmentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDepartmentResponse>);
        }
        
        /// <summary>
        /// 增加终端
        ///
        /// 企业管理员通过该接口添加专业会议终端。专业会议终端包括DP300/HUAWEI Bar系列/HUAWEI Board/TE系列。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDeviceResponse AddDevice(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
        }

        public SyncInvoker<AddDeviceResponse> AddDeviceInvoker(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            return new SyncInvoker<AddDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceResponse>);
        }
        
        /// <summary>
        /// 新增信息窗素材
        ///
        /// 新增信息窗素材（上传素材文件）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMaterialResponse AddMaterial(AddMaterialRequest addMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addMaterialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddMaterialResponse>(response);
        }

        public SyncInvoker<AddMaterialResponse> AddMaterialInvoker(AddMaterialRequest addMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addMaterialRequest);
            return new SyncInvoker<AddMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddMaterialResponse>);
        }
        
        /// <summary>
        /// 新增信息窗节目
        ///
        /// 新增信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddProgramResponse AddProgram(AddProgramRequest addProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProgramRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddProgramResponse>(response);
        }

        public SyncInvoker<AddProgramResponse> AddProgramInvoker(AddProgramRequest addProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProgramRequest);
            return new SyncInvoker<AddProgramResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddProgramResponse>);
        }
        
        /// <summary>
        /// 新增信息窗发布
        ///
        /// 新增信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddPublicationResponse AddPublication(AddPublicationRequest addPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPublicationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddPublicationResponse>(response);
        }

        public SyncInvoker<AddPublicationResponse> AddPublicationInvoker(AddPublicationRequest addPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPublicationRequest);
            return new SyncInvoker<AddPublicationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddPublicationResponse>);
        }
        
        /// <summary>
        /// SP管理员分配企业资源
        ///
        /// 企业新增资源发放。该接口同时支持修改，带resourceId后会判断该资源是否存在，存在即修改（支持修改的参数见修改接口），否则按新增处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddResourceResponse AddResource(AddResourceRequest addResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", addResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddResourceResponse>(response);
        }

        public SyncInvoker<AddResourceResponse> AddResourceInvoker(AddResourceRequest addResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", addResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourceRequest);
            return new SyncInvoker<AddResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddResourceResponse>);
        }
        
        /// <summary>
        /// 保存会议纪要到个人云空间
        ///
        /// 用户使用手机扫码后,手机端请求服务端将当前会议纪要文件保存到个人云空间。二维码内容 ：cloudlink://cloudlink.huawei.com/h5page?action&#x3D;SAVE_MEETING_FILE&amp;key1&#x3D;value1&amp;key2&#x3D;value2 。key/value的个数可能变化，终端解析后，在发起后续请求时，将所有key/value存为map，作为入参即可。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddToPersonalSpaceResponse AddToPersonalSpace(AddToPersonalSpaceRequest addToPersonalSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/save-to-personal-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addToPersonalSpaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddToPersonalSpaceResponse>(response);
        }

        public SyncInvoker<AddToPersonalSpaceResponse> AddToPersonalSpaceInvoker(AddToPersonalSpaceRequest addToPersonalSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/save-to-personal-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addToPersonalSpaceRequest);
            return new SyncInvoker<AddToPersonalSpaceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddToPersonalSpaceResponse>);
        }
        
        /// <summary>
        /// 添加用户
        ///
        /// 企业管理员通过该接口添加企业用户。
        /// &gt; 默认添加用户后，用户第一次登录华为云会议App或者Portal时需要修改密码。若需关闭第一次登录修改密码，请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddUserResponse AddUser(AddUserRequest addUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddUserResponse>(response);
        }

        public SyncInvoker<AddUserResponse> AddUserInvoker(AddUserRequest addUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserRequest);
            return new SyncInvoker<AddUserResponse>(this, "POST", request, JsonUtils.DeSerialize<AddUserResponse>);
        }
        
        /// <summary>
        /// 主持人允许观众入会
        ///
        /// 主持人通过接口控制是否允许观众入会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowAudienceJoinResponse AllowAudienceJoin(AllowAudienceJoinRequest allowAudienceJoinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowAudience", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowAudienceJoinRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowAudienceJoinResponse>(response);
        }

        public SyncInvoker<AllowAudienceJoinResponse> AllowAudienceJoinInvoker(AllowAudienceJoinRequest allowAudienceJoinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowAudience", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowAudienceJoinRequest);
            return new SyncInvoker<AllowAudienceJoinResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowAudienceJoinResponse>);
        }
        
        /// <summary>
        /// 允许客户端录制
        ///
        /// 该接口用于设置允许/禁止与会者客户端本地录制（非云端录制）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowClientRecordResponse AllowClientRecord(AllowClientRecordRequest allowClientRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowClientRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowClientRecordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowClientRecordResponse>(response);
        }

        public SyncInvoker<AllowClientRecordResponse> AllowClientRecordInvoker(AllowClientRecordRequest allowClientRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowClientRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowClientRecordRequest);
            return new SyncInvoker<AllowClientRecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowClientRecordResponse>);
        }
        
        /// <summary>
        /// 与会者自己解除静音
        ///
        /// 该接口用于设置与会者是否可以自己解除静音。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowGuestUnmuteResponse AllowGuestUnmute(AllowGuestUnmuteRequest allowGuestUnmuteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute/guestUnMute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowGuestUnmuteRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowGuestUnmuteResponse>(response);
        }

        public SyncInvoker<AllowGuestUnmuteResponse> AllowGuestUnmuteInvoker(AllowGuestUnmuteRequest allowGuestUnmuteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute/guestUnMute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowGuestUnmuteRequest);
            return new SyncInvoker<AllowGuestUnmuteResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowGuestUnmuteResponse>);
        }
        
        /// <summary>
        /// 准入等候者
        ///
        /// 该接口用于允许等候室中的成员进入会议。可以允许全部成员进入会议，或者允许指定成员进入会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowWaitingParticipantResponse AllowWaitingParticipant(AllowWaitingParticipantRequest allowWaitingParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowWaitingParticipant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowWaitingParticipantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowWaitingParticipantResponse>(response);
        }

        public SyncInvoker<AllowWaitingParticipantResponse> AllowWaitingParticipantInvoker(AllowWaitingParticipantRequest allowWaitingParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowWaitingParticipant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowWaitingParticipantRequest);
            return new SyncInvoker<AllowWaitingParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowWaitingParticipantResponse>);
        }
        
        /// <summary>
        /// 分配云会议室
        ///
        /// 企业管理员通过该接口将云会议室分配给用户、专业会议终端（TE10、TE20、HUAWEI Board、HUAWEI Bar 500及HUAWEI Box系列）、智慧屏TV、电子白板（SmartRooms）、IdeaHub。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateVmrResponse AssociateVmr(AssociateVmrRequest associateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", associateVmrRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/assign-to-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateVmrRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateVmrResponse>(response);
        }

        public SyncInvoker<AssociateVmrResponse> AssociateVmrInvoker(AssociateVmrRequest associateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", associateVmrRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/assign-to-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateVmrRequest);
            return new SyncInvoker<AssociateVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateVmrResponse>);
        }
        
        /// <summary>
        /// 批量删除企业管理员
        ///
        /// 通过该接口批量删除企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteCorpAdminsResponse BatchDeleteCorpAdmins(BatchDeleteCorpAdminsRequest batchDeleteCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCorpAdminsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteCorpAdminsResponse>(response);
        }

        public SyncInvoker<BatchDeleteCorpAdminsResponse> BatchDeleteCorpAdminsInvoker(BatchDeleteCorpAdminsRequest batchDeleteCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCorpAdminsRequest);
            return new SyncInvoker<BatchDeleteCorpAdminsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteCorpAdminsResponse>);
        }
        
        /// <summary>
        /// 批量删除终端
        ///
        /// 企业管理员通过该接口批量删除专业会议终端，返回删除失败的列表。
        /// &gt; 如果需要删除Ideahub、SmartRooms、智慧屏TV请使用[[批量删除用户](https://support.huaweicloud.com/api-meeting/meeting_21_0070.html)](tag:hws)[[批量删除用户](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0070.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDevicesResponse BatchDeleteDevices(BatchDeleteDevicesRequest batchDeleteDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDevicesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDevicesResponse>(response);
        }

        public SyncInvoker<BatchDeleteDevicesResponse> BatchDeleteDevicesInvoker(BatchDeleteDevicesRequest batchDeleteDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDevicesRequest);
            return new SyncInvoker<BatchDeleteDevicesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteDevicesResponse>);
        }
        
        /// <summary>
        /// 删除信息窗素材
        ///
        /// 删除信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteMaterialsResponse BatchDeleteMaterials(BatchDeleteMaterialsRequest batchDeleteMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMaterialsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteMaterialsResponse>(response);
        }

        public SyncInvoker<BatchDeleteMaterialsResponse> BatchDeleteMaterialsInvoker(BatchDeleteMaterialsRequest batchDeleteMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMaterialsRequest);
            return new SyncInvoker<BatchDeleteMaterialsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteMaterialsResponse>);
        }
        
        /// <summary>
        /// 删除信息窗节目
        ///
        /// 删除信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteProgramsResponse BatchDeletePrograms(BatchDeleteProgramsRequest batchDeleteProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProgramsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteProgramsResponse>(response);
        }

        public SyncInvoker<BatchDeleteProgramsResponse> BatchDeleteProgramsInvoker(BatchDeleteProgramsRequest batchDeleteProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProgramsRequest);
            return new SyncInvoker<BatchDeleteProgramsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteProgramsResponse>);
        }
        
        /// <summary>
        /// 删除信息窗发布
        ///
        /// 删除信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePublicationsResponse BatchDeletePublications(BatchDeletePublicationsRequest batchDeletePublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePublicationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicationsResponse>(response);
        }

        public SyncInvoker<BatchDeletePublicationsResponse> BatchDeletePublicationsInvoker(BatchDeletePublicationsRequest batchDeletePublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePublicationsRequest);
            return new SyncInvoker<BatchDeletePublicationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePublicationsResponse>);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 企业管理员通过该接口批量删除企业用户。删除多个用户时，全部删除成功或者全部删除失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteUsersResponse BatchDeleteUsers(BatchDeleteUsersRequest batchDeleteUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUsersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUsersResponse>(response);
        }

        public SyncInvoker<BatchDeleteUsersResponse> BatchDeleteUsersInvoker(BatchDeleteUsersRequest batchDeleteUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUsersRequest);
            return new SyncInvoker<BatchDeleteUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUsersResponse>);
        }
        
        /// <summary>
        /// 批量举手
        ///
        /// 该接口用于批量设置来宾的举手/放下举手状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchHandResponse BatchHand(BatchHandRequest batchHandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/batch/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchHandRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchHandResponse>(response);
        }

        public SyncInvoker<BatchHandResponse> BatchHandInvoker(BatchHandRequest batchHandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/batch/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchHandRequest);
            return new SyncInvoker<BatchHandResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchHandResponse>);
        }
        
        /// <summary>
        /// 批量移入等候室
        ///
        /// 主持人通过该接口批量移动用户到等候室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchMoveToWaitingRoomResponse BatchMoveToWaitingRoom(BatchMoveToWaitingRoomRequest batchMoveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/batchMoveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMoveToWaitingRoomRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchMoveToWaitingRoomResponse>(response);
        }

        public SyncInvoker<BatchMoveToWaitingRoomResponse> BatchMoveToWaitingRoomInvoker(BatchMoveToWaitingRoomRequest batchMoveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/batchMoveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMoveToWaitingRoomRequest);
            return new SyncInvoker<BatchMoveToWaitingRoomResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchMoveToWaitingRoomResponse>);
        }
        
        /// <summary>
        /// 分页查询企业应用
        ///
        /// 企业默认管理员分页查询企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSearchAppIdResponse BatchSearchAppId(BatchSearchAppIdRequest batchSearchAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSearchAppIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<BatchSearchAppIdResponse>(response);
        }

        public SyncInvoker<BatchSearchAppIdResponse> BatchSearchAppIdInvoker(BatchSearchAppIdRequest batchSearchAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSearchAppIdRequest);
            return new SyncInvoker<BatchSearchAppIdResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchSearchAppIdResponse>);
        }
        
        /// <summary>
        /// 批量查询用户详情
        ///
        /// 批量查询用户详情，支持指定第三方账号查询详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowUserDetailsResponse BatchShowUserDetails(BatchShowUserDetailsRequest batchShowUserDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowUserDetailsRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchShowUserDetailsResponse = JsonUtils.DeSerializeNull<BatchShowUserDetailsResponse>(response);
            batchShowUserDetailsResponse.Body = JsonUtils.DeSerializeList<UserDTO>(response);
            return batchShowUserDetailsResponse;
        }

        public SyncInvoker<BatchShowUserDetailsResponse> BatchShowUserDetailsInvoker(BatchShowUserDetailsRequest batchShowUserDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowUserDetailsRequest);
            return new SyncInvoker<BatchShowUserDetailsResponse>(this, "POST", request, response =>
            {
                var batchShowUserDetailsResponse = JsonUtils.DeSerializeNull<BatchShowUserDetailsResponse>(response);
                batchShowUserDetailsResponse.Body = JsonUtils.DeSerializeList<UserDTO>(response);
                return batchShowUserDetailsResponse;
            });
        }
        
        /// <summary>
        /// 批量修改终端状态
        ///
        /// 企业管理员通过该接口批量修改专业会议终端状态。当硬终端资源到期后，若企业内对应资源的硬终端超过数量后会被系统随机自动停用，此时可通过该接口修改专业会议终端的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateDevicesStatusResponse BatchUpdateDevicesStatus(BatchUpdateDevicesStatusRequest batchUpdateDevicesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("value", batchUpdateDevicesStatusRequest.Value.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateDevicesStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateDevicesStatusResponse>(response);
        }

        public SyncInvoker<BatchUpdateDevicesStatusResponse> BatchUpdateDevicesStatusInvoker(BatchUpdateDevicesStatusRequest batchUpdateDevicesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("value", batchUpdateDevicesStatusRequest.Value.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateDevicesStatusRequest);
            return new SyncInvoker<BatchUpdateDevicesStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateDevicesStatusResponse>);
        }
        
        /// <summary>
        /// 批量修改用户状态
        ///
        /// 企业管理员通过该接口批量修改用户状态，当用户帐号数资源或者电子白板（SmartRooms）资源到期后，若企业内对应资源的用户帐号超过数量后会被系统随机自动停用，此时可通过该接口修改用户的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateUserStatusResponse BatchUpdateUserStatus(BatchUpdateUserStatusRequest batchUpdateUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("value", batchUpdateUserStatusRequest.Value.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateUserStatusResponse>(response);
        }

        public SyncInvoker<BatchUpdateUserStatusResponse> BatchUpdateUserStatusInvoker(BatchUpdateUserStatusRequest batchUpdateUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("value", batchUpdateUserStatusRequest.Value.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserStatusRequest);
            return new SyncInvoker<BatchUpdateUserStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateUserStatusResponse>);
        }
        
        /// <summary>
        /// 广播会场
        ///
        /// 该接口用于广播指定的与会者。同一时间，只允许一个与会者被广播。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BroadcastParticipantResponse BroadcastParticipant(BroadcastParticipantRequest broadcastParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/broadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastParticipantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BroadcastParticipantResponse>(response);
        }

        public SyncInvoker<BroadcastParticipantResponse> BroadcastParticipantInvoker(BroadcastParticipantRequest broadcastParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/broadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastParticipantRequest);
            return new SyncInvoker<BroadcastParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BroadcastParticipantResponse>);
        }
        
        /// <summary>
        /// 取消广播
        ///
        /// 该接口用于取消广播，包括：取消广播多画面，取消广播会场，取消点名会场。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelBroadcastResponse CancelBroadcast(CancelBroadcastRequest cancelBroadcastRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/cancelBroadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelBroadcastRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CancelBroadcastResponse>(response);
        }

        public SyncInvoker<CancelBroadcastResponse> CancelBroadcastInvoker(CancelBroadcastRequest cancelBroadcastRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/cancelBroadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelBroadcastRequest);
            return new SyncInvoker<CancelBroadcastResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CancelBroadcastResponse>);
        }
        
        /// <summary>
        /// 取消预约会议
        ///
        /// 该接口用于取消预约的会议。企业管理员可以取消本企业下用户创建的会议，普通用户只能取消自己创建的会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelMeetingResponse CancelMeeting(CancelMeetingRequest cancelMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMeetingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelMeetingResponse>(response);
        }

        public SyncInvoker<CancelMeetingResponse> CancelMeetingInvoker(CancelMeetingRequest cancelMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMeetingRequest);
            return new SyncInvoker<CancelMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelMeetingResponse>);
        }
        
        /// <summary>
        /// 取消周期性会议
        ///
        /// 该接口用于取消周期性会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelRecurringMeetingResponse CancelRecurringMeeting(CancelRecurringMeetingRequest cancelRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringMeetingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRecurringMeetingResponse>(response);
        }

        public SyncInvoker<CancelRecurringMeetingResponse> CancelRecurringMeetingInvoker(CancelRecurringMeetingRequest cancelRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringMeetingRequest);
            return new SyncInvoker<CancelRecurringMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRecurringMeetingResponse>);
        }
        
        /// <summary>
        /// 取消周期性会议的子会议
        ///
        /// 该接口用于取消周期性会议的子会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelRecurringSubMeetingResponse CancelRecurringSubMeeting(CancelRecurringSubMeetingRequest cancelRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringSubMeetingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRecurringSubMeetingResponse>(response);
        }

        public SyncInvoker<CancelRecurringSubMeetingResponse> CancelRecurringSubMeetingInvoker(CancelRecurringSubMeetingRequest cancelRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringSubMeetingRequest);
            return new SyncInvoker<CancelRecurringSubMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRecurringSubMeetingResponse>);
        }
        
        /// <summary>
        /// 根据号码，查询是否在会议中
        ///
        /// 通过该接口查询号码，是否在会议中
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckCallNumberInConfResponse CheckCallNumberInConf(CheckCallNumberInConfRequest checkCallNumberInConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/online/check-callnumber-in-conf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCallNumberInConfRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckCallNumberInConfResponse>(response);
        }

        public SyncInvoker<CheckCallNumberInConfResponse> CheckCallNumberInConfInvoker(CheckCallNumberInConfRequest checkCallNumberInConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/online/check-callnumber-in-conf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCallNumberInConfRequest);
            return new SyncInvoker<CheckCallNumberInConfResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckCallNumberInConfResponse>);
        }
        
        /// <summary>
        /// 校验滑块验证码
        ///
        /// 该接口提供校验滑块验证码。服务器收到请求，返回校验结果。用户在前台界面通过滑块操作匹配图形，使得抠图和原图吻合。然后服务器进行校验滑块验证码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckSlideVerifyCodeResponse CheckSlideVerifyCode(CheckSlideVerifyCodeRequest checkSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSlideVerifyCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CheckSlideVerifyCodeResponse>(response);
        }

        public SyncInvoker<CheckSlideVerifyCodeResponse> CheckSlideVerifyCodeInvoker(CheckSlideVerifyCodeRequest checkSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSlideVerifyCodeRequest);
            return new SyncInvoker<CheckSlideVerifyCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckSlideVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 校验Token
        ///
        /// 该接口提供校验token合法性功能。服务器收到请求后，验证token合法性并返回结果。如果参数needGenNewToken为true时，生成新的token并返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckTokenResponse CheckToken(CheckTokenRequest checkTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckTokenResponse>(response);
        }

        public SyncInvoker<CheckTokenResponse> CheckTokenInvoker(CheckTokenRequest checkTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTokenRequest);
            return new SyncInvoker<CheckTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckTokenResponse>);
        }
        
        /// <summary>
        /// 校验手机和邮箱对应的验证码
        ///
        /// 企业用户通过该接口校验手机和邮箱对应的验证码，一分钟内记录尝试次数不得超过5次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckVeriCodeForUpdateUserInfoResponse CheckVeriCodeForUpdateUserInfo(CheckVeriCodeForUpdateUserInfoRequest checkVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVeriCodeForUpdateUserInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CheckVeriCodeForUpdateUserInfoResponse>(response);
        }

        public SyncInvoker<CheckVeriCodeForUpdateUserInfoResponse> CheckVeriCodeForUpdateUserInfoInvoker(CheckVeriCodeForUpdateUserInfoRequest checkVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVeriCodeForUpdateUserInfoRequest);
            return new SyncInvoker<CheckVeriCodeForUpdateUserInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckVeriCodeForUpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 校验验证码
        ///
        /// 该接口提供校验验证码，服务器收到请求，返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckVerifyCodeResponse CheckVerifyCode(CheckVerifyCodeRequest checkVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVerifyCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CheckVerifyCodeResponse>(response);
        }

        public SyncInvoker<CheckVerifyCodeResponse> CheckVerifyCodeInvoker(CheckVerifyCodeRequest checkVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVerifyCodeRequest);
            return new SyncInvoker<CheckVerifyCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 匿名用户会议鉴权
        ///
        /// 该接口用于匿名用户入会鉴权。请求根据会议ID和密码鉴权，返回鉴权随机数（可以根据该随机数获取匿名用户信息、会议信息等）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAnonymousAuthRandomResponse CreateAnonymousAuthRandom(CreateAnonymousAuthRandomRequest createAnonymousAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/anonymous/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnonymousAuthRandomRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CreateAnonymousAuthRandomResponse>(response);
        }

        public SyncInvoker<CreateAnonymousAuthRandomResponse> CreateAnonymousAuthRandomInvoker(CreateAnonymousAuthRandomRequest createAnonymousAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/anonymous/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnonymousAuthRandomRequest);
            return new SyncInvoker<CreateAnonymousAuthRandomResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateAnonymousAuthRandomResponse>);
        }
        
        /// <summary>
        /// 获取会议鉴权随机数
        ///
        /// 根据会议ID + 密码鉴权返回鉴权随机数，如果是小程序调用时，需要企业支持小程序功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuthRandomResponse CreateAuthRandom(CreateAuthRandomRequest createAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/auth/random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthRandomRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CreateAuthRandomResponse>(response);
        }

        public SyncInvoker<CreateAuthRandomResponse> CreateAuthRandomInvoker(CreateAuthRandomRequest createAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/auth/random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthRandomRequest);
            return new SyncInvoker<CreateAuthRandomResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateAuthRandomResponse>);
        }
        
        /// <summary>
        /// 获取会控Token
        ///
        /// 该接口用于获取正在召开会议的会控Token（未开始的会议调用该接口返回失败）。Token有效期是半个小时。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfTokenResponse CreateConfToken(CreateConfTokenRequest createConfTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfTokenRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CreateConfTokenResponse>(response);
        }

        public SyncInvoker<CreateConfTokenResponse> CreateConfTokenInvoker(CreateConfTokenRequest createConfTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfTokenRequest);
            return new SyncInvoker<CreateConfTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateConfTokenResponse>);
        }
        
        /// <summary>
        /// 创建会议
        ///
        /// 该接口用于创建立即会议和预约会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMeetingResponse CreateMeeting(CreateMeetingRequest createMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMeetingRequest);
            var response = DoHttpRequestSync("POST", request);
            var createMeetingResponse = JsonUtils.DeSerializeNull<CreateMeetingResponse>(response);
            createMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return createMeetingResponse;
        }

        public SyncInvoker<CreateMeetingResponse> CreateMeetingInvoker(CreateMeetingRequest createMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMeetingRequest);
            return new SyncInvoker<CreateMeetingResponse>(this, "POST", request, response =>
            {
                var createMeetingResponse = JsonUtils.DeSerializeNull<CreateMeetingResponse>(response);
                createMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
                return createMeetingResponse;
            });
        }
        
        /// <summary>
        /// 获取页面免登陆跳转的nonce信息
        ///
        /// 通过Access Token生成页面免登陆跳转到华为云会议的Portal的nonce信息。获取到nonce信息后，通过链接https://meeting.huaweicloud.com/?lang&#x3D;zh-CN&amp;nonce&#x3D;xxxxxxxxxxxxx#/login进行免登陆跳转。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePortalRefNonceResponse CreatePortalRefNonce(CreatePortalRefNonceRequest createPortalRefNonceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/portal-ref-nonce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPortalRefNonceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePortalRefNonceResponse>(response);
        }

        public SyncInvoker<CreatePortalRefNonceResponse> CreatePortalRefNonceInvoker(CreatePortalRefNonceRequest createPortalRefNonceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/portal-ref-nonce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPortalRefNonceRequest);
            return new SyncInvoker<CreatePortalRefNonceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePortalRefNonceResponse>);
        }
        
        /// <summary>
        /// 创建周期性会议
        ///
        /// 该接口用于预约周期性会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecurringMeetingResponse CreateRecurringMeeting(CreateRecurringMeetingRequest createRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecurringMeetingRequest);
            var response = DoHttpRequestSync("POST", request);
            var createRecurringMeetingResponse = JsonUtils.DeSerializeNull<CreateRecurringMeetingResponse>(response);
            createRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return createRecurringMeetingResponse;
        }

        public SyncInvoker<CreateRecurringMeetingResponse> CreateRecurringMeetingInvoker(CreateRecurringMeetingRequest createRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecurringMeetingRequest);
            return new SyncInvoker<CreateRecurringMeetingResponse>(this, "POST", request, response =>
            {
                var createRecurringMeetingResponse = JsonUtils.DeSerializeNull<CreateRecurringMeetingResponse>(response);
                createRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
                return createRecurringMeetingResponse;
            });
        }
        
        /// <summary>
        /// 企业管理员生成激活码
        ///
        /// 企业管理员生成智慧屏、电子白板（SmartRooms）、Ideahub的激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVisionActiveCodeResponse CreateVisionActiveCode(CreateVisionActiveCodeRequest createVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVisionActiveCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVisionActiveCodeResponse>(response);
        }

        public SyncInvoker<CreateVisionActiveCodeResponse> CreateVisionActiveCodeInvoker(CreateVisionActiveCodeRequest createVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVisionActiveCodeRequest);
            return new SyncInvoker<CreateVisionActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 获取websocket建链Token
        ///
        /// 该接口用于获取会控WebSocket建链的临时Token。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWebSocketTokenResponse CreateWebSocketToken(CreateWebSocketTokenRequest createWebSocketTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/wsToken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebSocketTokenRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CreateWebSocketTokenResponse>(response);
        }

        public SyncInvoker<CreateWebSocketTokenResponse> CreateWebSocketTokenInvoker(CreateWebSocketTokenRequest createWebSocketTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/wsToken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebSocketTokenRequest);
            return new SyncInvoker<CreateWebSocketTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateWebSocketTokenResponse>);
        }
        
        /// <summary>
        /// 预约网络研讨会
        ///
        /// 该接口用于创建网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWebinarResponse CreateWebinar(CreateWebinarRequest createWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebinarRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWebinarResponse>(response);
        }

        public SyncInvoker<CreateWebinarResponse> CreateWebinarInvoker(CreateWebinarRequest createWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebinarRequest);
            return new SyncInvoker<CreateWebinarResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWebinarResponse>);
        }
        
        /// <summary>
        /// 删除企业应用
        ///
        /// 企业管理员删除企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppIdResponse DeleteAppId(DeleteAppIdRequest deleteAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppIdResponse>(response);
        }

        public SyncInvoker<DeleteAppIdResponse> DeleteAppIdInvoker(DeleteAppIdRequest deleteAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIdRequest);
            return new SyncInvoker<DeleteAppIdResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppIdResponse>);
        }
        
        /// <summary>
        /// 删除与会者
        ///
        /// 该接口用于删除与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAttendeesResponse DeleteAttendees(DeleteAttendeesRequest deleteAttendeesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/attendees/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttendeesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAttendeesResponse>(response);
        }

        public SyncInvoker<DeleteAttendeesResponse> DeleteAttendeesInvoker(DeleteAttendeesRequest deleteAttendeesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/attendees/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttendeesRequest);
            return new SyncInvoker<DeleteAttendeesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAttendeesResponse>);
        }
        
        /// <summary>
        /// SP管理员删除企业
        ///
        /// 删除企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCorpResponse DeleteCorp(DeleteCorpRequest deleteCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCorpResponse>(response);
        }

        public SyncInvoker<DeleteCorpResponse> DeleteCorpInvoker(DeleteCorpRequest deleteCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpRequest);
            return new SyncInvoker<DeleteCorpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCorpResponse>);
        }
        
        /// <summary>
        /// 删除云会议室
        ///
        /// 企业管理员通过该接口删除企业的云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCorpVmrResponse DeleteCorpVmr(DeleteCorpVmrRequest deleteCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpVmrRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteCorpVmrResponse>(response);
        }

        public SyncInvoker<DeleteCorpVmrResponse> DeleteCorpVmrInvoker(DeleteCorpVmrRequest deleteCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpVmrRequest);
            return new SyncInvoker<DeleteCorpVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteCorpVmrResponse>);
        }
        
        /// <summary>
        /// 删除部门
        ///
        /// 企业管理员通过该接口删除部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDepartmentResponse DeleteDepartment(DeleteDepartmentRequest deleteDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", deleteDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDepartmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDepartmentResponse>(response);
        }

        public SyncInvoker<DeleteDepartmentResponse> DeleteDepartmentInvoker(DeleteDepartmentRequest deleteDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", deleteDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDepartmentRequest);
            return new SyncInvoker<DeleteDepartmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDepartmentResponse>);
        }
        
        /// <summary>
        /// 删除多画面布局
        ///
        /// 该接口用于删除当前会议已保存的多画面布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLayoutResponse DeleteLayout(DeleteLayoutRequest deleteLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLayoutRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLayoutResponse>(response);
        }

        public SyncInvoker<DeleteLayoutResponse> DeleteLayoutInvoker(DeleteLayoutRequest deleteLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLayoutRequest);
            return new SyncInvoker<DeleteLayoutResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLayoutResponse>);
        }
        
        /// <summary>
        /// 批量删除录制
        ///
        /// 该接口用于批量删除会议的录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordingsResponse DeleteRecordings(DeleteRecordingsRequest deleteRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordingsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordingsResponse>(response);
        }

        public SyncInvoker<DeleteRecordingsResponse> DeleteRecordingsInvoker(DeleteRecordingsRequest deleteRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordingsRequest);
            return new SyncInvoker<DeleteRecordingsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordingsResponse>);
        }
        
        /// <summary>
        /// SP管理员根据删除企业资源
        ///
        /// 企业删除资源项，删除资源项后，企业资源总数会自动减少。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceResponse DeleteResource(DeleteResourceRequest deleteResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", deleteResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteResourceResponse>(response);
        }

        public SyncInvoker<DeleteResourceResponse> DeleteResourceInvoker(DeleteResourceRequest deleteResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", deleteResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceRequest);
            return new SyncInvoker<DeleteResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteResourceResponse>);
        }
        
        /// <summary>
        /// 注销登录
        ///
        /// 该接口提供注销功能。服务器收到请求后，删除该Token。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTokenResponse DeleteToken(DeleteTokenRequest deleteTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTokenRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTokenResponse>(response);
        }

        public SyncInvoker<DeleteTokenResponse> DeleteTokenInvoker(DeleteTokenRequest deleteTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTokenRequest);
            return new SyncInvoker<DeleteTokenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTokenResponse>);
        }
        
        /// <summary>
        /// 企业管理员删除激活码
        ///
        /// 企业管理员批量删除激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVisionActiveCodeResponse DeleteVisionActiveCode(DeleteVisionActiveCodeRequest deleteVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVisionActiveCodeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVisionActiveCodeResponse>(response);
        }

        public SyncInvoker<DeleteVisionActiveCodeResponse> DeleteVisionActiveCodeInvoker(DeleteVisionActiveCodeRequest deleteVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVisionActiveCodeRequest);
            return new SyncInvoker<DeleteVisionActiveCodeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 删除事件推送
        ///
        /// 该接口用于管理员删除已配置的事件推送设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWebHookConfigResponse DeleteWebHookConfig(DeleteWebHookConfigRequest deleteWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebHookConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWebHookConfigResponse>(response);
        }

        public SyncInvoker<DeleteWebHookConfigResponse> DeleteWebHookConfigInvoker(DeleteWebHookConfigRequest deleteWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebHookConfigRequest);
            return new SyncInvoker<DeleteWebHookConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWebHookConfigResponse>);
        }
        
        /// <summary>
        /// 取消网络研讨会
        ///
        /// 该接口用于取消已预约的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWebinarResponse DeleteWebinar(DeleteWebinarRequest deleteWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", deleteWebinarRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebinarRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWebinarResponse>(response);
        }

        public SyncInvoker<DeleteWebinarResponse> DeleteWebinarInvoker(DeleteWebinarRequest deleteWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", deleteWebinarRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebinarRequest);
            return new SyncInvoker<DeleteWebinarResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWebinarResponse>);
        }
        
        /// <summary>
        /// 回收云会议室
        ///
        /// 企业管理员通过该接口回收云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateVmrResponse DisassociateVmr(DisassociateVmrRequest disassociateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", disassociateVmrRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/recycle-from-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateVmrRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateVmrResponse>(response);
        }

        public SyncInvoker<DisassociateVmrResponse> DisassociateVmrInvoker(DisassociateVmrRequest disassociateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", disassociateVmrRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/recycle-from-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateVmrRequest);
            return new SyncInvoker<DisassociateVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateVmrResponse>);
        }
        
        /// <summary>
        /// 举手
        ///
        /// 该接口用于设置指定与会者的举手/放下举手状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public HandResponse Hand(HandRequest handRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", handRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<HandResponse>(response);
        }

        public SyncInvoker<HandResponse> HandInvoker(HandRequest handRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", handRequest);
            return new SyncInvoker<HandResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<HandResponse>);
        }
        
        /// <summary>
        /// 挂断与会者
        ///
        /// 该接口用于挂断正在通话中的与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public HangUpResponse HangUp(HangUpRequest hangUpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hangUpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpResponse>(response);
        }

        public SyncInvoker<HangUpResponse> HangUpInvoker(HangUpRequest hangUpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hangUpRequest);
            return new SyncInvoker<HangUpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpResponse>);
        }
        
        /// <summary>
        /// 主持人邀请与会者开启/关闭摄像头
        ///
        /// 该接口用于邀请指定与会者开启、关闭摄像头。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteOperateVideoResponse InviteOperateVideo(InviteOperateVideoRequest inviteOperateVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/video", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteOperateVideoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<InviteOperateVideoResponse>(response);
        }

        public SyncInvoker<InviteOperateVideoResponse> InviteOperateVideoInvoker(InviteOperateVideoRequest inviteOperateVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/video", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteOperateVideoRequest);
            return new SyncInvoker<InviteOperateVideoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<InviteOperateVideoResponse>);
        }
        
        /// <summary>
        /// 邀请与会者
        ///
        /// 该接口用于邀请与会者加入会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteParticipantResponse InviteParticipant(InviteParticipantRequest inviteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteParticipantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<InviteParticipantResponse>(response);
        }

        public SyncInvoker<InviteParticipantResponse> InviteParticipantInvoker(InviteParticipantRequest inviteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteParticipantRequest);
            return new SyncInvoker<InviteParticipantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InviteParticipantResponse>);
        }
        
        /// <summary>
        /// 邀请共享
        ///
        /// 该接口用于邀请/取消邀请指定与会人共享桌面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteShareResponse InviteShare(InviteShareRequest inviteShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/share/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteShareRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<InviteShareResponse>(response);
        }

        public SyncInvoker<InviteShareResponse> InviteShareInvoker(InviteShareRequest inviteShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/share/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteShareRequest);
            return new SyncInvoker<InviteShareResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<InviteShareResponse>);
        }
        
        /// <summary>
        /// 邀请用户
        ///
        /// 通过手机号码或者邮箱地址邀请用户加入企业。
        /// * 若被邀请用户在华为云会议系统中不存在，则：
        ///   - 华为云会议免费版和华为云会议标准版发送短信/邮件邀请用户完成注册后加入企业。用户注册成功后，加入该企业。
        ///   - 华为云会议旗舰版在企业内直接添加该用户。用户会收到华为云会议的初始密码，用户第一次以手机号或者邮箱登录时，需要修改密码。
        /// * 若被邀请用户在华为云会议系统中存在，则该用户会收到短信或者邮件确认。确认完成后改用户加入企业内。该用户的密码保持原来的密码不变。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteUserResponse InviteUser(InviteUserRequest inviteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<InviteUserResponse>(response);
        }

        public SyncInvoker<InviteUserResponse> InviteUserInvoker(InviteUserRequest inviteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteUserRequest);
            return new SyncInvoker<InviteUserResponse>(this, "POST", request, JsonUtils.DeSerialize<InviteUserResponse>);
        }
        
        /// <summary>
        /// 通过会议ID和密码邀请与会者
        ///
        /// 该接口用于通过会议ID和密码邀请与会者。一般用于App已知会议ID和来宾密码，通过扫码等方式获取其他终端的SIP号码后，使用该接口将其他终端邀请加入会议中。
        /// &gt; 需要管理员在企业的“会议设置”&gt;“来宾扫码邀请任意硬终端入会”设置成打开，才允许通过来宾密码邀请其他终端入会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteWithPwdResponse InviteWithPwd(InviteWithPwdRequest inviteWithPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/inviteWithPwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteWithPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<InviteWithPwdResponse>(response);
        }

        public SyncInvoker<InviteWithPwdResponse> InviteWithPwdInvoker(InviteWithPwdRequest inviteWithPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/inviteWithPwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteWithPwdRequest);
            return new SyncInvoker<InviteWithPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InviteWithPwdResponse>);
        }
        
        /// <summary>
        /// 查询历史召开的网络研讨会列表
        ///
        /// 该接口用于查询历史网络研讨会。管理员可查询企业内历史网络研讨会，非管理员可查询个人历史网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistoryWebinarsResponse ListHistoryWebinars(ListHistoryWebinarsRequest listHistoryWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryWebinarsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryWebinarsResponse>(response);
        }

        public SyncInvoker<ListHistoryWebinarsResponse> ListHistoryWebinarsInvoker(ListHistoryWebinarsRequest listHistoryWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryWebinarsRequest);
            return new SyncInvoker<ListHistoryWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryWebinarsResponse>);
        }
        
        /// <summary>
        /// 查询会场网络质量
        ///
        /// 查询会场网络质量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNetworkQualityResponse ListNetworkQuality(ListNetworkQualityRequest listNetworkQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/cqs/media/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkQualityRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListNetworkQualityResponse>(response);
        }

        public SyncInvoker<ListNetworkQualityResponse> ListNetworkQualityInvoker(ListNetworkQualityRequest listNetworkQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/cqs/media/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkQualityRequest);
            return new SyncInvoker<ListNetworkQualityResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNetworkQualityResponse>);
        }
        
        /// <summary>
        /// 查询正在召开的网络研讨会列表
        ///
        /// 该接口用于查询正在召开的网络研讨会。管理员可查询企业内正在召开网络研讨会，非管理员可查询自己预订的正在召开的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOngoingWebinarsResponse ListOngoingWebinars(ListOngoingWebinarsRequest listOngoingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/ongoing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOngoingWebinarsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOngoingWebinarsResponse>(response);
        }

        public SyncInvoker<ListOngoingWebinarsResponse> ListOngoingWebinarsInvoker(ListOngoingWebinarsRequest listOngoingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/ongoing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOngoingWebinarsRequest);
            return new SyncInvoker<ListOngoingWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOngoingWebinarsResponse>);
        }
        
        /// <summary>
        /// 查询指定会议的在线与会者信息
        ///
        /// 该接口用于查询指定会议的在线与会者信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOnlineConfAttendeeResponse ListOnlineConfAttendee(ListOnlineConfAttendeeRequest listOnlineConfAttendeeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/conf-attendee", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnlineConfAttendeeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOnlineConfAttendeeResponse>(response);
        }

        public SyncInvoker<ListOnlineConfAttendeeResponse> ListOnlineConfAttendeeInvoker(ListOnlineConfAttendeeRequest listOnlineConfAttendeeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/conf-attendee", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnlineConfAttendeeRequest);
            return new SyncInvoker<ListOnlineConfAttendeeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOnlineConfAttendeeResponse>);
        }
        
        /// <summary>
        /// 查询即将召开的网络研讨会列表
        ///
        /// 该接口用于查询即将召开的网络研讨会。管理员可查询企业内即将召开网络研讨会，非管理员可查询自己预订的即将召开的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpComingWebinarsResponse ListUpComingWebinars(ListUpComingWebinarsRequest listUpComingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/upcoming", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpComingWebinarsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpComingWebinarsResponse>(response);
        }

        public SyncInvoker<ListUpComingWebinarsResponse> ListUpComingWebinarsInvoker(ListUpComingWebinarsRequest listUpComingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/upcoming", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpComingWebinarsRequest);
            return new SyncInvoker<ListUpComingWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpComingWebinarsResponse>);
        }
        
        /// <summary>
        /// 启停会议直播
        ///
        /// 该接口用于启动或停止会议直播。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LiveResponse Live(LiveRequest liveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/live", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<LiveResponse>(response);
        }

        public SyncInvoker<LiveResponse> LiveInvoker(LiveRequest liveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/live", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveRequest);
            return new SyncInvoker<LiveResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LiveResponse>);
        }
        
        /// <summary>
        /// 锁定会议
        ///
        /// 该接口用于锁定或解锁会议。锁定会议后，不允许新的来宾主动加入会议。会议锁定后使用主持人密码/主持人链接加入会议或者主持人邀请来宾不受影响。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LockMeetingResponse LockMeeting(LockMeetingRequest lockMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<LockMeetingResponse>(response);
        }

        public SyncInvoker<LockMeetingResponse> LockMeetingInvoker(LockMeetingRequest lockMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockMeetingRequest);
            return new SyncInvoker<LockMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LockMeetingResponse>);
        }
        
        /// <summary>
        /// 锁定会场视频源
        ///
        /// 该接口用于锁定或者解锁某在线会场的视频源。只适用于专业会议终端（如TE系列等）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LockViewResponse LockView(LockViewRequest lockViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lockView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockViewRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<LockViewResponse>(response);
        }

        public SyncInvoker<LockViewResponse> LockViewInvoker(LockViewRequest lockViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lockView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockViewRequest);
            return new SyncInvoker<LockViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LockViewResponse>);
        }
        
        /// <summary>
        /// 移入等候室
        ///
        /// 该接口用于将会中的指定与会者移入到等候室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MoveToWaitingRoomResponse MoveToWaitingRoom(MoveToWaitingRoomRequest moveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/moveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveToWaitingRoomRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<MoveToWaitingRoomResponse>(response);
        }

        public SyncInvoker<MoveToWaitingRoomResponse> MoveToWaitingRoomInvoker(MoveToWaitingRoomRequest moveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/moveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveToWaitingRoomRequest);
            return new SyncInvoker<MoveToWaitingRoomResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MoveToWaitingRoomResponse>);
        }
        
        /// <summary>
        /// 全场静音
        ///
        /// 该接口用于设置整个会议所有与会者（主持人除外）的静音/取消静音状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MuteMeetingResponse MuteMeeting(MuteMeetingRequest muteMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<MuteMeetingResponse>(response);
        }

        public SyncInvoker<MuteMeetingResponse> MuteMeetingInvoker(MuteMeetingRequest muteMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteMeetingRequest);
            return new SyncInvoker<MuteMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MuteMeetingResponse>);
        }
        
        /// <summary>
        /// 静音与会者
        ///
        /// 该接口用于设置指定与会者静音/取消静音状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MuteParticipantResponse MuteParticipant(MuteParticipantRequest muteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteParticipantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<MuteParticipantResponse>(response);
        }

        public SyncInvoker<MuteParticipantResponse> MuteParticipantInvoker(MuteParticipantRequest muteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteParticipantRequest);
            return new SyncInvoker<MuteParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MuteParticipantResponse>);
        }
        
        /// <summary>
        /// 主持人暂停/取消暂停会议
        ///
        /// 主持人通过接口控制暂停/取消暂停。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PauseConferenceResponse PauseConference(PauseConferenceRequest pauseConferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConferenceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PauseConferenceResponse>(response);
        }

        public SyncInvoker<PauseConferenceResponse> PauseConferenceInvoker(PauseConferenceRequest pauseConferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConferenceRequest);
            return new SyncInvoker<PauseConferenceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PauseConferenceResponse>);
        }
        
        /// <summary>
        /// 延长会议
        ///
        /// 该接口用于延长会议时间。默认会议自动延长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ProlongMeetingResponse ProlongMeeting(ProlongMeetingRequest prolongMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", prolongMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ProlongMeetingResponse>(response);
        }

        public SyncInvoker<ProlongMeetingResponse> ProlongMeetingInvoker(ProlongMeetingRequest prolongMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", prolongMeetingRequest);
            return new SyncInvoker<ProlongMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ProlongMeetingResponse>);
        }
        
        /// <summary>
        /// 启停会议录制
        ///
        /// 该接口用于启动或停止会议云录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RecordResponse Record(RecordRequest recordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RecordResponse>(response);
        }

        public SyncInvoker<RecordResponse> RecordInvoker(RecordRequest recordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recordRequest);
            return new SyncInvoker<RecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RecordResponse>);
        }
        
        /// <summary>
        /// 重命名与会者
        ///
        /// 重命名某个与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RenameParticipantResponse RenameParticipant(RenameParticipantRequest renameParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameParticipantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RenameParticipantResponse>(response);
        }

        public SyncInvoker<RenameParticipantResponse> RenameParticipantInvoker(RenameParticipantRequest renameParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameParticipantRequest);
            return new SyncInvoker<RenameParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RenameParticipantResponse>);
        }
        
        /// <summary>
        /// 企业管理员通过sn重置激活码
        ///
        /// 当硬终端激活码失效时，企业管理员可以通过该接口重置激活码，使用重新获取的激活码激活终端，每24小时可重新激活5次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetActivecodeResponse ResetActivecode(ResetActivecodeRequest resetActivecodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", resetActivecodeRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActivecodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetActivecodeResponse>(response);
        }

        public SyncInvoker<ResetActivecodeResponse> ResetActivecodeInvoker(ResetActivecodeRequest resetActivecodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", resetActivecodeRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActivecodeRequest);
            return new SyncInvoker<ResetActivecodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetActivecodeResponse>);
        }
        
        /// <summary>
        /// 重置企业应用appkey
        ///
        /// 企业默认管理员重置企业应用appkey
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetAppKeyResponse ResetAppKey(ResetAppKeyRequest resetAppKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", resetAppKeyRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetAppKeyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetAppKeyResponse>(response);
        }

        public SyncInvoker<ResetAppKeyResponse> ResetAppKeyInvoker(ResetAppKeyRequest resetAppKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", resetAppKeyRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetAppKeyRequest);
            return new SyncInvoker<ResetAppKeyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetAppKeyResponse>);
        }
        
        /// <summary>
        /// 用户重置密码
        ///
        /// 该接口提供给用户重置密码功能，服务器收到请求，重新设置用户密码并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdResponse ResetPwd(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public SyncInvoker<ResetPwdResponse> ResetPwdInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            return new SyncInvoker<ResetPwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
        }
        
        /// <summary>
        /// 企业管理员重置企业成员密码
        ///
        /// 企业管理员通过该接口提供企业管理员重置企业成员密码的功能。当服务器收到重置密码的请求时，发送新的密码到企业成员的邮箱或者短信，并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdByAdminResponse ResetPwdByAdmin(ResetPwdByAdminRequest resetPwdByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/admin/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdByAdminRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPwdByAdminResponse>(response);
        }

        public SyncInvoker<ResetPwdByAdminResponse> ResetPwdByAdminInvoker(ResetPwdByAdminRequest resetPwdByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/admin/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdByAdminRequest);
            return new SyncInvoker<ResetPwdByAdminResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPwdByAdminResponse>);
        }
        
        /// <summary>
        /// 企业管理员重置帐号的激活码
        ///
        /// 企业管理员重置帐号的激活码，重置后，原设备直接解绑，必须重新激活使用,若手机邮箱不填，则不会发送新的激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetVisionActiveCodeResponse ResetVisionActiveCode(ResetVisionActiveCodeRequest resetVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", resetVisionActiveCodeRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode/{account}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetVisionActiveCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetVisionActiveCodeResponse>(response);
        }

        public SyncInvoker<ResetVisionActiveCodeResponse> ResetVisionActiveCodeInvoker(ResetVisionActiveCodeRequest resetVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", resetVisionActiveCodeRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode/{account}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetVisionActiveCodeRequest);
            return new SyncInvoker<ResetVisionActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 开启/关闭同声传译
        ///
        /// 该接口用于会议主席可以通过该接口开启/关闭同声传译。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResumeSimultaneousInterpretationResponse ResumeSimultaneousInterpretation(ResumeSimultaneousInterpretationRequest resumeSimultaneousInterpretationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/simultaneousInterpretation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeSimultaneousInterpretationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResumeSimultaneousInterpretationResponse>(response);
        }

        public SyncInvoker<ResumeSimultaneousInterpretationResponse> ResumeSimultaneousInterpretationInvoker(ResumeSimultaneousInterpretationRequest resumeSimultaneousInterpretationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/simultaneousInterpretation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeSimultaneousInterpretationRequest);
            return new SyncInvoker<ResumeSimultaneousInterpretationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResumeSimultaneousInterpretationResponse>);
        }
        
        /// <summary>
        /// 点名会场
        ///
        /// 该接口用于点名指定与会者。点名会场的效果是除了主持人外，点名与会者为非静音状态，未点名的与会者统一为静音状态。同一时间，只允许一个与会者被点名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollcallParticipantResponse RollcallParticipant(RollcallParticipantRequest rollcallParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/rollCall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollcallParticipantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RollcallParticipantResponse>(response);
        }

        public SyncInvoker<RollcallParticipantResponse> RollcallParticipantInvoker(RollcallParticipantRequest rollcallParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/rollCall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollcallParticipantRequest);
            return new SyncInvoker<RollcallParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RollcallParticipantResponse>);
        }
        
        /// <summary>
        /// 保存多画面布局
        ///
        /// 该接口用于保存多画面布局。保存的多画面布局，只能在当前会议使用，会议结束后，保存的多画面布局就会释放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveLayoutResponse SaveLayout(SaveLayoutRequest saveLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLayoutRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SaveLayoutResponse>(response);
        }

        public SyncInvoker<SaveLayoutResponse> SaveLayoutInvoker(SaveLayoutRequest saveLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLayoutRequest);
            return new SyncInvoker<SaveLayoutResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SaveLayoutResponse>);
        }
        
        /// <summary>
        /// 查询历史会议的与会者记录
        ///
        /// 该接口用于查询指定历史会议的与会者记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchAttendanceRecordsOfHisMeetingResponse SearchAttendanceRecordsOfHisMeeting(SearchAttendanceRecordsOfHisMeetingRequest searchAttendanceRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confAttendeeRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAttendanceRecordsOfHisMeetingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchAttendanceRecordsOfHisMeetingResponse>(response);
        }

        public SyncInvoker<SearchAttendanceRecordsOfHisMeetingResponse> SearchAttendanceRecordsOfHisMeetingInvoker(SearchAttendanceRecordsOfHisMeetingRequest searchAttendanceRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confAttendeeRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAttendanceRecordsOfHisMeetingRequest);
            return new SyncInvoker<SearchAttendanceRecordsOfHisMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchAttendanceRecordsOfHisMeetingResponse>);
        }
        
        /// <summary>
        /// SP管理员分页搜索企业
        ///
        /// SP管理员分页搜索企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpResponse SearchCorp(SearchCorpRequest searchCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpResponse>(response);
        }

        public SyncInvoker<SearchCorpResponse> SearchCorpInvoker(SearchCorpRequest searchCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpRequest);
            return new SyncInvoker<SearchCorpResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpResponse>);
        }
        
        /// <summary>
        /// 分页查询企业管理员
        ///
        /// 通过该接口分页查询企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpAdminsResponse SearchCorpAdmins(SearchCorpAdminsRequest searchCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpAdminsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpAdminsResponse>(response);
        }

        public SyncInvoker<SearchCorpAdminsResponse> SearchCorpAdminsInvoker(SearchCorpAdminsRequest searchCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpAdminsRequest);
            return new SyncInvoker<SearchCorpAdminsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpAdminsResponse>);
        }
        
        /// <summary>
        /// 查询企业通讯录
        ///
        /// 企业用户（含管理员）通过该接口查询该企业的通讯录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpDirResponse SearchCorpDir(SearchCorpDirRequest searchCorpDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpDirRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpDirResponse>(response);
        }

        public SyncInvoker<SearchCorpDirResponse> SearchCorpDirInvoker(SearchCorpDirRequest searchCorpDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpDirRequest);
            return new SyncInvoker<SearchCorpDirResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpDirResponse>);
        }
        
        /// <summary>
        /// 查询企业外部联系人
        ///
        /// 企业用户（含管理员）通过该接口查询该企业的外部联系人或者个人外部联系人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpExternalDirResponse SearchCorpExternalDir(SearchCorpExternalDirRequest searchCorpExternalDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/external-contacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpExternalDirRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpExternalDirResponse>(response);
        }

        public SyncInvoker<SearchCorpExternalDirResponse> SearchCorpExternalDirInvoker(SearchCorpExternalDirRequest searchCorpExternalDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/external-contacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpExternalDirRequest);
            return new SyncInvoker<SearchCorpExternalDirResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpExternalDirResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询企业资源订单列表
        ///
        /// 企业管理员根据条件查询企业资源订单列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpResourcesResponse SearchCorpResources(SearchCorpResourcesRequest searchCorpResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpResourcesResponse>(response);
        }

        public SyncInvoker<SearchCorpResourcesResponse> SearchCorpResourcesInvoker(SearchCorpResourcesRequest searchCorpResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpResourcesRequest);
            return new SyncInvoker<SearchCorpResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpResourcesResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询企业云会议室
        ///
        /// 企业管理员通过该接口分页查询企业的云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCorpVmrResponse SearchCorpVmr(SearchCorpVmrRequest searchCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpVmrRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpVmrResponse>(response);
        }

        public SyncInvoker<SearchCorpVmrResponse> SearchCorpVmrInvoker(SearchCorpVmrRequest searchCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpVmrRequest);
            return new SyncInvoker<SearchCorpVmrResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpVmrResponse>);
        }
        
        /// <summary>
        /// 查询历史会议的会控记录
        ///
        /// 该接口用于查询指定历史会议的会控记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchCtlRecordsOfHisMeetingResponse SearchCtlRecordsOfHisMeeting(SearchCtlRecordsOfHisMeetingRequest searchCtlRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confCtlRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCtlRecordsOfHisMeetingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchCtlRecordsOfHisMeetingResponse>(response);
        }

        public SyncInvoker<SearchCtlRecordsOfHisMeetingResponse> SearchCtlRecordsOfHisMeetingInvoker(SearchCtlRecordsOfHisMeetingRequest searchCtlRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confCtlRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCtlRecordsOfHisMeetingRequest);
            return new SyncInvoker<SearchCtlRecordsOfHisMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCtlRecordsOfHisMeetingResponse>);
        }
        
        /// <summary>
        /// 按名称查询所有的部门
        ///
        /// 企业管理员通过该接口按名称查询所有的部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchDepartmentByNameResponse SearchDepartmentByName(SearchDepartmentByNameRequest searchDepartmentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDepartmentByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            var searchDepartmentByNameResponse = JsonUtils.DeSerializeNull<SearchDepartmentByNameResponse>(response);
            searchDepartmentByNameResponse.Body = JsonUtils.DeSerializeList<QueryDeptResultDTO>(response);
            return searchDepartmentByNameResponse;
        }

        public SyncInvoker<SearchDepartmentByNameResponse> SearchDepartmentByNameInvoker(SearchDepartmentByNameRequest searchDepartmentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDepartmentByNameRequest);
            return new SyncInvoker<SearchDepartmentByNameResponse>(this, "GET", request, response =>
            {
                var searchDepartmentByNameResponse = JsonUtils.DeSerializeNull<SearchDepartmentByNameResponse>(response);
                searchDepartmentByNameResponse.Body = JsonUtils.DeSerializeList<QueryDeptResultDTO>(response);
                return searchDepartmentByNameResponse;
            });
        }
        
        /// <summary>
        /// 分页查询终端
        ///
        /// 企业管理员通过该接口分页查询专业会议终端信息。
        /// &gt; 如果需要查询Ideahub、SmartRooms、智慧屏TV请使用[[分页查询用户](https://support.huaweicloud.com/api-meeting/meeting_21_0071.html)](tag:hws)[[分页查询用户](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0071.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchDevicesResponse SearchDevices(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchDevicesResponse>(response);
        }

        public SyncInvoker<SearchDevicesResponse> SearchDevicesInvoker(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            return new SyncInvoker<SearchDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchDevicesResponse>);
        }
        
        /// <summary>
        /// 查询历史会议列表
        ///
        /// 该接口用于查询已经结束的会议。管理员可以查询本企业内所有的历史会议，普通用户仅能查询自己创建或者被邀请的历史会议。不带查询参数时，默认查询权限范围内的历史会议。
        /// &gt; * 普通用户如果只是通过会议ID或者会议链接接入会议，不是预定者会前邀请或者会中主持人邀请的，则历史会议中无法查到
        /// &gt; * 如果同一个会议召开并结束多次，则会产生多条历史会议（会议ID相同，会议UUID不同）
        /// &gt; * 历史会议记录默认保留6个月，最长保留12个月。保留时间管理员可在“会议设置”的“历史会议留存时间”中修改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchHisMeetingsResponse SearchHisMeetings(SearchHisMeetingsRequest searchHisMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchHisMeetingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchHisMeetingsResponse>(response);
        }

        public SyncInvoker<SearchHisMeetingsResponse> SearchHisMeetingsInvoker(SearchHisMeetingsRequest searchHisMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchHisMeetingsRequest);
            return new SyncInvoker<SearchHisMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchHisMeetingsResponse>);
        }
        
        /// <summary>
        /// 分页查询信息窗素材
        ///
        /// 分页查询信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchMaterialsResponse SearchMaterials(SearchMaterialsRequest searchMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMaterialsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchMaterialsResponse>(response);
        }

        public SyncInvoker<SearchMaterialsResponse> SearchMaterialsInvoker(SearchMaterialsRequest searchMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMaterialsRequest);
            return new SyncInvoker<SearchMaterialsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMaterialsResponse>);
        }
        
        /// <summary>
        /// 查询会议纪要列表
        ///
        /// 用户查询自己的会议纪要列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchMeetingFileListResponse SearchMeetingFileList(SearchMeetingFileListRequest searchMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingFileListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchMeetingFileListResponse>(response);
        }

        public SyncInvoker<SearchMeetingFileListResponse> SearchMeetingFileListInvoker(SearchMeetingFileListRequest searchMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingFileListRequest);
            return new SyncInvoker<SearchMeetingFileListResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMeetingFileListResponse>);
        }
        
        /// <summary>
        /// 查询会议列表
        ///
        /// 该接口用于查询尚未结束的会议。
        /// * 管理员可以查询管理权限域内所有的会议，普通用户仅能查询自己创建或者需要参加的会议。不带查询参数时，默认查询权限范围内正在召开或还未召开的会议。
        /// * 只能查询尚未结束的会议（既正在召开的会议和已预约还未召开的会议）。如果需要查询历史会议列表，请参考[[查询历史会议列表](https://support.huaweicloud.com/api-meeting/meeting_21_0051.html)](tag:hws)[[查询历史会议列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0051.html)](tag:hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchMeetingsResponse SearchMeetings(SearchMeetingsRequest searchMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchMeetingsResponse>(response);
        }

        public SyncInvoker<SearchMeetingsResponse> SearchMeetingsInvoker(SearchMeetingsRequest searchMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingsRequest);
            return new SyncInvoker<SearchMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMeetingsResponse>);
        }
        
        /// <summary>
        /// 普通用户分页查询云会议室及个人会议ID
        ///
        /// 企业用户通过该接口查询个人已分配的云会议室及个人会议ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchMemberVmrResponse SearchMemberVmr(SearchMemberVmrRequest searchMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMemberVmrRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchMemberVmrResponse>(response);
        }

        public SyncInvoker<SearchMemberVmrResponse> SearchMemberVmrInvoker(SearchMemberVmrRequest searchMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMemberVmrRequest);
            return new SyncInvoker<SearchMemberVmrResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMemberVmrResponse>);
        }
        
        /// <summary>
        /// 查询在线会议列表
        ///
        /// 该接口用于查询正在召开的会议列表。管理员可以查询本企业内所有在线会议，普通用户仅能查询当前自己帐号创建或者需要参加的在线会议。不带查询参数时，默认查询权限范围内的在线会议，按开始时间升序排列。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchOnlineMeetingsResponse SearchOnlineMeetings(SearchOnlineMeetingsRequest searchOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchOnlineMeetingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchOnlineMeetingsResponse>(response);
        }

        public SyncInvoker<SearchOnlineMeetingsResponse> SearchOnlineMeetingsInvoker(SearchOnlineMeetingsRequest searchOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchOnlineMeetingsRequest);
            return new SyncInvoker<SearchOnlineMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchOnlineMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询信息窗节目
        ///
        /// 获取信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchProgramsResponse SearchPrograms(SearchProgramsRequest searchProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchProgramsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchProgramsResponse>(response);
        }

        public SyncInvoker<SearchProgramsResponse> SearchProgramsInvoker(SearchProgramsRequest searchProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchProgramsRequest);
            return new SyncInvoker<SearchProgramsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchProgramsResponse>);
        }
        
        /// <summary>
        /// 查询信息窗发布
        ///
        /// 获取信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchPublicationsResponse SearchPublications(SearchPublicationsRequest searchPublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchPublicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchPublicationsResponse>(response);
        }

        public SyncInvoker<SearchPublicationsResponse> SearchPublicationsInvoker(SearchPublicationsRequest searchPublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchPublicationsRequest);
            return new SyncInvoker<SearchPublicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchPublicationsResponse>);
        }
        
        /// <summary>
        /// 查询录制列表
        ///
        /// 该接口用于查询会议录制列表。管理员可以查询本企业内所有的录制，普通用户仅能查询自己创建的会议的录制。不带查询参数时，默认查询权限范围内的录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchRecordingsResponse SearchRecordings(SearchRecordingsRequest searchRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchRecordingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchRecordingsResponse>(response);
        }

        public SyncInvoker<SearchRecordingsResponse> SearchRecordingsInvoker(SearchRecordingsRequest searchRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchRecordingsRequest);
            return new SyncInvoker<SearchRecordingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchRecordingsResponse>);
        }
        
        /// <summary>
        /// SP管理员根据分页查询企业资源
        ///
        /// SP根据条件查询企业的资源项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceResponse SearchResource(SearchResourceRequest searchResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", searchResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchResourceResponse>(response);
        }

        public SyncInvoker<SearchResourceResponse> SearchResourceInvoker(SearchResourceRequest searchResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", searchResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceRequest);
            return new SyncInvoker<SearchResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchResourceResponse>);
        }
        
        /// <summary>
        /// SP管理员分页查询企业资源操作记录
        ///
        /// SP根据根据条件查询企业的资源操作记录，支持根据resourceId模糊搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceOpRecordResponse SearchResourceOpRecord(SearchResourceOpRecordRequest searchResourceOpRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", searchResourceOpRecordRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceOpRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchResourceOpRecordResponse>(response);
        }

        public SyncInvoker<SearchResourceOpRecordResponse> SearchResourceOpRecordInvoker(SearchResourceOpRecordRequest searchResourceOpRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", searchResourceOpRecordRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceOpRecordRequest);
            return new SyncInvoker<SearchResourceOpRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchResourceOpRecordResponse>);
        }
        
        /// <summary>
        /// 分页查询用户
        ///
        /// 企业管理员通过该接口分页查询企业用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchUsersResponse SearchUsers(SearchUsersRequest searchUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchUsersResponse>(response);
        }

        public SyncInvoker<SearchUsersResponse> SearchUsersInvoker(SearchUsersRequest searchUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchUsersRequest);
            return new SyncInvoker<SearchUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchUsersResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询激活码
        ///
        /// 企业管理员分页查询激活码，支持激活码、终端名称模糊查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchVisionActiveCodeResponse SearchVisionActiveCode(SearchVisionActiveCodeRequest searchVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchVisionActiveCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchVisionActiveCodeResponse>(response);
        }

        public SyncInvoker<SearchVisionActiveCodeResponse> SearchVisionActiveCodeInvoker(SearchVisionActiveCodeRequest searchVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchVisionActiveCodeRequest);
            return new SyncInvoker<SearchVisionActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 发送滑块验证码
        ///
        /// 该接口提供发送滑块验证码。服务器收到请求，返回抠图以及抠图后的原图等结果。需要在前台界面显示出抠图以及抠图后的原图，用户通过滑块操作来匹配图形。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendSlideVerifyCodeResponse SendSlideVerifyCode(SendSlideVerifyCodeRequest sendSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSlideVerifyCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendSlideVerifyCodeResponse>(response);
        }

        public SyncInvoker<SendSlideVerifyCodeResponse> SendSlideVerifyCodeInvoker(SendSlideVerifyCodeRequest sendSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSlideVerifyCodeRequest);
            return new SyncInvoker<SendSlideVerifyCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<SendSlideVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 发送验证码
        ///
        /// 该接口提供发送验证码，服务器收到请求，发送验证码到邮箱或者短信并返回结果。用户在前台界面通过滑块验证后，再进行发送验证码操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendVeriCodeForChangePwdResponse SendVeriCodeForChangePwd(SendVeriCodeForChangePwdRequest sendVeriCodeForChangePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForChangePwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendVeriCodeForChangePwdResponse>(response);
        }

        public SyncInvoker<SendVeriCodeForChangePwdResponse> SendVeriCodeForChangePwdInvoker(SendVeriCodeForChangePwdRequest sendVeriCodeForChangePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForChangePwdRequest);
            return new SyncInvoker<SendVeriCodeForChangePwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SendVeriCodeForChangePwdResponse>);
        }
        
        /// <summary>
        /// 获取验证码
        ///
        /// 修改用户手机或邮箱时，需要获取验证码。企业用户通过该接口获取验证码，系统会向用户的手机或邮箱发送，验证码1分钟内有效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendVeriCodeForUpdateUserInfoResponse SendVeriCodeForUpdateUserInfo(SendVeriCodeForUpdateUserInfoRequest sendVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForUpdateUserInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SendVeriCodeForUpdateUserInfoResponse>(response);
        }

        public SyncInvoker<SendVeriCodeForUpdateUserInfoResponse> SendVeriCodeForUpdateUserInfoInvoker(SendVeriCodeForUpdateUserInfoRequest sendVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForUpdateUserInfoRequest);
            return new SyncInvoker<SendVeriCodeForUpdateUserInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendVeriCodeForUpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 设置普通与会人的语言频道
        ///
        /// 主持人通过该接口设置某些普通与会者(包括主持人)加入哪个语言频道。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAttendeeLanChannelResponse SetAttendeeLanChannel(SetAttendeeLanChannelRequest setAttendeeLanChannelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/setAttendeeLanChannel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAttendeeLanChannelRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAttendeeLanChannelResponse>(response);
        }

        public SyncInvoker<SetAttendeeLanChannelResponse> SetAttendeeLanChannelInvoker(SetAttendeeLanChannelRequest setAttendeeLanChannelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/setAttendeeLanChannel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAttendeeLanChannelRequest);
            return new SyncInvoker<SetAttendeeLanChannelResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAttendeeLanChannelResponse>);
        }
        
        /// <summary>
        /// 申请联席主持人
        ///
        /// 该接口用于设置联席主持人或释放联席主持人。只能将来宾设置为联席主持人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetCohostResponse SetCohost(SetCohostRequest setCohostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/cohost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCohostRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetCohostResponse>(response);
        }

        public SyncInvoker<SetCohostResponse> SetCohostInvoker(SetCohostRequest setCohostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/cohost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCohostRequest);
            return new SyncInvoker<SetCohostResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetCohostResponse>);
        }
        
        /// <summary>
        /// 设置自定义多画面
        ///
        /// 该接口用于设置会中多画面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetCustomMultiPictureResponse SetCustomMultiPicture(SetCustomMultiPictureRequest setCustomMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/customMultiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCustomMultiPictureRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetCustomMultiPictureResponse>(response);
        }

        public SyncInvoker<SetCustomMultiPictureResponse> SetCustomMultiPictureInvoker(SetCustomMultiPictureRequest setCustomMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/customMultiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCustomMultiPictureRequest);
            return new SyncInvoker<SetCustomMultiPictureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetCustomMultiPictureResponse>);
        }
        
        /// <summary>
        /// 主持人选看
        ///
        /// 该接口用于主持人轮询、主持人选看多画面、主持人选看会场操作。只适用于专业会议终端（如TE系列等）为主持人的场景。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetHostViewResponse SetHostView(SetHostViewRequest setHostViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/chairView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setHostViewRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetHostViewResponse>(response);
        }

        public SyncInvoker<SetHostViewResponse> SetHostViewInvoker(SetHostViewRequest setHostViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/chairView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setHostViewRequest);
            return new SyncInvoker<SetHostViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetHostViewResponse>);
        }
        
        /// <summary>
        /// 设置传译组
        ///
        /// 主持人通过该接口设置传译组，每个传译组支持两种语言，传译组内支持多个传译员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetInterpreterGroupResponse SetInterpreterGroup(SetInterpreterGroupRequest setInterpreterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/interpreterGroup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInterpreterGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetInterpreterGroupResponse>(response);
        }

        public SyncInvoker<SetInterpreterGroupResponse> SetInterpreterGroupInvoker(SetInterpreterGroupRequest setInterpreterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/interpreterGroup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInterpreterGroupRequest);
            return new SyncInvoker<SetInterpreterGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetInterpreterGroupResponse>);
        }
        
        /// <summary>
        /// 启动/停止Mmr会议直播
        ///
        /// 使用场景：会议主持人可以通过该接口启动/停止Mmr会议直播 功能描述：提供启动/停止会议Mmr直播的能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetMmrLiveResponse SetMmrLive(SetMmrLiveRequest setMmrLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrLive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrLiveRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMmrLiveResponse>(response);
        }

        public SyncInvoker<SetMmrLiveResponse> SetMmrLiveInvoker(SetMmrLiveRequest setMmrLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrLive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrLiveRequest);
            return new SyncInvoker<SetMmrLiveResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMmrLiveResponse>);
        }
        
        /// <summary>
        /// 启动/暂停/停止mmr会议录制
        ///
        /// 使用场景：管理员或UC账号主席可以通过该接口启动/停止mmr会议录制 功能描述：提供启动/暂停/停止MMR会议录制的能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetMmrRecordResponse SetMmrRecord(SetMmrRecordRequest setMmrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrRecordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMmrRecordResponse>(response);
        }

        public SyncInvoker<SetMmrRecordResponse> SetMmrRecordInvoker(SetMmrRecordRequest setMmrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrRecordRequest);
            return new SyncInvoker<SetMmrRecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMmrRecordResponse>);
        }
        
        /// <summary>
        /// 设置多画面
        ///
        /// 设置会议多画面。该接口废弃不用，请使用“[[设置自定义多画面](https://support.huaweicloud.com/api-meeting/meeting_21_0418.html)](tag:hws)[[设置自定义多画面](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0418.html)](tag:hk)”接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetMultiPictureResponse SetMultiPicture(SetMultiPictureRequest setMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/multiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMultiPictureRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMultiPictureResponse>(response);
        }

        public SyncInvoker<SetMultiPictureResponse> SetMultiPictureInvoker(SetMultiPictureRequest setMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/multiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMultiPictureRequest);
            return new SyncInvoker<SetMultiPictureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMultiPictureResponse>);
        }
        
        /// <summary>
        /// 会场选看
        ///
        /// 该接口用于专业会议终端（如TE系列等）选看其他与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetParticipantViewResponse SetParticipantView(SetParticipantViewRequest setParticipantViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/partView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setParticipantViewRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetParticipantViewResponse>(response);
        }

        public SyncInvoker<SetParticipantViewResponse> SetParticipantViewInvoker(SetParticipantViewRequest setParticipantViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/partView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setParticipantViewRequest);
            return new SyncInvoker<SetParticipantViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetParticipantViewResponse>);
        }
        
        /// <summary>
        /// 用户设置头像
        ///
        /// 用户设置头像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetProfileImageResponse SetProfileImage(SetProfileImageRequest setProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setProfileImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetProfileImageResponse>(response);
        }

        public SyncInvoker<SetProfileImageResponse> SetProfileImageInvoker(SetProfileImageRequest setProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setProfileImageRequest);
            return new SyncInvoker<SetProfileImageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetProfileImageResponse>);
        }
        
        /// <summary>
        /// 申请主持人
        ///
        /// 该接口用于设置主持人或释放主持人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRoleResponse SetRole(SetRoleRequest setRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRoleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRoleResponse>(response);
        }

        public SyncInvoker<SetRoleResponse> SetRoleInvoker(SetRoleRequest setRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRoleRequest);
            return new SyncInvoker<SetRoleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRoleResponse>);
        }
        
        /// <summary>
        /// 设置SSO登录配置
        ///
        /// 该接口用于设置SSO登录的鉴权配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSsoConfigResponse SetSsoConfig(SetSsoConfigRequest setSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSsoConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetSsoConfigResponse>(response);
        }

        public SyncInvoker<SetSsoConfigResponse> SetSsoConfigInvoker(SetSsoConfigRequest setSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSsoConfigRequest);
            return new SyncInvoker<SetSsoConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetSsoConfigResponse>);
        }
        
        /// <summary>
        /// 企业管理员设置企业成员头像
        ///
        /// 为企业内的用户设置头像（只允许管理员调用）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetUserProfileImageResponse SetUserProfileImage(SetUserProfileImageRequest setUserProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", setUserProfileImageRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setUserProfileImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetUserProfileImageResponse>(response);
        }

        public SyncInvoker<SetUserProfileImageResponse> SetUserProfileImageInvoker(SetUserProfileImageRequest setUserProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", setUserProfileImageRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setUserProfileImageRequest);
            return new SyncInvoker<SetUserProfileImageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetUserProfileImageResponse>);
        }
        
        /// <summary>
        /// 设置事件推送
        ///
        /// 该接口用于管理员设置企业级会议事件订阅配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetWebHookConfigResponse SetWebHookConfig(SetWebHookConfigRequest setWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setWebHookConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetWebHookConfigResponse>(response);
        }

        public SyncInvoker<SetWebHookConfigResponse> SetWebHookConfigInvoker(SetWebHookConfigRequest setWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setWebHookConfigRequest);
            return new SyncInvoker<SetWebHookConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetWebHookConfigResponse>);
        }
        
        /// <summary>
        /// SP管理员查询会议归属企业
        ///
        /// SP管理员根据会议ID查询该会议归属的企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfOrgResponse ShowConfOrg(ShowConfOrgRequest showConfOrgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confOrg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfOrgRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfOrgResponse>(response);
        }

        public SyncInvoker<ShowConfOrgResponse> ShowConfOrgInvoker(ShowConfOrgRequest showConfOrgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confOrg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfOrgRequest);
            return new SyncInvoker<ShowConfOrgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfOrgResponse>);
        }
        
        /// <summary>
        /// SP管理员查询企业
        ///
        /// 获取企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCorpResponse ShowCorp(ShowCorpRequest showCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpResponse>(response);
        }

        public SyncInvoker<ShowCorpResponse> ShowCorpInvoker(ShowCorpRequest showCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpRequest);
            return new SyncInvoker<ShowCorpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpResponse>);
        }
        
        /// <summary>
        /// 查询企业管理员
        ///
        /// 通过该接口查询企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCorpAdminResponse ShowCorpAdmin(ShowCorpAdminRequest showCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", showCorpAdminRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpAdminRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpAdminResponse>(response);
        }

        public SyncInvoker<ShowCorpAdminResponse> ShowCorpAdminInvoker(ShowCorpAdminRequest showCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", showCorpAdminRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpAdminRequest);
            return new SyncInvoker<ShowCorpAdminResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpAdminResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业注册信息
        ///
        /// 企业管理员通过该接口查询企业注册信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCorpBasicInfoResponse ShowCorpBasicInfo(ShowCorpBasicInfoRequest showCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpBasicInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpBasicInfoResponse>(response);
        }

        public SyncInvoker<ShowCorpBasicInfoResponse> ShowCorpBasicInfoInvoker(ShowCorpBasicInfoRequest showCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpBasicInfoRequest);
            return new SyncInvoker<ShowCorpBasicInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpBasicInfoResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业内资源及业务权限
        ///
        /// 企业管理员通过该接口查询企业内资源及业务权限，包括查询已使用的资源情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCorpResourceResponse ShowCorpResource(ShowCorpResourceRequest showCorpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpResourceResponse>(response);
        }

        public SyncInvoker<ShowCorpResourceResponse> ShowCorpResourceInvoker(ShowCorpResourceRequest showCorpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpResourceRequest);
            return new SyncInvoker<ShowCorpResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpResourceResponse>);
        }
        
        /// <summary>
        /// 通过部门编码查询部门信息
        ///
        /// 通过部门编码查询部门信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDepartmentResponse ShowDepartment(ShowDepartmentRequest showDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", showDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/departments/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDepartmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDepartmentResponse>(response);
        }

        public SyncInvoker<ShowDepartmentResponse> ShowDepartmentInvoker(ShowDepartmentRequest showDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", showDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/departments/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDepartmentRequest);
            return new SyncInvoker<ShowDepartmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDepartmentResponse>);
        }
        
        /// <summary>
        /// 查询部门及其一级子部门列表
        ///
        /// 企业管理员通过该接口查询部门及其一级子部门列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeptAndChildDeptResponse ShowDeptAndChildDept(ShowDeptAndChildDeptRequest showDeptAndChildDeptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", showDeptAndChildDeptRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeptAndChildDeptRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeptAndChildDeptResponse>(response);
        }

        public SyncInvoker<ShowDeptAndChildDeptResponse> ShowDeptAndChildDeptInvoker(ShowDeptAndChildDeptRequest showDeptAndChildDeptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", showDeptAndChildDeptRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeptAndChildDeptRequest);
            return new SyncInvoker<ShowDeptAndChildDeptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeptAndChildDeptResponse>);
        }
        
        /// <summary>
        /// 查询终端详情
        ///
        /// 企业管理员通过该接口查询专业会议终端详情。
        /// &gt; 如果需要查询Ideahub、SmartRooms、智慧屏TV详情请使用[[查询用户详情](https://support.huaweicloud.com/api-meeting/meeting_21_0069.html)](tag:hws)[[查询用户详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0069.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceDetailResponse ShowDeviceDetail(ShowDeviceDetailRequest showDeviceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", showDeviceDetailRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceDetailResponse>(response);
        }

        public SyncInvoker<ShowDeviceDetailResponse> ShowDeviceDetailInvoker(ShowDeviceDetailRequest showDeviceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", showDeviceDetailRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceDetailRequest);
            return new SyncInvoker<ShowDeviceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceDetailResponse>);
        }
        
        /// <summary>
        /// 查询设备状态
        ///
        /// 调用本接口可以查询硬终端的状态。
        /// 硬终端与发起查询请求的帐号需在同一企业下，否则会鉴权失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceStatusResponse ShowDeviceStatus(ShowDeviceStatusRequest showDeviceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/ap/userstatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            var showDeviceStatusResponse = JsonUtils.DeSerializeNull<ShowDeviceStatusResponse>(response);
            showDeviceStatusResponse.Body = JsonUtils.DeSerializeList<UserStatusDTO>(response);
            return showDeviceStatusResponse;
        }

        public SyncInvoker<ShowDeviceStatusResponse> ShowDeviceStatusInvoker(ShowDeviceStatusRequest showDeviceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/ap/userstatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceStatusRequest);
            return new SyncInvoker<ShowDeviceStatusResponse>(this, "POST", request, response =>
            {
                var showDeviceStatusResponse = JsonUtils.DeSerializeNull<ShowDeviceStatusResponse>(response);
                showDeviceStatusResponse.Body = JsonUtils.DeSerializeList<UserStatusDTO>(response);
                return showDeviceStatusResponse;
            });
        }
        
        /// <summary>
        /// 获取所有终端类型
        ///
        /// 企业管理员通过该接口获取所有的专业会议终端类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceTypesResponse ShowDeviceTypes(ShowDeviceTypesRequest showDeviceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/termdevtype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            var showDeviceTypesResponse = JsonUtils.DeSerializeNull<ShowDeviceTypesResponse>(response);
            showDeviceTypesResponse.Body = JsonUtils.DeSerializeList<QueryDeviceTypeResultDTO>(response);
            return showDeviceTypesResponse;
        }

        public SyncInvoker<ShowDeviceTypesResponse> ShowDeviceTypesInvoker(ShowDeviceTypesRequest showDeviceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/termdevtype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTypesRequest);
            return new SyncInvoker<ShowDeviceTypesResponse>(this, "GET", request, response =>
            {
                var showDeviceTypesResponse = JsonUtils.DeSerializeNull<ShowDeviceTypesResponse>(response);
                showDeviceTypesResponse.Body = JsonUtils.DeSerializeList<QueryDeviceTypeResultDTO>(response);
                return showDeviceTypesResponse;
            });
        }
        
        /// <summary>
        /// 查询历史会议详情
        ///
        /// 该接口用户查询指定历史会议的详情。管理员可以查询本企业内所有的历史会议详情，普通用户仅能查询自己创建或者被邀请的历史会议详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHisMeetingDetailResponse ShowHisMeetingDetail(ShowHisMeetingDetailRequest showHisMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHisMeetingDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHisMeetingDetailResponse>(response);
        }

        public SyncInvoker<ShowHisMeetingDetailResponse> ShowHisMeetingDetailInvoker(ShowHisMeetingDetailRequest showHisMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHisMeetingDetailRequest);
            return new SyncInvoker<ShowHisMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHisMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 查询多画面布局
        ///
        /// 该接口用于查询当前会议已保存的多画面布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLayoutResponse ShowLayout(ShowLayoutRequest showLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLayoutRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLayoutResponse>(response);
        }

        public SyncInvoker<ShowLayoutResponse> ShowLayoutInvoker(ShowLayoutRequest showLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLayoutRequest);
            return new SyncInvoker<ShowLayoutResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLayoutResponse>);
        }
        
        /// <summary>
        /// 查询会议详情
        ///
        /// 查询偏移量
        /// * 管理员可以查询管理权限域内所有会议的详情，普通用户仅能查询自己创建或者需要参加的会议详情。
        /// * 只能查询尚未结束的会议（既正在召开的会议和已预约还未召开的会议）。如果需要查询历史会议列详情，请参考[[查询历史会议详情](https://support.huaweicloud.com/api-meeting/meeting_21_0052.html)](tag:hws)[[查询历史会议详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0052.html)](tag:hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMeetingDetailResponse ShowMeetingDetail(ShowMeetingDetailRequest showMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMeetingDetailResponse>(response);
        }

        public SyncInvoker<ShowMeetingDetailResponse> ShowMeetingDetailInvoker(ShowMeetingDetailRequest showMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingDetailRequest);
            return new SyncInvoker<ShowMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 查询会议纪要详情
        ///
        /// 用户查询单个会议纪要详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMeetingFileResponse ShowMeetingFile(ShowMeetingFileRequest showMeetingFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_code", showMeetingFileRequest.FileCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/{file_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMeetingFileResponse>(response);
        }

        public SyncInvoker<ShowMeetingFileResponse> ShowMeetingFileInvoker(ShowMeetingFileRequest showMeetingFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_code", showMeetingFileRequest.FileCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/{file_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileRequest);
            return new SyncInvoker<ShowMeetingFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeetingFileResponse>);
        }
        
        /// <summary>
        /// 打开会议纪要文件列表
        ///
        /// 用户使用手机扫码后，手机端请求服务端,让服务端通知指定IdeaHub打开指定用户的会议纪要文件列表。二维码内容 ：cloudlink://cloudlink.huawei.com/h5page?action&#x3D;OPEN_MEETING_FILE_LIST&amp;key1&#x3D;value1&amp;key2&#x3D;value2 。key/value的个数可能变化，终端解析后，在发起后续请求时，将所有key/value存为map，作为入参即可。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMeetingFileListResponse ShowMeetingFileList(ShowMeetingFileListRequest showMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/open-meeting-file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ShowMeetingFileListResponse>(response);
        }

        public SyncInvoker<ShowMeetingFileListResponse> ShowMeetingFileListInvoker(ShowMeetingFileListRequest showMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/open-meeting-file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileListRequest);
            return new SyncInvoker<ShowMeetingFileListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ShowMeetingFileListResponse>);
        }
        
        /// <summary>
        /// 查询会管状态
        ///
        /// 终端通过会控查询会管状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMgmtSiteStatusResponse ShowMgmtSiteStatus(ShowMgmtSiteStatusRequest showMgmtSiteStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/confmaintain/queryMgmtSiteStatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMgmtSiteStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMgmtSiteStatusResponse>(response);
        }

        public SyncInvoker<ShowMgmtSiteStatusResponse> ShowMgmtSiteStatusInvoker(ShowMgmtSiteStatusRequest showMgmtSiteStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/confmaintain/queryMgmtSiteStatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMgmtSiteStatusRequest);
            return new SyncInvoker<ShowMgmtSiteStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMgmtSiteStatusResponse>);
        }
        
        /// <summary>
        /// 用户查询自己的信息
        ///
        /// 企业用户通过该接口查询自己的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMyInfoResponse ShowMyInfo(ShowMyInfoRequest showMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMyInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMyInfoResponse>(response);
        }

        public SyncInvoker<ShowMyInfoResponse> ShowMyInfoInvoker(ShowMyInfoRequest showMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMyInfoRequest);
            return new SyncInvoker<ShowMyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMyInfoResponse>);
        }
        
        /// <summary>
        /// 查询在线会议详情
        ///
        /// 该接口用于查询正在召开的会议详情。管理员可以查询本企业内所有的在线会议详情，普通用户仅能查询自己帐号创建或者需要参加的在线会议详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOnlineMeetingDetailResponse ShowOnlineMeetingDetail(ShowOnlineMeetingDetailRequest showOnlineMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOnlineMeetingDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOnlineMeetingDetailResponse>(response);
        }

        public SyncInvoker<ShowOnlineMeetingDetailResponse> ShowOnlineMeetingDetailInvoker(ShowOnlineMeetingDetailRequest showOnlineMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOnlineMeetingDetailRequest);
            return new SyncInvoker<ShowOnlineMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOnlineMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业资源使用信息
        ///
        /// 企业管理员查询所属企业的资源使用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrgResResponse ShowOrgRes(ShowOrgResRequest showOrgResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/orgRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrgResRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrgResResponse>(response);
        }

        public SyncInvoker<ShowOrgResResponse> ShowOrgResInvoker(ShowOrgResRequest showOrgResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/orgRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrgResRequest);
            return new SyncInvoker<ShowOrgResResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrgResResponse>);
        }
        
        /// <summary>
        /// 根据ID查询节目详情
        ///
        /// 根据ID获取节目详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProgramResponse ShowProgram(ShowProgramRequest showProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showProgramRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgramRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProgramResponse>(response);
        }

        public SyncInvoker<ShowProgramResponse> ShowProgramInvoker(ShowProgramRequest showProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showProgramRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgramRequest);
            return new SyncInvoker<ShowProgramResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgramResponse>);
        }
        
        /// <summary>
        /// 根据ID查询信息窗发布详情
        ///
        /// 根据ID获取发布详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicationResponse ShowPublication(ShowPublicationRequest showPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showPublicationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicationResponse>(response);
        }

        public SyncInvoker<ShowPublicationResponse> ShowPublicationInvoker(ShowPublicationRequest showPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showPublicationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicationRequest);
            return new SyncInvoker<ShowPublicationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicationResponse>);
        }
        
        /// <summary>
        /// 查询会议实时信息
        ///
        /// 该接口用于查询正在召开的会议实时信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRealTimeInfoOfMeetingResponse ShowRealTimeInfoOfMeeting(ShowRealTimeInfoOfMeetingRequest showRealTimeInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/realTimeInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealTimeInfoOfMeetingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRealTimeInfoOfMeetingResponse>(response);
        }

        public SyncInvoker<ShowRealTimeInfoOfMeetingResponse> ShowRealTimeInfoOfMeetingInvoker(ShowRealTimeInfoOfMeetingRequest showRealTimeInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/realTimeInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealTimeInfoOfMeetingRequest);
            return new SyncInvoker<ShowRealTimeInfoOfMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRealTimeInfoOfMeetingResponse>);
        }
        
        /// <summary>
        /// 查询单会议录制文件信息
        ///
        /// 查询单会议录制文件信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordInfoResponse ShowRecordInfo(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/rlm/record/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowRecordInfoResponse>(response);
        }

        public SyncInvoker<ShowRecordInfoResponse> ShowRecordInfoInvoker(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/rlm/record/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            return new SyncInvoker<ShowRecordInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRecordInfoResponse>);
        }
        
        /// <summary>
        /// 查询录制详情
        ///
        /// 改接口用于查询某个会议录制的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordingDetailResponse ShowRecordingDetail(ShowRecordingDetailRequest showRecordingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordingDetailResponse>(response);
        }

        public SyncInvoker<ShowRecordingDetailResponse> ShowRecordingDetailInvoker(ShowRecordingDetailRequest showRecordingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingDetailRequest);
            return new SyncInvoker<ShowRecordingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordingDetailResponse>);
        }
        
        /// <summary>
        /// 查询录制文件下载链接
        ///
        /// 该接口用户查询指定会议录制文件下载链接。
        /// &gt; * 仅企业管理员权限的帐号才能查询录制文件的下载链接
        /// &gt; * 这个接口需要在华为云会议后台开通白名单后才能调用。请联系华为销售人员，并提供华为云会议企业ID
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordingFileDownloadUrlsResponse ShowRecordingFileDownloadUrls(ShowRecordingFileDownloadUrlsRequest showRecordingFileDownloadUrlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/downloadurls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingFileDownloadUrlsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordingFileDownloadUrlsResponse>(response);
        }

        public SyncInvoker<ShowRecordingFileDownloadUrlsResponse> ShowRecordingFileDownloadUrlsInvoker(ShowRecordingFileDownloadUrlsRequest showRecordingFileDownloadUrlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/downloadurls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingFileDownloadUrlsRequest);
            return new SyncInvoker<ShowRecordingFileDownloadUrlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordingFileDownloadUrlsResponse>);
        }
        
        /// <summary>
        /// 查询会议所在区域信息
        ///
        /// 该接口用于查询会议所在区域的IP和域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRegionInfoOfMeetingResponse ShowRegionInfoOfMeeting(ShowRegionInfoOfMeetingRequest showRegionInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/region/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegionInfoOfMeetingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRegionInfoOfMeetingResponse>(response);
        }

        public SyncInvoker<ShowRegionInfoOfMeetingResponse> ShowRegionInfoOfMeetingInvoker(ShowRegionInfoOfMeetingRequest showRegionInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/region/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegionInfoOfMeetingRequest);
            return new SyncInvoker<ShowRegionInfoOfMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRegionInfoOfMeetingResponse>);
        }
        
        /// <summary>
        /// 查询网络研讨会高级设置
        ///
        /// 该接口用于查询指定网络研讨会的高级设置。管理员可查询企业内的网络研讨会高级设置，非管理员只可查询自己预定的网络研讨会的高级设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRoomSettingResponse ShowRoomSetting(ShowRoomSettingRequest showRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", showRoomSettingRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoomSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRoomSettingResponse>(response);
        }

        public SyncInvoker<ShowRoomSettingResponse> ShowRoomSettingInvoker(ShowRoomSettingRequest showRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", showRoomSettingRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoomSettingRequest);
            return new SyncInvoker<ShowRoomSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoomSettingResponse>);
        }
        
        /// <summary>
        /// SP管理员查询SP下资源使用信息
        ///
        /// SP管理员查询所属SP的共享资源使用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSpResResponse ShowSpRes(ShowSpResRequest showSpResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/spRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSpResResponse>(response);
        }

        public SyncInvoker<ShowSpResResponse> ShowSpResInvoker(ShowSpResRequest showSpResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/spRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResRequest);
            return new SyncInvoker<ShowSpResResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpResResponse>);
        }
        
        /// <summary>
        /// SP管理员查询资源信息
        ///
        /// SP管理员查询SP的所有资源，包括已使用的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSpResourceResponse ShowSpResource(ShowSpResourceRequest showSpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSpResourceResponse>(response);
        }

        public SyncInvoker<ShowSpResourceResponse> ShowSpResourceInvoker(ShowSpResourceRequest showSpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResourceRequest);
            return new SyncInvoker<ShowSpResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpResourceResponse>);
        }
        
        /// <summary>
        /// 查询SSO登录配置
        ///
        /// 该接口用于查询SSO登录的鉴权配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSsoConfigResponse ShowSsoConfig(ShowSsoConfigRequest showSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSsoConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSsoConfigResponse>(response);
        }

        public SyncInvoker<ShowSsoConfigResponse> ShowSsoConfigInvoker(ShowSsoConfigRequest showSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSsoConfigRequest);
            return new SyncInvoker<ShowSsoConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSsoConfigResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 企业管理员通过该接口查询企业用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserDetailResponse ShowUserDetail(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", showUserDetailRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserDetailResponse>(response);
        }

        public SyncInvoker<ShowUserDetailResponse> ShowUserDetailInvoker(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", showUserDetailRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            return new SyncInvoker<ShowUserDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserDetailResponse>);
        }
        
        /// <summary>
        /// 查询事件推送
        ///
        /// 该接口用于管理员查询企业事件订阅配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWebHookConfigResponse ShowWebHookConfig(ShowWebHookConfigRequest showWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebHookConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWebHookConfigResponse>(response);
        }

        public SyncInvoker<ShowWebHookConfigResponse> ShowWebHookConfigInvoker(ShowWebHookConfigRequest showWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebHookConfigRequest);
            return new SyncInvoker<ShowWebHookConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWebHookConfigResponse>);
        }
        
        /// <summary>
        /// 查询网络研讨会详情
        ///
        /// 该接口用于查询指定网络研讨会的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWebinarResponse ShowWebinar(ShowWebinarRequest showWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", showWebinarRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebinarRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWebinarResponse>(response);
        }

        public SyncInvoker<ShowWebinarResponse> ShowWebinarInvoker(ShowWebinarRequest showWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", showWebinarRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebinarRequest);
            return new SyncInvoker<ShowWebinarResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWebinarResponse>);
        }
        
        /// <summary>
        /// 激活会议
        ///
        /// 该接口用于通过会议ID和会议密码激活会议。所有的会控接口都需要在会议激活后才能调用，可以通过该接口先激活会议。
        /// &gt; 来宾密码是否可以激活会议取决于会议创建时是否设置了“是否允许来宾启动会议”（allowGuestStartConf&#x3D;true）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartMeetingResponse StartMeeting(StartMeetingRequest startMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startMeetingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartMeetingResponse>(response);
        }

        public SyncInvoker<StartMeetingResponse> StartMeetingInvoker(StartMeetingRequest startMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startMeetingRequest);
            return new SyncInvoker<StartMeetingResponse>(this, "POST", request, JsonUtils.DeSerialize<StartMeetingResponse>);
        }
        
        /// <summary>
        /// 结束会议
        ///
        /// 该接口用于结束正在召开的会议。
        /// &gt; * 如果管理员在企业的会议设置中关闭“结束会议保留预约记录”开关，会议结束后会议列表中将删除该会议，与会者不能再次加入该会议。否则会议预约时间到之前，与会者可以再次加入该会议
        /// &gt; * “结束会议保留预约记录”默认是开的
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopMeetingResponse StopMeeting(StopMeetingRequest stopMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<StopMeetingResponse>(response);
        }

        public SyncInvoker<StopMeetingResponse> StopMeetingInvoker(StopMeetingRequest stopMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMeetingRequest);
            return new SyncInvoker<StopMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<StopMeetingResponse>);
        }
        
        /// <summary>
        /// 切换视频显示策略
        ///
        /// 该接口用于切换会中视频画面显示策略，包括广播多画面，广播单画面，声控多画面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchModeResponse SwitchMode(SwitchModeRequest switchModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchModeResponse>(response);
        }

        public SyncInvoker<SwitchModeResponse> SwitchModeInvoker(SwitchModeRequest switchModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchModeRequest);
            return new SyncInvoker<SwitchModeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchModeResponse>);
        }
        
        /// <summary>
        /// 修改企业应用
        ///
        /// 企业默认管理员修改企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppIdResponse UpdateAppId(UpdateAppIdRequest updateAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAppIdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppIdResponse>(response);
        }

        public SyncInvoker<UpdateAppIdResponse> UpdateAppIdInvoker(UpdateAppIdRequest updateAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAppIdRequest);
            return new SyncInvoker<UpdateAppIdResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppIdResponse>);
        }
        
        /// <summary>
        /// 修改手机或邮箱
        ///
        /// 企业用户通过该接口修改手机或邮箱，需要先获取验证码，验证多次失败会禁止修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateContactResponse UpdateContact(UpdateContactRequest updateContactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/contact", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateContactRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateContactResponse>(response);
        }

        public SyncInvoker<UpdateContactResponse> UpdateContactInvoker(UpdateContactRequest updateContactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/contact", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateContactRequest);
            return new SyncInvoker<UpdateContactResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateContactResponse>);
        }
        
        /// <summary>
        /// SP管理员修改企业
        ///
        /// 修改企业，若任一参数为null或者不携带则不修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCorpResponse UpdateCorp(UpdateCorpRequest updateCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateCorpResponse>(response);
        }

        public SyncInvoker<UpdateCorpResponse> UpdateCorpInvoker(UpdateCorpRequest updateCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCorpRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpRequest);
            return new SyncInvoker<UpdateCorpResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCorpResponse>);
        }
        
        /// <summary>
        /// 企业管理员修改企业注册信息
        ///
        /// 企业管理员通过该接口修改企业注册信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCorpBasicInfoResponse UpdateCorpBasicInfo(UpdateCorpBasicInfoRequest updateCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpBasicInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateCorpBasicInfoResponse>(response);
        }

        public SyncInvoker<UpdateCorpBasicInfoResponse> UpdateCorpBasicInfoInvoker(UpdateCorpBasicInfoRequest updateCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpBasicInfoRequest);
            return new SyncInvoker<UpdateCorpBasicInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCorpBasicInfoResponse>);
        }
        
        /// <summary>
        /// 修改部门
        ///
        /// 企业管理员通过该接口修改部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDepartmentResponse UpdateDepartment(UpdateDepartmentRequest updateDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", updateDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDepartmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDepartmentResponse>(response);
        }

        public SyncInvoker<UpdateDepartmentResponse> UpdateDepartmentInvoker(UpdateDepartmentRequest updateDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dept_code", updateDepartmentRequest.DeptCode.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDepartmentRequest);
            return new SyncInvoker<UpdateDepartmentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDepartmentResponse>);
        }
        
        /// <summary>
        /// 修改终端
        ///
        /// 企业管理员通过该接口修改专业会议终端。
        /// &gt; 如果需要修改Ideahub、SmartRooms、智慧屏TV请使用[[修改用户](https://support.huaweicloud.com/api-meeting/meeting_21_0068.html)](tag:hws)[[修改用户](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0068.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", updateDeviceRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDeviceResponse>(response);
        }

        public SyncInvoker<UpdateDeviceResponse> UpdateDeviceInvoker(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sn", updateDeviceRequest.Sn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            return new SyncInvoker<UpdateDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDeviceResponse>);
        }
        
        /// <summary>
        /// 更新信息窗素材
        ///
        /// 更新信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMaterialResponse UpdateMaterial(UpdateMaterialRequest updateMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateMaterialRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMaterialRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMaterialResponse>(response);
        }

        public SyncInvoker<UpdateMaterialResponse> UpdateMaterialInvoker(UpdateMaterialRequest updateMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateMaterialRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMaterialRequest);
            return new SyncInvoker<UpdateMaterialResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMaterialResponse>);
        }
        
        /// <summary>
        /// 编辑预约会议
        ///
        /// 该接口用于修改已预约的会议。会议开始后，不能被修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMeetingResponse UpdateMeeting(UpdateMeetingRequest updateMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateMeetingResponse = JsonUtils.DeSerializeNull<UpdateMeetingResponse>(response);
            updateMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return updateMeetingResponse;
        }

        public SyncInvoker<UpdateMeetingResponse> UpdateMeetingInvoker(UpdateMeetingRequest updateMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMeetingRequest);
            return new SyncInvoker<UpdateMeetingResponse>(this, "PUT", request, response =>
            {
                var updateMeetingResponse = JsonUtils.DeSerializeNull<UpdateMeetingResponse>(response);
                updateMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
                return updateMeetingResponse;
            });
        }
        
        /// <summary>
        /// 修改用会议室及个人会议ID信息
        ///
        /// 企业用户登录后可以修改分配给用户的云会议室及个人会议ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMemberVmrResponse UpdateMemberVmr(UpdateMemberVmrRequest updateMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateMemberVmrRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberVmrRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMemberVmrResponse>(response);
        }

        public SyncInvoker<UpdateMemberVmrResponse> UpdateMemberVmrInvoker(UpdateMemberVmrRequest updateMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateMemberVmrRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberVmrRequest);
            return new SyncInvoker<UpdateMemberVmrResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMemberVmrResponse>);
        }
        
        /// <summary>
        /// 用户修改自己的信息
        ///
        /// 企业用户通过该接口修改自己的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMyInfoResponse UpdateMyInfo(UpdateMyInfoRequest updateMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMyInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMyInfoResponse>(response);
        }

        public SyncInvoker<UpdateMyInfoResponse> UpdateMyInfoInvoker(UpdateMyInfoRequest updateMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMyInfoRequest);
            return new SyncInvoker<UpdateMyInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMyInfoResponse>);
        }
        
        /// <summary>
        /// 更新信息窗节目
        ///
        /// 更新信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProgramResponse UpdateProgram(UpdateProgramRequest updateProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateProgramRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProgramRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProgramResponse>(response);
        }

        public SyncInvoker<UpdateProgramResponse> UpdateProgramInvoker(UpdateProgramRequest updateProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateProgramRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProgramRequest);
            return new SyncInvoker<UpdateProgramResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProgramResponse>);
        }
        
        /// <summary>
        /// 修改信息窗发布
        ///
        /// 修改信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicationResponse UpdatePublication(UpdatePublicationRequest updatePublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updatePublicationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePublicationResponse>(response);
        }

        public SyncInvoker<UpdatePublicationResponse> UpdatePublicationInvoker(UpdatePublicationRequest updatePublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updatePublicationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicationRequest);
            return new SyncInvoker<UpdatePublicationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePublicationResponse>);
        }
        
        /// <summary>
        /// 修改密码
        ///
        /// 企业成员通过该接口提供用户修改密码功能，服务器收到请求，修改用户密码并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePwdResponse UpdatePwd(UpdatePwdRequest updatePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePwdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePwdResponse>(response);
        }

        public SyncInvoker<UpdatePwdResponse> UpdatePwdInvoker(UpdatePwdRequest updatePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePwdRequest);
            return new SyncInvoker<UpdatePwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePwdResponse>);
        }
        
        /// <summary>
        /// 编辑周期性会议
        ///
        /// 该接口用于修改已预约的周期性会议。会议开始后，不能被修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecurringMeetingResponse UpdateRecurringMeeting(UpdateRecurringMeetingRequest updateRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateRecurringMeetingResponse = JsonUtils.DeSerializeNull<UpdateRecurringMeetingResponse>(response);
            updateRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return updateRecurringMeetingResponse;
        }

        public SyncInvoker<UpdateRecurringMeetingResponse> UpdateRecurringMeetingInvoker(UpdateRecurringMeetingRequest updateRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringMeetingRequest);
            return new SyncInvoker<UpdateRecurringMeetingResponse>(this, "PUT", request, response =>
            {
                var updateRecurringMeetingResponse = JsonUtils.DeSerializeNull<UpdateRecurringMeetingResponse>(response);
                updateRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
                return updateRecurringMeetingResponse;
            });
        }
        
        /// <summary>
        /// 编辑周期性会议的子会议
        ///
        /// 该接口用于修改已预约的周期性会议的子会议。会议开始后，不能被修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecurringSubMeetingResponse UpdateRecurringSubMeeting(UpdateRecurringSubMeetingRequest updateRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringSubMeetingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRecurringSubMeetingResponse>(response);
        }

        public SyncInvoker<UpdateRecurringSubMeetingResponse> UpdateRecurringSubMeetingInvoker(UpdateRecurringSubMeetingRequest updateRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringSubMeetingRequest);
            return new SyncInvoker<UpdateRecurringSubMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRecurringSubMeetingResponse>);
        }
        
        /// <summary>
        /// SP管理员根据修改企业资源
        ///
        /// 企业修改资源的过期时间、停用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceResponse UpdateResource(UpdateResourceRequest updateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", updateResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceResponse>(response);
        }

        public SyncInvoker<UpdateResourceResponse> UpdateResourceInvoker(UpdateResourceRequest updateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("corp_id", updateResourceRequest.CorpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceRequest);
            return new SyncInvoker<UpdateResourceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceResponse>);
        }
        
        /// <summary>
        /// 修改网络研讨会高级设置
        ///
        /// 该接口用于设置指定网络研讨会的高级设置。管理员可设置企业内的网络研讨会高级设置，非管理员只可设置自己预定的网络研讨会的高级设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRoomSettingResponse UpdateRoomSetting(UpdateRoomSettingRequest updateRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", updateRoomSettingRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoomSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateRoomSettingResponse>(response);
        }

        public SyncInvoker<UpdateRoomSettingResponse> UpdateRoomSettingInvoker(UpdateRoomSettingRequest updateRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("conference_id", updateRoomSettingRequest.ConferenceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoomSettingRequest);
            return new SyncInvoker<UpdateRoomSettingResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateRoomSettingResponse>);
        }
        
        /// <summary>
        /// 会中修改配置
        ///
        /// 该接口用于修改会议配置，包括会议共享是否锁定，允许呼入范围。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStartedConfConfigResponse UpdateStartedConfConfig(UpdateStartedConfConfigRequest updateStartedConfConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/updateStartedConfConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartedConfConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStartedConfConfigResponse>(response);
        }

        public SyncInvoker<UpdateStartedConfConfigResponse> UpdateStartedConfConfigInvoker(UpdateStartedConfConfigRequest updateStartedConfConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/updateStartedConfConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartedConfConfigRequest);
            return new SyncInvoker<UpdateStartedConfConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStartedConfConfigResponse>);
        }
        
        /// <summary>
        /// 刷新Token
        ///
        /// 该接口提供刷新Token功能，根据传入的Token，刷新Token失效时间并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTokenResponse UpdateToken(UpdateTokenRequest updateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTokenRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTokenResponse>(response);
        }

        public SyncInvoker<UpdateTokenResponse> UpdateTokenInvoker(UpdateTokenRequest updateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTokenRequest);
            return new SyncInvoker<UpdateTokenResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTokenResponse>);
        }
        
        /// <summary>
        /// 修改用户
        ///
        /// 企业管理员通过该接口修改企业用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", updateUserRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public SyncInvoker<UpdateUserResponse> UpdateUserInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account", updateUserRequest.Account.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new SyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 开启事件推送
        ///
        /// 该接口用于管理员变更订阅配置使用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWebHookConfigStatusResponse UpdateWebHookConfigStatus(UpdateWebHookConfigStatusRequest updateWebHookConfigStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebHookConfigStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWebHookConfigStatusResponse>(response);
        }

        public SyncInvoker<UpdateWebHookConfigStatusResponse> UpdateWebHookConfigStatusInvoker(UpdateWebHookConfigStatusRequest updateWebHookConfigStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebHookConfigStatusRequest);
            return new SyncInvoker<UpdateWebHookConfigStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWebHookConfigStatusResponse>);
        }
        
        /// <summary>
        /// 编辑网络研讨会
        ///
        /// 该接口用于修改已创建的网络研讨会。网络研讨会开始后不能修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWebinarResponse UpdateWebinar(UpdateWebinarRequest updateWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebinarRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWebinarResponse>(response);
        }

        public SyncInvoker<UpdateWebinarResponse> UpdateWebinarInvoker(UpdateWebinarRequest updateWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebinarRequest);
            return new SyncInvoker<UpdateWebinarResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWebinarResponse>);
        }
        
        /// <summary>
        /// 上传图片
        ///
        /// 该接口用户上传网络研讨会高级设置用的图片。图片可用于网络研讨会的封面和Logo。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadFileResponse UploadFile(UploadFileRequest uploadFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/res/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadFileRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UploadFileResponse>(response);
        }

        public SyncInvoker<UploadFileResponse> UploadFileInvoker(UploadFileRequest uploadFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/res/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadFileRequest);
            return new SyncInvoker<UploadFileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UploadFileResponse>);
        }
        
        /// <summary>
        /// 查询QoS历史会议列表
        ///
        /// 该接口用于查询企业内历史会议的QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。可以查询最近3个月内的数据。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchQosHistoryMeetingsResponse SearchQosHistoryMeetings(SearchQosHistoryMeetingsRequest searchQosHistoryMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosHistoryMeetingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQosHistoryMeetingsResponse>(response);
        }

        public SyncInvoker<SearchQosHistoryMeetingsResponse> SearchQosHistoryMeetingsInvoker(SearchQosHistoryMeetingsRequest searchQosHistoryMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosHistoryMeetingsRequest);
            return new SyncInvoker<SearchQosHistoryMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosHistoryMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询QoS在线会议列表
        ///
        /// 该接口用于查询企业内正在召开会议的QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchQosOnlineMeetingsResponse SearchQosOnlineMeetings(SearchQosOnlineMeetingsRequest searchQosOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosOnlineMeetingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQosOnlineMeetingsResponse>(response);
        }

        public SyncInvoker<SearchQosOnlineMeetingsResponse> SearchQosOnlineMeetingsInvoker(SearchQosOnlineMeetingsRequest searchQosOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosOnlineMeetingsRequest);
            return new SyncInvoker<SearchQosOnlineMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosOnlineMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询与会者的QoS数据
        ///
        /// 该接口用于查询企业内在线会议或历史会议的与会者QoS数据。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchQosParticipantDetailResponse SearchQosParticipantDetail(SearchQosParticipantDetailRequest searchQosParticipantDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participant/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQosParticipantDetailResponse>(response);
        }

        public SyncInvoker<SearchQosParticipantDetailResponse> SearchQosParticipantDetailInvoker(SearchQosParticipantDetailRequest searchQosParticipantDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participant/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantDetailRequest);
            return new SyncInvoker<SearchQosParticipantDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosParticipantDetailResponse>);
        }
        
        /// <summary>
        /// 查询QoS会议与会者列表
        ///
        /// 该接口用于查询企业内在线会议或历史会议的与会者QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchQosParticipantsResponse SearchQosParticipants(SearchQosParticipantsRequest searchQosParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQosParticipantsResponse>(response);
        }

        public SyncInvoker<SearchQosParticipantsResponse> SearchQosParticipantsInvoker(SearchQosParticipantsRequest searchQosParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantsRequest);
            return new SyncInvoker<SearchQosParticipantsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosParticipantsResponse>);
        }
        
        /// <summary>
        /// 设置QoS告警阈值
        ///
        /// 该接口用于设置QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限设置。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetQosThresholdResponse SetQosThreshold(SetQosThresholdRequest setQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=utf-8", setQosThresholdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetQosThresholdResponse>(response);
        }

        public SyncInvoker<SetQosThresholdResponse> SetQosThresholdInvoker(SetQosThresholdRequest setQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=utf-8", setQosThresholdRequest);
            return new SyncInvoker<SetQosThresholdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetQosThresholdResponse>);
        }
        
        /// <summary>
        /// 查询QoS告警阈值
        ///
        /// 该接口用于查询QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 该接口用于查询QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQosThresholdResponse ShowQosThreshold(ShowQosThresholdRequest showQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQosThresholdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQosThresholdResponse>(response);
        }

        public SyncInvoker<ShowQosThresholdResponse> ShowQosThresholdInvoker(ShowQosThresholdRequest showQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQosThresholdRequest);
            return new SyncInvoker<ShowQosThresholdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQosThresholdResponse>);
        }
        
        /// <summary>
        /// 查询企业级会议总体统计数据
        ///
        /// 该接口用于查询企业内：
        /// * 单日内按小时统计的会议数据。
        /// * 指定日期范围内按日/按月统计的会议数据。
        /// &gt; 仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchStatisticConferenceInfoResponse SearchStatisticConferenceInfo(SearchStatisticConferenceInfoRequest searchStatisticConferenceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticConferenceInfoResponse>(response);
        }

        public SyncInvoker<SearchStatisticConferenceInfoResponse> SearchStatisticConferenceInfoInvoker(SearchStatisticConferenceInfoRequest searchStatisticConferenceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceInfoRequest);
            return new SyncInvoker<SearchStatisticConferenceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticConferenceInfoResponse>);
        }
        
        /// <summary>
        /// 查询企业级会议与会统计数据
        ///
        /// 该接口用于查询企业内与会者数据统计：
        /// * 查询与会用户统计数据，按日/按月统计。
        /// * 查询与会硬件终端统计数据，按日/按月统计。
        /// * 查询与会设备统计数据，按日/按月统计。
        /// &gt; 仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchStatisticConferenceParticipantResponse SearchStatisticConferenceParticipant(SearchStatisticConferenceParticipantRequest searchStatisticConferenceParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/participant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceParticipantRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticConferenceParticipantResponse>(response);
        }

        public SyncInvoker<SearchStatisticConferenceParticipantResponse> SearchStatisticConferenceParticipantInvoker(SearchStatisticConferenceParticipantRequest searchStatisticConferenceParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/participant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceParticipantRequest);
            return new SyncInvoker<SearchStatisticConferenceParticipantResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticConferenceParticipantResponse>);
        }
        
        /// <summary>
        /// 查询企业级会议已购资源使用统计数据
        ///
        /// 该接口用于查询企业内已购资源使用状况数据统计：
        /// * 查询已购资源使用状况，按日/按月统计。
        /// &gt; 仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchStatisticResourceInfoResponse SearchStatisticResourceInfo(SearchStatisticResourceInfoRequest searchStatisticResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/resource/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticResourceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticResourceInfoResponse>(response);
        }

        public SyncInvoker<SearchStatisticResourceInfoResponse> SearchStatisticResourceInfoInvoker(SearchStatisticResourceInfoRequest searchStatisticResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/resource/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticResourceInfoRequest);
            return new SyncInvoker<SearchStatisticResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticResourceInfoResponse>);
        }
        
        /// <summary>
        /// 查询企业级会议的用户统计数据
        ///
        /// 该接口用于查询企业内用户数据统计：
        /// * 查询会议用户登录数据，按日/按月统计。
        /// * 查询会议用户激活数据，按日/按月统计。
        /// * 查询会议用户登录设备数据，按日/按月统计。
        /// &gt; 仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchStatisticUserInfoResponse SearchStatisticUserInfo(SearchStatisticUserInfoRequest searchStatisticUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticUserInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticUserInfoResponse>(response);
        }

        public SyncInvoker<SearchStatisticUserInfoResponse> SearchStatisticUserInfoInvoker(SearchStatisticUserInfoRequest searchStatisticUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticUserInfoRequest);
            return new SyncInvoker<SearchStatisticUserInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticUserInfoResponse>);
        }
        
    }
}