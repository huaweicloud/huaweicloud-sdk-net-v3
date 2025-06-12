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
    /// 
    /// </summary>
    public class Create2DDigitalHumanVideoReq 
    {

        /// <summary>
        /// 剧本ID。 &gt; * 如果填写了script_id，model_asset_id、voice_config、scene_asset_id、video_config、shoot_scripts可以不填，以脚本中的配置为准。 &gt; * 如果填写了script_id，并且同时也填写了model_asset_id、voice_config、scene_asset_id、video_config、shoot_scripts则以本接口中的配置为准。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 分身数字人模型资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoConfig VideoConfig { get; set; }

        /// <summary>
        /// 拍摄脚本列表。
        /// </summary>
        [JsonProperty("shoot_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShootScriptItem> ShootScripts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_asset_config", NullValueHandling = NullValueHandling.Ignore)]
        public OutputAssetConfig OutputAssetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("background_music_config", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundMusicConfig BackgroundMusicConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public CallBackConfig CallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("action_config", NullValueHandling = NullValueHandling.Ignore)]
        public ActionConfig ActionConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Create2DDigitalHumanVideoReq {\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  shootScripts: ").Append(ShootScripts).Append("\n");
            sb.Append("  outputAssetConfig: ").Append(OutputAssetConfig).Append("\n");
            sb.Append("  backgroundMusicConfig: ").Append(BackgroundMusicConfig).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("  actionConfig: ").Append(ActionConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Create2DDigitalHumanVideoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Create2DDigitalHumanVideoReq input)
        {
            if (input == null) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.ShootScripts != input.ShootScripts || (this.ShootScripts != null && input.ShootScripts != null && !this.ShootScripts.SequenceEqual(input.ShootScripts))) return false;
            if (this.OutputAssetConfig != input.OutputAssetConfig || (this.OutputAssetConfig != null && !this.OutputAssetConfig.Equals(input.OutputAssetConfig))) return false;
            if (this.BackgroundMusicConfig != input.BackgroundMusicConfig || (this.BackgroundMusicConfig != null && !this.BackgroundMusicConfig.Equals(input.BackgroundMusicConfig))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.CallbackConfig != input.CallbackConfig || (this.CallbackConfig != null && !this.CallbackConfig.Equals(input.CallbackConfig))) return false;
            if (this.ActionConfig != input.ActionConfig || (this.ActionConfig != null && !this.ActionConfig.Equals(input.ActionConfig))) return false;

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
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.ShootScripts != null) hashCode = hashCode * 59 + this.ShootScripts.GetHashCode();
                if (this.OutputAssetConfig != null) hashCode = hashCode * 59 + this.OutputAssetConfig.GetHashCode();
                if (this.BackgroundMusicConfig != null) hashCode = hashCode * 59 + this.BackgroundMusicConfig.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                if (this.ActionConfig != null) hashCode = hashCode * 59 + this.ActionConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
