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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAppDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAppRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps-count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppCountRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppCountResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAppRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/apps/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , enableSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}/active",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<EnableSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSignatureDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSignatureDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSignatureFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSignatureFileResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateSignatureRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/signatures/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSignatureResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/upload-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadSignatureFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadSignatureFileResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/country",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSendCountryDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<ListTemplateDetailsResponse> ListTemplateDetailsAsync(ListTemplateDetailsRequest listTemplateDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , listTemplateVarilableDetailsRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}/varilable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVarilableDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateVarilableDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateTemplateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/msgsms/templates/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTemplateResponse>(response);
        }
        
    }
}