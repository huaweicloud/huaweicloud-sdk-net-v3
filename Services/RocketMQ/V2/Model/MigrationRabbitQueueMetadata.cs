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
    /// **参数解释**： RocketMQ元数据迁移，RabbitMQ队列元数据。 **约束限制**： 不涉及。 **取值范围**： - true：持久化。 - false：不进行持久化。 **默认取值**： 不涉及。
    /// </summary>
    public class MigrationRabbitQueueMetadata 
    {

        /// <summary>
        /// **参数解释**： vhost名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// **参数解释**： 队列名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 是否持久化。 **约束限制**： 不涉及。 **取值范围**： - true：持久化。 - false：不进行持久化。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRabbitQueueMetadata {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRabbitQueueMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRabbitQueueMetadata input)
        {
            if (input == null) return false;
            if (this.Vhost != input.Vhost || (this.Vhost != null && !this.Vhost.Equals(input.Vhost))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Durable != input.Durable || (this.Durable != null && !this.Durable.Equals(input.Durable))) return false;

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
                if (this.Vhost != null) hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Durable != null) hashCode = hashCode * 59 + this.Durable.GetHashCode();
                return hashCode;
            }
        }
    }
}
