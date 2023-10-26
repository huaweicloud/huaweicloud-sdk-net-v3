using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackUpInfoResponse : SdkResponse
    {

        /// <summary>
        /// 是否备份
        /// </summary>
        [JsonProperty("is_additional_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdditionalBackup { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 节点IP
        /// </summary>
        [JsonProperty("node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIp { get; set; }

        /// <summary>
        /// 节点角色
        /// </summary>
        [JsonProperty("node_role", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeRole { get; set; }

        /// <summary>
        /// 备份周期
        /// </summary>
        [JsonProperty("backup_period", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackUpInfoResponse {\n");
            sb.Append("  isAdditionalBackup: ").Append(IsAdditionalBackup).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeIp: ").Append(NodeIp).Append("\n");
            sb.Append("  nodeRole: ").Append(NodeRole).Append("\n");
            sb.Append("  backupPeriod: ").Append(BackupPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackUpInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackUpInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAdditionalBackup == input.IsAdditionalBackup ||
                    (this.IsAdditionalBackup != null &&
                    this.IsAdditionalBackup.Equals(input.IsAdditionalBackup))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.NodeRole == input.NodeRole ||
                    (this.NodeRole != null &&
                    this.NodeRole.Equals(input.NodeRole))
                ) && 
                (
                    this.BackupPeriod == input.BackupPeriod ||
                    (this.BackupPeriod != null &&
                    this.BackupPeriod.Equals(input.BackupPeriod))
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
                if (this.IsAdditionalBackup != null)
                    hashCode = hashCode * 59 + this.IsAdditionalBackup.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.NodeRole != null)
                    hashCode = hashCode * 59 + this.NodeRole.GetHashCode();
                if (this.BackupPeriod != null)
                    hashCode = hashCode * 59 + this.BackupPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
