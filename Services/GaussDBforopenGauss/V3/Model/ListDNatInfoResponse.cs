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
    /// Response Object
    /// </summary>
    public class ListDNatInfoResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 查询实例已绑定的NAT网关列表。
        /// </summary>
        [JsonProperty("dnat_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DNatInfoResult> DnatList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDNatInfoResponse {\n");
            sb.Append("  dnatList: ").Append(DnatList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDNatInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDNatInfoResponse input)
        {
            if (input == null) return false;
            if (this.DnatList != input.DnatList || (this.DnatList != null && input.DnatList != null && !this.DnatList.SequenceEqual(input.DnatList))) return false;

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
                if (this.DnatList != null) hashCode = hashCode * 59 + this.DnatList.GetHashCode();
                return hashCode;
            }
        }
    }
}
