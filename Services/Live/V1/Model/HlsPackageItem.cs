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
    /// HLS频道出流信息
    /// </summary>
    public class HlsPackageItem 
    {

        /// <summary>
        /// 客户自定义的拉流地址，包括方法、域名、路径和参数
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 从全量流中过滤出一个码率在[min, max]区间的流。如果不需要码率过滤可不选。
        /// </summary>
        [JsonProperty("stream_selection", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamSelectionItem> StreamSelection { get; set; }

        /// <summary>
        /// HLS版本号
        /// </summary>
        [JsonProperty("hls_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HlsVersion { get; set; }

        /// <summary>
        /// 频道输出分片的时长，为必选项  单位：秒。取值范围：1-10
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HlsPackageItem {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  streamSelection: ").Append(StreamSelection).Append("\n");
            sb.Append("  hlsVersion: ").Append(HlsVersion).Append("\n");
            sb.Append("  segmentDurationSeconds: ").Append(SegmentDurationSeconds).Append("\n");
            sb.Append("  playlistWindowSeconds: ").Append(PlaylistWindowSeconds).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  ads: ").Append(Ads).Append("\n");
            sb.Append("  extArgs: ").Append(ExtArgs).Append("\n");
            sb.Append("  requestArgs: ").Append(RequestArgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HlsPackageItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HlsPackageItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.StreamSelection == input.StreamSelection ||
                    this.StreamSelection != null &&
                    input.StreamSelection != null &&
                    this.StreamSelection.SequenceEqual(input.StreamSelection)
                ) && 
                (
                    this.HlsVersion == input.HlsVersion ||
                    (this.HlsVersion != null &&
                    this.HlsVersion.Equals(input.HlsVersion))
                ) && 
                (
                    this.SegmentDurationSeconds == input.SegmentDurationSeconds ||
                    (this.SegmentDurationSeconds != null &&
                    this.SegmentDurationSeconds.Equals(input.SegmentDurationSeconds))
                ) && 
                (
                    this.PlaylistWindowSeconds == input.PlaylistWindowSeconds ||
                    (this.PlaylistWindowSeconds != null &&
                    this.PlaylistWindowSeconds.Equals(input.PlaylistWindowSeconds))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.Ads == input.Ads ||
                    (this.Ads != null &&
                    this.Ads.Equals(input.Ads))
                ) && 
                (
                    this.ExtArgs == input.ExtArgs ||
                    (this.ExtArgs != null &&
                    this.ExtArgs.Equals(input.ExtArgs))
                ) && 
                (
                    this.RequestArgs == input.RequestArgs ||
                    (this.RequestArgs != null &&
                    this.RequestArgs.Equals(input.RequestArgs))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.StreamSelection != null)
                    hashCode = hashCode * 59 + this.StreamSelection.GetHashCode();
                if (this.HlsVersion != null)
                    hashCode = hashCode * 59 + this.HlsVersion.GetHashCode();
                if (this.SegmentDurationSeconds != null)
                    hashCode = hashCode * 59 + this.SegmentDurationSeconds.GetHashCode();
                if (this.PlaylistWindowSeconds != null)
                    hashCode = hashCode * 59 + this.PlaylistWindowSeconds.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.Ads != null)
                    hashCode = hashCode * 59 + this.Ads.GetHashCode();
                if (this.ExtArgs != null)
                    hashCode = hashCode * 59 + this.ExtArgs.GetHashCode();
                if (this.RequestArgs != null)
                    hashCode = hashCode * 59 + this.RequestArgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
