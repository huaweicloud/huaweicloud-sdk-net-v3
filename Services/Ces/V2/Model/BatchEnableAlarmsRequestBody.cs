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
    /// 
    /// </summary>
    public class BatchEnableAlarmsRequestBody 
    {

        /// <summary>
        /// 需要批量启停的告警规则的ID列表
        /// </summary>
        [JsonProperty("alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmIds { get; set; }

        /// <summary>
        /// 是否开启告警规则。true:开启，false:关闭。
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchEnableAlarmsRequestBody {\n");
            sb.Append("  alarmIds: ").Append(AlarmIds).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchEnableAlarmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchEnableAlarmsRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmIds != input.AlarmIds || (this.AlarmIds != null && input.AlarmIds != null && !this.AlarmIds.SequenceEqual(input.AlarmIds))) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;

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
                if (this.AlarmIds != null) hashCode = hashCode * 59 + this.AlarmIds.GetHashCode();
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
