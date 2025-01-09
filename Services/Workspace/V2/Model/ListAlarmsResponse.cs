using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmsResponse : SdkResponse
    {

        /// <summary>
        /// alarmHistories列表
        /// </summary>
        [JsonProperty("alarm_histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmHistoryItem> AlarmHistories { get; set; }

        /// <summary>
        /// 告警记录列表总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmsResponse {\n");
            sb.Append("  alarmHistories: ").Append(AlarmHistories).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmsResponse input)
        {
            if (input == null) return false;
            if (this.AlarmHistories != input.AlarmHistories || (this.AlarmHistories != null && input.AlarmHistories != null && !this.AlarmHistories.SequenceEqual(input.AlarmHistories))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.AlarmHistories != null) hashCode = hashCode * 59 + this.AlarmHistories.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
