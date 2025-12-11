using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProxyEngineRisk 
    {

        /// <summary>
        /// **参数解释**：  风险级别。  **取值范围**： 1：一级风险。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// **参数解释**：  建议升级原因。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("suggest", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggest { get; set; }

        /// <summary>
        /// **参数解释**：  升级影响。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("influence", NullValueHandling = NullValueHandling.Ignore)]
        public string Influence { get; set; }

        /// <summary>
        /// **参数解释**：  升级指导。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("guidance", NullValueHandling = NullValueHandling.Ignore)]
        public string Guidance { get; set; }

        /// <summary>
        /// **参数解释**：  预估业务影响时长。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("service_impact_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceImpactDuration { get; set; }

        /// <summary>
        /// **参数解释**：  预估升级时长。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("upgrade_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyEngineRisk {\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  suggest: ").Append(Suggest).Append("\n");
            sb.Append("  influence: ").Append(Influence).Append("\n");
            sb.Append("  guidance: ").Append(Guidance).Append("\n");
            sb.Append("  serviceImpactDuration: ").Append(ServiceImpactDuration).Append("\n");
            sb.Append("  upgradeDuration: ").Append(UpgradeDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyEngineRisk);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyEngineRisk input)
        {
            if (input == null) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Suggest != input.Suggest || (this.Suggest != null && !this.Suggest.Equals(input.Suggest))) return false;
            if (this.Influence != input.Influence || (this.Influence != null && !this.Influence.Equals(input.Influence))) return false;
            if (this.Guidance != input.Guidance || (this.Guidance != null && !this.Guidance.Equals(input.Guidance))) return false;
            if (this.ServiceImpactDuration != input.ServiceImpactDuration || (this.ServiceImpactDuration != null && !this.ServiceImpactDuration.Equals(input.ServiceImpactDuration))) return false;
            if (this.UpgradeDuration != input.UpgradeDuration || (this.UpgradeDuration != null && !this.UpgradeDuration.Equals(input.UpgradeDuration))) return false;

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
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Suggest != null) hashCode = hashCode * 59 + this.Suggest.GetHashCode();
                if (this.Influence != null) hashCode = hashCode * 59 + this.Influence.GetHashCode();
                if (this.Guidance != null) hashCode = hashCode * 59 + this.Guidance.GetHashCode();
                if (this.ServiceImpactDuration != null) hashCode = hashCode * 59 + this.ServiceImpactDuration.GetHashCode();
                if (this.UpgradeDuration != null) hashCode = hashCode * 59 + this.UpgradeDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
