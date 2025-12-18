using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 备份限速。 **取值范围**: 0-1024
        /// </summary>
        [JsonProperty("rate_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? RateLimit { get; set; }

        /// <summary>
        /// **参数解释**: 增备预取页面个数。 **取值范围**: 1-8192
        /// </summary>
        [JsonProperty("prefetch_block", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefetchBlock { get; set; }

        /// <summary>
        /// **参数解释**: 分片大小。 **取值范围**: 0-1024
        /// </summary>
        [JsonProperty("file_split_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSplitSize { get; set; }

        /// <summary>
        /// **参数解释**: 启用备机备份标识。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("enable_standby_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStandbyBackup { get; set; }

        /// <summary>
        /// **参数解释**: 是否关闭压缩。 **取值范围**: true,false
        /// </summary>
        [JsonProperty("close_compression", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloseCompression { get; set; }

        /// <summary>
        /// **参数解释**: 默认备份介质。 **取值范围**: - OBS 对象存储
        /// </summary>
        [JsonProperty("default_backup_media_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBackupMediaType { get; set; }

        /// <summary>
        /// **参数解释**: 默认备份方式。 **取值范围**: - EBACKUP 快照备份 - PHYSICAL_BACKUP 物理备份
        /// </summary>
        [JsonProperty("default_backup_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBackupMethod { get; set; }

        /// <summary>
        /// **参数解释**: 备份并行参数。 **取值范围**: 1, 2, 4, 8
        /// </summary>
        [JsonProperty("backup_parallel_degree", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupParallelDegree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_node_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupNodeInfoResult BackupNodeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationResponse {\n");
            sb.Append("  rateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("  prefetchBlock: ").Append(PrefetchBlock).Append("\n");
            sb.Append("  fileSplitSize: ").Append(FileSplitSize).Append("\n");
            sb.Append("  enableStandbyBackup: ").Append(EnableStandbyBackup).Append("\n");
            sb.Append("  closeCompression: ").Append(CloseCompression).Append("\n");
            sb.Append("  defaultBackupMediaType: ").Append(DefaultBackupMediaType).Append("\n");
            sb.Append("  defaultBackupMethod: ").Append(DefaultBackupMethod).Append("\n");
            sb.Append("  backupParallelDegree: ").Append(BackupParallelDegree).Append("\n");
            sb.Append("  backupNodeInfo: ").Append(BackupNodeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.RateLimit != input.RateLimit || (this.RateLimit != null && !this.RateLimit.Equals(input.RateLimit))) return false;
            if (this.PrefetchBlock != input.PrefetchBlock || (this.PrefetchBlock != null && !this.PrefetchBlock.Equals(input.PrefetchBlock))) return false;
            if (this.FileSplitSize != input.FileSplitSize || (this.FileSplitSize != null && !this.FileSplitSize.Equals(input.FileSplitSize))) return false;
            if (this.EnableStandbyBackup != input.EnableStandbyBackup || (this.EnableStandbyBackup != null && !this.EnableStandbyBackup.Equals(input.EnableStandbyBackup))) return false;
            if (this.CloseCompression != input.CloseCompression || (this.CloseCompression != null && !this.CloseCompression.Equals(input.CloseCompression))) return false;
            if (this.DefaultBackupMediaType != input.DefaultBackupMediaType || (this.DefaultBackupMediaType != null && !this.DefaultBackupMediaType.Equals(input.DefaultBackupMediaType))) return false;
            if (this.DefaultBackupMethod != input.DefaultBackupMethod || (this.DefaultBackupMethod != null && !this.DefaultBackupMethod.Equals(input.DefaultBackupMethod))) return false;
            if (this.BackupParallelDegree != input.BackupParallelDegree || (this.BackupParallelDegree != null && !this.BackupParallelDegree.Equals(input.BackupParallelDegree))) return false;
            if (this.BackupNodeInfo != input.BackupNodeInfo || (this.BackupNodeInfo != null && !this.BackupNodeInfo.Equals(input.BackupNodeInfo))) return false;

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
                if (this.RateLimit != null) hashCode = hashCode * 59 + this.RateLimit.GetHashCode();
                if (this.PrefetchBlock != null) hashCode = hashCode * 59 + this.PrefetchBlock.GetHashCode();
                if (this.FileSplitSize != null) hashCode = hashCode * 59 + this.FileSplitSize.GetHashCode();
                if (this.EnableStandbyBackup != null) hashCode = hashCode * 59 + this.EnableStandbyBackup.GetHashCode();
                if (this.CloseCompression != null) hashCode = hashCode * 59 + this.CloseCompression.GetHashCode();
                if (this.DefaultBackupMediaType != null) hashCode = hashCode * 59 + this.DefaultBackupMediaType.GetHashCode();
                if (this.DefaultBackupMethod != null) hashCode = hashCode * 59 + this.DefaultBackupMethod.GetHashCode();
                if (this.BackupParallelDegree != null) hashCode = hashCode * 59 + this.BackupParallelDegree.GetHashCode();
                if (this.BackupNodeInfo != null) hashCode = hashCode * 59 + this.BackupNodeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
