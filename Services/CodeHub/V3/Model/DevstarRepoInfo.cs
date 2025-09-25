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
    /// 
    /// </summary>
    public class DevstarRepoInfo 
    {

        /// <summary>
        /// 仓库的uuid
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 仓库SSH地址
        /// </summary>
        [JsonProperty("ssh_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrl { get; set; }

        /// <summary>
        /// 仓库HTTPS地址
        /// </summary>
        [JsonProperty("code_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 仓库预览地址
        /// </summary>
        [JsonProperty("detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevstarRepoInfo {\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  sshUrl: ").Append(SshUrl).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  detailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevstarRepoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevstarRepoInfo input)
        {
            if (input == null) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.SshUrl != input.SshUrl || (this.SshUrl != null && !this.SshUrl.Equals(input.SshUrl))) return false;
            if (this.CodeUrl != input.CodeUrl || (this.CodeUrl != null && !this.CodeUrl.Equals(input.CodeUrl))) return false;
            if (this.DetailUrl != input.DetailUrl || (this.DetailUrl != null && !this.DetailUrl.Equals(input.DetailUrl))) return false;

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
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.SshUrl != null) hashCode = hashCode * 59 + this.SshUrl.GetHashCode();
                if (this.CodeUrl != null) hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.DetailUrl != null) hashCode = hashCode * 59 + this.DetailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
