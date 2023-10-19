using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEnterpriseProjectsResponse : SdkResponse
    {

        /// <summary>
        /// 企业项目信息列表。
        /// </summary>
        [JsonProperty("enterprise_projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnterpriseProjectItem> EnterpriseProjects { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseProjectsResponse {\n");
            sb.Append("  enterpriseProjects: ").Append(EnterpriseProjects).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseProjectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseProjectsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjects == input.EnterpriseProjects ||
                    this.EnterpriseProjects != null &&
                    input.EnterpriseProjects != null &&
                    this.EnterpriseProjects.SequenceEqual(input.EnterpriseProjects)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
