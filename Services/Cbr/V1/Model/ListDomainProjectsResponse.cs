using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainProjectsResponse : SdkResponse
    {

        /// <summary>
        /// 项目列表
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainProjectsInfo> Projects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainProjectsResponse {\n");
            sb.Append("  projects: ").Append(Projects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainProjectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainProjectsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Projects == input.Projects ||
                    this.Projects != null &&
                    input.Projects != null &&
                    this.Projects.SequenceEqual(input.Projects)
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
                if (this.Projects != null)
                    hashCode = hashCode * 59 + this.Projects.GetHashCode();
                return hashCode;
            }
        }
    }
}
