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
    /// 第三方TTS音色元数据。
    /// </summary>
    public class TtscExternalVoiceAssetMeta 
    {

        /// <summary>
        /// 第三方TTS供应商类型。 * XIMALAYA：喜马拉雅TTS * HUAWEI_EI：EI TTS * MOBVOI：出门问问TTS
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mobvoi_voice_meta", NullValueHandling = NullValueHandling.Ignore)]
        public TtscMobvoiVoiceAssetMeta MobvoiVoiceMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audiox_voice_meta", NullValueHandling = NullValueHandling.Ignore)]
        public TtscAudioxVoiceAssetMeta AudioxVoiceMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtscExternalVoiceAssetMeta {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  mobvoiVoiceMeta: ").Append(MobvoiVoiceMeta).Append("\n");
            sb.Append("  audioxVoiceMeta: ").Append(AudioxVoiceMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtscExternalVoiceAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtscExternalVoiceAssetMeta input)
        {
            if (input == null) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.MobvoiVoiceMeta != input.MobvoiVoiceMeta || (this.MobvoiVoiceMeta != null && !this.MobvoiVoiceMeta.Equals(input.MobvoiVoiceMeta))) return false;
            if (this.AudioxVoiceMeta != input.AudioxVoiceMeta || (this.AudioxVoiceMeta != null && !this.AudioxVoiceMeta.Equals(input.AudioxVoiceMeta))) return false;

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
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.MobvoiVoiceMeta != null) hashCode = hashCode * 59 + this.MobvoiVoiceMeta.GetHashCode();
                if (this.AudioxVoiceMeta != null) hashCode = hashCode * 59 + this.AudioxVoiceMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
