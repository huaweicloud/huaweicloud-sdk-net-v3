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
    public class BoundingBox 
    {

        /// <summary>
        /// 矩形框宽度。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 矩形框左上角纵坐标。
        /// </summary>
        [JsonProperty("top_left_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// 矩形框左上角横坐标。
        /// </summary>
        [JsonProperty("top_left_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// 矩形框高度。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoundingBox {\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  topLeftY: ").Append(TopLeftY).Append("\n");
            sb.Append("  topLeftX: ").Append(TopLeftX).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.TopLeftY == input.TopLeftY ||
                    (this.TopLeftY != null &&
                    this.TopLeftY.Equals(input.TopLeftY))
                ) && 
                (
                    this.TopLeftX == input.TopLeftX ||
                    (this.TopLeftX != null &&
                    this.TopLeftX.Equals(input.TopLeftX))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.TopLeftY != null)
                    hashCode = hashCode * 59 + this.TopLeftY.GetHashCode();
                if (this.TopLeftX != null)
                    hashCode = hashCode * 59 + this.TopLeftX.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                return hashCode;
            }
        }
    }
}
