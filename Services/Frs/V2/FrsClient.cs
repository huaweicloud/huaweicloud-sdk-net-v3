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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByBase64Response>(response);
        }

        public SyncInvoker<AddFacesByBase64Response> AddFacesByBase64Invoker(AddFacesByBase64Request addFacesByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            return new SyncInvoker<AddFacesByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByFileResponse>(response);
        }

        public SyncInvoker<AddFacesByFileResponse> AddFacesByFileInvoker(AddFacesByFileRequest addFacesByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            return new SyncInvoker<AddFacesByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByUrlResponse>(response);
        }

        public SyncInvoker<AddFacesByUrlResponse> AddFacesByUrlInvoker(AddFacesByUrlRequest addFacesByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            return new SyncInvoker<AddFacesByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", batchDeleteFacesRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteFacesResponse>(response);
        }

        public SyncInvoker<BatchDeleteFacesResponse> BatchDeleteFacesInvoker(BatchDeleteFacesRequest batchDeleteFacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", batchDeleteFacesRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            return new SyncInvoker<BatchDeleteFacesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteFacesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByBase64Response>(response);
        }

        public SyncInvoker<CompareFaceByBase64Response> CompareFaceByBase64Invoker(CompareFaceByBase64Request compareFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            return new SyncInvoker<CompareFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByFileResponse>(response);
        }

        public SyncInvoker<CompareFaceByFileResponse> CompareFaceByFileInvoker(CompareFaceByFileRequest compareFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            return new SyncInvoker<CompareFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByUrlResponse>(response);
        }

        public SyncInvoker<CompareFaceByUrlResponse> CompareFaceByUrlInvoker(CompareFaceByUrlRequest compareFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            return new SyncInvoker<CompareFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFaceSetResponse>(response);
        }

        public SyncInvoker<CreateFaceSetResponse> CreateFaceSetInvoker(CreateFaceSetRequest createFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            return new SyncInvoker<CreateFaceSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFaceSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>(response);
        }

        public SyncInvoker<DeleteFaceByExternalImageIdResponse> DeleteFaceByExternalImageIdInvoker(DeleteFaceByExternalImageIdRequest deleteFaceByExternalImageIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            return new SyncInvoker<DeleteFaceByExternalImageIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>(response);
        }

        public SyncInvoker<DeleteFaceByFaceIdResponse> DeleteFaceByFaceIdInvoker(DeleteFaceByFaceIdRequest deleteFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            return new SyncInvoker<DeleteFaceByFaceIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceSetResponse>(response);
        }

        public SyncInvoker<DeleteFaceSetResponse> DeleteFaceSetInvoker(DeleteFaceSetRequest deleteFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            return new SyncInvoker<DeleteFaceSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByBase64Response>(response);
        }

        public SyncInvoker<DetectFaceByBase64Response> DetectFaceByBase64Invoker(DetectFaceByBase64Request detectFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            return new SyncInvoker<DetectFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64IntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByBase64IntlResponse>(response);
        }

        public SyncInvoker<DetectFaceByBase64IntlResponse> DetectFaceByBase64IntlInvoker(DetectFaceByBase64IntlRequest detectFaceByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64IntlRequest);
            return new SyncInvoker<DetectFaceByBase64IntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByBase64IntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByFileResponse>(response);
        }

        public SyncInvoker<DetectFaceByFileResponse> DetectFaceByFileInvoker(DetectFaceByFileRequest detectFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            return new SyncInvoker<DetectFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileIntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByFileIntlResponse>(response);
        }

        public SyncInvoker<DetectFaceByFileIntlResponse> DetectFaceByFileIntlInvoker(DetectFaceByFileIntlRequest detectFaceByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileIntlRequest);
            return new SyncInvoker<DetectFaceByFileIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByFileIntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByUrlResponse>(response);
        }

        public SyncInvoker<DetectFaceByUrlResponse> DetectFaceByUrlInvoker(DetectFaceByUrlRequest detectFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            return new SyncInvoker<DetectFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlIntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByUrlIntlResponse>(response);
        }

        public SyncInvoker<DetectFaceByUrlIntlResponse> DetectFaceByUrlIntlInvoker(DetectFaceByUrlIntlRequest detectFaceByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlIntlRequest);
            return new SyncInvoker<DetectFaceByUrlIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByUrlIntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByBase64Response>(response);
        }

        public SyncInvoker<DetectLiveByBase64Response> DetectLiveByBase64Invoker(DetectLiveByBase64Request detectLiveByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            return new SyncInvoker<DetectLiveByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64IntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByBase64IntlResponse>(response);
        }

        public SyncInvoker<DetectLiveByBase64IntlResponse> DetectLiveByBase64IntlInvoker(DetectLiveByBase64IntlRequest detectLiveByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64IntlRequest);
            return new SyncInvoker<DetectLiveByBase64IntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByBase64IntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByFileResponse>(response);
        }

        public SyncInvoker<DetectLiveByFileResponse> DetectLiveByFileInvoker(DetectLiveByFileRequest detectLiveByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            return new SyncInvoker<DetectLiveByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileIntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByFileIntlResponse>(response);
        }

        public SyncInvoker<DetectLiveByFileIntlResponse> DetectLiveByFileIntlInvoker(DetectLiveByFileIntlRequest detectLiveByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileIntlRequest);
            return new SyncInvoker<DetectLiveByFileIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByFileIntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByUrlResponse>(response);
        }

        public SyncInvoker<DetectLiveByUrlResponse> DetectLiveByUrlInvoker(DetectLiveByUrlRequest detectLiveByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            return new SyncInvoker<DetectLiveByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlIntlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByUrlIntlResponse>(response);
        }

        public SyncInvoker<DetectLiveByUrlIntlResponse> DetectLiveByUrlIntlInvoker(DetectLiveByUrlIntlRequest detectLiveByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlIntlRequest);
            return new SyncInvoker<DetectLiveByUrlIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByUrlIntlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>(response);
        }

        public SyncInvoker<DetectLiveFaceByBase64Response> DetectLiveFaceByBase64Invoker(DetectLiveFaceByBase64Request detectLiveFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            return new SyncInvoker<DetectLiveFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>(response);
        }

        public SyncInvoker<DetectLiveFaceByFileResponse> DetectLiveFaceByFileInvoker(DetectLiveFaceByFileRequest detectLiveFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            return new SyncInvoker<DetectLiveFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>(response);
        }

        public SyncInvoker<DetectLiveFaceByUrlResponse> DetectLiveFaceByUrlInvoker(DetectLiveFaceByUrlRequest detectLiveFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            return new SyncInvoker<DetectLiveFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByBase64Response>(response);
        }

        public SyncInvoker<SearchFaceByBase64Response> SearchFaceByBase64Invoker(SearchFaceByBase64Request searchFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            return new SyncInvoker<SearchFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByBase64Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>(response);
        }

        public SyncInvoker<SearchFaceByFaceIdResponse> SearchFaceByFaceIdInvoker(SearchFaceByFaceIdRequest searchFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            return new SyncInvoker<SearchFaceByFaceIdResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByFileResponse>(response);
        }

        public SyncInvoker<SearchFaceByFileResponse> SearchFaceByFileInvoker(SearchFaceByFileRequest searchFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            return new SyncInvoker<SearchFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByUrlResponse>(response);
        }

        public SyncInvoker<SearchFaceByUrlResponse> SearchFaceByUrlInvoker(SearchFaceByUrlRequest searchFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            return new SyncInvoker<SearchFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByUrlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAllFaceSetsResponse>(response);
        }

        public SyncInvoker<ShowAllFaceSetsResponse> ShowAllFaceSetsInvoker(ShowAllFaceSetsRequest showAllFaceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            return new SyncInvoker<ShowAllFaceSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllFaceSetsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFaceSetResponse>(response);
        }

        public SyncInvoker<ShowFaceSetResponse> ShowFaceSetInvoker(ShowFaceSetRequest showFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            return new SyncInvoker<ShowFaceSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFaceSetResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>(response);
        }

        public SyncInvoker<ShowFacesByFaceIdResponse> ShowFacesByFaceIdInvoker(ShowFacesByFaceIdRequest showFacesByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            return new SyncInvoker<ShowFacesByFaceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByLimitRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFacesByLimitResponse>(response);
        }

        public SyncInvoker<ShowFacesByLimitResponse> ShowFacesByLimitInvoker(ShowFacesByLimitRequest showFacesByLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByLimitRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            return new SyncInvoker<ShowFacesByLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFacesByLimitResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", updateFaceRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFaceResponse>(response);
        }

        public SyncInvoker<UpdateFaceResponse> UpdateFaceInvoker(UpdateFaceRequest updateFaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", updateFaceRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            return new SyncInvoker<UpdateFaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFaceResponse>);
        }
        
    }
}