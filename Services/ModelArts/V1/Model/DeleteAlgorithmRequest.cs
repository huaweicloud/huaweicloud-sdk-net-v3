using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteAlgorithmRequest 
    {

        /// <summary>
        /// 算法ID。
        /// </summary>
        [SDKProperty("algorithm_id", IsPath = true)]
        [JsonProperty("algorithm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAlgorithmRequest {\n");
            sb.Append("  algorithmId: ").Append(AlgorithmId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAlgorithmRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAlgorithmRequest input)
        {
            if (input == null) return false;
            if (this.AlgorithmId != input.AlgorithmId || (this.AlgorithmId != null && !this.AlgorithmId.Equals(input.AlgorithmId))) return false;

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
                if (this.AlgorithmId != null) hashCode = hashCode * 59 + this.AlgorithmId.GetHashCode();
                return hashCode;
            }
        }
    }
}
