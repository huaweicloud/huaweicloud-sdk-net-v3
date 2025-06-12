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
    /// 创视频制作脚本请求。
    /// </summary>
    public class LiveVideoScriptInfo 
    {

        /// <summary>
        /// **参数解释**： 剧本ID。 **约束限制**： 该字段无需填写。 **取值范围**： 字符长度1-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// **参数解释**： 剧本名称。 **约束限制**： 该字段必须填写。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// **参数解释**： 剧本描述。 **约束限制**： 该字段无需填写。 **取值范围**： 字符长度0-1024位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("script_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// **参数解释**： 数字人ID。对应形象和音色组合。 **约束限制**： 该字段暂未启用，无需填写。 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dh_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DhId { get; set; }

        /// <summary>
        /// **参数解释**： 数字人模型资产ID，可以从资产库中查询。 **约束限制**： 不涉及 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// 背景配置。
        /// </summary>
        [JsonProperty("background_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackgroundConfigInfo> BackgroundConfig { get; set; }

        /// <summary>
        /// 图层配置。
        /// </summary>
        [JsonProperty("layer_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<LayerConfig> LayerConfig { get; set; }

        /// <summary>
        /// 拍摄脚本列表。
        /// </summary>
        [JsonProperty("shoot_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveShootScriptItem> ShootScripts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveVideoScriptInfo {\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  scriptDescription: ").Append(ScriptDescription).Append("\n");
            sb.Append("  dhId: ").Append(DhId).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  backgroundConfig: ").Append(BackgroundConfig).Append("\n");
            sb.Append("  layerConfig: ").Append(LayerConfig).Append("\n");
            sb.Append("  shootScripts: ").Append(ShootScripts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveVideoScriptInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveVideoScriptInfo input)
        {
            if (input == null) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ScriptDescription != input.ScriptDescription || (this.ScriptDescription != null && !this.ScriptDescription.Equals(input.ScriptDescription))) return false;
            if (this.DhId != input.DhId || (this.DhId != null && !this.DhId.Equals(input.DhId))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.BackgroundConfig != input.BackgroundConfig || (this.BackgroundConfig != null && input.BackgroundConfig != null && !this.BackgroundConfig.SequenceEqual(input.BackgroundConfig))) return false;
            if (this.LayerConfig != input.LayerConfig || (this.LayerConfig != null && input.LayerConfig != null && !this.LayerConfig.SequenceEqual(input.LayerConfig))) return false;
            if (this.ShootScripts != input.ShootScripts || (this.ShootScripts != null && input.ShootScripts != null && !this.ShootScripts.SequenceEqual(input.ShootScripts))) return false;

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
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ScriptDescription != null) hashCode = hashCode * 59 + this.ScriptDescription.GetHashCode();
                if (this.DhId != null) hashCode = hashCode * 59 + this.DhId.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                if (this.BackgroundConfig != null) hashCode = hashCode * 59 + this.BackgroundConfig.GetHashCode();
                if (this.LayerConfig != null) hashCode = hashCode * 59 + this.LayerConfig.GetHashCode();
                if (this.ShootScripts != null) hashCode = hashCode * 59 + this.ShootScripts.GetHashCode();
                return hashCode;
            }
        }
    }
}
