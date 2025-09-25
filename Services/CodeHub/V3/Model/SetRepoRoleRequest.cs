using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SetRepoRoleRequest 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [SDKProperty("member_id", IsPath = true)]
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }

        /// <summary>
        /// 仓库uuid(由CreateRepository接口返回)
        /// </summary>
        [SDKProperty("repository_uuid", IsPath = true)]
        [JsonProperty("repository_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public SetRepoRoleRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRepoRoleRequest {\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("  repositoryUuid: ").Append(RepositoryUuid).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetRepoRoleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetRepoRoleRequest input)
        {
            if (input == null) return false;
            if (this.MemberId != input.MemberId || (this.MemberId != null && !this.MemberId.Equals(input.MemberId))) return false;
            if (this.RepositoryUuid != input.RepositoryUuid || (this.RepositoryUuid != null && !this.RepositoryUuid.Equals(input.RepositoryUuid))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.MemberId != null) hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.RepositoryUuid != null) hashCode = hashCode * 59 + this.RepositoryUuid.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
