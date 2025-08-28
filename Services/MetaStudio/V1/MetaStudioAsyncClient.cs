using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.MetaStudio.V1.Model;

namespace HuaweiCloud.SDK.MetaStudio.V1
{
    public partial class MetaStudioAsyncClient : Client
    {
        public static ClientBuilder<MetaStudioAsyncClient> NewBuilder()
        {
            return new ClientBuilder<MetaStudioAsyncClient>();
        }

        
        /// <summary>
        /// 创建激活码
        ///
        /// 该接口用于创建激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateActiveCodeResponse> CreateActiveCodeAsync(CreateActiveCodeRequest createActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createActiveCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateActiveCodeResponse>(response);
        }

        public AsyncInvoker<CreateActiveCodeResponse> CreateActiveCodeAsyncInvoker(CreateActiveCodeRequest createActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createActiveCodeRequest);
            return new AsyncInvoker<CreateActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateActiveCodeResponse>);
        }
        
        /// <summary>
        /// 删除激活码
        ///
        /// 该接口用于删除激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteActiveCodeResponse> DeleteActiveCodeAsync(DeleteActiveCodeRequest deleteActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActiveCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteActiveCodeResponse>(response);
        }

        public AsyncInvoker<DeleteActiveCodeResponse> DeleteActiveCodeAsyncInvoker(DeleteActiveCodeRequest deleteActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActiveCodeRequest);
            return new AsyncInvoker<DeleteActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteActiveCodeResponse>);
        }
        
        /// <summary>
        /// 查询激活码列表
        ///
        /// 该接口用于查询激活码列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActiveCodeResponse> ListActiveCodeAsync(ListActiveCodeRequest listActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveCodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListActiveCodeResponse>(response);
        }

        public AsyncInvoker<ListActiveCodeResponse> ListActiveCodeAsyncInvoker(ListActiveCodeRequest listActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveCodeRequest);
            return new AsyncInvoker<ListActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActiveCodeResponse>);
        }
        
        /// <summary>
        /// 重置激活码
        ///
        /// 该接口用于重置激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetActiveCodeResponse> ResetActiveCodeAsync(ResetActiveCodeRequest resetActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", resetActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActiveCodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResetActiveCodeResponse>(response);
        }

        public AsyncInvoker<ResetActiveCodeResponse> ResetActiveCodeAsyncInvoker(ResetActiveCodeRequest resetActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", resetActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActiveCodeRequest);
            return new AsyncInvoker<ResetActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetActiveCodeResponse>);
        }
        
        /// <summary>
        /// 查询激活码详情
        ///
        /// 该接口用于查询激活码详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowActiveCodeResponse> ShowActiveCodeAsync(ShowActiveCodeRequest showActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", showActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActiveCodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActiveCodeResponse>(response);
        }

        public AsyncInvoker<ShowActiveCodeResponse> ShowActiveCodeAsyncInvoker(ShowActiveCodeRequest showActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", showActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActiveCodeRequest);
            return new AsyncInvoker<ShowActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActiveCodeResponse>);
        }
        
        /// <summary>
        /// 修改激活码
        ///
        /// 该接口用于修改激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateActiveCodeResponse> UpdateActiveCodeAsync(UpdateActiveCodeRequest updateActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", updateActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActiveCodeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateActiveCodeResponse>(response);
        }

        public AsyncInvoker<UpdateActiveCodeResponse> UpdateActiveCodeAsyncInvoker(UpdateActiveCodeRequest updateActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", updateActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActiveCodeRequest);
            return new AsyncInvoker<UpdateActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateActiveCodeResponse>);
        }
        
        /// <summary>
        /// 创建委托
        ///
        /// 该接口用于创建委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgencyWithRoleTypeResponse> CreateAgencyWithRoleTypeAsync(CreateAgencyWithRoleTypeRequest createAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", createAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyWithRoleTypeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyWithRoleTypeResponse>(response);
        }

        public AsyncInvoker<CreateAgencyWithRoleTypeResponse> CreateAgencyWithRoleTypeAsyncInvoker(CreateAgencyWithRoleTypeRequest createAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", createAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyWithRoleTypeRequest);
            return new AsyncInvoker<CreateAgencyWithRoleTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyWithRoleTypeResponse>);
        }
        
        /// <summary>
        /// 删除委托
        ///
        /// 该接口用于删除项目下委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAgencyWithRoleTypeResponse> DeleteAgencyWithRoleTypeAsync(DeleteAgencyWithRoleTypeRequest deleteAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", deleteAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyWithRoleTypeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyWithRoleTypeResponse>(response);
        }

        public AsyncInvoker<DeleteAgencyWithRoleTypeResponse> DeleteAgencyWithRoleTypeAsyncInvoker(DeleteAgencyWithRoleTypeRequest deleteAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", deleteAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyWithRoleTypeRequest);
            return new AsyncInvoker<DeleteAgencyWithRoleTypeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyWithRoleTypeResponse>);
        }
        
        /// <summary>
        /// 查询委托
        ///
        /// 该接口用于查询项目下委托
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgencyResponse> ShowAgencyAsync(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public AsyncInvoker<ShowAgencyResponse> ShowAgencyAsyncInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new AsyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
        }
        
        /// <summary>
        /// 创建热词表
        ///
        /// 该接口用于创建热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAsrVocabularyResponse> CreateAsrVocabularyAsync(CreateAsrVocabularyRequest createAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsrVocabularyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAsrVocabularyResponse>(response);
        }

        public AsyncInvoker<CreateAsrVocabularyResponse> CreateAsrVocabularyAsyncInvoker(CreateAsrVocabularyRequest createAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsrVocabularyRequest);
            return new AsyncInvoker<CreateAsrVocabularyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAsrVocabularyResponse>);
        }
        
        /// <summary>
        /// 删除热词表
        ///
        /// 该接口用于删除热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAsrVocabularyResponse> DeleteAsrVocabularyAsync(DeleteAsrVocabularyRequest deleteAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", deleteAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAsrVocabularyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAsrVocabularyResponse>(response);
        }

        public AsyncInvoker<DeleteAsrVocabularyResponse> DeleteAsrVocabularyAsyncInvoker(DeleteAsrVocabularyRequest deleteAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", deleteAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAsrVocabularyRequest);
            return new AsyncInvoker<DeleteAsrVocabularyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAsrVocabularyResponse>);
        }
        
        /// <summary>
        /// 查询热词表列表
        ///
        /// 该接口用于查询热词表列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAsrVocabularyResponse> ListAsrVocabularyAsync(ListAsrVocabularyRequest listAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsrVocabularyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAsrVocabularyResponse>(response);
        }

        public AsyncInvoker<ListAsrVocabularyResponse> ListAsrVocabularyAsyncInvoker(ListAsrVocabularyRequest listAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsrVocabularyRequest);
            return new AsyncInvoker<ListAsrVocabularyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsrVocabularyResponse>);
        }
        
        /// <summary>
        /// 查询热词表详情
        ///
        /// 该接口用于查询热词表详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAsrVocabularyResponse> ShowAsrVocabularyAsync(ShowAsrVocabularyRequest showAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", showAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsrVocabularyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAsrVocabularyResponse>(response);
        }

        public AsyncInvoker<ShowAsrVocabularyResponse> ShowAsrVocabularyAsyncInvoker(ShowAsrVocabularyRequest showAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", showAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsrVocabularyRequest);
            return new AsyncInvoker<ShowAsrVocabularyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsrVocabularyResponse>);
        }
        
        /// <summary>
        /// 查询热词表关联详情
        ///
        /// 该接口用于查询热词表关联详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAsrVocabularyAssociationResponse> ShowAsrVocabularyAssociationAsync(ShowAsrVocabularyAssociationRequest showAsrVocabularyAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", showAsrVocabularyAssociationRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/association/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsrVocabularyAssociationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAsrVocabularyAssociationResponse>(response);
        }

        public AsyncInvoker<ShowAsrVocabularyAssociationResponse> ShowAsrVocabularyAssociationAsyncInvoker(ShowAsrVocabularyAssociationRequest showAsrVocabularyAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", showAsrVocabularyAssociationRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/association/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsrVocabularyAssociationRequest);
            return new AsyncInvoker<ShowAsrVocabularyAssociationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsrVocabularyAssociationResponse>);
        }
        
        /// <summary>
        /// 修改热词表
        ///
        /// 该接口用于修改热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAsrVocabularyResponse> UpdateAsrVocabularyAsync(UpdateAsrVocabularyRequest updateAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", updateAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAsrVocabularyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAsrVocabularyResponse>(response);
        }

        public AsyncInvoker<UpdateAsrVocabularyResponse> UpdateAsrVocabularyAsyncInvoker(UpdateAsrVocabularyRequest updateAsrVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asr_vocabulary_id", updateAsrVocabularyRequest.AsrVocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/asr-vocabulary/{asr_vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAsrVocabularyRequest);
            return new AsyncInvoker<UpdateAsrVocabularyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAsrVocabularyResponse>);
        }
        
        /// <summary>
        /// 删除导入导出任务
        ///
        /// 删除导入导出任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTaskResponse>(response);
        }

        public AsyncInvoker<DeleteTaskResponse> DeleteTaskAsyncInvoker(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            return new AsyncInvoker<DeleteTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTaskResponse>);
        }
        
        /// <summary>
        /// 下载导入或导出的结果文件
        ///
        /// 下载导入或者导出结果文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadResultFileResponse> DownloadResultFileAsync(DownloadResultFileRequest downloadResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", downloadResultFileRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/result/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadResultFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadResultFileResponse>(response);
        }

        public AsyncInvoker<DownloadResultFileResponse> DownloadResultFileAsyncInvoker(DownloadResultFileRequest downloadResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", downloadResultFileRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/result/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadResultFileRequest);
            return new AsyncInvoker<DownloadResultFileResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadResultFileResponse>);
        }
        
        /// <summary>
        /// 下载信息导入模板
        ///
        /// 下载导入模板，返回导入模板文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadTemplateResponse> DownloadTemplateAsync(DownloadTemplateRequest downloadTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", downloadTemplateRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/import/{resource}/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadTemplateResponse>(response);
        }

        public AsyncInvoker<DownloadTemplateResponse> DownloadTemplateAsyncInvoker(DownloadTemplateRequest downloadTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", downloadTemplateRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/import/{resource}/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTemplateRequest);
            return new AsyncInvoker<DownloadTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadTemplateResponse>);
        }
        
        /// <summary>
        /// 导出文件
        ///
        /// 导出文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportResourceResponse> ExportResourceAsync(ExportResourceRequest exportResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", exportResourceRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/export/{resource}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExportResourceResponse>(response);
        }

        public AsyncInvoker<ExportResourceResponse> ExportResourceAsyncInvoker(ExportResourceRequest exportResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", exportResourceRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/export/{resource}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportResourceRequest);
            return new AsyncInvoker<ExportResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportResourceResponse>);
        }
        
        /// <summary>
        /// 导入文件
        ///
        /// 导入文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportResourceResponse> ImportResourceAsync(ImportResourceRequest importResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", importResourceRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/import/{resource}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportResourceResponse>(response);
        }

        public AsyncInvoker<ImportResourceResponse> ImportResourceAsyncInvoker(ImportResourceRequest importResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource", importResourceRequest.Resource.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/import/{resource}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importResourceRequest);
            return new AsyncInvoker<ImportResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportResourceResponse>);
        }
        
        /// <summary>
        /// 分页查询导入导出任务列表
        ///
        /// 分页查询导入导出任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchTaskResponse> SearchTaskAsync(SearchTaskRequest searchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchTaskResponse>(response);
        }

        public AsyncInvoker<SearchTaskResponse> SearchTaskAsyncInvoker(SearchTaskRequest searchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTaskRequest);
            return new AsyncInvoker<SearchTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchTaskResponse>);
        }
        
        /// <summary>
        /// 查询导入导出任务详情
        ///
        /// 查询导入导出任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskResponse> ShowTaskAsync(ShowTaskRequest showTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskResponse>(response);
        }

        public AsyncInvoker<ShowTaskResponse> ShowTaskAsyncInvoker(ShowTaskRequest showTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ies/task/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskRequest);
            return new AsyncInvoker<ShowTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskResponse>);
        }
        
        /// <summary>
        /// 创建对话链接
        ///
        /// 该接口用于创建对话链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDialogUrlResponse> CreateDialogUrlAsync(CreateDialogUrlRequest createDialogUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/create-dialog-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDialogUrlResponse>(response);
        }

        public AsyncInvoker<CreateDialogUrlResponse> CreateDialogUrlAsyncInvoker(CreateDialogUrlRequest createDialogUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/create-dialog-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogUrlRequest);
            return new AsyncInvoker<CreateDialogUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDialogUrlResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能交互任务列表
        ///
        /// 该接口用于查询数字人智能交互任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartChatJobResponse> ListSmartChatJobAsync(ListSmartChatJobRequest listSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartChatJobResponse>(response);
        }

        public AsyncInvoker<ListSmartChatJobResponse> ListSmartChatJobAsyncInvoker(ListSmartChatJobRequest listSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatJobRequest);
            return new AsyncInvoker<ListSmartChatJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能交互任务
        ///
        /// 该接口用于查询数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSmartChatJobResponse> ShowSmartChatJobAsync(ShowSmartChatJobRequest showSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartChatJobResponse>(response);
        }

        public AsyncInvoker<ShowSmartChatJobResponse> ShowSmartChatJobAsyncInvoker(ShowSmartChatJobRequest showSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatJobRequest);
            return new AsyncInvoker<ShowSmartChatJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 启动数字人智能交互任务
        ///
        /// 该接口用于启动数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartSmartChatJobResponse> StartSmartChatJobAsync(StartSmartChatJobRequest startSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartChatJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartSmartChatJobResponse>(response);
        }

        public AsyncInvoker<StartSmartChatJobResponse> StartSmartChatJobAsyncInvoker(StartSmartChatJobRequest startSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartChatJobRequest);
            return new AsyncInvoker<StartSmartChatJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 结束数字人智能交互任务
        ///
        /// 该接口用于结束数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopSmartChatJobResponse> StopSmartChatJobAsync(StopSmartChatJobRequest stopSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartChatJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopSmartChatJobResponse>(response);
        }

        public AsyncInvoker<StopSmartChatJobResponse> StopSmartChatJobAsyncInvoker(StopSmartChatJobRequest stopSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartChatJobRequest);
            return new AsyncInvoker<StopSmartChatJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 创建对话结果上报配置
        ///
        /// 该接口用于创建对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDialogReportConfigResponse> CreateDialogReportConfigAsync(CreateDialogReportConfigRequest createDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogReportConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDialogReportConfigResponse>(response);
        }

        public AsyncInvoker<CreateDialogReportConfigResponse> CreateDialogReportConfigAsyncInvoker(CreateDialogReportConfigRequest createDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogReportConfigRequest);
            return new AsyncInvoker<CreateDialogReportConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 删除对话结果上报配置
        ///
        /// 该接口用于删除对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDialogReportConfigResponse> DeleteDialogReportConfigAsync(DeleteDialogReportConfigRequest deleteDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDialogReportConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDialogReportConfigResponse>(response);
        }

        public AsyncInvoker<DeleteDialogReportConfigResponse> DeleteDialogReportConfigAsyncInvoker(DeleteDialogReportConfigRequest deleteDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDialogReportConfigRequest);
            return new AsyncInvoker<DeleteDialogReportConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 查询对话结果上报配置
        ///
        /// 该接口用于查询对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDialogReportConfigResponse> ShowDialogReportConfigAsync(ShowDialogReportConfigRequest showDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDialogReportConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDialogReportConfigResponse>(response);
        }

        public AsyncInvoker<ShowDialogReportConfigResponse> ShowDialogReportConfigAsyncInvoker(ShowDialogReportConfigRequest showDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDialogReportConfigRequest);
            return new AsyncInvoker<ShowDialogReportConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 修改对话结果上报配置
        ///
        /// 该接口用于修改对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDialogReportConfigResponse> UpdateDialogReportConfigAsync(UpdateDialogReportConfigRequest updateDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDialogReportConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDialogReportConfigResponse>(response);
        }

        public AsyncInvoker<UpdateDialogReportConfigResponse> UpdateDialogReportConfigAsyncInvoker(UpdateDialogReportConfigRequest updateDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDialogReportConfigRequest);
            return new AsyncInvoker<UpdateDialogReportConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 批量资产操作
        ///
        /// 该接口用批量资产操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchExecuteAssetActionResponse> BatchExecuteAssetActionAsync(BatchExecuteAssetActionRequest batchExecuteAssetActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/batch-action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteAssetActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchExecuteAssetActionResponse>(response);
        }

        public AsyncInvoker<BatchExecuteAssetActionResponse> BatchExecuteAssetActionAsyncInvoker(BatchExecuteAssetActionRequest batchExecuteAssetActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/batch-action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteAssetActionRequest);
            return new AsyncInvoker<BatchExecuteAssetActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchExecuteAssetActionResponse>);
        }
        
        /// <summary>
        /// 复制资产
        ///
        /// 该接口用于在Region B复制Region A的指定资产。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAssetByReplicationInfoResponse> CreateAssetByReplicationInfoAsync(CreateAssetByReplicationInfoRequest createAssetByReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets-by-replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByReplicationInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAssetByReplicationInfoResponse>(response);
        }

        public AsyncInvoker<CreateAssetByReplicationInfoResponse> CreateAssetByReplicationInfoAsyncInvoker(CreateAssetByReplicationInfoRequest createAssetByReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets-by-replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByReplicationInfoRequest);
            return new AsyncInvoker<CreateAssetByReplicationInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAssetByReplicationInfoResponse>);
        }
        
        /// <summary>
        /// 创建资产
        ///
        /// 该接口用于在资产库中添加上传新的媒体资产。可上传的资产类型包括：分身数字人模型、背景图片、素材图片、素材视频、PPT等。
        /// &gt; 上传的图片、视频和背景图片，如果需要在视频制作素材中可见，需要设置system_properties。
        /// &gt; - 资产类型是IMAGE时，通过system_properties来区分背景图片（BACKGROUND_IMG）、素材图片（MATERIAL_IMG）。
        /// &gt; - 资产类型是VIDEO时，通过system_properties来区分素材视频（MATERIAL_VIDEO）、名片视频（BUSSINESS_CARD_VIDEO）。
        /// &gt; MetaStudio平台生成的视频，system_properties带CREATED_BY_PLATFORM。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDigitalAssetResponse> CreateDigitalAssetAsync(CreateDigitalAssetRequest createDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalAssetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDigitalAssetResponse>(response);
        }

        public AsyncInvoker<CreateDigitalAssetResponse> CreateDigitalAssetAsyncInvoker(CreateDigitalAssetRequest createDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalAssetRequest);
            return new AsyncInvoker<CreateDigitalAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDigitalAssetResponse>);
        }
        
        /// <summary>
        /// 删除资产
        ///
        /// 该接口用于删除资产库中的媒体资产。调用该接口删除媒体资产时，媒体资产会放入回收站中，不会彻底删除。如需彻底删除资产，需增加“mode&#x3D;force”参数配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", deleteAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAssetResponse>(response);
        }

        public AsyncInvoker<DeleteAssetResponse> DeleteAssetAsyncInvoker(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", deleteAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            return new AsyncInvoker<DeleteAssetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产概要
        ///
        /// 该接口用于查询媒体资产库中指定的多个资产的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssetSummaryResponse> ListAssetSummaryAsync(ListAssetSummaryRequest listAssetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/summarys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetSummaryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAssetSummaryResponse>(response);
        }

        public AsyncInvoker<ListAssetSummaryResponse> ListAssetSummaryAsyncInvoker(ListAssetSummaryRequest listAssetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/summarys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetSummaryRequest);
            return new AsyncInvoker<ListAssetSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAssetSummaryResponse>);
        }
        
        /// <summary>
        /// 查询资产列表
        ///
        /// 该接口用于查询资产库中的媒体资产列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest listAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAssetsResponse>(response);
        }

        public AsyncInvoker<ListAssetsResponse> ListAssetsAsyncInvoker(ListAssetsRequest listAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetsRequest);
            return new AsyncInvoker<ListAssetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssetsResponse>);
        }
        
        /// <summary>
        /// 恢复被删除的资产
        ///
        /// 该接口用于恢复被删除至回收站的媒体资产。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreAssetResponse> RestoreAssetAsync(RestoreAssetRequest restoreAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", restoreAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAssetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RestoreAssetResponse>(response);
        }

        public AsyncInvoker<RestoreAssetResponse> RestoreAssetAsyncInvoker(RestoreAssetRequest restoreAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", restoreAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAssetRequest);
            return new AsyncInvoker<RestoreAssetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RestoreAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产详情
        ///
        /// 该接口用于查询资产库中指定媒体资产的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssetResponse> ShowAssetAsync(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetResponse>(response);
        }

        public AsyncInvoker<ShowAssetResponse> ShowAssetAsyncInvoker(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            return new AsyncInvoker<ShowAssetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产复制信息
        ///
        /// 当需要将资产从A Region复制到B Region时，先要在A Region调用该接口用于查询资产复制信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssetReplicationInfoResponse> ShowAssetReplicationInfoAsync(ShowAssetReplicationInfoRequest showAssetReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetReplicationInfoRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetReplicationInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetReplicationInfoResponse>(response);
        }

        public AsyncInvoker<ShowAssetReplicationInfoResponse> ShowAssetReplicationInfoAsyncInvoker(ShowAssetReplicationInfoRequest showAssetReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetReplicationInfoRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetReplicationInfoRequest);
            return new AsyncInvoker<ShowAssetReplicationInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetReplicationInfoResponse>);
        }
        
        /// <summary>
        /// 更新资产
        ///
        /// 该接口用于更新资产库中的媒体资产信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDigitalAssetResponse> UpdateDigitalAssetAsync(UpdateDigitalAssetRequest updateDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", updateDigitalAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalAssetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDigitalAssetResponse>(response);
        }

        public AsyncInvoker<UpdateDigitalAssetResponse> UpdateDigitalAssetAsyncInvoker(UpdateDigitalAssetRequest updateDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", updateDigitalAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalAssetRequest);
            return new AsyncInvoker<UpdateDigitalAssetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDigitalAssetResponse>);
        }
        
        /// <summary>
        /// 创建数字人名片制作
        ///
        /// 该接口用于数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDigitalHumanBusinessCardResponse> CreateDigitalHumanBusinessCardAsync(CreateDigitalHumanBusinessCardRequest createDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalHumanBusinessCardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDigitalHumanBusinessCardResponse>(response);
        }

        public AsyncInvoker<CreateDigitalHumanBusinessCardResponse> CreateDigitalHumanBusinessCardAsyncInvoker(CreateDigitalHumanBusinessCardRequest createDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalHumanBusinessCardRequest);
            return new AsyncInvoker<CreateDigitalHumanBusinessCardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 删除数字人名片制作任务
        ///
        /// 该接口用于删除数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDigitalHumanBusinessCardResponse> DeleteDigitalHumanBusinessCardAsync(DeleteDigitalHumanBusinessCardRequest deleteDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDigitalHumanBusinessCardRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDigitalHumanBusinessCardResponse>(response);
        }

        public AsyncInvoker<DeleteDigitalHumanBusinessCardResponse> DeleteDigitalHumanBusinessCardAsyncInvoker(DeleteDigitalHumanBusinessCardRequest deleteDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDigitalHumanBusinessCardRequest);
            return new AsyncInvoker<DeleteDigitalHumanBusinessCardResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询数字人名片制作任务列表
        ///
        /// 该接口用于查询数字人名片制作任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDigitalHumanBusinessCardResponse> ListDigitalHumanBusinessCardAsync(ListDigitalHumanBusinessCardRequest listDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanBusinessCardRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDigitalHumanBusinessCardResponse>(response);
        }

        public AsyncInvoker<ListDigitalHumanBusinessCardResponse> ListDigitalHumanBusinessCardAsyncInvoker(ListDigitalHumanBusinessCardRequest listDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanBusinessCardRequest);
            return new AsyncInvoker<ListDigitalHumanBusinessCardResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询数字人名片制作任务详情
        ///
        /// 该接口用于查询数字人名片制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDigitalHumanBusinessCardResponse> ShowDigitalHumanBusinessCardAsync(ShowDigitalHumanBusinessCardRequest showDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDigitalHumanBusinessCardRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDigitalHumanBusinessCardResponse>(response);
        }

        public AsyncInvoker<ShowDigitalHumanBusinessCardResponse> ShowDigitalHumanBusinessCardAsyncInvoker(ShowDigitalHumanBusinessCardRequest showDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDigitalHumanBusinessCardRequest);
            return new AsyncInvoker<ShowDigitalHumanBusinessCardResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 更新数字人名片制作
        ///
        /// 该接口用于更新数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDigitalHumanBusinessCardResponse> UpdateDigitalHumanBusinessCardAsync(UpdateDigitalHumanBusinessCardRequest updateDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalHumanBusinessCardRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDigitalHumanBusinessCardResponse>(response);
        }

        public AsyncInvoker<UpdateDigitalHumanBusinessCardResponse> UpdateDigitalHumanBusinessCardAsyncInvoker(UpdateDigitalHumanBusinessCardRequest updateDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalHumanBusinessCardRequest);
            return new AsyncInvoker<UpdateDigitalHumanBusinessCardResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询视频制作任务列表
        ///
        /// 该接口用于查询视频制作任务列表。可查询分身数字人视频制作列表，照片数字人视频制作列表等。
        /// &gt; - 默认查询最近一个月任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDigitalHumanVideoResponse> ListDigitalHumanVideoAsync(ListDigitalHumanVideoRequest listDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<ListDigitalHumanVideoResponse> ListDigitalHumanVideoAsyncInvoker(ListDigitalHumanVideoRequest listDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanVideoRequest);
            return new AsyncInvoker<ListDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 取消等待中的分身数字人视频制作任务
        ///
        /// 该接口用于取消等待中的分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Cancel2DDigitalHumanVideoResponse> Cancel2DDigitalHumanVideoAsync(Cancel2DDigitalHumanVideoRequest cancel2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancel2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancel2DDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<Cancel2DDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<Cancel2DDigitalHumanVideoResponse> Cancel2DDigitalHumanVideoAsyncInvoker(Cancel2DDigitalHumanVideoRequest cancel2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancel2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancel2DDigitalHumanVideoRequest);
            return new AsyncInvoker<Cancel2DDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<Cancel2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人视频制作任务
        ///
        /// 该接口用于创建分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Create2DDigitalHumanVideoResponse> Create2DDigitalHumanVideoAsync(Create2DDigitalHumanVideoRequest create2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2DDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<Create2DDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<Create2DDigitalHumanVideoResponse> Create2DDigitalHumanVideoAsyncInvoker(Create2DDigitalHumanVideoRequest create2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2DDigitalHumanVideoRequest);
            return new AsyncInvoker<Create2DDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerialize<Create2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人视频制作任务详情
        ///
        /// 该接口用于查询分身数字人视频制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Show2DDigitalHumanVideoResponse> Show2DDigitalHumanVideoAsync(Show2DDigitalHumanVideoRequest show2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2DDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<Show2DDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<Show2DDigitalHumanVideoResponse> Show2DDigitalHumanVideoAsyncInvoker(Show2DDigitalHumanVideoRequest show2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2DDigitalHumanVideoRequest);
            return new AsyncInvoker<Show2DDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<Show2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 取消等待中的照片分身数字人视频制作任务
        ///
        /// 该接口用于取消等待中的照片分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelPhotoDigitalHumanVideoResponse> CancelPhotoDigitalHumanVideoAsync(CancelPhotoDigitalHumanVideoRequest cancelPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelPhotoDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CancelPhotoDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<CancelPhotoDigitalHumanVideoResponse> CancelPhotoDigitalHumanVideoAsyncInvoker(CancelPhotoDigitalHumanVideoRequest cancelPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelPhotoDigitalHumanVideoRequest);
            return new AsyncInvoker<CancelPhotoDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelPhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 创建照片检测任务
        ///
        /// 该接口用于创建照片检测任务，检测照片是否满足制作照片数字人的要求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePhotoDetectionResponse> CreatePhotoDetectionAsync(CreatePhotoDetectionRequest createPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDetectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePhotoDetectionResponse>(response);
        }

        public AsyncInvoker<CreatePhotoDetectionResponse> CreatePhotoDetectionAsyncInvoker(CreatePhotoDetectionRequest createPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDetectionRequest);
            return new AsyncInvoker<CreatePhotoDetectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePhotoDetectionResponse>);
        }
        
        /// <summary>
        /// 创建照片分身数字人视频制作任务
        ///
        /// 该接口用于创建照片分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePhotoDigitalHumanVideoResponse> CreatePhotoDigitalHumanVideoAsync(CreatePhotoDigitalHumanVideoRequest createPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePhotoDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<CreatePhotoDigitalHumanVideoResponse> CreatePhotoDigitalHumanVideoAsyncInvoker(CreatePhotoDigitalHumanVideoRequest createPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDigitalHumanVideoRequest);
            return new AsyncInvoker<CreatePhotoDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 查询照片检测任务详情
        ///
        /// 该接口用于查询照片检测任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPhotoDetectionResponse> ShowPhotoDetectionAsync(ShowPhotoDetectionRequest showPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDetectionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDetectionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPhotoDetectionResponse>(response);
        }

        public AsyncInvoker<ShowPhotoDetectionResponse> ShowPhotoDetectionAsyncInvoker(ShowPhotoDetectionRequest showPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDetectionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDetectionRequest);
            return new AsyncInvoker<ShowPhotoDetectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhotoDetectionResponse>);
        }
        
        /// <summary>
        /// 查询照片分身数字人视频制作任务详情
        ///
        /// 该接口用于查询照片分身数字人视频制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPhotoDigitalHumanVideoResponse> ShowPhotoDigitalHumanVideoAsync(ShowPhotoDigitalHumanVideoRequest showPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDigitalHumanVideoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPhotoDigitalHumanVideoResponse>(response);
        }

        public AsyncInvoker<ShowPhotoDigitalHumanVideoResponse> ShowPhotoDigitalHumanVideoAsyncInvoker(ShowPhotoDigitalHumanVideoRequest showPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDigitalHumanVideoRequest);
            return new AsyncInvoker<ShowPhotoDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 上传文档
        ///
        /// 该接口用于上传文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest createDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createDocumentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDocumentResponse>(response);
        }

        public AsyncInvoker<CreateDocumentResponse> CreateDocumentAsyncInvoker(CreateDocumentRequest createDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createDocumentRequest);
            return new AsyncInvoker<CreateDocumentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDocumentResponse>);
        }
        
        /// <summary>
        /// 批量删除文档
        ///
        /// 该接口用于批量删除文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest deleteDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDocumentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteDocumentResponse>(response);
        }

        public AsyncInvoker<DeleteDocumentResponse> DeleteDocumentAsyncInvoker(DeleteDocumentRequest deleteDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDocumentRequest);
            return new AsyncInvoker<DeleteDocumentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteDocumentResponse>);
        }
        
        /// <summary>
        /// 下载文档
        ///
        /// 该接口用于下载文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadDocumentResponse> DownloadDocumentAsync(DownloadDocumentRequest downloadDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", downloadDocumentRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDocumentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadDocumentResponse>(response);
        }

        public AsyncInvoker<DownloadDocumentResponse> DownloadDocumentAsyncInvoker(DownloadDocumentRequest downloadDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", downloadDocumentRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDocumentRequest);
            return new AsyncInvoker<DownloadDocumentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadDocumentResponse>);
        }
        
        /// <summary>
        /// 查询文档列表
        ///
        /// 该接口用于分页查询文档列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDocumentInfoResponse> ListDocumentInfoAsync(ListDocumentInfoRequest listDocumentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDocumentInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDocumentInfoResponse>(response);
        }

        public AsyncInvoker<ListDocumentInfoResponse> ListDocumentInfoAsyncInvoker(ListDocumentInfoRequest listDocumentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDocumentInfoRequest);
            return new AsyncInvoker<ListDocumentInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDocumentInfoResponse>);
        }
        
        /// <summary>
        /// 查询文档详情
        ///
        /// 该接口用于查询文档详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDocumentInfoResponse> ShowDocumentInfoAsync(ShowDocumentInfoRequest showDocumentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", showDocumentInfoRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/detail/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDocumentInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDocumentInfoResponse>(response);
        }

        public AsyncInvoker<ShowDocumentInfoResponse> ShowDocumentInfoAsyncInvoker(ShowDocumentInfoRequest showDocumentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", showDocumentInfoRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/detail/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDocumentInfoRequest);
            return new AsyncInvoker<ShowDocumentInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDocumentInfoResponse>);
        }
        
        /// <summary>
        /// 修改文档
        ///
        /// 该接口用于修改文档
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest updateDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", updateDocumentRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/update/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateDocumentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateDocumentResponse>(response);
        }

        public AsyncInvoker<UpdateDocumentResponse> UpdateDocumentAsyncInvoker(UpdateDocumentRequest updateDocumentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", updateDocumentRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document/update/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", updateDocumentRequest);
            return new AsyncInvoker<UpdateDocumentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateDocumentResponse>);
        }
        
        /// <summary>
        /// 分页查询文档分段信息
        ///
        /// 该接口用于分页查询文档分段信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDocumentSegmentResponse> ListDocumentSegmentAsync(ListDocumentSegmentRequest listDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDocumentSegmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDocumentSegmentResponse>(response);
        }

        public AsyncInvoker<ListDocumentSegmentResponse> ListDocumentSegmentAsyncInvoker(ListDocumentSegmentRequest listDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDocumentSegmentRequest);
            return new AsyncInvoker<ListDocumentSegmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDocumentSegmentResponse>);
        }
        
        /// <summary>
        /// 文档分段效果预览
        ///
        /// 该接口用于文档分段效果预览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PreviewDocumentSegmentResponse> PreviewDocumentSegmentAsync(PreviewDocumentSegmentRequest previewDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/preview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", previewDocumentSegmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var previewDocumentSegmentResponse = JsonUtils.DeSerializeNull<PreviewDocumentSegmentResponse>(response);
            previewDocumentSegmentResponse.Body = JsonUtils.DeSerializeList<DocumentSegmentInfo>(response);
            return previewDocumentSegmentResponse;
        }

        public AsyncInvoker<PreviewDocumentSegmentResponse> PreviewDocumentSegmentAsyncInvoker(PreviewDocumentSegmentRequest previewDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/preview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", previewDocumentSegmentRequest);
            return new AsyncInvoker<PreviewDocumentSegmentResponse>(this, "POST", request, response =>
            {
                var previewDocumentSegmentResponse = JsonUtils.DeSerializeNull<PreviewDocumentSegmentResponse>(response);
                previewDocumentSegmentResponse.Body = JsonUtils.DeSerializeList<DocumentSegmentInfo>(response);
                return previewDocumentSegmentResponse;
            });
        }
        
        /// <summary>
        /// 开始文档分段
        ///
        /// 该接口用于开始文档分段任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDocumentSegmentResponse> StartDocumentSegmentAsync(StartDocumentSegmentRequest startDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDocumentSegmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StartDocumentSegmentResponse>(response);
        }

        public AsyncInvoker<StartDocumentSegmentResponse> StartDocumentSegmentAsyncInvoker(StartDocumentSegmentRequest startDocumentSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDocumentSegmentRequest);
            return new AsyncInvoker<StartDocumentSegmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StartDocumentSegmentResponse>);
        }
        
        /// <summary>
        /// 修改文档分段内容
        ///
        /// 该接口用于文档分段内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDocumentSegmentInfoResponse> UpdateDocumentSegmentInfoAsync(UpdateDocumentSegmentInfoRequest updateDocumentSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDocumentSegmentInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateDocumentSegmentInfoResponse>(response);
        }

        public AsyncInvoker<UpdateDocumentSegmentInfoResponse> UpdateDocumentSegmentInfoAsyncInvoker(UpdateDocumentSegmentInfoRequest updateDocumentSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDocumentSegmentInfoRequest);
            return new AsyncInvoker<UpdateDocumentSegmentInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateDocumentSegmentInfoResponse>);
        }
        
        /// <summary>
        /// 更新文档分段配置
        ///
        /// 该接口用于更新文档分段配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDocumentSegmentParamResponse> UpdateDocumentSegmentParamAsync(UpdateDocumentSegmentParamRequest updateDocumentSegmentParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", updateDocumentSegmentParamRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDocumentSegmentParamRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDocumentSegmentParamResponse>(response);
        }

        public AsyncInvoker<UpdateDocumentSegmentParamResponse> UpdateDocumentSegmentParamAsyncInvoker(UpdateDocumentSegmentParamRequest updateDocumentSegmentParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("document_id", updateDocumentSegmentParamRequest.DocumentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/document-segment/{document_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDocumentSegmentParamRequest);
            return new AsyncInvoker<UpdateDocumentSegmentParamResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDocumentSegmentParamResponse>);
        }
        
        /// <summary>
        /// 确认文件已上传
        ///
        /// 资产文件上传完毕后，通过该接口确认上传完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmFileUploadResponse> ConfirmFileUploadAsync(ConfirmFileUploadRequest confirmFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", confirmFileUploadRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}/complete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmFileUploadRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ConfirmFileUploadResponse>(response);
        }

        public AsyncInvoker<ConfirmFileUploadResponse> ConfirmFileUploadAsyncInvoker(ConfirmFileUploadRequest confirmFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", confirmFileUploadRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}/complete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmFileUploadRequest);
            return new AsyncInvoker<ConfirmFileUploadResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ConfirmFileUploadResponse>);
        }
        
        /// <summary>
        /// 创建文件并获取上传URL
        ///
        /// 该接口用于创建文件并获取上传URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFileResponse>(response);
        }

        public AsyncInvoker<CreateFileResponse> CreateFileAsyncInvoker(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            return new AsyncInvoker<CreateFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFileResponse>);
        }
        
        /// <summary>
        /// 创建大文件
        ///
        /// 该接口用于创建大文件（超过5G），获取分段上传URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLargeFileResponse> CreateLargeFileAsync(CreateLargeFileRequest createLargeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/large-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLargeFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLargeFileResponse>(response);
        }

        public AsyncInvoker<CreateLargeFileResponse> CreateLargeFileAsyncInvoker(CreateLargeFileRequest createLargeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/large-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLargeFileRequest);
            return new AsyncInvoker<CreateLargeFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLargeFileResponse>);
        }
        
        /// <summary>
        /// 删除文件
        ///
        /// 该接口用于删除媒体资产库中指定的文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFileResponse>(response);
        }

        public AsyncInvoker<DeleteFileResponse> DeleteFileAsyncInvoker(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            return new AsyncInvoker<DeleteFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFileResponse>);
        }
        
        /// <summary>
        /// 创建热点问题
        ///
        /// 该接口用于创建热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHotQuestionResponse> CreateHotQuestionAsync(CreateHotQuestionRequest createHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHotQuestionResponse>(response);
        }

        public AsyncInvoker<CreateHotQuestionResponse> CreateHotQuestionAsyncInvoker(CreateHotQuestionRequest createHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotQuestionRequest);
            return new AsyncInvoker<CreateHotQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotQuestionResponse>);
        }
        
        /// <summary>
        /// 删除热点问题
        ///
        /// 该接口用于删除热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHotQuestionResponse> DeleteHotQuestionAsync(DeleteHotQuestionRequest deleteHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteHotQuestionResponse>(response);
        }

        public AsyncInvoker<DeleteHotQuestionResponse> DeleteHotQuestionAsyncInvoker(DeleteHotQuestionRequest deleteHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotQuestionRequest);
            return new AsyncInvoker<DeleteHotQuestionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteHotQuestionResponse>);
        }
        
        /// <summary>
        /// 查询热点问题列表
        ///
        /// 该接口用于查询热点问题列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHotQuestionResponse> ListHotQuestionAsync(ListHotQuestionRequest listHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotQuestionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHotQuestionResponse>(response);
        }

        public AsyncInvoker<ListHotQuestionResponse> ListHotQuestionAsyncInvoker(ListHotQuestionRequest listHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotQuestionRequest);
            return new AsyncInvoker<ListHotQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotQuestionResponse>);
        }
        
        /// <summary>
        /// 查询热点问题详情
        ///
        /// 该接口用于查询热点问题详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHotQuestionResponse> ShowHotQuestionAsync(ShowHotQuestionRequest showHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", showHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotQuestionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHotQuestionResponse>(response);
        }

        public AsyncInvoker<ShowHotQuestionResponse> ShowHotQuestionAsyncInvoker(ShowHotQuestionRequest showHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", showHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotQuestionRequest);
            return new AsyncInvoker<ShowHotQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotQuestionResponse>);
        }
        
        /// <summary>
        /// 修改热点问题
        ///
        /// 该接口用于修改热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHotQuestionResponse> UpdateHotQuestionAsync(UpdateHotQuestionRequest updateHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", updateHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotQuestionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotQuestionResponse>(response);
        }

        public AsyncInvoker<UpdateHotQuestionResponse> UpdateHotQuestionAsyncInvoker(UpdateHotQuestionRequest updateHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", updateHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotQuestionRequest);
            return new AsyncInvoker<UpdateHotQuestionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotQuestionResponse>);
        }
        
        /// <summary>
        /// 创建热词记录
        ///
        /// 该接口用于创建热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHotWordsResponse> CreateHotWordsAsync(CreateHotWordsRequest createHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotWordsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHotWordsResponse>(response);
        }

        public AsyncInvoker<CreateHotWordsResponse> CreateHotWordsAsyncInvoker(CreateHotWordsRequest createHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotWordsRequest);
            return new AsyncInvoker<CreateHotWordsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotWordsResponse>);
        }
        
        /// <summary>
        /// 删除热词记录
        ///
        /// 该接口用于删除热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHotWordsResponse> DeleteHotWordsAsync(DeleteHotWordsRequest deleteHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", deleteHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotWordsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHotWordsResponse>(response);
        }

        public AsyncInvoker<DeleteHotWordsResponse> DeleteHotWordsAsyncInvoker(DeleteHotWordsRequest deleteHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", deleteHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotWordsRequest);
            return new AsyncInvoker<DeleteHotWordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询热词记录列表
        ///
        /// 该接口用于查询热词记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHotWordsResponse> ListHotWordsAsync(ListHotWordsRequest listHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotWordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHotWordsResponse>(response);
        }

        public AsyncInvoker<ListHotWordsResponse> ListHotWordsAsyncInvoker(ListHotWordsRequest listHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotWordsRequest);
            return new AsyncInvoker<ListHotWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询配置热词记录详情
        ///
        /// 该接口用于查询热词记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHotWordsResponse> ShowHotWordsAsync(ShowHotWordsRequest showHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", showHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHotWordsResponse>(response);
        }

        public AsyncInvoker<ShowHotWordsResponse> ShowHotWordsAsyncInvoker(ShowHotWordsRequest showHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", showHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsRequest);
            return new AsyncInvoker<ShowHotWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询热词功能开关
        ///
        /// 该接口用于查询热词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHotWordsSwitchResponse> ShowHotWordsSwitchAsync(ShowHotWordsSwitchRequest showHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHotWordsSwitchResponse>(response);
        }

        public AsyncInvoker<ShowHotWordsSwitchResponse> ShowHotWordsSwitchAsyncInvoker(ShowHotWordsSwitchRequest showHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsSwitchRequest);
            return new AsyncInvoker<ShowHotWordsSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 修改热词记录
        ///
        /// 该接口用于修改热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHotWordsResponse> UpdateHotWordsAsync(UpdateHotWordsRequest updateHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", updateHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotWordsResponse>(response);
        }

        public AsyncInvoker<UpdateHotWordsResponse> UpdateHotWordsAsyncInvoker(UpdateHotWordsRequest updateHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", updateHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsRequest);
            return new AsyncInvoker<UpdateHotWordsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotWordsResponse>);
        }
        
        /// <summary>
        /// 修改热词功能开关
        ///
        /// 该接口用于修改热词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHotWordsSwitchResponse> UpdateHotWordsSwitchAsync(UpdateHotWordsSwitchRequest updateHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateHotWordsSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateHotWordsSwitchResponse> UpdateHotWordsSwitchAsyncInvoker(UpdateHotWordsSwitchRequest updateHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsSwitchRequest);
            return new AsyncInvoker<UpdateHotWordsSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateHotWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 创建指令集
        ///
        /// 该接口用于创建指令集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstructionLibraryResponse> CreateInstructionLibraryAsync(CreateInstructionLibraryRequest createInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstructionLibraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstructionLibraryResponse>(response);
        }

        public AsyncInvoker<CreateInstructionLibraryResponse> CreateInstructionLibraryAsyncInvoker(CreateInstructionLibraryRequest createInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstructionLibraryRequest);
            return new AsyncInvoker<CreateInstructionLibraryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstructionLibraryResponse>);
        }
        
        /// <summary>
        /// 删除指令集
        ///
        /// 该接口用于删除指令集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstructionLibraryResponse> DeleteInstructionLibraryAsync(DeleteInstructionLibraryRequest deleteInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstructionLibraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteInstructionLibraryResponse>(response);
        }

        public AsyncInvoker<DeleteInstructionLibraryResponse> DeleteInstructionLibraryAsyncInvoker(DeleteInstructionLibraryRequest deleteInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstructionLibraryRequest);
            return new AsyncInvoker<DeleteInstructionLibraryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteInstructionLibraryResponse>);
        }
        
        /// <summary>
        /// 查询指令集列表
        ///
        /// 该接口用于查询指令集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstructionLibraryResponse> ListInstructionLibraryAsync(ListInstructionLibraryRequest listInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstructionLibraryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstructionLibraryResponse>(response);
        }

        public AsyncInvoker<ListInstructionLibraryResponse> ListInstructionLibraryAsyncInvoker(ListInstructionLibraryRequest listInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstructionLibraryRequest);
            return new AsyncInvoker<ListInstructionLibraryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstructionLibraryResponse>);
        }
        
        /// <summary>
        /// 查询指令集详情
        ///
        /// 该接口用于查询指令集详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstructionLibraryResponse> ShowInstructionLibraryAsync(ShowInstructionLibraryRequest showInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_library_id", showInstructionLibraryRequest.InstructionLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/{instruction_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstructionLibraryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstructionLibraryResponse>(response);
        }

        public AsyncInvoker<ShowInstructionLibraryResponse> ShowInstructionLibraryAsyncInvoker(ShowInstructionLibraryRequest showInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_library_id", showInstructionLibraryRequest.InstructionLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/{instruction_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstructionLibraryRequest);
            return new AsyncInvoker<ShowInstructionLibraryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstructionLibraryResponse>);
        }
        
        /// <summary>
        /// 修改指令集
        ///
        /// 该接口用于修改指令集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstructionLibraryResponse> UpdateInstructionLibraryAsync(UpdateInstructionLibraryRequest updateInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_library_id", updateInstructionLibraryRequest.InstructionLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/{instruction_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstructionLibraryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstructionLibraryResponse>(response);
        }

        public AsyncInvoker<UpdateInstructionLibraryResponse> UpdateInstructionLibraryAsyncInvoker(UpdateInstructionLibraryRequest updateInstructionLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_library_id", updateInstructionLibraryRequest.InstructionLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction-library/{instruction_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstructionLibraryRequest);
            return new AsyncInvoker<UpdateInstructionLibraryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstructionLibraryResponse>);
        }
        
        /// <summary>
        /// 创建指令
        ///
        /// 该接口用于创建指令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstructionResponse> CreateInstructionAsync(CreateInstructionRequest createInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstructionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstructionResponse>(response);
        }

        public AsyncInvoker<CreateInstructionResponse> CreateInstructionAsyncInvoker(CreateInstructionRequest createInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstructionRequest);
            return new AsyncInvoker<CreateInstructionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstructionResponse>);
        }
        
        /// <summary>
        /// 删除指令
        ///
        /// 该接口用于删除指令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstructionResponse> DeleteInstructionAsync(DeleteInstructionRequest deleteInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstructionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteInstructionResponse>(response);
        }

        public AsyncInvoker<DeleteInstructionResponse> DeleteInstructionAsyncInvoker(DeleteInstructionRequest deleteInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstructionRequest);
            return new AsyncInvoker<DeleteInstructionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteInstructionResponse>);
        }
        
        /// <summary>
        /// 查询指令列表
        ///
        /// 该接口用于查询指令列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstructionResponse> ListInstructionAsync(ListInstructionRequest listInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstructionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstructionResponse>(response);
        }

        public AsyncInvoker<ListInstructionResponse> ListInstructionAsyncInvoker(ListInstructionRequest listInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstructionRequest);
            return new AsyncInvoker<ListInstructionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstructionResponse>);
        }
        
        /// <summary>
        /// 查询指令详情
        ///
        /// 该接口用于查询指令详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstructionResponse> ShowInstructionAsync(ShowInstructionRequest showInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_id", showInstructionRequest.InstructionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/{instruction_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstructionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstructionResponse>(response);
        }

        public AsyncInvoker<ShowInstructionResponse> ShowInstructionAsyncInvoker(ShowInstructionRequest showInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_id", showInstructionRequest.InstructionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/{instruction_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstructionRequest);
            return new AsyncInvoker<ShowInstructionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstructionResponse>);
        }
        
        /// <summary>
        /// 修改指令
        ///
        /// 该接口用于修改指令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstructionResponse> UpdateInstructionAsync(UpdateInstructionRequest updateInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_id", updateInstructionRequest.InstructionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/{instruction_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstructionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstructionResponse>(response);
        }

        public AsyncInvoker<UpdateInstructionResponse> UpdateInstructionAsyncInvoker(UpdateInstructionRequest updateInstructionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instruction_id", updateInstructionRequest.InstructionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/instruction/{instruction_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstructionRequest);
            return new AsyncInvoker<UpdateInstructionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstructionResponse>);
        }
        
        /// <summary>
        /// 创建智能直播间互动规则库
        ///
        /// 该接口用于创建智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInteractionRuleGroupResponse> CreateInteractionRuleGroupAsync(CreateInteractionRuleGroupRequest createInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractionRuleGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInteractionRuleGroupResponse>(response);
        }

        public AsyncInvoker<CreateInteractionRuleGroupResponse> CreateInteractionRuleGroupAsyncInvoker(CreateInteractionRuleGroupRequest createInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractionRuleGroupRequest);
            return new AsyncInvoker<CreateInteractionRuleGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 删除智能直播间互动规则库
        ///
        /// 该接口用于删除智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInteractionRuleGroupResponse> DeleteInteractionRuleGroupAsync(DeleteInteractionRuleGroupRequest deleteInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInteractionRuleGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInteractionRuleGroupResponse>(response);
        }

        public AsyncInvoker<DeleteInteractionRuleGroupResponse> DeleteInteractionRuleGroupAsyncInvoker(DeleteInteractionRuleGroupRequest deleteInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInteractionRuleGroupRequest);
            return new AsyncInvoker<DeleteInteractionRuleGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间互动规则库列表
        ///
        /// 该接口用于智能直播间互动规则库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInteractionRuleGroupsResponse> ListInteractionRuleGroupsAsync(ListInteractionRuleGroupsRequest listInteractionRuleGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInteractionRuleGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInteractionRuleGroupsResponse>(response);
        }

        public AsyncInvoker<ListInteractionRuleGroupsResponse> ListInteractionRuleGroupsAsyncInvoker(ListInteractionRuleGroupsRequest listInteractionRuleGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInteractionRuleGroupsRequest);
            return new AsyncInvoker<ListInteractionRuleGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInteractionRuleGroupsResponse>);
        }
        
        /// <summary>
        /// 更新智能直播间互动规则库
        ///
        /// 该接口用于更新智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInteractionRuleGroupResponse> UpdateInteractionRuleGroupAsync(UpdateInteractionRuleGroupRequest updateInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInteractionRuleGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInteractionRuleGroupResponse>(response);
        }

        public AsyncInvoker<UpdateInteractionRuleGroupResponse> UpdateInteractionRuleGroupAsyncInvoker(UpdateInteractionRuleGroupRequest updateInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInteractionRuleGroupRequest);
            return new AsyncInvoker<UpdateInteractionRuleGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 交互助手对话
        ///
        /// 该接口用于交互助手对话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInteractiveChatResponse> CreateInteractiveChatAsync(CreateInteractiveChatRequest createInteractiveChatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/chat", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractiveChatRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInteractiveChatResponse>(response);
        }

        public AsyncInvoker<CreateInteractiveChatResponse> CreateInteractiveChatAsyncInvoker(CreateInteractiveChatRequest createInteractiveChatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/chat", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractiveChatRequest);
            return new AsyncInvoker<CreateInteractiveChatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInteractiveChatResponse>);
        }
        
        /// <summary>
        /// 创建知识库意图和问法
        ///
        /// 该接口用于创建知识库意图和问法。一个意图包含一个主题，一个答案，若干个问法等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIntentAndQuestionResponse> CreateIntentAndQuestionAsync(CreateIntentAndQuestionRequest createIntentAndQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIntentAndQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateIntentAndQuestionResponse>(response);
        }

        public AsyncInvoker<CreateIntentAndQuestionResponse> CreateIntentAndQuestionAsyncInvoker(CreateIntentAndQuestionRequest createIntentAndQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIntentAndQuestionRequest);
            return new AsyncInvoker<CreateIntentAndQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIntentAndQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库意图
        ///
        /// 该接口用于创建知识库意图。一个意图包含一个主题，一个答案，若干个问法等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKnowledgeIntentResponse> CreateKnowledgeIntentAsync(CreateKnowledgeIntentRequest createKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeIntentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeIntentResponse>(response);
        }

        public AsyncInvoker<CreateKnowledgeIntentResponse> CreateKnowledgeIntentAsyncInvoker(CreateKnowledgeIntentRequest createKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeIntentRequest);
            return new AsyncInvoker<CreateKnowledgeIntentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 删除知识库意图
        ///
        /// 该接口用于删除知识库意图。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKnowledgeIntentResponse> DeleteKnowledgeIntentAsync(DeleteKnowledgeIntentRequest deleteKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeIntentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeIntentResponse>(response);
        }

        public AsyncInvoker<DeleteKnowledgeIntentResponse> DeleteKnowledgeIntentAsyncInvoker(DeleteKnowledgeIntentRequest deleteKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeIntentRequest);
            return new AsyncInvoker<DeleteKnowledgeIntentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 查询知识库意图列表
        ///
        /// 该接口用于查询知识库意图列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKnowledgeIntentResponse> ListKnowledgeIntentAsync(ListKnowledgeIntentRequest listKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeIntentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeIntentResponse>(response);
        }

        public AsyncInvoker<ListKnowledgeIntentResponse> ListKnowledgeIntentAsyncInvoker(ListKnowledgeIntentRequest listKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeIntentRequest);
            return new AsyncInvoker<ListKnowledgeIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 查询知识库意图详情
        ///
        /// 该接口用于查询知识库意图详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKnowledgeIntentResponse> ShowKnowledgeIntentAsync(ShowKnowledgeIntentRequest showKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", showKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeIntentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeIntentResponse>(response);
        }

        public AsyncInvoker<ShowKnowledgeIntentResponse> ShowKnowledgeIntentAsyncInvoker(ShowKnowledgeIntentRequest showKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", showKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeIntentRequest);
            return new AsyncInvoker<ShowKnowledgeIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 修改知识库意图
        ///
        /// 该接口用于修改知识库意图。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKnowledgeIntentResponse> UpdateKnowledgeIntentAsync(UpdateKnowledgeIntentRequest updateKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", updateKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeIntentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeIntentResponse>(response);
        }

        public AsyncInvoker<UpdateKnowledgeIntentResponse> UpdateKnowledgeIntentAsyncInvoker(UpdateKnowledgeIntentRequest updateKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", updateKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeIntentRequest);
            return new AsyncInvoker<UpdateKnowledgeIntentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 知识库召回测试
        ///
        /// 该接口用于知识库召回测试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckRecallKnowledgeLibraryResponse> CheckRecallKnowledgeLibraryAsync(CheckRecallKnowledgeLibraryRequest checkRecallKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/recall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecallKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var checkRecallKnowledgeLibraryResponse = JsonUtils.DeSerializeNull<CheckRecallKnowledgeLibraryResponse>(response);
            checkRecallKnowledgeLibraryResponse.Body = JsonUtils.DeSerializeList<RecallKnowledgeLibraryInfo>(response);
            return checkRecallKnowledgeLibraryResponse;
        }

        public AsyncInvoker<CheckRecallKnowledgeLibraryResponse> CheckRecallKnowledgeLibraryAsyncInvoker(CheckRecallKnowledgeLibraryRequest checkRecallKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/recall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecallKnowledgeLibraryRequest);
            return new AsyncInvoker<CheckRecallKnowledgeLibraryResponse>(this, "POST", request, response =>
            {
                var checkRecallKnowledgeLibraryResponse = JsonUtils.DeSerializeNull<CheckRecallKnowledgeLibraryResponse>(response);
                checkRecallKnowledgeLibraryResponse.Body = JsonUtils.DeSerializeList<RecallKnowledgeLibraryInfo>(response);
                return checkRecallKnowledgeLibraryResponse;
            });
        }
        
        /// <summary>
        /// 创建知识库
        ///
        /// 该接口用于创建知识库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKnowledgeLibraryResponse> CreateKnowledgeLibraryAsync(CreateKnowledgeLibraryRequest createKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeLibraryResponse>(response);
        }

        public AsyncInvoker<CreateKnowledgeLibraryResponse> CreateKnowledgeLibraryAsyncInvoker(CreateKnowledgeLibraryRequest createKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeLibraryRequest);
            return new AsyncInvoker<CreateKnowledgeLibraryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeLibraryResponse>);
        }
        
        /// <summary>
        /// 删除知识库
        ///
        /// 该接口用于删除知识库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKnowledgeLibraryResponse> DeleteKnowledgeLibraryAsync(DeleteKnowledgeLibraryRequest deleteKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeLibraryResponse>(response);
        }

        public AsyncInvoker<DeleteKnowledgeLibraryResponse> DeleteKnowledgeLibraryAsyncInvoker(DeleteKnowledgeLibraryRequest deleteKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeLibraryRequest);
            return new AsyncInvoker<DeleteKnowledgeLibraryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeLibraryResponse>);
        }
        
        /// <summary>
        /// 查询知识库列表
        ///
        /// 该接口用于查询知识库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKnowledgeLibraryResponse> ListKnowledgeLibraryAsync(ListKnowledgeLibraryRequest listKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeLibraryResponse>(response);
        }

        public AsyncInvoker<ListKnowledgeLibraryResponse> ListKnowledgeLibraryAsyncInvoker(ListKnowledgeLibraryRequest listKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeLibraryRequest);
            return new AsyncInvoker<ListKnowledgeLibraryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeLibraryResponse>);
        }
        
        /// <summary>
        /// 查询知识库详情
        ///
        /// 该接口用于查询知识库详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKnowledgeLibraryResponse> ShowKnowledgeLibraryAsync(ShowKnowledgeLibraryRequest showKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("knowledge_library_id", showKnowledgeLibraryRequest.KnowledgeLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/{knowledge_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeLibraryResponse>(response);
        }

        public AsyncInvoker<ShowKnowledgeLibraryResponse> ShowKnowledgeLibraryAsyncInvoker(ShowKnowledgeLibraryRequest showKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("knowledge_library_id", showKnowledgeLibraryRequest.KnowledgeLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/{knowledge_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeLibraryRequest);
            return new AsyncInvoker<ShowKnowledgeLibraryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeLibraryResponse>);
        }
        
        /// <summary>
        /// 修改知识库
        ///
        /// 该接口用于修改知识库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKnowledgeLibraryResponse> UpdateKnowledgeLibraryAsync(UpdateKnowledgeLibraryRequest updateKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("knowledge_library_id", updateKnowledgeLibraryRequest.KnowledgeLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/{knowledge_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeLibraryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeLibraryResponse>(response);
        }

        public AsyncInvoker<UpdateKnowledgeLibraryResponse> UpdateKnowledgeLibraryAsyncInvoker(UpdateKnowledgeLibraryRequest updateKnowledgeLibraryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("knowledge_library_id", updateKnowledgeLibraryRequest.KnowledgeLibraryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/knowledge-library/{knowledge_library_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeLibraryRequest);
            return new AsyncInvoker<UpdateKnowledgeLibraryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeLibraryResponse>);
        }
        
        /// <summary>
        /// 批量创建知识库问法
        ///
        /// 该接口用于批量创建知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBatchKnowledgeQuestionResponse> CreateBatchKnowledgeQuestionAsync(CreateBatchKnowledgeQuestionRequest createBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBatchKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<CreateBatchKnowledgeQuestionResponse> CreateBatchKnowledgeQuestionAsyncInvoker(CreateBatchKnowledgeQuestionRequest createBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchKnowledgeQuestionRequest);
            return new AsyncInvoker<CreateBatchKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBatchKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库问法
        ///
        /// 该接口用于创建知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKnowledgeQuestionResponse> CreateKnowledgeQuestionAsync(CreateKnowledgeQuestionRequest createKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<CreateKnowledgeQuestionResponse> CreateKnowledgeQuestionAsyncInvoker(CreateKnowledgeQuestionRequest createKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeQuestionRequest);
            return new AsyncInvoker<CreateKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 删除知识库问法
        ///
        /// 该接口用于删除知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKnowledgeQuestionResponse> DeleteKnowledgeQuestionAsync(DeleteKnowledgeQuestionRequest deleteKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<DeleteKnowledgeQuestionResponse> DeleteKnowledgeQuestionAsyncInvoker(DeleteKnowledgeQuestionRequest deleteKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeQuestionRequest);
            return new AsyncInvoker<DeleteKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 查询知识库问法列表
        ///
        /// 该接口用于查询知识库问法列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKnowledgeQuestionResponse> ListKnowledgeQuestionAsync(ListKnowledgeQuestionRequest listKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<ListKnowledgeQuestionResponse> ListKnowledgeQuestionAsyncInvoker(ListKnowledgeQuestionRequest listKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeQuestionRequest);
            return new AsyncInvoker<ListKnowledgeQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 查询知识库问法详情
        ///
        /// 该接口用于查询知识库问法详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKnowledgeQuestionResponse> ShowKnowledgeQuestionAsync(ShowKnowledgeQuestionRequest showKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", showKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<ShowKnowledgeQuestionResponse> ShowKnowledgeQuestionAsyncInvoker(ShowKnowledgeQuestionRequest showKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", showKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeQuestionRequest);
            return new AsyncInvoker<ShowKnowledgeQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 批量修改知识库问法
        ///
        /// 该接口用于批量修改知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBatchKnowledgeQuestionResponse> UpdateBatchKnowledgeQuestionAsync(UpdateBatchKnowledgeQuestionRequest updateBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBatchKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<UpdateBatchKnowledgeQuestionResponse> UpdateBatchKnowledgeQuestionAsyncInvoker(UpdateBatchKnowledgeQuestionRequest updateBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchKnowledgeQuestionRequest);
            return new AsyncInvoker<UpdateBatchKnowledgeQuestionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBatchKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 修改知识库问法
        ///
        /// 该接口用于修改知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKnowledgeQuestionResponse> UpdateKnowledgeQuestionAsync(UpdateKnowledgeQuestionRequest updateKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", updateKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeQuestionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeQuestionResponse>(response);
        }

        public AsyncInvoker<UpdateKnowledgeQuestionResponse> UpdateKnowledgeQuestionAsyncInvoker(UpdateKnowledgeQuestionRequest updateKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", updateKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeQuestionRequest);
            return new AsyncInvoker<UpdateKnowledgeQuestionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库技能
        ///
        /// 该接口用于创建知识库技能。一个技能用于特定场景的交互问答，包含若干个意图等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKnowledgeSkillResponse> CreateKnowledgeSkillAsync(CreateKnowledgeSkillRequest createKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<CreateKnowledgeSkillResponse> CreateKnowledgeSkillAsyncInvoker(CreateKnowledgeSkillRequest createKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeSkillRequest);
            return new AsyncInvoker<CreateKnowledgeSkillResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 删除知识库技能
        ///
        /// 该接口用于删除知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKnowledgeSkillResponse> DeleteKnowledgeSkillAsync(DeleteKnowledgeSkillRequest deleteKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<DeleteKnowledgeSkillResponse> DeleteKnowledgeSkillAsyncInvoker(DeleteKnowledgeSkillRequest deleteKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeSkillRequest);
            return new AsyncInvoker<DeleteKnowledgeSkillResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 导出知识库技能
        ///
        /// 该接口用于导出知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportKnowledgeSkillResponse> ExportKnowledgeSkillAsync(ExportKnowledgeSkillRequest exportKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", exportKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ExportKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<ExportKnowledgeSkillResponse> ExportKnowledgeSkillAsyncInvoker(ExportKnowledgeSkillRequest exportKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", exportKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportKnowledgeSkillRequest);
            return new AsyncInvoker<ExportKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ExportKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 查询知识库技能列表
        ///
        /// 该接口用于查询知识库技能列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKnowledgeSkillResponse> ListKnowledgeSkillAsync(ListKnowledgeSkillRequest listKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<ListKnowledgeSkillResponse> ListKnowledgeSkillAsyncInvoker(ListKnowledgeSkillRequest listKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeSkillRequest);
            return new AsyncInvoker<ListKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 查询知识库技能详情
        ///
        /// 该接口用于查询知识库技能详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKnowledgeSkillResponse> ShowKnowledgeSkillAsync(ShowKnowledgeSkillRequest showKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", showKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<ShowKnowledgeSkillResponse> ShowKnowledgeSkillAsyncInvoker(ShowKnowledgeSkillRequest showKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", showKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeSkillRequest);
            return new AsyncInvoker<ShowKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 修改知识库技能
        ///
        /// 该接口用于修改知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKnowledgeSkillResponse> UpdateKnowledgeSkillAsync(UpdateKnowledgeSkillRequest updateKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", updateKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeSkillRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeSkillResponse>(response);
        }

        public AsyncInvoker<UpdateKnowledgeSkillResponse> UpdateKnowledgeSkillAsyncInvoker(UpdateKnowledgeSkillRequest updateKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", updateKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeSkillRequest);
            return new AsyncInvoker<UpdateKnowledgeSkillResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 创建第三方直播平台
        ///
        /// 该接口用于创建第三方直播平台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLivePlatformResponse> CreateLivePlatformAsync(CreateLivePlatformRequest createLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLivePlatformRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLivePlatformResponse>(response);
        }

        public AsyncInvoker<CreateLivePlatformResponse> CreateLivePlatformAsyncInvoker(CreateLivePlatformRequest createLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLivePlatformRequest);
            return new AsyncInvoker<CreateLivePlatformResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLivePlatformResponse>);
        }
        
        /// <summary>
        /// 删除第三方直播平台信息
        ///
        /// 该接口用于删除第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLivePlatformResponse> DeleteLivePlatformAsync(DeleteLivePlatformRequest deleteLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", deleteLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLivePlatformRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLivePlatformResponse>(response);
        }

        public AsyncInvoker<DeleteLivePlatformResponse> DeleteLivePlatformAsyncInvoker(DeleteLivePlatformRequest deleteLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", deleteLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLivePlatformRequest);
            return new AsyncInvoker<DeleteLivePlatformResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLivePlatformResponse>);
        }
        
        /// <summary>
        /// 查询第三方直播平台商品列表
        ///
        /// 该接口用于查询第三方直播平台商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLivePlatformProductsResponse> ListLivePlatformProductsAsync(ListLivePlatformProductsRequest listLivePlatformProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLivePlatformProductsResponse>(response);
        }

        public AsyncInvoker<ListLivePlatformProductsResponse> ListLivePlatformProductsAsyncInvoker(ListLivePlatformProductsRequest listLivePlatformProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformProductsRequest);
            return new AsyncInvoker<ListLivePlatformProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLivePlatformProductsResponse>);
        }
        
        /// <summary>
        /// 查询直播平台列表
        ///
        /// 该接口用于查询直播平台列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLivePlatformsResponse> ListLivePlatformsAsync(ListLivePlatformsRequest listLivePlatformsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLivePlatformsResponse>(response);
        }

        public AsyncInvoker<ListLivePlatformsResponse> ListLivePlatformsAsyncInvoker(ListLivePlatformsRequest listLivePlatformsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformsRequest);
            return new AsyncInvoker<ListLivePlatformsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLivePlatformsResponse>);
        }
        
        /// <summary>
        /// 查询第三方直播平台信息
        ///
        /// 该接口用于查询第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLivePlatformResponse> ShowLivePlatformAsync(ShowLivePlatformRequest showLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", showLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLivePlatformRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLivePlatformResponse>(response);
        }

        public AsyncInvoker<ShowLivePlatformResponse> ShowLivePlatformAsyncInvoker(ShowLivePlatformRequest showLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", showLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLivePlatformRequest);
            return new AsyncInvoker<ShowLivePlatformResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLivePlatformResponse>);
        }
        
        /// <summary>
        /// 更新第三方直播平台信息
        ///
        /// 该接口用于更新第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLivePlatformResponse> UpdateLivePlatformAsync(UpdateLivePlatformRequest updateLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", updateLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLivePlatformRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLivePlatformResponse>(response);
        }

        public AsyncInvoker<UpdateLivePlatformResponse> UpdateLivePlatformAsyncInvoker(UpdateLivePlatformRequest updateLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", updateLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLivePlatformRequest);
            return new AsyncInvoker<UpdateLivePlatformResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLivePlatformResponse>);
        }
        
        /// <summary>
        /// 创建大语言模型配置
        ///
        /// 该接口用于创建大语言模型配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLlmConfigResponse> CreateLlmConfigAsync(CreateLlmConfigRequest createLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLlmConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLlmConfigResponse>(response);
        }

        public AsyncInvoker<CreateLlmConfigResponse> CreateLlmConfigAsyncInvoker(CreateLlmConfigRequest createLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLlmConfigRequest);
            return new AsyncInvoker<CreateLlmConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLlmConfigResponse>);
        }
        
        /// <summary>
        /// 删除大语言模型配置
        ///
        /// 该接口用于删除大语言模型配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLlmConfigResponse> DeleteLlmConfigAsync(DeleteLlmConfigRequest deleteLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLlmConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteLlmConfigResponse>(response);
        }

        public AsyncInvoker<DeleteLlmConfigResponse> DeleteLlmConfigAsyncInvoker(DeleteLlmConfigRequest deleteLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLlmConfigRequest);
            return new AsyncInvoker<DeleteLlmConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteLlmConfigResponse>);
        }
        
        /// <summary>
        /// 查询大语言模型配置列表
        ///
        /// 该接口用于查询大语言模型配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLlmConfigResponse> ListLlmConfigAsync(ListLlmConfigRequest listLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLlmConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLlmConfigResponse>(response);
        }

        public AsyncInvoker<ListLlmConfigResponse> ListLlmConfigAsyncInvoker(ListLlmConfigRequest listLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLlmConfigRequest);
            return new AsyncInvoker<ListLlmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLlmConfigResponse>);
        }
        
        /// <summary>
        /// 查询大语言模型配置详情
        ///
        /// 该接口用于查询大语言模型配置详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLlmConfigResponse> ShowLlmConfigAsync(ShowLlmConfigRequest showLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("llm_config_id", showLlmConfigRequest.LlmConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/{llm_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLlmConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLlmConfigResponse>(response);
        }

        public AsyncInvoker<ShowLlmConfigResponse> ShowLlmConfigAsyncInvoker(ShowLlmConfigRequest showLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("llm_config_id", showLlmConfigRequest.LlmConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/{llm_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLlmConfigRequest);
            return new AsyncInvoker<ShowLlmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLlmConfigResponse>);
        }
        
        /// <summary>
        /// 修改大语言模型配置
        ///
        /// 该接口用于修改大语言模型配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLlmConfigResponse> UpdateLlmConfigAsync(UpdateLlmConfigRequest updateLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("llm_config_id", updateLlmConfigRequest.LlmConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/{llm_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLlmConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateLlmConfigResponse>(response);
        }

        public AsyncInvoker<UpdateLlmConfigResponse> UpdateLlmConfigAsyncInvoker(UpdateLlmConfigRequest updateLlmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("llm_config_id", updateLlmConfigRequest.LlmConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/llm-config/{llm_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLlmConfigRequest);
            return new AsyncInvoker<UpdateLlmConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateLlmConfigResponse>);
        }
        
        /// <summary>
        /// 创建MCP服务端对接配置
        ///
        /// 该接口用于创建MCP服务端对接配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMcpServerResponse> CreateMcpServerAsync(CreateMcpServerRequest createMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMcpServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMcpServerResponse>(response);
        }

        public AsyncInvoker<CreateMcpServerResponse> CreateMcpServerAsyncInvoker(CreateMcpServerRequest createMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMcpServerRequest);
            return new AsyncInvoker<CreateMcpServerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMcpServerResponse>);
        }
        
        /// <summary>
        /// 删除MCP服务端对接配置
        ///
        /// 该接口用于删除MCP服务端对接配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMcpServerResponse> DeleteMcpServerAsync(DeleteMcpServerRequest deleteMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMcpServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteMcpServerResponse>(response);
        }

        public AsyncInvoker<DeleteMcpServerResponse> DeleteMcpServerAsyncInvoker(DeleteMcpServerRequest deleteMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMcpServerRequest);
            return new AsyncInvoker<DeleteMcpServerResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteMcpServerResponse>);
        }
        
        /// <summary>
        /// 查询MCP服务端对接配置列表
        ///
        /// 该接口用于查询MCP服务端对接配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMcpServerResponse> ListMcpServerAsync(ListMcpServerRequest listMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMcpServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMcpServerResponse>(response);
        }

        public AsyncInvoker<ListMcpServerResponse> ListMcpServerAsyncInvoker(ListMcpServerRequest listMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMcpServerRequest);
            return new AsyncInvoker<ListMcpServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMcpServerResponse>);
        }
        
        /// <summary>
        /// 查询MCP服务端对接配置详情
        ///
        /// 该接口用于查询MCP服务端对接配置详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMcpServerResponse> ShowMcpServerAsync(ShowMcpServerRequest showMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("mcp_server_id", showMcpServerRequest.McpServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/{mcp_server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMcpServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMcpServerResponse>(response);
        }

        public AsyncInvoker<ShowMcpServerResponse> ShowMcpServerAsyncInvoker(ShowMcpServerRequest showMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("mcp_server_id", showMcpServerRequest.McpServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/{mcp_server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMcpServerRequest);
            return new AsyncInvoker<ShowMcpServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMcpServerResponse>);
        }
        
        /// <summary>
        /// 修改MCP服务端对接配置
        ///
        /// 该接口用于修改MCP服务端对接配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMcpServerResponse> UpdateMcpServerAsync(UpdateMcpServerRequest updateMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("mcp_server_id", updateMcpServerRequest.McpServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/{mcp_server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMcpServerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMcpServerResponse>(response);
        }

        public AsyncInvoker<UpdateMcpServerResponse> UpdateMcpServerAsyncInvoker(UpdateMcpServerRequest updateMcpServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("mcp_server_id", updateMcpServerRequest.McpServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/mcp-server/{mcp_server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMcpServerRequest);
            return new AsyncInvoker<UpdateMcpServerResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMcpServerResponse>);
        }
        
        /// <summary>
        /// 创建一次性鉴权码
        ///
        /// 该接口用于创建一次性鉴权码，有效期5分钟，鉴权码只能使用一次，每次使用后需要重新获取。
        /// &gt; 接口只能通过第三方后台调用，不能在浏览器前台直接调用，否则会有跨域问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOnceCodeResponse> CreateOnceCodeAsync(CreateOnceCodeRequest createOnceCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/once-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOnceCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOnceCodeResponse>(response);
        }

        public AsyncInvoker<CreateOnceCodeResponse> CreateOnceCodeAsyncInvoker(CreateOnceCodeRequest createOnceCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/once-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOnceCodeRequest);
            return new AsyncInvoker<CreateOnceCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOnceCodeResponse>);
        }
        
        /// <summary>
        /// 订购metastudio云服务产品
        ///
        /// 该接口用于订购MetaStudio服务的包周期,一次性,按需套餐包产品
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMetaStudioOrdersResponse> CreateMetaStudioOrdersAsync(CreateMetaStudioOrdersRequest createMetaStudioOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mss/public/orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetaStudioOrdersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMetaStudioOrdersResponse>(response);
        }

        public AsyncInvoker<CreateMetaStudioOrdersResponse> CreateMetaStudioOrdersAsyncInvoker(CreateMetaStudioOrdersRequest createMetaStudioOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mss/public/orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetaStudioOrdersRequest);
            return new AsyncInvoker<CreateMetaStudioOrdersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMetaStudioOrdersResponse>);
        }
        
        /// <summary>
        /// 批量删除安抚话术
        ///
        /// 该接口用于批量删除安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePacifyWordsResponse> BatchDeletePacifyWordsAsync(BatchDeletePacifyWordsRequest batchDeletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePacifyWordsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePacifyWordsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePacifyWordsResponse> BatchDeletePacifyWordsAsyncInvoker(BatchDeletePacifyWordsRequest batchDeletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePacifyWordsRequest);
            return new AsyncInvoker<BatchDeletePacifyWordsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 创建安抚话术
        ///
        /// 该接口用于创建安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePacifyWordsResponse> CreatePacifyWordsAsync(CreatePacifyWordsRequest createPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPacifyWordsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePacifyWordsResponse>(response);
        }

        public AsyncInvoker<CreatePacifyWordsResponse> CreatePacifyWordsAsyncInvoker(CreatePacifyWordsRequest createPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPacifyWordsRequest);
            return new AsyncInvoker<CreatePacifyWordsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 删除安抚话术
        ///
        /// 该接口用于删除安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePacifyWordsResponse> DeletePacifyWordsAsync(DeletePacifyWordsRequest deletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", deletePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePacifyWordsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePacifyWordsResponse>(response);
        }

        public AsyncInvoker<DeletePacifyWordsResponse> DeletePacifyWordsAsyncInvoker(DeletePacifyWordsRequest deletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", deletePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePacifyWordsRequest);
            return new AsyncInvoker<DeletePacifyWordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术列表
        ///
        /// 该接口用于查询安抚话术列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPacifyWordsResponse> ListPacifyWordsAsync(ListPacifyWordsRequest listPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPacifyWordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPacifyWordsResponse>(response);
        }

        public AsyncInvoker<ListPacifyWordsResponse> ListPacifyWordsAsyncInvoker(ListPacifyWordsRequest listPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPacifyWordsRequest);
            return new AsyncInvoker<ListPacifyWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术详情
        ///
        /// 该接口用于查询安抚话术详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPacifyWordsResponse> ShowPacifyWordsAsync(ShowPacifyWordsRequest showPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", showPacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsResponse>(response);
        }

        public AsyncInvoker<ShowPacifyWordsResponse> ShowPacifyWordsAsyncInvoker(ShowPacifyWordsRequest showPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", showPacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsRequest);
            return new AsyncInvoker<ShowPacifyWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术意图
        ///
        /// 该接口用于查询安抚话术意图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPacifyWordsIntentResponse> ShowPacifyWordsIntentAsync(ShowPacifyWordsIntentRequest showPacifyWordsIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsIntentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsIntentResponse>(response);
        }

        public AsyncInvoker<ShowPacifyWordsIntentResponse> ShowPacifyWordsIntentAsyncInvoker(ShowPacifyWordsIntentRequest showPacifyWordsIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsIntentRequest);
            return new AsyncInvoker<ShowPacifyWordsIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsIntentResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术功能开关
        ///
        /// 该接口用于查询安抚话术功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPacifyWordsSwitchResponse> ShowPacifyWordsSwitchAsync(ShowPacifyWordsSwitchRequest showPacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsSwitchResponse>(response);
        }

        public AsyncInvoker<ShowPacifyWordsSwitchResponse> ShowPacifyWordsSwitchAsyncInvoker(ShowPacifyWordsSwitchRequest showPacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsSwitchRequest);
            return new AsyncInvoker<ShowPacifyWordsSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术等待触发时长
        ///
        /// 该接口用于查询等待触发时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPacifyWordsTriggerTimeResponse> ShowPacifyWordsTriggerTimeAsync(ShowPacifyWordsTriggerTimeRequest showPacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsTriggerTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsTriggerTimeResponse>(response);
        }

        public AsyncInvoker<ShowPacifyWordsTriggerTimeResponse> ShowPacifyWordsTriggerTimeAsyncInvoker(ShowPacifyWordsTriggerTimeRequest showPacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsTriggerTimeRequest);
            return new AsyncInvoker<ShowPacifyWordsTriggerTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsTriggerTimeResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术
        ///
        /// 该接口用于修改安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePacifyWordsResponse> UpdatePacifyWordsAsync(UpdatePacifyWordsRequest updatePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", updatePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePacifyWordsResponse>(response);
        }

        public AsyncInvoker<UpdatePacifyWordsResponse> UpdatePacifyWordsAsyncInvoker(UpdatePacifyWordsRequest updatePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", updatePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsRequest);
            return new AsyncInvoker<UpdatePacifyWordsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术功能开关
        ///
        /// 该接口用于修改安抚话术功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePacifyWordsSwitchResponse> UpdatePacifyWordsSwitchAsync(UpdatePacifyWordsSwitchRequest updatePacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsSwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePacifyWordsSwitchResponse>(response);
        }

        public AsyncInvoker<UpdatePacifyWordsSwitchResponse> UpdatePacifyWordsSwitchAsyncInvoker(UpdatePacifyWordsSwitchRequest updatePacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsSwitchRequest);
            return new AsyncInvoker<UpdatePacifyWordsSwitchResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePacifyWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术等待触发时长
        ///
        /// 该接口用于修改安抚话术等待触发时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePacifyWordsTriggerTimeResponse> UpdatePacifyWordsTriggerTimeAsync(UpdatePacifyWordsTriggerTimeRequest updatePacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsTriggerTimeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePacifyWordsTriggerTimeResponse>(response);
        }

        public AsyncInvoker<UpdatePacifyWordsTriggerTimeResponse> UpdatePacifyWordsTriggerTimeAsyncInvoker(UpdatePacifyWordsTriggerTimeRequest updatePacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsTriggerTimeRequest);
            return new AsyncInvoker<UpdatePacifyWordsTriggerTimeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePacifyWordsTriggerTimeResponse>);
        }
        
        /// <summary>
        /// 基于图片URL创建照片建模任务
        ///
        /// 该接口用于从URL中获取图片进行照片建模任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePictureModelingByUrlJobResponse> CreatePictureModelingByUrlJobAsync(CreatePictureModelingByUrlJobRequest createPictureModelingByUrlJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings-by-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPictureModelingByUrlJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePictureModelingByUrlJobResponse>(response);
        }

        public AsyncInvoker<CreatePictureModelingByUrlJobResponse> CreatePictureModelingByUrlJobAsyncInvoker(CreatePictureModelingByUrlJobRequest createPictureModelingByUrlJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings-by-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPictureModelingByUrlJobRequest);
            return new AsyncInvoker<CreatePictureModelingByUrlJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePictureModelingByUrlJobResponse>);
        }
        
        /// <summary>
        /// 创建照片建模任务
        ///
        /// 该接口用于创建风格化照片建模任务。通过上传照片，生成风格化数字人模型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePictureModelingJobResponse> CreatePictureModelingJobAsync(CreatePictureModelingJobRequest createPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createPictureModelingJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePictureModelingJobResponse>(response);
        }

        public AsyncInvoker<CreatePictureModelingJobResponse> CreatePictureModelingJobAsyncInvoker(CreatePictureModelingJobRequest createPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createPictureModelingJobRequest);
            return new AsyncInvoker<CreatePictureModelingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePictureModelingJobResponse>);
        }
        
        /// <summary>
        /// 照片建模任务列表查询
        ///
        /// 该接口用于查询风格化照片建模任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPictureModelingJobsResponse> ListPictureModelingJobsAsync(ListPictureModelingJobsRequest listPictureModelingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPictureModelingJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPictureModelingJobsResponse>(response);
        }

        public AsyncInvoker<ListPictureModelingJobsResponse> ListPictureModelingJobsAsyncInvoker(ListPictureModelingJobsRequest listPictureModelingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPictureModelingJobsRequest);
            return new AsyncInvoker<ListPictureModelingJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPictureModelingJobsResponse>);
        }
        
        /// <summary>
        /// 照片建模任务详情查询
        ///
        /// 该接口用于风格化查询照片建模任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPictureModelingJobResponse> ShowPictureModelingJobAsync(ShowPictureModelingJobRequest showPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPictureModelingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPictureModelingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPictureModelingJobResponse>(response);
        }

        public AsyncInvoker<ShowPictureModelingJobResponse> ShowPictureModelingJobAsyncInvoker(ShowPictureModelingJobRequest showPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPictureModelingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPictureModelingJobRequest);
            return new AsyncInvoker<ShowPictureModelingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPictureModelingJobResponse>);
        }
        
        /// <summary>
        /// 创建插件配置
        ///
        /// 该接口用于创建插件配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePluginConfigResponse> CreatePluginConfigAsync(CreatePluginConfigRequest createPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPluginConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePluginConfigResponse>(response);
        }

        public AsyncInvoker<CreatePluginConfigResponse> CreatePluginConfigAsyncInvoker(CreatePluginConfigRequest createPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPluginConfigRequest);
            return new AsyncInvoker<CreatePluginConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePluginConfigResponse>);
        }
        
        /// <summary>
        /// 删除插件配置
        ///
        /// 该接口用于删除插件配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePluginConfigResponse> DeletePluginConfigAsync(DeletePluginConfigRequest deletePluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeletePluginConfigResponse>(response);
        }

        public AsyncInvoker<DeletePluginConfigResponse> DeletePluginConfigAsyncInvoker(DeletePluginConfigRequest deletePluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginConfigRequest);
            return new AsyncInvoker<DeletePluginConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeletePluginConfigResponse>);
        }
        
        /// <summary>
        /// 查询插件配置列表
        ///
        /// 该接口用于查询插件配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginConfigResponse> ListPluginConfigAsync(ListPluginConfigRequest listPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPluginConfigResponse>(response);
        }

        public AsyncInvoker<ListPluginConfigResponse> ListPluginConfigAsyncInvoker(ListPluginConfigRequest listPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginConfigRequest);
            return new AsyncInvoker<ListPluginConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginConfigResponse>);
        }
        
        /// <summary>
        /// 查询插件配置详情
        ///
        /// 该接口用于查询插件配置详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginConfigResponse> ShowPluginConfigAsync(ShowPluginConfigRequest showPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("plugin_config_id", showPluginConfigRequest.PluginConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/{plugin_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPluginConfigResponse>(response);
        }

        public AsyncInvoker<ShowPluginConfigResponse> ShowPluginConfigAsyncInvoker(ShowPluginConfigRequest showPluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("plugin_config_id", showPluginConfigRequest.PluginConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/{plugin_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginConfigRequest);
            return new AsyncInvoker<ShowPluginConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPluginConfigResponse>);
        }
        
        /// <summary>
        /// 查询插件配置默认信息
        ///
        /// 该接口用于查询插件配置默认信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginConfigDefaultInfoResponse> ShowPluginConfigDefaultInfoAsync(ShowPluginConfigDefaultInfoRequest showPluginConfigDefaultInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginConfigDefaultInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPluginConfigDefaultInfoResponse>(response);
        }

        public AsyncInvoker<ShowPluginConfigDefaultInfoResponse> ShowPluginConfigDefaultInfoAsyncInvoker(ShowPluginConfigDefaultInfoRequest showPluginConfigDefaultInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginConfigDefaultInfoRequest);
            return new AsyncInvoker<ShowPluginConfigDefaultInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPluginConfigDefaultInfoResponse>);
        }
        
        /// <summary>
        /// 修改插件配置
        ///
        /// 该接口用于修改插件配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePluginConfigResponse> UpdatePluginConfigAsync(UpdatePluginConfigRequest updatePluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("plugin_config_id", updatePluginConfigRequest.PluginConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/{plugin_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePluginConfigResponse>(response);
        }

        public AsyncInvoker<UpdatePluginConfigResponse> UpdatePluginConfigAsyncInvoker(UpdatePluginConfigRequest updatePluginConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("plugin_config_id", updatePluginConfigRequest.PluginConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/plugin-config/{plugin_config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginConfigRequest);
            return new AsyncInvoker<UpdatePluginConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePluginConfigResponse>);
        }
        
        /// <summary>
        /// 创建商品
        ///
        /// Create product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProductRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
        }

        public AsyncInvoker<CreateProductResponse> CreateProductAsyncInvoker(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProductRequest);
            return new AsyncInvoker<CreateProductResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProductResponse>);
        }
        
        /// <summary>
        /// 删除商品
        ///
        /// 删除商品
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
        }

        public AsyncInvoker<DeleteProductResponse> DeleteProductAsyncInvoker(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            return new AsyncInvoker<DeleteProductResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProductResponse>);
        }
        
        /// <summary>
        /// 查询商品列表
        ///
        /// 查询商品列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public AsyncInvoker<ListProductsResponse> ListProductsAsyncInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new AsyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 商品资产组合配置
        ///
        /// 商品资产组合配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetProductAssetResponse> SetProductAssetAsync(SetProductAssetRequest setProductAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", setProductAssetRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}/assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setProductAssetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetProductAssetResponse>(response);
        }

        public AsyncInvoker<SetProductAssetResponse> SetProductAssetAsyncInvoker(SetProductAssetRequest setProductAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", setProductAssetRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}/assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setProductAssetRequest);
            return new AsyncInvoker<SetProductAssetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetProductAssetResponse>);
        }
        
        /// <summary>
        /// 查询商品详情
        ///
        /// Show product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProductResponse> ShowProductAsync(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }

        public AsyncInvoker<ShowProductResponse> ShowProductAsyncInvoker(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            return new AsyncInvoker<ShowProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProductResponse>);
        }
        
        /// <summary>
        /// 更新商品
        ///
        /// Update product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProductRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProductResponse>(response);
        }

        public AsyncInvoker<UpdateProductResponse> UpdateProductAsyncInvoker(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProductRequest);
            return new AsyncInvoker<UpdateProductResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProductResponse>);
        }
        
        /// <summary>
        /// 创建问答对
        ///
        /// 该接口用于创建问答对。一个问答对包含一个标准问题，一个答案，若干个相似问题等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateQuestionAnswerResponse> CreateQuestionAnswerAsync(CreateQuestionAnswerRequest createQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQuestionAnswerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateQuestionAnswerResponse>(response);
        }

        public AsyncInvoker<CreateQuestionAnswerResponse> CreateQuestionAnswerAsyncInvoker(CreateQuestionAnswerRequest createQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQuestionAnswerRequest);
            return new AsyncInvoker<CreateQuestionAnswerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateQuestionAnswerResponse>);
        }
        
        /// <summary>
        /// 删除问答对
        ///
        /// 该接口用于删除问答对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteQuestionAnswerResponse> DeleteQuestionAnswerAsync(DeleteQuestionAnswerRequest deleteQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQuestionAnswerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteQuestionAnswerResponse>(response);
        }

        public AsyncInvoker<DeleteQuestionAnswerResponse> DeleteQuestionAnswerAsyncInvoker(DeleteQuestionAnswerRequest deleteQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQuestionAnswerRequest);
            return new AsyncInvoker<DeleteQuestionAnswerResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteQuestionAnswerResponse>);
        }
        
        /// <summary>
        /// 查询问答对列表
        ///
        /// 该接口用于查询问答对列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuestionAnswerResponse> ListQuestionAnswerAsync(ListQuestionAnswerRequest listQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuestionAnswerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuestionAnswerResponse>(response);
        }

        public AsyncInvoker<ListQuestionAnswerResponse> ListQuestionAnswerAsyncInvoker(ListQuestionAnswerRequest listQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuestionAnswerRequest);
            return new AsyncInvoker<ListQuestionAnswerResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuestionAnswerResponse>);
        }
        
        /// <summary>
        /// 查询问答对详情
        ///
        /// 该接口用于查询问答对详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuestionAnswerResponse> ShowQuestionAnswerAsync(ShowQuestionAnswerRequest showQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_answer_id", showQuestionAnswerRequest.QuestionAnswerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/{question_answer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuestionAnswerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuestionAnswerResponse>(response);
        }

        public AsyncInvoker<ShowQuestionAnswerResponse> ShowQuestionAnswerAsyncInvoker(ShowQuestionAnswerRequest showQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_answer_id", showQuestionAnswerRequest.QuestionAnswerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/{question_answer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuestionAnswerRequest);
            return new AsyncInvoker<ShowQuestionAnswerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuestionAnswerResponse>);
        }
        
        /// <summary>
        /// 修改问答对
        ///
        /// 该接口用于修改问答对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateQuestionAnswerResponse> UpdateQuestionAnswerAsync(UpdateQuestionAnswerRequest updateQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_answer_id", updateQuestionAnswerRequest.QuestionAnswerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/{question_answer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQuestionAnswerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateQuestionAnswerResponse>(response);
        }

        public AsyncInvoker<UpdateQuestionAnswerResponse> UpdateQuestionAnswerAsyncInvoker(UpdateQuestionAnswerRequest updateQuestionAnswerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_answer_id", updateQuestionAnswerRequest.QuestionAnswerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/question-answer/{question_answer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQuestionAnswerRequest);
            return new AsyncInvoker<UpdateQuestionAnswerResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateQuestionAnswerResponse>);
        }
        
        /// <summary>
        /// 创建应用
        ///
        /// 该接口用于创建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRobotResponse> CreateRobotAsync(CreateRobotRequest createRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRobotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRobotResponse>(response);
        }

        public AsyncInvoker<CreateRobotResponse> CreateRobotAsyncInvoker(CreateRobotRequest createRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRobotRequest);
            return new AsyncInvoker<CreateRobotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRobotResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 该接口用于删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRobotResponse> DeleteRobotAsync(DeleteRobotRequest deleteRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRobotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteRobotResponse>(response);
        }

        public AsyncInvoker<DeleteRobotResponse> DeleteRobotAsyncInvoker(DeleteRobotRequest deleteRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRobotRequest);
            return new AsyncInvoker<DeleteRobotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteRobotResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 该接口用于查询应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRobotResponse> ListRobotAsync(ListRobotRequest listRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRobotRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRobotResponse>(response);
        }

        public AsyncInvoker<ListRobotResponse> ListRobotAsyncInvoker(ListRobotRequest listRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRobotRequest);
            return new AsyncInvoker<ListRobotResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRobotResponse>);
        }
        
        /// <summary>
        /// 查询应用详情
        ///
        /// 该接口用于查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRobotResponse> ShowRobotAsync(ShowRobotRequest showRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", showRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRobotRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRobotResponse>(response);
        }

        public AsyncInvoker<ShowRobotResponse> ShowRobotAsyncInvoker(ShowRobotRequest showRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", showRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRobotRequest);
            return new AsyncInvoker<ShowRobotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRobotResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 该接口用于修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRobotResponse> UpdateRobotAsync(UpdateRobotRequest updateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", updateRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRobotRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRobotResponse>(response);
        }

        public AsyncInvoker<UpdateRobotResponse> UpdateRobotAsyncInvoker(UpdateRobotRequest updateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", updateRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRobotRequest);
            return new AsyncInvoker<UpdateRobotResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRobotResponse>);
        }
        
        /// <summary>
        /// 校验应用
        ///
        /// 该接口用于校验应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateRobotResponse> ValidateRobotAsync(ValidateRobotRequest validateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateRobotRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ValidateRobotResponse>(response);
        }

        public AsyncInvoker<ValidateRobotResponse> ValidateRobotAsyncInvoker(ValidateRobotRequest validateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateRobotRequest);
            return new AsyncInvoker<ValidateRobotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ValidateRobotResponse>);
        }
        
        /// <summary>
        /// 创建角色
        ///
        /// 该接口用于创建角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest createRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRoleResponse>(response);
        }

        public AsyncInvoker<CreateRoleResponse> CreateRoleAsyncInvoker(CreateRoleRequest createRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoleRequest);
            return new AsyncInvoker<CreateRoleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoleResponse>);
        }
        
        /// <summary>
        /// 删除角色
        ///
        /// 该接口用于删除角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest deleteRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteRoleResponse>(response);
        }

        public AsyncInvoker<DeleteRoleResponse> DeleteRoleAsyncInvoker(DeleteRoleRequest deleteRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoleRequest);
            return new AsyncInvoker<DeleteRoleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteRoleResponse>);
        }
        
        /// <summary>
        /// 查询角色列表
        ///
        /// 该接口用于查询角色列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRoleResponse> ListRoleAsync(ListRoleRequest listRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRoleResponse>(response);
        }

        public AsyncInvoker<ListRoleResponse> ListRoleAsyncInvoker(ListRoleRequest listRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoleRequest);
            return new AsyncInvoker<ListRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRoleResponse>);
        }
        
        /// <summary>
        /// 查询角色详情
        ///
        /// 该接口用于查询角色详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRoleResponse> ShowRoleAsync(ShowRoleRequest showRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", showRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRoleResponse>(response);
        }

        public AsyncInvoker<ShowRoleResponse> ShowRoleAsyncInvoker(ShowRoleRequest showRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", showRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoleRequest);
            return new AsyncInvoker<ShowRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoleResponse>);
        }
        
        /// <summary>
        /// 修改角色
        ///
        /// 该接口用于修改角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest updateRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRoleResponse>(response);
        }

        public AsyncInvoker<UpdateRoleResponse> UpdateRoleAsyncInvoker(UpdateRoleRequest updateRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/wise-brain-manager/role/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoleRequest);
            return new AsyncInvoker<UpdateRoleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRoleResponse>);
        }
        
        /// <summary>
        /// 创建智能交互对话
        ///
        /// 该接口用于创建智能交互对话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSmartChatRoomResponse> CreateSmartChatRoomAsync(CreateSmartChatRoomRequest createSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartChatRoomRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSmartChatRoomResponse>(response);
        }

        public AsyncInvoker<CreateSmartChatRoomResponse> CreateSmartChatRoomAsyncInvoker(CreateSmartChatRoomRequest createSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartChatRoomRequest);
            return new AsyncInvoker<CreateSmartChatRoomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 删除智能交互对话
        ///
        /// 该接口用于删除智能交互对话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSmartChatRoomResponse> DeleteSmartChatRoomAsync(DeleteSmartChatRoomRequest deleteSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartChatRoomRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSmartChatRoomResponse>(response);
        }

        public AsyncInvoker<DeleteSmartChatRoomResponse> DeleteSmartChatRoomAsyncInvoker(DeleteSmartChatRoomRequest deleteSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartChatRoomRequest);
            return new AsyncInvoker<DeleteSmartChatRoomResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 查询智能交互对话列表
        ///
        /// 该接口用于智能交互对话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartChatRoomsResponse> ListSmartChatRoomsAsync(ListSmartChatRoomsRequest listSmartChatRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatRoomsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartChatRoomsResponse>(response);
        }

        public AsyncInvoker<ListSmartChatRoomsResponse> ListSmartChatRoomsAsyncInvoker(ListSmartChatRoomsRequest listSmartChatRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatRoomsRequest);
            return new AsyncInvoker<ListSmartChatRoomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartChatRoomsResponse>);
        }
        
        /// <summary>
        /// 查询智能交互对话详情
        ///
        /// 该接口用于查询智能交互对话详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSmartChatRoomResponse> ShowSmartChatRoomAsync(ShowSmartChatRoomRequest showSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatRoomRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartChatRoomResponse>(response);
        }

        public AsyncInvoker<ShowSmartChatRoomResponse> ShowSmartChatRoomAsyncInvoker(ShowSmartChatRoomRequest showSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatRoomRequest);
            return new AsyncInvoker<ShowSmartChatRoomResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 更新智能交互对话信息
        ///
        /// 该接口用于智能交互对话信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSmartChatRoomResponse> UpdateSmartChatRoomAsync(UpdateSmartChatRoomRequest updateSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartChatRoomRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSmartChatRoomResponse>(response);
        }

        public AsyncInvoker<UpdateSmartChatRoomResponse> UpdateSmartChatRoomAsyncInvoker(UpdateSmartChatRoomRequest updateSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartChatRoomRequest);
            return new AsyncInvoker<UpdateSmartChatRoomResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 批量确认命令
        ///
        /// 该接口用于批量确认命令列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchConfirmLiveCommandsResponse> BatchConfirmLiveCommandsAsync(BatchConfirmLiveCommandsRequest batchConfirmLiveCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", batchConfirmLiveCommandsRequest.RoomId.ToString());
            urlParam.Add("job_id", batchConfirmLiveCommandsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/batch-commands-confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchConfirmLiveCommandsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchConfirmLiveCommandsResponse>(response);
        }

        public AsyncInvoker<BatchConfirmLiveCommandsResponse> BatchConfirmLiveCommandsAsyncInvoker(BatchConfirmLiveCommandsRequest batchConfirmLiveCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", batchConfirmLiveCommandsRequest.RoomId.ToString());
            urlParam.Add("job_id", batchConfirmLiveCommandsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/batch-commands-confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchConfirmLiveCommandsRequest);
            return new AsyncInvoker<BatchConfirmLiveCommandsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchConfirmLiveCommandsResponse>);
        }
        
        /// <summary>
        /// 控制数字人直播过程
        ///
        /// 该接口用于控制数字人直播过程。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteSmartLiveCommandResponse> ExecuteSmartLiveCommandAsync(ExecuteSmartLiveCommandRequest executeSmartLiveCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", executeSmartLiveCommandRequest.RoomId.ToString());
            urlParam.Add("job_id", executeSmartLiveCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeSmartLiveCommandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteSmartLiveCommandResponse>(response);
        }

        public AsyncInvoker<ExecuteSmartLiveCommandResponse> ExecuteSmartLiveCommandAsyncInvoker(ExecuteSmartLiveCommandRequest executeSmartLiveCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", executeSmartLiveCommandRequest.RoomId.ToString());
            urlParam.Add("job_id", executeSmartLiveCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeSmartLiveCommandRequest);
            return new AsyncInvoker<ExecuteSmartLiveCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteSmartLiveCommandResponse>);
        }
        
        /// <summary>
        /// 查询某个智能直播间下直播任务列表
        ///
        /// 该接口用于查询某个智能直播间的直播任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartLiveResponse> ListSmartLiveAsync(ListSmartLiveRequest listSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveResponse>(response);
        }

        public AsyncInvoker<ListSmartLiveResponse> ListSmartLiveAsyncInvoker(ListSmartLiveRequest listSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRequest);
            return new AsyncInvoker<ListSmartLiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveResponse>);
        }
        
        /// <summary>
        /// 查询租户所有数字人直播任务列表
        ///
        /// 该接口用于查询租户所有数字人智能直播任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartLiveJobsResponse> ListSmartLiveJobsAsync(ListSmartLiveJobsRequest listSmartLiveJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveJobsResponse>(response);
        }

        public AsyncInvoker<ListSmartLiveJobsResponse> ListSmartLiveJobsAsyncInvoker(ListSmartLiveJobsRequest listSmartLiveJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveJobsRequest);
            return new AsyncInvoker<ListSmartLiveJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveJobsResponse>);
        }
        
        /// <summary>
        /// 查询租户未确认的互动规则命令列表
        ///
        /// 该接口用于查询租户未确认的互动规则命令列表，仅限于需要做二次确认的特定用户使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartLiveRuleCommandsResponse> ListSmartLiveRuleCommandsAsync(ListSmartLiveRuleCommandsRequest listSmartLiveRuleCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/rule-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRuleCommandsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveRuleCommandsResponse>(response);
        }

        public AsyncInvoker<ListSmartLiveRuleCommandsResponse> ListSmartLiveRuleCommandsAsyncInvoker(ListSmartLiveRuleCommandsRequest listSmartLiveRuleCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/rule-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRuleCommandsRequest);
            return new AsyncInvoker<ListSmartLiveRuleCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveRuleCommandsResponse>);
        }
        
        /// <summary>
        /// 查询租户未确认的剧本命令列表
        ///
        /// 该接口用于查询租户未确认的剧本命令列表，仅限于需要做二次确认的特定用户使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartLiveScriptCommandsResponse> ListSmartLiveScriptCommandsAsync(ListSmartLiveScriptCommandsRequest listSmartLiveScriptCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/script-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveScriptCommandsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveScriptCommandsResponse>(response);
        }

        public AsyncInvoker<ListSmartLiveScriptCommandsResponse> ListSmartLiveScriptCommandsAsyncInvoker(ListSmartLiveScriptCommandsRequest listSmartLiveScriptCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/script-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveScriptCommandsRequest);
            return new AsyncInvoker<ListSmartLiveScriptCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveScriptCommandsResponse>);
        }
        
        /// <summary>
        /// 上报直播间事件
        ///
        /// 该接口用于上报直播间事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LiveEventReportResponse> LiveEventReportAsync(LiveEventReportRequest liveEventReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", liveEventReportRequest.RoomId.ToString());
            urlParam.Add("job_id", liveEventReportRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/live-event-report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveEventReportRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<LiveEventReportResponse>(response);
        }

        public AsyncInvoker<LiveEventReportResponse> LiveEventReportAsyncInvoker(LiveEventReportRequest liveEventReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", liveEventReportRequest.RoomId.ToString());
            urlParam.Add("job_id", liveEventReportRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/live-event-report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveEventReportRequest);
            return new AsyncInvoker<LiveEventReportResponse>(this, "POST", request, JsonUtils.DeSerialize<LiveEventReportResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能直播任务详情
        ///
        /// 该接口用于查询数字人智能直播任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSmartLiveResponse> ShowSmartLiveAsync(ShowSmartLiveRequest showSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartLiveResponse>(response);
        }

        public AsyncInvoker<ShowSmartLiveResponse> ShowSmartLiveAsyncInvoker(ShowSmartLiveRequest showSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRequest);
            return new AsyncInvoker<ShowSmartLiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartLiveResponse>);
        }
        
        /// <summary>
        /// 启动数字人智能直播任务
        ///
        /// 该接口用于启动数字人智能直播任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartSmartLiveResponse> StartSmartLiveAsync(StartSmartLiveRequest startSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartLiveRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartSmartLiveResponse>(response);
        }

        public AsyncInvoker<StartSmartLiveResponse> StartSmartLiveAsyncInvoker(StartSmartLiveRequest startSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartLiveRequest);
            return new AsyncInvoker<StartSmartLiveResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSmartLiveResponse>);
        }
        
        /// <summary>
        /// 结束数字人智能直播任务
        ///
        /// 该接口用于结束数字人智能直播任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopSmartLiveResponse> StopSmartLiveAsync(StopSmartLiveRequest stopSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartLiveRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopSmartLiveResponse>(response);
        }

        public AsyncInvoker<StopSmartLiveResponse> StopSmartLiveAsyncInvoker(StopSmartLiveRequest stopSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartLiveRequest);
            return new AsyncInvoker<StopSmartLiveResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopSmartLiveResponse>);
        }
        
        /// <summary>
        /// 直播间确认
        ///
        /// 该接口用直播间二次确认
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmSmarLiveRoomResponse> ConfirmSmarLiveRoomAsync(ConfirmSmarLiveRoomRequest confirmSmarLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", confirmSmarLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSmarLiveRoomRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ConfirmSmarLiveRoomResponse>(response);
        }

        public AsyncInvoker<ConfirmSmarLiveRoomResponse> ConfirmSmarLiveRoomAsyncInvoker(ConfirmSmarLiveRoomRequest confirmSmarLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", confirmSmarLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSmarLiveRoomRequest);
            return new AsyncInvoker<ConfirmSmarLiveRoomResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ConfirmSmarLiveRoomResponse>);
        }
        
        /// <summary>
        /// 创建智能直播间
        ///
        /// 该接口用于创建智能直播间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSmartLiveRoomResponse> CreateSmartLiveRoomAsync(CreateSmartLiveRoomRequest createSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartLiveRoomRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSmartLiveRoomResponse>(response);
        }

        public AsyncInvoker<CreateSmartLiveRoomResponse> CreateSmartLiveRoomAsyncInvoker(CreateSmartLiveRoomRequest createSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartLiveRoomRequest);
            return new AsyncInvoker<CreateSmartLiveRoomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 删除智能直播间
        ///
        /// 该接口用于删除智能直播间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSmartLiveRoomResponse> DeleteSmartLiveRoomAsync(DeleteSmartLiveRoomRequest deleteSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartLiveRoomRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSmartLiveRoomResponse>(response);
        }

        public AsyncInvoker<DeleteSmartLiveRoomResponse> DeleteSmartLiveRoomAsyncInvoker(DeleteSmartLiveRoomRequest deleteSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartLiveRoomRequest);
            return new AsyncInvoker<DeleteSmartLiveRoomResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间列表
        ///
        /// 该接口用于智能直播间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSmartLiveRoomsResponse> ListSmartLiveRoomsAsync(ListSmartLiveRoomsRequest listSmartLiveRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRoomsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveRoomsResponse>(response);
        }

        public AsyncInvoker<ListSmartLiveRoomsResponse> ListSmartLiveRoomsAsyncInvoker(ListSmartLiveRoomsRequest listSmartLiveRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRoomsRequest);
            return new AsyncInvoker<ListSmartLiveRoomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveRoomsResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间剧本详情
        ///
        /// 该接口用于查询智能直播间剧本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSmartLiveRoomResponse> ShowSmartLiveRoomAsync(ShowSmartLiveRoomRequest showSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRoomRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartLiveRoomResponse>(response);
        }

        public AsyncInvoker<ShowSmartLiveRoomResponse> ShowSmartLiveRoomAsyncInvoker(ShowSmartLiveRoomRequest showSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRoomRequest);
            return new AsyncInvoker<ShowSmartLiveRoomResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 更新智能直播间信息
        ///
        /// 该接口用于智能直播间信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSmartLiveRoomResponse> UpdateSmartLiveRoomAsync(UpdateSmartLiveRoomRequest updateSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartLiveRoomRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSmartLiveRoomResponse>(response);
        }

        public AsyncInvoker<UpdateSmartLiveRoomResponse> UpdateSmartLiveRoomAsyncInvoker(UpdateSmartLiveRoomRequest updateSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartLiveRoomRequest);
            return new AsyncInvoker<UpdateSmartLiveRoomResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 查询数字人风格列表
        ///
        /// 查询数字人风格列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStylesResponse> ListStylesAsync(ListStylesRequest listStylesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/styles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStylesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStylesResponse>(response);
        }

        public AsyncInvoker<ListStylesResponse> ListStylesAsyncInvoker(ListStylesRequest listStylesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/styles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStylesRequest);
            return new AsyncInvoker<ListStylesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStylesResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人视频字幕文件
        ///
        /// 该接口用于创建分身数字人视频字幕文件任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubtitleFileResponse> CreateSubtitleFileAsync(CreateSubtitleFileRequest createSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubtitleFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSubtitleFileResponse>(response);
        }

        public AsyncInvoker<CreateSubtitleFileResponse> CreateSubtitleFileAsyncInvoker(CreateSubtitleFileRequest createSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubtitleFileRequest);
            return new AsyncInvoker<CreateSubtitleFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubtitleFileResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人视频字幕文件任务详情
        ///
        /// 该接口用于查询分身数字人视频字幕文件任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubtitleFileResponse> ShowSubtitleFileAsync(ShowSubtitleFileRequest showSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSubtitleFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubtitleFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubtitleFileResponse>(response);
        }

        public AsyncInvoker<ShowSubtitleFileResponse> ShowSubtitleFileAsyncInvoker(ShowSubtitleFileRequest showSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSubtitleFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubtitleFileRequest);
            return new AsyncInvoker<ShowSubtitleFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubtitleFileResponse>);
        }
        
        /// <summary>
        /// 统计时间段内过期的资源数量
        ///
        /// 统计指定时间段内即将过期的包周期与一次性资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountTenantResourcesResponse> CountTenantResourcesAsync(CountTenantResourcesRequest countTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTenantResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountTenantResourcesResponse>(response);
        }

        public AsyncInvoker<CountTenantResourcesResponse> CountTenantResourcesAsyncInvoker(CountTenantResourcesRequest countTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTenantResourcesRequest);
            return new AsyncInvoker<CountTenantResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountTenantResourcesResponse>);
        }
        
        /// <summary>
        /// 查看租户资源列表
        ///
        /// 查看租户资源列表。
        ///  &gt; 按需套餐包用量本接口无法查询，需要调用CBC接口查询，详见[按需套餐包用量查询](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0001239.html)和[查询资源包信息](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0000511.html)。
        /// &gt; 各种资源的计费方式请参考[计费说明](https://support.huaweicloud.com/productdesc-metastudio/metastudio_01_0006.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantResourcesResponse> ListTenantResourcesAsync(ListTenantResourcesRequest listTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantResourcesResponse>(response);
        }

        public AsyncInvoker<ListTenantResourcesResponse> ListTenantResourcesAsyncInvoker(ListTenantResourcesRequest listTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantResourcesRequest);
            return new AsyncInvoker<ListTenantResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantResourcesResponse>);
        }
        
        /// <summary>
        /// 查看租户资源用量信息
        ///
        /// 查询租户一次性和包周期（包年/包月）资源用量信息。
        /// &gt; 按需套餐包用量本接口无法查询，需要调用CBC接口查询，详见[按需套餐包用量查询](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0001239.html)和[查询资源包信息](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0000511.html)。
        /// &gt; 各种资源的计费方式请参考[计费说明](https://support.huaweicloud.com/productdesc-metastudio/metastudio_01_0006.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceUsageResponse> ShowResourceUsageAsync(ShowResourceUsageRequest showResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceUsageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceUsageResponse>(response);
        }

        public AsyncInvoker<ShowResourceUsageResponse> ShowResourceUsageAsyncInvoker(ShowResourceUsageRequest showResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceUsageRequest);
            return new AsyncInvoker<ShowResourceUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceUsageResponse>);
        }
        
        /// <summary>
        /// 提交语音训练任务
        ///
        /// 提交训练任务,执行该接口后,任务会进入审核状态,审核完成后会等待训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CommitVoiceTrainingJobResponse> CommitVoiceTrainingJobAsync(CommitVoiceTrainingJobRequest commitVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", commitVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitVoiceTrainingJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CommitVoiceTrainingJobResponse>(response);
        }

        public AsyncInvoker<CommitVoiceTrainingJobResponse> CommitVoiceTrainingJobAsyncInvoker(CommitVoiceTrainingJobRequest commitVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", commitVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitVoiceTrainingJobRequest);
            return new AsyncInvoker<CommitVoiceTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CommitVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 确认在线录音结果
        ///
        /// 确认在线录音结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmTrainingSegmentResponse> ConfirmTrainingSegmentAsync(ConfirmTrainingSegmentRequest confirmTrainingSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmTrainingSegmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ConfirmTrainingSegmentResponse>(response);
        }

        public AsyncInvoker<ConfirmTrainingSegmentResponse> ConfirmTrainingSegmentAsyncInvoker(ConfirmTrainingSegmentRequest confirmTrainingSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmTrainingSegmentRequest);
            return new AsyncInvoker<ConfirmTrainingSegmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmTrainingSegmentResponse>);
        }
        
        /// <summary>
        /// 创建高级版语音训练任务
        ///
        /// 用户创建语音训练高级版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 语音文件为一段WAV格式的长音频文件，仅支持将语音文件打包成zip压缩格式上传。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainingAdvanceJobResponse> CreateTrainingAdvanceJobAsync(CreateTrainingAdvanceJobRequest createTrainingAdvanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/advance-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingAdvanceJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingAdvanceJobResponse>(response);
        }

        public AsyncInvoker<CreateTrainingAdvanceJobResponse> CreateTrainingAdvanceJobAsyncInvoker(CreateTrainingAdvanceJobRequest createTrainingAdvanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/advance-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingAdvanceJobRequest);
            return new AsyncInvoker<CreateTrainingAdvanceJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingAdvanceJobResponse>);
        }
        
        /// <summary>
        /// 创建基础版语音训练任务
        ///
        /// 用户创建语音训练基础版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 支持2种方式上传语音文件：
        /// * 语音文件和文本文件打包成zip上传：语音文件已经切分成20个wav文件，每个语音文件对应一个txt文本文件，所有文件打包成zip文件。语音文件命名规则：0.wav~19.wav；文本文件命名规则：0.txt~19.txt。
        /// * 语音文件和文本文件逐句上传：每次上传一句语料的语音文件和文本文件，再调用“确认在线录音结果”接口确认语音和文本内容是否一致。确认成功后再上传和确认下一句。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainingBasicJobResponse> CreateTrainingBasicJobAsync(CreateTrainingBasicJobRequest createTrainingBasicJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/basic-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingBasicJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingBasicJobResponse>(response);
        }

        public AsyncInvoker<CreateTrainingBasicJobResponse> CreateTrainingBasicJobAsyncInvoker(CreateTrainingBasicJobRequest createTrainingBasicJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/basic-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingBasicJobRequest);
            return new AsyncInvoker<CreateTrainingBasicJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingBasicJobResponse>);
        }
        
        /// <summary>
        /// 创建进阶版语音训练任务
        ///
        /// 用户创建语音训练进阶版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 支持2种方式上传语音文件：
        /// * 语音文件和文本文件打包成zip上传：语音文件已经切分成100个wav文件，每个语音文件对应一个txt文本文件，所有文件打包成zip文件。语音文件命名规则：0.wav~99.wav；文本文件命名规则：0.txt~99.txt。
        /// * 语音文件和文本文件逐句上传：每次上传一句语料的语音文件和文本文件，再调用“确认在线录音结果”接口确认语音和文本内容是否一致。确认成功后再上传和确认下一句。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrainingMiddleJobResponse> CreateTrainingMiddleJobAsync(CreateTrainingMiddleJobRequest createTrainingMiddleJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/middle-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingMiddleJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingMiddleJobResponse>(response);
        }

        public AsyncInvoker<CreateTrainingMiddleJobResponse> CreateTrainingMiddleJobAsyncInvoker(CreateTrainingMiddleJobRequest createTrainingMiddleJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/middle-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingMiddleJobRequest);
            return new AsyncInvoker<CreateTrainingMiddleJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingMiddleJobResponse>);
        }
        
        /// <summary>
        /// 删除语音训练任务
        ///
        /// 删除语音训练任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVoiceTrainingJobResponse> DeleteVoiceTrainingJobAsync(DeleteVoiceTrainingJobRequest deleteVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVoiceTrainingJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVoiceTrainingJobResponse>(response);
        }

        public AsyncInvoker<DeleteVoiceTrainingJobResponse> DeleteVoiceTrainingJobAsyncInvoker(DeleteVoiceTrainingJobRequest deleteVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVoiceTrainingJobRequest);
            return new AsyncInvoker<DeleteVoiceTrainingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 查询任务操作日志
        ///
        /// 查询任务操作日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobOperationLogResponse> ListJobOperationLogAsync(ListJobOperationLogRequest listJobOperationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobOperationLogRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/op-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobOperationLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobOperationLogResponse>(response);
        }

        public AsyncInvoker<ListJobOperationLogResponse> ListJobOperationLogAsyncInvoker(ListJobOperationLogRequest listJobOperationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobOperationLogRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/op-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobOperationLogRequest);
            return new AsyncInvoker<ListJobOperationLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobOperationLogResponse>);
        }
        
        /// <summary>
        /// 查询语音训练任务列表
        ///
        /// 查询语音训练任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVoiceTrainingJobResponse> ListVoiceTrainingJobAsync(ListVoiceTrainingJobRequest listVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoiceTrainingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVoiceTrainingJobResponse>(response);
        }

        public AsyncInvoker<ListVoiceTrainingJobResponse> ListVoiceTrainingJobAsyncInvoker(ListVoiceTrainingJobRequest listVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoiceTrainingJobRequest);
            return new AsyncInvoker<ListVoiceTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 设置任务批次
        ///
        /// 用户设置任务批次，该接口用于批量任务管理场景，设置任务的批次
        /// * 需要开通NA租户权限后才能正常调用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetJobBatchNameResponse> SetJobBatchNameAsync(SetJobBatchNameRequest setJobBatchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setJobBatchNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetJobBatchNameResponse>(response);
        }

        public AsyncInvoker<SetJobBatchNameResponse> SetJobBatchNameAsyncInvoker(SetJobBatchNameRequest setJobBatchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setJobBatchNameRequest);
            return new AsyncInvoker<SetJobBatchNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetJobBatchNameResponse>);
        }
        
        /// <summary>
        /// 获取语音训练任务审核结果
        ///
        /// 获取语音训练任务审核结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobAuditResultResponse> ShowJobAuditResultAsync(ShowJobAuditResultRequest showJobAuditResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobAuditResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/audit-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobAuditResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobAuditResultResponse>(response);
        }

        public AsyncInvoker<ShowJobAuditResultResponse> ShowJobAuditResultAsyncInvoker(ShowJobAuditResultRequest showJobAuditResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobAuditResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/audit-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobAuditResultRequest);
            return new AsyncInvoker<ShowJobAuditResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobAuditResultResponse>);
        }
        
        /// <summary>
        /// 获取语音文件上传地址
        ///
        /// 获取语音文件上传地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobUploadingAddressResponse> ShowJobUploadingAddressAsync(ShowJobUploadingAddressRequest showJobUploadingAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobUploadingAddressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/uploading-address-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobUploadingAddressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobUploadingAddressResponse>(response);
        }

        public AsyncInvoker<ShowJobUploadingAddressResponse> ShowJobUploadingAddressAsyncInvoker(ShowJobUploadingAddressRequest showJobUploadingAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobUploadingAddressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/uploading-address-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobUploadingAddressRequest);
            return new AsyncInvoker<ShowJobUploadingAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobUploadingAddressResponse>);
        }
        
        /// <summary>
        /// 查询用户配置的个性化音频时长
        ///
        /// 查询用户配置的个性化音频时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTenantDurationCfgResponse> ShowTenantDurationCfgAsync(ShowTenantDurationCfgRequest showTenantDurationCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/tenant-duration-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantDurationCfgRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTenantDurationCfgResponse>(response);
        }

        public AsyncInvoker<ShowTenantDurationCfgResponse> ShowTenantDurationCfgAsyncInvoker(ShowTenantDurationCfgRequest showTenantDurationCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/tenant-duration-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantDurationCfgRequest);
            return new AsyncInvoker<ShowTenantDurationCfgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTenantDurationCfgResponse>);
        }
        
        /// <summary>
        /// 获取在线录音确认结果
        ///
        /// 获取在线录音确认结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrainingSegmentInfoResponse> ShowTrainingSegmentInfoAsync(ShowTrainingSegmentInfoRequest showTrainingSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingSegmentInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingSegmentInfoResponse>(response);
        }

        public AsyncInvoker<ShowTrainingSegmentInfoResponse> ShowTrainingSegmentInfoAsyncInvoker(ShowTrainingSegmentInfoRequest showTrainingSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingSegmentInfoRequest);
            return new AsyncInvoker<ShowTrainingSegmentInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingSegmentInfoResponse>);
        }
        
        /// <summary>
        /// 查询语音训练任务详情
        ///
        /// 查询语音训练任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVoiceTrainingJobResponse> ShowVoiceTrainingJobAsync(ShowVoiceTrainingJobRequest showVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVoiceTrainingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVoiceTrainingJobResponse>(response);
        }

        public AsyncInvoker<ShowVoiceTrainingJobResponse> ShowVoiceTrainingJobAsyncInvoker(ShowVoiceTrainingJobRequest showVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVoiceTrainingJobRequest);
            return new AsyncInvoker<ShowVoiceTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人模型训练任务
        ///
        /// 该接口用于创建分身数字人模型训练任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Create2dModelTrainingJobResponse> Create2dModelTrainingJobAsync(Create2dModelTrainingJobRequest create2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2dModelTrainingJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<Create2dModelTrainingJobResponse>(response);
        }

        public AsyncInvoker<Create2dModelTrainingJobResponse> Create2dModelTrainingJobAsyncInvoker(Create2dModelTrainingJobRequest create2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2dModelTrainingJobRequest);
            return new AsyncInvoker<Create2dModelTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<Create2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 删除分身数字人模型训练任务
        ///
        /// 该接口用于删除分身数字人模型训练任务。同时需要删除训练任务相关的训练视频、身份证照片、授权文件、模型资产等。
        /// &gt; * 该接口应当在任务处于以下状态时调用：WAIT_FILE_UPLOAD、AUTO_VERIFY_FAILED、MANUAL_VERIFYING、MANUAL_VERIFY_FAILED、TRAINING_DATA_PREPROCESS_FAILED、TRAIN_FAILED、INFERENCE_DATA_PREPROCESS_FAILED、JOB_SUCCESS、WAIT_USER_CONFIRM、JOB_REJECT、JOB_FINISH
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Delete2dModelTrainingJobResponse> Delete2dModelTrainingJobAsync(Delete2dModelTrainingJobRequest delete2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", delete2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", delete2dModelTrainingJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<Delete2dModelTrainingJobResponse>(response);
        }

        public AsyncInvoker<Delete2dModelTrainingJobResponse> Delete2dModelTrainingJobAsyncInvoker(Delete2dModelTrainingJobRequest delete2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", delete2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", delete2dModelTrainingJobRequest);
            return new AsyncInvoker<Delete2dModelTrainingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<Delete2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 租户执行分身数字人模型训练任务命令
        ///
        /// 该接口用于租户执行分身数字人模型训练任务命令，如提交训练审核等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Execute2dModelTrainingCommandByUserResponse> Execute2dModelTrainingCommandByUserAsync(Execute2dModelTrainingCommandByUserRequest execute2dModelTrainingCommandByUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", execute2dModelTrainingCommandByUserRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", execute2dModelTrainingCommandByUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<Execute2dModelTrainingCommandByUserResponse>(response);
        }

        public AsyncInvoker<Execute2dModelTrainingCommandByUserResponse> Execute2dModelTrainingCommandByUserAsyncInvoker(Execute2dModelTrainingCommandByUserRequest execute2dModelTrainingCommandByUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", execute2dModelTrainingCommandByUserRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", execute2dModelTrainingCommandByUserRequest);
            return new AsyncInvoker<Execute2dModelTrainingCommandByUserResponse>(this, "POST", request, JsonUtils.DeSerialize<Execute2dModelTrainingCommandByUserResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人模型训练任务列表
        ///
        /// 该接口用于查询分身数字人模型训练任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<List2dModelTrainingJobResponse> List2dModelTrainingJobAsync(List2dModelTrainingJobRequest list2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", list2dModelTrainingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<List2dModelTrainingJobResponse>(response);
        }

        public AsyncInvoker<List2dModelTrainingJobResponse> List2dModelTrainingJobAsyncInvoker(List2dModelTrainingJobRequest list2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", list2dModelTrainingJobRequest);
            return new AsyncInvoker<List2dModelTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<List2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人模型训练任务详情
        ///
        /// 该接口用于查询分身数字人模型训练任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Show2dModelTrainingJobResponse> Show2dModelTrainingJobAsync(Show2dModelTrainingJobRequest show2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2dModelTrainingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<Show2dModelTrainingJobResponse>(response);
        }

        public AsyncInvoker<Show2dModelTrainingJobResponse> Show2dModelTrainingJobAsyncInvoker(Show2dModelTrainingJobRequest show2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2dModelTrainingJobRequest);
            return new AsyncInvoker<Show2dModelTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<Show2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 更新分身数字人模型训练任务
        ///
        /// 该接口用于更新分身数字人模型训练任务。用于在自动审核或者人工审核不通过情况下，更新训练视频、身份证照片等。
        /// &gt; * 该接口只能在AUTO_VERIFY_FAILED或者MANUAL_VERIFY_FAILED状态下调用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<Update2dModelTrainingJobResponse> Update2dModelTrainingJobAsync(Update2dModelTrainingJobRequest update2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", update2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", update2dModelTrainingJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<Update2dModelTrainingJobResponse>(response);
        }

        public AsyncInvoker<Update2dModelTrainingJobResponse> Update2dModelTrainingJobAsyncInvoker(Update2dModelTrainingJobRequest update2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", update2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", update2dModelTrainingJobRequest);
            return new AsyncInvoker<Update2dModelTrainingJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<Update2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 创建语音驱动表情动画任务
        ///
        /// 该接口用于创建驱动数字人表情的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFacialAnimationsResponse> CreateFacialAnimationsAsync(CreateFacialAnimationsRequest createFacialAnimationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa/fas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFacialAnimationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFacialAnimationsResponse>(response);
        }

        public AsyncInvoker<CreateFacialAnimationsResponse> CreateFacialAnimationsAsyncInvoker(CreateFacialAnimationsRequest createFacialAnimationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa/fas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFacialAnimationsRequest);
            return new AsyncInvoker<CreateFacialAnimationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFacialAnimationsResponse>);
        }
        
        /// <summary>
        /// 创建语音驱动任务
        ///
        /// 该接口用于创建驱动数字人表情、动作及语音的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTtsaResponse> CreateTtsaAsync(CreateTtsaRequest createTtsaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsaRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTtsaResponse>(response);
        }

        public AsyncInvoker<CreateTtsaResponse> CreateTtsaAsyncInvoker(CreateTtsaRequest createTtsaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsaRequest);
            return new AsyncInvoker<CreateTtsaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtsaResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动表情数据
        ///
        /// 该接口用于获取生成的数字人表情驱动数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFacialAnimationsDataResponse> ListFacialAnimationsDataAsync(ListFacialAnimationsDataRequest listFacialAnimationsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listFacialAnimationsDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fas-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFacialAnimationsDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFacialAnimationsDataResponse>(response);
        }

        public AsyncInvoker<ListFacialAnimationsDataResponse> ListFacialAnimationsDataAsyncInvoker(ListFacialAnimationsDataRequest listFacialAnimationsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listFacialAnimationsDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fas-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFacialAnimationsDataRequest);
            return new AsyncInvoker<ListFacialAnimationsDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFacialAnimationsDataResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动数据
        ///
        /// 该接口用于获取生成的数字人驱动数据，包括语音、表情、动作等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTtsaDataResponse> ListTtsaDataAsync(ListTtsaDataRequest listTtsaDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTtsaDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTtsaDataResponse>(response);
        }

        public AsyncInvoker<ListTtsaDataResponse> ListTtsaDataAsyncInvoker(ListTtsaDataRequest listTtsaDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTtsaDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaDataRequest);
            return new AsyncInvoker<ListTtsaDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtsaDataResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动任务列表
        ///
        /// 该接口用于查询驱动数字人表情、动作及语音的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTtsaJobsResponse> ListTtsaJobsAsync(ListTtsaJobsRequest listTtsaJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTtsaJobsResponse>(response);
        }

        public AsyncInvoker<ListTtsaJobsResponse> ListTtsaJobsAsyncInvoker(ListTtsaJobsRequest listTtsaJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaJobsRequest);
            return new AsyncInvoker<ListTtsaJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtsaJobsResponse>);
        }
        
        /// <summary>
        /// 校验音色模型是否可用（自研和第三方音色）
        ///
        /// 该接口用于校验音色模型是否可用，模型可用返回模型信息，不可用返回具体不可用的原因
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckVoiceAssetResponse> CheckVoiceAssetAsync(CheckVoiceAssetRequest checkVoiceAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("voice_asset_id", checkVoiceAssetRequest.VoiceAssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/check-voice-asset/{voice_asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVoiceAssetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckVoiceAssetResponse>(response);
        }

        public AsyncInvoker<CheckVoiceAssetResponse> CheckVoiceAssetAsyncInvoker(CheckVoiceAssetRequest checkVoiceAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("voice_asset_id", checkVoiceAssetRequest.VoiceAssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/check-voice-asset/{voice_asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkVoiceAssetRequest);
            return new AsyncInvoker<CheckVoiceAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckVoiceAssetResponse>);
        }
        
        /// <summary>
        /// 获取TTS语音合成任务记录
        ///
        /// 该接口用于获取TTS语音合成任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTtsJobResponse> ShowTtsJobAsync(ShowTtsJobRequest showTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tts-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTtsJobResponse>(response);
        }

        public AsyncInvoker<ShowTtsJobResponse> ShowTtsJobAsyncInvoker(ShowTtsJobRequest showTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tts-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsJobRequest);
            return new AsyncInvoker<ShowTtsJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTtsJobResponse>);
        }
        
        /// <summary>
        /// 获取英文单词音标
        ///
        /// 根据英文单词返回对应音标列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTtsPhoneticSymbolResponse> ShowTtsPhoneticSymbolAsync(ShowTtsPhoneticSymbolRequest showTtsPhoneticSymbolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/phonetic-symbol", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsPhoneticSymbolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTtsPhoneticSymbolResponse>(response);
        }

        public AsyncInvoker<ShowTtsPhoneticSymbolResponse> ShowTtsPhoneticSymbolAsyncInvoker(ShowTtsPhoneticSymbolRequest showTtsPhoneticSymbolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/phonetic-symbol", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsPhoneticSymbolRequest);
            return new AsyncInvoker<ShowTtsPhoneticSymbolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTtsPhoneticSymbolResponse>);
        }
        
        /// <summary>
        /// 创建TTS异步任务
        ///
        /// 该接口用于对外生成音频文件。每个预置音色的计费标准详见[预置音色计费标准](metastudio_02_0060.xml)。
        /// 
        /// &gt; 使用本接口前，需要在MetaStudio控制台服务概览页面，开通“声音合成”的按需计费。
        /// &gt; 详细操作为：单击“声音合成”卡片中的“去开通”，在弹出的“开通按需计费服务提示”对话框中，勾选同意协议。单击“确定”，开通按需计费。
        /// &gt; 如需使用第三方声音进行语音合成，请购买出门问问声音套餐，操作请参考《用户指南》的“购买出门问问声音套餐”章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAsyncTtsJobResponse> CreateAsyncTtsJobAsync(CreateAsyncTtsJobRequest createAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncTtsJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAsyncTtsJobResponse>(response);
        }

        public AsyncInvoker<CreateAsyncTtsJobResponse> CreateAsyncTtsJobAsyncInvoker(CreateAsyncTtsJobRequest createAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncTtsJobRequest);
            return new AsyncInvoker<CreateAsyncTtsJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAsyncTtsJobResponse>);
        }
        
        /// <summary>
        /// 创建TTS试听任务
        ///
        /// 该接口用于创建生成播报内容的语音试听文件任务。
        /// 
        /// [第三方音色试听需要收费，收费标准参考：https://marketplace.huaweicloud.com/product/OFFI919400645308506112#productid&#x3D;OFFI919400645308506112](tag:hc)
        /// 
        /// [第三方音色试听需要收费，收费标准参考：https://marketplace.huaweicloud.com/intl/contents/939bf377-3005-472b-a4e2-383911e6102f](tag:hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTtsAuditionResponse> CreateTtsAuditionAsync(CreateTtsAuditionRequest createTtsAuditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsAuditionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTtsAuditionResponse>(response);
        }

        public AsyncInvoker<CreateTtsAuditionResponse> CreateTtsAuditionAsyncInvoker(CreateTtsAuditionRequest createTtsAuditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsAuditionRequest);
            return new AsyncInvoker<CreateTtsAuditionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtsAuditionResponse>);
        }
        
        /// <summary>
        /// 获取TTS异步任务
        ///
        /// 该接口用于获取TTS音频文件下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAsyncTtsJobResponse> ShowAsyncTtsJobAsync(ShowAsyncTtsJobRequest showAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAsyncTtsJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncTtsJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAsyncTtsJobResponse>(response);
        }

        public AsyncInvoker<ShowAsyncTtsJobResponse> ShowAsyncTtsJobAsyncInvoker(ShowAsyncTtsJobRequest showAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAsyncTtsJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncTtsJobRequest);
            return new AsyncInvoker<ShowAsyncTtsJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsyncTtsJobResponse>);
        }
        
        /// <summary>
        /// 获取TTS试听文件
        ///
        /// 该接口用于获取TTS试听文件下载链接，返回List中包含当前已生产的试听文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTtsAuditionFileResponse> ShowTtsAuditionFileAsync(ShowTtsAuditionFileRequest showTtsAuditionFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTtsAuditionFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition-file/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsAuditionFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTtsAuditionFileResponse>(response);
        }

        public AsyncInvoker<ShowTtsAuditionFileResponse> ShowTtsAuditionFileAsyncInvoker(ShowTtsAuditionFileRequest showTtsAuditionFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTtsAuditionFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition-file/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsAuditionFileRequest);
            return new AsyncInvoker<ShowTtsAuditionFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTtsAuditionFileResponse>);
        }
        
        /// <summary>
        /// 设置TTS租户级自定义读法配置
        ///
        /// 该接口用于设置TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTtscVocabularyConfigsResponse> CreateTtscVocabularyConfigsAsync(CreateTtscVocabularyConfigsRequest createTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyConfigsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTtscVocabularyConfigsResponse>(response);
        }

        public AsyncInvoker<CreateTtscVocabularyConfigsResponse> CreateTtscVocabularyConfigsAsyncInvoker(CreateTtscVocabularyConfigsRequest createTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyConfigsRequest);
            return new AsyncInvoker<CreateTtscVocabularyConfigsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 设置TTS租户级词表分组配置
        ///
        /// 该接口用于设置TTS租户级词表分组配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTtscVocabularyGroupsResponse> CreateTtscVocabularyGroupsAsync(CreateTtscVocabularyGroupsRequest createTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTtscVocabularyGroupsResponse>(response);
        }

        public AsyncInvoker<CreateTtscVocabularyGroupsResponse> CreateTtscVocabularyGroupsAsyncInvoker(CreateTtscVocabularyGroupsRequest createTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyGroupsRequest);
            return new AsyncInvoker<CreateTtscVocabularyGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtscVocabularyGroupsResponse>);
        }
        
        /// <summary>
        /// 删除TTS租户级自定义读法配置
        ///
        /// 该接口用于删除TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTtscVocabularyConfigsResponse> DeleteTtscVocabularyConfigsAsync(DeleteTtscVocabularyConfigsRequest deleteTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyConfigsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTtscVocabularyConfigsResponse>(response);
        }

        public AsyncInvoker<DeleteTtscVocabularyConfigsResponse> DeleteTtscVocabularyConfigsAsyncInvoker(DeleteTtscVocabularyConfigsRequest deleteTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyConfigsRequest);
            return new AsyncInvoker<DeleteTtscVocabularyConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 删除TTS租户级词表分组
        ///
        /// 该接口用于删除TTS租户级词表分组配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTtscVocabularyGroupsResponse> DeleteTtscVocabularyGroupsAsync(DeleteTtscVocabularyGroupsRequest deleteTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteTtscVocabularyGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyGroupsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTtscVocabularyGroupsResponse>(response);
        }

        public AsyncInvoker<DeleteTtscVocabularyGroupsResponse> DeleteTtscVocabularyGroupsAsyncInvoker(DeleteTtscVocabularyGroupsRequest deleteTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteTtscVocabularyGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyGroupsRequest);
            return new AsyncInvoker<DeleteTtscVocabularyGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTtscVocabularyGroupsResponse>);
        }
        
        /// <summary>
        /// 获取TTS租户级自定义读法配置
        ///
        /// 该接口用于获取TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTtscVocabularyConfigsResponse> ListTtscVocabularyConfigsAsync(ListTtscVocabularyConfigsRequest listTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTtscVocabularyConfigsResponse>(response);
        }

        public AsyncInvoker<ListTtscVocabularyConfigsResponse> ListTtscVocabularyConfigsAsyncInvoker(ListTtscVocabularyConfigsRequest listTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyConfigsRequest);
            return new AsyncInvoker<ListTtscVocabularyConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 获取TTS租户级词表分组列表
        ///
        /// 该接口用于获取TTS租户级词表分组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTtscVocabularyGroupsResponse> ListTtscVocabularyGroupsAsync(ListTtscVocabularyGroupsRequest listTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTtscVocabularyGroupsResponse>(response);
        }

        public AsyncInvoker<ListTtscVocabularyGroupsResponse> ListTtscVocabularyGroupsAsyncInvoker(ListTtscVocabularyGroupsRequest listTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyGroupsRequest);
            return new AsyncInvoker<ListTtscVocabularyGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtscVocabularyGroupsResponse>);
        }
        
        /// <summary>
        /// 设置租户级配置
        ///
        /// 该接口用于设置租户级配置，当前用于租户级自定义读法配置的全局开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveTtscTenantConfigsResponse> SaveTtscTenantConfigsAsync(SaveTtscTenantConfigsRequest saveTtscTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscTenantConfigsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SaveTtscTenantConfigsResponse>(response);
        }

        public AsyncInvoker<SaveTtscTenantConfigsResponse> SaveTtscTenantConfigsAsyncInvoker(SaveTtscTenantConfigsRequest saveTtscTenantConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscTenantConfigsRequest);
            return new AsyncInvoker<SaveTtscTenantConfigsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SaveTtscTenantConfigsResponse>);
        }
        
        /// <summary>
        /// 修改TTS租户级自定义读法配置
        ///
        /// 该接口用于修改TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveTtscVocabularyConfigsResponse> SaveTtscVocabularyConfigsAsync(SaveTtscVocabularyConfigsRequest saveTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id", saveTtscVocabularyConfigsRequest.VocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscVocabularyConfigsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SaveTtscVocabularyConfigsResponse>(response);
        }

        public AsyncInvoker<SaveTtscVocabularyConfigsResponse> SaveTtscVocabularyConfigsAsyncInvoker(SaveTtscVocabularyConfigsRequest saveTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id", saveTtscVocabularyConfigsRequest.VocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscVocabularyConfigsRequest);
            return new AsyncInvoker<SaveTtscVocabularyConfigsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SaveTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 设置TTS租户级词表分组的资产列表
        ///
        /// 该接口用于设置TTS租户级词表分组的资产列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetTtscGroupAssetsResponse> SetTtscGroupAssetsAsync(SetTtscGroupAssetsRequest setTtscGroupAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", setTtscGroupAssetsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/group-assets/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTtscGroupAssetsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetTtscGroupAssetsResponse>(response);
        }

        public AsyncInvoker<SetTtscGroupAssetsResponse> SetTtscGroupAssetsAsyncInvoker(SetTtscGroupAssetsRequest setTtscGroupAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", setTtscGroupAssetsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/group-assets/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTtscGroupAssetsRequest);
            return new AsyncInvoker<SetTtscGroupAssetsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetTtscGroupAssetsResponse>);
        }
        
        /// <summary>
        /// 获取租户级全局配置
        ///
        /// 该接口用于获取租户级全局配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVocabularySwitchConfigsResponse> ShowVocabularySwitchConfigsAsync(ShowVocabularySwitchConfigsRequest showVocabularySwitchConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularySwitchConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVocabularySwitchConfigsResponse>(response);
        }

        public AsyncInvoker<ShowVocabularySwitchConfigsResponse> ShowVocabularySwitchConfigsAsyncInvoker(ShowVocabularySwitchConfigsRequest showVocabularySwitchConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/tenant-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularySwitchConfigsRequest);
            return new AsyncInvoker<ShowVocabularySwitchConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVocabularySwitchConfigsResponse>);
        }
        
        /// <summary>
        /// TTS租户级词表分组重命名
        ///
        /// 该接口用于对TTS租户级词表分组重命名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTtscVocabularyGroupsResponse> UpdateTtscVocabularyGroupsAsync(UpdateTtscVocabularyGroupsRequest updateTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateTtscVocabularyGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTtscVocabularyGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTtscVocabularyGroupsResponse>(response);
        }

        public AsyncInvoker<UpdateTtscVocabularyGroupsResponse> UpdateTtscVocabularyGroupsAsyncInvoker(UpdateTtscVocabularyGroupsRequest updateTtscVocabularyGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateTtscVocabularyGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTtscVocabularyGroupsRequest);
            return new AsyncInvoker<UpdateTtscVocabularyGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTtscVocabularyGroupsResponse>);
        }
        
        /// <summary>
        /// 创建视频驱动任务
        ///
        /// 该接口用于创建视频驱动任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVideoMotionCaptureJobResponse> CreateVideoMotionCaptureJobAsync(CreateVideoMotionCaptureJobRequest createVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoMotionCaptureJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVideoMotionCaptureJobResponse>(response);
        }

        public AsyncInvoker<CreateVideoMotionCaptureJobResponse> CreateVideoMotionCaptureJobAsyncInvoker(CreateVideoMotionCaptureJobRequest createVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoMotionCaptureJobRequest);
            return new AsyncInvoker<CreateVideoMotionCaptureJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 控制数字人驱动
        ///
        /// 该接口用于控制数字人驱动。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteVideoMotionCaptureCommandResponse> ExecuteVideoMotionCaptureCommandAsync(ExecuteVideoMotionCaptureCommandRequest executeVideoMotionCaptureCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeVideoMotionCaptureCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeVideoMotionCaptureCommandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExecuteVideoMotionCaptureCommandResponse>(response);
        }

        public AsyncInvoker<ExecuteVideoMotionCaptureCommandResponse> ExecuteVideoMotionCaptureCommandAsyncInvoker(ExecuteVideoMotionCaptureCommandRequest executeVideoMotionCaptureCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeVideoMotionCaptureCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeVideoMotionCaptureCommandRequest);
            return new AsyncInvoker<ExecuteVideoMotionCaptureCommandResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteVideoMotionCaptureCommandResponse>);
        }
        
        /// <summary>
        /// 查询视频驱动任务列表
        ///
        /// 该接口用于查询视频驱动任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVideoMotionCaptureJobsResponse> ListVideoMotionCaptureJobsAsync(ListVideoMotionCaptureJobsRequest listVideoMotionCaptureJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoMotionCaptureJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVideoMotionCaptureJobsResponse>(response);
        }

        public AsyncInvoker<ListVideoMotionCaptureJobsResponse> ListVideoMotionCaptureJobsAsyncInvoker(ListVideoMotionCaptureJobsRequest listVideoMotionCaptureJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoMotionCaptureJobsRequest);
            return new AsyncInvoker<ListVideoMotionCaptureJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVideoMotionCaptureJobsResponse>);
        }
        
        /// <summary>
        /// 查询视频驱动任务详情
        ///
        /// 该接口用于查询视频驱动任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVideoMotionCaptureJobResponse> ShowVideoMotionCaptureJobAsync(ShowVideoMotionCaptureJobRequest showVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoMotionCaptureJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVideoMotionCaptureJobResponse>(response);
        }

        public AsyncInvoker<ShowVideoMotionCaptureJobResponse> ShowVideoMotionCaptureJobAsyncInvoker(ShowVideoMotionCaptureJobRequest showVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoMotionCaptureJobRequest);
            return new AsyncInvoker<ShowVideoMotionCaptureJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 停止视频驱动任务
        ///
        /// 该接口用于停止视频驱动任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopVideoMotionCaptureJobResponse> StopVideoMotionCaptureJobAsync(StopVideoMotionCaptureJobRequest stopVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/finish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopVideoMotionCaptureJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopVideoMotionCaptureJobResponse>(response);
        }

        public AsyncInvoker<StopVideoMotionCaptureJobResponse> StopVideoMotionCaptureJobAsyncInvoker(StopVideoMotionCaptureJobRequest stopVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/finish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopVideoMotionCaptureJobRequest);
            return new AsyncInvoker<StopVideoMotionCaptureJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 复制视频制作剧本
        ///
        /// 该接口用于复制视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyVideoScriptsResponse> CopyVideoScriptsAsync(CopyVideoScriptsRequest copyVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", copyVideoScriptsRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyVideoScriptsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyVideoScriptsResponse>(response);
        }

        public AsyncInvoker<CopyVideoScriptsResponse> CopyVideoScriptsAsyncInvoker(CopyVideoScriptsRequest copyVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", copyVideoScriptsRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyVideoScriptsRequest);
            return new AsyncInvoker<CopyVideoScriptsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 创建视频制作剧本
        ///
        /// 该接口用于创建视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVideoScriptsResponse> CreateVideoScriptsAsync(CreateVideoScriptsRequest createVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoScriptsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVideoScriptsResponse>(response);
        }

        public AsyncInvoker<CreateVideoScriptsResponse> CreateVideoScriptsAsyncInvoker(CreateVideoScriptsRequest createVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoScriptsRequest);
            return new AsyncInvoker<CreateVideoScriptsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 删除视频制作剧本
        ///
        /// 该接口用于删除视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVideoScriptResponse> DeleteVideoScriptAsync(DeleteVideoScriptRequest deleteVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVideoScriptRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVideoScriptResponse>(response);
        }

        public AsyncInvoker<DeleteVideoScriptResponse> DeleteVideoScriptAsyncInvoker(DeleteVideoScriptRequest deleteVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVideoScriptRequest);
            return new AsyncInvoker<DeleteVideoScriptResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVideoScriptResponse>);
        }
        
        /// <summary>
        /// 查询视频制作剧本列表
        ///
        /// 该接口用于查询视频制作剧本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVideoScriptsResponse> ListVideoScriptsAsync(ListVideoScriptsRequest listVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoScriptsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVideoScriptsResponse>(response);
        }

        public AsyncInvoker<ListVideoScriptsResponse> ListVideoScriptsAsyncInvoker(ListVideoScriptsRequest listVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoScriptsRequest);
            return new AsyncInvoker<ListVideoScriptsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 查询视频制作剧本详情
        ///
        /// 该接口用于查询视频制作剧本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVideoScriptResponse> ShowVideoScriptAsync(ShowVideoScriptRequest showVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoScriptRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVideoScriptResponse>(response);
        }

        public AsyncInvoker<ShowVideoScriptResponse> ShowVideoScriptAsyncInvoker(ShowVideoScriptRequest showVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoScriptRequest);
            return new AsyncInvoker<ShowVideoScriptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVideoScriptResponse>);
        }
        
        /// <summary>
        /// 更新视频制作剧本
        ///
        /// 该接口用于更新视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVideoScriptResponse> UpdateVideoScriptAsync(UpdateVideoScriptRequest updateVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVideoScriptRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVideoScriptResponse>(response);
        }

        public AsyncInvoker<UpdateVideoScriptResponse> UpdateVideoScriptAsyncInvoker(UpdateVideoScriptRequest updateVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVideoScriptRequest);
            return new AsyncInvoker<UpdateVideoScriptResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVideoScriptResponse>);
        }
        
        /// <summary>
        /// 创建欢迎词
        ///
        /// 该接口用于创建欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWelcomeSpeechResponse> CreateWelcomeSpeechAsync(CreateWelcomeSpeechRequest createWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWelcomeSpeechRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWelcomeSpeechResponse>(response);
        }

        public AsyncInvoker<CreateWelcomeSpeechResponse> CreateWelcomeSpeechAsyncInvoker(CreateWelcomeSpeechRequest createWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWelcomeSpeechRequest);
            return new AsyncInvoker<CreateWelcomeSpeechResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 删除欢迎词
        ///
        /// 该接口用于删除欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWelcomeSpeechResponse> DeleteWelcomeSpeechAsync(DeleteWelcomeSpeechRequest deleteWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWelcomeSpeechRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteWelcomeSpeechResponse>(response);
        }

        public AsyncInvoker<DeleteWelcomeSpeechResponse> DeleteWelcomeSpeechAsyncInvoker(DeleteWelcomeSpeechRequest deleteWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWelcomeSpeechRequest);
            return new AsyncInvoker<DeleteWelcomeSpeechResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词列表
        ///
        /// 该接口用于查询欢迎词列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWelcomeSpeechResponse> ListWelcomeSpeechAsync(ListWelcomeSpeechRequest listWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWelcomeSpeechRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWelcomeSpeechResponse>(response);
        }

        public AsyncInvoker<ListWelcomeSpeechResponse> ListWelcomeSpeechAsyncInvoker(ListWelcomeSpeechRequest listWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWelcomeSpeechRequest);
            return new AsyncInvoker<ListWelcomeSpeechResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词详情
        ///
        /// 该接口用于查询欢迎词详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWelcomeSpeechResponse> ShowWelcomeSpeechAsync(ShowWelcomeSpeechRequest showWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", showWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWelcomeSpeechResponse>(response);
        }

        public AsyncInvoker<ShowWelcomeSpeechResponse> ShowWelcomeSpeechAsyncInvoker(ShowWelcomeSpeechRequest showWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", showWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechRequest);
            return new AsyncInvoker<ShowWelcomeSpeechResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词功能开关
        ///
        /// 该接口用于查询欢迎词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWelcomeSpeechSwitchResponse> ShowWelcomeSpeechSwitchAsync(ShowWelcomeSpeechSwitchRequest showWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWelcomeSpeechSwitchResponse>(response);
        }

        public AsyncInvoker<ShowWelcomeSpeechSwitchResponse> ShowWelcomeSpeechSwitchAsyncInvoker(ShowWelcomeSpeechSwitchRequest showWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechSwitchRequest);
            return new AsyncInvoker<ShowWelcomeSpeechSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWelcomeSpeechSwitchResponse>);
        }
        
        /// <summary>
        /// 修改欢迎词
        ///
        /// 该接口用于修改欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWelcomeSpeechResponse> UpdateWelcomeSpeechAsync(UpdateWelcomeSpeechRequest updateWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", updateWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWelcomeSpeechResponse>(response);
        }

        public AsyncInvoker<UpdateWelcomeSpeechResponse> UpdateWelcomeSpeechAsyncInvoker(UpdateWelcomeSpeechRequest updateWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", updateWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechRequest);
            return new AsyncInvoker<UpdateWelcomeSpeechResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 修改欢迎词功能开关
        ///
        /// 该接口用于修改欢迎词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWelcomeSpeechSwitchResponse> UpdateWelcomeSpeechSwitchAsync(UpdateWelcomeSpeechSwitchRequest updateWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateWelcomeSpeechSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateWelcomeSpeechSwitchResponse> UpdateWelcomeSpeechSwitchAsyncInvoker(UpdateWelcomeSpeechSwitchRequest updateWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechSwitchRequest);
            return new AsyncInvoker<UpdateWelcomeSpeechSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateWelcomeSpeechSwitchResponse>);
        }
        
    }
}