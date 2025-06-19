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
    public class TestCaseListVo 
    {

        /// <summary>
        /// 用例URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Iteration { get; set; }

        /// <summary>
        /// 执行平台，如：apittest,其他三方执行平台
        /// </summary>
        [JsonProperty("exeplatform", NullValueHandling = NullValueHandling.Ignore)]
        public string Exeplatform { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 用例描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 用例等级
        /// </summary>
        [JsonProperty("rank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RankId { get; set; }

        /// <summary>
        /// 目录URI
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 是否组合关键字
        /// </summary>
        [JsonProperty("is_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKeyword { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("script_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptUrl { get; set; }

        /// <summary>
        /// 实时报告地址
        /// </summary>
        [JsonProperty("report_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo ServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public IntegerIdAndNameVo TestType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInfoVo CreateInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execute_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExecuteInfoVo ExecuteInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("associate_issue_info", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateIssueInfoVo AssociateIssueInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("associate_defect_info", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateDefectInfoVo AssociateDefectInfo { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [JsonProperty("case_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 用例标签名称列表
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelVo> Labels { get; set; }

        /// <summary>
        /// 自定义字段信息
        /// </summary>
        [JsonProperty("custom_field_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomFieldVo> CustomFieldInfo { get; set; }

        /// <summary>
        /// 是否来自测试设计（null：不限，false：否来自测试设计，true：来自测试设计）
        /// </summary>
        [JsonProperty("is_test_design", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTestDesign { get; set; }

        /// <summary>
        /// 最后修改时间（null：不限）
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModified { get; set; }

        /// <summary>
        /// 用例评审状态（null：0至127）
        /// </summary>
        [JsonProperty("review_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseListVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  exeplatform: ").Append(Exeplatform).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  rankId: ").Append(RankId).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  isKeyword: ").Append(IsKeyword).Append("\n");
            sb.Append("  scriptUrl: ").Append(ScriptUrl).Append("\n");
            sb.Append("  reportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  testType: ").Append(TestType).Append("\n");
            sb.Append("  createInfo: ").Append(CreateInfo).Append("\n");
            sb.Append("  executeInfo: ").Append(ExecuteInfo).Append("\n");
            sb.Append("  associateIssueInfo: ").Append(AssociateIssueInfo).Append("\n");
            sb.Append("  associateDefectInfo: ").Append(AssociateDefectInfo).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  customFieldInfo: ").Append(CustomFieldInfo).Append("\n");
            sb.Append("  isTestDesign: ").Append(IsTestDesign).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  reviewStatus: ").Append(ReviewStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseListVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseListVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Iteration != input.Iteration || (this.Iteration != null && !this.Iteration.Equals(input.Iteration))) return false;
            if (this.Exeplatform != input.Exeplatform || (this.Exeplatform != null && !this.Exeplatform.Equals(input.Exeplatform))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RankId != input.RankId || (this.RankId != null && !this.RankId.Equals(input.RankId))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.IsKeyword != input.IsKeyword || (this.IsKeyword != null && !this.IsKeyword.Equals(input.IsKeyword))) return false;
            if (this.ScriptUrl != input.ScriptUrl || (this.ScriptUrl != null && !this.ScriptUrl.Equals(input.ScriptUrl))) return false;
            if (this.ReportUrl != input.ReportUrl || (this.ReportUrl != null && !this.ReportUrl.Equals(input.ReportUrl))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.TestType != input.TestType || (this.TestType != null && !this.TestType.Equals(input.TestType))) return false;
            if (this.CreateInfo != input.CreateInfo || (this.CreateInfo != null && !this.CreateInfo.Equals(input.CreateInfo))) return false;
            if (this.ExecuteInfo != input.ExecuteInfo || (this.ExecuteInfo != null && !this.ExecuteInfo.Equals(input.ExecuteInfo))) return false;
            if (this.AssociateIssueInfo != input.AssociateIssueInfo || (this.AssociateIssueInfo != null && !this.AssociateIssueInfo.Equals(input.AssociateIssueInfo))) return false;
            if (this.AssociateDefectInfo != input.AssociateDefectInfo || (this.AssociateDefectInfo != null && !this.AssociateDefectInfo.Equals(input.AssociateDefectInfo))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.CustomFieldInfo != input.CustomFieldInfo || (this.CustomFieldInfo != null && input.CustomFieldInfo != null && !this.CustomFieldInfo.SequenceEqual(input.CustomFieldInfo))) return false;
            if (this.IsTestDesign != input.IsTestDesign || (this.IsTestDesign != null && !this.IsTestDesign.Equals(input.IsTestDesign))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.ReviewStatus != input.ReviewStatus || (this.ReviewStatus != null && !this.ReviewStatus.Equals(input.ReviewStatus))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Iteration != null) hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                if (this.Exeplatform != null) hashCode = hashCode * 59 + this.Exeplatform.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RankId != null) hashCode = hashCode * 59 + this.RankId.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.IsKeyword != null) hashCode = hashCode * 59 + this.IsKeyword.GetHashCode();
                if (this.ScriptUrl != null) hashCode = hashCode * 59 + this.ScriptUrl.GetHashCode();
                if (this.ReportUrl != null) hashCode = hashCode * 59 + this.ReportUrl.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.TestType != null) hashCode = hashCode * 59 + this.TestType.GetHashCode();
                if (this.CreateInfo != null) hashCode = hashCode * 59 + this.CreateInfo.GetHashCode();
                if (this.ExecuteInfo != null) hashCode = hashCode * 59 + this.ExecuteInfo.GetHashCode();
                if (this.AssociateIssueInfo != null) hashCode = hashCode * 59 + this.AssociateIssueInfo.GetHashCode();
                if (this.AssociateDefectInfo != null) hashCode = hashCode * 59 + this.AssociateDefectInfo.GetHashCode();
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CustomFieldInfo != null) hashCode = hashCode * 59 + this.CustomFieldInfo.GetHashCode();
                if (this.IsTestDesign != null) hashCode = hashCode * 59 + this.IsTestDesign.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.ReviewStatus != null) hashCode = hashCode * 59 + this.ReviewStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
