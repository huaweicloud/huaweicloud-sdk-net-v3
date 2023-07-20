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
    public class EnlargeVolume 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enlarge_volume", NullValueHandling = NullValueHandling.Ignore)]
        public EnlargeVolumeObject _EnlargeVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnlargeVolume {\n");
            sb.Append("  _enlargeVolume: ").Append(_EnlargeVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnlargeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnlargeVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._EnlargeVolume == input._EnlargeVolume ||
                    (this._EnlargeVolume != null &&
                    this._EnlargeVolume.Equals(input._EnlargeVolume))
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
                if (this._EnlargeVolume != null)
                    hashCode = hashCode * 59 + this._EnlargeVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}
