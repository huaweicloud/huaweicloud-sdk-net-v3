using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OriginHostBody 
    {
        /// <summary>
        /// accelerate：选择加速域名作为回源host域名； customize：使用自定义的域名作为回源host域名；
        /// </summary>
        /// <value>accelerate：选择加速域名作为回源host域名； customize：使用自定义的域名作为回源host域名；</value>
        [JsonConverter(typeof(EnumClassConverter<OriginHostTypeEnum>))]
        public class OriginHostTypeEnum
        {
            /// <summary>
            /// Enum ACCELERATE for value: accelerate
            /// </summary>
            public static readonly OriginHostTypeEnum ACCELERATE = new OriginHostTypeEnum("accelerate");

            /// <summary>
            /// Enum CUSTOMIZE for value: customize
            /// </summary>
            public static readonly OriginHostTypeEnum CUSTOMIZE = new OriginHostTypeEnum("customize");

            private static readonly Dictionary<string, OriginHostTypeEnum> StaticFields =
            new Dictionary<string, OriginHostTypeEnum>()
            {
                { "accelerate", ACCELERATE },
                { "customize", CUSTOMIZE },
            };

            private string _value;

            public OriginHostTypeEnum()
            {

            }

            public OriginHostTypeEnum(string value)
            {
                _value = value;
            }

            public static OriginHostTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OriginHostTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginHostTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginHostTypeEnum a, OriginHostTypeEnum b)
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

            public static bool operator !=(OriginHostTypeEnum a, OriginHostTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// accelerate：选择加速域名作为回源host域名； customize：使用自定义的域名作为回源host域名；
        /// </summary>
        [JsonProperty("origin_host_type", NullValueHandling = NullValueHandling.Ignore)]
        public OriginHostTypeEnum OriginHostType { get; set; }
        /// <summary>
        /// 自定义回源域名，origin_host_type为 customize时传入该参数。
        /// </summary>
        [JsonProperty("customize_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomizeDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginHostBody {\n");
            sb.Append("  originHostType: ").Append(OriginHostType).Append("\n");
            sb.Append("  customizeDomain: ").Append(CustomizeDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OriginHostBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OriginHostBody input)
        {
            if (input == null) return false;
            if (this.OriginHostType != input.OriginHostType) return false;
            if (this.CustomizeDomain != input.CustomizeDomain || (this.CustomizeDomain != null && !this.CustomizeDomain.Equals(input.CustomizeDomain))) return false;

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
                hashCode = hashCode * 59 + this.OriginHostType.GetHashCode();
                if (this.CustomizeDomain != null) hashCode = hashCode * 59 + this.CustomizeDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
