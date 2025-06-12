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
    /// 分身数字训练视频标记信息。
    /// </summary>
    public class TrainingVideoMarkInfo 
    {

        /// <summary>
        /// 训练视频起始时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("video_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoStartTime { get; set; }

        /// <summary>
        /// 训练视频结束时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("video_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingVideoMarkInfo {\n");
            sb.Append("  videoStartTime: ").Append(VideoStartTime).Append("\n");
            sb.Append("  videoEndTime: ").Append(VideoEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrainingVideoMarkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrainingVideoMarkInfo input)
        {
            if (input == null) return false;
            if (this.VideoStartTime != input.VideoStartTime || (this.VideoStartTime != null && !this.VideoStartTime.Equals(input.VideoStartTime))) return false;
            if (this.VideoEndTime != input.VideoEndTime || (this.VideoEndTime != null && !this.VideoEndTime.Equals(input.VideoEndTime))) return false;

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
                return hashCode;
            }
        }
    }
}
