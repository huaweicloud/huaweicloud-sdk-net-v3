using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OfficialWebsiteRatingResultV2 
    {

        /// <summary>
        /// |参数名称：官网价格。单位为元| |参数约束及描述：官网价格。单位为元|
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// |参数名称：分期金额的官网价。单位为元| |参数约束及描述：分期金额的官网价。单位为元|
        /// </summary>
        [JsonProperty("installment_official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentOfficialWebsiteAmount { get; set; }

        /// <summary>
        /// |参数名称：分期付款的周期类型。2：月| |参数的约束及描述：分期付款的周期类型。2：月|
        /// </summary>
        [JsonProperty("installment_period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstallmentPeriodType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficialWebsiteRatingResultV2 {\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
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
            return this.Equals(input as OfficialWebsiteRatingResultV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OfficialWebsiteRatingResultV2 input)
        {
            if (input == null) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
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
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.InstallmentOfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.InstallmentOfficialWebsiteAmount.GetHashCode();
                if (this.InstallmentPeriodType != null) hashCode = hashCode * 59 + this.InstallmentPeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
