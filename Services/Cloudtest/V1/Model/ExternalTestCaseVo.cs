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
    public class ExternalTestCaseVo 
    {

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
        /// 用例ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execution_type", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo ExecutionType { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalTestCaseVo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  rankId: ").Append(RankId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  executionType: ").Append(ExecutionType).Append("\n");
            sb.Append("  testType: ").Append(TestType).Append("\n");
            sb.Append("  createInfo: ").Append(CreateInfo).Append("\n");
            sb.Append("  executeInfo: ").Append(ExecuteInfo).Append("\n");
            sb.Append("  associateIssueInfo: ").Append(AssociateIssueInfo).Append("\n");
            sb.Append("  associateDefectInfo: ").Append(AssociateDefectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalTestCaseVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalTestCaseVo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Iteration != input.Iteration || (this.Iteration != null && !this.Iteration.Equals(input.Iteration))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RankId != input.RankId || (this.RankId != null && !this.RankId.Equals(input.RankId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ExecutionType != input.ExecutionType || (this.ExecutionType != null && !this.ExecutionType.Equals(input.ExecutionType))) return false;
            if (this.TestType != input.TestType || (this.TestType != null && !this.TestType.Equals(input.TestType))) return false;
            if (this.CreateInfo != input.CreateInfo || (this.CreateInfo != null && !this.CreateInfo.Equals(input.CreateInfo))) return false;
            if (this.ExecuteInfo != input.ExecuteInfo || (this.ExecuteInfo != null && !this.ExecuteInfo.Equals(input.ExecuteInfo))) return false;
            if (this.AssociateIssueInfo != input.AssociateIssueInfo || (this.AssociateIssueInfo != null && !this.AssociateIssueInfo.Equals(input.AssociateIssueInfo))) return false;
            if (this.AssociateDefectInfo != input.AssociateDefectInfo || (this.AssociateDefectInfo != null && !this.AssociateDefectInfo.Equals(input.AssociateDefectInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Iteration != null) hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RankId != null) hashCode = hashCode * 59 + this.RankId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ExecutionType != null) hashCode = hashCode * 59 + this.ExecutionType.GetHashCode();
                if (this.TestType != null) hashCode = hashCode * 59 + this.TestType.GetHashCode();
                if (this.CreateInfo != null) hashCode = hashCode * 59 + this.CreateInfo.GetHashCode();
                if (this.ExecuteInfo != null) hashCode = hashCode * 59 + this.ExecuteInfo.GetHashCode();
                if (this.AssociateIssueInfo != null) hashCode = hashCode * 59 + this.AssociateIssueInfo.GetHashCode();
                if (this.AssociateDefectInfo != null) hashCode = hashCode * 59 + this.AssociateDefectInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
