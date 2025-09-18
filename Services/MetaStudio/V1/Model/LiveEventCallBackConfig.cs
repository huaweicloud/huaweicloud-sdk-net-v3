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
    /// 直播事件HTTPS回调通知配置
    /// </summary>
    public class LiveEventCallBackConfig 
    {
        /// <summary>
        /// **参数解释**： 认证类型。 **约束限制**： 不涉及。 **取值范围**： * NONE：URL中自带认证。 * MSS_A：HMACSHA256签名模式，在URL中追加参数hwSecret、hwTime。   取值方式：hwSecret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)&amp;hwTime&#x3D;hex(timestamp) * MSS_A_HEAD：HMACSHA256签名模式，参数hwSecret、hwTime放置在Head中。   取值方式：x-hw-mss-secret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)     x-hw-mss-time&#x3D;hex(timestamp) * MEITUAN_DEFAULT：仅用于美团平台调用回调使用。
        /// </summary>
        /// <value>**参数解释**： 认证类型。 **约束限制**： 不涉及。 **取值范围**： * NONE：URL中自带认证。 * MSS_A：HMACSHA256签名模式，在URL中追加参数hwSecret、hwTime。   取值方式：hwSecret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)&amp;hwTime&#x3D;hex(timestamp) * MSS_A_HEAD：HMACSHA256签名模式，参数hwSecret、hwTime放置在Head中。   取值方式：x-hw-mss-secret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)     x-hw-mss-time&#x3D;hex(timestamp) * MEITUAN_DEFAULT：仅用于美团平台调用回调使用。</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AuthTypeEnum NONE = new AuthTypeEnum("NONE");

            /// <summary>
            /// Enum MSS_A for value: MSS_A
            /// </summary>
            public static readonly AuthTypeEnum MSS_A = new AuthTypeEnum("MSS_A");

            /// <summary>
            /// Enum MSS_A_HEAD for value: MSS_A_HEAD
            /// </summary>
            public static readonly AuthTypeEnum MSS_A_HEAD = new AuthTypeEnum("MSS_A_HEAD");

            /// <summary>
            /// Enum MEITUAN_DEFAULT for value: MEITUAN_DEFAULT
            /// </summary>
            public static readonly AuthTypeEnum MEITUAN_DEFAULT = new AuthTypeEnum("MEITUAN_DEFAULT");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "NONE", NONE },
                { "MSS_A", MSS_A },
                { "MSS_A_HEAD", MSS_A_HEAD },
                { "MEITUAN_DEFAULT", MEITUAN_DEFAULT },
            };

            private string _value;

            public AuthTypeEnum()
            {

            }

            public AuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthTypeEnum a, AuthTypeEnum b)
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

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 直播事件回调地址，为https地址。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-2048位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("live_event_type_callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveEventTypeCallbackUrl { get; set; }

        /// <summary>
        /// **参数解释**： 认证类型。 **约束限制**： 不涉及。 **取值范围**： * NONE：URL中自带认证。 * MSS_A：HMACSHA256签名模式，在URL中追加参数hwSecret、hwTime。   取值方式：hwSecret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)&amp;hwTime&#x3D;hex(timestamp) * MSS_A_HEAD：HMACSHA256签名模式，参数hwSecret、hwTime放置在Head中。   取值方式：x-hw-mss-secret&#x3D;hmac_sha256(Key, URI（live_event_callback_url）+ hwTime)     x-hw-mss-time&#x3D;hex(timestamp) * MEITUAN_DEFAULT：仅用于美团平台调用回调使用。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// **参数解释**： 密钥Key。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**： 回调的直播事件类型列表。 **约束限制**： 不涉及。 **取值范围**： 当前仅支持如下取值： * SHOOT_SCRIPT_SWITCH：剧本段落切换事件。  * RTMP_STREAM_STATE_CHANGE：RTMP链接发生变化回调事件。 * REPLY_COMMAND_FINISH：回复播放完成通知。  回调事件结构体定义： * event_type：事件类型。 * message：事件描述。   - SHOOT_SCRIPT_SWITCH事件回调定义如下：     &#x60;&#x60;&#x60;json     {       \&quot;event_type\&quot;:  \&quot;SHOOT_SCRIPT_SWITCH\&quot;,       \&quot;message\&quot;:\&quot;{\\\&quot;room_id\\\&quot;:\\\&quot;26f065244f754b3aa853b649a21aaf66\\\&quot;,\\\&quot;job_id\\\&quot;:\\\&quot;e87104f76d7546ce8a46ac6b04c49c3c\\\&quot;,\\\&quot;scene_script_name\\\&quot;:\\\&quot;商品1\\\&quot;,\\\&quot;shoot_script_sequence_no\\\&quot;:\\\&quot;2\\\&quot;,\\\&quot;shoot_script_title\\\&quot;:\\\&quot;段落2\\\&quot;}\&quot;     }     &#x60;&#x60;&#x60;   - RTMP_STREAM_STATE_CHANGE回调定义如下：     &#x60;&#x60;&#x60;json     {       \&quot;event_type\&quot;:  \&quot;RTMP_STREAM_STATE_CHANGE\&quot;,       \&quot;message\&quot;:\&quot;{\\\&quot;room_id\\\&quot;:\\\&quot;26f065244f754b3aa853b649a21aaf66\\\&quot;,\\\&quot;job_id\\\&quot;:\\\&quot;e87104f76d7546ce8a46ac6b04c49c3c\\\&quot;,\\\&quot;output_url\\\&quot;:\\\&quot;rtmp://xxx/xx/xx\\\&quot;,\\\&quot;stream_key\\\&quot;:\\\&quot;xxxxx\\\&quot;,\\\&quot;state\\\&quot;:\\\&quot;CONNECTED\\\&quot;}\&quot;     }     &#x60;&#x60;&#x60;     其中state取值：CONNECTING链路连接中；CONNECTED链路已连接；DISCONNECTED链路已断开，RECONNECTING链路重连中；END联络不再重连，链路已结束。    - REPLY_COMMAND_FINISH回调定义如下：     &#x60;&#x60;&#x60;json     {       \&quot;event_type\&quot;:  \&quot;REPLY_COMMAND_FINISH\&quot;,       \&quot;message\&quot;:\&quot;{\\\&quot;room_id\\\&quot;:\\\&quot;26f065244f754b3aa853b649a21aaf66\\\&quot;,\\\&quot;job_id\\\&quot;:\\\&quot;e87104f76d7546ce8a46ac6b04c49c3c\\\&quot;,\\\&quot;reply_id\\\&quot;:\\\&quot;e87104f76d7546ce8a46ac6b04c49c3c\&quot;}\&quot;     }
        /// </summary>
        [JsonProperty("callback_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CallbackEventType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveEventCallBackConfig {\n");
            sb.Append("  liveEventTypeCallbackUrl: ").Append(LiveEventTypeCallbackUrl).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  callbackEventType: ").Append(CallbackEventType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveEventCallBackConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveEventCallBackConfig input)
        {
            if (input == null) return false;
            if (this.LiveEventTypeCallbackUrl != input.LiveEventTypeCallbackUrl || (this.LiveEventTypeCallbackUrl != null && !this.LiveEventTypeCallbackUrl.Equals(input.LiveEventTypeCallbackUrl))) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.CallbackEventType != input.CallbackEventType || (this.CallbackEventType != null && input.CallbackEventType != null && !this.CallbackEventType.SequenceEqual(input.CallbackEventType))) return false;

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
                if (this.LiveEventTypeCallbackUrl != null) hashCode = hashCode * 59 + this.LiveEventTypeCallbackUrl.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.CallbackEventType != null) hashCode = hashCode * 59 + this.CallbackEventType.GetHashCode();
                return hashCode;
            }
        }
    }
}
