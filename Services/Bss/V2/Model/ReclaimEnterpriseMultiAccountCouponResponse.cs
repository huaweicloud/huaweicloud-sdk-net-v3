using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ReclaimEnterpriseMultiAccountCouponResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：实际回收金额。| |参数的约束及描述：成功时返回|
        /// </summary>
        [JsonProperty("real_retrieve_amout", NullValueHandling = NullValueHandling.Ignore)]
        public string RealRetrieveAmout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReclaimEnterpriseMultiAccountCouponResponse {\n");
            sb.Append("  realRetrieveAmout: ").Append(RealRetrieveAmout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReclaimEnterpriseMultiAccountCouponResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReclaimEnterpriseMultiAccountCouponResponse input)
        {
            if (input == null) return false;
            if (this.RealRetrieveAmout != input.RealRetrieveAmout || (this.RealRetrieveAmout != null && !this.RealRetrieveAmout.Equals(input.RealRetrieveAmout))) return false;

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
                if (this.RealRetrieveAmout != null) hashCode = hashCode * 59 + this.RealRetrieveAmout.GetHashCode();
                return hashCode;
            }
        }
    }
}
