using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 包周期创卷的计费策略参数。
    /// </summary>
    public class BssParamForCreateVolume 
    {
        /// <summary>
        /// 功能说明：计费模式。默认值为postPaid。 取值范围： * prePaid：包年包月 * postPaid：按需
        /// </summary>
        /// <value>功能说明：计费模式。默认值为postPaid。 取值范围： * prePaid：包年包月 * postPaid：按需</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly ChargingModeEnum POSTPAID = new ChargingModeEnum("postPaid");

            /// <summary>
            /// Enum PREPAID for value: prePaid
            /// </summary>
            public static readonly ChargingModeEnum PREPAID = new ChargingModeEnum("prePaid");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "postPaid", POSTPAID },
                { "prePaid", PREPAID },
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：是否立即支付。chargingMode为PrePaid时该参数会生效。默认值为false。 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 
        /// </summary>
        /// <value>功能说明：是否立即支付。chargingMode为PrePaid时该参数会生效。默认值为false。 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 </value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoPayEnum>))]
        public class IsAutoPayEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoPayEnum TRUE = new IsAutoPayEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoPayEnum FALSE = new IsAutoPayEnum("false");

            private static readonly Dictionary<string, IsAutoPayEnum> StaticFields =
            new Dictionary<string, IsAutoPayEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsAutoPayEnum()
            {

            }

            public IsAutoPayEnum(string value)
            {
                _value = value;
            }

            public static IsAutoPayEnum FromValue(string value)
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

                if (this.Equals(obj as IsAutoPayEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsAutoPayEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsAutoPayEnum a, IsAutoPayEnum b)
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

            public static bool operator !=(IsAutoPayEnum a, IsAutoPayEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：是否自动续订。chargingMode为prePaid时该参数会生效。默认值为false。 取值范围： * true：自动续订，自动续订周期与订购周期相同 * false：不自动续订 
        /// </summary>
        /// <value>功能说明：是否自动续订。chargingMode为prePaid时该参数会生效。默认值为false。 取值范围： * true：自动续订，自动续订周期与订购周期相同 * false：不自动续订 </value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoRenewEnum>))]
        public class IsAutoRenewEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoRenewEnum TRUE = new IsAutoRenewEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoRenewEnum FALSE = new IsAutoRenewEnum("false");

            private static readonly Dictionary<string, IsAutoRenewEnum> StaticFields =
            new Dictionary<string, IsAutoRenewEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsAutoRenewEnum()
            {

            }

            public IsAutoRenewEnum(string value)
            {
                _value = value;
            }

            public static IsAutoRenewEnum FromValue(string value)
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

                if (this.Equals(obj as IsAutoRenewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsAutoRenewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsAutoRenewEnum a, IsAutoRenewEnum b)
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

            public static bool operator !=(IsAutoRenewEnum a, IsAutoRenewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：订购周期单位。chargingMode为prePaid时该参数会生效，并且该参数为必选。 取值范围： * month：月 * year：年
        /// </summary>
        /// <value>功能说明：订购周期单位。chargingMode为prePaid时该参数会生效，并且该参数为必选。 取值范围： * month：月 * year：年</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum MONTH for value: month
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("month");

            /// <summary>
            /// Enum YEAR for value: year
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("year");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "month", MONTH },
                { "year", YEAR },
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
        /// 功能说明：计费模式。默认值为postPaid。 取值范围： * prePaid：包年包月 * postPaid：按需
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 功能说明：是否立即支付。chargingMode为PrePaid时该参数会生效。默认值为false。 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoPayEnum IsAutoPay { get; set; }
        /// <summary>
        /// 功能说明：是否自动续订。chargingMode为prePaid时该参数会生效。默认值为false。 取值范围： * true：自动续订，自动续订周期与订购周期相同 * false：不自动续订 
        /// </summary>
        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoRenewEnum IsAutoRenew { get; set; }
        /// <summary>
        /// 功能说明：订购周期数，chargingMode为prePaid时该参数会生效，并且该参数为为必选。 取值范围： * periodType为month时，为[1-9] * periodType为year时，为[1-1]
        /// </summary>
        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 功能说明：订购周期单位。chargingMode为prePaid时该参数会生效，并且该参数为必选。 取值范围： * month：月 * year：年
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BssParamForCreateVolume {\n");
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
            return this.Equals(input as BssParamForCreateVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BssParamForCreateVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
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
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
