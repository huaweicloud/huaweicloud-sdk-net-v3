using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// This is a auto request Object
    /// </summary>
    public class ReduceRequest 
    {

        /// <summary>
        /// 需要缩容的节点数量，最大值为实例节点数减1。
        /// </summary>
        [JsonProperty("node_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNumber { get; set; }

        /// <summary>
        /// 组id，指定当前进行节点扩容的组。当实例的组&gt;1时，必填。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceRequest {\n");
            sb.Append("  nodeNumber: ").Append(NodeNumber).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReduceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReduceRequest input)
        {
            if (input == null) return false;
            if (this.NodeNumber != input.NodeNumber || (this.NodeNumber != null && !this.NodeNumber.Equals(input.NodeNumber))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;

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
                if (this.NodeNumber != null) hashCode = hashCode * 59 + this.NodeNumber.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
