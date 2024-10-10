using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDDoSFlowResponse : SdkResponse
    {

        /// <summary>
        /// 当请求type&#x3D;bps时必返回
        /// </summary>
        [JsonProperty("flow_bps", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowBps> FlowBps { get; set; }

        /// <summary>
        /// 当请求type&#x3D;pps时必返回
        /// </summary>
        [JsonProperty("flow_pps", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowPps> FlowPps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDDoSFlowResponse {\n");
            sb.Append("  flowBps: ").Append(FlowBps).Append("\n");
            sb.Append("  flowPps: ").Append(FlowPps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDDoSFlowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDDoSFlowResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlowBps == input.FlowBps ||
                    this.FlowBps != null &&
                    input.FlowBps != null &&
                    this.FlowBps.SequenceEqual(input.FlowBps)
                ) && 
                (
                    this.FlowPps == input.FlowPps ||
                    this.FlowPps != null &&
                    input.FlowPps != null &&
                    this.FlowPps.SequenceEqual(input.FlowPps)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FlowBps != null)
                    hashCode = hashCode * 59 + this.FlowBps.GetHashCode();
                if (this.FlowPps != null)
                    hashCode = hashCode * 59 + this.FlowPps.GetHashCode();
                return hashCode;
            }
        }
    }
}
