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
    /// Response Object
    /// </summary>
    public class ShowMigrateInfoResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  源实例ID。  **取值范围**：  只能由英文字母、数字组成，长度为36个字符。
        /// </summary>
        [JsonProperty("rds_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  源实例状态。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("rds_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsStatus { get; set; }

        /// <summary>
        /// **参数解释**：  源实例名称。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("rds_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsInstanceName { get; set; }

        /// <summary>
        /// **参数解释**：  迁移任务ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("drs_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DrsJobId { get; set; }

        /// <summary>
        /// **参数解释**：  迁移任务状态。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("drs_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DrsStatus { get; set; }

        /// <summary>
        /// **参数解释**：  源实例读写状态。  **取值范围**：  - ON：读写状态。 - OFF：只读状态。
        /// </summary>
        [JsonProperty("rds_readwrite_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsReadwriteMode { get; set; }

        /// <summary>
        /// **参数解释**：  目标实例读写状态。  **取值范围**：  - ON：读写状态。 - OFF：只读状态。
        /// </summary>
        [JsonProperty("taurus_readwrite_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TaurusReadwriteMode { get; set; }

        /// <summary>
        /// **参数解释**：G  迁移方向。  **取值范围**：  - up：源实例到TaurusDB实例。 - down：TaurusDB实例到源实例。
        /// </summary>
        [JsonProperty("migration_direction", NullValueHandling = NullValueHandling.Ignore)]
        public string MigrationDirection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMigrateInfoResponse {\n");
            sb.Append("  rdsInstanceId: ").Append(RdsInstanceId).Append("\n");
            sb.Append("  rdsStatus: ").Append(RdsStatus).Append("\n");
            sb.Append("  rdsInstanceName: ").Append(RdsInstanceName).Append("\n");
            sb.Append("  drsJobId: ").Append(DrsJobId).Append("\n");
            sb.Append("  drsStatus: ").Append(DrsStatus).Append("\n");
            sb.Append("  rdsReadwriteMode: ").Append(RdsReadwriteMode).Append("\n");
            sb.Append("  taurusReadwriteMode: ").Append(TaurusReadwriteMode).Append("\n");
            sb.Append("  migrationDirection: ").Append(MigrationDirection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMigrateInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMigrateInfoResponse input)
        {
            if (input == null) return false;
            if (this.RdsInstanceId != input.RdsInstanceId || (this.RdsInstanceId != null && !this.RdsInstanceId.Equals(input.RdsInstanceId))) return false;
            if (this.RdsStatus != input.RdsStatus || (this.RdsStatus != null && !this.RdsStatus.Equals(input.RdsStatus))) return false;
            if (this.RdsInstanceName != input.RdsInstanceName || (this.RdsInstanceName != null && !this.RdsInstanceName.Equals(input.RdsInstanceName))) return false;
            if (this.DrsJobId != input.DrsJobId || (this.DrsJobId != null && !this.DrsJobId.Equals(input.DrsJobId))) return false;
            if (this.DrsStatus != input.DrsStatus || (this.DrsStatus != null && !this.DrsStatus.Equals(input.DrsStatus))) return false;
            if (this.RdsReadwriteMode != input.RdsReadwriteMode || (this.RdsReadwriteMode != null && !this.RdsReadwriteMode.Equals(input.RdsReadwriteMode))) return false;
            if (this.TaurusReadwriteMode != input.TaurusReadwriteMode || (this.TaurusReadwriteMode != null && !this.TaurusReadwriteMode.Equals(input.TaurusReadwriteMode))) return false;
            if (this.MigrationDirection != input.MigrationDirection || (this.MigrationDirection != null && !this.MigrationDirection.Equals(input.MigrationDirection))) return false;

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
                if (this.RdsInstanceId != null) hashCode = hashCode * 59 + this.RdsInstanceId.GetHashCode();
                if (this.RdsStatus != null) hashCode = hashCode * 59 + this.RdsStatus.GetHashCode();
                if (this.RdsInstanceName != null) hashCode = hashCode * 59 + this.RdsInstanceName.GetHashCode();
                if (this.DrsJobId != null) hashCode = hashCode * 59 + this.DrsJobId.GetHashCode();
                if (this.DrsStatus != null) hashCode = hashCode * 59 + this.DrsStatus.GetHashCode();
                if (this.RdsReadwriteMode != null) hashCode = hashCode * 59 + this.RdsReadwriteMode.GetHashCode();
                if (this.TaurusReadwriteMode != null) hashCode = hashCode * 59 + this.TaurusReadwriteMode.GetHashCode();
                if (this.MigrationDirection != null) hashCode = hashCode * 59 + this.MigrationDirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
