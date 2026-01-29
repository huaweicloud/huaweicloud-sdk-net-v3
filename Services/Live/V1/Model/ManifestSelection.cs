using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 流选择配置
    /// </summary>
    public class ManifestSelection 
    {
        /// <summary>
        /// **参数解释**： 流排序模式 **约束限制**： 不涉及 **取值范围**： - ORIGINAL：保持原始顺序，即按照频道配置中转码模板的顺序 - VIDEO_BITRATE_ASCENDING：按照视频码率升序 - VIDEO_BITRATE_DESCENDING：按照视频码率降序 
        /// </summary>
        /// <value>**参数解释**： 流排序模式 **约束限制**： 不涉及 **取值范围**： - ORIGINAL：保持原始顺序，即按照频道配置中转码模板的顺序 - VIDEO_BITRATE_ASCENDING：按照视频码率升序 - VIDEO_BITRATE_DESCENDING：按照视频码率降序 </value>
        [JsonConverter(typeof(EnumClassConverter<StreamOrderEnum>))]
        public class StreamOrderEnum
        {
            /// <summary>
            /// Enum ORIGINAL for value: ORIGINAL
            /// </summary>
            public static readonly StreamOrderEnum ORIGINAL = new StreamOrderEnum("ORIGINAL");

            /// <summary>
            /// Enum VIDEO_BITRATE_ASCENDING for value: VIDEO_BITRATE_ASCENDING
            /// </summary>
            public static readonly StreamOrderEnum VIDEO_BITRATE_ASCENDING = new StreamOrderEnum("VIDEO_BITRATE_ASCENDING");

            /// <summary>
            /// Enum VIDEO_BITRATE_DESCENDING for value: VIDEO_BITRATE_DESCENDING
            /// </summary>
            public static readonly StreamOrderEnum VIDEO_BITRATE_DESCENDING = new StreamOrderEnum("VIDEO_BITRATE_DESCENDING");

            private static readonly Dictionary<string, StreamOrderEnum> StaticFields =
            new Dictionary<string, StreamOrderEnum>()
            {
                { "ORIGINAL", ORIGINAL },
                { "VIDEO_BITRATE_ASCENDING", VIDEO_BITRATE_ASCENDING },
                { "VIDEO_BITRATE_DESCENDING", VIDEO_BITRATE_DESCENDING },
            };

            private string _value;

            public StreamOrderEnum()
            {

            }

            public StreamOrderEnum(string value)
            {
                _value = value;
            }

            public static StreamOrderEnum FromValue(string value)
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

                if (this.Equals(obj as StreamOrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StreamOrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StreamOrderEnum a, StreamOrderEnum b)
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

            public static bool operator !=(StreamOrderEnum a, StreamOrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 流排序模式 **约束限制**： 不涉及 **取值范围**： - ORIGINAL：保持原始顺序，即按照频道配置中转码模板的顺序 - VIDEO_BITRATE_ASCENDING：按照视频码率升序 - VIDEO_BITRATE_DESCENDING：按照视频码率降序 
        /// </summary>
        [JsonProperty("stream_order", NullValueHandling = NullValueHandling.Ignore)]
        public StreamOrderEnum StreamOrder { get; set; }
        /// <summary>
        /// **参数解释**： 视频码率过滤的最小码率 **约束限制**： 单位：bit/s；取值必须比max_video_bandwidth小 
        /// </summary>
        [JsonProperty("min_video_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVideoBandwidth { get; set; }

        /// <summary>
        /// **参数解释**： 视频码率过滤的最大码率 **约束限制**： 单位：bit/s；取值必须比min_video_bandwidth大 
        /// </summary>
        [JsonProperty("max_video_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVideoBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestSelection {\n");
            sb.Append("  streamOrder: ").Append(StreamOrder).Append("\n");
            sb.Append("  minVideoBandwidth: ").Append(MinVideoBandwidth).Append("\n");
            sb.Append("  maxVideoBandwidth: ").Append(MaxVideoBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManifestSelection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManifestSelection input)
        {
            if (input == null) return false;
            if (this.StreamOrder != input.StreamOrder) return false;
            if (this.MinVideoBandwidth != input.MinVideoBandwidth || (this.MinVideoBandwidth != null && !this.MinVideoBandwidth.Equals(input.MinVideoBandwidth))) return false;
            if (this.MaxVideoBandwidth != input.MaxVideoBandwidth || (this.MaxVideoBandwidth != null && !this.MaxVideoBandwidth.Equals(input.MaxVideoBandwidth))) return false;

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
                hashCode = hashCode * 59 + this.StreamOrder.GetHashCode();
                if (this.MinVideoBandwidth != null) hashCode = hashCode * 59 + this.MinVideoBandwidth.GetHashCode();
                if (this.MaxVideoBandwidth != null) hashCode = hashCode * 59 + this.MaxVideoBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
