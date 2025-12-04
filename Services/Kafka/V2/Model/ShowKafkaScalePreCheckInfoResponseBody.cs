using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowKafkaScalePreCheckInfoResponseBody 
    {

        /// <summary>
        /// **参数解释**： 检查项名称。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 检查项状态。 **取值范围**： - true：正常。 - false：异常。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// **参数解释**： 失败原因。    **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释**： 风险等级。   **取值范围**： - low：低风险。 - medium：中风险。 - high：高风险。
        /// </summary>
        [JsonProperty("risk", NullValueHandling = NullValueHandling.Ignore)]
        public string Risk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaScalePreCheckInfoResponseBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  risk: ").Append(Risk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaScalePreCheckInfoResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaScalePreCheckInfoResponseBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Risk != input.Risk || (this.Risk != null && !this.Risk.Equals(input.Risk))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Risk != null) hashCode = hashCode * 59 + this.Risk.GetHashCode();
                return hashCode;
            }
        }
    }
}
