using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FaceQuality 
    {

        /// <summary>
        /// 人脸质量总分，取值范围[0-1]，分值越大质量越高。
        /// </summary>
        [JsonProperty("total_score", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalScore { get; set; }

        /// <summary>
        /// 模糊度，取值范围[0-1]，分值越大模糊问题越严重。
        /// </summary>
        [JsonProperty("blur", NullValueHandling = NullValueHandling.Ignore)]
        public double? Blur { get; set; }

        /// <summary>
        /// 姿态，取值范围[0-1]，分值越大姿态问题越严重。
        /// </summary>
        [JsonProperty("pose", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pose { get; set; }

        /// <summary>
        /// 遮挡，取值范围[0-1]，分值越大遮挡问题越严重。
        /// </summary>
        [JsonProperty("occlusion", NullValueHandling = NullValueHandling.Ignore)]
        public double? Occlusion { get; set; }

        /// <summary>
        /// 光照，取值范围[0-1]，分值越大光照问题越严重。
        /// </summary>
        [JsonProperty("illumination", NullValueHandling = NullValueHandling.Ignore)]
        public double? Illumination { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceQuality {\n");
            sb.Append("  totalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  blur: ").Append(Blur).Append("\n");
            sb.Append("  pose: ").Append(Pose).Append("\n");
            sb.Append("  occlusion: ").Append(Occlusion).Append("\n");
            sb.Append("  illumination: ").Append(Illumination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceQuality);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceQuality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalScore == input.TotalScore ||
                    (this.TotalScore != null &&
                    this.TotalScore.Equals(input.TotalScore))
                ) && 
                (
                    this.Blur == input.Blur ||
                    (this.Blur != null &&
                    this.Blur.Equals(input.Blur))
                ) && 
                (
                    this.Pose == input.Pose ||
                    (this.Pose != null &&
                    this.Pose.Equals(input.Pose))
                ) && 
                (
                    this.Occlusion == input.Occlusion ||
                    (this.Occlusion != null &&
                    this.Occlusion.Equals(input.Occlusion))
                ) && 
                (
                    this.Illumination == input.Illumination ||
                    (this.Illumination != null &&
                    this.Illumination.Equals(input.Illumination))
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
                if (this.TotalScore != null)
                    hashCode = hashCode * 59 + this.TotalScore.GetHashCode();
                if (this.Blur != null)
                    hashCode = hashCode * 59 + this.Blur.GetHashCode();
                if (this.Pose != null)
                    hashCode = hashCode * 59 + this.Pose.GetHashCode();
                if (this.Occlusion != null)
                    hashCode = hashCode * 59 + this.Occlusion.GetHashCode();
                if (this.Illumination != null)
                    hashCode = hashCode * 59 + this.Illumination.GetHashCode();
                return hashCode;
            }
        }
    }
}
