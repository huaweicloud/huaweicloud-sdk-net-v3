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
    /// **参数解释：** 配置模板详情。
    /// </summary>
    public class ConfigTemplateBasicInfo 
    {

        /// <summary>
        /// **参数解释：** 执行机类型。 **取值范围：** X86/ARM。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// **参数解释：** 分支名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释：** 配置模板创建时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 配置模板创建者。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释：** 任务配置的排除目录信息。 **取值范围:** 不涉及。
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public string Exclude { get; set; }

        /// <summary>
        /// **参数解释：** 配置模板ID，修改配置信息需要用到配置模板ID，每个代码检查任务及其下的分支任务都有相同的且唯一的配置模板ID。 **取值范围:** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 检查目录。不配置检查目录时，检查代码仓中所有目录下的代码文件；配置检查目录时，只检查配置目录中的文件。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("includePaths", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludePaths { get; set; }

        /// <summary>
        /// **参数解释：** 最后修改人的用户名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastReviser", NullValueHandling = NullValueHandling.Ignore)]
        public string LastReviser { get; set; }

        /// <summary>
        /// **参数解释：** 配置模板上一次修改时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// **参数解释：** 配置模板的名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// **参数解释：** 代码仓类型。 **取值范围：** - DevCloud：CodeArtsRepo仓。 - Gitee：Gitee仓。 - GitHub：GitHub仓。 - GitPub：通用Git仓。 - gitcode：GitCode仓。 - gitlab：GitLab仓。 - self_gitlab：自建GitLab仓。 - tfs_git：TFS仓。 - bitbucket：Bitbucket仓。
        /// </summary>
        [JsonProperty("repoType", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoType { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("repoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// **参数解释：** 启用的资源池ID，使用内置执行机的情况下为\&quot;\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("resourcePoolId", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }

        /// <summary>
        /// **参数解释：** 启用的资源池名称，使用内置执行机的情况下为空。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("resourcePoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolName { get; set; }

        /// <summary>
        /// **参数解释：** 启用的资源池类型。 **取值范围：** - default：使用内置资源池。 - exclusive：使用专属资源池。 - self-hosted：使用自定义资源池。
        /// </summary>
        [JsonProperty("resource_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolType { get; set; }

        /// <summary>
        /// **参数解释：** 任务门禁配置列表。
        /// </summary>
        [JsonProperty("reviewData", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewDataInfoResponse> ReviewData { get; set; }

        /// <summary>
        /// **参数解释：** 任务门禁配置列表的json字符串。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("reviewDataJson", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewDataJson { get; set; }

        /// <summary>
        /// **参数解释：** 规则集配置列表。
        /// </summary>
        [JsonProperty("ruleSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigTemplateRuleSetInfo> RuleSets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigTemplateBasicInfo {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  exclude: ").Append(Exclude).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  includePaths: ").Append(IncludePaths).Append("\n");
            sb.Append("  lastReviser: ").Append(LastReviser).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  repoType: ").Append(RepoType).Append("\n");
            sb.Append("  repoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  resourcePoolName: ").Append(ResourcePoolName).Append("\n");
            sb.Append("  resourcePoolType: ").Append(ResourcePoolType).Append("\n");
            sb.Append("  reviewData: ").Append(ReviewData).Append("\n");
            sb.Append("  reviewDataJson: ").Append(ReviewDataJson).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigTemplateBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigTemplateBasicInfo input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Exclude != input.Exclude || (this.Exclude != null && !this.Exclude.Equals(input.Exclude))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IncludePaths != input.IncludePaths || (this.IncludePaths != null && !this.IncludePaths.Equals(input.IncludePaths))) return false;
            if (this.LastReviser != input.LastReviser || (this.LastReviser != null && !this.LastReviser.Equals(input.LastReviser))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RepoType != input.RepoType || (this.RepoType != null && !this.RepoType.Equals(input.RepoType))) return false;
            if (this.RepoUrl != input.RepoUrl || (this.RepoUrl != null && !this.RepoUrl.Equals(input.RepoUrl))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;
            if (this.ResourcePoolName != input.ResourcePoolName || (this.ResourcePoolName != null && !this.ResourcePoolName.Equals(input.ResourcePoolName))) return false;
            if (this.ResourcePoolType != input.ResourcePoolType || (this.ResourcePoolType != null && !this.ResourcePoolType.Equals(input.ResourcePoolType))) return false;
            if (this.ReviewData != input.ReviewData || (this.ReviewData != null && input.ReviewData != null && !this.ReviewData.SequenceEqual(input.ReviewData))) return false;
            if (this.ReviewDataJson != input.ReviewDataJson || (this.ReviewDataJson != null && !this.ReviewDataJson.Equals(input.ReviewDataJson))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;

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
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Exclude != null) hashCode = hashCode * 59 + this.Exclude.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncludePaths != null) hashCode = hashCode * 59 + this.IncludePaths.GetHashCode();
                if (this.LastReviser != null) hashCode = hashCode * 59 + this.LastReviser.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RepoType != null) hashCode = hashCode * 59 + this.RepoType.GetHashCode();
                if (this.RepoUrl != null) hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.ResourcePoolName != null) hashCode = hashCode * 59 + this.ResourcePoolName.GetHashCode();
                if (this.ResourcePoolType != null) hashCode = hashCode * 59 + this.ResourcePoolType.GetHashCode();
                if (this.ReviewData != null) hashCode = hashCode * 59 + this.ReviewData.GetHashCode();
                if (this.ReviewDataJson != null) hashCode = hashCode * 59 + this.ReviewDataJson.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                return hashCode;
            }
        }
    }
}
