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
    /// 用例其他扩展信息
    /// </summary>
    public class ExtendInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendAuthorInfo Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendAuthorInfo Updator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public AssignedUserInfo Domain { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 前置条件
        /// </summary>
        [JsonProperty("preparation", NullValueHandling = NullValueHandling.Ignore)]
        public string Preparation { get; set; }

        /// <summary>
        /// 测试步骤，数组长度小于10
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalServiceCaseStep> Steps { get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("label_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssignedUserInfo> LabelList { get; set; }

        /// <summary>
        /// 缺陷信息
        /// </summary>
        [JsonProperty("defect_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssignedUserInfo> DefectList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public AssignedUserInfo Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public AssignedUserInfo Issue { get; set; }

        /// <summary>
        /// 测试版本号
        /// </summary>
        [JsonProperty("test_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fixed_version", NullValueHandling = NullValueHandling.Ignore)]
        public AssignedUserInfo FixedVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendInfo {\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  preparation: ").Append(Preparation).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  labelList: ").Append(LabelList).Append("\n");
            sb.Append("  defectList: ").Append(DefectList).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  issue: ").Append(Issue).Append("\n");
            sb.Append("  testVersionId: ").Append(TestVersionId).Append("\n");
            sb.Append("  fixedVersion: ").Append(FixedVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendInfo input)
        {
            if (input == null) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Preparation != input.Preparation || (this.Preparation != null && !this.Preparation.Equals(input.Preparation))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.LabelList != input.LabelList || (this.LabelList != null && input.LabelList != null && !this.LabelList.SequenceEqual(input.LabelList))) return false;
            if (this.DefectList != input.DefectList || (this.DefectList != null && input.DefectList != null && !this.DefectList.SequenceEqual(input.DefectList))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Issue != input.Issue || (this.Issue != null && !this.Issue.Equals(input.Issue))) return false;
            if (this.TestVersionId != input.TestVersionId || (this.TestVersionId != null && !this.TestVersionId.Equals(input.TestVersionId))) return false;
            if (this.FixedVersion != input.FixedVersion || (this.FixedVersion != null && !this.FixedVersion.Equals(input.FixedVersion))) return false;

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
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Preparation != null) hashCode = hashCode * 59 + this.Preparation.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.LabelList != null) hashCode = hashCode * 59 + this.LabelList.GetHashCode();
                if (this.DefectList != null) hashCode = hashCode * 59 + this.DefectList.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Issue != null) hashCode = hashCode * 59 + this.Issue.GetHashCode();
                if (this.TestVersionId != null) hashCode = hashCode * 59 + this.TestVersionId.GetHashCode();
                if (this.FixedVersion != null) hashCode = hashCode * 59 + this.FixedVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
