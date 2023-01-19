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
    /// Request Object
    /// </summary>
    public class CinderDeleteVolumeTransferRequest 
    {

        /// <summary>
        /// 云硬盘过户记录ID
        /// </summary>
        [SDKProperty("transfer_id", IsPath = true)]
        [JsonProperty("transfer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderDeleteVolumeTransferRequest {\n");
            sb.Append("  transferId: ").Append(TransferId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderDeleteVolumeTransferRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderDeleteVolumeTransferRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransferId == input.TransferId ||
                    (this.TransferId != null &&
                    this.TransferId.Equals(input.TransferId))
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
                if (this.TransferId != null)
                    hashCode = hashCode * 59 + this.TransferId.GetHashCode();
                return hashCode;
            }
        }
    }
}
