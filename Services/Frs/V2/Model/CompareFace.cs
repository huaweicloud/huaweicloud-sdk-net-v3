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
    public class CompareFace 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bounding_box", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox BoundingBox { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareFace {\n");
            sb.Append("  boundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareFace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareFace input)
        {
            if (input == null) return false;
            if (this.BoundingBox != input.BoundingBox || (this.BoundingBox != null && !this.BoundingBox.Equals(input.BoundingBox))) return false;

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
                return hashCode;
            }
        }
    }
}
