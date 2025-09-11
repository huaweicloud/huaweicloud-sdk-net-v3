using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Msgsms.V2.Model;

namespace HuaweiCloud.SDK.Msgsms.V2
{
    public partial class MsgsmsClient : Client
    {
        public static ClientBuilder<MsgsmsClient> NewBuilder()
        {
            return new ClientBuilder<MsgsmsClient>();
        }

        
        /// <summary>
        /// 创建短信应用
        ///
        /// 该接口用于用户创建应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public SyncInvoker<CreateAppResponse> CreateAppInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new SyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 查询短信应用
        ///
        /// 该接口用于用户查询已创建的应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppDetailsResponse ListAppDetails(ListAppDetailsRequest listAppDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppDetailsResponse>(response);
        }

        public SyncInvoker<ListAppDetailsResponse> ListAppDetailsInvoker(ListAppDetailsRequest listAppDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            return new SyncInvoker<ListAppDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppDetailsResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 该接口用于用户查询应用详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppResponse ShowApp(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public SyncInvoker<ShowAppResponse> ShowAppInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new SyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 查询应用数量
        ///
        /// 该接口用于用户查询应用使用的数量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppCountResponse ShowAppCount(ShowAppCountRequest showAppCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppCountResponse>(response);
        }

        public SyncInvoker<ShowAppCountResponse> ShowAppCountInvoker(ShowAppCountRequest showAppCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            return new SyncInvoker<ShowAppCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppCountResponse>);
        }
        
        /// <summary>
        /// 修改短信应用
        ///
        /// 该接口用于用户修改应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppResponse UpdateApp(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
        }

        public SyncInvoker<UpdateAppResponse> UpdateAppInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new SyncInvoker<UpdateAppResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 创建短信签名
        ///
        /// 该接口用于用户创建签名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSignatureResponse CreateSignature(CreateSignatureRequest createSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSignatureResponse>(response);
        }

        public SyncInvoker<CreateSignatureResponse> CreateSignatureInvoker(CreateSignatureRequest createSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            return new SyncInvoker<CreateSignatureResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSignatureResponse>);
        }
        
        /// <summary>
        /// 删除短信签名
        ///
        /// 该接口用于用户删除已创建的签名信息息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSignatureResponse DeleteSignature(DeleteSignatureRequest deleteSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSignatureResponse>(response);
        }

        public SyncInvoker<DeleteSignatureResponse> DeleteSignatureInvoker(DeleteSignatureRequest deleteSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            return new SyncInvoker<DeleteSignatureResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSignatureResponse>);
        }
        
        /// <summary>
        /// 申请激活签名
        ///
        /// 该接口用于用户申请激活签名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableSignatureResponse EnableSignature(EnableSignatureRequest enableSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<EnableSignatureResponse>(response);
        }

        public SyncInvoker<EnableSignatureResponse> EnableSignatureInvoker(EnableSignatureRequest enableSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            return new SyncInvoker<EnableSignatureResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<EnableSignatureResponse>);
        }
        
        /// <summary>
        /// 查询签名信息
        ///
        /// 该接口用于用户查询已创建的短信签名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSignatureDetailsResponse ListSignatureDetails(ListSignatureDetailsRequest listSignatureDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSignatureDetailsResponse>(response);
        }

        public SyncInvoker<ListSignatureDetailsResponse> ListSignatureDetailsInvoker(ListSignatureDetailsRequest listSignatureDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            return new SyncInvoker<ListSignatureDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSignatureDetailsResponse>);
        }
        
        /// <summary>
        /// 获取签名详情
        ///
        /// 该接口用于用户查询签名详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSignatureResponse ShowSignature(ShowSignatureRequest showSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSignatureResponse>(response);
        }

        public SyncInvoker<ShowSignatureResponse> ShowSignatureInvoker(ShowSignatureRequest showSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            return new SyncInvoker<ShowSignatureResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSignatureResponse>);
        }
        
        /// <summary>
        /// 查询申请文件
        ///
        /// 该接口用于用户查询上传的文件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSignatureFileResponse ShowSignatureFile(ShowSignatureFileRequest showSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSignatureFileResponse>(response);
        }

        public SyncInvoker<ShowSignatureFileResponse> ShowSignatureFileInvoker(ShowSignatureFileRequest showSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            return new SyncInvoker<ShowSignatureFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSignatureFileResponse>);
        }
        
        /// <summary>
        /// 修改短信签名
        ///
        /// 该接口用于用户更新签名信息，目前仅支持审核不通过的短信签名重新修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSignatureResponse UpdateSignature(UpdateSignatureRequest updateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSignatureResponse>(response);
        }

        public SyncInvoker<UpdateSignatureResponse> UpdateSignatureInvoker(UpdateSignatureRequest updateSignatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSignatureRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            return new SyncInvoker<UpdateSignatureResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSignatureResponse>);
        }
        
        /// <summary>
        /// 上传申请文件
        ///
        /// 该接口用于用户上传文件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadSignatureFileResponse UploadSignatureFile(UploadSignatureFileRequest uploadSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadSignatureFileResponse>(response);
        }

        public SyncInvoker<UploadSignatureFileResponse> UploadSignatureFileInvoker(UploadSignatureFileRequest uploadSignatureFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            return new SyncInvoker<UploadSignatureFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadSignatureFileResponse>);
        }
        
        /// <summary>
        /// 创建短信模板
        ///
        /// 该接口用于用户创建模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
        }

        public SyncInvoker<CreateTemplateResponse> CreateTemplateInvoker(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            return new SyncInvoker<CreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateResponse>);
        }
        
        /// <summary>
        /// 删除短信模板
        ///
        /// 该接口用于用户删除已创建的模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }

        public SyncInvoker<DeleteTemplateResponse> DeleteTemplateInvoker(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            return new SyncInvoker<DeleteTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateResponse>);
        }
        
        /// <summary>
        /// 查询发送国家
        ///
        /// 该接口用于用户查询短信发送的国家信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSendCountryDetailsResponse ListSendCountryDetails(ListSendCountryDetailsRequest listSendCountryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSendCountryDetailsResponse = JsonUtils.DeSerializeNull<ListSendCountryDetailsResponse>(response);
            listSendCountryDetailsResponse.Body = JsonUtils.DeSerializeList<SmsCountryResp>(response);
            return listSendCountryDetailsResponse;
        }

        public SyncInvoker<ListSendCountryDetailsResponse> ListSendCountryDetailsInvoker(ListSendCountryDetailsRequest listSendCountryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            return new SyncInvoker<ListSendCountryDetailsResponse>(this, "GET", request, response =>
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
        public ListTemplateDetailsResponse ListTemplateDetails(ListTemplateDetailsRequest listTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateDetailsResponse>(response);
        }

        public SyncInvoker<ListTemplateDetailsResponse> ListTemplateDetailsInvoker(ListTemplateDetailsRequest listTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            return new SyncInvoker<ListTemplateDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateDetailsResponse>);
        }
        
        /// <summary>
        /// 查询模板变量
        ///
        /// 该接口用于用户查询模板参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateVarilableDetailsResponse ListTemplateVarilableDetails(ListTemplateVarilableDetailsRequest listTemplateVarilableDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateVarilableDetailsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>(response);
        }

        public SyncInvoker<ListTemplateVarilableDetailsResponse> ListTemplateVarilableDetailsInvoker(ListTemplateVarilableDetailsRequest listTemplateVarilableDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateVarilableDetailsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            return new SyncInvoker<ListTemplateVarilableDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>);
        }
        
        /// <summary>
        /// 获取模板详情
        ///
        /// 该接口用于用户查询已创建的模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTemplateResponse ShowTemplate(ShowTemplateRequest showTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateResponse>(response);
        }

        public SyncInvoker<ShowTemplateResponse> ShowTemplateInvoker(ShowTemplateRequest showTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            return new SyncInvoker<ShowTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateResponse>);
        }
        
        /// <summary>
        /// 修改短信模板
        ///
        /// 该接口用于用户修改模板信息，目前仅支持审核不通过的短信模板重新修改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest updateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTemplateResponse>(response);
        }

        public SyncInvoker<UpdateTemplateResponse> UpdateTemplateInvoker(UpdateTemplateRequest updateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            return new SyncInvoker<UpdateTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTemplateResponse>);
        }
        
    }
}