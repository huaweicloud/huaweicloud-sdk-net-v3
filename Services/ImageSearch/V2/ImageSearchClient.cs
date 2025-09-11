using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ImageSearch.V2.Model;

namespace HuaweiCloud.SDK.ImageSearch.V2
{
    public partial class ImageSearchClient : Client
    {
        public static ClientBuilder<ImageSearchClient> NewBuilder()
        {
            return new ClientBuilder<ImageSearchClient>();
        }

        
        /// <summary>
        /// 添加数据
        ///
        /// 添加数据到指定服务实例中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunAddDataResponse RunAddData(RunAddDataRequest runAddDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAddDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAddDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunAddDataResponse>(response);
        }

        public SyncInvoker<RunAddDataResponse> RunAddDataInvoker(RunAddDataRequest runAddDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAddDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAddDataRequest);
            return new SyncInvoker<RunAddDataResponse>(this, "POST", request, JsonUtils.DeSerialize<RunAddDataResponse>);
        }
        
        /// <summary>
        /// 检查数据
        ///
        /// 检查指定服务实例中的对应数据，支持指定ID检查和条件检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCheckDataResponse RunCheckData(RunCheckDataRequest runCheckDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runCheckDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCheckDataResponse>(response);
        }

        public SyncInvoker<RunCheckDataResponse> RunCheckDataInvoker(RunCheckDataRequest runCheckDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runCheckDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckDataRequest);
            return new SyncInvoker<RunCheckDataResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCheckDataResponse>);
        }
        
        /// <summary>
        /// 删除数据
        ///
        /// 删除指定服务实例中的对应数据，支持指定ID删除和条件删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunDeleteDataResponse RunDeleteData(RunDeleteDataRequest runDeleteDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runDeleteDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunDeleteDataResponse>(response);
        }

        public SyncInvoker<RunDeleteDataResponse> RunDeleteDataInvoker(RunDeleteDataRequest runDeleteDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runDeleteDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteDataRequest);
            return new SyncInvoker<RunDeleteDataResponse>(this, "POST", request, JsonUtils.DeSerialize<RunDeleteDataResponse>);
        }
        
        /// <summary>
        /// 搜索
        ///
        /// 从指定服务实例中进行搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunSearchResponse RunSearch(RunSearchRequest runSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runSearchRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runSearchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunSearchResponse>(response);
        }

        public SyncInvoker<RunSearchResponse> RunSearchInvoker(RunSearchRequest runSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runSearchRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runSearchRequest);
            return new SyncInvoker<RunSearchResponse>(this, "POST", request, JsonUtils.DeSerialize<RunSearchResponse>);
        }
        
        /// <summary>
        /// 更新数据
        ///
        /// 更新指定服务实例中的对应数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunUpdateDataResponse RunUpdateData(RunUpdateDataRequest runUpdateDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runUpdateDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runUpdateDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunUpdateDataResponse>(response);
        }

        public SyncInvoker<RunUpdateDataResponse> RunUpdateDataInvoker(RunUpdateDataRequest runUpdateDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runUpdateDataRequest.ServiceName, out var valueOfServiceName)) urlParam.Add("service_name", valueOfServiceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runUpdateDataRequest);
            return new SyncInvoker<RunUpdateDataResponse>(this, "POST", request, JsonUtils.DeSerialize<RunUpdateDataResponse>);
        }
        
    }
}