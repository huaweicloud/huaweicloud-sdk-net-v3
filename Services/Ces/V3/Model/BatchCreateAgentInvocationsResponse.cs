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
    public class BatchCreateAgentInvocationsResponse : SdkResponse
    {

        /// <summary>
        /// 创建任务的信息列表
        /// </summary>
        [JsonProperty("invocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchCreateInvocationInfo> Invocations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateAgentInvocationsResponse {\n");
            sb.Append("  invocations: ").Append(Invocations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateAgentInvocationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateAgentInvocationsResponse input)
        {
            if (input == null) return false;
            if (this.Invocations != input.Invocations || (this.Invocations != null && input.Invocations != null && !this.Invocations.SequenceEqual(input.Invocations))) return false;

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
                return hashCode;
            }
        }
    }
}
