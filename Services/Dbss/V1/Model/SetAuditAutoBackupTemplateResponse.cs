using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SetAuditAutoBackupTemplateResponse : SdkResponse
    {

        /// <summary>
        /// OBS桶名称
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS备份根路径
        /// </summary>
        [JsonProperty("bucket_root_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketRootPath { get; set; }

        /// <summary>
        /// 周期 - PER_DAY：每天 - PER_WEEK：每周 - PER_MONTH：每月 - PER_HOUR：每小时 - FIVE_MIN：每5分钟
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 最近备份时间
        /// </summary>
        [JsonProperty("latest_backup_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LatestBackupTime { get; set; }

        /// <summary>
        /// 备份开关  - 0：关闭  - 1：开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TriggerTime { get; set; }

        /// <summary>
        /// 是否已触发
        /// </summary>
        [JsonProperty("triggered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Triggered { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAuditAutoBackupTemplateResponse {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketRootPath: ").Append(BucketRootPath).Append("\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  latestBackupTime: ").Append(LatestBackupTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  triggered: ").Append(Triggered).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAuditAutoBackupTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAuditAutoBackupTemplateResponse input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketRootPath != input.BucketRootPath || (this.BucketRootPath != null && !this.BucketRootPath.Equals(input.BucketRootPath))) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.LatestBackupTime != input.LatestBackupTime || (this.LatestBackupTime != null && !this.LatestBackupTime.Equals(input.LatestBackupTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TriggerTime != input.TriggerTime || (this.TriggerTime != null && !this.TriggerTime.Equals(input.TriggerTime))) return false;
            if (this.Triggered != input.Triggered || (this.Triggered != null && !this.Triggered.Equals(input.Triggered))) return false;

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
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.BucketRootPath != null) hashCode = hashCode * 59 + this.BucketRootPath.GetHashCode();
                if (this.Cycle != null) hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.LatestBackupTime != null) hashCode = hashCode * 59 + this.LatestBackupTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TriggerTime != null) hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.Triggered != null) hashCode = hashCode * 59 + this.Triggered.GetHashCode();
                return hashCode;
            }
        }
    }
}
