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
    /// 文本转语音任务请求。
    /// </summary>
    public class CreateAsyncTtsJobRequestBody 
    {
        /// <summary>
        /// 输出音频文件格式。默认WAV。 * WAV：wav格式。 * MP3：mp3格式。
        /// </summary>
        /// <value>输出音频文件格式。默认WAV。 * WAV：wav格式。 * MP3：mp3格式。</value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum WAV for value: WAV
            /// </summary>
            public static readonly AudioFormatEnum WAV = new AudioFormatEnum("WAV");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly AudioFormatEnum MP3 = new AudioFormatEnum("MP3");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "WAV", WAV },
                { "MP3", MP3 },
            };

            private string _value;

            public AudioFormatEnum()
            {

            }

            public AudioFormatEnum(string value)
            {
                _value = value;
            }

            public static AudioFormatEnum FromValue(string value)
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

                if (this.Equals(obj as AudioFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioFormatEnum a, AudioFormatEnum b)
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

            public static bool operator !=(AudioFormatEnum a, AudioFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 待合成文本
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 发送给tts的待合成文本
        /// </summary>
        [JsonProperty("tts_text", NullValueHandling = NullValueHandling.Ignore)]
        public string TtsText { get; set; }

        /// <summary>
        /// 音色ID，获取方式详见[获取音色ID](metastudio_02_0054.xml)。  不同Region的计费标准详见[预置音色计费标准](metastudio_02_0060.xml)。
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }

        /// <summary>
        /// 语速。 * 当取值为“100”时，表示一个成年人正常的语速，约为250字/分钟。 * 50表示0.5倍语速，100表示正常语速，200表示2倍语速。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 音高。
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量。
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }

        /// <summary>
        /// 输出音频文件格式。默认WAV。 * WAV：wav格式。 * MP3：mp3格式。
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 是否需要时间戳。false为不需要，true为需要返回时间戳信息。默认值为false。
        /// </summary>
        [JsonProperty("need_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedTimestamp { get; set; }

        /// <summary>
        /// 异常时是否返回静默音频流
        /// </summary>
        [JsonProperty("silence_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SilenceFlag { get; set; }

        /// <summary>
        /// 异常时返回的静默音频流时长，单位毫秒。
        /// </summary>
        [JsonProperty("silence_time_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? SilenceTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public TtsCallBackConfig CallbackConfig { get; set; }

        /// <summary>
        /// 是否开启字幕
        /// </summary>
        [JsonProperty("gen_srt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GenSrt { get; set; }

        /// <summary>
        /// 字幕最大长度限制
        /// </summary>
        [JsonProperty("srt_len", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrtLen { get; set; }

        /// <summary>
        /// 字幕行数限制，默认为1
        /// </summary>
        [JsonProperty("srt_line_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrtLineLimit { get; set; }

        /// <summary>
        /// 是否对文本进行分段
        /// </summary>
        [JsonProperty("slice_segments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SliceSegments { get; set; }

        /// <summary>
        /// 声道。（单声道|双声道） 默认值1，最小值1，最大值2。
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// 音频文件上传的外部URL &gt; * 需要先申请开通白名单， 才允许将音频等文件上传到外部URL。
        /// </summary>
        [JsonProperty("output_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputExternalUrl { get; set; }

        /// <summary>
        /// 字幕文件上传的外部URL &gt; * 需要先申请开通白名单， 才允许将字幕等文件上传到外部URL。
        /// </summary>
        [JsonProperty("srt_output_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SrtOutputExternalUrl { get; set; }

        /// <summary>
        /// 动作信息文件上传的外部URL &gt; * 需要先申请开通白名单， 才允许将时间戳等文件上传到外部URL。
        /// </summary>
        [JsonProperty("action_output_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionOutputExternalUrl { get; set; }

        /// <summary>
        /// 是否应用当前租户的读法配置
        /// </summary>
        [JsonProperty("is_vocabulary_config_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVocabularyConfigEnable { get; set; }

        /// <summary>
        /// 是否使用包周期路数资源进行计费
        /// </summary>
        [JsonProperty("is_concurrent_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConcurrentResource { get; set; }

        /// <summary>
        /// 优先级（0-10），0为最高优先级，默认5
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAsyncTtsJobRequestBody {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  ttsText: ").Append(TtsText).Append("\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  needTimestamp: ").Append(NeedTimestamp).Append("\n");
            sb.Append("  silenceFlag: ").Append(SilenceFlag).Append("\n");
            sb.Append("  silenceTimeMs: ").Append(SilenceTimeMs).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("  genSrt: ").Append(GenSrt).Append("\n");
            sb.Append("  srtLen: ").Append(SrtLen).Append("\n");
            sb.Append("  srtLineLimit: ").Append(SrtLineLimit).Append("\n");
            sb.Append("  sliceSegments: ").Append(SliceSegments).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("  outputExternalUrl: ").Append(OutputExternalUrl).Append("\n");
            sb.Append("  srtOutputExternalUrl: ").Append(SrtOutputExternalUrl).Append("\n");
            sb.Append("  actionOutputExternalUrl: ").Append(ActionOutputExternalUrl).Append("\n");
            sb.Append("  isVocabularyConfigEnable: ").Append(IsVocabularyConfigEnable).Append("\n");
            sb.Append("  isConcurrentResource: ").Append(IsConcurrentResource).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAsyncTtsJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAsyncTtsJobRequestBody input)
        {
            if (input == null) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.TtsText != input.TtsText || (this.TtsText != null && !this.TtsText.Equals(input.TtsText))) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.AudioFormat != input.AudioFormat) return false;
            if (this.NeedTimestamp != input.NeedTimestamp || (this.NeedTimestamp != null && !this.NeedTimestamp.Equals(input.NeedTimestamp))) return false;
            if (this.SilenceFlag != input.SilenceFlag || (this.SilenceFlag != null && !this.SilenceFlag.Equals(input.SilenceFlag))) return false;
            if (this.SilenceTimeMs != input.SilenceTimeMs || (this.SilenceTimeMs != null && !this.SilenceTimeMs.Equals(input.SilenceTimeMs))) return false;
            if (this.CallbackConfig != input.CallbackConfig || (this.CallbackConfig != null && !this.CallbackConfig.Equals(input.CallbackConfig))) return false;
            if (this.GenSrt != input.GenSrt || (this.GenSrt != null && !this.GenSrt.Equals(input.GenSrt))) return false;
            if (this.SrtLen != input.SrtLen || (this.SrtLen != null && !this.SrtLen.Equals(input.SrtLen))) return false;
            if (this.SrtLineLimit != input.SrtLineLimit || (this.SrtLineLimit != null && !this.SrtLineLimit.Equals(input.SrtLineLimit))) return false;
            if (this.SliceSegments != input.SliceSegments || (this.SliceSegments != null && !this.SliceSegments.Equals(input.SliceSegments))) return false;
            if (this.Channels != input.Channels || (this.Channels != null && !this.Channels.Equals(input.Channels))) return false;
            if (this.OutputExternalUrl != input.OutputExternalUrl || (this.OutputExternalUrl != null && !this.OutputExternalUrl.Equals(input.OutputExternalUrl))) return false;
            if (this.SrtOutputExternalUrl != input.SrtOutputExternalUrl || (this.SrtOutputExternalUrl != null && !this.SrtOutputExternalUrl.Equals(input.SrtOutputExternalUrl))) return false;
            if (this.ActionOutputExternalUrl != input.ActionOutputExternalUrl || (this.ActionOutputExternalUrl != null && !this.ActionOutputExternalUrl.Equals(input.ActionOutputExternalUrl))) return false;
            if (this.IsVocabularyConfigEnable != input.IsVocabularyConfigEnable || (this.IsVocabularyConfigEnable != null && !this.IsVocabularyConfigEnable.Equals(input.IsVocabularyConfigEnable))) return false;
            if (this.IsConcurrentResource != input.IsConcurrentResource || (this.IsConcurrentResource != null && !this.IsConcurrentResource.Equals(input.IsConcurrentResource))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.TtsText != null) hashCode = hashCode * 59 + this.TtsText.GetHashCode();
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.NeedTimestamp != null) hashCode = hashCode * 59 + this.NeedTimestamp.GetHashCode();
                if (this.SilenceFlag != null) hashCode = hashCode * 59 + this.SilenceFlag.GetHashCode();
                if (this.SilenceTimeMs != null) hashCode = hashCode * 59 + this.SilenceTimeMs.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                if (this.GenSrt != null) hashCode = hashCode * 59 + this.GenSrt.GetHashCode();
                if (this.SrtLen != null) hashCode = hashCode * 59 + this.SrtLen.GetHashCode();
                if (this.SrtLineLimit != null) hashCode = hashCode * 59 + this.SrtLineLimit.GetHashCode();
                if (this.SliceSegments != null) hashCode = hashCode * 59 + this.SliceSegments.GetHashCode();
                if (this.Channels != null) hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.OutputExternalUrl != null) hashCode = hashCode * 59 + this.OutputExternalUrl.GetHashCode();
                if (this.SrtOutputExternalUrl != null) hashCode = hashCode * 59 + this.SrtOutputExternalUrl.GetHashCode();
                if (this.ActionOutputExternalUrl != null) hashCode = hashCode * 59 + this.ActionOutputExternalUrl.GetHashCode();
                if (this.IsVocabularyConfigEnable != null) hashCode = hashCode * 59 + this.IsVocabularyConfigEnable.GetHashCode();
                if (this.IsConcurrentResource != null) hashCode = hashCode * 59 + this.IsConcurrentResource.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
