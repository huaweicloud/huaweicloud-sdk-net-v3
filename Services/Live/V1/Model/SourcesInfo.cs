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
    /// 主入流信息
    /// </summary>
    public class SourcesInfo 
    {

        /// <summary>
        /// 频道源流URL，用于外部拉流
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 码率。无需直播转码时，此参数为必填项  单位：bps。取值范围：0 - 104,857,600（100Mbps）
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 分辨率对应宽的值，非必填项  取值范围：0 - 4096（4K）
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 分辨率对应高的值，非必填项  取值范围：0 - 2160（4K）
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 描述是否使用该流做截图
        /// </summary>
        [JsonProperty("enable_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSnapshot { get; set; }

        /// <summary>
        /// 是否使用bitrate来固定码率。默认值：false
        /// </summary>
        [JsonProperty("bitrate_for3u8", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BitrateFor3u8 { get; set; }

        /// <summary>
        /// 协议为SRT_PUSH时的加密信息
        /// </summary>
        [JsonProperty("passphrase", NullValueHandling = NullValueHandling.Ignore)]
        public string Passphrase { get; set; }

        /// <summary>
        /// 备入流地址列表
        /// </summary>
        [JsonProperty("backup_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BackupUrls { get; set; }

        /// <summary>
        /// 协议为SRT_PULL时，拉流地址的streamid
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 协议为SRT_PULL时，拉流时延
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Latency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcesInfo {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  enableSnapshot: ").Append(EnableSnapshot).Append("\n");
            sb.Append("  bitrateFor3u8: ").Append(BitrateFor3u8).Append("\n");
            sb.Append("  passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  backupUrls: ").Append(BackupUrls).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourcesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourcesInfo input)
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
                    this.Bitrate == input.Bitrate ||
                    (this.Bitrate != null &&
                    this.Bitrate.Equals(input.Bitrate))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.EnableSnapshot == input.EnableSnapshot ||
                    (this.EnableSnapshot != null &&
                    this.EnableSnapshot.Equals(input.EnableSnapshot))
                ) && 
                (
                    this.BitrateFor3u8 == input.BitrateFor3u8 ||
                    (this.BitrateFor3u8 != null &&
                    this.BitrateFor3u8.Equals(input.BitrateFor3u8))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
                ) && 
                (
                    this.BackupUrls == input.BackupUrls ||
                    this.BackupUrls != null &&
                    input.BackupUrls != null &&
                    this.BackupUrls.SequenceEqual(input.BackupUrls)
                ) && 
                (
                    this.StreamId == input.StreamId ||
                    (this.StreamId != null &&
                    this.StreamId.Equals(input.StreamId))
                ) && 
                (
                    this.Latency == input.Latency ||
                    (this.Latency != null &&
                    this.Latency.Equals(input.Latency))
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
                if (this.Bitrate != null)
                    hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.EnableSnapshot != null)
                    hashCode = hashCode * 59 + this.EnableSnapshot.GetHashCode();
                if (this.BitrateFor3u8 != null)
                    hashCode = hashCode * 59 + this.BitrateFor3u8.GetHashCode();
                if (this.Passphrase != null)
                    hashCode = hashCode * 59 + this.Passphrase.GetHashCode();
                if (this.BackupUrls != null)
                    hashCode = hashCode * 59 + this.BackupUrls.GetHashCode();
                if (this.StreamId != null)
                    hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.Latency != null)
                    hashCode = hashCode * 59 + this.Latency.GetHashCode();
                return hashCode;
            }
        }
    }
}
