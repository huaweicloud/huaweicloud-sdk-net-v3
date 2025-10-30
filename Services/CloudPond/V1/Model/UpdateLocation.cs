using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 场地信息
    /// </summary>
    public class UpdateLocation 
    {
        /// <summary>
        /// 场地所在国家
        /// </summary>
        /// <value>场地所在国家</value>
        [JsonConverter(typeof(EnumClassConverter<CountryEnum>))]
        public class CountryEnum
        {
            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            public static readonly CountryEnum CN = new CountryEnum("CN");

            private static readonly Dictionary<string, CountryEnum> StaticFields =
            new Dictionary<string, CountryEnum>()
            {
                { "CN", CN },
            };

            private string _value;

            public CountryEnum()
            {

            }

            public CountryEnum(string value)
            {
                _value = value;
            }

            public static CountryEnum FromValue(string value)
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

                if (this.Equals(obj as CountryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CountryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CountryEnum a, CountryEnum b)
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

            public static bool operator !=(CountryEnum a, CountryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 场地名称（已废弃），传入该参数不会再生效，新建站点也不会再返回该字段
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 场地所在国家
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public CountryEnum Country { get; set; }
        /// <summary>
        /// 场地所在省/自治区/直辖市
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 场地所在市/区
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 场地所在区/县
        /// </summary>
        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string District { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCondition Condition { get; set; }

        /// <summary>
        /// 场地描述，最大支持长度为255个字节，不允许包含&lt;&gt;
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLocation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("  city: ").Append(City).Append("\n");
            sb.Append("  district: ").Append(District).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLocation input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Country != input.Country) return false;
            if (this.Province != input.Province || (this.Province != null && !this.Province.Equals(input.Province))) return false;
            if (this.City != input.City || (this.City != null && !this.City.Equals(input.City))) return false;
            if (this.District != input.District || (this.District != null && !this.District.Equals(input.District))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Province != null) hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.City != null) hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.District != null) hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
