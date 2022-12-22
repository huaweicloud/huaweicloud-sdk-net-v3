using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestorePoint 
    {

        /// <summary>
        /// 实例ID，可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。当type为“backup”，为非必选。当type为“timestamp”，为必选。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 恢复方式，枚举值： - “backup”，表示使用备份文件恢复，按照此方式恢复时，当“type”字段为非必选时，“backup_id”必选。 - “timestamp”，表示按时间点恢复，按照此方式恢复时，当“type”字段必选时，“restore_time”必选。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 用于恢复的备份ID。当使用备份文件恢复时需要指定该参数。当“type”字段为非必选时，“backup_id”必选。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 恢复数据的时间点，格式为UNIX时间戳，单位是毫秒，时区为UTC。须知：当“type”字段必选时，“restore_time”必选。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestorePoint {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestorePoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestorePoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.RestoreTime != null)
                    hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
