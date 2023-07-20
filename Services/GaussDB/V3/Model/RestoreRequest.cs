using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreRequest 
    {

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 源实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 用于恢复的备份ID。当使用备份文件恢复时需要指定该参数。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 恢复数据的时间点，格式为UNIX时间戳，单位是毫秒，时区为UTC。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RestoreTime { get; set; }

        /// <summary>
        /// 表示恢复方式，枚举值： - backup：表示使用备份文件恢复，按照此方式恢复时，当\&quot;type\&quot;字段为非必选时，\&quot;backup_id\&quot;必选。 - timestamp：表示按时间点恢复，按照此方式恢复时，当\&quot;type\&quot;字段必选时，\&quot;restore_time\&quot;必选。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreRequest {\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetInstanceId == input.TargetInstanceId ||
                    (this.TargetInstanceId != null &&
                    this.TargetInstanceId.Equals(input.TargetInstanceId))
                ) && 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
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
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.TargetInstanceId != null)
                    hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.RestoreTime != null)
                    hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
