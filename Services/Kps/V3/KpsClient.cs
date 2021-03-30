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
        /// </summary>
        public AssociateKeypairResponse AssociateKeypair(AssociateKeypairRequest associateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AssociateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥对
        /// </summary>
        public CreateKeypairResponse CreateKeypair(CreateKeypairRequest createKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 删除所有失败的任务
        /// </summary>
        public DeleteAllFailedTaskResponse DeleteAllFailedTask(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除失败的任务
        /// </summary>
        public DeleteFailedTaskResponse DeleteFailedTask(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , deleteFailedTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除SSH密钥对
        /// </summary>
        public DeleteKeypairResponse DeleteKeypair(DeleteKeypairRequest deleteKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , deleteKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeypairResponse>(response);
        }
        
        /// <summary>
        /// 解绑SSH密钥对
        /// </summary>
        public DisassociateKeypairResponse DisassociateKeypair(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisassociateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 查询失败的任务信息
        /// </summary>
        public ListFailedTaskResponse ListFailedTask(ListFailedTaskRequest listFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥对详细信息
        /// </summary>
        public ListKeypairDetailResponse ListKeypairDetail(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , listKeypairDetailRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询任务信息
        /// </summary>
        public ListKeypairTaskResponse ListKeypairTask(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , listKeypairTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥对列表
        /// </summary>
        public ListKeypairsResponse ListKeypairs(ListKeypairsRequest listKeypairsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairsResponse>(response);
        }
        
        /// <summary>
        /// 查询正在处理的任务信息
        /// </summary>
        public ListRunningTaskResponse ListRunningTask(ListRunningTaskRequest listRunningTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRunningTaskResponse>(response);
        }
        
        /// <summary>
        /// 更新SSH密钥对描述
        /// </summary>
        public UpdateKeypairDescriptionResponse UpdateKeypairDescription(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , updateKeypairDescriptionRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>(response);
        }
        
    }
}