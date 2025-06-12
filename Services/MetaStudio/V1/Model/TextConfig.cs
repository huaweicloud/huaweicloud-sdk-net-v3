using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 台词脚本。 &gt; 最长10000个字符，不含SSML标签字符数。
    /// </summary>
    public class TextConfig 
    {

        /// <summary>
        /// **参数解释**： 台词脚本。支持两种模式，纯文本模式和标签模式。 - 纯文本模式：使用方法，如“大家好，我是人工智大家，是个虚拟主播”。 - 标签模式：SSML标签的详细定义请参考[文本驱动SSML定义](metastudio_02_0038.xml)。  **约束限制**： 不含SSML标签字符数最长10000个字符。 **取值范围**： 字符长度0-131072位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextConfig {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextConfig input)
        {
            if (input == null) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;

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
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }
}
