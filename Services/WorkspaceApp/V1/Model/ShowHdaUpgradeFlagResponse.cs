using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHdaUpgradeFlagResponse : SdkResponse
    {

        /// <summary>
        /// hda是否需要升级标识。0为无需提示升级, 1为需提示升级
        /// </summary>
        [JsonProperty("upgrade_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpgradeFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHdaUpgradeFlagResponse {\n");
            sb.Append("  upgradeFlag: ").Append(UpgradeFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHdaUpgradeFlagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHdaUpgradeFlagResponse input)
        {
            if (input == null) return false;
            if (this.UpgradeFlag != input.UpgradeFlag || (this.UpgradeFlag != null && !this.UpgradeFlag.Equals(input.UpgradeFlag))) return false;

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
                if (this.UpgradeFlag != null) hashCode = hashCode * 59 + this.UpgradeFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
