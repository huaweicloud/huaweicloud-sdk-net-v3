using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 标签结构体。
    /// </summary>
    public class TagV5DTO 
    {

        /// <summary>
        /// **参数说明**：标签键，在同一资源下标签键唯一。绑定资源时，如果设置的键已存在，则将覆盖之前的标签值。如果设置的键值不存在，则新增标签。 **取值范围**：长度不超过64，只允许中文、字母、数字、以及_.-等字符的组合。
        /// </summary>
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }

        /// <summary>
        /// **参数说明**：标签值。 **取值范围**：长度不超过128，只允许中文、字母、数字、以及_.-等字符的组合。
        /// </summary>
        [JsonProperty("tag_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TagValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagV5DTO {\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("  tagValue: ").Append(TagValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagV5DTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagV5DTO input)
        {
            if (input == null) return false;
            if (this.TagKey != input.TagKey || (this.TagKey != null && !this.TagKey.Equals(input.TagKey))) return false;
            if (this.TagValue != input.TagValue || (this.TagValue != null && !this.TagValue.Equals(input.TagValue))) return false;

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
                if (this.TagKey != null) hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                if (this.TagValue != null) hashCode = hashCode * 59 + this.TagValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
