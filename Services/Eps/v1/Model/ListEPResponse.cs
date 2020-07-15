using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.v1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEPResponse : SdkResponse
    {

        /// <summary>
        /// 企业项目列表
        /// </summary>
        [JsonProperty("enterprise_projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpDetail> EnterpriseProjects { get; set; }

        /// <summary>
        /// 企业项目总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEPResponse {\n");
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
            return this.Equals(input as ListEPResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEPResponse input)
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
