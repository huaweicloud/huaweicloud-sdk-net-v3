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
    public class Subscription 
    {

        /// <summary>
        /// **参数解释**： 订阅的Topic名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**： 订阅类型。 **约束限制**： 不涉及。 **取值范围**： - TAG：基于TAG进行订阅。 - SQL92：基于消息属性进行复杂条件过滤的订阅。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 订阅tag字符。
        /// </summary>
        [JsonProperty("expression", NullValueHandling = NullValueHandling.Ignore)]
        public string Expression { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  expression: ").Append(Expression).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subscription input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Expression != input.Expression || (this.Expression != null && !this.Expression.Equals(input.Expression))) return false;

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
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Expression != null) hashCode = hashCode * 59 + this.Expression.GetHashCode();
                return hashCode;
            }
        }
    }
}
