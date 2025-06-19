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
    /// 
    /// </summary>
    public class TestReportVo 
    {

        /// <summary>
        /// 测试报告Uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 测试报告名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public string Updator { get; set; }

        /// <summary>
        /// 测试计划Uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 分支Uri
        /// </summary>
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 测试计划名称
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// 测试结论
        /// </summary>
        [JsonProperty("test_conclusion", NullValueHandling = NullValueHandling.Ignore)]
        public string TestConclusion { get; set; }

        /// <summary>
        /// 测试结论描述
        /// </summary>
        [JsonProperty("test_conclusion_details", NullValueHandling = NullValueHandling.Ignore)]
        public string TestConclusionDetails { get; set; }

        /// <summary>
        /// 缺陷解决率
        /// </summary>
        [JsonProperty("defect_resolution_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectResolutionRate { get; set; }

        /// <summary>
        /// 缺陷解决分数
        /// </summary>
        [JsonProperty("defect_resolution_score", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectResolutionScore { get; set; }

        /// <summary>
        /// 用例执行率
        /// </summary>
        [JsonProperty("case_execution_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseExecutionRate { get; set; }

        /// <summary>
        /// 用例执行分数
        /// </summary>
        [JsonProperty("case_execution_score", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseExecutionScore { get; set; }

        /// <summary>
        /// 用例通过率
        /// </summary>
        [JsonProperty("case_pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePassRate { get; set; }

        /// <summary>
        /// 用例通过分数
        /// </summary>
        [JsonProperty("case_pass_score", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePassScore { get; set; }

        /// <summary>
        /// 需求通过率
        /// </summary>
        [JsonProperty("issue_pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuePassRate { get; set; }

        /// <summary>
        /// 需求通过分数
        /// </summary>
        [JsonProperty("issue_pass_score", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuePassScore { get; set; }

        /// <summary>
        /// 需求覆盖率
        /// </summary>
        [JsonProperty("issue_coverage_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCoverageRate { get; set; }

        /// <summary>
        /// 需求覆盖分数
        /// </summary>
        [JsonProperty("issue_coverage_score", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCoverageScore { get; set; }

        /// <summary>
        /// 项目总遗留DI
        /// </summary>
        [JsonProperty("project_residual_defect_index", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectResidualDefectIndex { get; set; }

        /// <summary>
        /// 计划新增DI
        /// </summary>
        [JsonProperty("iterator_residual_defect_index", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorResidualDefectIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_automation_details", NullValueHandling = NullValueHandling.Ignore)]
        public CaseAutomationDetailsVo CaseAutomationDetails { get; set; }

        /// <summary>
        /// 用例有效性比例
        /// </summary>
        [JsonProperty("case_validity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseValidityRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_details", NullValueHandling = NullValueHandling.Ignore)]
        public IssuePassDetailsVo IssueDetails { get; set; }

        /// <summary>
        /// 用例通过情况
        /// </summary>
        [JsonProperty("case_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueVo> CaseDetails { get; set; }

        /// <summary>
        /// 缺陷严重程度
        /// </summary>
        [JsonProperty("defect_details_by_severity", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdAndNameAndValueVo> DefectDetailsBySeverity { get; set; }

        /// <summary>
        /// 缺陷按照模块分布情况
        /// </summary>
        [JsonProperty("defect_details_by_module", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdAndNameAndValueVo> DefectDetailsByModule { get; set; }

        /// <summary>
        /// 每个测试类型的用例通过率
        /// </summary>
        [JsonProperty("case_pass_rate_by_test_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetailTestTypeCasePassRateVo> CasePassRateByTestType { get; set; }

        /// <summary>
        /// 测试报告自定义报告详情
        /// </summary>
        [JsonProperty("test_report_custom_report_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomReportListVo> TestReportCustomReportDetail { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 创建人名
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [JsonProperty("update_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// 修改人名
        /// </summary>
        [JsonProperty("updator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 风险分析
        /// </summary>
        [JsonProperty("risk_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskAnalysis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestReportVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  testConclusion: ").Append(TestConclusion).Append("\n");
            sb.Append("  testConclusionDetails: ").Append(TestConclusionDetails).Append("\n");
            sb.Append("  defectResolutionRate: ").Append(DefectResolutionRate).Append("\n");
            sb.Append("  defectResolutionScore: ").Append(DefectResolutionScore).Append("\n");
            sb.Append("  caseExecutionRate: ").Append(CaseExecutionRate).Append("\n");
            sb.Append("  caseExecutionScore: ").Append(CaseExecutionScore).Append("\n");
            sb.Append("  casePassRate: ").Append(CasePassRate).Append("\n");
            sb.Append("  casePassScore: ").Append(CasePassScore).Append("\n");
            sb.Append("  issuePassRate: ").Append(IssuePassRate).Append("\n");
            sb.Append("  issuePassScore: ").Append(IssuePassScore).Append("\n");
            sb.Append("  issueCoverageRate: ").Append(IssueCoverageRate).Append("\n");
            sb.Append("  issueCoverageScore: ").Append(IssueCoverageScore).Append("\n");
            sb.Append("  projectResidualDefectIndex: ").Append(ProjectResidualDefectIndex).Append("\n");
            sb.Append("  iteratorResidualDefectIndex: ").Append(IteratorResidualDefectIndex).Append("\n");
            sb.Append("  caseAutomationDetails: ").Append(CaseAutomationDetails).Append("\n");
            sb.Append("  caseValidityRatio: ").Append(CaseValidityRatio).Append("\n");
            sb.Append("  issueDetails: ").Append(IssueDetails).Append("\n");
            sb.Append("  caseDetails: ").Append(CaseDetails).Append("\n");
            sb.Append("  defectDetailsBySeverity: ").Append(DefectDetailsBySeverity).Append("\n");
            sb.Append("  defectDetailsByModule: ").Append(DefectDetailsByModule).Append("\n");
            sb.Append("  casePassRateByTestType: ").Append(CasePassRateByTestType).Append("\n");
            sb.Append("  testReportCustomReportDetail: ").Append(TestReportCustomReportDetail).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimestamp: ").Append(CreateTimestamp).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  updatorName: ").Append(UpdatorName).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  riskAnalysis: ").Append(RiskAnalysis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestReportVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestReportVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.TestConclusion != input.TestConclusion || (this.TestConclusion != null && !this.TestConclusion.Equals(input.TestConclusion))) return false;
            if (this.TestConclusionDetails != input.TestConclusionDetails || (this.TestConclusionDetails != null && !this.TestConclusionDetails.Equals(input.TestConclusionDetails))) return false;
            if (this.DefectResolutionRate != input.DefectResolutionRate || (this.DefectResolutionRate != null && !this.DefectResolutionRate.Equals(input.DefectResolutionRate))) return false;
            if (this.DefectResolutionScore != input.DefectResolutionScore || (this.DefectResolutionScore != null && !this.DefectResolutionScore.Equals(input.DefectResolutionScore))) return false;
            if (this.CaseExecutionRate != input.CaseExecutionRate || (this.CaseExecutionRate != null && !this.CaseExecutionRate.Equals(input.CaseExecutionRate))) return false;
            if (this.CaseExecutionScore != input.CaseExecutionScore || (this.CaseExecutionScore != null && !this.CaseExecutionScore.Equals(input.CaseExecutionScore))) return false;
            if (this.CasePassRate != input.CasePassRate || (this.CasePassRate != null && !this.CasePassRate.Equals(input.CasePassRate))) return false;
            if (this.CasePassScore != input.CasePassScore || (this.CasePassScore != null && !this.CasePassScore.Equals(input.CasePassScore))) return false;
            if (this.IssuePassRate != input.IssuePassRate || (this.IssuePassRate != null && !this.IssuePassRate.Equals(input.IssuePassRate))) return false;
            if (this.IssuePassScore != input.IssuePassScore || (this.IssuePassScore != null && !this.IssuePassScore.Equals(input.IssuePassScore))) return false;
            if (this.IssueCoverageRate != input.IssueCoverageRate || (this.IssueCoverageRate != null && !this.IssueCoverageRate.Equals(input.IssueCoverageRate))) return false;
            if (this.IssueCoverageScore != input.IssueCoverageScore || (this.IssueCoverageScore != null && !this.IssueCoverageScore.Equals(input.IssueCoverageScore))) return false;
            if (this.ProjectResidualDefectIndex != input.ProjectResidualDefectIndex || (this.ProjectResidualDefectIndex != null && !this.ProjectResidualDefectIndex.Equals(input.ProjectResidualDefectIndex))) return false;
            if (this.IteratorResidualDefectIndex != input.IteratorResidualDefectIndex || (this.IteratorResidualDefectIndex != null && !this.IteratorResidualDefectIndex.Equals(input.IteratorResidualDefectIndex))) return false;
            if (this.CaseAutomationDetails != input.CaseAutomationDetails || (this.CaseAutomationDetails != null && !this.CaseAutomationDetails.Equals(input.CaseAutomationDetails))) return false;
            if (this.CaseValidityRatio != input.CaseValidityRatio || (this.CaseValidityRatio != null && !this.CaseValidityRatio.Equals(input.CaseValidityRatio))) return false;
            if (this.IssueDetails != input.IssueDetails || (this.IssueDetails != null && !this.IssueDetails.Equals(input.IssueDetails))) return false;
            if (this.CaseDetails != input.CaseDetails || (this.CaseDetails != null && input.CaseDetails != null && !this.CaseDetails.SequenceEqual(input.CaseDetails))) return false;
            if (this.DefectDetailsBySeverity != input.DefectDetailsBySeverity || (this.DefectDetailsBySeverity != null && input.DefectDetailsBySeverity != null && !this.DefectDetailsBySeverity.SequenceEqual(input.DefectDetailsBySeverity))) return false;
            if (this.DefectDetailsByModule != input.DefectDetailsByModule || (this.DefectDetailsByModule != null && input.DefectDetailsByModule != null && !this.DefectDetailsByModule.SequenceEqual(input.DefectDetailsByModule))) return false;
            if (this.CasePassRateByTestType != input.CasePassRateByTestType || (this.CasePassRateByTestType != null && input.CasePassRateByTestType != null && !this.CasePassRateByTestType.SequenceEqual(input.CasePassRateByTestType))) return false;
            if (this.TestReportCustomReportDetail != input.TestReportCustomReportDetail || (this.TestReportCustomReportDetail != null && input.TestReportCustomReportDetail != null && !this.TestReportCustomReportDetail.SequenceEqual(input.TestReportCustomReportDetail))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimestamp != input.CreateTimestamp || (this.CreateTimestamp != null && !this.CreateTimestamp.Equals(input.CreateTimestamp))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;
            if (this.UpdatorName != input.UpdatorName || (this.UpdatorName != null && !this.UpdatorName.Equals(input.UpdatorName))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.RiskAnalysis != input.RiskAnalysis || (this.RiskAnalysis != null && !this.RiskAnalysis.Equals(input.RiskAnalysis))) return false;

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
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.TestConclusion != null) hashCode = hashCode * 59 + this.TestConclusion.GetHashCode();
                if (this.TestConclusionDetails != null) hashCode = hashCode * 59 + this.TestConclusionDetails.GetHashCode();
                if (this.DefectResolutionRate != null) hashCode = hashCode * 59 + this.DefectResolutionRate.GetHashCode();
                if (this.DefectResolutionScore != null) hashCode = hashCode * 59 + this.DefectResolutionScore.GetHashCode();
                if (this.CaseExecutionRate != null) hashCode = hashCode * 59 + this.CaseExecutionRate.GetHashCode();
                if (this.CaseExecutionScore != null) hashCode = hashCode * 59 + this.CaseExecutionScore.GetHashCode();
                if (this.CasePassRate != null) hashCode = hashCode * 59 + this.CasePassRate.GetHashCode();
                if (this.CasePassScore != null) hashCode = hashCode * 59 + this.CasePassScore.GetHashCode();
                if (this.IssuePassRate != null) hashCode = hashCode * 59 + this.IssuePassRate.GetHashCode();
                if (this.IssuePassScore != null) hashCode = hashCode * 59 + this.IssuePassScore.GetHashCode();
                if (this.IssueCoverageRate != null) hashCode = hashCode * 59 + this.IssueCoverageRate.GetHashCode();
                if (this.IssueCoverageScore != null) hashCode = hashCode * 59 + this.IssueCoverageScore.GetHashCode();
                if (this.ProjectResidualDefectIndex != null) hashCode = hashCode * 59 + this.ProjectResidualDefectIndex.GetHashCode();
                if (this.IteratorResidualDefectIndex != null) hashCode = hashCode * 59 + this.IteratorResidualDefectIndex.GetHashCode();
                if (this.CaseAutomationDetails != null) hashCode = hashCode * 59 + this.CaseAutomationDetails.GetHashCode();
                if (this.CaseValidityRatio != null) hashCode = hashCode * 59 + this.CaseValidityRatio.GetHashCode();
                if (this.IssueDetails != null) hashCode = hashCode * 59 + this.IssueDetails.GetHashCode();
                if (this.CaseDetails != null) hashCode = hashCode * 59 + this.CaseDetails.GetHashCode();
                if (this.DefectDetailsBySeverity != null) hashCode = hashCode * 59 + this.DefectDetailsBySeverity.GetHashCode();
                if (this.DefectDetailsByModule != null) hashCode = hashCode * 59 + this.DefectDetailsByModule.GetHashCode();
                if (this.CasePassRateByTestType != null) hashCode = hashCode * 59 + this.CasePassRateByTestType.GetHashCode();
                if (this.TestReportCustomReportDetail != null) hashCode = hashCode * 59 + this.TestReportCustomReportDetail.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimestamp != null) hashCode = hashCode * 59 + this.CreateTimestamp.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.UpdatorName != null) hashCode = hashCode * 59 + this.UpdatorName.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.RiskAnalysis != null) hashCode = hashCode * 59 + this.RiskAnalysis.GetHashCode();
                return hashCode;
            }
        }
    }
}
