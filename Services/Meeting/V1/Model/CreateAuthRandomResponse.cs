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
    /// Response Object
    /// </summary>
    public class CreateAuthRandomResponse : SdkResponse
    {
        /// <summary>
        /// 会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 
        /// </summary>
        /// <value>会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 </value>
        [JsonConverter(typeof(EnumClassConverter<ConfModeEnum>))]
        public class ConfModeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly ConfModeEnum COMMON = new ConfModeEnum("COMMON");

            /// <summary>
            /// Enum RTC for value: RTC
            /// </summary>
            public static readonly ConfModeEnum RTC = new ConfModeEnum("RTC");

            private static readonly Dictionary<string, ConfModeEnum> StaticFields =
            new Dictionary<string, ConfModeEnum>()
            {
                { "COMMON", COMMON },
                { "RTC", RTC },
            };

            private string _value;

            public ConfModeEnum()
            {

            }

            public ConfModeEnum(string value)
            {
                _value = value;
            }

            public static ConfModeEnum FromValue(string value)
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

                if (this.Equals(obj as ConfModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfModeEnum a, ConfModeEnum b)
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

            public static bool operator !=(ConfModeEnum a, ConfModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 鉴权随机数
        /// </summary>
        [JsonProperty("random", NullValueHandling = NullValueHandling.Ignore)]
        public string Random { get; set; }

        /// <summary>
        /// 会议主题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议类型模型。 * COMMON：MCU会议 * RTC：MMR会议 
        /// </summary>
        [JsonProperty("conf_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ConfModeEnum ConfMode { get; set; }
        /// <summary>
        /// 是否为网络研讨会
        /// </summary>
        [JsonProperty("webinar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Webinar { get; set; }

        /// <summary>
        /// 是否需要密码
        /// </summary>
        [JsonProperty("need_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedPassword { get; set; }

        /// <summary>
        /// 是否支持小程序
        /// </summary>
        [JsonProperty("support_applets", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportApplets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAuthRandomResponse {\n");
            sb.Append("  random: ").Append(Random).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  confMode: ").Append(ConfMode).Append("\n");
            sb.Append("  webinar: ").Append(Webinar).Append("\n");
            sb.Append("  needPassword: ").Append(NeedPassword).Append("\n");
            sb.Append("  supportApplets: ").Append(SupportApplets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAuthRandomResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAuthRandomResponse input)
        {
            if (input == null) return false;
            if (this.Random != input.Random || (this.Random != null && !this.Random.Equals(input.Random))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ConfMode != input.ConfMode) return false;
            if (this.Webinar != input.Webinar || (this.Webinar != null && !this.Webinar.Equals(input.Webinar))) return false;
            if (this.NeedPassword != input.NeedPassword || (this.NeedPassword != null && !this.NeedPassword.Equals(input.NeedPassword))) return false;
            if (this.SupportApplets != input.SupportApplets || (this.SupportApplets != null && !this.SupportApplets.Equals(input.SupportApplets))) return false;

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
                if (this.Random != null) hashCode = hashCode * 59 + this.Random.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.ConfMode.GetHashCode();
                if (this.Webinar != null) hashCode = hashCode * 59 + this.Webinar.GetHashCode();
                if (this.NeedPassword != null) hashCode = hashCode * 59 + this.NeedPassword.GetHashCode();
                if (this.SupportApplets != null) hashCode = hashCode * 59 + this.SupportApplets.GetHashCode();
                return hashCode;
            }
        }
    }
}
