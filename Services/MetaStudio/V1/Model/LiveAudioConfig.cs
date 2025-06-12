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
    /// 直播音频配置
    /// </summary>
    public class LiveAudioConfig 
    {

        /// <summary>
        /// **参数解释**： 插入音频资产的资产id，外部资产信息无需填写。若填写，可以从资产库中查询。 **约束限制**： 不涉及 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// **参数解释**： 音频URL。 **约束限制**： 仅支持MP3格式，大小&lt;100MB。输出会自动转化为单声道16KHZ采样。 **取值范围**： 字符长度0-2048位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("audio_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioUrl { get; set; }

        /// <summary>
        /// **参数解释**： 音频对应的字幕文件URL。 **约束限制**： 仅SRT格式，大小&lt;1MB。 **取值范围**： 字符长度0-2048位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("subtitle_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveAudioConfig {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  audioUrl: ").Append(AudioUrl).Append("\n");
            sb.Append("  subtitleUrl: ").Append(SubtitleUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveAudioConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveAudioConfig input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AudioUrl != input.AudioUrl || (this.AudioUrl != null && !this.AudioUrl.Equals(input.AudioUrl))) return false;
            if (this.SubtitleUrl != input.SubtitleUrl || (this.SubtitleUrl != null && !this.SubtitleUrl.Equals(input.SubtitleUrl))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AudioUrl != null) hashCode = hashCode * 59 + this.AudioUrl.GetHashCode();
                if (this.SubtitleUrl != null) hashCode = hashCode * 59 + this.SubtitleUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
