using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChargingInfo 
    {
        /// <summary>
        /// **参数解释**：付费类型。表示服务器的计费模式。 **约束限制**：不涉及。 **取值范围**： - COMMON：同时支持包周期和按需 - POST_PAID：后付费 - PRE_PAID：预付费 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：付费类型。表示服务器的计费模式。 **约束限制**：不涉及。 **取值范围**： - COMMON：同时支持包周期和按需 - POST_PAID：后付费 - PRE_PAID：预付费 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly ChargingModeEnum COMMON = new ChargingModeEnum("COMMON");

            /// <summary>
            /// Enum POST_PAID for value: POST_PAID
            /// </summary>
            public static readonly ChargingModeEnum POST_PAID = new ChargingModeEnum("POST_PAID");

            /// <summary>
            /// Enum PRE_PAID for value: PRE_PAID
            /// </summary>
            public static readonly ChargingModeEnum PRE_PAID = new ChargingModeEnum("PRE_PAID");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "COMMON", COMMON },
                { "POST_PAID", POST_PAID },
                { "PRE_PAID", PRE_PAID },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：订购周期类型。表示订购周期的时间单位。 **约束限制**：不涉及。 **取值范围**： - ABSOLUTE - DAY：天 - HOUR：小时 - MONTH：月 - WEEK：周 - YEAR：年 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：订购周期类型。表示订购周期的时间单位。 **约束限制**：不涉及。 **取值范围**： - ABSOLUTE - DAY：天 - HOUR：小时 - MONTH：月 - WEEK：周 - YEAR：年 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum ABSOLUTE for value: ABSOLUTE
            /// </summary>
            public static readonly PeriodTypeEnum ABSOLUTE = new PeriodTypeEnum("ABSOLUTE");

            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly PeriodTypeEnum DAY = new PeriodTypeEnum("DAY");

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly PeriodTypeEnum HOUR = new PeriodTypeEnum("HOUR");

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("MONTH");

            /// <summary>
            /// Enum WEEK for value: WEEK
            /// </summary>
            public static readonly PeriodTypeEnum WEEK = new PeriodTypeEnum("WEEK");

            /// <summary>
            /// Enum YEAR for value: YEAR
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("YEAR");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "ABSOLUTE", ABSOLUTE },
                { "DAY", DAY },
                { "HOUR", HOUR },
                { "MONTH", MONTH },
                { "WEEK", WEEK },
                { "YEAR", YEAR },
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
        /// **参数解释**：付费类型。表示服务器的计费模式。 **约束限制**：不涉及。 **取值范围**： - COMMON：同时支持包周期和按需 - POST_PAID：后付费 - PRE_PAID：预付费 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// **参数解释**：是否自动支付。表示是否开启自动支付功能。 **约束限制**：不涉及。 **取值范围**： - true：自动支付 - false：不自动支付 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }

        /// <summary>
        /// **参数解释**：是否自动续订。表示是否开启自动续订功能。 **约束限制**：不涉及。 **取值范围**： - true：自动续订 - false：不自动续订 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// **参数解释**：订购周期数量。表示订购周期的数量。 **约束限制**：不涉及。 **取值范围**：1 - 11 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// **参数解释**：订购周期类型。表示订购周期的时间单位。 **约束限制**：不涉及。 **取值范围**： - ABSOLUTE - DAY：天 - HOUR：小时 - MONTH：月 - WEEK：周 - YEAR：年 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargingInfo {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChargingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChargingInfo input)
        {
            if (input == null) return false;
            if (this.ChargingMode != input.ChargingMode) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.PeriodType != input.PeriodType) return false;

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
                hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
