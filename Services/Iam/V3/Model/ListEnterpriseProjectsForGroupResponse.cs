using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEnterpriseProjectsForGroupResponse : SdkResponse
    {

        /// <summary>
        /// 企业项目信息。
        /// </summary>
        [JsonProperty("enterprise-projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListEnterpriseProjectsResDetail> EnterpriseProjects { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseProjectsForGroupResponse {\n");
            sb.Append("  enterpriseProjects: ").Append(EnterpriseProjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseProjectsForGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseProjectsForGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjects == input.EnterpriseProjects ||
                    this.EnterpriseProjects != null &&
                    input.EnterpriseProjects != null &&
                    this.EnterpriseProjects.SequenceEqual(input.EnterpriseProjects)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EnterpriseProjects != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjects.GetHashCode();
                return hashCode;
            }
        }
    }
}
