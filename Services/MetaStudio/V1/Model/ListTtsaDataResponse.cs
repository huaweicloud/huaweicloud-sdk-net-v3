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
    public class ListTtsaDataResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 驱动任务开始时间，格式遵循：RFC 3339， 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 驱动任务结束时间，格式遵循：RFC 3339， 例 “2020-07-30T10:45:17Z”
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否为尾部(任务数据已全部生成，后续没有新的数据)
        /// </summary>
        [JsonProperty("is_tail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTail { get; set; }

        /// <summary>
        /// 音频数据，Base64编码，1秒内的数据。
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public string Audio { get; set; }

        /// <summary>
        /// 语音驱动的表情基数据。
        /// </summary>
        [JsonProperty("blendshapes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Blendshapes { get; set; }

        /// <summary>
        /// 手工指定的动作库动作数据。
        /// </summary>
        [JsonProperty("animations", NullValueHandling = NullValueHandling.Ignore)]
        public List<AnimationItem> Animations { get; set; }

        /// <summary>
        /// 语义驱动的智能动作数据。
        /// </summary>
        [JsonProperty("motions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MotionItem> Motions { get; set; }

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
            sb.Append("class ListTtsaDataResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  isTail: ").Append(IsTail).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  blendshapes: ").Append(Blendshapes).Append("\n");
            sb.Append("  animations: ").Append(Animations).Append("\n");
            sb.Append("  motions: ").Append(Motions).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTtsaDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTtsaDataResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.IsTail != input.IsTail || (this.IsTail != null && !this.IsTail.Equals(input.IsTail))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;
            if (this.Blendshapes != input.Blendshapes || (this.Blendshapes != null && input.Blendshapes != null && !this.Blendshapes.SequenceEqual(input.Blendshapes))) return false;
            if (this.Animations != input.Animations || (this.Animations != null && input.Animations != null && !this.Animations.SequenceEqual(input.Animations))) return false;
            if (this.Motions != input.Motions || (this.Motions != null && input.Motions != null && !this.Motions.SequenceEqual(input.Motions))) return false;
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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsTail != null) hashCode = hashCode * 59 + this.IsTail.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Blendshapes != null) hashCode = hashCode * 59 + this.Blendshapes.GetHashCode();
                if (this.Animations != null) hashCode = hashCode * 59 + this.Animations.GetHashCode();
                if (this.Motions != null) hashCode = hashCode * 59 + this.Motions.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
