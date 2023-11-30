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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", addAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/add-path",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAgentPathRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddAgentPathResponse>(response);
        }

        public AsyncInvoker<AddAgentPathResponse> AddAgentPathAsyncInvoker(AddAgentPathRequest addAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", addAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/add-path",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAgentPathRequest);
            return new AsyncInvoker<AddAgentPathResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAgentPathResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", addMemberRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddMemberResponse>(response);
        }

        public AsyncInvoker<AddMemberResponse> AddMemberAsyncInvoker(AddMemberRequest addMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", addMemberRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            return new AsyncInvoker<AddMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMemberResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", addVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddVaultResourceResponse>(response);
        }

        public AsyncInvoker<AddVaultResourceResponse> AddVaultResourceAsyncInvoker(AddVaultResourceRequest addVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", addVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            return new AsyncInvoker<AddVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddVaultResourceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", associateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateVaultPolicyResponse>(response);
        }

        public AsyncInvoker<AssociateVaultPolicyResponse> AssociateVaultPolicyAsyncInvoker(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", associateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            return new AsyncInvoker<AssociateVaultPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateVaultPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateAndDeleteVaultTagsResponse> BatchCreateAndDeleteVaultTagsAsyncInvoker(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            return new AsyncInvoker<BatchCreateAndDeleteVaultTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/batch-update",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateVaultRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateVaultResponse>(response);
        }

        public AsyncInvoker<BatchUpdateVaultResponse> BatchUpdateVaultAsyncInvoker(BatchUpdateVaultRequest batchUpdateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/batch-update",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateVaultRequest);
            return new AsyncInvoker<BatchUpdateVaultResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent/check",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkAgentRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckAgentResponse>(response);
        }

        public AsyncInvoker<CheckAgentResponse> CheckAgentAsyncInvoker(CheckAgentRequest checkAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent/check",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkAgentRequest);
            return new AsyncInvoker<CheckAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", copyBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyBackupResponse>(response);
        }

        public AsyncInvoker<CopyBackupResponse> CopyBackupAsyncInvoker(CopyBackupRequest copyBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", copyBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            return new AsyncInvoker<CopyBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyCheckpointResponse>(response);
        }

        public AsyncInvoker<CopyCheckpointResponse> CopyCheckpointAsyncInvoker(CopyCheckpointRequest copyCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            return new AsyncInvoker<CopyCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyCheckpointResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCheckpointResponse>(response);
        }

        public AsyncInvoker<CreateCheckpointResponse> CreateCheckpointAsyncInvoker(CreateCheckpointRequest createCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            return new AsyncInvoker<CreateCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCheckpointResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public AsyncInvoker<CreatePolicyResponse> CreatePolicyAsyncInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            return new AsyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/order",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidVaultRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidVaultResponse>(response);
        }

        public AsyncInvoker<CreatePostPaidVaultResponse> CreatePostPaidVaultAsyncInvoker(CreatePostPaidVaultRequest createPostPaidVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/order",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidVaultRequest);
            return new AsyncInvoker<CreatePostPaidVaultResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVaultResponse>(response);
        }

        public AsyncInvoker<CreateVaultResponse> CreateVaultAsyncInvoker(CreateVaultRequest createVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            return new AsyncInvoker<CreateVaultResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", createVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVaultTagsResponse>(response);
        }

        public AsyncInvoker<CreateVaultTagsResponse> CreateVaultTagsAsyncInvoker(CreateVaultTagsRequest createVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", createVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            return new AsyncInvoker<CreateVaultTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateVaultTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackupResponse>(response);
        }

        public AsyncInvoker<DeleteBackupResponse> DeleteBackupAsyncInvoker(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            return new AsyncInvoker<DeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public AsyncInvoker<DeleteMemberResponse> DeleteMemberAsyncInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new AsyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public AsyncInvoker<DeletePolicyResponse> DeletePolicyAsyncInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new AsyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", deleteVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultResponse>(response);
        }

        public AsyncInvoker<DeleteVaultResponse> DeleteVaultAsyncInvoker(DeleteVaultRequest deleteVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", deleteVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            return new AsyncInvoker<DeleteVaultResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id", deleteVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultTagResponse>(response);
        }

        public AsyncInvoker<DeleteVaultTagResponse> DeleteVaultTagAsyncInvoker(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id", deleteVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            return new AsyncInvoker<DeleteVaultTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVaultTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", disassociateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>(response);
        }

        public AsyncInvoker<DisassociateVaultPolicyResponse> DisassociateVaultPolicyAsyncInvoker(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", disassociateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            return new AsyncInvoker<DisassociateVaultPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportBackupResponse>(response);
        }

        public AsyncInvoker<ImportBackupResponse> ImportBackupAsyncInvoker(ImportBackupRequest importBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            return new AsyncInvoker<ImportBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/sync",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importCheckpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportCheckpointResponse>(response);
        }

        public AsyncInvoker<ImportCheckpointResponse> ImportCheckpointAsyncInvoker(ImportCheckpointRequest importCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/sync",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importCheckpointRequest);
            return new AsyncInvoker<ImportCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportCheckpointResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgentResponse>(response);
        }

        public AsyncInvoker<ListAgentResponse> ListAgentAsyncInvoker(ListAgentRequest listAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentRequest);
            return new AsyncInvoker<ListAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }

        public AsyncInvoker<ListBackupsResponse> ListBackupsAsyncInvoker(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            return new AsyncInvoker<ListBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainProjectsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{domain_name}/projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainProjectsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainProjectsResponse>(response);
        }

        public AsyncInvoker<ListDomainProjectsResponse> ListDomainProjectsAsyncInvoker(ListDomainProjectsRequest listDomainProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainProjectsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{domain_name}/projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainProjectsRequest);
            return new AsyncInvoker<ListDomainProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainProjectsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/external",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalVaultRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListExternalVaultResponse>(response);
        }

        public AsyncInvoker<ListExternalVaultResponse> ListExternalVaultAsyncInvoker(ListExternalVaultRequest listExternalVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/external",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalVaultRequest);
            return new AsyncInvoker<ListExternalVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOpLogsResponse>(response);
        }

        public AsyncInvoker<ListOpLogsResponse> ListOpLogsAsyncInvoker(ListOpLogsRequest listOpLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            return new AsyncInvoker<ListOpLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOpLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }

        public AsyncInvoker<ListPoliciesResponse> ListPoliciesAsyncInvoker(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            return new AsyncInvoker<ListPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/region-projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectsResponse>(response);
        }

        public AsyncInvoker<ListProjectsResponse> ListProjectsAsyncInvoker(ListProjectsRequest listProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/region-projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsRequest);
            return new AsyncInvoker<ListProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type", listProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProtectableResponse>(response);
        }

        public AsyncInvoker<ListProtectableResponse> ListProtectableAsyncInvoker(ListProtectableRequest listProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type", listProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            return new AsyncInvoker<ListProtectableResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectableResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVaultResponse>(response);
        }

        public AsyncInvoker<ListVaultResponse> ListVaultAsyncInvoker(ListVaultRequest listVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            return new AsyncInvoker<ListVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateDomainRequest);
            var response = await DoHttpRequestAsync("POST",request);
            var migrateDomainResponse = JsonUtils.DeSerializeNull<MigrateDomainResponse>(response);
            migrateDomainResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return migrateDomainResponse;
        }

        public AsyncInvoker<MigrateDomainResponse> MigrateDomainAsyncInvoker(MigrateDomainRequest migrateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateDomainRequest);
            return new AsyncInvoker<MigrateDomainResponse>(this, "POST", request, response =>
            {
                var migrateDomainResponse = JsonUtils.DeSerializeNull<MigrateDomainResponse>(response);
                migrateDomainResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
                return migrateDomainResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", migrateVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<MigrateVaultResourceResponse>(response);
        }

        public AsyncInvoker<MigrateVaultResourceResponse> MigrateVaultResourceAsyncInvoker(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", migrateVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            return new AsyncInvoker<MigrateVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateVaultResourceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerAgentRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RegisterAgentResponse>(response);
        }

        public AsyncInvoker<RegisterAgentResponse> RegisterAgentAsyncInvoker(RegisterAgentRequest registerAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerAgentRequest);
            return new AsyncInvoker<RegisterAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", removeAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/remove-path",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeAgentPathRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RemoveAgentPathResponse>(response);
        }

        public AsyncInvoker<RemoveAgentPathResponse> RemoveAgentPathAsyncInvoker(RemoveAgentPathRequest removeAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", removeAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/remove-path",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeAgentPathRequest);
            return new AsyncInvoker<RemoveAgentPathResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveAgentPathResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", removeVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RemoveVaultResourceResponse>(response);
        }

        public AsyncInvoker<RemoveVaultResourceResponse> RemoveVaultResourceAsyncInvoker(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", removeVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            return new AsyncInvoker<RemoveVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveVaultResourceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", restoreBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreBackupResponse>(response);
        }

        public AsyncInvoker<RestoreBackupResponse> RestoreBackupAsyncInvoker(RestoreBackupRequest restoreBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", restoreBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            return new AsyncInvoker<RestoreBackupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RestoreBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", setVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/set-resources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setVaultResourceRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetVaultResourceResponse>(response);
        }

        public AsyncInvoker<SetVaultResourceResponse> SetVaultResourceAsyncInvoker(SetVaultResourceRequest setVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", setVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/set-resources",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setVaultResourceRequest);
            return new AsyncInvoker<SetVaultResourceResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetVaultResourceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", showAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgentResponse>(response);
        }

        public AsyncInvoker<ShowAgentResponse> ShowAgentAsyncInvoker(ShowAgentRequest showAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", showAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentRequest);
            return new AsyncInvoker<ShowAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }

        public AsyncInvoker<ShowBackupResponse> ShowBackupAsyncInvoker(ShowBackupRequest showBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            return new AsyncInvoker<ShowBackupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id", showCheckpointRequest.CheckpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCheckpointResponse>(response);
        }

        public AsyncInvoker<ShowCheckpointResponse> ShowCheckpointAsyncInvoker(ShowCheckpointRequest showCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id", showCheckpointRequest.CheckpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            return new AsyncInvoker<ShowCheckpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCheckpointResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("source_project_id", showDomainRequest.SourceProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{source_project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }

        public AsyncInvoker<ShowDomainResponse> ShowDomainAsyncInvoker(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("source_project_id", showDomainRequest.SourceProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{source_project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            return new AsyncInvoker<ShowDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id", showMemberDetailRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberDetailResponse>(response);
        }

        public AsyncInvoker<ShowMemberDetailResponse> ShowMemberDetailAsyncInvoker(ShowMemberDetailRequest showMemberDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id", showMemberDetailRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            return new AsyncInvoker<ShowMemberDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMembersDetailRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMembersDetailResponse>(response);
        }

        public AsyncInvoker<ShowMembersDetailResponse> ShowMembersDetailAsyncInvoker(ShowMembersDetailRequest showMembersDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMembersDetailRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            return new AsyncInvoker<ShowMembersDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMembersDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMetadataRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/metadata",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
        }

        public AsyncInvoker<ShowMetadataResponse> ShowMetadataAsyncInvoker(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMetadataRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/metadata",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            return new AsyncInvoker<ShowMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetadataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrateStatusRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMigrateStatusResponse>(response);
        }

        public AsyncInvoker<ShowMigrateStatusResponse> ShowMigrateStatusAsyncInvoker(ShowMigrateStatusRequest showMigrateStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrateStatusRequest);
            return new AsyncInvoker<ShowMigrateStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrateStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id", showOpLogRequest.OperationLogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOpLogResponse>(response);
        }

        public AsyncInvoker<ShowOpLogResponse> ShowOpLogAsyncInvoker(ShowOpLogRequest showOpLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id", showOpLogRequest.OperationLogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            return new AsyncInvoker<ShowOpLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpLogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public AsyncInvoker<ShowPolicyResponse> ShowPolicyAsyncInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new AsyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type", showProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProtectableResponse>(response);
        }

        public AsyncInvoker<ShowProtectableResponse> ShowProtectableAsyncInvoker(ShowProtectableRequest showProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type", showProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            return new AsyncInvoker<ShowProtectableResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectableResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>(response);
        }

        public AsyncInvoker<ShowReplicationCapabilitiesResponse> ShowReplicationCapabilitiesAsyncInvoker(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            return new AsyncInvoker<ShowReplicationCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage_usage",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsageRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowStorageUsageResponse>(response);
        }

        public AsyncInvoker<ShowStorageUsageResponse> ShowStorageUsageAsyncInvoker(ShowStorageUsageRequest showStorageUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage_usage",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsageRequest);
            return new AsyncInvoker<ShowStorageUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageUsageResponse>);
        }
        
        /// <summary>
        /// 存储库容量总览
        ///
        /// 查询项目下所有存储库的总容量和总使用量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSummaryResponse> ShowSummaryAsync(ShowSummaryRequest showSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/summary",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSummaryResponse>(response);
        }

        public AsyncInvoker<ShowSummaryResponse> ShowSummaryAsyncInvoker(ShowSummaryRequest showSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/summary",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryRequest);
            return new AsyncInvoker<ShowSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSummaryResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultResponse>(response);
        }

        public AsyncInvoker<ShowVaultResponse> ShowVaultAsyncInvoker(ShowVaultRequest showVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            return new AsyncInvoker<ShowVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultProjectTagResponse>(response);
        }

        public AsyncInvoker<ShowVaultProjectTagResponse> ShowVaultProjectTagAsyncInvoker(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            return new AsyncInvoker<ShowVaultProjectTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultProjectTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ShowVaultResourceInstancesResponse> ShowVaultResourceInstancesAsyncInvoker(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            return new AsyncInvoker<ShowVaultResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultTagResponse>(response);
        }

        public AsyncInvoker<ShowVaultTagResponse> ShowVaultTagAsyncInvoker(ShowVaultTagRequest showVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            return new AsyncInvoker<ShowVaultTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", unregisterAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unregisterAgentRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<UnregisterAgentResponse>(response);
        }

        public AsyncInvoker<UnregisterAgentResponse> UnregisterAgentAsyncInvoker(UnregisterAgentRequest unregisterAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", unregisterAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unregisterAgentRequest);
            return new AsyncInvoker<UnregisterAgentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<UnregisterAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", updateAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgentRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgentResponse>(response);
        }

        public AsyncInvoker<UpdateAgentResponse> UpdateAgentAsyncInvoker(UpdateAgentRequest updateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", updateAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgentRequest);
            return new AsyncInvoker<UpdateAgentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAgentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", updateBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBackupResponse>(response);
        }

        public AsyncInvoker<UpdateBackupResponse> UpdateBackupAsyncInvoker(UpdateBackupRequest updateBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", updateBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupRequest);
            return new AsyncInvoker<UpdateBackupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id", updateMemberStatusRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberStatusResponse>(response);
        }

        public AsyncInvoker<UpdateMemberStatusResponse> UpdateMemberStatusAsyncInvoker(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id", updateMemberStatusRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            return new AsyncInvoker<UpdateMemberStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", updateOrderRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/{order_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrderRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOrderResponse>(response);
        }

        public AsyncInvoker<UpdateOrderResponse> UpdateOrderAsyncInvoker(UpdateOrderRequest updateOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", updateOrderRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/{order_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrderRequest);
            return new AsyncInvoker<UpdateOrderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrderResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyResponse> UpdatePolicyAsyncInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            return new AsyncInvoker<UpdatePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", updateVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVaultResponse>(response);
        }

        public AsyncInvoker<UpdateVaultResponse> UpdateVaultAsyncInvoker(UpdateVaultRequest updateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", updateVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            return new AsyncInvoker<UpdateVaultResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVaultResponse>);
        }
        
    }
}