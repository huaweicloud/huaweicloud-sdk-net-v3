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
    /// 重置节点参数。集群内已有节点通过重置进行重新安装并接入集群。
    /// </summary>
    public class ResetNode 
    {

        /// <summary>
        /// 节点ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [JsonProperty("nodeID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NodeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallNodeSpec Spec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetNode {\n");
            sb.Append("  nodeID: ").Append(NodeID).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetNode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetNode input)
        {
            if (input == null) return false;
            if (this.NodeID != input.NodeID || (this.NodeID != null && !this.NodeID.Equals(input.NodeID))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;

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
                if (this.NodeID != null) hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                return hashCode;
            }
        }
    }
}
