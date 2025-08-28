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
    /// 音色模型元数据。
    /// </summary>
    public class TtscVoiceModelAssetMeta 
    {

        /// <summary>
        /// 音色性别。 * UNKNOW：中性音色 * MALE：男性音色 * FEMALE：女性音色  默认UNKNOW。
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_voice_meta", NullValueHandling = NullValueHandling.Ignore)]
        public TtscExternalVoiceAssetMeta ExternalVoiceMeta { get; set; }

        /// <summary>
        /// 音色语言。 * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语  默认UNKNOW。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 语速缩放比例
        /// </summary>
        [JsonProperty("speed_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public float? SpeedRatio { get; set; }

        /// <summary>
        /// 音量缩放比例
        /// </summary>
        [JsonProperty("volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public float? VolumeRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtscVoiceModelAssetMeta {\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  externalVoiceMeta: ").Append(ExternalVoiceMeta).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  speedRatio: ").Append(SpeedRatio).Append("\n");
            sb.Append("  volumeRatio: ").Append(VolumeRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtscVoiceModelAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtscVoiceModelAssetMeta input)
        {
            if (input == null) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.ExternalVoiceMeta != input.ExternalVoiceMeta || (this.ExternalVoiceMeta != null && !this.ExternalVoiceMeta.Equals(input.ExternalVoiceMeta))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.SpeedRatio != input.SpeedRatio || (this.SpeedRatio != null && !this.SpeedRatio.Equals(input.SpeedRatio))) return false;
            if (this.VolumeRatio != input.VolumeRatio || (this.VolumeRatio != null && !this.VolumeRatio.Equals(input.VolumeRatio))) return false;

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
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.ExternalVoiceMeta != null) hashCode = hashCode * 59 + this.ExternalVoiceMeta.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SpeedRatio != null) hashCode = hashCode * 59 + this.SpeedRatio.GetHashCode();
                if (this.VolumeRatio != null) hashCode = hashCode * 59 + this.VolumeRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
