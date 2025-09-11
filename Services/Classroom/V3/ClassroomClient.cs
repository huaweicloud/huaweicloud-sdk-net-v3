using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Classroom.V3.Model;

namespace HuaweiCloud.SDK.Classroom.V3
{
    public partial class ClassroomClient : Client
    {
        public static ClientBuilder<ClassroomClient> NewBuilder()
        {
            return new ClientBuilder<ClassroomClient>();
        }

        
        /// <summary>
        /// 下发判题任务
        ///
        /// 下发判题任务，根据回调地址、代码来源、源代码文本、语言类型、超时时长、输出类型，触发后台代码编译运行和判题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyJudgementResponse ApplyJudgement(ApplyJudgementRequest applyJudgementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyJudgementRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplyJudgementResponse>(response);
        }

        public SyncInvoker<ApplyJudgementResponse> ApplyJudgementInvoker(ApplyJudgementRequest applyJudgementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyJudgementRequest);
            return new SyncInvoker<ApplyJudgementResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyJudgementResponse>);
        }
        
        /// <summary>
        /// 获取判题结果详情
        ///
        /// 根据判题任务ID获取判题结果详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJudgementDetailResponse ShowJudgementDetail(ShowJudgementDetailRequest showJudgementDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementDetailRequest.JudgementId, out var valueOfJudgementId)) urlParam.Add("judgement_id", valueOfJudgementId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements/{judgement_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJudgementDetailResponse>(response);
        }

        public SyncInvoker<ShowJudgementDetailResponse> ShowJudgementDetailInvoker(ShowJudgementDetailRequest showJudgementDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementDetailRequest.JudgementId, out var valueOfJudgementId)) urlParam.Add("judgement_id", valueOfJudgementId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements/{judgement_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementDetailRequest);
            return new SyncInvoker<ShowJudgementDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJudgementDetailResponse>);
        }
        
        /// <summary>
        /// 下载判题结果文件
        ///
        /// 根据文件id或图片id下载输出结果文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJudgementFileResponse ShowJudgementFile(ShowJudgementFileRequest showJudgementFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgement/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJudgementFileResponse>(response);
        }

        public SyncInvoker<ShowJudgementFileResponse> ShowJudgementFileInvoker(ShowJudgementFileRequest showJudgementFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgement/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementFileRequest);
            return new SyncInvoker<ShowJudgementFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJudgementFileResponse>);
        }
        
        /// <summary>
        /// 习题判题
        ///
        /// 习题判题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteExerciseResponse ExecuteExercise(ExecuteExerciseRequest executeExerciseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeExerciseRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/judge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeExerciseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteExerciseResponse>(response);
        }

        public SyncInvoker<ExecuteExerciseResponse> ExecuteExerciseInvoker(ExecuteExerciseRequest executeExerciseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeExerciseRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/judge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeExerciseRequest);
            return new SyncInvoker<ExecuteExerciseResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteExerciseResponse>);
        }
        
        /// <summary>
        /// 查询习题库下习题列表
        ///
        /// 查询习题库下习题列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExercisesResponse ListExercises(ListExercisesRequest listExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExercisesRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/exercise/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listExercisesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListExercisesResponse>(response);
        }

        public SyncInvoker<ListExercisesResponse> ListExercisesInvoker(ListExercisesRequest listExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExercisesRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/exercise/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listExercisesRequest);
            return new SyncInvoker<ListExercisesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListExercisesResponse>);
        }
        
        /// <summary>
        /// 查询当前租户的习题库列表
        ///
        /// 查询当前租户的习题库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPackagesResponse ListPackages(ListPackagesRequest listPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPackagesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPackagesResponse>(response);
        }

        public SyncInvoker<ListPackagesResponse> ListPackagesInvoker(ListPackagesRequest listPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPackagesRequest);
            return new SyncInvoker<ListPackagesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPackagesResponse>);
        }
        
        /// <summary>
        /// 查询单个习题详情
        ///
        /// 查询单个习题详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExerciseDetailResponse ShowExerciseDetail(ShowExerciseDetailRequest showExerciseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExerciseDetailRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExerciseDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowExerciseDetailResponse>(response);
        }

        public SyncInvoker<ShowExerciseDetailResponse> ShowExerciseDetailInvoker(ShowExerciseDetailRequest showExerciseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExerciseDetailRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExerciseDetailRequest);
            return new SyncInvoker<ShowExerciseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExerciseDetailResponse>);
        }
        
        /// <summary>
        /// 查询单个习题库详情
        ///
        /// 查询单个习题库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPackageDetailResponse ShowPackageDetail(ShowPackageDetailRequest showPackageDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPackageDetailRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageDetailResponse>(response);
        }

        public SyncInvoker<ShowPackageDetailResponse> ShowPackageDetailInvoker(ShowPackageDetailRequest showPackageDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPackageDetailRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDetailRequest);
            return new SyncInvoker<ShowPackageDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageDetailResponse>);
        }
        
        /// <summary>
        /// 获取习题所有难度
        ///
        /// 获取习题所有难度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllDifficultsResponse ListAllDifficults(ListAllDifficultsRequest listAllDifficultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/difficult/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDifficultsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllDifficultsResponse>(response);
        }

        public SyncInvoker<ListAllDifficultsResponse> ListAllDifficultsInvoker(ListAllDifficultsRequest listAllDifficultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/difficult/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDifficultsRequest);
            return new SyncInvoker<ListAllDifficultsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllDifficultsResponse>);
        }
        
        /// <summary>
        /// 获取自身习题知识点
        ///
        /// 获取自身习题知识点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMyKnowledgePointsResponse ListMyKnowledgePoints(ListMyKnowledgePointsRequest listMyKnowledgePointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/knowledge-point/mine", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listMyKnowledgePointsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListMyKnowledgePointsResponse>(response);
        }

        public SyncInvoker<ListMyKnowledgePointsResponse> ListMyKnowledgePointsInvoker(ListMyKnowledgePointsRequest listMyKnowledgePointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/knowledge-point/mine", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listMyKnowledgePointsRequest);
            return new SyncInvoker<ListMyKnowledgePointsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMyKnowledgePointsResponse>);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的课堂成员列表
        ///
        /// 根据课堂ID获取指定课堂的课堂成员列表，支持分页，搜索字段默认同时匹配姓名，学号，用户名，班级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClassroomMembersResponse ListClassroomMembers(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMembersRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomMembersResponse>(response);
        }

        public SyncInvoker<ListClassroomMembersResponse> ListClassroomMembersInvoker(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMembersRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMembersRequest);
            return new SyncInvoker<ListClassroomMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomMembersResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的课堂列表
        ///
        /// 获取当前用户的课堂列表，课堂课表分为我创建的课堂，我加入的课堂以及所有课堂，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClassroomsResponse ListClassrooms(ListClassroomsRequest listClassroomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomsResponse>(response);
        }

        public SyncInvoker<ListClassroomsResponse> ListClassroomsInvoker(ListClassroomsRequest listClassroomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomsRequest);
            return new SyncInvoker<ListClassroomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomsResponse>);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的详细信息
        ///
        /// 根据课堂ID获取指定课堂的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClassroomDetailResponse ShowClassroomDetail(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClassroomDetailRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClassroomDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClassroomDetailResponse>(response);
        }

        public SyncInvoker<ShowClassroomDetailResponse> ShowClassroomDetailInvoker(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClassroomDetailRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClassroomDetailRequest);
            return new SyncInvoker<ShowClassroomDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClassroomDetailResponse>);
        }
        
        /// <summary>
        /// 查询课堂下指定成员的作业信息
        ///
        /// 查询课堂下指定成员的作业信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClassroomMemberJobsResponse ListClassroomMemberJobs(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMemberJobsRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMemberJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>(response);
        }

        public SyncInvoker<ListClassroomMemberJobsResponse> ListClassroomMemberJobsInvoker(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMemberJobsRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMemberJobsRequest);
            return new SyncInvoker<ListClassroomMemberJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>);
        }
        
        /// <summary>
        /// 查询指定课堂下的作业列表信息
        ///
        /// 查询指定课堂下的作业列表信息，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询学生函数习题提交记录信息
        ///
        /// 查询学生指定作业的习题提交记录信息(针对函数习题)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMemberJobRecordsResponse ListMemberJobRecords(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMemberJobRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMemberJobRecordsResponse>(response);
        }

        public SyncInvoker<ListMemberJobRecordsResponse> ListMemberJobRecordsInvoker(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMemberJobRecordsRequest);
            return new SyncInvoker<ListMemberJobRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMemberJobRecordsResponse>);
        }
        
        /// <summary>
        /// 根据作业ID，查询指定作业的信息
        ///
        /// 根据作业ID，查询指定作业的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobDetailResponse ShowJobDetail(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public SyncInvoker<ShowJobDetailResponse> ShowJobDetailInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new SyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询指定作业下的习题信息
        ///
        /// 查询指定作业下的习题信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobExercisesResponse ShowJobExercises(ShowJobExercisesRequest showJobExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobExercisesRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobExercisesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobExercisesResponse>(response);
        }

        public SyncInvoker<ShowJobExercisesResponse> ShowJobExercisesInvoker(ShowJobExercisesRequest showJobExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobExercisesRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobExercisesRequest);
            return new SyncInvoker<ShowJobExercisesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobExercisesResponse>);
        }
        
    }
}