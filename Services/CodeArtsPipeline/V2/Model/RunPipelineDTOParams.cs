using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 流水线源相关参数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class RunPipelineDTOParams 
    {

        /// <summary>
        /// **参数解释**： 代码仓类型。 **约束限制**： 不涉及。 **取值范围**： - codehub。 - gitee。 - github。 - gitcode。 - gitlab。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GitType { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓别名，用户自定义，用于多仓时帮助区分系统参数。例如：A_REPO_COMMIT_ID，B_REPO_COMMIT_ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// **参数解释**： CodeArts Repo代码仓ID。可以通过代码仓查询接口获取，代码仓的唯一标识。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行时代码仓默认分支。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("default_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// **参数解释**： Git仓库https地址，例如https://example.com/CloudPipelinezycs00001/2000.git。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： 代码源扩展点ID。可以通过[查询扩展点列表接口](ListEndpointsDetails.xml)获取，其中endpoints.uuid即为扩展点的唯一标识。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("build_params", NullValueHandling = NullValueHandling.Ignore)]
        public RunPipelineDTOParamsBuildParams BuildParams { get; set; }

        /// <summary>
        /// **参数解释**： 执行变更流水线变更ID列表。可以通过[查询变更列表](ListChangeRequests.xml)接口，其中data.id即为变更ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("change_request_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChangeRequestIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunPipelineDTOParams {\n");
            sb.Append("  gitType: ").Append(GitType).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  codehubId: ").Append(CodehubId).Append("\n");
            sb.Append("  defaultBranch: ").Append(DefaultBranch).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  buildParams: ").Append(BuildParams).Append("\n");
            sb.Append("  changeRequestIds: ").Append(ChangeRequestIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunPipelineDTOParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunPipelineDTOParams input)
        {
            if (input == null) return false;
            if (this.GitType != input.GitType || (this.GitType != null && !this.GitType.Equals(input.GitType))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.CodehubId != input.CodehubId || (this.CodehubId != null && !this.CodehubId.Equals(input.CodehubId))) return false;
            if (this.DefaultBranch != input.DefaultBranch || (this.DefaultBranch != null && !this.DefaultBranch.Equals(input.DefaultBranch))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.BuildParams != input.BuildParams || (this.BuildParams != null && !this.BuildParams.Equals(input.BuildParams))) return false;
            if (this.ChangeRequestIds != input.ChangeRequestIds || (this.ChangeRequestIds != null && input.ChangeRequestIds != null && !this.ChangeRequestIds.SequenceEqual(input.ChangeRequestIds))) return false;

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
                if (this.GitType != null) hashCode = hashCode * 59 + this.GitType.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.CodehubId != null) hashCode = hashCode * 59 + this.CodehubId.GetHashCode();
                if (this.DefaultBranch != null) hashCode = hashCode * 59 + this.DefaultBranch.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.BuildParams != null) hashCode = hashCode * 59 + this.BuildParams.GetHashCode();
                if (this.ChangeRequestIds != null) hashCode = hashCode * 59 + this.ChangeRequestIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
