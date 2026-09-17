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
    /// **参数解释：** 返回信息。
    /// </summary>
    public class IssueInfoResponseResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2 Issue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueInfoResponseResult {\n");
            sb.Append("  issue: ").Append(Issue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueInfoResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueInfoResponseResult input)
        {
            if (input == null) return false;
            if (this.Issue != input.Issue || (this.Issue != null && !this.Issue.Equals(input.Issue))) return false;

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
                if (this.Issue != null) hashCode = hashCode * 59 + this.Issue.GetHashCode();
                return hashCode;
            }
        }
    }
}
