using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TranscodeInfoResult 
    {

        /// <summary>
        /// 转码模板名 
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 转码进度 
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 转码开始处理时间，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 等待时长，单位为秒，当值为非-1时有效 
        /// </summary>
        [JsonProperty("waiting_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitingTime { get; set; }

        /// <summary>
        /// 处理时长，单位为秒，当值为非-1时有效 
        /// </summary>
        [JsonProperty("process_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscodeInfoResult {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  waitingTime: ").Append(WaitingTime).Append("\n");
            sb.Append("  processTime: ").Append(ProcessTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TranscodeInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TranscodeInfoResult input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.WaitingTime != input.WaitingTime || (this.WaitingTime != null && !this.WaitingTime.Equals(input.WaitingTime))) return false;
            if (this.ProcessTime != input.ProcessTime || (this.ProcessTime != null && !this.ProcessTime.Equals(input.ProcessTime))) return false;

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
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.WaitingTime != null) hashCode = hashCode * 59 + this.WaitingTime.GetHashCode();
                if (this.ProcessTime != null) hashCode = hashCode * 59 + this.ProcessTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
