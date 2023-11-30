using System;
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDemoResourceResponse>(response);
        }

        public SyncInvoker<CreateDemoResourceResponse> CreateDemoResourceInvoker(CreateDemoResourceRequest createDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            return new SyncInvoker<CreateDemoResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDemoResourceResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// DeleteDemoResource Test
        /// </summary>
        public DeleteDemoResourceResponse DeleteDemoResource(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteDemoResourceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }

        public SyncInvoker<DeleteDemoResourceResponse> DeleteDemoResourceInvoker(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteDemoResourceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            return new SyncInvoker<DeleteDemoResourceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoArray Test
        /// </summary>
        public ListDemoArrayResponse ListDemoArray(ListDemoArrayRequest listDemoArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            var response = DoHttpRequestSync("GET", request);
            var listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<ArrayItem>(response);
            return listDemoArrayResponse;
        }

        public SyncInvoker<ListDemoArrayResponse> ListDemoArrayInvoker(ListDemoArrayRequest listDemoArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            return new SyncInvoker<ListDemoArrayResponse>(this, "GET", request, response =>
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
        public ListDemoMapResponse ListDemoMap(ListDemoMapRequest listDemoMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            var response = DoHttpRequestSync("GET", request);
            var listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listDemoMapResponse;
        }

        public SyncInvoker<ListDemoMapResponse> ListDemoMapInvoker(ListDemoMapRequest listDemoMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            return new SyncInvoker<ListDemoMapResponse>(this, "GET", request, response =>
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
        public ListDemoResourcesResponse ListDemoResources(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDemoResourcesResponse>(response);
        }

        public SyncInvoker<ListDemoResourcesResponse> ListDemoResourcesInvoker(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            return new SyncInvoker<ListDemoResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDemoResourcesResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload download demo
        /// </summary>
        public UploadDownloadDemoResponse UploadDownloadDemo(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadDownloadDemoResponse>(response);
        }

        public SyncInvoker<UploadDownloadDemoResponse> UploadDownloadDemoInvoker(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            return new SyncInvoker<UploadDownloadDemoResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadDownloadDemoResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload Multipart demo
        /// </summary>
        public UploadMultipartResponse UploadMultipart(UploadMultipartRequest uploadMultipartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadMultipartResponse>(response);
        }

        public SyncInvoker<UploadMultipartResponse> UploadMultipartInvoker(UploadMultipartRequest uploadMultipartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            return new SyncInvoker<UploadMultipartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadMultipartResponse>);
        }
        
    }
}