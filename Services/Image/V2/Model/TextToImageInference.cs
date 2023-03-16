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
    public class TextToImageInference 
    {
        /// <summary>
        /// 生成图片分辨率，限定字符串\&quot;512\\*768\&quot;,\&quot;768\\*512\&quot;,\&quot;512\\*512\&quot;，默认\&quot;512\\*512\&quot;
        /// </summary>
        /// <value>生成图片分辨率，限定字符串\&quot;512\\*768\&quot;,\&quot;768\\*512\&quot;,\&quot;512\\*512\&quot;，默认\&quot;512\\*512\&quot;</value>
        [JsonConverter(typeof(EnumClassConverter<ResolutionEnum>))]
        public class ResolutionEnum
        {
            /// <summary>
            /// Enum _512_768 for value: 512*768
            /// </summary>
            public static readonly ResolutionEnum _512_768 = new ResolutionEnum("512*768");

            /// <summary>
            /// Enum _768_512 for value: 768*512
            /// </summary>
            public static readonly ResolutionEnum _768_512 = new ResolutionEnum("768*512");

            /// <summary>
            /// Enum _512_512 for value: 512*512
            /// </summary>
            public static readonly ResolutionEnum _512_512 = new ResolutionEnum("512*512");

            private static readonly Dictionary<string, ResolutionEnum> StaticFields =
            new Dictionary<string, ResolutionEnum>()
            {
                { "512*768", _512_768 },
                { "768*512", _768_512 },
                { "512*512", _512_512 },
            };

            private string _value;

            public ResolutionEnum()
            {

            }

            public ResolutionEnum(string value)
            {
                _value = value;
            }

            public static ResolutionEnum FromValue(string value)
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

                if (this.Equals(obj as ResolutionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResolutionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResolutionEnum a, ResolutionEnum b)
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

            public static bool operator !=(ResolutionEnum a, ResolutionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 文生图引导词
        /// </summary>
        [JsonProperty("prompt", NullValueHandling = NullValueHandling.Ignore)]
        public string Prompt { get; set; }

        /// <summary>
        /// 随机数种子
        /// </summary>
        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Seed { get; set; }

        /// <summary>
        /// 生成图片分辨率，限定字符串\&quot;512\\*768\&quot;,\&quot;768\\*512\&quot;,\&quot;512\\*512\&quot;，默认\&quot;512\\*512\&quot;
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public ResolutionEnum Resolution { get; set; }
        /// <summary>
        /// 生成图片数量，支持1-4张，默认为1
        /// </summary>
        [JsonProperty("image_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageNums { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextToImageInference {\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("  seed: ").Append(Seed).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  imageNums: ").Append(ImageNums).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextToImageInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextToImageInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.ImageNums == input.ImageNums ||
                    (this.ImageNums != null &&
                    this.ImageNums.Equals(input.ImageNums))
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
                if (this.Prompt != null)
                    hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.Seed != null)
                    hashCode = hashCode * 59 + this.Seed.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.ImageNums != null)
                    hashCode = hashCode * 59 + this.ImageNums.GetHashCode();
                return hashCode;
            }
        }
    }
}
