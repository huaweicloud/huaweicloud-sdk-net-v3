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
    /// Response Object
    /// </summary>
    public class SignAgreementResponse : SdkResponse
    {
        /// <summary>
        /// 重新签署过期处理方式:EXPIRE_AUTO_AGREE 自动签署协议,EXPIRE_STOP_SERVICE 强制签署协议
        /// </summary>
        /// <value>重新签署过期处理方式:EXPIRE_AUTO_AGREE 自动签署协议,EXPIRE_STOP_SERVICE 强制签署协议</value>
        [JsonConverter(typeof(EnumClassConverter<ResignExpireProcessModeEnum>))]
        public class ResignExpireProcessModeEnum
        {
            /// <summary>
            /// Enum EXPIRE_AUTO_AGREE for value: EXPIRE_AUTO_AGREE
            /// </summary>
            public static readonly ResignExpireProcessModeEnum EXPIRE_AUTO_AGREE = new ResignExpireProcessModeEnum("EXPIRE_AUTO_AGREE");

            /// <summary>
            /// Enum EXPIRE_STOP_SERVICE for value: EXPIRE_STOP_SERVICE
            /// </summary>
            public static readonly ResignExpireProcessModeEnum EXPIRE_STOP_SERVICE = new ResignExpireProcessModeEnum("EXPIRE_STOP_SERVICE");

            private static readonly Dictionary<string, ResignExpireProcessModeEnum> StaticFields =
            new Dictionary<string, ResignExpireProcessModeEnum>()
            {
                { "EXPIRE_AUTO_AGREE", EXPIRE_AUTO_AGREE },
                { "EXPIRE_STOP_SERVICE", EXPIRE_STOP_SERVICE },
            };

            private string _value;

            public ResignExpireProcessModeEnum()
            {

            }

            public ResignExpireProcessModeEnum(string value)
            {
                _value = value;
            }

            public static ResignExpireProcessModeEnum FromValue(string value)
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

                if (this.Equals(obj as ResignExpireProcessModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResignExpireProcessModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResignExpireProcessModeEnum a, ResignExpireProcessModeEnum b)
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

            public static bool operator !=(ResignExpireProcessModeEnum a, ResignExpireProcessModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 当前服务协议版本
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 是否需要签署
        /// </summary>
        [JsonProperty("need_to_sign", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedToSign { get; set; }

        /// <summary>
        /// 签署服务协议版本
        /// </summary>
        [JsonProperty("signed_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SignedVersion { get; set; }

        /// <summary>
        /// 协议签署时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [JsonProperty("signed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SignedTime { get; set; }

        /// <summary>
        /// 签署最后期限。格式遵循：RFC 3339 如\&quot;2024-10-10T15:59:59Z\&quot;
        /// </summary>
        [JsonProperty("resign_deadline", NullValueHandling = NullValueHandling.Ignore)]
        public string ResignDeadline { get; set; }

        /// <summary>
        /// 重新签署过期处理方式:EXPIRE_AUTO_AGREE 自动签署协议,EXPIRE_STOP_SERVICE 强制签署协议
        /// </summary>
        [JsonProperty("resign_expire_process_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ResignExpireProcessModeEnum ResignExpireProcessMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignAgreementResponse {\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  needToSign: ").Append(NeedToSign).Append("\n");
            sb.Append("  signedVersion: ").Append(SignedVersion).Append("\n");
            sb.Append("  signedTime: ").Append(SignedTime).Append("\n");
            sb.Append("  resignDeadline: ").Append(ResignDeadline).Append("\n");
            sb.Append("  resignExpireProcessMode: ").Append(ResignExpireProcessMode).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SignAgreementResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SignAgreementResponse input)
        {
            if (input == null) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.NeedToSign != input.NeedToSign || (this.NeedToSign != null && !this.NeedToSign.Equals(input.NeedToSign))) return false;
            if (this.SignedVersion != input.SignedVersion || (this.SignedVersion != null && !this.SignedVersion.Equals(input.SignedVersion))) return false;
            if (this.SignedTime != input.SignedTime || (this.SignedTime != null && !this.SignedTime.Equals(input.SignedTime))) return false;
            if (this.ResignDeadline != input.ResignDeadline || (this.ResignDeadline != null && !this.ResignDeadline.Equals(input.ResignDeadline))) return false;
            if (this.ResignExpireProcessMode != input.ResignExpireProcessMode) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.NeedToSign != null) hashCode = hashCode * 59 + this.NeedToSign.GetHashCode();
                if (this.SignedVersion != null) hashCode = hashCode * 59 + this.SignedVersion.GetHashCode();
                if (this.SignedTime != null) hashCode = hashCode * 59 + this.SignedTime.GetHashCode();
                if (this.ResignDeadline != null) hashCode = hashCode * 59 + this.ResignDeadline.GetHashCode();
                hashCode = hashCode * 59 + this.ResignExpireProcessMode.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
