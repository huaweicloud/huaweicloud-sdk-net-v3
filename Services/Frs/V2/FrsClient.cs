using System;
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
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 自定义筛选条件，批量删除人脸库中的符合指定条件的多张人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建用于存储人脸特征的人脸库。您最多可以创建10个人脸库，每个人脸库最大容量为10万个人脸特征。如有更大规格的需求请联系客服。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据external_image_id删除人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据face_id删除人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除人脸库以及其中所有的人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectFaceByBase64IntlResponse DetectFaceByBase64Intl(DetectFaceByBase64IntlRequest detectFaceByBase64IntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64IntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByBase64IntlResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectFaceByFileIntlResponse DetectFaceByFileIntl(DetectFaceByFileIntlRequest detectFaceByFileIntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileIntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByFileIntlResponse>(response);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectFaceByUrlIntlResponse DetectFaceByUrlIntl(DetectFaceByUrlIntlRequest detectFaceByUrlIntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlIntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectFaceByUrlIntlResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectLiveByBase64IntlResponse DetectLiveByBase64Intl(DetectLiveByBase64IntlRequest detectLiveByBase64IntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64IntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByBase64IntlResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectLiveByFileIntlResponse DetectLiveByFileIntl(DetectLiveByFileIntlRequest detectLiveByFileIntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileIntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByFileIntlResponse>(response);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectLiveByUrlIntlResponse DetectLiveByUrlIntl(DetectLiveByUrlIntlRequest detectLiveByUrlIntlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlIntlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectLiveByUrlIntlResponse>(response);
        }
        
        /// <summary>
        /// 静默活体检测
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询当前用户所有人脸库的状态信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询人脸库当前的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定人脸库中人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定人脸库中人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据人脸ID（face_id）更新单张人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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