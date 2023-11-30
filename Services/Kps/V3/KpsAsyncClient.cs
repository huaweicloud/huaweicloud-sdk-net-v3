using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kps.V3.Model;

namespace HuaweiCloud.SDK.Kps.V3
{
    public partial class KpsAsyncClient : Client
    {
        public static ClientBuilder<KpsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KpsAsyncClient>();
        }

        
        /// <summary>
        /// 绑定SSH密钥对
        ///
        /// 给指定的虚拟机绑定（替换或重置，替换需提供虚拟机已配置的SSH密钥对私钥；重置不需要提供虚拟机的SSH密钥对私钥）新的SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateKeypairResponse> AssociateKeypairAsync(AssociateKeypairRequest associateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateKeypairResponse>(response);
        }

        public AsyncInvoker<AssociateKeypairResponse> AssociateKeypairAsyncInvoker(AssociateKeypairRequest associateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            return new AsyncInvoker<AssociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateKeypairResponse>);
        }
        
        /// <summary>
        /// 批量绑定SSH密钥对
        ///
        /// 给指定的虚拟机批量绑定新的SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAssociateKeypairResponse> BatchAssociateKeypairAsync(BatchAssociateKeypairRequest batchAssociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-associate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAssociateKeypairRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAssociateKeypairResponse>(response);
        }

        public AsyncInvoker<BatchAssociateKeypairResponse> BatchAssociateKeypairAsyncInvoker(BatchAssociateKeypairRequest batchAssociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/batch-associate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAssociateKeypairRequest);
            return new AsyncInvoker<BatchAssociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAssociateKeypairResponse>);
        }
        
        /// <summary>
        /// 清除私钥
        ///
        /// 清除SSH密钥对私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ClearPrivateKeyResponse> ClearPrivateKeyAsync(ClearPrivateKeyRequest clearPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", clearPrivateKeyRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}/private-key",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearPrivateKeyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<ClearPrivateKeyResponse>(response);
        }

        public AsyncInvoker<ClearPrivateKeyResponse> ClearPrivateKeyAsyncInvoker(ClearPrivateKeyRequest clearPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", clearPrivateKeyRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}/private-key",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearPrivateKeyRequest);
            return new AsyncInvoker<ClearPrivateKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<ClearPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥对
        ///
        /// 创建和导入SSH密钥对
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKeypairResponse> CreateKeypairAsync(CreateKeypairRequest createKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKeypairResponse>(response);
        }

        public AsyncInvoker<CreateKeypairResponse> CreateKeypairAsyncInvoker(CreateKeypairRequest createKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            return new AsyncInvoker<CreateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeypairResponse>);
        }
        
        /// <summary>
        /// 删除所有失败的任务
        ///
        /// 删除操作失败的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAllFailedTaskResponse> DeleteAllFailedTaskAsync(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>(response);
        }

        public AsyncInvoker<DeleteAllFailedTaskResponse> DeleteAllFailedTaskAsyncInvoker(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            return new AsyncInvoker<DeleteAllFailedTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>);
        }
        
        /// <summary>
        /// 删除失败的任务
        ///
        /// 删除失败的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFailedTaskResponse> DeleteFailedTaskAsync(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteFailedTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>(response);
        }

        public AsyncInvoker<DeleteFailedTaskResponse> DeleteFailedTaskAsyncInvoker(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteFailedTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            return new AsyncInvoker<DeleteFailedTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>);
        }
        
        /// <summary>
        /// 删除SSH密钥对
        ///
        /// 删除SSH密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKeypairResponse> DeleteKeypairAsync(DeleteKeypairRequest deleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", deleteKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeypairResponse>(response);
        }

        public AsyncInvoker<DeleteKeypairResponse> DeleteKeypairAsyncInvoker(DeleteKeypairRequest deleteKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", deleteKeypairRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            return new AsyncInvoker<DeleteKeypairResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeypairResponse>);
        }
        
        /// <summary>
        /// 解绑SSH密钥对
        ///
        /// 给指定的虚拟机解除绑定SSH密钥对并恢复SSH密码登录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateKeypairResponse> DisassociateKeypairAsync(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateKeypairResponse>(response);
        }

        public AsyncInvoker<DisassociateKeypairResponse> DisassociateKeypairAsyncInvoker(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            return new AsyncInvoker<DisassociateKeypairResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateKeypairResponse>);
        }
        
        /// <summary>
        /// 导出私钥
        ///
        /// 导出指定密钥对的私钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportPrivateKeyResponse> ExportPrivateKeyAsync(ExportPrivateKeyRequest exportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/export",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportPrivateKeyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExportPrivateKeyResponse>(response);
        }

        public AsyncInvoker<ExportPrivateKeyResponse> ExportPrivateKeyAsyncInvoker(ExportPrivateKeyRequest exportPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/export",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportPrivateKeyRequest);
            return new AsyncInvoker<ExportPrivateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 导入私钥
        ///
        /// 导入私钥到指定密钥对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportPrivateKeyResponse> ImportPrivateKeyAsync(ImportPrivateKeyRequest importPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/import",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importPrivateKeyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportPrivateKeyResponse>(response);
        }

        public AsyncInvoker<ImportPrivateKeyResponse> ImportPrivateKeyAsyncInvoker(ImportPrivateKeyRequest importPrivateKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/private-key/import",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importPrivateKeyRequest);
            return new AsyncInvoker<ImportPrivateKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportPrivateKeyResponse>);
        }
        
        /// <summary>
        /// 查询失败的任务信息
        ///
        /// 查询绑定、解绑等操作失败的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFailedTaskResponse> ListFailedTaskAsync(ListFailedTaskRequest listFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFailedTaskResponse>(response);
        }

        public AsyncInvoker<ListFailedTaskResponse> ListFailedTaskAsyncInvoker(ListFailedTaskRequest listFailedTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            return new AsyncInvoker<ListFailedTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFailedTaskResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥对详细信息
        ///
        /// 查询SSH密钥对详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeypairDetailResponse> ListKeypairDetailAsync(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", listKeypairDetailRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairDetailResponse>(response);
        }

        public AsyncInvoker<ListKeypairDetailResponse> ListKeypairDetailAsyncInvoker(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", listKeypairDetailRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            return new AsyncInvoker<ListKeypairDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairDetailResponse>);
        }
        
        /// <summary>
        /// 查询任务信息
        ///
        /// 根据SSH密钥对接口返回的task_id，查询SSH密钥对当前任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeypairTaskResponse> ListKeypairTaskAsync(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listKeypairTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairTaskResponse>(response);
        }

        public AsyncInvoker<ListKeypairTaskResponse> ListKeypairTaskAsyncInvoker(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listKeypairTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            return new AsyncInvoker<ListKeypairTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairTaskResponse>);
        }
        
        /// <summary>
        /// 查询SSH密钥对列表
        ///
        /// 查询SSH密钥对列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeypairsResponse> ListKeypairsAsync(ListKeypairsRequest listKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairsResponse>(response);
        }

        public AsyncInvoker<ListKeypairsResponse> ListKeypairsAsyncInvoker(ListKeypairsRequest listKeypairsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            return new AsyncInvoker<ListKeypairsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeypairsResponse>);
        }
        
        /// <summary>
        /// 查询正在处理的任务信息
        ///
        /// 查询正在处理的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRunningTaskResponse> ListRunningTaskAsync(ListRunningTaskRequest listRunningTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRunningTaskResponse>(response);
        }

        public AsyncInvoker<ListRunningTaskResponse> ListRunningTaskAsyncInvoker(ListRunningTaskRequest listRunningTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            return new AsyncInvoker<ListRunningTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRunningTaskResponse>);
        }
        
        /// <summary>
        /// 更新SSH密钥对描述
        ///
        /// 更新SSH密钥对描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKeypairDescriptionResponse> UpdateKeypairDescriptionAsync(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", updateKeypairDescriptionRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>(response);
        }

        public AsyncInvoker<UpdateKeypairDescriptionResponse> UpdateKeypairDescriptionAsyncInvoker(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name", updateKeypairDescriptionRequest.KeypairName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            return new AsyncInvoker<UpdateKeypairDescriptionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>);
        }
        
    }
}