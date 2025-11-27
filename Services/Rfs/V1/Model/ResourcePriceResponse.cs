using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourcePriceResponse 
    {
        /// <summary>
        /// 计费模式  * &#x60;PRE_PAID&#x60; - 包周期计费 * &#x60;POST_PAID&#x60; - 按需计费 * &#x60;FREE&#x60; - 免费
        /// </summary>
        /// <value>计费模式  * &#x60;PRE_PAID&#x60; - 包周期计费 * &#x60;POST_PAID&#x60; - 按需计费 * &#x60;FREE&#x60; - 免费</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum PRE_PAID for value: PRE_PAID
            /// </summary>
            public static readonly ChargeModeEnum PRE_PAID = new ChargeModeEnum("PRE_PAID");

            /// <summary>
            /// Enum POST_PAID for value: POST_PAID
            /// </summary>
            public static readonly ChargeModeEnum POST_PAID = new ChargeModeEnum("POST_PAID");

            /// <summary>
            /// Enum FREE for value: FREE
            /// </summary>
            public static readonly ChargeModeEnum FREE = new ChargeModeEnum("FREE");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "PRE_PAID", PRE_PAID },
                { "POST_PAID", POST_PAID },
                { "FREE", FREE },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 计费单位  如果该资源支持包周期计费或按需计费，则会返回该字段；如果该资源为免费资源，则不返回该字段。  * &#x60;HOUR&#x60; - 小时，按需计费的单位 * &#x60;DAY&#x60; - 天，按需计费的单位 * &#x60;MONTH&#x60; - 月，包周期计费的单位 * &#x60;YEAR&#x60; - 年，包周期计费的单位 * &#x60;BYTE&#x60; - 字节，按需计费的单位 * &#x60;MB&#x60; - 百万字节，包周期计费和按需计费的单位 * &#x60;GB&#x60; - 千兆字节，包周期计费和按需计费的单位
        /// </summary>
        /// <value>计费单位  如果该资源支持包周期计费或按需计费，则会返回该字段；如果该资源为免费资源，则不返回该字段。  * &#x60;HOUR&#x60; - 小时，按需计费的单位 * &#x60;DAY&#x60; - 天，按需计费的单位 * &#x60;MONTH&#x60; - 月，包周期计费的单位 * &#x60;YEAR&#x60; - 年，包周期计费的单位 * &#x60;BYTE&#x60; - 字节，按需计费的单位 * &#x60;MB&#x60; - 百万字节，包周期计费和按需计费的单位 * &#x60;GB&#x60; - 千兆字节，包周期计费和按需计费的单位</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly PeriodTypeEnum HOUR = new PeriodTypeEnum("HOUR");

            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly PeriodTypeEnum DAY = new PeriodTypeEnum("DAY");

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("MONTH");

            /// <summary>
            /// Enum YEAR for value: YEAR
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("YEAR");

            /// <summary>
            /// Enum BYTE for value: BYTE
            /// </summary>
            public static readonly PeriodTypeEnum BYTE = new PeriodTypeEnum("BYTE");

            /// <summary>
            /// Enum MB for value: MB
            /// </summary>
            public static readonly PeriodTypeEnum MB = new PeriodTypeEnum("MB");

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            public static readonly PeriodTypeEnum GB = new PeriodTypeEnum("GB");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "HOUR", HOUR },
                { "DAY", DAY },
                { "MONTH", MONTH },
                { "YEAR", YEAR },
                { "BYTE", BYTE },
                { "MB", MB },
                { "GB", GB },
            };

            private string _value;

            public PeriodTypeEnum()
            {

            }

            public PeriodTypeEnum(string value)
            {
                _value = value;
            }

            public static PeriodTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as PeriodTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 计费模式  * &#x60;PRE_PAID&#x60; - 包周期计费 * &#x60;POST_PAID&#x60; - 按需计费 * &#x60;FREE&#x60; - 免费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 该资源最终优惠后的金额（只考虑官网折扣、商务折扣以及伙伴折扣，不包含促销折扣及优惠券），保留小数点后2位，向上取整，默认单位是元。
        /// </summary>
        [JsonProperty("sale_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? SalePrice { get; set; }

        /// <summary>
        /// 该资源的总优惠额，保留小数点后2位，向上取整，默认单位是元。
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount { get; set; }

        /// <summary>
        /// 该资源的原价，保留小数点后2位，向上取整，默认单位是元。
        /// </summary>
        [JsonProperty("original_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? OriginalPrice { get; set; }

        /// <summary>
        /// 计费单位  如果该资源支持包周期计费或按需计费，则会返回该字段；如果该资源为免费资源，则不返回该字段。  * &#x60;HOUR&#x60; - 小时，按需计费的单位 * &#x60;DAY&#x60; - 天，按需计费的单位 * &#x60;MONTH&#x60; - 月，包周期计费的单位 * &#x60;YEAR&#x60; - 年，包周期计费的单位 * &#x60;BYTE&#x60; - 字节，按需计费的单位 * &#x60;MB&#x60; - 百万字节，包周期计费和按需计费的单位 * &#x60;GB&#x60; - 千兆字节，包周期计费和按需计费的单位
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 该资源的计费数量，需要和period_type搭配使用  如果该资源支持包周期计费或按需计费，则会返回该字段；如果该资源为免费资源，则不返回该字段。  * 对于按需计费资源，此值默认返回1，代表在1个计费单位下，该资源的价格 * 对于包周期计费资源，此值与模板中该资源的period字段保持一致
        /// </summary>
        [JsonProperty("period_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodCount { get; set; }

        /// <summary>
        /// 该资源的最优折扣类型  对于按需计费资源的折扣类型 合同商务优惠类型：605 （华为云商务-折扣率，一口价，华为云用户）、606 （渠道商务-折扣率，一口价，BP用户） 伙伴折扣优惠类型：607 (合作伙伴授予折扣-折扣率)  对于包周期计费资源的折扣类型 合同商务折扣：605（华为云BE场景下的合同商务折扣）、606（分销商BE场景下的合同商务折扣） 伙伴授予折扣：607 促销折扣：700  如果该资源存在折扣，则返回该字段；如果该资源不存在折扣，则不返回该字段。
        /// </summary>
        [JsonProperty("best_discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BestDiscountType { get; set; }

        /// <summary>
        /// 最优折扣优惠额，保留小数点后2位，向上取整，默认单位是元。  如果该资源存在折扣，则返回该字段；如果该资源不存在折扣，则不返回该字段。
        /// </summary>
        [JsonProperty("best_discount_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? BestDiscountPrice { get; set; }

        /// <summary>
        /// 官网价优惠额，保留小数点后2位，向上取整，默认单位是元。  如果该资源存在官网价优惠额，则返回该字段；如果该资源不存在官网价优惠额，则不返回该字段。
        /// </summary>
        [JsonProperty("official_website_discount_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? OfficialWebsiteDiscountPrice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcePriceResponse {\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  salePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  discount: ").Append(Discount).Append("\n");
            sb.Append("  originalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodCount: ").Append(PeriodCount).Append("\n");
            sb.Append("  bestDiscountType: ").Append(BestDiscountType).Append("\n");
            sb.Append("  bestDiscountPrice: ").Append(BestDiscountPrice).Append("\n");
            sb.Append("  officialWebsiteDiscountPrice: ").Append(OfficialWebsiteDiscountPrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourcePriceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourcePriceResponse input)
        {
            if (input == null) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.SalePrice != input.SalePrice || (this.SalePrice != null && !this.SalePrice.Equals(input.SalePrice))) return false;
            if (this.Discount != input.Discount || (this.Discount != null && !this.Discount.Equals(input.Discount))) return false;
            if (this.OriginalPrice != input.OriginalPrice || (this.OriginalPrice != null && !this.OriginalPrice.Equals(input.OriginalPrice))) return false;
            if (this.PeriodType != input.PeriodType) return false;
            if (this.PeriodCount != input.PeriodCount || (this.PeriodCount != null && !this.PeriodCount.Equals(input.PeriodCount))) return false;
            if (this.BestDiscountType != input.BestDiscountType || (this.BestDiscountType != null && !this.BestDiscountType.Equals(input.BestDiscountType))) return false;
            if (this.BestDiscountPrice != input.BestDiscountPrice || (this.BestDiscountPrice != null && !this.BestDiscountPrice.Equals(input.BestDiscountPrice))) return false;
            if (this.OfficialWebsiteDiscountPrice != input.OfficialWebsiteDiscountPrice || (this.OfficialWebsiteDiscountPrice != null && !this.OfficialWebsiteDiscountPrice.Equals(input.OfficialWebsiteDiscountPrice))) return false;

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
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.SalePrice != null) hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.Discount != null) hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.OriginalPrice != null) hashCode = hashCode * 59 + this.OriginalPrice.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodCount != null) hashCode = hashCode * 59 + this.PeriodCount.GetHashCode();
                if (this.BestDiscountType != null) hashCode = hashCode * 59 + this.BestDiscountType.GetHashCode();
                if (this.BestDiscountPrice != null) hashCode = hashCode * 59 + this.BestDiscountPrice.GetHashCode();
                if (this.OfficialWebsiteDiscountPrice != null) hashCode = hashCode * 59 + this.OfficialWebsiteDiscountPrice.GetHashCode();
                return hashCode;
            }
        }
    }
}
