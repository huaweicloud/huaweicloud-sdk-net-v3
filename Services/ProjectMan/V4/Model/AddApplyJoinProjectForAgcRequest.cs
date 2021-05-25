using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class AddApplyJoinProjectForAgcRequest 
    {

        /// <summary>
        /// 租户id
        /// </summary>
        [SDKProperty("Domain-Id", IsHeader = true)]
        [JsonProperty("Domain-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [SDKProperty("User-Id", IsHeader = true)]
        [JsonProperty("User-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddApplyJoinProjectForAgcRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddApplyJoinProjectForAgcRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddApplyJoinProjectForAgcRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
