using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 云服务按需转包请求体
    /// </summary>
    public class BwChangeToPeriodReq 
    {

        /// <summary>
        /// 待按需转包带宽列表 
        /// </summary>
        [JsonProperty("bandwidth_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BandwidthIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePrePaidPublicipExtendParamOption ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BwChangeToPeriodReq {\n");
            sb.Append("  bandwidthIds: ").Append(BandwidthIds).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BwChangeToPeriodReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BwChangeToPeriodReq input)
        {
            if (input == null) return false;
            if (this.BandwidthIds != input.BandwidthIds || (this.BandwidthIds != null && input.BandwidthIds != null && !this.BandwidthIds.SequenceEqual(input.BandwidthIds))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.BandwidthIds != null) hashCode = hashCode * 59 + this.BandwidthIds.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
