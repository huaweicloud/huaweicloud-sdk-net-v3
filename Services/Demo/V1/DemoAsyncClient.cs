using System;
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDemoResourceResponse>(response);
        }

        public AsyncInvoker<CreateDemoResourceResponse> CreateDemoResourceAsyncInvoker(CreateDemoResourceRequest createDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            return new AsyncInvoker<CreateDemoResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDemoResourceResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// DeleteDemoResource Test
        /// </summary>
        public async Task<DeleteDemoResourceResponse> DeleteDemoResourceAsync(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteDemoResourceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }

        public AsyncInvoker<DeleteDemoResourceResponse> DeleteDemoResourceAsyncInvoker(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteDemoResourceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            return new AsyncInvoker<DeleteDemoResourceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoArray Test
        /// </summary>
        public async Task<ListDemoArrayResponse> ListDemoArrayAsync(ListDemoArrayRequest listDemoArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<ArrayItem>(response);
            return listDemoArrayResponse;
        }

        public AsyncInvoker<ListDemoArrayResponse> ListDemoArrayAsyncInvoker(ListDemoArrayRequest listDemoArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            return new AsyncInvoker<ListDemoArrayResponse>(this, "GET", request, response =>
            {
                var listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
                listDemoArrayResponse.Body = JsonUtils.DeSerializeList<ArrayItem>(response);
                return listDemoArrayResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoMap Test
        /// </summary>
        public async Task<ListDemoMapResponse> ListDemoMapAsync(ListDemoMapRequest listDemoMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listDemoMapResponse;
        }

        public AsyncInvoker<ListDemoMapResponse> ListDemoMapAsyncInvoker(ListDemoMapRequest listDemoMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            return new AsyncInvoker<ListDemoMapResponse>(this, "GET", request, response =>
            {
                var listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
                listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
                return listDemoMapResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoResources Test
        /// </summary>
        public async Task<ListDemoResourcesResponse> ListDemoResourcesAsync(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDemoResourcesResponse>(response);
        }

        public AsyncInvoker<ListDemoResourcesResponse> ListDemoResourcesAsyncInvoker(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            return new AsyncInvoker<ListDemoResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDemoResourcesResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload download demo
        /// </summary>
        public async Task<UploadDownloadDemoResponse> UploadDownloadDemoAsync(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadDownloadDemoResponse>(response);
        }

        public AsyncInvoker<UploadDownloadDemoResponse> UploadDownloadDemoAsyncInvoker(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            return new AsyncInvoker<UploadDownloadDemoResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadDownloadDemoResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload Multipart demo
        /// </summary>
        public async Task<UploadMultipartResponse> UploadMultipartAsync(UploadMultipartRequest uploadMultipartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadMultipartResponse>(response);
        }

        public AsyncInvoker<UploadMultipartResponse> UploadMultipartAsyncInvoker(UploadMultipartRequest uploadMultipartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            return new AsyncInvoker<UploadMultipartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadMultipartResponse>);
        }
        
    }
}