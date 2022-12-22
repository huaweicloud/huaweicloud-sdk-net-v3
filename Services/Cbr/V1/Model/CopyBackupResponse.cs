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
    /// Response Object
    /// </summary>
    public class CopyBackupResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("replication", NullValueHandling = NullValueHandling.Ignore)]
        public BackupReplicateRespBody Replication { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyBackupResponse {\n");
            sb.Append("  replication: ").Append(Replication).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CopyBackupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CopyBackupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Replication == input.Replication ||
                    (this.Replication != null &&
                    this.Replication.Equals(input.Replication))
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
                if (this.Replication != null)
                    hashCode = hashCode * 59 + this.Replication.GetHashCode();
                return hashCode;
            }
        }
    }
}
