using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：要添加或删除的资源标签。  **约束限制**：不涉及
    /// </summary>
    public class ChangeResourceTagOption 
    {

        /// <summary>
        /// **参数解释**：标签的键。  **约束限制**：不能传入空值。  **取值范围**：最大长度36个unicode字符。 不能包含非打印字符\&quot;&#x3D;\&quot;，“*”，“&lt;”，“&gt;”，“\\”，“,”，\&quot;|\&quot;，“/”。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：标签的值，可以传入空字符串，表示任何值。  **约束限制**：注意删除标签也需要同时传入标签键值。  **取值范围**：最大长度255个unicode字符。 不能包含非打印字符\&quot;&#x3D;\&quot;，“*”，“&lt;”，“&gt;”，“\\”，“,”，\&quot;|\&quot;，“/”。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeResourceTagOption {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeResourceTagOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeResourceTagOption input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
