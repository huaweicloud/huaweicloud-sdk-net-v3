using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Csms.V1.Model;

namespace HuaweiCloud.SDK.Csms.V1
{
    public partial class CsmsAsyncClient : Client
    {
        public static ClientBuilder<CsmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CsmsAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除凭据标签
        ///
        /// - 功能介绍：批量添加或删除凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsAsync(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", batchCreateOrDeleteTagsRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsAsyncInvoker(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", batchCreateOrDeleteTagsRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            return new AsyncInvoker<BatchCreateOrDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 创建服务委托
        ///
        /// 创建服务委托。用于创建凭据管理服务相关委托和函数工作流相关委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgencyResponse> CreateAgencyAsync(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }

        public AsyncInvoker<CreateAgencyResponse> CreateAgencyAsyncInvoker(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            return new AsyncInvoker<CreateAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyResponse>);
        }
        
        /// <summary>
        /// 授权操作
        ///
        /// 授权操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGrantsResponse> CreateGrantsAsync(CreateGrantsRequest createGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGrantsResponse>(response);
        }

        public AsyncInvoker<CreateGrantsResponse> CreateGrantsAsyncInvoker(CreateGrantsRequest createGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantsRequest);
            return new AsyncInvoker<CreateGrantsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGrantsResponse>);
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
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }

        public AsyncInvoker<CreateSecretResponse> CreateSecretAsyncInvoker(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            return new AsyncInvoker<CreateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretResponse>);
        }
        
        /// <summary>
        /// 创建事件
        ///
        /// 创建事件，事件可配置在一个或多个凭据对象上。当事件为启用状态且包含的基础事件类型在凭据对象上触发时，云服务会将对应的事件通知发送至事件指定的通知主题上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecretEventResponse> CreateSecretEventAsync(CreateSecretEventRequest createSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretEventRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretEventResponse>(response);
        }

        public AsyncInvoker<CreateSecretEventResponse> CreateSecretEventAsyncInvoker(CreateSecretEventRequest createSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretEventRequest);
            return new AsyncInvoker<CreateSecretEventResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretEventResponse>);
        }
        
        /// <summary>
        /// 添加凭据标签
        ///
        /// 添加凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecretTagResponse> CreateSecretTagAsync(CreateSecretTagRequest createSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", createSecretTagRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSecretTagResponse>(response);
        }

        public AsyncInvoker<CreateSecretTagResponse> CreateSecretTagAsyncInvoker(CreateSecretTagRequest createSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", createSecretTagRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretTagRequest);
            return new AsyncInvoker<CreateSecretTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSecretTagResponse>);
        }
        
        /// <summary>
        /// 创建凭据版本
        ///
        /// 在指定的凭据中，创建一个新的凭据版本，用于加密保管新的凭据值。默认情况下，新创建的凭据版本被标记为SYSCURRENT状态，而SYSCURRENT标记的前一个凭据版本被标记为SYSPREVIOUS状态。您可以通过指定VersionStage参数来覆盖默认行为。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecretVersionResponse> CreateSecretVersionAsync(CreateSecretVersionRequest createSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", createSecretVersionRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretVersionResponse>(response);
        }

        public AsyncInvoker<CreateSecretVersionResponse> CreateSecretVersionAsyncInvoker(CreateSecretVersionRequest createSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", createSecretVersionRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            return new AsyncInvoker<CreateSecretVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretVersionResponse>);
        }
        
        /// <summary>
        /// 删除授权
        ///
        /// 删除授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGrantResponse> DeleteGrantAsync(DeleteGrantRequest deleteGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGrantRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGrantResponse>(response);
        }

        public AsyncInvoker<DeleteGrantResponse> DeleteGrantAsyncInvoker(DeleteGrantRequest deleteGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGrantRequest);
            return new AsyncInvoker<DeleteGrantResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGrantResponse>);
        }
        
        /// <summary>
        /// 立即删除凭据
        ///
        /// 立即删除指定的凭据，且无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest deleteSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretResponse>(response);
        }

        public AsyncInvoker<DeleteSecretResponse> DeleteSecretAsyncInvoker(DeleteSecretRequest deleteSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            return new AsyncInvoker<DeleteSecretResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretResponse>);
        }
        
        /// <summary>
        /// 立即删除事件
        ///
        /// 立即删除指定的事件，且无法恢复。如事件存在凭据引用，则无法删除，请先解除关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecretEventResponse> DeleteSecretEventAsync(DeleteSecretEventRequest deleteSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", deleteSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretEventRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretEventResponse>(response);
        }

        public AsyncInvoker<DeleteSecretEventResponse> DeleteSecretEventAsyncInvoker(DeleteSecretEventRequest deleteSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", deleteSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretEventRequest);
            return new AsyncInvoker<DeleteSecretEventResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretEventResponse>);
        }
        
        /// <summary>
        /// 创建凭据的定时删除任务
        ///
        /// 指定延迟删除时间，创建删除凭据的定时任务，可设置7~30天的的延迟删除时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecretForScheduleResponse> DeleteSecretForScheduleAsync(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretForScheduleRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>(response);
        }

        public AsyncInvoker<DeleteSecretForScheduleResponse> DeleteSecretForScheduleAsyncInvoker(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretForScheduleRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            return new AsyncInvoker<DeleteSecretForScheduleResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>);
        }
        
        /// <summary>
        /// 删除凭据的版本状态
        ///
        /// 删除指定的凭据版本状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecretStageResponse> DeleteSecretStageAsync(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", deleteSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretStageResponse>(response);
        }

        public AsyncInvoker<DeleteSecretStageResponse> DeleteSecretStageAsyncInvoker(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", deleteSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", deleteSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            return new AsyncInvoker<DeleteSecretStageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretStageResponse>);
        }
        
        /// <summary>
        /// 删除凭据标签
        ///
        /// 删除凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecretTagResponse> DeleteSecretTagAsync(DeleteSecretTagRequest deleteSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", deleteSecretTagRequest.SecretId.ToString());
            urlParam.Add("key", deleteSecretTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecretTagResponse>(response);
        }

        public AsyncInvoker<DeleteSecretTagResponse> DeleteSecretTagAsyncInvoker(DeleteSecretTagRequest deleteSecretTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", deleteSecretTagRequest.SecretId.ToString());
            urlParam.Add("key", deleteSecretTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretTagRequest);
            return new AsyncInvoker<DeleteSecretTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecretTagResponse>);
        }
        
        /// <summary>
        /// 下载凭据备份
        ///
        /// 下载指定凭据的备份文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadSecretBlobResponse> DownloadSecretBlobAsync(DownloadSecretBlobRequest downloadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", downloadSecretBlobRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSecretBlobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadSecretBlobResponse>(response);
        }

        public AsyncInvoker<DownloadSecretBlobResponse> DownloadSecretBlobAsyncInvoker(DownloadSecretBlobRequest downloadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", downloadSecretBlobRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSecretBlobRequest);
            return new AsyncInvoker<DownloadSecretBlobResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSecretBlobResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 生成随机密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GenerateRandomPasswordResponse> GenerateRandomPasswordAsync(GenerateRandomPasswordRequest generateRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/generate-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateRandomPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GenerateRandomPasswordResponse>(response);
        }

        public AsyncInvoker<GenerateRandomPasswordResponse> GenerateRandomPasswordAsyncInvoker(GenerateRandomPasswordRequest generateRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/generate-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateRandomPasswordRequest);
            return new AsyncInvoker<GenerateRandomPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<GenerateRandomPasswordResponse>);
        }
        
        /// <summary>
        /// 授权列表
        ///
        /// 授权列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGrantsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }

        public AsyncInvoker<ListGrantsResponse> ListGrantsAsyncInvoker(ListGrantsRequest listGrantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGrantsRequest);
            return new AsyncInvoker<ListGrantsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGrantsResponse>);
        }
        
        /// <summary>
        /// 查询已触发的事件通知记录
        ///
        /// 查询三个月内所有已触发的事件通知记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationRecordsResponse> ListNotificationRecordsAsync(ListNotificationRecordsRequest listNotificationRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationRecordsResponse>(response);
        }

        public AsyncInvoker<ListNotificationRecordsResponse> ListNotificationRecordsAsyncInvoker(ListNotificationRecordsRequest listNotificationRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationRecordsRequest);
            return new AsyncInvoker<ListNotificationRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationRecordsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询用户在指定项目下的所有凭据标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectSecretsTagsResponse> ListProjectSecretsTagsAsync(ListProjectSecretsTagsRequest listProjectSecretsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSecretsTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectSecretsTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectSecretsTagsResponse> ListProjectSecretsTagsAsyncInvoker(ListProjectSecretsTagsRequest listProjectSecretsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSecretsTagsRequest);
            return new AsyncInvoker<ListProjectSecretsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectSecretsTagsResponse>);
        }
        
        /// <summary>
        /// 查询凭据实例
        ///
        /// 查询凭据实例。通过标签过滤，筛选用户凭据，返回凭据列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listResourceInstancesRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListResourceInstancesResponse> ListResourceInstancesAsyncInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances", listResourceInstancesRequest.ResourceInstances.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{resource_instances}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new AsyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询事件列表
        ///
        /// 查询当前用户在本项目下创建的所有事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecretEventsResponse> ListSecretEventsAsync(ListSecretEventsRequest listSecretEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecretEventsResponse>(response);
        }

        public AsyncInvoker<ListSecretEventsResponse> ListSecretEventsAsyncInvoker(ListSecretEventsRequest listSecretEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretEventsRequest);
            return new AsyncInvoker<ListSecretEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretEventsResponse>);
        }
        
        /// <summary>
        /// 查询凭据标签
        ///
        /// 查询凭据标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecretTagsResponse> ListSecretTagsAsync(ListSecretTagsRequest listSecretTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", listSecretTagsRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecretTagsResponse>(response);
        }

        public AsyncInvoker<ListSecretTagsResponse> ListSecretTagsAsyncInvoker(ListSecretTagsRequest listSecretTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id", listSecretTagsRequest.SecretId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/{secret_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTagsRequest);
            return new AsyncInvoker<ListSecretTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretTagsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecretTaskResponse> ListSecretTaskAsync(ListSecretTaskRequest listSecretTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecretTaskResponse>(response);
        }

        public AsyncInvoker<ListSecretTaskResponse> ListSecretTaskAsyncInvoker(ListSecretTaskRequest listSecretTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretTaskRequest);
            return new AsyncInvoker<ListSecretTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretTaskResponse>);
        }
        
        /// <summary>
        /// 查询凭据的版本列表
        ///
        /// 查询指定凭据下的版本列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecretVersionsResponse> ListSecretVersionsAsync(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", listSecretVersionsRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecretVersionsResponse>(response);
        }

        public AsyncInvoker<ListSecretVersionsResponse> ListSecretVersionsAsyncInvoker(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", listSecretVersionsRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            return new AsyncInvoker<ListSecretVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretVersionsResponse>);
        }
        
        /// <summary>
        /// 查询凭据列表
        ///
        /// 查询当前用户在本项目下创建的所有凭据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest listSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecretsResponse>(response);
        }

        public AsyncInvoker<ListSecretsResponse> ListSecretsAsyncInvoker(ListSecretsRequest listSecretsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            return new AsyncInvoker<ListSecretsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecretsResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 取消凭据的定时删除任务
        ///
        /// 取消凭据的定时删除任务，凭据对象恢复可使用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest restoreSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", restoreSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreSecretResponse>(response);
        }

        public AsyncInvoker<RestoreSecretResponse> RestoreSecretAsyncInvoker(RestoreSecretRequest restoreSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", restoreSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/scheduled-deleted-tasks/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            return new AsyncInvoker<RestoreSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreSecretResponse>);
        }
        
        /// <summary>
        /// 轮转凭据
        ///
        /// 立即执行轮转凭据。在指定的凭据中，创建一个新的凭据版本，用于加密存储后台随机产生的凭据值。同时将新创建的凭据版本标记为SYSCURRENT状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest rotateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", rotateSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/rotate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rotateSecretRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RotateSecretResponse>(response);
        }

        public AsyncInvoker<RotateSecretResponse> RotateSecretAsyncInvoker(RotateSecretRequest rotateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", rotateSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/rotate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rotateSecretRequest);
            return new AsyncInvoker<RotateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<RotateSecretResponse>);
        }
        
        /// <summary>
        /// 查看是否有服务委托
        ///
        /// 查看是否有服务委托
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgencyResponse> ShowAgencyAsync(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public AsyncInvoker<ShowAgencyResponse> ShowAgencyAsyncInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new AsyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
        }
        
        /// <summary>
        /// 查询凭据
        ///
        /// 查询指定凭据的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecretResponse> ShowSecretAsync(ShowSecretRequest showSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretResponse>(response);
        }

        public AsyncInvoker<ShowSecretResponse> ShowSecretAsyncInvoker(ShowSecretRequest showSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            return new AsyncInvoker<ShowSecretResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretResponse>);
        }
        
        /// <summary>
        /// 查询事件
        ///
        /// 查询指定事件的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecretEventResponse> ShowSecretEventAsync(ShowSecretEventRequest showSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", showSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretEventRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretEventResponse>(response);
        }

        public AsyncInvoker<ShowSecretEventResponse> ShowSecretEventAsyncInvoker(ShowSecretEventRequest showSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", showSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretEventRequest);
            return new AsyncInvoker<ShowSecretEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretEventResponse>);
        }
        
        /// <summary>
        /// 获取凭据轮转函数模板
        ///
        /// 获取凭据轮转函数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecretFunctionTemplatesResponse> ShowSecretFunctionTemplatesAsync(ShowSecretFunctionTemplatesRequest showSecretFunctionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/function-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretFunctionTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretFunctionTemplatesResponse>(response);
        }

        public AsyncInvoker<ShowSecretFunctionTemplatesResponse> ShowSecretFunctionTemplatesAsyncInvoker(ShowSecretFunctionTemplatesRequest showSecretFunctionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/csms/function-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretFunctionTemplatesRequest);
            return new AsyncInvoker<ShowSecretFunctionTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretFunctionTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询凭据的版本状态
        ///
        /// 查询指定凭据版本状态标记的版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecretStageResponse> ShowSecretStageAsync(ShowSecretStageRequest showSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", showSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretStageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretStageResponse>(response);
        }

        public AsyncInvoker<ShowSecretStageResponse> ShowSecretStageAsyncInvoker(ShowSecretStageRequest showSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", showSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretStageRequest);
            return new AsyncInvoker<ShowSecretStageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretStageResponse>);
        }
        
        /// <summary>
        /// 查询凭据的版本与凭据值
        ///
        /// 查询指定凭据版本的信息和版本中的明文凭据值，只能查询ENABLED状态的凭据。
        /// 通过/v1/{project_id}/secrets/{secret_name}/versions/latest （即将当前接口URL中的{version_id}赋值为latest）可访问凭据最新版本的凭据值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecretVersionResponse> ShowSecretVersionAsync(ShowSecretVersionRequest showSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretVersionRequest.SecretName.ToString());
            urlParam.Add("version_id", showSecretVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecretVersionResponse>(response);
        }

        public AsyncInvoker<ShowSecretVersionResponse> ShowSecretVersionAsyncInvoker(ShowSecretVersionRequest showSecretVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", showSecretVersionRequest.SecretName.ToString());
            urlParam.Add("version_id", showSecretVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            return new AsyncInvoker<ShowSecretVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecretVersionResponse>);
        }
        
        /// <summary>
        /// 更新授权
        ///
        /// 更新授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGrantResponse> UpdateGrantAsync(UpdateGrantRequest updateGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGrantRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGrantResponse>(response);
        }

        public AsyncInvoker<UpdateGrantResponse> UpdateGrantAsyncInvoker(UpdateGrantRequest updateGrantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/grants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGrantRequest);
            return new AsyncInvoker<UpdateGrantResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGrantResponse>);
        }
        
        /// <summary>
        /// 更新凭据
        ///
        /// 更新指定凭据的元数据信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest updateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretResponse>(response);
        }

        public AsyncInvoker<UpdateSecretResponse> UpdateSecretAsyncInvoker(UpdateSecretRequest updateSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateSecretRequest.SecretName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            return new AsyncInvoker<UpdateSecretResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretResponse>);
        }
        
        /// <summary>
        /// 更新事件
        ///
        /// 更新指定事件的元数据信息。支持更新的元数据包含事件启用状态、基础类型列表、通知主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecretEventResponse> UpdateSecretEventAsync(UpdateSecretEventRequest updateSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", updateSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretEventRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretEventResponse>(response);
        }

        public AsyncInvoker<UpdateSecretEventResponse> UpdateSecretEventAsyncInvoker(UpdateSecretEventRequest updateSecretEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", updateSecretEventRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/csms/events/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretEventRequest);
            return new AsyncInvoker<UpdateSecretEventResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretEventResponse>);
        }
        
        /// <summary>
        /// 更新凭据的版本状态
        ///
        /// 更新凭据的版本状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecretStageResponse> UpdateSecretStageAsync(UpdateSecretStageRequest updateSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", updateSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecretStageResponse>(response);
        }

        public AsyncInvoker<UpdateSecretStageResponse> UpdateSecretStageAsyncInvoker(UpdateSecretStageRequest updateSecretStageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateSecretStageRequest.SecretName.ToString());
            urlParam.Add("stage_name", updateSecretStageRequest.StageName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/stages/{stage_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            return new AsyncInvoker<UpdateSecretStageResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecretStageResponse>);
        }
        
        /// <summary>
        /// 更新凭据版本
        ///
        /// 当前支持更新指定凭据版本的有效期，只能更新ENABLED状态的凭据。在关联订阅的事件包含“版本过期”基础事件类型时，每次更新版本有效期后仅会触发一次事件通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVersionResponse> UpdateVersionAsync(UpdateVersionRequest updateVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateVersionRequest.SecretName.ToString());
            urlParam.Add("version_id", updateVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVersionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVersionResponse>(response);
        }

        public AsyncInvoker<UpdateVersionResponse> UpdateVersionAsyncInvoker(UpdateVersionRequest updateVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_name", updateVersionRequest.SecretName.ToString());
            urlParam.Add("version_id", updateVersionRequest.VersionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_name}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVersionRequest);
            return new AsyncInvoker<UpdateVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVersionResponse>);
        }
        
        /// <summary>
        /// 恢复凭据对象
        ///
        /// 通过上传凭据备份文件，恢复凭据对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadSecretBlobResponse> UploadSecretBlobAsync(UploadSecretBlobRequest uploadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSecretBlobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadSecretBlobResponse>(response);
        }

        public AsyncInvoker<UploadSecretBlobResponse> UploadSecretBlobAsyncInvoker(UploadSecretBlobRequest uploadSecretBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSecretBlobRequest);
            return new AsyncInvoker<UploadSecretBlobResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadSecretBlobResponse>);
        }
        
    }
}