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
    /// This is a auto create Body Object
    /// </summary>
    public class BatchDeleteListenersRequestBody 
    {

        /// <summary>
        /// **参数解释**：待删除的监听器id列表。 **约束限制**：一次最多删除10个监听器。 **取值范围**：不涉及 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("listener_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListenerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteListenersRequestBody {\n");
            sb.Append("  listenerIds: ").Append(ListenerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteListenersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteListenersRequestBody input)
        {
            if (input == null) return false;
            if (this.ListenerIds != input.ListenerIds || (this.ListenerIds != null && input.ListenerIds != null && !this.ListenerIds.SequenceEqual(input.ListenerIds))) return false;

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
                if (this.ListenerIds != null) hashCode = hashCode * 59 + this.ListenerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
