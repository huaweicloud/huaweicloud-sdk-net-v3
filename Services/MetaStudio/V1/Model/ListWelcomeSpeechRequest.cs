using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWelcomeSpeechRequest 
    {
        /// <summary>
        /// 智能交互语言  * CN:中文  * EN:英文  * ESP：西班牙语（仅海外站点支持）  * por：葡萄牙语（仅海外站点支持）  * Arabic：阿拉伯语（仅海外站点支持）  * Thai：泰语（仅海外站点支持）
        /// </summary>
        /// <value>智能交互语言  * CN:中文  * EN:英文  * ESP：西班牙语（仅海外站点支持）  * por：葡萄牙语（仅海外站点支持）  * Arabic：阿拉伯语（仅海外站点支持）  * Thai：泰语（仅海外站点支持）</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            public static readonly LanguageEnum CN = new LanguageEnum("CN");

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            public static readonly LanguageEnum EN = new LanguageEnum("EN");

            /// <summary>
            /// Enum ESP for value: ESP
            /// </summary>
            public static readonly LanguageEnum ESP = new LanguageEnum("ESP");

            /// <summary>
            /// Enum POR for value: por
            /// </summary>
            public static readonly LanguageEnum POR = new LanguageEnum("por");

            /// <summary>
            /// Enum ARABIC for value: Arabic
            /// </summary>
            public static readonly LanguageEnum ARABIC = new LanguageEnum("Arabic");

            /// <summary>
            /// Enum THAI for value: Thai
            /// </summary>
            public static readonly LanguageEnum THAI = new LanguageEnum("Thai");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "CN", CN },
                { "EN", EN },
                { "ESP", ESP },
                { "por", POR },
                { "Arabic", ARABIC },
                { "Thai", THAI },
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息。
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [SDKProperty("robot_id", IsQuery = true)]
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 智能交互语言  * CN:中文  * EN:英文  * ESP：西班牙语（仅海外站点支持）  * por：葡萄牙语（仅海外站点支持）  * Arabic：阿拉伯语（仅海外站点支持）  * Thai：泰语（仅海外站点支持）
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWelcomeSpeechRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWelcomeSpeechRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWelcomeSpeechRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
