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
    /// Response Object
    /// </summary>
    public class EstimateExecutionPlanPriceResponse : SdkResponse
    {
        /// <summary>
        /// 币种，枚举值   * &#x60;CNY&#x60; - 元，中国站返回的币种   * &#x60;USD&#x60; - 美元，国际站返回的币种 
        /// </summary>
        /// <value>币种，枚举值   * &#x60;CNY&#x60; - 元，中国站返回的币种   * &#x60;USD&#x60; - 美元，国际站返回的币种 </value>
        [JsonConverter(typeof(EnumClassConverter<CurrencyEnum>))]
        public class CurrencyEnum
        {
            /// <summary>
            /// Enum CNY for value: CNY
            /// </summary>
            public static readonly CurrencyEnum CNY = new CurrencyEnum("CNY");

            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            public static readonly CurrencyEnum USD = new CurrencyEnum("USD");

            private static readonly Dictionary<string, CurrencyEnum> StaticFields =
            new Dictionary<string, CurrencyEnum>()
            {
                { "CNY", CNY },
                { "USD", USD },
            };

            private string _value;

            public CurrencyEnum()
            {

            }

            public CurrencyEnum(string value)
            {
                _value = value;
            }

            public static CurrencyEnum FromValue(string value)
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

                if (this.Equals(obj as CurrencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CurrencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CurrencyEnum a, CurrencyEnum b)
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

            public static bool operator !=(CurrencyEnum a, CurrencyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 币种，枚举值   * &#x60;CNY&#x60; - 元，中国站返回的币种   * &#x60;USD&#x60; - 美元，国际站返回的币种 
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// 执行计划中所有资源的询价结果
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemsResponse> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateExecutionPlanPriceResponse {\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateExecutionPlanPriceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EstimateExecutionPlanPriceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
