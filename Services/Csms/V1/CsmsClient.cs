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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteTagsRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsInvoker(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteTagsRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            return new SyncInvoker<BatchCreateOrDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 批量导入凭据
        ///
        /// 批量导入凭据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchImportSecretsResponse BatchImportSecrets(BatchImportSecretsRequest batchImportSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchImportSecretsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchImportSecretsResponse>(response);
        }

        public SyncInvoker<BatchImportSecretsResponse> BatchImportSecretsInvoker(BatchImportSecretsRequest batchImportSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchImportSecretsRequest);
            return new SyncInvoker<BatchImportSecretsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchImportSecretsResponse>);
        }
        
        /// <summary>
        /// 检测传入凭据的凭据强度
        ///
        /// 检测传入的凭据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckSecretsResponse CheckSecrets(CheckSecretsRequest checkSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSecretsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckSecretsResponse>(response);
        }

        public SyncInvoker<CheckSecretsResponse> CheckSecretsInvoker(CheckSecretsRequest checkSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkSecretsRequest);
            return new SyncInvoker<CheckSecretsResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckSecretsResponse>);
        }
        
        /// <summary>
        /// 创建服务委托
        ///
        /// 创建服务委托。用于创建凭据管理服务相关委托和函数工作流相关委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAgencyResponse CreateAgency(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }

        public SyncInvoker<CreateAgencyResponse> CreateAgencyInvoker(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            return new SyncInvoker<CreateAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyResponse>);
        }
        
        /// <summary>
        /// 授权操作
        ///
        /// 授权操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGrantsResponse CreateGrants(CreateGrantsRequest createGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGrantsResponse>(response);
        }

        public SyncInvoker<CreateGrantsResponse> CreateGrantsInvoker(CreateGrantsRequest createGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantsRequest);
            return new SyncInvoker<CreateGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGrantsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }

        public SyncInvoker<CreateSecretResponse> CreateSecretInvoker(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            return new SyncInvoker<CreateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretEventRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretEventResponse>(response);
        }

        public SyncInvoker<CreateSecretEventResponse> CreateSecretEventInvoker(CreateSecretEventRequest createSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretEventRequest);
            return new SyncInvoker<CreateSecretEventResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretEventResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecretTagRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSecretTagResponse>(response);
        }

        public SyncInvoker<CreateSecretTagResponse> CreateSecretTagInvoker(CreateSecretTagRequest createSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecretTagRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretTagRequest);
            return new SyncInvoker<CreateSecretTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSecretTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecretVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretVersionResponse>(response);
        }

        public SyncInvoker<CreateSecretVersionResponse> CreateSecretVersionInvoker(CreateSecretVersionRequest createSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecretVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            return new SyncInvoker<CreateSecretVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretVersionResponse>);
        }
        
        /// <summary>
        /// 删除授权
        ///
        /// 删除授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGrantResponse DeleteGrant(DeleteGrantRequest deleteGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGrantRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGrantResponse>(response);
        }

        public SyncInvoker<DeleteGrantResponse> DeleteGrantInvoker(DeleteGrantRequest deleteGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGrantRequest);
            return new SyncInvoker<DeleteGrantResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGrantResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretResponse>(response);
        }

        public SyncInvoker<DeleteSecretResponse> DeleteSecretInvoker(DeleteSecretRequest deleteSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            return new SyncInvoker<DeleteSecretResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretEventRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretEventResponse>(response);
        }

        public SyncInvoker<DeleteSecretEventResponse> DeleteSecretEventInvoker(DeleteSecretEventRequest deleteSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretEventRequest);
            return new SyncInvoker<DeleteSecretEventResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretEventResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretForScheduleRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>(response);
        }

        public SyncInvoker<DeleteSecretForScheduleResponse> DeleteSecretForScheduleInvoker(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretForScheduleRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            return new SyncInvoker<DeleteSecretForScheduleResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretStageResponse>(response);
        }

        public SyncInvoker<DeleteSecretStageResponse> DeleteSecretStageInvoker(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            return new SyncInvoker<DeleteSecretStageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretStageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretTagRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretTagResponse>(response);
        }

        public SyncInvoker<DeleteSecretTagResponse> DeleteSecretTagInvoker(DeleteSecretTagRequest deleteSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretTagRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecretTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretTagRequest);
            return new SyncInvoker<DeleteSecretTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSecretBlobRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSecretBlobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadSecretBlobResponse>(response);
        }

        public SyncInvoker<DownloadSecretBlobResponse> DownloadSecretBlobInvoker(DownloadSecretBlobRequest downloadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSecretBlobRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSecretBlobRequest);
            return new SyncInvoker<DownloadSecretBlobResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSecretBlobResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 生成随机密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GenerateRandomPasswordResponse GenerateRandomPassword(GenerateRandomPasswordRequest generateRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/generate-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateRandomPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<GenerateRandomPasswordResponse>(response);
        }

        public SyncInvoker<GenerateRandomPasswordResponse> GenerateRandomPasswordInvoker(GenerateRandomPasswordRequest generateRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/generate-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateRandomPasswordRequest);
            return new SyncInvoker<GenerateRandomPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<GenerateRandomPasswordResponse>);
        }
        
        /// <summary>
        /// 授权列表
        ///
        /// 授权列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGrantsResponse ListGrants(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGrantsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }

        public SyncInvoker<ListGrantsResponse> ListGrantsInvoker(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGrantsRequest);
            return new SyncInvoker<ListGrantsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGrantsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationRecordsResponse>(response);
        }

        public SyncInvoker<ListNotificationRecordsResponse> ListNotificationRecordsInvoker(ListNotificationRecordsRequest listNotificationRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationRecordsRequest);
            return new SyncInvoker<ListNotificationRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationRecordsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSecretsTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectSecretsTagsResponse>(response);
        }

        public SyncInvoker<ListProjectSecretsTagsResponse> ListProjectSecretsTagsInvoker(ListProjectSecretsTagsRequest listProjectSecretsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSecretsTagsRequest);
            return new SyncInvoker<ListProjectSecretsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectSecretsTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceInstances, out var valueOfResourceInstances)) urlParam.Add("resource_instances", valueOfResourceInstances);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListResourceInstancesResponse> ListResourceInstancesInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceInstances, out var valueOfResourceInstances)) urlParam.Add("resource_instances", valueOfResourceInstances);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new SyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecretEventsResponse>(response);
        }

        public SyncInvoker<ListSecretEventsResponse> ListSecretEventsInvoker(ListSecretEventsRequest listSecretEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretEventsRequest);
            return new SyncInvoker<ListSecretEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretEventsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSecretTagsRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecretTagsResponse>(response);
        }

        public SyncInvoker<ListSecretTagsResponse> ListSecretTagsInvoker(ListSecretTagsRequest listSecretTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSecretTagsRequest.SecretId, out var valueOfSecretId)) urlParam.Add("secret_id", valueOfSecretId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTagsRequest);
            return new SyncInvoker<ListSecretTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretTagsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecretTaskResponse ListSecretTask(ListSecretTaskRequest listSecretTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecretTaskResponse>(response);
        }

        public SyncInvoker<ListSecretTaskResponse> ListSecretTaskInvoker(ListSecretTaskRequest listSecretTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTaskRequest);
            return new SyncInvoker<ListSecretTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSecretVersionsRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecretVersionsResponse>(response);
        }

        public SyncInvoker<ListSecretVersionsResponse> ListSecretVersionsInvoker(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSecretVersionsRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            return new SyncInvoker<ListSecretVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretVersionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecretsResponse>(response);
        }

        public SyncInvoker<ListSecretsResponse> ListSecretsInvoker(ListSecretsRequest listSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            return new SyncInvoker<ListSecretsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretsResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreSecretResponse>(response);
        }

        public SyncInvoker<RestoreSecretResponse> RestoreSecretInvoker(RestoreSecretRequest restoreSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            return new SyncInvoker<RestoreSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreSecretResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rotateSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/rotate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rotateSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RotateSecretResponse>(response);
        }

        public SyncInvoker<RotateSecretResponse> RotateSecretInvoker(RotateSecretRequest rotateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rotateSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/rotate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rotateSecretRequest);
            return new SyncInvoker<RotateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<RotateSecretResponse>);
        }
        
        /// <summary>
        /// 查看是否有服务委托
        ///
        /// 查看是否有服务委托
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAgencyResponse ShowAgency(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public SyncInvoker<ShowAgencyResponse> ShowAgencyInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new SyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretResponse>(response);
        }

        public SyncInvoker<ShowSecretResponse> ShowSecretInvoker(ShowSecretRequest showSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            return new SyncInvoker<ShowSecretResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretEventResponse>(response);
        }

        public SyncInvoker<ShowSecretEventResponse> ShowSecretEventInvoker(ShowSecretEventRequest showSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretEventRequest);
            return new SyncInvoker<ShowSecretEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretEventResponse>);
        }
        
        /// <summary>
        /// 获取凭据轮转函数模板
        ///
        /// 获取凭据轮转函数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretFunctionTemplatesResponse ShowSecretFunctionTemplates(ShowSecretFunctionTemplatesRequest showSecretFunctionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/function-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretFunctionTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretFunctionTemplatesResponse>(response);
        }

        public SyncInvoker<ShowSecretFunctionTemplatesResponse> ShowSecretFunctionTemplatesInvoker(ShowSecretFunctionTemplatesRequest showSecretFunctionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/function-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretFunctionTemplatesRequest);
            return new SyncInvoker<ShowSecretFunctionTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretFunctionTemplatesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(showSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretStageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretStageResponse>(response);
        }

        public SyncInvoker<ShowSecretStageResponse> ShowSecretStageInvoker(ShowSecretStageRequest showSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(showSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretStageRequest);
            return new SyncInvoker<ShowSecretStageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretStageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(showSecretVersionRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretVersionResponse>(response);
        }

        public SyncInvoker<ShowSecretVersionResponse> ShowSecretVersionInvoker(ShowSecretVersionRequest showSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecretVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(showSecretVersionRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            return new SyncInvoker<ShowSecretVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretVersionResponse>);
        }
        
        /// <summary>
        /// 获取租户的凭据检测配置
        ///
        /// 获取租户的凭据检测配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecretsConfigResponse ShowSecretsConfig(ShowSecretsConfigRequest showSecretsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretsConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretsConfigResponse>(response);
        }

        public SyncInvoker<ShowSecretsConfigResponse> ShowSecretsConfigInvoker(ShowSecretsConfigRequest showSecretsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretsConfigRequest);
            return new SyncInvoker<ShowSecretsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretsConfigResponse>);
        }
        
        /// <summary>
        /// 获取用户详情
        ///
        /// 根据用户id查询用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserDetailResponse ShowUserDetail(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserDetailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserDetailResponse>(response);
        }

        public SyncInvoker<ShowUserDetailResponse> ShowUserDetailInvoker(ShowUserDetailRequest showUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserDetailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDetailRequest);
            return new SyncInvoker<ShowUserDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserDetailResponse>);
        }
        
        /// <summary>
        /// 更新授权
        ///
        /// 更新授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGrantResponse UpdateGrant(UpdateGrantRequest updateGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGrantRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGrantResponse>(response);
        }

        public SyncInvoker<UpdateGrantResponse> UpdateGrantInvoker(UpdateGrantRequest updateGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGrantRequest);
            return new SyncInvoker<UpdateGrantResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGrantResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretResponse>(response);
        }

        public SyncInvoker<UpdateSecretResponse> UpdateSecretInvoker(UpdateSecretRequest updateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            return new SyncInvoker<UpdateSecretResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretEventRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretEventResponse>(response);
        }

        public SyncInvoker<UpdateSecretEventResponse> UpdateSecretEventInvoker(UpdateSecretEventRequest updateSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretEventRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretEventRequest);
            return new SyncInvoker<UpdateSecretEventResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretEventResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(updateSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretStageResponse>(response);
        }

        public SyncInvoker<UpdateSecretStageResponse> UpdateSecretStageInvoker(UpdateSecretStageRequest updateSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecretStageRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(updateSecretStageRequest.StageName, out var valueOfStageName)) urlParam.Add("stage_name", valueOfStageName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            return new SyncInvoker<UpdateSecretStageResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretStageResponse>);
        }
        
        /// <summary>
        /// 更改获取租户的凭据检测配置
        ///
        /// 更改获取租户的凭据检测配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecretsConfigResponse UpdateSecretsConfig(UpdateSecretsConfigRequest updateSecretsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecretsConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSecretsConfigResponse>(response);
        }

        public SyncInvoker<UpdateSecretsConfigResponse> UpdateSecretsConfigInvoker(UpdateSecretsConfigRequest updateSecretsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/checker/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecretsConfigRequest);
            return new SyncInvoker<UpdateSecretsConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSecretsConfigResponse>);
        }
        
        /// <summary>
        /// 修改用户密码
        ///
        /// 修改用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserPasswordResponse UpdateUserPassword(UpdateUserPasswordRequest updateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users/change-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateUserPasswordResponse>(response);
        }

        public SyncInvoker<UpdateUserPasswordResponse> UpdateUserPasswordInvoker(UpdateUserPasswordRequest updateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users/change-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserPasswordRequest);
            return new SyncInvoker<UpdateUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateUserPasswordResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(updateVersionRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVersionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVersionResponse>(response);
        }

        public SyncInvoker<UpdateVersionResponse> UpdateVersionInvoker(UpdateVersionRequest updateVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionRequest.SecretName, out var valueOfSecretName)) urlParam.Add("secret_name", valueOfSecretName);
            if (StringUtils.TryConvertToNonEmptyString(updateVersionRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVersionRequest);
            return new SyncInvoker<UpdateVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSecretBlobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadSecretBlobResponse>(response);
        }

        public SyncInvoker<UploadSecretBlobResponse> UploadSecretBlobInvoker(UploadSecretBlobRequest uploadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSecretBlobRequest);
            return new SyncInvoker<UploadSecretBlobResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadSecretBlobResponse>);
        }
        
    }
}