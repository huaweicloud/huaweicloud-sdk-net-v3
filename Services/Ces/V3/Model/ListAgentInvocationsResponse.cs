using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAgentInvocationsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 任务列表 **取值范围**: 返回数组长度为[0,100] 
        /// </summary>
        [JsonProperty("invocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<InvocationInfo> Invocations { get; set; }

        /// <summary>
        /// **参数解释**: 任务列表总量 **取值范围**: 数字范围为[0,9999999999999] 
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentInvocationsResponse {\n");
            sb.Append("  invocations: ").Append(Invocations).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentInvocationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentInvocationsResponse input)
        {
            if (input == null) return false;
            if (this.Invocations != input.Invocations || (this.Invocations != null && input.Invocations != null && !this.Invocations.SequenceEqual(input.Invocations))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.Invocations != null) hashCode = hashCode * 59 + this.Invocations.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
