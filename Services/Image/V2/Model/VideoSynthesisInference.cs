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
    /// 视频合成服务推理参数
    /// </summary>
    public class VideoSynthesisInference 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSynthesisInfo VideoConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSynthesisInference {\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoSynthesisInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSynthesisInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoConfig == input.VideoConfig ||
                    (this.VideoConfig != null &&
                    this.VideoConfig.Equals(input.VideoConfig))
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
                if (this.VideoConfig != null)
                    hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
