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
    /// 
    /// </summary>
    public class CreateTaskRequestV2 
    {

        /// <summary>
        /// 检查类型，数组格式，默认为source
        /// </summary>
        [JsonProperty("check_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CheckType { get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// 仓库分支
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// 检查语言，数组格式，支持cpp,java,js,python,php,css,html,go,typescript,csharp
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Language { get; set; }

        /// <summary>
        /// 指定规则集
        /// </summary>
        [JsonProperty("rule_sets", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleSetV2> RuleSets { get; set; }

        /// <summary>
        /// 检查类型，支持full/inc两种类型，full表示全量检查，inc表示mr检查
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 仓库有权限的用户名
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 仓库有权限的用户token
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 仓库有权限的用户endpointId
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inc_config", NullValueHandling = NullValueHandling.Ignore)]
        public IncConfigV2 IncConfig { get; set; }

        /// <summary>
        /// 是否打开fossbot检查,默认不开
        /// </summary>
        [JsonProperty("enable_fossbot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFossbot { get; set; }

        /// <summary>
        /// 资源池id，可以从资源池管理页面获取
        /// </summary>
        [JsonProperty("resource_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTaskRequestV2 {\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  incConfig: ").Append(IncConfig).Append("\n");
            sb.Append("  enableFossbot: ").Append(EnableFossbot).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTaskRequestV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTaskRequestV2 input)
        {
            if (input == null) return false;
            if (this.CheckType != input.CheckType || (this.CheckType != null && input.CheckType != null && !this.CheckType.SequenceEqual(input.CheckType))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;
            if (this.Language != input.Language || (this.Language != null && input.Language != null && !this.Language.SequenceEqual(input.Language))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.IncConfig != input.IncConfig || (this.IncConfig != null && !this.IncConfig.Equals(input.IncConfig))) return false;
            if (this.EnableFossbot != input.EnableFossbot || (this.EnableFossbot != null && !this.EnableFossbot.Equals(input.EnableFossbot))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;

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
                if (this.CheckType != null) hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.IncConfig != null) hashCode = hashCode * 59 + this.IncConfig.GetHashCode();
                if (this.EnableFossbot != null) hashCode = hashCode * 59 + this.EnableFossbot.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                return hashCode;
            }
        }
    }
}
