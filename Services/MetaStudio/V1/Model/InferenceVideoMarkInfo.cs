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
    /// 分身数字人推理预处理视频标记信息。
    /// </summary>
    public class InferenceVideoMarkInfo 
    {

        /// <summary>
        /// 选取推理数据预处理视频起始时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("video_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoStartTime { get; set; }

        /// <summary>
        /// 选取推理数据预处理视频结束时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("video_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoEndTime { get; set; }

        /// <summary>
        /// 选取推理数据预处理智能交互视频起始时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("chat_video_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ChatVideoStartTime { get; set; }

        /// <summary>
        /// 选取推理数据预处理智能交互视频结束时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("chat_video_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ChatVideoEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferenceVideoMarkInfo {\n");
            sb.Append("  videoStartTime: ").Append(VideoStartTime).Append("\n");
            sb.Append("  videoEndTime: ").Append(VideoEndTime).Append("\n");
            sb.Append("  chatVideoStartTime: ").Append(ChatVideoStartTime).Append("\n");
            sb.Append("  chatVideoEndTime: ").Append(ChatVideoEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferenceVideoMarkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferenceVideoMarkInfo input)
        {
            if (input == null) return false;
            if (this.VideoStartTime != input.VideoStartTime || (this.VideoStartTime != null && !this.VideoStartTime.Equals(input.VideoStartTime))) return false;
            if (this.VideoEndTime != input.VideoEndTime || (this.VideoEndTime != null && !this.VideoEndTime.Equals(input.VideoEndTime))) return false;
            if (this.ChatVideoStartTime != input.ChatVideoStartTime || (this.ChatVideoStartTime != null && !this.ChatVideoStartTime.Equals(input.ChatVideoStartTime))) return false;
            if (this.ChatVideoEndTime != input.ChatVideoEndTime || (this.ChatVideoEndTime != null && !this.ChatVideoEndTime.Equals(input.ChatVideoEndTime))) return false;

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
                if (this.VideoStartTime != null) hashCode = hashCode * 59 + this.VideoStartTime.GetHashCode();
                if (this.VideoEndTime != null) hashCode = hashCode * 59 + this.VideoEndTime.GetHashCode();
                if (this.ChatVideoStartTime != null) hashCode = hashCode * 59 + this.ChatVideoStartTime.GetHashCode();
                if (this.ChatVideoEndTime != null) hashCode = hashCode * 59 + this.ChatVideoEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
