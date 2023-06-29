using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OutputSetting 
    {
        /// <summary>
        /// 剪切或拼接的输出封装格式。
        /// </summary>
        /// <value>剪切或拼接的输出封装格式。</value>
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
            /// Enum TS for value: TS
            /// </summary>
            public static readonly FormatEnum TS = new FormatEnum("TS");

            /// <summary>
            /// Enum FLV for value: FLV
            /// </summary>
            public static readonly FormatEnum FLV = new FormatEnum("FLV");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "MP4", MP4 },
                { "HLS", HLS },
                { "TS", TS },
                { "FLV", FLV },
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
        /// 剪切或拼接的输出封装格式。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public EditVideoInfo Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public EditAudioInfo Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hls", NullValueHandling = NullValueHandling.Ignore)]
        public EditHlsInfo Hls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputSetting {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  hls: ").Append(Hls).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
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
                    this.Hls == input.Hls ||
                    (this.Hls != null &&
                    this.Hls.Equals(input.Hls))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Hls != null)
                    hashCode = hashCode * 59 + this.Hls.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
