using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// **参数解释：** 备份信息。 **约束限制：** 支持按指定备份恢复和按指定实例的指定时间点恢复。 目前仅GeminiDB Cassandra和GeminiDB Influx集群支持按指定实例的指定时间点恢复。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
    /// </summary>
    public class RestoreInfo 
    {

        /// <summary>
        /// **参数解释：** 全量备份文件ID。 **约束限制：** 用于根据指定备份恢复数据到一个新创建的实例的场景，此场景下该字段取值不能为空。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// **参数解释：** 数据恢复参考的指定实例的ID。 **约束限制：** 用于恢复指定实例的指定时间点的数据到一个新创建的实例的场景，此场景下该字段取值不能为空。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 数据恢复的指定的时间点。 **约束限制：** 用于恢复指定实例的指定时间点的数据到一个新创建的实例的场景，此场景下该字段取值不能为空。 **取值范围：** 取值为UTC 13位毫秒数，可通过查询实例可恢复的时间段 - QueryingtheTimeWindowWhenaBackupCanBeRestored接口进行查询。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RestoreTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInfo {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInfo input)
        {
            if (input == null) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;

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
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
