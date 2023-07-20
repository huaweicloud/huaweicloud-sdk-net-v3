using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHealthCompareJobListResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 健康对比任务列表。
        /// </summary>
        [JsonProperty("compare_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<HealthCompareJob> CompareJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHealthCompareJobListResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  compareJobs: ").Append(CompareJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHealthCompareJobListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHealthCompareJobListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.CompareJobs == input.CompareJobs ||
                    this.CompareJobs != null &&
                    input.CompareJobs != null &&
                    this.CompareJobs.SequenceEqual(input.CompareJobs)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CompareJobs != null)
                    hashCode = hashCode * 59 + this.CompareJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
