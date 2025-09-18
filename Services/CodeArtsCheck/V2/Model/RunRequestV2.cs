using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 代码仓相关的信息非必填，主要是用于CodeFever临时仓库使用，不填时直接使用创建任务时已经提供的信息
    /// </summary>
    public class RunRequestV2 
    {

        /// <summary>
        /// 该任务对应临时仓库有权限的用户名
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 该任务对应临时仓库有权限的用户token
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 该任务对应的临时仓库地址
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// 该任务对应的临时仓库分支
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunRequestV2 {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunRequestV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunRequestV2 input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                return hashCode;
            }
        }
    }
}
