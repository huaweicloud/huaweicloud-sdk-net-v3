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
    public class ShowCommonSkillPackageRequest 
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
        /// 技能标识。
        /// </summary>
        [SDKProperty("skill_id", IsPath = true)]
        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        /// <summary>
        /// 技能包标识。
        /// </summary>
        [SDKProperty("package_id", IsPath = true)]
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCommonSkillPackageRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  skillId: ").Append(SkillId).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCommonSkillPackageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCommonSkillPackageRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.SkillId != input.SkillId || (this.SkillId != null && !this.SkillId.Equals(input.SkillId))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;

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
                if (this.SkillId != null) hashCode = hashCode * 59 + this.SkillId.GetHashCode();
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
