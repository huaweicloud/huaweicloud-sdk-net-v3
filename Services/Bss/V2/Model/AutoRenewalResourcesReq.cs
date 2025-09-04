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
    /// 
    /// </summary>
    public class AutoRenewalResourcesReq 
    {

        /// <summary>
        /// |参数名称：自动续费次数| |参数的约束及描述：该参数非必填，范围限制：0-99，0代表不限制次数。 首次开通自动续费，此参数不携带或携带值为null时，默认为不限制次数 已开通自动续费，重置自动续费次数时此参数必填，否则不做处理，不进行修改|
        /// </summary>
        [JsonProperty("auto_renew_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoRenewTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoRenewalResourcesReq {\n");
            sb.Append("  autoRenewTimes: ").Append(AutoRenewTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoRenewalResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoRenewalResourcesReq input)
        {
            if (input == null) return false;
            if (this.AutoRenewTimes != input.AutoRenewTimes || (this.AutoRenewTimes != null && !this.AutoRenewTimes.Equals(input.AutoRenewTimes))) return false;

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
                if (this.AutoRenewTimes != null) hashCode = hashCode * 59 + this.AutoRenewTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
