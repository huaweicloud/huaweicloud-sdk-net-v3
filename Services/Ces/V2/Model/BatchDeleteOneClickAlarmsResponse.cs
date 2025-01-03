using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteOneClickAlarmsResponse : SdkResponse
    {

        /// <summary>
        /// 成功删除的一键告警ID列表
        /// </summary>
        [JsonProperty("one_click_alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OneClickAlarmIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteOneClickAlarmsResponse {\n");
            sb.Append("  oneClickAlarmIds: ").Append(OneClickAlarmIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteOneClickAlarmsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteOneClickAlarmsResponse input)
        {
            if (input == null) return false;
            if (this.OneClickAlarmIds != input.OneClickAlarmIds || (this.OneClickAlarmIds != null && input.OneClickAlarmIds != null && !this.OneClickAlarmIds.SequenceEqual(input.OneClickAlarmIds))) return false;

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
                if (this.OneClickAlarmIds != null) hashCode = hashCode * 59 + this.OneClickAlarmIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
