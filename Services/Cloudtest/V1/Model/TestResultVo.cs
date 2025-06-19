using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class TestResultVo 
    {

        /// <summary>
        /// 结果URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 用例结果名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// 测试结果Code
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; }

        /// <summary>
        /// 执行批次
        /// </summary>
        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public int? Round { get; set; }

        /// <summary>
        /// 前置条件
        /// </summary>
        [JsonProperty("preparation", NullValueHandling = NullValueHandling.Ignore)]
        public string Preparation { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 逻辑Region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 测试步骤信息
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResultStepVo> Steps { get; set; }

        /// <summary>
        /// 用例结果编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 执行开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 执行开始时间时间戳
        /// </summary>
        [JsonProperty("begin_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTimeTimestamp { get; set; }

        /// <summary>
        /// 执行结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 执行结束时间时间戳
        /// </summary>
        [JsonProperty("end_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTimeTimestamp { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("creation_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDateTimestamp { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// 最后变更时间
        /// </summary>
        [JsonProperty("last_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastChangeTime { get; set; }

        /// <summary>
        /// 最后变更时间
        /// </summary>
        [JsonProperty("last_change_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastChangeTimeTimestamp { get; set; }

        /// <summary>
        /// DFX测试结果
        /// </summary>
        [JsonProperty("dfx_test_result", NullValueHandling = NullValueHandling.Ignore)]
        public string DfxTestResult { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("failure_cause", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureCause { get; set; }

        /// <summary>
        /// 父节点URI(分支用例URI或迭代用例URI)
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 分支用例URI
        /// </summary>
        [JsonProperty("test_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseUri { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("test_case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 测试任务URI
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 测试结果
        /// </summary>
        [JsonProperty("result_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultName { get; set; }

        /// <summary>
        /// 是否自动化执行
        /// </summary>
        [JsonProperty("test_result_ae", NullValueHandling = NullValueHandling.Ignore)]
        public string TestResultAe { get; set; }

        /// <summary>
        /// 执行人ID
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// 执行人名称
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }

        /// <summary>
        /// 执行机任务ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 执行ID
        /// </summary>
        [JsonProperty("execute_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteId { get; set; }

        /// <summary>
        /// 执行耗时
        /// </summary>
        [JsonProperty("time_cost", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeCost { get; set; }

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("step_txt", NullValueHandling = NullValueHandling.Ignore)]
        public string StepTxt { get; set; }

        /// <summary>
        /// 测试步骤期望结果
        /// </summary>
        [JsonProperty("step_expect", NullValueHandling = NullValueHandling.Ignore)]
        public string StepExpect { get; set; }

        /// <summary>
        /// 测试步骤实际结果
        /// </summary>
        [JsonProperty("step_actual", NullValueHandling = NullValueHandling.Ignore)]
        public string StepActual { get; set; }

        /// <summary>
        /// 测试步骤结果
        /// </summary>
        [JsonProperty("step_result", NullValueHandling = NullValueHandling.Ignore)]
        public string StepResult { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 创建版本URI
        /// </summary>
        [JsonProperty("creation_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationVersionUri { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 第三方过来的执行结果，返回跳转到第三方的url
        /// </summary>
        [JsonProperty("report_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// 测试用例编号
        /// </summary>
        [JsonProperty("test_case_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseNumber { get; set; }

        /// <summary>
        /// 测试类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestResultVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  round: ").Append(Round).Append("\n");
            sb.Append("  preparation: ").Append(Preparation).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  beginTimeTimestamp: ").Append(BeginTimeTimestamp).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  endTimeTimestamp: ").Append(EndTimeTimestamp).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  creationDateTimestamp: ").Append(CreationDateTimestamp).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  lastModifiedTimestamp: ").Append(LastModifiedTimestamp).Append("\n");
            sb.Append("  lastChangeTime: ").Append(LastChangeTime).Append("\n");
            sb.Append("  lastChangeTimeTimestamp: ").Append(LastChangeTimeTimestamp).Append("\n");
            sb.Append("  dfxTestResult: ").Append(DfxTestResult).Append("\n");
            sb.Append("  failureCause: ").Append(FailureCause).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  testCaseUri: ").Append(TestCaseUri).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  resultName: ").Append(ResultName).Append("\n");
            sb.Append("  testResultAe: ").Append(TestResultAe).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  executeId: ").Append(ExecuteId).Append("\n");
            sb.Append("  timeCost: ").Append(TimeCost).Append("\n");
            sb.Append("  stepTxt: ").Append(StepTxt).Append("\n");
            sb.Append("  stepExpect: ").Append(StepExpect).Append("\n");
            sb.Append("  stepActual: ").Append(StepActual).Append("\n");
            sb.Append("  stepResult: ").Append(StepResult).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  creationVersionUri: ").Append(CreationVersionUri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  reportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  testCaseNumber: ").Append(TestCaseNumber).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestResultVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestResultVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Round != input.Round || (this.Round != null && !this.Round.Equals(input.Round))) return false;
            if (this.Preparation != input.Preparation || (this.Preparation != null && !this.Preparation.Equals(input.Preparation))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.BeginTimeTimestamp != input.BeginTimeTimestamp || (this.BeginTimeTimestamp != null && !this.BeginTimeTimestamp.Equals(input.BeginTimeTimestamp))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.EndTimeTimestamp != input.EndTimeTimestamp || (this.EndTimeTimestamp != null && !this.EndTimeTimestamp.Equals(input.EndTimeTimestamp))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreationDateTimestamp != input.CreationDateTimestamp || (this.CreationDateTimestamp != null && !this.CreationDateTimestamp.Equals(input.CreationDateTimestamp))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.LastModifiedTimestamp != input.LastModifiedTimestamp || (this.LastModifiedTimestamp != null && !this.LastModifiedTimestamp.Equals(input.LastModifiedTimestamp))) return false;
            if (this.LastChangeTime != input.LastChangeTime || (this.LastChangeTime != null && !this.LastChangeTime.Equals(input.LastChangeTime))) return false;
            if (this.LastChangeTimeTimestamp != input.LastChangeTimeTimestamp || (this.LastChangeTimeTimestamp != null && !this.LastChangeTimeTimestamp.Equals(input.LastChangeTimeTimestamp))) return false;
            if (this.DfxTestResult != input.DfxTestResult || (this.DfxTestResult != null && !this.DfxTestResult.Equals(input.DfxTestResult))) return false;
            if (this.FailureCause != input.FailureCause || (this.FailureCause != null && !this.FailureCause.Equals(input.FailureCause))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.TestCaseUri != input.TestCaseUri || (this.TestCaseUri != null && !this.TestCaseUri.Equals(input.TestCaseUri))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.ResultName != input.ResultName || (this.ResultName != null && !this.ResultName.Equals(input.ResultName))) return false;
            if (this.TestResultAe != input.TestResultAe || (this.TestResultAe != null && !this.TestResultAe.Equals(input.TestResultAe))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.ExecuteId != input.ExecuteId || (this.ExecuteId != null && !this.ExecuteId.Equals(input.ExecuteId))) return false;
            if (this.TimeCost != input.TimeCost || (this.TimeCost != null && !this.TimeCost.Equals(input.TimeCost))) return false;
            if (this.StepTxt != input.StepTxt || (this.StepTxt != null && !this.StepTxt.Equals(input.StepTxt))) return false;
            if (this.StepExpect != input.StepExpect || (this.StepExpect != null && !this.StepExpect.Equals(input.StepExpect))) return false;
            if (this.StepActual != input.StepActual || (this.StepActual != null && !this.StepActual.Equals(input.StepActual))) return false;
            if (this.StepResult != input.StepResult || (this.StepResult != null && !this.StepResult.Equals(input.StepResult))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.CreationVersionUri != input.CreationVersionUri || (this.CreationVersionUri != null && !this.CreationVersionUri.Equals(input.CreationVersionUri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ReportUrl != input.ReportUrl || (this.ReportUrl != null && !this.ReportUrl.Equals(input.ReportUrl))) return false;
            if (this.TestCaseNumber != input.TestCaseNumber || (this.TestCaseNumber != null && !this.TestCaseNumber.Equals(input.TestCaseNumber))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Round != null) hashCode = hashCode * 59 + this.Round.GetHashCode();
                if (this.Preparation != null) hashCode = hashCode * 59 + this.Preparation.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.BeginTimeTimestamp != null) hashCode = hashCode * 59 + this.BeginTimeTimestamp.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.EndTimeTimestamp != null) hashCode = hashCode * 59 + this.EndTimeTimestamp.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreationDateTimestamp != null) hashCode = hashCode * 59 + this.CreationDateTimestamp.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedTimestamp != null) hashCode = hashCode * 59 + this.LastModifiedTimestamp.GetHashCode();
                if (this.LastChangeTime != null) hashCode = hashCode * 59 + this.LastChangeTime.GetHashCode();
                if (this.LastChangeTimeTimestamp != null) hashCode = hashCode * 59 + this.LastChangeTimeTimestamp.GetHashCode();
                if (this.DfxTestResult != null) hashCode = hashCode * 59 + this.DfxTestResult.GetHashCode();
                if (this.FailureCause != null) hashCode = hashCode * 59 + this.FailureCause.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.TestCaseUri != null) hashCode = hashCode * 59 + this.TestCaseUri.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.ResultName != null) hashCode = hashCode * 59 + this.ResultName.GetHashCode();
                if (this.TestResultAe != null) hashCode = hashCode * 59 + this.TestResultAe.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ExecuteId != null) hashCode = hashCode * 59 + this.ExecuteId.GetHashCode();
                if (this.TimeCost != null) hashCode = hashCode * 59 + this.TimeCost.GetHashCode();
                if (this.StepTxt != null) hashCode = hashCode * 59 + this.StepTxt.GetHashCode();
                if (this.StepExpect != null) hashCode = hashCode * 59 + this.StepExpect.GetHashCode();
                if (this.StepActual != null) hashCode = hashCode * 59 + this.StepActual.GetHashCode();
                if (this.StepResult != null) hashCode = hashCode * 59 + this.StepResult.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.CreationVersionUri != null) hashCode = hashCode * 59 + this.CreationVersionUri.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ReportUrl != null) hashCode = hashCode * 59 + this.ReportUrl.GetHashCode();
                if (this.TestCaseNumber != null) hashCode = hashCode * 59 + this.TestCaseNumber.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
