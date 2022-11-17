using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Demo.V1.Model;

namespace HuaweiCloud.SDK.Demo.V1
{
    public partial class DemoAsyncClient : Client
    {
        public static ClientBuilder<DemoAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DemoAsyncClient>();
        }

        
        /// <summary>
        /// demo
        ///
        /// CreateDemoResource Test
        /// </summary>
        public async Task<CreateDemoResourceResponse> CreateDemoResourceAsync(CreateDemoResourceRequest createDemoResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDemoResourceResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// DeleteDemoResource Test
        /// </summary>
        public async Task<DeleteDemoResourceResponse> DeleteDemoResourceAsync(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteDemoResourceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoArray Test
        /// </summary>
        public async Task<ListDemoArrayResponse> ListDemoArrayAsync(ListDemoArrayRequest listDemoArrayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListDemoArrayResponse listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<ArrayItem>(response);
            return listDemoArrayResponse;
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoMap Test
        /// </summary>
        public async Task<ListDemoMapResponse> ListDemoMapAsync(ListDemoMapRequest listDemoMapRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListDemoMapResponse listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listDemoMapResponse;
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoResources Test
        /// </summary>
        public async Task<ListDemoResourcesResponse> ListDemoResourcesAsync(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDemoResourcesResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload download demo
        /// </summary>
        public async Task<UploadDownloadDemoResponse> UploadDownloadDemoAsync(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadDownloadDemoResponse>(response);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload Multipart demo
        /// </summary>
        public async Task<UploadMultipartResponse> UploadMultipartAsync(UploadMultipartRequest uploadMultipartRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadMultipartResponse>(response);
        }
        
    }
}