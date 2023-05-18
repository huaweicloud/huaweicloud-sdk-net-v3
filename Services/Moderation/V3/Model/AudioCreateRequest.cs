using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 音频内容审核请求体
    /// </summary>
    public class AudioCreateRequest 
    {
        /// <summary>
        /// 事件类型，可选值如下： default：默认事件 audiobook：有声书 education：教育音频 game：游戏语音房 live：秀场直播 ecommerce：电商直播 voiceroom：交友语音房 private：私密语音聊天
        /// </summary>
        /// <value>事件类型，可选值如下： default：默认事件 audiobook：有声书 education：教育音频 game：游戏语音房 live：秀场直播 ecommerce：电商直播 voiceroom：交友语音房 private：私密语音聊天</value>
        [JsonConverter(typeof(EnumClassConverter<EventTypeEnum>))]
        public class EventTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: default
            /// </summary>
            public static readonly EventTypeEnum DEFAULT = new EventTypeEnum("default");

            /// <summary>
            /// Enum AUDIOBOOK for value: audiobook
            /// </summary>
            public static readonly EventTypeEnum AUDIOBOOK = new EventTypeEnum("audiobook");

            /// <summary>
            /// Enum EDUCATION for value: education
            /// </summary>
            public static readonly EventTypeEnum EDUCATION = new EventTypeEnum("education");

            /// <summary>
            /// Enum GAME for value: game
            /// </summary>
            public static readonly EventTypeEnum GAME = new EventTypeEnum("game");

            /// <summary>
            /// Enum LIVE for value: live
            /// </summary>
            public static readonly EventTypeEnum LIVE = new EventTypeEnum("live");

            /// <summary>
            /// Enum ECOMMERCE for value: ecommerce
            /// </summary>
            public static readonly EventTypeEnum ECOMMERCE = new EventTypeEnum("ecommerce");

            /// <summary>
            /// Enum VOICEROOM for value: voiceroom
            /// </summary>
            public static readonly EventTypeEnum VOICEROOM = new EventTypeEnum("voiceroom");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly EventTypeEnum PRIVATE = new EventTypeEnum("private");

            private static readonly Dictionary<string, EventTypeEnum> StaticFields =
            new Dictionary<string, EventTypeEnum>()
            {
                { "default", DEFAULT },
                { "audiobook", AUDIOBOOK },
                { "education", EDUCATION },
                { "game", GAME },
                { "live", LIVE },
                { "ecommerce", ECOMMERCE },
                { "voiceroom", VOICEROOM },
                { "private", PRIVATE },
            };

            private string _value;

            public EventTypeEnum()
            {

            }

            public EventTypeEnum(string value)
            {
                _value = value;
            }

            public static EventTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventTypeEnum a, EventTypeEnum b)
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

            public static bool operator !=(EventTypeEnum a, EventTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines categories
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CategoriesEnum>))]
        public class CategoriesEnum
        {
            /// <summary>
            /// Enum POLITICS for value: politics
            /// </summary>
            public static readonly CategoriesEnum POLITICS = new CategoriesEnum("politics");

            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly CategoriesEnum PORN = new CategoriesEnum("porn");

            /// <summary>
            /// Enum AD for value: ad
            /// </summary>
            public static readonly CategoriesEnum AD = new CategoriesEnum("ad");

            /// <summary>
            /// Enum MOAN for value: moan
            /// </summary>
            public static readonly CategoriesEnum MOAN = new CategoriesEnum("moan");

            /// <summary>
            /// Enum ABUSE for value: abuse
            /// </summary>
            public static readonly CategoriesEnum ABUSE = new CategoriesEnum("abuse");

            private static readonly Dictionary<string, CategoriesEnum> StaticFields =
            new Dictionary<string, CategoriesEnum>()
            {
                { "politics", POLITICS },
                { "porn", PORN },
                { "ad", AD },
                { "moan", MOAN },
                { "abuse", ABUSE },
            };

            private string _value;

            public CategoriesEnum()
            {

            }

            public CategoriesEnum(string value)
            {
                _value = value;
            }

            public static CategoriesEnum FromValue(string value)
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

                if (this.Equals(obj as CategoriesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoriesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoriesEnum a, CategoriesEnum b)
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

            public static bool operator !=(CategoriesEnum a, CategoriesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public AudioInputBody Data { get; set; }

        /// <summary>
        /// 事件类型，可选值如下： default：默认事件 audiobook：有声书 education：教育音频 game：游戏语音房 live：秀场直播 ecommerce：电商直播 voiceroom：交友语音房 private：私密语音聊天
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 需要检测的风险类型，列表不能为空。 风险类型如下： - porn：涉黄检测 - ad：广告检测 - moan：娇喘检测 - abuse：辱骂检测
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// 回调http接口：当该字段非空时，服务将根据该字段回调通知用户审核结果。
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string Callback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioCreateRequest {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  callback: ").Append(Callback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                return hashCode;
            }
        }
    }
}
