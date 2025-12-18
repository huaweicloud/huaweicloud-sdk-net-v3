using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupNodeInfoResult 
    {

        /// <summary>
        /// **参数解释**: 选择指定az下的节点进行备份。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("az_list", NullValueHandling = NullValueHandling.Ignore)]
        public string AzList { get; set; }

        /// <summary>
        /// **参数解释**: 选择指定节点进行备份。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupNodeInfoResult {\n");
            sb.Append("  azList: ").Append(AzList).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupNodeInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupNodeInfoResult input)
        {
            if (input == null) return false;
            if (this.AzList != input.AzList || (this.AzList != null && !this.AzList.Equals(input.AzList))) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && !this.NodeList.Equals(input.NodeList))) return false;

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
                if (this.AzList != null) hashCode = hashCode * 59 + this.AzList.GetHashCode();
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
