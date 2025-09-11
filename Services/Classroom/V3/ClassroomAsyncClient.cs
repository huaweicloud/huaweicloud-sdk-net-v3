using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Classroom.V3.Model;

namespace HuaweiCloud.SDK.Classroom.V3
{
    public partial class ClassroomAsyncClient : Client
    {
        public static ClientBuilder<ClassroomAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ClassroomAsyncClient>();
        }

        
        /// <summary>
        /// 下发判题任务
        ///
        /// 下发判题任务，根据回调地址、代码来源、源代码文本、语言类型、超时时长、输出类型，触发后台代码编译运行和判题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyJudgementResponse> ApplyJudgementAsync(ApplyJudgementRequest applyJudgementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyJudgementRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplyJudgementResponse>(response);
        }

        public AsyncInvoker<ApplyJudgementResponse> ApplyJudgementAsyncInvoker(ApplyJudgementRequest applyJudgementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyJudgementRequest);
            return new AsyncInvoker<ApplyJudgementResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyJudgementResponse>);
        }
        
        /// <summary>
        /// 获取判题结果详情
        ///
        /// 根据判题任务ID获取判题结果详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJudgementDetailResponse> ShowJudgementDetailAsync(ShowJudgementDetailRequest showJudgementDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementDetailRequest.JudgementId, out var valueOfJudgementId)) urlParam.Add("judgement_id", valueOfJudgementId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements/{judgement_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJudgementDetailResponse>(response);
        }

        public AsyncInvoker<ShowJudgementDetailResponse> ShowJudgementDetailAsyncInvoker(ShowJudgementDetailRequest showJudgementDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementDetailRequest.JudgementId, out var valueOfJudgementId)) urlParam.Add("judgement_id", valueOfJudgementId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements/{judgement_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementDetailRequest);
            return new AsyncInvoker<ShowJudgementDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJudgementDetailResponse>);
        }
        
        /// <summary>
        /// 下载判题结果文件
        ///
        /// 根据文件id或图片id下载输出结果文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJudgementFileResponse> ShowJudgementFileAsync(ShowJudgementFileRequest showJudgementFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgement/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJudgementFileResponse>(response);
        }

        public AsyncInvoker<ShowJudgementFileResponse> ShowJudgementFileAsyncInvoker(ShowJudgementFileRequest showJudgementFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJudgementFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgement/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementFileRequest);
            return new AsyncInvoker<ShowJudgementFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJudgementFileResponse>);
        }
        
        /// <summary>
        /// 习题判题
        ///
        /// 习题判题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteExerciseResponse> ExecuteExerciseAsync(ExecuteExerciseRequest executeExerciseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeExerciseRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/judge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeExerciseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteExerciseResponse>(response);
        }

        public AsyncInvoker<ExecuteExerciseResponse> ExecuteExerciseAsyncInvoker(ExecuteExerciseRequest executeExerciseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeExerciseRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/judge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeExerciseRequest);
            return new AsyncInvoker<ExecuteExerciseResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteExerciseResponse>);
        }
        
        /// <summary>
        /// 查询习题库下习题列表
        ///
        /// 查询习题库下习题列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExercisesResponse> ListExercisesAsync(ListExercisesRequest listExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExercisesRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/exercise/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listExercisesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListExercisesResponse>(response);
        }

        public AsyncInvoker<ListExercisesResponse> ListExercisesAsyncInvoker(ListExercisesRequest listExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExercisesRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/exercise/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listExercisesRequest);
            return new AsyncInvoker<ListExercisesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListExercisesResponse>);
        }
        
        /// <summary>
        /// 查询当前租户的习题库列表
        ///
        /// 查询当前租户的习题库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPackagesResponse> ListPackagesAsync(ListPackagesRequest listPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPackagesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPackagesResponse>(response);
        }

        public AsyncInvoker<ListPackagesResponse> ListPackagesAsyncInvoker(ListPackagesRequest listPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPackagesRequest);
            return new AsyncInvoker<ListPackagesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPackagesResponse>);
        }
        
        /// <summary>
        /// 查询单个习题详情
        ///
        /// 查询单个习题详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExerciseDetailResponse> ShowExerciseDetailAsync(ShowExerciseDetailRequest showExerciseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExerciseDetailRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExerciseDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowExerciseDetailResponse>(response);
        }

        public AsyncInvoker<ShowExerciseDetailResponse> ShowExerciseDetailAsyncInvoker(ShowExerciseDetailRequest showExerciseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExerciseDetailRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/exercise/{exercise_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExerciseDetailRequest);
            return new AsyncInvoker<ShowExerciseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExerciseDetailResponse>);
        }
        
        /// <summary>
        /// 查询单个习题库详情
        ///
        /// 查询单个习题库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPackageDetailResponse> ShowPackageDetailAsync(ShowPackageDetailRequest showPackageDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPackageDetailRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageDetailResponse>(response);
        }

        public AsyncInvoker<ShowPackageDetailResponse> ShowPackageDetailAsyncInvoker(ShowPackageDetailRequest showPackageDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPackageDetailRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/assemble/package/{package_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDetailRequest);
            return new AsyncInvoker<ShowPackageDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageDetailResponse>);
        }
        
        /// <summary>
        /// 获取习题所有难度
        ///
        /// 获取习题所有难度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllDifficultsResponse> ListAllDifficultsAsync(ListAllDifficultsRequest listAllDifficultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/difficult/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDifficultsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllDifficultsResponse>(response);
        }

        public AsyncInvoker<ListAllDifficultsResponse> ListAllDifficultsAsyncInvoker(ListAllDifficultsRequest listAllDifficultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/difficult/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllDifficultsRequest);
            return new AsyncInvoker<ListAllDifficultsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllDifficultsResponse>);
        }
        
        /// <summary>
        /// 获取自身习题知识点
        ///
        /// 获取自身习题知识点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMyKnowledgePointsResponse> ListMyKnowledgePointsAsync(ListMyKnowledgePointsRequest listMyKnowledgePointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/knowledge-point/mine", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listMyKnowledgePointsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListMyKnowledgePointsResponse>(response);
        }

        public AsyncInvoker<ListMyKnowledgePointsResponse> ListMyKnowledgePointsAsyncInvoker(ListMyKnowledgePointsRequest listMyKnowledgePointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/baseresource/extend-resource/knowledge-point/mine", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listMyKnowledgePointsRequest);
            return new AsyncInvoker<ListMyKnowledgePointsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMyKnowledgePointsResponse>);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的课堂成员列表
        ///
        /// 根据课堂ID获取指定课堂的课堂成员列表，支持分页，搜索字段默认同时匹配姓名，学号，用户名，班级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomMembersResponse> ListClassroomMembersAsync(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMembersRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomMembersResponse>(response);
        }

        public AsyncInvoker<ListClassroomMembersResponse> ListClassroomMembersAsyncInvoker(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMembersRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMembersRequest);
            return new AsyncInvoker<ListClassroomMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomMembersResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的课堂列表
        ///
        /// 获取当前用户的课堂列表，课堂课表分为我创建的课堂，我加入的课堂以及所有课堂，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomsResponse> ListClassroomsAsync(ListClassroomsRequest listClassroomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomsResponse>(response);
        }

        public AsyncInvoker<ListClassroomsResponse> ListClassroomsAsyncInvoker(ListClassroomsRequest listClassroomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomsRequest);
            return new AsyncInvoker<ListClassroomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomsResponse>);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的详细信息
        ///
        /// 根据课堂ID获取指定课堂的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClassroomDetailResponse> ShowClassroomDetailAsync(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClassroomDetailRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClassroomDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClassroomDetailResponse>(response);
        }

        public AsyncInvoker<ShowClassroomDetailResponse> ShowClassroomDetailAsyncInvoker(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClassroomDetailRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClassroomDetailRequest);
            return new AsyncInvoker<ShowClassroomDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClassroomDetailResponse>);
        }
        
        /// <summary>
        /// 查询课堂下指定成员的作业信息
        ///
        /// 查询课堂下指定成员的作业信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomMemberJobsResponse> ListClassroomMemberJobsAsync(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMemberJobsRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMemberJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>(response);
        }

        public AsyncInvoker<ListClassroomMemberJobsResponse> ListClassroomMemberJobsAsyncInvoker(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClassroomMemberJobsRequest.ClassroomId, out var valueOfClassroomId)) urlParam.Add("classroom_id", valueOfClassroomId);
            var urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMemberJobsRequest);
            return new AsyncInvoker<ListClassroomMemberJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>);
        }
        
        /// <summary>
        /// 查询指定课堂下的作业列表信息
        ///
        /// 查询指定课堂下的作业列表信息，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询学生函数习题提交记录信息
        ///
        /// 查询学生指定作业的习题提交记录信息(针对函数习题)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMemberJobRecordsResponse> ListMemberJobRecordsAsync(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMemberJobRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMemberJobRecordsResponse>(response);
        }

        public AsyncInvoker<ListMemberJobRecordsResponse> ListMemberJobRecordsAsyncInvoker(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listMemberJobRecordsRequest.ExerciseId, out var valueOfExerciseId)) urlParam.Add("exercise_id", valueOfExerciseId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMemberJobRecordsRequest);
            return new AsyncInvoker<ListMemberJobRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMemberJobRecordsResponse>);
        }
        
        /// <summary>
        /// 根据作业ID，查询指定作业的信息
        ///
        /// 根据作业ID，查询指定作业的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowJobDetailResponse> ShowJobDetailAsyncInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new AsyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询指定作业下的习题信息
        ///
        /// 查询指定作业下的习题信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobExercisesResponse> ShowJobExercisesAsync(ShowJobExercisesRequest showJobExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobExercisesRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobExercisesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobExercisesResponse>(response);
        }

        public AsyncInvoker<ShowJobExercisesResponse> ShowJobExercisesAsyncInvoker(ShowJobExercisesRequest showJobExercisesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobExercisesRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobExercisesRequest);
            return new AsyncInvoker<ShowJobExercisesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobExercisesResponse>);
        }
        
    }
}