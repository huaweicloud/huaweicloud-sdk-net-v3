using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReportHistoryVO 
    {

        /// <summary>
        /// **参数解释**： 报告ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        /// <summary>
        /// **参数解释**： 发送时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("send_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? SendTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistic_period", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticPeriod StatisticPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportHistoryVO {\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("  sendTime: ").Append(SendTime).Append("\n");
            sb.Append("  statisticPeriod: ").Append(StatisticPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportHistoryVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportHistoryVO input)
        {
            if (input == null) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;
            if (this.SendTime != input.SendTime || (this.SendTime != null && !this.SendTime.Equals(input.SendTime))) return false;
            if (this.StatisticPeriod != input.StatisticPeriod || (this.StatisticPeriod != null && !this.StatisticPeriod.Equals(input.StatisticPeriod))) return false;

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
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.SendTime != null) hashCode = hashCode * 59 + this.SendTime.GetHashCode();
                if (this.StatisticPeriod != null) hashCode = hashCode * 59 + this.StatisticPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
