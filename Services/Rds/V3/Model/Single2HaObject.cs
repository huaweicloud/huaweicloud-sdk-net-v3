using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 单机转主备时必填。
    /// </summary>
    public class Single2HaObject 
    {

        /// <summary>
        /// 实例节点可用区码（AZ）。
        /// </summary>
        [JsonProperty("az_code_new_node", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCodeNewNode { get; set; }

        /// <summary>
        /// Dec用户专属存储ID，每个az配置的专属存储不同，实例节点所在专属存储ID，仅支持DEC用户创建时使用。
        /// </summary>
        [JsonProperty("dsspool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DsspoolId { get; set; }

        /// <summary>
        /// 仅包周期实例进行单机转主备时可指定，表示是否自动从客户的账户中支付。 - true，为自动支付。 - false，为手动支付，默认该方式。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public ADDomainInfo AdDomainInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Single2HaObject {\n");
            sb.Append("  azCodeNewNode: ").Append(AzCodeNewNode).Append("\n");
            sb.Append("  dsspoolId: ").Append(DsspoolId).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  adDomainInfo: ").Append(AdDomainInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Single2HaObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Single2HaObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AzCodeNewNode == input.AzCodeNewNode ||
                    (this.AzCodeNewNode != null &&
                    this.AzCodeNewNode.Equals(input.AzCodeNewNode))
                ) && 
                (
                    this.DsspoolId == input.DsspoolId ||
                    (this.DsspoolId != null &&
                    this.DsspoolId.Equals(input.DsspoolId))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.AdDomainInfo == input.AdDomainInfo ||
                    (this.AdDomainInfo != null &&
                    this.AdDomainInfo.Equals(input.AdDomainInfo))
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
                if (this.AzCodeNewNode != null)
                    hashCode = hashCode * 59 + this.AzCodeNewNode.GetHashCode();
                if (this.DsspoolId != null)
                    hashCode = hashCode * 59 + this.DsspoolId.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.AdDomainInfo != null)
                    hashCode = hashCode * 59 + this.AdDomainInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
