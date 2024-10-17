using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MarketModel 
    {
        /// <summary>
        /// 计费类型
        /// </summary>
        /// <value>计费类型</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum SPOT for value: spot
            /// </summary>
            public static readonly ChargeModeEnum SPOT = new ChargeModeEnum("spot");

            /// <summary>
            /// Enum PREPAID for value: prepaid
            /// </summary>
            public static readonly ChargeModeEnum PREPAID = new ChargeModeEnum("prepaid");

            /// <summary>
            /// Enum POSTPAID for value: postpaid
            /// </summary>
            public static readonly ChargeModeEnum POSTPAID = new ChargeModeEnum("postpaid");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "spot", SPOT },
                { "prepaid", PREPAID },
                { "postpaid", POSTPAID },
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
        /// 计费类型
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_info", NullValueHandling = NullValueHandling.Ignore)]
        public MarketModelPrepaidInfo PrepaidInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketModel {\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  prepaidInfo: ").Append(PrepaidInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarketModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MarketModel input)
        {
            if (input == null) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.PrepaidInfo != input.PrepaidInfo || (this.PrepaidInfo != null && !this.PrepaidInfo.Equals(input.PrepaidInfo))) return false;

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
                if (this.PrepaidInfo != null) hashCode = hashCode * 59 + this.PrepaidInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
