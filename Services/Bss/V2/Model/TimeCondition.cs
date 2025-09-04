using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeCondition 
    {

        /// <summary>
        /// 时间单位。1：天2：月
        /// </summary>
        [JsonProperty("time_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeMeasureId { get; set; }

        /// <summary>
        /// 查询开始时间，必须是日期格式。当time_measure_id值为1或为空时，格式为YYYY-MM-DD当time_measure_id值为2时，格式为YYYY-MM
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间：必须是日期格式。当time_measure_id值为1或为空时，格式为YYYY-MM-DD当time_measure_id值为2时，格式为YYYY-MM
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeCondition {\n");
            sb.Append("  timeMeasureId: ").Append(TimeMeasureId).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimeCondition input)
        {
            if (input == null) return false;
            if (this.TimeMeasureId != input.TimeMeasureId || (this.TimeMeasureId != null && !this.TimeMeasureId.Equals(input.TimeMeasureId))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.TimeMeasureId != null) hashCode = hashCode * 59 + this.TimeMeasureId.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
