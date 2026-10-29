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
    /// **参数解释：** 任务信息。 **取值范围：** 不涉及。
    /// </summary>
    public class TaskBasicInfo 
    {

        /// <summary>
        /// **参数解释：** 分支名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 是否有删除任务的权限。 **取值范围：** - true：有删除的权限。 - false：没有删除的权限。
        /// </summary>
        [JsonProperty("canDelete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// **参数解释：** 是否有编辑的权限。 **取值范围：** - true：有编辑的权限。 - false：没有编辑的权限。
        /// </summary>
        [JsonProperty("canEdit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// **参数解释：** 是否有执行的权限。 **取值范围：** - true：有执行的权限。 - false：没有执行的权限。
        /// </summary>
        [JsonProperty("canExecute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// **参数解释：** 是否有读的权限。 **取值范围：** - true：有读的权限。 - false：没有读的权限。
        /// </summary>
        [JsonProperty("canRead", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigTemplateBasicInfo ConfigTemplate { get; set; }

        /// <summary>
        /// **参数解释：** 任务的配置模板的ID。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("configTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigTemplateId { get; set; }

        /// <summary>
        /// **参数解释：** 任务的创建时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 任务ID，即新建检查任务接口的返回值，每个代码检查任务及其下的分支任务、通过API创建的增量任务都有唯一的任务ID。即[[查询任务列表](https://support.huaweicloud.com/api-codecheck/ShowTasksList.html)](tag:hws)[[查询任务列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ShowTasksList.html)](tag:hws_hk)[查询任务列表](tag:hcs,hcs_sm)接口响应中的id字段。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 任务是否被关注。 **取值范围：** - true：任务被关注。 - false：任务未被关注。
        /// </summary>
        [JsonProperty("isFollowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFollowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("jobResult", NullValueHandling = NullValueHandling.Ignore)]
        public JobResultInfo JobResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastJob", NullValueHandling = NullValueHandling.Ignore)]
        public JobBasicInfo LastJob { get; set; }

        /// <summary>
        /// **参数解释：** 任务的上一次更新时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// **参数解释：** 代码检查任务名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 代码检查任务所有者。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位UUID，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/zh-cn/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口获取。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 项目名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("projectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 华为云地域。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("repoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// **参数解释：** 规则集配置列表。
        /// </summary>
        [JsonProperty("ruleSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigTemplateRuleSetInfo> RuleSets { get; set; }

        /// <summary>
        /// **参数解释：** 任务类型。 **取值范围：** - basic：普通任务。 - security：安全增强包任务。
        /// </summary>
        [JsonProperty("ruleType", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// **参数解释：** 任务分组的ID。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("taskGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskBasicInfo {\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canRead: ").Append(CanRead).Append("\n");
            sb.Append("  configTemplate: ").Append(ConfigTemplate).Append("\n");
            sb.Append("  configTemplateId: ").Append(ConfigTemplateId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isFollowed: ").Append(IsFollowed).Append("\n");
            sb.Append("  jobResult: ").Append(JobResult).Append("\n");
            sb.Append("  lastJob: ").Append(LastJob).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  repoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  taskGroupId: ").Append(TaskGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskBasicInfo input)
        {
            if (input == null) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanExecute != input.CanExecute || (this.CanExecute != null && !this.CanExecute.Equals(input.CanExecute))) return false;
            if (this.CanRead != input.CanRead || (this.CanRead != null && !this.CanRead.Equals(input.CanRead))) return false;
            if (this.ConfigTemplate != input.ConfigTemplate || (this.ConfigTemplate != null && !this.ConfigTemplate.Equals(input.ConfigTemplate))) return false;
            if (this.ConfigTemplateId != input.ConfigTemplateId || (this.ConfigTemplateId != null && !this.ConfigTemplateId.Equals(input.ConfigTemplateId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsFollowed != input.IsFollowed || (this.IsFollowed != null && !this.IsFollowed.Equals(input.IsFollowed))) return false;
            if (this.JobResult != input.JobResult || (this.JobResult != null && !this.JobResult.Equals(input.JobResult))) return false;
            if (this.LastJob != input.LastJob || (this.LastJob != null && !this.LastJob.Equals(input.LastJob))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RepoUrl != input.RepoUrl || (this.RepoUrl != null && !this.RepoUrl.Equals(input.RepoUrl))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.TaskGroupId != input.TaskGroupId || (this.TaskGroupId != null && !this.TaskGroupId.Equals(input.TaskGroupId))) return false;

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
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanExecute != null) hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanRead != null) hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.ConfigTemplate != null) hashCode = hashCode * 59 + this.ConfigTemplate.GetHashCode();
                if (this.ConfigTemplateId != null) hashCode = hashCode * 59 + this.ConfigTemplateId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsFollowed != null) hashCode = hashCode * 59 + this.IsFollowed.GetHashCode();
                if (this.JobResult != null) hashCode = hashCode * 59 + this.JobResult.GetHashCode();
                if (this.LastJob != null) hashCode = hashCode * 59 + this.LastJob.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RepoUrl != null) hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                if (this.RuleType != null) hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.TaskGroupId != null) hashCode = hashCode * 59 + this.TaskGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
