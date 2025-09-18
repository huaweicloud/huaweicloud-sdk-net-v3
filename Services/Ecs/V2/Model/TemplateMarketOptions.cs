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
    /// 计费条件
    /// </summary>
    public class TemplateMarketOptions 
    {
        /// <summary>
        /// 计费类型
        /// </summary>
        /// <value>计费类型</value>
        [JsonConverter(typeof(EnumClassConverter<MarketTypeEnum>))]
        public class MarketTypeEnum
        {
            /// <summary>
            /// Enum SPOT for value: spot
            /// </summary>
            public static readonly MarketTypeEnum SPOT = new MarketTypeEnum("spot");

            /// <summary>
            /// Enum POSTPAID for value: postpaid
            /// </summary>
            public static readonly MarketTypeEnum POSTPAID = new MarketTypeEnum("postpaid");

            private static readonly Dictionary<string, MarketTypeEnum> StaticFields =
            new Dictionary<string, MarketTypeEnum>()
            {
                { "spot", SPOT },
                { "postpaid", POSTPAID },
            };

            private string _value;

            public MarketTypeEnum()
            {

            }

            public MarketTypeEnum(string value)
            {
                _value = value;
            }

            public static MarketTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MarketTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MarketTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MarketTypeEnum a, MarketTypeEnum b)
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

            public static bool operator !=(MarketTypeEnum a, MarketTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("market_type", NullValueHandling = NullValueHandling.Ignore)]
        public MarketTypeEnum MarketType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spot_options", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateSpotOptions SpotOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateMarketOptions {\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("  spotOptions: ").Append(SpotOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateMarketOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateMarketOptions input)
        {
            if (input == null) return false;
            if (this.MarketType != input.MarketType) return false;
            if (this.SpotOptions != input.SpotOptions || (this.SpotOptions != null && !this.SpotOptions.Equals(input.SpotOptions))) return false;

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
                hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.SpotOptions != null) hashCode = hashCode * 59 + this.SpotOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
