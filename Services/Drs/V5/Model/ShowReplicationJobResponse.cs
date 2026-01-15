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
    /// Response Object
    /// </summary>
    public class ShowReplicationJobResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务状态。取值：success，failed
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务完成时间。
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupInfoResp BackupInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupJobBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_db_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupJobEndpointInfo TargetDbInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public BackupRestoreOptionInfo Options { get; set; }

        /// <summary>
        /// 备份恢复数据库映射新名称。
        /// </summary>
        [JsonProperty("new_db_names", NullValueHandling = NullValueHandling.Ignore)]
        public string NewDbNames { get; set; }

        /// <summary>
        /// RDS实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 迁移过程中失败原因。
        /// </summary>
        [JsonProperty("error_log", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplicationJobResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  backupInfo: ").Append(BackupInfo).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  targetDbInfo: ").Append(TargetDbInfo).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  newDbNames: ").Append(NewDbNames).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  errorLog: ").Append(ErrorLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplicationJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplicationJobResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.BackupInfo != input.BackupInfo || (this.BackupInfo != null && !this.BackupInfo.Equals(input.BackupInfo))) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.TargetDbInfo != input.TargetDbInfo || (this.TargetDbInfo != null && !this.TargetDbInfo.Equals(input.TargetDbInfo))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.NewDbNames != input.NewDbNames || (this.NewDbNames != null && !this.NewDbNames.Equals(input.NewDbNames))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.ErrorLog != input.ErrorLog || (this.ErrorLog != null && !this.ErrorLog.Equals(input.ErrorLog))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.BackupInfo != null) hashCode = hashCode * 59 + this.BackupInfo.GetHashCode();
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.TargetDbInfo != null) hashCode = hashCode * 59 + this.TargetDbInfo.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.NewDbNames != null) hashCode = hashCode * 59 + this.NewDbNames.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.ErrorLog != null) hashCode = hashCode * 59 + this.ErrorLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
