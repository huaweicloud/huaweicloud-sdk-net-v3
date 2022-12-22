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
    public class BackupSyncReq 
    {

        /// <summary>
        /// 待同步备份副本列表
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupSync> Sync { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupSyncReq {\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupSyncReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupSyncReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sync == input.Sync ||
                    this.Sync != null &&
                    input.Sync != null &&
                    this.Sync.SequenceEqual(input.Sync)
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
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                return hashCode;
            }
        }
    }
}
