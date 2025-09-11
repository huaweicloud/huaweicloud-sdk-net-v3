using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Workspace.V2.Model;

namespace HuaweiCloud.SDK.Workspace.V2
{
    public partial class WorkspaceClient : Client
    {
        public static ClientBuilder<WorkspaceClient> NewBuilder()
        {
            return new ClientBuilder<WorkspaceClient>();
        }

        
        /// <summary>
        /// 获取云办公服务接入地址备份配置
        ///
        /// 该接口用于获取云办公服务接入地址备份配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessAddressBackupConfigResponse ListAccessAddressBackupConfig(ListAccessAddressBackupConfigRequest listAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAddressBackupConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessAddressBackupConfigResponse>(response);
        }

        public SyncInvoker<ListAccessAddressBackupConfigResponse> ListAccessAddressBackupConfigInvoker(ListAccessAddressBackupConfigRequest listAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAddressBackupConfigRequest);
            return new SyncInvoker<ListAccessAddressBackupConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessAddressBackupConfigResponse>);
        }
        
        /// <summary>
        /// 修改云办公服务接入地址备份配置
        ///
        /// 该接口用于修改云办公服务接入地址备份配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessAddressBackupConfigResponse UpdateAccessAddressBackupConfig(UpdateAccessAddressBackupConfigRequest updateAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessAddressBackupConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAccessAddressBackupConfigResponse>(response);
        }

        public SyncInvoker<UpdateAccessAddressBackupConfigResponse> UpdateAccessAddressBackupConfigInvoker(UpdateAccessAddressBackupConfigRequest updateAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessAddressBackupConfigRequest);
            return new SyncInvoker<UpdateAccessAddressBackupConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAccessAddressBackupConfigResponse>);
        }
        
        /// <summary>
        /// 删除接入策略
        ///
        /// 该接口用于删除指定接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAccessPoliciesResponse BatchDeleteAccessPolicies(BatchDeleteAccessPoliciesRequest batchDeleteAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAccessPoliciesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAccessPoliciesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAccessPoliciesResponse> BatchDeleteAccessPoliciesInvoker(BatchDeleteAccessPoliciesRequest batchDeleteAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAccessPoliciesRequest);
            return new SyncInvoker<BatchDeleteAccessPoliciesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteAccessPoliciesResponse>);
        }
        
        /// <summary>
        /// 创建接入策略
        ///
        /// 该接口用于创建接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAccessPolicyResponse>(response);
        }

        public SyncInvoker<CreateAccessPolicyResponse> CreateAccessPolicyInvoker(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            return new SyncInvoker<CreateAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询接入策略
        ///
        /// 该接口用于查询接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest listAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessPoliciesResponse>(response);
        }

        public SyncInvoker<ListAccessPoliciesResponse> ListAccessPoliciesInvoker(ListAccessPoliciesRequest listAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPoliciesRequest);
            return new SyncInvoker<ListAccessPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询指定接入策略的应用对象
        ///
        /// 该接口用于查询指定接入策略的应用对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessPolicyObjectsResponse ListAccessPolicyObjects(ListAccessPolicyObjectsRequest listAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessPolicyObjectsRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyObjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessPolicyObjectsResponse>(response);
        }

        public SyncInvoker<ListAccessPolicyObjectsResponse> ListAccessPolicyObjectsInvoker(ListAccessPolicyObjectsRequest listAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessPolicyObjectsRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyObjectsRequest);
            return new SyncInvoker<ListAccessPolicyObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessPolicyObjectsResponse>);
        }
        
        /// <summary>
        /// 更新指定接入策略
        ///
        /// 该接口用于更新指定接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAccessPolicyResponse>(response);
        }

        public SyncInvoker<UpdateAccessPolicyResponse> UpdateAccessPolicyInvoker(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            return new SyncInvoker<UpdateAccessPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 更新指定接入策略的应用对象
        ///
        /// 该接口用于更新指定接入策略的应用对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessPolicyObjectsResponse UpdateAccessPolicyObjects(UpdateAccessPolicyObjectsRequest updateAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyObjectsRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyObjectsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAccessPolicyObjectsResponse>(response);
        }

        public SyncInvoker<UpdateAccessPolicyObjectsResponse> UpdateAccessPolicyObjectsInvoker(UpdateAccessPolicyObjectsRequest updateAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessPolicyObjectsRequest.AccessPolicyId, out var valueOfAccessPolicyId)) urlParam.Add("access_policy_id", valueOfAccessPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyObjectsRequest);
            return new SyncInvoker<UpdateAccessPolicyObjectsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAccessPolicyObjectsResponse>);
        }
        
        /// <summary>
        /// 开通委托功能
        ///
        /// 开通委托功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAgenciesResponse CreateAgencies(CreateAgenciesRequest createAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAgenciesResponse>(response);
        }

        public SyncInvoker<CreateAgenciesResponse> CreateAgenciesInvoker(CreateAgenciesRequest createAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesRequest);
            return new SyncInvoker<CreateAgenciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAgenciesResponse>);
        }
        
        /// <summary>
        /// 查询委托功能
        ///
        /// 查询委托功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgenciesResponse ListAgencies(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }

        public SyncInvoker<ListAgenciesResponse> ListAgenciesInvoker(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            return new SyncInvoker<ListAgenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesResponse>);
        }
        
        /// <summary>
        /// 查询告警统计
        ///
        /// 返回各级别告警数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmStatisticsResponse ListAlarmStatistics(ListAlarmStatisticsRequest listAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmStatisticsResponse>(response);
        }

        public SyncInvoker<ListAlarmStatisticsResponse> ListAlarmStatisticsInvoker(ListAlarmStatisticsRequest listAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsRequest);
            return new SyncInvoker<ListAlarmStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询告警列表
        ///
        /// 从ces查询告警列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmsResponse ListAlarms(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }

        public SyncInvoker<ListAlarmsResponse> ListAlarmsInvoker(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            return new SyncInvoker<ListAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmsResponse>);
        }
        
        /// <summary>
        /// 批量删除应用
        ///
        /// 批量删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAppsResponse BatchDeleteApps(BatchDeleteAppsRequest batchDeleteAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppsResponse> BatchDeleteAppsInvoker(BatchDeleteAppsRequest batchDeleteAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppsRequest);
            return new SyncInvoker<BatchDeleteAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppsResponse>);
        }
        
        /// <summary>
        /// 批量删除job
        ///
        /// 批量删除job。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteJobsResponse BatchDeleteJobs(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteJobsResponse>(response);
        }

        public SyncInvoker<BatchDeleteJobsResponse> BatchDeleteJobsInvoker(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            return new SyncInvoker<BatchDeleteJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteJobsResponse>);
        }
        
        /// <summary>
        /// 批量设置不可见
        ///
        /// 批量设置不可见。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDisableAppsResponse BatchDisableApps(BatchDisableAppsRequest batchDisableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisableAppsResponse>(response);
        }

        public SyncInvoker<BatchDisableAppsResponse> BatchDisableAppsInvoker(BatchDisableAppsRequest batchDisableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppsRequest);
            return new SyncInvoker<BatchDisableAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisableAppsResponse>);
        }
        
        /// <summary>
        /// 批量设置可见
        ///
        /// 批量设置可见。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchEnableAppsResponse BatchEnableApps(BatchEnableAppsRequest batchEnableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchEnableAppsResponse>(response);
        }

        public SyncInvoker<BatchEnableAppsResponse> BatchEnableAppsInvoker(BatchEnableAppsRequest batchEnableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppsRequest);
            return new SyncInvoker<BatchEnableAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchEnableAppsResponse>);
        }
        
        /// <summary>
        /// 批量自动安装安装应用
        ///
        /// 批量自动安装安装应用 (应用需支持静默安装或者解压安装)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchInstallAppsResponse BatchInstallApps(BatchInstallAppsRequest batchInstallAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchInstallAppsResponse>(response);
        }

        public SyncInvoker<BatchInstallAppsResponse> BatchInstallAppsInvoker(BatchInstallAppsRequest batchInstallAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAppsRequest);
            return new SyncInvoker<BatchInstallAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchInstallAppsResponse>);
        }
        
        /// <summary>
        /// 批量设置应用授权
        ///
        /// 批量设置应用授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateAppAuthorizationsResponse BatchUpdateAppAuthorizations(BatchUpdateAppAuthorizationsRequest batchUpdateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-assign-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAppAuthorizationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateAppAuthorizationsResponse>(response);
        }

        public SyncInvoker<BatchUpdateAppAuthorizationsResponse> BatchUpdateAppAuthorizationsInvoker(BatchUpdateAppAuthorizationsRequest batchUpdateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-assign-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAppAuthorizationsRequest);
            return new SyncInvoker<BatchUpdateAppAuthorizationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 添加并授权默认桶
        ///
        /// 添加并授权默认桶,桶不存在时会自动创建OBS桶。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAndAuthorizeBucketResponse CreateAndAuthorizeBucket(CreateAndAuthorizeBucketRequest createAndAuthorizeBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAndAuthorizeBucketRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAndAuthorizeBucketResponse>(response);
        }

        public SyncInvoker<CreateAndAuthorizeBucketResponse> CreateAndAuthorizeBucketInvoker(CreateAndAuthorizeBucketRequest createAndAuthorizeBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAndAuthorizeBucketRequest);
            return new SyncInvoker<CreateAndAuthorizeBucketResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAndAuthorizeBucketResponse>);
        }
        
        /// <summary>
        /// 生成访问凭证信息
        ///
        /// 生成桶凭证信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBucketCredentialResponse CreateBucketCredential(CreateBucketCredentialRequest createBucketCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets/actions/create-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketCredentialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBucketCredentialResponse>(response);
        }

        public SyncInvoker<CreateBucketCredentialResponse> CreateBucketCredentialInvoker(CreateBucketCredentialRequest createBucketCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets/actions/create-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketCredentialRequest);
            return new SyncInvoker<CreateBucketCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBucketCredentialResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public SyncInvoker<DeleteAppResponse> DeleteAppInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new SyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 自动安装应用
        ///
        /// 自动安装应用(应用需支持静默安装或者解压安装)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InstallAppResponse InstallApp(InstallAppRequest installAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(installAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", installAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<InstallAppResponse>(response);
        }

        public SyncInvoker<InstallAppResponse> InstallAppInvoker(InstallAppRequest installAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(installAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", installAppRequest);
            return new SyncInvoker<InstallAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InstallAppResponse>);
        }
        
        /// <summary>
        /// 查询应用授权信息
        ///
        /// 查询应用授权信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppAuthorizationsResponse ListAppAuthorizations(ListAppAuthorizationsRequest listAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAppAuthorizationsRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppAuthorizationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppAuthorizationsResponse>(response);
        }

        public SyncInvoker<ListAppAuthorizationsResponse> ListAppAuthorizationsInvoker(ListAppAuthorizationsRequest listAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAppAuthorizationsRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppAuthorizationsRequest);
            return new SyncInvoker<ListAppAuthorizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 查询应用分类信息
        ///
        /// 查询应用分类信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppCatalogsResponse ListAppCatalogs(ListAppCatalogsRequest listAppCatalogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-catalogs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppCatalogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppCatalogsResponse>(response);
        }

        public SyncInvoker<ListAppCatalogsResponse> ListAppCatalogsInvoker(ListAppCatalogsRequest listAppCatalogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-catalogs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppCatalogsRequest);
            return new SyncInvoker<ListAppCatalogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppCatalogsResponse>);
        }
        
        /// <summary>
        /// 按照名称分页查询应用
        ///
        /// 按照名称分页查询应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppsResponse ListApps(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public SyncInvoker<ListAppsResponse> ListAppsInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new SyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询应用安装job信息
        ///
        /// 查询应用安装job信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 重试失败job
        ///
        /// 重试指定失败job(仅支持失败job重试，其他类型job重试会响应错误)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryJobsResponse RetryJobs(RetryJobsRequest retryJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RetryJobsResponse>(response);
        }

        public SyncInvoker<RetryJobsResponse> RetryJobsInvoker(RetryJobsRequest retryJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryJobsRequest);
            return new SyncInvoker<RetryJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryJobsResponse>);
        }
        
        /// <summary>
        /// 设置应用授权
        ///
        /// 设置应用授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppAuthorizationsResponse UpdateAppAuthorizations(UpdateAppAuthorizationsRequest updateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppAuthorizationsRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/assign-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppAuthorizationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAppAuthorizationsResponse>(response);
        }

        public SyncInvoker<UpdateAppAuthorizationsResponse> UpdateAppAuthorizationsInvoker(UpdateAppAuthorizationsRequest updateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppAuthorizationsRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/assign-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppAuthorizationsRequest);
            return new SyncInvoker<UpdateAppAuthorizationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUploadedAppResponse UpdateUploadedApp(UpdateUploadedAppRequest updateUploadedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUploadedAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUploadedAppRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateUploadedAppResponse>(response);
        }

        public SyncInvoker<UpdateUploadedAppResponse> UpdateUploadedAppInvoker(UpdateUploadedAppRequest updateUploadedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUploadedAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUploadedAppRequest);
            return new SyncInvoker<UpdateUploadedAppResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateUploadedAppResponse>);
        }
        
        /// <summary>
        /// 添加应用
        ///
        /// 添加应用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadAppResponse UploadApp(UploadAppRequest uploadAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadAppResponse>(response);
        }

        public SyncInvoker<UploadAppResponse> UploadAppInvoker(UploadAppRequest uploadAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAppRequest);
            return new SyncInvoker<UploadAppResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAppResponse>);
        }
        
        /// <summary>
        /// 增加管控规则
        ///
        /// 增加管控规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRestrictedRuleResponse AddRestrictedRule(AddRestrictedRuleRequest addRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRestrictedRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddRestrictedRuleResponse>(response);
        }

        public SyncInvoker<AddRestrictedRuleResponse> AddRestrictedRuleInvoker(AddRestrictedRuleRequest addRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRestrictedRuleRequest);
            return new SyncInvoker<AddRestrictedRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除规则
        ///
        /// 批量删除规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAppRulesResponse BatchDeleteAppRules(BatchDeleteAppRulesRequest batchDeleteAppRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppRulesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppRulesResponse> BatchDeleteAppRulesInvoker(BatchDeleteAppRulesRequest batchDeleteAppRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRulesRequest);
            return new SyncInvoker<BatchDeleteAppRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppRulesResponse>);
        }
        
        /// <summary>
        /// 创建应用规则
        ///
        /// 创建应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppRuleResponse CreateAppRule(CreateAppRuleRequest createAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppRuleResponse>(response);
        }

        public SyncInvoker<CreateAppRuleResponse> CreateAppRuleInvoker(CreateAppRuleRequest createAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRuleRequest);
            return new SyncInvoker<CreateAppRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppRuleResponse>);
        }
        
        /// <summary>
        /// 删除应用规则
        ///
        /// 删除应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppRuleResponse DeleteAppRule(DeleteAppRuleRequest deleteAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppRuleResponse>(response);
        }

        public SyncInvoker<DeleteAppRuleResponse> DeleteAppRuleInvoker(DeleteAppRuleRequest deleteAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRuleRequest);
            return new SyncInvoker<DeleteAppRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除管控规则
        ///
        /// 批量删除管控规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRestrictedRuleResponse DeleteRestrictedRule(DeleteRestrictedRuleRequest deleteRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRestrictedRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteRestrictedRuleResponse>(response);
        }

        public SyncInvoker<DeleteRestrictedRuleResponse> DeleteRestrictedRuleInvoker(DeleteRestrictedRuleRequest deleteRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRestrictedRuleRequest);
            return new SyncInvoker<DeleteRestrictedRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 禁用规则管控
        ///
        /// 禁用规则管控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableRuleRestrictionResponse DisableRuleRestriction(DisableRuleRestrictionRequest disableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/disable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableRuleRestrictionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableRuleRestrictionResponse>(response);
        }

        public SyncInvoker<DisableRuleRestrictionResponse> DisableRuleRestrictionInvoker(DisableRuleRestrictionRequest disableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/disable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableRuleRestrictionRequest);
            return new SyncInvoker<DisableRuleRestrictionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 启用规则管控
        ///
        /// 启用规则管控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableRuleRestrictionResponse EnableRuleRestriction(EnableRuleRestrictionRequest enableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/enable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableRuleRestrictionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableRuleRestrictionResponse>(response);
        }

        public SyncInvoker<EnableRuleRestrictionResponse> EnableRuleRestrictionInvoker(EnableRuleRestrictionRequest enableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/enable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableRuleRestrictionRequest);
            return new SyncInvoker<EnableRuleRestrictionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 查询应用规则
        ///
        /// 查询应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppRuleResponse ListAppRule(ListAppRuleRequest listAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppRuleResponse>(response);
        }

        public SyncInvoker<ListAppRuleResponse> ListAppRuleInvoker(ListAppRuleRequest listAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppRuleRequest);
            return new SyncInvoker<ListAppRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppRuleResponse>);
        }
        
        /// <summary>
        /// 查询管控规则列表
        ///
        /// 查询管控规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestrictedRuleResponse ListRestrictedRule(ListRestrictedRuleRequest listRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestrictedRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestrictedRuleResponse>(response);
        }

        public SyncInvoker<ListRestrictedRuleResponse> ListRestrictedRuleInvoker(ListRestrictedRuleRequest listRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestrictedRuleRequest);
            return new SyncInvoker<ListRestrictedRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 设置管控规则
        ///
        /// 设置管控规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRuleRestrictionResponse SetRuleRestriction(SetRuleRestrictionRequest setRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/set-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRuleRestrictionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetRuleRestrictionResponse>(response);
        }

        public SyncInvoker<SetRuleRestrictionResponse> SetRuleRestrictionInvoker(SetRuleRestrictionRequest setRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/set-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRuleRestrictionRequest);
            return new SyncInvoker<SetRuleRestrictionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 查询管控规则
        ///
        /// 查询管控规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRuleRestrictionResponse ShowRuleRestriction(ShowRuleRestrictionRequest showRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/get-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRestrictionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleRestrictionResponse>(response);
        }

        public SyncInvoker<ShowRuleRestrictionResponse> ShowRuleRestrictionInvoker(ShowRuleRestrictionRequest showRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/get-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRestrictionRequest);
            return new SyncInvoker<ShowRuleRestrictionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 修改应用规则
        ///
        /// 修改应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppRuleResponse UpdateAppRule(UpdateAppRuleRequest updateAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRuleRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppRuleResponse>(response);
        }

        public SyncInvoker<UpdateAppRuleResponse> UpdateAppRuleInvoker(UpdateAppRuleRequest updateAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRuleRequest);
            return new SyncInvoker<UpdateAppRuleResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppRuleResponse>);
        }
        
        /// <summary>
        /// 查询辅助认证配置
        ///
        /// 查询辅助认证的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssistAuthConfigResponse ShowAssistAuthConfig(ShowAssistAuthConfigRequest showAssistAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssistAuthConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssistAuthConfigResponse>(response);
        }

        public SyncInvoker<ShowAssistAuthConfigResponse> ShowAssistAuthConfigInvoker(ShowAssistAuthConfigRequest showAssistAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssistAuthConfigRequest);
            return new SyncInvoker<ShowAssistAuthConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssistAuthConfigResponse>);
        }
        
        /// <summary>
        /// 查询认证登录方式
        ///
        /// 查询认证登录方式配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuthConfigResponse ShowAuthConfig(ShowAuthConfigRequest showAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuthConfigResponse>(response);
        }

        public SyncInvoker<ShowAuthConfigResponse> ShowAuthConfigInvoker(ShowAuthConfigRequest showAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthConfigRequest);
            return new SyncInvoker<ShowAuthConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuthConfigResponse>);
        }
        
        /// <summary>
        /// 更新辅助认证策略配置
        ///
        /// 更新辅助认证策略配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssistAuthMethodConfigResponse UpdateAssistAuthMethodConfig(UpdateAssistAuthMethodConfigRequest updateAssistAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssistAuthMethodConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAssistAuthMethodConfigResponse>(response);
        }

        public SyncInvoker<UpdateAssistAuthMethodConfigResponse> UpdateAssistAuthMethodConfigInvoker(UpdateAssistAuthMethodConfigRequest updateAssistAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssistAuthMethodConfigRequest);
            return new SyncInvoker<UpdateAssistAuthMethodConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAssistAuthMethodConfigResponse>);
        }
        
        /// <summary>
        /// 更新认证策略配置
        ///
        /// 更新认证策略配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuthMethodConfigResponse UpdateAuthMethodConfig(UpdateAuthMethodConfigRequest updateAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthMethodConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuthMethodConfigResponse>(response);
        }

        public SyncInvoker<UpdateAuthMethodConfigResponse> UpdateAuthMethodConfigInvoker(UpdateAuthMethodConfigRequest updateAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthMethodConfigRequest);
            return new SyncInvoker<UpdateAuthMethodConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuthMethodConfigResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// 该接口用于查询云桌面支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailabilityZonesResponse ListAvailabilityZones(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }

        public SyncInvoker<ListAvailabilityZonesResponse> ListAvailabilityZonesInvoker(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            return new SyncInvoker<ListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表概要
        ///
        /// 该接口用于查询云桌面支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAzsResponse ListAzs(ListAzsRequest listAzsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAzsResponse>(response);
        }

        public SyncInvoker<ListAzsResponse> ListAzsInvoker(ListAzsRequest listAzsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzsRequest);
            return new SyncInvoker<ListAzsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAzsResponse>);
        }
        
        /// <summary>
        /// 查询可用分区详情
        ///
        /// 该接口用于查询云桌面支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAzDetailsResponse ShowAzDetails(ShowAzDetailsRequest showAzDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAzDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAzDetailsResponse>(response);
        }

        public SyncInvoker<ShowAzDetailsResponse> ShowAzDetailsInvoker(ShowAzDetailsRequest showAzDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAzDetailsRequest);
            return new SyncInvoker<ShowAzDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAzDetailsResponse>);
        }
        
        /// <summary>
        /// 导出连接记录
        ///
        /// 该接口用于导出连接记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportUserLoginInfoNewResponse ExportUserLoginInfoNew(ExportUserLoginInfoNewRequest exportUserLoginInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserLoginInfoNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ExportUserLoginInfoNewResponse>(response);
        }

        public SyncInvoker<ExportUserLoginInfoNewResponse> ExportUserLoginInfoNewInvoker(ExportUserLoginInfoNewRequest exportUserLoginInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserLoginInfoNewRequest);
            return new SyncInvoker<ExportUserLoginInfoNewResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ExportUserLoginInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询登录人数
        ///
        /// 该接口用于查询登录人数，注意查询参数不可全空。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistoryOnlineInfoNewResponse ListHistoryOnlineInfoNew(ListHistoryOnlineInfoNewRequest listHistoryOnlineInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOnlineInfoNewResponse>(response);
        }

        public SyncInvoker<ListHistoryOnlineInfoNewResponse> ListHistoryOnlineInfoNewInvoker(ListHistoryOnlineInfoNewRequest listHistoryOnlineInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoNewRequest);
            return new SyncInvoker<ListHistoryOnlineInfoNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOnlineInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询桌面登录状态
        ///
        /// 该接口用于查询桌面登录状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesStatusResponse ListInstancesStatus(ListInstancesStatusRequest listInstancesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesStatusResponse>(response);
        }

        public SyncInvoker<ListInstancesStatusResponse> ListInstancesStatusInvoker(ListInstancesStatusRequest listInstancesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesStatusRequest);
            return new SyncInvoker<ListInstancesStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesStatusResponse>);
        }
        
        /// <summary>
        /// 查询登录信息
        ///
        /// 该接口用于查询登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoginRecordsNewResponse ListLoginRecordsNew(ListLoginRecordsNewRequest listLoginRecordsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginRecordsNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoginRecordsNewResponse>(response);
        }

        public SyncInvoker<ListLoginRecordsNewResponse> ListLoginRecordsNewInvoker(ListLoginRecordsNewRequest listLoginRecordsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginRecordsNewRequest);
            return new SyncInvoker<ListLoginRecordsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoginRecordsNewResponse>);
        }
        
        /// <summary>
        /// 分配用户
        ///
        /// 将桌面分配给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachInstancesResponse AttachInstances(AttachInstancesRequest attachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachInstancesResponse>(response);
        }

        public SyncInvoker<AttachInstancesResponse> AttachInstancesInvoker(AttachInstancesRequest attachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInstancesRequest);
            return new SyncInvoker<AttachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInstancesResponse>);
        }
        
        /// <summary>
        /// 预批量分配用户
        ///
        /// 预批量将桌面分配给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAssociateInstancesResponse BatchAssociateInstances(BatchAssociateInstancesRequest batchAssociateInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/pre-batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAssociateInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAssociateInstancesResponse>(response);
        }

        public SyncInvoker<BatchAssociateInstancesResponse> BatchAssociateInstancesInvoker(BatchAssociateInstancesRequest batchAssociateInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/pre-batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAssociateInstancesRequest);
            return new SyncInvoker<BatchAssociateInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAssociateInstancesResponse>);
        }
        
        /// <summary>
        /// 批量分配用户
        ///
        /// 批量分配桌面给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAttachInstancesResponse BatchAttachInstances(BatchAttachInstancesRequest batchAttachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachInstancesResponse>(response);
        }

        public SyncInvoker<BatchAttachInstancesResponse> BatchAttachInstancesInvoker(BatchAttachInstancesRequest batchAttachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInstancesRequest);
            return new SyncInvoker<BatchAttachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachInstancesResponse>);
        }
        
        /// <summary>
        /// 批量切换桌面网络
        ///
        /// 批量切换桌面vpc、子网、ip、安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchChangeDesktopNetworkResponse BatchChangeDesktopNetwork(BatchChangeDesktopNetworkRequest batchChangeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks/batch-change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDesktopNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeDesktopNetworkResponse>(response);
        }

        public SyncInvoker<BatchChangeDesktopNetworkResponse> BatchChangeDesktopNetworkInvoker(BatchChangeDesktopNetworkRequest batchChangeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks/batch-change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDesktopNetworkRequest);
            return new SyncInvoker<BatchChangeDesktopNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 批量删除桌面
        ///
        /// 批量删除桌面，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDesktopsResponse BatchDeleteDesktops(BatchDeleteDesktopsRequest batchDeleteDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDesktopsResponse>(response);
        }

        public SyncInvoker<BatchDeleteDesktopsResponse> BatchDeleteDesktopsInvoker(BatchDeleteDesktopsRequest batchDeleteDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsRequest);
            return new SyncInvoker<BatchDeleteDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDesktopsResponse>);
        }
        
        /// <summary>
        /// 批量解绑用户
        ///
        /// 批量将桌面和用户解绑。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDetachInstancesResponse BatchDetachInstances(BatchDetachInstancesRequest batchDetachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDetachInstancesResponse>(response);
        }

        public SyncInvoker<BatchDetachInstancesResponse> BatchDetachInstancesInvoker(BatchDetachInstancesRequest batchDetachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInstancesRequest);
            return new SyncInvoker<BatchDetachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDetachInstancesResponse>);
        }
        
        /// <summary>
        /// 安装agent
        ///
        /// 批量为桌面安装agent。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchInstallAgentResponse BatchInstallAgent(BatchInstallAgentRequest batchInstallAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchInstallAgentResponse>(response);
        }

        public SyncInvoker<BatchInstallAgentResponse> BatchInstallAgentInvoker(BatchInstallAgentRequest batchInstallAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAgentRequest);
            return new SyncInvoker<BatchInstallAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchInstallAgentResponse>);
        }
        
        /// <summary>
        /// 批量注销桌面
        ///
        /// 批量注销桌面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchLogoffDesktopsResponse BatchLogoffDesktops(BatchLogoffDesktopsRequest batchLogoffDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLogoffDesktopsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchLogoffDesktopsResponse>(response);
        }

        public SyncInvoker<BatchLogoffDesktopsResponse> BatchLogoffDesktopsInvoker(BatchLogoffDesktopsRequest batchLogoffDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLogoffDesktopsRequest);
            return new SyncInvoker<BatchLogoffDesktopsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchLogoffDesktopsResponse>);
        }
        
        /// <summary>
        /// 重建桌面
        ///
        /// 批量重建桌面系统盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRebuildDesktopsSystemDiskResponse BatchRebuildDesktopsSystemDisk(BatchRebuildDesktopsSystemDiskRequest batchRebuildDesktopsSystemDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebuildDesktopsSystemDiskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRebuildDesktopsSystemDiskResponse>(response);
        }

        public SyncInvoker<BatchRebuildDesktopsSystemDiskResponse> BatchRebuildDesktopsSystemDiskInvoker(BatchRebuildDesktopsSystemDiskRequest batchRebuildDesktopsSystemDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebuildDesktopsSystemDiskRequest);
            return new SyncInvoker<BatchRebuildDesktopsSystemDiskResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebuildDesktopsSystemDiskResponse>);
        }
        
        /// <summary>
        /// 操作桌面
        ///
        /// 批量操作桌面，用于批量开机、关机、休眠和重启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRunDesktopsResponse BatchRunDesktops(BatchRunDesktopsRequest batchRunDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRunDesktopsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRunDesktopsResponse>(response);
        }

        public SyncInvoker<BatchRunDesktopsResponse> BatchRunDesktopsInvoker(BatchRunDesktopsRequest batchRunDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRunDesktopsRequest);
            return new SyncInvoker<BatchRunDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRunDesktopsResponse>);
        }
        
        /// <summary>
        /// 取消远程协助
        ///
        /// 取消远程协助。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelRemoteAssistanceResponse CancelRemoteAssistance(CancelRemoteAssistanceRequest cancelRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelRemoteAssistanceRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemoteAssistanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRemoteAssistanceResponse>(response);
        }

        public SyncInvoker<CancelRemoteAssistanceResponse> CancelRemoteAssistanceInvoker(CancelRemoteAssistanceRequest cancelRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelRemoteAssistanceRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemoteAssistanceRequest);
            return new SyncInvoker<CancelRemoteAssistanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRemoteAssistanceResponse>);
        }
        
        /// <summary>
        /// 切换桌面网络
        ///
        /// 切换桌面vpc、子网、ip、安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeDesktopNetworkResponse ChangeDesktopNetwork(ChangeDesktopNetworkRequest changeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDesktopNetworkRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopNetworkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDesktopNetworkResponse>(response);
        }

        public SyncInvoker<ChangeDesktopNetworkResponse> ChangeDesktopNetworkInvoker(ChangeDesktopNetworkRequest changeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDesktopNetworkRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopNetworkRequest);
            return new SyncInvoker<ChangeDesktopNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 桌面转镜像
        ///
        /// 桌面转镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeDesktopToImageResponse ChangeDesktopToImage(ChangeDesktopToImageRequest changeDesktopToImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/desktop-to-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopToImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeDesktopToImageResponse>(response);
        }

        public SyncInvoker<ChangeDesktopToImageResponse> ChangeDesktopToImageInvoker(ChangeDesktopToImageRequest changeDesktopToImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/desktop-to-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopToImageRequest);
            return new SyncInvoker<ChangeDesktopToImageResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeDesktopToImageResponse>);
        }
        
        /// <summary>
        /// 批量修改用户权限组
        ///
        /// 批量修改用户权限组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeUserPrivilegeGroupResponse ChangeUserPrivilegeGroup(ChangeUserPrivilegeGroupRequest changeUserPrivilegeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-user-privilege-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserPrivilegeGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeUserPrivilegeGroupResponse>(response);
        }

        public SyncInvoker<ChangeUserPrivilegeGroupResponse> ChangeUserPrivilegeGroupInvoker(ChangeUserPrivilegeGroupRequest changeUserPrivilegeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-user-privilege-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserPrivilegeGroupRequest);
            return new SyncInvoker<ChangeUserPrivilegeGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeUserPrivilegeGroupResponse>);
        }
        
        /// <summary>
        /// 创建桌面
        ///
        /// 创建桌面，并将此桌面分配给用户，当桌面创建成功后用户可以登录使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopResponse CreateDesktop(CreateDesktopRequest createDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopResponse>(response);
        }

        public SyncInvoker<CreateDesktopResponse> CreateDesktopInvoker(CreateDesktopRequest createDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopRequest);
            return new SyncInvoker<CreateDesktopResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopResponse>);
        }
        
        /// <summary>
        /// 创建远程协助
        ///
        /// 创建远程协助。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRemoteAssistanceResponse CreateRemoteAssistance(CreateRemoteAssistanceRequest createRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRemoteAssistanceRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemoteAssistanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRemoteAssistanceResponse>(response);
        }

        public SyncInvoker<CreateRemoteAssistanceResponse> CreateRemoteAssistanceInvoker(CreateRemoteAssistanceRequest createRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRemoteAssistanceRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemoteAssistanceRequest);
            return new SyncInvoker<CreateRemoteAssistanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRemoteAssistanceResponse>);
        }
        
        /// <summary>
        /// 删除单个桌面
        ///
        /// 删除单个桌面，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDesktopResponse DeleteDesktop(DeleteDesktopRequest deleteDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDesktopResponse>(response);
        }

        public SyncInvoker<DeleteDesktopResponse> DeleteDesktopInvoker(DeleteDesktopRequest deleteDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopRequest);
            return new SyncInvoker<DeleteDesktopResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDesktopResponse>);
        }
        
        /// <summary>
        /// 解绑用户
        ///
        /// 将桌面和用户解绑。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachInstancesResponse DetachInstances(DetachInstancesRequest detachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetachInstancesResponse>(response);
        }

        public SyncInvoker<DetachInstancesResponse> DetachInstancesInvoker(DetachInstancesRequest detachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInstancesRequest);
            return new SyncInvoker<DetachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachInstancesResponse>);
        }
        
        /// <summary>
        /// 查询桌面安装agent详情
        ///
        /// 展示桌面安装agent详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentsInstallConditionResponse ListAgentsInstallCondition(ListAgentsInstallConditionRequest listAgentsInstallConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsInstallConditionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgentsInstallConditionResponse>(response);
        }

        public SyncInvoker<ListAgentsInstallConditionResponse> ListAgentsInstallConditionInvoker(ListAgentsInstallConditionRequest listAgentsInstallConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsInstallConditionRequest);
            return new SyncInvoker<ListAgentsInstallConditionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentsInstallConditionResponse>);
        }
        
        /// <summary>
        /// 查询桌面开关机信息
        ///
        /// 获取桌面开关机信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopActionsResponse ListDesktopActions(ListDesktopActionsRequest listDesktopActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopActionsRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopActionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopActionsResponse>(response);
        }

        public SyncInvoker<ListDesktopActionsResponse> ListDesktopActionsInvoker(ListDesktopActionsRequest listDesktopActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopActionsRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopActionsRequest);
            return new SyncInvoker<ListDesktopActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopActionsResponse>);
        }
        
        /// <summary>
        /// 查询桌面列表
        ///
        /// 该接口用于查询桌面虚拟机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopsResponse ListDesktops(ListDesktopsRequest listDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsResponse>(response);
        }

        public SyncInvoker<ListDesktopsResponse> ListDesktopsInvoker(ListDesktopsRequest listDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsRequest);
            return new SyncInvoker<ListDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询桌面连接状态列表
        ///
        /// 查询桌面连接状态列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopsConnectStatusResponse ListDesktopsConnectStatus(ListDesktopsConnectStatusRequest listDesktopsConnectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connect-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsConnectStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsConnectStatusResponse>(response);
        }

        public SyncInvoker<ListDesktopsConnectStatusResponse> ListDesktopsConnectStatusInvoker(ListDesktopsConnectStatusRequest listDesktopsConnectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connect-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsConnectStatusRequest);
            return new SyncInvoker<ListDesktopsConnectStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsConnectStatusResponse>);
        }
        
        /// <summary>
        /// 查询桌面详情列表
        ///
        /// 查询桌面详情信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopsDetailResponse ListDesktopsDetail(ListDesktopsDetailRequest listDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsDetailResponse>(response);
        }

        public SyncInvoker<ListDesktopsDetailResponse> ListDesktopsDetailInvoker(ListDesktopsDetailRequest listDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsDetailRequest);
            return new SyncInvoker<ListDesktopsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsDetailResponse>);
        }
        
        /// <summary>
        /// 重新加入AD域
        ///
        /// 该接口用于Windows桌面重新加入AD域，一般用于解决桌面脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterDomainResponse RegisterDomain(RegisterDomainRequest registerDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerDomainRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterDomainResponse>(response);
        }

        public SyncInvoker<RegisterDomainResponse> RegisterDomainInvoker(RegisterDomainRequest registerDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerDomainRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDomainRequest);
            return new SyncInvoker<RegisterDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterDomainResponse>);
        }
        
        /// <summary>
        /// 变更规格
        ///
        /// 变更云桌面规格，只支持变更CPU和内存，不支持变更磁盘，不支持同规格互相变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeDesktopResponse ResizeDesktop(ResizeDesktopRequest resizeDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeDesktopResponse>(response);
        }

        public SyncInvoker<ResizeDesktopResponse> ResizeDesktopInvoker(ResizeDesktopRequest resizeDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopRequest);
            return new SyncInvoker<ResizeDesktopResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeDesktopResponse>);
        }
        
        /// <summary>
        /// 发送消息通知
        ///
        /// 用于管理员向桌面发送消息通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendNotificationsResponse SendNotifications(SendNotificationsRequest sendNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendNotificationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendNotificationsResponse>(response);
        }

        public SyncInvoker<SendNotificationsResponse> SendNotificationsInvoker(SendNotificationsRequest sendNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendNotificationsRequest);
            return new SyncInvoker<SendNotificationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SendNotificationsResponse>);
        }
        
        /// <summary>
        /// 批量设置桌面维护模式
        ///
        /// 批量设置桌面管理员维护模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetMaintenanceModeResponse SetMaintenanceMode(SetMaintenanceModeRequest setMaintenanceModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/maintenance-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMaintenanceModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMaintenanceModeResponse>(response);
        }

        public SyncInvoker<SetMaintenanceModeResponse> SetMaintenanceModeInvoker(SetMaintenanceModeRequest setMaintenanceModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/maintenance-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMaintenanceModeRequest);
            return new SyncInvoker<SetMaintenanceModeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMaintenanceModeResponse>);
        }
        
        /// <summary>
        /// 查询单个桌面详情
        ///
        /// 指定桌面Id查询详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopDetailResponse ShowDesktopDetail(ShowDesktopDetailRequest showDesktopDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopDetailRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopDetailResponse>(response);
        }

        public SyncInvoker<ShowDesktopDetailResponse> ShowDesktopDetailInvoker(ShowDesktopDetailRequest showDesktopDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopDetailRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopDetailRequest);
            return new SyncInvoker<ShowDesktopDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopDetailResponse>);
        }
        
        /// <summary>
        /// 查询桌面监控信息
        ///
        /// 该接口可获取某一计算机在一段时间段(范围：1小时到30天)的数据信息（例如CPU占用率、内存占用率、用户的在线时间段等），最长数据保存时间不能超过180天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopMonitorDataResponse ShowDesktopMonitorData(ShowDesktopMonitorDataRequest showDesktopMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopMonitorDataRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-monitor/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopMonitorDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopMonitorDataResponse>(response);
        }

        public SyncInvoker<ShowDesktopMonitorDataResponse> ShowDesktopMonitorDataInvoker(ShowDesktopMonitorDataRequest showDesktopMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopMonitorDataRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-monitor/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopMonitorDataRequest);
            return new SyncInvoker<ShowDesktopMonitorDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopMonitorDataResponse>);
        }
        
        /// <summary>
        /// 查询桌面网络
        ///
        /// 查询桌面vpc、子网、privateIp、EIP、安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopNetworkResponse ShowDesktopNetwork(ShowDesktopNetworkRequest showDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopNetworkRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopNetworkResponse>(response);
        }

        public SyncInvoker<ShowDesktopNetworkResponse> ShowDesktopNetworkInvoker(ShowDesktopNetworkRequest showDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopNetworkRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworkRequest);
            return new SyncInvoker<ShowDesktopNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 批量查询桌面网络
        ///
        /// 查询桌面vpc、子网、privateIp、EIP、安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopNetworksResponse ShowDesktopNetworks(ShowDesktopNetworksRequest showDesktopNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopNetworksResponse>(response);
        }

        public SyncInvoker<ShowDesktopNetworksResponse> ShowDesktopNetworksInvoker(ShowDesktopNetworksRequest showDesktopNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworksRequest);
            return new SyncInvoker<ShowDesktopNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopNetworksResponse>);
        }
        
        /// <summary>
        /// 根据桌面id查询远程协助信息
        ///
        /// 根据桌面id查询远程协助信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopRemoteAssistanceInfoResponse ShowDesktopRemoteAssistanceInfo(ShowDesktopRemoteAssistanceInfoRequest showDesktopRemoteAssistanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopRemoteAssistanceInfoRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopRemoteAssistanceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopRemoteAssistanceInfoResponse>(response);
        }

        public SyncInvoker<ShowDesktopRemoteAssistanceInfoResponse> ShowDesktopRemoteAssistanceInfoInvoker(ShowDesktopRemoteAssistanceInfoRequest showDesktopRemoteAssistanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopRemoteAssistanceInfoRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopRemoteAssistanceInfoRequest);
            return new SyncInvoker<ShowDesktopRemoteAssistanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopRemoteAssistanceInfoResponse>);
        }
        
        /// <summary>
        /// 远程登录控制台
        ///
        /// 用于直接获取远程登录控制台地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRemoteConsoleAddressResponse ShowRemoteConsoleAddress(ShowRemoteConsoleAddressRequest showRemoteConsoleAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteConsoleAddressRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-consoles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteConsoleAddressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRemoteConsoleAddressResponse>(response);
        }

        public SyncInvoker<ShowRemoteConsoleAddressResponse> ShowRemoteConsoleAddressInvoker(ShowRemoteConsoleAddressRequest showRemoteConsoleAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteConsoleAddressRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-consoles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteConsoleAddressRequest);
            return new SyncInvoker<ShowRemoteConsoleAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemoteConsoleAddressResponse>);
        }
        
        /// <summary>
        /// 查询sysprep版本信息
        ///
        /// 查询sysprep版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSysprepInfoResponse ShowSysprepInfo(ShowSysprepInfoRequest showSysprepInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSysprepInfoRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/sysprep", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSysprepInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSysprepInfoResponse>(response);
        }

        public SyncInvoker<ShowSysprepInfoResponse> ShowSysprepInfoInvoker(ShowSysprepInfoRequest showSysprepInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSysprepInfoRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/sysprep", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSysprepInfoRequest);
            return new SyncInvoker<ShowSysprepInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSysprepInfoResponse>);
        }
        
        /// <summary>
        /// 修改桌面属性
        ///
        /// 修改桌面属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDesktopResponse UpdateDesktop(UpdateDesktopRequest updateDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDesktopResponse>(response);
        }

        public SyncInvoker<UpdateDesktopResponse> UpdateDesktopInvoker(UpdateDesktopRequest updateDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopRequest);
            return new SyncInvoker<UpdateDesktopResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDesktopResponse>);
        }
        
        /// <summary>
        /// 更新桌面SID
        ///
        /// 该接口用于桌面sid和WindowsAD中的SID不同时，更新桌面SID使其与AD中的SID保持一致，一般用于解决桌面脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDesktopSidsResponse UpdateDesktopSids(UpdateDesktopSidsRequest updateDesktopSidsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/sids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopSidsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopSidsResponse>(response);
        }

        public SyncInvoker<UpdateDesktopSidsResponse> UpdateDesktopSidsInvoker(UpdateDesktopSidsRequest updateDesktopSidsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/sids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopSidsRequest);
            return new SyncInvoker<UpdateDesktopSidsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopSidsResponse>);
        }
        
        /// <summary>
        /// AD场景支持桌面更换关联用户名
        ///
        /// AD场景支持桌面更换关联用户名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDesktopUsernameResponse UpdateDesktopUsername(UpdateDesktopUsernameRequest updateDesktopUsernameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-username", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopUsernameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopUsernameResponse>(response);
        }

        public SyncInvoker<UpdateDesktopUsernameResponse> UpdateDesktopUsernameInvoker(UpdateDesktopUsernameRequest updateDesktopUsernameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-username", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopUsernameRequest);
            return new SyncInvoker<UpdateDesktopUsernameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopUsernameResponse>);
        }
        
        /// <summary>
        /// 批量删除桌面名称策略
        ///
        /// 批量删除桌面名称策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDesktopNamePolicyResponse BatchDeleteDesktopNamePolicy(BatchDeleteDesktopNamePolicyRequest batchDeleteDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopNamePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDesktopNamePolicyResponse>(response);
        }

        public SyncInvoker<BatchDeleteDesktopNamePolicyResponse> BatchDeleteDesktopNamePolicyInvoker(BatchDeleteDesktopNamePolicyRequest batchDeleteDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopNamePolicyRequest);
            return new SyncInvoker<BatchDeleteDesktopNamePolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 创建桌面名称策略
        ///
        /// 创建桌面名称策略，用于自动生成桌面名称，最多允许50个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopNamePolicyResponse CreateDesktopNamePolicy(CreateDesktopNamePolicyRequest createDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopNamePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopNamePolicyResponse>(response);
        }

        public SyncInvoker<CreateDesktopNamePolicyResponse> CreateDesktopNamePolicyInvoker(CreateDesktopNamePolicyRequest createDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopNamePolicyRequest);
            return new SyncInvoker<CreateDesktopNamePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 获取桌面名称策略
        ///
        /// 获取桌面名称策略，用于自动生成桌面名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopNamePolicyResponse ListDesktopNamePolicy(ListDesktopNamePolicyRequest listDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopNamePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopNamePolicyResponse>(response);
        }

        public SyncInvoker<ListDesktopNamePolicyResponse> ListDesktopNamePolicyInvoker(ListDesktopNamePolicyRequest listDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopNamePolicyRequest);
            return new SyncInvoker<ListDesktopNamePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 更新桌面名称策略
        ///
        /// 更新桌面名称策略，用于自动生成桌面名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDesktopNamePolicyResponse UpdateDesktopNamePolicy(UpdateDesktopNamePolicyRequest updateDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopNamePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopNamePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopNamePolicyResponse>(response);
        }

        public SyncInvoker<UpdateDesktopNamePolicyResponse> UpdateDesktopNamePolicyInvoker(UpdateDesktopNamePolicyRequest updateDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopNamePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopNamePolicyRequest);
            return new SyncInvoker<UpdateDesktopNamePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 桌面池批量添加磁盘
        ///
        /// 桌面池批量添加磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDesktopPoolVolumesResponse AddDesktopPoolVolumes(AddDesktopPoolVolumesRequest addDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopPoolVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopPoolVolumesResponse>(response);
        }

        public SyncInvoker<AddDesktopPoolVolumesResponse> AddDesktopPoolVolumesInvoker(AddDesktopPoolVolumesRequest addDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopPoolVolumesRequest);
            return new SyncInvoker<AddDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 创建桌面池
        ///
        /// 创建桌面池，可将此桌面池分配给用户、用户组，用户登录时会绑定其中一个桌面。
        /// 注:需通过开通委托功能接口先对云服务进行授权才可以使用该功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopPoolResponse CreateDesktopPool(CreateDesktopPoolRequest createDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopPoolResponse>(response);
        }

        public SyncInvoker<CreateDesktopPoolResponse> CreateDesktopPoolInvoker(CreateDesktopPoolRequest createDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolRequest);
            return new SyncInvoker<CreateDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池授权用户、用户组
        ///
        /// 该接口用于桌面池授权用户、用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopPoolAuthorizedObjectsResponse CreateDesktopPoolAuthorizedObjects(CreateDesktopPoolAuthorizedObjectsRequest createDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDesktopPoolAuthorizedObjectsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolAuthorizedObjectsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDesktopPoolAuthorizedObjectsResponse>(response);
        }

        public SyncInvoker<CreateDesktopPoolAuthorizedObjectsResponse> CreateDesktopPoolAuthorizedObjectsInvoker(CreateDesktopPoolAuthorizedObjectsRequest createDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDesktopPoolAuthorizedObjectsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolAuthorizedObjectsRequest);
            return new SyncInvoker<CreateDesktopPoolAuthorizedObjectsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDesktopPoolAuthorizedObjectsResponse>);
        }
        
        /// <summary>
        /// 删除桌面池
        ///
        /// 当桌面池内无桌面时可删除桌面池，桌面池删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDesktopPoolResponse DeleteDesktopPool(DeleteDesktopPoolRequest deleteDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDesktopPoolResponse>(response);
        }

        public SyncInvoker<DeleteDesktopPoolResponse> DeleteDesktopPoolInvoker(DeleteDesktopPoolRequest deleteDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolRequest);
            return new SyncInvoker<DeleteDesktopPoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池批量删除磁盘
        ///
        /// 桌面池批量删除磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDesktopPoolVolumesResponse DeleteDesktopPoolVolumes(DeleteDesktopPoolVolumesRequest deleteDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopPoolVolumesResponse>(response);
        }

        public SyncInvoker<DeleteDesktopPoolVolumesResponse> DeleteDesktopPoolVolumesInvoker(DeleteDesktopPoolVolumesRequest deleteDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolVolumesRequest);
            return new SyncInvoker<DeleteDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 操作桌面池
        ///
        /// 操作桌面池，用于桌面池里面的桌面批量开机、关机、重启和休眠。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteDesktopPoolActionResponse ExecuteDesktopPoolAction(ExecuteDesktopPoolActionRequest executeDesktopPoolActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeDesktopPoolActionRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteDesktopPoolActionResponse>(response);
        }

        public SyncInvoker<ExecuteDesktopPoolActionResponse> ExecuteDesktopPoolActionInvoker(ExecuteDesktopPoolActionRequest executeDesktopPoolActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeDesktopPoolActionRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolActionRequest);
            return new SyncInvoker<ExecuteDesktopPoolActionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteDesktopPoolActionResponse>);
        }
        
        /// <summary>
        /// 桌面池批量执行脚本
        ///
        /// 桌面池批量执行脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteDesktopPoolScriptResponse ExecuteDesktopPoolScript(ExecuteDesktopPoolScriptRequest executeDesktopPoolScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeDesktopPoolScriptRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolScriptRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteDesktopPoolScriptResponse>(response);
        }

        public SyncInvoker<ExecuteDesktopPoolScriptResponse> ExecuteDesktopPoolScriptInvoker(ExecuteDesktopPoolScriptRequest executeDesktopPoolScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeDesktopPoolScriptRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolScriptRequest);
            return new SyncInvoker<ExecuteDesktopPoolScriptResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteDesktopPoolScriptResponse>);
        }
        
        /// <summary>
        /// 扩容桌面池
        ///
        /// 扩容桌面池。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandDesktopPoolResponse ExpandDesktopPool(ExpandDesktopPoolRequest expandDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopPoolResponse>(response);
        }

        public SyncInvoker<ExpandDesktopPoolResponse> ExpandDesktopPoolInvoker(ExpandDesktopPoolRequest expandDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolRequest);
            return new SyncInvoker<ExpandDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池批量扩容磁盘
        ///
        /// 桌面池批量扩容磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandDesktopPoolVolumesResponse ExpandDesktopPoolVolumes(ExpandDesktopPoolVolumesRequest expandDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopPoolVolumesResponse>(response);
        }

        public SyncInvoker<ExpandDesktopPoolVolumesResponse> ExpandDesktopPoolVolumesInvoker(ExpandDesktopPoolVolumesRequest expandDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopPoolVolumesRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolVolumesRequest);
            return new SyncInvoker<ExpandDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 查询桌面池授权的用户、用户组
        ///
        /// 该接口用于查询指定桌面池授权的用户、用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopPoolAuthorizedObjectsResponse ListDesktopPoolAuthorizedObjects(ListDesktopPoolAuthorizedObjectsRequest listDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopPoolAuthorizedObjectsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolAuthorizedObjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopPoolAuthorizedObjectsResponse>(response);
        }

        public SyncInvoker<ListDesktopPoolAuthorizedObjectsResponse> ListDesktopPoolAuthorizedObjectsInvoker(ListDesktopPoolAuthorizedObjectsRequest listDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopPoolAuthorizedObjectsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolAuthorizedObjectsRequest);
            return new SyncInvoker<ListDesktopPoolAuthorizedObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopPoolAuthorizedObjectsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池列表
        ///
        /// 该接口用于查询桌面池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopPoolsResponse ListDesktopPools(ListDesktopPoolsRequest listDesktopPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopPoolsResponse>(response);
        }

        public SyncInvoker<ListDesktopPoolsResponse> ListDesktopPoolsInvoker(ListDesktopPoolsRequest listDesktopPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolsRequest);
            return new SyncInvoker<ListDesktopPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopPoolsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池下的桌面信息
        ///
        /// 该接口用于查询桌面池下的桌面信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoolDesktopsDetailResponse ListPoolDesktopsDetail(ListPoolDesktopsDetailRequest listPoolDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolDesktopsDetailRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolDesktopsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoolDesktopsDetailResponse>(response);
        }

        public SyncInvoker<ListPoolDesktopsDetailResponse> ListPoolDesktopsDetailInvoker(ListPoolDesktopsDetailRequest listPoolDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoolDesktopsDetailRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolDesktopsDetailRequest);
            return new SyncInvoker<ListPoolDesktopsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolDesktopsDetailResponse>);
        }
        
        /// <summary>
        /// 桌面池重建系统盘
        ///
        /// 桌面池重建系统盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebuildDesktopPoolResponse RebuildDesktopPool(RebuildDesktopPoolRequest rebuildDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebuildDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildDesktopPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebuildDesktopPoolResponse>(response);
        }

        public SyncInvoker<RebuildDesktopPoolResponse> RebuildDesktopPoolInvoker(RebuildDesktopPoolRequest rebuildDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebuildDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildDesktopPoolRequest);
            return new SyncInvoker<RebuildDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<RebuildDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池变更规格
        ///
        /// 桌面池变更规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeDesktopPoolResponse ResizeDesktopPool(ResizeDesktopPoolRequest resizeDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeDesktopPoolResponse>(response);
        }

        public SyncInvoker<ResizeDesktopPoolResponse> ResizeDesktopPoolInvoker(ResizeDesktopPoolRequest resizeDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopPoolRequest);
            return new SyncInvoker<ResizeDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 发送消息通知
        ///
        /// 用于管理员向桌面发送消息通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendDesktopPoolNotificationsResponse SendDesktopPoolNotifications(SendDesktopPoolNotificationsRequest sendDesktopPoolNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendDesktopPoolNotificationsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDesktopPoolNotificationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendDesktopPoolNotificationsResponse>(response);
        }

        public SyncInvoker<SendDesktopPoolNotificationsResponse> SendDesktopPoolNotificationsInvoker(SendDesktopPoolNotificationsRequest sendDesktopPoolNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendDesktopPoolNotificationsRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDesktopPoolNotificationsRequest);
            return new SyncInvoker<SendDesktopPoolNotificationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SendDesktopPoolNotificationsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池详情
        ///
        /// 指定桌面池Id查询详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopPoolDetailResponse ShowDesktopPoolDetail(ShowDesktopPoolDetailRequest showDesktopPoolDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopPoolDetailRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopPoolDetailResponse>(response);
        }

        public SyncInvoker<ShowDesktopPoolDetailResponse> ShowDesktopPoolDetailInvoker(ShowDesktopPoolDetailRequest showDesktopPoolDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDesktopPoolDetailRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolDetailRequest);
            return new SyncInvoker<ShowDesktopPoolDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopPoolDetailResponse>);
        }
        
        /// <summary>
        /// 查询桌面池的脚本执行任务列表
        ///
        /// 桌面池的脚本执行任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDesktopPoolsScriptExecTasksResponse ShowDesktopPoolsScriptExecTasks(ShowDesktopPoolsScriptExecTasksRequest showDesktopPoolsScriptExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/script-execution-tasks/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolsScriptExecTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopPoolsScriptExecTasksResponse>(response);
        }

        public SyncInvoker<ShowDesktopPoolsScriptExecTasksResponse> ShowDesktopPoolsScriptExecTasksInvoker(ShowDesktopPoolsScriptExecTasksRequest showDesktopPoolsScriptExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/script-execution-tasks/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolsScriptExecTasksRequest);
            return new SyncInvoker<ShowDesktopPoolsScriptExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopPoolsScriptExecTasksResponse>);
        }
        
        /// <summary>
        /// 修改桌面池属性
        ///
        /// 修改桌面池属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDesktopPoolResponse UpdateDesktopPool(UpdateDesktopPoolRequest updateDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopPoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopPoolResponse>(response);
        }

        public SyncInvoker<UpdateDesktopPoolResponse> UpdateDesktopPoolInvoker(UpdateDesktopPoolRequest updateDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDesktopPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopPoolRequest);
            return new SyncInvoker<UpdateDesktopPoolResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 批量添加多个桌面标签
        ///
        /// 同时对多个桌面批量添加标签，如果创建的标签已经存在（key相同）则覆，最大支持100个桌面，每个桌面最大20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddDesktopsTagsResponse BatchAddDesktopsTags(BatchAddDesktopsTagsRequest batchAddDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddDesktopsTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddDesktopsTagsResponse>(response);
        }

        public SyncInvoker<BatchAddDesktopsTagsResponse> BatchAddDesktopsTagsInvoker(BatchAddDesktopsTagsRequest batchAddDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddDesktopsTagsRequest);
            return new SyncInvoker<BatchAddDesktopsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddDesktopsTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加删除标签
        ///
        /// 为指定桌面批量添加或删除标签。创建时，如果创建的标签已经存在（key相同），则覆盖。删除时，如果删除的标签不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchChangeTagsResponse BatchChangeTags(BatchChangeTagsRequest batchChangeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchChangeTagsRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchChangeTagsResponse>(response);
        }

        public SyncInvoker<BatchChangeTagsResponse> BatchChangeTagsInvoker(BatchChangeTagsRequest batchChangeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchChangeTagsRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeTagsRequest);
            return new SyncInvoker<BatchChangeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchChangeTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除多个桌面标签
        ///
        /// 同时对多个桌面批量添加标签，删除时，如果删除的标签不存在默认处理成功，最大支持100个桌面，每个桌面最大20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDesktopsTagsResponse BatchDeleteDesktopsTags(BatchDeleteDesktopsTagsRequest batchDeleteDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDesktopsTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteDesktopsTagsResponse> BatchDeleteDesktopsTagsInvoker(BatchDeleteDesktopsTagsRequest batchDeleteDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsTagsRequest);
            return new SyncInvoker<BatchDeleteDesktopsTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteDesktopsTagsResponse>);
        }
        
        /// <summary>
        /// 创建桌面标签
        ///
        /// 该接口用于为桌面创建标签，一个桌面上最多有10个标签。创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public SyncInvoker<CreateTagResponse> CreateTagInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new SyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除桌面标签
        ///
        /// 该接口用于删除桌面标签。删除时，如果删除的标签不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 使用标签过滤桌面
        ///
        /// 使用标签过滤桌面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopByTagsResponse ListDesktopByTags(ListDesktopByTagsRequest listDesktopByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDesktopByTagsResponse>(response);
        }

        public SyncInvoker<ListDesktopByTagsResponse> ListDesktopByTagsInvoker(ListDesktopByTagsRequest listDesktopByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopByTagsRequest);
            return new SyncInvoker<ListDesktopByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDesktopByTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public SyncInvoker<ListProjectTagsResponse> ListProjectTagsInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new SyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询桌面标签
        ///
        /// 查询指定桌面的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagByDesktopIdResponse ShowTagByDesktopId(ShowTagByDesktopIdRequest showTagByDesktopIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagByDesktopIdRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagByDesktopIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagByDesktopIdResponse>(response);
        }

        public SyncInvoker<ShowTagByDesktopIdResponse> ShowTagByDesktopIdInvoker(ShowTagByDesktopIdRequest showTagByDesktopIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagByDesktopIdRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagByDesktopIdRequest);
            return new SyncInvoker<ShowTagByDesktopIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagByDesktopIdResponse>);
        }
        
        /// <summary>
        /// 批量删除用户组
        ///
        /// 该接口用于批量删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteUserGroupsResponse BatchDeleteUserGroups(BatchDeleteUserGroupsRequest batchDeleteUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUserGroupsResponse>(response);
        }

        public SyncInvoker<BatchDeleteUserGroupsResponse> BatchDeleteUserGroupsInvoker(BatchDeleteUserGroupsRequest batchDeleteUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserGroupsRequest);
            return new SyncInvoker<BatchDeleteUserGroupsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUserGroupsResponse>);
        }
        
        /// <summary>
        /// 创建用户组
        ///
        /// 该接口用于创建用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest createUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserGroupResponse>(response);
        }

        public SyncInvoker<CreateUserGroupResponse> CreateUserGroupInvoker(CreateUserGroupRequest createUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserGroupRequest);
            return new SyncInvoker<CreateUserGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateUserGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest deleteUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserGroupResponse>(response);
        }

        public SyncInvoker<DeleteUserGroupResponse> DeleteUserGroupInvoker(DeleteUserGroupRequest deleteUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserGroupRequest);
            return new SyncInvoker<DeleteUserGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组列表
        ///
        /// 查询用户组列表，支持分页。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest listUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserGroupsResponse>(response);
        }

        public SyncInvoker<ListUserGroupsResponse> ListUserGroupsInvoker(ListUserGroupsRequest listUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGroupsRequest);
            return new SyncInvoker<ListUserGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserGroupsResponse>);
        }
        
        /// <summary>
        /// 查询用户组中的用户
        ///
        /// 该接口用于查询用户组中的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersOfGroupResponse ListUsersOfGroup(ListUsersOfGroupRequest listUsersOfGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersOfGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersOfGroupResponse>(response);
        }

        public SyncInvoker<ListUsersOfGroupResponse> ListUsersOfGroupInvoker(ListUsersOfGroupRequest listUsersOfGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersOfGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfGroupRequest);
            return new SyncInvoker<ListUsersOfGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersOfGroupResponse>);
        }
        
        /// <summary>
        /// 操作用户组
        ///
        /// 操作用户组，如添加用户、删除用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunActionsOnGroupResponse RunActionsOnGroup(RunActionsOnGroupRequest runActionsOnGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsOnGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RunActionsOnGroupResponse>(response);
        }

        public SyncInvoker<RunActionsOnGroupResponse> RunActionsOnGroupInvoker(RunActionsOnGroupRequest runActionsOnGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsOnGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnGroupRequest);
            return new SyncInvoker<RunActionsOnGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunActionsOnGroupResponse>);
        }
        
        /// <summary>
        /// 修改用户组信息
        ///
        /// 该接口用于修改用户组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest updateUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserGroupResponse>(response);
        }

        public SyncInvoker<UpdateUserGroupResponse> UpdateUserGroupInvoker(UpdateUserGroupRequest updateUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserGroupRequest);
            return new SyncInvoker<UpdateUserGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserGroupResponse>);
        }
        
        /// <summary>
        /// 查询产品镜像列表
        ///
        /// 该接口用于查询云桌面支持的产品镜像列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImagesResponse ListImages(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }

        public SyncInvoker<ListImagesResponse> ListImagesInvoker(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            return new SyncInvoker<ListImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImagesResponse>);
        }
        
        /// <summary>
        /// 获取云市场镜像列表
        ///
        /// 获取云市场镜像列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMarketImagesResponse ListMarketImages(ListMarketImagesRequest listMarketImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/market-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketImagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMarketImagesResponse>(response);
        }

        public SyncInvoker<ListMarketImagesResponse> ListMarketImagesInvoker(ListMarketImagesRequest listMarketImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/market-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketImagesRequest);
            return new SyncInvoker<ListMarketImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMarketImagesResponse>);
        }
        
        /// <summary>
        /// 包周期桌面增配变更批量询价
        ///
        /// 包周期桌面增配变更批量询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateAddResourcesResponse EstimateAddResources(EstimateAddResourcesRequest estimateAddResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/add-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateAddResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateAddResourcesResponse>(response);
        }

        public SyncInvoker<EstimateAddResourcesResponse> EstimateAddResourcesInvoker(EstimateAddResourcesRequest estimateAddResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/add-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateAddResourcesRequest);
            return new SyncInvoker<EstimateAddResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateAddResourcesResponse>);
        }
        
        /// <summary>
        /// 批量包周期桌面切换镜像询价
        ///
        /// 批量包周期桌面切换镜像(由不收费镜像变更至收费镜像)询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateChangeImagesResponse EstimateChangeImages(EstimateChangeImagesRequest estimateChangeImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateChangeImagesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateChangeImagesResponse>(response);
        }

        public SyncInvoker<EstimateChangeImagesResponse> EstimateChangeImagesInvoker(EstimateChangeImagesRequest estimateChangeImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateChangeImagesRequest);
            return new SyncInvoker<EstimateChangeImagesResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateChangeImagesResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池添加单个磁盘批量询价
        ///
        /// 包周期桌面池添加单个磁盘批量询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateDesktopPoolAddVolumeResponse EstimateDesktopPoolAddVolume(EstimateDesktopPoolAddVolumeRequest estimateDesktopPoolAddVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/add-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolAddVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolAddVolumeResponse>(response);
        }

        public SyncInvoker<EstimateDesktopPoolAddVolumeResponse> EstimateDesktopPoolAddVolumeInvoker(EstimateDesktopPoolAddVolumeRequest estimateDesktopPoolAddVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/add-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolAddVolumeRequest);
            return new SyncInvoker<EstimateDesktopPoolAddVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolAddVolumeResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池切换镜像批量询价
        ///
        /// 包周期桌面池切换镜像(由不收费镜像变更至收费镜像)批量询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateDesktopPoolChangeImageResponse EstimateDesktopPoolChangeImage(EstimateDesktopPoolChangeImageRequest estimateDesktopPoolChangeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolChangeImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolChangeImageResponse>(response);
        }

        public SyncInvoker<EstimateDesktopPoolChangeImageResponse> EstimateDesktopPoolChangeImageInvoker(EstimateDesktopPoolChangeImageRequest estimateDesktopPoolChangeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolChangeImageRequest);
            return new SyncInvoker<EstimateDesktopPoolChangeImageResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolChangeImageResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池扩容磁盘批量询价
        ///
        /// 包周期桌面池扩容磁盘批量询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateDesktopPoolExtendVolumeResponse EstimateDesktopPoolExtendVolume(EstimateDesktopPoolExtendVolumeRequest estimateDesktopPoolExtendVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolExtendVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolExtendVolumeResponse>(response);
        }

        public SyncInvoker<EstimateDesktopPoolExtendVolumeResponse> EstimateDesktopPoolExtendVolumeInvoker(EstimateDesktopPoolExtendVolumeRequest estimateDesktopPoolExtendVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolExtendVolumeRequest);
            return new SyncInvoker<EstimateDesktopPoolExtendVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolExtendVolumeResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池变更规格批量询价
        ///
        /// 包周期桌面池变更规格批量询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateDesktopPoolResizeResponse EstimateDesktopPoolResize(EstimateDesktopPoolResizeRequest estimateDesktopPoolResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolResizeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolResizeResponse>(response);
        }

        public SyncInvoker<EstimateDesktopPoolResizeResponse> EstimateDesktopPoolResizeInvoker(EstimateDesktopPoolResizeRequest estimateDesktopPoolResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolResizeRequest);
            return new SyncInvoker<EstimateDesktopPoolResizeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolResizeResponse>);
        }
        
        /// <summary>
        /// 重试任务
        ///
        /// 该接口用来对失败的任务进行重试，当前仅支持开户和销户的任务重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunActionsOnWorkspaceJobResponse RunActionsOnWorkspaceJob(RunActionsOnWorkspaceJobRequest runActionsOnWorkspaceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsOnWorkspaceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnWorkspaceJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunActionsOnWorkspaceJobResponse>(response);
        }

        public SyncInvoker<RunActionsOnWorkspaceJobResponse> RunActionsOnWorkspaceJobInvoker(RunActionsOnWorkspaceJobRequest runActionsOnWorkspaceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsOnWorkspaceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnWorkspaceJobRequest);
            return new SyncInvoker<RunActionsOnWorkspaceJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunActionsOnWorkspaceJobResponse>);
        }
        
        /// <summary>
        /// 删除子任务
        ///
        /// 该接口用于删除子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSubJobsResponse BatchDeleteSubJobs(BatchDeleteSubJobsRequest batchDeleteSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSubJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubJobsResponse>(response);
        }

        public SyncInvoker<BatchDeleteSubJobsResponse> BatchDeleteSubJobsInvoker(BatchDeleteSubJobsRequest batchDeleteSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSubJobsRequest);
            return new SyncInvoker<BatchDeleteSubJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务查询
        ///
        /// 该接口用于查询异步任务执行情况，比如查询创建桌面的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListItaSubJobsResponse ListItaSubJobs(ListItaSubJobsRequest listItaSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItaSubJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListItaSubJobsResponse>(response);
        }

        public SyncInvoker<ListItaSubJobsResponse> ListItaSubJobsInvoker(ListItaSubJobsRequest listItaSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItaSubJobsRequest);
            return new SyncInvoker<ListItaSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListItaSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询任务详情
        ///
        /// 该接口用于查询异步任务的执行情况，比如查询创建桌面任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public SyncInvoker<ShowJobResponse> ShowJobInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new SyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 查询租户的NAT映射配置项
        ///
        /// 查询租户的NAT映射配置项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatMappingConfigsResponse ListNatMappingConfigs(ListNatMappingConfigsRequest listNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatMappingConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatMappingConfigsResponse>(response);
        }

        public SyncInvoker<ListNatMappingConfigsResponse> ListNatMappingConfigsInvoker(ListNatMappingConfigsRequest listNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatMappingConfigsRequest);
            return new SyncInvoker<ListNatMappingConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatMappingConfigsResponse>);
        }
        
        /// <summary>
        /// 修改租户的NAT映射配置项
        ///
        /// 修改租户的NAT映射配置项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNatMappingConfigsResponse UpdateNatMappingConfigs(UpdateNatMappingConfigsRequest updateNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatMappingConfigsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateNatMappingConfigsResponse>(response);
        }

        public SyncInvoker<UpdateNatMappingConfigsResponse> UpdateNatMappingConfigsInvoker(UpdateNatMappingConfigsRequest updateNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatMappingConfigsRequest);
            return new SyncInvoker<UpdateNatMappingConfigsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNatMappingConfigsResponse>);
        }
        
        /// <summary>
        /// 开通桌面上网功能
        ///
        /// 开通桌面上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyDesktopsInternetResponse ApplyDesktopsInternet(ApplyDesktopsInternetRequest applyDesktopsInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDesktopsInternetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplyDesktopsInternetResponse>(response);
        }

        public SyncInvoker<ApplyDesktopsInternetResponse> ApplyDesktopsInternetInvoker(ApplyDesktopsInternetRequest applyDesktopsInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDesktopsInternetRequest);
            return new SyncInvoker<ApplyDesktopsInternetResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyDesktopsInternetResponse>);
        }
        
        /// <summary>
        /// 开通上网功能
        ///
        /// 开通上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyInternetResponse ApplyInternet(ApplyInternetRequest applyInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyInternetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ApplyInternetResponse>(response);
        }

        public SyncInvoker<ApplyInternetResponse> ApplyInternetInvoker(ApplyInternetRequest applyInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyInternetRequest);
            return new SyncInvoker<ApplyInternetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ApplyInternetResponse>);
        }
        
        /// <summary>
        /// 创建云办公带宽
        ///
        /// 创建按需云办公带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplySubnetBandwidthResponse ApplySubnetBandwidth(ApplySubnetBandwidthRequest applySubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applySubnetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplySubnetBandwidthResponse>(response);
        }

        public SyncInvoker<ApplySubnetBandwidthResponse> ApplySubnetBandwidthInvoker(ApplySubnetBandwidthRequest applySubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applySubnetBandwidthRequest);
            return new SyncInvoker<ApplySubnetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplySubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 桌面绑定EIP
        ///
        /// 桌面绑定EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateDesktopsEipResponse AssociateDesktopsEip(AssociateDesktopsEipRequest associateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateDesktopsEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateDesktopsEipResponse>(response);
        }

        public SyncInvoker<AssociateDesktopsEipResponse> AssociateDesktopsEipInvoker(AssociateDesktopsEipRequest associateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateDesktopsEipRequest);
            return new SyncInvoker<AssociateDesktopsEipResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateDesktopsEipResponse>);
        }
        
        /// <summary>
        /// 批量桌面解绑EIP
        ///
        /// 批量桌面解绑EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDisassociateDesktopsEipResponse BatchDisassociateDesktopsEip(BatchDisassociateDesktopsEipRequest batchDisassociateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisassociateDesktopsEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisassociateDesktopsEipResponse>(response);
        }

        public SyncInvoker<BatchDisassociateDesktopsEipResponse> BatchDisassociateDesktopsEipInvoker(BatchDisassociateDesktopsEipRequest batchDisassociateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisassociateDesktopsEipRequest);
            return new SyncInvoker<BatchDisassociateDesktopsEipResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisassociateDesktopsEipResponse>);
        }
        
        /// <summary>
        /// 删除云办公带宽
        ///
        /// 删除云办公带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubnetBandwidthResponse DeleteSubnetBandwidth(DeleteSubnetBandwidthRequest deleteSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetBandwidthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSubnetBandwidthResponse>(response);
        }

        public SyncInvoker<DeleteSubnetBandwidthResponse> DeleteSubnetBandwidthInvoker(DeleteSubnetBandwidthRequest deleteSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetBandwidthRequest);
            return new SyncInvoker<DeleteSubnetBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询已绑定桌面和未绑定的EIP
        ///
        /// 查询已绑定桌面和未绑定的EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopsEipsResponse ListDesktopsEips(ListDesktopsEipsRequest listDesktopsEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsEipsResponse>(response);
        }

        public SyncInvoker<ListDesktopsEipsResponse> ListDesktopsEipsInvoker(ListDesktopsEipsRequest listDesktopsEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsEipsRequest);
            return new SyncInvoker<ListDesktopsEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsEipsResponse>);
        }
        
        /// <summary>
        /// 查询上网功能
        ///
        /// 查询上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetResponse ListInternet(ListInternetRequest listInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInternetResponse>(response);
        }

        public SyncInvoker<ListInternetResponse> ListInternetInvoker(ListInternetRequest listInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetRequest);
            return new SyncInvoker<ListInternetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetResponse>);
        }
        
        /// <summary>
        /// 查询NAT网关列表
        ///
        /// 查询NAT网关列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewaysResponse ListNatGateways(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaysResponse>(response);
        }

        public SyncInvoker<ListNatGatewaysResponse> ListNatGatewaysInvoker(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            return new SyncInvoker<ListNatGatewaysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaysResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询端口列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPortsResponse ListPorts(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }

        public SyncInvoker<ListPortsResponse> ListPortsInvoker(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            return new SyncInvoker<ListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPortsResponse>);
        }
        
        /// <summary>
        /// 查询云办公带宽列表
        ///
        /// 查询云办公带宽列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubnetBandwidthsResponse ListSubnetBandwidths(ListSubnetBandwidthsRequest listSubnetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetBandwidthsResponse>(response);
        }

        public SyncInvoker<ListSubnetBandwidthsResponse> ListSubnetBandwidthsInvoker(ListSubnetBandwidthsRequest listSubnetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetBandwidthsRequest);
            return new SyncInvoker<ListSubnetBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询云办公带宽的控制配置
        ///
        /// 查询云办公带宽的控制配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubnetBandwidthControlListResponse ShowSubnetBandwidthControlList(ShowSubnetBandwidthControlListRequest showSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetBandwidthControlListRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetBandwidthControlListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetBandwidthControlListResponse>(response);
        }

        public SyncInvoker<ShowSubnetBandwidthControlListResponse> ShowSubnetBandwidthControlListInvoker(ShowSubnetBandwidthControlListRequest showSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetBandwidthControlListRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetBandwidthControlListRequest);
            return new SyncInvoker<ShowSubnetBandwidthControlListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetBandwidthControlListResponse>);
        }
        
        /// <summary>
        /// 查询正在被使用的子网id列表
        ///
        /// 根据子网id列表查询正在被桌面使用的子网id，并且返回subnetId列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUsingSubnetsResponse ShowUsingSubnets(ShowUsingSubnetsRequest showUsingSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/using-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUsingSubnetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUsingSubnetsResponse>(response);
        }

        public SyncInvoker<ShowUsingSubnetsResponse> ShowUsingSubnetsInvoker(ShowUsingSubnetsRequest showUsingSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/using-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUsingSubnetsRequest);
            return new SyncInvoker<ShowUsingSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUsingSubnetsResponse>);
        }
        
        /// <summary>
        /// 修改云办公带宽
        ///
        /// 修改云办公带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubnetBandwidthResponse UpdateSubnetBandwidth(UpdateSubnetBandwidthRequest updateSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSubnetBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateSubnetBandwidthResponse> UpdateSubnetBandwidthInvoker(UpdateSubnetBandwidthRequest updateSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthRequest);
            return new SyncInvoker<UpdateSubnetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 修改云办公带宽的控制配置
        ///
        /// 修改云办公带宽的控制配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubnetBandwidthControlListResponse UpdateSubnetBandwidthControlList(UpdateSubnetBandwidthControlListRequest updateSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetBandwidthControlListRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthControlListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubnetBandwidthControlListResponse>(response);
        }

        public SyncInvoker<UpdateSubnetBandwidthControlListResponse> UpdateSubnetBandwidthControlListInvoker(UpdateSubnetBandwidthControlListRequest updateSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetBandwidthControlListRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthControlListRequest);
            return new SyncInvoker<UpdateSubnetBandwidthControlListResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubnetBandwidthControlListResponse>);
        }
        
        /// <summary>
        /// 创建变更订单
        ///
        /// 变更规格、扩容磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateChangeOrderResponse CreateChangeOrder(CreateChangeOrderRequest createChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createChangeOrderRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/{desktop_id}/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createChangeOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateChangeOrderResponse>(response);
        }

        public SyncInvoker<CreateChangeOrderResponse> CreateChangeOrderInvoker(CreateChangeOrderRequest createChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createChangeOrderRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/{desktop_id}/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createChangeOrderRequest);
            return new SyncInvoker<CreateChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateChangeOrderResponse>);
        }
        
        /// <summary>
        /// 包周期桌面批量变更下单
        ///
        /// 包周期桌面批量变更下单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopBatchOrderResponse CreateDesktopBatchOrder(CreateDesktopBatchOrderRequest createDesktopBatchOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/change/batch-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopBatchOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopBatchOrderResponse>(response);
        }

        public SyncInvoker<CreateDesktopBatchOrderResponse> CreateDesktopBatchOrderInvoker(CreateDesktopBatchOrderRequest createDesktopBatchOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/change/batch-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopBatchOrderRequest);
            return new SyncInvoker<CreateDesktopBatchOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopBatchOrderResponse>);
        }
        
        /// <summary>
        /// 创建桌面订单
        ///
        /// 创建桌面订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopOrderResponse CreateDesktopOrder(CreateDesktopOrderRequest createDesktopOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/orders/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopOrderResponse>(response);
        }

        public SyncInvoker<CreateDesktopOrderResponse> CreateDesktopOrderInvoker(CreateDesktopOrderRequest createDesktopOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/orders/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopOrderRequest);
            return new SyncInvoker<CreateDesktopOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopOrderResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池批量变更下单
        ///
        /// 包周期桌面池批量变更下单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopPoolChangeOrderResponse CreateDesktopPoolChangeOrder(CreateDesktopPoolChangeOrderRequest createDesktopPoolChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolChangeOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopPoolChangeOrderResponse>(response);
        }

        public SyncInvoker<CreateDesktopPoolChangeOrderResponse> CreateDesktopPoolChangeOrderInvoker(CreateDesktopPoolChangeOrderRequest createDesktopPoolChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolChangeOrderRequest);
            return new SyncInvoker<CreateDesktopPoolChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopPoolChangeOrderResponse>);
        }
        
        /// <summary>
        /// 包周期下单
        ///
        /// 包周期资源（桌面、磁盘）下订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrderResponse CreateOrder(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrderResponse>(response);
        }

        public SyncInvoker<CreateOrderResponse> CreateOrderInvoker(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            return new SyncInvoker<CreateOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrderResponse>);
        }
        
        /// <summary>
        /// 包周期云办公带宽变更下单
        ///
        /// 包周期云办公带宽变更下单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubnetBandwidthChangeOrderResponse CreateSubnetBandwidthChangeOrder(CreateSubnetBandwidthChangeOrderRequest createSubnetBandwidthChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubnetBandwidthChangeOrderRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubnetBandwidthChangeOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSubnetBandwidthChangeOrderResponse>(response);
        }

        public SyncInvoker<CreateSubnetBandwidthChangeOrderResponse> CreateSubnetBandwidthChangeOrderInvoker(CreateSubnetBandwidthChangeOrderRequest createSubnetBandwidthChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubnetBandwidthChangeOrderRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubnetBandwidthChangeOrderRequest);
            return new SyncInvoker<CreateSubnetBandwidthChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubnetBandwidthChangeOrderResponse>);
        }
        
        /// <summary>
        /// 新增OU信息
        ///
        /// 该接口用于创建OU。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddOuResponse AddOu(AddOuRequest addOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOuRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddOuResponse>(response);
        }

        public SyncInvoker<AddOuResponse> AddOuInvoker(AddOuRequest addOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOuRequest);
            return new SyncInvoker<AddOuResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOuResponse>);
        }
        
        /// <summary>
        /// 删除OU信息
        ///
        /// 该接口用于删除OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOuResponse DeleteOu(DeleteOuRequest deleteOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOuRequest.OuId, out var valueOfOuId)) urlParam.Add("ou_id", valueOfOuId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOuRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOuResponse>(response);
        }

        public SyncInvoker<DeleteOuResponse> DeleteOuInvoker(DeleteOuRequest deleteOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOuRequest.OuId, out var valueOfOuId)) urlParam.Add("ou_id", valueOfOuId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOuRequest);
            return new SyncInvoker<DeleteOuResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOuResponse>);
        }
        
        /// <summary>
        /// 查询OU下用户信息
        ///
        /// 查询OU下用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAdOuUsersResponse ListAdOuUsers(ListAdOuUsersRequest listAdOuUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ou-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOuUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAdOuUsersResponse>(response);
        }

        public SyncInvoker<ListAdOuUsersResponse> ListAdOuUsersInvoker(ListAdOuUsersRequest listAdOuUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ou-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOuUsersRequest);
            return new SyncInvoker<ListAdOuUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAdOuUsersResponse>);
        }
        
        /// <summary>
        /// 查询AD里的OU列表
        ///
        /// 查询AD里的OU列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAdOusResponse ListAdOus(ListAdOusRequest listAdOusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ad-ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAdOusResponse>(response);
        }

        public SyncInvoker<ListAdOusResponse> ListAdOusInvoker(ListAdOusRequest listAdOusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ad-ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOusRequest);
            return new SyncInvoker<ListAdOusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAdOusResponse>);
        }
        
        /// <summary>
        /// 查询OU列表
        ///
        /// 查询OU列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOuDetailsResponse ListOuDetails(ListOuDetailsRequest listOuDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOuDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOuDetailsResponse>(response);
        }

        public SyncInvoker<ListOuDetailsResponse> ListOuDetailsInvoker(ListOuDetailsRequest listOuDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOuDetailsRequest);
            return new SyncInvoker<ListOuDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOuDetailsResponse>);
        }
        
        /// <summary>
        /// 更新OU信息
        ///
        /// 更新OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOuInfoResponse UpdateOuInfo(UpdateOuInfoRequest updateOuInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOuInfoRequest.OuId, out var valueOfOuId)) urlParam.Add("ou_id", valueOfOuId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOuInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateOuInfoResponse>(response);
        }

        public SyncInvoker<UpdateOuInfoResponse> UpdateOuInfoInvoker(UpdateOuInfoRequest updateOuInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOuInfoRequest.OuId, out var valueOfOuId)) urlParam.Add("ou_id", valueOfOuId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOuInfoRequest);
            return new SyncInvoker<UpdateOuInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateOuInfoResponse>);
        }
        
        /// <summary>
        /// 修改策略组应用对象
        ///
        /// 批量增加、删除应用对象到指定策略组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateTargetOfPolicyGroupResponse BatchUpdateTargetOfPolicyGroup(BatchUpdateTargetOfPolicyGroupRequest batchUpdateTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateTargetOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTargetOfPolicyGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateTargetOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<BatchUpdateTargetOfPolicyGroupResponse> BatchUpdateTargetOfPolicyGroupInvoker(BatchUpdateTargetOfPolicyGroupRequest batchUpdateTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateTargetOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTargetOfPolicyGroupRequest);
            return new SyncInvoker<BatchUpdateTargetOfPolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateTargetOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 新增策略组
        ///
        /// 新增策略组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyGroupResponse>(response);
        }

        public SyncInvoker<CreatePolicyGroupResponse> CreatePolicyGroupInvoker(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            return new SyncInvoker<CreatePolicyGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 删除策略组
        ///
        /// 删除指定策略组，包含策略组对应的策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyGroupResponse DeletePolicyGroup(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>(response);
        }

        public SyncInvoker<DeletePolicyGroupResponse> DeletePolicyGroupInvoker(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            return new SyncInvoker<DeletePolicyGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询初始策略项
        ///
        /// 查询初始策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOriginalPolicyInfoResponse ListOriginalPolicyInfo(ListOriginalPolicyInfoRequest listOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/original-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOriginalPolicyInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOriginalPolicyInfoResponse>(response);
        }

        public SyncInvoker<ListOriginalPolicyInfoResponse> ListOriginalPolicyInfoInvoker(ListOriginalPolicyInfoRequest listOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/original-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOriginalPolicyInfoRequest);
            return new SyncInvoker<ListOriginalPolicyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOriginalPolicyInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组中的策略项
        ///
        /// 查询指定策略组内的策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoliciesOfPolicyGroupResponse ListPoliciesOfPolicyGroup(ListPoliciesOfPolicyGroupRequest listPoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoliciesOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesOfPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListPoliciesOfPolicyGroupResponse> ListPoliciesOfPolicyGroupInvoker(ListPoliciesOfPolicyGroupRequest listPoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPoliciesOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesOfPolicyGroupRequest);
            return new SyncInvoker<ListPoliciesOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组
        ///
        /// 根据策略组ID查询策略组详细信息，包含策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyDetailInfoByIdResponse ListPolicyDetailInfoById(ListPolicyDetailInfoByIdRequest listPolicyDetailInfoByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyDetailInfoByIdRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDetailInfoByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyDetailInfoByIdResponse>(response);
        }

        public SyncInvoker<ListPolicyDetailInfoByIdResponse> ListPolicyDetailInfoByIdInvoker(ListPolicyDetailInfoByIdRequest listPolicyDetailInfoByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyDetailInfoByIdRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDetailInfoByIdRequest);
            return new SyncInvoker<ListPolicyDetailInfoByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyDetailInfoByIdResponse>);
        }
        
        /// <summary>
        /// 查询策略组列表
        ///
        /// 查询策略组概要信息列表，不包含策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyGroupResponse ListPolicyGroup(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListPolicyGroupResponse> ListPolicyGroupInvoker(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            return new SyncInvoker<ListPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情列表
        ///
        /// 包含策略信息以及应用对象的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyGroupInfoResponse ListPolicyGroupInfo(ListPolicyGroupInfoRequest listPolicyGroupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupInfoResponse>(response);
        }

        public SyncInvoker<ListPolicyGroupInfoResponse> ListPolicyGroupInfoInvoker(ListPolicyGroupInfoRequest listPolicyGroupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupInfoRequest);
            return new SyncInvoker<ListPolicyGroupInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组应用对象
        ///
        /// 查询指定策略组所应用的对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTargetOfPolicyGroupResponse ListTargetOfPolicyGroup(ListTargetOfPolicyGroupRequest listTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTargetOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetOfPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTargetOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListTargetOfPolicyGroupResponse> ListTargetOfPolicyGroupInvoker(ListTargetOfPolicyGroupRequest listTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTargetOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetOfPolicyGroupRequest);
            return new SyncInvoker<ListTargetOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTargetOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组中的策略项
        ///
        /// 修改一个策略组的部分或者所有策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePoliciesOfPolicyGroupResponse UpdatePoliciesOfPolicyGroup(UpdatePoliciesOfPolicyGroupRequest updatePoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoliciesOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoliciesOfPolicyGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoliciesOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<UpdatePoliciesOfPolicyGroupResponse> UpdatePoliciesOfPolicyGroupInvoker(UpdatePoliciesOfPolicyGroupRequest updatePoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoliciesOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoliciesOfPolicyGroupRequest);
            return new SyncInvoker<UpdatePoliciesOfPolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoliciesOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组
        ///
        /// 修改指定策略组的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyGroupResponse UpdatePolicyGroup(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyGroupResponse>(response);
        }

        public SyncInvoker<UpdatePolicyGroupResponse> UpdatePolicyGroupInvoker(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            return new SyncInvoker<UpdatePolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询可订购小时包类型
        ///
        /// 该接口用于查询可订购小时包类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHourPackagesTypeResponse ListHourPackagesType(ListHourPackagesTypeRequest listHourPackagesTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/hour-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHourPackagesTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHourPackagesTypeResponse>(response);
        }

        public SyncInvoker<ListHourPackagesTypeResponse> ListHourPackagesTypeInvoker(ListHourPackagesTypeRequest listHourPackagesTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/hour-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHourPackagesTypeRequest);
            return new SyncInvoker<ListHourPackagesTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHourPackagesTypeResponse>);
        }
        
        /// <summary>
        /// 查询产品套餐列表
        ///
        /// 该接口用于查询云桌面支持的产品套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public SyncInvoker<ListProductsResponse> ListProductsInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new SyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 查询协同套餐列表
        ///
        /// 该接口用于查询协同套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSharerProductsResponse ListSharerProducts(ListSharerProductsRequest listSharerProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/sharer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharerProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSharerProductsResponse>(response);
        }

        public SyncInvoker<ListSharerProductsResponse> ListSharerProductsInvoker(ListSharerProductsRequest listSharerProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/sharer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharerProductsRequest);
            return new SyncInvoker<ListSharerProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSharerProductsResponse>);
        }
        
        /// <summary>
        /// 查询租户功能状态
        ///
        /// 查询租户功能状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantProfilesResponse ListTenantProfiles(ListTenantProfilesRequest listTenantProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfilesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTenantProfilesResponse = JsonUtils.DeSerializeNull<ListTenantProfilesResponse>(response);
            listTenantProfilesResponse.Body = JsonUtils.DeSerializeMap<string, bool?>(response);
            return listTenantProfilesResponse;
        }

        public SyncInvoker<ListTenantProfilesResponse> ListTenantProfilesInvoker(ListTenantProfilesRequest listTenantProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfilesRequest);
            return new SyncInvoker<ListTenantProfilesResponse>(this, "GET", request, response =>
            {
                var listTenantProfilesResponse = JsonUtils.DeSerializeNull<ListTenantProfilesResponse>(response);
                listTenantProfilesResponse.Body = JsonUtils.DeSerializeMap<string, bool?>(response);
                return listTenantProfilesResponse;
            });
        }
        
        /// <summary>
        /// 启禁用租户功能
        ///
        /// 启禁用租户功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTenantProfileResponse UpdateTenantProfile(UpdateTenantProfileRequest updateTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantProfileRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTenantProfileResponse>(response);
        }

        public SyncInvoker<UpdateTenantProfileResponse> UpdateTenantProfileInvoker(UpdateTenantProfileRequest updateTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantProfileRequest);
            return new SyncInvoker<UpdateTenantProfileResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateTenantProfileResponse>);
        }
        
        /// <summary>
        /// 查询租户单个站点配额详情
        ///
        /// 查询租户单个站点配额详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaDetailsResponse ShowQuotaDetails(ShowQuotaDetailsRequest showQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaDetailsResponse>(response);
        }

        public SyncInvoker<ShowQuotaDetailsResponse> ShowQuotaDetailsInvoker(ShowQuotaDetailsRequest showQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaDetailsRequest);
            return new SyncInvoker<ShowQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// Console Framework和WKSDesktopManager调用该接口查询租户配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 批量删除定时任务
        ///
        /// 批量删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteScheduledTasksResponse BatchDeleteScheduledTasks(BatchDeleteScheduledTasksRequest batchDeleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduledTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScheduledTasksResponse>(response);
        }

        public SyncInvoker<BatchDeleteScheduledTasksResponse> BatchDeleteScheduledTasksInvoker(BatchDeleteScheduledTasksRequest batchDeleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduledTasksRequest);
            return new SyncInvoker<BatchDeleteScheduledTasksResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 创建定时任务
        ///
        /// 创建定时任务。
        /// 注:需通过开通委托功能接口先对云服务进行授权才可以使用该功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateScheduledTasksResponse CreateScheduledTasks(CreateScheduledTasksRequest createScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduledTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateScheduledTasksResponse>(response);
        }

        public SyncInvoker<CreateScheduledTasksResponse> CreateScheduledTasksInvoker(CreateScheduledTasksRequest createScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduledTasksRequest);
            return new SyncInvoker<CreateScheduledTasksResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 删除定时任务
        ///
        /// 删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduledTasksResponse DeleteScheduledTasks(DeleteScheduledTasksRequest deleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTasksRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduledTasksResponse>(response);
        }

        public SyncInvoker<DeleteScheduledTasksResponse> DeleteScheduledTasksInvoker(DeleteScheduledTasksRequest deleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTasksRequest);
            return new SyncInvoker<DeleteScheduledTasksResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 未来执行的具体时间列表
        ///
        /// 未来执行的具体时间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFutureExecutionsResponse ListFutureExecutions(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFutureExecutionsResponse>(response);
        }

        public SyncInvoker<ListFutureExecutionsResponse> ListFutureExecutionsInvoker(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            return new SyncInvoker<ListFutureExecutionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFutureExecutionsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduledTasksResponse ListScheduledTasks(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksResponse>(response);
        }

        public SyncInvoker<ListScheduledTasksResponse> ListScheduledTasksInvoker(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            return new SyncInvoker<ListScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行记录
        ///
        /// 查询定时任务执行记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduledTasksRecordsResponse ListScheduledTasksRecords(ListScheduledTasksRecordsRequest listScheduledTasksRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksRecordsResponse>(response);
        }

        public SyncInvoker<ListScheduledTasksRecordsResponse> ListScheduledTasksRecordsInvoker(ListScheduledTasksRecordsRequest listScheduledTasksRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsRequest);
            return new SyncInvoker<ListScheduledTasksRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksRecordsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行记录详情
        ///
        /// 查询定时任务执行记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduledTasksRecordsDetailsResponse ListScheduledTasksRecordsDetails(ListScheduledTasksRecordsDetailsRequest listScheduledTasksRecordsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsDetailsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsDetailsRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksRecordsDetailsResponse>(response);
        }

        public SyncInvoker<ListScheduledTasksRecordsDetailsResponse> ListScheduledTasksRecordsDetailsInvoker(ListScheduledTasksRecordsDetailsRequest listScheduledTasksRecordsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsDetailsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRecordsDetailsRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsDetailsRequest);
            return new SyncInvoker<ListScheduledTasksRecordsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksRecordsDetailsResponse>);
        }
        
        /// <summary>
        /// 获取时区配置
        ///
        /// 获取时区配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTimeZonesResponse ListTimeZones(ListTimeZonesRequest listTimeZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/common/timezones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTimeZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTimeZonesResponse>(response);
        }

        public SyncInvoker<ListTimeZonesResponse> ListTimeZonesInvoker(ListTimeZonesRequest listTimeZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/common/timezones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTimeZonesRequest);
            return new SyncInvoker<ListTimeZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTimeZonesResponse>);
        }
        
        /// <summary>
        /// 查询定时任务详情
        ///
        /// 查询定时任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScheduledTasksResponse ShowScheduledTasks(ShowScheduledTasksRequest showScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduledTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScheduledTasksResponse>(response);
        }

        public SyncInvoker<ShowScheduledTasksResponse> ShowScheduledTasksInvoker(ShowScheduledTasksRequest showScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduledTasksRequest);
            return new SyncInvoker<ShowScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 修改定时任务
        ///
        /// 修改定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateScheduledTasksResponse UpdateScheduledTasks(UpdateScheduledTasksRequest updateScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTasksRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScheduledTasksResponse>(response);
        }

        public SyncInvoker<UpdateScheduledTasksResponse> UpdateScheduledTasksInvoker(UpdateScheduledTasksRequest updateScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTasksRequest);
            return new SyncInvoker<UpdateScheduledTasksResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 批量删除录屏记录
        ///
        /// 批量删除录屏记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteScreenRecordsResponse BatchDeleteScreenRecords(BatchDeleteScreenRecordsRequest batchDeleteScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", batchDeleteScreenRecordsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteScreenRecordsResponse>(response);
        }

        public SyncInvoker<BatchDeleteScreenRecordsResponse> BatchDeleteScreenRecordsInvoker(BatchDeleteScreenRecordsRequest batchDeleteScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", batchDeleteScreenRecordsRequest);
            return new SyncInvoker<BatchDeleteScreenRecordsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteScreenRecordsResponse>);
        }
        
        /// <summary>
        /// 查询桌面关键事件列表
        ///
        /// 查询桌面关键事件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopOperationsResponse ListDesktopOperations(ListDesktopOperationsRequest listDesktopOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopOperationsRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}/os-operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopOperationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopOperationsResponse>(response);
        }

        public SyncInvoker<ListDesktopOperationsResponse> ListDesktopOperationsInvoker(ListDesktopOperationsRequest listDesktopOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDesktopOperationsRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}/os-operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopOperationsRequest);
            return new SyncInvoker<ListDesktopOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopOperationsResponse>);
        }
        
        /// <summary>
        /// 查询下载地址列表
        ///
        /// 查询下载地址列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDownloadAddressResponse ListDownloadAddress(ListDownloadAddressRequest listDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/download-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", listDownloadAddressRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDownloadAddressResponse>(response);
        }

        public SyncInvoker<ListDownloadAddressResponse> ListDownloadAddressInvoker(ListDownloadAddressRequest listDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/download-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", listDownloadAddressRequest);
            return new SyncInvoker<ListDownloadAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDownloadAddressResponse>);
        }
        
        /// <summary>
        /// 查询录屏记录列表
        ///
        /// 查询录屏记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScreenRecordsResponse ListScreenRecords(ListScreenRecordsRequest listScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScreenRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScreenRecordsResponse>(response);
        }

        public SyncInvoker<ListScreenRecordsResponse> ListScreenRecordsInvoker(ListScreenRecordsRequest listScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScreenRecordsRequest);
            return new SyncInvoker<ListScreenRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScreenRecordsResponse>);
        }
        
        /// <summary>
        /// 查询录屏详情
        ///
        /// 查询录屏详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScreenRecordResponse ShowScreenRecord(ShowScreenRecordRequest showScreenRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScreenRecordRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScreenRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScreenRecordResponse>(response);
        }

        public SyncInvoker<ShowScreenRecordResponse> ShowScreenRecordInvoker(ShowScreenRecordRequest showScreenRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScreenRecordRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScreenRecordRequest);
            return new SyncInvoker<ShowScreenRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScreenRecordResponse>);
        }
        
        /// <summary>
        /// 新增脚本
        ///
        /// 新增脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateScriptResponse CreateScript(CreateScriptRequest createScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScriptRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScriptResponse>(response);
        }

        public SyncInvoker<CreateScriptResponse> CreateScriptInvoker(CreateScriptRequest createScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScriptRequest);
            return new SyncInvoker<CreateScriptResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScriptResponse>);
        }
        
        /// <summary>
        /// 删除脚本
        ///
        /// 删除脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScriptResponse DeleteScript(DeleteScriptRequest deleteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScriptRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScriptRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScriptResponse>(response);
        }

        public SyncInvoker<DeleteScriptResponse> DeleteScriptInvoker(DeleteScriptRequest deleteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScriptRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScriptRequest);
            return new SyncInvoker<DeleteScriptResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScriptResponse>);
        }
        
        /// <summary>
        /// 批量执行脚本或命令
        ///
        /// 批量执行脚本或命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteScriptOrCommandResponse ExecuteScriptOrCommand(ExecuteScriptOrCommandRequest executeScriptOrCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeScriptOrCommandRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteScriptOrCommandResponse>(response);
        }

        public SyncInvoker<ExecuteScriptOrCommandResponse> ExecuteScriptOrCommandInvoker(ExecuteScriptOrCommandRequest executeScriptOrCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeScriptOrCommandRequest);
            return new SyncInvoker<ExecuteScriptOrCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteScriptOrCommandResponse>);
        }
        
        /// <summary>
        /// 查询脚本执行记录列表
        ///
        /// 查询脚本执行记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScriptRecordsResponse ListScriptRecords(ListScriptRecordsRequest listScriptRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScriptRecordsResponse>(response);
        }

        public SyncInvoker<ListScriptRecordsResponse> ListScriptRecordsInvoker(ListScriptRecordsRequest listScriptRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptRecordsRequest);
            return new SyncInvoker<ListScriptRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptRecordsResponse>);
        }
        
        /// <summary>
        /// 查询脚本任务列表
        ///
        /// 查询脚本任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScriptTasksResponse ListScriptTasks(ListScriptTasksRequest listScriptTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScriptTasksResponse>(response);
        }

        public SyncInvoker<ListScriptTasksResponse> ListScriptTasksInvoker(ListScriptTasksRequest listScriptTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptTasksRequest);
            return new SyncInvoker<ListScriptTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptTasksResponse>);
        }
        
        /// <summary>
        /// 查询脚本列表
        ///
        /// 查询脚本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScriptsResponse ListScripts(ListScriptsRequest listScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScriptsResponse>(response);
        }

        public SyncInvoker<ListScriptsResponse> ListScriptsInvoker(ListScriptsRequest listScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptsRequest);
            return new SyncInvoker<ListScriptsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptsResponse>);
        }
        
        /// <summary>
        /// 重试脚本或执行脚本失败的任务
        ///
        /// 重试脚本或执行脚本失败的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryScriptExecutionResponse RetryScriptExecution(RetryScriptExecutionRequest retryScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryScriptExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetryScriptExecutionResponse>(response);
        }

        public SyncInvoker<RetryScriptExecutionResponse> RetryScriptExecutionInvoker(RetryScriptExecutionRequest retryScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryScriptExecutionRequest);
            return new SyncInvoker<RetryScriptExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryScriptExecutionResponse>);
        }
        
        /// <summary>
        /// 查询脚本详情
        ///
        /// 查询脚本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScriptDetailResponse ShowScriptDetail(ShowScriptDetailRequest showScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScriptDetailRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScriptDetailResponse>(response);
        }

        public SyncInvoker<ShowScriptDetailResponse> ShowScriptDetailInvoker(ShowScriptDetailRequest showScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScriptDetailRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptDetailRequest);
            return new SyncInvoker<ShowScriptDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScriptDetailResponse>);
        }
        
        /// <summary>
        /// 查询脚本执行记录详情
        ///
        /// 查询脚本执行记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScriptRecordDetailResponse ShowScriptRecordDetail(ShowScriptRecordDetailRequest showScriptRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScriptRecordDetailRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptRecordDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScriptRecordDetailResponse>(response);
        }

        public SyncInvoker<ShowScriptRecordDetailResponse> ShowScriptRecordDetailInvoker(ShowScriptRecordDetailRequest showScriptRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScriptRecordDetailRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptRecordDetailRequest);
            return new SyncInvoker<ShowScriptRecordDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScriptRecordDetailResponse>);
        }
        
        /// <summary>
        /// 停止脚本或者命令执行任务
        ///
        /// 停止脚本或者命令执行任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopScriptExecutionResponse StopScriptExecution(StopScriptExecutionRequest stopScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopScriptExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopScriptExecutionResponse>(response);
        }

        public SyncInvoker<StopScriptExecutionResponse> StopScriptExecutionInvoker(StopScriptExecutionRequest stopScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopScriptExecutionRequest);
            return new SyncInvoker<StopScriptExecutionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopScriptExecutionResponse>);
        }
        
        /// <summary>
        /// 更新脚本
        ///
        /// 更新脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateScriptResponse UpdateScript(UpdateScriptRequest updateScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScriptRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScriptRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScriptResponse>(response);
        }

        public SyncInvoker<UpdateScriptResponse> UpdateScriptInvoker(UpdateScriptRequest updateScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScriptRequest.ScriptId, out var valueOfScriptId)) urlParam.Add("script_id", valueOfScriptId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScriptRequest);
            return new SyncInvoker<UpdateScriptResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScriptResponse>);
        }
        
        /// <summary>
        /// 桌面购买附属资源
        ///
        /// 存量桌面购买附属资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDesktopSubResourcesResponse AddDesktopSubResources(AddDesktopSubResourcesRequest addDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopSubResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopSubResourcesResponse>(response);
        }

        public SyncInvoker<AddDesktopSubResourcesResponse> AddDesktopSubResourcesInvoker(AddDesktopSubResourcesRequest addDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopSubResourcesRequest);
            return new SyncInvoker<AddDesktopSubResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopSubResourcesResponse>);
        }
        
        /// <summary>
        /// 桌面删除附属资源
        ///
        /// 桌面删除附属资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDesktopSubResourcesResponse DeleteDesktopSubResources(DeleteDesktopSubResourcesRequest deleteDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/delete-sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopSubResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopSubResourcesResponse>(response);
        }

        public SyncInvoker<DeleteDesktopSubResourcesResponse> DeleteDesktopSubResourcesInvoker(DeleteDesktopSubResourcesRequest deleteDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/delete-sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopSubResourcesRequest);
            return new SyncInvoker<DeleteDesktopSubResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopSubResourcesResponse>);
        }
        
        /// <summary>
        /// 查询协同桌面默认用户配置
        ///
        /// 查询协同桌面默认用户配置（当前功能公测中,需要使用请联系管理员申请使用）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowShareSpaceConfigResponse ShowShareSpaceConfig(ShowShareSpaceConfigRequest showShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareSpaceConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowShareSpaceConfigResponse>(response);
        }

        public SyncInvoker<ShowShareSpaceConfigResponse> ShowShareSpaceConfigInvoker(ShowShareSpaceConfigRequest showShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareSpaceConfigRequest);
            return new SyncInvoker<ShowShareSpaceConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShareSpaceConfigResponse>);
        }
        
        /// <summary>
        /// 设置协同桌面默认用户配置
        ///
        /// 设置协同桌面默认用户配置（当前功能公测中，需要使用请联系管理员申请使用）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateShareSpaceConfigResponse UpdateShareSpaceConfig(UpdateShareSpaceConfigRequest updateShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareSpaceConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateShareSpaceConfigResponse>(response);
        }

        public SyncInvoker<UpdateShareSpaceConfigResponse> UpdateShareSpaceConfigInvoker(UpdateShareSpaceConfigRequest updateShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareSpaceConfigRequest);
            return new SyncInvoker<UpdateShareSpaceConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateShareSpaceConfigResponse>);
        }
        
        /// <summary>
        /// 新增站点
        ///
        /// 用于查询站点信息的接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSiteResponse AddSite(AddSiteRequest addSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSiteRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSiteResponse>(response);
        }

        public SyncInvoker<AddSiteResponse> AddSiteInvoker(AddSiteRequest addSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSiteRequest);
            return new SyncInvoker<AddSiteResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSiteResponse>);
        }
        
        /// <summary>
        /// 删除站点
        ///
        /// 用于删除站点的接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSiteResponse DeleteSite(DeleteSiteRequest deleteSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSiteResponse>(response);
        }

        public SyncInvoker<DeleteSiteResponse> DeleteSiteInvoker(DeleteSiteRequest deleteSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteRequest);
            return new SyncInvoker<DeleteSiteResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSiteResponse>);
        }
        
        /// <summary>
        /// 查询站点信息
        ///
        /// 用于查询站点信息的接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSiteConfigsResponse ListSiteConfigs(ListSiteConfigsRequest listSiteConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSiteConfigsResponse>(response);
        }

        public SyncInvoker<ListSiteConfigsResponse> ListSiteConfigsInvoker(ListSiteConfigsRequest listSiteConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteConfigsRequest);
            return new SyncInvoker<ListSiteConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteConfigsResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站列表
        ///
        /// 查询边缘小站列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWksEdgeSitesResponse ListWksEdgeSites(ListWksEdgeSitesRequest listWksEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/wks-edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWksEdgeSitesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWksEdgeSitesResponse>(response);
        }

        public SyncInvoker<ListWksEdgeSitesResponse> ListWksEdgeSitesInvoker(ListWksEdgeSitesRequest listWksEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/wks-edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWksEdgeSitesRequest);
            return new SyncInvoker<ListWksEdgeSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWksEdgeSitesResponse>);
        }
        
        /// <summary>
        /// 修改站点接入方式
        ///
        /// 用于修改站点接入方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessModeResponse UpdateAccessMode(UpdateAccessModeRequest updateAccessModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessModeRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/access-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessModeResponse>(response);
        }

        public SyncInvoker<UpdateAccessModeResponse> UpdateAccessModeInvoker(UpdateAccessModeRequest updateAccessModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessModeRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/access-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessModeRequest);
            return new SyncInvoker<UpdateAccessModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessModeResponse>);
        }
        
        /// <summary>
        /// 修改站点业务子网
        ///
        /// 用于修改站点业务子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubnetIdsResponse UpdateSubnetIds(UpdateSubnetIdsRequest updateSubnetIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetIdsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/subnet-ids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetIdsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubnetIdsResponse>(response);
        }

        public SyncInvoker<UpdateSubnetIdsResponse> UpdateSubnetIdsInvoker(UpdateSubnetIdsRequest updateSubnetIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetIdsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/subnet-ids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetIdsRequest);
            return new SyncInvoker<UpdateSubnetIdsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubnetIdsResponse>);
        }
        
        /// <summary>
        /// 批量创建快照
        ///
        /// 批量创建快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateDesktopSnapshotResponse BatchCreateDesktopSnapshot(BatchCreateDesktopSnapshotRequest batchCreateDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDesktopSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateDesktopSnapshotResponse>(response);
        }

        public SyncInvoker<BatchCreateDesktopSnapshotResponse> BatchCreateDesktopSnapshotInvoker(BatchCreateDesktopSnapshotRequest batchCreateDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDesktopSnapshotRequest);
            return new SyncInvoker<BatchCreateDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 批量删除快照
        ///
        /// 批量删除快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteDesktopSnapshotResponse BatchDeleteDesktopSnapshot(BatchDeleteDesktopSnapshotRequest batchDeleteDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDesktopSnapshotResponse>(response);
        }

        public SyncInvoker<BatchDeleteDesktopSnapshotResponse> BatchDeleteDesktopSnapshotInvoker(BatchDeleteDesktopSnapshotRequest batchDeleteDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopSnapshotRequest);
            return new SyncInvoker<BatchDeleteDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 批量恢复快照
        ///
        /// 批量恢快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestoreDesktopSnapshotResponse BatchRestoreDesktopSnapshot(BatchRestoreDesktopSnapshotRequest batchRestoreDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDesktopSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreDesktopSnapshotResponse>(response);
        }

        public SyncInvoker<BatchRestoreDesktopSnapshotResponse> BatchRestoreDesktopSnapshotInvoker(BatchRestoreDesktopSnapshotRequest batchRestoreDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDesktopSnapshotRequest);
            return new SyncInvoker<BatchRestoreDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 查询快照列表
        ///
        /// 查询快照列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopSnapshotResponse ListDesktopSnapshot(ListDesktopSnapshotRequest listDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopSnapshotRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopSnapshotResponse>(response);
        }

        public SyncInvoker<ListDesktopSnapshotResponse> ListDesktopSnapshotInvoker(ListDesktopSnapshotRequest listDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopSnapshotRequest);
            return new SyncInvoker<ListDesktopSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 新增通知规则
        ///
        /// 新增对应指标的通知规则;对应指标满足相应的规则条件时发送通知
        /// 同一指标的规则不允许重复;
        /// 统计指标名称，目前仅支持固定值：desktop_idle_duration
        ///   * &#x60;desktop_idle_duration&#x60; -  桌面空闲时长, 仅允许设置 &#39;&gt;&#x3D;&#39; 阈值
        /// 注：需先为云服务添加委托授权，否则无法正常发送通知到SMN
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMetricNotifyRuleResponse AddMetricNotifyRule(AddMetricNotifyRuleRequest addMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMetricNotifyRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddMetricNotifyRuleResponse>(response);
        }

        public SyncInvoker<AddMetricNotifyRuleResponse> AddMetricNotifyRuleInvoker(AddMetricNotifyRuleRequest addMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMetricNotifyRuleRequest);
            return new SyncInvoker<AddMetricNotifyRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 删除通知规则
        ///
        /// 删除对应指标的通知规则;对应指标满足相应的规则条件时发送通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMetricNotifyRuleResponse DeleteMetricNotifyRule(DeleteMetricNotifyRuleRequest deleteMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMetricNotifyRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricNotifyRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMetricNotifyRuleResponse>(response);
        }

        public SyncInvoker<DeleteMetricNotifyRuleResponse> DeleteMetricNotifyRuleInvoker(DeleteMetricNotifyRuleRequest deleteMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMetricNotifyRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricNotifyRuleRequest);
            return new SyncInvoker<DeleteMetricNotifyRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 查询云应用接入统计数据
        ///
        /// 查询云应用接入统计数据，一次最多查询30天，支持最近30天的数据查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppUserAccessDataResponse ListAppUserAccessData(ListAppUserAccessDataRequest listAppUserAccessDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/app-user-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppUserAccessDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppUserAccessDataResponse>(response);
        }

        public SyncInvoker<ListAppUserAccessDataResponse> ListAppUserAccessDataInvoker(ListAppUserAccessDataRequest listAppUserAccessDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/app-user-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppUserAccessDataRequest);
            return new SyncInvoker<ListAppUserAccessDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppUserAccessDataResponse>);
        }
        
        /// <summary>
        /// 查询桌面使用情况统计数据
        ///
        /// 查询桌面使用统计信息;
        /// 云服务每天凌晨02:00进行聚合运算前一天00:00:00~23:59:59的使用时长,并将周期范围内的数据聚合到周期边界上
        /// 跨天的记录会按照统计周期进行计算
        /// 假设一天内桌面登录多次，09:00~12:00,13:00~21:00,22:00~01:00(次日):
        /// 则当天的累计使用时长数据会被汇聚到23:59:59这个点;总使用时长为 3hours(09:00~12:00)+8hours(13:00~21:00)+2hours(22:00~00:00)
        /// 仅能查询最近180天已进行汇聚计算的数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopUsageMetricResponse ListDesktopUsageMetric(ListDesktopUsageMetricRequest listDesktopUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopUsageMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopUsageMetricResponse>(response);
        }

        public SyncInvoker<ListDesktopUsageMetricResponse> ListDesktopUsageMetricInvoker(ListDesktopUsageMetricRequest listDesktopUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopUsageMetricRequest);
            return new SyncInvoker<ListDesktopUsageMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopUsageMetricResponse>);
        }
        
        /// <summary>
        /// 桌面统计
        ///
        /// 统计租户下的普通桌面、桌面池状态，默认仅统计总数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDesktopsStatisticsResponse ListDesktopsStatistics(ListDesktopsStatisticsRequest listDesktopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsStatisticsResponse>(response);
        }

        public SyncInvoker<ListDesktopsStatisticsResponse> ListDesktopsStatisticsInvoker(ListDesktopsStatisticsRequest listDesktopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatisticsRequest);
            return new SyncInvoker<ListDesktopsStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsStatisticsResponse>);
        }
        
        /// <summary>
        /// 登录状态统计
        ///
        /// 查询租户桌面登录状态统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoginStateResponse ListLoginState(ListLoginStateRequest listLoginStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/login-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginStateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoginStateResponse>(response);
        }

        public SyncInvoker<ListLoginStateResponse> ListLoginStateInvoker(ListLoginStateRequest listLoginStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/login-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginStateRequest);
            return new SyncInvoker<ListLoginStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoginStateResponse>);
        }
        
        /// <summary>
        /// 查询对应指标维度是否存在满足通知规则的记录
        ///
        /// 查询对应指标维度是否存在满足通知规则的记录;
        /// 查询结果仅表示满足相应指标维度下对应通知规则可产生的通知记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricNotifyRecordResponse ListMetricNotifyRecord(ListMetricNotifyRecordRequest listMetricNotifyRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetricNotifyRecordResponse>(response);
        }

        public SyncInvoker<ListMetricNotifyRecordResponse> ListMetricNotifyRecordInvoker(ListMetricNotifyRecordRequest listMetricNotifyRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRecordRequest);
            return new SyncInvoker<ListMetricNotifyRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricNotifyRecordResponse>);
        }
        
        /// <summary>
        /// 查询通知规则
        ///
        /// 查询对应指标的通知规则;。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricNotifyRuleResponse ListMetricNotifyRule(ListMetricNotifyRuleRequest listMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetricNotifyRuleResponse>(response);
        }

        public SyncInvoker<ListMetricNotifyRuleResponse> ListMetricNotifyRuleInvoker(ListMetricNotifyRuleRequest listMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRuleRequest);
            return new SyncInvoker<ListMetricNotifyRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 查询指标
        ///
        /// 查询指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMetricsResponse = JsonUtils.DeSerializeNull<ListMetricsResponse>(response);
            listMetricsResponse.Body = JsonUtils.DeSerializeList<Metric>(response);
            return listMetricsResponse;
        }

        public SyncInvoker<ListMetricsResponse> ListMetricsInvoker(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            return new SyncInvoker<ListMetricsResponse>(this, "GET", request, response =>
            {
                var listMetricsResponse = JsonUtils.DeSerializeNull<ListMetricsResponse>(response);
                listMetricsResponse.Body = JsonUtils.DeSerializeList<Metric>(response);
                return listMetricsResponse;
            });
        }
        
        /// <summary>
        /// 查询指标趋势
        ///
        /// 查询指标趋势。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricsTrendResponse ListMetricsTrend(ListMetricsTrendRequest listMetricsTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsTrendRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMetricsTrendResponse = JsonUtils.DeSerializeNull<ListMetricsTrendResponse>(response);
            listMetricsTrendResponse.Body = JsonUtils.DeSerializeList<MetricsWithTime>(response);
            return listMetricsTrendResponse;
        }

        public SyncInvoker<ListMetricsTrendResponse> ListMetricsTrendInvoker(ListMetricsTrendRequest listMetricsTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsTrendRequest);
            return new SyncInvoker<ListMetricsTrendResponse>(this, "GET", request, response =>
            {
                var listMetricsTrendResponse = JsonUtils.DeSerializeNull<ListMetricsTrendResponse>(response);
                listMetricsTrendResponse.Body = JsonUtils.DeSerializeList<MetricsWithTime>(response);
                return listMetricsTrendResponse;
            });
        }
        
        /// <summary>
        /// 运行状态统计
        ///
        /// 租户桌面运行状态统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRunStateResponse ListRunState(ListRunStateRequest listRunStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/run-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunStateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRunStateResponse>(response);
        }

        public SyncInvoker<ListRunStateResponse> ListRunStateInvoker(ListRunStateRequest listRunStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/run-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunStateRequest);
            return new SyncInvoker<ListRunStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRunStateResponse>);
        }
        
        /// <summary>
        /// 查询在指定时间段未使用的桌面
        ///
        /// 查询在指定时间段未使用的桌面。已废弃，不推荐使用。统计数据推荐使用[查询桌面使用情况统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListDesktopUsageMetric)和[查询用户使用统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListUserUsageMetric)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUnusedDesktopsResponse ListUnusedDesktops(ListUnusedDesktopsRequest listUnusedDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/unused", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnusedDesktopsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUnusedDesktopsResponse>(response);
        }

        public SyncInvoker<ListUnusedDesktopsResponse> ListUnusedDesktopsInvoker(ListUnusedDesktopsRequest listUnusedDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/unused", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnusedDesktopsRequest);
            return new SyncInvoker<ListUnusedDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnusedDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询使用桌面的时长
        ///
        /// 查询使用桌面的时长。已废弃，不推荐使用。统计数据推荐使用[查询桌面使用情况统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListDesktopUsageMetric)和[查询用户使用统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListUserUsageMetric)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsedDesktopInfoResponse ListUsedDesktopInfo(ListUsedDesktopInfoRequest listUsedDesktopInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsedDesktopInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListUsedDesktopInfoResponse>(response);
        }

        public SyncInvoker<ListUsedDesktopInfoResponse> ListUsedDesktopInfoInvoker(ListUsedDesktopInfoRequest listUsedDesktopInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsedDesktopInfoRequest);
            return new SyncInvoker<ListUsedDesktopInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListUsedDesktopInfoResponse>);
        }
        
        /// <summary>
        /// 查询用户使用统计数据
        ///
        /// 查询用户使用统计信息;
        /// 最多查询30天内的数据;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserUsageMetricResponse ListUserUsageMetric(ListUserUsageMetricRequest listUserUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserUsageMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserUsageMetricResponse>(response);
        }

        public SyncInvoker<ListUserUsageMetricResponse> ListUserUsageMetricInvoker(ListUserUsageMetricRequest listUserUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserUsageMetricRequest);
            return new SyncInvoker<ListUserUsageMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserUsageMetricResponse>);
        }
        
        /// <summary>
        /// 查询指标环比值
        ///
        /// 查询指标环比值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGrowthRateResponse ShowGrowthRate(ShowGrowthRateRequest showGrowthRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/growth-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGrowthRateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGrowthRateResponse>(response);
        }

        public SyncInvoker<ShowGrowthRateResponse> ShowGrowthRateInvoker(ShowGrowthRateRequest showGrowthRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/growth-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGrowthRateRequest);
            return new SyncInvoker<ShowGrowthRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGrowthRateResponse>);
        }
        
        /// <summary>
        /// 查询接入云桌面或云应用各阶段时长数据
        ///
        /// 查询接入云桌面或云应用各阶段时长数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserAccessStagesResponse ShowUserAccessStages(ShowUserAccessStagesRequest showUserAccessStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/access-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessStagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserAccessStagesResponse>(response);
        }

        public SyncInvoker<ShowUserAccessStagesResponse> ShowUserAccessStagesInvoker(ShowUserAccessStagesRequest showUserAccessStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/access-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessStagesRequest);
            return new SyncInvoker<ShowUserAccessStagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserAccessStagesResponse>);
        }
        
        /// <summary>
        /// 更新通知规则
        ///
        /// 更新对应指标的通知规则;对应指标满足相应的规则条件时发送通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMetricNotifyRuleResponse UpdateMetricNotifyRule(UpdateMetricNotifyRuleRequest updateMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMetricNotifyRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetricNotifyRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMetricNotifyRuleResponse>(response);
        }

        public SyncInvoker<UpdateMetricNotifyRuleResponse> UpdateMetricNotifyRuleInvoker(UpdateMetricNotifyRuleRequest updateMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMetricNotifyRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetricNotifyRuleRequest);
            return new SyncInvoker<UpdateMetricNotifyRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 根据子网id查询该子网下可用的ip
        ///
        /// 根据子网id查询该子网下可用的ip。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvailableIpResponse ShowAvailableIp(ShowAvailableIpRequest showAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvailableIpRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/{subnet_id}/available-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableIpResponse>(response);
        }

        public SyncInvoker<ShowAvailableIpResponse> ShowAvailableIpInvoker(ShowAvailableIpRequest showAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvailableIpRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/{subnet_id}/available-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableIpRequest);
            return new SyncInvoker<ShowAvailableIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableIpResponse>);
        }
        
        /// <summary>
        /// 查询租户个性配置列表
        ///
        /// 查询租户个性配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantConfigsResponse ListTenantConfigs(ListTenantConfigsRequest listTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantConfigsResponse>(response);
        }

        public SyncInvoker<ListTenantConfigsResponse> ListTenantConfigsInvoker(ListTenantConfigsRequest listTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantConfigsRequest);
            return new SyncInvoker<ListTenantConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantConfigsResponse>);
        }
        
        /// <summary>
        /// 修改租户个性配置
        ///
        /// 租户个性配置修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTenantConfigResponse UpdateTenantConfig(UpdateTenantConfigRequest updateTenantConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTenantConfigResponse>(response);
        }

        public SyncInvoker<UpdateTenantConfigResponse> UpdateTenantConfigInvoker(UpdateTenantConfigRequest updateTenantConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantConfigRequest);
            return new SyncInvoker<UpdateTenantConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTenantConfigResponse>);
        }
        
        /// <summary>
        /// 增加终端与桌面绑定配置
        ///
        /// 增加终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTerminalsBindingDesktopsResponse CreateTerminalsBindingDesktops(CreateTerminalsBindingDesktopsRequest createTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTerminalsBindingDesktopsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTerminalsBindingDesktopsResponse>(response);
        }

        public SyncInvoker<CreateTerminalsBindingDesktopsResponse> CreateTerminalsBindingDesktopsInvoker(CreateTerminalsBindingDesktopsRequest createTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTerminalsBindingDesktopsRequest);
            return new SyncInvoker<CreateTerminalsBindingDesktopsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 删除终端与桌面绑定配置
        ///
        /// 删除终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTerminalsBindingDesktopsResponse DeleteTerminalsBindingDesktops(DeleteTerminalsBindingDesktopsRequest deleteTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTerminalsBindingDesktopsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteTerminalsBindingDesktopsResponse>(response);
        }

        public SyncInvoker<DeleteTerminalsBindingDesktopsResponse> DeleteTerminalsBindingDesktopsInvoker(DeleteTerminalsBindingDesktopsRequest deleteTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTerminalsBindingDesktopsRequest);
            return new SyncInvoker<DeleteTerminalsBindingDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询终端与桌面绑定配置列表
        ///
        /// 查询终端与桌面绑定配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTerminalsBindingDesktopsResponse ListTerminalsBindingDesktops(ListTerminalsBindingDesktopsRequest listTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTerminalsBindingDesktopsResponse>(response);
        }

        public SyncInvoker<ListTerminalsBindingDesktopsResponse> ListTerminalsBindingDesktopsInvoker(ListTerminalsBindingDesktopsRequest listTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsRequest);
            return new SyncInvoker<ListTerminalsBindingDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询终端与桌面绑定的开关配置信息
        ///
        /// 查询终端与桌面绑定的开关配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTerminalsBindingDesktopsConfigResponse ListTerminalsBindingDesktopsConfig(ListTerminalsBindingDesktopsConfigRequest listTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTerminalsBindingDesktopsConfigResponse>(response);
        }

        public SyncInvoker<ListTerminalsBindingDesktopsConfigResponse> ListTerminalsBindingDesktopsConfigInvoker(ListTerminalsBindingDesktopsConfigRequest listTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsConfigRequest);
            return new SyncInvoker<ListTerminalsBindingDesktopsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTerminalsBindingDesktopsConfigResponse>);
        }
        
        /// <summary>
        /// 修改终端与桌面绑定配置
        ///
        /// 修改终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTerminalsBindingDesktopsResponse UpdateTerminalsBindingDesktops(UpdateTerminalsBindingDesktopsRequest updateTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsResponse>(response);
        }

        public SyncInvoker<UpdateTerminalsBindingDesktopsResponse> UpdateTerminalsBindingDesktopsInvoker(UpdateTerminalsBindingDesktopsRequest updateTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsRequest);
            return new SyncInvoker<UpdateTerminalsBindingDesktopsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 设置终端与桌面绑定的开关配置
        ///
        /// 设置终端与桌面绑定的开关配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTerminalsBindingDesktopsConfigResponse UpdateTerminalsBindingDesktopsConfig(UpdateTerminalsBindingDesktopsConfigRequest updateTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsConfigResponse>(response);
        }

        public SyncInvoker<UpdateTerminalsBindingDesktopsConfigResponse> UpdateTerminalsBindingDesktopsConfigInvoker(UpdateTerminalsBindingDesktopsConfigRequest updateTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsConfigRequest);
            return new SyncInvoker<UpdateTerminalsBindingDesktopsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsConfigResponse>);
        }
        
        /// <summary>
        /// 批量创建用户
        ///
        /// 该接口用于批量创建用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateUsersResponse BatchCreateUsers(BatchCreateUsersRequest batchCreateUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateUsersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateUsersResponse>(response);
        }

        public SyncInvoker<BatchCreateUsersResponse> BatchCreateUsersInvoker(BatchCreateUsersRequest batchCreateUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateUsersRequest);
            return new SyncInvoker<BatchCreateUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateUsersResponse>);
        }
        
        /// <summary>
        /// 解绑OTP设备
        ///
        /// 该接口用于解绑用户的OTP设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteOtpDevicesResponse BatchDeleteOtpDevices(BatchDeleteOtpDevicesRequest batchDeleteOtpDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteOtpDevicesRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOtpDevicesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteOtpDevicesResponse>(response);
        }

        public SyncInvoker<BatchDeleteOtpDevicesResponse> BatchDeleteOtpDevicesInvoker(BatchDeleteOtpDevicesRequest batchDeleteOtpDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteOtpDevicesRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOtpDevicesRequest);
            return new SyncInvoker<BatchDeleteOtpDevicesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteOtpDevicesResponse>);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 该接口用于批量删除桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteUserResponse BatchDeleteUser(BatchDeleteUserRequest batchDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUserResponse>(response);
        }

        public SyncInvoker<BatchDeleteUserResponse> BatchDeleteUserInvoker(BatchDeleteUserRequest batchDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserRequest);
            return new SyncInvoker<BatchDeleteUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUserResponse>);
        }
        
        /// <summary>
        /// 操作用户
        ///
        /// 该接口用于操作用户，包含三种操作：锁定、解锁和重置密码（重置密码建议使用/v2/{project_id}/users/{user_id}/random-password接口，在没有通知方式的情况下必须使用/v2/{project_id}/users/{user_id}/random-password接口）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeUserStatusResponse ChangeUserStatus(ChangeUserStatusRequest changeUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeUserStatusRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeUserStatusResponse>(response);
        }

        public SyncInvoker<ChangeUserStatusResponse> ChangeUserStatusInvoker(ChangeUserStatusRequest changeUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeUserStatusRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserStatusRequest);
            return new SyncInvoker<ChangeUserStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeUserStatusResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 该接口用于创建桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDesktopUserResponse CreateDesktopUser(CreateDesktopUserRequest createDesktopUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopUserResponse>(response);
        }

        public SyncInvoker<CreateDesktopUserResponse> CreateDesktopUserInvoker(CreateDesktopUserRequest createDesktopUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopUserRequest);
            return new SyncInvoker<CreateDesktopUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopUserResponse>);
        }
        
        /// <summary>
        /// 删除指定用户
        ///
        /// 删除指定的桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询OTP设备
        ///
        /// 该接口用于查询相应用户下面的OTP设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOtpDevicesByUserIdResponse ListOtpDevicesByUserId(ListOtpDevicesByUserIdRequest listOtpDevicesByUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOtpDevicesByUserIdRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtpDevicesByUserIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOtpDevicesByUserIdResponse>(response);
        }

        public SyncInvoker<ListOtpDevicesByUserIdResponse> ListOtpDevicesByUserIdInvoker(ListOtpDevicesByUserIdRequest listOtpDevicesByUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOtpDevicesByUserIdRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtpDevicesByUserIdRequest);
            return new SyncInvoker<ListOtpDevicesByUserIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOtpDevicesByUserIdResponse>);
        }
        
        /// <summary>
        /// 查询用户详情信息
        ///
        /// 该接口用于查询指定的桌面用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserDetailResponse ListUserDetail(ListUserDetailRequest listUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserDetailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserDetailResponse>(response);
        }

        public SyncInvoker<ListUserDetailResponse> ListUserDetailInvoker(ListUserDetailRequest listUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserDetailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDetailRequest);
            return new SyncInvoker<ListUserDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserDetailResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 该接口用于查询桌面用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 给用户重置随机密码
        ///
        /// 该接口用于给用户重置一个密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetRandomPasswordResponse ResetRandomPassword(ResetRandomPasswordRequest resetRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetRandomPasswordRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/random-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetRandomPasswordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ResetRandomPasswordResponse>(response);
        }

        public SyncInvoker<ResetRandomPasswordResponse> ResetRandomPasswordInvoker(ResetRandomPasswordRequest resetRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetRandomPasswordRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/random-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetRandomPasswordRequest);
            return new SyncInvoker<ResetRandomPasswordResponse>(this, "GET", request, JsonUtils.DeSerialize<ResetRandomPasswordResponse>);
        }
        
        /// <summary>
        /// 重新发送邮件
        ///
        /// 该接口用于重新发送邮件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendEmailResponse SendEmail(SendEmailRequest sendEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendEmailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/resend-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendEmailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SendEmailResponse>(response);
        }

        public SyncInvoker<SendEmailResponse> SendEmailInvoker(SendEmailRequest sendEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendEmailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/resend-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendEmailRequest);
            return new SyncInvoker<SendEmailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendEmailResponse>);
        }
        
        /// <summary>
        /// 修改用户信息
        ///
        /// 该接口用于修改桌面用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest updateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserInfoRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserInfoResponse>(response);
        }

        public SyncInvoker<UpdateUserInfoResponse> UpdateUserInfoInvoker(UpdateUserInfoRequest updateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserInfoRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserInfoRequest);
            return new SyncInvoker<UpdateUserInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 查询用户事件
        ///
        /// 查询用户事件，一次最多查询30天，支持最近30天的数据查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserEventsResponse ListUserEvents(ListUserEventsRequest listUserEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserEventsResponse>(response);
        }

        public SyncInvoker<ListUserEventsResponse> ListUserEventsInvoker(ListUserEventsRequest listUserEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsRequest);
            return new SyncInvoker<ListUserEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserEventsResponse>);
        }
        
        /// <summary>
        /// 查询用户事件LTS配置
        ///
        /// 查询用户事件LTS配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserEventsLtsConfigurationsResponse ListUserEventsLtsConfigurations(ListUserEventsLtsConfigurationsRequest listUserEventsLtsConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events/lts-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsLtsConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserEventsLtsConfigurationsResponse>(response);
        }

        public SyncInvoker<ListUserEventsLtsConfigurationsResponse> ListUserEventsLtsConfigurationsInvoker(ListUserEventsLtsConfigurationsRequest listUserEventsLtsConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events/lts-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsLtsConfigurationsRequest);
            return new SyncInvoker<ListUserEventsLtsConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserEventsLtsConfigurationsResponse>);
        }
        
        /// <summary>
        /// 配置用户事件LTS
        ///
        /// 配置用户事件LTS。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetUserEventsLtsConfigurationsResponse SetUserEventsLtsConfigurations(SetUserEventsLtsConfigurationsRequest setUserEventsLtsConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events/lts-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setUserEventsLtsConfigurationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetUserEventsLtsConfigurationsResponse>(response);
        }

        public SyncInvoker<SetUserEventsLtsConfigurationsResponse> SetUserEventsLtsConfigurationsInvoker(SetUserEventsLtsConfigurationsRequest setUserEventsLtsConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events/lts-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setUserEventsLtsConfigurationsRequest);
            return new SyncInvoker<SetUserEventsLtsConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetUserEventsLtsConfigurationsResponse>);
        }
        
        /// <summary>
        /// 增加桌面磁盘
        ///
        /// 给单个桌面增加磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDesktopVolumesResponse AddDesktopVolumes(AddDesktopVolumesRequest addDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDesktopVolumesRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopVolumesResponse>(response);
        }

        public SyncInvoker<AddDesktopVolumesResponse> AddDesktopVolumesInvoker(AddDesktopVolumesRequest addDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDesktopVolumesRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopVolumesRequest);
            return new SyncInvoker<AddDesktopVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopVolumesResponse>);
        }
        
        /// <summary>
        /// 批量增加桌面磁盘
        ///
        /// 批量增加桌面磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddVolumesResponse AddVolumes(AddVolumesRequest addVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddVolumesResponse>(response);
        }

        public SyncInvoker<AddVolumesResponse> AddVolumesInvoker(AddVolumesRequest addVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVolumesRequest);
            return new SyncInvoker<AddVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddVolumesResponse>);
        }
        
        /// <summary>
        /// 删除桌面数据盘
        ///
        /// 删除桌面数据盘，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDesktopVolumesResponse DeleteDesktopVolumes(DeleteDesktopVolumesRequest deleteDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopVolumesRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopVolumesResponse>(response);
        }

        public SyncInvoker<DeleteDesktopVolumesResponse> DeleteDesktopVolumesInvoker(DeleteDesktopVolumesRequest deleteDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDesktopVolumesRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopVolumesRequest);
            return new SyncInvoker<DeleteDesktopVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopVolumesResponse>);
        }
        
        /// <summary>
        /// 扩容磁盘
        ///
        /// 扩容磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandDesktopVolumeResponse ExpandDesktopVolume(ExpandDesktopVolumeRequest expandDesktopVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopVolumeRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/{volume_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopVolumeResponse>(response);
        }

        public SyncInvoker<ExpandDesktopVolumeResponse> ExpandDesktopVolumeInvoker(ExpandDesktopVolumeRequest expandDesktopVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopVolumeRequest.DesktopId, out var valueOfDesktopId)) urlParam.Add("desktop_id", valueOfDesktopId);
            if (StringUtils.TryConvertToNonEmptyString(expandDesktopVolumeRequest.VolumeId, out var valueOfVolumeId)) urlParam.Add("volume_id", valueOfVolumeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/{volume_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopVolumeRequest);
            return new SyncInvoker<ExpandDesktopVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopVolumeResponse>);
        }
        
        /// <summary>
        /// 扩容桌面磁盘
        ///
        /// 扩容桌面磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandVolumesResponse ExpandVolumes(ExpandVolumesRequest expandVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandVolumesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandVolumesResponse>(response);
        }

        public SyncInvoker<ExpandVolumesResponse> ExpandVolumesInvoker(ExpandVolumesRequest expandVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandVolumesRequest);
            return new SyncInvoker<ExpandVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandVolumesResponse>);
        }
        
        /// <summary>
        /// 查询磁盘产品信息
        ///
        /// 查询磁盘产品信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumeProductInfoResponse ListVolumeProductInfo(ListVolumeProductInfoRequest listVolumeProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volume/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeProductInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVolumeProductInfoResponse>(response);
        }

        public SyncInvoker<ListVolumeProductInfoResponse> ListVolumeProductInfoInvoker(ListVolumeProductInfoRequest listVolumeProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volume/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeProductInfoRequest);
            return new SyncInvoker<ListVolumeProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeProductInfoResponse>);
        }
        
        /// <summary>
        /// 开通云办公服务
        ///
        /// 该接口用于开通云办公服务。
        /// 
        /// 作为异步接口，调用成功说明云办公服务后台收到了开通请求，但服务是否开通成功需要通过任务查询接口(GET /v2/{project_id}/workspace-sub-jobs)查询该任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyWorkspaceResponse ApplyWorkspace(ApplyWorkspaceRequest applyWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyWorkspaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplyWorkspaceResponse>(response);
        }

        public SyncInvoker<ApplyWorkspaceResponse> ApplyWorkspaceInvoker(ApplyWorkspaceRequest applyWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyWorkspaceRequest);
            return new SyncInvoker<ApplyWorkspaceResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyWorkspaceResponse>);
        }
        
        /// <summary>
        /// 注销云办公服务
        ///
        /// 该接口用于注销云办公服务。注销前请确保当前用户下的云桌面已经删除，注销后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelWorkspaceResponse CancelWorkspace(CancelWorkspaceRequest cancelWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelWorkspaceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<CancelWorkspaceResponse>(response);
        }

        public SyncInvoker<CancelWorkspaceResponse> CancelWorkspaceInvoker(CancelWorkspaceRequest cancelWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelWorkspaceRequest);
            return new SyncInvoker<CancelWorkspaceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelWorkspaceResponse>);
        }
        
        /// <summary>
        /// 查询云办公服务详情
        ///
        /// 该接口用于查询云办公服务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest listWorkspacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspacesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWorkspacesResponse>(response);
        }

        public SyncInvoker<ListWorkspacesResponse> ListWorkspacesInvoker(ListWorkspacesRequest listWorkspacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspacesRequest);
            return new SyncInvoker<ListWorkspacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkspacesResponse>);
        }
        
        /// <summary>
        /// 查询云办公服务是否被锁定
        ///
        /// 查询云办公服务是否被锁定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWorkspaceLockResponse ShowWorkspaceLock(ShowWorkspaceLockRequest showWorkspaceLockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceLockRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkspaceLockResponse>(response);
        }

        public SyncInvoker<ShowWorkspaceLockResponse> ShowWorkspaceLockInvoker(ShowWorkspaceLockRequest showWorkspaceLockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceLockRequest);
            return new SyncInvoker<ShowWorkspaceLockResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkspaceLockResponse>);
        }
        
        /// <summary>
        /// 解除云办公服务锁定状态
        ///
        /// 该接口目前支持解除云办公服务锁定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnlockWorkspaceResponse UnlockWorkspace(UnlockWorkspaceRequest unlockWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockWorkspaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UnlockWorkspaceResponse>(response);
        }

        public SyncInvoker<UnlockWorkspaceResponse> UnlockWorkspaceInvoker(UnlockWorkspaceRequest unlockWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockWorkspaceRequest);
            return new SyncInvoker<UnlockWorkspaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UnlockWorkspaceResponse>);
        }
        
        /// <summary>
        /// 修改企业ID
        ///
        /// 修改租户的企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEnterpriseIdResponse UpdateEnterpriseId(UpdateEnterpriseIdRequest updateEnterpriseIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/enterprise-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnterpriseIdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnterpriseIdResponse>(response);
        }

        public SyncInvoker<UpdateEnterpriseIdResponse> UpdateEnterpriseIdInvoker(UpdateEnterpriseIdRequest updateEnterpriseIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/enterprise-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnterpriseIdRequest);
            return new SyncInvoker<UpdateEnterpriseIdResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnterpriseIdResponse>);
        }
        
        /// <summary>
        /// 修改云办公服务属性
        ///
        /// 该接口目前支持修改云办公服务属性。单次请求仅支持修改一种属性类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkspaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkspaceResponse>(response);
        }

        public SyncInvoker<UpdateWorkspaceResponse> UpdateWorkspaceInvoker(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkspaceRequest);
            return new SyncInvoker<UpdateWorkspaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkspaceResponse>);
        }
        
    }
}