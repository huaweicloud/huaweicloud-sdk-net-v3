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
        /// **参数解释：** 代码仓地址。 **约束限制：** 不涉及。 **取值范围：** repo仓传以git开头的地址；非repo仓传以http开头的地址。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 计划创建任务的对应代码仓的分支。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// **参数解释：** 启用的检查语言，数组格式，支持的语言请关注服务更新特性文档。 **约束限制：** 与rule_sets 2选1使用。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Language { get; set; }

        /// <summary>
        /// **参数解释：** 启用的规则集，数组格式，当只传语言，不传规则集ID时，与language参数等效，启用这些语言在项目下的默认规则集，支持的语言请关注服务更新特性文档。 **约束限制：** 与language 2选1使用。
        /// </summary>
        [JsonProperty("rule_sets", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleSetV2> RuleSets { get; set; }

        /// <summary>
        /// **参数解释：** 任务类型。 **约束限制：** 不涉及。 **取值范围：** - full：代码仓分支对应的全量任务。 - inc：MR增量任务。 **默认取值：** full
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// **参数解释：** 用户名，与access_token联合使用，用于在创建三方仓时，由Check服务创建1个通用git扩展点，从而保存代码仓信息。 **约束限制：** username、access_token组合与endpoint_id 2选1使用。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释：** 密码或访问密钥/令牌，username，用于在创建三方仓时，由Check服务创建1个通用git扩展点，从而保存代码仓信息。 **约束限制：** username、access_token组合与endpoint_id 2选1使用。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// **参数解释：** 用户预先创建的项目下的代码源扩展点ID，保存了代码仓信息。创建第三方代码源任务，若未填写endpoint，会自动创建扩展点，需要账号有创建扩展点权限，且项目下扩展点未达到上限。 **约束限制：** username、access_token组合与endpoint_id 2选1使用。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inc_config", NullValueHandling = NullValueHandling.Ignore)]
        public IncConfigV2 IncConfig { get; set; }

        /// <summary>
        /// **参数解释：** 用户购买的资源池ID，创建任务时如传此参数，任务将使用对应资源池进行检查。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("resource_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }

        /// <summary>
        /// **参数解释：** [密级ID,可见信息密级的ID，从页面接口GET https://{endpoint}/projects/v1/options的响应参数中获取，其中的code值即为密级ID。](tag:hcs_sm,hcs_sitesm)[该参数暂无业务意义，传0即可。](tag:fcs) **约束限制：** [租户开启密级功能后必传。](tag:hcs_sm,hcs_sitesm)[不涉及。](tag:fcs) **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("sm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SmLevel { get; set; }

        /// <summary>
        /// **参数解释：** 废弃参数
        /// </summary>
        [JsonProperty("check_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CheckType { get; set; }

        /// <summary>
        /// **参数解释：** 废弃参数
        /// </summary>
        [JsonProperty("enable_fossbot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFossbot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTaskRequestV2 {\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  incConfig: ").Append(IncConfig).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  smLevel: ").Append(SmLevel).Append("\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("  enableFossbot: ").Append(EnableFossbot).Append("\n");
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
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;
            if (this.Language != input.Language || (this.Language != null && input.Language != null && !this.Language.SequenceEqual(input.Language))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.IncConfig != input.IncConfig || (this.IncConfig != null && !this.IncConfig.Equals(input.IncConfig))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;
            if (this.SmLevel != input.SmLevel || (this.SmLevel != null && !this.SmLevel.Equals(input.SmLevel))) return false;
            if (this.CheckType != input.CheckType || (this.CheckType != null && input.CheckType != null && !this.CheckType.SequenceEqual(input.CheckType))) return false;
            if (this.EnableFossbot != input.EnableFossbot || (this.EnableFossbot != null && !this.EnableFossbot.Equals(input.EnableFossbot))) return false;

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
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.IncConfig != null) hashCode = hashCode * 59 + this.IncConfig.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.SmLevel != null) hashCode = hashCode * 59 + this.SmLevel.GetHashCode();
                if (this.CheckType != null) hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.EnableFossbot != null) hashCode = hashCode * 59 + this.EnableFossbot.GetHashCode();
                return hashCode;
            }
        }
    }
}
