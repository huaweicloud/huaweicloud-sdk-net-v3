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
    /// 
    /// </summary>
    public class BatchDeleteIterationsV4RequestBody 
    {

        /// <summary>
        /// 迭代的id
        /// </summary>
        [JsonProperty("iteration_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IterationIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteIterationsV4RequestBody {\n");
            sb.Append("  iterationIds: ").Append(IterationIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteIterationsV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteIterationsV4RequestBody input)
        {
            if (input == null) return false;
            if (this.IterationIds != input.IterationIds || (this.IterationIds != null && input.IterationIds != null && !this.IterationIds.SequenceEqual(input.IterationIds))) return false;

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
                if (this.IterationIds != null) hashCode = hashCode * 59 + this.IterationIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
