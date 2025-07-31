using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 攻击统计信息 **取值范围**： 不涉及
    /// </summary>
    public class ShowAttackTotalRespData 
    {

        /// <summary>
        /// **参数解释**： 攻击次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackCount { get; set; }

        /// <summary>
        /// **参数解释**： 阻断次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DenyCount { get; set; }

        /// <summary>
        /// **参数解释**： 放行次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermitCount { get; set; }

        /// <summary>
        /// **参数解释**： 风险端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("risk_ports", NullValueHandling = NullValueHandling.Ignore)]
        public long? RiskPorts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAttackTotalRespData {\n");
            sb.Append("  attackCount: ").Append(AttackCount).Append("\n");
            sb.Append("  denyCount: ").Append(DenyCount).Append("\n");
            sb.Append("  permitCount: ").Append(PermitCount).Append("\n");
            sb.Append("  riskPorts: ").Append(RiskPorts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAttackTotalRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAttackTotalRespData input)
        {
            if (input == null) return false;
            if (this.AttackCount != input.AttackCount || (this.AttackCount != null && !this.AttackCount.Equals(input.AttackCount))) return false;
            if (this.DenyCount != input.DenyCount || (this.DenyCount != null && !this.DenyCount.Equals(input.DenyCount))) return false;
            if (this.PermitCount != input.PermitCount || (this.PermitCount != null && !this.PermitCount.Equals(input.PermitCount))) return false;
            if (this.RiskPorts != input.RiskPorts || (this.RiskPorts != null && !this.RiskPorts.Equals(input.RiskPorts))) return false;

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
                if (this.AttackCount != null) hashCode = hashCode * 59 + this.AttackCount.GetHashCode();
                if (this.DenyCount != null) hashCode = hashCode * 59 + this.DenyCount.GetHashCode();
                if (this.PermitCount != null) hashCode = hashCode * 59 + this.PermitCount.GetHashCode();
                if (this.RiskPorts != null) hashCode = hashCode * 59 + this.RiskPorts.GetHashCode();
                return hashCode;
            }
        }
    }
}
