using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点检查状态
    /// </summary>
    public class NodeStageStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public NodeInfo NodeInfo { get; set; }

        /// <summary>
        /// 检查项状态集合
        /// </summary>
        [JsonProperty("itemsStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreCheckItemStatus> ItemsStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeStageStatus {\n");
            sb.Append("  nodeInfo: ").Append(NodeInfo).Append("\n");
            sb.Append("  itemsStatus: ").Append(ItemsStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeStageStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeStageStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeInfo == input.NodeInfo ||
                    (this.NodeInfo != null &&
                    this.NodeInfo.Equals(input.NodeInfo))
                ) && 
                (
                    this.ItemsStatus == input.ItemsStatus ||
                    this.ItemsStatus != null &&
                    input.ItemsStatus != null &&
                    this.ItemsStatus.SequenceEqual(input.ItemsStatus)
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
                if (this.NodeInfo != null)
                    hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                if (this.ItemsStatus != null)
                    hashCode = hashCode * 59 + this.ItemsStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
