using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cbr.V1.Model;

namespace HuaweiCloud.SDK.Cbr.V1
{
    public partial class CbrAsyncClient : Client
    {
        public static ClientBuilder<CbrAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CbrAsyncClient>();
        }

        
        /// <summary>
        /// 新增备份路径
        ///
        /// 对客户端新增备份路径，新增的路径不会校验是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAgentPathResponse> AddAgentPathAsync(AddAgentPathRequest addAgentPathRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id" , addAgentPathRequest.AgentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/add-path",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAgentPathRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddAgentPathResponse>(response);
        }
        
        /// <summary>
        /// 添加备份成员
        ///
        /// 添加备份可共享的成员，只有云服务器备份可以添加备份共享成员，且仅支持在同一区域的不同用户间共享。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddMemberResponse> AddMemberAsync(AddMemberRequest addMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , addMemberRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddMemberResponse>(response);
        }
        
        /// <summary>
        /// 添加资源
        ///
        /// 存储库添加资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddVaultResourceResponse> AddVaultResourceAsync(AddVaultResourceRequest addVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , addVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 设置存储库策略
        ///
        /// 存储库设置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateVaultPolicyResponse> AssociateVaultPolicyAsync(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , associateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateVaultPolicyResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除存储库资源标签
        ///
        /// 为指定实例批量添加或删除标签
        /// 标签管理服务需要使用该接口批量管理实例的标签。
        /// 一个资源上最多有10个标签。
        /// 此接口为幂等接口：
        ///     创建时如果请求体中存在重复key则报错。
        ///     创建时，不允许重复key，如果数据库存在就覆盖。
        ///     删除时，允许重复key。
        ///     删除时，如果删除的标签不存在，默认处理成功,删除时不对标签字符集范围做校验。key长度127个字符，value为255个字符。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateAndDeleteVaultTagsResponse> BatchCreateAndDeleteVaultTagsAsync(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量修改存储库
        ///
        /// 批量修改项目下所有存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateVaultResponse> BatchUpdateVaultAsync(BatchUpdateVaultRequest batchUpdateVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/batch-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateVaultResponse>(response);
        }
        
        /// <summary>
        /// 查询agent状态
        ///
        /// 检查应用一致性Agent状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckAgentResponse> CheckAgentAsync(CheckAgentRequest checkAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckAgentResponse>(response);
        }
        
        /// <summary>
        /// 复制备份
        ///
        /// 跨区域复制备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyBackupResponse> CopyBackupAsync(CopyBackupRequest copyBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , copyBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyBackupResponse>(response);
        }
        
        /// <summary>
        /// 复制备份还原点
        ///
        /// 执行复制
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyCheckpointResponse> CopyCheckpointAsync(CopyCheckpointRequest copyCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 创建备份还原点
        ///
        /// 对存储库执行备份，生成备份还原点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCheckpointResponse> CreateCheckpointAsync(CreateCheckpointRequest createCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略，策略分为备份策略和复制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest createPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建包周期存储库
        ///
        /// 创建包周期存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostPaidVaultResponse> CreatePostPaidVaultAsync(CreatePostPaidVaultRequest createPostPaidVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/order",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidVaultResponse>(response);
        }
        
        /// <summary>
        /// 创建存储库
        ///
        /// 创建存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest createVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVaultResponse>(response);
        }
        
        /// <summary>
        /// 添加存储库资源标签
        ///
        /// 一个资源上最多有10个标签。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVaultTagsResponse> CreateVaultTagsAsync(CreateVaultTagsRequest createVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , createVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVaultTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除备份
        ///
        /// 删除单个备份。
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
            return JsonUtils.DeSerializeNull<DeleteBackupResponse>(response);
        }
        
        /// <summary>
        /// 删除指定备份成员
        ///
        /// 删除指定的备份共享成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除存储库
        ///
        /// 删除存储库。若删除储存库，将一并删除存储库中的所有备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest deleteVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , deleteVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultResponse>(response);
        }
        
        /// <summary>
        /// 删除存储库资源标签
        ///
        /// 幂等接口：删除时，如果删除的标签不存在，返回404。Key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVaultTagResponse> DeleteVaultTagAsync(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id" , deleteVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultTagResponse>(response);
        }
        
        /// <summary>
        /// 解除存储库策略
        ///
        /// 存储库解除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateVaultPolicyResponse> DisassociateVaultPolicyAsync(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , disassociateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>(response);
        }
        
        /// <summary>
        /// 同步备份
        ///
        /// 同步线下混合云VMware备份副本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportBackupResponse> ImportBackupAsync(ImportBackupRequest importBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportBackupResponse>(response);
        }
        
        /// <summary>
        /// 同步备份还原点
        ///
        /// 针对vault同步备份副本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportCheckpointResponse> ImportCheckpointAsync(ImportCheckpointRequest importCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/sync",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 查询客户端列表
        ///
        /// 查询客户端列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentResponse> ListAgentAsync(ListAgentRequest listAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgentResponse>(response);
        }
        
        /// <summary>
        /// 查询所有备份
        ///
        /// 查询所有副本
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
        /// 查询租户项目列表
        ///
        /// 根据指定租户名称查询项目列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainProjectsResponse> ListDomainProjectsAsync(ListDomainProjectsRequest listDomainProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , listDomainProjectsRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domain/{domain_name}/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询其他区域存储库列表
        ///
        /// 查询其他区域的存储库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExternalVaultResponse> ListExternalVaultAsync(ListExternalVaultRequest listExternalVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/external",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListExternalVaultResponse>(response);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOpLogsResponse> ListOpLogsAsync(ListOpLogsRequest listOpLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOpLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询策略列表
        ///
        /// 查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest listPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的项目信息
        ///
        /// 查询租户的企业项目信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest listProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/region-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询可保护资源
        ///
        /// 查询可保护性资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtectableResponse> ListProtectableAsync(ListProtectableRequest listProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type" , listProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProtectableResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库列表
        ///
        /// 查询存储库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVaultResponse> ListVaultAsync(ListVaultRequest listVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVaultResponse>(response);
        }
        
        /// <summary>
        /// 租户迁移
        ///
        /// 将CSBS/VBS资源迁移到CBR。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateDomainResponse> MigrateDomainAsync(MigrateDomainRequest migrateDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            MigrateDomainResponse migrateDomainResponse = JsonUtils.DeSerializeNull<MigrateDomainResponse>(response);
            migrateDomainResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return migrateDomainResponse;
        }
        
        /// <summary>
        /// 迁移资源
        ///
        /// 支持资源迁移到另一个存储库，不删除备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateVaultResourceResponse> MigrateVaultResourceAsync(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , migrateVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<MigrateVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 注册客户端
        ///
        /// 注册客户端，安装时候由Agent调用，无需手动注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest registerAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RegisterAgentResponse>(response);
        }
        
        /// <summary>
        /// 移除备份路径
        ///
        /// 移除已添加的文件备份路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveAgentPathResponse> RemoveAgentPathAsync(RemoveAgentPathRequest removeAgentPathRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id" , removeAgentPathRequest.AgentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/remove-path",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeAgentPathRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RemoveAgentPathResponse>(response);
        }
        
        /// <summary>
        /// 移除资源
        ///
        /// 移除存储库中的资源，若移除资源，将一并删除该资源在保管库中的备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveVaultResourceResponse> RemoveVaultResourceAsync(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , removeVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RemoveVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 备份恢复
        ///
        /// 恢复备份数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreBackupResponse> RestoreBackupAsync(RestoreBackupRequest restoreBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , restoreBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreBackupResponse>(response);
        }
        
        /// <summary>
        /// 设置存储库资源
        ///
        /// 设置存储库资源是否自动备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetVaultResourceResponse> SetVaultResourceAsync(SetVaultResourceRequest setVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , setVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/set-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 查询指定客户端
        ///
        /// 查询指定客户端
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgentResponse> ShowAgentAsync(ShowAgentRequest showAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id" , showAgentRequest.AgentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgentResponse>(response);
        }
        
        /// <summary>
        /// 查询指定备份
        ///
        /// 根据指定id查询单个副本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupResponse> ShowBackupAsync(ShowBackupRequest showBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }
        
        /// <summary>
        /// 查询备份还原点
        ///
        /// 根据还原点ID查询指定还原点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCheckpointResponse> ShowCheckpointAsync(ShowCheckpointRequest showCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id" , showCheckpointRequest.CheckpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 查询租户信息
        ///
        /// 由控制台调用的内部接口，用于仅在查询共享备份时获取源project_id的域名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainResponse> ShowDomainAsync(ShowDomainRequest showDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("source_project_id" , showDomainRequest.SourceProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domain/{source_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }
        
        /// <summary>
        /// 获取备份成员详情
        ///
        /// 获取备份成员的详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMemberDetailResponse> ShowMemberDetailAsync(ShowMemberDetailRequest showMemberDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id" , showMemberDetailRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberDetailResponse>(response);
        }
        
        /// <summary>
        /// 获取备份成员列表
        ///
        /// 获取备份共享成员的列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMembersDetailResponse> ShowMembersDetailAsync(ShowMembersDetailRequest showMembersDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMembersDetailRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMembersDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询备份元数据
        ///
        /// 查询备份时资源的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMetadataResponse> ShowMetadataAsync(ShowMetadataRequest showMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMetadataRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移
        ///
        /// 查询迁移结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMigrateStatusResponse> ShowMigrateStatusAsync(ShowMigrateStatusRequest showMigrateStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrateStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMigrateStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询单个任务
        ///
        /// 根据指定任务ID查询任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOpLogResponse> ShowOpLogAsync(ShowOpLogRequest showOpLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id" , showOpLogRequest.OperationLogId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOpLogResponse>(response);
        }
        
        /// <summary>
        /// 查询单个策略
        ///
        /// 查询单个策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyResponse> ShowPolicyAsync(ShowPolicyRequest showPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , showPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询指定可保护资源
        ///
        /// 根据ID查询可保护性资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProtectableResponse> ShowProtectableAsync(ShowProtectableRequest showProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type" , showProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProtectableResponse>(response);
        }
        
        /// <summary>
        /// 查询复制能力
        ///
        /// 查询本区域的复制能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplicationCapabilitiesResponse> ShowReplicationCapabilitiesAsync(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>(response);
        }
        
        /// <summary>
        /// 查询容量统计
        ///
        /// 查询容量统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStorageUsageResponse> ShowStorageUsageAsync(ShowStorageUsageRequest showStorageUsageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage_usage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowStorageUsageResponse>(response);
        }
        
        /// <summary>
        /// 查询指定存储库
        ///
        /// 根据ID查询指定存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVaultResponse> ShowVaultAsync(ShowVaultRequest showVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库项目标签
        ///
        /// 查询租户在指定Region和实例类型的所有标签集合
        /// 标签管理服务需要能够列出当前租户全部已使用的标签集合，为各服务Console打标签和过滤实例时提供标签联想功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVaultProjectTagResponse> ShowVaultProjectTagAsync(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultProjectTagResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库资源实例
        ///
        /// 使用标签过滤实例
        /// 标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVaultResourceInstancesResponse> ShowVaultResourceInstancesAsync(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库资源标签
        ///
        /// 查询指定实例的标签信息
        /// 标签管理服务需要使用该接口查询指定实例的全部标签数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVaultTagResponse> ShowVaultTagAsync(ShowVaultTagRequest showVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultTagResponse>(response);
        }
        
        /// <summary>
        /// 移除客户端
        ///
        /// 移除客户端，移除客户端时将会删除该客户端所有备份，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnregisterAgentResponse> UnregisterAgentAsync(UnregisterAgentRequest unregisterAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id" , unregisterAgentRequest.AgentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", unregisterAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<UnregisterAgentResponse>(response);
        }
        
        /// <summary>
        /// 修改客户端
        ///
        /// 修改客户端状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest updateAgentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id" , updateAgentRequest.AgentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgentResponse>(response);
        }
        
        /// <summary>
        /// 更新备份
        ///
        /// 根据备份id更改备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBackupResponse> UpdateBackupAsync(UpdateBackupRequest updateBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , updateBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBackupResponse>(response);
        }
        
        /// <summary>
        /// 更新备份成员状态
        ///
        /// 更新备份共享成员的状态，需要接收方执行此API。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMemberStatusResponse> UpdateMemberStatusAsync(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id" , updateMemberStatusRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberStatusResponse>(response);
        }
        
        /// <summary>
        /// 变更
        ///
        /// 订单更新，支付cbc订单后，调用该接口更新包周期产品订单信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOrderResponse> UpdateOrderAsync(UpdateOrderRequest updateOrderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id" , updateOrderRequest.OrderId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/{order_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateOrderResponse>(response);
        }
        
        /// <summary>
        /// 修改策略
        ///
        /// 修改策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest updatePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , updatePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改存储库
        ///
        /// 根据存储库ID修改存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVaultResponse> UpdateVaultAsync(UpdateVaultRequest updateVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , updateVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVaultResponse>(response);
        }
        
    }
}