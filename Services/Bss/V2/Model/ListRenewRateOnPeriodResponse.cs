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
    public class ListRenewRateOnPeriodResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：币种。CNY：人民币。USD：美元。| |参数约束及描述：币种。CNY：人民币。USD：美元。|
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// |参数名称：主资源（包含从资源）询价结果| |参数约束以及描述：主资源（包含从资源）询价结果|
        /// </summary>
        [JsonProperty("renew_inquiry_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<RenewInquiryResultInfo> RenewInquiryResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("official_website_rating_result", NullValueHandling = NullValueHandling.Ignore)]
        public OfficialWebsiteRatingResultV2 OfficialWebsiteRatingResult { get; set; }

        /// <summary>
        /// |参数名称：存在可选折扣优惠时返回折扣优惠维度询价结果，每个折扣优惠一组询价结果| |参数约束以及描述：存在可选折扣优惠时返回折扣优惠维度询价结果，每个折扣优惠一组询价结果|
        /// </summary>
        [JsonProperty("optional_discount_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionalDiscountRatingResultV2> OptionalDiscountRatingResults { get; set; }

        /// <summary>
        /// |参数名称：失败的资源信息列表| |参数约束以及描述：失败的资源信息列表|
        /// </summary>
        [JsonProperty("fail_resource_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailResourceInfo> FailResourceInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRenewRateOnPeriodResponse {\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  renewInquiryResults: ").Append(RenewInquiryResults).Append("\n");
            sb.Append("  officialWebsiteRatingResult: ").Append(OfficialWebsiteRatingResult).Append("\n");
            sb.Append("  optionalDiscountRatingResults: ").Append(OptionalDiscountRatingResults).Append("\n");
            sb.Append("  failResourceInfos: ").Append(FailResourceInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRenewRateOnPeriodResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRenewRateOnPeriodResponse input)
        {
            if (input == null) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.RenewInquiryResults != input.RenewInquiryResults || (this.RenewInquiryResults != null && input.RenewInquiryResults != null && !this.RenewInquiryResults.SequenceEqual(input.RenewInquiryResults))) return false;
            if (this.OfficialWebsiteRatingResult != input.OfficialWebsiteRatingResult || (this.OfficialWebsiteRatingResult != null && !this.OfficialWebsiteRatingResult.Equals(input.OfficialWebsiteRatingResult))) return false;
            if (this.OptionalDiscountRatingResults != input.OptionalDiscountRatingResults || (this.OptionalDiscountRatingResults != null && input.OptionalDiscountRatingResults != null && !this.OptionalDiscountRatingResults.SequenceEqual(input.OptionalDiscountRatingResults))) return false;
            if (this.FailResourceInfos != input.FailResourceInfos || (this.FailResourceInfos != null && input.FailResourceInfos != null && !this.FailResourceInfos.SequenceEqual(input.FailResourceInfos))) return false;

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
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RenewInquiryResults != null) hashCode = hashCode * 59 + this.RenewInquiryResults.GetHashCode();
                if (this.OfficialWebsiteRatingResult != null) hashCode = hashCode * 59 + this.OfficialWebsiteRatingResult.GetHashCode();
                if (this.OptionalDiscountRatingResults != null) hashCode = hashCode * 59 + this.OptionalDiscountRatingResults.GetHashCode();
                if (this.FailResourceInfos != null) hashCode = hashCode * 59 + this.FailResourceInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
