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
    /// 单个标签筛选条件。
    /// </summary>
    public class ListTagFilter 
    {

        /// <summary>
        /// **参数解释**：标签键。 **约束限制**：   - 必填；   - 长度 1~128；   - 首尾不可为空格；   - 仅支持字母、数字、空格及 &#x60;_ . : &#x3D; + - @&#x60;。 **取值范围**：符合标签键命名规范的字符串。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：标签值列表，与 &#x60;key&#x60; 组合用于筛选作业。 **约束限制**：   - 非必填；   - 最多 10 个值；   - 单个值长度 0~255；   - 仅支持字母、数字、空格及 &#x60;_ . : / &#x3D; + - @&#x60;。 **取值范围**：   - 传具体值：匹配 &#x60;key&#x3D;value&#x60; 的作业；   - 不传、传空数组或空字符串：匹配带有该 &#x60;key&#x60; 的作业（不限 value）。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTagFilter {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTagFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTagFilter input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
