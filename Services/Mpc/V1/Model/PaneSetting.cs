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
    public class PaneSetting 
    {

        /// <summary>
        /// 原视频的id。
        /// </summary>
        [JsonProperty("pane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaneId { get; set; }

        /// <summary>
        /// pane_id标记的原视频起点，在合成视频中相对于左下角的水平偏移量。 目前只支持小数类型，表示相对于输出视频宽的水平偏移比率。取值范围(0,1)。
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public string X { get; set; }

        /// <summary>
        /// pane_id标记的原视频，在合成视频中相对于左下角的垂直偏移量。 目前只支持小数型，表示相对于输出视频高的垂直偏移比率。取值范围:(0,1)。
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public string Y { get; set; }

        /// <summary>
        /// pane_id标记的原视频，在合成视频中占的宽。目前只支持小数型，范围(0,1)，表示占据合成视频宽的比率。 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }

        /// <summary>
        /// pane_id标记的原视频，在合成视频中占的高。目前只支持小数型，范围(0,1)，表示占据合成视频高的比率。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaneSetting {\n");
            sb.Append("  paneId: ").Append(PaneId).Append("\n");
            sb.Append("  x: ").Append(X).Append("\n");
            sb.Append("  y: ").Append(Y).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaneSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PaneSetting input)
        {
            if (input == null) return false;
            if (this.PaneId != input.PaneId || (this.PaneId != null && !this.PaneId.Equals(input.PaneId))) return false;
            if (this.X != input.X || (this.X != null && !this.X.Equals(input.X))) return false;
            if (this.Y != input.Y || (this.Y != null && !this.Y.Equals(input.Y))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;

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
                if (this.PaneId != null) hashCode = hashCode * 59 + this.PaneId.GetHashCode();
                if (this.X != null) hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null) hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                return hashCode;
            }
        }
    }
}
