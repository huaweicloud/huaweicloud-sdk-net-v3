using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupReplicateReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("replicate", NullValueHandling = NullValueHandling.Ignore)]
        public BackupReplicateReqBody Replicate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupReplicateReq {\n");
            sb.Append("  replicate: ").Append(Replicate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupReplicateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupReplicateReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Replicate == input.Replicate ||
                    (this.Replicate != null &&
                    this.Replicate.Equals(input.Replicate))
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
                if (this.Replicate != null)
                    hashCode = hashCode * 59 + this.Replicate.GetHashCode();
                return hashCode;
            }
        }
    }
}
