using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowIterationV4Request 
    {

        /// <summary>
        /// 迭代id
        /// </summary>
        [SDKProperty("iteration_id", IsPath = true)]
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IterationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIterationV4Request {\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIterationV4Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIterationV4Request input)
        {
            if (input == null) return false;
            if (this.IterationId != input.IterationId || (this.IterationId != null && !this.IterationId.Equals(input.IterationId))) return false;

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
                if (this.IterationId != null) hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
