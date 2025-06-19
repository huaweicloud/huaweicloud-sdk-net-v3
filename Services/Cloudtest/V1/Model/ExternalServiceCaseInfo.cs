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
    /// 测试用例其他扩展信息
    /// </summary>
    public class ExternalServiceCaseInfo 
    {

        /// <summary>
        /// 测试用例描述信息，长度为[0-500]位字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 执行该测试用例时需要满足的前置条件，长度为[0-500]位字符
        /// </summary>
        [JsonProperty("preparation", NullValueHandling = NullValueHandling.Ignore)]
        public string Preparation { get; set; }

        /// <summary>
        /// 测试步骤，数组长度小于10
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalServiceCaseStep> Steps { get; set; }

        /// <summary>
        /// 标签名称列表，数组长度小于25
        /// </summary>
        [JsonProperty("label_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelList { get; set; }

        /// <summary>
        /// 模块号，长度为[0-32]位字符
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 测试版本号，长度为[0-10]位字符
        /// </summary>
        [JsonProperty("test_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestVersionId { get; set; }

        /// <summary>
        /// 迭代号，长度为[0-32]位字符
        /// </summary>
        [JsonProperty("fix_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FixVersionId { get; set; }

        /// <summary>
        /// 处理者id信息，固定长度32位字符
        /// </summary>
        [JsonProperty("assigned_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedId { get; set; }

        /// <summary>
        /// 用例关联的需求id信息，长度为[0-32]位字符
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalServiceCaseInfo {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  preparation: ").Append(Preparation).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  labelList: ").Append(LabelList).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  testVersionId: ").Append(TestVersionId).Append("\n");
            sb.Append("  fixVersionId: ").Append(FixVersionId).Append("\n");
            sb.Append("  assignedId: ").Append(AssignedId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalServiceCaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalServiceCaseInfo input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Preparation != input.Preparation || (this.Preparation != null && !this.Preparation.Equals(input.Preparation))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.LabelList != input.LabelList || (this.LabelList != null && input.LabelList != null && !this.LabelList.SequenceEqual(input.LabelList))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.TestVersionId != input.TestVersionId || (this.TestVersionId != null && !this.TestVersionId.Equals(input.TestVersionId))) return false;
            if (this.FixVersionId != input.FixVersionId || (this.FixVersionId != null && !this.FixVersionId.Equals(input.FixVersionId))) return false;
            if (this.AssignedId != input.AssignedId || (this.AssignedId != null && !this.AssignedId.Equals(input.AssignedId))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Preparation != null) hashCode = hashCode * 59 + this.Preparation.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.LabelList != null) hashCode = hashCode * 59 + this.LabelList.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.TestVersionId != null) hashCode = hashCode * 59 + this.TestVersionId.GetHashCode();
                if (this.FixVersionId != null) hashCode = hashCode * 59 + this.FixVersionId.GetHashCode();
                if (this.AssignedId != null) hashCode = hashCode * 59 + this.AssignedId.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                return hashCode;
            }
        }
    }
}
