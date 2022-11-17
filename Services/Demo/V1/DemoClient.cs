using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Demo.V1.Model;

namespace HuaweiCloud.SDK.Demo.V1
{
    public partial class DemoClient : Client
    {
        public static ClientBuilder<DemoClient> NewBuilder()
        {
            return new ClientBuilder<DemoClient>();
        }

        
        /// <summary>
        /// demo
        ///
        /// CreateDemoResource Test
        /// </summary>
        public CreateDemoResourceResponse CreateDemoResource(CreateDemoResourceRequest createDemoResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDemoResourceResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// DeleteDemoResource Test
        /// </summary>
        public DeleteDemoResourceResponse DeleteDemoResource(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteDemoResourceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoArray Test
        /// </summary>
        public ListDemoArrayResponse ListDemoArray(ListDemoArrayRequest listDemoArrayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListDemoArrayResponse listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<ArrayItem>(response);
            return listDemoArrayResponse;
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoMap Test
        /// </summary>
        public ListDemoMapResponse ListDemoMap(ListDemoMapRequest listDemoMapRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListDemoMapResponse listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listDemoMapResponse;
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoResources Test
        /// </summary>
        public ListDemoResourcesResponse ListDemoResources(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDemoResourcesResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload download demo
        /// </summary>
        public UploadDownloadDemoResponse UploadDownloadDemo(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadDownloadDemoResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload Multipart demo
        /// </summary>
        public UploadMultipartResponse UploadMultipart(UploadMultipartRequest uploadMultipartRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadMultipartResponse>(response);
        }
        
    }
}