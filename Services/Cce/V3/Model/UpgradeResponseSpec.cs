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
    /// 升级任务元数据
    /// </summary>
    public class UpgradeResponseSpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterUpgradeAction", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterUpgradeResponseAction ClusterUpgradeAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeResponseSpec {\n");
            sb.Append("  clusterUpgradeAction: ").Append(ClusterUpgradeAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeResponseSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeResponseSpec input)
        {
            if (input == null) return false;
            if (this.ClusterUpgradeAction != input.ClusterUpgradeAction || (this.ClusterUpgradeAction != null && !this.ClusterUpgradeAction.Equals(input.ClusterUpgradeAction))) return false;

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
                if (this.ClusterUpgradeAction != null) hashCode = hashCode * 59 + this.ClusterUpgradeAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
