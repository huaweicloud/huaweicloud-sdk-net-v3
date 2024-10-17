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
    public class ImageMainObjectDetectionInstance 
    {

        /// <summary>
        /// 主体的类别，现阶段分为：bounding_box和main_object_box
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        ///  目标检测框位置信息，包括4个值：  width：检测框区域宽度  height：检测框区域高度  top_left_x：检测框左上角到垂直轴距离  top_left_y：检测框左上角到水平轴距离 properties: width: type: string description: 检测框区域高度 example: 139.58 height: type: string description: 检测框区域高度 example: 261.32 top_left_x: type: string description: 检测框左上角到垂直轴距离 example: 256.13 top_left_y: type: string description: 检测框左上角到水平轴距离 example: 85.2 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Object Location { get; set; }

        /// <summary>
        /// 主体框的置信度,将Float型置信度转为String类型返回,Float取值范围（0~100）。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public string Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageMainObjectDetectionInstance {\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageMainObjectDetectionInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageMainObjectDetectionInstance input)
        {
            if (input == null) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;

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
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
