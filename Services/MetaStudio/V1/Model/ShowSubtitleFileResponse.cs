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
    public class ShowSubtitleFileResponse : SdkResponse
    {

        /// <summary>
        /// 字幕文件所有任务状态。 * GENERATING：字幕文件任务生成中。 * GENERATED：字幕文件生成结束。
        /// </summary>
        [JsonProperty("job_state", NullValueHandling = NullValueHandling.Ignore)]
        public string JobState { get; set; }

        /// <summary>
        /// 字幕文件列表。
        /// </summary>
        [JsonProperty("subtitle_file_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubtitleFileDetail> SubtitleFileInfo { get; set; }

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
            sb.Append("class ShowSubtitleFileResponse {\n");
            sb.Append("  jobState: ").Append(JobState).Append("\n");
            sb.Append("  subtitleFileInfo: ").Append(SubtitleFileInfo).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSubtitleFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSubtitleFileResponse input)
        {
            if (input == null) return false;
            if (this.JobState != input.JobState || (this.JobState != null && !this.JobState.Equals(input.JobState))) return false;
            if (this.SubtitleFileInfo != input.SubtitleFileInfo || (this.SubtitleFileInfo != null && input.SubtitleFileInfo != null && !this.SubtitleFileInfo.SequenceEqual(input.SubtitleFileInfo))) return false;
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
                if (this.JobState != null) hashCode = hashCode * 59 + this.JobState.GetHashCode();
                if (this.SubtitleFileInfo != null) hashCode = hashCode * 59 + this.SubtitleFileInfo.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
