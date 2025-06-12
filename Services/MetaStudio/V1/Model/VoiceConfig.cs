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
    /// 语音配置参数。
    /// </summary>
    public class VoiceConfig 
    {

        /// <summary>
        /// **参数解释**： 音色资产ID，可以从资产库中查询。 音色ID的查询操作，详见[查询预置音色ID](metastudio_02_0054.xml)。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }

        /// <summary>
        /// **参数解释**： 语速。50表示0.5倍语速，100表示正常语速，200表示2倍语速。 当取值为“100”时，表示一个成年人的正常语速，约为250字/分钟。  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// **参数解释**： 音高。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// **参数解释**： 音量。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceConfig {\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceConfig input)
        {
            if (input == null) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
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
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }
    }
}
