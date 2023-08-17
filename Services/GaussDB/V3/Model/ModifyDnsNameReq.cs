using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 修改内网域名
    /// </summary>
    public class ModifyDnsNameReq 
    {

        /// <summary>
        /// 新域名的前缀，取值范围如下：8~63个字符之间，可以包含小写字母、数字，不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyDnsNameReq {\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyDnsNameReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyDnsNameReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsName == input.DnsName ||
                    (this.DnsName != null &&
                    this.DnsName.Equals(input.DnsName))
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
                if (this.DnsName != null)
                    hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                return hashCode;
            }
        }
    }
}
