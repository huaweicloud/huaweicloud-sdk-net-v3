using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cloudtest.V1.Model;

namespace HuaweiCloud.SDK.Cloudtest.V1
{
    public partial class CloudtestClient : Client
    {
        public static ClientBuilder<CloudtestClient> NewBuilder()
        {
            return new ClientBuilder<CloudtestClient>();
        }

        
        /// <summary>
        /// 设置用例结果
        ///
        /// 设置用例结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddCaseResultFourResponse AddCaseResultFour(AddCaseResultFourRequest addCaseResultFourRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCaseResultFourRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddCaseResultFourResponse>(response);
        }

        public SyncInvoker<AddCaseResultFourResponse> AddCaseResultFourInvoker(AddCaseResultFourRequest addCaseResultFourRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(addCaseResultFourRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCaseResultFourRequest);
            return new SyncInvoker<AddCaseResultFourResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCaseResultFourResponse>);
        }
        
        /// <summary>
        /// 新增用例评论
        ///
        /// 新增用例评论
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTestCaseCommentResponse AddTestCaseComment(AddTestCaseCommentRequest addTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTestCaseCommentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTestCaseCommentResponse>(response);
        }

        public SyncInvoker<AddTestCaseCommentResponse> AddTestCaseCommentInvoker(AddTestCaseCommentRequest addTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTestCaseCommentRequest);
            return new SyncInvoker<AddTestCaseCommentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTestCaseCommentResponse>);
        }
        
        /// <summary>
        /// 初始化用例执行记录
        ///
        /// 初始化用例执行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTestCaseResultLogResponse AddTestCaseResultLog(AddTestCaseResultLogRequest addTestCaseResultLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results/init", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTestCaseResultLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTestCaseResultLogResponse>(response);
        }

        public SyncInvoker<AddTestCaseResultLogResponse> AddTestCaseResultLogInvoker(AddTestCaseResultLogRequest addTestCaseResultLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(addTestCaseResultLogRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results/init", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTestCaseResultLogRequest);
            return new SyncInvoker<AddTestCaseResultLogResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTestCaseResultLogResponse>);
        }
        
        /// <summary>
        /// 添加需求/缺陷和多个用例关联关系
        ///
        /// 添加需求/缺陷和多个用例关联关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddRelationsByOneCaseResponse BatchAddRelationsByOneCase(BatchAddRelationsByOneCaseRequest batchAddRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddRelationsByOneCaseRequest.WorkitemId, out var valueOfWorkitemId)) urlParam.Add("workitem_id", valueOfWorkitemId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/workitems/{workitem_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddRelationsByOneCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddRelationsByOneCaseResponse>(response);
        }

        public SyncInvoker<BatchAddRelationsByOneCaseResponse> BatchAddRelationsByOneCaseInvoker(BatchAddRelationsByOneCaseRequest batchAddRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddRelationsByOneCaseRequest.WorkitemId, out var valueOfWorkitemId)) urlParam.Add("workitem_id", valueOfWorkitemId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/workitems/{workitem_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddRelationsByOneCaseRequest);
            return new SyncInvoker<BatchAddRelationsByOneCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddRelationsByOneCaseResponse>);
        }
        
        /// <summary>
        /// 向迭代中添加资源
        ///
        /// 向迭代中添加资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddResourcesForIteratorResponse BatchAddResourcesForIterator(BatchAddResourcesForIteratorRequest batchAddResourcesForIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourcesForIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}/testcases/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddResourcesForIteratorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddResourcesForIteratorResponse>(response);
        }

        public SyncInvoker<BatchAddResourcesForIteratorResponse> BatchAddResourcesForIteratorInvoker(BatchAddResourcesForIteratorRequest batchAddResourcesForIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourcesForIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}/testcases/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddResourcesForIteratorRequest);
            return new SyncInvoker<BatchAddResourcesForIteratorResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddResourcesForIteratorResponse>);
        }
        
        /// <summary>
        /// 批量删除自定义测试服务类型用例
        ///
        /// 批量删除自定义测试服务类型用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTestCaseResponse BatchDeleteTestCase(BatchDeleteTestCaseRequest batchDeleteTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteTestCaseResponse>(response);
        }

        public SyncInvoker<BatchDeleteTestCaseResponse> BatchDeleteTestCaseInvoker(BatchDeleteTestCaseRequest batchDeleteTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestCaseRequest);
            return new SyncInvoker<BatchDeleteTestCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteTestCaseResponse>);
        }
        
        /// <summary>
        /// 批量删除用例
        ///
        /// 批量删除用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTestCasesResponse BatchDeleteTestCases(BatchDeleteTestCasesRequest batchDeleteTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestCasesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteTestCasesResponse>(response);
        }

        public SyncInvoker<BatchDeleteTestCasesResponse> BatchDeleteTestCasesInvoker(BatchDeleteTestCasesRequest batchDeleteTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestCasesRequest);
            return new SyncInvoker<BatchDeleteTestCasesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteTestCasesResponse>);
        }
        
        /// <summary>
        /// 根据测试报告uri列表，删除测试报告
        ///
        /// 根据测试报告uri列表，删除测试报告
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTestReportResponse BatchDeleteTestReport(BatchDeleteTestReportRequest batchDeleteTestReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteTestReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/test-reports/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestReportRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteTestReportResponse>(response);
        }

        public SyncInvoker<BatchDeleteTestReportResponse> BatchDeleteTestReportInvoker(BatchDeleteTestReportRequest batchDeleteTestReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteTestReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/test-reports/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTestReportRequest);
            return new SyncInvoker<BatchDeleteTestReportResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteTestReportResponse>);
        }
        
        /// <summary>
        /// 从迭代中批量移除用例
        ///
        /// 从迭代中批量移除用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRemoveTestCasesFromIteratorResponse BatchRemoveTestCasesFromIterator(BatchRemoveTestCasesFromIteratorRequest batchRemoveTestCasesFromIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveTestCasesFromIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRemoveTestCasesFromIteratorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchRemoveTestCasesFromIteratorResponse>(response);
        }

        public SyncInvoker<BatchRemoveTestCasesFromIteratorResponse> BatchRemoveTestCasesFromIteratorInvoker(BatchRemoveTestCasesFromIteratorRequest batchRemoveTestCasesFromIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveTestCasesFromIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}/testcases/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRemoveTestCasesFromIteratorRequest);
            return new SyncInvoker<BatchRemoveTestCasesFromIteratorResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchRemoveTestCasesFromIteratorResponse>);
        }
        
        /// <summary>
        /// 在不同分支或者迭代下批量修改用例
        ///
        /// 在不同分支或者迭代下批量修改用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateTestCasesInDiffVersionResponse BatchUpdateTestCasesInDiffVersion(BatchUpdateTestCasesInDiffVersionRequest batchUpdateTestCasesInDiffVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/batch/update/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTestCasesInDiffVersionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateTestCasesInDiffVersionResponse>(response);
        }

        public SyncInvoker<BatchUpdateTestCasesInDiffVersionResponse> BatchUpdateTestCasesInDiffVersionInvoker(BatchUpdateTestCasesInDiffVersionRequest batchUpdateTestCasesInDiffVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/batch/update/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTestCasesInDiffVersionRequest);
            return new SyncInvoker<BatchUpdateTestCasesInDiffVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateTestCasesInDiffVersionResponse>);
        }
        
        /// <summary>
        /// 批量更新用例属性
        ///
        /// 批量更新用例属性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateVersionTestCasesResponse BatchUpdateVersionTestCases(BatchUpdateVersionTestCasesRequest batchUpdateVersionTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateVersionTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateVersionTestCasesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateVersionTestCasesResponse>(response);
        }

        public SyncInvoker<BatchUpdateVersionTestCasesResponse> BatchUpdateVersionTestCasesInvoker(BatchUpdateVersionTestCasesRequest batchUpdateVersionTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateVersionTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateVersionTestCasesRequest);
            return new SyncInvoker<BatchUpdateVersionTestCasesResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateVersionTestCasesResponse>);
        }
        
        /// <summary>
        /// 检查项目权限
        ///
        /// 检查项目权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckPermissionResponse CheckPermission(CheckPermissionRequest checkPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkPermissionRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/permission/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckPermissionResponse>(response);
        }

        public SyncInvoker<CheckPermissionResponse> CheckPermissionInvoker(CheckPermissionRequest checkPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkPermissionRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/permission/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPermissionRequest);
            return new SyncInvoker<CheckPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckPermissionResponse>);
        }
        
        /// <summary>
        /// 新增迭代
        ///
        /// 新增迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateIteratorResponse CreateIterator(CreateIteratorRequest createIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIteratorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateIteratorResponse>(response);
        }

        public SyncInvoker<CreateIteratorResponse> CreateIteratorInvoker(CreateIteratorRequest createIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIteratorRequest);
            return new SyncInvoker<CreateIteratorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIteratorResponse>);
        }
        
        /// <summary>
        /// 项目下创建计划
        ///
        /// 项目下创建计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePlanResponse CreatePlan(CreatePlanRequest createPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPlanRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPlanRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePlanResponse>(response);
        }

        public SyncInvoker<CreatePlanResponse> CreatePlanInvoker(CreatePlanRequest createPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPlanRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPlanRequest);
            return new SyncInvoker<CreatePlanResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePlanResponse>);
        }
        
        /// <summary>
        /// 新增分支
        ///
        /// 新增分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectBranchResponse CreateProjectBranch(CreateProjectBranchRequest createProjectBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectBranchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectBranchResponse>(response);
        }

        public SyncInvoker<CreateProjectBranchResponse> CreateProjectBranchInvoker(CreateProjectBranchRequest createProjectBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectBranchRequest);
            return new SyncInvoker<CreateProjectBranchResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectBranchResponse>);
        }
        
        /// <summary>
        /// 添加一个用例和多个需求/缺陷关联关系
        ///
        /// 添加一个用例和多个需求/缺陷关联关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRelationsByOneCaseResponse CreateRelationsByOneCase(CreateRelationsByOneCaseRequest createRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRelationsByOneCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/testcases/{case_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRelationsByOneCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRelationsByOneCaseResponse>(response);
        }

        public SyncInvoker<CreateRelationsByOneCaseResponse> CreateRelationsByOneCaseInvoker(CreateRelationsByOneCaseRequest createRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRelationsByOneCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/testcases/{case_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRelationsByOneCaseRequest);
            return new SyncInvoker<CreateRelationsByOneCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRelationsByOneCaseResponse>);
        }
        
        /// <summary>
        /// 保存单个自定义报表
        ///
        /// 保存单个自定义报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReportResponse CreateReport(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/custom-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReportResponse>(response);
        }

        public SyncInvoker<CreateReportResponse> CreateReportInvoker(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/custom-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            return new SyncInvoker<CreateReportResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReportResponse>);
        }
        
        /// <summary>
        /// 生成资源URI
        ///
        /// 生成资源URI
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceUriResponse CreateResourceUri(CreateResourceUriRequest createResourceUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResourceUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/resource-uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceUriRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceUriResponse>(response);
        }

        public SyncInvoker<CreateResourceUriResponse> CreateResourceUriInvoker(CreateResourceUriRequest createResourceUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResourceUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/resource-uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceUriRequest);
            return new SyncInvoker<CreateResourceUriResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceUriResponse>);
        }
        
        /// <summary>
        /// 新测试类型服务注册
        ///
        /// 通过接口CreateService注册成为自定义服务。 注册完成后界面将会出现此自定义测试类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateServiceResponse CreateService(CreateServiceRequest createServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateServiceResponse>(response);
        }

        public SyncInvoker<CreateServiceResponse> CreateServiceInvoker(CreateServiceRequest createServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceRequest);
            return new SyncInvoker<CreateServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServiceResponse>);
        }
        
        /// <summary>
        /// 初始化测试任务执行记录
        ///
        /// 初始化测试任务执行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTaskDefaultResultResponse CreateTaskDefaultResult(CreateTaskDefaultResultRequest createTaskDefaultResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskDefaultResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createTaskDefaultResultRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/tasks/{task_uri}/results/init", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskDefaultResultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTaskDefaultResultResponse>(response);
        }

        public SyncInvoker<CreateTaskDefaultResultResponse> CreateTaskDefaultResultInvoker(CreateTaskDefaultResultRequest createTaskDefaultResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskDefaultResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createTaskDefaultResultRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/tasks/{task_uri}/results/init", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskDefaultResultRequest);
            return new SyncInvoker<CreateTaskDefaultResultResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTaskDefaultResultResponse>);
        }
        
        /// <summary>
        /// 创建自定义测试服务类型用例
        ///
        /// 创建自定义测试服务类型用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTestCaseResponse CreateTestCase(CreateTestCaseRequest createTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTestCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTestCaseResponse>(response);
        }

        public SyncInvoker<CreateTestCaseResponse> CreateTestCaseInvoker(CreateTestCaseRequest createTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTestCaseRequest);
            return new SyncInvoker<CreateTestCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTestCaseResponse>);
        }
        
        /// <summary>
        /// 计划中批量添加测试用例
        ///
        /// 计划中批量添加测试用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTestCaseInPlanResponse CreateTestCaseInPlan(CreateTestCaseInPlanRequest createTestCaseInPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseInPlanRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseInPlanRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/testcases/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTestCaseInPlanRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTestCaseInPlanResponse>(response);
        }

        public SyncInvoker<CreateTestCaseInPlanResponse> CreateTestCaseInPlanInvoker(CreateTestCaseInPlanRequest createTestCaseInPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseInPlanRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createTestCaseInPlanRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/testcases/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTestCaseInPlanRequest);
            return new SyncInvoker<CreateTestCaseInPlanResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTestCaseInPlanResponse>);
        }
        
        /// <summary>
        /// 新增用户自定义URL关键字
        ///
        /// 新增用户自定义URL关键字
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserDefinedUrlKeyWordResponse CreateUserDefinedUrlKeyWord(CreateUserDefinedUrlKeyWordRequest createUserDefinedUrlKeyWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserDefinedUrlKeyWordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/basic-aw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDefinedUrlKeyWordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserDefinedUrlKeyWordResponse>(response);
        }

        public SyncInvoker<CreateUserDefinedUrlKeyWordResponse> CreateUserDefinedUrlKeyWordInvoker(CreateUserDefinedUrlKeyWordRequest createUserDefinedUrlKeyWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserDefinedUrlKeyWordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/basic-aw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDefinedUrlKeyWordRequest);
            return new SyncInvoker<CreateUserDefinedUrlKeyWordResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserDefinedUrlKeyWordResponse>);
        }
        
        /// <summary>
        /// 在分支或者测试计划下创建用例
        ///
        /// 在分支或者测试计划下创建用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVersionTestCaseResponse CreateVersionTestCase(CreateVersionTestCaseRequest createVersionTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVersionTestCaseRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/versions/{version_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionTestCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVersionTestCaseResponse>(response);
        }

        public SyncInvoker<CreateVersionTestCaseResponse> CreateVersionTestCaseInvoker(CreateVersionTestCaseRequest createVersionTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVersionTestCaseRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/versions/{version_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionTestCaseRequest);
            return new SyncInvoker<CreateVersionTestCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVersionTestCaseResponse>);
        }
        
        /// <summary>
        /// 融合版本删除单个basicAw
        ///
        /// 融合版本删除单个basicAw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBasicAwByIdResponse DeleteBasicAwById(DeleteBasicAwByIdRequest deleteBasicAwByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicAwByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicAwByIdRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicAwByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBasicAwByIdResponse>(response);
        }

        public SyncInvoker<DeleteBasicAwByIdResponse> DeleteBasicAwByIdInvoker(DeleteBasicAwByIdRequest deleteBasicAwByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicAwByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicAwByIdRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicAwByIdRequest);
            return new SyncInvoker<DeleteBasicAwByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBasicAwByIdResponse>);
        }
        
        /// <summary>
        /// 删除附件
        ///
        /// 删除附件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCacheFileResponse DeleteCacheFile(DeleteCacheFileRequest deleteCacheFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCacheFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/resources/temp-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCacheFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCacheFileResponse>(response);
        }

        public SyncInvoker<DeleteCacheFileResponse> DeleteCacheFileInvoker(DeleteCacheFileRequest deleteCacheFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCacheFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/resources/temp-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCacheFileRequest);
            return new SyncInvoker<DeleteCacheFileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCacheFileResponse>);
        }
        
        /// <summary>
        /// 删除因子
        ///
        /// 删除因子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFacotrByIdResponse DeleteFacotrById(DeleteFacotrByIdRequest deleteFacotrByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFacotrByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteFacotrByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFacotrByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFacotrByIdResponse>(response);
        }

        public SyncInvoker<DeleteFacotrByIdResponse> DeleteFacotrByIdInvoker(DeleteFacotrByIdRequest deleteFacotrByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFacotrByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteFacotrByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFacotrByIdRequest);
            return new SyncInvoker<DeleteFacotrByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFacotrByIdResponse>);
        }
        
        /// <summary>
        /// 删除一个用例和多个需求/缺陷关联关系
        ///
        /// 删除一个用例和多个需求/缺陷关联关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRelationsByOneCaseResponse DeleteRelationsByOneCase(DeleteRelationsByOneCaseRequest deleteRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRelationsByOneCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/testcases/{case_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRelationsByOneCaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRelationsByOneCaseResponse>(response);
        }

        public SyncInvoker<DeleteRelationsByOneCaseResponse> DeleteRelationsByOneCaseInvoker(DeleteRelationsByOneCaseRequest deleteRelationsByOneCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRelationsByOneCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/testcases/{case_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRelationsByOneCaseRequest);
            return new SyncInvoker<DeleteRelationsByOneCaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRelationsByOneCaseResponse>);
        }
        
        /// <summary>
        /// 删除已注册服务
        ///
        /// 删除已注册服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceResponse DeleteService(DeleteServiceRequest deleteServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceResponse>(response);
        }

        public SyncInvoker<DeleteServiceResponse> DeleteServiceInvoker(DeleteServiceRequest deleteServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceRequest);
            return new SyncInvoker<DeleteServiceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceResponse>);
        }
        
        /// <summary>
        /// 删除用例评论
        ///
        /// 删除用例评论
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTestCaseCommentResponse DeleteTestCaseComment(DeleteTestCaseCommentRequest deleteTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.CommentId, out var valueOfCommentId)) urlParam.Add("comment_id", valueOfCommentId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments/{comment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTestCaseCommentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTestCaseCommentResponse>(response);
        }

        public SyncInvoker<DeleteTestCaseCommentResponse> DeleteTestCaseCommentInvoker(DeleteTestCaseCommentRequest deleteTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestCaseCommentRequest.CommentId, out var valueOfCommentId)) urlParam.Add("comment_id", valueOfCommentId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments/{comment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTestCaseCommentRequest);
            return new SyncInvoker<DeleteTestCaseCommentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTestCaseCommentResponse>);
        }
        
        /// <summary>
        /// 删除测试报告自定义模块
        ///
        /// 删除测试报告自定义模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTestReportCustomDetailByUriResponse DeleteTestReportCustomDetailByUri(DeleteTestReportCustomDetailByUriRequest deleteTestReportCustomDetailByUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.CustomInfoUri, out var valueOfCustomInfoUri)) urlParam.Add("custom_info_uri", valueOfCustomInfoUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos/{custom_info_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTestReportCustomDetailByUriRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTestReportCustomDetailByUriResponse>(response);
        }

        public SyncInvoker<DeleteTestReportCustomDetailByUriResponse> DeleteTestReportCustomDetailByUriInvoker(DeleteTestReportCustomDetailByUriRequest deleteTestReportCustomDetailByUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            if (StringUtils.TryConvertToNonEmptyString(deleteTestReportCustomDetailByUriRequest.CustomInfoUri, out var valueOfCustomInfoUri)) urlParam.Add("custom_info_uri", valueOfCustomInfoUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos/{custom_info_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTestReportCustomDetailByUriRequest);
            return new SyncInvoker<DeleteTestReportCustomDetailByUriResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTestReportCustomDetailByUriResponse>);
        }
        
        /// <summary>
        /// 下载图片
        ///
        /// 下载图片
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadStepImageNewResponse DownloadStepImageNew(DownloadStepImageNewRequest downloadStepImageNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.Parent, out var valueOfParent)) urlParam.Add("parent", valueOfParent);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.Sub, out var valueOfSub)) urlParam.Add("sub", valueOfSub);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.FileName, out var valueOfFileName)) urlParam.Add("file_name", valueOfFileName);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.FileType, out var valueOfFileType)) urlParam.Add("file_type", valueOfFileType);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/image/{parent}/{sub}/{file_name}/{file_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStepImageNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadStepImageNewResponse>(response);
        }

        public SyncInvoker<DownloadStepImageNewResponse> DownloadStepImageNewInvoker(DownloadStepImageNewRequest downloadStepImageNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.Parent, out var valueOfParent)) urlParam.Add("parent", valueOfParent);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.Sub, out var valueOfSub)) urlParam.Add("sub", valueOfSub);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.FileName, out var valueOfFileName)) urlParam.Add("file_name", valueOfFileName);
            if (StringUtils.TryConvertToNonEmptyString(downloadStepImageNewRequest.FileType, out var valueOfFileType)) urlParam.Add("file_type", valueOfFileType);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/image/{parent}/{sub}/{file_name}/{file_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStepImageNewRequest);
            return new SyncInvoker<DownloadStepImageNewResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadStepImageNewResponse>);
        }
        
        /// <summary>
        /// 查询告警统计数据
        ///
        /// 查询告警统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmStatisticsUsingResponse ListAlarmStatisticsUsing(ListAlarmStatisticsUsingRequest listAlarmStatisticsUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmStatisticsUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/dashboards/alarm/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsUsingRequest);
            var response = DoHttpRequestSync("POST", request);
            var listAlarmStatisticsUsingResponse = JsonUtils.DeSerializeNull<ListAlarmStatisticsUsingResponse>(response);
            listAlarmStatisticsUsingResponse.Body = JsonUtils.DeSerializeList<AlertStatisticsDto>(response);
            return listAlarmStatisticsUsingResponse;
        }

        public SyncInvoker<ListAlarmStatisticsUsingResponse> ListAlarmStatisticsUsingInvoker(ListAlarmStatisticsUsingRequest listAlarmStatisticsUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmStatisticsUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/dashboards/alarm/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmStatisticsUsingRequest);
            return new SyncInvoker<ListAlarmStatisticsUsingResponse>(this, "POST", request, response =>
            {
                var listAlarmStatisticsUsingResponse = JsonUtils.DeSerializeNull<ListAlarmStatisticsUsingResponse>(response);
                listAlarmStatisticsUsingResponse.Body = JsonUtils.DeSerializeList<AlertStatisticsDto>(response);
                return listAlarmStatisticsUsingResponse;
            });
        }
        
        /// <summary>
        /// 查询告警组列表
        ///
        /// 查询告警组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlertGroupsByConditionResponse ListAlertGroupsByCondition(ListAlertGroupsByConditionRequest listAlertGroupsByConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlertGroupsByConditionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert/group/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlertGroupsByConditionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAlertGroupsByConditionResponse>(response);
        }

        public SyncInvoker<ListAlertGroupsByConditionResponse> ListAlertGroupsByConditionInvoker(ListAlertGroupsByConditionRequest listAlertGroupsByConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlertGroupsByConditionRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert/group/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlertGroupsByConditionRequest);
            return new SyncInvoker<ListAlertGroupsByConditionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAlertGroupsByConditionResponse>);
        }
        
        /// <summary>
        /// 查询告警模板
        ///
        /// 查询告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlertTemplatesResponse ListAlertTemplates(ListAlertTemplatesRequest listAlertTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlertTemplatesRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlertTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlertTemplatesResponse>(response);
        }

        public SyncInvoker<ListAlertTemplatesResponse> ListAlertTemplatesInvoker(ListAlertTemplatesRequest listAlertTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlertTemplatesRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlertTemplatesRequest);
            return new SyncInvoker<ListAlertTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlertTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取分支列表
        ///
        /// 获取分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllBranchesResponse ListAllBranches(ListAllBranchesRequest listAllBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBranchesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllBranchesResponse>(response);
        }

        public SyncInvoker<ListAllBranchesResponse> ListAllBranchesInvoker(ListAllBranchesRequest listAllBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBranchesRequest);
            return new SyncInvoker<ListAllBranchesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllBranchesResponse>);
        }
        
        /// <summary>
        /// 查询任务告警信息
        ///
        /// 查询任务告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllConfigItemByTypeResponse ListAllConfigItemByType(ListAllConfigItemByTypeRequest listAllConfigItemByTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllConfigItemByTypeRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/service/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllConfigItemByTypeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllConfigItemByTypeResponse>(response);
        }

        public SyncInvoker<ListAllConfigItemByTypeResponse> ListAllConfigItemByTypeInvoker(ListAllConfigItemByTypeRequest listAllConfigItemByTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllConfigItemByTypeRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/service/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllConfigItemByTypeRequest);
            return new SyncInvoker<ListAllConfigItemByTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllConfigItemByTypeResponse>);
        }
        
        /// <summary>
        /// 查询项目下所有迭代计划
        ///
        /// 查询项目下所有迭代计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllIteratorsResponse ListAllIterators(ListAllIteratorsRequest listAllIteratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllIteratorsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/projects/{project_id}/iterator-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllIteratorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllIteratorsResponse>(response);
        }

        public SyncInvoker<ListAllIteratorsResponse> ListAllIteratorsInvoker(ListAllIteratorsRequest listAllIteratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllIteratorsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/projects/{project_id}/iterator-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllIteratorsRequest);
            return new SyncInvoker<ListAllIteratorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllIteratorsResponse>);
        }
        
        /// <summary>
        /// 查询用例列表
        ///
        /// 查询用例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllTestCasesResponse ListAllTestCases(ListAllTestCasesRequest listAllTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTestCasesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllTestCasesResponse>(response);
        }

        public SyncInvoker<ListAllTestCasesResponse> ListAllTestCasesInvoker(ListAllTestCasesRequest listAllTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTestCasesRequest);
            return new SyncInvoker<ListAllTestCasesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllTestCasesResponse>);
        }
        
        /// <summary>
        /// 查询附件列表
        ///
        /// 查询附件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttachmentsResponse ListAttachments(ListAttachmentsRequest listAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachmentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listAttachmentsRequest.ResourceUri, out var valueOfResourceUri)) urlParam.Add("resource_uri", valueOfResourceUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/resources/{resource_uri}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttachmentsResponse>(response);
        }

        public SyncInvoker<ListAttachmentsResponse> ListAttachmentsInvoker(ListAttachmentsRequest listAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachmentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listAttachmentsRequest.ResourceUri, out var valueOfResourceUri)) urlParam.Add("resource_uri", valueOfResourceUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/resources/{resource_uri}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachmentsRequest);
            return new SyncInvoker<ListAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttachmentsResponse>);
        }
        
        /// <summary>
        /// 获取当前局点功能是否开启
        ///
        /// 获取当前局点功能是否开启
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableConfigResponse ListAvailableConfig(ListAvailableConfigRequest listAvailableConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableConfigRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/available/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableConfigResponse>(response);
        }

        public SyncInvoker<ListAvailableConfigResponse> ListAvailableConfigInvoker(ListAvailableConfigRequest listAvailableConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableConfigRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/available/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableConfigRequest);
            return new SyncInvoker<ListAvailableConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableConfigResponse>);
        }
        
        /// <summary>
        /// 根据id获取单个basicAW信息
        ///
        /// 根据id获取单个basicAW信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBasicAwResponse ListBasicAw(ListBasicAwRequest listBasicAwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasicAwRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBasicAwResponse>(response);
        }

        public SyncInvoker<ListBasicAwResponse> ListBasicAwInvoker(ListBasicAwRequest listBasicAwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasicAwRequest);
            return new SyncInvoker<ListBasicAwResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBasicAwResponse>);
        }
        
        /// <summary>
        /// 分页获取工程BasicAW详细信息列表（含目录）
        ///
        /// 分页获取工程BasicAW列表（含目录）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBasicAwInfoListSupportsSearchResponse ListBasicAwInfoListSupportsSearch(ListBasicAwInfoListSupportsSearchRequest listBasicAwInfoListSupportsSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwInfoListSupportsSearchRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/aw-cata/aw-info-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasicAwInfoListSupportsSearchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListBasicAwInfoListSupportsSearchResponse>(response);
        }

        public SyncInvoker<ListBasicAwInfoListSupportsSearchResponse> ListBasicAwInfoListSupportsSearchInvoker(ListBasicAwInfoListSupportsSearchRequest listBasicAwInfoListSupportsSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasicAwInfoListSupportsSearchRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/aw-cata/aw-info-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasicAwInfoListSupportsSearchRequest);
            return new SyncInvoker<ListBasicAwInfoListSupportsSearchResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBasicAwInfoListSupportsSearchResponse>);
        }
        
        /// <summary>
        /// 获取分支列表
        ///
        /// 获取分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBranchesResponse ListBranches(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBranchesResponse>(response);
        }

        public SyncInvoker<ListBranchesResponse> ListBranchesInvoker(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            return new SyncInvoker<ListBranchesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBranchesResponse>);
        }
        
        /// <summary>
        /// 批量获取用例状态
        ///
        /// 批量获取用例状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCasesStatusResponse ListCasesStatus(ListCasesStatusRequest listCasesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/querycasestatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCasesStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCasesStatusResponse>(response);
        }

        public SyncInvoker<ListCasesStatusResponse> ListCasesStatusInvoker(ListCasesStatusRequest listCasesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/querycasestatus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCasesStatusRequest);
            return new SyncInvoker<ListCasesStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCasesStatusResponse>);
        }
        
        /// <summary>
        /// 查询当前租户可见的第三方服务列表
        ///
        /// 查询当前租户可见的第三方服务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainVisibleServicesResponse ListDomainVisibleServices(ListDomainVisibleServicesRequest listDomainVisibleServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainVisibleServicesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/visible-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainVisibleServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainVisibleServicesResponse>(response);
        }

        public SyncInvoker<ListDomainVisibleServicesResponse> ListDomainVisibleServicesInvoker(ListDomainVisibleServicesRequest listDomainVisibleServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainVisibleServicesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/visible-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainVisibleServicesRequest);
            return new SyncInvoker<ListDomainVisibleServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainVisibleServicesResponse>);
        }
        
        /// <summary>
        /// 查询需求树
        ///
        /// 查询需求树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIssueTreeResponse ListIssueTree(ListIssueTreeRequest listIssueTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIssueTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listIssueTreeRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/issue-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueTreeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListIssueTreeResponse>(response);
        }

        public SyncInvoker<ListIssueTreeResponse> ListIssueTreeInvoker(ListIssueTreeRequest listIssueTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIssueTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listIssueTreeRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/issue-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueTreeRequest);
            return new SyncInvoker<ListIssueTreeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIssueTreeResponse>);
        }
        
        /// <summary>
        /// 查询迭代关联的需求列表或树
        ///
        /// 查询迭代关联的需求列表或树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIteratorIssueTreeResponse ListIteratorIssueTree(ListIteratorIssueTreeRequest listIteratorIssueTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIteratorIssueTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listIteratorIssueTreeRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/iterators/{iterator_id}/issues/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorIssueTreeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListIteratorIssueTreeResponse>(response);
        }

        public SyncInvoker<ListIteratorIssueTreeResponse> ListIteratorIssueTreeInvoker(ListIteratorIssueTreeRequest listIteratorIssueTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIteratorIssueTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listIteratorIssueTreeRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/iterators/{iterator_id}/issues/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorIssueTreeRequest);
            return new SyncInvoker<ListIteratorIssueTreeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIteratorIssueTreeResponse>);
        }
        
        /// <summary>
        /// 查询迭代计划列表，包含统计信息
        ///
        /// 查询迭代计划列表，包含统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIteratorsResponse ListIterators(ListIteratorsRequest listIteratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListIteratorsResponse>(response);
        }

        public SyncInvoker<ListIteratorsResponse> ListIteratorsInvoker(ListIteratorsRequest listIteratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorsRequest);
            return new SyncInvoker<ListIteratorsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIteratorsResponse>);
        }
        
        /// <summary>
        /// 查询迭代计划列表，包含统计信息，对版本强校验
        ///
        /// 查询迭代计划列表，包含统计信息，对版本强校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIteratorsInfoResponse ListIteratorsInfo(ListIteratorsInfoRequest listIteratorsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/iterators/info/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorsInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListIteratorsInfoResponse>(response);
        }

        public SyncInvoker<ListIteratorsInfoResponse> ListIteratorsInfoInvoker(ListIteratorsInfoRequest listIteratorsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/iterators/info/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIteratorsInfoRequest);
            return new SyncInvoker<ListIteratorsInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIteratorsInfoResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘折线图数据
        ///
        /// 查询仪表盘折线图数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLinesUsingResponse ListLinesUsing(ListLinesUsingRequest listLinesUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLinesUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinesUsingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLinesUsingResponse>(response);
        }

        public SyncInvoker<ListLinesUsingResponse> ListLinesUsingInvoker(ListLinesUsingRequest listLinesUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLinesUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinesUsingRequest);
            return new SyncInvoker<ListLinesUsingResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLinesUsingResponse>);
        }
        
        /// <summary>
        /// 仪表盘根据测试服务ID获取MsgInfo详细信息
        ///
        /// 成功返回MsgInfo的详细信息列表，返回值为Model的List
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMsgInfosUsingResponse ListMsgInfosUsing(ListMsgInfosUsingRequest listMsgInfosUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMsgInfosUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/alarm/msgs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsgInfosUsingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListMsgInfosUsingResponse>(response);
        }

        public SyncInvoker<ListMsgInfosUsingResponse> ListMsgInfosUsingInvoker(ListMsgInfosUsingRequest listMsgInfosUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMsgInfosUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/alarm/msgs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsgInfosUsingRequest);
            return new SyncInvoker<ListMsgInfosUsingResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMsgInfosUsingResponse>);
        }
        
        /// <summary>
        /// 获取责任人是自己的测试用例
        ///
        /// 获取责任人是自己的测试用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOwnTestCasesResponse ListOwnTestCases(ListOwnTestCasesRequest listOwnTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/current-user/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOwnTestCasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOwnTestCasesResponse>(response);
        }

        public SyncInvoker<ListOwnTestCasesResponse> ListOwnTestCasesInvoker(ListOwnTestCasesRequest listOwnTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/current-user/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOwnTestCasesRequest);
            return new SyncInvoker<ListOwnTestCasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOwnTestCasesResponse>);
        }
        
        /// <summary>
        /// 查询项目字段配置
        ///
        /// 查询项目字段配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectFieldConfigsResponse ListProjectFieldConfigs(ListProjectFieldConfigsRequest listProjectFieldConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectFieldConfigsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/projects/{project_id}/field-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectFieldConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectFieldConfigsResponse>(response);
        }

        public SyncInvoker<ListProjectFieldConfigsResponse> ListProjectFieldConfigsInvoker(ListProjectFieldConfigsRequest listProjectFieldConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectFieldConfigsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/projects/{project_id}/field-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectFieldConfigsRequest);
            return new SyncInvoker<ListProjectFieldConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectFieldConfigsResponse>);
        }
        
        /// <summary>
        /// 获取项目测试用例自定义字段列表
        ///
        /// 获取项目测试用例自定义字段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTestCaseFieldsResponse ListProjectTestCaseFields(ListProjectTestCaseFieldsRequest listProjectTestCaseFieldsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectTestCaseFieldsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcase/field/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTestCaseFieldsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTestCaseFieldsResponse>(response);
        }

        public SyncInvoker<ListProjectTestCaseFieldsResponse> ListProjectTestCaseFieldsInvoker(ListProjectTestCaseFieldsRequest listProjectTestCaseFieldsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectTestCaseFieldsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcase/field/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTestCaseFieldsRequest);
            return new SyncInvoker<ListProjectTestCaseFieldsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTestCaseFieldsResponse>);
        }
        
        /// <summary>
        /// 获取工程关联的公共aw信息和公共aw所属公共aw库信息
        ///
        /// 获取工程关联的公共aw信息和公共aw所属公共aw库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicLibAndAwsResponse ListPublicLibAndAws(ListPublicLibAndAwsRequest listPublicLibAndAwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublicLibAndAwsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/project/{project_id}/public_aw_lib_and_aws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicLibAndAwsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicLibAndAwsResponse>(response);
        }

        public SyncInvoker<ListPublicLibAndAwsResponse> ListPublicLibAndAwsInvoker(ListPublicLibAndAwsRequest listPublicLibAndAwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublicLibAndAwsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/project/{project_id}/public_aw_lib_and_aws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicLibAndAwsRequest);
            return new SyncInvoker<ListPublicLibAndAwsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicLibAndAwsResponse>);
        }
        
        /// <summary>
        /// 页面报表展示
        ///
        /// 页面报表展示
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReportsResponse ListReports(ListReportsRequest listReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReportsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listReportsRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/versions/{version_id}/custom-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReportsResponse>(response);
        }

        public SyncInvoker<ListReportsResponse> ListReportsInvoker(ListReportsRequest listReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReportsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listReportsRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/versions/{version_id}/custom-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReportsRequest);
            return new SyncInvoker<ListReportsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReportsResponse>);
        }
        
        /// <summary>
        /// 获取资源池列表
        ///
        /// 获取资源池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcePoolsResponse ListResourcePools(ListResourcePoolsRequest listResourcePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcePoolsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testexecutor/v4/{project_id}/resource-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcePoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourcePoolsResponse>(response);
        }

        public SyncInvoker<ListResourcePoolsResponse> ListResourcePoolsInvoker(ListResourcePoolsRequest listResourcePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcePoolsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testexecutor/v4/{project_id}/resource-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcePoolsRequest);
            return new SyncInvoker<ListResourcePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourcePoolsResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘散点图数据
        ///
        /// 查询仪表盘散点图数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScattersUsingResponse ListScattersUsing(ListScattersUsingRequest listScattersUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScattersUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/scatters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScattersUsingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListScattersUsingResponse>(response);
        }

        public SyncInvoker<ListScattersUsingResponse> ListScattersUsingInvoker(ListScattersUsingRequest listScattersUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScattersUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards/scatters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScattersUsingRequest);
            return new SyncInvoker<ListScattersUsingResponse>(this, "POST", request, JsonUtils.DeSerialize<ListScattersUsingResponse>);
        }
        
        /// <summary>
        /// 查询subTestCase阻塞任务数据
        ///
        /// 成功返回子任务用例数据积压信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubTaskCaseOverstockUsingResponse ListSubTaskCaseOverstockUsing(ListSubTaskCaseOverstockUsingRequest listSubTaskCaseOverstockUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubTaskCaseOverstockUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/dashboard/statistic/block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubTaskCaseOverstockUsingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubTaskCaseOverstockUsingResponse>(response);
        }

        public SyncInvoker<ListSubTaskCaseOverstockUsingResponse> ListSubTaskCaseOverstockUsingInvoker(ListSubTaskCaseOverstockUsingRequest listSubTaskCaseOverstockUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubTaskCaseOverstockUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/dashboard/statistic/block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubTaskCaseOverstockUsingRequest);
            return new SyncInvoker<ListSubTaskCaseOverstockUsingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubTaskCaseOverstockUsingResponse>);
        }
        
        /// <summary>
        /// 获取测试套关联用例详情
        ///
        /// 获取测试套关联用例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskAssignCasesResponse ListTaskAssignCases(ListTaskAssignCasesRequest listTaskAssignCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskAssignCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskAssignCasesRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/tasks/{task_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskAssignCasesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTaskAssignCasesResponse>(response);
        }

        public SyncInvoker<ListTaskAssignCasesResponse> ListTaskAssignCasesInvoker(ListTaskAssignCasesRequest listTaskAssignCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskAssignCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskAssignCasesRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/tasks/{task_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskAssignCasesRequest);
            return new SyncInvoker<ListTaskAssignCasesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTaskAssignCasesResponse>);
        }
        
        /// <summary>
        /// 查询单次测试套执行的详细结果
        ///
        /// 查询单次测试套执行的详细结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskResultsDetailResponse ListTaskResultsDetail(ListTaskResultsDetailRequest listTaskResultsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.ResultUri, out var valueOfResultUri)) urlParam.Add("result_uri", valueOfResultUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results/{result_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskResultsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTaskResultsDetailResponse>(response);
        }

        public SyncInvoker<ListTaskResultsDetailResponse> ListTaskResultsDetailInvoker(ListTaskResultsDetailRequest listTaskResultsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsDetailRequest.ResultUri, out var valueOfResultUri)) urlParam.Add("result_uri", valueOfResultUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results/{result_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskResultsDetailRequest);
            return new SyncInvoker<ListTaskResultsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskResultsDetailResponse>);
        }
        
        /// <summary>
        /// 查询用例关联的测试任务列表
        ///
        /// 查询用例关联的测试任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskTestCasesResponse ListTaskTestCases(ListTaskTestCasesRequest listTaskTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/tasks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskTestCasesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTaskTestCasesResponse>(response);
        }

        public SyncInvoker<ListTaskTestCasesResponse> ListTaskTestCasesInvoker(ListTaskTestCasesRequest listTaskTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/tasks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskTestCasesRequest);
            return new SyncInvoker<ListTaskTestCasesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTaskTestCasesResponse>);
        }
        
        /// <summary>
        /// 查询测试任务列表
        ///
        /// 查询测试任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTasksResponse ListTasks(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTasksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTasksRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/tasks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public SyncInvoker<ListTasksResponse> ListTasksInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTasksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTasksRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/tasks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new SyncInvoker<ListTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 查询用例评论
        ///
        /// 查询用例评论
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestCaseCommentsResponse ListTestCaseComments(ListTestCaseCommentsRequest listTestCaseCommentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseCommentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseCommentsRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseCommentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTestCaseCommentsResponse>(response);
        }

        public SyncInvoker<ListTestCaseCommentsResponse> ListTestCaseCommentsInvoker(ListTestCaseCommentsRequest listTestCaseCommentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseCommentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseCommentsRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseCommentsRequest);
            return new SyncInvoker<ListTestCaseCommentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTestCaseCommentsResponse>);
        }
        
        /// <summary>
        /// 查询用例修改历史记录
        ///
        /// 查询用例修改历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestCaseHistoriesResponse ListTestCaseHistories(ListTestCaseHistoriesRequest listTestCaseHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseHistoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseHistoriesRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/{testcase_id}/histories/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseHistoriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTestCaseHistoriesResponse>(response);
        }

        public SyncInvoker<ListTestCaseHistoriesResponse> ListTestCaseHistoriesInvoker(ListTestCaseHistoriesRequest listTestCaseHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseHistoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseHistoriesRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/{testcase_id}/histories/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseHistoriesRequest);
            return new SyncInvoker<ListTestCaseHistoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTestCaseHistoriesResponse>);
        }
        
        /// <summary>
        /// 获取用例脚本详细信息
        ///
        /// 获取用例脚本详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestCaseScriptDetailResponse ListTestCaseScriptDetail(ListTestCaseScriptDetailRequest listTestCaseScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseScriptDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseScriptDetailRequest.TmssCaseUri, out var valueOfTmssCaseUri)) urlParam.Add("tmss_case_uri", valueOfTmssCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/testcase/{tmss_case_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseScriptDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListTestCaseScriptDetailResponse>(response);
        }

        public SyncInvoker<ListTestCaseScriptDetailResponse> ListTestCaseScriptDetailInvoker(ListTestCaseScriptDetailRequest listTestCaseScriptDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseScriptDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCaseScriptDetailRequest.TmssCaseUri, out var valueOfTmssCaseUri)) urlParam.Add("tmss_case_uri", valueOfTmssCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/testcase/{tmss_case_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCaseScriptDetailRequest);
            return new SyncInvoker<ListTestCaseScriptDetailResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListTestCaseScriptDetailResponse>);
        }
        
        /// <summary>
        /// 查询用例列表
        ///
        /// 查询用例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestCasesResponse ListTestCases(ListTestCasesRequest listTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCasesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTestCasesResponse>(response);
        }

        public SyncInvoker<ListTestCasesResponse> ListTestCasesInvoker(ListTestCasesRequest listTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCasesRequest);
            return new SyncInvoker<ListTestCasesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTestCasesResponse>);
        }
        
        /// <summary>
        /// 查询需求下的用例列表
        ///
        /// 查询需求下的用例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestCasesByIssueResponse ListTestCasesByIssue(ListTestCasesByIssueRequest listTestCasesByIssueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesByIssueRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesByIssueRequest.IssueId, out var valueOfIssueId)) urlParam.Add("issue_id", valueOfIssueId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/{project_id}/issues/{issue_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCasesByIssueRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTestCasesByIssueResponse>(response);
        }

        public SyncInvoker<ListTestCasesByIssueResponse> ListTestCasesByIssueInvoker(ListTestCasesByIssueRequest listTestCasesByIssueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesByIssueRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTestCasesByIssueRequest.IssueId, out var valueOfIssueId)) urlParam.Add("issue_id", valueOfIssueId);
            var urlPath = HttpUtils.AddUrlPath("/testrelation/v4/{project_id}/issues/{issue_id}/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestCasesByIssueRequest);
            return new SyncInvoker<ListTestCasesByIssueResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTestCasesByIssueResponse>);
        }
        
        /// <summary>
        /// 根据查询条件获取测试报告列表
        ///
        /// 根据查询条件获取测试报告列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestReportsByConditionResponse ListTestReportsByCondition(ListTestReportsByConditionRequest listTestReportsByConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestReportsByConditionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/test-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestReportsByConditionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTestReportsByConditionResponse>(response);
        }

        public SyncInvoker<ListTestReportsByConditionResponse> ListTestReportsByConditionInvoker(ListTestReportsByConditionRequest listTestReportsByConditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestReportsByConditionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/test-reports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestReportsByConditionRequest);
            return new SyncInvoker<ListTestReportsByConditionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTestReportsByConditionResponse>);
        }
        
        /// <summary>
        /// 获取测试类型列表
        ///
        /// 获取测试类型列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestTypesResponse ListTestTypes(ListTestTypesRequest listTestTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestTypesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/test-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTestTypesResponse>(response);
        }

        public SyncInvoker<ListTestTypesResponse> ListTestTypesInvoker(ListTestTypesRequest listTestTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestTypesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/test-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestTypesRequest);
            return new SyncInvoker<ListTestTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTestTypesResponse>);
        }
        
        /// <summary>
        /// 查询项目下关联了需求的用例列表
        ///
        /// 查询项目下关联了需求的用例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestcasesByProjectIssuesRelationResponse ListTestcasesByProjectIssuesRelation(ListTestcasesByProjectIssuesRelationRequest listTestcasesByProjectIssuesRelationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestcasesByProjectIssuesRelationRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/issues/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestcasesByProjectIssuesRelationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTestcasesByProjectIssuesRelationResponse>(response);
        }

        public SyncInvoker<ListTestcasesByProjectIssuesRelationResponse> ListTestcasesByProjectIssuesRelationInvoker(ListTestcasesByProjectIssuesRelationRequest listTestcasesByProjectIssuesRelationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestcasesByProjectIssuesRelationRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/issues/testcases/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestcasesByProjectIssuesRelationRequest);
            return new SyncInvoker<ListTestcasesByProjectIssuesRelationResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTestcasesByProjectIssuesRelationResponse>);
        }
        
        /// <summary>
        /// 获取租户订单已用资源信息
        ///
        /// 获取租户订单已用资源信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsageInfosResponse ListUsageInfos(ListUsageInfosRequest listUsageInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/domain/usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsageInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsageInfosResponse>(response);
        }

        public SyncInvoker<ListUsageInfosResponse> ListUsageInfosInvoker(ListUsageInfosRequest listUsageInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/domain/usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsageInfosRequest);
            return new SyncInvoker<ListUsageInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsageInfosResponse>);
        }
        
        /// <summary>
        /// 查询用户DNS映射
        ///
        /// 查询用户DNS映射
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserDnsMappingResponse ListUserDnsMapping(ListUserDnsMappingRequest listUserDnsMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserDnsMappingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDnsMappingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserDnsMappingResponse>(response);
        }

        public SyncInvoker<ListUserDnsMappingResponse> ListUserDnsMappingInvoker(ListUserDnsMappingRequest listUserDnsMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserDnsMappingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserDnsMappingRequest);
            return new SyncInvoker<ListUserDnsMappingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserDnsMappingResponse>);
        }
        
        /// <summary>
        /// ListUserPackageUsage
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserPackageUsageResponse ListUserPackageUsage(ListUserPackageUsageRequest listUserPackageUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPackageUsageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/package-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPackageUsageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserPackageUsageResponse>(response);
        }

        public SyncInvoker<ListUserPackageUsageResponse> ListUserPackageUsageInvoker(ListUserPackageUsageRequest listUserPackageUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPackageUsageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/package-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPackageUsageRequest);
            return new SyncInvoker<ListUserPackageUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserPackageUsageResponse>);
        }
        
        /// <summary>
        /// ListUserPopupInfo
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserPopupInfoResponse ListUserPopupInfo(ListUserPopupInfoRequest listUserPopupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPopupInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/package-charge/popup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPopupInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserPopupInfoResponse>(response);
        }

        public SyncInvoker<ListUserPopupInfoResponse> ListUserPopupInfoInvoker(ListUserPopupInfoRequest listUserPopupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPopupInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/package-charge/popup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPopupInfoRequest);
            return new SyncInvoker<ListUserPopupInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserPopupInfoResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘用户的看板
        ///
        /// 查询仪表盘用户的看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsingGetResponse ListUsingGet(ListUsingGetRequest listUsingGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsingGetRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsingGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsingGetResponse>(response);
        }

        public SyncInvoker<ListUsingGetResponse> ListUsingGetInvoker(ListUsingGetRequest listUsingGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsingGetRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsingGetRequest);
            return new SyncInvoker<ListUsingGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsingGetResponse>);
        }
        
        /// <summary>
        /// 查询全局变量参数列表V4
        ///
        /// 查询全局变量参数列表V4
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVariablesResponse ListVariables(ListVariablesRequest listVariablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVariablesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/variables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVariablesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVariablesResponse>(response);
        }

        public SyncInvoker<ListVariablesResponse> ListVariablesInvoker(ListVariablesRequest listVariablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVariablesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/variables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVariablesRequest);
            return new SyncInvoker<ListVariablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVariablesResponse>);
        }
        
        /// <summary>
        /// 从迭代中移除需求
        ///
        /// 从迭代中移除需求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveIssuesFromIteratorResponse RemoveIssuesFromIterator(RemoveIssuesFromIteratorRequest removeIssuesFromIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIssuesFromIteratorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeIssuesFromIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/iterators/{iterator_id}/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIssuesFromIteratorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RemoveIssuesFromIteratorResponse>(response);
        }

        public SyncInvoker<RemoveIssuesFromIteratorResponse> RemoveIssuesFromIteratorInvoker(RemoveIssuesFromIteratorRequest removeIssuesFromIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIssuesFromIteratorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeIssuesFromIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/iterators/{iterator_id}/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIssuesFromIteratorRequest);
            return new SyncInvoker<RemoveIssuesFromIteratorResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RemoveIssuesFromIteratorResponse>);
        }
        
        /// <summary>
        /// 批量执行测试用例
        ///
        /// 批量执行测试用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTestCaseResponse RunTestCase(RunTestCaseRequest runTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTestCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunTestCaseResponse>(response);
        }

        public SyncInvoker<RunTestCaseResponse> RunTestCaseInvoker(RunTestCaseRequest runTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTestCaseRequest);
            return new SyncInvoker<RunTestCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTestCaseResponse>);
        }
        
        /// <summary>
        /// 保存任务配置
        ///
        /// 保存任务配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveTaskSettingResponse SaveTaskSetting(SaveTaskSettingRequest saveTaskSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTaskSettingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/task/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTaskSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SaveTaskSettingResponse>(response);
        }

        public SyncInvoker<SaveTaskSettingResponse> SaveTaskSettingInvoker(SaveTaskSettingRequest saveTaskSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTaskSettingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/task/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTaskSettingRequest);
            return new SyncInvoker<SaveTaskSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<SaveTaskSettingResponse>);
        }
        
        /// <summary>
        /// 创建测试报告自定义模块
        ///
        /// 创建测试报告自定义模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveTestReportCustomDetailResponse SaveTestReportCustomDetail(SaveTestReportCustomDetailRequest saveTestReportCustomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTestReportCustomDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SaveTestReportCustomDetailResponse>(response);
        }

        public SyncInvoker<SaveTestReportCustomDetailResponse> SaveTestReportCustomDetailInvoker(SaveTestReportCustomDetailRequest saveTestReportCustomDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(saveTestReportCustomDetailRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTestReportCustomDetailRequest);
            return new SyncInvoker<SaveTestReportCustomDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<SaveTestReportCustomDetailResponse>);
        }
        
        /// <summary>
        /// 设置测试套结果
        ///
        /// 设置测试套结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetTaskResultResponse SetTaskResult(SetTaskResultRequest setTaskResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setTaskResultRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(setTaskResultRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTaskResultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetTaskResultResponse>(response);
        }

        public SyncInvoker<SetTaskResultResponse> SetTaskResultInvoker(SetTaskResultRequest setTaskResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setTaskResultRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(setTaskResultRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTaskResultRequest);
            return new SyncInvoker<SetTaskResultResponse>(this, "POST", request, JsonUtils.DeSerialize<SetTaskResultResponse>);
        }
        
        /// <summary>
        /// 查询任务配置
        ///
        /// 查询任务配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAllConfigValueByTypeAndKeyResponse ShowAllConfigValueByTypeAndKey(ShowAllConfigValueByTypeAndKeyRequest showAllConfigValueByTypeAndKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllConfigValueByTypeAndKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/service/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllConfigValueByTypeAndKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAllConfigValueByTypeAndKeyResponse>(response);
        }

        public SyncInvoker<ShowAllConfigValueByTypeAndKeyResponse> ShowAllConfigValueByTypeAndKeyInvoker(ShowAllConfigValueByTypeAndKeyRequest showAllConfigValueByTypeAndKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllConfigValueByTypeAndKeyRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/service/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllConfigValueByTypeAndKeyRequest);
            return new SyncInvoker<ShowAllConfigValueByTypeAndKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllConfigValueByTypeAndKeyResponse>);
        }
        
        /// <summary>
        /// 获取特性树V5
        ///
        /// 获取目录\\特性树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAllFeatureChildrenResponse ShowAllFeatureChildren(ShowAllFeatureChildrenRequest showAllFeatureChildrenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllFeatureChildrenRequest.FeatureId, out var valueOfFeatureId)) urlParam.Add("feature_id", valueOfFeatureId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v5/features/{feature_id}/children", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFeatureChildrenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAllFeatureChildrenResponse>(response);
        }

        public SyncInvoker<ShowAllFeatureChildrenResponse> ShowAllFeatureChildrenInvoker(ShowAllFeatureChildrenRequest showAllFeatureChildrenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllFeatureChildrenRequest.FeatureId, out var valueOfFeatureId)) urlParam.Add("feature_id", valueOfFeatureId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v5/features/{feature_id}/children", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFeatureChildrenRequest);
            return new SyncInvoker<ShowAllFeatureChildrenResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAllFeatureChildrenResponse>);
        }
        
        /// <summary>
        /// 获取用例历史执行数据
        ///
        /// 获取用例历史执行数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiTestcaseHistoriesResponse ShowApiTestcaseHistories(ShowApiTestcaseHistoriesRequest showApiTestcaseHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiTestcaseHistoriesRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(showApiTestcaseHistoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/api-testcases/{testcase_id}/execute-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiTestcaseHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiTestcaseHistoriesResponse>(response);
        }

        public SyncInvoker<ShowApiTestcaseHistoriesResponse> ShowApiTestcaseHistoriesInvoker(ShowApiTestcaseHistoriesRequest showApiTestcaseHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiTestcaseHistoriesRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(showApiTestcaseHistoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/api-testcases/{testcase_id}/execute-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiTestcaseHistoriesRequest);
            return new SyncInvoker<ShowApiTestcaseHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiTestcaseHistoriesResponse>);
        }
        
        /// <summary>
        /// 获取资产列表
        ///
        /// 获取资产列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetResponse ShowAsset(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetResponse>(response);
        }

        public SyncInvoker<ShowAssetResponse> ShowAssetInvoker(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            return new SyncInvoker<ShowAssetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetResponse>);
        }
        
        /// <summary>
        /// 获取资产树列表
        ///
        /// 获取资产树列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetTreeResponse ShowAssetTree(ShowAssetTreeRequest showAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetTreeResponse>(response);
        }

        public SyncInvoker<ShowAssetTreeResponse> ShowAssetTreeInvoker(ShowAssetTreeRequest showAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTreeRequest);
            return new SyncInvoker<ShowAssetTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetTreeResponse>);
        }
        
        /// <summary>
        /// 获取测试报告的模板设置
        ///
        /// 获取测试报告的模板设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackgroundInfoResponse ShowBackgroundInfo(ShowBackgroundInfoRequest showBackgroundInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/background", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundInfoResponse>(response);
        }

        public SyncInvoker<ShowBackgroundInfoResponse> ShowBackgroundInfoInvoker(ShowBackgroundInfoRequest showBackgroundInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/background", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundInfoRequest);
            return new SyncInvoker<ShowBackgroundInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundInfoResponse>);
        }
        
        /// <summary>
        /// 获取分支详情
        ///
        /// 获取分支详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBranchResponse ShowBranch(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.BranchId, out var valueOfBranchId)) urlParam.Add("branch_id", valueOfBranchId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches/{branch_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchResponse>(response);
        }

        public SyncInvoker<ShowBranchResponse> ShowBranchInvoker(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.BranchId, out var valueOfBranchId)) urlParam.Add("branch_id", valueOfBranchId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/branches/{branch_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            return new SyncInvoker<ShowBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchResponse>);
        }
        
        /// <summary>
        /// 查询用例结果
        ///
        /// 查询用例结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCaseResultResponse ShowCaseResult(ShowCaseResultRequest showCaseResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCaseResultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowCaseResultResponse>(response);
        }

        public SyncInvoker<ShowCaseResultResponse> ShowCaseResultInvoker(ShowCaseResultRequest showCaseResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(showCaseResultRequest.CaseUri, out var valueOfCaseUri)) urlParam.Add("case_uri", valueOfCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/testcases/{case_uri}/results/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCaseResultRequest);
            return new SyncInvoker<ShowCaseResultResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowCaseResultResponse>);
        }
        
        /// <summary>
        /// 查询租户测试并发套餐状态
        ///
        /// 查询租户测试并发套餐状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConcurrencyPackageUsingResponse ShowConcurrencyPackageUsing(ShowConcurrencyPackageUsingRequest showConcurrencyPackageUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/echotest/concurrency/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConcurrencyPackageUsingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowConcurrencyPackageUsingResponse>(response);
        }

        public SyncInvoker<ShowConcurrencyPackageUsingResponse> ShowConcurrencyPackageUsingInvoker(ShowConcurrencyPackageUsingRequest showConcurrencyPackageUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/echotest/concurrency/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConcurrencyPackageUsingRequest);
            return new SyncInvoker<ShowConcurrencyPackageUsingResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowConcurrencyPackageUsingResponse>);
        }
        
        /// <summary>
        /// 查询用户免责声明
        ///
        /// 查询用户免责声明
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDisclaimerRecordResponse ShowDisclaimerRecord(ShowDisclaimerRecordRequest showDisclaimerRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/disclaimer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisclaimerRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDisclaimerRecordResponse>(response);
        }

        public SyncInvoker<ShowDisclaimerRecordResponse> ShowDisclaimerRecordInvoker(ShowDisclaimerRecordRequest showDisclaimerRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/disclaimer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisclaimerRecordRequest);
            return new SyncInvoker<ShowDisclaimerRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDisclaimerRecordResponse>);
        }
        
        /// <summary>
        /// 根据domainId获取加密的testbirdkey
        ///
        /// 根据domainId获取加密的testbirdkey
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainInfoResponse ShowDomainInfo(ShowDomainInfoRequest showDomainInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/user-info/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainInfoResponse>(response);
        }

        public SyncInvoker<ShowDomainInfoResponse> ShowDomainInfoInvoker(ShowDomainInfoRequest showDomainInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/user-info/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainInfoRequest);
            return new SyncInvoker<ShowDomainInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户在线拨测套餐状态
        ///
        /// 查询租户在线拨测套餐状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEchoTestPackageUsingResponse ShowEchoTestPackageUsing(ShowEchoTestPackageUsingRequest showEchoTestPackageUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEchoTestPackageUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/package/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEchoTestPackageUsingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowEchoTestPackageUsingResponse>(response);
        }

        public SyncInvoker<ShowEchoTestPackageUsingResponse> ShowEchoTestPackageUsingInvoker(ShowEchoTestPackageUsingRequest showEchoTestPackageUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEchoTestPackageUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/package/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEchoTestPackageUsingRequest);
            return new SyncInvoker<ShowEchoTestPackageUsingResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowEchoTestPackageUsingResponse>);
        }
        
        /// <summary>
        /// 查询指定表的内容
        ///
        /// 查询指定表的内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEtlDataResponse ShowEtlData(ShowEtlDataRequest showEtlDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/testhub/etl/query-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEtlDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowEtlDataResponse>(response);
        }

        public SyncInvoker<ShowEtlDataResponse> ShowEtlDataInvoker(ShowEtlDataRequest showEtlDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/testhub/etl/query-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEtlDataRequest);
            return new SyncInvoker<ShowEtlDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowEtlDataResponse>);
        }
        
        /// <summary>
        /// 根据目录查询因子
        ///
        /// 根据目录查询因子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFactorByAssetIdResponse ShowFactorByAssetId(ShowFactorByAssetIdRequest showFactorByAssetIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFactorByAssetIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFactorByAssetIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFactorByAssetIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowFactorByAssetIdResponse>(response);
        }

        public SyncInvoker<ShowFactorByAssetIdResponse> ShowFactorByAssetIdInvoker(ShowFactorByAssetIdRequest showFactorByAssetIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFactorByAssetIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFactorByAssetIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFactorByAssetIdRequest);
            return new SyncInvoker<ShowFactorByAssetIdResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowFactorByAssetIdResponse>);
        }
        
        /// <summary>
        /// 根据id获取因子
        ///
        /// 根据id获取因子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFactorByIdResponse ShowFactorById(ShowFactorByIdRequest showFactorByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFactorByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFactorByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFactorByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFactorByIdResponse>(response);
        }

        public SyncInvoker<ShowFactorByIdResponse> ShowFactorByIdInvoker(ShowFactorByIdRequest showFactorByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFactorByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFactorByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFactorByIdRequest);
            return new SyncInvoker<ShowFactorByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFactorByIdResponse>);
        }
        
        /// <summary>
        /// 获取目录\\特性树
        ///
        /// 获取目录\\特性树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFeatureChildrenResponse ShowFeatureChildren(ShowFeatureChildrenRequest showFeatureChildrenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFeatureChildrenRequest.FeatureId, out var valueOfFeatureId)) urlParam.Add("feature_id", valueOfFeatureId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/features/{feature_id}/children", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFeatureChildrenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowFeatureChildrenResponse>(response);
        }

        public SyncInvoker<ShowFeatureChildrenResponse> ShowFeatureChildrenInvoker(ShowFeatureChildrenRequest showFeatureChildrenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFeatureChildrenRequest.FeatureId, out var valueOfFeatureId)) urlParam.Add("feature_id", valueOfFeatureId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/features/{feature_id}/children", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFeatureChildrenRequest);
            return new SyncInvoker<ShowFeatureChildrenResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowFeatureChildrenResponse>);
        }
        
        /// <summary>
        /// 查询限时免费用户免责声明记录
        ///
        /// 查询限时免费用户免责声明记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFreeDeclarationResponse ShowFreeDeclaration(ShowFreeDeclarationRequest showFreeDeclarationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/free-declaration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFreeDeclarationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFreeDeclarationResponse>(response);
        }

        public SyncInvoker<ShowFreeDeclarationResponse> ShowFreeDeclarationInvoker(ShowFreeDeclarationRequest showFreeDeclarationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/free-declaration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFreeDeclarationRequest);
            return new SyncInvoker<ShowFreeDeclarationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFreeDeclarationResponse>);
        }
        
        /// <summary>
        /// 查询告警模板名称是否重复
        ///
        /// 查询告警模板名称是否重复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIfTaskNameRepeatResponse ShowIfTaskNameRepeat(ShowIfTaskNameRepeatRequest showIfTaskNameRepeatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIfTaskNameRepeatRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert-templates/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIfTaskNameRepeatRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIfTaskNameRepeatResponse>(response);
        }

        public SyncInvoker<ShowIfTaskNameRepeatResponse> ShowIfTaskNameRepeatInvoker(ShowIfTaskNameRepeatRequest showIfTaskNameRepeatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIfTaskNameRepeatRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert-templates/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIfTaskNameRepeatRequest);
            return new SyncInvoker<ShowIfTaskNameRepeatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIfTaskNameRepeatResponse>);
        }
        
        /// <summary>
        /// 查询告警组用户名是否重复
        ///
        /// 查询告警组用户名是否重复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIfUserNameRepeatResponse ShowIfUserNameRepeat(ShowIfUserNameRepeatRequest showIfUserNameRepeatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIfUserNameRepeatRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert/user/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIfUserNameRepeatRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowIfUserNameRepeatResponse>(response);
        }

        public SyncInvoker<ShowIfUserNameRepeatResponse> ShowIfUserNameRepeatInvoker(ShowIfUserNameRepeatRequest showIfUserNameRepeatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIfUserNameRepeatRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{service_id}/alert/user/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIfUserNameRepeatRequest);
            return new SyncInvoker<ShowIfUserNameRepeatResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowIfUserNameRepeatResponse>);
        }
        
        /// <summary>
        /// 查询某个测试计划下的需求树
        ///
        /// 查询某个测试计划下的需求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIssuesByPlanIdResponse ShowIssuesByPlanId(ShowIssuesByPlanIdRequest showIssuesByPlanIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIssuesByPlanIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showIssuesByPlanIdRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssuesByPlanIdRequest);
            var response = DoHttpRequestSync("GET", request);
            var showIssuesByPlanIdResponse = JsonUtils.DeSerializeNull<ShowIssuesByPlanIdResponse>(response);
            showIssuesByPlanIdResponse.Body = JsonUtils.DeSerializeList<TestPlanIssueDetail>(response);
            return showIssuesByPlanIdResponse;
        }

        public SyncInvoker<ShowIssuesByPlanIdResponse> ShowIssuesByPlanIdInvoker(ShowIssuesByPlanIdRequest showIssuesByPlanIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIssuesByPlanIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showIssuesByPlanIdRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssuesByPlanIdRequest);
            return new SyncInvoker<ShowIssuesByPlanIdResponse>(this, "GET", request, response =>
            {
                var showIssuesByPlanIdResponse = JsonUtils.DeSerializeNull<ShowIssuesByPlanIdResponse>(response);
                showIssuesByPlanIdResponse.Body = JsonUtils.DeSerializeList<TestPlanIssueDetail>(response);
                return showIssuesByPlanIdResponse;
            });
        }
        
        /// <summary>
        /// 查询缺陷相关联测试计划
        ///
        /// 查询缺陷相关联测试计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIteratorByDefectResponse ShowIteratorByDefect(ShowIteratorByDefectRequest showIteratorByDefectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIteratorByDefectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showIteratorByDefectRequest.DefectId, out var valueOfDefectId)) urlParam.Add("defect_id", valueOfDefectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/defects/{defect_id}/iterators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIteratorByDefectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIteratorByDefectResponse>(response);
        }

        public SyncInvoker<ShowIteratorByDefectResponse> ShowIteratorByDefectInvoker(ShowIteratorByDefectRequest showIteratorByDefectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIteratorByDefectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showIteratorByDefectRequest.DefectId, out var valueOfDefectId)) urlParam.Add("defect_id", valueOfDefectId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/defects/{defect_id}/iterators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIteratorByDefectRequest);
            return new SyncInvoker<ShowIteratorByDefectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIteratorByDefectResponse>);
        }
        
        /// <summary>
        /// 查询迭代计划详情，包含统计信息
        ///
        /// 查询迭代计划详情，包含统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIteratorDetailResponse ShowIteratorDetail(ShowIteratorDetailRequest showIteratorDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIteratorDetailRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIteratorDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIteratorDetailResponse>(response);
        }

        public SyncInvoker<ShowIteratorDetailResponse> ShowIteratorDetailInvoker(ShowIteratorDetailRequest showIteratorDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIteratorDetailRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIteratorDetailRequest);
            return new SyncInvoker<ShowIteratorDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIteratorDetailResponse>);
        }
        
        /// <summary>
        /// 根据id获取脑图对象
        ///
        /// 根据id获取脑图对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindMapByIdResponse ShowMindMapById(ShowMindMapByIdRequest showMindMapByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindMapByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindMapByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mindmaps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindMapByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMindMapByIdResponse>(response);
        }

        public SyncInvoker<ShowMindMapByIdResponse> ShowMindMapByIdInvoker(ShowMindMapByIdRequest showMindMapByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindMapByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindMapByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mindmaps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindMapByIdRequest);
            return new SyncInvoker<ShowMindMapByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMindMapByIdResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取脑图对象V3
        ///
        /// 根据条件分页获取脑图对象V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapByPageResponse ShowMindmapByPage(ShowMindmapByPageRequest showMindmapByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmaps/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowMindmapByPageResponse>(response);
        }

        public SyncInvoker<ShowMindmapByPageResponse> ShowMindmapByPageInvoker(ShowMindmapByPageRequest showMindmapByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmaps/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapByPageRequest);
            return new SyncInvoker<ShowMindmapByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMindmapByPageResponse>);
        }
        
        /// <summary>
        /// 获取脑图创建人V2
        ///
        /// 获取脑图创建人V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapCreatorNameResponse ShowMindmapCreatorName(ShowMindmapCreatorNameRequest showMindmapCreatorNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapCreatorNameRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-creator-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapCreatorNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMindmapCreatorNameResponse>(response);
        }

        public SyncInvoker<ShowMindmapCreatorNameResponse> ShowMindmapCreatorNameInvoker(ShowMindmapCreatorNameRequest showMindmapCreatorNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapCreatorNameRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-creator-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapCreatorNameRequest);
            return new SyncInvoker<ShowMindmapCreatorNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMindmapCreatorNameResponse>);
        }
        
        /// <summary>
        /// 查询运行面板信息
        ///
        /// 成功返回运行面板信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOperationalDataCurrentMonthUsingResponse ShowOperationalDataCurrentMonthUsing(ShowOperationalDataCurrentMonthUsingRequest showOperationalDataCurrentMonthUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOperationalDataCurrentMonthUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboard/run-panel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationalDataCurrentMonthUsingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOperationalDataCurrentMonthUsingResponse>(response);
        }

        public SyncInvoker<ShowOperationalDataCurrentMonthUsingResponse> ShowOperationalDataCurrentMonthUsingInvoker(ShowOperationalDataCurrentMonthUsingRequest showOperationalDataCurrentMonthUsingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOperationalDataCurrentMonthUsingRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{service_id}/dashboard/run-panel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationalDataCurrentMonthUsingRequest);
            return new SyncInvoker<ShowOperationalDataCurrentMonthUsingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOperationalDataCurrentMonthUsingResponse>);
        }
        
        /// <summary>
        /// 查询某测试计划下的操作历史
        ///
        /// 查询某测试计划下的操作历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPlanJournalsResponse ShowPlanJournals(ShowPlanJournalsRequest showPlanJournalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlanJournalsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPlanJournalsRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/journals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlanJournalsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showPlanJournalsResponse = JsonUtils.DeSerializeNull<ShowPlanJournalsResponse>(response);
            showPlanJournalsResponse.Body = JsonUtils.DeSerializeList<TestPlanJournalList>(response);
            return showPlanJournalsResponse;
        }

        public SyncInvoker<ShowPlanJournalsResponse> ShowPlanJournalsInvoker(ShowPlanJournalsRequest showPlanJournalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlanJournalsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPlanJournalsRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans/{plan_id}/journals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlanJournalsRequest);
            return new SyncInvoker<ShowPlanJournalsResponse>(this, "GET", request, response =>
            {
                var showPlanJournalsResponse = JsonUtils.DeSerializeNull<ShowPlanJournalsResponse>(response);
                showPlanJournalsResponse.Body = JsonUtils.DeSerializeList<TestPlanJournalList>(response);
                return showPlanJournalsResponse;
            });
        }
        
        /// <summary>
        /// 项目下查询测试计划列表v2
        ///
        /// 项目下查询测试计划列表v2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPlanListResponse ShowPlanList(ShowPlanListRequest showPlanListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlanListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlanListRequest);
            var response = DoHttpRequestSync("GET", request);
            var showPlanListResponse = JsonUtils.DeSerializeNull<ShowPlanListResponse>(response);
            showPlanListResponse.Body = JsonUtils.DeSerializeList<TestPlanDetail>(response);
            return showPlanListResponse;
        }

        public SyncInvoker<ShowPlanListResponse> ShowPlanListInvoker(ShowPlanListRequest showPlanListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlanListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlanListRequest);
            return new SyncInvoker<ShowPlanListResponse>(this, "GET", request, response =>
            {
                var showPlanListResponse = JsonUtils.DeSerializeNull<ShowPlanListResponse>(response);
                showPlanListResponse.Body = JsonUtils.DeSerializeList<TestPlanDetail>(response);
                return showPlanListResponse;
            });
        }
        
        /// <summary>
        /// 项目下查询测试计划列表
        ///
        /// 项目下查询测试计划列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPlansResponse ShowPlans(ShowPlansRequest showPlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlansRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlansRequest);
            var response = DoHttpRequestSync("GET", request);
            var showPlansResponse = JsonUtils.DeSerializeNull<ShowPlansResponse>(response);
            showPlansResponse.Body = JsonUtils.DeSerializeList<TestPlanDetail>(response);
            return showPlansResponse;
        }

        public SyncInvoker<ShowPlansResponse> ShowPlansInvoker(ShowPlansRequest showPlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPlansRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPlansRequest);
            return new SyncInvoker<ShowPlansResponse>(this, "GET", request, response =>
            {
                var showPlansResponse = JsonUtils.DeSerializeNull<ShowPlansResponse>(response);
                showPlansResponse.Body = JsonUtils.DeSerializeList<TestPlanDetail>(response);
                return showPlansResponse;
            });
        }
        
        /// <summary>
        /// 获取异步进度
        ///
        /// 获取异步进度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProgressResponse ShowProgress(ShowProgressRequest showProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressRequest.OperationUri, out var valueOfOperationUri)) urlParam.Add("operation_uri", valueOfOperationUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/progress/{operation_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProgressResponse>(response);
        }

        public SyncInvoker<ShowProgressResponse> ShowProgressInvoker(ShowProgressRequest showProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressRequest.OperationUri, out var valueOfOperationUri)) urlParam.Add("operation_uri", valueOfOperationUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/progress/{operation_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressRequest);
            return new SyncInvoker<ShowProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgressResponse>);
        }
        
        /// <summary>
        /// 查询质量报告看板统计信息
        ///
        /// 查询质量报告看板统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectDataDashboardResponse ShowProjectDataDashboard(ShowProjectDataDashboardRequest showProjectDataDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectDataDashboardRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/data-dashboard/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDataDashboardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowProjectDataDashboardResponse>(response);
        }

        public SyncInvoker<ShowProjectDataDashboardResponse> ShowProjectDataDashboardInvoker(ShowProjectDataDashboardRequest showProjectDataDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectDataDashboardRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/data-dashboard/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDataDashboardRequest);
            return new SyncInvoker<ShowProjectDataDashboardResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowProjectDataDashboardResponse>);
        }
        
        /// <summary>
        /// 用户获取自己当前已经注册的服务
        ///
        /// 用户获取自己当前已经注册的服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRegisterServiceResponse ShowRegisterService(ShowRegisterServiceRequest showRegisterServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegisterServiceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRegisterServiceResponse>(response);
        }

        public SyncInvoker<ShowRegisterServiceResponse> ShowRegisterServiceInvoker(ShowRegisterServiceRequest showRegisterServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRegisterServiceRequest);
            return new SyncInvoker<ShowRegisterServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRegisterServiceResponse>);
        }
        
        /// <summary>
        /// 实时计算单个自定义报表
        ///
        /// 实时计算单个自定义报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReportResponse ShowReport(ShowReportRequest showReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showReportRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{plan_id}/custom-reports/generate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowReportResponse>(response);
        }

        public SyncInvoker<ShowReportResponse> ShowReportInvoker(ShowReportRequest showReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReportRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showReportRequest.PlanId, out var valueOfPlanId)) urlParam.Add("plan_id", valueOfPlanId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{plan_id}/custom-reports/generate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportRequest);
            return new SyncInvoker<ShowReportResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowReportResponse>);
        }
        
        /// <summary>
        /// 质量报告需求测试情况统计
        ///
        /// 质量报告需求测试情况统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRequirementsOverviewResponse ShowRequirementsOverview(ShowRequirementsOverviewRequest showRequirementsOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRequirementsOverviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRequirementsOverviewRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/versions/{version_id}/requirements/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRequirementsOverviewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowRequirementsOverviewResponse>(response);
        }

        public SyncInvoker<ShowRequirementsOverviewResponse> ShowRequirementsOverviewInvoker(ShowRequirementsOverviewRequest showRequirementsOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRequirementsOverviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRequirementsOverviewRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/testreport/v4/{project_id}/versions/{version_id}/requirements/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRequirementsOverviewRequest);
            return new SyncInvoker<ShowRequirementsOverviewResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRequirementsOverviewResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取评审对象V2
        ///
        /// 根据条件分页获取评审对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReviewByPageResponse ShowReviewByPage(ShowReviewByPageRequest showReviewByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/reviews/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowReviewByPageResponse>(response);
        }

        public SyncInvoker<ShowReviewByPageResponse> ShowReviewByPageInvoker(ShowReviewByPageRequest showReviewByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/reviews/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewByPageRequest);
            return new SyncInvoker<ShowReviewByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowReviewByPageResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取场景对象V2
        ///
        /// 根据条件分页获取场景对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSceneByPageResponse ShowSceneByPage(ShowSceneByPageRequest showSceneByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSceneByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scenes/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSceneByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSceneByPageResponse>(response);
        }

        public SyncInvoker<ShowSceneByPageResponse> ShowSceneByPageInvoker(ShowSceneByPageRequest showSceneByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSceneByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/scenes/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSceneByPageRequest);
            return new SyncInvoker<ShowSceneByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSceneByPageResponse>);
        }
        
        /// <summary>
        /// 根据脑图id查询统计数目
        ///
        /// 根据脑图id查询统计数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticByIdResponse ShowStatisticById(ShowStatisticByIdRequest showStatisticByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStatisticByIdRequest.MindmapId, out var valueOfMindmapId)) urlParam.Add("mindmap_id", valueOfMindmapId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/statistics/{mindmap_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticByIdResponse>(response);
        }

        public SyncInvoker<ShowStatisticByIdResponse> ShowStatisticByIdInvoker(ShowStatisticByIdRequest showStatisticByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStatisticByIdRequest.MindmapId, out var valueOfMindmapId)) urlParam.Add("mindmap_id", valueOfMindmapId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/statistics/{mindmap_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticByIdRequest);
            return new SyncInvoker<ShowStatisticByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticByIdResponse>);
        }
        
        /// <summary>
        /// 根据入参动态查询系统配置中的信息
        ///
        /// 根据入参动态查询系统配置中的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSystemConfigsResponse ShowSystemConfigs(ShowSystemConfigsRequest showSystemConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSystemConfigsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system-config/find-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSystemConfigsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSystemConfigsResponse>(response);
        }

        public SyncInvoker<ShowSystemConfigsResponse> ShowSystemConfigsInvoker(ShowSystemConfigsRequest showSystemConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSystemConfigsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/system-config/find-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSystemConfigsRequest);
            return new SyncInvoker<ShowSystemConfigsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSystemConfigsResponse>);
        }
        
        /// <summary>
        /// 获取模板V2
        ///
        /// 获取模板V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTemplateByIdResponse ShowTemplateById(ShowTemplateByIdRequest showTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateByIdResponse>(response);
        }

        public SyncInvoker<ShowTemplateByIdResponse> ShowTemplateByIdInvoker(ShowTemplateByIdRequest showTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateByIdRequest);
            return new SyncInvoker<ShowTemplateByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateByIdResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取模板V3
        ///
        /// 根据条件分页获取模板V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTemplateByPageResponse ShowTemplateByPage(ShowTemplateByPageRequest showTemplateByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/templates/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTemplateByPageResponse>(response);
        }

        public SyncInvoker<ShowTemplateByPageResponse> ShowTemplateByPageInvoker(ShowTemplateByPageRequest showTemplateByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/templates/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateByPageRequest);
            return new SyncInvoker<ShowTemplateByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTemplateByPageResponse>);
        }
        
        /// <summary>
        /// 查询用例详情
        ///
        /// 查询用例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCaseResponse ShowTestCase(ShowTestCaseRequest showTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestCaseResponse>(response);
        }

        public SyncInvoker<ShowTestCaseResponse> ShowTestCaseInvoker(ShowTestCaseRequest showTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseRequest);
            return new SyncInvoker<ShowTestCaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTestCaseResponse>);
        }
        
        /// <summary>
        /// 查询用户用例关联缺陷的统计信息
        ///
        /// 查询用户用例关联缺陷的统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCaseAndDefectInfoResponse ShowTestCaseAndDefectInfo(ShowTestCaseAndDefectInfoRequest showTestCaseAndDefectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseAndDefectInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/defect-info/list-by-creation-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseAndDefectInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTestCaseAndDefectInfoResponse>(response);
        }

        public SyncInvoker<ShowTestCaseAndDefectInfoResponse> ShowTestCaseAndDefectInfoInvoker(ShowTestCaseAndDefectInfoRequest showTestCaseAndDefectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseAndDefectInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/defect-info/list-by-creation-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseAndDefectInfoRequest);
            return new SyncInvoker<ShowTestCaseAndDefectInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTestCaseAndDefectInfoResponse>);
        }
        
        /// <summary>
        /// 获取测试用例详情
        ///
        /// 获取测试用例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCaseDetailResponse ShowTestCaseDetail(ShowTestCaseDetailRequest showTestCaseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestCaseDetailResponse>(response);
        }

        public SyncInvoker<ShowTestCaseDetailResponse> ShowTestCaseDetailInvoker(ShowTestCaseDetailRequest showTestCaseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseDetailRequest);
            return new SyncInvoker<ShowTestCaseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTestCaseDetailResponse>);
        }
        
        /// <summary>
        /// 通过用例编号获取测试用例详情
        ///
        /// 通过用例编号获取测试用例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCaseDetailV2Response ShowTestCaseDetailV2(ShowTestCaseDetailV2Request showTestCaseDetailV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailV2Request.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseDetailV2Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestCaseDetailV2Response>(response);
        }

        public SyncInvoker<ShowTestCaseDetailV2Response> ShowTestCaseDetailV2Invoker(ShowTestCaseDetailV2Request showTestCaseDetailV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseDetailV2Request.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseDetailV2Request);
            return new SyncInvoker<ShowTestCaseDetailV2Response>(this, "GET", request, JsonUtils.DeSerialize<ShowTestCaseDetailV2Response>);
        }
        
        /// <summary>
        /// 根据用例查询评审记录
        ///
        /// 根据用例查询评审记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCaseReviewsResponse ShowTestCaseReviews(ShowTestCaseReviewsRequest showTestCaseReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseReviewsRequest.TestcaseUri, out var valueOfTestcaseUri)) urlParam.Add("testcase_uri", valueOfTestcaseUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{testcase_uri}/review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseReviewsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestCaseReviewsResponse>(response);
        }

        public SyncInvoker<ShowTestCaseReviewsResponse> ShowTestCaseReviewsInvoker(ShowTestCaseReviewsRequest showTestCaseReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCaseReviewsRequest.TestcaseUri, out var valueOfTestcaseUri)) urlParam.Add("testcase_uri", valueOfTestcaseUri);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{testcase_uri}/review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCaseReviewsRequest);
            return new SyncInvoker<ShowTestCaseReviewsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTestCaseReviewsResponse>);
        }
        
        /// <summary>
        /// 版本测试用例变更统计（只统计分支，不统计基线）
        ///
        /// 版本测试用例变更统计（只统计分支，不统计基线）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestCasesChangeStatisticsResponse ShowTestCasesChangeStatistics(ShowTestCasesChangeStatisticsRequest showTestCasesChangeStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCasesChangeStatisticsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestCasesChangeStatisticsRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/testcases/change-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCasesChangeStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestCasesChangeStatisticsResponse>(response);
        }

        public SyncInvoker<ShowTestCasesChangeStatisticsResponse> ShowTestCasesChangeStatisticsInvoker(ShowTestCasesChangeStatisticsRequest showTestCasesChangeStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestCasesChangeStatisticsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestCasesChangeStatisticsRequest.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/versions/{version_id}/testcases/change-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestCasesChangeStatisticsRequest);
            return new SyncInvoker<ShowTestCasesChangeStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTestCasesChangeStatisticsResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取测试用例对象V2
        ///
        /// 根据条件分页获取测试用例对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestcaseByPageResponse ShowTestcaseByPage(ShowTestcaseByPageRequest showTestcaseByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testcases/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestcaseByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTestcaseByPageResponse>(response);
        }

        public SyncInvoker<ShowTestcaseByPageResponse> ShowTestcaseByPageInvoker(ShowTestcaseByPageRequest showTestcaseByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testcases/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestcaseByPageRequest);
            return new SyncInvoker<ShowTestcaseByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTestcaseByPageResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取测试点对象V2
        ///
        /// 根据条件分页获取测试点对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestpointByPageResponse ShowTestpointByPage(ShowTestpointByPageRequest showTestpointByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestpointByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testpoints/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestpointByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTestpointByPageResponse>(response);
        }

        public SyncInvoker<ShowTestpointByPageResponse> ShowTestpointByPageInvoker(ShowTestpointByPageRequest showTestpointByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestpointByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testpoints/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestpointByPageRequest);
            return new SyncInvoker<ShowTestpointByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTestpointByPageResponse>);
        }
        
        /// <summary>
        /// 获取租户订单信息
        ///
        /// 获取租户订单信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserAccessInfoResponse ShowUserAccessInfo(ShowUserAccessInfoRequest showUserAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/domain/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserAccessInfoResponse>(response);
        }

        public SyncInvoker<ShowUserAccessInfoResponse> ShowUserAccessInfoInvoker(ShowUserAccessInfoRequest showUserAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/domain/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserAccessInfoRequest);
            return new SyncInvoker<ShowUserAccessInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserAccessInfoResponse>);
        }
        
        /// <summary>
        /// 查询时段内用例的执行情况
        ///
        /// 查询时段内用例的执行情况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserExecuteTestCaseInfoResponse ShowUserExecuteTestCaseInfo(ShowUserExecuteTestCaseInfoRequest showUserExecuteTestCaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserExecuteTestCaseInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/execute-info/statistic-by-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserExecuteTestCaseInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowUserExecuteTestCaseInfoResponse>(response);
        }

        public SyncInvoker<ShowUserExecuteTestCaseInfoResponse> ShowUserExecuteTestCaseInfoInvoker(ShowUserExecuteTestCaseInfoRequest showUserExecuteTestCaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserExecuteTestCaseInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/testcases/execute-info/statistic-by-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserExecuteTestCaseInfoRequest);
            return new SyncInvoker<ShowUserExecuteTestCaseInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowUserExecuteTestCaseInfoResponse>);
        }
        
        /// <summary>
        /// 修改关键字信息接口
        ///
        /// 修改关键字信息接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBasicAwByIdResponse UpdateBasicAwById(UpdateBasicAwByIdRequest updateBasicAwByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicAwByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateBasicAwByIdRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBasicAwByIdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBasicAwByIdResponse>(response);
        }

        public SyncInvoker<UpdateBasicAwByIdResponse> UpdateBasicAwByIdInvoker(UpdateBasicAwByIdRequest updateBasicAwByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicAwByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateBasicAwByIdRequest.AwId, out var valueOfAwId)) urlParam.Add("aw_id", valueOfAwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/basic-aw/{aw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBasicAwByIdRequest);
            return new SyncInvoker<UpdateBasicAwByIdResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBasicAwByIdResponse>);
        }
        
        /// <summary>
        /// 修改测试计划
        ///
        /// 修改测试计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIteratorResponse UpdateIterator(UpdateIteratorRequest updateIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIteratorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIteratorResponse>(response);
        }

        public SyncInvoker<UpdateIteratorResponse> UpdateIteratorInvoker(UpdateIteratorRequest updateIteratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIteratorRequest.IteratorId, out var valueOfIteratorId)) urlParam.Add("iterator_id", valueOfIteratorId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/iterators/{iterator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIteratorRequest);
            return new SyncInvoker<UpdateIteratorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIteratorResponse>);
        }
        
        /// <summary>
        /// 更新已注册服务
        ///
        /// 更新已注册服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServiceResponse UpdateService(UpdateServiceRequest updateServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServiceResponse>(response);
        }

        public SyncInvoker<UpdateServiceResponse> UpdateServiceInvoker(UpdateServiceRequest updateServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceRequest);
            return new SyncInvoker<UpdateServiceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServiceResponse>);
        }
        
        /// <summary>
        /// 更新自定义测试服务类型用例
        ///
        /// 更新自定义测试服务类型用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTestCaseResponse UpdateTestCase(UpdateTestCaseRequest updateTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTestCaseResponse>(response);
        }

        public SyncInvoker<UpdateTestCaseResponse> UpdateTestCaseInvoker(UpdateTestCaseRequest updateTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/{testcase_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseRequest);
            return new SyncInvoker<UpdateTestCaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTestCaseResponse>);
        }
        
        /// <summary>
        /// 更新tmss用例和用例脚本
        ///
        /// 更新tmss用例和用例脚本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTestCaseAndScriptResponse UpdateTestCaseAndScript(UpdateTestCaseAndScriptRequest updateTestCaseAndScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseAndScriptRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseAndScriptRequest.TmssCaseUri, out var valueOfTmssCaseUri)) urlParam.Add("tmss_case_uri", valueOfTmssCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/testcase/{tmss_case_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseAndScriptRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTestCaseAndScriptResponse>(response);
        }

        public SyncInvoker<UpdateTestCaseAndScriptResponse> UpdateTestCaseAndScriptInvoker(UpdateTestCaseAndScriptRequest updateTestCaseAndScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseAndScriptRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseAndScriptRequest.TmssCaseUri, out var valueOfTmssCaseUri)) urlParam.Add("tmss_case_uri", valueOfTmssCaseUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/testcase/{tmss_case_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseAndScriptRequest);
            return new SyncInvoker<UpdateTestCaseAndScriptResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTestCaseAndScriptResponse>);
        }
        
        /// <summary>
        /// 修改用例评论
        ///
        /// 修改用例评论
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTestCaseCommentResponse UpdateTestCaseComment(UpdateTestCaseCommentRequest updateTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.CommentId, out var valueOfCommentId)) urlParam.Add("comment_id", valueOfCommentId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments/{comment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseCommentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTestCaseCommentResponse>(response);
        }

        public SyncInvoker<UpdateTestCaseCommentResponse> UpdateTestCaseCommentInvoker(UpdateTestCaseCommentRequest updateTestCaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.TestcaseId, out var valueOfTestcaseId)) urlParam.Add("testcase_id", valueOfTestcaseId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseCommentRequest.CommentId, out var valueOfCommentId)) urlParam.Add("comment_id", valueOfCommentId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/{project_id}/testcases/{testcase_id}/comments/{comment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseCommentRequest);
            return new SyncInvoker<UpdateTestCaseCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTestCaseCommentResponse>);
        }
        
        /// <summary>
        /// 批量更新测试用例结果
        ///
        /// 批量更新测试用例结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTestCaseResultResponse UpdateTestCaseResult(UpdateTestCaseResultRequest updateTestCaseResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseResultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateTestCaseResultResponse>(response);
        }

        public SyncInvoker<UpdateTestCaseResultResponse> UpdateTestCaseResultInvoker(UpdateTestCaseResultRequest updateTestCaseResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestCaseResultRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/testcases/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestCaseResultRequest);
            return new SyncInvoker<UpdateTestCaseResultResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateTestCaseResultResponse>);
        }
        
        /// <summary>
        /// 修改测试报告自定义模块
        ///
        /// 修改测试报告自定义模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTestReportCustomDetailByUriResponse UpdateTestReportCustomDetailByUri(UpdateTestReportCustomDetailByUriRequest updateTestReportCustomDetailByUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.CustomInfoUri, out var valueOfCustomInfoUri)) urlParam.Add("custom_info_uri", valueOfCustomInfoUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos/{custom_info_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestReportCustomDetailByUriRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTestReportCustomDetailByUriResponse>(response);
        }

        public SyncInvoker<UpdateTestReportCustomDetailByUriResponse> UpdateTestReportCustomDetailByUriInvoker(UpdateTestReportCustomDetailByUriRequest updateTestReportCustomDetailByUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.VersionUri, out var valueOfVersionUri)) urlParam.Add("version_uri", valueOfVersionUri);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.ReportUri, out var valueOfReportUri)) urlParam.Add("report_uri", valueOfReportUri);
            if (StringUtils.TryConvertToNonEmptyString(updateTestReportCustomDetailByUriRequest.CustomInfoUri, out var valueOfCustomInfoUri)) urlParam.Add("custom_info_uri", valueOfCustomInfoUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/versions/{version_uri}/test-reports/{report_uri}/custom-infos/{custom_info_uri}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTestReportCustomDetailByUriRequest);
            return new SyncInvoker<UpdateTestReportCustomDetailByUriResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTestReportCustomDetailByUriResponse>);
        }
        
        /// <summary>
        /// 更新用户DNS映射
        ///
        /// 更新用户DNS映射，执行器自定义映射
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserDnsMappingResponse UpdateUserDnsMapping(UpdateUserDnsMappingRequest updateUserDnsMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserDnsMappingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserDnsMappingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateUserDnsMappingResponse>(response);
        }

        public SyncInvoker<UpdateUserDnsMappingResponse> UpdateUserDnsMappingInvoker(UpdateUserDnsMappingRequest updateUserDnsMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserDnsMappingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserDnsMappingRequest);
            return new SyncInvoker<UpdateUserDnsMappingResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateUserDnsMappingResponse>);
        }
        
        /// <summary>
        /// 在分支或者测试计划下修改用例
        ///
        /// 在分支或者测试计划下修改用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVersionTestCaseResponse UpdateVersionTestCase(UpdateVersionTestCaseRequest updateVersionTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionTestCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{case_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionTestCaseRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVersionTestCaseResponse>(response);
        }

        public SyncInvoker<UpdateVersionTestCaseResponse> UpdateVersionTestCaseInvoker(UpdateVersionTestCaseRequest updateVersionTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionTestCaseRequest.CaseId, out var valueOfCaseId)) urlParam.Add("case_id", valueOfCaseId);
            var urlPath = HttpUtils.AddUrlPath("/GT3KServer/v4/testcases/{case_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionTestCaseRequest);
            return new SyncInvoker<UpdateVersionTestCaseResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVersionTestCaseResponse>);
        }
        
        /// <summary>
        /// 上传附件
        ///
        /// 上传附件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadCacheFileResponse UploadCacheFile(UploadCacheFileRequest uploadCacheFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadCacheFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/resources/temp-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadCacheFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadCacheFileResponse>(response);
        }

        public SyncInvoker<UploadCacheFileResponse> UploadCacheFileInvoker(UploadCacheFileRequest uploadCacheFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadCacheFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/resources/temp-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadCacheFileRequest);
            return new SyncInvoker<UploadCacheFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadCacheFileResponse>);
        }
        
        /// <summary>
        /// 通过导入仓库中的文件生成接口测试套
        ///
        /// 通过导入仓库中的文件生成接口测试套
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateApiTestSuiteByRepoFileResponse CreateApiTestSuiteByRepoFile(CreateApiTestSuiteByRepoFileRequest createApiTestSuiteByRepoFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApiTestSuiteByRepoFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/repository/testsuites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApiTestSuiteByRepoFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateApiTestSuiteByRepoFileResponse>(response);
        }

        public SyncInvoker<CreateApiTestSuiteByRepoFileResponse> CreateApiTestSuiteByRepoFileInvoker(CreateApiTestSuiteByRepoFileRequest createApiTestSuiteByRepoFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApiTestSuiteByRepoFileRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/repository/testsuites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApiTestSuiteByRepoFileRequest);
            return new SyncInvoker<CreateApiTestSuiteByRepoFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApiTestSuiteByRepoFileResponse>);
        }
        
        /// <summary>
        /// 获取环境参数分组列表
        ///
        /// 获取环境参数分组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
        }

        public SyncInvoker<ListEnvironmentsResponse> ListEnvironmentsInvoker(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            return new SyncInvoker<ListEnvironmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnvironmentsResponse>);
        }
        
        /// <summary>
        /// 上传测试步骤图片
        ///
        /// 对外API
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadStepImgResponse UploadStepImg(UploadStepImgRequest uploadStepImgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadStepImgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/images/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadStepImgRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadStepImgResponse>(response);
        }

        public SyncInvoker<UploadStepImgResponse> UploadStepImgInvoker(UploadStepImgRequest uploadStepImgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadStepImgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/images/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadStepImgRequest);
            return new SyncInvoker<UploadStepImgResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadStepImgResponse>);
        }
        
        /// <summary>
        /// 批量删除因子
        ///
        /// 批量删除因子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteFacotrByIdsResponse BatchDeleteFacotrByIds(BatchDeleteFacotrByIdsRequest batchDeleteFacotrByIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteFacotrByIdsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacotrByIdsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteFacotrByIdsResponse>(response);
        }

        public SyncInvoker<BatchDeleteFacotrByIdsResponse> BatchDeleteFacotrByIdsInvoker(BatchDeleteFacotrByIdsRequest batchDeleteFacotrByIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteFacotrByIdsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/factor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacotrByIdsRequest);
            return new SyncInvoker<BatchDeleteFacotrByIdsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteFacotrByIdsResponse>);
        }
        
        /// <summary>
        /// 批量查询用例V3
        ///
        /// 批量查询用例V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowTestCaseResponse BatchShowTestCase(BatchShowTestCaseRequest batchShowTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowTestCaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchShowTestCaseResponse>(response);
        }

        public SyncInvoker<BatchShowTestCaseResponse> BatchShowTestCaseInvoker(BatchShowTestCaseRequest batchShowTestCaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowTestCaseRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/testcases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowTestCaseRequest);
            return new SyncInvoker<BatchShowTestCaseResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchShowTestCaseResponse>);
        }
        
        /// <summary>
        /// 新增资产树节点
        ///
        /// 新增资产树节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetTreeResponse CreateAssetTree(CreateAssetTreeRequest createAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.ParentId, out var valueOfParentId)) urlParam.Add("parent_id", valueOfParentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}/{parent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetTreeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssetTreeResponse>(response);
        }

        public SyncInvoker<CreateAssetTreeResponse> CreateAssetTreeInvoker(CreateAssetTreeRequest createAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            if (StringUtils.TryConvertToNonEmptyString(createAssetTreeRequest.ParentId, out var valueOfParentId)) urlParam.Add("parent_id", valueOfParentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}/{parent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetTreeRequest);
            return new SyncInvoker<CreateAssetTreeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetTreeResponse>);
        }
        
        /// <summary>
        /// 备份脑图V2
        ///
        /// 备份脑图V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBackupMindmapResponse CreateBackupMindmap(CreateBackupMindmapRequest createBackupMindmapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBackupMindmapRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackupMindmapRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBackupMindmapResponse>(response);
        }

        public SyncInvoker<CreateBackupMindmapResponse> CreateBackupMindmapInvoker(CreateBackupMindmapRequest createBackupMindmapRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBackupMindmapRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/backup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackupMindmapRequest);
            return new SyncInvoker<CreateBackupMindmapResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBackupMindmapResponse>);
        }
        
        /// <summary>
        /// 保存模板V2
        ///
        /// 保存模板V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
        }

        public SyncInvoker<CreateTemplateResponse> CreateTemplateInvoker(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            return new SyncInvoker<CreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateResponse>);
        }
        
        /// <summary>
        /// 删除资产
        ///
        /// 删除资产
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssetResponse DeleteAsset(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAssetResponse>(response);
        }

        public SyncInvoker<DeleteAssetResponse> DeleteAssetInvoker(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            return new SyncInvoker<DeleteAssetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssetResponse>);
        }
        
        /// <summary>
        /// 删除资产树节点
        ///
        /// 删除资产树节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssetTreeResponse DeleteAssetTree(DeleteAssetTreeRequest deleteAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.ParentId, out var valueOfParentId)) urlParam.Add("parent_id", valueOfParentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}/{parent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetTreeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAssetTreeResponse>(response);
        }

        public SyncInvoker<DeleteAssetTreeResponse> DeleteAssetTreeInvoker(DeleteAssetTreeRequest deleteAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAssetTreeRequest.ParentId, out var valueOfParentId)) urlParam.Add("parent_id", valueOfParentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree/{asset_id}/{parent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetTreeRequest);
            return new SyncInvoker<DeleteAssetTreeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssetTreeResponse>);
        }
        
        /// <summary>
        /// 根据id删除脑图备份V2
        ///
        /// 根据id删除脑图备份V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMindmapBackupByIdResponse DeleteMindmapBackupById(DeleteMindmapBackupByIdRequest deleteMindmapBackupByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapBackupByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapBackupByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMindmapBackupByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMindmapBackupByIdResponse>(response);
        }

        public SyncInvoker<DeleteMindmapBackupByIdResponse> DeleteMindmapBackupByIdInvoker(DeleteMindmapBackupByIdRequest deleteMindmapBackupByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapBackupByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapBackupByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMindmapBackupByIdRequest);
            return new SyncInvoker<DeleteMindmapBackupByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMindmapBackupByIdResponse>);
        }
        
        /// <summary>
        /// 删除脑图回收站V2
        ///
        /// 删除脑图回收站V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMindmapRecycleByIdResponse DeleteMindmapRecycleById(DeleteMindmapRecycleByIdRequest deleteMindmapRecycleByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapRecycleByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapRecycleByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-recycles/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMindmapRecycleByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMindmapRecycleByIdResponse>(response);
        }

        public SyncInvoker<DeleteMindmapRecycleByIdResponse> DeleteMindmapRecycleByIdInvoker(DeleteMindmapRecycleByIdRequest deleteMindmapRecycleByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapRecycleByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMindmapRecycleByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-recycles/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMindmapRecycleByIdRequest);
            return new SyncInvoker<DeleteMindmapRecycleByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMindmapRecycleByIdResponse>);
        }
        
        /// <summary>
        /// 删除模板V2
        ///
        /// 删除模板V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateByIdResponse DeleteTemplateById(DeleteTemplateByIdRequest deleteTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTemplateByIdResponse>(response);
        }

        public SyncInvoker<DeleteTemplateByIdResponse> DeleteTemplateByIdInvoker(DeleteTemplateByIdRequest deleteTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateByIdRequest);
            return new SyncInvoker<DeleteTemplateByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTemplateByIdResponse>);
        }
        
        /// <summary>
        /// 下载资产模板
        ///
        /// 下载资产模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadAssetTemplateResponse DownloadAssetTemplate(DownloadAssetTemplateRequest downloadAssetTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAssetTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAssetTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAssetTemplateResponse>(response);
        }

        public SyncInvoker<DownloadAssetTemplateResponse> DownloadAssetTemplateInvoker(DownloadAssetTemplateRequest downloadAssetTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAssetTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAssetTemplateRequest);
            return new SyncInvoker<DownloadAssetTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAssetTemplateResponse>);
        }
        
        /// <summary>
        /// 因子库导出
        ///
        /// 因子库导出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportFactorResponse ExportFactor(ExportFactorRequest exportFactorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportFactorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(exportFactorRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{asset_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFactorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportFactorResponse>(response);
        }

        public SyncInvoker<ExportFactorResponse> ExportFactorInvoker(ExportFactorRequest exportFactorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportFactorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(exportFactorRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{asset_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFactorRequest);
            return new SyncInvoker<ExportFactorResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportFactorResponse>);
        }
        
        /// <summary>
        /// 资产导入
        ///
        /// 资产导入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportAssetResponse ImportAsset(ImportAssetRequest importAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importAssetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportAssetResponse>(response);
        }

        public SyncInvoker<ImportAssetResponse> ImportAssetInvoker(ImportAssetRequest importAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importAssetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importAssetRequest);
            return new SyncInvoker<ImportAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportAssetResponse>);
        }
        
        /// <summary>
        /// 因子导入
        ///
        /// 因子导入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportFactorResponse ImportFactor(ImportFactorRequest importFactorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importFactorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(importFactorRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{asset_id}/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importFactorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportFactorResponse>(response);
        }

        public SyncInvoker<ImportFactorResponse> ImportFactorInvoker(ImportFactorRequest importFactorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importFactorRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(importFactorRequest.AssetId, out var valueOfAssetId)) urlParam.Add("asset_id", valueOfAssetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/{asset_id}/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importFactorRequest);
            return new SyncInvoker<ImportFactorResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportFactorResponse>);
        }
        
        /// <summary>
        /// 获取默认模板V2
        ///
        /// 获取默认模板V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDefaultTemplateByPageResponse ShowDefaultTemplateByPage(ShowDefaultTemplateByPageRequest showDefaultTemplateByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDefaultTemplateByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/templates-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultTemplateByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowDefaultTemplateByPageResponse>(response);
        }

        public SyncInvoker<ShowDefaultTemplateByPageResponse> ShowDefaultTemplateByPageInvoker(ShowDefaultTemplateByPageRequest showDefaultTemplateByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDefaultTemplateByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/templates/templates-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultTemplateByPageRequest);
            return new SyncInvoker<ShowDefaultTemplateByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowDefaultTemplateByPageResponse>);
        }
        
        /// <summary>
        /// 根据id获取脑图备份V2
        ///
        /// 根据id获取脑图备份V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapBackupByIdResponse ShowMindmapBackupById(ShowMindmapBackupByIdRequest showMindmapBackupByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapBackupByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMindmapBackupByIdResponse>(response);
        }

        public SyncInvoker<ShowMindmapBackupByIdResponse> ShowMindmapBackupByIdInvoker(ShowMindmapBackupByIdRequest showMindmapBackupByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapBackupByIdRequest);
            return new SyncInvoker<ShowMindmapBackupByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMindmapBackupByIdResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取脑图备份对象V3
        ///
        /// 根据条件分页获取脑图备份对象V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapBackupByPageResponse ShowMindmapBackupByPage(ShowMindmapBackupByPageRequest showMindmapBackupByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmap-backups/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapBackupByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowMindmapBackupByPageResponse>(response);
        }

        public SyncInvoker<ShowMindmapBackupByPageResponse> ShowMindmapBackupByPageInvoker(ShowMindmapBackupByPageRequest showMindmapBackupByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapBackupByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmap-backups/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapBackupByPageRequest);
            return new SyncInvoker<ShowMindmapBackupByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMindmapBackupByPageResponse>);
        }
        
        /// <summary>
        /// 根据id获取回收站脑图对象V2
        ///
        /// 根据id获取回收站脑图对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapRecycleByIdResponse ShowMindmapRecycleById(ShowMindmapRecycleByIdRequest showMindmapRecycleByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-recycles/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapRecycleByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMindmapRecycleByIdResponse>(response);
        }

        public SyncInvoker<ShowMindmapRecycleByIdResponse> ShowMindmapRecycleByIdInvoker(ShowMindmapRecycleByIdRequest showMindmapRecycleByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mindmap-recycles/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapRecycleByIdRequest);
            return new SyncInvoker<ShowMindmapRecycleByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMindmapRecycleByIdResponse>);
        }
        
        /// <summary>
        /// 根据条件分页获取回收站脑图对象V3
        ///
        /// 根据条件分页获取回收站脑图对象V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMindmapRecycleByPageResponse ShowMindmapRecycleByPage(ShowMindmapRecycleByPageRequest showMindmapRecycleByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmap-recycles/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapRecycleByPageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowMindmapRecycleByPageResponse>(response);
        }

        public SyncInvoker<ShowMindmapRecycleByPageResponse> ShowMindmapRecycleByPageInvoker(ShowMindmapRecycleByPageRequest showMindmapRecycleByPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMindmapRecycleByPageRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mindmap-recycles/page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMindmapRecycleByPageRequest);
            return new SyncInvoker<ShowMindmapRecycleByPageResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMindmapRecycleByPageResponse>);
        }
        
        /// <summary>
        /// 根据id获取测试用例对象V2
        ///
        /// 根据id获取测试用例对象V2
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTestcaseByIdResponse ShowTestcaseById(ShowTestcaseByIdRequest showTestcaseByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testcases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestcaseByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTestcaseByIdResponse>(response);
        }

        public SyncInvoker<ShowTestcaseByIdResponse> ShowTestcaseByIdInvoker(ShowTestcaseByIdRequest showTestcaseByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTestcaseByIdRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/testcases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTestcaseByIdRequest);
            return new SyncInvoker<ShowTestcaseByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTestcaseByIdResponse>);
        }
        
        /// <summary>
        /// 修改资产树节点
        ///
        /// 修改资产树节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssetTreeResponse UpdateAssetTree(UpdateAssetTreeRequest updateAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetTreeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAssetTreeResponse>(response);
        }

        public SyncInvoker<UpdateAssetTreeResponse> UpdateAssetTreeInvoker(UpdateAssetTreeRequest updateAssetTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAssetTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetTreeRequest);
            return new SyncInvoker<UpdateAssetTreeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssetTreeResponse>);
        }
        
        /// <summary>
        /// 脑图名称编辑
        ///
        /// 脑图名称编辑
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMindmapNameResponse UpdateMindmapName(UpdateMindmapNameRequest updateMindmapNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMindmapNameRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateMindmapNameRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mindmaps/{id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMindmapNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMindmapNameResponse>(response);
        }

        public SyncInvoker<UpdateMindmapNameResponse> UpdateMindmapNameInvoker(UpdateMindmapNameRequest updateMindmapNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMindmapNameRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateMindmapNameRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mindmaps/{id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMindmapNameRequest);
            return new SyncInvoker<UpdateMindmapNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMindmapNameResponse>);
        }
        
        /// <summary>
        /// 添加目录信息
        ///
        /// 添加目录信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddFeatureResponse AddFeature(AddFeatureRequest addFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFeatureRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddFeatureResponse>(response);
        }

        public SyncInvoker<AddFeatureResponse> AddFeatureInvoker(AddFeatureRequest addFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFeatureRequest);
            return new SyncInvoker<AddFeatureResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFeatureResponse>);
        }
        
        /// <summary>
        /// 根据测试用例URI或用例编号查询测试用例对应的测试计划
        ///
        /// 根据测试用例URI或用例编号查询测试用例对应的测试计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTestcasePlansResponse ListTestcasePlans(ListTestcasePlansRequest listTestcasePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestcasePlansRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTestcasePlansRequest.BranchUri, out var valueOfBranchUri)) urlParam.Add("branch_uri", valueOfBranchUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/branch/{branch_uri}/testcases/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestcasePlansRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTestcasePlansResponse>(response);
        }

        public SyncInvoker<ListTestcasePlansResponse> ListTestcasePlansInvoker(ListTestcasePlansRequest listTestcasePlansRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTestcasePlansRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTestcasePlansRequest.BranchUri, out var valueOfBranchUri)) urlParam.Add("branch_uri", valueOfBranchUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/branch/{branch_uri}/testcases/plans", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTestcasePlansRequest);
            return new SyncInvoker<ListTestcasePlansResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTestcasePlansResponse>);
        }
        
        /// <summary>
        /// 根据任务uri查询测试任务执行历史
        ///
        /// 根据任务uri查询测试任务执行历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskResultsResponse ListTaskResults(ListTaskResultsRequest listTaskResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskResultsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTaskResultsResponse>(response);
        }

        public SyncInvoker<ListTaskResultsResponse> ListTaskResultsInvoker(ListTaskResultsRequest listTaskResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(listTaskResultsRequest.TaskUri, out var valueOfTaskUri)) urlParam.Add("task_uri", valueOfTaskUri);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_uuid}/tasks/{task_uri}/results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskResultsRequest);
            return new SyncInvoker<ListTaskResultsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskResultsResponse>);
        }
        
    }
}