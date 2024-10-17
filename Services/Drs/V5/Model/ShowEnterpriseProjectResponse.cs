using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEnterpriseProjectResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 企业项目列表。
        /// </summary>
        [JsonProperty("enterprise_project_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnterpriseProject> EnterpriseProjectList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnterpriseProjectResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  enterpriseProjectList: ").Append(EnterpriseProjectList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnterpriseProjectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnterpriseProjectResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.EnterpriseProjectList != input.EnterpriseProjectList || (this.EnterpriseProjectList != null && input.EnterpriseProjectList != null && !this.EnterpriseProjectList.SequenceEqual(input.EnterpriseProjectList))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.EnterpriseProjectList != null) hashCode = hashCode * 59 + this.EnterpriseProjectList.GetHashCode();
                return hashCode;
            }
        }
    }
}
