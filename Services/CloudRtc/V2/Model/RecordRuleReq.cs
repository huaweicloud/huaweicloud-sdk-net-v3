using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 修改录制规则
    /// </summary>
    public class RecordRuleReq 
    {
        /// <summary>
        /// Defines recordFormats
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<RecordFormatsEnum>))]
        public class RecordFormatsEnum
        {
            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly RecordFormatsEnum HLS = new RecordFormatsEnum("HLS");

            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly RecordFormatsEnum MP4 = new RecordFormatsEnum("MP4");

            private static readonly Dictionary<string, RecordFormatsEnum> StaticFields =
            new Dictionary<string, RecordFormatsEnum>()
            {
                { "HLS", HLS },
                { "MP4", MP4 },
            };

            private string _value;

            public RecordFormatsEnum()
            {

            }

            public RecordFormatsEnum(string value)
            {
                _value = value;
            }

            public static RecordFormatsEnum FromValue(string value)
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

                if (this.Equals(obj as RecordFormatsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordFormatsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordFormatsEnum a, RecordFormatsEnum b)
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

            public static bool operator !=(RecordFormatsEnum a, RecordFormatsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_addr", NullValueHandling = NullValueHandling.Ignore)]
        public RecordObsFileAddr ObsAddr { get; set; }

        /// <summary>
        ///  录制格式：支持HLS格式和MP4格式（HLS和MP4为大写）。   - 若配置HLS则必须携带HLSRecordConfig参数  - 若配置MP4则需要携带MP4RecordConfig 
        /// </summary>
        [JsonProperty("record_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordFormatsEnum> RecordFormats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hls_config", NullValueHandling = NullValueHandling.Ignore)]
        public HLSRecordConfig HlsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mp4_config", NullValueHandling = NullValueHandling.Ignore)]
        public MP4RecordConfig Mp4Config { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordRuleReq {\n");
            sb.Append("  obsAddr: ").Append(ObsAddr).Append("\n");
            sb.Append("  recordFormats: ").Append(RecordFormats).Append("\n");
            sb.Append("  hlsConfig: ").Append(HlsConfig).Append("\n");
            sb.Append("  mp4Config: ").Append(Mp4Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordRuleReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObsAddr == input.ObsAddr ||
                    (this.ObsAddr != null &&
                    this.ObsAddr.Equals(input.ObsAddr))
                ) && 
                (
                    this.RecordFormats == input.RecordFormats ||
                    this.RecordFormats != null &&
                    input.RecordFormats != null &&
                    this.RecordFormats.SequenceEqual(input.RecordFormats)
                ) && 
                (
                    this.HlsConfig == input.HlsConfig ||
                    (this.HlsConfig != null &&
                    this.HlsConfig.Equals(input.HlsConfig))
                ) && 
                (
                    this.Mp4Config == input.Mp4Config ||
                    (this.Mp4Config != null &&
                    this.Mp4Config.Equals(input.Mp4Config))
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
                if (this.ObsAddr != null)
                    hashCode = hashCode * 59 + this.ObsAddr.GetHashCode();
                if (this.RecordFormats != null)
                    hashCode = hashCode * 59 + this.RecordFormats.GetHashCode();
                if (this.HlsConfig != null)
                    hashCode = hashCode * 59 + this.HlsConfig.GetHashCode();
                if (this.Mp4Config != null)
                    hashCode = hashCode * 59 + this.Mp4Config.GetHashCode();
                return hashCode;
            }
        }
    }
}
