using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Frs.V2.Model;

namespace HuaweiCloud.SDK.Frs.V2
{
    public partial class FrsAsyncClient : Client
    {
        public static ClientBuilder<FrsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<FrsAsyncClient>();
        }

        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public async Task<AddFacesByBase64Response> AddFacesByBase64Async(AddFacesByBase64Request addFacesByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByBase64Request.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByBase64Response>(response);
        }
        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public async Task<AddFacesByFileResponse> AddFacesByFileAsync(AddFacesByFileRequest addFacesByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByFileRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByFileResponse>(response);
        }
        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public async Task<AddFacesByUrlResponse> AddFacesByUrlAsync(AddFacesByUrlRequest addFacesByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByUrlRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByUrlResponse>(response);
        }
        
        /// <summary>
        /// 批量删除人脸
        /// </summary>
        public async Task<BatchDeleteFacesResponse> BatchDeleteFacesAsync(BatchDeleteFacesRequest batchDeleteFacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , batchDeleteFacesRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteFacesResponse>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public async Task<CompareFaceByBase64Response> CompareFaceByBase64Async(CompareFaceByBase64Request compareFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public async Task<CompareFaceByFileResponse> CompareFaceByFileAsync(CompareFaceByFileRequest compareFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public async Task<CompareFaceByUrlResponse> CompareFaceByUrlAsync(CompareFaceByUrlRequest compareFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 创建人脸库
        /// </summary>
        public async Task<CreateFaceSetResponse> CreateFaceSetAsync(CreateFaceSetRequest createFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸
        /// </summary>
        public async Task<DeleteFaceByExternalImageIdResponse> DeleteFaceByExternalImageIdAsync(DeleteFaceByExternalImageIdRequest deleteFaceByExternalImageIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸
        /// </summary>
        public async Task<DeleteFaceByFaceIdResponse> DeleteFaceByFaceIdAsync(DeleteFaceByFaceIdRequest deleteFaceByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸库
        /// </summary>
        public async Task<DeleteFaceSetResponse> DeleteFaceSetAsync(DeleteFaceSetRequest deleteFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceSetRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public async Task<DetectFaceByBase64Response> DetectFaceByBase64Async(DetectFaceByBase64Request detectFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public async Task<DetectFaceByFileResponse> DetectFaceByFileAsync(DetectFaceByFileRequest detectFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public async Task<DetectFaceByUrlResponse> DetectFaceByUrlAsync(DetectFaceByUrlRequest detectFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public async Task<DetectLiveByBase64Response> DetectLiveByBase64Async(DetectLiveByBase64Request detectLiveByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByBase64Response>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public async Task<DetectLiveByFileResponse> DetectLiveByFileAsync(DetectLiveByFileRequest detectLiveByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByFileResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public async Task<DetectLiveByUrlResponse> DetectLiveByUrlAsync(DetectLiveByUrlRequest detectLiveByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByUrlResponse>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public async Task<DetectLiveFaceByBase64Response> DetectLiveFaceByBase64Async(DetectLiveFaceByBase64Request detectLiveFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public async Task<DetectLiveFaceByFileResponse> DetectLiveFaceByFileAsync(DetectLiveFaceByFileRequest detectLiveFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public async Task<DetectLiveFaceByUrlResponse> DetectLiveFaceByUrlAsync(DetectLiveFaceByUrlRequest detectLiveFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public async Task<SearchFaceByBase64Response> SearchFaceByBase64Async(SearchFaceByBase64Request searchFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByBase64Request.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public async Task<SearchFaceByFaceIdResponse> SearchFaceByFaceIdAsync(SearchFaceByFaceIdRequest searchFaceByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public async Task<SearchFaceByFileResponse> SearchFaceByFileAsync(SearchFaceByFileRequest searchFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByFileRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public async Task<SearchFaceByUrlResponse> SearchFaceByUrlAsync(SearchFaceByUrlRequest searchFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByUrlRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 查询所有人脸库
        /// </summary>
        public async Task<ShowAllFaceSetsResponse> ShowAllFaceSetsAsync(ShowAllFaceSetsRequest showAllFaceSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAllFaceSetsResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸库
        /// </summary>
        public async Task<ShowFaceSetResponse> ShowFaceSetAsync(ShowFaceSetRequest showFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFaceSetRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸
        /// </summary>
        public async Task<ShowFacesByFaceIdResponse> ShowFacesByFaceIdAsync(ShowFacesByFaceIdRequest showFacesByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFacesByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸
        /// </summary>
        public async Task<ShowFacesByLimitResponse> ShowFacesByLimitAsync(ShowFacesByLimitRequest showFacesByLimitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFacesByLimitRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFacesByLimitResponse>(response);
        }
        
        /// <summary>
        /// 更新人脸
        /// </summary>
        public async Task<UpdateFaceResponse> UpdateFaceAsync(UpdateFaceRequest updateFaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , updateFaceRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFaceResponse>(response);
        }
        
    }
}