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
    /// 包周期扩容计费策略参数。
    /// </summary>
    public class BssParamForResizeVolume 
    {
        /// <summary>
        /// 功能说明：是否立即支付。该参数只有在云硬盘为包周期的情况下有意义。默认值为false 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 
        /// </summary>
        /// <value>功能说明：是否立即支付。该参数只有在云硬盘为包周期的情况下有意义。默认值为false 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 </value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoPayEnum>))]
        public class IsAutoPayEnum
        {
            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoPayEnum FALSE = new IsAutoPayEnum("false");

            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoPayEnum TRUE = new IsAutoPayEnum("true");

            private static readonly Dictionary<string, IsAutoPayEnum> StaticFields =
            new Dictionary<string, IsAutoPayEnum>()
            {
                { "false", FALSE },
                { "true", TRUE },
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

            public static bool operator !=(IsAutoPayEnum a, IsAutoPayEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：是否立即支付。该参数只有在云硬盘为包周期的情况下有意义。默认值为false 取值范围： * true：立即支付，从帐户余额中自动扣费 * false：不立即支付，创建订单暂不支付 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoPayEnum IsAutoPay { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BssParamForResizeVolume {\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BssParamForResizeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BssParamForResizeVolume input)
        {
            if (input == null) return false;
            if (this.IsAutoPay != input.IsAutoPay) return false;

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
                hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
