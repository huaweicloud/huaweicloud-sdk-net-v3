using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConfOrgResponse : SdkResponse
    {

        /// <summary>
        /// SP管理员根据会议ID查询该会议归属的企业ID。
        /// </summary>
        [JsonProperty("orgID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfOrgResponse {\n");
            sb.Append("  orgID: ").Append(OrgID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfOrgResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfOrgResponse input)
        {
            if (input == null) return false;
            if (this.OrgID != input.OrgID || (this.OrgID != null && !this.OrgID.Equals(input.OrgID))) return false;

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
                if (this.OrgID != null) hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                return hashCode;
            }
        }
    }
}
