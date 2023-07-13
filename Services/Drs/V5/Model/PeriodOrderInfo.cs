using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 包年/包月信息体。
    /// </summary>
    public class PeriodOrderInfo 
    {
        /// <summary>
        /// 订购周期类型。取值： - 2：月。 - 3：年。
        /// </summary>
        /// <value>订购周期类型。取值： - 2：月。 - 3：年。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly PeriodTypeEnum NUMBER_2 = new PeriodTypeEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly PeriodTypeEnum NUMBER_3 = new PeriodTypeEnum(3);

            private static readonly Dictionary<int?, PeriodTypeEnum> StaticFields =
            new Dictionary<int?, PeriodTypeEnum>()
            {
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public PeriodTypeEnum()
            {

            }

            public PeriodTypeEnum(int? value)
            {
                _value = value;
            }

            public static PeriodTypeEnum FromValue(int? value)
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

            public int? GetValue()
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
        /// 是否自动续订。取值： - 0：否（默认值，需要客户手动去支付）。 - 1：是（自动支付）。
        /// </summary>
        /// <value>是否自动续订。取值： - 0：否（默认值，需要客户手动去支付）。 - 1：是（自动支付）。</value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoRenewEnum>))]
        public class IsAutoRenewEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly IsAutoRenewEnum NUMBER_0 = new IsAutoRenewEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly IsAutoRenewEnum NUMBER_1 = new IsAutoRenewEnum(1);

            private static readonly Dictionary<int?, IsAutoRenewEnum> StaticFields =
            new Dictionary<int?, IsAutoRenewEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public IsAutoRenewEnum()
            {

            }

            public IsAutoRenewEnum(int? value)
            {
                _value = value;
            }

            public static IsAutoRenewEnum FromValue(int? value)
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

            public int? GetValue()
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
        /// 订购周期类型。取值： - 2：月。 - 3：年。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 订购周期数。根据period_type取值不同，代表不同周期数，例如： - 当period_type为2时，period_num为1代表1月。 - 当period_type为3时，period_num为1代表1年。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订。取值： - 0：否（默认值，需要客户手动去支付）。 - 1：是（自动支付）。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoRenewEnum IsAutoRenew { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeriodOrderInfo {\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeriodOrderInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeriodOrderInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
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
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                return hashCode;
            }
        }
    }
}
