using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 修改虚拟IGW的请求体
    /// </summary>
    public class UpdateTenantVpcIgwRequestBodyVpcIgw 
    {

        /// <summary>
        /// 虚拟IGW的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否使能ipv6
        /// </summary>
        [JsonProperty("enable_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantVpcIgwRequestBodyVpcIgw {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enableIpv6: ").Append(EnableIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantVpcIgwRequestBodyVpcIgw);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantVpcIgwRequestBodyVpcIgw input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EnableIpv6 == input.EnableIpv6 ||
                    (this.EnableIpv6 != null &&
                    this.EnableIpv6.Equals(input.EnableIpv6))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnableIpv6 != null)
                    hashCode = hashCode * 59 + this.EnableIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
