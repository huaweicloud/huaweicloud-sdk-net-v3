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
    /// 转储策略信息
    /// </summary>
    public class TransferPolicy 
    {

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("setting_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SettingId { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 转储策略周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 转储备份类型
        /// </summary>
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupType { get; set; }

        /// <summary>
        /// 目标存储
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 转储目标前缀
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferPolicy {\n");
            sb.Append("  settingId: ").Append(SettingId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferPolicy input)
        {
            if (input == null) return false;
            if (this.SettingId != input.SettingId || (this.SettingId != null && !this.SettingId.Equals(input.SettingId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.BackupType != input.BackupType || (this.BackupType != null && !this.BackupType.Equals(input.BackupType))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;

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
                if (this.SettingId != null) hashCode = hashCode * 59 + this.SettingId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.BackupType != null) hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                return hashCode;
            }
        }
    }
}
