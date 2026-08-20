using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateProcessInstanceReqCos 
    {

        /// <summary>
        /// 工作项编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 工作项ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeType { get; set; }

        /// <summary>
        /// 变更前
        /// </summary>
        [JsonProperty("before_change", NullValueHandling = NullValueHandling.Ignore)]
        public string BeforeChange { get; set; }

        /// <summary>
        /// 变更后
        /// </summary>
        [JsonProperty("after_change", NullValueHandling = NullValueHandling.Ignore)]
        public string AfterChange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProcessInstanceReqCos {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  beforeChange: ").Append(BeforeChange).Append("\n");
            sb.Append("  afterChange: ").Append(AfterChange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProcessInstanceReqCos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProcessInstanceReqCos input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.ChangeType != input.ChangeType || (this.ChangeType != null && !this.ChangeType.Equals(input.ChangeType))) return false;
            if (this.BeforeChange != input.BeforeChange || (this.BeforeChange != null && !this.BeforeChange.Equals(input.BeforeChange))) return false;
            if (this.AfterChange != input.AfterChange || (this.AfterChange != null && !this.AfterChange.Equals(input.AfterChange))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.ChangeType != null) hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.BeforeChange != null) hashCode = hashCode * 59 + this.BeforeChange.GetHashCode();
                if (this.AfterChange != null) hashCode = hashCode * 59 + this.AfterChange.GetHashCode();
                return hashCode;
            }
        }
    }
}
