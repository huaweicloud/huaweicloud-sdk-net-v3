using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRoutingFlowControlPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 数据流转流控策略列表。
        /// </summary>
        [JsonProperty("flowcontrol_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowControlPolicyInfo> FlowcontrolPolicies { get; set; }

        /// <summary>
        /// 满足查询条件的记录总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 本次分页查询结果中最后一条记录的ID，可在下一次分页查询时使用。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRoutingFlowControlPolicyResponse {\n");
            sb.Append("  flowcontrolPolicies: ").Append(FlowcontrolPolicies).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRoutingFlowControlPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRoutingFlowControlPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlowcontrolPolicies == input.FlowcontrolPolicies ||
                    this.FlowcontrolPolicies != null &&
                    input.FlowcontrolPolicies != null &&
                    this.FlowcontrolPolicies.SequenceEqual(input.FlowcontrolPolicies)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
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
                if (this.FlowcontrolPolicies != null)
                    hashCode = hashCode * 59 + this.FlowcontrolPolicies.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
