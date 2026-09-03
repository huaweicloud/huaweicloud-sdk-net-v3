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
    /// **参数解释**：  升级预检查结果。  **取值范围**：  不涉及。
    /// </summary>
    public class UpgradeDatabasePrecheckResult 
    {

        /// <summary>
        /// **参数解释**：  升级预检查项目。  **取值范围**：  - Upgrade permission check：升级权限检查。 - Instance version check：实例源版本检查。 - Resource check：资源检查。 - Upgrade feature compatibility check：升级特性兼容性检查。
        /// </summary>
        [JsonProperty("check_item", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckItem { get; set; }

        /// <summary>
        /// **参数解释**：  升级预检查项说明。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("check_description", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckDescription { get; set; }

        /// <summary>
        /// **参数解释**：  升级预检查对象。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("check_object", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckObject { get; set; }

        /// <summary>
        /// **参数解释**：  升级预检查项的检查状态。  **取值范围**：  - passed：检查通过。 - failed：检查失败。
        /// </summary>
        [JsonProperty("check_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeDatabasePrecheckResult {\n");
            sb.Append("  checkItem: ").Append(CheckItem).Append("\n");
            sb.Append("  checkDescription: ").Append(CheckDescription).Append("\n");
            sb.Append("  checkObject: ").Append(CheckObject).Append("\n");
            sb.Append("  checkStatus: ").Append(CheckStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeDatabasePrecheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeDatabasePrecheckResult input)
        {
            if (input == null) return false;
            if (this.CheckItem != input.CheckItem || (this.CheckItem != null && !this.CheckItem.Equals(input.CheckItem))) return false;
            if (this.CheckDescription != input.CheckDescription || (this.CheckDescription != null && !this.CheckDescription.Equals(input.CheckDescription))) return false;
            if (this.CheckObject != input.CheckObject || (this.CheckObject != null && !this.CheckObject.Equals(input.CheckObject))) return false;
            if (this.CheckStatus != input.CheckStatus || (this.CheckStatus != null && !this.CheckStatus.Equals(input.CheckStatus))) return false;

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
                if (this.CheckItem != null) hashCode = hashCode * 59 + this.CheckItem.GetHashCode();
                if (this.CheckDescription != null) hashCode = hashCode * 59 + this.CheckDescription.GetHashCode();
                if (this.CheckObject != null) hashCode = hashCode * 59 + this.CheckObject.GetHashCode();
                if (this.CheckStatus != null) hashCode = hashCode * 59 + this.CheckStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
