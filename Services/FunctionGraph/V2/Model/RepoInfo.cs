using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 存储库信息
    /// </summary>
    public class RepoInfo 
    {

        /// <summary>
        /// http地址
        /// </summary>
        [JsonProperty("https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsUrl { get; set; }

        /// <summary>
        /// 存储库链接
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 存储库状态
        /// </summary>
        [JsonProperty("repo_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoStatus { get; set; }

        /// <summary>
        /// 报错信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoInfo {\n");
            sb.Append("  httpsUrl: ").Append(HttpsUrl).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  repoStatus: ").Append(RepoStatus).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpsUrl == input.HttpsUrl ||
                    (this.HttpsUrl != null &&
                    this.HttpsUrl.Equals(input.HttpsUrl))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.RepoStatus == input.RepoStatus ||
                    (this.RepoStatus != null &&
                    this.RepoStatus.Equals(input.RepoStatus))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.HttpsUrl != null)
                    hashCode = hashCode * 59 + this.HttpsUrl.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.RepoStatus != null)
                    hashCode = hashCode * 59 + this.RepoStatus.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
