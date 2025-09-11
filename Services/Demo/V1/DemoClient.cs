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
            if (StringUtils.TryConvertToNonEmptyString(deleteDemoResourceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/demo/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDemoResourceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDemoResourceResponse>(response);
        }

        public SyncInvoker<DeleteDemoResourceResponse> DeleteDemoResourceInvoker(DeleteDemoResourceRequest deleteDemoResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDemoResourceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
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
            listDemoArrayResponse.Body = JsonUtils.DeSerializeList<SimpleItem>(response);
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
                listDemoArrayResponse.Body = JsonUtils.DeSerializeList<SimpleItem>(response);
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
            listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, SimpleItem>(response);
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
                listDemoMapResponse.Body = JsonUtils.DeSerializeMap<string, SimpleItem>(response);
                return listDemoMapResponse;
            });
        }
        
        /// <summary>
        /// demo
        ///
        /// ListDemoObject Test
        /// </summary>
        public ListDemoObjectResponse ListDemoObject(ListDemoObjectRequest listDemoObjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoObjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListDemoObjectResponse>(response);
        }

        public SyncInvoker<ListDemoObjectResponse> ListDemoObjectInvoker(ListDemoObjectRequest listDemoObjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoObjectRequest);
            return new SyncInvoker<ListDemoObjectResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListDemoObjectResponse>);
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
        /// ListDemoString Test
        /// </summary>
        public ListDemoStringResponse ListDemoString(ListDemoStringRequest listDemoStringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoStringRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListDemoStringResponse>(response);
        }

        public SyncInvoker<ListDemoStringResponse> ListDemoStringInvoker(ListDemoStringRequest listDemoStringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDemoStringRequest);
            return new SyncInvoker<ListDemoStringResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListDemoStringResponse>);
        }
        
        /// <summary>
        /// demo
        ///
        /// ListObjectArray Test
        /// </summary>
        public ListObjectArrayResponse ListObjectArray(ListObjectArrayRequest listObjectArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectArrayRequest);
            var response = DoHttpRequestSync("GET", request);
            var listObjectArrayResponse = JsonUtils.DeSerializeNull<ListObjectArrayResponse>(response);
            listObjectArrayResponse.Body = JsonUtils.DeSerializeList<Object>(response);
            return listObjectArrayResponse;
        }

        public SyncInvoker<ListObjectArrayResponse> ListObjectArrayInvoker(ListObjectArrayRequest listObjectArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectArrayRequest);
            return new SyncInvoker<ListObjectArrayResponse>(this, "GET", request, response =>
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
        public ListObjectMapResponse ListObjectMap(ListObjectMapRequest listObjectMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectMapRequest);
            var response = DoHttpRequestSync("GET", request);
            var listObjectMapResponse = JsonUtils.DeSerializeNull<ListObjectMapResponse>(response);
            listObjectMapResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
            return listObjectMapResponse;
        }

        public SyncInvoker<ListObjectMapResponse> ListObjectMapInvoker(ListObjectMapRequest listObjectMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/object_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObjectMapRequest);
            return new SyncInvoker<ListObjectMapResponse>(this, "GET", request, response =>
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
        public ListStringArrayResponse ListStringArray(ListStringArrayRequest listStringArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringArrayRequest);
            var response = DoHttpRequestSync("GET", request);
            var listStringArrayResponse = JsonUtils.DeSerializeNull<ListStringArrayResponse>(response);
            listStringArrayResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listStringArrayResponse;
        }

        public SyncInvoker<ListStringArrayResponse> ListStringArrayInvoker(ListStringArrayRequest listStringArrayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_array", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringArrayRequest);
            return new SyncInvoker<ListStringArrayResponse>(this, "GET", request, response =>
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
        public ListStringMapResponse ListStringMap(ListStringMapRequest listStringMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringMapRequest);
            var response = DoHttpRequestSync("GET", request);
            var listStringMapResponse = JsonUtils.DeSerializeNull<ListStringMapResponse>(response);
            listStringMapResponse.Body = JsonUtils.DeSerializeMap<string, string>(response);
            return listStringMapResponse;
        }

        public SyncInvoker<ListStringMapResponse> ListStringMapInvoker(ListStringMapRequest listStringMapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/string_map", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStringMapRequest);
            return new SyncInvoker<ListStringMapResponse>(this, "GET", request, response =>
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
        
        /// <summary>
        /// Update Something
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWithUrlEncodedResponse UpdateWithUrlEncoded(UpdateWithUrlEncodedRequest updateWithUrlEncodedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/x-www-form-urlencoded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", updateWithUrlEncodedRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWithUrlEncodedResponse>(response);
        }

        public SyncInvoker<UpdateWithUrlEncodedResponse> UpdateWithUrlEncodedInvoker(UpdateWithUrlEncodedRequest updateWithUrlEncodedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/x-www-form-urlencoded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", updateWithUrlEncodedRequest);
            return new SyncInvoker<UpdateWithUrlEncodedResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWithUrlEncodedResponse>);
        }
        
    }
}