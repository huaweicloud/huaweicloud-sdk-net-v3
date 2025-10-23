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
    /// 差异提交数量
    /// </summary>
    public class DivergingCommitCounts 
    {

        /// <summary>
        /// 落后默认分支提交数量
        /// </summary>
        [JsonProperty("behind", NullValueHandling = NullValueHandling.Ignore)]
        public int? Behind { get; set; }

        /// <summary>
        /// 领先默认分支提交数量
        /// </summary>
        [JsonProperty("ahead", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ahead { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DivergingCommitCounts {\n");
            sb.Append("  behind: ").Append(Behind).Append("\n");
            sb.Append("  ahead: ").Append(Ahead).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DivergingCommitCounts);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DivergingCommitCounts input)
        {
            if (input == null) return false;
            if (this.Behind != input.Behind || (this.Behind != null && !this.Behind.Equals(input.Behind))) return false;
            if (this.Ahead != input.Ahead || (this.Ahead != null && !this.Ahead.Equals(input.Ahead))) return false;

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
                if (this.Behind != null) hashCode = hashCode * 59 + this.Behind.GetHashCode();
                if (this.Ahead != null) hashCode = hashCode * 59 + this.Ahead.GetHashCode();
                return hashCode;
            }
        }
    }
}
