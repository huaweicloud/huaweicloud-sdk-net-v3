using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NeutronCreateRouterOption 
    {

        /// <summary>
        /// 功能说明：路由器的名称。 取值范围：0-64个字符，仅支持数字、字母、中文、_(下划线)、-（中划线）、.（点）。 约束：如果name非空，则name不能重复
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：资源的管理状态 取值范围：true、false 约束：只支持true
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_gateway_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalGatewayInfoOption ExternalGatewayInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateRouterOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  externalGatewayInfo: ").Append(ExternalGatewayInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateRouterOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateRouterOption input)
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
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ExternalGatewayInfo == input.ExternalGatewayInfo ||
                    (this.ExternalGatewayInfo != null &&
                    this.ExternalGatewayInfo.Equals(input.ExternalGatewayInfo))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.ExternalGatewayInfo != null)
                    hashCode = hashCode * 59 + this.ExternalGatewayInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
