using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRestoreTimeResponse : SdkResponse
    {

        /// <summary>
        /// 实例可恢复时间段总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 实例可恢复的时间段
        /// </summary>
        [JsonProperty("restorable_time_periods", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestorableTime> RestorableTimePeriods { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRestoreTimeResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  restorableTimePeriods: ").Append(RestorableTimePeriods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRestoreTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRestoreTimeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.RestorableTimePeriods == input.RestorableTimePeriods ||
                    this.RestorableTimePeriods != null &&
                    input.RestorableTimePeriods != null &&
                    this.RestorableTimePeriods.SequenceEqual(input.RestorableTimePeriods)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.RestorableTimePeriods != null)
                    hashCode = hashCode * 59 + this.RestorableTimePeriods.GetHashCode();
                return hashCode;
            }
        }
    }
}
