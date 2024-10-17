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
    public class DetectFace 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bounding_box", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attributes Attributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectFace {\n");
            sb.Append("  boundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectFace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectFace input)
        {
            if (input == null) return false;
            if (this.BoundingBox != input.BoundingBox || (this.BoundingBox != null && !this.BoundingBox.Equals(input.BoundingBox))) return false;
            if (this.Attributes != input.Attributes || (this.Attributes != null && !this.Attributes.Equals(input.Attributes))) return false;

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
                if (this.BoundingBox != null) hashCode = hashCode * 59 + this.BoundingBox.GetHashCode();
                if (this.Attributes != null) hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
