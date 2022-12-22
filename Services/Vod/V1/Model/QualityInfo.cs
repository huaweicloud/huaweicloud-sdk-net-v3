using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QualityInfo 
    {
        /// <summary>
        /// 格式。
        /// </summary>
        /// <value>格式。</value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly FormatEnum MP4 = new FormatEnum("MP4");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly FormatEnum HLS = new FormatEnum("HLS");

            /// <summary>
            /// Enum DASH for value: DASH
            /// </summary>
            public static readonly FormatEnum DASH = new FormatEnum("DASH");

            /// <summary>
            /// Enum DASH_HLS for value: DASH_HLS
            /// </summary>
            public static readonly FormatEnum DASH_HLS = new FormatEnum("DASH_HLS");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly FormatEnum MP3 = new FormatEnum("MP3");

            /// <summary>
            /// Enum ADTS for value: ADTS
            /// </summary>
            public static readonly FormatEnum ADTS = new FormatEnum("ADTS");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly FormatEnum UNKNOW = new FormatEnum("UNKNOW");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "MP4", MP4 },
                { "HLS", HLS },
                { "DASH", DASH },
                { "DASH_HLS", DASH_HLS },
                { "MP3", MP3 },
                { "ADTS", ADTS },
                { "UNKNOW", UNKNOW },
            };

            private string _value;

            public FormatEnum()
            {

            }

            public FormatEnum(string value)
            {
                _value = value;
            }

            public static FormatEnum FromValue(string value)
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

                if (this.Equals(obj as FormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FormatEnum a, FormatEnum b)
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTemplateInfo Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public AudioTemplateInfo Audio { get; set; }

        /// <summary>
        /// 格式。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityInfo {\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualityInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
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
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }
}
