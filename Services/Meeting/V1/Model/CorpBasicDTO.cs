using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 企业的基本信息。
    /// </summary>
    public class CorpBasicDTO 
    {
        /// <summary>
        /// 企业提示音语言设置,zh-CN或en-US。
        /// </summary>
        /// <value>企业提示音语言设置,zh-CN或en-US。</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-CN
            /// </summary>
            public static readonly LanguageEnum ZH_CN = new LanguageEnum("zh-CN");

            /// <summary>
            /// Enum EN_US for value: en-US
            /// </summary>
            public static readonly LanguageEnum EN_US = new LanguageEnum("en-US");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh-CN", ZH_CN },
                { "en-US", EN_US },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
            }

            public static LanguageEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业名称，格式必须满足^[^#%&amp;&#39;+;&lt;&gt;&#x3D;\\\&quot;&#39;？?\\\\\\\\……/]*$。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业域名。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 手机号，必须加上国家码，例如中国大陆手机+86xxxxxxx，当填写手机号时， “country”参数必填,手机格式必须满足(^$|^[+]?[0-9]+$)。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 传真号码,格式必须满足(^$|^[+]?[0-9]+$)。
        /// </summary>
        [JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        /// <summary>
        /// 邮箱地址,格式必须满足(^$|^[\\\\w-+]+(\\\\.[\\\\w-+]+)*@[\\\\w-]+(\\\\.[\\\\w-]+)*(\\\\.[\\\\w-]{1,})$)。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业归属的SP ID。仅在查询时返回。
        /// </summary>
        [JsonProperty("spId", NullValueHandling = NullValueHandling.Ignore)]
        public string SpId { get; set; }

        /// <summary>
        /// 企业提示音语言设置,zh-CN或en-US。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 时区Id设置,例如北京东8区timeZoneId值为56,时区Id和时区的对应关系请参考: [[时区表](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html)](tag:hws)[[时区表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html)](tag:hk) 。 
        /// </summary>
        [JsonProperty("timeZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorpBasicDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  fax: ").Append(Fax).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  spId: ").Append(SpId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  timeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CorpBasicDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CorpBasicDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Fax != input.Fax || (this.Fax != null && !this.Fax.Equals(input.Fax))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SpId != input.SpId || (this.SpId != null && !this.SpId.Equals(input.SpId))) return false;
            if (this.Language != input.Language) return false;
            if (this.TimeZoneId != input.TimeZoneId || (this.TimeZoneId != null && !this.TimeZoneId.Equals(input.TimeZoneId))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Fax != null) hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SpId != null) hashCode = hashCode * 59 + this.SpId.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TimeZoneId != null) hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
