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
    public class CheckpointReplicateRespBody 
    {

        /// <summary>
        /// 待复制的备份列表
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckpointReplicateRespbackups> Backups { get; set; }

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
        /// 目标区域存储库ID
        /// </summary>
        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        /// <summary>
        /// 执行复制的项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 备份提供商ID
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 复制的源区域
        /// </summary>
        [JsonProperty("source_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// 存储库ID
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointReplicateRespBody {\n");
            sb.Append("  backups: ").Append(Backups).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  sourceRegion: ").Append(SourceRegion).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointReplicateRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointReplicateRespBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Backups == input.Backups ||
                    this.Backups != null &&
                    input.Backups != null &&
                    this.Backups.SequenceEqual(input.Backups)
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.SourceRegion == input.SourceRegion ||
                    (this.SourceRegion != null &&
                    this.SourceRegion.Equals(input.SourceRegion))
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
                if (this.Backups != null)
                    hashCode = hashCode * 59 + this.Backups.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationVaultId != null)
                    hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.SourceRegion != null)
                    hashCode = hashCode * 59 + this.SourceRegion.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
