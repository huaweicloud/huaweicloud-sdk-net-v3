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
    public class BatchDeleteAlarmRulesResponse : SdkResponse
    {

        /// <summary>
        /// 成功删除的告警规则ID列表
        /// </summary>
        [JsonProperty("alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAlarmRulesResponse {\n");
            sb.Append("  alarmIds: ").Append(AlarmIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAlarmRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAlarmRulesResponse input)
        {
            if (input == null) return false;
            if (this.AlarmIds != input.AlarmIds || (this.AlarmIds != null && input.AlarmIds != null && !this.AlarmIds.SequenceEqual(input.AlarmIds))) return false;

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
                return hashCode;
            }
        }
    }
}
