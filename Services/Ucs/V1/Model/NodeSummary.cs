using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeSummary 
    {

        /// <summary>
        /// 集群中所有节点的个数。
        /// </summary>
        [JsonProperty("totalNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 集群中已就绪节点的数量。
        /// </summary>
        [JsonProperty("readyNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadyNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSummary {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  readyNum: ").Append(ReadyNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSummary input)
        {
            if (input == null) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.ReadyNum != input.ReadyNum || (this.ReadyNum != null && !this.ReadyNum.Equals(input.ReadyNum))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.ReadyNum != null) hashCode = hashCode * 59 + this.ReadyNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
