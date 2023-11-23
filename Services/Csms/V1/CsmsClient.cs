using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Csms.V1.Model;

namespace HuaweiCloud.SDK.Csms.V1
{
    public partial class CsmsClient : Client
    {
        public static ClientBuilder<CsmsClient> NewBuilder()
        {
            return new ClientBuilder<CsmsClient>();
        }

        
        /// <summary>
        /// 批量添加或删除凭据标签
        ///
        /// - 功能介绍：批量添加或删除凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateOrDeleteTagsResponse BatchCreateOrDeleteTags(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , batchCreateOrDeleteTagsRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据
        ///
        /// 创建新的凭据，并将凭据值存入凭据的初始版本。
        /// 
        /// 凭据管理服务将凭据值加密后，存储在凭据对象下的版本中。每个版本可与多个凭据版本状态相关联，凭据版本状态用于标识凭据版本处于的阶段，没有版本状态标记的版本视为已弃用，可用凭据管理服务自动删除。
        /// 
        /// 初始版本的状态被标记为SYSCURRENT。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecretResponse CreateSecret(CreateSecretRequest createSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建事件
        ///
        /// 创建事件，事件可配置在一个或多个凭据对象上。当事件为启用状态且包含的基础事件类型在凭据对象上触发时，云服务会将对应的事件通知发送至事件指定的通知主题上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecretEventResponse CreateSecretEvent(CreateSecretEventRequest createSecretEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretEventResponse>(response);
        }
        
        /// <summary>
        /// 添加凭据标签
        ///
        /// 添加凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecretTagResponse CreateSecretTag(CreateSecretTagRequest createSecretTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , createSecretTagRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateSecretTagResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据版本
        ///
        /// 在指定的凭据中，创建一个新的凭据版本，用于加密保管新的凭据值。默认情况下，新创建的凭据版本被标记为SYSCURRENT状态，而SYSCURRENT标记的前一个凭据版本被标记为SYSPREVIOUS状态。您可以通过指定VersionStage参数来覆盖默认行为。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecretVersionResponse CreateSecretVersion(CreateSecretVersionRequest createSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , createSecretVersionRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 立即删除凭据
        ///
        /// 立即删除指定的凭据，且无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest deleteSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , deleteSecretRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretResponse>(response);
        }
        
        /// <summary>
        /// 立即删除事件
        ///
        /// 立即删除指定的事件，且无法恢复。如事件存在凭据引用，则无法删除，请先解除关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecretEventResponse DeleteSecretEvent(DeleteSecretEventRequest deleteSecretEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name" , deleteSecretEventRequest.EventName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretEventResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据的定时删除任务
        ///
        /// 指定延迟删除时间，创建删除凭据的定时任务，可设置7~30天的的延迟删除时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecretForScheduleResponse DeleteSecretForSchedule(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , deleteSecretForScheduleRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>(response);
        }
        
        /// <summary>
        /// 删除凭据的版本状态
        ///
        /// 删除指定的凭据版本状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecretStageResponse DeleteSecretStage(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , deleteSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name" , deleteSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 删除凭据标签
        ///
        /// 删除凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecretTagResponse DeleteSecretTag(DeleteSecretTagRequest deleteSecretTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretTagRequest.SecretId.ToString());
            urlParam.Add("key" , deleteSecretTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretTagResponse>(response);
        }
        
        /// <summary>
        /// 下载凭据备份
        ///
        /// 下载指定凭据的备份文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadSecretBlobResponse DownloadSecretBlob(DownloadSecretBlobRequest downloadSecretBlobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , downloadSecretBlobRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/backup",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSecretBlobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DownloadSecretBlobResponse>(response);
        }
        
        /// <summary>
        /// 查询已触发的事件通知记录
        ///
        /// 查询三个月内所有已触发的事件通知记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationRecordsResponse ListNotificationRecords(ListNotificationRecordsRequest listNotificationRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/notification-records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationRecordsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationRecordsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询用户在指定项目下的所有凭据标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectSecretsTagsResponse ListProjectSecretsTags(ListProjectSecretsTagsRequest listProjectSecretsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSecretsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectSecretsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据实例
        ///
        /// 查询凭据实例。通过标签过滤，筛选用户凭据，返回凭据列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listResourceInstancesRequest.ResourceInstances.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询事件列表
        ///
        /// 查询当前用户在本项目下创建的所有事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecretEventsResponse ListSecretEvents(ListSecretEventsRequest listSecretEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretEventsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据标签
        ///
        /// 查询凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecretTagsResponse ListSecretTags(ListSecretTagsRequest listSecretTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , listSecretTagsRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本列表
        ///
        /// 查询指定凭据下的版本列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecretVersionsResponse ListSecretVersions(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , listSecretVersionsRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据列表
        ///
        /// 查询当前用户在本项目下创建的所有凭据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecretsResponse ListSecrets(ListSecretsRequest listSecretsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecretsResponse>(response);
        }
        
        /// <summary>
        /// 取消凭据的定时删除任务
        ///
        /// 取消凭据的定时删除任务，凭据对象恢复可使用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreSecretResponse RestoreSecret(RestoreSecretRequest restoreSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , restoreSecretRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/cancel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreSecretResponse>(response);
        }
        
        /// <summary>
        /// 轮转凭据
        ///
        /// 立即执行轮转凭据。在指定的凭据中，创建一个新的凭据版本，用于加密存储后台随机产生的凭据值。同时将新创建的凭据版本标记为SYSCURRENT状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RotateSecretResponse RotateSecret(RotateSecretRequest rotateSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , rotateSecretRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/rotate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", rotateSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RotateSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据
        ///
        /// 查询指定凭据的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretResponse ShowSecret(ShowSecretRequest showSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , showSecretRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询事件
        ///
        /// 查询指定事件的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretEventResponse ShowSecretEvent(ShowSecretEventRequest showSecretEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name" , showSecretEventRequest.EventName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretEventResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本状态
        ///
        /// 查询指定凭据版本状态标记的版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretStageResponse ShowSecretStage(ShowSecretStageRequest showSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , showSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name" , showSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本与凭据值
        ///
        /// 查询指定凭据版本的信息和版本中的明文凭据值，只能查询ENABLED状态的凭据。
        /// 通过/v1/{project_id}/secrets/{secret_name}/versions/latest （即将当前接口URL中的{version_id}赋值为latest）可访问凭据最新版本的凭据值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretVersionResponse ShowSecretVersion(ShowSecretVersionRequest showSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , showSecretVersionRequest.SecretName.ToString());
            urlParam.Add("version_id" , showSecretVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据
        ///
        /// 更新指定凭据的元数据信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest updateSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , updateSecretRequest.SecretName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretResponse>(response);
        }
        
        /// <summary>
        /// 更新事件
        ///
        /// 更新指定事件的元数据信息。支持更新的元数据包含事件启用状态、基础类型列表、通知主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecretEventResponse UpdateSecretEvent(UpdateSecretEventRequest updateSecretEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name" , updateSecretEventRequest.EventName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretEventResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据的版本状态
        ///
        /// 更新凭据的版本状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecretStageResponse UpdateSecretStage(UpdateSecretStageRequest updateSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , updateSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name" , updateSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据版本
        ///
        /// 当前支持更新指定凭据版本的有效期，只能更新ENABLED状态的凭据。在关联订阅的事件包含“版本过期”基础事件类型时，每次更新版本有效期后仅会触发一次事件通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVersionResponse UpdateVersion(UpdateVersionRequest updateVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name" , updateVersionRequest.SecretName.ToString());
            urlParam.Add("version_id" , updateVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVersionResponse>(response);
        }
        
        /// <summary>
        /// 恢复凭据对象
        ///
        /// 通过上传凭据备份文件，恢复凭据对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadSecretBlobResponse UploadSecretBlob(UploadSecretBlobRequest uploadSecretBlobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSecretBlobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadSecretBlobResponse>(response);
        }
        
    }
}