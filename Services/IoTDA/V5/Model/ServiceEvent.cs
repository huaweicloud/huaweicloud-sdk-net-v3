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
    /// 事件服务对象。
    /// </summary>
    public class ServiceEvent 
    {

        /// <summary>
        /// **参数说明**：设备事件类型。注：设备服务内不允许重复。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// **参数说明**：设备事件的参数列表。
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCommandPara> Paras { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceEvent {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Paras == input.Paras ||
                    this.Paras != null &&
                    input.Paras != null &&
                    this.Paras.SequenceEqual(input.Paras)
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Paras != null)
                    hashCode = hashCode * 59 + this.Paras.GetHashCode();
                return hashCode;
            }
        }
    }
}
