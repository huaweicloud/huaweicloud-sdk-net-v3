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
    public class CinderAcceptVolumeTransferRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accept", NullValueHandling = NullValueHandling.Ignore)]
        public CinderAcceptVolumeTransferOption Accept { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderAcceptVolumeTransferRequestBody {\n");
            sb.Append("  accept: ").Append(Accept).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderAcceptVolumeTransferRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderAcceptVolumeTransferRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accept == input.Accept ||
                    (this.Accept != null &&
                    this.Accept.Equals(input.Accept))
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
                if (this.Accept != null)
                    hashCode = hashCode * 59 + this.Accept.GetHashCode();
                return hashCode;
            }
        }
    }
}
