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
    /// 
    /// </summary>
    public class InPlaceMigratetoNodesSpec 
    {

        /// <summary>
        /// **参数解释**： 腾挪节点列表 **约束限制**： 不涉及 
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<InplaceMigrateNodeItem> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dataDiskCleanUpOption", NullValueHandling = NullValueHandling.Ignore)]
        public DataDiskCleanUpOption DataDiskCleanUpOption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public InPlaceMigrateNodeExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InPlaceMigratetoNodesSpec {\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  dataDiskCleanUpOption: ").Append(DataDiskCleanUpOption).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InPlaceMigratetoNodesSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InPlaceMigratetoNodesSpec input)
        {
            if (input == null) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.DataDiskCleanUpOption != input.DataDiskCleanUpOption || (this.DataDiskCleanUpOption != null && !this.DataDiskCleanUpOption.Equals(input.DataDiskCleanUpOption))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.DataDiskCleanUpOption != null) hashCode = hashCode * 59 + this.DataDiskCleanUpOption.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
