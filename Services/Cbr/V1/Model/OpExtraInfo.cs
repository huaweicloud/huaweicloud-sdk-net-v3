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
    public class OpExtraInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoBckup Backup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoCommon Common { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoDelete Delete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoSync Sync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remove_resources", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoRemoveResources RemoveResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("replication", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoReplication Replication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public Resource Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoRestore Restore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vault_delete", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtendInfoVaultDelete VaultDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtraInfo {\n");
            sb.Append("  backup: ").Append(Backup).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("  removeResources: ").Append(RemoveResources).Append("\n");
            sb.Append("  replication: ").Append(Replication).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  restore: ").Append(Restore).Append("\n");
            sb.Append("  vaultDelete: ").Append(VaultDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtraInfo input)
        {
            if (input == null) return false;
            if (this.Backup != input.Backup || (this.Backup != null && !this.Backup.Equals(input.Backup))) return false;
            if (this.Common != input.Common || (this.Common != null && !this.Common.Equals(input.Common))) return false;
            if (this.Delete != input.Delete || (this.Delete != null && !this.Delete.Equals(input.Delete))) return false;
            if (this.Sync != input.Sync || (this.Sync != null && !this.Sync.Equals(input.Sync))) return false;
            if (this.RemoveResources != input.RemoveResources || (this.RemoveResources != null && !this.RemoveResources.Equals(input.RemoveResources))) return false;
            if (this.Replication != input.Replication || (this.Replication != null && !this.Replication.Equals(input.Replication))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Restore != input.Restore || (this.Restore != null && !this.Restore.Equals(input.Restore))) return false;
            if (this.VaultDelete != input.VaultDelete || (this.VaultDelete != null && !this.VaultDelete.Equals(input.VaultDelete))) return false;

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
                if (this.Backup != null) hashCode = hashCode * 59 + this.Backup.GetHashCode();
                if (this.Common != null) hashCode = hashCode * 59 + this.Common.GetHashCode();
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Sync != null) hashCode = hashCode * 59 + this.Sync.GetHashCode();
                if (this.RemoveResources != null) hashCode = hashCode * 59 + this.RemoveResources.GetHashCode();
                if (this.Replication != null) hashCode = hashCode * 59 + this.Replication.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Restore != null) hashCode = hashCode * 59 + this.Restore.GetHashCode();
                if (this.VaultDelete != null) hashCode = hashCode * 59 + this.VaultDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
