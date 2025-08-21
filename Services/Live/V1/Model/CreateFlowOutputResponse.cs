using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateFlowOutputResponse : SdkResponse
    {

        /// <summary>
        /// 流ID
        /// </summary>
        [JsonProperty("flow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowId { get; set; }

        /// <summary>
        /// 所有输出信息
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowsOutput> Outputs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFlowOutputResponse {\n");
            sb.Append("  flowId: ").Append(FlowId).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFlowOutputResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFlowOutputResponse input)
        {
            if (input == null) return false;
            if (this.FlowId != input.FlowId || (this.FlowId != null && !this.FlowId.Equals(input.FlowId))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;

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
                if (this.FlowId != null) hashCode = hashCode * 59 + this.FlowId.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                return hashCode;
            }
        }
    }
}
