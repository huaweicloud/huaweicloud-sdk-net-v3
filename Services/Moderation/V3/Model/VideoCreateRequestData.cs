using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 视频数据输入
    /// </summary>
    public class VideoCreateRequestData 
    {

        /// <summary>
        /// 视频url地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 截帧频率间隔，单位为秒，取值范围为1~60s；若不传递默认5s截帧一次
        /// </summary>
        [JsonProperty("frame_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoCreateRequestData {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  frameInterval: ").Append(FrameInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoCreateRequestData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCreateRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.FrameInterval == input.FrameInterval ||
                    (this.FrameInterval != null &&
                    this.FrameInterval.Equals(input.FrameInterval))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.FrameInterval != null)
                    hashCode = hashCode * 59 + this.FrameInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
