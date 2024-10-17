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
    /// 目标检测框位置信息
    /// </summary>
    public class BoundingBox 
    {

        /// <summary>
        /// 检测框区域宽度
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 检测框区域高度
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 检测框左上角到垂直轴距离
        /// </summary>
        [JsonProperty("top_left_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// 检测框左上角到水平轴距离
        /// </summary>
        [JsonProperty("top_left_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftY { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoundingBox {\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  topLeftX: ").Append(TopLeftX).Append("\n");
            sb.Append("  topLeftY: ").Append(TopLeftY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BoundingBox);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BoundingBox input)
        {
            if (input == null) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.TopLeftX != input.TopLeftX || (this.TopLeftX != null && !this.TopLeftX.Equals(input.TopLeftX))) return false;
            if (this.TopLeftY != input.TopLeftY || (this.TopLeftY != null && !this.TopLeftY.Equals(input.TopLeftY))) return false;

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
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.TopLeftX != null) hashCode = hashCode * 59 + this.TopLeftX.GetHashCode();
                if (this.TopLeftY != null) hashCode = hashCode * 59 + this.TopLeftY.GetHashCode();
                return hashCode;
            }
        }
    }
}
