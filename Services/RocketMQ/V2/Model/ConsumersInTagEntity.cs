using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsumersInTagEntity 
    {

        /// <summary>
        /// **参数解释**： 消费者列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("consumers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Consumers { get; set; }

        /// <summary>
        /// **参数解释**： 标签名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TagName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumersInTagEntity {\n");
            sb.Append("  consumers: ").Append(Consumers).Append("\n");
            sb.Append("  tagName: ").Append(TagName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumersInTagEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumersInTagEntity input)
        {
            if (input == null) return false;
            if (this.Consumers != input.Consumers || (this.Consumers != null && input.Consumers != null && !this.Consumers.SequenceEqual(input.Consumers))) return false;
            if (this.TagName != input.TagName || (this.TagName != null && !this.TagName.Equals(input.TagName))) return false;

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
                if (this.Consumers != null) hashCode = hashCode * 59 + this.Consumers.GetHashCode();
                if (this.TagName != null) hashCode = hashCode * 59 + this.TagName.GetHashCode();
                return hashCode;
            }
        }
    }
}
