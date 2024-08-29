using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class RetypeVolumeRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bssParam", NullValueHandling = NullValueHandling.Ignore)]
        public BssParamForRetypeVolume BssParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-retype", NullValueHandling = NullValueHandling.Ignore)]
        public RetypeVolume OsRetype { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetypeVolumeRequestBody {\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("  osRetype: ").Append(OsRetype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetypeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetypeVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
                ) && 
                (
                    this.OsRetype == input.OsRetype ||
                    (this.OsRetype != null &&
                    this.OsRetype.Equals(input.OsRetype))
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
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                if (this.OsRetype != null)
                    hashCode = hashCode * 59 + this.OsRetype.GetHashCode();
                return hashCode;
            }
        }
    }
}
