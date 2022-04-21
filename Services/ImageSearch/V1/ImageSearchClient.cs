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
        ///
        /// 添加图片
        /// 将图片导入图片索引库，该图片可以是同一区域OBS桶内的图片或请求消息体里的图片，只有导入图片索引库的图片方可被搜索到。
        /// 
        /// &gt; - 添加或搜索的图片存储在OBS的桶中时，需要对OBS的桶授权。在图像搜索服务管理控制台“实例管理”页面，单击实例操作列的“离线导入”，进入“离线导入”页面。选择存放数据的OBS桶，单击“授权”按钮，字体显示为灰色即完成OBS授权访问。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 通过图片路径查询索引库中对应图片是否存在。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建实例，实例中会生成图片索引库，用来存放图片特征。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除已存在的实例。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 通过图片路径删除索引库中对应图片。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 修改图像索引库中已存在的图片信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查看用户指定实例详细信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 从图片索引库中搜索相似图片。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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