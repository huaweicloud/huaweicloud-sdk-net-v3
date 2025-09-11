using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kps.V3.Model;

namespace HuaweiCloud.SDK.Kps.V3
{
    public partial class KpsClient : Client
    {
        public static ClientBuilder<KpsClient> NewBuilder()
        {
            return new ClientBuilder<KpsClient>();
        }

        
        /// <summary>
        /// 绑定SSH密钥对
        ///
        /// 给指定的虚拟机绑定（替换或重置，替换需提供虚拟机已配置的SSH密钥对私钥；重置不需要提供虚拟机的SSH密钥对私钥）新的SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateKeypairResponse AssociateKeypair(AssociateKeypairRequest associateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateKeypairResponse>(response);
        }

        public SyncInvoker<AssociateKeypairResponse> AssociateKeypairInvoker(AssociateKeypairRequest associateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            return new SyncInvoker<AssociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateKeypairResponse>);
        }
        
        /// <summary>
        /// 批量绑定SSH密钥对
        ///
        /// 给指定的虚拟机批量绑定新的SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAssociateKeypairResponse BatchAssociateKeypair(BatchAssociateKeypairRequest batchAssociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAssociateKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAssociateKeypairResponse>(response);
        }

        public SyncInvoker<BatchAssociateKeypairResponse> BatchAssociateKeypairInvoker(BatchAssociateKeypairRequest batchAssociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAssociateKeypairRequest);
            return new SyncInvoker<BatchAssociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAssociateKeypairResponse>);
        }
        
        /// <summary>
        /// 批量导出密钥对私钥
        ///
        /// 批量导出密钥对私钥，单次最多导出10条数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchExportPrivateKeyResponse BatchExportPrivateKey(BatchExportPrivateKeyRequest batchExportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/batch-export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchExportPrivateKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchExportPrivateKeyResponse>(response);
        }

        public SyncInvoker<BatchExportPrivateKeyResponse> BatchExportPrivateKeyInvoker(BatchExportPrivateKeyRequest batchExportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/batch-export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchExportPrivateKeyRequest);
            return new SyncInvoker<BatchExportPrivateKeyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchExportPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 批量导入SSH密钥对
        ///
        /// 批量导入SSH密钥对,单次批量导入不得超过10条记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchImportKeypairResponse BatchImportKeypair(BatchImportKeypairRequest batchImportKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchImportKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchImportKeypairResponse>(response);
        }

        public SyncInvoker<BatchImportKeypairResponse> BatchImportKeypairInvoker(BatchImportKeypairRequest batchImportKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchImportKeypairRequest);
            return new SyncInvoker<BatchImportKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchImportKeypairResponse>);
        }
        
        /// <summary>
        /// 清除私钥
        ///
        /// 清除SSH密钥对私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ClearPrivateKeyResponse ClearPrivateKey(ClearPrivateKeyRequest clearPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(clearPrivateKeyRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}/private-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearPrivateKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<ClearPrivateKeyResponse>(response);
        }

        public SyncInvoker<ClearPrivateKeyResponse> ClearPrivateKeyInvoker(ClearPrivateKeyRequest clearPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(clearPrivateKeyRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}/private-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearPrivateKeyRequest);
            return new SyncInvoker<ClearPrivateKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<ClearPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥对
        ///
        /// 创建和导入SSH密钥对
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKeypairResponse CreateKeypair(CreateKeypairRequest createKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKeypairResponse>(response);
        }

        public SyncInvoker<CreateKeypairResponse> CreateKeypairInvoker(CreateKeypairRequest createKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            return new SyncInvoker<CreateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeypairResponse>);
        }
        
        /// <summary>
        /// 删除所有失败的任务
        ///
        /// 删除操作失败的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAllFailedTaskResponse DeleteAllFailedTask(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>(response);
        }

        public SyncInvoker<DeleteAllFailedTaskResponse> DeleteAllFailedTaskInvoker(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            return new SyncInvoker<DeleteAllFailedTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>);
        }
        
        /// <summary>
        /// 删除失败的任务
        ///
        /// 删除失败的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFailedTaskResponse DeleteFailedTask(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFailedTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>(response);
        }

        public SyncInvoker<DeleteFailedTaskResponse> DeleteFailedTaskInvoker(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFailedTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            return new SyncInvoker<DeleteFailedTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>);
        }
        
        /// <summary>
        /// 删除SSH密钥对
        ///
        /// 删除SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKeypairResponse DeleteKeypair(DeleteKeypairRequest deleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKeypairResponse>(response);
        }

        public SyncInvoker<DeleteKeypairResponse> DeleteKeypairInvoker(DeleteKeypairRequest deleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKeypairRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            return new SyncInvoker<DeleteKeypairResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeypairResponse>);
        }
        
        /// <summary>
        /// 解绑SSH密钥对
        ///
        /// 给指定的虚拟机解除绑定SSH密钥对并恢复SSH密码登录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateKeypairResponse DisassociateKeypair(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateKeypairResponse>(response);
        }

        public SyncInvoker<DisassociateKeypairResponse> DisassociateKeypairInvoker(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            return new SyncInvoker<DisassociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateKeypairResponse>);
        }
        
        /// <summary>
        /// 导出私钥
        ///
        /// 导出指定密钥对的私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportPrivateKeyResponse ExportPrivateKey(ExportPrivateKeyRequest exportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportPrivateKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportPrivateKeyResponse>(response);
        }

        public SyncInvoker<ExportPrivateKeyResponse> ExportPrivateKeyInvoker(ExportPrivateKeyRequest exportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportPrivateKeyRequest);
            return new SyncInvoker<ExportPrivateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 导入私钥
        ///
        /// 导入私钥到指定密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportPrivateKeyResponse ImportPrivateKey(ImportPrivateKeyRequest importPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importPrivateKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportPrivateKeyResponse>(response);
        }

        public SyncInvoker<ImportPrivateKeyResponse> ImportPrivateKeyInvoker(ImportPrivateKeyRequest importPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importPrivateKeyRequest);
            return new SyncInvoker<ImportPrivateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 查询失败的任务信息
        ///
        /// 查询绑定、解绑等操作失败的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFailedTaskResponse ListFailedTask(ListFailedTaskRequest listFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFailedTaskResponse>(response);
        }

        public SyncInvoker<ListFailedTaskResponse> ListFailedTaskInvoker(ListFailedTaskRequest listFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            return new SyncInvoker<ListFailedTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFailedTaskResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥对详细信息
        ///
        /// 查询SSH密钥对详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeypairDetailResponse ListKeypairDetail(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeypairDetailRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeypairDetailResponse>(response);
        }

        public SyncInvoker<ListKeypairDetailResponse> ListKeypairDetailInvoker(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeypairDetailRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            return new SyncInvoker<ListKeypairDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairDetailResponse>);
        }
        
        /// <summary>
        /// 查询任务信息
        ///
        /// 根据SSH密钥对接口返回的task_id，查询SSH密钥对当前任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeypairTaskResponse ListKeypairTask(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeypairTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeypairTaskResponse>(response);
        }

        public SyncInvoker<ListKeypairTaskResponse> ListKeypairTaskInvoker(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeypairTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            return new SyncInvoker<ListKeypairTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairTaskResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥对列表
        ///
        /// 查询SSH密钥对列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeypairsResponse ListKeypairs(ListKeypairsRequest listKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeypairsResponse>(response);
        }

        public SyncInvoker<ListKeypairsResponse> ListKeypairsInvoker(ListKeypairsRequest listKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            return new SyncInvoker<ListKeypairsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairsResponse>);
        }
        
        /// <summary>
        /// 查询正在处理的任务信息
        ///
        /// 查询正在处理的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRunningTaskResponse ListRunningTask(ListRunningTaskRequest listRunningTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRunningTaskResponse>(response);
        }

        public SyncInvoker<ListRunningTaskResponse> ListRunningTaskInvoker(ListRunningTaskRequest listRunningTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            return new SyncInvoker<ListRunningTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRunningTaskResponse>);
        }
        
        /// <summary>
        /// 更新SSH密钥对描述
        ///
        /// 更新SSH密钥对描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKeypairDescriptionResponse UpdateKeypairDescription(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateKeypairDescriptionRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>(response);
        }

        public SyncInvoker<UpdateKeypairDescriptionResponse> UpdateKeypairDescriptionInvoker(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateKeypairDescriptionRequest.KeypairName, out var valueOfKeypairName)) urlParam.Add("keypair_name", valueOfKeypairName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            return new SyncInvoker<UpdateKeypairDescriptionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>);
        }
        
    }
}