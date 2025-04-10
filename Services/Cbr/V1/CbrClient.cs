using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cbr.V1.Model;

namespace HuaweiCloud.SDK.Cbr.V1
{
    public partial class CbrClient : Client
    {
        public static ClientBuilder<CbrClient> NewBuilder()
        {
            return new ClientBuilder<CbrClient>();
        }

        
        /// <summary>
        /// 新增备份路径
        ///
        /// 对客户端新增备份路径，新增的路径不会校验是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAgentPathResponse AddAgentPath(AddAgentPathRequest addAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", addAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/add-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAgentPathRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAgentPathResponse>(response);
        }

        public SyncInvoker<AddAgentPathResponse> AddAgentPathInvoker(AddAgentPathRequest addAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", addAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/add-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAgentPathRequest);
            return new SyncInvoker<AddAgentPathResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAgentPathResponse>);
        }
        
        /// <summary>
        /// 添加备份成员
        ///
        /// 添加备份可共享的成员，只有云服务器备份可以添加备份共享成员，且仅支持在同一区域的不同用户间共享。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMemberResponse AddMember(AddMemberRequest addMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", addMemberRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddMemberResponse>(response);
        }

        public SyncInvoker<AddMemberResponse> AddMemberInvoker(AddMemberRequest addMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", addMemberRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            return new SyncInvoker<AddMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMemberResponse>);
        }
        
        /// <summary>
        /// 添加资源
        ///
        /// 存储库添加资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddVaultResourceResponse AddVaultResource(AddVaultResourceRequest addVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", addVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddVaultResourceResponse>(response);
        }

        public SyncInvoker<AddVaultResourceResponse> AddVaultResourceInvoker(AddVaultResourceRequest addVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", addVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            return new SyncInvoker<AddVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddVaultResourceResponse>);
        }
        
        /// <summary>
        /// 设置存储库策略
        ///
        /// 存储库设置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateVaultPolicyResponse AssociateVaultPolicy(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", associateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateVaultPolicyResponse>(response);
        }

        public SyncInvoker<AssociateVaultPolicyResponse> AssociateVaultPolicyInvoker(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", associateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            return new SyncInvoker<AssociateVaultPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateVaultPolicyResponse>);
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
        public BatchCreateAndDeleteVaultTagsResponse BatchCreateAndDeleteVaultTags(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateAndDeleteVaultTagsResponse> BatchCreateAndDeleteVaultTagsInvoker(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            return new SyncInvoker<BatchCreateAndDeleteVaultTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>);
        }
        
        /// <summary>
        /// 批量修改存储库
        ///
        /// 批量修改项目下所有存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateVaultResponse BatchUpdateVault(BatchUpdateVaultRequest batchUpdateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateVaultRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateVaultResponse>(response);
        }

        public SyncInvoker<BatchUpdateVaultResponse> BatchUpdateVaultInvoker(BatchUpdateVaultRequest batchUpdateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateVaultRequest);
            return new SyncInvoker<BatchUpdateVaultResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateVaultResponse>);
        }
        
        /// <summary>
        /// 变更
        ///
        /// 订单更新，调用该接口更新包周期产品订单信息,返回待支付订单信息。
        /// &gt; 该接口目前属于公测阶段，部分region暂时无法使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeOrderResponse ChangeOrder(ChangeOrderRequest changeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeOrderResponse>(response);
        }

        public SyncInvoker<ChangeOrderResponse> ChangeOrderInvoker(ChangeOrderRequest changeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/change", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeOrderRequest);
            return new SyncInvoker<ChangeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeOrderResponse>);
        }
        
        /// <summary>
        /// 修改付费模式
        ///
        /// 修改资源的付费模式，暂时只支持按需资源转包周期资源。
        /// &gt; 该接口目前输入公测阶段，部分region暂时无法使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeVaultChargeModeResponse ChangeVaultChargeMode(ChangeVaultChargeModeRequest changeVaultChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVaultChargeModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeVaultChargeModeResponse>(response);
        }

        public SyncInvoker<ChangeVaultChargeModeResponse> ChangeVaultChargeModeInvoker(ChangeVaultChargeModeRequest changeVaultChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeVaultChargeModeRequest);
            return new SyncInvoker<ChangeVaultChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeVaultChargeModeResponse>);
        }
        
        /// <summary>
        /// 查询agent状态
        ///
        /// 检查应用一致性Agent状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckAgentResponse CheckAgent(CheckAgentRequest checkAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckAgentResponse>(response);
        }

        public SyncInvoker<CheckAgentResponse> CheckAgentInvoker(CheckAgentRequest checkAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkAgentRequest);
            return new SyncInvoker<CheckAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckAgentResponse>);
        }
        
        /// <summary>
        /// 复制备份
        ///
        /// 跨区域复制备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyBackupResponse CopyBackup(CopyBackupRequest copyBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", copyBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyBackupResponse>(response);
        }

        public SyncInvoker<CopyBackupResponse> CopyBackupInvoker(CopyBackupRequest copyBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", copyBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            return new SyncInvoker<CopyBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyBackupResponse>);
        }
        
        /// <summary>
        /// 复制备份还原点
        ///
        /// 执行复制
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyCheckpointResponse CopyCheckpoint(CopyCheckpointRequest copyCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyCheckpointResponse>(response);
        }

        public SyncInvoker<CopyCheckpointResponse> CopyCheckpointInvoker(CopyCheckpointRequest copyCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            return new SyncInvoker<CopyCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyCheckpointResponse>);
        }
        
        /// <summary>
        /// 创建备份还原点
        ///
        /// 对存储库执行备份，生成备份还原点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCheckpointResponse CreateCheckpoint(CreateCheckpointRequest createCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCheckpointResponse>(response);
        }

        public SyncInvoker<CreateCheckpointResponse> CreateCheckpointInvoker(CreateCheckpointRequest createCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            return new SyncInvoker<CreateCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCheckpointResponse>);
        }
        
        /// <summary>
        /// 创建组织策略
        ///
        /// 创建组织策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrganizationPolicyResponse CreateOrganizationPolicy(CreateOrganizationPolicyRequest createOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrganizationPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationPolicyResponse>(response);
        }

        public SyncInvoker<CreateOrganizationPolicyResponse> CreateOrganizationPolicyInvoker(CreateOrganizationPolicyRequest createOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrganizationPolicyRequest);
            return new SyncInvoker<CreateOrganizationPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationPolicyResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略，策略分为备份策略和复制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public SyncInvoker<CreatePolicyResponse> CreatePolicyInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            return new SyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
        }
        
        /// <summary>
        /// 创建包周期存储库
        ///
        /// 创建包周期存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostPaidVaultResponse CreatePostPaidVault(CreatePostPaidVaultRequest createPostPaidVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidVaultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidVaultResponse>(response);
        }

        public SyncInvoker<CreatePostPaidVaultResponse> CreatePostPaidVaultInvoker(CreatePostPaidVaultRequest createPostPaidVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidVaultRequest);
            return new SyncInvoker<CreatePostPaidVaultResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidVaultResponse>);
        }
        
        /// <summary>
        /// 创建存储库
        ///
        /// 创建存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVaultResponse CreateVault(CreateVaultRequest createVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVaultResponse>(response);
        }

        public SyncInvoker<CreateVaultResponse> CreateVaultInvoker(CreateVaultRequest createVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            return new SyncInvoker<CreateVaultResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVaultResponse>);
        }
        
        /// <summary>
        /// 添加存储库资源标签
        ///
        /// 一个资源上最多有10个标签。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVaultTagsResponse CreateVaultTags(CreateVaultTagsRequest createVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", createVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateVaultTagsResponse>(response);
        }

        public SyncInvoker<CreateVaultTagsResponse> CreateVaultTagsInvoker(CreateVaultTagsRequest createVaultTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", createVaultTagsRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            return new SyncInvoker<CreateVaultTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateVaultTagsResponse>);
        }
        
        /// <summary>
        /// 删除备份
        ///
        /// 删除单个备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackupResponse>(response);
        }

        public SyncInvoker<DeleteBackupResponse> DeleteBackupInvoker(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            return new SyncInvoker<DeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackupResponse>);
        }
        
        /// <summary>
        /// 删除指定备份成员
        ///
        /// 删除指定的备份共享成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public SyncInvoker<DeleteMemberResponse> DeleteMemberInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new SyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
        }
        
        /// <summary>
        /// 删除组织策略
        ///
        /// 删除组织策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOrganizationPolicyResponse DeleteOrganizationPolicy(DeleteOrganizationPolicyRequest deleteOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", deleteOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationPolicyResponse>(response);
        }

        public SyncInvoker<DeleteOrganizationPolicyResponse> DeleteOrganizationPolicyInvoker(DeleteOrganizationPolicyRequest deleteOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", deleteOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyRequest);
            return new SyncInvoker<DeleteOrganizationPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationPolicyResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public SyncInvoker<DeletePolicyResponse> DeletePolicyInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new SyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
        }
        
        /// <summary>
        /// 删除存储库
        ///
        /// 删除存储库。若删除储存库，将一并删除存储库中的所有备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest deleteVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", deleteVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVaultResponse>(response);
        }

        public SyncInvoker<DeleteVaultResponse> DeleteVaultInvoker(DeleteVaultRequest deleteVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", deleteVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            return new SyncInvoker<DeleteVaultResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVaultResponse>);
        }
        
        /// <summary>
        /// 删除存储库资源标签
        ///
        /// 幂等接口：删除时，如果删除的标签不存在，返回404。Key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVaultTagResponse DeleteVaultTag(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id", deleteVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVaultTagResponse>(response);
        }

        public SyncInvoker<DeleteVaultTagResponse> DeleteVaultTagInvoker(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id", deleteVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            return new SyncInvoker<DeleteVaultTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVaultTagResponse>);
        }
        
        /// <summary>
        /// 解除存储库策略
        ///
        /// 存储库解除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateVaultPolicyResponse DisassociateVaultPolicy(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", disassociateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>(response);
        }

        public SyncInvoker<DisassociateVaultPolicyResponse> DisassociateVaultPolicyInvoker(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", disassociateVaultPolicyRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            return new SyncInvoker<DisassociateVaultPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>);
        }
        
        /// <summary>
        /// 同步备份
        ///
        /// 同步线下混合云VMware备份副本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportBackupResponse ImportBackup(ImportBackupRequest importBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportBackupResponse>(response);
        }

        public SyncInvoker<ImportBackupResponse> ImportBackupInvoker(ImportBackupRequest importBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            return new SyncInvoker<ImportBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportBackupResponse>);
        }
        
        /// <summary>
        /// 同步备份还原点
        ///
        /// 针对vault同步备份副本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportCheckpointResponse ImportCheckpoint(ImportCheckpointRequest importCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importCheckpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportCheckpointResponse>(response);
        }

        public SyncInvoker<ImportCheckpointResponse> ImportCheckpointInvoker(ImportCheckpointRequest importCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importCheckpointRequest);
            return new SyncInvoker<ImportCheckpointResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportCheckpointResponse>);
        }
        
        /// <summary>
        /// 查询客户端列表
        ///
        /// 查询客户端列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentResponse ListAgent(ListAgentRequest listAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgentResponse>(response);
        }

        public SyncInvoker<ListAgentResponse> ListAgentInvoker(ListAgentRequest listAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentRequest);
            return new SyncInvoker<ListAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentResponse>);
        }
        
        /// <summary>
        /// 查询所有备份
        ///
        /// 查询所有副本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupsResponse ListBackups(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }

        public SyncInvoker<ListBackupsResponse> ListBackupsInvoker(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            return new SyncInvoker<ListBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsResponse>);
        }
        
        /// <summary>
        /// 查询租户项目列表
        ///
        /// 根据指定租户名称查询项目列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainProjectsResponse ListDomainProjects(ListDomainProjectsRequest listDomainProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainProjectsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{domain_name}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainProjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainProjectsResponse>(response);
        }

        public SyncInvoker<ListDomainProjectsResponse> ListDomainProjectsInvoker(ListDomainProjectsRequest listDomainProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainProjectsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{domain_name}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainProjectsRequest);
            return new SyncInvoker<ListDomainProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainProjectsResponse>);
        }
        
        /// <summary>
        /// 查询其他区域存储库列表
        ///
        /// 查询其他区域的存储库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExternalVaultResponse ListExternalVault(ListExternalVaultRequest listExternalVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/external", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalVaultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExternalVaultResponse>(response);
        }

        public SyncInvoker<ListExternalVaultResponse> ListExternalVaultInvoker(ListExternalVaultRequest listExternalVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/external", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalVaultRequest);
            return new SyncInvoker<ListExternalVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalVaultResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOpLogsResponse ListOpLogs(ListOpLogsRequest listOpLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOpLogsResponse>(response);
        }

        public SyncInvoker<ListOpLogsResponse> ListOpLogsInvoker(ListOpLogsRequest listOpLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            return new SyncInvoker<ListOpLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOpLogsResponse>);
        }
        
        /// <summary>
        /// 查询组织策略列表
        ///
        /// 查询组织策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationPoliciesResponse ListOrganizationPolicies(ListOrganizationPoliciesRequest listOrganizationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationPoliciesResponse>(response);
        }

        public SyncInvoker<ListOrganizationPoliciesResponse> ListOrganizationPoliciesInvoker(ListOrganizationPoliciesRequest listOrganizationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPoliciesRequest);
            return new SyncInvoker<ListOrganizationPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询组织策略部署状态列表
        ///
        /// 查询组织策略每个账号下策略部署状态列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationPolicyDetailResponse ListOrganizationPolicyDetail(ListOrganizationPolicyDetailRequest listOrganizationPolicyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", listOrganizationPolicyDetailRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}/policy-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationPolicyDetailResponse>(response);
        }

        public SyncInvoker<ListOrganizationPolicyDetailResponse> ListOrganizationPolicyDetailInvoker(ListOrganizationPolicyDetailRequest listOrganizationPolicyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", listOrganizationPolicyDetailRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}/policy-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyDetailRequest);
            return new SyncInvoker<ListOrganizationPolicyDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationPolicyDetailResponse>);
        }
        
        /// <summary>
        /// 查询策略列表
        ///
        /// 查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }

        public SyncInvoker<ListPoliciesResponse> ListPoliciesInvoker(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            return new SyncInvoker<ListPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询租户的项目信息
        ///
        /// 查询租户的企业项目信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectsResponse ListProjects(ListProjectsRequest listProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/region-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectsResponse>(response);
        }

        public SyncInvoker<ListProjectsResponse> ListProjectsInvoker(ListProjectsRequest listProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/region-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsRequest);
            return new SyncInvoker<ListProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectsResponse>);
        }
        
        /// <summary>
        /// 查询可保护资源
        ///
        /// 查询可保护性资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectableResponse ListProtectable(ListProtectableRequest listProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type", listProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProtectableResponse>(response);
        }

        public SyncInvoker<ListProtectableResponse> ListProtectableInvoker(ListProtectableRequest listProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type", listProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            return new SyncInvoker<ListProtectableResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectableResponse>);
        }
        
        /// <summary>
        /// 查询存储库列表
        ///
        /// 查询存储库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVaultResponse ListVault(ListVaultRequest listVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVaultResponse>(response);
        }

        public SyncInvoker<ListVaultResponse> ListVaultInvoker(ListVaultRequest listVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            return new SyncInvoker<ListVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVaultResponse>);
        }
        
        /// <summary>
        /// 租户迁移
        ///
        /// 将CSBS/VBS资源迁移到CBR。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateDomainResponse MigrateDomain(MigrateDomainRequest migrateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            var migrateDomainResponse = JsonUtils.DeSerializeNull<MigrateDomainResponse>(response);
            migrateDomainResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return migrateDomainResponse;
        }

        public SyncInvoker<MigrateDomainResponse> MigrateDomainInvoker(MigrateDomainRequest migrateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateDomainRequest);
            return new SyncInvoker<MigrateDomainResponse>(this, "POST", request, response =>
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
        public MigrateVaultResourceResponse MigrateVaultResource(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", migrateVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<MigrateVaultResourceResponse>(response);
        }

        public SyncInvoker<MigrateVaultResourceResponse> MigrateVaultResourceInvoker(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", migrateVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            return new SyncInvoker<MigrateVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateVaultResourceResponse>);
        }
        
        /// <summary>
        /// 注册客户端
        ///
        /// 注册客户端，安装时候由Agent调用，无需手动注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterAgentResponse RegisterAgent(RegisterAgentRequest registerAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterAgentResponse>(response);
        }

        public SyncInvoker<RegisterAgentResponse> RegisterAgentInvoker(RegisterAgentRequest registerAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerAgentRequest);
            return new SyncInvoker<RegisterAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterAgentResponse>);
        }
        
        /// <summary>
        /// 移除备份路径
        ///
        /// 移除已添加的文件备份路径。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveAgentPathResponse RemoveAgentPath(RemoveAgentPathRequest removeAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", removeAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/remove-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeAgentPathRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RemoveAgentPathResponse>(response);
        }

        public SyncInvoker<RemoveAgentPathResponse> RemoveAgentPathInvoker(RemoveAgentPathRequest removeAgentPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", removeAgentPathRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}/remove-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeAgentPathRequest);
            return new SyncInvoker<RemoveAgentPathResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveAgentPathResponse>);
        }
        
        /// <summary>
        /// 移除资源
        ///
        /// 移除存储库中的资源，若移除资源，将一并删除该资源在保管库中的备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveVaultResourceResponse RemoveVaultResource(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", removeVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RemoveVaultResourceResponse>(response);
        }

        public SyncInvoker<RemoveVaultResourceResponse> RemoveVaultResourceInvoker(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", removeVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            return new SyncInvoker<RemoveVaultResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveVaultResourceResponse>);
        }
        
        /// <summary>
        /// 备份恢复
        ///
        /// 恢复备份数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreBackupResponse RestoreBackup(RestoreBackupRequest restoreBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", restoreBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RestoreBackupResponse>(response);
        }

        public SyncInvoker<RestoreBackupResponse> RestoreBackupInvoker(RestoreBackupRequest restoreBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", restoreBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            return new SyncInvoker<RestoreBackupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RestoreBackupResponse>);
        }
        
        /// <summary>
        /// 设置存储库资源
        ///
        /// 设置存储库资源是否自动备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetVaultResourceResponse SetVaultResource(SetVaultResourceRequest setVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", setVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/set-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setVaultResourceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetVaultResourceResponse>(response);
        }

        public SyncInvoker<SetVaultResourceResponse> SetVaultResourceInvoker(SetVaultResourceRequest setVaultResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", setVaultResourceRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/set-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setVaultResourceRequest);
            return new SyncInvoker<SetVaultResourceResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetVaultResourceResponse>);
        }
        
        /// <summary>
        /// 查询指定客户端
        ///
        /// 查询指定客户端
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAgentResponse ShowAgent(ShowAgentRequest showAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", showAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAgentResponse>(response);
        }

        public SyncInvoker<ShowAgentResponse> ShowAgentInvoker(ShowAgentRequest showAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", showAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentRequest);
            return new SyncInvoker<ShowAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgentResponse>);
        }
        
        /// <summary>
        /// 查询指定备份
        ///
        /// 根据指定id查询单个副本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupResponse ShowBackup(ShowBackupRequest showBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }

        public SyncInvoker<ShowBackupResponse> ShowBackupInvoker(ShowBackupRequest showBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            return new SyncInvoker<ShowBackupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupResponse>);
        }
        
        /// <summary>
        /// 查询备份还原点
        ///
        /// 根据还原点ID查询指定还原点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCheckpointResponse ShowCheckpoint(ShowCheckpointRequest showCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id", showCheckpointRequest.CheckpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCheckpointResponse>(response);
        }

        public SyncInvoker<ShowCheckpointResponse> ShowCheckpointInvoker(ShowCheckpointRequest showCheckpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id", showCheckpointRequest.CheckpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            return new SyncInvoker<ShowCheckpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCheckpointResponse>);
        }
        
        /// <summary>
        /// 查询租户信息
        ///
        /// 由控制台调用的内部接口，用于仅在查询共享备份时获取源project_id的域名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainResponse ShowDomain(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("source_project_id", showDomainRequest.SourceProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{source_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }

        public SyncInvoker<ShowDomainResponse> ShowDomainInvoker(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("source_project_id", showDomainRequest.SourceProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domain/{source_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            return new SyncInvoker<ShowDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainResponse>);
        }
        
        /// <summary>
        /// 获取备份成员详情
        ///
        /// 获取备份成员的详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMemberDetailResponse ShowMemberDetail(ShowMemberDetailRequest showMemberDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id", showMemberDetailRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberDetailResponse>(response);
        }

        public SyncInvoker<ShowMemberDetailResponse> ShowMemberDetailInvoker(ShowMemberDetailRequest showMemberDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id", showMemberDetailRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            return new SyncInvoker<ShowMemberDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberDetailResponse>);
        }
        
        /// <summary>
        /// 获取备份成员列表
        ///
        /// 获取备份共享成员的列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMembersDetailResponse ShowMembersDetail(ShowMembersDetailRequest showMembersDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMembersDetailRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMembersDetailResponse>(response);
        }

        public SyncInvoker<ShowMembersDetailResponse> ShowMembersDetailInvoker(ShowMembersDetailRequest showMembersDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMembersDetailRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            return new SyncInvoker<ShowMembersDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMembersDetailResponse>);
        }
        
        /// <summary>
        /// 查询备份元数据
        ///
        /// 查询备份时资源的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMetadataResponse ShowMetadata(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMetadataRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
        }

        public SyncInvoker<ShowMetadataResponse> ShowMetadataInvoker(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showMetadataRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            return new SyncInvoker<ShowMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetadataResponse>);
        }
        
        /// <summary>
        /// 查询迁移
        ///
        /// 查询迁移结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMigrateStatusResponse ShowMigrateStatus(ShowMigrateStatusRequest showMigrateStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrateStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrateStatusResponse>(response);
        }

        public SyncInvoker<ShowMigrateStatusResponse> ShowMigrateStatusInvoker(ShowMigrateStatusRequest showMigrateStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/migrates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrateStatusRequest);
            return new SyncInvoker<ShowMigrateStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrateStatusResponse>);
        }
        
        /// <summary>
        /// 查询单个任务
        ///
        /// 根据指定任务ID查询任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOpLogResponse ShowOpLog(ShowOpLogRequest showOpLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id", showOpLogRequest.OperationLogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOpLogResponse>(response);
        }

        public SyncInvoker<ShowOpLogResponse> ShowOpLogInvoker(ShowOpLogRequest showOpLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id", showOpLogRequest.OperationLogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            return new SyncInvoker<ShowOpLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpLogResponse>);
        }
        
        /// <summary>
        /// 查询指定组织策略
        ///
        /// 查询指定组织策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationPolicyResponse ShowOrganizationPolicy(ShowOrganizationPolicyRequest showOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", showOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyResponse>(response);
        }

        public SyncInvoker<ShowOrganizationPolicyResponse> ShowOrganizationPolicyInvoker(ShowOrganizationPolicyRequest showOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", showOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyRequest);
            return new SyncInvoker<ShowOrganizationPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyResponse>);
        }
        
        /// <summary>
        /// 查询单个策略
        ///
        /// 查询单个策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyResponse ShowPolicy(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public SyncInvoker<ShowPolicyResponse> ShowPolicyInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new SyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
        }
        
        /// <summary>
        /// 查询指定可保护资源
        ///
        /// 根据ID查询可保护性资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProtectableResponse ShowProtectable(ShowProtectableRequest showProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type", showProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProtectableResponse>(response);
        }

        public SyncInvoker<ShowProtectableResponse> ShowProtectableInvoker(ShowProtectableRequest showProtectableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type", showProtectableRequest.ProtectableType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            return new SyncInvoker<ShowProtectableResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectableResponse>);
        }
        
        /// <summary>
        /// 查询复制能力
        ///
        /// 查询本区域的复制能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplicationCapabilitiesResponse ShowReplicationCapabilities(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>(response);
        }

        public SyncInvoker<ShowReplicationCapabilitiesResponse> ShowReplicationCapabilitiesInvoker(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            return new SyncInvoker<ShowReplicationCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询容量统计
        ///
        /// 查询容量统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStorageUsageResponse ShowStorageUsage(ShowStorageUsageRequest showStorageUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage_usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStorageUsageResponse>(response);
        }

        public SyncInvoker<ShowStorageUsageResponse> ShowStorageUsageInvoker(ShowStorageUsageRequest showStorageUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage_usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsageRequest);
            return new SyncInvoker<ShowStorageUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageUsageResponse>);
        }
        
        /// <summary>
        /// 存储库容量总览
        ///
        /// 查询项目下所有存储库的总容量和总使用量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSummaryResponse ShowSummary(ShowSummaryRequest showSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSummaryResponse>(response);
        }

        public SyncInvoker<ShowSummaryResponse> ShowSummaryInvoker(ShowSummaryRequest showSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryRequest);
            return new SyncInvoker<ShowSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSummaryResponse>);
        }
        
        /// <summary>
        /// 查询指定存储库
        ///
        /// 根据ID查询指定存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVaultResponse ShowVault(ShowVaultRequest showVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVaultResponse>(response);
        }

        public SyncInvoker<ShowVaultResponse> ShowVaultInvoker(ShowVaultRequest showVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            return new SyncInvoker<ShowVaultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultResponse>);
        }
        
        /// <summary>
        /// 查询存储库项目标签
        ///
        /// 查询租户在指定Region和实例类型的所有标签集合
        /// 标签管理服务需要能够列出当前租户全部已使用的标签集合，为各服务Console打标签和过滤实例时提供标签联想功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVaultProjectTagResponse ShowVaultProjectTag(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVaultProjectTagResponse>(response);
        }

        public SyncInvoker<ShowVaultProjectTagResponse> ShowVaultProjectTagInvoker(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            return new SyncInvoker<ShowVaultProjectTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultProjectTagResponse>);
        }
        
        /// <summary>
        /// 查询存储库资源实例
        ///
        /// 使用标签过滤实例
        /// 标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVaultResourceInstancesResponse ShowVaultResourceInstances(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>(response);
        }

        public SyncInvoker<ShowVaultResourceInstancesResponse> ShowVaultResourceInstancesInvoker(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            return new SyncInvoker<ShowVaultResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询存储库资源标签
        ///
        /// 查询指定实例的标签信息
        /// 标签管理服务需要使用该接口查询指定实例的全部标签数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVaultTagResponse ShowVaultTag(ShowVaultTagRequest showVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVaultTagResponse>(response);
        }

        public SyncInvoker<ShowVaultTagResponse> ShowVaultTagInvoker(ShowVaultTagRequest showVaultTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", showVaultTagRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            return new SyncInvoker<ShowVaultTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVaultTagResponse>);
        }
        
        /// <summary>
        /// 移除客户端
        ///
        /// 移除客户端，移除客户端时将会删除该客户端所有备份，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnregisterAgentResponse UnregisterAgent(UnregisterAgentRequest unregisterAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", unregisterAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unregisterAgentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<UnregisterAgentResponse>(response);
        }

        public SyncInvoker<UnregisterAgentResponse> UnregisterAgentInvoker(UnregisterAgentRequest unregisterAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", unregisterAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unregisterAgentRequest);
            return new SyncInvoker<UnregisterAgentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<UnregisterAgentResponse>);
        }
        
        /// <summary>
        /// 修改客户端
        ///
        /// 修改客户端状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest updateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", updateAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAgentResponse>(response);
        }

        public SyncInvoker<UpdateAgentResponse> UpdateAgentInvoker(UpdateAgentRequest updateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agent_id", updateAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgentRequest);
            return new SyncInvoker<UpdateAgentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAgentResponse>);
        }
        
        /// <summary>
        /// 更新备份
        ///
        /// 根据备份id更改备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBackupResponse UpdateBackup(UpdateBackupRequest updateBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", updateBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBackupResponse>(response);
        }

        public SyncInvoker<UpdateBackupResponse> UpdateBackupInvoker(UpdateBackupRequest updateBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", updateBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupRequest);
            return new SyncInvoker<UpdateBackupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBackupResponse>);
        }
        
        /// <summary>
        /// 更新备份成员状态
        ///
        /// 更新备份共享成员的状态，需要接收方执行此API。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMemberStatusResponse UpdateMemberStatus(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id", updateMemberStatusRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMemberStatusResponse>(response);
        }

        public SyncInvoker<UpdateMemberStatusResponse> UpdateMemberStatusInvoker(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id", updateMemberStatusRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            return new SyncInvoker<UpdateMemberStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberStatusResponse>);
        }
        
        /// <summary>
        /// 变更（废弃）
        ///
        /// 订单更新，支付cbc订单后，调用该接口更新包周期产品订单信息。该接口已废弃。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOrderResponse UpdateOrder(UpdateOrderRequest updateOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", updateOrderRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/{order_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrderRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrderResponse>(response);
        }

        public SyncInvoker<UpdateOrderResponse> UpdateOrderInvoker(UpdateOrderRequest updateOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", updateOrderRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/orders/{order_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrderRequest);
            return new SyncInvoker<UpdateOrderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrderResponse>);
        }
        
        /// <summary>
        /// 更新组织策略
        ///
        /// 更新组织策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOrganizationPolicyResponse UpdateOrganizationPolicy(UpdateOrganizationPolicyRequest updateOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", updateOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrganizationPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrganizationPolicyResponse>(response);
        }

        public SyncInvoker<UpdateOrganizationPolicyResponse> UpdateOrganizationPolicyInvoker(UpdateOrganizationPolicyRequest updateOrganizationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organization_policy_id", updateOrganizationPolicyRequest.OrganizationPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/organization-policies/{organization_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOrganizationPolicyRequest);
            return new SyncInvoker<UpdateOrganizationPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrganizationPolicyResponse>);
        }
        
        /// <summary>
        /// 修改策略
        ///
        /// 修改策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }

        public SyncInvoker<UpdatePolicyResponse> UpdatePolicyInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            return new SyncInvoker<UpdatePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyResponse>);
        }
        
        /// <summary>
        /// 修改存储库
        ///
        /// 根据存储库ID修改存储库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVaultResponse UpdateVault(UpdateVaultRequest updateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", updateVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVaultResponse>(response);
        }

        public SyncInvoker<UpdateVaultResponse> UpdateVaultInvoker(UpdateVaultRequest updateVaultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id", updateVaultRequest.VaultId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            return new SyncInvoker<UpdateVaultResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVaultResponse>);
        }
        
    }
}