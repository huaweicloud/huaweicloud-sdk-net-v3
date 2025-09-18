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
    /// 声音配置信息，为Flexus版声音的配置项，标准版声音不支持此配置。
    /// </summary>
    public class VoiceProperties 
    {
        /// <summary>
        /// 任务标签，为Flexus版声音的配置。   * ECOMMERCE: 电商   * NEWS: 新闻   * MARKETING: 营销
        /// </summary>
        /// <value>任务标签，为Flexus版声音的配置。   * ECOMMERCE: 电商   * NEWS: 新闻   * MARKETING: 营销</value>
        [JsonConverter(typeof(EnumClassConverter<JobTagEnum>))]
        public class JobTagEnum
        {
            /// <summary>
            /// Enum ECOMMERCE for value: ECOMMERCE
            /// </summary>
            public static readonly JobTagEnum ECOMMERCE = new JobTagEnum("ECOMMERCE");

            /// <summary>
            /// Enum NEWS for value: NEWS
            /// </summary>
            public static readonly JobTagEnum NEWS = new JobTagEnum("NEWS");

            /// <summary>
            /// Enum MARKETING for value: MARKETING
            /// </summary>
            public static readonly JobTagEnum MARKETING = new JobTagEnum("MARKETING");

            private static readonly Dictionary<string, JobTagEnum> StaticFields =
            new Dictionary<string, JobTagEnum>()
            {
                { "ECOMMERCE", ECOMMERCE },
                { "NEWS", NEWS },
                { "MARKETING", MARKETING },
            };

            private string _value;

            public JobTagEnum()
            {

            }

            public JobTagEnum(string value)
            {
                _value = value;
            }

            public static JobTagEnum FromValue(string value)
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

                if (this.Equals(obj as JobTagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTagEnum a, JobTagEnum b)
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

            public static bool operator !=(JobTagEnum a, JobTagEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 语音性别，是男性声音还是女性声音，为Flexus版声音的配置。 * FEMALE: 女性 * MALE: 男性
        /// </summary>
        /// <value>语音性别，是男性声音还是女性声音，为Flexus版声音的配置。 * FEMALE: 女性 * MALE: 男性</value>
        [JsonConverter(typeof(EnumClassConverter<SexEnum>))]
        public class SexEnum
        {
            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            public static readonly SexEnum FEMALE = new SexEnum("FEMALE");

            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            public static readonly SexEnum MALE = new SexEnum("MALE");

            private static readonly Dictionary<string, SexEnum> StaticFields =
            new Dictionary<string, SexEnum>()
            {
                { "FEMALE", FEMALE },
                { "MALE", MALE },
            };

            private string _value;

            public SexEnum()
            {

            }

            public SexEnum(string value)
            {
                _value = value;
            }

            public static SexEnum FromValue(string value)
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

                if (this.Equals(obj as SexEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SexEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SexEnum a, SexEnum b)
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

            public static bool operator !=(SexEnum a, SexEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 训练语言，当前仅支持中文，为Flexus版声音的配置。 * CN: 中文 * EN: 英文
        /// </summary>
        /// <value>训练语言，当前仅支持中文，为Flexus版声音的配置。 * CN: 中文 * EN: 英文</value>
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

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "CN", CN },
                { "EN", EN },
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务标签，为Flexus版声音的配置。   * ECOMMERCE: 电商   * NEWS: 新闻   * MARKETING: 营销
        /// </summary>
        [JsonProperty("job_tag", NullValueHandling = NullValueHandling.Ignore)]
        public JobTagEnum JobTag { get; set; }
        /// <summary>
        /// 语音性别，是男性声音还是女性声音，为Flexus版声音的配置。 * FEMALE: 女性 * MALE: 男性
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public SexEnum Sex { get; set; }
        /// <summary>
        /// 训练语言，当前仅支持中文，为Flexus版声音的配置。 * CN: 中文 * EN: 英文
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceProperties {\n");
            sb.Append("  jobTag: ").Append(JobTag).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceProperties input)
        {
            if (input == null) return false;
            if (this.JobTag != input.JobTag) return false;
            if (this.Sex != input.Sex) return false;
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
                hashCode = hashCode * 59 + this.JobTag.GetHashCode();
                hashCode = hashCode * 59 + this.Sex.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
