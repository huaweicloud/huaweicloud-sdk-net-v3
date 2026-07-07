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
    /// ALT开关对象。
    /// </summary>
    public class SwitchGaussMySqlProxyAltRequestBody 
    {

        /// <summary>
        /// **参数解释**：  ALT开关。  **约束限制**：  不涉及。  **取值范围**：  - on：开启。  - off：关闭。  **默认取值**：  不涉及。 
        /// </summary>
        [JsonProperty("alt_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string AltEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  只读ALT开关。  **约束限制**：  不涉及。  **取值范围**：  - on：开启。  - off：关闭。  **默认取值**：  off。
        /// </summary>
        [JsonProperty("alt_for_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public string AltForReadonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchGaussMySqlProxyAltRequestBody {\n");
            sb.Append("  altEnabled: ").Append(AltEnabled).Append("\n");
            sb.Append("  altForReadonly: ").Append(AltForReadonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchGaussMySqlProxyAltRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchGaussMySqlProxyAltRequestBody input)
        {
            if (input == null) return false;
            if (this.AltEnabled != input.AltEnabled || (this.AltEnabled != null && !this.AltEnabled.Equals(input.AltEnabled))) return false;
            if (this.AltForReadonly != input.AltForReadonly || (this.AltForReadonly != null && !this.AltForReadonly.Equals(input.AltForReadonly))) return false;

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
                if (this.AltEnabled != null) hashCode = hashCode * 59 + this.AltEnabled.GetHashCode();
                if (this.AltForReadonly != null) hashCode = hashCode * 59 + this.AltForReadonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
