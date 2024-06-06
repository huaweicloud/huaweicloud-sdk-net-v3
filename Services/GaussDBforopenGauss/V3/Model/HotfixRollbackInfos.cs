using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 可以回退的热补丁信息。
    /// </summary>
    public class HotfixRollbackInfos 
    {

        /// <summary>
        /// 热补丁版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 通用/非通用补丁信息。 枚举值：   \&quot;common\&quot;: 通用补丁。   \&quot;certain\&quot;: 定制补丁。
        /// </summary>
        [JsonProperty("common_patch", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonPatch { get; set; }

        /// <summary>
        /// 是否和备份相关。
        /// </summary>
        [JsonProperty("backup_sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackupSensitive { get; set; }

        /// <summary>
        /// 补丁的描述信息。
        /// </summary>
        [JsonProperty("descripition", NullValueHandling = NullValueHandling.Ignore)]
        public string Descripition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotfixRollbackInfos {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  commonPatch: ").Append(CommonPatch).Append("\n");
            sb.Append("  backupSensitive: ").Append(BackupSensitive).Append("\n");
            sb.Append("  descripition: ").Append(Descripition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotfixRollbackInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotfixRollbackInfos input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.CommonPatch == input.CommonPatch ||
                    (this.CommonPatch != null &&
                    this.CommonPatch.Equals(input.CommonPatch))
                ) && 
                (
                    this.BackupSensitive == input.BackupSensitive ||
                    (this.BackupSensitive != null &&
                    this.BackupSensitive.Equals(input.BackupSensitive))
                ) && 
                (
                    this.Descripition == input.Descripition ||
                    (this.Descripition != null &&
                    this.Descripition.Equals(input.Descripition))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CommonPatch != null)
                    hashCode = hashCode * 59 + this.CommonPatch.GetHashCode();
                if (this.BackupSensitive != null)
                    hashCode = hashCode * 59 + this.BackupSensitive.GetHashCode();
                if (this.Descripition != null)
                    hashCode = hashCode * 59 + this.Descripition.GetHashCode();
                return hashCode;
            }
        }
    }
}
