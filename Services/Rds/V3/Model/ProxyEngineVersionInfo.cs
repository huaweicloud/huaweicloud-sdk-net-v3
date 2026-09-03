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
    /// 数据库代理节点引擎版本信息
    /// </summary>
    public class ProxyEngineVersionInfo 
    {

        /// <summary>
        /// **参数解释**：  当前引擎版本。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("current_engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentEngineVersion { get; set; }

        /// <summary>
        /// **参数解释**：  目标引擎版本。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("target_engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetEngineVersion { get; set; }

        /// <summary>
        /// **参数解释**：  是否可升级标志。true表示可以升级，false表示不可升级。  **约束限制**：  不涉及。  **取值范围**：  - true - false  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("upgrade_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpgradeFlag { get; set; }

        /// <summary>
        /// **参数解释**：  代理节点ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }

        /// <summary>
        /// **参数解释**：  升级风险列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<EngineRiskDesc> Risks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyEngineVersionInfo {\n");
            sb.Append("  currentEngineVersion: ").Append(CurrentEngineVersion).Append("\n");
            sb.Append("  targetEngineVersion: ").Append(TargetEngineVersion).Append("\n");
            sb.Append("  upgradeFlag: ").Append(UpgradeFlag).Append("\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("  risks: ").Append(Risks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyEngineVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyEngineVersionInfo input)
        {
            if (input == null) return false;
            if (this.CurrentEngineVersion != input.CurrentEngineVersion || (this.CurrentEngineVersion != null && !this.CurrentEngineVersion.Equals(input.CurrentEngineVersion))) return false;
            if (this.TargetEngineVersion != input.TargetEngineVersion || (this.TargetEngineVersion != null && !this.TargetEngineVersion.Equals(input.TargetEngineVersion))) return false;
            if (this.UpgradeFlag != input.UpgradeFlag || (this.UpgradeFlag != null && !this.UpgradeFlag.Equals(input.UpgradeFlag))) return false;
            if (this.ProxyId != input.ProxyId || (this.ProxyId != null && !this.ProxyId.Equals(input.ProxyId))) return false;
            if (this.Risks != input.Risks || (this.Risks != null && input.Risks != null && !this.Risks.SequenceEqual(input.Risks))) return false;

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
                if (this.CurrentEngineVersion != null) hashCode = hashCode * 59 + this.CurrentEngineVersion.GetHashCode();
                if (this.TargetEngineVersion != null) hashCode = hashCode * 59 + this.TargetEngineVersion.GetHashCode();
                if (this.UpgradeFlag != null) hashCode = hashCode * 59 + this.UpgradeFlag.GetHashCode();
                if (this.ProxyId != null) hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                if (this.Risks != null) hashCode = hashCode * 59 + this.Risks.GetHashCode();
                return hashCode;
            }
        }
    }
}
