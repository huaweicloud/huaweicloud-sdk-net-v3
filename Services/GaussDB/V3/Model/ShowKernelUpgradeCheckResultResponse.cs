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
    public class ShowKernelUpgradeCheckResultResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  预检查结果。  **取值范围**：  - true：成功。 - false：失败。
        /// </summary>
        [JsonProperty("upgrade_precheck_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradePrecheckResult { get; set; }

        /// <summary>
        /// **参数解释**：  预检查完成时间。  **取值范围**：  格式为UNIX时间戳，单位是毫秒，时区为UTC标准时区。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释**：  实例预检查详情。
        /// </summary>
        [JsonProperty("upgrade_precheck_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeDatabasePrecheckResult> UpgradePrecheckDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKernelUpgradeCheckResultResponse {\n");
            sb.Append("  upgradePrecheckResult: ").Append(UpgradePrecheckResult).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  upgradePrecheckDetail: ").Append(UpgradePrecheckDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKernelUpgradeCheckResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKernelUpgradeCheckResultResponse input)
        {
            if (input == null) return false;
            if (this.UpgradePrecheckResult != input.UpgradePrecheckResult || (this.UpgradePrecheckResult != null && !this.UpgradePrecheckResult.Equals(input.UpgradePrecheckResult))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.UpgradePrecheckDetail != input.UpgradePrecheckDetail || (this.UpgradePrecheckDetail != null && input.UpgradePrecheckDetail != null && !this.UpgradePrecheckDetail.SequenceEqual(input.UpgradePrecheckDetail))) return false;

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
                if (this.UpgradePrecheckResult != null) hashCode = hashCode * 59 + this.UpgradePrecheckResult.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpgradePrecheckDetail != null) hashCode = hashCode * 59 + this.UpgradePrecheckDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
