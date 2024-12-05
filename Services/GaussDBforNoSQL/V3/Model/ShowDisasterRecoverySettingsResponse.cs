using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDisasterRecoverySettingsResponse : SdkResponse
    {

        /// <summary>
        /// 容灾切换的故障节点比例列表。
        /// </summary>
        [JsonProperty("disaster_recovery_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwitchoverRatioInfo> DisasterRecoverySettings { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDisasterRecoverySettingsResponse {\n");
            sb.Append("  disasterRecoverySettings: ").Append(DisasterRecoverySettings).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDisasterRecoverySettingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDisasterRecoverySettingsResponse input)
        {
            if (input == null) return false;
            if (this.DisasterRecoverySettings != input.DisasterRecoverySettings || (this.DisasterRecoverySettings != null && input.DisasterRecoverySettings != null && !this.DisasterRecoverySettings.SequenceEqual(input.DisasterRecoverySettings))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.DisasterRecoverySettings != null) hashCode = hashCode * 59 + this.DisasterRecoverySettings.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
