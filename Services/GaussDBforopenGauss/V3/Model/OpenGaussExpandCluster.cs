using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// CN横向扩容/DN分片扩容时必填
    /// </summary>
    public class OpenGaussExpandCluster 
    {

        /// <summary>
        /// CN横向扩容时必填
        /// </summary>
        [JsonProperty("coordinators", NullValueHandling = NullValueHandling.Ignore)]
        public List<OpenGaussCoordinators> Coordinators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shard", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussShard Shard { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussExpandCluster {\n");
            sb.Append("  coordinators: ").Append(Coordinators).Append("\n");
            sb.Append("  shard: ").Append(Shard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussExpandCluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussExpandCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Coordinators == input.Coordinators ||
                    this.Coordinators != null &&
                    input.Coordinators != null &&
                    this.Coordinators.SequenceEqual(input.Coordinators)
                ) && 
                (
                    this.Shard == input.Shard ||
                    (this.Shard != null &&
                    this.Shard.Equals(input.Shard))
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
                if (this.Coordinators != null)
                    hashCode = hashCode * 59 + this.Coordinators.GetHashCode();
                if (this.Shard != null)
                    hashCode = hashCode * 59 + this.Shard.GetHashCode();
                return hashCode;
            }
        }
    }
}
