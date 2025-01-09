using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Workspace.V2.Model;

namespace HuaweiCloud.SDK.Workspace.V2
{
    public partial class WorkspaceAsyncClient : Client
    {
        public static ClientBuilder<WorkspaceAsyncClient> NewBuilder()
        {
            return new ClientBuilder<WorkspaceAsyncClient>();
        }

        
        /// <summary>
        /// 获取云办公服务接入地址备份配置
        ///
        /// 该接口用于获取云办公服务接入地址备份配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessAddressBackupConfigResponse> ListAccessAddressBackupConfigAsync(ListAccessAddressBackupConfigRequest listAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAddressBackupConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessAddressBackupConfigResponse>(response);
        }

        public AsyncInvoker<ListAccessAddressBackupConfigResponse> ListAccessAddressBackupConfigAsyncInvoker(ListAccessAddressBackupConfigRequest listAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAddressBackupConfigRequest);
            return new AsyncInvoker<ListAccessAddressBackupConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessAddressBackupConfigResponse>);
        }
        
        /// <summary>
        /// 修改云办公服务接入地址备份配置
        ///
        /// 该接口用于修改云办公服务接入地址备份配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessAddressBackupConfigResponse> UpdateAccessAddressBackupConfigAsync(UpdateAccessAddressBackupConfigRequest updateAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessAddressBackupConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAccessAddressBackupConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAccessAddressBackupConfigResponse> UpdateAccessAddressBackupConfigAsyncInvoker(UpdateAccessAddressBackupConfigRequest updateAccessAddressBackupConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-config/address-backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessAddressBackupConfigRequest);
            return new AsyncInvoker<UpdateAccessAddressBackupConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAccessAddressBackupConfigResponse>);
        }
        
        /// <summary>
        /// 删除接入策略
        ///
        /// 该接口用于删除指定接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAccessPoliciesResponse> BatchDeleteAccessPoliciesAsync(BatchDeleteAccessPoliciesRequest batchDeleteAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAccessPoliciesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAccessPoliciesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAccessPoliciesResponse> BatchDeleteAccessPoliciesAsyncInvoker(BatchDeleteAccessPoliciesRequest batchDeleteAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAccessPoliciesRequest);
            return new AsyncInvoker<BatchDeleteAccessPoliciesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteAccessPoliciesResponse>);
        }
        
        /// <summary>
        /// 创建接入策略
        ///
        /// 该接口用于创建接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessPolicyResponse> CreateAccessPolicyAsync(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAccessPolicyResponse>(response);
        }

        public AsyncInvoker<CreateAccessPolicyResponse> CreateAccessPolicyAsyncInvoker(CreateAccessPolicyRequest createAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessPolicyRequest);
            return new AsyncInvoker<CreateAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询接入策略
        ///
        /// 该接口用于查询接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessPoliciesResponse> ListAccessPoliciesAsync(ListAccessPoliciesRequest listAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessPoliciesResponse>(response);
        }

        public AsyncInvoker<ListAccessPoliciesResponse> ListAccessPoliciesAsyncInvoker(ListAccessPoliciesRequest listAccessPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPoliciesRequest);
            return new AsyncInvoker<ListAccessPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询指定接入策略的应用对象
        ///
        /// 该接口用于查询指定接入策略的应用对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessPolicyObjectsResponse> ListAccessPolicyObjectsAsync(ListAccessPolicyObjectsRequest listAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", listAccessPolicyObjectsRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyObjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessPolicyObjectsResponse>(response);
        }

        public AsyncInvoker<ListAccessPolicyObjectsResponse> ListAccessPolicyObjectsAsyncInvoker(ListAccessPolicyObjectsRequest listAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", listAccessPolicyObjectsRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessPolicyObjectsRequest);
            return new AsyncInvoker<ListAccessPolicyObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessPolicyObjectsResponse>);
        }
        
        /// <summary>
        /// 更新指定接入策略
        ///
        /// 该接口用于更新指定接入策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessPolicyResponse> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", updateAccessPolicyRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAccessPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateAccessPolicyResponse> UpdateAccessPolicyAsyncInvoker(UpdateAccessPolicyRequest updateAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", updateAccessPolicyRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyRequest);
            return new AsyncInvoker<UpdateAccessPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 更新指定接入策略的应用对象
        ///
        /// 该接口用于更新指定接入策略的应用对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessPolicyObjectsResponse> UpdateAccessPolicyObjectsAsync(UpdateAccessPolicyObjectsRequest updateAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", updateAccessPolicyObjectsRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyObjectsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAccessPolicyObjectsResponse>(response);
        }

        public AsyncInvoker<UpdateAccessPolicyObjectsResponse> UpdateAccessPolicyObjectsAsyncInvoker(UpdateAccessPolicyObjectsRequest updateAccessPolicyObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_policy_id", updateAccessPolicyObjectsRequest.AccessPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/access-policy/{access_policy_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessPolicyObjectsRequest);
            return new AsyncInvoker<UpdateAccessPolicyObjectsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAccessPolicyObjectsResponse>);
        }
        
        /// <summary>
        /// 开通委托功能
        ///
        /// 开通委托功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgenciesResponse> CreateAgenciesAsync(CreateAgenciesRequest createAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAgenciesResponse>(response);
        }

        public AsyncInvoker<CreateAgenciesResponse> CreateAgenciesAsyncInvoker(CreateAgenciesRequest createAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesRequest);
            return new AsyncInvoker<CreateAgenciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAgenciesResponse>);
        }
        
        /// <summary>
        /// 查询委托功能
        ///
        /// 查询委托功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgenciesResponse> ListAgenciesAsync(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }

        public AsyncInvoker<ListAgenciesResponse> ListAgenciesAsyncInvoker(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            return new AsyncInvoker<ListAgenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesResponse>);
        }
        
        /// <summary>
        /// 查询告警统计
        ///
        /// 返回各级别告警数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmStatisticsResponse> ListAlarmStatisticsAsync(ListAlarmStatisticsRequest listAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmStatisticsResponse>(response);
        }

        public AsyncInvoker<ListAlarmStatisticsResponse> ListAlarmStatisticsAsyncInvoker(ListAlarmStatisticsRequest listAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsRequest);
            return new AsyncInvoker<ListAlarmStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询告警列表
        ///
        /// 从ces查询告警列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }

        public AsyncInvoker<ListAlarmsResponse> ListAlarmsAsyncInvoker(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            return new AsyncInvoker<ListAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmsResponse>);
        }
        
        /// <summary>
        /// 批量删除应用
        ///
        /// 批量删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppsResponse> BatchDeleteAppsAsync(BatchDeleteAppsRequest batchDeleteAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppsResponse> BatchDeleteAppsAsyncInvoker(BatchDeleteAppsRequest batchDeleteAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppsRequest);
            return new AsyncInvoker<BatchDeleteAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppsResponse>);
        }
        
        /// <summary>
        /// 批量删除job
        ///
        /// 批量删除job。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteJobsResponse> BatchDeleteJobsAsync(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteJobsResponse> BatchDeleteJobsAsyncInvoker(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            return new AsyncInvoker<BatchDeleteJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteJobsResponse>);
        }
        
        /// <summary>
        /// 批量设置不可见
        ///
        /// 批量设置不可见。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisableAppsResponse> BatchDisableAppsAsync(BatchDisableAppsRequest batchDisableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisableAppsResponse>(response);
        }

        public AsyncInvoker<BatchDisableAppsResponse> BatchDisableAppsAsyncInvoker(BatchDisableAppsRequest batchDisableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppsRequest);
            return new AsyncInvoker<BatchDisableAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisableAppsResponse>);
        }
        
        /// <summary>
        /// 批量设置可见
        ///
        /// 批量设置可见。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchEnableAppsResponse> BatchEnableAppsAsync(BatchEnableAppsRequest batchEnableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchEnableAppsResponse>(response);
        }

        public AsyncInvoker<BatchEnableAppsResponse> BatchEnableAppsAsyncInvoker(BatchEnableAppsRequest batchEnableAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppsRequest);
            return new AsyncInvoker<BatchEnableAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchEnableAppsResponse>);
        }
        
        /// <summary>
        /// 批量自动安装安装应用
        ///
        /// 批量自动安装安装应用 (应用需支持静默安装或者解压安装)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchInstallAppsResponse> BatchInstallAppsAsync(BatchInstallAppsRequest batchInstallAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchInstallAppsResponse>(response);
        }

        public AsyncInvoker<BatchInstallAppsResponse> BatchInstallAppsAsyncInvoker(BatchInstallAppsRequest batchInstallAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAppsRequest);
            return new AsyncInvoker<BatchInstallAppsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchInstallAppsResponse>);
        }
        
        /// <summary>
        /// 批量设置应用授权
        ///
        /// 批量设置应用授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateAppAuthorizationsResponse> BatchUpdateAppAuthorizationsAsync(BatchUpdateAppAuthorizationsRequest batchUpdateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-assign-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAppAuthorizationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateAppAuthorizationsResponse>(response);
        }

        public AsyncInvoker<BatchUpdateAppAuthorizationsResponse> BatchUpdateAppAuthorizationsAsyncInvoker(BatchUpdateAppAuthorizationsRequest batchUpdateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/actions/batch-assign-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAppAuthorizationsRequest);
            return new AsyncInvoker<BatchUpdateAppAuthorizationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 添加并授权默认桶
        ///
        /// 添加并授权默认桶,桶不存在时会自动创建OBS桶。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAndAuthorizeBucketResponse> CreateAndAuthorizeBucketAsync(CreateAndAuthorizeBucketRequest createAndAuthorizeBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAndAuthorizeBucketRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAndAuthorizeBucketResponse>(response);
        }

        public AsyncInvoker<CreateAndAuthorizeBucketResponse> CreateAndAuthorizeBucketAsyncInvoker(CreateAndAuthorizeBucketRequest createAndAuthorizeBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAndAuthorizeBucketRequest);
            return new AsyncInvoker<CreateAndAuthorizeBucketResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAndAuthorizeBucketResponse>);
        }
        
        /// <summary>
        /// 生成访问凭证信息
        ///
        /// 生成桶凭证信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBucketCredentialResponse> CreateBucketCredentialAsync(CreateBucketCredentialRequest createBucketCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets/actions/create-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketCredentialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBucketCredentialResponse>(response);
        }

        public AsyncInvoker<CreateBucketCredentialResponse> CreateBucketCredentialAsyncInvoker(CreateBucketCredentialRequest createBucketCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/buckets/actions/create-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketCredentialRequest);
            return new AsyncInvoker<CreateBucketCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBucketCredentialResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public AsyncInvoker<DeleteAppResponse> DeleteAppAsyncInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new AsyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 自动安装应用
        ///
        /// 自动安装应用(应用需支持静默安装或者解压安装)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest installAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", installAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", installAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<InstallAppResponse>(response);
        }

        public AsyncInvoker<InstallAppResponse> InstallAppAsyncInvoker(InstallAppRequest installAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", installAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/auto-install", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", installAppRequest);
            return new AsyncInvoker<InstallAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<InstallAppResponse>);
        }
        
        /// <summary>
        /// 查询应用授权信息
        ///
        /// 查询应用授权信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppAuthorizationsResponse> ListAppAuthorizationsAsync(ListAppAuthorizationsRequest listAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", listAppAuthorizationsRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppAuthorizationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppAuthorizationsResponse>(response);
        }

        public AsyncInvoker<ListAppAuthorizationsResponse> ListAppAuthorizationsAsyncInvoker(ListAppAuthorizationsRequest listAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", listAppAuthorizationsRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppAuthorizationsRequest);
            return new AsyncInvoker<ListAppAuthorizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 查询应用分类信息
        ///
        /// 查询应用分类信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppCatalogsResponse> ListAppCatalogsAsync(ListAppCatalogsRequest listAppCatalogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-catalogs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppCatalogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppCatalogsResponse>(response);
        }

        public AsyncInvoker<ListAppCatalogsResponse> ListAppCatalogsAsyncInvoker(ListAppCatalogsRequest listAppCatalogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-catalogs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppCatalogsRequest);
            return new AsyncInvoker<ListAppCatalogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppCatalogsResponse>);
        }
        
        /// <summary>
        /// 按照名称分页查询应用
        ///
        /// 按照名称分页查询应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public AsyncInvoker<ListAppsResponse> ListAppsAsyncInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new AsyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询应用安装job信息
        ///
        /// 查询应用安装job信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 重试失败job
        ///
        /// 重试指定失败job(仅支持失败job重试，其他类型job重试会响应错误)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryJobsResponse> RetryJobsAsync(RetryJobsRequest retryJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RetryJobsResponse>(response);
        }

        public AsyncInvoker<RetryJobsResponse> RetryJobsAsyncInvoker(RetryJobsRequest retryJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/jobs/actions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryJobsRequest);
            return new AsyncInvoker<RetryJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryJobsResponse>);
        }
        
        /// <summary>
        /// 设置应用授权
        ///
        /// 设置应用授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppAuthorizationsResponse> UpdateAppAuthorizationsAsync(UpdateAppAuthorizationsRequest updateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppAuthorizationsRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/assign-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppAuthorizationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAppAuthorizationsResponse>(response);
        }

        public AsyncInvoker<UpdateAppAuthorizationsResponse> UpdateAppAuthorizationsAsyncInvoker(UpdateAppAuthorizationsRequest updateAppAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppAuthorizationsRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}/actions/assign-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppAuthorizationsRequest);
            return new AsyncInvoker<UpdateAppAuthorizationsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAppAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUploadedAppResponse> UpdateUploadedAppAsync(UpdateUploadedAppRequest updateUploadedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateUploadedAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUploadedAppRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateUploadedAppResponse>(response);
        }

        public AsyncInvoker<UpdateUploadedAppResponse> UpdateUploadedAppAsyncInvoker(UpdateUploadedAppRequest updateUploadedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateUploadedAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUploadedAppRequest);
            return new AsyncInvoker<UpdateUploadedAppResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateUploadedAppResponse>);
        }
        
        /// <summary>
        /// 添加应用
        ///
        /// 添加应用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadAppResponse> UploadAppAsync(UploadAppRequest uploadAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadAppResponse>(response);
        }

        public AsyncInvoker<UploadAppResponse> UploadAppAsyncInvoker(UploadAppRequest uploadAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAppRequest);
            return new AsyncInvoker<UploadAppResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAppResponse>);
        }
        
        /// <summary>
        /// 增加管控规则
        ///
        /// 增加管控规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRestrictedRuleResponse> AddRestrictedRuleAsync(AddRestrictedRuleRequest addRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRestrictedRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddRestrictedRuleResponse>(response);
        }

        public AsyncInvoker<AddRestrictedRuleResponse> AddRestrictedRuleAsyncInvoker(AddRestrictedRuleRequest addRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRestrictedRuleRequest);
            return new AsyncInvoker<AddRestrictedRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除规则
        ///
        /// 批量删除规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppRulesResponse> BatchDeleteAppRulesAsync(BatchDeleteAppRulesRequest batchDeleteAppRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppRulesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppRulesResponse> BatchDeleteAppRulesAsyncInvoker(BatchDeleteAppRulesRequest batchDeleteAppRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRulesRequest);
            return new AsyncInvoker<BatchDeleteAppRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppRulesResponse>);
        }
        
        /// <summary>
        /// 创建应用规则
        ///
        /// 创建应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppRuleResponse> CreateAppRuleAsync(CreateAppRuleRequest createAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppRuleResponse>(response);
        }

        public AsyncInvoker<CreateAppRuleResponse> CreateAppRuleAsyncInvoker(CreateAppRuleRequest createAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRuleRequest);
            return new AsyncInvoker<CreateAppRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppRuleResponse>);
        }
        
        /// <summary>
        /// 删除应用规则
        ///
        /// 删除应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppRuleResponse> DeleteAppRuleAsync(DeleteAppRuleRequest deleteAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteAppRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppRuleResponse>(response);
        }

        public AsyncInvoker<DeleteAppRuleResponse> DeleteAppRuleAsyncInvoker(DeleteAppRuleRequest deleteAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteAppRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRuleRequest);
            return new AsyncInvoker<DeleteAppRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除管控规则列表
        ///
        /// 批量删除管控规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRestrictedRuleResponse> DeleteRestrictedRuleAsync(DeleteRestrictedRuleRequest deleteRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRestrictedRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteRestrictedRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRestrictedRuleResponse> DeleteRestrictedRuleAsyncInvoker(DeleteRestrictedRuleRequest deleteRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRestrictedRuleRequest);
            return new AsyncInvoker<DeleteRestrictedRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 禁用规则管控
        ///
        /// 禁用规则管控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableRuleRestrictionResponse> DisableRuleRestrictionAsync(DisableRuleRestrictionRequest disableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/disable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableRuleRestrictionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableRuleRestrictionResponse>(response);
        }

        public AsyncInvoker<DisableRuleRestrictionResponse> DisableRuleRestrictionAsyncInvoker(DisableRuleRestrictionRequest disableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/disable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableRuleRestrictionRequest);
            return new AsyncInvoker<DisableRuleRestrictionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 启用规则管控
        ///
        /// 启用规则管控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableRuleRestrictionResponse> EnableRuleRestrictionAsync(EnableRuleRestrictionRequest enableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/enable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableRuleRestrictionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableRuleRestrictionResponse>(response);
        }

        public AsyncInvoker<EnableRuleRestrictionResponse> EnableRuleRestrictionAsyncInvoker(EnableRuleRestrictionRequest enableRuleRestrictionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/actions/enable-rule-restriction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableRuleRestrictionRequest);
            return new AsyncInvoker<EnableRuleRestrictionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableRuleRestrictionResponse>);
        }
        
        /// <summary>
        /// 查询应用规则
        ///
        /// 查询应用规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppRuleResponse> ListAppRuleAsync(ListAppRuleRequest listAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppRuleResponse>(response);
        }

        public AsyncInvoker<ListAppRuleResponse> ListAppRuleAsyncInvoker(ListAppRuleRequest listAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppRuleRequest);
            return new AsyncInvoker<ListAppRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppRuleResponse>);
        }
        
        /// <summary>
        /// 查询管控规则列表
        ///
        /// 查询管控规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestrictedRuleResponse> ListRestrictedRuleAsync(ListRestrictedRuleRequest listRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestrictedRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestrictedRuleResponse>(response);
        }

        public AsyncInvoker<ListRestrictedRuleResponse> ListRestrictedRuleAsyncInvoker(ListRestrictedRuleRequest listRestrictedRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-restricted-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestrictedRuleRequest);
            return new AsyncInvoker<ListRestrictedRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestrictedRuleResponse>);
        }
        
        /// <summary>
        /// 修改应用规则
        ///
        /// 修改应用规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppRuleResponse> UpdateAppRuleAsync(UpdateAppRuleRequest updateAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateAppRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRuleRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAppRuleResponse> UpdateAppRuleAsyncInvoker(UpdateAppRuleRequest updateAppRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateAppRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/app-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRuleRequest);
            return new AsyncInvoker<UpdateAppRuleResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppRuleResponse>);
        }
        
        /// <summary>
        /// 查询辅助认证配置
        ///
        /// 查询辅助认证的配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssistAuthConfigResponse> ShowAssistAuthConfigAsync(ShowAssistAuthConfigRequest showAssistAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssistAuthConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssistAuthConfigResponse>(response);
        }

        public AsyncInvoker<ShowAssistAuthConfigResponse> ShowAssistAuthConfigAsyncInvoker(ShowAssistAuthConfigRequest showAssistAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssistAuthConfigRequest);
            return new AsyncInvoker<ShowAssistAuthConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssistAuthConfigResponse>);
        }
        
        /// <summary>
        /// 查询认证登录方式
        ///
        /// 查询认证登录方式配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuthConfigResponse> ShowAuthConfigAsync(ShowAuthConfigRequest showAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuthConfigResponse>(response);
        }

        public AsyncInvoker<ShowAuthConfigResponse> ShowAuthConfigAsyncInvoker(ShowAuthConfigRequest showAuthConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthConfigRequest);
            return new AsyncInvoker<ShowAuthConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuthConfigResponse>);
        }
        
        /// <summary>
        /// 更新辅助认证策略配置
        ///
        /// 更新辅助认证策略配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAssistAuthMethodConfigResponse> UpdateAssistAuthMethodConfigAsync(UpdateAssistAuthMethodConfigRequest updateAssistAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssistAuthMethodConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAssistAuthMethodConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAssistAuthMethodConfigResponse> UpdateAssistAuthMethodConfigAsyncInvoker(UpdateAssistAuthMethodConfigRequest updateAssistAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/assist-auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssistAuthMethodConfigRequest);
            return new AsyncInvoker<UpdateAssistAuthMethodConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAssistAuthMethodConfigResponse>);
        }
        
        /// <summary>
        /// 更新认证策略配置
        ///
        /// 更新认证策略配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuthMethodConfigResponse> UpdateAuthMethodConfigAsync(UpdateAuthMethodConfigRequest updateAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthMethodConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuthMethodConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAuthMethodConfigResponse> UpdateAuthMethodConfigAsyncInvoker(UpdateAuthMethodConfigRequest updateAuthMethodConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/auth-config/method-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthMethodConfigRequest);
            return new AsyncInvoker<UpdateAuthMethodConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuthMethodConfigResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// 该接口用于查询云桌面支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailabilityZonesResponse> ListAvailabilityZonesAsync(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }

        public AsyncInvoker<ListAvailabilityZonesResponse> ListAvailabilityZonesAsyncInvoker(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            return new AsyncInvoker<ListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表概要
        ///
        /// 该接口用于查询云桌面支持的可用分区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAzsResponse> ListAzsAsync(ListAzsRequest listAzsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAzsResponse>(response);
        }

        public AsyncInvoker<ListAzsResponse> ListAzsAsyncInvoker(ListAzsRequest listAzsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzsRequest);
            return new AsyncInvoker<ListAzsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAzsResponse>);
        }
        
        /// <summary>
        /// 查询可用分区详情
        ///
        /// 该接口用于查询云桌面支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAzDetailsResponse> ShowAzDetailsAsync(ShowAzDetailsRequest showAzDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAzDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAzDetailsResponse>(response);
        }

        public AsyncInvoker<ShowAzDetailsResponse> ShowAzDetailsAsyncInvoker(ShowAzDetailsRequest showAzDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zones/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAzDetailsRequest);
            return new AsyncInvoker<ShowAzDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAzDetailsResponse>);
        }
        
        /// <summary>
        /// 导出连接记录
        ///
        /// 该接口用于导出连接记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportUserLoginInfoNewResponse> ExportUserLoginInfoNewAsync(ExportUserLoginInfoNewRequest exportUserLoginInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserLoginInfoNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ExportUserLoginInfoNewResponse>(response);
        }

        public AsyncInvoker<ExportUserLoginInfoNewResponse> ExportUserLoginInfoNewAsyncInvoker(ExportUserLoginInfoNewRequest exportUserLoginInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserLoginInfoNewRequest);
            return new AsyncInvoker<ExportUserLoginInfoNewResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ExportUserLoginInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询桌面登录状态
        ///
        /// 该接口用于查询桌面登录状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListDesktopsStatusResponse> ListDesktopsStatusAsync(ListDesktopsStatusRequest listDesktopsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsStatusResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListDesktopsStatusResponse> ListDesktopsStatusAsyncInvoker(ListDesktopsStatusRequest listDesktopsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatusRequest);
            return new AsyncInvoker<ListDesktopsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsStatusResponse>);
        }
        
        /// <summary>
        /// 查询登录人数
        ///
        /// 该接口用于查询登录人数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryOnlineInfoResponse> ListHistoryOnlineInfoAsync(ListHistoryOnlineInfoRequest listHistoryOnlineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOnlineInfoResponse>(response);
        }

        public AsyncInvoker<ListHistoryOnlineInfoResponse> ListHistoryOnlineInfoAsyncInvoker(ListHistoryOnlineInfoRequest listHistoryOnlineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoRequest);
            return new AsyncInvoker<ListHistoryOnlineInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOnlineInfoResponse>);
        }
        
        /// <summary>
        /// 查询登录人数
        ///
        /// 该接口用于查询登录人数，注意查询参数不可全空。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryOnlineInfoNewResponse> ListHistoryOnlineInfoNewAsync(ListHistoryOnlineInfoNewRequest listHistoryOnlineInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOnlineInfoNewResponse>(response);
        }

        public AsyncInvoker<ListHistoryOnlineInfoNewResponse> ListHistoryOnlineInfoNewAsyncInvoker(ListHistoryOnlineInfoNewRequest listHistoryOnlineInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/online-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOnlineInfoNewRequest);
            return new AsyncInvoker<ListHistoryOnlineInfoNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOnlineInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询桌面登录状态
        ///
        /// 该接口用于查询桌面登录状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesStatusResponse> ListInstancesStatusAsync(ListInstancesStatusRequest listInstancesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesStatusResponse>(response);
        }

        public AsyncInvoker<ListInstancesStatusResponse> ListInstancesStatusAsyncInvoker(ListInstancesStatusRequest listInstancesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesStatusRequest);
            return new AsyncInvoker<ListInstancesStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesStatusResponse>);
        }
        
        /// <summary>
        /// 查询登录信息
        ///
        /// 该接口用于查询登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoginRecordsNewResponse> ListLoginRecordsNewAsync(ListLoginRecordsNewRequest listLoginRecordsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginRecordsNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLoginRecordsNewResponse>(response);
        }

        public AsyncInvoker<ListLoginRecordsNewResponse> ListLoginRecordsNewAsyncInvoker(ListLoginRecordsNewRequest listLoginRecordsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connections/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginRecordsNewRequest);
            return new AsyncInvoker<ListLoginRecordsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoginRecordsNewResponse>);
        }
        
        /// <summary>
        /// 分配用户
        ///
        /// 将桌面分配给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest attachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachInstancesResponse>(response);
        }

        public AsyncInvoker<AttachInstancesResponse> AttachInstancesAsyncInvoker(AttachInstancesRequest attachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInstancesRequest);
            return new AsyncInvoker<AttachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInstancesResponse>);
        }
        
        /// <summary>
        /// 预批量分配用户
        ///
        /// 预批量将桌面分配给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAssociateInstancesResponse> BatchAssociateInstancesAsync(BatchAssociateInstancesRequest batchAssociateInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/pre-batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAssociateInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAssociateInstancesResponse>(response);
        }

        public AsyncInvoker<BatchAssociateInstancesResponse> BatchAssociateInstancesAsyncInvoker(BatchAssociateInstancesRequest batchAssociateInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/pre-batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAssociateInstancesRequest);
            return new AsyncInvoker<BatchAssociateInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAssociateInstancesResponse>);
        }
        
        /// <summary>
        /// 批量分配用户
        ///
        /// 批量分配桌面给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAttachInstancesResponse> BatchAttachInstancesAsync(BatchAttachInstancesRequest batchAttachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachInstancesResponse>(response);
        }

        public AsyncInvoker<BatchAttachInstancesResponse> BatchAttachInstancesAsyncInvoker(BatchAttachInstancesRequest batchAttachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInstancesRequest);
            return new AsyncInvoker<BatchAttachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachInstancesResponse>);
        }
        
        /// <summary>
        /// 批量切换桌面网络
        ///
        /// 批量切换桌面vpc、子网、ip、安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchChangeDesktopNetworkResponse> BatchChangeDesktopNetworkAsync(BatchChangeDesktopNetworkRequest batchChangeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks/batch-change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDesktopNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeDesktopNetworkResponse>(response);
        }

        public AsyncInvoker<BatchChangeDesktopNetworkResponse> BatchChangeDesktopNetworkAsyncInvoker(BatchChangeDesktopNetworkRequest batchChangeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks/batch-change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDesktopNetworkRequest);
            return new AsyncInvoker<BatchChangeDesktopNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 批量删除桌面
        ///
        /// 批量删除桌面，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDesktopsResponse> BatchDeleteDesktopsAsync(BatchDeleteDesktopsRequest batchDeleteDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDesktopsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDesktopsResponse> BatchDeleteDesktopsAsyncInvoker(BatchDeleteDesktopsRequest batchDeleteDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsRequest);
            return new AsyncInvoker<BatchDeleteDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDesktopsResponse>);
        }
        
        /// <summary>
        /// 批量解绑用户
        ///
        /// 批量将桌面和用户解绑
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDetachInstancesResponse> BatchDetachInstancesAsync(BatchDetachInstancesRequest batchDetachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDetachInstancesResponse>(response);
        }

        public AsyncInvoker<BatchDetachInstancesResponse> BatchDetachInstancesAsyncInvoker(BatchDetachInstancesRequest batchDetachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInstancesRequest);
            return new AsyncInvoker<BatchDetachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDetachInstancesResponse>);
        }
        
        /// <summary>
        /// 安装ces-agent
        ///
        /// 批量为桌面安装agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchInstallAgentResponse> BatchInstallAgentAsync(BatchInstallAgentRequest batchInstallAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchInstallAgentResponse>(response);
        }

        public AsyncInvoker<BatchInstallAgentResponse> BatchInstallAgentAsyncInvoker(BatchInstallAgentRequest batchInstallAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchInstallAgentRequest);
            return new AsyncInvoker<BatchInstallAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchInstallAgentResponse>);
        }
        
        /// <summary>
        /// 批量注销桌面
        ///
        /// 批量注销桌面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchLogoffDesktopsResponse> BatchLogoffDesktopsAsync(BatchLogoffDesktopsRequest batchLogoffDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLogoffDesktopsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchLogoffDesktopsResponse>(response);
        }

        public AsyncInvoker<BatchLogoffDesktopsResponse> BatchLogoffDesktopsAsyncInvoker(BatchLogoffDesktopsRequest batchLogoffDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchLogoffDesktopsRequest);
            return new AsyncInvoker<BatchLogoffDesktopsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchLogoffDesktopsResponse>);
        }
        
        /// <summary>
        /// 重建桌面
        ///
        /// 批量重建桌面系统盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRebuildDesktopsSystemDiskResponse> BatchRebuildDesktopsSystemDiskAsync(BatchRebuildDesktopsSystemDiskRequest batchRebuildDesktopsSystemDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebuildDesktopsSystemDiskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRebuildDesktopsSystemDiskResponse>(response);
        }

        public AsyncInvoker<BatchRebuildDesktopsSystemDiskResponse> BatchRebuildDesktopsSystemDiskAsyncInvoker(BatchRebuildDesktopsSystemDiskRequest batchRebuildDesktopsSystemDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebuildDesktopsSystemDiskRequest);
            return new AsyncInvoker<BatchRebuildDesktopsSystemDiskResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRebuildDesktopsSystemDiskResponse>);
        }
        
        /// <summary>
        /// 操作桌面
        ///
        /// 批量操作桌面，用于批量开机、关机和重启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRunDesktopsResponse> BatchRunDesktopsAsync(BatchRunDesktopsRequest batchRunDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRunDesktopsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRunDesktopsResponse>(response);
        }

        public AsyncInvoker<BatchRunDesktopsResponse> BatchRunDesktopsAsyncInvoker(BatchRunDesktopsRequest batchRunDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRunDesktopsRequest);
            return new AsyncInvoker<BatchRunDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRunDesktopsResponse>);
        }
        
        /// <summary>
        /// 取消远程协助
        ///
        /// 取消远程协助。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelRemoteAssistanceResponse> CancelRemoteAssistanceAsync(CancelRemoteAssistanceRequest cancelRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", cancelRemoteAssistanceRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemoteAssistanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRemoteAssistanceResponse>(response);
        }

        public AsyncInvoker<CancelRemoteAssistanceResponse> CancelRemoteAssistanceAsyncInvoker(CancelRemoteAssistanceRequest cancelRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", cancelRemoteAssistanceRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemoteAssistanceRequest);
            return new AsyncInvoker<CancelRemoteAssistanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRemoteAssistanceResponse>);
        }
        
        /// <summary>
        /// 切换桌面网络
        ///
        /// 切换桌面vpc、子网、ip、安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDesktopNetworkResponse> ChangeDesktopNetworkAsync(ChangeDesktopNetworkRequest changeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", changeDesktopNetworkRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopNetworkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDesktopNetworkResponse>(response);
        }

        public AsyncInvoker<ChangeDesktopNetworkResponse> ChangeDesktopNetworkAsyncInvoker(ChangeDesktopNetworkRequest changeDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", changeDesktopNetworkRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopNetworkRequest);
            return new AsyncInvoker<ChangeDesktopNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 桌面转镜像
        ///
        /// 桌面转镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDesktopToImageResponse> ChangeDesktopToImageAsync(ChangeDesktopToImageRequest changeDesktopToImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/desktop-to-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopToImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeDesktopToImageResponse>(response);
        }

        public AsyncInvoker<ChangeDesktopToImageResponse> ChangeDesktopToImageAsyncInvoker(ChangeDesktopToImageRequest changeDesktopToImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/desktop-to-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDesktopToImageRequest);
            return new AsyncInvoker<ChangeDesktopToImageResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeDesktopToImageResponse>);
        }
        
        /// <summary>
        /// 批量修改用户权限组
        ///
        /// 批量修改用户权限组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeUserPrivilegeGroupResponse> ChangeUserPrivilegeGroupAsync(ChangeUserPrivilegeGroupRequest changeUserPrivilegeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-user-privilege-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserPrivilegeGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeUserPrivilegeGroupResponse>(response);
        }

        public AsyncInvoker<ChangeUserPrivilegeGroupResponse> ChangeUserPrivilegeGroupAsyncInvoker(ChangeUserPrivilegeGroupRequest changeUserPrivilegeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-user-privilege-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserPrivilegeGroupRequest);
            return new AsyncInvoker<ChangeUserPrivilegeGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeUserPrivilegeGroupResponse>);
        }
        
        /// <summary>
        /// 创建桌面
        ///
        /// 创建桌面，并将此桌面分配给用户，当桌面创建成功后用户可以登录使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopResponse> CreateDesktopAsync(CreateDesktopRequest createDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopResponse>(response);
        }

        public AsyncInvoker<CreateDesktopResponse> CreateDesktopAsyncInvoker(CreateDesktopRequest createDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopRequest);
            return new AsyncInvoker<CreateDesktopResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopResponse>);
        }
        
        /// <summary>
        /// 创建远程协助
        ///
        /// 创建远程协助。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRemoteAssistanceResponse> CreateRemoteAssistanceAsync(CreateRemoteAssistanceRequest createRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createRemoteAssistanceRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemoteAssistanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRemoteAssistanceResponse>(response);
        }

        public AsyncInvoker<CreateRemoteAssistanceResponse> CreateRemoteAssistanceAsyncInvoker(CreateRemoteAssistanceRequest createRemoteAssistanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createRemoteAssistanceRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemoteAssistanceRequest);
            return new AsyncInvoker<CreateRemoteAssistanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRemoteAssistanceResponse>);
        }
        
        /// <summary>
        /// 删除单个桌面
        ///
        /// 删除单个桌面，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDesktopResponse> DeleteDesktopAsync(DeleteDesktopRequest deleteDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteDesktopRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDesktopResponse>(response);
        }

        public AsyncInvoker<DeleteDesktopResponse> DeleteDesktopAsyncInvoker(DeleteDesktopRequest deleteDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteDesktopRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopRequest);
            return new AsyncInvoker<DeleteDesktopResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDesktopResponse>);
        }
        
        /// <summary>
        /// 解绑用户
        ///
        /// 将桌面和用户解绑
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest detachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetachInstancesResponse>(response);
        }

        public AsyncInvoker<DetachInstancesResponse> DetachInstancesAsyncInvoker(DetachInstancesRequest detachInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInstancesRequest);
            return new AsyncInvoker<DetachInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachInstancesResponse>);
        }
        
        /// <summary>
        /// 查询桌面安装agent详情
        ///
        /// 展示桌面安装agent详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentsInstallConditionResponse> ListAgentsInstallConditionAsync(ListAgentsInstallConditionRequest listAgentsInstallConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsInstallConditionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgentsInstallConditionResponse>(response);
        }

        public AsyncInvoker<ListAgentsInstallConditionResponse> ListAgentsInstallConditionAsyncInvoker(ListAgentsInstallConditionRequest listAgentsInstallConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsInstallConditionRequest);
            return new AsyncInvoker<ListAgentsInstallConditionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentsInstallConditionResponse>);
        }
        
        /// <summary>
        /// 查询桌面开关机信息
        ///
        /// 获取桌面开关机信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopActionsResponse> ListDesktopActionsAsync(ListDesktopActionsRequest listDesktopActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", listDesktopActionsRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopActionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopActionsResponse>(response);
        }

        public AsyncInvoker<ListDesktopActionsResponse> ListDesktopActionsAsyncInvoker(ListDesktopActionsRequest listDesktopActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", listDesktopActionsRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopActionsRequest);
            return new AsyncInvoker<ListDesktopActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopActionsResponse>);
        }
        
        /// <summary>
        /// 查询桌面解绑信息
        ///
        /// 查询桌面解绑信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopDetachInfoResponse> ListDesktopDetachInfoAsync(ListDesktopDetachInfoRequest listDesktopDetachInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", listDesktopDetachInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/detach-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopDetachInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopDetachInfoResponse>(response);
        }

        public AsyncInvoker<ListDesktopDetachInfoResponse> ListDesktopDetachInfoAsyncInvoker(ListDesktopDetachInfoRequest listDesktopDetachInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", listDesktopDetachInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/detach-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopDetachInfoRequest);
            return new AsyncInvoker<ListDesktopDetachInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopDetachInfoResponse>);
        }
        
        /// <summary>
        /// 查询桌面列表
        ///
        /// 该接口用于查询桌面虚拟机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopsResponse> ListDesktopsAsync(ListDesktopsRequest listDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsResponse>(response);
        }

        public AsyncInvoker<ListDesktopsResponse> ListDesktopsAsyncInvoker(ListDesktopsRequest listDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsRequest);
            return new AsyncInvoker<ListDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询桌面连接状态列表
        ///
        /// 查询桌面连接状态列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopsConnectStatusResponse> ListDesktopsConnectStatusAsync(ListDesktopsConnectStatusRequest listDesktopsConnectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connect-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsConnectStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsConnectStatusResponse>(response);
        }

        public AsyncInvoker<ListDesktopsConnectStatusResponse> ListDesktopsConnectStatusAsyncInvoker(ListDesktopsConnectStatusRequest listDesktopsConnectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connect-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsConnectStatusRequest);
            return new AsyncInvoker<ListDesktopsConnectStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsConnectStatusResponse>);
        }
        
        /// <summary>
        /// 查询桌面详情列表
        ///
        /// 查询桌面详情信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopsDetailResponse> ListDesktopsDetailAsync(ListDesktopsDetailRequest listDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsDetailResponse>(response);
        }

        public AsyncInvoker<ListDesktopsDetailResponse> ListDesktopsDetailAsyncInvoker(ListDesktopsDetailRequest listDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsDetailRequest);
            return new AsyncInvoker<ListDesktopsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsDetailResponse>);
        }
        
        /// <summary>
        /// 重新加入AD域
        ///
        /// 该接口用于Windows桌面重新加入AD域，一般用于解决桌面脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest registerDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", registerDomainRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterDomainResponse>(response);
        }

        public AsyncInvoker<RegisterDomainResponse> RegisterDomainAsyncInvoker(RegisterDomainRequest registerDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", registerDomainRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDomainRequest);
            return new AsyncInvoker<RegisterDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterDomainResponse>);
        }
        
        /// <summary>
        /// 变更规格
        ///
        /// 变更云桌面规格，只支持变更CPU和内存，不支持变更磁盘，不支持同规格互相变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeDesktopResponse> ResizeDesktopAsync(ResizeDesktopRequest resizeDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeDesktopResponse>(response);
        }

        public AsyncInvoker<ResizeDesktopResponse> ResizeDesktopAsyncInvoker(ResizeDesktopRequest resizeDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopRequest);
            return new AsyncInvoker<ResizeDesktopResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeDesktopResponse>);
        }
        
        /// <summary>
        /// 发送消息通知
        ///
        /// 用于管理员向桌面发送消息通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendNotificationsResponse> SendNotificationsAsync(SendNotificationsRequest sendNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendNotificationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendNotificationsResponse>(response);
        }

        public AsyncInvoker<SendNotificationsResponse> SendNotificationsAsyncInvoker(SendNotificationsRequest sendNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendNotificationsRequest);
            return new AsyncInvoker<SendNotificationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SendNotificationsResponse>);
        }
        
        /// <summary>
        /// 批量设置桌面维护模式
        ///
        /// 批量设置桌面管理员维护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetMaintenanceModeResponse> SetMaintenanceModeAsync(SetMaintenanceModeRequest setMaintenanceModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/maintenance-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMaintenanceModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetMaintenanceModeResponse>(response);
        }

        public AsyncInvoker<SetMaintenanceModeResponse> SetMaintenanceModeAsyncInvoker(SetMaintenanceModeRequest setMaintenanceModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/maintenance-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setMaintenanceModeRequest);
            return new AsyncInvoker<SetMaintenanceModeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetMaintenanceModeResponse>);
        }
        
        /// <summary>
        /// 查询单个桌面详情
        ///
        /// 指定桌面Id查询详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopDetailResponse> ShowDesktopDetailAsync(ShowDesktopDetailRequest showDesktopDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopDetailRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopDetailResponse>(response);
        }

        public AsyncInvoker<ShowDesktopDetailResponse> ShowDesktopDetailAsyncInvoker(ShowDesktopDetailRequest showDesktopDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopDetailRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopDetailRequest);
            return new AsyncInvoker<ShowDesktopDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopDetailResponse>);
        }
        
        /// <summary>
        /// 查询桌面监控信息
        ///
        /// 该接口可获取某一计算机在一段时间段(范围：1小时到30天)的数据信息（例如CPU占用率、内存占用率、用户的在线时间段等），最长数据保存时间不能超过180天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopMonitorDataResponse> ShowDesktopMonitorDataAsync(ShowDesktopMonitorDataRequest showDesktopMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopMonitorDataRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-monitor/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopMonitorDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopMonitorDataResponse>(response);
        }

        public AsyncInvoker<ShowDesktopMonitorDataResponse> ShowDesktopMonitorDataAsyncInvoker(ShowDesktopMonitorDataRequest showDesktopMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopMonitorDataRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-monitor/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopMonitorDataRequest);
            return new AsyncInvoker<ShowDesktopMonitorDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopMonitorDataResponse>);
        }
        
        /// <summary>
        /// 查询桌面网络
        ///
        /// 查询桌面vpc、子网、privateIp、EIP、安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopNetworkResponse> ShowDesktopNetworkAsync(ShowDesktopNetworkRequest showDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopNetworkRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopNetworkResponse>(response);
        }

        public AsyncInvoker<ShowDesktopNetworkResponse> ShowDesktopNetworkAsyncInvoker(ShowDesktopNetworkRequest showDesktopNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopNetworkRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworkRequest);
            return new AsyncInvoker<ShowDesktopNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopNetworkResponse>);
        }
        
        /// <summary>
        /// 批量查询桌面网络
        ///
        /// 查询桌面vpc、子网、privateIp、EIP、安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopNetworksResponse> ShowDesktopNetworksAsync(ShowDesktopNetworksRequest showDesktopNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopNetworksResponse>(response);
        }

        public AsyncInvoker<ShowDesktopNetworksResponse> ShowDesktopNetworksAsyncInvoker(ShowDesktopNetworksRequest showDesktopNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopNetworksRequest);
            return new AsyncInvoker<ShowDesktopNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopNetworksResponse>);
        }
        
        /// <summary>
        /// 根据桌面id查询远程协助信息
        ///
        /// 根据桌面id查询远程协助信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopRemoteAssistanceInfoResponse> ShowDesktopRemoteAssistanceInfoAsync(ShowDesktopRemoteAssistanceInfoRequest showDesktopRemoteAssistanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopRemoteAssistanceInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopRemoteAssistanceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopRemoteAssistanceInfoResponse>(response);
        }

        public AsyncInvoker<ShowDesktopRemoteAssistanceInfoResponse> ShowDesktopRemoteAssistanceInfoAsyncInvoker(ShowDesktopRemoteAssistanceInfoRequest showDesktopRemoteAssistanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showDesktopRemoteAssistanceInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-assistance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopRemoteAssistanceInfoRequest);
            return new AsyncInvoker<ShowDesktopRemoteAssistanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopRemoteAssistanceInfoResponse>);
        }
        
        /// <summary>
        /// 远程登录控制台
        ///
        /// 用于直接获取远程登录控制台地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRemoteConsoleAddressResponse> ShowRemoteConsoleAddressAsync(ShowRemoteConsoleAddressRequest showRemoteConsoleAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showRemoteConsoleAddressRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-consoles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteConsoleAddressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRemoteConsoleAddressResponse>(response);
        }

        public AsyncInvoker<ShowRemoteConsoleAddressResponse> ShowRemoteConsoleAddressAsyncInvoker(ShowRemoteConsoleAddressRequest showRemoteConsoleAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showRemoteConsoleAddressRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/remote-consoles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteConsoleAddressRequest);
            return new AsyncInvoker<ShowRemoteConsoleAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemoteConsoleAddressResponse>);
        }
        
        /// <summary>
        /// 查询sysprep版本信息
        ///
        /// 查询sysprep版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSysprepInfoResponse> ShowSysprepInfoAsync(ShowSysprepInfoRequest showSysprepInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showSysprepInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/sysprep", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSysprepInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSysprepInfoResponse>(response);
        }

        public AsyncInvoker<ShowSysprepInfoResponse> ShowSysprepInfoAsyncInvoker(ShowSysprepInfoRequest showSysprepInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showSysprepInfoRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/sysprep", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSysprepInfoRequest);
            return new AsyncInvoker<ShowSysprepInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSysprepInfoResponse>);
        }
        
        /// <summary>
        /// 修改桌面属性
        ///
        /// 修改桌面属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDesktopResponse> UpdateDesktopAsync(UpdateDesktopRequest updateDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", updateDesktopRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDesktopResponse>(response);
        }

        public AsyncInvoker<UpdateDesktopResponse> UpdateDesktopAsyncInvoker(UpdateDesktopRequest updateDesktopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", updateDesktopRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopRequest);
            return new AsyncInvoker<UpdateDesktopResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDesktopResponse>);
        }
        
        /// <summary>
        /// 更新桌面SID
        ///
        /// 该接口用于桌面sid和WindowsAD中的SID不同时，更新桌面SID使其与AD中的SID保持一致，一般用于解决桌面脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDesktopSidsResponse> UpdateDesktopSidsAsync(UpdateDesktopSidsRequest updateDesktopSidsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/sids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopSidsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopSidsResponse>(response);
        }

        public AsyncInvoker<UpdateDesktopSidsResponse> UpdateDesktopSidsAsyncInvoker(UpdateDesktopSidsRequest updateDesktopSidsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/sids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopSidsRequest);
            return new AsyncInvoker<UpdateDesktopSidsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopSidsResponse>);
        }
        
        /// <summary>
        /// AD场景支持桌面更换关联用户名
        ///
        /// AD场景支持桌面更换关联用户名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDesktopUsernameResponse> UpdateDesktopUsernameAsync(UpdateDesktopUsernameRequest updateDesktopUsernameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-username", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopUsernameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopUsernameResponse>(response);
        }

        public AsyncInvoker<UpdateDesktopUsernameResponse> UpdateDesktopUsernameAsyncInvoker(UpdateDesktopUsernameRequest updateDesktopUsernameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/change-username", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopUsernameRequest);
            return new AsyncInvoker<UpdateDesktopUsernameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopUsernameResponse>);
        }
        
        /// <summary>
        /// 批量删除桌面名称策略
        ///
        /// 批量删除桌面名称策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDesktopNamePolicyResponse> BatchDeleteDesktopNamePolicyAsync(BatchDeleteDesktopNamePolicyRequest batchDeleteDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopNamePolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDesktopNamePolicyResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDesktopNamePolicyResponse> BatchDeleteDesktopNamePolicyAsyncInvoker(BatchDeleteDesktopNamePolicyRequest batchDeleteDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopNamePolicyRequest);
            return new AsyncInvoker<BatchDeleteDesktopNamePolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 创建桌面名称策略
        ///
        /// 创建桌面名称策略，用于自动生成桌面名称，最多允许50个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopNamePolicyResponse> CreateDesktopNamePolicyAsync(CreateDesktopNamePolicyRequest createDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopNamePolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopNamePolicyResponse>(response);
        }

        public AsyncInvoker<CreateDesktopNamePolicyResponse> CreateDesktopNamePolicyAsyncInvoker(CreateDesktopNamePolicyRequest createDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopNamePolicyRequest);
            return new AsyncInvoker<CreateDesktopNamePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 获取桌面名称策略
        ///
        /// 获取桌面名称策略，用于自动生成桌面名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopNamePolicyResponse> ListDesktopNamePolicyAsync(ListDesktopNamePolicyRequest listDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopNamePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopNamePolicyResponse>(response);
        }

        public AsyncInvoker<ListDesktopNamePolicyResponse> ListDesktopNamePolicyAsyncInvoker(ListDesktopNamePolicyRequest listDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopNamePolicyRequest);
            return new AsyncInvoker<ListDesktopNamePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 更新桌面名称策略
        ///
        /// 更新桌面名称策略，用于自动生成桌面名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDesktopNamePolicyResponse> UpdateDesktopNamePolicyAsync(UpdateDesktopNamePolicyRequest updateDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updateDesktopNamePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopNamePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopNamePolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDesktopNamePolicyResponse> UpdateDesktopNamePolicyAsyncInvoker(UpdateDesktopNamePolicyRequest updateDesktopNamePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updateDesktopNamePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-name-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopNamePolicyRequest);
            return new AsyncInvoker<UpdateDesktopNamePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopNamePolicyResponse>);
        }
        
        /// <summary>
        /// 桌面池批量添加磁盘
        ///
        /// 桌面池批量添加磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDesktopPoolVolumesResponse> AddDesktopPoolVolumesAsync(AddDesktopPoolVolumesRequest addDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", addDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopPoolVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopPoolVolumesResponse>(response);
        }

        public AsyncInvoker<AddDesktopPoolVolumesResponse> AddDesktopPoolVolumesAsyncInvoker(AddDesktopPoolVolumesRequest addDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", addDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopPoolVolumesRequest);
            return new AsyncInvoker<AddDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 创建桌面池
        ///
        /// 创建桌面池，可将此桌面池分配给用户、用户组，用户登录时会绑定其中一个桌面。
        /// 注:需通过开通委托功能接口先对云服务进行授权才可以使用该功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopPoolResponse> CreateDesktopPoolAsync(CreateDesktopPoolRequest createDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopPoolResponse>(response);
        }

        public AsyncInvoker<CreateDesktopPoolResponse> CreateDesktopPoolAsyncInvoker(CreateDesktopPoolRequest createDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolRequest);
            return new AsyncInvoker<CreateDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池授权用户、用户组
        ///
        /// 该接口用于桌面池授权用户、用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopPoolAuthorizedObjectsResponse> CreateDesktopPoolAuthorizedObjectsAsync(CreateDesktopPoolAuthorizedObjectsRequest createDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createDesktopPoolAuthorizedObjectsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolAuthorizedObjectsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDesktopPoolAuthorizedObjectsResponse>(response);
        }

        public AsyncInvoker<CreateDesktopPoolAuthorizedObjectsResponse> CreateDesktopPoolAuthorizedObjectsAsyncInvoker(CreateDesktopPoolAuthorizedObjectsRequest createDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createDesktopPoolAuthorizedObjectsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolAuthorizedObjectsRequest);
            return new AsyncInvoker<CreateDesktopPoolAuthorizedObjectsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDesktopPoolAuthorizedObjectsResponse>);
        }
        
        /// <summary>
        /// 删除桌面池
        ///
        /// 当桌面池内无桌面时可删除桌面池，桌面池删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDesktopPoolResponse> DeleteDesktopPoolAsync(DeleteDesktopPoolRequest deleteDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDesktopPoolResponse>(response);
        }

        public AsyncInvoker<DeleteDesktopPoolResponse> DeleteDesktopPoolAsyncInvoker(DeleteDesktopPoolRequest deleteDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolRequest);
            return new AsyncInvoker<DeleteDesktopPoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池批量删除磁盘
        ///
        /// 桌面池批量删除磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDesktopPoolVolumesResponse> DeleteDesktopPoolVolumesAsync(DeleteDesktopPoolVolumesRequest deleteDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopPoolVolumesResponse>(response);
        }

        public AsyncInvoker<DeleteDesktopPoolVolumesResponse> DeleteDesktopPoolVolumesAsyncInvoker(DeleteDesktopPoolVolumesRequest deleteDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopPoolVolumesRequest);
            return new AsyncInvoker<DeleteDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 操作桌面池
        ///
        /// 操作桌面池，用于桌面池里面的桌面批量开机、关机、重启和休眠。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteDesktopPoolActionResponse> ExecuteDesktopPoolActionAsync(ExecuteDesktopPoolActionRequest executeDesktopPoolActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", executeDesktopPoolActionRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteDesktopPoolActionResponse>(response);
        }

        public AsyncInvoker<ExecuteDesktopPoolActionResponse> ExecuteDesktopPoolActionAsyncInvoker(ExecuteDesktopPoolActionRequest executeDesktopPoolActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", executeDesktopPoolActionRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolActionRequest);
            return new AsyncInvoker<ExecuteDesktopPoolActionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteDesktopPoolActionResponse>);
        }
        
        /// <summary>
        /// 桌面池批量执行脚本
        ///
        /// 桌面池批量执行脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteDesktopPoolScriptResponse> ExecuteDesktopPoolScriptAsync(ExecuteDesktopPoolScriptRequest executeDesktopPoolScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", executeDesktopPoolScriptRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolScriptRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteDesktopPoolScriptResponse>(response);
        }

        public AsyncInvoker<ExecuteDesktopPoolScriptResponse> ExecuteDesktopPoolScriptAsyncInvoker(ExecuteDesktopPoolScriptRequest executeDesktopPoolScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", executeDesktopPoolScriptRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeDesktopPoolScriptRequest);
            return new AsyncInvoker<ExecuteDesktopPoolScriptResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteDesktopPoolScriptResponse>);
        }
        
        /// <summary>
        /// 扩容桌面池
        ///
        /// 扩容桌面池。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandDesktopPoolResponse> ExpandDesktopPoolAsync(ExpandDesktopPoolRequest expandDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", expandDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopPoolResponse>(response);
        }

        public AsyncInvoker<ExpandDesktopPoolResponse> ExpandDesktopPoolAsyncInvoker(ExpandDesktopPoolRequest expandDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", expandDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolRequest);
            return new AsyncInvoker<ExpandDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池批量扩容磁盘
        ///
        /// 桌面池批量扩容磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandDesktopPoolVolumesResponse> ExpandDesktopPoolVolumesAsync(ExpandDesktopPoolVolumesRequest expandDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", expandDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopPoolVolumesResponse>(response);
        }

        public AsyncInvoker<ExpandDesktopPoolVolumesResponse> ExpandDesktopPoolVolumesAsyncInvoker(ExpandDesktopPoolVolumesRequest expandDesktopPoolVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", expandDesktopPoolVolumesRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/volumes/batch-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopPoolVolumesRequest);
            return new AsyncInvoker<ExpandDesktopPoolVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopPoolVolumesResponse>);
        }
        
        /// <summary>
        /// 查询桌面池授权的用户、用户组
        ///
        /// 该接口用于查询指定桌面池授权的用户、用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopPoolAuthorizedObjectsResponse> ListDesktopPoolAuthorizedObjectsAsync(ListDesktopPoolAuthorizedObjectsRequest listDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listDesktopPoolAuthorizedObjectsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolAuthorizedObjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopPoolAuthorizedObjectsResponse>(response);
        }

        public AsyncInvoker<ListDesktopPoolAuthorizedObjectsResponse> ListDesktopPoolAuthorizedObjectsAsyncInvoker(ListDesktopPoolAuthorizedObjectsRequest listDesktopPoolAuthorizedObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listDesktopPoolAuthorizedObjectsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolAuthorizedObjectsRequest);
            return new AsyncInvoker<ListDesktopPoolAuthorizedObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopPoolAuthorizedObjectsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池列表
        ///
        /// 该接口用于查询桌面池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopPoolsResponse> ListDesktopPoolsAsync(ListDesktopPoolsRequest listDesktopPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopPoolsResponse>(response);
        }

        public AsyncInvoker<ListDesktopPoolsResponse> ListDesktopPoolsAsyncInvoker(ListDesktopPoolsRequest listDesktopPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopPoolsRequest);
            return new AsyncInvoker<ListDesktopPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopPoolsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池下的桌面信息
        ///
        /// 该接口用于查询桌面池下的桌面信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolDesktopsDetailResponse> ListPoolDesktopsDetailAsync(ListPoolDesktopsDetailRequest listPoolDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listPoolDesktopsDetailRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolDesktopsDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolDesktopsDetailResponse>(response);
        }

        public AsyncInvoker<ListPoolDesktopsDetailResponse> ListPoolDesktopsDetailAsyncInvoker(ListPoolDesktopsDetailRequest listPoolDesktopsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listPoolDesktopsDetailRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolDesktopsDetailRequest);
            return new AsyncInvoker<ListPoolDesktopsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolDesktopsDetailResponse>);
        }
        
        /// <summary>
        /// 桌面池重建系统盘
        ///
        /// 桌面池重建系统盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebuildDesktopPoolResponse> RebuildDesktopPoolAsync(RebuildDesktopPoolRequest rebuildDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", rebuildDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildDesktopPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebuildDesktopPoolResponse>(response);
        }

        public AsyncInvoker<RebuildDesktopPoolResponse> RebuildDesktopPoolAsyncInvoker(RebuildDesktopPoolRequest rebuildDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", rebuildDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/rebuild", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildDesktopPoolRequest);
            return new AsyncInvoker<RebuildDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<RebuildDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 桌面池变更规格
        ///
        /// 桌面池变更规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeDesktopPoolResponse> ResizeDesktopPoolAsync(ResizeDesktopPoolRequest resizeDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", resizeDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeDesktopPoolResponse>(response);
        }

        public AsyncInvoker<ResizeDesktopPoolResponse> ResizeDesktopPoolAsyncInvoker(ResizeDesktopPoolRequest resizeDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", resizeDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeDesktopPoolRequest);
            return new AsyncInvoker<ResizeDesktopPoolResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 发送消息通知
        ///
        /// 用于管理员向桌面发送消息通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendDesktopPoolNotificationsResponse> SendDesktopPoolNotificationsAsync(SendDesktopPoolNotificationsRequest sendDesktopPoolNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", sendDesktopPoolNotificationsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDesktopPoolNotificationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendDesktopPoolNotificationsResponse>(response);
        }

        public AsyncInvoker<SendDesktopPoolNotificationsResponse> SendDesktopPoolNotificationsAsyncInvoker(SendDesktopPoolNotificationsRequest sendDesktopPoolNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", sendDesktopPoolNotificationsRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDesktopPoolNotificationsRequest);
            return new AsyncInvoker<SendDesktopPoolNotificationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SendDesktopPoolNotificationsResponse>);
        }
        
        /// <summary>
        /// 查询桌面池详情
        ///
        /// 指定桌面池Id查询详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopPoolDetailResponse> ShowDesktopPoolDetailAsync(ShowDesktopPoolDetailRequest showDesktopPoolDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showDesktopPoolDetailRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopPoolDetailResponse>(response);
        }

        public AsyncInvoker<ShowDesktopPoolDetailResponse> ShowDesktopPoolDetailAsyncInvoker(ShowDesktopPoolDetailRequest showDesktopPoolDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showDesktopPoolDetailRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolDetailRequest);
            return new AsyncInvoker<ShowDesktopPoolDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopPoolDetailResponse>);
        }
        
        /// <summary>
        /// 查询桌面池的脚本执行任务列表
        ///
        /// 桌面池的脚本执行任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDesktopPoolsScriptExecTasksResponse> ShowDesktopPoolsScriptExecTasksAsync(ShowDesktopPoolsScriptExecTasksRequest showDesktopPoolsScriptExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/script-execution-tasks/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolsScriptExecTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDesktopPoolsScriptExecTasksResponse>(response);
        }

        public AsyncInvoker<ShowDesktopPoolsScriptExecTasksResponse> ShowDesktopPoolsScriptExecTasksAsyncInvoker(ShowDesktopPoolsScriptExecTasksRequest showDesktopPoolsScriptExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/script-execution-tasks/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDesktopPoolsScriptExecTasksRequest);
            return new AsyncInvoker<ShowDesktopPoolsScriptExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDesktopPoolsScriptExecTasksResponse>);
        }
        
        /// <summary>
        /// 修改桌面池属性
        ///
        /// 修改桌面池属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDesktopPoolResponse> UpdateDesktopPoolAsync(UpdateDesktopPoolRequest updateDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updateDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopPoolRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDesktopPoolResponse>(response);
        }

        public AsyncInvoker<UpdateDesktopPoolResponse> UpdateDesktopPoolAsyncInvoker(UpdateDesktopPoolRequest updateDesktopPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updateDesktopPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDesktopPoolRequest);
            return new AsyncInvoker<UpdateDesktopPoolResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDesktopPoolResponse>);
        }
        
        /// <summary>
        /// 批量添加多个桌面标签
        ///
        /// 同时对多个桌面批量添加标签，如果创建的标签已经存在（key相同）则覆，最大支持100个桌面，每个桌面最大20个标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddDesktopsTagsResponse> BatchAddDesktopsTagsAsync(BatchAddDesktopsTagsRequest batchAddDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddDesktopsTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddDesktopsTagsResponse>(response);
        }

        public AsyncInvoker<BatchAddDesktopsTagsResponse> BatchAddDesktopsTagsAsyncInvoker(BatchAddDesktopsTagsRequest batchAddDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddDesktopsTagsRequest);
            return new AsyncInvoker<BatchAddDesktopsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddDesktopsTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加删除标签
        ///
        /// 为指定桌面批量添加或删除标签。创建时，如果创建的标签已经存在（key相同），则覆盖。删除时，如果删除的标签不存在，默认处理成功
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchChangeTagsResponse> BatchChangeTagsAsync(BatchChangeTagsRequest batchChangeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", batchChangeTagsRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchChangeTagsResponse>(response);
        }

        public AsyncInvoker<BatchChangeTagsResponse> BatchChangeTagsAsyncInvoker(BatchChangeTagsRequest batchChangeTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", batchChangeTagsRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeTagsRequest);
            return new AsyncInvoker<BatchChangeTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchChangeTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除多个桌面标签
        ///
        /// 同时对多个桌面批量添加标签，删除时，如果删除的标签不存在默认处理成功，最大支持100个桌面，每个桌面最大20个标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDesktopsTagsResponse> BatchDeleteDesktopsTagsAsync(BatchDeleteDesktopsTagsRequest batchDeleteDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteDesktopsTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDesktopsTagsResponse> BatchDeleteDesktopsTagsAsyncInvoker(BatchDeleteDesktopsTagsRequest batchDeleteDesktopsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/batch-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopsTagsRequest);
            return new AsyncInvoker<BatchDeleteDesktopsTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteDesktopsTagsResponse>);
        }
        
        /// <summary>
        /// 创建桌面标签
        ///
        /// 该接口用于为桌面创建标签，一个桌面上最多有10个标签。创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createTagRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createTagRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除桌面标签
        ///
        /// 该接口用于删除桌面标签。删除时，如果删除的标签不存在，默认处理成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteTagRequest.DesktopId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteTagRequest.DesktopId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 使用标签过滤桌面
        ///
        /// 使用标签过滤桌面
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopByTagsResponse> ListDesktopByTagsAsync(ListDesktopByTagsRequest listDesktopByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListDesktopByTagsResponse>(response);
        }

        public AsyncInvoker<ListDesktopByTagsResponse> ListDesktopByTagsAsyncInvoker(ListDesktopByTagsRequest listDesktopByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopByTagsRequest);
            return new AsyncInvoker<ListDesktopByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDesktopByTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询桌面标签
        ///
        /// 查询指定桌面的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTagByDesktopIdResponse> ShowTagByDesktopIdAsync(ShowTagByDesktopIdRequest showTagByDesktopIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showTagByDesktopIdRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagByDesktopIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTagByDesktopIdResponse>(response);
        }

        public AsyncInvoker<ShowTagByDesktopIdResponse> ShowTagByDesktopIdAsyncInvoker(ShowTagByDesktopIdRequest showTagByDesktopIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", showTagByDesktopIdRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagByDesktopIdRequest);
            return new AsyncInvoker<ShowTagByDesktopIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagByDesktopIdResponse>);
        }
        
        /// <summary>
        /// 批量删除用户组
        ///
        /// 该接口用于批量删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteUserGroupsResponse> BatchDeleteUserGroupsAsync(BatchDeleteUserGroupsRequest batchDeleteUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUserGroupsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteUserGroupsResponse> BatchDeleteUserGroupsAsyncInvoker(BatchDeleteUserGroupsRequest batchDeleteUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserGroupsRequest);
            return new AsyncInvoker<BatchDeleteUserGroupsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUserGroupsResponse>);
        }
        
        /// <summary>
        /// 创建用户组
        ///
        /// 该接口用于创建用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest createUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserGroupResponse>(response);
        }

        public AsyncInvoker<CreateUserGroupResponse> CreateUserGroupAsyncInvoker(CreateUserGroupRequest createUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserGroupRequest);
            return new AsyncInvoker<CreateUserGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateUserGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest deleteUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteUserGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserGroupResponse>(response);
        }

        public AsyncInvoker<DeleteUserGroupResponse> DeleteUserGroupAsyncInvoker(DeleteUserGroupRequest deleteUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteUserGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserGroupRequest);
            return new AsyncInvoker<DeleteUserGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组列表
        ///
        /// 查询用户组列表，支持分页。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest listUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserGroupsResponse>(response);
        }

        public AsyncInvoker<ListUserGroupsResponse> ListUserGroupsAsyncInvoker(ListUserGroupsRequest listUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGroupsRequest);
            return new AsyncInvoker<ListUserGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserGroupsResponse>);
        }
        
        /// <summary>
        /// 查询用户组中的用户
        ///
        /// 该接口用于查询用户组中的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersOfGroupResponse> ListUsersOfGroupAsync(ListUsersOfGroupRequest listUsersOfGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listUsersOfGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersOfGroupResponse>(response);
        }

        public AsyncInvoker<ListUsersOfGroupResponse> ListUsersOfGroupAsyncInvoker(ListUsersOfGroupRequest listUsersOfGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listUsersOfGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfGroupRequest);
            return new AsyncInvoker<ListUsersOfGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersOfGroupResponse>);
        }
        
        /// <summary>
        /// 操作用户组
        ///
        /// 操作用户组，如添加用户、删除用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunActionsOnGroupResponse> RunActionsOnGroupAsync(RunActionsOnGroupRequest runActionsOnGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", runActionsOnGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RunActionsOnGroupResponse>(response);
        }

        public AsyncInvoker<RunActionsOnGroupResponse> RunActionsOnGroupAsyncInvoker(RunActionsOnGroupRequest runActionsOnGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", runActionsOnGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnGroupRequest);
            return new AsyncInvoker<RunActionsOnGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunActionsOnGroupResponse>);
        }
        
        /// <summary>
        /// 修改用户组信息
        ///
        /// 该接口用于修改用户组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest updateUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateUserGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserGroupResponse>(response);
        }

        public AsyncInvoker<UpdateUserGroupResponse> UpdateUserGroupAsyncInvoker(UpdateUserGroupRequest updateUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateUserGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserGroupRequest);
            return new AsyncInvoker<UpdateUserGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserGroupResponse>);
        }
        
        /// <summary>
        /// 查询产品镜像列表
        ///
        /// 该接口用于查询云桌面支持的产品镜像列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }

        public AsyncInvoker<ListImagesResponse> ListImagesAsyncInvoker(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            return new AsyncInvoker<ListImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImagesResponse>);
        }
        
        /// <summary>
        /// 获取云市场镜像列表
        ///
        /// 获取云市场镜像列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMarketImagesResponse> ListMarketImagesAsync(ListMarketImagesRequest listMarketImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/market-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMarketImagesResponse>(response);
        }

        public AsyncInvoker<ListMarketImagesResponse> ListMarketImagesAsyncInvoker(ListMarketImagesRequest listMarketImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/market-images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketImagesRequest);
            return new AsyncInvoker<ListMarketImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMarketImagesResponse>);
        }
        
        /// <summary>
        /// 包周期桌面增配变更批量询价
        ///
        /// 包周期桌面增配变更批量询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateAddResourcesResponse> EstimateAddResourcesAsync(EstimateAddResourcesRequest estimateAddResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/add-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateAddResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateAddResourcesResponse>(response);
        }

        public AsyncInvoker<EstimateAddResourcesResponse> EstimateAddResourcesAsyncInvoker(EstimateAddResourcesRequest estimateAddResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/add-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateAddResourcesRequest);
            return new AsyncInvoker<EstimateAddResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateAddResourcesResponse>);
        }
        
        /// <summary>
        /// 批量包周期桌面切换镜像询价
        ///
        /// 批量包周期桌面切换镜像(由不收费镜像变更至收费镜像)询价。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateChangeImagesResponse> EstimateChangeImagesAsync(EstimateChangeImagesRequest estimateChangeImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateChangeImagesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateChangeImagesResponse>(response);
        }

        public AsyncInvoker<EstimateChangeImagesResponse> EstimateChangeImagesAsyncInvoker(EstimateChangeImagesRequest estimateChangeImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateChangeImagesRequest);
            return new AsyncInvoker<EstimateChangeImagesResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateChangeImagesResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池添加单个磁盘批量询价
        ///
        /// 包周期桌面池添加单个磁盘批量询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateDesktopPoolAddVolumeResponse> EstimateDesktopPoolAddVolumeAsync(EstimateDesktopPoolAddVolumeRequest estimateDesktopPoolAddVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/add-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolAddVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolAddVolumeResponse>(response);
        }

        public AsyncInvoker<EstimateDesktopPoolAddVolumeResponse> EstimateDesktopPoolAddVolumeAsyncInvoker(EstimateDesktopPoolAddVolumeRequest estimateDesktopPoolAddVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/add-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolAddVolumeRequest);
            return new AsyncInvoker<EstimateDesktopPoolAddVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolAddVolumeResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池切换镜像批量询价
        ///
        /// 包周期桌面池切换镜像(由不收费镜像变更至收费镜像)批量询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateDesktopPoolChangeImageResponse> EstimateDesktopPoolChangeImageAsync(EstimateDesktopPoolChangeImageRequest estimateDesktopPoolChangeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolChangeImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolChangeImageResponse>(response);
        }

        public AsyncInvoker<EstimateDesktopPoolChangeImageResponse> EstimateDesktopPoolChangeImageAsyncInvoker(EstimateDesktopPoolChangeImageRequest estimateDesktopPoolChangeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolChangeImageRequest);
            return new AsyncInvoker<EstimateDesktopPoolChangeImageResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolChangeImageResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池扩容磁盘批量询价
        ///
        /// 包周期桌面池扩容磁盘批量询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateDesktopPoolExtendVolumeResponse> EstimateDesktopPoolExtendVolumeAsync(EstimateDesktopPoolExtendVolumeRequest estimateDesktopPoolExtendVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolExtendVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolExtendVolumeResponse>(response);
        }

        public AsyncInvoker<EstimateDesktopPoolExtendVolumeResponse> EstimateDesktopPoolExtendVolumeAsyncInvoker(EstimateDesktopPoolExtendVolumeRequest estimateDesktopPoolExtendVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolExtendVolumeRequest);
            return new AsyncInvoker<EstimateDesktopPoolExtendVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolExtendVolumeResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池变更规格批量询价
        ///
        /// 包周期桌面池变更规格批量询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateDesktopPoolResizeResponse> EstimateDesktopPoolResizeAsync(EstimateDesktopPoolResizeRequest estimateDesktopPoolResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolResizeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EstimateDesktopPoolResizeResponse>(response);
        }

        public AsyncInvoker<EstimateDesktopPoolResizeResponse> EstimateDesktopPoolResizeAsyncInvoker(EstimateDesktopPoolResizeRequest estimateDesktopPoolResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/inquiry/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateDesktopPoolResizeRequest);
            return new AsyncInvoker<EstimateDesktopPoolResizeResponse>(this, "POST", request, JsonUtils.DeSerialize<EstimateDesktopPoolResizeResponse>);
        }
        
        /// <summary>
        /// 重试任务
        ///
        /// 该接口用来对失败的任务进行重试，当前仅支持开户和销户的任务重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunActionsOnWorkspaceJobResponse> RunActionsOnWorkspaceJobAsync(RunActionsOnWorkspaceJobRequest runActionsOnWorkspaceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runActionsOnWorkspaceJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnWorkspaceJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunActionsOnWorkspaceJobResponse>(response);
        }

        public AsyncInvoker<RunActionsOnWorkspaceJobResponse> RunActionsOnWorkspaceJobAsyncInvoker(RunActionsOnWorkspaceJobRequest runActionsOnWorkspaceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runActionsOnWorkspaceJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runActionsOnWorkspaceJobRequest);
            return new AsyncInvoker<RunActionsOnWorkspaceJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunActionsOnWorkspaceJobResponse>);
        }
        
        /// <summary>
        /// 删除子任务
        ///
        /// 该接口用于删除子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSubJobsResponse> BatchDeleteSubJobsAsync(BatchDeleteSubJobsRequest batchDeleteSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSubJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSubJobsResponse> BatchDeleteSubJobsAsyncInvoker(BatchDeleteSubJobsRequest batchDeleteSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSubJobsRequest);
            return new AsyncInvoker<BatchDeleteSubJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务查询
        ///
        /// 该接口用于查询异步任务执行情况，比如查询创建桌面的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListItaSubJobsResponse> ListItaSubJobsAsync(ListItaSubJobsRequest listItaSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItaSubJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListItaSubJobsResponse>(response);
        }

        public AsyncInvoker<ListItaSubJobsResponse> ListItaSubJobsAsyncInvoker(ListItaSubJobsRequest listItaSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItaSubJobsRequest);
            return new AsyncInvoker<ListItaSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListItaSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询任务详情
        ///
        /// 该接口用于查询异步任务的执行情况，比如查询创建桌面任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspace-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 查询租户的NAT映射配置项
        ///
        /// 查询租户的NAT映射配置项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatMappingConfigsResponse> ListNatMappingConfigsAsync(ListNatMappingConfigsRequest listNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatMappingConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatMappingConfigsResponse>(response);
        }

        public AsyncInvoker<ListNatMappingConfigsResponse> ListNatMappingConfigsAsyncInvoker(ListNatMappingConfigsRequest listNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatMappingConfigsRequest);
            return new AsyncInvoker<ListNatMappingConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatMappingConfigsResponse>);
        }
        
        /// <summary>
        /// 修改租户的NAT映射配置项
        ///
        /// 修改租户的NAT映射配置项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNatMappingConfigsResponse> UpdateNatMappingConfigsAsync(UpdateNatMappingConfigsRequest updateNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatMappingConfigsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateNatMappingConfigsResponse>(response);
        }

        public AsyncInvoker<UpdateNatMappingConfigsResponse> UpdateNatMappingConfigsAsyncInvoker(UpdateNatMappingConfigsRequest updateNatMappingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-mapping-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatMappingConfigsRequest);
            return new AsyncInvoker<UpdateNatMappingConfigsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNatMappingConfigsResponse>);
        }
        
        /// <summary>
        /// 开通桌面上网功能
        ///
        /// 开通桌面上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyDesktopsInternetResponse> ApplyDesktopsInternetAsync(ApplyDesktopsInternetRequest applyDesktopsInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDesktopsInternetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplyDesktopsInternetResponse>(response);
        }

        public AsyncInvoker<ApplyDesktopsInternetResponse> ApplyDesktopsInternetAsyncInvoker(ApplyDesktopsInternetRequest applyDesktopsInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDesktopsInternetRequest);
            return new AsyncInvoker<ApplyDesktopsInternetResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyDesktopsInternetResponse>);
        }
        
        /// <summary>
        /// 开通上网功能
        ///
        /// 开通上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyInternetResponse> ApplyInternetAsync(ApplyInternetRequest applyInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyInternetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ApplyInternetResponse>(response);
        }

        public AsyncInvoker<ApplyInternetResponse> ApplyInternetAsyncInvoker(ApplyInternetRequest applyInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyInternetRequest);
            return new AsyncInvoker<ApplyInternetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ApplyInternetResponse>);
        }
        
        /// <summary>
        /// 创建云办公带宽
        ///
        /// 创建按需云办公带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplySubnetBandwidthResponse> ApplySubnetBandwidthAsync(ApplySubnetBandwidthRequest applySubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applySubnetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplySubnetBandwidthResponse>(response);
        }

        public AsyncInvoker<ApplySubnetBandwidthResponse> ApplySubnetBandwidthAsyncInvoker(ApplySubnetBandwidthRequest applySubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applySubnetBandwidthRequest);
            return new AsyncInvoker<ApplySubnetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplySubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 桌面绑定EIP
        ///
        /// 桌面绑定EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateDesktopsEipResponse> AssociateDesktopsEipAsync(AssociateDesktopsEipRequest associateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateDesktopsEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateDesktopsEipResponse>(response);
        }

        public AsyncInvoker<AssociateDesktopsEipResponse> AssociateDesktopsEipAsyncInvoker(AssociateDesktopsEipRequest associateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateDesktopsEipRequest);
            return new AsyncInvoker<AssociateDesktopsEipResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateDesktopsEipResponse>);
        }
        
        /// <summary>
        /// 批量桌面解绑EIP
        ///
        /// 批量桌面解绑EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisassociateDesktopsEipResponse> BatchDisassociateDesktopsEipAsync(BatchDisassociateDesktopsEipRequest batchDisassociateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisassociateDesktopsEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisassociateDesktopsEipResponse>(response);
        }

        public AsyncInvoker<BatchDisassociateDesktopsEipResponse> BatchDisassociateDesktopsEipAsyncInvoker(BatchDisassociateDesktopsEipRequest batchDisassociateDesktopsEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisassociateDesktopsEipRequest);
            return new AsyncInvoker<BatchDisassociateDesktopsEipResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisassociateDesktopsEipResponse>);
        }
        
        /// <summary>
        /// 删除云办公带宽
        ///
        /// 删除云办公带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubnetBandwidthResponse> DeleteSubnetBandwidthAsync(DeleteSubnetBandwidthRequest deleteSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", deleteSubnetBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetBandwidthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSubnetBandwidthResponse>(response);
        }

        public AsyncInvoker<DeleteSubnetBandwidthResponse> DeleteSubnetBandwidthAsyncInvoker(DeleteSubnetBandwidthRequest deleteSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", deleteSubnetBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetBandwidthRequest);
            return new AsyncInvoker<DeleteSubnetBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询已绑定桌面和未绑定的Eip
        ///
        /// 查询已绑定桌面和未绑定的Eip。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopsEipsResponse> ListDesktopsEipsAsync(ListDesktopsEipsRequest listDesktopsEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsEipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsEipsResponse>(response);
        }

        public AsyncInvoker<ListDesktopsEipsResponse> ListDesktopsEipsAsyncInvoker(ListDesktopsEipsRequest listDesktopsEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsEipsRequest);
            return new AsyncInvoker<ListDesktopsEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsEipsResponse>);
        }
        
        /// <summary>
        /// 查询上网功能
        ///
        /// 查询上网功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetResponse> ListInternetAsync(ListInternetRequest listInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInternetResponse>(response);
        }

        public AsyncInvoker<ListInternetResponse> ListInternetAsyncInvoker(ListInternetRequest listInternetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/internet", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetRequest);
            return new AsyncInvoker<ListInternetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetResponse>);
        }
        
        /// <summary>
        /// 查询Nat网关列表
        ///
        /// 查询NAT网关列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewaysResponse> ListNatGatewaysAsync(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaysResponse>(response);
        }

        public AsyncInvoker<ListNatGatewaysResponse> ListNatGatewaysAsyncInvoker(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat-gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            return new AsyncInvoker<ListNatGatewaysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaysResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询端口列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPortsResponse> ListPortsAsync(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }

        public AsyncInvoker<ListPortsResponse> ListPortsAsyncInvoker(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            return new AsyncInvoker<ListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPortsResponse>);
        }
        
        /// <summary>
        /// 查询云办公带宽列表
        ///
        /// 查询云办公带宽列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubnetBandwidthsResponse> ListSubnetBandwidthsAsync(ListSubnetBandwidthsRequest listSubnetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListSubnetBandwidthsResponse> ListSubnetBandwidthsAsyncInvoker(ListSubnetBandwidthsRequest listSubnetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetBandwidthsRequest);
            return new AsyncInvoker<ListSubnetBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询云办公带宽的控制配置
        ///
        /// 查询云办公带宽的控制配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubnetBandwidthControlListResponse> ShowSubnetBandwidthControlListAsync(ShowSubnetBandwidthControlListRequest showSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", showSubnetBandwidthControlListRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetBandwidthControlListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetBandwidthControlListResponse>(response);
        }

        public AsyncInvoker<ShowSubnetBandwidthControlListResponse> ShowSubnetBandwidthControlListAsyncInvoker(ShowSubnetBandwidthControlListRequest showSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", showSubnetBandwidthControlListRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetBandwidthControlListRequest);
            return new AsyncInvoker<ShowSubnetBandwidthControlListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetBandwidthControlListResponse>);
        }
        
        /// <summary>
        /// 查询正在被使用的子网id列表
        ///
        /// 根据子网id列表查询正在被桌面使用的子网id，并且返回subnetId列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUsingSubnetsResponse> ShowUsingSubnetsAsync(ShowUsingSubnetsRequest showUsingSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/using-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUsingSubnetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUsingSubnetsResponse>(response);
        }

        public AsyncInvoker<ShowUsingSubnetsResponse> ShowUsingSubnetsAsyncInvoker(ShowUsingSubnetsRequest showUsingSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/using-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUsingSubnetsRequest);
            return new AsyncInvoker<ShowUsingSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUsingSubnetsResponse>);
        }
        
        /// <summary>
        /// 修改云办公带宽
        ///
        /// 修改云办公带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubnetBandwidthResponse> UpdateSubnetBandwidthAsync(UpdateSubnetBandwidthRequest updateSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateSubnetBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSubnetBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateSubnetBandwidthResponse> UpdateSubnetBandwidthAsyncInvoker(UpdateSubnetBandwidthRequest updateSubnetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateSubnetBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthRequest);
            return new AsyncInvoker<UpdateSubnetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSubnetBandwidthResponse>);
        }
        
        /// <summary>
        /// 修改云办公带宽的控制配置
        ///
        /// 修改云办公带宽的控制配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubnetBandwidthControlListResponse> UpdateSubnetBandwidthControlListAsync(UpdateSubnetBandwidthControlListRequest updateSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateSubnetBandwidthControlListRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthControlListRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubnetBandwidthControlListResponse>(response);
        }

        public AsyncInvoker<UpdateSubnetBandwidthControlListResponse> UpdateSubnetBandwidthControlListAsyncInvoker(UpdateSubnetBandwidthControlListRequest updateSubnetBandwidthControlListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateSubnetBandwidthControlListRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/control-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetBandwidthControlListRequest);
            return new AsyncInvoker<UpdateSubnetBandwidthControlListResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubnetBandwidthControlListResponse>);
        }
        
        /// <summary>
        /// 创建变更订单
        ///
        /// 变更规格、扩容磁盘[、按需转包周期生成订单](tag:inner)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateChangeOrderResponse> CreateChangeOrderAsync(CreateChangeOrderRequest createChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createChangeOrderRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/{desktop_id}/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createChangeOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateChangeOrderResponse>(response);
        }

        public AsyncInvoker<CreateChangeOrderResponse> CreateChangeOrderAsyncInvoker(CreateChangeOrderRequest createChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", createChangeOrderRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/{desktop_id}/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createChangeOrderRequest);
            return new AsyncInvoker<CreateChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateChangeOrderResponse>);
        }
        
        /// <summary>
        /// 包周期桌面批量变更下单
        ///
        /// 包周期桌面批量变更下单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopBatchOrderResponse> CreateDesktopBatchOrderAsync(CreateDesktopBatchOrderRequest createDesktopBatchOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/change/batch-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopBatchOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopBatchOrderResponse>(response);
        }

        public AsyncInvoker<CreateDesktopBatchOrderResponse> CreateDesktopBatchOrderAsyncInvoker(CreateDesktopBatchOrderRequest createDesktopBatchOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/change/batch-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopBatchOrderRequest);
            return new AsyncInvoker<CreateDesktopBatchOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopBatchOrderResponse>);
        }
        
        /// <summary>
        /// 创建桌面订单
        ///
        /// 创建桌面订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopOrderResponse> CreateDesktopOrderAsync(CreateDesktopOrderRequest createDesktopOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/orders/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopOrderResponse>(response);
        }

        public AsyncInvoker<CreateDesktopOrderResponse> CreateDesktopOrderAsyncInvoker(CreateDesktopOrderRequest createDesktopOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/orders/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopOrderRequest);
            return new AsyncInvoker<CreateDesktopOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopOrderResponse>);
        }
        
        /// <summary>
        /// 包周期桌面池批量变更下单
        ///
        /// 包周期桌面池批量变更下单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopPoolChangeOrderResponse> CreateDesktopPoolChangeOrderAsync(CreateDesktopPoolChangeOrderRequest createDesktopPoolChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolChangeOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopPoolChangeOrderResponse>(response);
        }

        public AsyncInvoker<CreateDesktopPoolChangeOrderResponse> CreateDesktopPoolChangeOrderAsyncInvoker(CreateDesktopPoolChangeOrderRequest createDesktopPoolChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop-pool/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopPoolChangeOrderRequest);
            return new AsyncInvoker<CreateDesktopPoolChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopPoolChangeOrderResponse>);
        }
        
        /// <summary>
        /// 包周期下单
        ///
        /// 包周期资源（桌面、磁盘[、云办公主机](tag:ZQ)）下订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrderResponse>(response);
        }

        public AsyncInvoker<CreateOrderResponse> CreateOrderAsyncInvoker(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/periodic/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            return new AsyncInvoker<CreateOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrderResponse>);
        }
        
        /// <summary>
        /// 包周期云办公带宽变更下单
        ///
        /// 包周期云办公带宽变更下单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubnetBandwidthChangeOrderResponse> CreateSubnetBandwidthChangeOrderAsync(CreateSubnetBandwidthChangeOrderRequest createSubnetBandwidthChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", createSubnetBandwidthChangeOrderRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubnetBandwidthChangeOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSubnetBandwidthChangeOrderResponse>(response);
        }

        public AsyncInvoker<CreateSubnetBandwidthChangeOrderResponse> CreateSubnetBandwidthChangeOrderAsyncInvoker(CreateSubnetBandwidthChangeOrderRequest createSubnetBandwidthChangeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", createSubnetBandwidthChangeOrderRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidths/{bandwidth_id}/periodic/change/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubnetBandwidthChangeOrderRequest);
            return new AsyncInvoker<CreateSubnetBandwidthChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubnetBandwidthChangeOrderResponse>);
        }
        
        /// <summary>
        /// 新增OU信息
        ///
        /// 该接口用于创建OU。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddOuResponse> AddOuAsync(AddOuRequest addOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOuRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddOuResponse>(response);
        }

        public AsyncInvoker<AddOuResponse> AddOuAsyncInvoker(AddOuRequest addOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOuRequest);
            return new AsyncInvoker<AddOuResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOuResponse>);
        }
        
        /// <summary>
        /// 删除OU信息
        ///
        /// 该接口用于删除OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOuResponse> DeleteOuAsync(DeleteOuRequest deleteOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ou_id", deleteOuRequest.OuId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOuRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOuResponse>(response);
        }

        public AsyncInvoker<DeleteOuResponse> DeleteOuAsyncInvoker(DeleteOuRequest deleteOuRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ou_id", deleteOuRequest.OuId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOuRequest);
            return new AsyncInvoker<DeleteOuResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOuResponse>);
        }
        
        /// <summary>
        /// 查询OU下用户信息
        ///
        /// 查询OU下用户信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAdOuUsersResponse> ListAdOuUsersAsync(ListAdOuUsersRequest listAdOuUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ou-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOuUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAdOuUsersResponse>(response);
        }

        public AsyncInvoker<ListAdOuUsersResponse> ListAdOuUsersAsyncInvoker(ListAdOuUsersRequest listAdOuUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ou-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOuUsersRequest);
            return new AsyncInvoker<ListAdOuUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAdOuUsersResponse>);
        }
        
        /// <summary>
        /// 查询OU信息
        ///
        /// 查询OU信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAdOusResponse> ListAdOusAsync(ListAdOusRequest listAdOusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ad-ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAdOusResponse>(response);
        }

        public AsyncInvoker<ListAdOusResponse> ListAdOusAsyncInvoker(ListAdOusRequest listAdOusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ad-ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAdOusRequest);
            return new AsyncInvoker<ListAdOusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAdOusResponse>);
        }
        
        /// <summary>
        /// 查询OU信息
        ///
        /// 查询OU信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOuDetailsResponse> ListOuDetailsAsync(ListOuDetailsRequest listOuDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOuDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOuDetailsResponse>(response);
        }

        public AsyncInvoker<ListOuDetailsResponse> ListOuDetailsAsyncInvoker(ListOuDetailsRequest listOuDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOuDetailsRequest);
            return new AsyncInvoker<ListOuDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOuDetailsResponse>);
        }
        
        /// <summary>
        /// 更新OU信息
        ///
        /// 更新OU信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOuInfoResponse> UpdateOuInfoAsync(UpdateOuInfoRequest updateOuInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ou_id", updateOuInfoRequest.OuId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOuInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateOuInfoResponse>(response);
        }

        public AsyncInvoker<UpdateOuInfoResponse> UpdateOuInfoAsyncInvoker(UpdateOuInfoRequest updateOuInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ou_id", updateOuInfoRequest.OuId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ous/{ou_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOuInfoRequest);
            return new AsyncInvoker<UpdateOuInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateOuInfoResponse>);
        }
        
        /// <summary>
        /// 修改策略组应用对象
        ///
        /// 批量增加、删除应用对象到指定策略组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateTargetOfPolicyGroupResponse> BatchUpdateTargetOfPolicyGroupAsync(BatchUpdateTargetOfPolicyGroupRequest batchUpdateTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", batchUpdateTargetOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTargetOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchUpdateTargetOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<BatchUpdateTargetOfPolicyGroupResponse> BatchUpdateTargetOfPolicyGroupAsyncInvoker(BatchUpdateTargetOfPolicyGroupRequest batchUpdateTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", batchUpdateTargetOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTargetOfPolicyGroupRequest);
            return new AsyncInvoker<BatchUpdateTargetOfPolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateTargetOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 新增策略组
        ///
        /// 新增策略组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyGroupResponse>(response);
        }

        public AsyncInvoker<CreatePolicyGroupResponse> CreatePolicyGroupAsyncInvoker(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            return new AsyncInvoker<CreatePolicyGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 删除策略组
        ///
        /// 删除指定策略组，包含策略组对应的策略信息以及应用对象信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupAsync(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", deletePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>(response);
        }

        public AsyncInvoker<DeletePolicyGroupResponse> DeletePolicyGroupAsyncInvoker(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", deletePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            return new AsyncInvoker<DeletePolicyGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询初始策略项
        ///
        /// 查询初始策略项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOriginalPolicyInfoResponse> ListOriginalPolicyInfoAsync(ListOriginalPolicyInfoRequest listOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/original-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOriginalPolicyInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOriginalPolicyInfoResponse>(response);
        }

        public AsyncInvoker<ListOriginalPolicyInfoResponse> ListOriginalPolicyInfoAsyncInvoker(ListOriginalPolicyInfoRequest listOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/original-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOriginalPolicyInfoRequest);
            return new AsyncInvoker<ListOriginalPolicyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOriginalPolicyInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组中的策略项
        ///
        /// 查询指定策略组内的策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoliciesOfPolicyGroupResponse> ListPoliciesOfPolicyGroupAsync(ListPoliciesOfPolicyGroupRequest listPoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPoliciesOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListPoliciesOfPolicyGroupResponse> ListPoliciesOfPolicyGroupAsyncInvoker(ListPoliciesOfPolicyGroupRequest listPoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPoliciesOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesOfPolicyGroupRequest);
            return new AsyncInvoker<ListPoliciesOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组
        ///
        /// 根据策略组ID查询策略组详细信息，包含策略信息以及应用对象信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyDetailInfoByIdResponse> ListPolicyDetailInfoByIdAsync(ListPolicyDetailInfoByIdRequest listPolicyDetailInfoByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPolicyDetailInfoByIdRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDetailInfoByIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyDetailInfoByIdResponse>(response);
        }

        public AsyncInvoker<ListPolicyDetailInfoByIdResponse> ListPolicyDetailInfoByIdAsyncInvoker(ListPolicyDetailInfoByIdRequest listPolicyDetailInfoByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPolicyDetailInfoByIdRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDetailInfoByIdRequest);
            return new AsyncInvoker<ListPolicyDetailInfoByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyDetailInfoByIdResponse>);
        }
        
        /// <summary>
        /// 查询策略组列表
        ///
        /// 查询策略组概要信息列表，不包含策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyGroupResponse> ListPolicyGroupAsync(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListPolicyGroupResponse> ListPolicyGroupAsyncInvoker(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            return new AsyncInvoker<ListPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情列表
        ///
        /// 包含策略信息以及应用对象的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyGroupInfoResponse> ListPolicyGroupInfoAsync(ListPolicyGroupInfoRequest listPolicyGroupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupInfoResponse>(response);
        }

        public AsyncInvoker<ListPolicyGroupInfoResponse> ListPolicyGroupInfoAsyncInvoker(ListPolicyGroupInfoRequest listPolicyGroupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupInfoRequest);
            return new AsyncInvoker<ListPolicyGroupInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组应用对象
        ///
        /// 查询指定策略组所应用的对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTargetOfPolicyGroupResponse> ListTargetOfPolicyGroupAsync(ListTargetOfPolicyGroupRequest listTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listTargetOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTargetOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListTargetOfPolicyGroupResponse> ListTargetOfPolicyGroupAsyncInvoker(ListTargetOfPolicyGroupRequest listTargetOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listTargetOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetOfPolicyGroupRequest);
            return new AsyncInvoker<ListTargetOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTargetOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组中的策略项
        ///
        /// 修改一个策略组的部分或者所有策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePoliciesOfPolicyGroupResponse> UpdatePoliciesOfPolicyGroupAsync(UpdatePoliciesOfPolicyGroupRequest updatePoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePoliciesOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoliciesOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoliciesOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<UpdatePoliciesOfPolicyGroupResponse> UpdatePoliciesOfPolicyGroupAsyncInvoker(UpdatePoliciesOfPolicyGroupRequest updatePoliciesOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePoliciesOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoliciesOfPolicyGroupRequest);
            return new AsyncInvoker<UpdatePoliciesOfPolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoliciesOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组
        ///
        /// 修改指定策略组的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyGroupResponse> UpdatePolicyGroupAsync(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyGroupResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyGroupResponse> UpdatePolicyGroupAsyncInvoker(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            return new AsyncInvoker<UpdatePolicyGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询可订购小时包类型
        ///
        /// 该接口用于查询可订购小时包类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHourPackagesTypeResponse> ListHourPackagesTypeAsync(ListHourPackagesTypeRequest listHourPackagesTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/hour-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHourPackagesTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHourPackagesTypeResponse>(response);
        }

        public AsyncInvoker<ListHourPackagesTypeResponse> ListHourPackagesTypeAsyncInvoker(ListHourPackagesTypeRequest listHourPackagesTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/hour-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHourPackagesTypeRequest);
            return new AsyncInvoker<ListHourPackagesTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHourPackagesTypeResponse>);
        }
        
        /// <summary>
        /// 查询产品套餐列表
        ///
        /// 该接口用于查询云桌面支持的产品套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public AsyncInvoker<ListProductsResponse> ListProductsAsyncInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new AsyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 查询协同套餐列表
        ///
        /// 该接口用于查询协同套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSharerProductsResponse> ListSharerProductsAsync(ListSharerProductsRequest listSharerProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/sharer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharerProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSharerProductsResponse>(response);
        }

        public AsyncInvoker<ListSharerProductsResponse> ListSharerProductsAsyncInvoker(ListSharerProductsRequest listSharerProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/products/sharer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharerProductsRequest);
            return new AsyncInvoker<ListSharerProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSharerProductsResponse>);
        }
        
        /// <summary>
        /// 查询租户功能状态
        ///
        /// 查询租户功能状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantProfilesResponse> ListTenantProfilesAsync(ListTenantProfilesRequest listTenantProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTenantProfilesResponse = JsonUtils.DeSerializeNull<ListTenantProfilesResponse>(response);
            listTenantProfilesResponse.Body = JsonUtils.DeSerializeMap<string, bool?>(response);
            return listTenantProfilesResponse;
        }

        public AsyncInvoker<ListTenantProfilesResponse> ListTenantProfilesAsyncInvoker(ListTenantProfilesRequest listTenantProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfilesRequest);
            return new AsyncInvoker<ListTenantProfilesResponse>(this, "GET", request, response =>
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
        public async Task<UpdateTenantProfileResponse> UpdateTenantProfileAsync(UpdateTenantProfileRequest updateTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantProfileRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTenantProfileResponse>(response);
        }

        public AsyncInvoker<UpdateTenantProfileResponse> UpdateTenantProfileAsyncInvoker(UpdateTenantProfileRequest updateTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-center/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantProfileRequest);
            return new AsyncInvoker<UpdateTenantProfileResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateTenantProfileResponse>);
        }
        
        /// <summary>
        /// 查询租户单个站点配额详情
        ///
        /// 查询租户单个站点配额详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaDetailsResponse> ShowQuotaDetailsAsync(ShowQuotaDetailsRequest showQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaDetailsResponse>(response);
        }

        public AsyncInvoker<ShowQuotaDetailsResponse> ShowQuotaDetailsAsyncInvoker(ShowQuotaDetailsRequest showQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaDetailsRequest);
            return new AsyncInvoker<ShowQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// Console Framework和WKSDesktopManager调用该接口查询租户配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 批量删除定时任务
        ///
        /// 批量删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteScheduledTasksResponse> BatchDeleteScheduledTasksAsync(BatchDeleteScheduledTasksRequest batchDeleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduledTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScheduledTasksResponse>(response);
        }

        public AsyncInvoker<BatchDeleteScheduledTasksResponse> BatchDeleteScheduledTasksAsyncInvoker(BatchDeleteScheduledTasksRequest batchDeleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduledTasksRequest);
            return new AsyncInvoker<BatchDeleteScheduledTasksResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 创建定时任务
        ///
        /// 创建定时任务。
        /// 注:需通过开通委托功能接口先对云服务进行授权才可以使用该功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScheduledTasksResponse> CreateScheduledTasksAsync(CreateScheduledTasksRequest createScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduledTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateScheduledTasksResponse>(response);
        }

        public AsyncInvoker<CreateScheduledTasksResponse> CreateScheduledTasksAsyncInvoker(CreateScheduledTasksRequest createScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduledTasksRequest);
            return new AsyncInvoker<CreateScheduledTasksResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 删除定时任务
        ///
        /// 删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScheduledTasksResponse> DeleteScheduledTasksAsync(DeleteScheduledTasksRequest deleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTasksRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduledTasksResponse>(response);
        }

        public AsyncInvoker<DeleteScheduledTasksResponse> DeleteScheduledTasksAsyncInvoker(DeleteScheduledTasksRequest deleteScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTasksRequest);
            return new AsyncInvoker<DeleteScheduledTasksResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 未来执行的具体时间列表
        ///
        /// 未来执行的具体时间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFutureExecutionsResponse> ListFutureExecutionsAsync(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFutureExecutionsResponse>(response);
        }

        public AsyncInvoker<ListFutureExecutionsResponse> ListFutureExecutionsAsyncInvoker(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            return new AsyncInvoker<ListFutureExecutionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFutureExecutionsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksAsync(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksResponse>(response);
        }

        public AsyncInvoker<ListScheduledTasksResponse> ListScheduledTasksAsyncInvoker(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            return new AsyncInvoker<ListScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行记录
        ///
        /// 查询定时任务执行记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledTasksRecordsResponse> ListScheduledTasksRecordsAsync(ListScheduledTasksRecordsRequest listScheduledTasksRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listScheduledTasksRecordsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksRecordsResponse>(response);
        }

        public AsyncInvoker<ListScheduledTasksRecordsResponse> ListScheduledTasksRecordsAsyncInvoker(ListScheduledTasksRecordsRequest listScheduledTasksRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listScheduledTasksRecordsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsRequest);
            return new AsyncInvoker<ListScheduledTasksRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksRecordsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行记录详情
        ///
        /// 查询定时任务执行记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledTasksRecordsDetailsResponse> ListScheduledTasksRecordsDetailsAsync(ListScheduledTasksRecordsDetailsRequest listScheduledTasksRecordsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listScheduledTasksRecordsDetailsRequest.TaskId.ToString());
            urlParam.Add("record_id", listScheduledTasksRecordsDetailsRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksRecordsDetailsResponse>(response);
        }

        public AsyncInvoker<ListScheduledTasksRecordsDetailsResponse> ListScheduledTasksRecordsDetailsAsyncInvoker(ListScheduledTasksRecordsDetailsRequest listScheduledTasksRecordsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listScheduledTasksRecordsDetailsRequest.TaskId.ToString());
            urlParam.Add("record_id", listScheduledTasksRecordsDetailsRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}/records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRecordsDetailsRequest);
            return new AsyncInvoker<ListScheduledTasksRecordsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksRecordsDetailsResponse>);
        }
        
        /// <summary>
        /// 获取时区配置
        ///
        /// 获取时区配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTimeZonesResponse> ListTimeZonesAsync(ListTimeZonesRequest listTimeZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/common/timezones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTimeZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTimeZonesResponse>(response);
        }

        public AsyncInvoker<ListTimeZonesResponse> ListTimeZonesAsyncInvoker(ListTimeZonesRequest listTimeZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/common/timezones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTimeZonesRequest);
            return new AsyncInvoker<ListTimeZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTimeZonesResponse>);
        }
        
        /// <summary>
        /// 查询定时任务详情
        ///
        /// 查询定时任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScheduledTasksResponse> ShowScheduledTasksAsync(ShowScheduledTasksRequest showScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduledTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScheduledTasksResponse>(response);
        }

        public AsyncInvoker<ShowScheduledTasksResponse> ShowScheduledTasksAsyncInvoker(ShowScheduledTasksRequest showScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduledTasksRequest);
            return new AsyncInvoker<ShowScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 修改定时任务
        ///
        /// 修改定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScheduledTasksResponse> UpdateScheduledTasksAsync(UpdateScheduledTasksRequest updateScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTasksRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScheduledTasksResponse>(response);
        }

        public AsyncInvoker<UpdateScheduledTasksResponse> UpdateScheduledTasksAsyncInvoker(UpdateScheduledTasksRequest updateScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateScheduledTasksRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTasksRequest);
            return new AsyncInvoker<UpdateScheduledTasksResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 批量删除录屏记录
        ///
        /// 批量删除录屏记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteScreenRecordsResponse> BatchDeleteScreenRecordsAsync(BatchDeleteScreenRecordsRequest batchDeleteScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", batchDeleteScreenRecordsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteScreenRecordsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteScreenRecordsResponse> BatchDeleteScreenRecordsAsyncInvoker(BatchDeleteScreenRecordsRequest batchDeleteScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", batchDeleteScreenRecordsRequest);
            return new AsyncInvoker<BatchDeleteScreenRecordsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteScreenRecordsResponse>);
        }
        
        /// <summary>
        /// 查询桌面关键事件列表
        ///
        /// 查询桌面关键事件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopOperationsResponse> ListDesktopOperationsAsync(ListDesktopOperationsRequest listDesktopOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", listDesktopOperationsRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}/os-operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopOperationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopOperationsResponse>(response);
        }

        public AsyncInvoker<ListDesktopOperationsResponse> ListDesktopOperationsAsyncInvoker(ListDesktopOperationsRequest listDesktopOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", listDesktopOperationsRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}/os-operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopOperationsRequest);
            return new AsyncInvoker<ListDesktopOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopOperationsResponse>);
        }
        
        /// <summary>
        /// 查询下载地址列表
        ///
        /// 查询下载地址列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDownloadAddressResponse> ListDownloadAddressAsync(ListDownloadAddressRequest listDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/download-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", listDownloadAddressRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListDownloadAddressResponse>(response);
        }

        public AsyncInvoker<ListDownloadAddressResponse> ListDownloadAddressAsyncInvoker(ListDownloadAddressRequest listDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/download-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", listDownloadAddressRequest);
            return new AsyncInvoker<ListDownloadAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDownloadAddressResponse>);
        }
        
        /// <summary>
        /// 查询录屏记录列表
        ///
        /// 查询录屏记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScreenRecordsResponse> ListScreenRecordsAsync(ListScreenRecordsRequest listScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScreenRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScreenRecordsResponse>(response);
        }

        public AsyncInvoker<ListScreenRecordsResponse> ListScreenRecordsAsyncInvoker(ListScreenRecordsRequest listScreenRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScreenRecordsRequest);
            return new AsyncInvoker<ListScreenRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScreenRecordsResponse>);
        }
        
        /// <summary>
        /// 查询录屏详情
        ///
        /// 查询录屏详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScreenRecordResponse> ShowScreenRecordAsync(ShowScreenRecordRequest showScreenRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showScreenRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScreenRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScreenRecordResponse>(response);
        }

        public AsyncInvoker<ShowScreenRecordResponse> ShowScreenRecordAsyncInvoker(ShowScreenRecordRequest showScreenRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showScreenRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/screen-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScreenRecordRequest);
            return new AsyncInvoker<ShowScreenRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScreenRecordResponse>);
        }
        
        /// <summary>
        /// 新增脚本
        ///
        /// 新增脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest createScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScriptRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateScriptResponse>(response);
        }

        public AsyncInvoker<CreateScriptResponse> CreateScriptAsyncInvoker(CreateScriptRequest createScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScriptRequest);
            return new AsyncInvoker<CreateScriptResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScriptResponse>);
        }
        
        /// <summary>
        /// 删除脚本
        ///
        /// 删除脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest deleteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScriptRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScriptResponse>(response);
        }

        public AsyncInvoker<DeleteScriptResponse> DeleteScriptAsyncInvoker(DeleteScriptRequest deleteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScriptRequest);
            return new AsyncInvoker<DeleteScriptResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScriptResponse>);
        }
        
        /// <summary>
        /// 批量执行脚本或命令
        ///
        /// 批量执行脚本或命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteScriptOrCommandResponse> ExecuteScriptOrCommandAsync(ExecuteScriptOrCommandRequest executeScriptOrCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeScriptOrCommandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteScriptOrCommandResponse>(response);
        }

        public AsyncInvoker<ExecuteScriptOrCommandResponse> ExecuteScriptOrCommandAsyncInvoker(ExecuteScriptOrCommandRequest executeScriptOrCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeScriptOrCommandRequest);
            return new AsyncInvoker<ExecuteScriptOrCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteScriptOrCommandResponse>);
        }
        
        /// <summary>
        /// 查询脚本执行记录列表
        ///
        /// 查询脚本执行记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScriptRecordsResponse> ListScriptRecordsAsync(ListScriptRecordsRequest listScriptRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScriptRecordsResponse>(response);
        }

        public AsyncInvoker<ListScriptRecordsResponse> ListScriptRecordsAsyncInvoker(ListScriptRecordsRequest listScriptRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptRecordsRequest);
            return new AsyncInvoker<ListScriptRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptRecordsResponse>);
        }
        
        /// <summary>
        /// 查询脚本任务列表
        ///
        /// 查询脚本任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScriptTasksResponse> ListScriptTasksAsync(ListScriptTasksRequest listScriptTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScriptTasksResponse>(response);
        }

        public AsyncInvoker<ListScriptTasksResponse> ListScriptTasksAsyncInvoker(ListScriptTasksRequest listScriptTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptTasksRequest);
            return new AsyncInvoker<ListScriptTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptTasksResponse>);
        }
        
        /// <summary>
        /// 查询脚本列表
        ///
        /// 查询脚本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest listScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScriptsResponse>(response);
        }

        public AsyncInvoker<ListScriptsResponse> ListScriptsAsyncInvoker(ListScriptsRequest listScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScriptsRequest);
            return new AsyncInvoker<ListScriptsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScriptsResponse>);
        }
        
        /// <summary>
        /// 重试脚本或执行脚本失败的任务
        ///
        /// 重试脚本或执行脚本失败的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryScriptExecutionResponse> RetryScriptExecutionAsync(RetryScriptExecutionRequest retryScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryScriptExecutionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RetryScriptExecutionResponse>(response);
        }

        public AsyncInvoker<RetryScriptExecutionResponse> RetryScriptExecutionAsyncInvoker(RetryScriptExecutionRequest retryScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryScriptExecutionRequest);
            return new AsyncInvoker<RetryScriptExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryScriptExecutionResponse>);
        }
        
        /// <summary>
        /// 查询脚本详情
        ///
        /// 查询脚本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScriptDetailResponse> ShowScriptDetailAsync(ShowScriptDetailRequest showScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showScriptDetailRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScriptDetailResponse>(response);
        }

        public AsyncInvoker<ShowScriptDetailResponse> ShowScriptDetailAsyncInvoker(ShowScriptDetailRequest showScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showScriptDetailRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptDetailRequest);
            return new AsyncInvoker<ShowScriptDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScriptDetailResponse>);
        }
        
        /// <summary>
        /// 查询脚本执行记录详情
        ///
        /// 查询脚本执行记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScriptRecordDetailResponse> ShowScriptRecordDetailAsync(ShowScriptRecordDetailRequest showScriptRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showScriptRecordDetailRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptRecordDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScriptRecordDetailResponse>(response);
        }

        public AsyncInvoker<ShowScriptRecordDetailResponse> ShowScriptRecordDetailAsyncInvoker(ShowScriptRecordDetailRequest showScriptRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showScriptRecordDetailRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-execution-records/{record_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScriptRecordDetailRequest);
            return new AsyncInvoker<ShowScriptRecordDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScriptRecordDetailResponse>);
        }
        
        /// <summary>
        /// 停止脚本或者命令执行任务
        ///
        /// 停止脚本或者命令执行任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopScriptExecutionResponse> StopScriptExecutionAsync(StopScriptExecutionRequest stopScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopScriptExecutionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopScriptExecutionResponse>(response);
        }

        public AsyncInvoker<StopScriptExecutionResponse> StopScriptExecutionAsyncInvoker(StopScriptExecutionRequest stopScriptExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/script-executions/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopScriptExecutionRequest);
            return new AsyncInvoker<StopScriptExecutionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopScriptExecutionResponse>);
        }
        
        /// <summary>
        /// 更新脚本
        ///
        /// 更新脚本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest updateScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScriptRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScriptResponse>(response);
        }

        public AsyncInvoker<UpdateScriptResponse> UpdateScriptAsyncInvoker(UpdateScriptRequest updateScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScriptRequest);
            return new AsyncInvoker<UpdateScriptResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScriptResponse>);
        }
        
        /// <summary>
        /// 桌面购买附属资源
        ///
        /// 存量桌面购买附属资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDesktopSubResourcesResponse> AddDesktopSubResourcesAsync(AddDesktopSubResourcesRequest addDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopSubResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopSubResourcesResponse>(response);
        }

        public AsyncInvoker<AddDesktopSubResourcesResponse> AddDesktopSubResourcesAsyncInvoker(AddDesktopSubResourcesRequest addDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopSubResourcesRequest);
            return new AsyncInvoker<AddDesktopSubResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopSubResourcesResponse>);
        }
        
        /// <summary>
        /// 桌面删除附属资源
        ///
        /// 桌面删除附属资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDesktopSubResourcesResponse> DeleteDesktopSubResourcesAsync(DeleteDesktopSubResourcesRequest deleteDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/delete-sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopSubResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopSubResourcesResponse>(response);
        }

        public AsyncInvoker<DeleteDesktopSubResourcesResponse> DeleteDesktopSubResourcesAsyncInvoker(DeleteDesktopSubResourcesRequest deleteDesktopSubResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktop/delete-sub-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopSubResourcesRequest);
            return new AsyncInvoker<DeleteDesktopSubResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopSubResourcesResponse>);
        }
        
        /// <summary>
        /// 查询协同桌面默认用户配置
        ///
        /// 查询协同桌面默认用户配置（当前功能公测中,需要使用请联系管理员申请使用）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowShareSpaceConfigResponse> ShowShareSpaceConfigAsync(ShowShareSpaceConfigRequest showShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareSpaceConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowShareSpaceConfigResponse>(response);
        }

        public AsyncInvoker<ShowShareSpaceConfigResponse> ShowShareSpaceConfigAsyncInvoker(ShowShareSpaceConfigRequest showShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareSpaceConfigRequest);
            return new AsyncInvoker<ShowShareSpaceConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShareSpaceConfigResponse>);
        }
        
        /// <summary>
        /// 设置协同桌面默认用户配置
        ///
        /// 设置协同桌面默认用户配置（当前功能公测中，需要使用请联系管理员申请使用）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateShareSpaceConfigResponse> UpdateShareSpaceConfigAsync(UpdateShareSpaceConfigRequest updateShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareSpaceConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateShareSpaceConfigResponse>(response);
        }

        public AsyncInvoker<UpdateShareSpaceConfigResponse> UpdateShareSpaceConfigAsyncInvoker(UpdateShareSpaceConfigRequest updateShareSpaceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/share-space/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareSpaceConfigRequest);
            return new AsyncInvoker<UpdateShareSpaceConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateShareSpaceConfigResponse>);
        }
        
        /// <summary>
        /// 新增站点
        ///
        /// 用于查询站点信息的接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSiteResponse> AddSiteAsync(AddSiteRequest addSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSiteRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSiteResponse>(response);
        }

        public AsyncInvoker<AddSiteResponse> AddSiteAsyncInvoker(AddSiteRequest addSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSiteRequest);
            return new AsyncInvoker<AddSiteResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSiteResponse>);
        }
        
        /// <summary>
        /// 删除站点
        ///
        /// 用于删除站点的接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest deleteSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", deleteSiteRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSiteResponse>(response);
        }

        public AsyncInvoker<DeleteSiteResponse> DeleteSiteAsyncInvoker(DeleteSiteRequest deleteSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", deleteSiteRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteRequest);
            return new AsyncInvoker<DeleteSiteResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSiteResponse>);
        }
        
        /// <summary>
        /// 查询站点信息
        ///
        /// 用于查询站点信息的接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSiteConfigsResponse> ListSiteConfigsAsync(ListSiteConfigsRequest listSiteConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSiteConfigsResponse>(response);
        }

        public AsyncInvoker<ListSiteConfigsResponse> ListSiteConfigsAsyncInvoker(ListSiteConfigsRequest listSiteConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteConfigsRequest);
            return new AsyncInvoker<ListSiteConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteConfigsResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站列表
        ///
        /// 查询边缘小站列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWksEdgeSitesResponse> ListWksEdgeSitesAsync(ListWksEdgeSitesRequest listWksEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/wks-edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWksEdgeSitesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWksEdgeSitesResponse>(response);
        }

        public AsyncInvoker<ListWksEdgeSitesResponse> ListWksEdgeSitesAsyncInvoker(ListWksEdgeSitesRequest listWksEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/wks-edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWksEdgeSitesRequest);
            return new AsyncInvoker<ListWksEdgeSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWksEdgeSitesResponse>);
        }
        
        /// <summary>
        /// 修改站点接入方式
        ///
        /// 用于修改站点接入方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessModeResponse> UpdateAccessModeAsync(UpdateAccessModeRequest updateAccessModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", updateAccessModeRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/access-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessModeResponse>(response);
        }

        public AsyncInvoker<UpdateAccessModeResponse> UpdateAccessModeAsyncInvoker(UpdateAccessModeRequest updateAccessModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", updateAccessModeRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/access-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessModeRequest);
            return new AsyncInvoker<UpdateAccessModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessModeResponse>);
        }
        
        /// <summary>
        /// 修改站点业务子网
        ///
        /// 用于修改站点业务子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubnetIdsResponse> UpdateSubnetIdsAsync(UpdateSubnetIdsRequest updateSubnetIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", updateSubnetIdsRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/subnet-ids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetIdsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubnetIdsResponse>(response);
        }

        public AsyncInvoker<UpdateSubnetIdsResponse> UpdateSubnetIdsAsyncInvoker(UpdateSubnetIdsRequest updateSubnetIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_id", updateSubnetIdsRequest.SiteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/sites/{site_id}/subnet-ids", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubnetIdsRequest);
            return new AsyncInvoker<UpdateSubnetIdsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubnetIdsResponse>);
        }
        
        /// <summary>
        /// 批量创建快照
        ///
        /// 批量创建快照
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateDesktopSnapshotResponse> BatchCreateDesktopSnapshotAsync(BatchCreateDesktopSnapshotRequest batchCreateDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDesktopSnapshotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateDesktopSnapshotResponse>(response);
        }

        public AsyncInvoker<BatchCreateDesktopSnapshotResponse> BatchCreateDesktopSnapshotAsyncInvoker(BatchCreateDesktopSnapshotRequest batchCreateDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDesktopSnapshotRequest);
            return new AsyncInvoker<BatchCreateDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 批量删除快照
        ///
        /// 批量删除快照
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteDesktopSnapshotResponse> BatchDeleteDesktopSnapshotAsync(BatchDeleteDesktopSnapshotRequest batchDeleteDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopSnapshotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteDesktopSnapshotResponse>(response);
        }

        public AsyncInvoker<BatchDeleteDesktopSnapshotResponse> BatchDeleteDesktopSnapshotAsyncInvoker(BatchDeleteDesktopSnapshotRequest batchDeleteDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteDesktopSnapshotRequest);
            return new AsyncInvoker<BatchDeleteDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 批量恢复快照
        ///
        /// 批量恢快照
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestoreDesktopSnapshotResponse> BatchRestoreDesktopSnapshotAsync(BatchRestoreDesktopSnapshotRequest batchRestoreDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDesktopSnapshotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreDesktopSnapshotResponse>(response);
        }

        public AsyncInvoker<BatchRestoreDesktopSnapshotResponse> BatchRestoreDesktopSnapshotAsyncInvoker(BatchRestoreDesktopSnapshotRequest batchRestoreDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots/batch-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDesktopSnapshotRequest);
            return new AsyncInvoker<BatchRestoreDesktopSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreDesktopSnapshotResponse>);
        }
        
        /// <summary>
        /// 查询快照列表
        ///
        /// 查询快照列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopSnapshotResponse> ListDesktopSnapshotAsync(ListDesktopSnapshotRequest listDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopSnapshotRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopSnapshotResponse>(response);
        }

        public AsyncInvoker<ListDesktopSnapshotResponse> ListDesktopSnapshotAsyncInvoker(ListDesktopSnapshotRequest listDesktopSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopSnapshotRequest);
            return new AsyncInvoker<ListDesktopSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopSnapshotResponse>);
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
        public async Task<AddMetricNotifyRuleResponse> AddMetricNotifyRuleAsync(AddMetricNotifyRuleRequest addMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMetricNotifyRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddMetricNotifyRuleResponse>(response);
        }

        public AsyncInvoker<AddMetricNotifyRuleResponse> AddMetricNotifyRuleAsyncInvoker(AddMetricNotifyRuleRequest addMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMetricNotifyRuleRequest);
            return new AsyncInvoker<AddMetricNotifyRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 删除通知规则
        ///
        /// 删除对应指标的通知规则;对应指标满足相应的规则条件时发送通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMetricNotifyRuleResponse> DeleteMetricNotifyRuleAsync(DeleteMetricNotifyRuleRequest deleteMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteMetricNotifyRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricNotifyRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMetricNotifyRuleResponse>(response);
        }

        public AsyncInvoker<DeleteMetricNotifyRuleResponse> DeleteMetricNotifyRuleAsyncInvoker(DeleteMetricNotifyRuleRequest deleteMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", deleteMetricNotifyRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricNotifyRuleRequest);
            return new AsyncInvoker<DeleteMetricNotifyRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 查询云应用接入统计数据
        ///
        /// 查询云应用接入统计数据;
        /// 最多查询30天内的数据;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppUserAccessDataResponse> ListAppUserAccessDataAsync(ListAppUserAccessDataRequest listAppUserAccessDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/app-user-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppUserAccessDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppUserAccessDataResponse>(response);
        }

        public AsyncInvoker<ListAppUserAccessDataResponse> ListAppUserAccessDataAsyncInvoker(ListAppUserAccessDataRequest listAppUserAccessDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/app-user-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppUserAccessDataRequest);
            return new AsyncInvoker<ListAppUserAccessDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppUserAccessDataResponse>);
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
        public async Task<ListDesktopUsageMetricResponse> ListDesktopUsageMetricAsync(ListDesktopUsageMetricRequest listDesktopUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopUsageMetricRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopUsageMetricResponse>(response);
        }

        public AsyncInvoker<ListDesktopUsageMetricResponse> ListDesktopUsageMetricAsyncInvoker(ListDesktopUsageMetricRequest listDesktopUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopUsageMetricRequest);
            return new AsyncInvoker<ListDesktopUsageMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopUsageMetricResponse>);
        }
        
        /// <summary>
        /// 桌面统计
        ///
        /// 统计租户下的普通桌面、桌面池状态，默认仅统计总数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDesktopsStatisticsResponse> ListDesktopsStatisticsAsync(ListDesktopsStatisticsRequest listDesktopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDesktopsStatisticsResponse>(response);
        }

        public AsyncInvoker<ListDesktopsStatisticsResponse> ListDesktopsStatisticsAsyncInvoker(ListDesktopsStatisticsRequest listDesktopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDesktopsStatisticsRequest);
            return new AsyncInvoker<ListDesktopsStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDesktopsStatisticsResponse>);
        }
        
        /// <summary>
        /// 登录状态统计
        ///
        /// 查询租户桌面登录状态统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoginStateResponse> ListLoginStateAsync(ListLoginStateRequest listLoginStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/login-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginStateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLoginStateResponse>(response);
        }

        public AsyncInvoker<ListLoginStateResponse> ListLoginStateAsyncInvoker(ListLoginStateRequest listLoginStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/login-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoginStateRequest);
            return new AsyncInvoker<ListLoginStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoginStateResponse>);
        }
        
        /// <summary>
        /// 查询对应指标维度是否存在满足通知规则的记录
        ///
        /// 查询对应指标维度是否存在满足通知规则的记录;
        /// 查询结果仅表示满足相应指标维度下对应通知规则可产生的通知记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricNotifyRecordResponse> ListMetricNotifyRecordAsync(ListMetricNotifyRecordRequest listMetricNotifyRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMetricNotifyRecordResponse>(response);
        }

        public AsyncInvoker<ListMetricNotifyRecordResponse> ListMetricNotifyRecordAsyncInvoker(ListMetricNotifyRecordRequest listMetricNotifyRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notification-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRecordRequest);
            return new AsyncInvoker<ListMetricNotifyRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricNotifyRecordResponse>);
        }
        
        /// <summary>
        /// 查询通知规则
        ///
        /// 查询对应指标的通知规则;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricNotifyRuleResponse> ListMetricNotifyRuleAsync(ListMetricNotifyRuleRequest listMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMetricNotifyRuleResponse>(response);
        }

        public AsyncInvoker<ListMetricNotifyRuleResponse> ListMetricNotifyRuleAsyncInvoker(ListMetricNotifyRuleRequest listMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricNotifyRuleRequest);
            return new AsyncInvoker<ListMetricNotifyRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 查询指标
        ///
        /// 查询指标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMetricsResponse = JsonUtils.DeSerializeNull<ListMetricsResponse>(response);
            listMetricsResponse.Body = JsonUtils.DeSerializeList<Metric>(response);
            return listMetricsResponse;
        }

        public AsyncInvoker<ListMetricsResponse> ListMetricsAsyncInvoker(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            return new AsyncInvoker<ListMetricsResponse>(this, "GET", request, response =>
            {
                var listMetricsResponse = JsonUtils.DeSerializeNull<ListMetricsResponse>(response);
                listMetricsResponse.Body = JsonUtils.DeSerializeList<Metric>(response);
                return listMetricsResponse;
            });
        }
        
        /// <summary>
        /// 查询指标趋势
        ///
        /// 查询指标趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricsTrendResponse> ListMetricsTrendAsync(ListMetricsTrendRequest listMetricsTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsTrendRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMetricsTrendResponse = JsonUtils.DeSerializeNull<ListMetricsTrendResponse>(response);
            listMetricsTrendResponse.Body = JsonUtils.DeSerializeList<MetricsWithTime>(response);
            return listMetricsTrendResponse;
        }

        public AsyncInvoker<ListMetricsTrendResponse> ListMetricsTrendAsyncInvoker(ListMetricsTrendRequest listMetricsTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsTrendRequest);
            return new AsyncInvoker<ListMetricsTrendResponse>(this, "GET", request, response =>
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
        public async Task<ListRunStateResponse> ListRunStateAsync(ListRunStateRequest listRunStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/run-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunStateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRunStateResponse>(response);
        }

        public AsyncInvoker<ListRunStateResponse> ListRunStateAsyncInvoker(ListRunStateRequest listRunStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/run-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunStateRequest);
            return new AsyncInvoker<ListRunStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRunStateResponse>);
        }
        
        /// <summary>
        /// 查询在指定时间段未使用的桌面
        ///
        /// 查询在指定时间段未使用的桌面。已废弃，不推荐使用。统计数据推荐使用[查询桌面使用情况统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListDesktopUsageMetric)和[查询用户使用统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListUserUsageMetric)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUnusedDesktopsResponse> ListUnusedDesktopsAsync(ListUnusedDesktopsRequest listUnusedDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/unused", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnusedDesktopsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUnusedDesktopsResponse>(response);
        }

        public AsyncInvoker<ListUnusedDesktopsResponse> ListUnusedDesktopsAsyncInvoker(ListUnusedDesktopsRequest listUnusedDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/unused", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnusedDesktopsRequest);
            return new AsyncInvoker<ListUnusedDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnusedDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询使用桌面的时长
        ///
        /// 查询使用桌面的时长。已废弃，不推荐使用。统计数据推荐使用[查询桌面使用情况统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListDesktopUsageMetric)和[查询用户使用统计数据接口](https://console.huaweicloud.com/apiexplorer/#/openapi/Workspace/doc?api&#x3D;ListUserUsageMetric)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsedDesktopInfoResponse> ListUsedDesktopInfoAsync(ListUsedDesktopInfoRequest listUsedDesktopInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsedDesktopInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListUsedDesktopInfoResponse>(response);
        }

        public AsyncInvoker<ListUsedDesktopInfoResponse> ListUsedDesktopInfoAsyncInvoker(ListUsedDesktopInfoRequest listUsedDesktopInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/statistics/used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsedDesktopInfoRequest);
            return new AsyncInvoker<ListUsedDesktopInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListUsedDesktopInfoResponse>);
        }
        
        /// <summary>
        /// 查询用户使用统计数据
        ///
        /// 查询用户使用统计信息;
        /// 最多查询30天内的数据;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserUsageMetricResponse> ListUserUsageMetricAsync(ListUserUsageMetricRequest listUserUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserUsageMetricRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserUsageMetricResponse>(response);
        }

        public AsyncInvoker<ListUserUsageMetricResponse> ListUserUsageMetricAsyncInvoker(ListUserUsageMetricRequest listUserUsageMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserUsageMetricRequest);
            return new AsyncInvoker<ListUserUsageMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserUsageMetricResponse>);
        }
        
        /// <summary>
        /// 查询指标环比值
        ///
        /// 查询指标环比值
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGrowthRateResponse> ShowGrowthRateAsync(ShowGrowthRateRequest showGrowthRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/growth-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGrowthRateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGrowthRateResponse>(response);
        }

        public AsyncInvoker<ShowGrowthRateResponse> ShowGrowthRateAsyncInvoker(ShowGrowthRateRequest showGrowthRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/growth-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGrowthRateRequest);
            return new AsyncInvoker<ShowGrowthRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGrowthRateResponse>);
        }
        
        /// <summary>
        /// 查询接入云桌面或云应用各阶段时长数据
        ///
        /// 查询接入云桌面或云应用各阶段时长数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserAccessStagesResponse> ShowUserAccessStagesAsync(ShowUserAccessStagesRequest showUserAccessStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/access-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessStagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserAccessStagesResponse>(response);
        }

        public AsyncInvoker<ShowUserAccessStagesResponse> ShowUserAccessStagesAsyncInvoker(ShowUserAccessStagesRequest showUserAccessStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/metrics/access-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessStagesRequest);
            return new AsyncInvoker<ShowUserAccessStagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserAccessStagesResponse>);
        }
        
        /// <summary>
        /// 更新通知规则
        ///
        /// 更新对应指标的通知规则;对应指标满足相应的规则条件时发送通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMetricNotifyRuleResponse> UpdateMetricNotifyRuleAsync(UpdateMetricNotifyRuleRequest updateMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateMetricNotifyRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetricNotifyRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMetricNotifyRuleResponse>(response);
        }

        public AsyncInvoker<UpdateMetricNotifyRuleResponse> UpdateMetricNotifyRuleAsyncInvoker(UpdateMetricNotifyRuleRequest updateMetricNotifyRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", updateMetricNotifyRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/statistics/notify-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMetricNotifyRuleRequest);
            return new AsyncInvoker<UpdateMetricNotifyRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMetricNotifyRuleResponse>);
        }
        
        /// <summary>
        /// 根据子网id查询该子网下可用的ip
        ///
        /// 根据子网id查询该子网下可用的ip。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAvailableIpResponse> ShowAvailableIpAsync(ShowAvailableIpRequest showAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showAvailableIpRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/{subnet_id}/available-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableIpResponse>(response);
        }

        public AsyncInvoker<ShowAvailableIpResponse> ShowAvailableIpAsyncInvoker(ShowAvailableIpRequest showAvailableIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showAvailableIpRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/subnets/{subnet_id}/available-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableIpRequest);
            return new AsyncInvoker<ShowAvailableIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableIpResponse>);
        }
        
        /// <summary>
        /// 查询租户个性配置列表
        ///
        /// 查询租户个性配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantConfigsResponse> ListTenantConfigsAsync(ListTenantConfigsRequest listTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantConfigsResponse>(response);
        }

        public AsyncInvoker<ListTenantConfigsResponse> ListTenantConfigsAsyncInvoker(ListTenantConfigsRequest listTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantConfigsRequest);
            return new AsyncInvoker<ListTenantConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantConfigsResponse>);
        }
        
        /// <summary>
        /// 修改租户个性配置
        ///
        /// 租户个性配置修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTenantConfigResponse> UpdateTenantConfigAsync(UpdateTenantConfigRequest updateTenantConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTenantConfigResponse>(response);
        }

        public AsyncInvoker<UpdateTenantConfigResponse> UpdateTenantConfigAsyncInvoker(UpdateTenantConfigRequest updateTenantConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantConfigRequest);
            return new AsyncInvoker<UpdateTenantConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTenantConfigResponse>);
        }
        
        /// <summary>
        /// 增加终端与桌面绑定配置
        ///
        /// 增加终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTerminalsBindingDesktopsResponse> CreateTerminalsBindingDesktopsAsync(CreateTerminalsBindingDesktopsRequest createTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTerminalsBindingDesktopsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTerminalsBindingDesktopsResponse>(response);
        }

        public AsyncInvoker<CreateTerminalsBindingDesktopsResponse> CreateTerminalsBindingDesktopsAsyncInvoker(CreateTerminalsBindingDesktopsRequest createTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTerminalsBindingDesktopsRequest);
            return new AsyncInvoker<CreateTerminalsBindingDesktopsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 删除终端与桌面绑定配置
        ///
        /// 删除终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTerminalsBindingDesktopsResponse> DeleteTerminalsBindingDesktopsAsync(DeleteTerminalsBindingDesktopsRequest deleteTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTerminalsBindingDesktopsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteTerminalsBindingDesktopsResponse>(response);
        }

        public AsyncInvoker<DeleteTerminalsBindingDesktopsResponse> DeleteTerminalsBindingDesktopsAsyncInvoker(DeleteTerminalsBindingDesktopsRequest deleteTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTerminalsBindingDesktopsRequest);
            return new AsyncInvoker<DeleteTerminalsBindingDesktopsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询终端与桌面绑定配置列表
        ///
        /// 查询终端与桌面绑定配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTerminalsBindingDesktopsResponse> ListTerminalsBindingDesktopsAsync(ListTerminalsBindingDesktopsRequest listTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTerminalsBindingDesktopsResponse>(response);
        }

        public AsyncInvoker<ListTerminalsBindingDesktopsResponse> ListTerminalsBindingDesktopsAsyncInvoker(ListTerminalsBindingDesktopsRequest listTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsRequest);
            return new AsyncInvoker<ListTerminalsBindingDesktopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 查询终端与桌面绑定的开关配置信息
        ///
        /// 查询终端与桌面绑定的开关配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTerminalsBindingDesktopsConfigResponse> ListTerminalsBindingDesktopsConfigAsync(ListTerminalsBindingDesktopsConfigRequest listTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTerminalsBindingDesktopsConfigResponse>(response);
        }

        public AsyncInvoker<ListTerminalsBindingDesktopsConfigResponse> ListTerminalsBindingDesktopsConfigAsyncInvoker(ListTerminalsBindingDesktopsConfigRequest listTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTerminalsBindingDesktopsConfigRequest);
            return new AsyncInvoker<ListTerminalsBindingDesktopsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTerminalsBindingDesktopsConfigResponse>);
        }
        
        /// <summary>
        /// 修改终端与桌面绑定配置
        ///
        /// 修改终端与桌面绑定配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTerminalsBindingDesktopsResponse> UpdateTerminalsBindingDesktopsAsync(UpdateTerminalsBindingDesktopsRequest updateTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsResponse>(response);
        }

        public AsyncInvoker<UpdateTerminalsBindingDesktopsResponse> UpdateTerminalsBindingDesktopsAsyncInvoker(UpdateTerminalsBindingDesktopsRequest updateTerminalsBindingDesktopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsRequest);
            return new AsyncInvoker<UpdateTerminalsBindingDesktopsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsResponse>);
        }
        
        /// <summary>
        /// 设置终端与桌面绑定的开关配置
        ///
        /// 设置终端与桌面绑定的开关配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTerminalsBindingDesktopsConfigResponse> UpdateTerminalsBindingDesktopsConfigAsync(UpdateTerminalsBindingDesktopsConfigRequest updateTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsConfigResponse>(response);
        }

        public AsyncInvoker<UpdateTerminalsBindingDesktopsConfigResponse> UpdateTerminalsBindingDesktopsConfigAsyncInvoker(UpdateTerminalsBindingDesktopsConfigRequest updateTerminalsBindingDesktopsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/terminals/binding-desktops/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTerminalsBindingDesktopsConfigRequest);
            return new AsyncInvoker<UpdateTerminalsBindingDesktopsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTerminalsBindingDesktopsConfigResponse>);
        }
        
        /// <summary>
        /// 批量创建用户
        ///
        /// 该接口用于批量创建用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateUsersResponse> BatchCreateUsersAsync(BatchCreateUsersRequest batchCreateUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateUsersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateUsersResponse>(response);
        }

        public AsyncInvoker<BatchCreateUsersResponse> BatchCreateUsersAsyncInvoker(BatchCreateUsersRequest batchCreateUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateUsersRequest);
            return new AsyncInvoker<BatchCreateUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateUsersResponse>);
        }
        
        /// <summary>
        /// 解绑OTP设备
        ///
        /// 该接口用于解绑用户的OTP设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteOtpDevicesResponse> BatchDeleteOtpDevicesAsync(BatchDeleteOtpDevicesRequest batchDeleteOtpDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", batchDeleteOtpDevicesRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOtpDevicesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteOtpDevicesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteOtpDevicesResponse> BatchDeleteOtpDevicesAsyncInvoker(BatchDeleteOtpDevicesRequest batchDeleteOtpDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", batchDeleteOtpDevicesRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOtpDevicesRequest);
            return new AsyncInvoker<BatchDeleteOtpDevicesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteOtpDevicesResponse>);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 该接口用于批量删除桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteUserResponse> BatchDeleteUserAsync(BatchDeleteUserRequest batchDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteUserResponse>(response);
        }

        public AsyncInvoker<BatchDeleteUserResponse> BatchDeleteUserAsyncInvoker(BatchDeleteUserRequest batchDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteUserRequest);
            return new AsyncInvoker<BatchDeleteUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteUserResponse>);
        }
        
        /// <summary>
        /// 操作用户
        ///
        /// 该接口用于操作用户，包含三种操作：锁定、解锁和重置密码（重置密码建议使用/v2/{project_id}/users/{user_id}/random-password接口，在没有通知方式的情况下必须使用/v2/{project_id}/users/{user_id}/random-password接口）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeUserStatusResponse> ChangeUserStatusAsync(ChangeUserStatusRequest changeUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", changeUserStatusRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeUserStatusResponse>(response);
        }

        public AsyncInvoker<ChangeUserStatusResponse> ChangeUserStatusAsyncInvoker(ChangeUserStatusRequest changeUserStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", changeUserStatusRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeUserStatusRequest);
            return new AsyncInvoker<ChangeUserStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeUserStatusResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 该接口用于创建桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDesktopUserResponse> CreateDesktopUserAsync(CreateDesktopUserRequest createDesktopUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDesktopUserResponse>(response);
        }

        public AsyncInvoker<CreateDesktopUserResponse> CreateDesktopUserAsyncInvoker(CreateDesktopUserRequest createDesktopUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDesktopUserRequest);
            return new AsyncInvoker<CreateDesktopUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDesktopUserResponse>);
        }
        
        /// <summary>
        /// 删除指定用户
        ///
        /// 删除指定的桌面用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public AsyncInvoker<DeleteUserResponse> DeleteUserAsyncInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new AsyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询OTP设备
        ///
        /// 该接口用于查询相应用户下面的OTP设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOtpDevicesByUserIdResponse> ListOtpDevicesByUserIdAsync(ListOtpDevicesByUserIdRequest listOtpDevicesByUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listOtpDevicesByUserIdRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtpDevicesByUserIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOtpDevicesByUserIdResponse>(response);
        }

        public AsyncInvoker<ListOtpDevicesByUserIdResponse> ListOtpDevicesByUserIdAsyncInvoker(ListOtpDevicesByUserIdRequest listOtpDevicesByUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listOtpDevicesByUserIdRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/otp-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtpDevicesByUserIdRequest);
            return new AsyncInvoker<ListOtpDevicesByUserIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOtpDevicesByUserIdResponse>);
        }
        
        /// <summary>
        /// 查询用户详情信息
        ///
        /// 该接口用于查询指定的桌面用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserDetailResponse> ListUserDetailAsync(ListUserDetailRequest listUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listUserDetailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserDetailResponse>(response);
        }

        public AsyncInvoker<ListUserDetailResponse> ListUserDetailAsyncInvoker(ListUserDetailRequest listUserDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listUserDetailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDetailRequest);
            return new AsyncInvoker<ListUserDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserDetailResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 该接口用于查询桌面用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 给用户重置随机密码
        ///
        /// 该接口用于给用户重置一个密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetRandomPasswordResponse> ResetRandomPasswordAsync(ResetRandomPasswordRequest resetRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", resetRandomPasswordRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/random-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetRandomPasswordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ResetRandomPasswordResponse>(response);
        }

        public AsyncInvoker<ResetRandomPasswordResponse> ResetRandomPasswordAsyncInvoker(ResetRandomPasswordRequest resetRandomPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", resetRandomPasswordRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/random-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetRandomPasswordRequest);
            return new AsyncInvoker<ResetRandomPasswordResponse>(this, "GET", request, JsonUtils.DeSerialize<ResetRandomPasswordResponse>);
        }
        
        /// <summary>
        /// 重新发送邮件
        ///
        /// 该接口用于重新发送邮件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendEmailResponse> SendEmailAsync(SendEmailRequest sendEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", sendEmailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/resend-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendEmailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendEmailResponse>(response);
        }

        public AsyncInvoker<SendEmailResponse> SendEmailAsyncInvoker(SendEmailRequest sendEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", sendEmailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}/resend-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendEmailRequest);
            return new AsyncInvoker<SendEmailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendEmailResponse>);
        }
        
        /// <summary>
        /// 修改用户信息
        ///
        /// 该接口用于修改桌面用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserInfoResponse> UpdateUserInfoAsync(UpdateUserInfoRequest updateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserInfoRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserInfoResponse>(response);
        }

        public AsyncInvoker<UpdateUserInfoResponse> UpdateUserInfoAsyncInvoker(UpdateUserInfoRequest updateUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserInfoRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserInfoRequest);
            return new AsyncInvoker<UpdateUserInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserInfoResponse>);
        }
        
        /// <summary>
        /// 查询用户事件
        ///
        /// 查询用户事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserEventsResponse> ListUserEventsAsync(ListUserEventsRequest listUserEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserEventsResponse>(response);
        }

        public AsyncInvoker<ListUserEventsResponse> ListUserEventsAsyncInvoker(ListUserEventsRequest listUserEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/user-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserEventsRequest);
            return new AsyncInvoker<ListUserEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserEventsResponse>);
        }
        
        /// <summary>
        /// 增加桌面磁盘
        ///
        /// 给单个桌面增加磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDesktopVolumesResponse> AddDesktopVolumesAsync(AddDesktopVolumesRequest addDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", addDesktopVolumesRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDesktopVolumesResponse>(response);
        }

        public AsyncInvoker<AddDesktopVolumesResponse> AddDesktopVolumesAsyncInvoker(AddDesktopVolumesRequest addDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", addDesktopVolumesRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDesktopVolumesRequest);
            return new AsyncInvoker<AddDesktopVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDesktopVolumesResponse>);
        }
        
        /// <summary>
        /// 增加桌面磁盘
        ///
        /// 增加桌面磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddVolumesResponse> AddVolumesAsync(AddVolumesRequest addVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddVolumesResponse>(response);
        }

        public AsyncInvoker<AddVolumesResponse> AddVolumesAsyncInvoker(AddVolumesRequest addVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVolumesRequest);
            return new AsyncInvoker<AddVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<AddVolumesResponse>);
        }
        
        /// <summary>
        /// 删除桌面数据盘
        ///
        /// 删除桌面数据盘，删除后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDesktopVolumesResponse> DeleteDesktopVolumesAsync(DeleteDesktopVolumesRequest deleteDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteDesktopVolumesRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteDesktopVolumesResponse>(response);
        }

        public AsyncInvoker<DeleteDesktopVolumesResponse> DeleteDesktopVolumesAsyncInvoker(DeleteDesktopVolumesRequest deleteDesktopVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", deleteDesktopVolumesRequest.DesktopId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDesktopVolumesRequest);
            return new AsyncInvoker<DeleteDesktopVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDesktopVolumesResponse>);
        }
        
        /// <summary>
        /// 扩容磁盘
        ///
        /// 扩容磁盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandDesktopVolumeResponse> ExpandDesktopVolumeAsync(ExpandDesktopVolumeRequest expandDesktopVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", expandDesktopVolumeRequest.DesktopId.ToString());
            urlParam.Add("volume_id", expandDesktopVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/{volume_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandDesktopVolumeResponse>(response);
        }

        public AsyncInvoker<ExpandDesktopVolumeResponse> ExpandDesktopVolumeAsyncInvoker(ExpandDesktopVolumeRequest expandDesktopVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("desktop_id", expandDesktopVolumeRequest.DesktopId.ToString());
            urlParam.Add("volume_id", expandDesktopVolumeRequest.VolumeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/desktops/{desktop_id}/volumes/{volume_id}/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandDesktopVolumeRequest);
            return new AsyncInvoker<ExpandDesktopVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDesktopVolumeResponse>);
        }
        
        /// <summary>
        /// 扩容桌面磁盘
        ///
        /// 扩容桌面磁盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandVolumesResponse> ExpandVolumesAsync(ExpandVolumesRequest expandVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandVolumesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandVolumesResponse>(response);
        }

        public AsyncInvoker<ExpandVolumesResponse> ExpandVolumesAsyncInvoker(ExpandVolumesRequest expandVolumesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volumes/expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandVolumesRequest);
            return new AsyncInvoker<ExpandVolumesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandVolumesResponse>);
        }
        
        /// <summary>
        /// 查询磁盘产品信息
        ///
        /// 查询磁盘产品信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumeProductInfoResponse> ListVolumeProductInfoAsync(ListVolumeProductInfoRequest listVolumeProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volume/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeProductInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVolumeProductInfoResponse>(response);
        }

        public AsyncInvoker<ListVolumeProductInfoResponse> ListVolumeProductInfoAsyncInvoker(ListVolumeProductInfoRequest listVolumeProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/volume/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeProductInfoRequest);
            return new AsyncInvoker<ListVolumeProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeProductInfoResponse>);
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
        public async Task<ApplyWorkspaceResponse> ApplyWorkspaceAsync(ApplyWorkspaceRequest applyWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyWorkspaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplyWorkspaceResponse>(response);
        }

        public AsyncInvoker<ApplyWorkspaceResponse> ApplyWorkspaceAsyncInvoker(ApplyWorkspaceRequest applyWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyWorkspaceRequest);
            return new AsyncInvoker<ApplyWorkspaceResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyWorkspaceResponse>);
        }
        
        /// <summary>
        /// 注销云办公服务
        ///
        /// 该接口用于注销云办公服务。注销前请确保当前用户下的云桌面已经删除，注销后无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelWorkspaceResponse> CancelWorkspaceAsync(CancelWorkspaceRequest cancelWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelWorkspaceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<CancelWorkspaceResponse>(response);
        }

        public AsyncInvoker<CancelWorkspaceResponse> CancelWorkspaceAsyncInvoker(CancelWorkspaceRequest cancelWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelWorkspaceRequest);
            return new AsyncInvoker<CancelWorkspaceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelWorkspaceResponse>);
        }
        
        /// <summary>
        /// 查询云办公服务详情
        ///
        /// 该接口用于查询云办公服务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest listWorkspacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspacesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWorkspacesResponse>(response);
        }

        public AsyncInvoker<ListWorkspacesResponse> ListWorkspacesAsyncInvoker(ListWorkspacesRequest listWorkspacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkspacesRequest);
            return new AsyncInvoker<ListWorkspacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkspacesResponse>);
        }
        
        /// <summary>
        /// 查询云办公服务是否被锁定
        ///
        /// 查询云办公服务是否被锁定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkspaceLockResponse> ShowWorkspaceLockAsync(ShowWorkspaceLockRequest showWorkspaceLockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceLockRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkspaceLockResponse>(response);
        }

        public AsyncInvoker<ShowWorkspaceLockResponse> ShowWorkspaceLockAsyncInvoker(ShowWorkspaceLockRequest showWorkspaceLockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkspaceLockRequest);
            return new AsyncInvoker<ShowWorkspaceLockResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkspaceLockResponse>);
        }
        
        /// <summary>
        /// 解除云办公服务锁定状态
        ///
        /// 该接口目前支持解除云办公服务锁定状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnlockWorkspaceResponse> UnlockWorkspaceAsync(UnlockWorkspaceRequest unlockWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockWorkspaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UnlockWorkspaceResponse>(response);
        }

        public AsyncInvoker<UnlockWorkspaceResponse> UnlockWorkspaceAsyncInvoker(UnlockWorkspaceRequest unlockWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/lock-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockWorkspaceRequest);
            return new AsyncInvoker<UnlockWorkspaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UnlockWorkspaceResponse>);
        }
        
        /// <summary>
        /// 修改企业ID
        ///
        /// 修改租户的企业ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEnterpriseIdResponse> UpdateEnterpriseIdAsync(UpdateEnterpriseIdRequest updateEnterpriseIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/enterprise-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnterpriseIdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnterpriseIdResponse>(response);
        }

        public AsyncInvoker<UpdateEnterpriseIdResponse> UpdateEnterpriseIdAsyncInvoker(UpdateEnterpriseIdRequest updateEnterpriseIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces/enterprise-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnterpriseIdRequest);
            return new AsyncInvoker<UpdateEnterpriseIdResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnterpriseIdResponse>);
        }
        
        /// <summary>
        /// 修改云办公服务属性
        ///
        /// 该接口目前支持修改云办公服务属性。单次请求仅支持修改一种属性类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkspaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkspaceResponse>(response);
        }

        public AsyncInvoker<UpdateWorkspaceResponse> UpdateWorkspaceAsyncInvoker(UpdateWorkspaceRequest updateWorkspaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/workspaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkspaceRequest);
            return new AsyncInvoker<UpdateWorkspaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkspaceResponse>);
        }
        
    }
}