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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDemoResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDemoResourceResponse>(response);
        }

        public AsyncInvoker<CreateDemoResourceResponse> CreateDemoResourceAsyncInvoker(CreateDemoResourceRequest createDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }

        public AsyncInvoker<DeleteDemoResourceResponse> DeleteDemoResourceAsyncInvoker(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteDemoResourceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<SimpleItem>(response);
            return listDemoArrayResponse;
        }

        public AsyncInvoker<ListDemoArrayResponse> ListDemoArrayAsyncInvoker(ListDemoArrayRequest listDemoArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoArrayRequest);
            return new AsyncInvoker<ListDemoArrayResponse>(this, "GET", request, response =>
            {
                var listDemoArrayResponse = JsonUtils.DeSerializeNull<ListDemoArrayResponse>(response);
                listDemoArrayResponse.Body = JsonUtils.DeSerializeList<SimpleItem>(response);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, SimpleItem>(response);
            return listDemoMapResponse;
        }

        public AsyncInvoker<ListDemoMapResponse> ListDemoMapAsyncInvoker(ListDemoMapRequest listDemoMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoMapRequest);
            return new AsyncInvoker<ListDemoMapResponse>(this, "GET", request, response =>
            {
                var listDemoMapResponse = JsonUtils.DeSerializeNull<ListDemoMapResponse>(response);
                listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, SimpleItem>(response);
                return listDemoMapResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoObject Test
        /// </summary>
        public async Task<ListDemoObjectResponse> ListDemoObjectAsync(ListDemoObjectRequest listDemoObjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoObjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListDemoObjectResponse>(response);
        }

        public AsyncInvoker<ListDemoObjectResponse> ListDemoObjectAsyncInvoker(ListDemoObjectRequest listDemoObjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoObjectRequest);
            return new AsyncInvoker<ListDemoObjectResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListDemoObjectResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoResources Test
        /// </summary>
        public async Task<ListDemoResourcesResponse> ListDemoResourcesAsync(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDemoResourcesResponse>(response);
        }

        public AsyncInvoker<ListDemoResourcesResponse> ListDemoResourcesAsyncInvoker(ListDemoResourcesRequest listDemoResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoResourcesRequest);
            return new AsyncInvoker<ListDemoResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDemoResourcesResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoString Test
        /// </summary>
        public async Task<ListDemoStringResponse> ListDemoStringAsync(ListDemoStringRequest listDemoStringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoStringRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListDemoStringResponse>(response);
        }

        public AsyncInvoker<ListDemoStringResponse> ListDemoStringAsyncInvoker(ListDemoStringRequest listDemoStringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoStringRequest);
            return new AsyncInvoker<ListDemoStringResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListDemoStringResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListObjectArray Test
        /// </summary>
        public async Task<ListObjectArrayResponse> ListObjectArrayAsync(ListObjectArrayRequest listObjectArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectArrayRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listObjectArrayResponse = JsonUtils.DeSerializeNull<ListObjectArrayResponse>(response);
            listObjectArrayResponse.Body = JsonUtils.DeSerializeList<Object>(response);
            return listObjectArrayResponse;
        }

        public AsyncInvoker<ListObjectArrayResponse> ListObjectArrayAsyncInvoker(ListObjectArrayRequest listObjectArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectArrayRequest);
            return new AsyncInvoker<ListObjectArrayResponse>(this, "GET", request, response =>
            {
                var listObjectArrayResponse = JsonUtils.DeSerializeNull<ListObjectArrayResponse>(response);
                listObjectArrayResponse.Body = JsonUtils.DeSerializeList<Object>(response);
                return listObjectArrayResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListObjectMap Test
        /// </summary>
        public async Task<ListObjectMapResponse> ListObjectMapAsync(ListObjectMapRequest listObjectMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectMapRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listObjectMapResponse = JsonUtils.DeSerializeNull<ListObjectMapResponse>(response);
            listObjectMapResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
            return listObjectMapResponse;
        }

        public AsyncInvoker<ListObjectMapResponse> ListObjectMapAsyncInvoker(ListObjectMapRequest listObjectMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectMapRequest);
            return new AsyncInvoker<ListObjectMapResponse>(this, "GET", request, response =>
            {
                var listObjectMapResponse = JsonUtils.DeSerializeNull<ListObjectMapResponse>(response);
                listObjectMapResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
                return listObjectMapResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListStringArray Test
        /// </summary>
        public async Task<ListStringArrayResponse> ListStringArrayAsync(ListStringArrayRequest listStringArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringArrayRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listStringArrayResponse = JsonUtils.DeSerializeNull<ListStringArrayResponse>(response);
            listStringArrayResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listStringArrayResponse;
        }

        public AsyncInvoker<ListStringArrayResponse> ListStringArrayAsyncInvoker(ListStringArrayRequest listStringArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringArrayRequest);
            return new AsyncInvoker<ListStringArrayResponse>(this, "GET", request, response =>
            {
                var listStringArrayResponse = JsonUtils.DeSerializeNull<ListStringArrayResponse>(response);
                listStringArrayResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listStringArrayResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListStringMap Test
        /// </summary>
        public async Task<ListStringMapResponse> ListStringMapAsync(ListStringMapRequest listStringMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringMapRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listStringMapResponse = JsonUtils.DeSerializeNull<ListStringMapResponse>(response);
            listStringMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listStringMapResponse;
        }

        public AsyncInvoker<ListStringMapResponse> ListStringMapAsyncInvoker(ListStringMapRequest listStringMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringMapRequest);
            return new AsyncInvoker<ListStringMapResponse>(this, "GET", request, response =>
            {
                var listStringMapResponse = JsonUtils.DeSerializeNull<ListStringMapResponse>(response);
                listStringMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
                return listStringMapResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// Upload download demo
        /// </summary>
        public async Task<UploadDownloadDemoResponse> UploadDownloadDemoAsync(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/octet-stream", uploadDownloadDemoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadDownloadDemoResponse>(response);
        }

        public AsyncInvoker<UploadDownloadDemoResponse> UploadDownloadDemoAsyncInvoker(UploadDownloadDemoRequest uploadDownloadDemoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uploaddownload", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadMultipartResponse>(response);
        }

        public AsyncInvoker<UploadMultipartResponse> UploadMultipartAsyncInvoker(UploadMultipartRequest uploadMultipartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadMultipartRequest);
            return new AsyncInvoker<UploadMultipartResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadMultipartResponse>);
        }
        
    }
}