using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListProvidersRequest 
    {
        /// <summary>
        /// 指定显示语言
        /// </summary>
        /// <value>指定显示语言</value>
        [JsonConverter(typeof(EnumClassConverter<LocaleEnum>))]
        public class LocaleEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly LocaleEnum ZH_CN = new LocaleEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly LocaleEnum EN_US = new LocaleEnum("en-us");

            private static readonly Dictionary<string, LocaleEnum> StaticFields =
            new Dictionary<string, LocaleEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public LocaleEnum()
            {

            }

            public LocaleEnum(string value)
            {
                _value = value;
            }

            public static LocaleEnum FromValue(string value)
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

                if (this.Equals(obj as LocaleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LocaleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LocaleEnum a, LocaleEnum b)
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

            public static bool operator !=(LocaleEnum a, LocaleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定显示语言
        /// </summary>
        [SDKProperty("locale", IsQuery = true)]
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public LocaleEnum Locale { get; set; }
        /// <summary>
        /// 查询记录数默认为10，limit最多为200，最小值为1。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 索引位置，从offset指定的下一条数据开始查询，必须为数字，不能为负数，默认为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 云服务名称
        /// </summary>
        [SDKProperty("provider", IsQuery = true)]
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProvidersRequest {\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProvidersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProvidersRequest input)
        {
            if (input == null) return false;
            if (this.Locale != input.Locale) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;

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
                hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                return hashCode;
            }
        }
    }
}
