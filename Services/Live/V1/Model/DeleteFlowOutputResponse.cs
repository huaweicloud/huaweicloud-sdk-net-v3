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
    public class DeleteFlowOutputResponse : SdkResponse
    {

        /// <summary>
        /// 流ID
        /// </summary>
        [JsonProperty("flow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowId { get; set; }

        /// <summary>
        /// 输出名称
        /// </summary>
        [JsonProperty("output_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFlowOutputResponse {\n");
            sb.Append("  flowId: ").Append(FlowId).Append("\n");
            sb.Append("  outputName: ").Append(OutputName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFlowOutputResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFlowOutputResponse input)
        {
            if (input == null) return false;
            if (this.FlowId != input.FlowId || (this.FlowId != null && !this.FlowId.Equals(input.FlowId))) return false;
            if (this.OutputName != input.OutputName || (this.OutputName != null && !this.OutputName.Equals(input.OutputName))) return false;

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
                if (this.OutputName != null) hashCode = hashCode * 59 + this.OutputName.GetHashCode();
                return hashCode;
            }
        }
    }
}
