using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 云存储。
    /// </summary>
    public class CloudStorage 
    {

        /// <summary>
        /// 云存储id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云存储名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云存储id。
        /// </summary>
        [JsonProperty("project_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectConfigId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 个人目录声明数量。
        /// </summary>
        [JsonProperty("user_claim_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserClaimCount { get; set; }

        /// <summary>
        /// 共享目录声明数量。
        /// </summary>
        [JsonProperty("share_claim_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShareClaimCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudStorage {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectConfigId: ").Append(ProjectConfigId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  userClaimCount: ").Append(UserClaimCount).Append("\n");
            sb.Append("  shareClaimCount: ").Append(ShareClaimCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudStorage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudStorage input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectConfigId != input.ProjectConfigId || (this.ProjectConfigId != null && !this.ProjectConfigId.Equals(input.ProjectConfigId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UserClaimCount != input.UserClaimCount || (this.UserClaimCount != null && !this.UserClaimCount.Equals(input.UserClaimCount))) return false;
            if (this.ShareClaimCount != input.ShareClaimCount || (this.ShareClaimCount != null && !this.ShareClaimCount.Equals(input.ShareClaimCount))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectConfigId != null) hashCode = hashCode * 59 + this.ProjectConfigId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UserClaimCount != null) hashCode = hashCode * 59 + this.UserClaimCount.GetHashCode();
                if (this.ShareClaimCount != null) hashCode = hashCode * 59 + this.ShareClaimCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
