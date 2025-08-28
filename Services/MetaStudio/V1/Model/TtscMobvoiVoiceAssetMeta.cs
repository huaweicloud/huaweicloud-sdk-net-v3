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
    /// 出门问问TTS音色元数据。
    /// </summary>
    public class TtscMobvoiVoiceAssetMeta 
    {

        /// <summary>
        /// 合成音频指定发音人
        /// </summary>
        [JsonProperty("speaker", NullValueHandling = NullValueHandling.Ignore)]
        public string Speaker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtscMobvoiVoiceAssetMeta {\n");
            sb.Append("  speaker: ").Append(Speaker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtscMobvoiVoiceAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtscMobvoiVoiceAssetMeta input)
        {
            if (input == null) return false;
            if (this.Speaker != input.Speaker || (this.Speaker != null && !this.Speaker.Equals(input.Speaker))) return false;

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
                if (this.Speaker != null) hashCode = hashCode * 59 + this.Speaker.GetHashCode();
                return hashCode;
            }
        }
    }
}
