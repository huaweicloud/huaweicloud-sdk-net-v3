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
    public class HyperNodeSpec 
    {

        /// <summary>
        /// **参数解释**： 超节点规格
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**： 所属节点池ID
        /// </summary>
        [JsonProperty("nodepoolID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolID { get; set; }

        /// <summary>
        /// **参数解释**： 超节点下节点相关的配置。
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeTemplateInHyperNode> NodeTemplate { get; set; }

        /// <summary>
        /// **参数解释**： 付费方式 **取值范围**： - prepaid: 预付费，即包年包月； - postpaid: 后付费，即按需付费；
        /// </summary>
        [JsonProperty("chargeMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperNodeSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  nodepoolID: ").Append(NodepoolID).Append("\n");
            sb.Append("  nodeTemplate: ").Append(NodeTemplate).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperNodeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperNodeSpec input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.NodepoolID != input.NodepoolID || (this.NodepoolID != null && !this.NodepoolID.Equals(input.NodepoolID))) return false;
            if (this.NodeTemplate != input.NodeTemplate || (this.NodeTemplate != null && input.NodeTemplate != null && !this.NodeTemplate.SequenceEqual(input.NodeTemplate))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.NodepoolID != null) hashCode = hashCode * 59 + this.NodepoolID.GetHashCode();
                if (this.NodeTemplate != null) hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
