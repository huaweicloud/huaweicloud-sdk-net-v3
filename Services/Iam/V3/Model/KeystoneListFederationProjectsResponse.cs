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
    public class KeystoneListFederationProjectsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public LinksSelf Links { get; set; }

        /// <summary>
        /// 项目信息列表。
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthProjectResult> Projects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListFederationProjectsResponse {\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  projects: ").Append(Projects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListFederationProjectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListFederationProjectsResponse input)
        {
            if (input == null) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;
            if (this.Projects != input.Projects || (this.Projects != null && input.Projects != null && !this.Projects.SequenceEqual(input.Projects))) return false;

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
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Projects != null) hashCode = hashCode * 59 + this.Projects.GetHashCode();
                return hashCode;
            }
        }
    }
}
