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
    public class ListVideoMotionCaptureJobsResponse : SdkResponse
    {

        /// <summary>
        /// 视频驱动任务总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 视频驱动任务列表。
        /// </summary>
        [JsonProperty("video_motion_capture_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoMotionCaptureInfo> VideoMotionCaptureJobs { get; set; }

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
            sb.Append("class ListVideoMotionCaptureJobsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  videoMotionCaptureJobs: ").Append(VideoMotionCaptureJobs).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVideoMotionCaptureJobsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVideoMotionCaptureJobsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.VideoMotionCaptureJobs != input.VideoMotionCaptureJobs || (this.VideoMotionCaptureJobs != null && input.VideoMotionCaptureJobs != null && !this.VideoMotionCaptureJobs.SequenceEqual(input.VideoMotionCaptureJobs))) return false;
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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.VideoMotionCaptureJobs != null) hashCode = hashCode * 59 + this.VideoMotionCaptureJobs.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
