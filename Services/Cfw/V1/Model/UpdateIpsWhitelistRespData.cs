using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释** 返回数据 **取值范围**： 不涉及
    /// </summary>
    public class UpdateIpsWhitelistRespData 
    {

        /// <summary>
        /// **参数解释** 白名单id  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ips_whitelist_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsWhitelistId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIpsWhitelistRespData {\n");
            sb.Append("  ipsWhitelistId: ").Append(IpsWhitelistId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateIpsWhitelistRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateIpsWhitelistRespData input)
        {
            if (input == null) return false;
            if (this.IpsWhitelistId != input.IpsWhitelistId || (this.IpsWhitelistId != null && !this.IpsWhitelistId.Equals(input.IpsWhitelistId))) return false;

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
                if (this.IpsWhitelistId != null) hashCode = hashCode * 59 + this.IpsWhitelistId.GetHashCode();
                return hashCode;
            }
        }
    }
}
