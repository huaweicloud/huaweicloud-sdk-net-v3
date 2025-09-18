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
    /// 表演脚本。
    /// </summary>
    public class ShootScript 
    {
        /// <summary>
        /// **参数解释**： 脚本类型，即视频制作的驱动方式 **约束限制**： 不涉及 **取值范围** * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动
        /// </summary>
        /// <value>**参数解释**： 脚本类型，即视频制作的驱动方式 **约束限制**： 不涉及 **取值范围** * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动</value>
        [JsonConverter(typeof(EnumClassConverter<ScriptTypeEnum>))]
        public class ScriptTypeEnum
        {
            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly ScriptTypeEnum TEXT = new ScriptTypeEnum("TEXT");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly ScriptTypeEnum AUDIO = new ScriptTypeEnum("AUDIO");

            private static readonly Dictionary<string, ScriptTypeEnum> StaticFields =
            new Dictionary<string, ScriptTypeEnum>()
            {
                { "TEXT", TEXT },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public ScriptTypeEnum()
            {

            }

            public ScriptTypeEnum(string value)
            {
                _value = value;
            }

            public static ScriptTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScriptTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScriptTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScriptTypeEnum a, ScriptTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ScriptTypeEnum a, ScriptTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 脚本类型，即视频制作的驱动方式 **约束限制**： 不涉及 **取值范围** * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动
        /// </summary>
        [JsonProperty("script_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScriptTypeEnum ScriptType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text_config", NullValueHandling = NullValueHandling.Ignore)]
        public TextConfig TextConfig { get; set; }

        /// <summary>
        /// 语音驱动时，音频时长，单位秒。 &gt; * 创建剧本时此参数可以不设置，音频文件上传成功后，通过更新剧本接口设置 &gt; * 查询剧本详情时，返回音频时长，用于预估视频时长
        /// </summary>
        [JsonProperty("audio_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? AudioDuration { get; set; }

        /// <summary>
        /// 语音驱动时的动作配置。
        /// </summary>
        [JsonProperty("audio_drive_action_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioDriveActionConfig> AudioDriveActionConfig { get; set; }

        /// <summary>
        /// 语音驱动音频文件外部下载URL。  &gt; * 只支持分身数字人视频制作  &gt; * 需要先申请开通白名单后，才允许通过外部URL的音频文件来驱动分身数字人视频。  &gt; * 音频文件需要存放在华为云OBS
        /// </summary>
        [JsonProperty("audio_drive_file_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioDriveFileExternalUrl { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("audio_config", NullValueHandling = NullValueHandling.Ignore)]
        public AudioInfo AudioConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShootScript {\n");
            sb.Append("  scriptType: ").Append(ScriptType).Append("\n");
            sb.Append("  textConfig: ").Append(TextConfig).Append("\n");
            sb.Append("  audioDuration: ").Append(AudioDuration).Append("\n");
            sb.Append("  audioDriveActionConfig: ").Append(AudioDriveActionConfig).Append("\n");
            sb.Append("  audioDriveFileExternalUrl: ").Append(AudioDriveFileExternalUrl).Append("\n");
            sb.Append("  backgroundConfig: ").Append(BackgroundConfig).Append("\n");
            sb.Append("  layerConfig: ").Append(LayerConfig).Append("\n");
            sb.Append("  audioConfig: ").Append(AudioConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShootScript);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShootScript input)
        {
            if (input == null) return false;
            if (this.ScriptType != input.ScriptType) return false;
            if (this.TextConfig != input.TextConfig || (this.TextConfig != null && !this.TextConfig.Equals(input.TextConfig))) return false;
            if (this.AudioDuration != input.AudioDuration || (this.AudioDuration != null && !this.AudioDuration.Equals(input.AudioDuration))) return false;
            if (this.AudioDriveActionConfig != input.AudioDriveActionConfig || (this.AudioDriveActionConfig != null && input.AudioDriveActionConfig != null && !this.AudioDriveActionConfig.SequenceEqual(input.AudioDriveActionConfig))) return false;
            if (this.AudioDriveFileExternalUrl != input.AudioDriveFileExternalUrl || (this.AudioDriveFileExternalUrl != null && !this.AudioDriveFileExternalUrl.Equals(input.AudioDriveFileExternalUrl))) return false;
            if (this.BackgroundConfig != input.BackgroundConfig || (this.BackgroundConfig != null && input.BackgroundConfig != null && !this.BackgroundConfig.SequenceEqual(input.BackgroundConfig))) return false;
            if (this.LayerConfig != input.LayerConfig || (this.LayerConfig != null && input.LayerConfig != null && !this.LayerConfig.SequenceEqual(input.LayerConfig))) return false;
            if (this.AudioConfig != input.AudioConfig || (this.AudioConfig != null && !this.AudioConfig.Equals(input.AudioConfig))) return false;

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
                hashCode = hashCode * 59 + this.ScriptType.GetHashCode();
                if (this.TextConfig != null) hashCode = hashCode * 59 + this.TextConfig.GetHashCode();
                if (this.AudioDuration != null) hashCode = hashCode * 59 + this.AudioDuration.GetHashCode();
                if (this.AudioDriveActionConfig != null) hashCode = hashCode * 59 + this.AudioDriveActionConfig.GetHashCode();
                if (this.AudioDriveFileExternalUrl != null) hashCode = hashCode * 59 + this.AudioDriveFileExternalUrl.GetHashCode();
                if (this.BackgroundConfig != null) hashCode = hashCode * 59 + this.BackgroundConfig.GetHashCode();
                if (this.LayerConfig != null) hashCode = hashCode * 59 + this.LayerConfig.GetHashCode();
                if (this.AudioConfig != null) hashCode = hashCode * 59 + this.AudioConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
