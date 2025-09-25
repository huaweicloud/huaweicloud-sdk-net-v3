using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowCommitRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 分支名、tag名、提交ID。
        /// </summary>
        [SDKProperty("sha", IsQuery = true)]
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// **参数解释：** 是否包含状态信息。 **取值范围：** - true，包含。 - false，不包含。
        /// </summary>
        [SDKProperty("stats", IsQuery = true)]
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stats { get; set; }

        /// <summary>
        /// **参数解释：** 是否包含代码变化信息。 **取值范围：** - true，包含。 - false，不包含。
        /// </summary>
        [SDKProperty("show_code_changes", IsQuery = true)]
        [JsonProperty("show_code_changes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCodeChanges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCommitRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  stats: ").Append(Stats).Append("\n");
            sb.Append("  showCodeChanges: ").Append(ShowCodeChanges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCommitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCommitRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.Stats != input.Stats || (this.Stats != null && !this.Stats.Equals(input.Stats))) return false;
            if (this.ShowCodeChanges != input.ShowCodeChanges || (this.ShowCodeChanges != null && !this.ShowCodeChanges.Equals(input.ShowCodeChanges))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Stats != null) hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.ShowCodeChanges != null) hashCode = hashCode * 59 + this.ShowCodeChanges.GetHashCode();
                return hashCode;
            }
        }
    }
}
