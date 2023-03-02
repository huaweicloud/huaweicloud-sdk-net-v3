using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 视频剪切服务推理分段参数
    /// </summary>
    public class VideoCuttingInference 
    {

        /// <summary>
        /// 视频剪切服务推理分段参数
        /// </summary>
        [JsonProperty("segment_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoSegmentInfo> SegmentInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoCuttingInference {\n");
            sb.Append("  segmentInfo: ").Append(SegmentInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoCuttingInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCuttingInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SegmentInfo == input.SegmentInfo ||
                    this.SegmentInfo != null &&
                    input.SegmentInfo != null &&
                    this.SegmentInfo.SequenceEqual(input.SegmentInfo)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SegmentInfo != null)
                    hashCode = hashCode * 59 + this.SegmentInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
