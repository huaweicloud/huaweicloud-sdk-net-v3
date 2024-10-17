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
    public class CheckpointReplicateParam 
    {

        /// <summary>
        /// 本次复制是否自动触发，默认为false，代表手动触发
        /// </summary>
        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// 复制的目标项目ID
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// 复制的目标区域id
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 目标区域存储库ID
        /// </summary>
        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        /// <summary>
        /// 跨区域复制时，是否启用加速从而缩短复制的时间，如果不指定，默认不启用加速，如果启用加速，会额外收取加速的费用。
        /// </summary>
        [JsonProperty("enable_acceleration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcceleration { get; set; }

        /// <summary>
        /// 存储库ID: uuid
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointReplicateParam {\n");
            sb.Append("  autoTrigger: ").Append(AutoTrigger).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  enableAcceleration: ").Append(EnableAcceleration).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointReplicateParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointReplicateParam input)
        {
            if (input == null) return false;
            if (this.AutoTrigger != input.AutoTrigger || (this.AutoTrigger != null && !this.AutoTrigger.Equals(input.AutoTrigger))) return false;
            if (this.DestinationProjectId != input.DestinationProjectId || (this.DestinationProjectId != null && !this.DestinationProjectId.Equals(input.DestinationProjectId))) return false;
            if (this.DestinationRegion != input.DestinationRegion || (this.DestinationRegion != null && !this.DestinationRegion.Equals(input.DestinationRegion))) return false;
            if (this.DestinationVaultId != input.DestinationVaultId || (this.DestinationVaultId != null && !this.DestinationVaultId.Equals(input.DestinationVaultId))) return false;
            if (this.EnableAcceleration != input.EnableAcceleration || (this.EnableAcceleration != null && !this.EnableAcceleration.Equals(input.EnableAcceleration))) return false;
            if (this.VaultId != input.VaultId || (this.VaultId != null && !this.VaultId.Equals(input.VaultId))) return false;

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
                if (this.AutoTrigger != null) hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.DestinationProjectId != null) hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null) hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationVaultId != null) hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.EnableAcceleration != null) hashCode = hashCode * 59 + this.EnableAcceleration.GetHashCode();
                if (this.VaultId != null) hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
