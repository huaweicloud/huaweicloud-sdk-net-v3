using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QualityEnhanceVideo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_denoise", NullValueHandling = NullValueHandling.Ignore)]
        public VideoDenoise VideoDenoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_sharp", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSharp VideoSharp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_contrast", NullValueHandling = NullValueHandling.Ignore)]
        public VideoContrast VideoContrast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_superresolution", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSuperresolution VideoSuperresolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_deblock", NullValueHandling = NullValueHandling.Ignore)]
        public VideoDeblock VideoDeblock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_saturation", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSaturation VideoSaturation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityEnhanceVideo {\n");
            sb.Append("  videoDenoise: ").Append(VideoDenoise).Append("\n");
            sb.Append("  videoSharp: ").Append(VideoSharp).Append("\n");
            sb.Append("  videoContrast: ").Append(VideoContrast).Append("\n");
            sb.Append("  videoSuperresolution: ").Append(VideoSuperresolution).Append("\n");
            sb.Append("  videoDeblock: ").Append(VideoDeblock).Append("\n");
            sb.Append("  videoSaturation: ").Append(VideoSaturation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualityEnhanceVideo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualityEnhanceVideo input)
        {
            if (input == null) return false;
            if (this.VideoDenoise != input.VideoDenoise || (this.VideoDenoise != null && !this.VideoDenoise.Equals(input.VideoDenoise))) return false;
            if (this.VideoSharp != input.VideoSharp || (this.VideoSharp != null && !this.VideoSharp.Equals(input.VideoSharp))) return false;
            if (this.VideoContrast != input.VideoContrast || (this.VideoContrast != null && !this.VideoContrast.Equals(input.VideoContrast))) return false;
            if (this.VideoSuperresolution != input.VideoSuperresolution || (this.VideoSuperresolution != null && !this.VideoSuperresolution.Equals(input.VideoSuperresolution))) return false;
            if (this.VideoDeblock != input.VideoDeblock || (this.VideoDeblock != null && !this.VideoDeblock.Equals(input.VideoDeblock))) return false;
            if (this.VideoSaturation != input.VideoSaturation || (this.VideoSaturation != null && !this.VideoSaturation.Equals(input.VideoSaturation))) return false;

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
                if (this.VideoDenoise != null) hashCode = hashCode * 59 + this.VideoDenoise.GetHashCode();
                if (this.VideoSharp != null) hashCode = hashCode * 59 + this.VideoSharp.GetHashCode();
                if (this.VideoContrast != null) hashCode = hashCode * 59 + this.VideoContrast.GetHashCode();
                if (this.VideoSuperresolution != null) hashCode = hashCode * 59 + this.VideoSuperresolution.GetHashCode();
                if (this.VideoDeblock != null) hashCode = hashCode * 59 + this.VideoDeblock.GetHashCode();
                if (this.VideoSaturation != null) hashCode = hashCode * 59 + this.VideoSaturation.GetHashCode();
                return hashCode;
            }
        }
    }
}
