using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Meeting.V1.Model;

namespace HuaweiCloud.SDK.Meeting.V1
{
    public partial class MeetingAsyncClient : Client
    {
        public static ClientBuilder<MeetingAsyncClient> NewBuilder()
        {
            return new ClientBuilder<MeetingAsyncClient>("MeetingCredentials");
        }

        
        /// <summary>
        /// 添加企业应用
        ///
        /// 企业默认管理员添加应用，添加应用后，记录返回信息，后续可通过[[执行App ID鉴权](https://support.huaweicloud.com/api-meeting/meeting_21_0311.html)](tag:hws) [[执行App ID鉴权](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0311.html)](tag:hk)获取accessToken
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAppIdResponse> AddAppIdAsync(AddAppIdRequest addAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", addAppIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAppIdResponse>(response);
        }

        public AsyncInvoker<AddAppIdResponse> AddAppIdAsyncInvoker(AddAppIdRequest addAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", addAppIdRequest);
            return new AsyncInvoker<AddAppIdResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAppIdResponse>);
        }
        
        /// <summary>
        /// SP管理员创建企业
        ///
        /// 创建企业，默认管理员及分配资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddCorpResponse> AddCorpAsync(AddCorpRequest addCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddCorpResponse>(response);
        }

        public AsyncInvoker<AddCorpResponse> AddCorpAsyncInvoker(AddCorpRequest addCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpRequest);
            return new AsyncInvoker<AddCorpResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCorpResponse>);
        }
        
        /// <summary>
        /// 添加企业管理员
        ///
        /// 企业默认管理员添加企业普通管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddCorpAdminResponse> AddCorpAdminAsync(AddCorpAdminRequest addCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpAdminRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddCorpAdminResponse>(response);
        }

        public AsyncInvoker<AddCorpAdminResponse> AddCorpAdminAsyncInvoker(AddCorpAdminRequest addCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCorpAdminRequest);
            return new AsyncInvoker<AddCorpAdminResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddCorpAdminResponse>);
        }
        
        /// <summary>
        /// 添加部门
        ///
        /// 企业管理员通过该接口添加部门，最多支持10级部门，每级子部门最多支持100个，默认企业最大部门数量为10000个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDepartmentResponse> AddDepartmentAsync(AddDepartmentRequest addDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDepartmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDepartmentResponse>(response);
        }

        public AsyncInvoker<AddDepartmentResponse> AddDepartmentAsyncInvoker(AddDepartmentRequest addDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDepartmentRequest);
            return new AsyncInvoker<AddDepartmentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDepartmentResponse>);
        }
        
        /// <summary>
        /// 增加终端
        ///
        /// 企业管理员通过该接口添加专业会议终端。专业会议终端包括DP300/HUAWEI Bar系列/HUAWEI Board/TE系列。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
        }

        public AsyncInvoker<AddDeviceResponse> AddDeviceAsyncInvoker(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            return new AsyncInvoker<AddDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceResponse>);
        }
        
        /// <summary>
        /// 新增信息窗素材
        ///
        /// 新增信息窗素材（上传素材文件）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddMaterialResponse> AddMaterialAsync(AddMaterialRequest addMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addMaterialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddMaterialResponse>(response);
        }

        public AsyncInvoker<AddMaterialResponse> AddMaterialAsyncInvoker(AddMaterialRequest addMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addMaterialRequest);
            return new AsyncInvoker<AddMaterialResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddMaterialResponse>);
        }
        
        /// <summary>
        /// 新增信息窗节目
        ///
        /// 新增信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddProgramResponse> AddProgramAsync(AddProgramRequest addProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProgramRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddProgramResponse>(response);
        }

        public AsyncInvoker<AddProgramResponse> AddProgramAsyncInvoker(AddProgramRequest addProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProgramRequest);
            return new AsyncInvoker<AddProgramResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddProgramResponse>);
        }
        
        /// <summary>
        /// 新增信息窗发布
        ///
        /// 新增信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddPublicationResponse> AddPublicationAsync(AddPublicationRequest addPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPublicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddPublicationResponse>(response);
        }

        public AsyncInvoker<AddPublicationResponse> AddPublicationAsyncInvoker(AddPublicationRequest addPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPublicationRequest);
            return new AsyncInvoker<AddPublicationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddPublicationResponse>);
        }
        
        /// <summary>
        /// SP管理员分配企业资源
        ///
        /// 企业新增资源发放。该接口同时支持修改，带resourceId后会判断该资源是否存在，存在即修改（支持修改的参数见修改接口），否则按新增处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddResourceResponse> AddResourceAsync(AddResourceRequest addResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddResourceResponse>(response);
        }

        public AsyncInvoker<AddResourceResponse> AddResourceAsyncInvoker(AddResourceRequest addResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourceRequest);
            return new AsyncInvoker<AddResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddResourceResponse>);
        }
        
        /// <summary>
        /// 保存会议纪要到个人云空间
        ///
        /// 用户使用手机扫码后,手机端请求服务端将当前会议纪要文件保存到个人云空间。二维码内容 ：cloudlink://cloudlink.huawei.com/h5page?action&#x3D;SAVE_MEETING_FILE&amp;key1&#x3D;value1&amp;key2&#x3D;value2 。key/value的个数可能变化，终端解析后，在发起后续请求时，将所有key/value存为map，作为入参即可。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddToPersonalSpaceResponse> AddToPersonalSpaceAsync(AddToPersonalSpaceRequest addToPersonalSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/save-to-personal-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addToPersonalSpaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddToPersonalSpaceResponse>(response);
        }

        public AsyncInvoker<AddToPersonalSpaceResponse> AddToPersonalSpaceAsyncInvoker(AddToPersonalSpaceRequest addToPersonalSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/save-to-personal-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addToPersonalSpaceRequest);
            return new AsyncInvoker<AddToPersonalSpaceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddToPersonalSpaceResponse>);
        }
        
        /// <summary>
        /// 添加用户
        ///
        /// 企业管理员通过该接口添加企业用户。
        /// &gt; 默认添加用户后，用户第一次登录华为云会议App或者Portal时需要修改密码。若需关闭第一次登录修改密码，请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddUserResponse> AddUserAsync(AddUserRequest addUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddUserResponse>(response);
        }

        public AsyncInvoker<AddUserResponse> AddUserAsyncInvoker(AddUserRequest addUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserRequest);
            return new AsyncInvoker<AddUserResponse>(this, "POST", request, JsonUtils.DeSerialize<AddUserResponse>);
        }
        
        /// <summary>
        /// 主持人允许观众入会
        ///
        /// 主持人通过接口控制是否允许观众入会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowAudienceJoinResponse> AllowAudienceJoinAsync(AllowAudienceJoinRequest allowAudienceJoinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowAudience", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowAudienceJoinRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowAudienceJoinResponse>(response);
        }

        public AsyncInvoker<AllowAudienceJoinResponse> AllowAudienceJoinAsyncInvoker(AllowAudienceJoinRequest allowAudienceJoinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowAudience", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowAudienceJoinRequest);
            return new AsyncInvoker<AllowAudienceJoinResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowAudienceJoinResponse>);
        }
        
        /// <summary>
        /// 允许客户端录制
        ///
        /// 该接口用于设置允许/禁止与会者客户端本地录制（非云端录制）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowClientRecordResponse> AllowClientRecordAsync(AllowClientRecordRequest allowClientRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowClientRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowClientRecordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowClientRecordResponse>(response);
        }

        public AsyncInvoker<AllowClientRecordResponse> AllowClientRecordAsyncInvoker(AllowClientRecordRequest allowClientRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowClientRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowClientRecordRequest);
            return new AsyncInvoker<AllowClientRecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowClientRecordResponse>);
        }
        
        /// <summary>
        /// 与会者自己解除静音
        ///
        /// 该接口用于设置与会者是否可以自己解除静音。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowGuestUnmuteResponse> AllowGuestUnmuteAsync(AllowGuestUnmuteRequest allowGuestUnmuteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute/guestUnMute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowGuestUnmuteRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowGuestUnmuteResponse>(response);
        }

        public AsyncInvoker<AllowGuestUnmuteResponse> AllowGuestUnmuteAsyncInvoker(AllowGuestUnmuteRequest allowGuestUnmuteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute/guestUnMute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowGuestUnmuteRequest);
            return new AsyncInvoker<AllowGuestUnmuteResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowGuestUnmuteResponse>);
        }
        
        /// <summary>
        /// 准入等候者
        ///
        /// 该接口用于允许等候室中的成员进入会议。可以允许全部成员进入会议，或者允许指定成员进入会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowWaitingParticipantResponse> AllowWaitingParticipantAsync(AllowWaitingParticipantRequest allowWaitingParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowWaitingParticipant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowWaitingParticipantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AllowWaitingParticipantResponse>(response);
        }

        public AsyncInvoker<AllowWaitingParticipantResponse> AllowWaitingParticipantAsyncInvoker(AllowWaitingParticipantRequest allowWaitingParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/allowWaitingParticipant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowWaitingParticipantRequest);
            return new AsyncInvoker<AllowWaitingParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AllowWaitingParticipantResponse>);
        }
        
        /// <summary>
        /// 分配云会议室
        ///
        /// 企业管理员通过该接口将云会议室分配给用户、专业会议终端（TE10、TE20、HUAWEI Board、HUAWEI Bar 500及HUAWEI Box系列）、智慧屏TV、电子白板（SmartRooms）、IdeaHub。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateVmrResponse> AssociateVmrAsync(AssociateVmrRequest associateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateVmrRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/assign-to-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateVmrRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateVmrResponse>(response);
        }

        public AsyncInvoker<AssociateVmrResponse> AssociateVmrAsyncInvoker(AssociateVmrRequest associateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateVmrRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/assign-to-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateVmrRequest);
            return new AsyncInvoker<AssociateVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateVmrResponse>);
        }
        
        /// <summary>
        /// 批量删除企业管理员
        ///
        /// 通过该接口批量删除企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteCorpAdminsResponse> BatchDeleteCorpAdminsAsync(BatchDeleteCorpAdminsRequest batchDeleteCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCorpAdminsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteCorpAdminsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteCorpAdminsResponse> BatchDeleteCorpAdminsAsyncInvoker(BatchDeleteCorpAdminsRequest batchDeleteCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCorpAdminsRequest);
            return new AsyncInvoker<BatchDeleteCorpAdminsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteCorpAdminsResponse>);
        }
        
        /// <summary>
        /// 批量删除终端
        ///
        /// 企业管理员通过该接口批量删除专业会议终端，返回删除失败的列表。
        /// &gt; 如果需要删除Ideahub、SmartRooms、智慧屏TV请使用[[批量删除用户](https://support.huaweicloud.com/api-meeting/meeting_21_0070.html)](tag:hws)[[批量删除用户](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0070.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDevicesResponse> BatchDeleteDevicesAsync(BatchDeleteDevicesRequest batchDeleteDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDevicesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDevicesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDevicesResponse> BatchDeleteDevicesAsyncInvoker(BatchDeleteDevicesRequest batchDeleteDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDevicesRequest);
            return new AsyncInvoker<BatchDeleteDevicesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteDevicesResponse>);
        }
        
        /// <summary>
        /// 删除信息窗素材
        ///
        /// 删除信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteMaterialsResponse> BatchDeleteMaterialsAsync(BatchDeleteMaterialsRequest batchDeleteMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMaterialsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteMaterialsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteMaterialsResponse> BatchDeleteMaterialsAsyncInvoker(BatchDeleteMaterialsRequest batchDeleteMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMaterialsRequest);
            return new AsyncInvoker<BatchDeleteMaterialsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteMaterialsResponse>);
        }
        
        /// <summary>
        /// 删除信息窗节目
        ///
        /// 删除信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteProgramsResponse> BatchDeleteProgramsAsync(BatchDeleteProgramsRequest batchDeleteProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProgramsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteProgramsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteProgramsResponse> BatchDeleteProgramsAsyncInvoker(BatchDeleteProgramsRequest batchDeleteProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProgramsRequest);
            return new AsyncInvoker<BatchDeleteProgramsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteProgramsResponse>);
        }
        
        /// <summary>
        /// 删除信息窗发布
        ///
        /// 删除信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePublicationsResponse> BatchDeletePublicationsAsync(BatchDeletePublicationsRequest batchDeletePublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePublicationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicationsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePublicationsResponse> BatchDeletePublicationsAsyncInvoker(BatchDeletePublicationsRequest batchDeletePublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePublicationsRequest);
            return new AsyncInvoker<BatchDeletePublicationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePublicationsResponse>);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 企业管理员通过该接口批量删除企业用户。删除多个用户时，全部删除成功或者全部删除失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteUsersResponse> BatchDeleteUsersAsync(BatchDeleteUsersRequest batchDeleteUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUsersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUsersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteUsersResponse> BatchDeleteUsersAsyncInvoker(BatchDeleteUsersRequest batchDeleteUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUsersRequest);
            return new AsyncInvoker<BatchDeleteUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUsersResponse>);
        }
        
        /// <summary>
        /// 批量举手
        ///
        /// 该接口用于批量设置来宾的举手/放下举手状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchHandResponse> BatchHandAsync(BatchHandRequest batchHandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/batch/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchHandRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchHandResponse>(response);
        }

        public AsyncInvoker<BatchHandResponse> BatchHandAsyncInvoker(BatchHandRequest batchHandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/batch/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchHandRequest);
            return new AsyncInvoker<BatchHandResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchHandResponse>);
        }
        
        /// <summary>
        /// 批量移入等候室
        ///
        /// 主持人通过该接口批量移动用户到等候室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchMoveToWaitingRoomResponse> BatchMoveToWaitingRoomAsync(BatchMoveToWaitingRoomRequest batchMoveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/batchMoveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMoveToWaitingRoomRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchMoveToWaitingRoomResponse>(response);
        }

        public AsyncInvoker<BatchMoveToWaitingRoomResponse> BatchMoveToWaitingRoomAsyncInvoker(BatchMoveToWaitingRoomRequest batchMoveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/batchMoveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMoveToWaitingRoomRequest);
            return new AsyncInvoker<BatchMoveToWaitingRoomResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchMoveToWaitingRoomResponse>);
        }
        
        /// <summary>
        /// 分页查询企业应用
        ///
        /// 企业默认管理员分页查询企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSearchAppIdResponse> BatchSearchAppIdAsync(BatchSearchAppIdRequest batchSearchAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSearchAppIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<BatchSearchAppIdResponse>(response);
        }

        public AsyncInvoker<BatchSearchAppIdResponse> BatchSearchAppIdAsyncInvoker(BatchSearchAppIdRequest batchSearchAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSearchAppIdRequest);
            return new AsyncInvoker<BatchSearchAppIdResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchSearchAppIdResponse>);
        }
        
        /// <summary>
        /// 批量查询用户详情
        ///
        /// 批量查询用户详情，支持指定第三方账号查询详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowUserDetailsResponse> BatchShowUserDetailsAsync(BatchShowUserDetailsRequest batchShowUserDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowUserDetailsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var batchShowUserDetailsResponse = JsonUtils.DeSerializeNull<BatchShowUserDetailsResponse>(response);
            batchShowUserDetailsResponse.Body = JsonUtils.DeSerializeList<UserDTO>(response);
            return batchShowUserDetailsResponse;
        }

        public AsyncInvoker<BatchShowUserDetailsResponse> BatchShowUserDetailsAsyncInvoker(BatchShowUserDetailsRequest batchShowUserDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowUserDetailsRequest);
            return new AsyncInvoker<BatchShowUserDetailsResponse>(this, "POST", request, response =>
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
        public async Task<BatchUpdateDevicesStatusResponse> BatchUpdateDevicesStatusAsync(BatchUpdateDevicesStatusRequest batchUpdateDevicesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateDevicesStatusRequest.Value, out var valueOfValue)) urlParam.Add("value", valueOfValue);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateDevicesStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateDevicesStatusResponse>(response);
        }

        public AsyncInvoker<BatchUpdateDevicesStatusResponse> BatchUpdateDevicesStatusAsyncInvoker(BatchUpdateDevicesStatusRequest batchUpdateDevicesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateDevicesStatusRequest.Value, out var valueOfValue)) urlParam.Add("value", valueOfValue);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateDevicesStatusRequest);
            return new AsyncInvoker<BatchUpdateDevicesStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateDevicesStatusResponse>);
        }
        
        /// <summary>
        /// 批量修改用户状态
        ///
        /// 企业管理员通过该接口批量修改用户状态，当用户帐号数资源或者电子白板（SmartRooms）资源到期后，若企业内对应资源的用户帐号超过数量后会被系统随机自动停用，此时可通过该接口修改用户的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateUserStatusResponse> BatchUpdateUserStatusAsync(BatchUpdateUserStatusRequest batchUpdateUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateUserStatusRequest.Value, out var valueOfValue)) urlParam.Add("value", valueOfValue);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateUserStatusResponse>(response);
        }

        public AsyncInvoker<BatchUpdateUserStatusResponse> BatchUpdateUserStatusAsyncInvoker(BatchUpdateUserStatusRequest batchUpdateUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateUserStatusRequest.Value, out var valueOfValue)) urlParam.Add("value", valueOfValue);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/status/{value}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserStatusRequest);
            return new AsyncInvoker<BatchUpdateUserStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateUserStatusResponse>);
        }
        
        /// <summary>
        /// 广播会场
        ///
        /// 该接口用于广播指定的与会者。同一时间，只允许一个与会者被广播。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BroadcastParticipantResponse> BroadcastParticipantAsync(BroadcastParticipantRequest broadcastParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/broadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastParticipantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BroadcastParticipantResponse>(response);
        }

        public AsyncInvoker<BroadcastParticipantResponse> BroadcastParticipantAsyncInvoker(BroadcastParticipantRequest broadcastParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/broadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastParticipantRequest);
            return new AsyncInvoker<BroadcastParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BroadcastParticipantResponse>);
        }
        
        /// <summary>
        /// 取消广播
        ///
        /// 该接口用于取消广播，包括：取消广播多画面，取消广播会场，取消点名会场。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelBroadcastResponse> CancelBroadcastAsync(CancelBroadcastRequest cancelBroadcastRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/cancelBroadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelBroadcastRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CancelBroadcastResponse>(response);
        }

        public AsyncInvoker<CancelBroadcastResponse> CancelBroadcastAsyncInvoker(CancelBroadcastRequest cancelBroadcastRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/cancelBroadcast", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelBroadcastRequest);
            return new AsyncInvoker<CancelBroadcastResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CancelBroadcastResponse>);
        }
        
        /// <summary>
        /// 取消预约会议
        ///
        /// 该接口用于取消预约的会议。企业管理员可以取消本企业下用户创建的会议，普通用户只能取消自己创建的会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelMeetingResponse> CancelMeetingAsync(CancelMeetingRequest cancelMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMeetingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelMeetingResponse>(response);
        }

        public AsyncInvoker<CancelMeetingResponse> CancelMeetingAsyncInvoker(CancelMeetingRequest cancelMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMeetingRequest);
            return new AsyncInvoker<CancelMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelMeetingResponse>);
        }
        
        /// <summary>
        /// 取消周期性会议
        ///
        /// 该接口用于取消周期性会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelRecurringMeetingResponse> CancelRecurringMeetingAsync(CancelRecurringMeetingRequest cancelRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringMeetingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRecurringMeetingResponse>(response);
        }

        public AsyncInvoker<CancelRecurringMeetingResponse> CancelRecurringMeetingAsyncInvoker(CancelRecurringMeetingRequest cancelRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringMeetingRequest);
            return new AsyncInvoker<CancelRecurringMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRecurringMeetingResponse>);
        }
        
        /// <summary>
        /// 取消周期性会议的子会议
        ///
        /// 该接口用于取消周期性会议的子会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelRecurringSubMeetingResponse> CancelRecurringSubMeetingAsync(CancelRecurringSubMeetingRequest cancelRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringSubMeetingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRecurringSubMeetingResponse>(response);
        }

        public AsyncInvoker<CancelRecurringSubMeetingResponse> CancelRecurringSubMeetingAsyncInvoker(CancelRecurringSubMeetingRequest cancelRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRecurringSubMeetingRequest);
            return new AsyncInvoker<CancelRecurringSubMeetingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRecurringSubMeetingResponse>);
        }
        
        /// <summary>
        /// 根据号码，查询是否在会议中
        ///
        /// 通过该接口查询号码，是否在会议中
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckCallNumberInConfResponse> CheckCallNumberInConfAsync(CheckCallNumberInConfRequest checkCallNumberInConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/online/check-callnumber-in-conf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCallNumberInConfRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckCallNumberInConfResponse>(response);
        }

        public AsyncInvoker<CheckCallNumberInConfResponse> CheckCallNumberInConfAsyncInvoker(CheckCallNumberInConfRequest checkCallNumberInConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/online/check-callnumber-in-conf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCallNumberInConfRequest);
            return new AsyncInvoker<CheckCallNumberInConfResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckCallNumberInConfResponse>);
        }
        
        /// <summary>
        /// 校验滑块验证码
        ///
        /// 该接口提供校验滑块验证码。服务器收到请求，返回校验结果。用户在前台界面通过滑块操作匹配图形，使得抠图和原图吻合。然后服务器进行校验滑块验证码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckSlideVerifyCodeResponse> CheckSlideVerifyCodeAsync(CheckSlideVerifyCodeRequest checkSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSlideVerifyCodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CheckSlideVerifyCodeResponse>(response);
        }

        public AsyncInvoker<CheckSlideVerifyCodeResponse> CheckSlideVerifyCodeAsyncInvoker(CheckSlideVerifyCodeRequest checkSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSlideVerifyCodeRequest);
            return new AsyncInvoker<CheckSlideVerifyCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckSlideVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 校验Token
        ///
        /// 该接口提供校验token合法性功能。服务器收到请求后，验证token合法性并返回结果。如果参数needGenNewToken为true时，生成新的token并返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckTokenResponse> CheckTokenAsync(CheckTokenRequest checkTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckTokenResponse>(response);
        }

        public AsyncInvoker<CheckTokenResponse> CheckTokenAsyncInvoker(CheckTokenRequest checkTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkTokenRequest);
            return new AsyncInvoker<CheckTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckTokenResponse>);
        }
        
        /// <summary>
        /// 校验手机和邮箱对应的验证码
        ///
        /// 企业用户通过该接口校验手机和邮箱对应的验证码，一分钟内记录尝试次数不得超过5次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckVeriCodeForUpdateUserInfoResponse> CheckVeriCodeForUpdateUserInfoAsync(CheckVeriCodeForUpdateUserInfoRequest checkVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVeriCodeForUpdateUserInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CheckVeriCodeForUpdateUserInfoResponse>(response);
        }

        public AsyncInvoker<CheckVeriCodeForUpdateUserInfoResponse> CheckVeriCodeForUpdateUserInfoAsyncInvoker(CheckVeriCodeForUpdateUserInfoRequest checkVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVeriCodeForUpdateUserInfoRequest);
            return new AsyncInvoker<CheckVeriCodeForUpdateUserInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckVeriCodeForUpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 校验验证码
        ///
        /// 该接口提供校验验证码，服务器收到请求，返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckVerifyCodeResponse> CheckVerifyCodeAsync(CheckVerifyCodeRequest checkVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVerifyCodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CheckVerifyCodeResponse>(response);
        }

        public AsyncInvoker<CheckVerifyCodeResponse> CheckVerifyCodeAsyncInvoker(CheckVerifyCodeRequest checkVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVerifyCodeRequest);
            return new AsyncInvoker<CheckVerifyCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 匿名用户会议鉴权
        ///
        /// 该接口用于匿名用户入会鉴权。请求根据会议ID和密码鉴权，返回鉴权随机数（可以根据该随机数获取匿名用户信息、会议信息等）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAnonymousAuthRandomResponse> CreateAnonymousAuthRandomAsync(CreateAnonymousAuthRandomRequest createAnonymousAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/anonymous/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnonymousAuthRandomRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CreateAnonymousAuthRandomResponse>(response);
        }

        public AsyncInvoker<CreateAnonymousAuthRandomResponse> CreateAnonymousAuthRandomAsyncInvoker(CreateAnonymousAuthRandomRequest createAnonymousAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/anonymous/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnonymousAuthRandomRequest);
            return new AsyncInvoker<CreateAnonymousAuthRandomResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateAnonymousAuthRandomResponse>);
        }
        
        /// <summary>
        /// 获取会议鉴权随机数
        ///
        /// 根据会议ID + 密码鉴权返回鉴权随机数，如果是小程序调用时，需要企业支持小程序功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuthRandomResponse> CreateAuthRandomAsync(CreateAuthRandomRequest createAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/auth/random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthRandomRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CreateAuthRandomResponse>(response);
        }

        public AsyncInvoker<CreateAuthRandomResponse> CreateAuthRandomAsyncInvoker(CreateAuthRandomRequest createAuthRandomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/mms/ncms/conferences/auth/random", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthRandomRequest);
            return new AsyncInvoker<CreateAuthRandomResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateAuthRandomResponse>);
        }
        
        /// <summary>
        /// 获取会控Token
        ///
        /// 该接口用于获取正在召开会议的会控Token（未开始的会议调用该接口返回失败）。Token有效期是半个小时。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfTokenResponse> CreateConfTokenAsync(CreateConfTokenRequest createConfTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfTokenRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CreateConfTokenResponse>(response);
        }

        public AsyncInvoker<CreateConfTokenResponse> CreateConfTokenAsyncInvoker(CreateConfTokenRequest createConfTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfTokenRequest);
            return new AsyncInvoker<CreateConfTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateConfTokenResponse>);
        }
        
        /// <summary>
        /// 创建会议
        ///
        /// 该接口用于创建立即会议和预约会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMeetingResponse> CreateMeetingAsync(CreateMeetingRequest createMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMeetingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createMeetingResponse = JsonUtils.DeSerializeNull<CreateMeetingResponse>(response);
            createMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return createMeetingResponse;
        }

        public AsyncInvoker<CreateMeetingResponse> CreateMeetingAsyncInvoker(CreateMeetingRequest createMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMeetingRequest);
            return new AsyncInvoker<CreateMeetingResponse>(this, "POST", request, response =>
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
        public async Task<CreatePortalRefNonceResponse> CreatePortalRefNonceAsync(CreatePortalRefNonceRequest createPortalRefNonceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/portal-ref-nonce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPortalRefNonceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePortalRefNonceResponse>(response);
        }

        public AsyncInvoker<CreatePortalRefNonceResponse> CreatePortalRefNonceAsyncInvoker(CreatePortalRefNonceRequest createPortalRefNonceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/portal-ref-nonce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPortalRefNonceRequest);
            return new AsyncInvoker<CreatePortalRefNonceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePortalRefNonceResponse>);
        }
        
        /// <summary>
        /// 创建周期性会议
        ///
        /// 该接口用于预约周期性会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecurringMeetingResponse> CreateRecurringMeetingAsync(CreateRecurringMeetingRequest createRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecurringMeetingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createRecurringMeetingResponse = JsonUtils.DeSerializeNull<CreateRecurringMeetingResponse>(response);
            createRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return createRecurringMeetingResponse;
        }

        public AsyncInvoker<CreateRecurringMeetingResponse> CreateRecurringMeetingAsyncInvoker(CreateRecurringMeetingRequest createRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecurringMeetingRequest);
            return new AsyncInvoker<CreateRecurringMeetingResponse>(this, "POST", request, response =>
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
        public async Task<CreateVisionActiveCodeResponse> CreateVisionActiveCodeAsync(CreateVisionActiveCodeRequest createVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVisionActiveCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVisionActiveCodeResponse>(response);
        }

        public AsyncInvoker<CreateVisionActiveCodeResponse> CreateVisionActiveCodeAsyncInvoker(CreateVisionActiveCodeRequest createVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVisionActiveCodeRequest);
            return new AsyncInvoker<CreateVisionActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 获取websocket建链Token
        ///
        /// 该接口用于获取会控WebSocket建链的临时Token。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWebSocketTokenResponse> CreateWebSocketTokenAsync(CreateWebSocketTokenRequest createWebSocketTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/wsToken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebSocketTokenRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CreateWebSocketTokenResponse>(response);
        }

        public AsyncInvoker<CreateWebSocketTokenResponse> CreateWebSocketTokenAsyncInvoker(CreateWebSocketTokenRequest createWebSocketTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/wsToken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebSocketTokenRequest);
            return new AsyncInvoker<CreateWebSocketTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<CreateWebSocketTokenResponse>);
        }
        
        /// <summary>
        /// 预约网络研讨会
        ///
        /// 该接口用于创建网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWebinarResponse> CreateWebinarAsync(CreateWebinarRequest createWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebinarRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWebinarResponse>(response);
        }

        public AsyncInvoker<CreateWebinarResponse> CreateWebinarAsyncInvoker(CreateWebinarRequest createWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWebinarRequest);
            return new AsyncInvoker<CreateWebinarResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWebinarResponse>);
        }
        
        /// <summary>
        /// 删除企业应用
        ///
        /// 企业管理员删除企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppIdResponse> DeleteAppIdAsync(DeleteAppIdRequest deleteAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIdRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppIdResponse>(response);
        }

        public AsyncInvoker<DeleteAppIdResponse> DeleteAppIdAsyncInvoker(DeleteAppIdRequest deleteAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIdRequest);
            return new AsyncInvoker<DeleteAppIdResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppIdResponse>);
        }
        
        /// <summary>
        /// 删除与会者
        ///
        /// 该接口用于删除与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAttendeesResponse> DeleteAttendeesAsync(DeleteAttendeesRequest deleteAttendeesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/attendees/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttendeesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAttendeesResponse>(response);
        }

        public AsyncInvoker<DeleteAttendeesResponse> DeleteAttendeesAsyncInvoker(DeleteAttendeesRequest deleteAttendeesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/attendees/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttendeesRequest);
            return new AsyncInvoker<DeleteAttendeesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAttendeesResponse>);
        }
        
        /// <summary>
        /// SP管理员删除企业
        ///
        /// 删除企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCorpResponse> DeleteCorpAsync(DeleteCorpRequest deleteCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCorpResponse>(response);
        }

        public AsyncInvoker<DeleteCorpResponse> DeleteCorpAsyncInvoker(DeleteCorpRequest deleteCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpRequest);
            return new AsyncInvoker<DeleteCorpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCorpResponse>);
        }
        
        /// <summary>
        /// 删除云会议室
        ///
        /// 企业管理员通过该接口删除企业的云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCorpVmrResponse> DeleteCorpVmrAsync(DeleteCorpVmrRequest deleteCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpVmrRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteCorpVmrResponse>(response);
        }

        public AsyncInvoker<DeleteCorpVmrResponse> DeleteCorpVmrAsyncInvoker(DeleteCorpVmrRequest deleteCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCorpVmrRequest);
            return new AsyncInvoker<DeleteCorpVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteCorpVmrResponse>);
        }
        
        /// <summary>
        /// 删除部门
        ///
        /// 企业管理员通过该接口删除部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDepartmentResponse> DeleteDepartmentAsync(DeleteDepartmentRequest deleteDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDepartmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDepartmentResponse>(response);
        }

        public AsyncInvoker<DeleteDepartmentResponse> DeleteDepartmentAsyncInvoker(DeleteDepartmentRequest deleteDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDepartmentRequest);
            return new AsyncInvoker<DeleteDepartmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDepartmentResponse>);
        }
        
        /// <summary>
        /// 删除多画面布局
        ///
        /// 该接口用于删除当前会议已保存的多画面布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLayoutResponse> DeleteLayoutAsync(DeleteLayoutRequest deleteLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLayoutRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLayoutResponse>(response);
        }

        public AsyncInvoker<DeleteLayoutResponse> DeleteLayoutAsyncInvoker(DeleteLayoutRequest deleteLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLayoutRequest);
            return new AsyncInvoker<DeleteLayoutResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLayoutResponse>);
        }
        
        /// <summary>
        /// 批量删除录制
        ///
        /// 该接口用于批量删除会议的录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordingsResponse> DeleteRecordingsAsync(DeleteRecordingsRequest deleteRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordingsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordingsResponse>(response);
        }

        public AsyncInvoker<DeleteRecordingsResponse> DeleteRecordingsAsyncInvoker(DeleteRecordingsRequest deleteRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordingsRequest);
            return new AsyncInvoker<DeleteRecordingsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordingsResponse>);
        }
        
        /// <summary>
        /// SP管理员根据删除企业资源
        ///
        /// 企业删除资源项，删除资源项后，企业资源总数会自动减少。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest deleteResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteResourceResponse>(response);
        }

        public AsyncInvoker<DeleteResourceResponse> DeleteResourceAsyncInvoker(DeleteResourceRequest deleteResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceRequest);
            return new AsyncInvoker<DeleteResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteResourceResponse>);
        }
        
        /// <summary>
        /// 注销登录
        ///
        /// 该接口提供注销功能。服务器收到请求后，删除该Token。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTokenResponse> DeleteTokenAsync(DeleteTokenRequest deleteTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTokenRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTokenResponse>(response);
        }

        public AsyncInvoker<DeleteTokenResponse> DeleteTokenAsyncInvoker(DeleteTokenRequest deleteTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTokenRequest);
            return new AsyncInvoker<DeleteTokenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTokenResponse>);
        }
        
        /// <summary>
        /// 企业管理员删除激活码
        ///
        /// 企业管理员批量删除激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVisionActiveCodeResponse> DeleteVisionActiveCodeAsync(DeleteVisionActiveCodeRequest deleteVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVisionActiveCodeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVisionActiveCodeResponse>(response);
        }

        public AsyncInvoker<DeleteVisionActiveCodeResponse> DeleteVisionActiveCodeAsyncInvoker(DeleteVisionActiveCodeRequest deleteVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVisionActiveCodeRequest);
            return new AsyncInvoker<DeleteVisionActiveCodeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 删除事件推送
        ///
        /// 该接口用于管理员删除已配置的事件推送设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWebHookConfigResponse> DeleteWebHookConfigAsync(DeleteWebHookConfigRequest deleteWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebHookConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWebHookConfigResponse>(response);
        }

        public AsyncInvoker<DeleteWebHookConfigResponse> DeleteWebHookConfigAsyncInvoker(DeleteWebHookConfigRequest deleteWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebHookConfigRequest);
            return new AsyncInvoker<DeleteWebHookConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWebHookConfigResponse>);
        }
        
        /// <summary>
        /// 取消网络研讨会
        ///
        /// 该接口用于取消已预约的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWebinarResponse> DeleteWebinarAsync(DeleteWebinarRequest deleteWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWebinarRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebinarRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWebinarResponse>(response);
        }

        public AsyncInvoker<DeleteWebinarResponse> DeleteWebinarAsyncInvoker(DeleteWebinarRequest deleteWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWebinarRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWebinarRequest);
            return new AsyncInvoker<DeleteWebinarResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWebinarResponse>);
        }
        
        /// <summary>
        /// 回收云会议室
        ///
        /// 企业管理员通过该接口回收云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateVmrResponse> DisassociateVmrAsync(DisassociateVmrRequest disassociateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateVmrRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/recycle-from-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateVmrRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateVmrResponse>(response);
        }

        public AsyncInvoker<DisassociateVmrResponse> DisassociateVmrAsyncInvoker(DisassociateVmrRequest disassociateVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateVmrRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr/recycle-from-member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateVmrRequest);
            return new AsyncInvoker<DisassociateVmrResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateVmrResponse>);
        }
        
        /// <summary>
        /// 举手
        ///
        /// 该接口用于设置指定与会者的举手/放下举手状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<HandResponse> HandAsync(HandRequest handRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", handRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<HandResponse>(response);
        }

        public AsyncInvoker<HandResponse> HandAsyncInvoker(HandRequest handRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/hands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", handRequest);
            return new AsyncInvoker<HandResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<HandResponse>);
        }
        
        /// <summary>
        /// 挂断与会者
        ///
        /// 该接口用于挂断正在通话中的与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<HangUpResponse> HangUpAsync(HangUpRequest hangUpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hangUpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpResponse>(response);
        }

        public AsyncInvoker<HangUpResponse> HangUpAsyncInvoker(HangUpRequest hangUpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", hangUpRequest);
            return new AsyncInvoker<HangUpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpResponse>);
        }
        
        /// <summary>
        /// 主持人邀请与会者开启/关闭摄像头
        ///
        /// 该接口用于邀请指定与会者开启、关闭摄像头。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InviteOperateVideoResponse> InviteOperateVideoAsync(InviteOperateVideoRequest inviteOperateVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/video", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteOperateVideoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<InviteOperateVideoResponse>(response);
        }

        public AsyncInvoker<InviteOperateVideoResponse> InviteOperateVideoAsyncInvoker(InviteOperateVideoRequest inviteOperateVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/video", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteOperateVideoRequest);
            return new AsyncInvoker<InviteOperateVideoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<InviteOperateVideoResponse>);
        }
        
        /// <summary>
        /// 邀请与会者
        ///
        /// 该接口用于邀请与会者加入会议。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InviteParticipantResponse> InviteParticipantAsync(InviteParticipantRequest inviteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteParticipantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<InviteParticipantResponse>(response);
        }

        public AsyncInvoker<InviteParticipantResponse> InviteParticipantAsyncInvoker(InviteParticipantRequest inviteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteParticipantRequest);
            return new AsyncInvoker<InviteParticipantResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InviteParticipantResponse>);
        }
        
        /// <summary>
        /// 邀请共享
        ///
        /// 该接口用于邀请/取消邀请指定与会人共享桌面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InviteShareResponse> InviteShareAsync(InviteShareRequest inviteShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/share/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteShareRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<InviteShareResponse>(response);
        }

        public AsyncInvoker<InviteShareResponse> InviteShareAsyncInvoker(InviteShareRequest inviteShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/share/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteShareRequest);
            return new AsyncInvoker<InviteShareResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<InviteShareResponse>);
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
        public async Task<InviteUserResponse> InviteUserAsync(InviteUserRequest inviteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<InviteUserResponse>(response);
        }

        public AsyncInvoker<InviteUserResponse> InviteUserAsyncInvoker(InviteUserRequest inviteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteUserRequest);
            return new AsyncInvoker<InviteUserResponse>(this, "POST", request, JsonUtils.DeSerialize<InviteUserResponse>);
        }
        
        /// <summary>
        /// 通过会议ID和密码邀请与会者
        ///
        /// 该接口用于通过会议ID和密码邀请与会者。一般用于App已知会议ID和来宾密码，通过扫码等方式获取其他终端的SIP号码后，使用该接口将其他终端邀请加入会议中。
        /// &gt; 需要管理员在企业的“会议设置”&gt;“来宾扫码邀请任意硬终端入会”设置成打开，才允许通过来宾密码邀请其他终端入会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InviteWithPwdResponse> InviteWithPwdAsync(InviteWithPwdRequest inviteWithPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/inviteWithPwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteWithPwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<InviteWithPwdResponse>(response);
        }

        public AsyncInvoker<InviteWithPwdResponse> InviteWithPwdAsyncInvoker(InviteWithPwdRequest inviteWithPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/inviteWithPwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteWithPwdRequest);
            return new AsyncInvoker<InviteWithPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InviteWithPwdResponse>);
        }
        
        /// <summary>
        /// 查询历史召开的网络研讨会列表
        ///
        /// 该接口用于查询历史网络研讨会。管理员可查询企业内历史网络研讨会，非管理员可查询个人历史网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryWebinarsResponse> ListHistoryWebinarsAsync(ListHistoryWebinarsRequest listHistoryWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryWebinarsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryWebinarsResponse>(response);
        }

        public AsyncInvoker<ListHistoryWebinarsResponse> ListHistoryWebinarsAsyncInvoker(ListHistoryWebinarsRequest listHistoryWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryWebinarsRequest);
            return new AsyncInvoker<ListHistoryWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryWebinarsResponse>);
        }
        
        /// <summary>
        /// 查询会场网络质量
        ///
        /// 查询会场网络质量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetworkQualityResponse> ListNetworkQualityAsync(ListNetworkQualityRequest listNetworkQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/cqs/media/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkQualityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListNetworkQualityResponse>(response);
        }

        public AsyncInvoker<ListNetworkQualityResponse> ListNetworkQualityAsyncInvoker(ListNetworkQualityRequest listNetworkQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/cqs/media/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkQualityRequest);
            return new AsyncInvoker<ListNetworkQualityResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNetworkQualityResponse>);
        }
        
        /// <summary>
        /// 查询正在召开的网络研讨会列表
        ///
        /// 该接口用于查询正在召开的网络研讨会。管理员可查询企业内正在召开网络研讨会，非管理员可查询自己预订的正在召开的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOngoingWebinarsResponse> ListOngoingWebinarsAsync(ListOngoingWebinarsRequest listOngoingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/ongoing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOngoingWebinarsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOngoingWebinarsResponse>(response);
        }

        public AsyncInvoker<ListOngoingWebinarsResponse> ListOngoingWebinarsAsyncInvoker(ListOngoingWebinarsRequest listOngoingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/ongoing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOngoingWebinarsRequest);
            return new AsyncInvoker<ListOngoingWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOngoingWebinarsResponse>);
        }
        
        /// <summary>
        /// 查询指定会议的在线与会者信息
        ///
        /// 该接口用于查询指定会议的在线与会者信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOnlineConfAttendeeResponse> ListOnlineConfAttendeeAsync(ListOnlineConfAttendeeRequest listOnlineConfAttendeeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/conf-attendee", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnlineConfAttendeeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOnlineConfAttendeeResponse>(response);
        }

        public AsyncInvoker<ListOnlineConfAttendeeResponse> ListOnlineConfAttendeeAsyncInvoker(ListOnlineConfAttendeeRequest listOnlineConfAttendeeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/conf-attendee", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnlineConfAttendeeRequest);
            return new AsyncInvoker<ListOnlineConfAttendeeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOnlineConfAttendeeResponse>);
        }
        
        /// <summary>
        /// 查询即将召开的网络研讨会列表
        ///
        /// 该接口用于查询即将召开的网络研讨会。管理员可查询企业内即将召开网络研讨会，非管理员可查询自己预订的即将召开的网络研讨会。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUpComingWebinarsResponse> ListUpComingWebinarsAsync(ListUpComingWebinarsRequest listUpComingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/upcoming", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpComingWebinarsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpComingWebinarsResponse>(response);
        }

        public AsyncInvoker<ListUpComingWebinarsResponse> ListUpComingWebinarsAsyncInvoker(ListUpComingWebinarsRequest listUpComingWebinarsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/upcoming", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpComingWebinarsRequest);
            return new AsyncInvoker<ListUpComingWebinarsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpComingWebinarsResponse>);
        }
        
        /// <summary>
        /// 启停会议直播
        ///
        /// 该接口用于启动或停止会议直播。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LiveResponse> LiveAsync(LiveRequest liveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/live", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<LiveResponse>(response);
        }

        public AsyncInvoker<LiveResponse> LiveAsyncInvoker(LiveRequest liveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/live", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveRequest);
            return new AsyncInvoker<LiveResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LiveResponse>);
        }
        
        /// <summary>
        /// 锁定会议
        ///
        /// 该接口用于锁定或解锁会议。锁定会议后，不允许新的来宾主动加入会议。会议锁定后使用主持人密码/主持人链接加入会议或者主持人邀请来宾不受影响。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LockMeetingResponse> LockMeetingAsync(LockMeetingRequest lockMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<LockMeetingResponse>(response);
        }

        public AsyncInvoker<LockMeetingResponse> LockMeetingAsyncInvoker(LockMeetingRequest lockMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockMeetingRequest);
            return new AsyncInvoker<LockMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LockMeetingResponse>);
        }
        
        /// <summary>
        /// 锁定会场视频源
        ///
        /// 该接口用于锁定或者解锁某在线会场的视频源。只适用于专业会议终端（如TE系列等）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LockViewResponse> LockViewAsync(LockViewRequest lockViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lockView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockViewRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<LockViewResponse>(response);
        }

        public AsyncInvoker<LockViewResponse> LockViewAsyncInvoker(LockViewRequest lockViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/lockView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockViewRequest);
            return new AsyncInvoker<LockViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<LockViewResponse>);
        }
        
        /// <summary>
        /// 移入等候室
        ///
        /// 该接口用于将会中的指定与会者移入到等候室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MoveToWaitingRoomResponse> MoveToWaitingRoomAsync(MoveToWaitingRoomRequest moveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/moveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveToWaitingRoomRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<MoveToWaitingRoomResponse>(response);
        }

        public AsyncInvoker<MoveToWaitingRoomResponse> MoveToWaitingRoomAsyncInvoker(MoveToWaitingRoomRequest moveToWaitingRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/moveToWaitingRoom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveToWaitingRoomRequest);
            return new AsyncInvoker<MoveToWaitingRoomResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MoveToWaitingRoomResponse>);
        }
        
        /// <summary>
        /// 全场静音
        ///
        /// 该接口用于设置整个会议所有与会者（主持人除外）的静音/取消静音状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MuteMeetingResponse> MuteMeetingAsync(MuteMeetingRequest muteMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<MuteMeetingResponse>(response);
        }

        public AsyncInvoker<MuteMeetingResponse> MuteMeetingAsyncInvoker(MuteMeetingRequest muteMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteMeetingRequest);
            return new AsyncInvoker<MuteMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MuteMeetingResponse>);
        }
        
        /// <summary>
        /// 静音与会者
        ///
        /// 该接口用于设置指定与会者静音/取消静音状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MuteParticipantResponse> MuteParticipantAsync(MuteParticipantRequest muteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteParticipantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<MuteParticipantResponse>(response);
        }

        public AsyncInvoker<MuteParticipantResponse> MuteParticipantAsyncInvoker(MuteParticipantRequest muteParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/mute", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", muteParticipantRequest);
            return new AsyncInvoker<MuteParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MuteParticipantResponse>);
        }
        
        /// <summary>
        /// 主持人暂停/取消暂停会议
        ///
        /// 主持人通过接口控制暂停/取消暂停。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PauseConferenceResponse> PauseConferenceAsync(PauseConferenceRequest pauseConferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConferenceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<PauseConferenceResponse>(response);
        }

        public AsyncInvoker<PauseConferenceResponse> PauseConferenceAsyncInvoker(PauseConferenceRequest pauseConferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConferenceRequest);
            return new AsyncInvoker<PauseConferenceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PauseConferenceResponse>);
        }
        
        /// <summary>
        /// 延长会议
        ///
        /// 该接口用于延长会议时间。默认会议自动延长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ProlongMeetingResponse> ProlongMeetingAsync(ProlongMeetingRequest prolongMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", prolongMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ProlongMeetingResponse>(response);
        }

        public AsyncInvoker<ProlongMeetingResponse> ProlongMeetingAsyncInvoker(ProlongMeetingRequest prolongMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", prolongMeetingRequest);
            return new AsyncInvoker<ProlongMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ProlongMeetingResponse>);
        }
        
        /// <summary>
        /// 启停会议录制
        ///
        /// 该接口用于启动或停止会议云录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecordResponse> RecordAsync(RecordRequest recordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<RecordResponse>(response);
        }

        public AsyncInvoker<RecordResponse> RecordAsyncInvoker(RecordRequest recordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recordRequest);
            return new AsyncInvoker<RecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RecordResponse>);
        }
        
        /// <summary>
        /// 重命名与会者
        ///
        /// 重命名某个与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RenameParticipantResponse> RenameParticipantAsync(RenameParticipantRequest renameParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameParticipantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<RenameParticipantResponse>(response);
        }

        public AsyncInvoker<RenameParticipantResponse> RenameParticipantAsyncInvoker(RenameParticipantRequest renameParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameParticipantRequest);
            return new AsyncInvoker<RenameParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RenameParticipantResponse>);
        }
        
        /// <summary>
        /// 企业管理员通过sn重置激活码
        ///
        /// 当硬终端激活码失效时，企业管理员可以通过该接口重置激活码，使用重新获取的激活码激活终端，每24小时可重新激活5次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetActivecodeResponse> ResetActivecodeAsync(ResetActivecodeRequest resetActivecodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetActivecodeRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActivecodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetActivecodeResponse>(response);
        }

        public AsyncInvoker<ResetActivecodeResponse> ResetActivecodeAsyncInvoker(ResetActivecodeRequest resetActivecodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetActivecodeRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActivecodeRequest);
            return new AsyncInvoker<ResetActivecodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetActivecodeResponse>);
        }
        
        /// <summary>
        /// 重置企业应用appkey
        ///
        /// 企业默认管理员重置企业应用appkey
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetAppKeyResponse> ResetAppKeyAsync(ResetAppKeyRequest resetAppKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAppKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetAppKeyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResetAppKeyResponse>(response);
        }

        public AsyncInvoker<ResetAppKeyResponse> ResetAppKeyAsyncInvoker(ResetAppKeyRequest resetAppKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAppKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetAppKeyRequest);
            return new AsyncInvoker<ResetAppKeyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetAppKeyResponse>);
        }
        
        /// <summary>
        /// 用户重置密码
        ///
        /// 该接口提供给用户重置密码功能，服务器收到请求，重新设置用户密码并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdResponse> ResetPwdAsync(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public AsyncInvoker<ResetPwdResponse> ResetPwdAsyncInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            return new AsyncInvoker<ResetPwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
        }
        
        /// <summary>
        /// 企业管理员重置企业成员密码
        ///
        /// 企业管理员通过该接口提供企业管理员重置企业成员密码的功能。当服务器收到重置密码的请求时，发送新的密码到企业成员的邮箱或者短信，并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdByAdminResponse> ResetPwdByAdminAsync(ResetPwdByAdminRequest resetPwdByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/admin/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdByAdminRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPwdByAdminResponse>(response);
        }

        public AsyncInvoker<ResetPwdByAdminResponse> ResetPwdByAdminAsyncInvoker(ResetPwdByAdminRequest resetPwdByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password/admin/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdByAdminRequest);
            return new AsyncInvoker<ResetPwdByAdminResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPwdByAdminResponse>);
        }
        
        /// <summary>
        /// 企业管理员重置帐号的激活码
        ///
        /// 企业管理员重置帐号的激活码，重置后，原设备直接解绑，必须重新激活使用,若手机邮箱不填，则不会发送新的激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetVisionActiveCodeResponse> ResetVisionActiveCodeAsync(ResetVisionActiveCodeRequest resetVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetVisionActiveCodeRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode/{account}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetVisionActiveCodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResetVisionActiveCodeResponse>(response);
        }

        public AsyncInvoker<ResetVisionActiveCodeResponse> ResetVisionActiveCodeAsyncInvoker(ResetVisionActiveCodeRequest resetVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetVisionActiveCodeRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode/{account}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetVisionActiveCodeRequest);
            return new AsyncInvoker<ResetVisionActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 开启/关闭同声传译
        ///
        /// 该接口用于会议主席可以通过该接口开启/关闭同声传译。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResumeSimultaneousInterpretationResponse> ResumeSimultaneousInterpretationAsync(ResumeSimultaneousInterpretationRequest resumeSimultaneousInterpretationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/simultaneousInterpretation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeSimultaneousInterpretationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResumeSimultaneousInterpretationResponse>(response);
        }

        public AsyncInvoker<ResumeSimultaneousInterpretationResponse> ResumeSimultaneousInterpretationAsyncInvoker(ResumeSimultaneousInterpretationRequest resumeSimultaneousInterpretationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/simultaneousInterpretation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeSimultaneousInterpretationRequest);
            return new AsyncInvoker<ResumeSimultaneousInterpretationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResumeSimultaneousInterpretationResponse>);
        }
        
        /// <summary>
        /// 点名会场
        ///
        /// 该接口用于点名指定与会者。点名会场的效果是除了主持人外，点名与会者为非静音状态，未点名的与会者统一为静音状态。同一时间，只允许一个与会者被点名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollcallParticipantResponse> RollcallParticipantAsync(RollcallParticipantRequest rollcallParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/rollCall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollcallParticipantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<RollcallParticipantResponse>(response);
        }

        public AsyncInvoker<RollcallParticipantResponse> RollcallParticipantAsyncInvoker(RollcallParticipantRequest rollcallParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/rollCall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollcallParticipantRequest);
            return new AsyncInvoker<RollcallParticipantResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RollcallParticipantResponse>);
        }
        
        /// <summary>
        /// 保存多画面布局
        ///
        /// 该接口用于保存多画面布局。保存的多画面布局，只能在当前会议使用，会议结束后，保存的多画面布局就会释放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveLayoutResponse> SaveLayoutAsync(SaveLayoutRequest saveLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLayoutRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SaveLayoutResponse>(response);
        }

        public AsyncInvoker<SaveLayoutResponse> SaveLayoutAsyncInvoker(SaveLayoutRequest saveLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLayoutRequest);
            return new AsyncInvoker<SaveLayoutResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SaveLayoutResponse>);
        }
        
        /// <summary>
        /// 查询历史会议的与会者记录
        ///
        /// 该接口用于查询指定历史会议的与会者记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchAttendanceRecordsOfHisMeetingResponse> SearchAttendanceRecordsOfHisMeetingAsync(SearchAttendanceRecordsOfHisMeetingRequest searchAttendanceRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confAttendeeRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAttendanceRecordsOfHisMeetingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchAttendanceRecordsOfHisMeetingResponse>(response);
        }

        public AsyncInvoker<SearchAttendanceRecordsOfHisMeetingResponse> SearchAttendanceRecordsOfHisMeetingAsyncInvoker(SearchAttendanceRecordsOfHisMeetingRequest searchAttendanceRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confAttendeeRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAttendanceRecordsOfHisMeetingRequest);
            return new AsyncInvoker<SearchAttendanceRecordsOfHisMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchAttendanceRecordsOfHisMeetingResponse>);
        }
        
        /// <summary>
        /// SP管理员分页搜索企业
        ///
        /// SP管理员分页搜索企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpResponse> SearchCorpAsync(SearchCorpRequest searchCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpResponse>(response);
        }

        public AsyncInvoker<SearchCorpResponse> SearchCorpAsyncInvoker(SearchCorpRequest searchCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpRequest);
            return new AsyncInvoker<SearchCorpResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpResponse>);
        }
        
        /// <summary>
        /// 分页查询企业管理员
        ///
        /// 通过该接口分页查询企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpAdminsResponse> SearchCorpAdminsAsync(SearchCorpAdminsRequest searchCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpAdminsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpAdminsResponse>(response);
        }

        public AsyncInvoker<SearchCorpAdminsResponse> SearchCorpAdminsAsyncInvoker(SearchCorpAdminsRequest searchCorpAdminsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpAdminsRequest);
            return new AsyncInvoker<SearchCorpAdminsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpAdminsResponse>);
        }
        
        /// <summary>
        /// 查询企业通讯录
        ///
        /// 企业用户（含管理员）通过该接口查询该企业的通讯录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpDirResponse> SearchCorpDirAsync(SearchCorpDirRequest searchCorpDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpDirRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpDirResponse>(response);
        }

        public AsyncInvoker<SearchCorpDirResponse> SearchCorpDirAsyncInvoker(SearchCorpDirRequest searchCorpDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpDirRequest);
            return new AsyncInvoker<SearchCorpDirResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpDirResponse>);
        }
        
        /// <summary>
        /// 查询企业外部联系人
        ///
        /// 企业用户（含管理员）通过该接口查询该企业的外部联系人或者个人外部联系人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpExternalDirResponse> SearchCorpExternalDirAsync(SearchCorpExternalDirRequest searchCorpExternalDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/external-contacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpExternalDirRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpExternalDirResponse>(response);
        }

        public AsyncInvoker<SearchCorpExternalDirResponse> SearchCorpExternalDirAsyncInvoker(SearchCorpExternalDirRequest searchCorpExternalDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/external-contacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpExternalDirRequest);
            return new AsyncInvoker<SearchCorpExternalDirResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpExternalDirResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询企业资源订单列表
        ///
        /// 企业管理员根据条件查询企业资源订单列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpResourcesResponse> SearchCorpResourcesAsync(SearchCorpResourcesRequest searchCorpResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpResourcesResponse>(response);
        }

        public AsyncInvoker<SearchCorpResourcesResponse> SearchCorpResourcesAsyncInvoker(SearchCorpResourcesRequest searchCorpResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpResourcesRequest);
            return new AsyncInvoker<SearchCorpResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpResourcesResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询企业云会议室
        ///
        /// 企业管理员通过该接口分页查询企业的云会议室。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCorpVmrResponse> SearchCorpVmrAsync(SearchCorpVmrRequest searchCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpVmrRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCorpVmrResponse>(response);
        }

        public AsyncInvoker<SearchCorpVmrResponse> SearchCorpVmrAsyncInvoker(SearchCorpVmrRequest searchCorpVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCorpVmrRequest);
            return new AsyncInvoker<SearchCorpVmrResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCorpVmrResponse>);
        }
        
        /// <summary>
        /// 查询历史会议的会控记录
        ///
        /// 该接口用于查询指定历史会议的会控记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchCtlRecordsOfHisMeetingResponse> SearchCtlRecordsOfHisMeetingAsync(SearchCtlRecordsOfHisMeetingRequest searchCtlRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confCtlRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCtlRecordsOfHisMeetingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchCtlRecordsOfHisMeetingResponse>(response);
        }

        public AsyncInvoker<SearchCtlRecordsOfHisMeetingResponse> SearchCtlRecordsOfHisMeetingAsyncInvoker(SearchCtlRecordsOfHisMeetingRequest searchCtlRecordsOfHisMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confCtlRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchCtlRecordsOfHisMeetingRequest);
            return new AsyncInvoker<SearchCtlRecordsOfHisMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchCtlRecordsOfHisMeetingResponse>);
        }
        
        /// <summary>
        /// 按名称查询所有的部门
        ///
        /// 企业管理员通过该接口按名称查询所有的部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchDepartmentByNameResponse> SearchDepartmentByNameAsync(SearchDepartmentByNameRequest searchDepartmentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDepartmentByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var searchDepartmentByNameResponse = JsonUtils.DeSerializeNull<SearchDepartmentByNameResponse>(response);
            searchDepartmentByNameResponse.Body = JsonUtils.DeSerializeList<QueryDeptResultDTO>(response);
            return searchDepartmentByNameResponse;
        }

        public AsyncInvoker<SearchDepartmentByNameResponse> SearchDepartmentByNameAsyncInvoker(SearchDepartmentByNameRequest searchDepartmentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDepartmentByNameRequest);
            return new AsyncInvoker<SearchDepartmentByNameResponse>(this, "GET", request, response =>
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
        public async Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchDevicesResponse>(response);
        }

        public AsyncInvoker<SearchDevicesResponse> SearchDevicesAsyncInvoker(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            return new AsyncInvoker<SearchDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchDevicesResponse>);
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
        public async Task<SearchHisMeetingsResponse> SearchHisMeetingsAsync(SearchHisMeetingsRequest searchHisMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchHisMeetingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchHisMeetingsResponse>(response);
        }

        public AsyncInvoker<SearchHisMeetingsResponse> SearchHisMeetingsAsyncInvoker(SearchHisMeetingsRequest searchHisMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchHisMeetingsRequest);
            return new AsyncInvoker<SearchHisMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchHisMeetingsResponse>);
        }
        
        /// <summary>
        /// 分页查询信息窗素材
        ///
        /// 分页查询信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchMaterialsResponse> SearchMaterialsAsync(SearchMaterialsRequest searchMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMaterialsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchMaterialsResponse>(response);
        }

        public AsyncInvoker<SearchMaterialsResponse> SearchMaterialsAsyncInvoker(SearchMaterialsRequest searchMaterialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMaterialsRequest);
            return new AsyncInvoker<SearchMaterialsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMaterialsResponse>);
        }
        
        /// <summary>
        /// 查询会议纪要列表
        ///
        /// 用户查询自己的会议纪要列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchMeetingFileListResponse> SearchMeetingFileListAsync(SearchMeetingFileListRequest searchMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingFileListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchMeetingFileListResponse>(response);
        }

        public AsyncInvoker<SearchMeetingFileListResponse> SearchMeetingFileListAsyncInvoker(SearchMeetingFileListRequest searchMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingFileListRequest);
            return new AsyncInvoker<SearchMeetingFileListResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMeetingFileListResponse>);
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
        public async Task<SearchMeetingsResponse> SearchMeetingsAsync(SearchMeetingsRequest searchMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchMeetingsResponse>(response);
        }

        public AsyncInvoker<SearchMeetingsResponse> SearchMeetingsAsyncInvoker(SearchMeetingsRequest searchMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMeetingsRequest);
            return new AsyncInvoker<SearchMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMeetingsResponse>);
        }
        
        /// <summary>
        /// 普通用户分页查询云会议室及个人会议ID
        ///
        /// 企业用户通过该接口查询个人已分配的云会议室及个人会议ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchMemberVmrResponse> SearchMemberVmrAsync(SearchMemberVmrRequest searchMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMemberVmrRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchMemberVmrResponse>(response);
        }

        public AsyncInvoker<SearchMemberVmrResponse> SearchMemberVmrAsyncInvoker(SearchMemberVmrRequest searchMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchMemberVmrRequest);
            return new AsyncInvoker<SearchMemberVmrResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchMemberVmrResponse>);
        }
        
        /// <summary>
        /// 查询在线会议列表
        ///
        /// 该接口用于查询正在召开的会议列表。管理员可以查询本企业内所有在线会议，普通用户仅能查询当前自己帐号创建或者需要参加的在线会议。不带查询参数时，默认查询权限范围内的在线会议，按开始时间升序排列。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchOnlineMeetingsResponse> SearchOnlineMeetingsAsync(SearchOnlineMeetingsRequest searchOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchOnlineMeetingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchOnlineMeetingsResponse>(response);
        }

        public AsyncInvoker<SearchOnlineMeetingsResponse> SearchOnlineMeetingsAsyncInvoker(SearchOnlineMeetingsRequest searchOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchOnlineMeetingsRequest);
            return new AsyncInvoker<SearchOnlineMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchOnlineMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询信息窗节目
        ///
        /// 获取信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchProgramsResponse> SearchProgramsAsync(SearchProgramsRequest searchProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchProgramsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchProgramsResponse>(response);
        }

        public AsyncInvoker<SearchProgramsResponse> SearchProgramsAsyncInvoker(SearchProgramsRequest searchProgramsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchProgramsRequest);
            return new AsyncInvoker<SearchProgramsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchProgramsResponse>);
        }
        
        /// <summary>
        /// 查询信息窗发布
        ///
        /// 获取信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchPublicationsResponse> SearchPublicationsAsync(SearchPublicationsRequest searchPublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchPublicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchPublicationsResponse>(response);
        }

        public AsyncInvoker<SearchPublicationsResponse> SearchPublicationsAsyncInvoker(SearchPublicationsRequest searchPublicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchPublicationsRequest);
            return new AsyncInvoker<SearchPublicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchPublicationsResponse>);
        }
        
        /// <summary>
        /// 查询录制列表
        ///
        /// 该接口用于查询会议录制列表。管理员可以查询本企业内所有的录制，普通用户仅能查询自己创建的会议的录制。不带查询参数时，默认查询权限范围内的录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchRecordingsResponse> SearchRecordingsAsync(SearchRecordingsRequest searchRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchRecordingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchRecordingsResponse>(response);
        }

        public AsyncInvoker<SearchRecordingsResponse> SearchRecordingsAsyncInvoker(SearchRecordingsRequest searchRecordingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchRecordingsRequest);
            return new AsyncInvoker<SearchRecordingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchRecordingsResponse>);
        }
        
        /// <summary>
        /// SP管理员根据分页查询企业资源
        ///
        /// SP根据条件查询企业的资源项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceResponse> SearchResourceAsync(SearchResourceRequest searchResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchResourceResponse>(response);
        }

        public AsyncInvoker<SearchResourceResponse> SearchResourceAsyncInvoker(SearchResourceRequest searchResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceRequest);
            return new AsyncInvoker<SearchResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchResourceResponse>);
        }
        
        /// <summary>
        /// SP管理员分页查询企业资源操作记录
        ///
        /// SP根据根据条件查询企业的资源操作记录，支持根据resourceId模糊搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceOpRecordResponse> SearchResourceOpRecordAsync(SearchResourceOpRecordRequest searchResourceOpRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchResourceOpRecordRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceOpRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchResourceOpRecordResponse>(response);
        }

        public AsyncInvoker<SearchResourceOpRecordResponse> SearchResourceOpRecordAsyncInvoker(SearchResourceOpRecordRequest searchResourceOpRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchResourceOpRecordRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceOpRecordRequest);
            return new AsyncInvoker<SearchResourceOpRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchResourceOpRecordResponse>);
        }
        
        /// <summary>
        /// 分页查询用户
        ///
        /// 企业管理员通过该接口分页查询企业用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest searchUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchUsersResponse>(response);
        }

        public AsyncInvoker<SearchUsersResponse> SearchUsersAsyncInvoker(SearchUsersRequest searchUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchUsersRequest);
            return new AsyncInvoker<SearchUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchUsersResponse>);
        }
        
        /// <summary>
        /// 企业管理员分页查询激活码
        ///
        /// 企业管理员分页查询激活码，支持激活码、终端名称模糊查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchVisionActiveCodeResponse> SearchVisionActiveCodeAsync(SearchVisionActiveCodeRequest searchVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchVisionActiveCodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchVisionActiveCodeResponse>(response);
        }

        public AsyncInvoker<SearchVisionActiveCodeResponse> SearchVisionActiveCodeAsyncInvoker(SearchVisionActiveCodeRequest searchVisionActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/vision/activecode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchVisionActiveCodeRequest);
            return new AsyncInvoker<SearchVisionActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchVisionActiveCodeResponse>);
        }
        
        /// <summary>
        /// 发送滑块验证码
        ///
        /// 该接口提供发送滑块验证码。服务器收到请求，返回抠图以及抠图后的原图等结果。需要在前台界面显示出抠图以及抠图后的原图，用户通过滑块操作来匹配图形。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendSlideVerifyCodeResponse> SendSlideVerifyCodeAsync(SendSlideVerifyCodeRequest sendSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSlideVerifyCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendSlideVerifyCodeResponse>(response);
        }

        public AsyncInvoker<SendSlideVerifyCodeResponse> SendSlideVerifyCodeAsyncInvoker(SendSlideVerifyCodeRequest sendSlideVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/auth/slideverifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSlideVerifyCodeRequest);
            return new AsyncInvoker<SendSlideVerifyCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<SendSlideVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 发送验证码
        ///
        /// 该接口提供发送验证码，服务器收到请求，发送验证码到邮箱或者短信并返回结果。用户在前台界面通过滑块验证后，再进行发送验证码操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendVeriCodeForChangePwdResponse> SendVeriCodeForChangePwdAsync(SendVeriCodeForChangePwdRequest sendVeriCodeForChangePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForChangePwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendVeriCodeForChangePwdResponse>(response);
        }

        public AsyncInvoker<SendVeriCodeForChangePwdResponse> SendVeriCodeForChangePwdAsyncInvoker(SendVeriCodeForChangePwdRequest sendVeriCodeForChangePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/verifycode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForChangePwdRequest);
            return new AsyncInvoker<SendVeriCodeForChangePwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SendVeriCodeForChangePwdResponse>);
        }
        
        /// <summary>
        /// 获取验证码
        ///
        /// 修改用户手机或邮箱时，需要获取验证码。企业用户通过该接口获取验证码，系统会向用户的手机或邮箱发送，验证码1分钟内有效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendVeriCodeForUpdateUserInfoResponse> SendVeriCodeForUpdateUserInfoAsync(SendVeriCodeForUpdateUserInfoRequest sendVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForUpdateUserInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendVeriCodeForUpdateUserInfoResponse>(response);
        }

        public AsyncInvoker<SendVeriCodeForUpdateUserInfoResponse> SendVeriCodeForUpdateUserInfoAsyncInvoker(SendVeriCodeForUpdateUserInfoRequest sendVeriCodeForUpdateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVeriCodeForUpdateUserInfoRequest);
            return new AsyncInvoker<SendVeriCodeForUpdateUserInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendVeriCodeForUpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 设置普通与会人的语言频道
        ///
        /// 主持人通过该接口设置某些普通与会者(包括主持人)加入哪个语言频道。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAttendeeLanChannelResponse> SetAttendeeLanChannelAsync(SetAttendeeLanChannelRequest setAttendeeLanChannelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/setAttendeeLanChannel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAttendeeLanChannelRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAttendeeLanChannelResponse>(response);
        }

        public AsyncInvoker<SetAttendeeLanChannelResponse> SetAttendeeLanChannelAsyncInvoker(SetAttendeeLanChannelRequest setAttendeeLanChannelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/setAttendeeLanChannel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAttendeeLanChannelRequest);
            return new AsyncInvoker<SetAttendeeLanChannelResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAttendeeLanChannelResponse>);
        }
        
        /// <summary>
        /// 申请联席主持人
        ///
        /// 该接口用于设置联席主持人或释放联席主持人。只能将来宾设置为联席主持人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetCohostResponse> SetCohostAsync(SetCohostRequest setCohostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/cohost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCohostRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetCohostResponse>(response);
        }

        public AsyncInvoker<SetCohostResponse> SetCohostAsyncInvoker(SetCohostRequest setCohostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/cohost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCohostRequest);
            return new AsyncInvoker<SetCohostResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetCohostResponse>);
        }
        
        /// <summary>
        /// 设置自定义多画面
        ///
        /// 该接口用于设置会中多画面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetCustomMultiPictureResponse> SetCustomMultiPictureAsync(SetCustomMultiPictureRequest setCustomMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/customMultiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCustomMultiPictureRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetCustomMultiPictureResponse>(response);
        }

        public AsyncInvoker<SetCustomMultiPictureResponse> SetCustomMultiPictureAsyncInvoker(SetCustomMultiPictureRequest setCustomMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/customMultiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCustomMultiPictureRequest);
            return new AsyncInvoker<SetCustomMultiPictureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetCustomMultiPictureResponse>);
        }
        
        /// <summary>
        /// 主持人选看
        ///
        /// 该接口用于主持人轮询、主持人选看多画面、主持人选看会场操作。只适用于专业会议终端（如TE系列等）为主持人的场景。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetHostViewResponse> SetHostViewAsync(SetHostViewRequest setHostViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/chairView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setHostViewRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetHostViewResponse>(response);
        }

        public AsyncInvoker<SetHostViewResponse> SetHostViewAsyncInvoker(SetHostViewRequest setHostViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/chairView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setHostViewRequest);
            return new AsyncInvoker<SetHostViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetHostViewResponse>);
        }
        
        /// <summary>
        /// 设置传译组
        ///
        /// 主持人通过该接口设置传译组，每个传译组支持两种语言，传译组内支持多个传译员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetInterpreterGroupResponse> SetInterpreterGroupAsync(SetInterpreterGroupRequest setInterpreterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/interpreterGroup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInterpreterGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetInterpreterGroupResponse>(response);
        }

        public AsyncInvoker<SetInterpreterGroupResponse> SetInterpreterGroupAsyncInvoker(SetInterpreterGroupRequest setInterpreterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/interpreterGroup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInterpreterGroupRequest);
            return new AsyncInvoker<SetInterpreterGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetInterpreterGroupResponse>);
        }
        
        /// <summary>
        /// 启动/停止Mmr会议直播
        ///
        /// 使用场景：会议主持人可以通过该接口启动/停止Mmr会议直播 功能描述：提供启动/停止会议Mmr直播的能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetMmrLiveResponse> SetMmrLiveAsync(SetMmrLiveRequest setMmrLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrLive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrLiveRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMmrLiveResponse>(response);
        }

        public AsyncInvoker<SetMmrLiveResponse> SetMmrLiveAsyncInvoker(SetMmrLiveRequest setMmrLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrLive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrLiveRequest);
            return new AsyncInvoker<SetMmrLiveResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMmrLiveResponse>);
        }
        
        /// <summary>
        /// 启动/暂停/停止mmr会议录制
        ///
        /// 使用场景：管理员或UC账号主席可以通过该接口启动/停止mmr会议录制 功能描述：提供启动/暂停/停止MMR会议录制的能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetMmrRecordResponse> SetMmrRecordAsync(SetMmrRecordRequest setMmrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrRecordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMmrRecordResponse>(response);
        }

        public AsyncInvoker<SetMmrRecordResponse> SetMmrRecordAsyncInvoker(SetMmrRecordRequest setMmrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/mmrRecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMmrRecordRequest);
            return new AsyncInvoker<SetMmrRecordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMmrRecordResponse>);
        }
        
        /// <summary>
        /// 设置多画面
        ///
        /// 设置会议多画面。该接口废弃不用，请使用“[[设置自定义多画面](https://support.huaweicloud.com/api-meeting/meeting_21_0418.html)](tag:hws)[[设置自定义多画面](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0418.html)](tag:hk)”接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetMultiPictureResponse> SetMultiPictureAsync(SetMultiPictureRequest setMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/multiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMultiPictureRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMultiPictureResponse>(response);
        }

        public AsyncInvoker<SetMultiPictureResponse> SetMultiPictureAsyncInvoker(SetMultiPictureRequest setMultiPictureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/multiPicture", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMultiPictureRequest);
            return new AsyncInvoker<SetMultiPictureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMultiPictureResponse>);
        }
        
        /// <summary>
        /// 会场选看
        ///
        /// 该接口用于专业会议终端（如TE系列等）选看其他与会者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetParticipantViewResponse> SetParticipantViewAsync(SetParticipantViewRequest setParticipantViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/partView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setParticipantViewRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetParticipantViewResponse>(response);
        }

        public AsyncInvoker<SetParticipantViewResponse> SetParticipantViewAsyncInvoker(SetParticipantViewRequest setParticipantViewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/partView", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setParticipantViewRequest);
            return new AsyncInvoker<SetParticipantViewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetParticipantViewResponse>);
        }
        
        /// <summary>
        /// 用户设置头像
        ///
        /// 用户设置头像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetProfileImageResponse> SetProfileImageAsync(SetProfileImageRequest setProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setProfileImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetProfileImageResponse>(response);
        }

        public AsyncInvoker<SetProfileImageResponse> SetProfileImageAsyncInvoker(SetProfileImageRequest setProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setProfileImageRequest);
            return new AsyncInvoker<SetProfileImageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetProfileImageResponse>);
        }
        
        /// <summary>
        /// 申请主持人
        ///
        /// 该接口用于设置主持人或释放主持人。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRoleResponse> SetRoleAsync(SetRoleRequest setRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRoleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRoleResponse>(response);
        }

        public AsyncInvoker<SetRoleResponse> SetRoleAsyncInvoker(SetRoleRequest setRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/participants/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRoleRequest);
            return new AsyncInvoker<SetRoleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRoleResponse>);
        }
        
        /// <summary>
        /// 设置SSO登录配置
        ///
        /// 该接口用于设置SSO登录的鉴权配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSsoConfigResponse> SetSsoConfigAsync(SetSsoConfigRequest setSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSsoConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetSsoConfigResponse>(response);
        }

        public AsyncInvoker<SetSsoConfigResponse> SetSsoConfigAsyncInvoker(SetSsoConfigRequest setSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSsoConfigRequest);
            return new AsyncInvoker<SetSsoConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetSsoConfigResponse>);
        }
        
        /// <summary>
        /// 企业管理员设置企业成员头像
        ///
        /// 为企业内的用户设置头像（只允许管理员调用）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetUserProfileImageResponse> SetUserProfileImageAsync(SetUserProfileImageRequest setUserProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setUserProfileImageRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setUserProfileImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetUserProfileImageResponse>(response);
        }

        public AsyncInvoker<SetUserProfileImageResponse> SetUserProfileImageAsyncInvoker(SetUserProfileImageRequest setUserProfileImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setUserProfileImageRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/profile-images/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", setUserProfileImageRequest);
            return new AsyncInvoker<SetUserProfileImageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetUserProfileImageResponse>);
        }
        
        /// <summary>
        /// 设置事件推送
        ///
        /// 该接口用于管理员设置企业级会议事件订阅配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetWebHookConfigResponse> SetWebHookConfigAsync(SetWebHookConfigRequest setWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setWebHookConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetWebHookConfigResponse>(response);
        }

        public AsyncInvoker<SetWebHookConfigResponse> SetWebHookConfigAsyncInvoker(SetWebHookConfigRequest setWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setWebHookConfigRequest);
            return new AsyncInvoker<SetWebHookConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetWebHookConfigResponse>);
        }
        
        /// <summary>
        /// SP管理员查询会议归属企业
        ///
        /// SP管理员根据会议ID查询该会议归属的企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfOrgResponse> ShowConfOrgAsync(ShowConfOrgRequest showConfOrgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confOrg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfOrgRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfOrgResponse>(response);
        }

        public AsyncInvoker<ShowConfOrgResponse> ShowConfOrgAsyncInvoker(ShowConfOrgRequest showConfOrgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confOrg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfOrgRequest);
            return new AsyncInvoker<ShowConfOrgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfOrgResponse>);
        }
        
        /// <summary>
        /// SP管理员查询企业
        ///
        /// 获取企业。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCorpResponse> ShowCorpAsync(ShowCorpRequest showCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpResponse>(response);
        }

        public AsyncInvoker<ShowCorpResponse> ShowCorpAsyncInvoker(ShowCorpRequest showCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpRequest);
            return new AsyncInvoker<ShowCorpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpResponse>);
        }
        
        /// <summary>
        /// 查询企业管理员
        ///
        /// 通过该接口查询企业管理员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCorpAdminResponse> ShowCorpAdminAsync(ShowCorpAdminRequest showCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCorpAdminRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpAdminRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpAdminResponse>(response);
        }

        public AsyncInvoker<ShowCorpAdminResponse> ShowCorpAdminAsyncInvoker(ShowCorpAdminRequest showCorpAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCorpAdminRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/admin/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpAdminRequest);
            return new AsyncInvoker<ShowCorpAdminResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpAdminResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业注册信息
        ///
        /// 企业管理员通过该接口查询企业注册信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCorpBasicInfoResponse> ShowCorpBasicInfoAsync(ShowCorpBasicInfoRequest showCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpBasicInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpBasicInfoResponse>(response);
        }

        public AsyncInvoker<ShowCorpBasicInfoResponse> ShowCorpBasicInfoAsyncInvoker(ShowCorpBasicInfoRequest showCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpBasicInfoRequest);
            return new AsyncInvoker<ShowCorpBasicInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpBasicInfoResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业内资源及业务权限
        ///
        /// 企业管理员通过该接口查询企业内资源及业务权限，包括查询已使用的资源情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCorpResourceResponse> ShowCorpResourceAsync(ShowCorpResourceRequest showCorpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCorpResourceResponse>(response);
        }

        public AsyncInvoker<ShowCorpResourceResponse> ShowCorpResourceAsyncInvoker(ShowCorpResourceRequest showCorpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCorpResourceRequest);
            return new AsyncInvoker<ShowCorpResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCorpResourceResponse>);
        }
        
        /// <summary>
        /// 通过部门编码查询部门信息
        ///
        /// 通过部门编码查询部门信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDepartmentResponse> ShowDepartmentAsync(ShowDepartmentRequest showDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/departments/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDepartmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDepartmentResponse>(response);
        }

        public AsyncInvoker<ShowDepartmentResponse> ShowDepartmentAsyncInvoker(ShowDepartmentRequest showDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/abs/departments/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDepartmentRequest);
            return new AsyncInvoker<ShowDepartmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDepartmentResponse>);
        }
        
        /// <summary>
        /// 查询部门及其一级子部门列表
        ///
        /// 企业管理员通过该接口查询部门及其一级子部门列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeptAndChildDeptResponse> ShowDeptAndChildDeptAsync(ShowDeptAndChildDeptRequest showDeptAndChildDeptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeptAndChildDeptRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeptAndChildDeptRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeptAndChildDeptResponse>(response);
        }

        public AsyncInvoker<ShowDeptAndChildDeptResponse> ShowDeptAndChildDeptAsyncInvoker(ShowDeptAndChildDeptRequest showDeptAndChildDeptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeptAndChildDeptRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeptAndChildDeptRequest);
            return new AsyncInvoker<ShowDeptAndChildDeptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeptAndChildDeptResponse>);
        }
        
        /// <summary>
        /// 查询终端详情
        ///
        /// 企业管理员通过该接口查询专业会议终端详情。
        /// &gt; 如果需要查询Ideahub、SmartRooms、智慧屏TV详情请使用[[查询用户详情](https://support.huaweicloud.com/api-meeting/meeting_21_0069.html)](tag:hws)[[查询用户详情](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0069.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceDetailResponse> ShowDeviceDetailAsync(ShowDeviceDetailRequest showDeviceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceDetailRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceDetailResponse>(response);
        }

        public AsyncInvoker<ShowDeviceDetailResponse> ShowDeviceDetailAsyncInvoker(ShowDeviceDetailRequest showDeviceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceDetailRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceDetailRequest);
            return new AsyncInvoker<ShowDeviceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceDetailResponse>);
        }
        
        /// <summary>
        /// 查询设备状态
        ///
        /// 调用本接口可以查询硬终端的状态。
        /// 硬终端与发起查询请求的帐号需在同一企业下，否则会鉴权失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeviceStatusResponse> ShowDeviceStatusAsync(ShowDeviceStatusRequest showDeviceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/ap/userstatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var showDeviceStatusResponse = JsonUtils.DeSerializeNull<ShowDeviceStatusResponse>(response);
            showDeviceStatusResponse.Body = JsonUtils.DeSerializeList<UserStatusDTO>(response);
            return showDeviceStatusResponse;
        }

        public AsyncInvoker<ShowDeviceStatusResponse> ShowDeviceStatusAsyncInvoker(ShowDeviceStatusRequest showDeviceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/ap/userstatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceStatusRequest);
            return new AsyncInvoker<ShowDeviceStatusResponse>(this, "POST", request, response =>
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
        public async Task<ShowDeviceTypesResponse> ShowDeviceTypesAsync(ShowDeviceTypesRequest showDeviceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/termdevtype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showDeviceTypesResponse = JsonUtils.DeSerializeNull<ShowDeviceTypesResponse>(response);
            showDeviceTypesResponse.Body = JsonUtils.DeSerializeList<QueryDeviceTypeResultDTO>(response);
            return showDeviceTypesResponse;
        }

        public AsyncInvoker<ShowDeviceTypesResponse> ShowDeviceTypesAsyncInvoker(ShowDeviceTypesRequest showDeviceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/termdevtype", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTypesRequest);
            return new AsyncInvoker<ShowDeviceTypesResponse>(this, "GET", request, response =>
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
        public async Task<ShowHisMeetingDetailResponse> ShowHisMeetingDetailAsync(ShowHisMeetingDetailRequest showHisMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHisMeetingDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHisMeetingDetailResponse>(response);
        }

        public AsyncInvoker<ShowHisMeetingDetailResponse> ShowHisMeetingDetailAsyncInvoker(ShowHisMeetingDetailRequest showHisMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/history/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHisMeetingDetailRequest);
            return new AsyncInvoker<ShowHisMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHisMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 查询多画面布局
        ///
        /// 该接口用于查询当前会议已保存的多画面布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLayoutResponse> ShowLayoutAsync(ShowLayoutRequest showLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLayoutRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLayoutResponse>(response);
        }

        public AsyncInvoker<ShowLayoutResponse> ShowLayoutAsyncInvoker(ShowLayoutRequest showLayoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/layOut", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLayoutRequest);
            return new AsyncInvoker<ShowLayoutResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLayoutResponse>);
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
        public async Task<ShowMeetingDetailResponse> ShowMeetingDetailAsync(ShowMeetingDetailRequest showMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMeetingDetailResponse>(response);
        }

        public AsyncInvoker<ShowMeetingDetailResponse> ShowMeetingDetailAsyncInvoker(ShowMeetingDetailRequest showMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingDetailRequest);
            return new AsyncInvoker<ShowMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 查询会议纪要详情
        ///
        /// 用户查询单个会议纪要详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMeetingFileResponse> ShowMeetingFileAsync(ShowMeetingFileRequest showMeetingFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMeetingFileRequest.FileCode, out var valueOfFileCode)) urlParam.Add("file_code", valueOfFileCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/{file_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMeetingFileResponse>(response);
        }

        public AsyncInvoker<ShowMeetingFileResponse> ShowMeetingFileAsyncInvoker(ShowMeetingFileRequest showMeetingFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMeetingFileRequest.FileCode, out var valueOfFileCode)) urlParam.Add("file_code", valueOfFileCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/{file_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileRequest);
            return new AsyncInvoker<ShowMeetingFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeetingFileResponse>);
        }
        
        /// <summary>
        /// 打开会议纪要文件列表
        ///
        /// 用户使用手机扫码后，手机端请求服务端,让服务端通知指定IdeaHub打开指定用户的会议纪要文件列表。二维码内容 ：cloudlink://cloudlink.huawei.com/h5page?action&#x3D;OPEN_MEETING_FILE_LIST&amp;key1&#x3D;value1&amp;key2&#x3D;value2 。key/value的个数可能变化，终端解析后，在发起后续请求时，将所有key/value存为map，作为入参即可。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMeetingFileListResponse> ShowMeetingFileListAsync(ShowMeetingFileListRequest showMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/open-meeting-file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ShowMeetingFileListResponse>(response);
        }

        public AsyncInvoker<ShowMeetingFileListResponse> ShowMeetingFileListAsyncInvoker(ShowMeetingFileListRequest showMeetingFileListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/meeting-files/open-meeting-file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeetingFileListRequest);
            return new AsyncInvoker<ShowMeetingFileListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ShowMeetingFileListResponse>);
        }
        
        /// <summary>
        /// 查询会管状态
        ///
        /// 终端通过会控查询会管状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMgmtSiteStatusResponse> ShowMgmtSiteStatusAsync(ShowMgmtSiteStatusRequest showMgmtSiteStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/confmaintain/queryMgmtSiteStatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMgmtSiteStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMgmtSiteStatusResponse>(response);
        }

        public AsyncInvoker<ShowMgmtSiteStatusResponse> ShowMgmtSiteStatusAsyncInvoker(ShowMgmtSiteStatusRequest showMgmtSiteStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/confmaintain/queryMgmtSiteStatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMgmtSiteStatusRequest);
            return new AsyncInvoker<ShowMgmtSiteStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMgmtSiteStatusResponse>);
        }
        
        /// <summary>
        /// 用户查询自己的信息
        ///
        /// 企业用户通过该接口查询自己的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMyInfoResponse> ShowMyInfoAsync(ShowMyInfoRequest showMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMyInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMyInfoResponse>(response);
        }

        public AsyncInvoker<ShowMyInfoResponse> ShowMyInfoAsyncInvoker(ShowMyInfoRequest showMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMyInfoRequest);
            return new AsyncInvoker<ShowMyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMyInfoResponse>);
        }
        
        /// <summary>
        /// 查询在线会议详情
        ///
        /// 该接口用于查询正在召开的会议详情。管理员可以查询本企业内所有的在线会议详情，普通用户仅能查询自己帐号创建或者需要参加的在线会议详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOnlineMeetingDetailResponse> ShowOnlineMeetingDetailAsync(ShowOnlineMeetingDetailRequest showOnlineMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOnlineMeetingDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOnlineMeetingDetailResponse>(response);
        }

        public AsyncInvoker<ShowOnlineMeetingDetailResponse> ShowOnlineMeetingDetailAsyncInvoker(ShowOnlineMeetingDetailRequest showOnlineMeetingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/online/confDetail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOnlineMeetingDetailRequest);
            return new AsyncInvoker<ShowOnlineMeetingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOnlineMeetingDetailResponse>);
        }
        
        /// <summary>
        /// 企业管理员查询企业资源使用信息
        ///
        /// 企业管理员查询所属企业的资源使用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrgResResponse> ShowOrgResAsync(ShowOrgResRequest showOrgResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/orgRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrgResRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrgResResponse>(response);
        }

        public AsyncInvoker<ShowOrgResResponse> ShowOrgResAsyncInvoker(ShowOrgResRequest showOrgResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/orgRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrgResRequest);
            return new AsyncInvoker<ShowOrgResResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrgResResponse>);
        }
        
        /// <summary>
        /// 根据ID查询节目详情
        ///
        /// 根据ID获取节目详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProgramResponse> ShowProgramAsync(ShowProgramRequest showProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgramRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgramRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProgramResponse>(response);
        }

        public AsyncInvoker<ShowProgramResponse> ShowProgramAsyncInvoker(ShowProgramRequest showProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgramRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgramRequest);
            return new AsyncInvoker<ShowProgramResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgramResponse>);
        }
        
        /// <summary>
        /// 根据ID查询信息窗发布详情
        ///
        /// 根据ID获取发布详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicationResponse> ShowPublicationAsync(ShowPublicationRequest showPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicationResponse>(response);
        }

        public AsyncInvoker<ShowPublicationResponse> ShowPublicationAsyncInvoker(ShowPublicationRequest showPublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicationRequest);
            return new AsyncInvoker<ShowPublicationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicationResponse>);
        }
        
        /// <summary>
        /// 查询会议实时信息
        ///
        /// 该接口用于查询正在召开的会议实时信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRealTimeInfoOfMeetingResponse> ShowRealTimeInfoOfMeetingAsync(ShowRealTimeInfoOfMeetingRequest showRealTimeInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/realTimeInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealTimeInfoOfMeetingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRealTimeInfoOfMeetingResponse>(response);
        }

        public AsyncInvoker<ShowRealTimeInfoOfMeetingResponse> ShowRealTimeInfoOfMeetingAsyncInvoker(ShowRealTimeInfoOfMeetingRequest showRealTimeInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/realTimeInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealTimeInfoOfMeetingRequest);
            return new AsyncInvoker<ShowRealTimeInfoOfMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRealTimeInfoOfMeetingResponse>);
        }
        
        /// <summary>
        /// 查询单会议录制文件信息
        ///
        /// 查询单会议录制文件信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordInfoResponse> ShowRecordInfoAsync(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/rlm/record/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowRecordInfoResponse>(response);
        }

        public AsyncInvoker<ShowRecordInfoResponse> ShowRecordInfoAsyncInvoker(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/rlm/record/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            return new AsyncInvoker<ShowRecordInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRecordInfoResponse>);
        }
        
        /// <summary>
        /// 查询录制详情
        ///
        /// 改接口用于查询某个会议录制的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordingDetailResponse> ShowRecordingDetailAsync(ShowRecordingDetailRequest showRecordingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordingDetailResponse>(response);
        }

        public AsyncInvoker<ShowRecordingDetailResponse> ShowRecordingDetailAsyncInvoker(ShowRecordingDetailRequest showRecordingDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/record/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingDetailRequest);
            return new AsyncInvoker<ShowRecordingDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordingDetailResponse>);
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
        public async Task<ShowRecordingFileDownloadUrlsResponse> ShowRecordingFileDownloadUrlsAsync(ShowRecordingFileDownloadUrlsRequest showRecordingFileDownloadUrlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/downloadurls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingFileDownloadUrlsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordingFileDownloadUrlsResponse>(response);
        }

        public AsyncInvoker<ShowRecordingFileDownloadUrlsResponse> ShowRecordingFileDownloadUrlsAsyncInvoker(ShowRecordingFileDownloadUrlsRequest showRecordingFileDownloadUrlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/record/downloadurls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordingFileDownloadUrlsRequest);
            return new AsyncInvoker<ShowRecordingFileDownloadUrlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordingFileDownloadUrlsResponse>);
        }
        
        /// <summary>
        /// 查询会议所在区域信息
        ///
        /// 该接口用于查询会议所在区域的IP和域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRegionInfoOfMeetingResponse> ShowRegionInfoOfMeetingAsync(ShowRegionInfoOfMeetingRequest showRegionInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/region/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegionInfoOfMeetingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRegionInfoOfMeetingResponse>(response);
        }

        public AsyncInvoker<ShowRegionInfoOfMeetingResponse> ShowRegionInfoOfMeetingAsyncInvoker(ShowRegionInfoOfMeetingRequest showRegionInfoOfMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/region/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegionInfoOfMeetingRequest);
            return new AsyncInvoker<ShowRegionInfoOfMeetingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRegionInfoOfMeetingResponse>);
        }
        
        /// <summary>
        /// 查询网络研讨会高级设置
        ///
        /// 该接口用于查询指定网络研讨会的高级设置。管理员可查询企业内的网络研讨会高级设置，非管理员只可查询自己预定的网络研讨会的高级设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRoomSettingResponse> ShowRoomSettingAsync(ShowRoomSettingRequest showRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoomSettingRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoomSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRoomSettingResponse>(response);
        }

        public AsyncInvoker<ShowRoomSettingResponse> ShowRoomSettingAsyncInvoker(ShowRoomSettingRequest showRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoomSettingRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoomSettingRequest);
            return new AsyncInvoker<ShowRoomSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoomSettingResponse>);
        }
        
        /// <summary>
        /// SP管理员查询SP下资源使用信息
        ///
        /// SP管理员查询所属SP的共享资源使用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSpResResponse> ShowSpResAsync(ShowSpResRequest showSpResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/spRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSpResResponse>(response);
        }

        public AsyncInvoker<ShowSpResResponse> ShowSpResAsyncInvoker(ShowSpResRequest showSpResRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/spRes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResRequest);
            return new AsyncInvoker<ShowSpResResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpResResponse>);
        }
        
        /// <summary>
        /// SP管理员查询资源信息
        ///
        /// SP管理员查询SP的所有资源，包括已使用的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSpResourceResponse> ShowSpResourceAsync(ShowSpResourceRequest showSpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSpResourceResponse>(response);
        }

        public AsyncInvoker<ShowSpResourceResponse> ShowSpResourceAsyncInvoker(ShowSpResourceRequest showSpResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpResourceRequest);
            return new AsyncInvoker<ShowSpResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpResourceResponse>);
        }
        
        /// <summary>
        /// 查询SSO登录配置
        ///
        /// 该接口用于查询SSO登录的鉴权配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSsoConfigResponse> ShowSsoConfigAsync(ShowSsoConfigRequest showSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSsoConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSsoConfigResponse>(response);
        }

        public AsyncInvoker<ShowSsoConfigResponse> ShowSsoConfigAsyncInvoker(ShowSsoConfigRequest showSsoConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/authorizeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSsoConfigRequest);
            return new AsyncInvoker<ShowSsoConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSsoConfigResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 企业管理员通过该接口查询企业用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserDetailResponse> ShowUserDetailAsync(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserDetailRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserDetailResponse>(response);
        }

        public AsyncInvoker<ShowUserDetailResponse> ShowUserDetailAsyncInvoker(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserDetailRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            return new AsyncInvoker<ShowUserDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserDetailResponse>);
        }
        
        /// <summary>
        /// 查询事件推送
        ///
        /// 该接口用于管理员查询企业事件订阅配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWebHookConfigResponse> ShowWebHookConfigAsync(ShowWebHookConfigRequest showWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebHookConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWebHookConfigResponse>(response);
        }

        public AsyncInvoker<ShowWebHookConfigResponse> ShowWebHookConfigAsyncInvoker(ShowWebHookConfigRequest showWebHookConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/link-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebHookConfigRequest);
            return new AsyncInvoker<ShowWebHookConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWebHookConfigResponse>);
        }
        
        /// <summary>
        /// 查询网络研讨会详情
        ///
        /// 该接口用于查询指定网络研讨会的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWebinarResponse> ShowWebinarAsync(ShowWebinarRequest showWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWebinarRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebinarRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWebinarResponse>(response);
        }

        public AsyncInvoker<ShowWebinarResponse> ShowWebinarAsyncInvoker(ShowWebinarRequest showWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWebinarRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWebinarRequest);
            return new AsyncInvoker<ShowWebinarResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWebinarResponse>);
        }
        
        /// <summary>
        /// 激活会议
        ///
        /// 该接口用于通过会议ID和会议密码激活会议。所有的会控接口都需要在会议激活后才能调用，可以通过该接口先激活会议。
        /// &gt; 来宾密码是否可以激活会议取决于会议创建时是否设置了“是否允许来宾启动会议”（allowGuestStartConf&#x3D;true）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartMeetingResponse> StartMeetingAsync(StartMeetingRequest startMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startMeetingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartMeetingResponse>(response);
        }

        public AsyncInvoker<StartMeetingResponse> StartMeetingAsyncInvoker(StartMeetingRequest startMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startMeetingRequest);
            return new AsyncInvoker<StartMeetingResponse>(this, "POST", request, JsonUtils.DeSerialize<StartMeetingResponse>);
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
        public async Task<StopMeetingResponse> StopMeetingAsync(StopMeetingRequest stopMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<StopMeetingResponse>(response);
        }

        public AsyncInvoker<StopMeetingResponse> StopMeetingAsyncInvoker(StopMeetingRequest stopMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMeetingRequest);
            return new AsyncInvoker<StopMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<StopMeetingResponse>);
        }
        
        /// <summary>
        /// 切换视频显示策略
        ///
        /// 该接口用于切换会中视频画面显示策略，包括广播多画面，广播单画面，声控多画面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchModeResponse> SwitchModeAsync(SwitchModeRequest switchModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchModeResponse>(response);
        }

        public AsyncInvoker<SwitchModeResponse> SwitchModeAsyncInvoker(SwitchModeRequest switchModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/display/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchModeRequest);
            return new AsyncInvoker<SwitchModeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchModeResponse>);
        }
        
        /// <summary>
        /// 修改企业应用
        ///
        /// 企业默认管理员修改企业应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppIdResponse> UpdateAppIdAsync(UpdateAppIdRequest updateAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAppIdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppIdResponse>(response);
        }

        public AsyncInvoker<UpdateAppIdResponse> UpdateAppIdAsyncInvoker(UpdateAppIdRequest updateAppIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/usg/acs/corp/app/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAppIdRequest);
            return new AsyncInvoker<UpdateAppIdResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppIdResponse>);
        }
        
        /// <summary>
        /// 修改手机或邮箱
        ///
        /// 企业用户通过该接口修改手机或邮箱，需要先获取验证码，验证多次失败会禁止修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest updateContactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/contact", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateContactRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateContactResponse>(response);
        }

        public AsyncInvoker<UpdateContactResponse> UpdateContactAsyncInvoker(UpdateContactRequest updateContactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/contact", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateContactRequest);
            return new AsyncInvoker<UpdateContactResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateContactResponse>);
        }
        
        /// <summary>
        /// SP管理员修改企业
        ///
        /// 修改企业，若任一参数为null或者不携带则不修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCorpResponse> UpdateCorpAsync(UpdateCorpRequest updateCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateCorpResponse>(response);
        }

        public AsyncInvoker<UpdateCorpResponse> UpdateCorpAsyncInvoker(UpdateCorpRequest updateCorpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCorpRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpRequest);
            return new AsyncInvoker<UpdateCorpResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCorpResponse>);
        }
        
        /// <summary>
        /// 企业管理员修改企业注册信息
        ///
        /// 企业管理员通过该接口修改企业注册信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCorpBasicInfoResponse> UpdateCorpBasicInfoAsync(UpdateCorpBasicInfoRequest updateCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpBasicInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateCorpBasicInfoResponse>(response);
        }

        public AsyncInvoker<UpdateCorpBasicInfoResponse> UpdateCorpBasicInfoAsyncInvoker(UpdateCorpBasicInfoRequest updateCorpBasicInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCorpBasicInfoRequest);
            return new AsyncInvoker<UpdateCorpBasicInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCorpBasicInfoResponse>);
        }
        
        /// <summary>
        /// 修改部门
        ///
        /// 企业管理员通过该接口修改部门。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDepartmentResponse> UpdateDepartmentAsync(UpdateDepartmentRequest updateDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDepartmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDepartmentResponse>(response);
        }

        public AsyncInvoker<UpdateDepartmentResponse> UpdateDepartmentAsyncInvoker(UpdateDepartmentRequest updateDepartmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDepartmentRequest.DeptCode, out var valueOfDeptCode)) urlParam.Add("dept_code", valueOfDeptCode);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/dept/{dept_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDepartmentRequest);
            return new AsyncInvoker<UpdateDepartmentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDepartmentResponse>);
        }
        
        /// <summary>
        /// 修改终端
        ///
        /// 企业管理员通过该接口修改专业会议终端。
        /// &gt; 如果需要修改Ideahub、SmartRooms、智慧屏TV请使用[[修改用户](https://support.huaweicloud.com/api-meeting/meeting_21_0068.html)](tag:hws)[[修改用户](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0068.html)](tag:hk)接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDeviceResponse>(response);
        }

        public AsyncInvoker<UpdateDeviceResponse> UpdateDeviceAsyncInvoker(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceRequest.Sn, out var valueOfSn)) urlParam.Add("sn", valueOfSn);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/device/{sn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            return new AsyncInvoker<UpdateDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDeviceResponse>);
        }
        
        /// <summary>
        /// 更新信息窗素材
        ///
        /// 更新信息窗素材。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMaterialResponse> UpdateMaterialAsync(UpdateMaterialRequest updateMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMaterialRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMaterialRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMaterialResponse>(response);
        }

        public AsyncInvoker<UpdateMaterialResponse> UpdateMaterialAsyncInvoker(UpdateMaterialRequest updateMaterialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMaterialRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/materials/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMaterialRequest);
            return new AsyncInvoker<UpdateMaterialResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMaterialResponse>);
        }
        
        /// <summary>
        /// 编辑预约会议
        ///
        /// 该接口用于修改已预约的会议。会议开始后，不能被修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMeetingResponse> UpdateMeetingAsync(UpdateMeetingRequest updateMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateMeetingResponse = JsonUtils.DeSerializeNull<UpdateMeetingResponse>(response);
            updateMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return updateMeetingResponse;
        }

        public AsyncInvoker<UpdateMeetingResponse> UpdateMeetingAsyncInvoker(UpdateMeetingRequest updateMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMeetingRequest);
            return new AsyncInvoker<UpdateMeetingResponse>(this, "PUT", request, response =>
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
        public async Task<UpdateMemberVmrResponse> UpdateMemberVmrAsync(UpdateMemberVmrRequest updateMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberVmrRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberVmrRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMemberVmrResponse>(response);
        }

        public AsyncInvoker<UpdateMemberVmrResponse> UpdateMemberVmrAsyncInvoker(UpdateMemberVmrRequest updateMemberVmrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberVmrRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member/vmr/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberVmrRequest);
            return new AsyncInvoker<UpdateMemberVmrResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMemberVmrResponse>);
        }
        
        /// <summary>
        /// 用户修改自己的信息
        ///
        /// 企业用户通过该接口修改自己的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMyInfoResponse> UpdateMyInfoAsync(UpdateMyInfoRequest updateMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMyInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMyInfoResponse>(response);
        }

        public AsyncInvoker<UpdateMyInfoResponse> UpdateMyInfoAsyncInvoker(UpdateMyInfoRequest updateMyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMyInfoRequest);
            return new AsyncInvoker<UpdateMyInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMyInfoResponse>);
        }
        
        /// <summary>
        /// 更新信息窗节目
        ///
        /// 更新信息窗节目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProgramResponse> UpdateProgramAsync(UpdateProgramRequest updateProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProgramRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProgramRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProgramResponse>(response);
        }

        public AsyncInvoker<UpdateProgramResponse> UpdateProgramAsyncInvoker(UpdateProgramRequest updateProgramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProgramRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/programs/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProgramRequest);
            return new AsyncInvoker<UpdateProgramResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProgramResponse>);
        }
        
        /// <summary>
        /// 修改信息窗发布
        ///
        /// 修改信息窗发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicationResponse> UpdatePublicationAsync(UpdatePublicationRequest updatePublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePublicationResponse>(response);
        }

        public AsyncInvoker<UpdatePublicationResponse> UpdatePublicationAsyncInvoker(UpdatePublicationRequest updatePublicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/sss/publications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicationRequest);
            return new AsyncInvoker<UpdatePublicationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePublicationResponse>);
        }
        
        /// <summary>
        /// 修改密码
        ///
        /// 企业成员通过该接口提供用户修改密码功能，服务器收到请求，修改用户密码并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePwdResponse> UpdatePwdAsync(UpdatePwdRequest updatePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePwdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePwdResponse>(response);
        }

        public AsyncInvoker<UpdatePwdResponse> UpdatePwdAsyncInvoker(UpdatePwdRequest updatePwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePwdRequest);
            return new AsyncInvoker<UpdatePwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePwdResponse>);
        }
        
        /// <summary>
        /// 编辑周期性会议
        ///
        /// 该接口用于修改已预约的周期性会议。会议开始后，不能被修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecurringMeetingResponse> UpdateRecurringMeetingAsync(UpdateRecurringMeetingRequest updateRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateRecurringMeetingResponse = JsonUtils.DeSerializeNull<UpdateRecurringMeetingResponse>(response);
            updateRecurringMeetingResponse.Body = JsonUtils.DeSerializeList<ConferenceInfo>(response);
            return updateRecurringMeetingResponse;
        }

        public AsyncInvoker<UpdateRecurringMeetingResponse> UpdateRecurringMeetingAsyncInvoker(UpdateRecurringMeetingRequest updateRecurringMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/cycleconferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringMeetingRequest);
            return new AsyncInvoker<UpdateRecurringMeetingResponse>(this, "PUT", request, response =>
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
        public async Task<UpdateRecurringSubMeetingResponse> UpdateRecurringSubMeetingAsync(UpdateRecurringSubMeetingRequest updateRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringSubMeetingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRecurringSubMeetingResponse>(response);
        }

        public AsyncInvoker<UpdateRecurringSubMeetingResponse> UpdateRecurringSubMeetingAsyncInvoker(UpdateRecurringSubMeetingRequest updateRecurringSubMeetingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/conferences/cyclesubconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecurringSubMeetingRequest);
            return new AsyncInvoker<UpdateRecurringSubMeetingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRecurringSubMeetingResponse>);
        }
        
        /// <summary>
        /// SP管理员根据修改企业资源
        ///
        /// 企业修改资源的过期时间、停用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest updateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceResponse>(response);
        }

        public AsyncInvoker<UpdateResourceResponse> UpdateResourceAsyncInvoker(UpdateResourceRequest updateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceRequest.CorpId, out var valueOfCorpId)) urlParam.Add("corp_id", valueOfCorpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/sp/corp/{corp_id}/resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceRequest);
            return new AsyncInvoker<UpdateResourceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceResponse>);
        }
        
        /// <summary>
        /// 修改网络研讨会高级设置
        ///
        /// 该接口用于设置指定网络研讨会的高级设置。管理员可设置企业内的网络研讨会高级设置，非管理员只可设置自己预定的网络研讨会的高级设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRoomSettingResponse> UpdateRoomSettingAsync(UpdateRoomSettingRequest updateRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoomSettingRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoomSettingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateRoomSettingResponse>(response);
        }

        public AsyncInvoker<UpdateRoomSettingResponse> UpdateRoomSettingAsyncInvoker(UpdateRoomSettingRequest updateRoomSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoomSettingRequest.ConferenceId, out var valueOfConferenceId)) urlParam.Add("conference_id", valueOfConferenceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/room-setting/{conference_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoomSettingRequest);
            return new AsyncInvoker<UpdateRoomSettingResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateRoomSettingResponse>);
        }
        
        /// <summary>
        /// 会中修改配置
        ///
        /// 该接口用于修改会议配置，包括会议共享是否锁定，允许呼入范围。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStartedConfConfigResponse> UpdateStartedConfConfigAsync(UpdateStartedConfConfigRequest updateStartedConfConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/updateStartedConfConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartedConfConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStartedConfConfigResponse>(response);
        }

        public AsyncInvoker<UpdateStartedConfConfigResponse> UpdateStartedConfConfigAsyncInvoker(UpdateStartedConfConfigRequest updateStartedConfConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/control/conferences/updateStartedConfConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartedConfConfigRequest);
            return new AsyncInvoker<UpdateStartedConfConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStartedConfConfigResponse>);
        }
        
        /// <summary>
        /// 刷新Token
        ///
        /// 该接口提供刷新Token功能，根据传入的Token，刷新Token失效时间并返回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTokenResponse> UpdateTokenAsync(UpdateTokenRequest updateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTokenRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTokenResponse>(response);
        }

        public AsyncInvoker<UpdateTokenResponse> UpdateTokenAsyncInvoker(UpdateTokenRequest updateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/acs/token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTokenRequest);
            return new AsyncInvoker<UpdateTokenResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTokenResponse>);
        }
        
        /// <summary>
        /// 修改用户
        ///
        /// 企业管理员通过该接口修改企业用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.Account, out var valueOfAccount)) urlParam.Add("account", valueOfAccount);
            var urlPath = HttpUtils.AddUrlPath("/v1/usg/dcs/corp/member/{account}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 开启事件推送
        ///
        /// 该接口用于管理员变更订阅配置使用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWebHookConfigStatusResponse> UpdateWebHookConfigStatusAsync(UpdateWebHookConfigStatusRequest updateWebHookConfigStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebHookConfigStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWebHookConfigStatusResponse>(response);
        }

        public AsyncInvoker<UpdateWebHookConfigStatusResponse> UpdateWebHookConfigStatusAsyncInvoker(UpdateWebHookConfigStatusRequest updateWebHookConfigStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mmc/management/webhook/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebHookConfigStatusRequest);
            return new AsyncInvoker<UpdateWebHookConfigStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWebHookConfigStatusResponse>);
        }
        
        /// <summary>
        /// 编辑网络研讨会
        ///
        /// 该接口用于修改已创建的网络研讨会。网络研讨会开始后不能修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWebinarResponse> UpdateWebinarAsync(UpdateWebinarRequest updateWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebinarRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWebinarResponse>(response);
        }

        public AsyncInvoker<UpdateWebinarResponse> UpdateWebinarAsyncInvoker(UpdateWebinarRequest updateWebinarRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/conferences", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWebinarRequest);
            return new AsyncInvoker<UpdateWebinarResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWebinarResponse>);
        }
        
        /// <summary>
        /// 上传图片
        ///
        /// 该接口用户上传网络研讨会高级设置用的图片。图片可用于网络研讨会的封面和Logo。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadFileResponse> UploadFileAsync(UploadFileRequest uploadFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/res/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadFileRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UploadFileResponse>(response);
        }

        public AsyncInvoker<UploadFileResponse> UploadFileAsyncInvoker(UploadFileRequest uploadFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/wss/webinar/open/res/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadFileRequest);
            return new AsyncInvoker<UploadFileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UploadFileResponse>);
        }
        
        /// <summary>
        /// 查询QoS历史会议列表
        ///
        /// 该接口用于查询企业内历史会议的QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。可以查询最近3个月内的数据。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQosHistoryMeetingsResponse> SearchQosHistoryMeetingsAsync(SearchQosHistoryMeetingsRequest searchQosHistoryMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosHistoryMeetingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQosHistoryMeetingsResponse>(response);
        }

        public AsyncInvoker<SearchQosHistoryMeetingsResponse> SearchQosHistoryMeetingsAsyncInvoker(SearchQosHistoryMeetingsRequest searchQosHistoryMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosHistoryMeetingsRequest);
            return new AsyncInvoker<SearchQosHistoryMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosHistoryMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询QoS在线会议列表
        ///
        /// 该接口用于查询企业内正在召开会议的QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQosOnlineMeetingsResponse> SearchQosOnlineMeetingsAsync(SearchQosOnlineMeetingsRequest searchQosOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosOnlineMeetingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQosOnlineMeetingsResponse>(response);
        }

        public AsyncInvoker<SearchQosOnlineMeetingsResponse> SearchQosOnlineMeetingsAsyncInvoker(SearchQosOnlineMeetingsRequest searchQosOnlineMeetingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conferences/online", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosOnlineMeetingsRequest);
            return new AsyncInvoker<SearchQosOnlineMeetingsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosOnlineMeetingsResponse>);
        }
        
        /// <summary>
        /// 查询与会者的QoS数据
        ///
        /// 该接口用于查询企业内在线会议或历史会议的与会者QoS数据。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQosParticipantDetailResponse> SearchQosParticipantDetailAsync(SearchQosParticipantDetailRequest searchQosParticipantDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participant/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQosParticipantDetailResponse>(response);
        }

        public AsyncInvoker<SearchQosParticipantDetailResponse> SearchQosParticipantDetailAsyncInvoker(SearchQosParticipantDetailRequest searchQosParticipantDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participant/qos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantDetailRequest);
            return new AsyncInvoker<SearchQosParticipantDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosParticipantDetailResponse>);
        }
        
        /// <summary>
        /// 查询QoS会议与会者列表
        ///
        /// 该接口用于查询企业内在线会议或历史会议的与会者QoS告警。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQosParticipantsResponse> SearchQosParticipantsAsync(SearchQosParticipantsRequest searchQosParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQosParticipantsResponse>(response);
        }

        public AsyncInvoker<SearchQosParticipantsResponse> SearchQosParticipantsAsyncInvoker(SearchQosParticipantsRequest searchQosParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQosParticipantsRequest);
            return new AsyncInvoker<SearchQosParticipantsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQosParticipantsResponse>);
        }
        
        /// <summary>
        /// 设置QoS告警阈值
        ///
        /// 该接口用于设置QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限设置。
        /// &gt; 仪表盘的QoS统计功能需要申请才能开通。请联系华为销售人员，并提供华为云会议企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetQosThresholdResponse> SetQosThresholdAsync(SetQosThresholdRequest setQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=utf-8", setQosThresholdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetQosThresholdResponse>(response);
        }

        public AsyncInvoker<SetQosThresholdResponse> SetQosThresholdAsyncInvoker(SetQosThresholdRequest setQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=utf-8", setQosThresholdRequest);
            return new AsyncInvoker<SetQosThresholdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetQosThresholdResponse>);
        }
        
        /// <summary>
        /// 查询QoS告警阈值
        ///
        /// 该接口用于查询QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// &gt; 该接口用于查询QoS告警阈值。仅旗舰版企业/标准版企业的企业管理员有权限查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQosThresholdResponse> ShowQosThresholdAsync(ShowQosThresholdRequest showQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQosThresholdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQosThresholdResponse>(response);
        }

        public AsyncInvoker<ShowQosThresholdResponse> ShowQosThresholdAsyncInvoker(ShowQosThresholdRequest showQosThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/conference/threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQosThresholdRequest);
            return new AsyncInvoker<ShowQosThresholdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQosThresholdResponse>);
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
        public async Task<SearchStatisticConferenceInfoResponse> SearchStatisticConferenceInfoAsync(SearchStatisticConferenceInfoRequest searchStatisticConferenceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticConferenceInfoResponse>(response);
        }

        public AsyncInvoker<SearchStatisticConferenceInfoResponse> SearchStatisticConferenceInfoAsyncInvoker(SearchStatisticConferenceInfoRequest searchStatisticConferenceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceInfoRequest);
            return new AsyncInvoker<SearchStatisticConferenceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticConferenceInfoResponse>);
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
        public async Task<SearchStatisticConferenceParticipantResponse> SearchStatisticConferenceParticipantAsync(SearchStatisticConferenceParticipantRequest searchStatisticConferenceParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/participant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceParticipantRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticConferenceParticipantResponse>(response);
        }

        public AsyncInvoker<SearchStatisticConferenceParticipantResponse> SearchStatisticConferenceParticipantAsyncInvoker(SearchStatisticConferenceParticipantRequest searchStatisticConferenceParticipantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/conference/participant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticConferenceParticipantRequest);
            return new AsyncInvoker<SearchStatisticConferenceParticipantResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticConferenceParticipantResponse>);
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
        public async Task<SearchStatisticResourceInfoResponse> SearchStatisticResourceInfoAsync(SearchStatisticResourceInfoRequest searchStatisticResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/resource/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticResourceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticResourceInfoResponse>(response);
        }

        public AsyncInvoker<SearchStatisticResourceInfoResponse> SearchStatisticResourceInfoAsyncInvoker(SearchStatisticResourceInfoRequest searchStatisticResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/resource/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticResourceInfoRequest);
            return new AsyncInvoker<SearchStatisticResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticResourceInfoResponse>);
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
        public async Task<SearchStatisticUserInfoResponse> SearchStatisticUserInfoAsync(SearchStatisticUserInfoRequest searchStatisticUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticUserInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchStatisticUserInfoResponse>(response);
        }

        public AsyncInvoker<SearchStatisticUserInfoResponse> SearchStatisticUserInfoAsyncInvoker(SearchStatisticUserInfoRequest searchStatisticUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/metrics/dashboard/statistic/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchStatisticUserInfoRequest);
            return new AsyncInvoker<SearchStatisticUserInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchStatisticUserInfoResponse>);
        }
        
    }
}