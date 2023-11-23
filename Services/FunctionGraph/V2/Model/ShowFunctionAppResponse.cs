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
    /// Response Object
    /// </summary>
    public class ShowFunctionAppResponse : SdkResponse
    {

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("stack_resources", NullValueHandling = NullValueHandling.Ignore)]
        public StackResource StackResources { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源栈名称
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 资源栈id
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 存储库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repo", NullValueHandling = NullValueHandling.Ignore)]
        public RepoInfo Repo { get; set; }

        /// <summary>
        /// 管道id
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 调用URL
        /// </summary>
        [JsonProperty("apig_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ApigUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFunctionAppResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  lastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  stackResources: ").Append(StackResources).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  repo: ").Append(Repo).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  apigUrl: ").Append(ApigUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.StackResources == input.StackResources ||
                    (this.StackResources != null &&
                    this.StackResources.Equals(input.StackResources))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
                ) && 
                (
                    this.RepoName == input.RepoName ||
                    (this.RepoName != null &&
                    this.RepoName.Equals(input.RepoName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Repo == input.Repo ||
                    (this.Repo != null &&
                    this.Repo.Equals(input.Repo))
                ) && 
                (
                    this.PipelineId == input.PipelineId ||
                    (this.PipelineId != null &&
                    this.PipelineId.Equals(input.PipelineId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ApigUrl == input.ApigUrl ||
                    (this.ApigUrl != null &&
                    this.ApigUrl.Equals(input.ApigUrl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.StackResources != null)
                    hashCode = hashCode * 59 + this.StackResources.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.RepoName != null)
                    hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Repo != null)
                    hashCode = hashCode * 59 + this.Repo.GetHashCode();
                if (this.PipelineId != null)
                    hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ApigUrl != null)
                    hashCode = hashCode * 59 + this.ApigUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
