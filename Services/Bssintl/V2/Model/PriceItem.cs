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
    public class PriceItem 
    {

        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonProperty("offering_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferingId { get; set; }

        /// <summary>
        /// 币种，USD
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 官网价
        /// </summary>
        [JsonProperty("official_price", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialPrice { get; set; }

        /// <summary>
        /// 计费模式，PERIOD：包年/包月、ON_DEMAND：按需、ONE_TIME：一次性、ON_DEMAND_PKG：按需套餐包
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 销售周期类型，0：天 2：月 3：年 4：小时
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 销售周期数列表
        /// </summary>
        [JsonProperty("period_nums", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PeriodNums { get; set; }

        /// <summary>
        /// 计费因子编码
        /// </summary>
        [JsonProperty("billing_usage_factor", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingUsageFactor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceItem {\n");
            sb.Append("  offeringId: ").Append(OfferingId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  officialPrice: ").Append(OfficialPrice).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNums: ").Append(PeriodNums).Append("\n");
            sb.Append("  billingUsageFactor: ").Append(BillingUsageFactor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PriceItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PriceItem input)
        {
            if (input == null) return false;
            if (this.OfferingId != input.OfferingId || (this.OfferingId != null && !this.OfferingId.Equals(input.OfferingId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.OfficialPrice != input.OfficialPrice || (this.OfficialPrice != null && !this.OfficialPrice.Equals(input.OfficialPrice))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNums != input.PeriodNums || (this.PeriodNums != null && input.PeriodNums != null && !this.PeriodNums.SequenceEqual(input.PeriodNums))) return false;
            if (this.BillingUsageFactor != input.BillingUsageFactor || (this.BillingUsageFactor != null && !this.BillingUsageFactor.Equals(input.BillingUsageFactor))) return false;

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
                if (this.OfferingId != null) hashCode = hashCode * 59 + this.OfferingId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.OfficialPrice != null) hashCode = hashCode * 59 + this.OfficialPrice.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNums != null) hashCode = hashCode * 59 + this.PeriodNums.GetHashCode();
                if (this.BillingUsageFactor != null) hashCode = hashCode * 59 + this.BillingUsageFactor.GetHashCode();
                return hashCode;
            }
        }
    }
}
