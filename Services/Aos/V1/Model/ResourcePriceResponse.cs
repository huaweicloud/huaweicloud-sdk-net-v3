using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// resource price response
    /// </summary>
    public class ResourcePriceResponse 
    {
        /// <summary>
        /// 计费模式，包周期计费、按需计费、免费的返回，不支持的资源不返回 PRE_PAID 包周期计费 POST_PAID 按需计费 FREE 免费
        /// </summary>
        /// <value>计费模式，包周期计费、按需计费、免费的返回，不支持的资源不返回 PRE_PAID 包周期计费 POST_PAID 按需计费 FREE 免费</value>
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

            private string Value;

            public ChargeModeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
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
        /// 包周期和按需的计费单位，包周期计费和按需计费返回，免费不会返回 HOUR：小时，包周期计费和按需计费返回，免费不会返回 DAY：天，包周期计费返回，按需计费和免费不会返回 WEEK：周，包周期计费返回，按需计费和免费不会返回 MONTH：月，包周期计费返回，按需计费和免费不会返回 YEAR：年，包周期计费返回，按需计费和免费不会返回 BYTE：字节，按需计费返回，包周期计费和免费不会返回 MB：百万字节，按需计费返回，包周期计费和免费不会返回 GB：千兆字节，按需计费返回，包周期计费和免费不会返回
        /// </summary>
        /// <value>包周期和按需的计费单位，包周期计费和按需计费返回，免费不会返回 HOUR：小时，包周期计费和按需计费返回，免费不会返回 DAY：天，包周期计费返回，按需计费和免费不会返回 WEEK：周，包周期计费返回，按需计费和免费不会返回 MONTH：月，包周期计费返回，按需计费和免费不会返回 YEAR：年，包周期计费返回，按需计费和免费不会返回 BYTE：字节，按需计费返回，包周期计费和免费不会返回 MB：百万字节，按需计费返回，包周期计费和免费不会返回 GB：千兆字节，按需计费返回，包周期计费和免费不会返回</value>
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
            /// Enum WEEK for value: WEEK
            /// </summary>
            public static readonly PeriodTypeEnum WEEK = new PeriodTypeEnum("WEEK");

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
                { "WEEK", WEEK },
                { "MONTH", MONTH },
                { "YEAR", YEAR },
                { "BYTE", BYTE },
                { "MB", MB },
                { "GB", GB },
            };

            private string Value;

            public PeriodTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
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
        /// 计费模式，包周期计费、按需计费、免费的返回，不支持的资源不返回 PRE_PAID 包周期计费 POST_PAID 按需计费 FREE 免费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 执行计划中的每个资源部署后最终优惠后的金额，保留小数点后2位，向下取整，默认单位是元
        /// </summary>
        [JsonProperty("sale_price", NullValueHandling = NullValueHandling.Ignore)]
        public Object SalePrice { get; set; }

        /// <summary>
        /// 执行计划中的每个资源部署后的优惠额，保留小数点后2位，向下取整，默认单位是元
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public Object Discount { get; set; }

        /// <summary>
        /// 执行计划中的每个资源部署后的原价，保留小数点后2位，向下取整，默认单位是元
        /// </summary>
        [JsonProperty("original_price", NullValueHandling = NullValueHandling.Ignore)]
        public Object OriginalPrice { get; set; }

        /// <summary>
        /// 包周期和按需的计费单位，包周期计费和按需计费返回，免费不会返回 HOUR：小时，包周期计费和按需计费返回，免费不会返回 DAY：天，包周期计费返回，按需计费和免费不会返回 WEEK：周，包周期计费返回，按需计费和免费不会返回 MONTH：月，包周期计费返回，按需计费和免费不会返回 YEAR：年，包周期计费返回，按需计费和免费不会返回 BYTE：字节，按需计费返回，包周期计费和免费不会返回 MB：百万字节，按需计费返回，包周期计费和免费不会返回 GB：千兆字节，按需计费返回，包周期计费和免费不会返回
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 订购数量。包周期计费和按需计费返回，免费不会返回。
        /// </summary>
        [JsonProperty("period_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodCount { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodCount == input.PeriodCount ||
                    (this.PeriodCount != null &&
                    this.PeriodCount.Equals(input.PeriodCount))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.SalePrice != null)
                    hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.OriginalPrice != null)
                    hashCode = hashCode * 59 + this.OriginalPrice.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodCount != null)
                    hashCode = hashCode * 59 + this.PeriodCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
