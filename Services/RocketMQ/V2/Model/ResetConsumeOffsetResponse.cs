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
    /// Response Object
    /// </summary>
    public class ResetConsumeOffsetResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 重置的队列。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResetConsumeOffsetRespQueues> Queues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetConsumeOffsetResponse {\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetConsumeOffsetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetConsumeOffsetResponse input)
        {
            if (input == null) return false;
            if (this.Queues != input.Queues || (this.Queues != null && input.Queues != null && !this.Queues.SequenceEqual(input.Queues))) return false;

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
                if (this.Queues != null) hashCode = hashCode * 59 + this.Queues.GetHashCode();
                return hashCode;
            }
        }
    }
}
