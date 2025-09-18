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
        /// 用户在控制台界面创建的biz_type名称，如果请求参数中传了biz_type则优先使用biz_type；如果用户没传biz_type则event_type和categories必须传。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

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
        /// 用于回调通知时校验请求由华为云内容安全服务发起，由您自定义。随机字符串，由英文字母、数字、下划线组成，不超过64个字符。 说明：当seed非空时，headers中将包含X-Auth-Signature字段，字段的值使用HmacSHA256算法生成，待加密字符串由create_time、job_id、request_id、seed按照顺序拼接而成，密钥为seed。
        /// </summary>
        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Seed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioCreateRequest {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  callback: ").Append(Callback).Append("\n");
            sb.Append("  seed: ").Append(Seed).Append("\n");
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
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.BizType != input.BizType || (this.BizType != null && !this.BizType.Equals(input.BizType))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.Callback != input.Callback || (this.Callback != null && !this.Callback.Equals(input.Callback))) return false;
            if (this.Seed != input.Seed || (this.Seed != null && !this.Seed.Equals(input.Seed))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.BizType != null) hashCode = hashCode * 59 + this.BizType.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Callback != null) hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.Seed != null) hashCode = hashCode * 59 + this.Seed.GetHashCode();
                return hashCode;
            }
        }
    }
}
