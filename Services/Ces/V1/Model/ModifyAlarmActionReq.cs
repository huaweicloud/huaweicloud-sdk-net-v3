using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyAlarmActionReq 
    {

        /// <summary>
        /// 告警是否启用。true：启动。false：停止
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyAlarmActionReq {\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyAlarmActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyAlarmActionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmEnabled == input.AlarmEnabled ||
                    (this.AlarmEnabled != null &&
                    this.AlarmEnabled.Equals(input.AlarmEnabled))
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
                if (this.AlarmEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
