using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量变更询价响应体。
    /// </summary>
    public class BatchInquiryChangeRsp 
    {

        /// <summary>
        /// 返回码，恒为0。
        /// </summary>
        [JsonProperty("ret_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RetCode { get; set; }

        /// <summary>
        /// 返回信息。
        /// </summary>
        [JsonProperty("error_txt", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorTxt { get; set; }

        /// <summary>
        /// 总额，即最终优惠后的金额(降配场景下包含退还的现金、现金券、储值卡的总额)。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 券的退订金额（降配存在）。
        /// </summary>
        [JsonProperty("coupon_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<CouponUnsubscribeResult> CouponResults { get; set; }

        /// <summary>
        /// 优惠额。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 原总额，即优惠前总额。
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OriginalAmount { get; set; }

        /// <summary>
        /// 度量单位标识。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 货币单位代码（遵循ISO 4217标准）。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 批价结果。
        /// </summary>
        [JsonProperty("product_rating_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchResInquiryResult> ProductRatingResult { get; set; }

        /// <summary>
        /// 扩展参数。
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchInquiryChangeRsp {\n");
            sb.Append("  retCode: ").Append(RetCode).Append("\n");
            sb.Append("  errorTxt: ").Append(ErrorTxt).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  couponResults: ").Append(CouponResults).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  originalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  productRatingResult: ").Append(ProductRatingResult).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchInquiryChangeRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchInquiryChangeRsp input)
        {
            if (input == null) return false;
            if (this.RetCode != input.RetCode || (this.RetCode != null && !this.RetCode.Equals(input.RetCode))) return false;
            if (this.ErrorTxt != input.ErrorTxt || (this.ErrorTxt != null && !this.ErrorTxt.Equals(input.ErrorTxt))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.CouponResults != input.CouponResults || (this.CouponResults != null && input.CouponResults != null && !this.CouponResults.SequenceEqual(input.CouponResults))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.OriginalAmount != input.OriginalAmount || (this.OriginalAmount != null && !this.OriginalAmount.Equals(input.OriginalAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.ProductRatingResult != input.ProductRatingResult || (this.ProductRatingResult != null && input.ProductRatingResult != null && !this.ProductRatingResult.SequenceEqual(input.ProductRatingResult))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;

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
                if (this.RetCode != null) hashCode = hashCode * 59 + this.RetCode.GetHashCode();
                if (this.ErrorTxt != null) hashCode = hashCode * 59 + this.ErrorTxt.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CouponResults != null) hashCode = hashCode * 59 + this.CouponResults.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.OriginalAmount != null) hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ProductRatingResult != null) hashCode = hashCode * 59 + this.ProductRatingResult.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
