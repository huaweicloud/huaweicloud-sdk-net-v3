using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ResizePostPaidServerRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public ResizePostPaidServerOption Resize { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizePostPaidServerRequestBody {\n");
            sb.Append("  resize: ").Append(Resize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizePostPaidServerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizePostPaidServerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resize == input.Resize ||
                    (this.Resize != null &&
                    this.Resize.Equals(input.Resize))
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
                if (this.Resize != null)
                    hashCode = hashCode * 59 + this.Resize.GetHashCode();
                return hashCode;
            }
        }
    }
}
