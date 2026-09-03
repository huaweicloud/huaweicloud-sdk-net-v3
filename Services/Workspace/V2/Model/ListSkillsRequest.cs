using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSkillsRequest 
    {
        /// <summary>
        /// 语言，用于国际化。 - en-us：英文 - zh-cn：中文
        /// </summary>
        /// <value>语言，用于国际化。 - en-us：英文 - zh-cn：中文</value>
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言，用于国际化。 - en-us：英文 - zh-cn：中文
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 偏移量，默认0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页大小，默认20。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 技能分类。
        /// </summary>
        [SDKProperty("category", IsQuery = true)]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 技能状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 技能名称（模糊匹配slug、display_name和alias_name）。
        /// </summary>
        [SDKProperty("skill_name", IsQuery = true)]
        [JsonProperty("skill_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSkillsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  skillName: ").Append(SkillName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSkillsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSkillsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SkillName != input.SkillName || (this.SkillName != null && !this.SkillName.Equals(input.SkillName))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SkillName != null) hashCode = hashCode * 59 + this.SkillName.GetHashCode();
                return hashCode;
            }
        }
    }
}
