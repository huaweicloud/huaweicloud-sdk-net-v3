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
    /// Response Object
    /// </summary>
    public class CinderShowVolumeTransferResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transfer", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeTransfer Transfer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderShowVolumeTransferResponse {\n");
            sb.Append("  transfer: ").Append(Transfer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderShowVolumeTransferResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderShowVolumeTransferResponse input)
        {
            if (input == null) return false;
            if (this.Transfer != input.Transfer || (this.Transfer != null && !this.Transfer.Equals(input.Transfer))) return false;

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
                if (this.Transfer != null) hashCode = hashCode * 59 + this.Transfer.GetHashCode();
                return hashCode;
            }
        }
    }
}
