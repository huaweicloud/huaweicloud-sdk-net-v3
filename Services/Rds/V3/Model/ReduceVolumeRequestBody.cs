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
    /// 
    /// </summary>
    public class ReduceVolumeRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reduce_volume", NullValueHandling = NullValueHandling.Ignore)]
        public ReduceVolumeObject ReduceVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceVolumeRequestBody {\n");
            sb.Append("  reduceVolume: ").Append(ReduceVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReduceVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReduceVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReduceVolume == input.ReduceVolume ||
                    (this.ReduceVolume != null &&
                    this.ReduceVolume.Equals(input.ReduceVolume))
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
                if (this.ReduceVolume != null)
                    hashCode = hashCode * 59 + this.ReduceVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}
