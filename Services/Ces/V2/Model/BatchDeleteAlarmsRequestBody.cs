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
    public class BatchDeleteAlarmsRequestBody 
    {

        /// <summary>
        /// 需要批量删除的告警规则的ID列表
        /// </summary>
        [JsonProperty("alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAlarmsRequestBody {\n");
            sb.Append("  alarmIds: ").Append(AlarmIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAlarmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAlarmsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmIds == input.AlarmIds ||
                    this.AlarmIds != null &&
                    input.AlarmIds != null &&
                    this.AlarmIds.SequenceEqual(input.AlarmIds)
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
                if (this.AlarmIds != null)
                    hashCode = hashCode * 59 + this.AlarmIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
