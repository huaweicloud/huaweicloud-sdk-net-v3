using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CommitRevetOrCherryPickDto 
    {

        /// <summary>
        /// revert目标分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 是否使用创建MR的形式Revert
        /// </summary>
        [JsonProperty("with_new_merge_request", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithNewMergeRequest { get; set; }

        /// <summary>
        /// 提交信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitRevetOrCherryPickDto {\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  withNewMergeRequest: ").Append(WithNewMergeRequest).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitRevetOrCherryPickDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitRevetOrCherryPickDto input)
        {
            if (input == null) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.WithNewMergeRequest != input.WithNewMergeRequest || (this.WithNewMergeRequest != null && !this.WithNewMergeRequest.Equals(input.WithNewMergeRequest))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.WithNewMergeRequest != null) hashCode = hashCode * 59 + this.WithNewMergeRequest.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
