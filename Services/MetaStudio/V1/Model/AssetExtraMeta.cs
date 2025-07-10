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
    /// **参数解释**： 资产额外元数据。  **约束限制**： 根据asset_type选择对应结构填写，填写其他不匹配的结构会被忽略。 * HUMAN_MODEL_2D: 填写human_model_2d_meta * MATERIAL：填写material_meta * VOICE_MODEL：填写voice_model_meta * VIDEO：填写video_meta * IMAGE：填写image_meta * PPT：填写ppt_meta * AUDIO: 填写audio_meta
    /// </summary>
    public class AssetExtraMeta 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_model_meta", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceModelAssetMeta VoiceModelMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ppt_meta", NullValueHandling = NullValueHandling.Ignore)]
        public PPTAssetMeta PptMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("material_meta", NullValueHandling = NullValueHandling.Ignore)]
        public MaterialAssetMeta MaterialMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("human_model_2d_meta", NullValueHandling = NullValueHandling.Ignore)]
        public HumanModel2DAssetMeta HumanModel2dMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_meta", NullValueHandling = NullValueHandling.Ignore)]
        public ImageAssetMeta ImageMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_meta", NullValueHandling = NullValueHandling.Ignore)]
        public VideoAssetMeta VideoMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_meta", NullValueHandling = NullValueHandling.Ignore)]
        public AudioAssetMeta AudioMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetExtraMeta {\n");
            sb.Append("  voiceModelMeta: ").Append(VoiceModelMeta).Append("\n");
            sb.Append("  pptMeta: ").Append(PptMeta).Append("\n");
            sb.Append("  materialMeta: ").Append(MaterialMeta).Append("\n");
            sb.Append("  humanModel2dMeta: ").Append(HumanModel2dMeta).Append("\n");
            sb.Append("  imageMeta: ").Append(ImageMeta).Append("\n");
            sb.Append("  videoMeta: ").Append(VideoMeta).Append("\n");
            sb.Append("  audioMeta: ").Append(AudioMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetExtraMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetExtraMeta input)
        {
            if (input == null) return false;
            if (this.VoiceModelMeta != input.VoiceModelMeta || (this.VoiceModelMeta != null && !this.VoiceModelMeta.Equals(input.VoiceModelMeta))) return false;
            if (this.PptMeta != input.PptMeta || (this.PptMeta != null && !this.PptMeta.Equals(input.PptMeta))) return false;
            if (this.MaterialMeta != input.MaterialMeta || (this.MaterialMeta != null && !this.MaterialMeta.Equals(input.MaterialMeta))) return false;
            if (this.HumanModel2dMeta != input.HumanModel2dMeta || (this.HumanModel2dMeta != null && !this.HumanModel2dMeta.Equals(input.HumanModel2dMeta))) return false;
            if (this.ImageMeta != input.ImageMeta || (this.ImageMeta != null && !this.ImageMeta.Equals(input.ImageMeta))) return false;
            if (this.VideoMeta != input.VideoMeta || (this.VideoMeta != null && !this.VideoMeta.Equals(input.VideoMeta))) return false;
            if (this.AudioMeta != input.AudioMeta || (this.AudioMeta != null && !this.AudioMeta.Equals(input.AudioMeta))) return false;

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
                if (this.PptMeta != null) hashCode = hashCode * 59 + this.PptMeta.GetHashCode();
                if (this.MaterialMeta != null) hashCode = hashCode * 59 + this.MaterialMeta.GetHashCode();
                if (this.HumanModel2dMeta != null) hashCode = hashCode * 59 + this.HumanModel2dMeta.GetHashCode();
                if (this.ImageMeta != null) hashCode = hashCode * 59 + this.ImageMeta.GetHashCode();
                if (this.VideoMeta != null) hashCode = hashCode * 59 + this.VideoMeta.GetHashCode();
                if (this.AudioMeta != null) hashCode = hashCode * 59 + this.AudioMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
