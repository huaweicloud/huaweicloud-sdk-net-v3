using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class JobSummaryBodyResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public JobSummary Summary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSummaryBodyResult {\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobSummaryBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobSummaryBodyResult input)
        {
            if (input == null) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;

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
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
