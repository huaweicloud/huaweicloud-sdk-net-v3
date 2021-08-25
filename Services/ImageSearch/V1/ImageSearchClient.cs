using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ImageSearch.V1.Model;

namespace HuaweiCloud.SDK.ImageSearch.V1
{
    public partial class ImageSearchClient : Client
    {
        public static ClientBuilder<ImageSearchClient> NewBuilder()
        {
            return new ClientBuilder<ImageSearchClient>();
        }

        
        /// <summary>
        /// 添加图片
        /// </summary>
        public RunAddPictureResponse RunAddPicture(RunAddPictureRequest runAddPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runAddPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runAddPictureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunAddPictureResponse>(response);
        }
        
        /// <summary>
        /// 查询图片
        /// </summary>
        public RunCheckPictureResponse RunCheckPicture(RunCheckPictureRequest runCheckPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runCheckPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCheckPictureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunCheckPictureResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
        /// </summary>
        public RunCreateInstanceResponse RunCreateInstance(RunCreateInstanceRequest runCreateInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCreateInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunCreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除实例
        /// </summary>
        public RunDeleteInstanceResponse RunDeleteInstance(RunDeleteInstanceRequest runDeleteInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runDeleteInstanceRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service/{instance_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<RunDeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除图片
        /// </summary>
        public RunDeletePictureResponse RunDeletePicture(RunDeletePictureRequest runDeletePictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runDeletePictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runDeletePictureRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<RunDeletePictureResponse>(response);
        }
        
        /// <summary>
        /// 修改图片信息
        /// </summary>
        public RunModifyPictureResponse RunModifyPicture(RunModifyPictureRequest runModifyPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runModifyPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModifyPictureRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RunModifyPictureResponse>(response);
        }
        
        /// <summary>
        /// 查询用户实例信息
        /// </summary>
        public RunQueryInstanceResponse RunQueryInstance(RunQueryInstanceRequest runQueryInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runQueryInstanceRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service/{instance_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<RunQueryInstanceResponse>(response);
        }
        
        /// <summary>
        /// 搜索图片
        /// </summary>
        public RunSearchPictureResponse RunSearchPicture(RunSearchPictureRequest runSearchPictureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_name" , runSearchPictureRequest.InstanceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_name}/image/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runSearchPictureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunSearchPictureResponse>(response);
        }
        
    }
}