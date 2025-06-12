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
    public class CreateTTSAReq 
    {
        /// <summary>
        /// 脚本类型，即视频制作的驱动方式。默认TEXT * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动
        /// </summary>
        /// <value>脚本类型，即视频制作的驱动方式。默认TEXT * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动</value>
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

            public static bool operator !=(ScriptTypeEnum a, ScriptTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务类型。 * REAL_JOB：实时任务。如数字人交互。 * UNREAL_JOB：非实时任务。如数字人视频制作
        /// </summary>
        /// <value>任务类型。 * REAL_JOB：实时任务。如数字人交互。 * UNREAL_JOB：非实时任务。如数字人视频制作</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum REAL_JOB for value: REAL_JOB
            /// </summary>
            public static readonly JobTypeEnum REAL_JOB = new JobTypeEnum("REAL_JOB");

            /// <summary>
            /// Enum UNREAL_JOB for value: UNREAL_JOB
            /// </summary>
            public static readonly JobTypeEnum UNREAL_JOB = new JobTypeEnum("UNREAL_JOB");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "REAL_JOB", REAL_JOB },
                { "UNREAL_JOB", UNREAL_JOB },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
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

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
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

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 音色模型ID。需要使用MetaStudio的数字资产管理相关接口从资产库查出。
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }

        /// <summary>
        /// 脚本类型，即视频制作的驱动方式。默认TEXT * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动
        /// </summary>
        [JsonProperty("script_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScriptTypeEnum ScriptType { get; set; }
        /// <summary>
        /// HTML格式的台词，可包含动作。最多2048个字符。 &gt; * HTML格式举例：\\&lt;speak&gt;大家好&lt;insert-action id&#x3D;\\\&quot;14cc7bbcde4982aab82f9d9af9e0f743\\\&quot;/&gt;，非常高兴给大家介绍MetaStudio。\\&lt;/speak&gt; &gt; * insert-action id通过查询资产列表接口获取，查询时asset_type&#x3D;ANIMATION &gt; * 多音字标签：\\&lt;phoneme ph&#x3D;\\\&quot;拼音\\\&quot;&gt;汉字\\&lt;/phoneme&gt;，南京\\&lt;phoneme ph&#x3D;\\\&quot;shi4 zhang3\\\&quot;&gt;市长\\&lt;/phoneme&gt;江大桥。 &gt; * 停顿标签：\\&lt;break/&gt;，中方一贯主张\\&lt;break/&gt;维护国家主权平等，不干涉他国内政\\&lt;break time&#x3D;\\\&quot;300ms\\\&quot;/&gt;是联合国宪章\\&lt;break time&#x3D;\\\&quot;500ms\\\&quot;/&gt;最重要的原则。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 语音驱动音频文件下载URL。
        /// </summary>
        [JsonProperty("audio_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileDownloadUrl { get; set; }

        /// <summary>
        /// 语速。  取值范围[50,200]   默认值：100
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 基频。  取值范围[50,200]  默认值：100
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量。  取值范围[90,240]   默认值：100
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }

        /// <summary>
        /// 情感标签。 * ANGER：愤怒 * HAPPY：开心 * SAD：悲伤 * CALM：平静
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public string Emotion { get; set; }

        /// <summary>
        /// 风格化ID。需要调用数字人风格管理相关接口，从系统中查得。
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 人位置及相机位置。由如下4组浮点数组成的字符：人位置的X/Y/Z值，人角度的Pitch/Yaw/Roll值；相机位置的X/Y/Z值，相机角度的Pitch/Yaw/Roll值。
        /// </summary>
        [JsonProperty("camera_position", NullValueHandling = NullValueHandling.Ignore)]
        public string CameraPosition { get; set; }

        /// <summary>
        /// 任务类型。 * REAL_JOB：实时任务。如数字人交互。 * UNREAL_JOB：非实时任务。如数字人视频制作
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTTSAReq {\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  scriptType: ").Append(ScriptType).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  audioFileDownloadUrl: ").Append(AudioFileDownloadUrl).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  emotion: ").Append(Emotion).Append("\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  cameraPosition: ").Append(CameraPosition).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTTSAReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTTSAReq input)
        {
            if (input == null) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.ScriptType != input.ScriptType) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.AudioFileDownloadUrl != input.AudioFileDownloadUrl || (this.AudioFileDownloadUrl != null && !this.AudioFileDownloadUrl.Equals(input.AudioFileDownloadUrl))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.Emotion != input.Emotion || (this.Emotion != null && !this.Emotion.Equals(input.Emotion))) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.CameraPosition != input.CameraPosition || (this.CameraPosition != null && !this.CameraPosition.Equals(input.CameraPosition))) return false;
            if (this.JobType != input.JobType) return false;

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
                hashCode = hashCode * 59 + this.ScriptType.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.AudioFileDownloadUrl != null) hashCode = hashCode * 59 + this.AudioFileDownloadUrl.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Emotion != null) hashCode = hashCode * 59 + this.Emotion.GetHashCode();
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.CameraPosition != null) hashCode = hashCode * 59 + this.CameraPosition.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                return hashCode;
            }
        }
    }
}
