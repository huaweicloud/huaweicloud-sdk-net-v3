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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAppDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAppRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAppCountResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAppRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , enableSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<EnableSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSignatureDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSignatureFileResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadSignatureFileResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListSendCountryDetailsResponse listSendCountryDetailsResponse = JsonUtils.DeSerializeNull<ListSendCountryDetailsResponse>(response);
            listSendCountryDetailsResponse.Body = JsonUtils.DeSerializeList<SmsCountryResp>(response);
            return listSendCountryDetailsResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , listTemplateVarilableDetailsRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTemplateResponse>(response);
        }
        
    }
}