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
    /// 更新镜像标签请求体，包含两个字段read_me和tags，其中read_me为镜像说明信息，支持30k长度以内字符串；tags为标签列表，标签为键值对
    /// </summary>
    public class UpdateImageGroupRequestBody 
    {

        /// <summary>
        /// **参数解释**：镜像组更新的概览信息。 **约束限制**：不涉及。 **取值范围**：长度限制30000个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("read_me", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadMe { get; set; }

        /// <summary>
        /// **参数解释**：镜像组更新的标签。 **约束限制**：最大支持20个标签。 **取值范围**：key值最大支持长度128，value值最大支持255。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateImageGroupRequestBodyTags> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateImageGroupRequestBody {\n");
            sb.Append("  readMe: ").Append(ReadMe).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateImageGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateImageGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.ReadMe != input.ReadMe || (this.ReadMe != null && !this.ReadMe.Equals(input.ReadMe))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.ReadMe != null) hashCode = hashCode * 59 + this.ReadMe.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
