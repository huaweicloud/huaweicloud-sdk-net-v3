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
    /// Response Object
    /// </summary>
    public class ShowVideoScriptResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 不涉及。 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL：竖屏。
        /// </summary>
        /// <value>**参数解释**： 横竖屏类型。 **约束限制**： 不涉及。 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL：竖屏。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewModeEnum>))]
        public class ViewModeEnum
        {
            /// <summary>
            /// Enum LANDSCAPE for value: LANDSCAPE
            /// </summary>
            public static readonly ViewModeEnum LANDSCAPE = new ViewModeEnum("LANDSCAPE");

            /// <summary>
            /// Enum VERTICAL for value: VERTICAL
            /// </summary>
            public static readonly ViewModeEnum VERTICAL = new ViewModeEnum("VERTICAL");

            private static readonly Dictionary<string, ViewModeEnum> StaticFields =
            new Dictionary<string, ViewModeEnum>()
            {
                { "LANDSCAPE", LANDSCAPE },
                { "VERTICAL", VERTICAL },
            };

            private string _value;

            public ViewModeEnum()
            {

            }

            public ViewModeEnum(string value)
            {
                _value = value;
            }

            public static ViewModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ViewModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewModeEnum a, ViewModeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ViewModeEnum a, ViewModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 数字人模型类型。 **约束限制**： 不涉及 **取值范围**： * HUMAN_MODEL_2D：分身数字人 * HUMAN_MODEL_3D：3D数字人  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 数字人模型类型。 **约束限制**： 不涉及 **取值范围**： * HUMAN_MODEL_2D：分身数字人 * HUMAN_MODEL_3D：3D数字人  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ModelAssetTypeEnum>))]
        public class ModelAssetTypeEnum
        {
            /// <summary>
            /// Enum HUMAN_MODEL_2D for value: HUMAN_MODEL_2D
            /// </summary>
            public static readonly ModelAssetTypeEnum HUMAN_MODEL_2D = new ModelAssetTypeEnum("HUMAN_MODEL_2D");

            /// <summary>
            /// Enum HUMAN_MODEL_3D for value: HUMAN_MODEL_3D
            /// </summary>
            public static readonly ModelAssetTypeEnum HUMAN_MODEL_3D = new ModelAssetTypeEnum("HUMAN_MODEL_3D");

            private static readonly Dictionary<string, ModelAssetTypeEnum> StaticFields =
            new Dictionary<string, ModelAssetTypeEnum>()
            {
                { "HUMAN_MODEL_2D", HUMAN_MODEL_2D },
                { "HUMAN_MODEL_3D", HUMAN_MODEL_3D },
            };

            private string _value;

            public ModelAssetTypeEnum()
            {

            }

            public ModelAssetTypeEnum(string value)
            {
                _value = value;
            }

            public static ModelAssetTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ModelAssetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelAssetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelAssetTypeEnum a, ModelAssetTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ModelAssetTypeEnum a, ModelAssetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 剧本名称。 **约束限制**： 不涉及。 **取值范围**： 只能使用中英文字符，字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// **参数解释**： 剧本描述。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-1024位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("script_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 不涉及。 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL：竖屏。
        /// </summary>
        [JsonProperty("view_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ViewModeEnum ViewMode { get; set; }
        /// <summary>
        /// **参数解释**： 数字人模型资产ID。 **约束限制**： 不涉及 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// **参数解释**： 数字人模型类型。 **约束限制**： 不涉及 **取值范围**： * HUMAN_MODEL_2D：分身数字人 * HUMAN_MODEL_3D：3D数字人  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("model_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public ModelAssetTypeEnum ModelAssetType { get; set; }
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
        /// **参数解释**： 场景资产ID。 **约束限制**： 分身数字人视频制作不需要填写该参数。 **取值范围**： 字符长度0-64位 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("scene_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneAssetId { get; set; }

        /// <summary>
        /// **参数解释**： 私有数据，用户填写，原样带回。 **约束限制**： 不涉及 **取值范围**： 字符长度0-8192位 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("priv_data", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivData { get; set; }

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
        [JsonProperty("audio_files", NullValueHandling = NullValueHandling.Ignore)]
        public ShootScriptAudioFiles AudioFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("action_config", NullValueHandling = NullValueHandling.Ignore)]
        public ActionConfig ActionConfig { get; set; }

        /// <summary>
        /// 拍摄脚本列表。
        /// </summary>
        [JsonProperty("shoot_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShootScriptShowItem> ShootScripts { get; set; }

        /// <summary>
        /// 剧本ID。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 剧本封面下载url。
        /// </summary>
        [JsonProperty("script_cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptCoverUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVideoScriptResponse {\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  scriptDescription: ").Append(ScriptDescription).Append("\n");
            sb.Append("  viewMode: ").Append(ViewMode).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  modelAssetType: ").Append(ModelAssetType).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  sceneAssetId: ").Append(SceneAssetId).Append("\n");
            sb.Append("  privData: ").Append(PrivData).Append("\n");
            sb.Append("  backgroundMusicConfig: ").Append(BackgroundMusicConfig).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  audioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  actionConfig: ").Append(ActionConfig).Append("\n");
            sb.Append("  shootScripts: ").Append(ShootScripts).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  scriptCoverUrl: ").Append(ScriptCoverUrl).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVideoScriptResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVideoScriptResponse input)
        {
            if (input == null) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ScriptDescription != input.ScriptDescription || (this.ScriptDescription != null && !this.ScriptDescription.Equals(input.ScriptDescription))) return false;
            if (this.ViewMode != input.ViewMode) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.ModelAssetType != input.ModelAssetType) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.SceneAssetId != input.SceneAssetId || (this.SceneAssetId != null && !this.SceneAssetId.Equals(input.SceneAssetId))) return false;
            if (this.PrivData != input.PrivData || (this.PrivData != null && !this.PrivData.Equals(input.PrivData))) return false;
            if (this.BackgroundMusicConfig != input.BackgroundMusicConfig || (this.BackgroundMusicConfig != null && !this.BackgroundMusicConfig.Equals(input.BackgroundMusicConfig))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.AudioFiles != input.AudioFiles || (this.AudioFiles != null && !this.AudioFiles.Equals(input.AudioFiles))) return false;
            if (this.ActionConfig != input.ActionConfig || (this.ActionConfig != null && !this.ActionConfig.Equals(input.ActionConfig))) return false;
            if (this.ShootScripts != input.ShootScripts || (this.ShootScripts != null && input.ShootScripts != null && !this.ShootScripts.SequenceEqual(input.ShootScripts))) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ScriptCoverUrl != input.ScriptCoverUrl || (this.ScriptCoverUrl != null && !this.ScriptCoverUrl.Equals(input.ScriptCoverUrl))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ScriptDescription != null) hashCode = hashCode * 59 + this.ScriptDescription.GetHashCode();
                hashCode = hashCode * 59 + this.ViewMode.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                hashCode = hashCode * 59 + this.ModelAssetType.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.SceneAssetId != null) hashCode = hashCode * 59 + this.SceneAssetId.GetHashCode();
                if (this.PrivData != null) hashCode = hashCode * 59 + this.PrivData.GetHashCode();
                if (this.BackgroundMusicConfig != null) hashCode = hashCode * 59 + this.BackgroundMusicConfig.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.AudioFiles != null) hashCode = hashCode * 59 + this.AudioFiles.GetHashCode();
                if (this.ActionConfig != null) hashCode = hashCode * 59 + this.ActionConfig.GetHashCode();
                if (this.ShootScripts != null) hashCode = hashCode * 59 + this.ShootScripts.GetHashCode();
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ScriptCoverUrl != null) hashCode = hashCode * 59 + this.ScriptCoverUrl.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
