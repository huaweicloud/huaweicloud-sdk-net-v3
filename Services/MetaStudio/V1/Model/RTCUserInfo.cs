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
    /// 接入RTC的用户信息。
    /// </summary>
    public class RTCUserInfo 
    {
        /// <summary>
        /// 用户类型。 * CAPTURE: 直播助手，将摄像头获取视频流推送到RTC房间 * ANIMATION: VDS服务，从RTC房间拉视频流生成动作数据 * RENDER: 渲染服务，将动作数据渲染成数字人动画 * PLAYER: 普通观看方，可选择原始视频流或者数字人动画视频流观看 * INFERENCE_USER: 数字人推理端用户。从RTC房间接收音频流，并推送视频流到RTC房间 * END_USER: 端侧用户。从推送音频流到RTC房间，并从RTC房间接收视频流
        /// </summary>
        /// <value>用户类型。 * CAPTURE: 直播助手，将摄像头获取视频流推送到RTC房间 * ANIMATION: VDS服务，从RTC房间拉视频流生成动作数据 * RENDER: 渲染服务，将动作数据渲染成数字人动画 * PLAYER: 普通观看方，可选择原始视频流或者数字人动画视频流观看 * INFERENCE_USER: 数字人推理端用户。从RTC房间接收音频流，并推送视频流到RTC房间 * END_USER: 端侧用户。从推送音频流到RTC房间，并从RTC房间接收视频流</value>
        [JsonConverter(typeof(EnumClassConverter<UserTypeEnum>))]
        public class UserTypeEnum
        {
            /// <summary>
            /// Enum CAPTURE for value: CAPTURE
            /// </summary>
            public static readonly UserTypeEnum CAPTURE = new UserTypeEnum("CAPTURE");

            /// <summary>
            /// Enum ANIMATION for value: ANIMATION
            /// </summary>
            public static readonly UserTypeEnum ANIMATION = new UserTypeEnum("ANIMATION");

            /// <summary>
            /// Enum RENDER for value: RENDER
            /// </summary>
            public static readonly UserTypeEnum RENDER = new UserTypeEnum("RENDER");

            /// <summary>
            /// Enum PLAYER for value: PLAYER
            /// </summary>
            public static readonly UserTypeEnum PLAYER = new UserTypeEnum("PLAYER");

            /// <summary>
            /// Enum INFERENCE_USER for value: INFERENCE_USER
            /// </summary>
            public static readonly UserTypeEnum INFERENCE_USER = new UserTypeEnum("INFERENCE_USER");

            /// <summary>
            /// Enum END_USER for value: END_USER
            /// </summary>
            public static readonly UserTypeEnum END_USER = new UserTypeEnum("END_USER");

            private static readonly Dictionary<string, UserTypeEnum> StaticFields =
            new Dictionary<string, UserTypeEnum>()
            {
                { "CAPTURE", CAPTURE },
                { "ANIMATION", ANIMATION },
                { "RENDER", RENDER },
                { "PLAYER", PLAYER },
                { "INFERENCE_USER", INFERENCE_USER },
                { "END_USER", END_USER },
            };

            private string _value;

            public UserTypeEnum()
            {

            }

            public UserTypeEnum(string value)
            {
                _value = value;
            }

            public static UserTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UserTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UserTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UserTypeEnum a, UserTypeEnum b)
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

            public static bool operator !=(UserTypeEnum a, UserTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户类型。 * CAPTURE: 直播助手，将摄像头获取视频流推送到RTC房间 * ANIMATION: VDS服务，从RTC房间拉视频流生成动作数据 * RENDER: 渲染服务，将动作数据渲染成数字人动画 * PLAYER: 普通观看方，可选择原始视频流或者数字人动画视频流观看 * INFERENCE_USER: 数字人推理端用户。从RTC房间接收音频流，并推送视频流到RTC房间 * END_USER: 端侧用户。从推送音频流到RTC房间，并从RTC房间接收视频流
        /// </summary>
        [JsonProperty("user_type", NullValueHandling = NullValueHandling.Ignore)]
        public UserTypeEnum UserType { get; set; }
        /// <summary>
        /// RTC用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// RTC鉴权token。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// 有效期。时间戳，单位：秒。
        /// </summary>
        [JsonProperty("ctime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ctime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RTCUserInfo {\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  ctime: ").Append(Ctime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RTCUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RTCUserInfo input)
        {
            if (input == null) return false;
            if (this.UserType != input.UserType) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.Ctime != input.Ctime || (this.Ctime != null && !this.Ctime.Equals(input.Ctime))) return false;

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
                hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Ctime != null) hashCode = hashCode * 59 + this.Ctime.GetHashCode();
                return hashCode;
            }
        }
    }
}
