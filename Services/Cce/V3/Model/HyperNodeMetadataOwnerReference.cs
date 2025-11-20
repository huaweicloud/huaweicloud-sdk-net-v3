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
    /// 属主对象
    /// </summary>
    public class HyperNodeMetadataOwnerReference 
    {

        /// <summary>
        /// **参数解释**： 节点池名称
        /// </summary>
        [JsonProperty("nodepoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolName { get; set; }

        /// <summary>
        /// **参数解释**： 节点池UID
        /// </summary>
        [JsonProperty("nodepoolID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperNodeMetadataOwnerReference {\n");
            sb.Append("  nodepoolName: ").Append(NodepoolName).Append("\n");
            sb.Append("  nodepoolID: ").Append(NodepoolID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperNodeMetadataOwnerReference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperNodeMetadataOwnerReference input)
        {
            if (input == null) return false;
            if (this.NodepoolName != input.NodepoolName || (this.NodepoolName != null && !this.NodepoolName.Equals(input.NodepoolName))) return false;
            if (this.NodepoolID != input.NodepoolID || (this.NodepoolID != null && !this.NodepoolID.Equals(input.NodepoolID))) return false;

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
                if (this.NodepoolName != null) hashCode = hashCode * 59 + this.NodepoolName.GetHashCode();
                if (this.NodepoolID != null) hashCode = hashCode * 59 + this.NodepoolID.GetHashCode();
                return hashCode;
            }
        }
    }
}
