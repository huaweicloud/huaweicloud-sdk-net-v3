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
    public class ListRetainedBackupsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  保留备份信息列表。
        /// </summary>
        [JsonProperty("recycle_backup_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetainedBackupInfo> RecycleBackupInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public RetainedBackupPolicy Policy { get; set; }

        /// <summary>
        /// **参数解释**：  保留备份总数。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRetainedBackupsResponse {\n");
            sb.Append("  recycleBackupInfos: ").Append(RecycleBackupInfos).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRetainedBackupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRetainedBackupsResponse input)
        {
            if (input == null) return false;
            if (this.RecycleBackupInfos != input.RecycleBackupInfos || (this.RecycleBackupInfos != null && input.RecycleBackupInfos != null && !this.RecycleBackupInfos.SequenceEqual(input.RecycleBackupInfos))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.RecycleBackupInfos != null) hashCode = hashCode * 59 + this.RecycleBackupInfos.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
