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
    public class Landmark 
    {

        /// <summary>
        /// 眼睛轮廓，Point为轮廓坐标值。
        /// </summary>
        [JsonProperty("eyes_contour", NullValueHandling = NullValueHandling.Ignore)]
        public List<Point> EyesContour { get; set; }

        /// <summary>
        /// 嘴巴轮廓，Point为轮廓坐标值。
        /// </summary>
        [JsonProperty("mouth_contour", NullValueHandling = NullValueHandling.Ignore)]
        public List<Point> MouthContour { get; set; }

        /// <summary>
        /// 人脸轮廓，Point为轮廓坐标值。
        /// </summary>
        [JsonProperty("face_contour", NullValueHandling = NullValueHandling.Ignore)]
        public List<Point> FaceContour { get; set; }

        /// <summary>
        /// 眉毛轮廓，Point为轮廓坐标值。
        /// </summary>
        [JsonProperty("eyebrow_contour", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Point>> EyebrowContour { get; set; }

        /// <summary>
        /// 鼻子轮廓，Point为轮廓坐标值。
        /// </summary>
        [JsonProperty("nose_contour", NullValueHandling = NullValueHandling.Ignore)]
        public List<Point> NoseContour { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Landmark {\n");
            sb.Append("  eyesContour: ").Append(EyesContour).Append("\n");
            sb.Append("  mouthContour: ").Append(MouthContour).Append("\n");
            sb.Append("  faceContour: ").Append(FaceContour).Append("\n");
            sb.Append("  eyebrowContour: ").Append(EyebrowContour).Append("\n");
            sb.Append("  noseContour: ").Append(NoseContour).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Landmark);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Landmark input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EyesContour == input.EyesContour ||
                    this.EyesContour != null &&
                    input.EyesContour != null &&
                    this.EyesContour.SequenceEqual(input.EyesContour)
                ) && 
                (
                    this.MouthContour == input.MouthContour ||
                    this.MouthContour != null &&
                    input.MouthContour != null &&
                    this.MouthContour.SequenceEqual(input.MouthContour)
                ) && 
                (
                    this.FaceContour == input.FaceContour ||
                    this.FaceContour != null &&
                    input.FaceContour != null &&
                    this.FaceContour.SequenceEqual(input.FaceContour)
                ) && 
                (
                    this.EyebrowContour == input.EyebrowContour ||
                    this.EyebrowContour != null &&
                    input.EyebrowContour != null &&
                    this.EyebrowContour.SequenceEqual(input.EyebrowContour)
                ) && 
                (
                    this.NoseContour == input.NoseContour ||
                    this.NoseContour != null &&
                    input.NoseContour != null &&
                    this.NoseContour.SequenceEqual(input.NoseContour)
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
                if (this.EyesContour != null)
                    hashCode = hashCode * 59 + this.EyesContour.GetHashCode();
                if (this.MouthContour != null)
                    hashCode = hashCode * 59 + this.MouthContour.GetHashCode();
                if (this.FaceContour != null)
                    hashCode = hashCode * 59 + this.FaceContour.GetHashCode();
                if (this.EyebrowContour != null)
                    hashCode = hashCode * 59 + this.EyebrowContour.GetHashCode();
                if (this.NoseContour != null)
                    hashCode = hashCode * 59 + this.NoseContour.GetHashCode();
                return hashCode;
            }
        }
    }
}
