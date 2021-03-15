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
    /// ENI网络配置，创建集群指定使用Yangtse网络模式时必填。
    /// </summary>
    public class EniNetwork 
    {

        /// <summary>
        /// ENI子网CIDR
        /// </summary>
        [JsonProperty("eniSubnetCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetCIDR { get; set; }

        /// <summary>
        /// eni子网ID
        /// </summary>
        [JsonProperty("eniSubnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EniNetwork {\n");
            sb.Append("  eniSubnetCIDR: ").Append(EniSubnetCIDR).Append("\n");
            sb.Append("  eniSubnetId: ").Append(EniSubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EniNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EniNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EniSubnetCIDR == input.EniSubnetCIDR ||
                    (this.EniSubnetCIDR != null &&
                    this.EniSubnetCIDR.Equals(input.EniSubnetCIDR))
                ) && 
                (
                    this.EniSubnetId == input.EniSubnetId ||
                    (this.EniSubnetId != null &&
                    this.EniSubnetId.Equals(input.EniSubnetId))
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
                if (this.EniSubnetCIDR != null)
                    hashCode = hashCode * 59 + this.EniSubnetCIDR.GetHashCode();
                if (this.EniSubnetId != null)
                    hashCode = hashCode * 59 + this.EniSubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
