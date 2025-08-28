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
    /// 资产元数据。根据资产类型选择其中一个填写。
    /// </summary>
    public class TtscAssetExtraMeta 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_model_meta", NullValueHandling = NullValueHandling.Ignore)]
        public TtscVoiceModelAssetMeta VoiceModelMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtscAssetExtraMeta {\n");
            sb.Append("  voiceModelMeta: ").Append(VoiceModelMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtscAssetExtraMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtscAssetExtraMeta input)
        {
            if (input == null) return false;
            if (this.VoiceModelMeta != input.VoiceModelMeta || (this.VoiceModelMeta != null && !this.VoiceModelMeta.Equals(input.VoiceModelMeta))) return false;

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
                if (this.VoiceModelMeta != null) hashCode = hashCode * 59 + this.VoiceModelMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
