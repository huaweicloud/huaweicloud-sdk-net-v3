using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoTagginginference 
    {
        /// <summary>
        /// 标签语种
        /// </summary>
        /// <value>标签语种</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH for value: zh
            /// </summary>
            public static readonly LanguageEnum ZH = new LanguageEnum("zh");

            /// <summary>
            /// Enum EN for value: en
            /// </summary>
            public static readonly LanguageEnum EN = new LanguageEnum("en");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh", ZH },
                { "en", EN },
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
        /// 视频标题
        /// </summary>
        [JsonProperty("video_title", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoTitle { get; set; }

        /// <summary>
        /// 标签语种
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 名人识别使用开关
        /// </summary>
        [JsonProperty("use_celebrity", NullValueHandling = NullValueHandling.Ignore)]
        public string UseCelebrity { get; set; }

        /// <summary>
        /// 地标识别使用开关
        /// </summary>
        [JsonProperty("use_landmark", NullValueHandling = NullValueHandling.Ignore)]
        public string UseLandmark { get; set; }

        /// <summary>
        /// LOGO识别使用开关
        /// </summary>
        [JsonProperty("use_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string UseLogo { get; set; }

        /// <summary>
        /// OCR识别使用开关
        /// </summary>
        [JsonProperty("use_ocr", NullValueHandling = NullValueHandling.Ignore)]
        public string UseOcr { get; set; }

        /// <summary>
        /// 视频语音识别开关
        /// </summary>
        [JsonProperty("use_sis", NullValueHandling = NullValueHandling.Ignore)]
        public string UseSis { get; set; }

        /// <summary>
        /// 图像标签识别开关
        /// </summary>
        [JsonProperty("use_tagging", NullValueHandling = NullValueHandling.Ignore)]
        public string UseTagging { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTagginginference {\n");
            sb.Append("  videoTitle: ").Append(VideoTitle).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  useCelebrity: ").Append(UseCelebrity).Append("\n");
            sb.Append("  useLandmark: ").Append(UseLandmark).Append("\n");
            sb.Append("  useLogo: ").Append(UseLogo).Append("\n");
            sb.Append("  useOcr: ").Append(UseOcr).Append("\n");
            sb.Append("  useSis: ").Append(UseSis).Append("\n");
            sb.Append("  useTagging: ").Append(UseTagging).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTagginginference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTagginginference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoTitle == input.VideoTitle ||
                    (this.VideoTitle != null &&
                    this.VideoTitle.Equals(input.VideoTitle))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.UseCelebrity == input.UseCelebrity ||
                    (this.UseCelebrity != null &&
                    this.UseCelebrity.Equals(input.UseCelebrity))
                ) && 
                (
                    this.UseLandmark == input.UseLandmark ||
                    (this.UseLandmark != null &&
                    this.UseLandmark.Equals(input.UseLandmark))
                ) && 
                (
                    this.UseLogo == input.UseLogo ||
                    (this.UseLogo != null &&
                    this.UseLogo.Equals(input.UseLogo))
                ) && 
                (
                    this.UseOcr == input.UseOcr ||
                    (this.UseOcr != null &&
                    this.UseOcr.Equals(input.UseOcr))
                ) && 
                (
                    this.UseSis == input.UseSis ||
                    (this.UseSis != null &&
                    this.UseSis.Equals(input.UseSis))
                ) && 
                (
                    this.UseTagging == input.UseTagging ||
                    (this.UseTagging != null &&
                    this.UseTagging.Equals(input.UseTagging))
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
                if (this.VideoTitle != null)
                    hashCode = hashCode * 59 + this.VideoTitle.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.UseCelebrity != null)
                    hashCode = hashCode * 59 + this.UseCelebrity.GetHashCode();
                if (this.UseLandmark != null)
                    hashCode = hashCode * 59 + this.UseLandmark.GetHashCode();
                if (this.UseLogo != null)
                    hashCode = hashCode * 59 + this.UseLogo.GetHashCode();
                if (this.UseOcr != null)
                    hashCode = hashCode * 59 + this.UseOcr.GetHashCode();
                if (this.UseSis != null)
                    hashCode = hashCode * 59 + this.UseSis.GetHashCode();
                if (this.UseTagging != null)
                    hashCode = hashCode * 59 + this.UseTagging.GetHashCode();
                return hashCode;
            }
        }
    }
}
