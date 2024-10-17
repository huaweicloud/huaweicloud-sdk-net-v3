using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrecheckDisasterRecoveryInstance 
    {

        /// <summary>
        /// 与当前实例建立容灾关系实例的vpc网段。
        /// </summary>
        [JsonProperty("vpc_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcCidr { get; set; }

        /// <summary>
        /// 与当前实例建立容灾关系实例的规格码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 与当前实例建立容灾关系实例的节点IP列表。
        /// </summary>
        [JsonProperty("node_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckDisasterRecoveryInstance {\n");
            sb.Append("  vpcCidr: ").Append(VpcCidr).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  nodeIps: ").Append(NodeIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckDisasterRecoveryInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckDisasterRecoveryInstance input)
        {
            if (input == null) return false;
            if (this.VpcCidr != input.VpcCidr || (this.VpcCidr != null && !this.VpcCidr.Equals(input.VpcCidr))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.NodeIps != input.NodeIps || (this.NodeIps != null && input.NodeIps != null && !this.NodeIps.SequenceEqual(input.NodeIps))) return false;

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
                if (this.VpcCidr != null) hashCode = hashCode * 59 + this.VpcCidr.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.NodeIps != null) hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
