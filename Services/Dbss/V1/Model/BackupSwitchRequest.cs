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
    /// 
    /// </summary>
    public class BackupSwitchRequest 
    {

        /// <summary>
        /// OBS桶名称
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 备份根路径
        /// </summary>
        [JsonProperty("bucket_root_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketRootPath { get; set; }

        /// <summary>
        /// 备份周期 - PER_DAY：每天 - PER_WEEK：每周 - PER_MONTH：每月 - PER_HOUR：每小时 - FIVE_MIN：每5分钟
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 备份模式  - AUTO：自动备份
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 开关状态  - 0：关闭  - 1：开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 触发时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TriggerTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupSwitchRequest {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketRootPath: ").Append(BucketRootPath).Append("\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupSwitchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupSwitchRequest input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketRootPath != input.BucketRootPath || (this.BucketRootPath != null && !this.BucketRootPath.Equals(input.BucketRootPath))) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TriggerTime != input.TriggerTime || (this.TriggerTime != null && !this.TriggerTime.Equals(input.TriggerTime))) return false;

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
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TriggerTime != null) hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
