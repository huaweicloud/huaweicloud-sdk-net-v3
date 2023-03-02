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
    /// This is a auto crerate Body Object
    /// </summary>
    public class ImageWisedesignCombineReq 
    {

        /// <summary>
        /// 画布的宽度
        /// </summary>
        [JsonProperty("canvas_w", NullValueHandling = NullValueHandling.Ignore)]
        public int? CanvasW { get; set; }

        /// <summary>
        /// 画布的高度
        /// </summary>
        [JsonProperty("canvas_h", NullValueHandling = NullValueHandling.Ignore)]
        public int? CanvasH { get; set; }

        /// <summary>
        /// 图片合成的层级详细信息
        /// </summary>
        [JsonProperty("layers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageWisedesignCombineBody> Layers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageWisedesignCombineReq {\n");
            sb.Append("  canvasW: ").Append(CanvasW).Append("\n");
            sb.Append("  canvasH: ").Append(CanvasH).Append("\n");
            sb.Append("  layers: ").Append(Layers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageWisedesignCombineReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageWisedesignCombineReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanvasW == input.CanvasW ||
                    (this.CanvasW != null &&
                    this.CanvasW.Equals(input.CanvasW))
                ) && 
                (
                    this.CanvasH == input.CanvasH ||
                    (this.CanvasH != null &&
                    this.CanvasH.Equals(input.CanvasH))
                ) && 
                (
                    this.Layers == input.Layers ||
                    this.Layers != null &&
                    input.Layers != null &&
                    this.Layers.SequenceEqual(input.Layers)
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
                if (this.CanvasW != null)
                    hashCode = hashCode * 59 + this.CanvasW.GetHashCode();
                if (this.CanvasH != null)
                    hashCode = hashCode * 59 + this.CanvasH.GetHashCode();
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
                return hashCode;
            }
        }
    }
}
