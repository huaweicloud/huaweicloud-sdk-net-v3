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
    /// 策略有效期。
    /// </summary>
    public class JobScheduleDurationInfo 
    {

        /// <summary>
        /// 第一次执行日期 yyyy-MM-dd。取值范围1990-01-01至2099-12-31
        /// </summary>
        [JsonProperty("active_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveStartDate { get; set; }

        /// <summary>
        /// 最后一次执行日期。默认不会结束 yyyy-MM-dd
        /// </summary>
        [JsonProperty("active_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveEndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobScheduleDurationInfo {\n");
            sb.Append("  activeStartDate: ").Append(ActiveStartDate).Append("\n");
            sb.Append("  activeEndDate: ").Append(ActiveEndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobScheduleDurationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobScheduleDurationInfo input)
        {
            if (input == null) return false;
            if (this.ActiveStartDate != input.ActiveStartDate || (this.ActiveStartDate != null && !this.ActiveStartDate.Equals(input.ActiveStartDate))) return false;
            if (this.ActiveEndDate != input.ActiveEndDate || (this.ActiveEndDate != null && !this.ActiveEndDate.Equals(input.ActiveEndDate))) return false;

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
                if (this.ActiveEndDate != null) hashCode = hashCode * 59 + this.ActiveEndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
