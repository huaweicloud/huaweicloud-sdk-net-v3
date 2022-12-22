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
    public class ImageTaggingInstance 
    {

        /// <summary>
        /// 目标检测框位置信息，包括4个值：  width：检测框区域宽度  height：检测框区域高度  top_left_x：检测框左上角到垂直轴距离  top_left_y：检测框左上角到水平轴距离 
        /// </summary>
        [JsonProperty("bounding_box", NullValueHandling = NullValueHandling.Ignore)]
        public Object BoundingBox { get; set; }

        /// <summary>
        /// 检测标签置信度,将Float型置信度转为String类型返回,Float取值范围（0~100）。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public string Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTaggingInstance {\n");
            sb.Append("  boundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageTaggingInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageTaggingInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundingBox == input.BoundingBox ||
                    (this.BoundingBox != null &&
                    this.BoundingBox.Equals(input.BoundingBox))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.BoundingBox != null)
                    hashCode = hashCode * 59 + this.BoundingBox.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
