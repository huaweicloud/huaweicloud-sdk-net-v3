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
    public class EnlargeVolumeRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enlarge_volume", NullValueHandling = NullValueHandling.Ignore)]
        public EnlargeVolumeObject EnlargeVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnlargeVolumeRequestBody {\n");
            sb.Append("  enlargeVolume: ").Append(EnlargeVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnlargeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnlargeVolumeRequestBody input)
        {
            if (input == null) return false;
            if (this.EnlargeVolume != input.EnlargeVolume || (this.EnlargeVolume != null && !this.EnlargeVolume.Equals(input.EnlargeVolume))) return false;

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
                if (this.EnlargeVolume != null) hashCode = hashCode * 59 + this.EnlargeVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}
