using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 订阅选项。
    /// </summary>
    public class SubscriptionOption 
    {

        /// <summary>
        /// 独立的分发代理。  true：使用。 false：不使用。
        /// </summary>
        [JsonProperty("independent_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndependentAgent { get; set; }

        /// <summary>
        /// 快照始终可用。需要“独立的分发代理”。  true：可用。 false：不可用。
        /// </summary>
        [JsonProperty("snapshot_always_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnapshotAlwaysAvailable { get; set; }

        /// <summary>
        /// 复制架构更改。  true：可更改。 false：不可更改。
        /// </summary>
        [JsonProperty("replicate_ddl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplicateDdl { get; set; }

        /// <summary>
        /// 允许使用备份文件初始化。  true：允许。 false：不允许。
        /// </summary>
        [JsonProperty("allow_initialize_from_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowInitializeFromBackup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionOption {\n");
            sb.Append("  independentAgent: ").Append(IndependentAgent).Append("\n");
            sb.Append("  snapshotAlwaysAvailable: ").Append(SnapshotAlwaysAvailable).Append("\n");
            sb.Append("  replicateDdl: ").Append(ReplicateDdl).Append("\n");
            sb.Append("  allowInitializeFromBackup: ").Append(AllowInitializeFromBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscriptionOption input)
        {
            if (input == null) return false;
            if (this.IndependentAgent != input.IndependentAgent || (this.IndependentAgent != null && !this.IndependentAgent.Equals(input.IndependentAgent))) return false;
            if (this.SnapshotAlwaysAvailable != input.SnapshotAlwaysAvailable || (this.SnapshotAlwaysAvailable != null && !this.SnapshotAlwaysAvailable.Equals(input.SnapshotAlwaysAvailable))) return false;
            if (this.ReplicateDdl != input.ReplicateDdl || (this.ReplicateDdl != null && !this.ReplicateDdl.Equals(input.ReplicateDdl))) return false;
            if (this.AllowInitializeFromBackup != input.AllowInitializeFromBackup || (this.AllowInitializeFromBackup != null && !this.AllowInitializeFromBackup.Equals(input.AllowInitializeFromBackup))) return false;

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
                if (this.IndependentAgent != null) hashCode = hashCode * 59 + this.IndependentAgent.GetHashCode();
                if (this.SnapshotAlwaysAvailable != null) hashCode = hashCode * 59 + this.SnapshotAlwaysAvailable.GetHashCode();
                if (this.ReplicateDdl != null) hashCode = hashCode * 59 + this.ReplicateDdl.GetHashCode();
                if (this.AllowInitializeFromBackup != null) hashCode = hashCode * 59 + this.AllowInitializeFromBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
