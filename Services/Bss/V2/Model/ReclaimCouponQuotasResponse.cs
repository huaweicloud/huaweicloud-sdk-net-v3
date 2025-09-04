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
    public class ReclaimCouponQuotasResponse : SdkResponse
    {

        /// <summary>
        /// 回收失败的云经销商额度信息，具体参见表1，只有HTTP STATUS 200的时候才有这个结构体。
        /// </summary>
        [JsonProperty("error_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorDetail> ErrorDetails { get; set; }

        /// <summary>
        /// 回收成功的云经销商额度信息，具体参见表2，只有HTTP STATUS 200的时候才有这个结构体。
        /// </summary>
        [JsonProperty("simple_quota_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuotaReclaim> SimpleQuotaInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReclaimCouponQuotasResponse {\n");
            sb.Append("  errorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  simpleQuotaInfos: ").Append(SimpleQuotaInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReclaimCouponQuotasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReclaimCouponQuotasResponse input)
        {
            if (input == null) return false;
            if (this.ErrorDetails != input.ErrorDetails || (this.ErrorDetails != null && input.ErrorDetails != null && !this.ErrorDetails.SequenceEqual(input.ErrorDetails))) return false;
            if (this.SimpleQuotaInfos != input.SimpleQuotaInfos || (this.SimpleQuotaInfos != null && input.SimpleQuotaInfos != null && !this.SimpleQuotaInfos.SequenceEqual(input.SimpleQuotaInfos))) return false;

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
                if (this.ErrorDetails != null) hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.SimpleQuotaInfos != null) hashCode = hashCode * 59 + this.SimpleQuotaInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
