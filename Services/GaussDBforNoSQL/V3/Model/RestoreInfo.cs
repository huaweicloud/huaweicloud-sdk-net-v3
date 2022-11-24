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
    /// 支持按指定备份文件恢复和按指定时间点恢复。 其中按指定时间点恢复仅支持GaussDB(for Cassandra)和GaussDB(for Influx)。
    /// </summary>
    public class RestoreInfo 
    {

        /// <summary>
        /// 备份文件ID。  用于根据指定备份恢复数据到一个新创建的实例的场景，此场景下该字段取值不能为空。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 数据恢复参考的指定实例的ID。  用于恢复指定实例的指定时间点的数据到一个新创建的实例的场景，此场景下该字段取值不能为空。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 数据恢复的指定的时间点。  用于恢复指定实例的指定时间点的数据到一个新创建的实例的场景，此场景下该字段取值不能为空。取值为UTC 13位毫秒数，可通过[查询实例可恢复的时间段]接口进行查询。
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
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
                ) && 
                (
                    this.RestoreTime == input.RestoreTime ||
                    (this.RestoreTime != null &&
                    this.RestoreTime.Equals(input.RestoreTime))
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
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.RestoreTime != null)
                    hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
