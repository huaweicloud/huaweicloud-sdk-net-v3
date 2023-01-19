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
    public class CheckpointReplicateRespbackups 
    {

        /// <summary>
        /// 待复制的备份ID
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 复制记录ID
        /// </summary>
        [JsonProperty("replication_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationRecordId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointReplicateRespbackups {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  replicationRecordId: ").Append(ReplicationRecordId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointReplicateRespbackups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointReplicateRespbackups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.ReplicationRecordId == input.ReplicationRecordId ||
                    (this.ReplicationRecordId != null &&
                    this.ReplicationRecordId.Equals(input.ReplicationRecordId))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.ReplicationRecordId != null)
                    hashCode = hashCode * 59 + this.ReplicationRecordId.GetHashCode();
                return hashCode;
            }
        }
    }
}
