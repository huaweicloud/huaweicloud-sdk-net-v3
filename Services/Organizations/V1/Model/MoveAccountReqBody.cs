using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// MoveAccount 操作的请求体。
    /// </summary>
    public class MoveAccountReqBody 
    {

        /// <summary>
        /// 要移出账号的根或组织单元的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("source_parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceParentId { get; set; }

        /// <summary>
        /// 要移入账号的根或组织单元的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("destination_parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationParentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveAccountReqBody {\n");
            sb.Append("  sourceParentId: ").Append(SourceParentId).Append("\n");
            sb.Append("  destinationParentId: ").Append(DestinationParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MoveAccountReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MoveAccountReqBody input)
        {
            if (input == null) return false;
            if (this.SourceParentId != input.SourceParentId || (this.SourceParentId != null && !this.SourceParentId.Equals(input.SourceParentId))) return false;
            if (this.DestinationParentId != input.DestinationParentId || (this.DestinationParentId != null && !this.DestinationParentId.Equals(input.DestinationParentId))) return false;

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
                if (this.SourceParentId != null) hashCode = hashCode * 59 + this.SourceParentId.GetHashCode();
                if (this.DestinationParentId != null) hashCode = hashCode * 59 + this.DestinationParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
