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
    /// 
    /// </summary>
    public class CelebrityRecognitionResultBody 
    {

        /// <summary>
        /// 置信度，取值范围 0-1。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 名人的面部信息，包括4个值：  h：人脸区域高度  w：人脸区域宽度  x：人脸区域左上角到y轴距离  y：人脸区域左上角到x轴距离 
        /// </summary>
        [JsonProperty("face_detail", NullValueHandling = NullValueHandling.Ignore)]
        public Object FaceDetail { get; set; }

        /// <summary>
        /// label为对应的名人信息。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CelebrityRecognitionResultBody {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  faceDetail: ").Append(FaceDetail).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CelebrityRecognitionResultBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CelebrityRecognitionResultBody input)
        {
            if (input == null) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.FaceDetail != input.FaceDetail || (this.FaceDetail != null && !this.FaceDetail.Equals(input.FaceDetail))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;

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
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.FaceDetail != null) hashCode = hashCode * 59 + this.FaceDetail.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }
}
