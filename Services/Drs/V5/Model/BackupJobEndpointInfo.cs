using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 备份迁移任务恢复目标RDS for SQL Server实例信息。
    /// </summary>
    public class BackupJobEndpointInfo 
    {

        /// <summary>
        /// 备份迁移任务恢复目标RDS for SQL Server实例ID。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 目标实例是否开启FileStream模式。可通过RDS for SQL Server详情接口获取。
        /// </summary>
        [JsonProperty("ms_file_stream_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MsFileStreamStatus { get; set; }

        /// <summary>
        /// RDS for SQL Server备份文件的文件ID，通过RDS全量恢复时必填。可通过云数据库RDS备份管理页面获取。
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupJobEndpointInfo {\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  msFileStreamStatus: ").Append(MsFileStreamStatus).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupJobEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupJobEndpointInfo input)
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
                    this.MsFileStreamStatus == input.MsFileStreamStatus ||
                    (this.MsFileStreamStatus != null &&
                    this.MsFileStreamStatus.Equals(input.MsFileStreamStatus))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.MsFileStreamStatus != null)
                    hashCode = hashCode * 59 + this.MsFileStreamStatus.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                return hashCode;
            }
        }
    }
}
