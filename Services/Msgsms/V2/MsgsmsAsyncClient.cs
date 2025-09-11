using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Msgsms.V2.Model;

namespace HuaweiCloud.SDK.Msgsms.V2
{
    public partial class MsgsmsAsyncClient : Client
    {
        public static ClientBuilder<MsgsmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<MsgsmsAsyncClient>();
        }

        
        /// <summary>
        /// 创建短信应用
        ///
        /// 该接口用于用户创建应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public AsyncInvoker<CreateAppResponse> CreateAppAsyncInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new AsyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 查询短信应用
        ///
        /// 该接口用于用户查询已创建的应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppDetailsResponse> ListAppDetailsAsync(ListAppDetailsRequest listAppDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppDetailsResponse>(response);
        }

        public AsyncInvoker<ListAppDetailsResponse> ListAppDetailsAsyncInvoker(ListAppDetailsRequest listAppDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            return new AsyncInvoker<ListAppDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppDetailsResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 该接口用于用户查询应用详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppResponse> ShowAppAsync(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public AsyncInvoker<ShowAppResponse> ShowAppAsyncInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new AsyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 查询应用数量
        ///
        /// 该接口用于用户查询应用使用的数量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppCountResponse> ShowAppCountAsync(ShowAppCountRequest showAppCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppCountResponse>(response);
        }

        public AsyncInvoker<ShowAppCountResponse> ShowAppCountAsyncInvoker(ShowAppCountRequest showAppCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            return new AsyncInvoker<ShowAppCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppCountResponse>);
        }
        
        /// <summary>
        /// 修改短信应用
        ///
        /// 该接口用于用户修改应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
        }

        public AsyncInvoker<UpdateAppResponse> UpdateAppAsyncInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new AsyncInvoker<UpdateAppResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 创建短信签名
        ///
        /// 该接口用于用户创建签名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSignatureResponse> CreateSignatureAsync(CreateSignatureRequest createSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSignatureResponse>(response);
        }

        public AsyncInvoker<CreateSignatureResponse> CreateSignatureAsyncInvoker(CreateSignatureRequest createSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            return new AsyncInvoker<CreateSignatureResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSignatureResponse>);
        }
        
        /// <summary>
        /// 删除短信签名
        ///
        /// 该接口用于用户删除已创建的签名信息息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSignatureResponse> DeleteSignatureAsync(DeleteSignatureRequest deleteSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSignatureResponse>(response);
        }

        public AsyncInvoker<DeleteSignatureResponse> DeleteSignatureAsyncInvoker(DeleteSignatureRequest deleteSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            return new AsyncInvoker<DeleteSignatureResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSignatureResponse>);
        }
        
        /// <summary>
        /// 申请激活签名
        ///
        /// 该接口用于用户申请激活签名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableSignatureResponse> EnableSignatureAsync(EnableSignatureRequest enableSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<EnableSignatureResponse>(response);
        }

        public AsyncInvoker<EnableSignatureResponse> EnableSignatureAsyncInvoker(EnableSignatureRequest enableSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            return new AsyncInvoker<EnableSignatureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<EnableSignatureResponse>);
        }
        
        /// <summary>
        /// 查询签名信息
        ///
        /// 该接口用于用户查询已创建的短信签名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSignatureDetailsResponse> ListSignatureDetailsAsync(ListSignatureDetailsRequest listSignatureDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSignatureDetailsResponse>(response);
        }

        public AsyncInvoker<ListSignatureDetailsResponse> ListSignatureDetailsAsyncInvoker(ListSignatureDetailsRequest listSignatureDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            return new AsyncInvoker<ListSignatureDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSignatureDetailsResponse>);
        }
        
        /// <summary>
        /// 获取签名详情
        ///
        /// 该接口用于用户查询签名详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSignatureResponse> ShowSignatureAsync(ShowSignatureRequest showSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSignatureResponse>(response);
        }

        public AsyncInvoker<ShowSignatureResponse> ShowSignatureAsyncInvoker(ShowSignatureRequest showSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            return new AsyncInvoker<ShowSignatureResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSignatureResponse>);
        }
        
        /// <summary>
        /// 查询申请文件
        ///
        /// 该接口用于用户查询上传的文件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSignatureFileResponse> ShowSignatureFileAsync(ShowSignatureFileRequest showSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSignatureFileResponse>(response);
        }

        public AsyncInvoker<ShowSignatureFileResponse> ShowSignatureFileAsyncInvoker(ShowSignatureFileRequest showSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            return new AsyncInvoker<ShowSignatureFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSignatureFileResponse>);
        }
        
        /// <summary>
        /// 修改短信签名
        ///
        /// 该接口用于用户更新签名信息，目前仅支持审核不通过的短信签名重新修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSignatureResponse> UpdateSignatureAsync(UpdateSignatureRequest updateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSignatureResponse>(response);
        }

        public AsyncInvoker<UpdateSignatureResponse> UpdateSignatureAsyncInvoker(UpdateSignatureRequest updateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            return new AsyncInvoker<UpdateSignatureResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSignatureResponse>);
        }
        
        /// <summary>
        /// 上传申请文件
        ///
        /// 该接口用于用户上传文件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadSignatureFileResponse> UploadSignatureFileAsync(UploadSignatureFileRequest uploadSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadSignatureFileResponse>(response);
        }

        public AsyncInvoker<UploadSignatureFileResponse> UploadSignatureFileAsyncInvoker(UploadSignatureFileRequest uploadSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            return new AsyncInvoker<UploadSignatureFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadSignatureFileResponse>);
        }
        
        /// <summary>
        /// 创建短信模板
        ///
        /// 该接口用于用户创建模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
        }

        public AsyncInvoker<CreateTemplateResponse> CreateTemplateAsyncInvoker(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            return new AsyncInvoker<CreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateResponse>);
        }
        
        /// <summary>
        /// 删除短信模板
        ///
        /// 该接口用于用户删除已创建的模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteTemplateResponse> DeleteTemplateAsyncInvoker(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            return new AsyncInvoker<DeleteTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateResponse>);
        }
        
        /// <summary>
        /// 查询发送国家
        ///
        /// 该接口用于用户查询短信发送的国家信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSendCountryDetailsResponse> ListSendCountryDetailsAsync(ListSendCountryDetailsRequest listSendCountryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listSendCountryDetailsResponse = JsonUtils.DeSerializeNull<ListSendCountryDetailsResponse>(response);
            listSendCountryDetailsResponse.Body = JsonUtils.DeSerializeList<SmsCountryResp>(response);
            return listSendCountryDetailsResponse;
        }

        public AsyncInvoker<ListSendCountryDetailsResponse> ListSendCountryDetailsAsyncInvoker(ListSendCountryDetailsRequest listSendCountryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            return new AsyncInvoker<ListSendCountryDetailsResponse>(this, "GET", request, response =>
            {
                var listSendCountryDetailsResponse = JsonUtils.DeSerializeNull<ListSendCountryDetailsResponse>(response);
                listSendCountryDetailsResponse.Body = JsonUtils.DeSerializeList<SmsCountryResp>(response);
                return listSendCountryDetailsResponse;
            });
        }
        
        /// <summary>
        /// 查询短信模板
        ///
        /// 该接口用于用户查询已创建的模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateDetailsResponse> ListTemplateDetailsAsync(ListTemplateDetailsRequest listTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateDetailsResponse>(response);
        }

        public AsyncInvoker<ListTemplateDetailsResponse> ListTemplateDetailsAsyncInvoker(ListTemplateDetailsRequest listTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            return new AsyncInvoker<ListTemplateDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateDetailsResponse>);
        }
        
        /// <summary>
        /// 查询模板变量
        ///
        /// 该接口用于用户查询模板参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateVarilableDetailsResponse> ListTemplateVarilableDetailsAsync(ListTemplateVarilableDetailsRequest listTemplateVarilableDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateVarilableDetailsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>(response);
        }

        public AsyncInvoker<ListTemplateVarilableDetailsResponse> ListTemplateVarilableDetailsAsyncInvoker(ListTemplateVarilableDetailsRequest listTemplateVarilableDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateVarilableDetailsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            return new AsyncInvoker<ListTemplateVarilableDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>);
        }
        
        /// <summary>
        /// 获取模板详情
        ///
        /// 该接口用于用户查询已创建的模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateResponse> ShowTemplateAsync(ShowTemplateRequest showTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateResponse>(response);
        }

        public AsyncInvoker<ShowTemplateResponse> ShowTemplateAsyncInvoker(ShowTemplateRequest showTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            return new AsyncInvoker<ShowTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateResponse>);
        }
        
        /// <summary>
        /// 修改短信模板
        ///
        /// 该接口用于用户修改模板信息，目前仅支持审核不通过的短信模板重新修改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest updateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateTemplateResponse> UpdateTemplateAsyncInvoker(UpdateTemplateRequest updateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            return new AsyncInvoker<UpdateTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTemplateResponse>);
        }
        
    }
}