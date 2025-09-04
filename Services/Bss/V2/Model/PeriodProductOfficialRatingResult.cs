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
    public class PeriodProductOfficialRatingResult 
    {

        /// <summary>
        /// ID标识，来源于请求中的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 包年/包月产品的ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 包年/包月产品的官网价。
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 价格度量单位标识。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 分期金额的官网价。  说明： 暂只支持CloudPond产品。
        /// </summary>
        [JsonProperty("installment_official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentOfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 分期付款的周期类型。 2：月 3：年 说明： 暂只支持CloudPond产品。
        /// </summary>
        [JsonProperty("installment_period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstallmentPeriodType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeriodProductOfficialRatingResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  installmentOfficialWebsiteAmount: ").Append(InstallmentOfficialWebsiteAmount).Append("\n");
            sb.Append("  installmentPeriodType: ").Append(InstallmentPeriodType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeriodProductOfficialRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeriodProductOfficialRatingResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.InstallmentOfficialWebsiteAmount != input.InstallmentOfficialWebsiteAmount || (this.InstallmentOfficialWebsiteAmount != null && !this.InstallmentOfficialWebsiteAmount.Equals(input.InstallmentOfficialWebsiteAmount))) return false;
            if (this.InstallmentPeriodType != input.InstallmentPeriodType || (this.InstallmentPeriodType != null && !this.InstallmentPeriodType.Equals(input.InstallmentPeriodType))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.InstallmentOfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.InstallmentOfficialWebsiteAmount.GetHashCode();
                if (this.InstallmentPeriodType != null) hashCode = hashCode * 59 + this.InstallmentPeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
