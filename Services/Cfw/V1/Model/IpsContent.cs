using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 自定义IPS规则内容 **约束限制**：     不涉及 **取值范围**： 不涉及 **默认取值**：   不涉及
    /// </summary>
    public class IpsContent 
    {

        /// <summary>
        /// **参数解释**： 内容 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释**： 匹配特征时，截止匹配的位置 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// **参数解释**： 报文内容是否为十六进制 **约束限制**： 不涉及 **取值范围**： true： 是十六进制 false： 不是十六进制 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("is_hex", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHex { get; set; }

        /// <summary>
        /// **参数解释**： 是否忽略大小写 **约束限制**： 不涉及 **取值范围**： true： 忽略 false： 不忽略 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("is_ignore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIgnore { get; set; }

        /// <summary>
        /// **参数解释**： 是否匹配URL中跟“内容”一致的字段 **约束限制**： 不涉及 **取值范围**： true： 匹配 false： 不匹配 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("is_uri", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUri { get; set; }

        /// <summary>
        /// **参数解释**： 匹配特征时开始的位置 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 匹配特征时，指定开始的位置 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("relative_position", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelativePosition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsContent {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  depth: ").Append(Depth).Append("\n");
            sb.Append("  isHex: ").Append(IsHex).Append("\n");
            sb.Append("  isIgnore: ").Append(IsIgnore).Append("\n");
            sb.Append("  isUri: ").Append(IsUri).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  relativePosition: ").Append(RelativePosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsContent input)
        {
            if (input == null) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Depth != input.Depth || (this.Depth != null && !this.Depth.Equals(input.Depth))) return false;
            if (this.IsHex != input.IsHex || (this.IsHex != null && !this.IsHex.Equals(input.IsHex))) return false;
            if (this.IsIgnore != input.IsIgnore || (this.IsIgnore != null && !this.IsIgnore.Equals(input.IsIgnore))) return false;
            if (this.IsUri != input.IsUri || (this.IsUri != null && !this.IsUri.Equals(input.IsUri))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.RelativePosition != input.RelativePosition || (this.RelativePosition != null && !this.RelativePosition.Equals(input.RelativePosition))) return false;

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
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Depth != null) hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.IsHex != null) hashCode = hashCode * 59 + this.IsHex.GetHashCode();
                if (this.IsIgnore != null) hashCode = hashCode * 59 + this.IsIgnore.GetHashCode();
                if (this.IsUri != null) hashCode = hashCode * 59 + this.IsUri.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.RelativePosition != null) hashCode = hashCode * 59 + this.RelativePosition.GetHashCode();
                return hashCode;
            }
        }
    }
}
