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
    /// 
    /// </summary>
    public class IpsWhitelistRespData 
    {

        /// <summary>
        /// **参数解释**：  白名单ID列表 **取值范围**：  不涉及
        /// </summary>
        [JsonProperty("list_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsWhitelistRespData {\n");
            sb.Append("  listIds: ").Append(ListIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsWhitelistRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsWhitelistRespData input)
        {
            if (input == null) return false;
            if (this.ListIds != input.ListIds || (this.ListIds != null && input.ListIds != null && !this.ListIds.SequenceEqual(input.ListIds))) return false;

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
                if (this.ListIds != null) hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
