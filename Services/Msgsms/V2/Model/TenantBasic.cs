using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TenantBasic 
    {

        /// <summary>
        /// 租户custom id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 租户custom name
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 租户企业名称
        /// </summary>
        [JsonProperty("enterprise_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantBasic {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  customerName: ").Append(CustomerName).Append("\n");
            sb.Append("  enterpriseName: ").Append(EnterpriseName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TenantBasic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TenantBasic input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CustomerName != input.CustomerName || (this.CustomerName != null && !this.CustomerName.Equals(input.CustomerName))) return false;
            if (this.EnterpriseName != input.EnterpriseName || (this.EnterpriseName != null && !this.EnterpriseName.Equals(input.EnterpriseName))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CustomerName != null) hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.EnterpriseName != null) hashCode = hashCode * 59 + this.EnterpriseName.GetHashCode();
                return hashCode;
            }
        }
    }
}
