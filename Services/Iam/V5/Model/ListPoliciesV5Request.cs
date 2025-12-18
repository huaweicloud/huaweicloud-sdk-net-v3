using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPoliciesV5Request 
    {
        /// <summary>
        /// 身份策略类型，可以为“自定义”（custom）或“系统预置”（system）。
        /// </summary>
        /// <value>身份策略类型，可以为“自定义”（custom）或“系统预置”（system）。</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyTypeEnum>))]
        public class PolicyTypeEnum
        {
            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly PolicyTypeEnum CUSTOM = new PolicyTypeEnum("custom");

            /// <summary>
            /// Enum SYSTEM for value: system
            /// </summary>
            public static readonly PolicyTypeEnum SYSTEM = new PolicyTypeEnum("system");

            private static readonly Dictionary<string, PolicyTypeEnum> StaticFields =
            new Dictionary<string, PolicyTypeEnum>()
            {
                { "custom", CUSTOM },
                { "system", SYSTEM },
            };

            private string _value;

            public PolicyTypeEnum()
            {

            }

            public PolicyTypeEnum(string value)
            {
                _value = value;
            }

            public static PolicyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PolicyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PolicyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PolicyTypeEnum a, PolicyTypeEnum b)
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

            public static bool operator !=(PolicyTypeEnum a, PolicyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 选择接口返回的信息的语言，可以为中文（\&quot;zh-cn\&quot;）或英文（\&quot;en-us\&quot;），默认为中文。
        /// </summary>
        /// <value>选择接口返回的信息的语言，可以为中文（\&quot;zh-cn\&quot;）或英文（\&quot;en-us\&quot;），默认为中文。</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
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
        /// 每页显示的条目数量，范围为1到200条，默认为100条。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页标记，长度为4到400个字符，只包含字母、数字、\&quot;+\&quot;、\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;-\&quot;和\&quot;_\&quot;的字符串。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 身份策略类型，可以为“自定义”（custom）或“系统预置”（system）。
        /// </summary>
        [SDKProperty("policy_type", IsQuery = true)]
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTypeEnum PolicyType { get; set; }
        /// <summary>
        /// 资源路径前缀，由若干段字符串拼接而成，每段先包含一个或多个字母、数字、\&quot;.\&quot;、\&quot;,\&quot;、\&quot;+\&quot;、\&quot;@\&quot;、\&quot;&#x3D;\&quot;、\&quot;_\&quot;或\&quot;-\&quot;，并以\&quot;/\&quot;结尾，例如\&quot;foo/bar/\&quot;。
        /// </summary>
        [SDKProperty("path_prefix", IsQuery = true)]
        [JsonProperty("path_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// 是否仅列举存在附加实体的身份策略。
        /// </summary>
        [SDKProperty("only_attached", IsQuery = true)]
        [JsonProperty("only_attached", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAttached { get; set; }

        /// <summary>
        /// 选择接口返回的信息的语言，可以为中文（\&quot;zh-cn\&quot;）或英文（\&quot;en-us\&quot;），默认为中文。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoliciesV5Request {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("  pathPrefix: ").Append(PathPrefix).Append("\n");
            sb.Append("  onlyAttached: ").Append(OnlyAttached).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoliciesV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoliciesV5Request input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PolicyType != input.PolicyType) return false;
            if (this.PathPrefix != input.PathPrefix || (this.PathPrefix != null && !this.PathPrefix.Equals(input.PathPrefix))) return false;
            if (this.OnlyAttached != input.OnlyAttached || (this.OnlyAttached != null && !this.OnlyAttached.Equals(input.OnlyAttached))) return false;
            if (this.XLanguage != input.XLanguage) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.PathPrefix != null) hashCode = hashCode * 59 + this.PathPrefix.GetHashCode();
                if (this.OnlyAttached != null) hashCode = hashCode * 59 + this.OnlyAttached.GetHashCode();
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
