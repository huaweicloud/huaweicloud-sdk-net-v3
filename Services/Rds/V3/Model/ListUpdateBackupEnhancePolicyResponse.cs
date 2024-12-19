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
    /// Response Object
    /// </summary>
    public class ListUpdateBackupEnhancePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 备份时间段开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 备份时间段结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 手动备份保留时长
        /// </summary>
        [JsonProperty("manual_backup_retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public string ManualBackupRetentionDays { get; set; }

        /// <summary>
        /// 高频备份的频率
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }

        /// <summary>
        /// 备份策略集
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUpdateBackupEnhancePolicyResponse {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  manualBackupRetentionDays: ").Append(ManualBackupRetentionDays).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUpdateBackupEnhancePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUpdateBackupEnhancePolicyResponse input)
        {
            if (input == null) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ManualBackupRetentionDays != input.ManualBackupRetentionDays || (this.ManualBackupRetentionDays != null && !this.ManualBackupRetentionDays.Equals(input.ManualBackupRetentionDays))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;

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
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ManualBackupRetentionDays != null) hashCode = hashCode * 59 + this.ManualBackupRetentionDays.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
