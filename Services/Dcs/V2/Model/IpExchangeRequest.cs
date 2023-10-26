using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 交换IP请求体
    /// </summary>
    public class IpExchangeRequest 
    {

        /// <summary>
        /// 待交换的ip地址
        /// </summary>
        [JsonProperty("exchanged_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExchangedIp { get; set; }

        /// <summary>
        /// 是否交换domain
        /// </summary>
        [JsonProperty("is_exchange_domain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExchangeDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpExchangeRequest {\n");
            sb.Append("  exchangedIp: ").Append(ExchangedIp).Append("\n");
            sb.Append("  isExchangeDomain: ").Append(IsExchangeDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpExchangeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpExchangeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExchangedIp == input.ExchangedIp ||
                    this.ExchangedIp != null &&
                    input.ExchangedIp != null &&
                    this.ExchangedIp.SequenceEqual(input.ExchangedIp)
                ) && 
                (
                    this.IsExchangeDomain == input.IsExchangeDomain ||
                    (this.IsExchangeDomain != null &&
                    this.IsExchangeDomain.Equals(input.IsExchangeDomain))
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
                if (this.ExchangedIp != null)
                    hashCode = hashCode * 59 + this.ExchangedIp.GetHashCode();
                if (this.IsExchangeDomain != null)
                    hashCode = hashCode * 59 + this.IsExchangeDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
