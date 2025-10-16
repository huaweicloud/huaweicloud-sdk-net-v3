using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 执行一次执行时间。
    /// </summary>
    public class JobScheduleOneTimeOccurrenceInfo 
    {

        /// <summary>
        /// 执行日期 yyyy-MM-dd。取值范围1990-01-01至2099-12-31
        /// </summary>
        [JsonProperty("active_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveStartDate { get; set; }

        /// <summary>
        /// 执行时间。HH:mm:ss
        /// </summary>
        [JsonProperty("active_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveStartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobScheduleOneTimeOccurrenceInfo {\n");
            sb.Append("  activeStartDate: ").Append(ActiveStartDate).Append("\n");
            sb.Append("  activeStartTime: ").Append(ActiveStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobScheduleOneTimeOccurrenceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobScheduleOneTimeOccurrenceInfo input)
        {
            if (input == null) return false;
            if (this.ActiveStartDate != input.ActiveStartDate || (this.ActiveStartDate != null && !this.ActiveStartDate.Equals(input.ActiveStartDate))) return false;
            if (this.ActiveStartTime != input.ActiveStartTime || (this.ActiveStartTime != null && !this.ActiveStartTime.Equals(input.ActiveStartTime))) return false;

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
                if (this.ActiveStartDate != null) hashCode = hashCode * 59 + this.ActiveStartDate.GetHashCode();
                if (this.ActiveStartTime != null) hashCode = hashCode * 59 + this.ActiveStartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
