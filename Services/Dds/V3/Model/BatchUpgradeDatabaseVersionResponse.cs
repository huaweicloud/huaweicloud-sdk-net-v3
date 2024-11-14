using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchUpgradeDatabaseVersionResponse : SdkResponse
    {

        /// <summary>
        /// 批量升级结果。
        /// </summary>
        [JsonProperty("upgrade_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeResult> UpgradeResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpgradeDatabaseVersionResponse {\n");
            sb.Append("  upgradeResults: ").Append(UpgradeResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpgradeDatabaseVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpgradeDatabaseVersionResponse input)
        {
            if (input == null) return false;
            if (this.UpgradeResults != input.UpgradeResults || (this.UpgradeResults != null && input.UpgradeResults != null && !this.UpgradeResults.SequenceEqual(input.UpgradeResults))) return false;

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
                if (this.UpgradeResults != null) hashCode = hashCode * 59 + this.UpgradeResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
