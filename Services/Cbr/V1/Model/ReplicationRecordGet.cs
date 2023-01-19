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
    public class ReplicationRecordGet 
    {
        /// <summary>
        /// 复制的状态
        /// </summary>
        /// <value>复制的状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum REPLICATING for value: replicating
            /// </summary>
            public static readonly StatusEnum REPLICATING = new StatusEnum("replicating");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum FAIL for value: fail
            /// </summary>
            public static readonly StatusEnum FAIL = new StatusEnum("fail");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly StatusEnum SKIP = new StatusEnum("skip");

            /// <summary>
            /// Enum WAITING_REPLICATE for value: waiting_replicate
            /// </summary>
            public static readonly StatusEnum WAITING_REPLICATE = new StatusEnum("waiting_replicate");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "replicating", REPLICATING },
                { "success", SUCCESS },
                { "fail", FAIL },
                { "skip", SKIP },
                { "waiting_replicate", WAITING_REPLICATE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 复制的开始时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 复制的目的备份ID
        /// </summary>
        [JsonProperty("destination_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationBackupId { get; set; }

        /// <summary>
        /// 复制的目的备份记录ID
        /// </summary>
        [JsonProperty("destination_checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationCheckpointId { get; set; }

        /// <summary>
        /// 复制的目标项目ID
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// 复制的目标区域
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 目标存储库ID
        /// </summary>
        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationRecordsExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 复制记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 复制的源备份ID
        /// </summary>
        [JsonProperty("source_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBackupId { get; set; }

        /// <summary>
        /// 复制的源备份记录ID
        /// </summary>
        [JsonProperty("source_checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCheckpointId { get; set; }

        /// <summary>
        /// 复制的源项目ID
        /// </summary>
        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProjectId { get; set; }

        /// <summary>
        /// 复制的源区域
        /// </summary>
        [JsonProperty("source_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// 复制的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 备份所在的存储库ID
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationRecordGet {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  destinationBackupId: ").Append(DestinationBackupId).Append("\n");
            sb.Append("  destinationCheckpointId: ").Append(DestinationCheckpointId).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sourceBackupId: ").Append(SourceBackupId).Append("\n");
            sb.Append("  sourceCheckpointId: ").Append(SourceCheckpointId).Append("\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("  sourceRegion: ").Append(SourceRegion).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplicationRecordGet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplicationRecordGet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DestinationBackupId == input.DestinationBackupId ||
                    (this.DestinationBackupId != null &&
                    this.DestinationBackupId.Equals(input.DestinationBackupId))
                ) && 
                (
                    this.DestinationCheckpointId == input.DestinationCheckpointId ||
                    (this.DestinationCheckpointId != null &&
                    this.DestinationCheckpointId.Equals(input.DestinationCheckpointId))
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
                ) && 
                (
                    this.DestinationRegion == input.DestinationRegion ||
                    (this.DestinationRegion != null &&
                    this.DestinationRegion.Equals(input.DestinationRegion))
                ) && 
                (
                    this.DestinationVaultId == input.DestinationVaultId ||
                    (this.DestinationVaultId != null &&
                    this.DestinationVaultId.Equals(input.DestinationVaultId))
                ) && 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SourceBackupId == input.SourceBackupId ||
                    (this.SourceBackupId != null &&
                    this.SourceBackupId.Equals(input.SourceBackupId))
                ) && 
                (
                    this.SourceCheckpointId == input.SourceCheckpointId ||
                    (this.SourceCheckpointId != null &&
                    this.SourceCheckpointId.Equals(input.SourceCheckpointId))
                ) && 
                (
                    this.SourceProjectId == input.SourceProjectId ||
                    (this.SourceProjectId != null &&
                    this.SourceProjectId.Equals(input.SourceProjectId))
                ) && 
                (
                    this.SourceRegion == input.SourceRegion ||
                    (this.SourceRegion != null &&
                    this.SourceRegion.Equals(input.SourceRegion))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DestinationBackupId != null)
                    hashCode = hashCode * 59 + this.DestinationBackupId.GetHashCode();
                if (this.DestinationCheckpointId != null)
                    hashCode = hashCode * 59 + this.DestinationCheckpointId.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationVaultId != null)
                    hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SourceBackupId != null)
                    hashCode = hashCode * 59 + this.SourceBackupId.GetHashCode();
                if (this.SourceCheckpointId != null)
                    hashCode = hashCode * 59 + this.SourceCheckpointId.GetHashCode();
                if (this.SourceProjectId != null)
                    hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                if (this.SourceRegion != null)
                    hashCode = hashCode * 59 + this.SourceRegion.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
