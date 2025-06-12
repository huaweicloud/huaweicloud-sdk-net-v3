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
    /// 背景音乐配置。
    /// </summary>
    public class BackgroundMusicConfig 
    {

        /// <summary>
        /// **参数解释**： 音乐资产ID。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("music_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MusicAssetId { get; set; }

        /// <summary>
        /// **参数解释**： 音乐音量。如100，表示音量100%，50表示音量50%。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundMusicConfig {\n");
            sb.Append("  musicAssetId: ").Append(MusicAssetId).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackgroundMusicConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackgroundMusicConfig input)
        {
            if (input == null) return false;
            if (this.MusicAssetId != input.MusicAssetId || (this.MusicAssetId != null && !this.MusicAssetId.Equals(input.MusicAssetId))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;

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
                if (this.MusicAssetId != null) hashCode = hashCode * 59 + this.MusicAssetId.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }
    }
}
