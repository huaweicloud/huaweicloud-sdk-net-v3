using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GitRepositoryRef 
    {

        /// <summary>
        /// 用于指定要检出的Git分支。如果未定义其他字段，则默认检出&#39;master&#39;分支。
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitRepositoryRef {\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GitRepositoryRef);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GitRepositoryRef input)
        {
            if (input == null) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;

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
                return hashCode;
            }
        }
    }
}
