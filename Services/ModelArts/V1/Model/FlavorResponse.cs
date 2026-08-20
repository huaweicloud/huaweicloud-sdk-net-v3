using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业、算法的规格信息。
    /// </summary>
    public class FlavorResponse 
    {

        /// <summary>
        /// **参数解释**：训练作业选择的资源池ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 资源规格的ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 资源规格的名称。
        /// </summary>
        [JsonProperty("flavor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorName { get; set; }

        /// <summary>
        /// **参数解释**：该规格支持的训练引擎列表（JSON 数组字符串格式）。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("support_engines", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportEngines { get; set; }

        /// <summary>
        /// **参数解释**：该规格支持的用户组列表。若为空则默认为 &#x60;public&#x60;。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：&#x60;public&#x60;
        /// </summary>
        [JsonProperty("support_groups", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportGroups { get; set; }

        /// <summary>
        /// 资源规格的最大节点数。
        /// </summary>
        [JsonProperty("max_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNum { get; set; }

        /// <summary>
        /// 资源规格的类型。可选值如下： - CPU - GPU - [Ascend](tag:hc,hk,fcs_super)
        /// </summary>
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingInfo Billing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor_info", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfoResponse FlavorInfo { get; set; }

        /// <summary>
        /// 其他规格属性。
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Attributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorResponse {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  flavorName: ").Append(FlavorName).Append("\n");
            sb.Append("  supportEngines: ").Append(SupportEngines).Append("\n");
            sb.Append("  supportGroups: ").Append(SupportGroups).Append("\n");
            sb.Append("  maxNum: ").Append(MaxNum).Append("\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  flavorInfo: ").Append(FlavorInfo).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorResponse input)
        {
            if (input == null) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.FlavorName != input.FlavorName || (this.FlavorName != null && !this.FlavorName.Equals(input.FlavorName))) return false;
            if (this.SupportEngines != input.SupportEngines || (this.SupportEngines != null && !this.SupportEngines.Equals(input.SupportEngines))) return false;
            if (this.SupportGroups != input.SupportGroups || (this.SupportGroups != null && !this.SupportGroups.Equals(input.SupportGroups))) return false;
            if (this.MaxNum != input.MaxNum || (this.MaxNum != null && !this.MaxNum.Equals(input.MaxNum))) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.FlavorInfo != input.FlavorInfo || (this.FlavorInfo != null && !this.FlavorInfo.Equals(input.FlavorInfo))) return false;
            if (this.Attributes != input.Attributes || (this.Attributes != null && input.Attributes != null && !this.Attributes.SequenceEqual(input.Attributes))) return false;

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
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.FlavorName != null) hashCode = hashCode * 59 + this.FlavorName.GetHashCode();
                if (this.SupportEngines != null) hashCode = hashCode * 59 + this.SupportEngines.GetHashCode();
                if (this.SupportGroups != null) hashCode = hashCode * 59 + this.SupportGroups.GetHashCode();
                if (this.MaxNum != null) hashCode = hashCode * 59 + this.MaxNum.GetHashCode();
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.FlavorInfo != null) hashCode = hashCode * 59 + this.FlavorInfo.GetHashCode();
                if (this.Attributes != null) hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
