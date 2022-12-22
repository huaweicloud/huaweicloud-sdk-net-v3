using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 涉政场景中的人物面部信息。
    /// </summary>
    public class ImageDetectionResultDetailFaceDetail 
    {

        /// <summary>
        /// 人脸区域高度。
        /// </summary>
        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public int? H { get; set; }

        /// <summary>
        /// 人脸区域宽度。
        /// </summary>
        [JsonProperty("w", NullValueHandling = NullValueHandling.Ignore)]
        public int? W { get; set; }

        /// <summary>
        /// 人脸区域左上角到y轴距离。
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public int? X { get; set; }

        /// <summary>
        /// 人脸区域左上角到x轴距离。
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public int? Y { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultDetailFaceDetail {\n");
            sb.Append("  h: ").Append(H).Append("\n");
            sb.Append("  w: ").Append(W).Append("\n");
            sb.Append("  x: ").Append(X).Append("\n");
            sb.Append("  y: ").Append(Y).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultDetailFaceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultDetailFaceDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.W != null)
                    hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                return hashCode;
            }
        }
    }
}
