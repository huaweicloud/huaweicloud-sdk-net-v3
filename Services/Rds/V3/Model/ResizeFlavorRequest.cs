using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 变更实例规格时必填。
    /// </summary>
    public class ResizeFlavorRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public ResizeFlavorObject ResizeFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeFlavorRequest {\n");
            sb.Append("  resizeFlavor: ").Append(ResizeFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeFlavorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeFlavorRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResizeFlavor == input.ResizeFlavor ||
                    (this.ResizeFlavor != null &&
                    this.ResizeFlavor.Equals(input.ResizeFlavor))
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
                if (this.ResizeFlavor != null)
                    hashCode = hashCode * 59 + this.ResizeFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
