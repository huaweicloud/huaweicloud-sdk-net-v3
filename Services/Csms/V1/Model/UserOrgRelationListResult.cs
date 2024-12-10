using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserOrgRelationListResult 
    {

        /// <summary>
        /// 组织id
        /// </summary>
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgId { get; set; }

        /// <summary>
        /// 关系类型。
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOrgRelationListResult {\n");
            sb.Append("  orgId: ").Append(OrgId).Append("\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserOrgRelationListResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserOrgRelationListResult input)
        {
            if (input == null) return false;
            if (this.OrgId != input.OrgId || (this.OrgId != null && !this.OrgId.Equals(input.OrgId))) return false;
            if (this.RelationType != input.RelationType || (this.RelationType != null && !this.RelationType.Equals(input.RelationType))) return false;

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
                if (this.OrgId != null) hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.RelationType != null) hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
