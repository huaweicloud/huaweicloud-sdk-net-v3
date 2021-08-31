using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Frs.V2.Model;

namespace HuaweiCloud.SDK.Frs.V2
{
    public partial class FrsClient : Client
    {
        public static ClientBuilder<FrsClient> NewBuilder()
        {
            return new ClientBuilder<FrsClient>();
        }

        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public AddFacesByBase64Response AddFacesByBase64(AddFacesByBase64Request addFacesByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByBase64Request.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByBase64Response>(response);
        }
        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public AddFacesByFileResponse AddFacesByFile(AddFacesByFileRequest addFacesByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByFileRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByFileResponse>(response);
        }
        
        /// <summary>
        /// 添加人脸
        /// </summary>
        public AddFacesByUrlResponse AddFacesByUrl(AddFacesByUrlRequest addFacesByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , addFacesByUrlRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddFacesByUrlResponse>(response);
        }
        
        /// <summary>
        /// 批量删除人脸
        /// </summary>
        public BatchDeleteFacesResponse BatchDeleteFaces(BatchDeleteFacesRequest batchDeleteFacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , batchDeleteFacesRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteFacesResponse>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public CompareFaceByBase64Response CompareFaceByBase64(CompareFaceByBase64Request compareFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public CompareFaceByFileResponse CompareFaceByFile(CompareFaceByFileRequest compareFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸比对
        /// </summary>
        public CompareFaceByUrlResponse CompareFaceByUrl(CompareFaceByUrlRequest compareFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CompareFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 创建人脸库
        /// </summary>
        public CreateFaceSetResponse CreateFaceSet(CreateFaceSetRequest createFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸
        /// </summary>
        public DeleteFaceByExternalImageIdResponse DeleteFaceByExternalImageId(DeleteFaceByExternalImageIdRequest deleteFaceByExternalImageIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸
        /// </summary>
        public DeleteFaceByFaceIdResponse DeleteFaceByFaceId(DeleteFaceByFaceIdRequest deleteFaceByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 删除人脸库
        /// </summary>
        public DeleteFaceSetResponse DeleteFaceSet(DeleteFaceSetRequest deleteFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , deleteFaceSetRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public DetectFaceByBase64Response DetectFaceByBase64(DetectFaceByBase64Request detectFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public DetectFaceByFileResponse DetectFaceByFile(DetectFaceByFileRequest detectFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        /// </summary>
        public DetectFaceByUrlResponse DetectFaceByUrl(DetectFaceByUrlRequest detectFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public DetectLiveByBase64Response DetectLiveByBase64(DetectLiveByBase64Request detectLiveByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByBase64Response>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public DetectLiveByFileResponse DetectLiveByFile(DetectLiveByFileRequest detectLiveByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByFileResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        /// </summary>
        public DetectLiveByUrlResponse DetectLiveByUrl(DetectLiveByUrlRequest detectLiveByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByUrlResponse>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public DetectLiveFaceByBase64Response DetectLiveFaceByBase64(DetectLiveFaceByBase64Request detectLiveFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public DetectLiveFaceByFileResponse DetectLiveFaceByFile(DetectLiveFaceByFileRequest detectLiveFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        /// </summary>
        public DetectLiveFaceByUrlResponse DetectLiveFaceByUrl(DetectLiveFaceByUrlRequest detectLiveFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public SearchFaceByBase64Response SearchFaceByBase64(SearchFaceByBase64Request searchFaceByBase64Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByBase64Request.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByBase64Response>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public SearchFaceByFaceIdResponse SearchFaceByFaceId(SearchFaceByFaceIdRequest searchFaceByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public SearchFaceByFileResponse SearchFaceByFile(SearchFaceByFileRequest searchFaceByFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByFileRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByFileResponse>(response);
        }
        
        /// <summary>
        /// 人脸搜索
        /// </summary>
        public SearchFaceByUrlResponse SearchFaceByUrl(SearchFaceByUrlRequest searchFaceByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , searchFaceByUrlRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SearchFaceByUrlResponse>(response);
        }
        
        /// <summary>
        /// 查询所有人脸库
        /// </summary>
        public ShowAllFaceSetsResponse ShowAllFaceSets(ShowAllFaceSetsRequest showAllFaceSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAllFaceSetsResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸库
        /// </summary>
        public ShowFaceSetResponse ShowFaceSet(ShowFaceSetRequest showFaceSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFaceSetRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFaceSetResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸
        /// </summary>
        public ShowFacesByFaceIdResponse ShowFacesByFaceId(ShowFacesByFaceIdRequest showFacesByFaceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFacesByFaceIdRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>(response);
        }
        
        /// <summary>
        /// 查询人脸
        /// </summary>
        public ShowFacesByLimitResponse ShowFacesByLimit(ShowFacesByLimitRequest showFacesByLimitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , showFacesByLimitRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFacesByLimitResponse>(response);
        }
        
        /// <summary>
        /// 更新人脸
        /// </summary>
        public UpdateFaceResponse UpdateFace(UpdateFaceRequest updateFaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name" , updateFaceRequest.FaceSetName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFaceResponse>(response);
        }
        
    }
}