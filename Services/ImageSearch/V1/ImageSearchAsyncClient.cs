using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ImageSearch.V1.Model;

namespace HuaweiCloud.SDK.ImageSearch.V1
{
    public partial class ImageSearchAsyncClient : Client
    {
        public static ClientBuilder<ImageSearchAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ImageSearchAsyncClient>();
        }

        
        /// <summary>
        /// 添加图片
        /// </summary>
        public async Task<RunAddPictureResponse> RunAddPictureAsync(RunAddPictureRequest runAddPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runAddPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runAddPictureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunAddPictureResponse>(response);
        }
        
        /// <summary>
        /// 查询图片
        /// </summary>
        public async Task<RunCheckPictureResponse> RunCheckPictureAsync(RunCheckPictureRequest runCheckPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runCheckPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCheckPictureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCheckPictureResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
        /// </summary>
        public async Task<RunCreateInstanceResponse> RunCreateInstanceAsync(RunCreateInstanceRequest runCreateInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCreateInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除实例
        /// </summary>
        public async Task<RunDeleteInstanceResponse> RunDeleteInstanceAsync(RunDeleteInstanceRequest runDeleteInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runDeleteInstanceRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service/{instance_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<RunDeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除图片
        /// </summary>
        public async Task<RunDeletePictureResponse> RunDeletePictureAsync(RunDeletePictureRequest runDeletePictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runDeletePictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runDeletePictureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<RunDeletePictureResponse>(response);
        }
        
        /// <summary>
        /// 修改图片信息
        /// </summary>
        public async Task<RunModifyPictureResponse> RunModifyPictureAsync(RunModifyPictureRequest runModifyPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runModifyPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModifyPictureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RunModifyPictureResponse>(response);
        }
        
        /// <summary>
        /// 查询用户实例信息
        /// </summary>
        public async Task<RunQueryInstanceResponse> RunQueryInstanceAsync(RunQueryInstanceRequest runQueryInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runQueryInstanceRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service/{instance_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryInstanceResponse>(response);
        }
        
        /// <summary>
        /// 搜索图片
        /// </summary>
        public async Task<RunSearchPictureResponse> RunSearchPictureAsync(RunSearchPictureRequest runSearchPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runSearchPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runSearchPictureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunSearchPictureResponse>(response);
        }
        
    }
}