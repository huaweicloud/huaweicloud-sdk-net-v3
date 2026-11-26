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
    /// **参数解释**：资产可执行操作详情配置。 **约束限制**：不涉及。
    /// </summary>
    public class AssetActionReq 
    {

        /// <summary>
        /// **参数解释**：资产action类型。 **约束限制**：0-32位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }

        /// <summary>
        /// **参数解释**：资产action配置文件地址。 **约束限制**：0-32位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("action_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetActionReq {\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  actionDir: ").Append(ActionDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetActionReq input)
        {
            if (input == null) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;
            if (this.ActionDir != input.ActionDir || (this.ActionDir != null && !this.ActionDir.Equals(input.ActionDir))) return false;

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
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.ActionDir != null) hashCode = hashCode * 59 + this.ActionDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
