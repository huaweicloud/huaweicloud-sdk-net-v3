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
    /// 
    /// </summary>
    public class VideoCreateRequest 
    {
        /// <summary>
        /// 事件类型，可选值如下： default：默认事件
        /// </summary>
        /// <value>事件类型，可选值如下： default：默认事件</value>
        [JsonConverter(typeof(EnumClassConverter<EventTypeEnum>))]
        public class EventTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: default
            /// </summary>
            public static readonly EventTypeEnum DEFAULT = new EventTypeEnum("default");

            private static readonly Dictionary<string, EventTypeEnum> StaticFields =
            new Dictionary<string, EventTypeEnum>()
            {
                { "default", DEFAULT },
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
        /// Defines imageCategories
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ImageCategoriesEnum>))]
        public class ImageCategoriesEnum
        {
            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly ImageCategoriesEnum PORN = new ImageCategoriesEnum("porn");

            /// <summary>
            /// Enum POLITICS for value: politics
            /// </summary>
            public static readonly ImageCategoriesEnum POLITICS = new ImageCategoriesEnum("politics");

            /// <summary>
            /// Enum TERRORISM for value: terrorism
            /// </summary>
            public static readonly ImageCategoriesEnum TERRORISM = new ImageCategoriesEnum("terrorism");

            /// <summary>
            /// Enum IMAGE_TEXT for value: image_text
            /// </summary>
            public static readonly ImageCategoriesEnum IMAGE_TEXT = new ImageCategoriesEnum("image_text");

            private static readonly Dictionary<string, ImageCategoriesEnum> StaticFields =
            new Dictionary<string, ImageCategoriesEnum>()
            {
                { "porn", PORN },
                { "politics", POLITICS },
                { "terrorism", TERRORISM },
                { "image_text", IMAGE_TEXT },
            };

            private string _value;

            public ImageCategoriesEnum()
            {

            }

            public ImageCategoriesEnum(string value)
            {
                _value = value;
            }

            public static ImageCategoriesEnum FromValue(string value)
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

                if (this.Equals(obj as ImageCategoriesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageCategoriesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageCategoriesEnum a, ImageCategoriesEnum b)
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

            public static bool operator !=(ImageCategoriesEnum a, ImageCategoriesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines audioCategories
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AudioCategoriesEnum>))]
        public class AudioCategoriesEnum
        {
            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly AudioCategoriesEnum PORN = new AudioCategoriesEnum("porn");

            /// <summary>
            /// Enum AD for value: ad
            /// </summary>
            public static readonly AudioCategoriesEnum AD = new AudioCategoriesEnum("ad");

            /// <summary>
            /// Enum POLITICS for value: politics
            /// </summary>
            public static readonly AudioCategoriesEnum POLITICS = new AudioCategoriesEnum("politics");

            /// <summary>
            /// Enum MOAN for value: moan
            /// </summary>
            public static readonly AudioCategoriesEnum MOAN = new AudioCategoriesEnum("moan");

            /// <summary>
            /// Enum ABUSE for value: abuse
            /// </summary>
            public static readonly AudioCategoriesEnum ABUSE = new AudioCategoriesEnum("abuse");

            private static readonly Dictionary<string, AudioCategoriesEnum> StaticFields =
            new Dictionary<string, AudioCategoriesEnum>()
            {
                { "porn", PORN },
                { "ad", AD },
                { "politics", POLITICS },
                { "moan", MOAN },
                { "abuse", ABUSE },
            };

            private string _value;

            public AudioCategoriesEnum()
            {

            }

            public AudioCategoriesEnum(string value)
            {
                _value = value;
            }

            public static AudioCategoriesEnum FromValue(string value)
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

                if (this.Equals(obj as AudioCategoriesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioCategoriesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioCategoriesEnum a, AudioCategoriesEnum b)
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

            public static bool operator !=(AudioCategoriesEnum a, AudioCategoriesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCreateRequestData Data { get; set; }

        /// <summary>
        /// 用户在控制台界面创建的biz_type名称，如果请求参数中传了biz_type则优先使用biz_type；如果用户没传biz_type则event_type和image_categories必须传。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 事件类型，可选值如下： default：默认事件
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 视频中画面需要检测的风险类型，列表不能为空。 terrorism：涉政暴恐内容的检测 porn：鉴黄内容的检测 politics：政治敏感人物内容的检测 image_text：图文违规内容的检测（检测图片中出现的广告、色情、暴恐、涉政的文字违规内容以及二维码内容）
        /// </summary>
        [JsonProperty("image_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageCategoriesEnum> ImageCategories { get; set; }
        /// <summary>
        /// 视频中音频需要检测的风险类型，不传或为空时表示不审核音频维度。 politics: 涉政检测 porn：涉黄检测 ad: 广告检测 moan: 娇喘检测 abuse: 辱骂检测
        /// </summary>
        [JsonProperty("audio_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioCategoriesEnum> AudioCategories { get; set; }
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
            sb.Append("class VideoCreateRequest {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  imageCategories: ").Append(ImageCategories).Append("\n");
            sb.Append("  audioCategories: ").Append(AudioCategories).Append("\n");
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
            return this.Equals(input as VideoCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCreateRequest input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.BizType != input.BizType || (this.BizType != null && !this.BizType.Equals(input.BizType))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.ImageCategories != input.ImageCategories || (this.ImageCategories != null && input.ImageCategories != null && !this.ImageCategories.SequenceEqual(input.ImageCategories))) return false;
            if (this.AudioCategories != input.AudioCategories || (this.AudioCategories != null && input.AudioCategories != null && !this.AudioCategories.SequenceEqual(input.AudioCategories))) return false;
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
                hashCode = hashCode * 59 + this.ImageCategories.GetHashCode();
                hashCode = hashCode * 59 + this.AudioCategories.GetHashCode();
                if (this.Callback != null) hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.Seed != null) hashCode = hashCode * 59 + this.Seed.GetHashCode();
                return hashCode;
            }
        }
    }
}
