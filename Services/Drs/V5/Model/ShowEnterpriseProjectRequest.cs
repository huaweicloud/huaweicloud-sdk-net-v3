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
    /// Request Object
    /// </summary>
    public class ShowEnterpriseProjectRequest 
    {
        /// <summary>
        /// 请求语言类型。
        /// </summary>
        /// <value>请求语言类型。</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "en-us", EN_US },
                { "zh-cn", ZH_CN },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 请求语言类型。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 偏移量，表示从此偏移量开始查询， offset 大于等于 0。默认为0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。默认为10，取值范围【1-1000】
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 企业项目名称，支持模糊搜索。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IAM用户所属帐号ID。op_service权限必须携带此参数，非op_service权限可不携带此参数。
        /// </summary>
        [SDKProperty("domain_id", IsQuery = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnterpriseProjectRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnterpriseProjectRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnterpriseProjectRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;

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
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
