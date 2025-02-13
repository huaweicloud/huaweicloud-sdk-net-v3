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
    /// DASH频道出流信息
    /// </summary>
    public class DashPackageItem 
    {
        /// <summary>
        /// 广告标识。DASH取值：\&quot;xml+bin\&quot;
        /// </summary>
        /// <value>广告标识。DASH取值：\&quot;xml+bin\&quot;</value>
        [JsonConverter(typeof(EnumClassConverter<AdMarkerEnum>))]
        public class AdMarkerEnum
        {
            /// <summary>
            /// Enum XML_BIN for value: xml+bin
            /// </summary>
            public static readonly AdMarkerEnum XML_BIN = new AdMarkerEnum("xml+bin");

            /// <summary>
            /// Enum XML for value: xml
            /// </summary>
            public static readonly AdMarkerEnum XML = new AdMarkerEnum("xml");

            private static readonly Dictionary<string, AdMarkerEnum> StaticFields =
            new Dictionary<string, AdMarkerEnum>()
            {
                { "xml+bin", XML_BIN },
                { "xml", XML },
            };

            private string _value;

            public AdMarkerEnum()
            {

            }

            public AdMarkerEnum(string value)
            {
                _value = value;
            }

            public static AdMarkerEnum FromValue(string value)
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

                if (this.Equals(obj as AdMarkerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdMarkerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdMarkerEnum a, AdMarkerEnum b)
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

            public static bool operator !=(AdMarkerEnum a, AdMarkerEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 客户自定义的拉流地址，包括方法、域名、路径
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 从全量流中过滤出一个码率在[min, max]区间的流。如果不需要码率过滤可不选。
        /// </summary>
        [JsonProperty("stream_selection", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamSelectionItem> StreamSelection { get; set; }

        /// <summary>
        /// 频道输出分片的时长，为必选项  单位：秒。取值范围：1-10 &gt; 修改分片时长会影响已录制内容的时移和回看服务，请谨慎修改！
        /// </summary>
        [JsonProperty("segment_duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentDurationSeconds { get; set; }

        /// <summary>
        /// 频道直播返回分片的窗口长度，为频道输出分片的时长乘以数量后得到的值。实际返回的分片数不小于3个。  单位：秒。取值范围：0 - 86400（24小时转化成秒后的取值）
        /// </summary>
        [JsonProperty("playlist_window_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlaylistWindowSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// 广告配置
        /// </summary>
        [JsonProperty("ads", NullValueHandling = NullValueHandling.Ignore)]
        public Object Ads { get; set; }

        /// <summary>
        /// 其他额外参数
        /// </summary>
        [JsonProperty("ext_args", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_args", NullValueHandling = NullValueHandling.Ignore)]
        public PackageRequestArgs RequestArgs { get; set; }

        /// <summary>
        /// 广告标识。DASH取值：\&quot;xml+bin\&quot;
        /// </summary>
        [JsonProperty("ad_marker", NullValueHandling = NullValueHandling.Ignore)]
        public AdMarkerEnum AdMarker { get; set; }
        /// <summary>
        /// 建议播放延迟。单位：秒。取值范围：[1 - 120]
        /// </summary>
        [JsonProperty("suggested_presentation_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuggestedPresentationDelay { get; set; }

        /// <summary>
        /// 索引最短更新周期。单位：秒。取值范围：[1 - 120]
        /// </summary>
        [JsonProperty("minimum_update_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumUpdatePeriod { get; set; }

        /// <summary>
        /// 最小缓冲时间。单位：秒。取值范围：[1 - 120]
        /// </summary>
        [JsonProperty("min_buffer_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBufferTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashPackageItem {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  streamSelection: ").Append(StreamSelection).Append("\n");
            sb.Append("  segmentDurationSeconds: ").Append(SegmentDurationSeconds).Append("\n");
            sb.Append("  playlistWindowSeconds: ").Append(PlaylistWindowSeconds).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  ads: ").Append(Ads).Append("\n");
            sb.Append("  extArgs: ").Append(ExtArgs).Append("\n");
            sb.Append("  requestArgs: ").Append(RequestArgs).Append("\n");
            sb.Append("  adMarker: ").Append(AdMarker).Append("\n");
            sb.Append("  suggestedPresentationDelay: ").Append(SuggestedPresentationDelay).Append("\n");
            sb.Append("  minimumUpdatePeriod: ").Append(MinimumUpdatePeriod).Append("\n");
            sb.Append("  minBufferTime: ").Append(MinBufferTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashPackageItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DashPackageItem input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.StreamSelection != input.StreamSelection || (this.StreamSelection != null && input.StreamSelection != null && !this.StreamSelection.SequenceEqual(input.StreamSelection))) return false;
            if (this.SegmentDurationSeconds != input.SegmentDurationSeconds || (this.SegmentDurationSeconds != null && !this.SegmentDurationSeconds.Equals(input.SegmentDurationSeconds))) return false;
            if (this.PlaylistWindowSeconds != input.PlaylistWindowSeconds || (this.PlaylistWindowSeconds != null && !this.PlaylistWindowSeconds.Equals(input.PlaylistWindowSeconds))) return false;
            if (this.Encryption != input.Encryption || (this.Encryption != null && !this.Encryption.Equals(input.Encryption))) return false;
            if (this.Ads != input.Ads || (this.Ads != null && !this.Ads.Equals(input.Ads))) return false;
            if (this.ExtArgs != input.ExtArgs || (this.ExtArgs != null && !this.ExtArgs.Equals(input.ExtArgs))) return false;
            if (this.RequestArgs != input.RequestArgs || (this.RequestArgs != null && !this.RequestArgs.Equals(input.RequestArgs))) return false;
            if (this.AdMarker != input.AdMarker) return false;
            if (this.SuggestedPresentationDelay != input.SuggestedPresentationDelay || (this.SuggestedPresentationDelay != null && !this.SuggestedPresentationDelay.Equals(input.SuggestedPresentationDelay))) return false;
            if (this.MinimumUpdatePeriod != input.MinimumUpdatePeriod || (this.MinimumUpdatePeriod != null && !this.MinimumUpdatePeriod.Equals(input.MinimumUpdatePeriod))) return false;
            if (this.MinBufferTime != input.MinBufferTime || (this.MinBufferTime != null && !this.MinBufferTime.Equals(input.MinBufferTime))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.StreamSelection != null) hashCode = hashCode * 59 + this.StreamSelection.GetHashCode();
                if (this.SegmentDurationSeconds != null) hashCode = hashCode * 59 + this.SegmentDurationSeconds.GetHashCode();
                if (this.PlaylistWindowSeconds != null) hashCode = hashCode * 59 + this.PlaylistWindowSeconds.GetHashCode();
                if (this.Encryption != null) hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.Ads != null) hashCode = hashCode * 59 + this.Ads.GetHashCode();
                if (this.ExtArgs != null) hashCode = hashCode * 59 + this.ExtArgs.GetHashCode();
                if (this.RequestArgs != null) hashCode = hashCode * 59 + this.RequestArgs.GetHashCode();
                hashCode = hashCode * 59 + this.AdMarker.GetHashCode();
                if (this.SuggestedPresentationDelay != null) hashCode = hashCode * 59 + this.SuggestedPresentationDelay.GetHashCode();
                if (this.MinimumUpdatePeriod != null) hashCode = hashCode * 59 + this.MinimumUpdatePeriod.GetHashCode();
                if (this.MinBufferTime != null) hashCode = hashCode * 59 + this.MinBufferTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
