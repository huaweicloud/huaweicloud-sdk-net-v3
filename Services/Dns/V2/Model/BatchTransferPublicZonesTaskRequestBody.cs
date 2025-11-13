using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchTransferPublicZonesTaskRequestBody 
    {

        /// <summary>
        /// **参数解释：** 域名。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("zone_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ZoneNames { get; set; }

        /// <summary>
        /// **参数解释：** 对方账号ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("target_user", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTransferPublicZonesTaskRequestBody {\n");
            sb.Append("  zoneNames: ").Append(ZoneNames).Append("\n");
            sb.Append("  targetUser: ").Append(TargetUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchTransferPublicZonesTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchTransferPublicZonesTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.ZoneNames != input.ZoneNames || (this.ZoneNames != null && input.ZoneNames != null && !this.ZoneNames.SequenceEqual(input.ZoneNames))) return false;
            if (this.TargetUser != input.TargetUser || (this.TargetUser != null && !this.TargetUser.Equals(input.TargetUser))) return false;

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
                if (this.ZoneNames != null) hashCode = hashCode * 59 + this.ZoneNames.GetHashCode();
                if (this.TargetUser != null) hashCode = hashCode * 59 + this.TargetUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
