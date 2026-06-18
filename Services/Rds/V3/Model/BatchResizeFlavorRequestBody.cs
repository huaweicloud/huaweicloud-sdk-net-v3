using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 批量规格变更请求体请求体
    /// </summary>
    public class BatchResizeFlavorRequestBody 
    {

        /// <summary>
        /// **参数解释**：   实例ID列表。   **约束限制**：  一次最多下发10个实例。   **取值范围**：  不涉及。  **默认取值**：   不涉及。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**：  资源规格编码。  **约束限制**：   不涉及。   **取值范围**：  不涉及。   **默认取值**：   不涉及。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// **参数解释**：  是否进行定时规格变更。  **约束限制**：   不涉及。   **取值范围**：  不涉及。   **默认取值**：   false
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delay { get; set; }

        /// <summary>
        /// **参数解释**：  变更包周期实例的规格时可指定，表示是否自动从客户的账户中支付。  **约束限制**：   不涉及。   **取值范围**：  不涉及。   **默认取值**：   false
        /// </summary>
        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// **参数解释**：  表示是否占用ip进行规格变更。  **约束限制**：   不涉及。   **取值范围**：  不涉及。   **默认取值**：   true
        /// </summary>
        [JsonProperty("occupy_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OccupyIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResizeFlavorRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  autoPay: ").Append(AutoPay).Append("\n");
            sb.Append("  occupyIp: ").Append(OccupyIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResizeFlavorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResizeFlavorRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.AutoPay != input.AutoPay || (this.AutoPay != null && !this.AutoPay.Equals(input.AutoPay))) return false;
            if (this.OccupyIp != input.OccupyIp || (this.OccupyIp != null && !this.OccupyIp.Equals(input.OccupyIp))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.AutoPay != null) hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                if (this.OccupyIp != null) hashCode = hashCode * 59 + this.OccupyIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
