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
    /// Response Object
    /// </summary>
    public class ShowPipelineDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **取值范围**： 仅包含中文、大小写英文字母、数字、&#39;-&#39;和&#39;_&#39;，且长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 对流水线的补充描述。 **取值范围**： 不超过1024字符。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 流水线版本，默认为3.0。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 当前环境所属局点。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 所属租户ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 所属微服务ID。可以通过[查询微服务列表](ListMicroservice.xml)接口获取，其中data.id即为微服务ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **取值范围**： - true：是变更流水线。 - false：不是变更流水线。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线上次更新人ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("updater_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线是否被当前用户收藏。 **取值范围**： - true：流水线已被收藏。 - false：流水线未被收藏。 
        /// </summary>
        [JsonProperty("is_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCollect { get; set; }

        /// <summary>
        /// **参数解释**： 流水线源列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineSource> Sources { get; set; }

        /// <summary>
        /// **参数解释**： 流水线自定义参数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineVariable> Variables { get; set; }

        /// <summary>
        /// **参数解释**： 流水线定时任务设置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("schedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineSchedule> Schedules { get; set; }

        /// <summary>
        /// **参数解释**： 流水线事件触发设置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineTrigger> Triggers { get; set; }

        /// <summary>
        /// **参数解释**： 流水线所属分组ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线定义JSON。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public string Definition { get; set; }

        /// <summary>
        /// **参数解释**： 流水线涉密等级。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityLevel { get; set; }

        /// <summary>
        /// **参数解释**： 复制流水线场景下，原流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("origin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginId { get; set; }

        /// <summary>
        /// **参数解释**： 是否禁用发布分支管理。 **取值范围**： - true：禁用发布分支管理。 - false：不禁用发布分支管理。 
        /// </summary>
        [JsonProperty("disable_release_branch_management", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableReleaseBranchManagement { get; set; }

        /// <summary>
        /// **参数解释**： 流水线是否已被删除。 **取值范围**： - true：已删除。 - false：未删除。 
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// **参数解释**： 流水线是否被禁用。 **取值范围**： - true：已禁用。 - false：未禁用。 
        /// </summary>
        [JsonProperty("banned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Banned { get; set; }

        /// <summary>
        /// **参数解释**： 是否来自CodeHub代码仓。 **取值范围**： - true：来自CodeHub代码仓。 - false：非来自CodeHub代码仓。 
        /// </summary>
        [JsonProperty("from_git_code", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FromGitCode { get; set; }

        /// <summary>
        /// **参数解释**： 是否来自CodeHub代码仓库。 **取值范围**： - true：来自CodeHub代码仓库。 - false：非来自CodeHub代码仓库。 
        /// </summary>
        [JsonProperty("from_git_code_repo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FromGitCodeRepo { get; set; }

        /// <summary>
        /// **参数解释**： CodeHub代码仓库ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("git_code_repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GitCodeRepoId { get; set; }

        /// <summary>
        /// **参数解释**： YAML格式流水线定义。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("yaml_definition", NullValueHandling = NullValueHandling.Ignore)]
        public string YamlDefinition { get; set; }

        /// <summary>
        /// **参数解释**： PAC代码仓关联信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pac_repo_relation", NullValueHandling = NullValueHandling.Ignore)]
        public Object PacRepoRelation { get; set; }

        /// <summary>
        /// **参数解释**： YAML流水线文件内容。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("yaml_content", NullValueHandling = NullValueHandling.Ignore)]
        public string YamlContent { get; set; }

        /// <summary>
        /// **参数解释**： 委托名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// **参数解释**： 执行计划列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("execution_plans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> ExecutionPlans { get; set; }

        /// <summary>
        /// **参数解释**： 流水线来源。 **取值范围**： - 0：默认。 - 1：普通模板创建。 - 2：老数据转换。 - 3：CloudInit凤凰商城触发模板创建。 - 4：CloudInit其他触发模板创建。 - 5：创建模板。 
        /// </summary>
        [JsonProperty("from_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromSource { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线所属分组名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("concurrency_control", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineConcurrencyMgmt ConcurrencyControl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线取消运行策略。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("cancel_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Object CancelStrategy { get; set; }

        /// <summary>
        /// **参数解释**： 流水线标签ID列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("tag_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// **参数解释**： 流水线变量组列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("variable_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VariableGroups { get; set; }

        /// <summary>
        /// **参数解释**： 流水线密级代码。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("security_level_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityLevelCode { get; set; }

        /// <summary>
        /// **参数解释**： 流水线权限信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Object Permissions { get; set; }

        /// <summary>
        /// **参数解释**： 主体ID，即流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("subject_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线详情页URL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线编辑页URL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifyUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线标签列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// **参数解释**： 是否为CR（变更）模型流水线。 **取值范围**： - true：是CR模型流水线。 - false：非CR模型流水线。 
        /// </summary>
        [JsonProperty("is_cr_model", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCrModel { get; set; }

        /// <summary>
        /// **参数解释**： PAC归档源信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("archive_source", NullValueHandling = NullValueHandling.Ignore)]
        public Object ArchiveSource { get; set; }

        /// <summary>
        /// **参数解释**： V2 YAML流水线的代码仓相关信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("yaml_repo_properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object YamlRepoProperties { get; set; }

        /// <summary>
        /// **参数解释**： 关联的通用参数组ID列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("variable_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VariableGroupIds { get; set; }

        /// <summary>
        /// **参数解释**： PAC代码源别名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pac_source_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string PacSourceAlias { get; set; }

        /// <summary>
        /// **参数解释**： PAC代码源CodeHub仓库的HTTPS端点ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pac_source_repo_https_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string PacSourceRepoHttpsEndpoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  isCollect: ").Append(IsCollect).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  schedules: ").Append(Schedules).Append("\n");
            sb.Append("  triggers: ").Append(Triggers).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  definition: ").Append(Definition).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  originId: ").Append(OriginId).Append("\n");
            sb.Append("  disableReleaseBranchManagement: ").Append(DisableReleaseBranchManagement).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  banned: ").Append(Banned).Append("\n");
            sb.Append("  fromGitCode: ").Append(FromGitCode).Append("\n");
            sb.Append("  fromGitCodeRepo: ").Append(FromGitCodeRepo).Append("\n");
            sb.Append("  gitCodeRepoId: ").Append(GitCodeRepoId).Append("\n");
            sb.Append("  yamlDefinition: ").Append(YamlDefinition).Append("\n");
            sb.Append("  pacRepoRelation: ").Append(PacRepoRelation).Append("\n");
            sb.Append("  yamlContent: ").Append(YamlContent).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  executionPlans: ").Append(ExecutionPlans).Append("\n");
            sb.Append("  fromSource: ").Append(FromSource).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  concurrencyControl: ").Append(ConcurrencyControl).Append("\n");
            sb.Append("  cancelStrategy: ").Append(CancelStrategy).Append("\n");
            sb.Append("  tagIds: ").Append(TagIds).Append("\n");
            sb.Append("  variableGroups: ").Append(VariableGroups).Append("\n");
            sb.Append("  securityLevelCode: ").Append(SecurityLevelCode).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  subjectId: ").Append(SubjectId).Append("\n");
            sb.Append("  detailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("  modifyUrl: ").Append(ModifyUrl).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  isCrModel: ").Append(IsCrModel).Append("\n");
            sb.Append("  archiveSource: ").Append(ArchiveSource).Append("\n");
            sb.Append("  yamlRepoProperties: ").Append(YamlRepoProperties).Append("\n");
            sb.Append("  variableGroupIds: ").Append(VariableGroupIds).Append("\n");
            sb.Append("  pacSourceAlias: ").Append(PacSourceAlias).Append("\n");
            sb.Append("  pacSourceRepoHttpsEndpoint: ").Append(PacSourceRepoHttpsEndpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdaterId != input.UpdaterId || (this.UpdaterId != null && !this.UpdaterId.Equals(input.UpdaterId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IsCollect != input.IsCollect || (this.IsCollect != null && !this.IsCollect.Equals(input.IsCollect))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;
            if (this.Schedules != input.Schedules || (this.Schedules != null && input.Schedules != null && !this.Schedules.SequenceEqual(input.Schedules))) return false;
            if (this.Triggers != input.Triggers || (this.Triggers != null && input.Triggers != null && !this.Triggers.SequenceEqual(input.Triggers))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Definition != input.Definition || (this.Definition != null && !this.Definition.Equals(input.Definition))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;
            if (this.OriginId != input.OriginId || (this.OriginId != null && !this.OriginId.Equals(input.OriginId))) return false;
            if (this.DisableReleaseBranchManagement != input.DisableReleaseBranchManagement || (this.DisableReleaseBranchManagement != null && !this.DisableReleaseBranchManagement.Equals(input.DisableReleaseBranchManagement))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.Banned != input.Banned || (this.Banned != null && !this.Banned.Equals(input.Banned))) return false;
            if (this.FromGitCode != input.FromGitCode || (this.FromGitCode != null && !this.FromGitCode.Equals(input.FromGitCode))) return false;
            if (this.FromGitCodeRepo != input.FromGitCodeRepo || (this.FromGitCodeRepo != null && !this.FromGitCodeRepo.Equals(input.FromGitCodeRepo))) return false;
            if (this.GitCodeRepoId != input.GitCodeRepoId || (this.GitCodeRepoId != null && !this.GitCodeRepoId.Equals(input.GitCodeRepoId))) return false;
            if (this.YamlDefinition != input.YamlDefinition || (this.YamlDefinition != null && !this.YamlDefinition.Equals(input.YamlDefinition))) return false;
            if (this.PacRepoRelation != input.PacRepoRelation || (this.PacRepoRelation != null && !this.PacRepoRelation.Equals(input.PacRepoRelation))) return false;
            if (this.YamlContent != input.YamlContent || (this.YamlContent != null && !this.YamlContent.Equals(input.YamlContent))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.ExecutionPlans != input.ExecutionPlans || (this.ExecutionPlans != null && input.ExecutionPlans != null && !this.ExecutionPlans.SequenceEqual(input.ExecutionPlans))) return false;
            if (this.FromSource != input.FromSource || (this.FromSource != null && !this.FromSource.Equals(input.FromSource))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ConcurrencyControl != input.ConcurrencyControl || (this.ConcurrencyControl != null && !this.ConcurrencyControl.Equals(input.ConcurrencyControl))) return false;
            if (this.CancelStrategy != input.CancelStrategy || (this.CancelStrategy != null && !this.CancelStrategy.Equals(input.CancelStrategy))) return false;
            if (this.TagIds != input.TagIds || (this.TagIds != null && input.TagIds != null && !this.TagIds.SequenceEqual(input.TagIds))) return false;
            if (this.VariableGroups != input.VariableGroups || (this.VariableGroups != null && input.VariableGroups != null && !this.VariableGroups.SequenceEqual(input.VariableGroups))) return false;
            if (this.SecurityLevelCode != input.SecurityLevelCode || (this.SecurityLevelCode != null && !this.SecurityLevelCode.Equals(input.SecurityLevelCode))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && !this.Permissions.Equals(input.Permissions))) return false;
            if (this.SubjectId != input.SubjectId || (this.SubjectId != null && !this.SubjectId.Equals(input.SubjectId))) return false;
            if (this.DetailUrl != input.DetailUrl || (this.DetailUrl != null && !this.DetailUrl.Equals(input.DetailUrl))) return false;
            if (this.ModifyUrl != input.ModifyUrl || (this.ModifyUrl != null && !this.ModifyUrl.Equals(input.ModifyUrl))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.IsCrModel != input.IsCrModel || (this.IsCrModel != null && !this.IsCrModel.Equals(input.IsCrModel))) return false;
            if (this.ArchiveSource != input.ArchiveSource || (this.ArchiveSource != null && !this.ArchiveSource.Equals(input.ArchiveSource))) return false;
            if (this.YamlRepoProperties != input.YamlRepoProperties || (this.YamlRepoProperties != null && !this.YamlRepoProperties.Equals(input.YamlRepoProperties))) return false;
            if (this.VariableGroupIds != input.VariableGroupIds || (this.VariableGroupIds != null && input.VariableGroupIds != null && !this.VariableGroupIds.SequenceEqual(input.VariableGroupIds))) return false;
            if (this.PacSourceAlias != input.PacSourceAlias || (this.PacSourceAlias != null && !this.PacSourceAlias.Equals(input.PacSourceAlias))) return false;
            if (this.PacSourceRepoHttpsEndpoint != input.PacSourceRepoHttpsEndpoint || (this.PacSourceRepoHttpsEndpoint != null && !this.PacSourceRepoHttpsEndpoint.Equals(input.PacSourceRepoHttpsEndpoint))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdaterId != null) hashCode = hashCode * 59 + this.UpdaterId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IsCollect != null) hashCode = hashCode * 59 + this.IsCollect.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.Schedules != null) hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.Triggers != null) hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Definition != null) hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                if (this.OriginId != null) hashCode = hashCode * 59 + this.OriginId.GetHashCode();
                if (this.DisableReleaseBranchManagement != null) hashCode = hashCode * 59 + this.DisableReleaseBranchManagement.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Banned != null) hashCode = hashCode * 59 + this.Banned.GetHashCode();
                if (this.FromGitCode != null) hashCode = hashCode * 59 + this.FromGitCode.GetHashCode();
                if (this.FromGitCodeRepo != null) hashCode = hashCode * 59 + this.FromGitCodeRepo.GetHashCode();
                if (this.GitCodeRepoId != null) hashCode = hashCode * 59 + this.GitCodeRepoId.GetHashCode();
                if (this.YamlDefinition != null) hashCode = hashCode * 59 + this.YamlDefinition.GetHashCode();
                if (this.PacRepoRelation != null) hashCode = hashCode * 59 + this.PacRepoRelation.GetHashCode();
                if (this.YamlContent != null) hashCode = hashCode * 59 + this.YamlContent.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.ExecutionPlans != null) hashCode = hashCode * 59 + this.ExecutionPlans.GetHashCode();
                if (this.FromSource != null) hashCode = hashCode * 59 + this.FromSource.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ConcurrencyControl != null) hashCode = hashCode * 59 + this.ConcurrencyControl.GetHashCode();
                if (this.CancelStrategy != null) hashCode = hashCode * 59 + this.CancelStrategy.GetHashCode();
                if (this.TagIds != null) hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.VariableGroups != null) hashCode = hashCode * 59 + this.VariableGroups.GetHashCode();
                if (this.SecurityLevelCode != null) hashCode = hashCode * 59 + this.SecurityLevelCode.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.SubjectId != null) hashCode = hashCode * 59 + this.SubjectId.GetHashCode();
                if (this.DetailUrl != null) hashCode = hashCode * 59 + this.DetailUrl.GetHashCode();
                if (this.ModifyUrl != null) hashCode = hashCode * 59 + this.ModifyUrl.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.IsCrModel != null) hashCode = hashCode * 59 + this.IsCrModel.GetHashCode();
                if (this.ArchiveSource != null) hashCode = hashCode * 59 + this.ArchiveSource.GetHashCode();
                if (this.YamlRepoProperties != null) hashCode = hashCode * 59 + this.YamlRepoProperties.GetHashCode();
                if (this.VariableGroupIds != null) hashCode = hashCode * 59 + this.VariableGroupIds.GetHashCode();
                if (this.PacSourceAlias != null) hashCode = hashCode * 59 + this.PacSourceAlias.GetHashCode();
                if (this.PacSourceRepoHttpsEndpoint != null) hashCode = hashCode * 59 + this.PacSourceRepoHttpsEndpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
