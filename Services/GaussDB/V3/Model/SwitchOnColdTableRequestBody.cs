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
    public class SwitchOnColdTableRequestBody 
    {

        /// <summary>
        /// **参数解释**：  冷热分离开关状态。  **约束限制**：  开启冷热数据分离功能后，暂不支持关闭。  **取值范围**：  true：开启。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("switch_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchOnColdTableRequestBody {\n");
            sb.Append("  switchOn: ").Append(SwitchOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchOnColdTableRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchOnColdTableRequestBody input)
        {
            if (input == null) return false;
            if (this.SwitchOn != input.SwitchOn || (this.SwitchOn != null && !this.SwitchOn.Equals(input.SwitchOn))) return false;

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
                if (this.SwitchOn != null) hashCode = hashCode * 59 + this.SwitchOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
