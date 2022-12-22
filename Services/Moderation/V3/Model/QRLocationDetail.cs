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
    /// 
    /// </summary>
    public class QRLocationDetail 
    {

        /// <summary>
        /// 检测出的二维码左上角横坐标。
        /// </summary>
        [JsonProperty("top_left_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// 检测出的二维码左上角纵坐标。
        /// </summary>
        [JsonProperty("top_left_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// 检测出的二维码右下角横坐标。
        /// </summary>
        [JsonProperty("bottom_right_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? BottomRightX { get; set; }

        /// <summary>
        /// 检测出的二维码右下角纵坐标。
        /// </summary>
        [JsonProperty("bottom_right_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? BottomRightY { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QRLocationDetail {\n");
            sb.Append("  topLeftX: ").Append(TopLeftX).Append("\n");
            sb.Append("  topLeftY: ").Append(TopLeftY).Append("\n");
            sb.Append("  bottomRightX: ").Append(BottomRightX).Append("\n");
            sb.Append("  bottomRightY: ").Append(BottomRightY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QRLocationDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QRLocationDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopLeftX == input.TopLeftX ||
                    (this.TopLeftX != null &&
                    this.TopLeftX.Equals(input.TopLeftX))
                ) && 
                (
                    this.TopLeftY == input.TopLeftY ||
                    (this.TopLeftY != null &&
                    this.TopLeftY.Equals(input.TopLeftY))
                ) && 
                (
                    this.BottomRightX == input.BottomRightX ||
                    (this.BottomRightX != null &&
                    this.BottomRightX.Equals(input.BottomRightX))
                ) && 
                (
                    this.BottomRightY == input.BottomRightY ||
                    (this.BottomRightY != null &&
                    this.BottomRightY.Equals(input.BottomRightY))
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
                if (this.TopLeftX != null)
                    hashCode = hashCode * 59 + this.TopLeftX.GetHashCode();
                if (this.TopLeftY != null)
                    hashCode = hashCode * 59 + this.TopLeftY.GetHashCode();
                if (this.BottomRightX != null)
                    hashCode = hashCode * 59 + this.BottomRightX.GetHashCode();
                if (this.BottomRightY != null)
                    hashCode = hashCode * 59 + this.BottomRightY.GetHashCode();
                return hashCode;
            }
        }
    }
}
