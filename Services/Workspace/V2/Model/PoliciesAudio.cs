using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 音频。
    /// </summary>
    public class PoliciesAudio 
    {

        /// <summary>
        /// 是否开启音频重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("audio_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AudioRedirectionEnable { get; set; }

        /// <summary>
        /// 播音设置音量。 不设置音量取值为：Do Not Set Volume。 音量设置，最小值为10，最大值为100，中间取值，间隔为5的递增序列。如：10、15、20、25等。
        /// </summary>
        [JsonProperty("play_volume", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayVolume { get; set; }

        /// <summary>
        /// 播音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("play_volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayVolumeRatio { get; set; }

        /// <summary>
        /// 录音设置音量。 不设置取值为：Do Not Set Volume。 音量设置，最小值为10，最大值为100，中间取值，间隔为5的递增序列。如：10、15、20、25等。
        /// </summary>
        [JsonProperty("record_volume", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordVolume { get; set; }

        /// <summary>
        /// 录音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("record_volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordVolumeRatio { get; set; }

        /// <summary>
        /// 音频传输方式。取值为： 可靠传输：Reliable Transmission。 实时传输：Real Time Transmission。
        /// </summary>
        [JsonProperty("audio_transmission_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioTransmissionMode { get; set; }

        /// <summary>
        /// 是否开启播音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("play_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PlayRedirectionEnable { get; set; }

        /// <summary>
        /// 播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("play_classification", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayClassification { get; set; }

        /// <summary>
        /// 播音质量。取值为： 低：Low。 中：Middle。 高：High
        /// </summary>
        [JsonProperty("play_quality", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayQuality { get; set; }

        /// <summary>
        /// 播音降噪。取值为： 不开启降噪：Disable Denoising。 开启降噪，最小值为-100，最大值为-5，中间取值，间隔为5的递增序列。如：-100、-95、-90、-85等。
        /// </summary>
        [JsonProperty("play_denoising", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDenoising { get; set; }

        /// <summary>
        /// 播音增益。取值为：不开启增益：Disable AGC。开启增益，最小值为4000，最大值为32000，中间取值，从10000开始间隔为1000的递增序列。如：4000、6000、8000、10000、11000、12000、13000等。
        /// </summary>
        [JsonProperty("play_agc", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayAgc { get; set; }

        /// <summary>
        /// 播音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        [JsonProperty("play_crc", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayCrc { get; set; }

        /// <summary>
        /// 播音设置模式。取值为： 播音设备共享模式：Play Device In Shared Mode。 播音设备独占模式：Play Device In Exclusive Mode。
        /// </summary>
        [JsonProperty("play_device_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDeviceMode { get; set; }

        /// <summary>
        /// 播音控制时延阈值。取值为：最小值为160，最大值为2500。中间取值，400以下为40的递增序列，1000以下为50的递增序列。从高到低为：2500、2000、1800、1500、1200、1000、950、900、850等。
        /// </summary>
        [JsonProperty("play_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDelayThreshold { get; set; }

        /// <summary>
        /// 播音检测振幅阈值。取值为：2048、4096、5120、6144、7168、8192。
        /// </summary>
        [JsonProperty("play_amplitude_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayAmplitudeThreshold { get; set; }

        /// <summary>
        /// 播音音乐预充数据。取值为：不预充：Do Not Prefill Data。预充取值：最小值为50，最大值为2000，250以前为50的递增序列，500以前为100的递增序列。从高到低取值如：2000、1500、1000、500、400、300、250。
        /// </summary>
        [JsonProperty("play_prefill_data", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayPrefillData { get; set; }

        /// <summary>
        /// 是否开启录音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("record_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecordRedirectionEnable { get; set; }

        /// <summary>
        /// 录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("record_classification", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordClassification { get; set; }

        /// <summary>
        /// 录音质量。取值为： 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("record_quality", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordQuality { get; set; }

        /// <summary>
        /// 录音降噪。取值为： 不开启降噪：Disable Denoising。 开启降噪，最小值为-100，最大值为-5，中间取值，间隔为5的递增序列。如：-100、-95、-90、-85等。
        /// </summary>
        [JsonProperty("record_denoising", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDenoising { get; set; }

        /// <summary>
        /// 录音增益。取值为：不开启增益：Disable AGC。开启增益，最小值为4000，最大值为32000，中间取值，从10000开始间隔为1000的递增序列。如：4000、6000、8000、10000、11000、12000、13000等。
        /// </summary>
        [JsonProperty("record_agc", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordAgc { get; set; }

        /// <summary>
        /// 录音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        [JsonProperty("record_crc", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordCrc { get; set; }

        /// <summary>
        /// 录音设置模式。取值为： 播音设备共享模式：Record Device In Shared Mode。 播音设备独占模式：Record Device In Exclusive Mode。
        /// </summary>
        [JsonProperty("record_device_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDeviceMode { get; set; }

        /// <summary>
        /// 录音控制时延阈值。取值为：最小值为160，最大值为2500。中间取值，400以下为40的递增序列，1000以下为50的递增序列。从高到低为：2500、2000、1800、1500、1200、1000、950、900、850等。
        /// </summary>
        [JsonProperty("record_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelayThreshold { get; set; }

        /// <summary>
        /// 录音检测振幅阈值。取值为：2048、4096、5120、6144、7168、8192。
        /// </summary>
        [JsonProperty("record_amplitude_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordAmplitudeThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesAudio {\n");
            sb.Append("  audioRedirectionEnable: ").Append(AudioRedirectionEnable).Append("\n");
            sb.Append("  playVolume: ").Append(PlayVolume).Append("\n");
            sb.Append("  playVolumeRatio: ").Append(PlayVolumeRatio).Append("\n");
            sb.Append("  recordVolume: ").Append(RecordVolume).Append("\n");
            sb.Append("  recordVolumeRatio: ").Append(RecordVolumeRatio).Append("\n");
            sb.Append("  audioTransmissionMode: ").Append(AudioTransmissionMode).Append("\n");
            sb.Append("  playRedirectionEnable: ").Append(PlayRedirectionEnable).Append("\n");
            sb.Append("  playClassification: ").Append(PlayClassification).Append("\n");
            sb.Append("  playQuality: ").Append(PlayQuality).Append("\n");
            sb.Append("  playDenoising: ").Append(PlayDenoising).Append("\n");
            sb.Append("  playAgc: ").Append(PlayAgc).Append("\n");
            sb.Append("  playCrc: ").Append(PlayCrc).Append("\n");
            sb.Append("  playDeviceMode: ").Append(PlayDeviceMode).Append("\n");
            sb.Append("  playDelayThreshold: ").Append(PlayDelayThreshold).Append("\n");
            sb.Append("  playAmplitudeThreshold: ").Append(PlayAmplitudeThreshold).Append("\n");
            sb.Append("  playPrefillData: ").Append(PlayPrefillData).Append("\n");
            sb.Append("  recordRedirectionEnable: ").Append(RecordRedirectionEnable).Append("\n");
            sb.Append("  recordClassification: ").Append(RecordClassification).Append("\n");
            sb.Append("  recordQuality: ").Append(RecordQuality).Append("\n");
            sb.Append("  recordDenoising: ").Append(RecordDenoising).Append("\n");
            sb.Append("  recordAgc: ").Append(RecordAgc).Append("\n");
            sb.Append("  recordCrc: ").Append(RecordCrc).Append("\n");
            sb.Append("  recordDeviceMode: ").Append(RecordDeviceMode).Append("\n");
            sb.Append("  recordDelayThreshold: ").Append(RecordDelayThreshold).Append("\n");
            sb.Append("  recordAmplitudeThreshold: ").Append(RecordAmplitudeThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesAudio input)
        {
            if (input == null) return false;
            if (this.AudioRedirectionEnable != input.AudioRedirectionEnable || (this.AudioRedirectionEnable != null && !this.AudioRedirectionEnable.Equals(input.AudioRedirectionEnable))) return false;
            if (this.PlayVolume != input.PlayVolume || (this.PlayVolume != null && !this.PlayVolume.Equals(input.PlayVolume))) return false;
            if (this.PlayVolumeRatio != input.PlayVolumeRatio || (this.PlayVolumeRatio != null && !this.PlayVolumeRatio.Equals(input.PlayVolumeRatio))) return false;
            if (this.RecordVolume != input.RecordVolume || (this.RecordVolume != null && !this.RecordVolume.Equals(input.RecordVolume))) return false;
            if (this.RecordVolumeRatio != input.RecordVolumeRatio || (this.RecordVolumeRatio != null && !this.RecordVolumeRatio.Equals(input.RecordVolumeRatio))) return false;
            if (this.AudioTransmissionMode != input.AudioTransmissionMode || (this.AudioTransmissionMode != null && !this.AudioTransmissionMode.Equals(input.AudioTransmissionMode))) return false;
            if (this.PlayRedirectionEnable != input.PlayRedirectionEnable || (this.PlayRedirectionEnable != null && !this.PlayRedirectionEnable.Equals(input.PlayRedirectionEnable))) return false;
            if (this.PlayClassification != input.PlayClassification || (this.PlayClassification != null && !this.PlayClassification.Equals(input.PlayClassification))) return false;
            if (this.PlayQuality != input.PlayQuality || (this.PlayQuality != null && !this.PlayQuality.Equals(input.PlayQuality))) return false;
            if (this.PlayDenoising != input.PlayDenoising || (this.PlayDenoising != null && !this.PlayDenoising.Equals(input.PlayDenoising))) return false;
            if (this.PlayAgc != input.PlayAgc || (this.PlayAgc != null && !this.PlayAgc.Equals(input.PlayAgc))) return false;
            if (this.PlayCrc != input.PlayCrc || (this.PlayCrc != null && !this.PlayCrc.Equals(input.PlayCrc))) return false;
            if (this.PlayDeviceMode != input.PlayDeviceMode || (this.PlayDeviceMode != null && !this.PlayDeviceMode.Equals(input.PlayDeviceMode))) return false;
            if (this.PlayDelayThreshold != input.PlayDelayThreshold || (this.PlayDelayThreshold != null && !this.PlayDelayThreshold.Equals(input.PlayDelayThreshold))) return false;
            if (this.PlayAmplitudeThreshold != input.PlayAmplitudeThreshold || (this.PlayAmplitudeThreshold != null && !this.PlayAmplitudeThreshold.Equals(input.PlayAmplitudeThreshold))) return false;
            if (this.PlayPrefillData != input.PlayPrefillData || (this.PlayPrefillData != null && !this.PlayPrefillData.Equals(input.PlayPrefillData))) return false;
            if (this.RecordRedirectionEnable != input.RecordRedirectionEnable || (this.RecordRedirectionEnable != null && !this.RecordRedirectionEnable.Equals(input.RecordRedirectionEnable))) return false;
            if (this.RecordClassification != input.RecordClassification || (this.RecordClassification != null && !this.RecordClassification.Equals(input.RecordClassification))) return false;
            if (this.RecordQuality != input.RecordQuality || (this.RecordQuality != null && !this.RecordQuality.Equals(input.RecordQuality))) return false;
            if (this.RecordDenoising != input.RecordDenoising || (this.RecordDenoising != null && !this.RecordDenoising.Equals(input.RecordDenoising))) return false;
            if (this.RecordAgc != input.RecordAgc || (this.RecordAgc != null && !this.RecordAgc.Equals(input.RecordAgc))) return false;
            if (this.RecordCrc != input.RecordCrc || (this.RecordCrc != null && !this.RecordCrc.Equals(input.RecordCrc))) return false;
            if (this.RecordDeviceMode != input.RecordDeviceMode || (this.RecordDeviceMode != null && !this.RecordDeviceMode.Equals(input.RecordDeviceMode))) return false;
            if (this.RecordDelayThreshold != input.RecordDelayThreshold || (this.RecordDelayThreshold != null && !this.RecordDelayThreshold.Equals(input.RecordDelayThreshold))) return false;
            if (this.RecordAmplitudeThreshold != input.RecordAmplitudeThreshold || (this.RecordAmplitudeThreshold != null && !this.RecordAmplitudeThreshold.Equals(input.RecordAmplitudeThreshold))) return false;

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
                if (this.AudioRedirectionEnable != null) hashCode = hashCode * 59 + this.AudioRedirectionEnable.GetHashCode();
                if (this.PlayVolume != null) hashCode = hashCode * 59 + this.PlayVolume.GetHashCode();
                if (this.PlayVolumeRatio != null) hashCode = hashCode * 59 + this.PlayVolumeRatio.GetHashCode();
                if (this.RecordVolume != null) hashCode = hashCode * 59 + this.RecordVolume.GetHashCode();
                if (this.RecordVolumeRatio != null) hashCode = hashCode * 59 + this.RecordVolumeRatio.GetHashCode();
                if (this.AudioTransmissionMode != null) hashCode = hashCode * 59 + this.AudioTransmissionMode.GetHashCode();
                if (this.PlayRedirectionEnable != null) hashCode = hashCode * 59 + this.PlayRedirectionEnable.GetHashCode();
                if (this.PlayClassification != null) hashCode = hashCode * 59 + this.PlayClassification.GetHashCode();
                if (this.PlayQuality != null) hashCode = hashCode * 59 + this.PlayQuality.GetHashCode();
                if (this.PlayDenoising != null) hashCode = hashCode * 59 + this.PlayDenoising.GetHashCode();
                if (this.PlayAgc != null) hashCode = hashCode * 59 + this.PlayAgc.GetHashCode();
                if (this.PlayCrc != null) hashCode = hashCode * 59 + this.PlayCrc.GetHashCode();
                if (this.PlayDeviceMode != null) hashCode = hashCode * 59 + this.PlayDeviceMode.GetHashCode();
                if (this.PlayDelayThreshold != null) hashCode = hashCode * 59 + this.PlayDelayThreshold.GetHashCode();
                if (this.PlayAmplitudeThreshold != null) hashCode = hashCode * 59 + this.PlayAmplitudeThreshold.GetHashCode();
                if (this.PlayPrefillData != null) hashCode = hashCode * 59 + this.PlayPrefillData.GetHashCode();
                if (this.RecordRedirectionEnable != null) hashCode = hashCode * 59 + this.RecordRedirectionEnable.GetHashCode();
                if (this.RecordClassification != null) hashCode = hashCode * 59 + this.RecordClassification.GetHashCode();
                if (this.RecordQuality != null) hashCode = hashCode * 59 + this.RecordQuality.GetHashCode();
                if (this.RecordDenoising != null) hashCode = hashCode * 59 + this.RecordDenoising.GetHashCode();
                if (this.RecordAgc != null) hashCode = hashCode * 59 + this.RecordAgc.GetHashCode();
                if (this.RecordCrc != null) hashCode = hashCode * 59 + this.RecordCrc.GetHashCode();
                if (this.RecordDeviceMode != null) hashCode = hashCode * 59 + this.RecordDeviceMode.GetHashCode();
                if (this.RecordDelayThreshold != null) hashCode = hashCode * 59 + this.RecordDelayThreshold.GetHashCode();
                if (this.RecordAmplitudeThreshold != null) hashCode = hashCode * 59 + this.RecordAmplitudeThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
