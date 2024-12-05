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
    /// 
    /// </summary>
    public class SetDisasterRecoverySettingsRequestBody 
    {

        /// <summary>
        /// 容灾切换的故障节点比例列表。
        /// </summary>
        [JsonProperty("disaster_recovery_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwitchoverRatioInfo> DisasterRecoverySettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDisasterRecoverySettingsRequestBody {\n");
            sb.Append("  disasterRecoverySettings: ").Append(DisasterRecoverySettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetDisasterRecoverySettingsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetDisasterRecoverySettingsRequestBody input)
        {
            if (input == null) return false;
            if (this.DisasterRecoverySettings != input.DisasterRecoverySettings || (this.DisasterRecoverySettings != null && input.DisasterRecoverySettings != null && !this.DisasterRecoverySettings.SequenceEqual(input.DisasterRecoverySettings))) return false;

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
                return hashCode;
            }
        }
    }
}
