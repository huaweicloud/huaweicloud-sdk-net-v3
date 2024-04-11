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
    public class ListRoutingBacklogPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 数据流转积压策略列表。
        /// </summary>
        [JsonProperty("backlog_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<BacklogPolicyInfo> BacklogPolicies { get; set; }

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
            sb.Append("class ListRoutingBacklogPolicyResponse {\n");
            sb.Append("  backlogPolicies: ").Append(BacklogPolicies).Append("\n");
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
            return this.Equals(input as ListRoutingBacklogPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRoutingBacklogPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BacklogPolicies == input.BacklogPolicies ||
                    this.BacklogPolicies != null &&
                    input.BacklogPolicies != null &&
                    this.BacklogPolicies.SequenceEqual(input.BacklogPolicies)
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
                if (this.BacklogPolicies != null)
                    hashCode = hashCode * 59 + this.BacklogPolicies.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
