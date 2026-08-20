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
    /// 批量基线工作项的结果项
    /// </summary>
    public class BatchBaselineIssueResponseResult 
    {

        /// <summary>
        /// 基线成功的工作项列表。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueBaselineResult> Success { get; set; }

        /// <summary>
        /// 基线失败的工作项列表。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueBaselineResult> Failed { get; set; }

        /// <summary>
        /// 成功数量。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("fail_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchBaselineIssueResponseResult {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failNum: ").Append(FailNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchBaselineIssueResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchBaselineIssueResponseResult input)
        {
            if (input == null) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && input.Failed != null && !this.Failed.SequenceEqual(input.Failed))) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailNum != input.FailNum || (this.FailNum != null && !this.FailNum.Equals(input.FailNum))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailNum != null) hashCode = hashCode * 59 + this.FailNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
