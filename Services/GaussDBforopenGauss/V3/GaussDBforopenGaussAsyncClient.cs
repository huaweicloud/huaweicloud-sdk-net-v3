using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3
{
    public partial class GaussDBforopenGaussAsyncClient : Client
    {
        public static ClientBuilder<GaussDBforopenGaussAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforopenGaussAsyncClient>();
        }

        
        /// <summary>
        /// 添加实例标签。
        ///
        /// 对指定实例添加用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddInstanceTagsResponse> AddInstanceTagsAsync(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , addInstanceTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddInstanceTagsResponse>(response);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 在指定实例的数据库中, 设置帐号的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowDbPrivilegesResponse> AllowDbPrivilegesAsync(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , allowDbPrivilegesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>(response);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachEipResponse> AttachEipAsync(AttachEipRequest attachEipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , attachEipRequest.InstanceId.ToString());
            urlParam.Add("node_id" , attachEipRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationResponse> CopyConfigurationAsync(CopyConfigurationRequest copyConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , copyConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConfigurationTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConfigurationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 在指定实例中创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest createDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库SCHEMA
        ///
        /// 在指定实例的数据库中, 创建数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseSchemasResponse> CreateDatabaseSchemasAsync(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDatabaseSchemasRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbInstanceResponse> CreateDbInstanceAsync(CreateDbInstanceRequest createDbInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDbInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbUserResponse> CreateDbUserAsync(CreateDbUserRequest createDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDbUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateDbUserResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库企业版和集中式实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateManualBackupResponse> CreateManualBackupAsync(CreateManualBackupRequest createManualBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createManualBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 根据备份恢复新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRestoreInstanceResponse> CreateRestoreInstanceAsync(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConfigurationResponse> DeleteConfigurationAsync(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , deleteConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除任务记录
        ///
        /// 删除任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest deleteJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , deleteJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteManualBackupResponse> DeleteManualBackupAsync(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteManualBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteManualBackupResponse>(response);
        }
        
        /// <summary>
        /// 查询可应用实例列表
        ///
        /// 查询可应用当前参数组模板的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicableInstancesResponse> ListApplicableInstancesAsync(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , listApplicableInstancesRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicableInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板的应用记录
        ///
        /// 查询参数模板的应用记录，以实例级别为维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppliedHistoriesResponse> ListAppliedHistoriesAsync(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , listAppliedHistoriesRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAppliedHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableFlavorsResponse> ListAvailableFlavorsAsync(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAvailableFlavorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailableFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest listBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例已绑定EIP列表
        ///
        /// 查询实例已绑定EIP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBindedEipsResponse> ListBindedEipsAsync(ListBindedEipsRequest listBindedEipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBindedEipsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBindedEipsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的组件列表
        ///
        /// 查询实例的组件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListComponentInfosResponse> ListComponentInfosAsync(ListComponentInfosRequest listComponentInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listComponentInfosRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListComponentInfosResponse>(response);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest listConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 比较两个参数组模板之间的差异
        ///
        /// 获取两个参数配置模板的差异列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsDiffResponse> ListConfigurationsDiffAsync(ListConfigurationsDiffRequest listConfigurationsDiffRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDiffRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListConfigurationsDiffResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库SCHEMA列表
        ///
        /// 查询指定实例的数据库SCHEMA列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseSchemasResponse> ListDatabaseSchemasAsync(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDatabaseSchemasRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatabaseSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询指定实例中的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest listDatabasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 查询指定数据库引擎对应的版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbBackupsResponse> ListDbBackupsAsync(ListDbBackupsRequest listDbBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDbBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbFlavorsResponse> ListDbFlavorsAsync(ListDbFlavorsRequest listDbFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDbFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 在指定实例中查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbUsersResponse> ListDbUsersAsync(ListDbUsersRequest listDbUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDbUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目配额组
        ///
        /// 查询企业项目配额组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEpsQuotasResponse> ListEpsQuotasAsync(ListEpsQuotasRequest listEpsQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEpsQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEpsQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询引擎列表
        ///
        /// 查询引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussDbDatastoresResponse> ListGaussDbDatastoresAsync(ListGaussDbDatastoresRequest listGaussDbDatastoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussDbDatastoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListGaussDbDatastoresResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板的修改历史
        ///
        /// 查询参数模板的修改历史记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryOperationsResponse> ListHistoryOperationsAsync(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , listHistoryOperationsRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHistoryOperationsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询指定实例的用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesDetailsResponse> ListInstancesDetailsAsync(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListParamGroupTemplatesResponse> ListParamGroupTemplatesAsync(ListParamGroupTemplatesRequest listParamGroupTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParamGroupTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListParamGroupTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 查询预定义标签
        ///
        /// 查询预预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefinedTagsResponse> ListPredefinedTagsAsync(ListPredefinedTagsRequest listPredefinedTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/predefined-tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPredefinedTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目下所有用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询回收站所有引擎实例列表。
        ///
        /// 查询回收站所有引擎实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleInstancesResponse> ListRecycleInstancesAsync(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询可用于备份恢复的实例列表
        ///
        /// 查询可用于备份恢复的实例列表，实例信息要符合备份条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestorableInstancesResponse> ListRestorableInstancesAsync(ListRestorableInstancesRequest listRestorableInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/restorable-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRestorableInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询可恢复时间段。
        /// 如果您备份策略中的保存天数设置较长，建议您传入查询日期“date”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTimesResponse> ListRestoreTimesAsync(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreTimesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询指定数据库引擎对应的磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageTypesResponse> ListStorageTypesAsync(ListStorageTypesRequest listStorageTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 获取任务中心的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest listTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyEpsQuotaResponse> ModifyEpsQuotaAsync(ModifyEpsQuotaRequest modifyEpsQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEpsQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotaResponse>(response);
        }
        
        /// <summary>
        /// 重置参数模板
        ///
        /// 重置参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetConfigurationResponse> ResetConfigurationAsync(ResetConfigurationRequest resetConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , resetConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            ResetConfigurationResponse resetConfigurationResponse = JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
            return resetConfigurationResponse;
        }
        
        /// <summary>
        /// 重置数据库密码。
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdResponse> ResetPwdAsync(ResetPwdRequest resetPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPwdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }
        
        /// <summary>
        /// GaussDB数据库实例规格变更
        ///
        /// GaussDB数据库实例规格变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceFlavorResponse> ResizeInstanceFlavorAsync(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceFlavorRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>(response);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest restartInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }
        
        /// <summary>
        /// CN横向扩容/DN分片扩容/磁盘扩容
        ///
        /// CN横向扩容/DN分片扩容/磁盘扩容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunInstanceActionResponse> RunInstanceActionAsync(RunInstanceActionRequest runInstanceActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , runInstanceActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunInstanceActionResponse>(response);
        }
        
        /// <summary>
        /// 设置自动备份策略。
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBackupPolicyResponse> SetBackupPolicyAsync(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 重置数据库帐号密码
        ///
        /// 重置指定数据库帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDbUserPwdResponse> SetDbUserPwdAsync(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setDbUserPwdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetDbUserPwdResponse>(response);
        }
        
        /// <summary>
        /// 设置回收站策略
        ///
        /// 设置回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecyclePolicyResponse> SetRecyclePolicyAsync(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupPolicyResponse> ShowBackupPolicyAsync(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询实例主备平衡状态
        ///
        /// 查询实例是否发生过主备切换而导致主机负载不均衡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBalanceStatusResponse> ShowBalanceStatusAsync(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBalanceStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBalanceStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 根据参数模板ID获取指定参数模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationDetailResponse> ShowConfigurationDetailAsync(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showConfigurationDetailRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigurationDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询解决方案模板配置
        ///
        /// 根据解决方案模板名称或实例ID查询副本数、分片数、节点数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeploymentFormResponse> ShowDeploymentFormAsync(ShowDeploymentFormRequest showDeploymentFormRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/deployment-form",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentFormRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeploymentFormResponse>(response);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsync(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 查询实例存储空间使用信息
        ///
        /// 查询指定实例的存储使用空间和最大空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceDiskResponse> ShowInstanceDiskAsync(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceDiskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceDiskResponse>(response);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceParamGroupResponse> ShowInstanceParamGroupAsync(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceParamGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>(response);
        }
        
        /// <summary>
        /// 根据时间点或者备份文件查询原实例信息
        ///
        /// 根据时间点或者备份文件查询原实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceSnapshotResponse> ShowInstanceSnapshotAsync(ShowInstanceSnapshotRequest showInstanceSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceSnapshotResponse>(response);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息。
        ///
        /// 获取指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的实例配额
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectQuotasResponse> ShowProjectQuotasAsync(ShowProjectQuotasRequest showProjectQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查看回收站策略
        ///
        /// 查看回收站的回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询实例SSL证书下载地址
        ///
        /// 查询实例SSL证书下载地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSslCertDownloadLinkResponse> ShowSslCertDownloadLinkAsync(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSslCertDownloadLinkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>(response);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchConfigurationResponse> SwitchConfigurationAsync(SwitchConfigurationRequest switchConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , switchConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 分片节点主备切换。
        ///
        /// 支持用户对单个或多个DN分片做主备切换，同一分组内只能指定一个新的备节点进行升主操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchShardResponse> SwitchShardAsync(SwitchShardRequest switchShardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchShardRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SwitchShardResponse>(response);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsync(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }
        
        /// <summary>
        /// 校验参数组名称是否存在
        ///
        /// 校验参数组名称是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateParaGroupNameResponse> ValidateParaGroupNameAsync(ValidateParaGroupNameRequest validateParaGroupNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateParaGroupNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ValidateParaGroupNameResponse>(response);
        }
        
        /// <summary>
        /// 弱密码校验
        ///
        /// 校验数据库root用户密码的安全性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateWeakPasswordResponse> ValidateWeakPasswordAsync(ValidateWeakPasswordRequest validateWeakPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateWeakPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ValidateWeakPasswordResponse>(response);
        }
        
    }
}