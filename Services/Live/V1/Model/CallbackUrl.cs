using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CallbackUrl 
    {
        /// <summary>
        /// 接收回调通知服务器所在区域。 包含如下取值： - mainland_china：中国大陆区域。 - outside_mainland_china：中国大陆以外区域。
        /// </summary>
        /// <value>接收回调通知服务器所在区域。 包含如下取值： - mainland_china：中国大陆区域。 - outside_mainland_china：中国大陆以外区域。</value>
        [JsonConverter(typeof(EnumClassConverter<CallBackAreaEnum>))]
        public class CallBackAreaEnum
        {
            /// <summary>
            /// Enum MAINLAND_CHINA for value: mainland_china
            /// </summary>
            public static readonly CallBackAreaEnum MAINLAND_CHINA = new CallBackAreaEnum("mainland_china");

            /// <summary>
            /// Enum OUTSIDE_MAINLAND_CHINA for value: outside_mainland_china
            /// </summary>
            public static readonly CallBackAreaEnum OUTSIDE_MAINLAND_CHINA = new CallBackAreaEnum("outside_mainland_china");

            private static readonly Dictionary<string, CallBackAreaEnum> StaticFields =
            new Dictionary<string, CallBackAreaEnum>()
            {
                { "mainland_china", MAINLAND_CHINA },
                { "outside_mainland_china", OUTSIDE_MAINLAND_CHINA },
            };

            private string _value;

            public CallBackAreaEnum()
            {

            }

            public CallBackAreaEnum(string value)
            {
                _value = value;
            }

            public static CallBackAreaEnum FromValue(string value)
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

                if (this.Equals(obj as CallBackAreaEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CallBackAreaEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CallBackAreaEnum a, CallBackAreaEnum b)
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

            public static bool operator !=(CallBackAreaEnum a, CallBackAreaEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 鉴权密钥
        /// </summary>
        [JsonProperty("auth_sign_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthSignKey { get; set; }

        /// <summary>
        /// 接收回调通知服务器所在区域。 包含如下取值： - mainland_china：中国大陆区域。 - outside_mainland_china：中国大陆以外区域。
        /// </summary>
        [JsonProperty("call_back_area", NullValueHandling = NullValueHandling.Ignore)]
        public CallBackAreaEnum CallBackArea { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallbackUrl {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  authSignKey: ").Append(AuthSignKey).Append("\n");
            sb.Append("  callBackArea: ").Append(CallBackArea).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CallbackUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CallbackUrl input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.AuthSignKey != input.AuthSignKey || (this.AuthSignKey != null && !this.AuthSignKey.Equals(input.AuthSignKey))) return false;
            if (this.CallBackArea != input.CallBackArea) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthSignKey != null) hashCode = hashCode * 59 + this.AuthSignKey.GetHashCode();
                hashCode = hashCode * 59 + this.CallBackArea.GetHashCode();
                return hashCode;
            }
        }
    }
}
