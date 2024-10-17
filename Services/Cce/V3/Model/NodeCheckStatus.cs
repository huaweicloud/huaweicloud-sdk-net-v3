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
    /// 节点限制检查状态
    /// </summary>
    public class NodeCheckStatus 
    {

        /// <summary>
        /// 状态，取值如下 - Init: 初始化 - Running 运行中 - Success 成功 - Failed 失败
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 节点检查状态
        /// </summary>
        [JsonProperty("nodeStageStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeStageStatus> NodeStageStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeCheckStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  nodeStageStatus: ").Append(NodeStageStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeCheckStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeCheckStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.NodeStageStatus != input.NodeStageStatus || (this.NodeStageStatus != null && input.NodeStageStatus != null && !this.NodeStageStatus.SequenceEqual(input.NodeStageStatus))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.NodeStageStatus != null) hashCode = hashCode * 59 + this.NodeStageStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
