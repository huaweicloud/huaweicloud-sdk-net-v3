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
    /// 文本转语音任务合成记录。
    /// </summary>
    public class TtsJobDetail 
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// websocket任务ID。
        /// </summary>
        [JsonProperty("websocket_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WebsocketJobId { get; set; }

        /// <summary>
        /// 音色ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 声音版本
        /// </summary>
        [JsonProperty("tts_service_enum", NullValueHandling = NullValueHandling.Ignore)]
        public string TtsServiceEnum { get; set; }

        /// <summary>
        /// 文本长度
        /// </summary>
        [JsonProperty("text_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? TextLength { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 输出音频文件格式。默认WAV。 * WAV：wav格式。 * MP3：mp3格式。 * PCM：pcm格式。
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFormat { get; set; }

        /// <summary>
        /// 是否需要时间戳。false为不需要，true为需要返回时间戳信息。默认值为false。
        /// </summary>
        [JsonProperty("need_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedTimestamp { get; set; }

        /// <summary>
        /// 是否开启字幕
        /// </summary>
        [JsonProperty("gen_srt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GenSrt { get; set; }

        /// <summary>
        /// 任务类型。 * PRELOAD：预加载任务 * WEBSOCKET：websocket接口任务 * ASYNC_JOB：异步任务 * AUDITION：试听任务
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 任务状态。 * WAITING：等待中 * PROCESSING：合成中 * FAILED：合成失败 * SUCCEED：合成成功
        /// </summary>
        [JsonProperty("job_state", NullValueHandling = NullValueHandling.Ignore)]
        public string JobState { get; set; }

        /// <summary>
        /// 任务合成错误信息
        /// </summary>
        [JsonProperty("fail_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string FailMsg { get; set; }

        /// <summary>
        /// 任务合成文件列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<TtsJobFile> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtsJobDetail {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  websocketJobId: ").Append(WebsocketJobId).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  ttsServiceEnum: ").Append(TtsServiceEnum).Append("\n");
            sb.Append("  textLength: ").Append(TextLength).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  needTimestamp: ").Append(NeedTimestamp).Append("\n");
            sb.Append("  genSrt: ").Append(GenSrt).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobState: ").Append(JobState).Append("\n");
            sb.Append("  failMsg: ").Append(FailMsg).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtsJobDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtsJobDetail input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.WebsocketJobId != input.WebsocketJobId || (this.WebsocketJobId != null && !this.WebsocketJobId.Equals(input.WebsocketJobId))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.TtsServiceEnum != input.TtsServiceEnum || (this.TtsServiceEnum != null && !this.TtsServiceEnum.Equals(input.TtsServiceEnum))) return false;
            if (this.TextLength != input.TextLength || (this.TextLength != null && !this.TextLength.Equals(input.TextLength))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.AudioFormat != input.AudioFormat || (this.AudioFormat != null && !this.AudioFormat.Equals(input.AudioFormat))) return false;
            if (this.NeedTimestamp != input.NeedTimestamp || (this.NeedTimestamp != null && !this.NeedTimestamp.Equals(input.NeedTimestamp))) return false;
            if (this.GenSrt != input.GenSrt || (this.GenSrt != null && !this.GenSrt.Equals(input.GenSrt))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.JobState != input.JobState || (this.JobState != null && !this.JobState.Equals(input.JobState))) return false;
            if (this.FailMsg != input.FailMsg || (this.FailMsg != null && !this.FailMsg.Equals(input.FailMsg))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.WebsocketJobId != null) hashCode = hashCode * 59 + this.WebsocketJobId.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.TtsServiceEnum != null) hashCode = hashCode * 59 + this.TtsServiceEnum.GetHashCode();
                if (this.TextLength != null) hashCode = hashCode * 59 + this.TextLength.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.AudioFormat != null) hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.NeedTimestamp != null) hashCode = hashCode * 59 + this.NeedTimestamp.GetHashCode();
                if (this.GenSrt != null) hashCode = hashCode * 59 + this.GenSrt.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobState != null) hashCode = hashCode * 59 + this.JobState.GetHashCode();
                if (this.FailMsg != null) hashCode = hashCode * 59 + this.FailMsg.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
