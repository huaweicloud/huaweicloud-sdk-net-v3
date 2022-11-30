using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3
{
    public partial class GaussDBforNoSQLAsyncClient : Client
    {
        public static ClientBuilder<GaussDBforNoSQLAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforNoSQLAsyncClient>();
        }

        
        /// <summary>
        /// 应用参数模板
        ///
        /// 将参数模板应用到实例，可以指定一个或多个实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyConfigurationResponse> ApplyConfigurationAsync(ApplyConfigurationRequest applyConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , applyConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ApplyConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加或删除指定数据库实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagActionResponse> BatchTagActionAsync(BatchTagActionRequest batchTagActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchTagActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }
        
        /// <summary>
        /// 校验实例是否可以与指定实例建立/解除容灾关系
        ///
        /// 校验实例是否可以与指定实例建立/解除容灾关系。若接口返回成功，表示可以与指定实例建立/解除容灾关系。
        /// 该接口需要对建立/解除容灾关系的两个实例各调用一次，2次调用都响应成功才能进行容灾关系的搭建/解除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDisasterRecoveryOperationResponse> CheckDisasterRecoveryOperationAsync(CheckDisasterRecoveryOperationRequest checkDisasterRecoveryOperationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , checkDisasterRecoveryOperationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/precheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDisasterRecoveryOperationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CheckDisasterRecoveryOperationResponse>(response);
        }
        
        /// <summary>
        /// 判断弱密码
        ///
        /// 判断弱密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckWeekPasswordResponse> CheckWeekPasswordAsync(CheckWeekPasswordRequest checkWeekPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeekPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckWeekPasswordResponse>(response);
        }
        
        /// <summary>
        /// 参数模板比较
        ///
        /// 比较两个参数模板之间的差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareConfigurationResponse> CompareConfigurationAsync(CompareConfigurationRequest compareConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationResponse> CopyConfigurationAsync(CopyConfigurationRequest copyConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , copyConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBackResponse> CreateBackAsync(CreateBackRequest createBackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createBackRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateBackResponse>(response);
        }
        
        /// <summary>
        /// ‘创建冷数据存储’
        ///
        /// ‘创建冷数据存储’
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateColdVolumeResponse> CreateColdVolumeAsync(CreateColdVolumeRequest createColdVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createColdVolumeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createColdVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateColdVolumeResponse>(response);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest createConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 搭建实例与特定实例的容灾关系
        ///
        /// 搭建实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功搭建容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDisasterRecoveryResponse> CreateDisasterRecoveryAsync(CreateDisasterRecoveryRequest createDisasterRecoveryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDisasterRecoveryRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/construction",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDisasterRecoveryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDisasterRecoveryResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest deleteBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteBackupResponse>(response);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
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
        /// 解除实例与特定实例的容灾关系
        ///
        /// 解除实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功解除容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryAsync(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDisasterRecoveryRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/deconstruction",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>(response);
        }
        
        /// <summary>
        /// 删除扩容失败的节点
        ///
        /// 删除扩容失败的节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEnlargeFailNodeResponse> DeleteEnlargeFailNodeAsync(DeleteEnlargeFailNodeRequest deleteEnlargeFailNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteEnlargeFailNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-failed-nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnlargeFailNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEnlargeFailNodeResponse>(response);
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
        /// 扩容指定集群实例的节点数量
        ///
        /// 扩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandInstanceNodeResponse> ExpandInstanceNodeAsync(ExpandInstanceNodeRequest expandInstanceNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , expandInstanceNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-node",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandInstanceNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExpandInstanceNodeResponse>(response);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableFlavorInfosResponse> ListAvailableFlavorInfosAsync(ListAvailableFlavorInfosRequest listAvailableFlavorInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAvailableFlavorInfosRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailableFlavorInfosResponse>(response);
        }
        
        /// <summary>
        /// 查询支持参数模板的引擎信息
        ///
        /// 查询支持参数模板的引擎信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationDatastoresResponse> ListConfigurationDatastoresAsync(ListConfigurationDatastoresRequest listConfigurationDatastoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/datastores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationDatastoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationDatastoresResponse>(response);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationTemplatesResponse> ListConfigurationTemplatesAsync(ListConfigurationTemplatesRequest listConfigurationTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationTemplatesResponse>(response);
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
        /// 查询指定实例类型的数据库版本信息
        ///
        /// 查询指定实例类型的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name" , listDatastoresRequest.DatastoreName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }
        
        /// <summary>
        /// 查询专属资源列表
        ///
        /// 查询专属资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDedicatedResourcesResponse> ListDedicatedResourcesAsync(ListDedicatedResourcesRequest listDedicatedResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDedicatedResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDedicatedResourcesResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目配额
        ///
        /// 查询企业项目配额。
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
        /// 查询指定条件下的实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorInfosResponse> ListFlavorInfosAsync(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的所有实例规格信息
        ///
        /// 查询指定条件下的所有实例规格信息。
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
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
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
        /// 查询实例列表和详情
        ///
        /// 根据指定条件查询数据库实例列表和详情。
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
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesByResourceTagsResponse> ListInstancesByResourceTagsAsync(ListInstancesByResourceTagsRequest listInstancesByResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource-instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListInstancesByResourceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesByTagsResponse> ListInstancesByTagsAsync(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定项目的标签信息。
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
        /// 查询回收站实例列表
        ///
        /// 查询回收站所有引擎的实例列表。
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
        /// 查询实例可恢复的时间段
        ///
        /// 查询实例可恢复的时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTimeResponse> ListRestoreTimeAsync(ListRestoreTimeRequest listRestoreTimeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreTimeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-periods",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreTimeResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsResponse> ListSlowLogsAsync(ListSlowLogsRequest listSlowLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyEpsQuotasResponse> ModifyEpsQuotasAsync(ModifyEpsQuotasRequest modifyEpsQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyEpsQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotasResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库实例的端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyPortResponse> ModifyPortAsync(ModifyPortRequest modifyPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyPortRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifyPortResponse>(response);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyPublicIpResponse> ModifyPublicIpAsync(ModifyPublicIpRequest modifyPublicIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyPublicIpRequest.InstanceId.ToString());
            urlParam.Add("node_id" , modifyPublicIpRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPublicIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ModifyPublicIpResponse>(response);
        }
        
        /// <summary>
        /// 暂停/恢复具备容灾关系的实例数据同步
        ///
        /// 该接口用于暂停/恢复具备容灾关系的实例数据同步。
        /// 
        /// 该接口需要对具备容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功暂停/恢复容灾实例数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PauseResumeDataSynchronizationResponse> PauseResumeDataSynchronizationAsync(PauseResumeDataSynchronizationRequest pauseResumeDataSynchronizationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , pauseResumeDataSynchronizationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseResumeDataSynchronizationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            PauseResumeDataSynchronizationResponse pauseResumeDataSynchronizationResponse = JsonUtils.DeSerializeNull<PauseResumeDataSynchronizationResponse>(response);
            return pauseResumeDataSynchronizationResponse;
        }
        
        /// <summary>
        /// 修改实例的管理员密码
        ///
        /// 修改实例的管理员密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }
        
        /// <summary>
        /// 扩容冷数据存储
        ///
        /// 扩容冷数据存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeColdVolumeResponse> ResizeColdVolumeAsync(ResizeColdVolumeRequest resizeColdVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeColdVolumeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeColdVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ResizeColdVolumeResponse>(response);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }
        
        /// <summary>
        /// 扩容实例存储容量
        ///
        /// 扩容实例的存储容量大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceVolumeResponse> ResizeInstanceVolumeAsync(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceVolumeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extend-volume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
        }
        
        /// <summary>
        /// 重启实例的数据库服务
        ///
        /// 重启实例的数据库服务。
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
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreExistingInstanceResponse> RestoreExistingInstanceAsync(RestoreExistingInstanceRequest restoreExistingInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreExistingInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistingInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreExistingInstanceResponse>(response);
        }
        
        /// <summary>
        /// 设置磁盘自动扩容策略
        ///
        /// 设置磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyAsync(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disk-auto-expansion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置自动备份策略
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置回收策略
        ///
        /// 设置已删除实例保留天数，修改保留天数后删除的实例按照新的天数保留，修改之前已在回收站的实例保留天数不变。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecyclePolicyResponse> SetRecyclePolicyAsync(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAllInstancesBackupsResponse> ShowAllInstancesBackupsAsync(ShowAllInstancesBackupsRequest showAllInstancesBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAllInstancesBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板可应用的实例列表
        ///
        /// 查询参数模板可应用的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplicableInstancesResponse> ShowApplicableInstancesAsync(ShowApplicableInstancesRequest showApplicableInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showApplicableInstancesRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicableInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplicableInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板应用历史
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplyHistoryResponse> ShowApplyHistoryAsync(ShowApplyHistoryRequest showApplyHistoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showApplyHistoryRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplyHistoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApplyHistoryResponse>(response);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsync(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAutoEnlargePolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
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
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的详细信息。
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
        /// 查询数据库错误日志信息
        ///
        /// 查询数据库错误日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowErrorLogResponse> ShowErrorLogAsync(ShowErrorLogRequest showErrorLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showErrorLogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowErrorLogResponse>(response);
        }
        
        /// <summary>
        /// 获取指定实例的参数
        ///
        /// 获取指定实例的参数信息。
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
        /// 获取容灾实例主/备角色信息
        ///
        /// 该接口用于获取容灾实例主/备角色信息，以便后续容灾实例备升主和容灾实例主降备接口调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceRoleResponse> ShowInstanceRoleAsync(ShowInstanceRoleRequest showInstanceRoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceRoleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/instance-role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceRoleResponse>(response);
        }
        
        /// <summary>
        /// 查询创建实例或扩容节点时需要的IP数量
        ///
        /// 查询创建实例或扩容节点时需要的IP数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpNumRequirementResponse> ShowIpNumRequirementAsync(ShowIpNumRequirementRequest showIpNumRequirementRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ip-num-requirement",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpNumRequirementRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpNumRequirementResponse>(response);
        }
        
        /// <summary>
        /// 查询实例参数的修改历史
        ///
        /// 查询实例参数的修改历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowModifyHistoryResponse> ShowModifyHistoryAsync(ShowModifyHistoryRequest showModifyHistoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showModifyHistoryRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showModifyHistoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowModifyHistoryResponse>(response);
        }
        
        /// <summary>
        /// 获取容灾实例数据同步状态
        ///
        /// 获取容灾实例数据同步状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPauseResumeStutusResponse> ShowPauseResumeStutusAsync(ShowPauseResumeStutusRequest showPauseResumeStutusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPauseResumeStutusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPauseResumeStutusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPauseResumeStutusResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在GaussDBforNoSQL服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询回收策略
        ///
        /// 查询回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询可恢复的实例列表
        ///
        /// 查询用户可恢复的实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRestorableListResponse> ShowRestorableListAsync(ShowRestorableListRequest showRestorableListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showRestorableListRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restorable-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestorableListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRestorableListResponse>(response);
        }
        
        /// <summary>
        /// 查询慢日志脱敏状态
        ///
        /// 查询慢日志脱敏状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSlowLogDesensitizationResponse> ShowSlowLogDesensitizationAsync(ShowSlowLogDesensitizationRequest showSlowLogDesensitizationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSlowLogDesensitizationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDesensitizationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSlowLogDesensitizationResponse>(response);
        }
        
        /// <summary>
        /// 缩容指定集群实例的节点数量
        ///
        /// 缩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShrinkInstanceNodeResponse> ShrinkInstanceNodeAsync(ShrinkInstanceNodeRequest shrinkInstanceNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , shrinkInstanceNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reduce-node",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodeResponse>(response);
        }
        
        /// <summary>
        /// 设置慢日志脱敏状态
        ///
        /// 设置慢日志脱敏状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationAsync(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSlowlogDesensitizationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
        }
        
        /// <summary>
        /// 切换实例SSL开关
        ///
        /// 切换实例SSL开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSslResponse> SwitchSslAsync(SwitchSslRequest switchSslRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSslRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }
        
        /// <summary>
        /// 容灾实例备升主
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将备实例升级为主实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchToMasterResponse> SwitchToMasterAsync(SwitchToMasterRequest switchToMasterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchToMasterRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-master",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToMasterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SwitchToMasterResponse>(response);
        }
        
        /// <summary>
        /// 容灾实例主降备
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将主实例降级为备实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchToSlaveResponse> SwitchToSlaveAsync(SwitchToSlaveRequest switchToSlaveRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchToSlaveRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-slave",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToSlaveRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SwitchToSlaveResponse>(response);
        }
        
        /// <summary>
        /// 修改副本集跨网段访问配置
        ///
        /// 修改副本集跨网段访问配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClientNetworkResponse> UpdateClientNetworkAsync(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateClientNetworkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateClientNetworkResponse>(response);
        }
        
        /// <summary>
        /// 修改参数模板参数
        ///
        /// 修改参数模板参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest updateConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , updateConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationResponse>(response);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }
        
        /// <summary>
        /// 变更实例安全组
        ///
        /// 变更实例关联的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateSecurityGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 数据库补丁升级
        ///
        /// 升级数据库补丁版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbVersionResponse> UpgradeDbVersionAsync(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , upgradeDbVersionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询当前支持的API版本信息列表
        ///
        /// 查询当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionResponse> ListApiVersionAsync(ListApiVersionRequest listApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showApiVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
    }
}