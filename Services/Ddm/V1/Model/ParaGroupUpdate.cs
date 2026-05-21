using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ParaGroupUpdate 
    {

        /// <summary>
        /// **参数解释**：  参数组名称。  **约束限制**：  不涉及。  **取值范围**：  在1到64个字符之间，区分大小写，可包含字母、数字、中划线、下划线或句点，不能包含其他特殊字符。。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  参数组描述。  **约束限制**：  不涉及。  **取值范围**：  不能超过256位，且不能包含回车和特殊字符 ! &lt; \&quot; &#x3D; &#39; &gt; &amp;。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：  修改的值。  **约束限制**：  不涉及  **取值范围**：  长度为1-64的a-z、A-Z、0-9、.、_ 和 -的字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParaGroupUpdate {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParaGroupUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParaGroupUpdate input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
