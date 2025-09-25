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
    public class MergeMergeRequestBodyDto 
    {

        /// <summary>
        /// 压缩合并信息
        /// </summary>
        [JsonProperty("squash_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string SquashCommitMessage { get; set; }

        /// <summary>
        /// 压缩合并
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// 强制合并
        /// </summary>
        [JsonProperty("force_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceMerge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeMergeRequestBodyDto {\n");
            sb.Append("  squashCommitMessage: ").Append(SquashCommitMessage).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  forceMerge: ").Append(ForceMerge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeMergeRequestBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeMergeRequestBodyDto input)
        {
            if (input == null) return false;
            if (this.SquashCommitMessage != input.SquashCommitMessage || (this.SquashCommitMessage != null && !this.SquashCommitMessage.Equals(input.SquashCommitMessage))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.ForceMerge != input.ForceMerge || (this.ForceMerge != null && !this.ForceMerge.Equals(input.ForceMerge))) return false;

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
                if (this.SquashCommitMessage != null) hashCode = hashCode * 59 + this.SquashCommitMessage.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.ForceMerge != null) hashCode = hashCode * 59 + this.ForceMerge.GetHashCode();
                return hashCode;
            }
        }
    }
}
