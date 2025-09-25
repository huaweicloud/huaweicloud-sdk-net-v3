using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// GaussDB实例版本升级接口传参参数。
    /// </summary>
    public class UpgradeRequestBody 
    {

        /// <summary>
        /// **参数解释**: 实例升级类型，区分大小写。包括就地升级，灰度升级，热补丁升级三种，三种升级方式的异同，详见接口描述。 **约束限制**: 不涉及。 **取值范围**: - inplace：就地升级。 - grey：灰度升级。 - hotfix：热补丁升级。  **默认取值**:   不涉及。
        /// </summary>
        [JsonProperty("upgrade_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// **参数解释**: 实例升级操作，区分大小写。 实例升级类型是就地升级时非必选。 灰度升级包括升级自动提交、升级待观察、提交升级和升级回退四种。 热补丁升级包括升级自动提交，升级回退两种。 **约束限制**: 不涉及。 **取值范围**: - upgradeAutoCommit：升级自动提交。 - upgrade：升级待观察。 - commit：提交升级。 - rollback：升级回退。  **默认取值**:   不涉及。
        /// </summary>
        [JsonProperty("upgrade_action", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeAction { get; set; }

        /// <summary>
        /// **参数解释**: 实例升级目标版本。 **约束限制**: - 热补丁升级场景下支持传入多个热补丁版本。  **取值范围**:   不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// **参数解释**: 分布式实例灰度升级，滚动升级分片数。分布式实例灰度升级，升级待观察必填。该值不能大于实例未升级分片总数。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("upgrade_shard_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpgradeShardNum { get; set; }

        /// <summary>
        /// **参数解释**: 灰度升级，升级待观察AZ值，升级待观察时必填。可以支持多AZ一起升级，AZ之间以英文逗号分隔。不能填入不属于该实例的AZ值。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("upgrade_az", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeRequestBody {\n");
            sb.Append("  upgradeType: ").Append(UpgradeType).Append("\n");
            sb.Append("  upgradeAction: ").Append(UpgradeAction).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  upgradeShardNum: ").Append(UpgradeShardNum).Append("\n");
            sb.Append("  upgradeAz: ").Append(UpgradeAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeRequestBody input)
        {
            if (input == null) return false;
            if (this.UpgradeType != input.UpgradeType || (this.UpgradeType != null && !this.UpgradeType.Equals(input.UpgradeType))) return false;
            if (this.UpgradeAction != input.UpgradeAction || (this.UpgradeAction != null && !this.UpgradeAction.Equals(input.UpgradeAction))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.UpgradeShardNum != input.UpgradeShardNum || (this.UpgradeShardNum != null && !this.UpgradeShardNum.Equals(input.UpgradeShardNum))) return false;
            if (this.UpgradeAz != input.UpgradeAz || (this.UpgradeAz != null && !this.UpgradeAz.Equals(input.UpgradeAz))) return false;

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
                if (this.UpgradeType != null) hashCode = hashCode * 59 + this.UpgradeType.GetHashCode();
                if (this.UpgradeAction != null) hashCode = hashCode * 59 + this.UpgradeAction.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.UpgradeShardNum != null) hashCode = hashCode * 59 + this.UpgradeShardNum.GetHashCode();
                if (this.UpgradeAz != null) hashCode = hashCode * 59 + this.UpgradeAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
