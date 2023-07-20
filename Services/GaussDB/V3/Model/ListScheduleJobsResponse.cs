using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScheduleJobsResponse : SdkResponse
    {

        /// <summary>
        /// 任务详情
        /// </summary>
        [JsonProperty("schedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleTask> Schedules { get; set; }

        /// <summary>
        /// 记录总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScheduleJobsResponse {\n");
            sb.Append("  schedules: ").Append(Schedules).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduleJobsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduleJobsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    input.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.Schedules != null)
                    hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
