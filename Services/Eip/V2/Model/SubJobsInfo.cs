using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubJobsInfo 
    {

        /// <summary>
        /// 子job信息，类型与主job一致
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> SubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubJobsInfo {\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubJobsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubJobsInfo input)
        {
            if (input == null) return false;
            if (this.SubJobs != input.SubJobs || (this.SubJobs != null && input.SubJobs != null && !this.SubJobs.SequenceEqual(input.SubJobs))) return false;

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
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
