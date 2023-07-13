using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 配置条件处理策略，用于确定规则是否判断上次数据是否满足条件。当rule_type类型为 “DEVICE_LINKAGE”时，为必选参数。默认为pulse触发类型，事件有效性为永久有效
    /// </summary>
    public class Strategy 
    {

        /// <summary>
        /// **参数说明**：规则条件触发的判断策略，默认为pulse。 **取值范围**： - pulse：设备上报的数据满足条件则触发，不判断上一次上报的数据。 - reverse：设备上一次上报的数据不满足条件，本次上报的数据满足条件则触发。
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public string Trigger { get; set; }

        /// <summary>
        /// **参数说明**：设备数据的有效时间，单位为秒，设备数据的产生时间以上报数据中的eventTime为基准。
        /// </summary>
        [JsonProperty("event_valid_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventValidTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Strategy {\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  eventValidTime: ").Append(EventValidTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Strategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Strategy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.EventValidTime == input.EventValidTime ||
                    (this.EventValidTime != null &&
                    this.EventValidTime.Equals(input.EventValidTime))
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
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.EventValidTime != null)
                    hashCode = hashCode * 59 + this.EventValidTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
