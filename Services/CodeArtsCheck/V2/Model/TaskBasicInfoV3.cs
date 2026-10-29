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
    /// **参数解释：** 任务信息。
    /// </summary>
    public class TaskBasicInfoV3 
    {

        /// <summary>
        /// **参数解释：** 头像颜色。 **取值范围：** - pure-blue：蓝色。 - pure-purple：紫色。 - pure-tomato：红色。 - pure-green：绿色。 - pure-orange：橙色。 - pure-pink：粉色。
        /// </summary>
        [JsonProperty("avastarType", NullValueHandling = NullValueHandling.Ignore)]
        public string AvastarType { get; set; }

        /// <summary>
        /// **参数解释：** 分支名称。 **取值范围：** 长度为[1~200]个字符。
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 是否可以更新忽略文件模式。 **取值范围：** - true：能更新忽略文件模式。 - false：不能更新忽略文件模式。
        /// </summary>
        [JsonProperty("canChangeIgnoreMode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanChangeIgnoreMode { get; set; }

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
        /// **参数解释：** 是否有切换任务模板的权限。 **取值范围：** - true：有切换任务模板的权限。 - false：没有切换任务模板的权限。
        /// </summary>
        [JsonProperty("canEditTemplateSwitch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEditTemplateSwitch { get; set; }

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
        /// **参数解释：** 自定义参数列表。
        /// </summary>
        [JsonProperty("checkParamList", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomParameter> CheckParamList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checkParamMap", NullValueHandling = NullValueHandling.Ignore)]
        public TaskBasicInfoV3CheckParamMap CheckParamMap { get; set; }

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
        /// **参数解释：** 规则集列表，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("criterionSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigTemplateRuleSetInfo> CriterionSets { get; set; }

        /// <summary>
        /// **参数解释：** 自定义参数列表，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("customParams", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomParameter> CustomParams { get; set; }

        /// <summary>
        /// **参数解释：** 默认分支的分支名。 **取值范围：** 长度为[1~200]个字符。
        /// </summary>
        [JsonProperty("defaultBranchName", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranchName { get; set; }

        /// <summary>
        /// **参数解释：** 文件编码。 **取值范围：** - UTF-8：UTF-8格式。 - GBK：GBK格式。
        /// </summary>
        [JsonProperty("fileEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string FileEncoding { get; set; }

        /// <summary>
        /// **参数解释：** 华为云地域。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("hwCloudRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string HwCloudRegion { get; set; }

        /// <summary>
        /// **参数解释：** 任务ID，即新建检查任务接口的返回值，每个代码检查任务及其下的分支任务、通过API创建的增量任务都有唯一的任务ID。即[[查询任务列表](https://support.huaweicloud.com/api-codecheck/ShowTasksList.html)](tag:hws)[[查询任务列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ShowTasksList.html)](tag:hws_hk)[查询任务列表](tag:hcs,hcs_sm)接口响应中的id字段。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 检查目录。 不配置检查目录时，检查代码仓中所有目录下的代码文件； 配置检查目录时，只检查配置目录中的代码文件。 **取值范围：** 长度为[1~200]个字符。
        /// </summary>
        [JsonProperty("includePaths", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludePaths { get; set; }

        /// <summary>
        /// **参数解释：** 是否打开合并请求时触发。 **取值范围：** - true：打开。 - false：关闭。
        /// </summary>
        [JsonProperty("isSetMrWebhook", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetMrWebhook { get; set; }

        /// <summary>
        /// **参数解释：** 是否打开代码提交时触发。 **取值范围：** - true：打开。 - false：关闭。
        /// </summary>
        [JsonProperty("isSetPushWebhook", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetPushWebhook { get; set; }

        /// <summary>
        /// **参数解释：** 是否打开合并请求时触发。 **取值范围：** - true：打开。 - false：关闭。
        /// </summary>
        [JsonProperty("isSetWebhook", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetWebhook { get; set; }

        /// <summary>
        /// **参数解释：** 是否是任务模板。 **取值范围：** - true：是任务模板。 - false：不是任务模板。
        /// </summary>
        [JsonProperty("isTemplateTask", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTemplateTask { get; set; }

        /// <summary>
        /// **参数解释：** 执行ID，来自代码检查执行任务接口的返回值，每次执行代码检查任务都有唯一的执行ID。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释:** 超时时间，以分钟为单位，格式固定为\&quot;xxx min\&quot;，其中xxx为整数，0 ＜ xxx ≤ 1200。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("jobTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public string JobTimeout { get; set; }

        /// <summary>
        /// **参数解释：** 最后一次检查完成的任务的执行ID。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("lastFinishedFullJobId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFinishedFullJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastJob", NullValueHandling = NullValueHandling.Ignore)]
        public JobBasicInfoV3 LastJob { get; set; }

        /// <summary>
        /// **参数解释：** 任务的最后修改人。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastReviser", NullValueHandling = NullValueHandling.Ignore)]
        public string LastReviser { get; set; }

        /// <summary>
        /// **参数解释：** 任务的上一次更新时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// **参数解释：** 模型集列表，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("modelSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ModelSets { get; set; }

        /// <summary>
        /// **参数解释：** mr检查分支门禁策略。 **取值范围：** - 0：白名单。
        /// </summary>
        [JsonProperty("mrCheckBranchStrategy", NullValueHandling = NullValueHandling.Ignore)]
        public int? MrCheckBranchStrategy { get; set; }

        /// <summary>
        /// **参数解释：** 代码检查任务名。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 消息通知是否使用项目通知设置的配置项，格式为x,x,x,x,x,x，其中x的取值为0或者1。 x为0时代表使用任务的通知设置，x为1时代表使用项目通知设置。 从左到右依次为站内消息通知、邮件通知、企业微信、钉钉、飞书、通用webhook的消息通知配置。 **取值范围：** 格式为x,x,x,x,x,x，其中x的取值为0或者1。
        /// </summary>
        [JsonProperty("notificationConfig", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationConfig { get; set; }

        /// <summary>
        /// **参数解释：** 代码检查任务所有者。 **取值范围：** 长度为[1~255]个字符。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// **参数解释：** 代码检查任务所有者的用户ID。 **取值范围：** 长度为[1~64]个字符。
        /// </summary>
        [JsonProperty("ownerId", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位UUID，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/zh-cn/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口获取。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 项目名。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("projectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 地域，此字段固定为\&quot;suzhou\&quot;。 **取值范围：** suzhou。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址对应的CodeartsRepo仓的RepoId。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("repoId", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 长度为[1~1024]个字符。
        /// </summary>
        [JsonProperty("repoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// **参数解释：** 门禁配置，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("reviewData", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewData { get; set; }

        /// <summary>
        /// **参数解释：** 规则集配置，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("ruleSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RuleSets { get; set; }

        /// <summary>
        /// **参数解释：** 任务来源，一般为\&quot;customer\&quot;。 **取值范围：** customer。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释：** 任务分组的ID。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("taskGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskGroupId { get; set; }

        /// <summary>
        /// **参数解释：** 任务ID列表，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("taskIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// **参数解释：** 任务所属的租户的租户ID，租户ID的值来源于IAM的租户ID。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("tenantId", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释：** 查询任务信息是否使用缓存。 **取值范围：** - true：使用缓存。 - false：不使用缓存。
        /// </summary>
        [JsonProperty("useCache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCache { get; set; }

        /// <summary>
        /// **参数解释：** 消息通知是否使用项目通知设置的配置项，来自notificationConfig的对应的二进制的取反转化成十进制。 例如，notificationConfig配置为1,1,0,1,0,0，则二进制为110100，取反为001011，转化为10进制时该值为11，最终useWorkspaceNotificationConfig的值为11。 **取值范围：** 0-31
        /// </summary>
        [JsonProperty("useWorkspaceNotificationConfig", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseWorkspaceNotificationConfig { get; set; }

        /// <summary>
        /// **参数解释：** 版本升级缓冲期，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("versionUpdateDelayDays", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VersionUpdateDelayDays { get; set; }

        /// <summary>
        /// **参数解释：** webhook检查模式，一般为0，代表禁止来自其它代码仓的MR。 **取值范围：** 0
        /// </summary>
        [JsonProperty("webhookCheckMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? WebhookCheckMode { get; set; }

        /// <summary>
        /// **参数解释：** 区域，一般为green。 **取值范围：** green。
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskBasicInfoV3 {\n");
            sb.Append("  avastarType: ").Append(AvastarType).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  canChangeIgnoreMode: ").Append(CanChangeIgnoreMode).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canEditTemplateSwitch: ").Append(CanEditTemplateSwitch).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canRead: ").Append(CanRead).Append("\n");
            sb.Append("  checkParamList: ").Append(CheckParamList).Append("\n");
            sb.Append("  checkParamMap: ").Append(CheckParamMap).Append("\n");
            sb.Append("  configTemplateId: ").Append(ConfigTemplateId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  criterionSets: ").Append(CriterionSets).Append("\n");
            sb.Append("  customParams: ").Append(CustomParams).Append("\n");
            sb.Append("  defaultBranchName: ").Append(DefaultBranchName).Append("\n");
            sb.Append("  fileEncoding: ").Append(FileEncoding).Append("\n");
            sb.Append("  hwCloudRegion: ").Append(HwCloudRegion).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  includePaths: ").Append(IncludePaths).Append("\n");
            sb.Append("  isSetMrWebhook: ").Append(IsSetMrWebhook).Append("\n");
            sb.Append("  isSetPushWebhook: ").Append(IsSetPushWebhook).Append("\n");
            sb.Append("  isSetWebhook: ").Append(IsSetWebhook).Append("\n");
            sb.Append("  isTemplateTask: ").Append(IsTemplateTask).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobTimeout: ").Append(JobTimeout).Append("\n");
            sb.Append("  lastFinishedFullJobId: ").Append(LastFinishedFullJobId).Append("\n");
            sb.Append("  lastJob: ").Append(LastJob).Append("\n");
            sb.Append("  lastReviser: ").Append(LastReviser).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  modelSets: ").Append(ModelSets).Append("\n");
            sb.Append("  mrCheckBranchStrategy: ").Append(MrCheckBranchStrategy).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  notificationConfig: ").Append(NotificationConfig).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  repoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  reviewData: ").Append(ReviewData).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  taskGroupId: ").Append(TaskGroupId).Append("\n");
            sb.Append("  taskIds: ").Append(TaskIds).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  useCache: ").Append(UseCache).Append("\n");
            sb.Append("  useWorkspaceNotificationConfig: ").Append(UseWorkspaceNotificationConfig).Append("\n");
            sb.Append("  versionUpdateDelayDays: ").Append(VersionUpdateDelayDays).Append("\n");
            sb.Append("  webhookCheckMode: ").Append(WebhookCheckMode).Append("\n");
            sb.Append("  zone: ").Append(Zone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskBasicInfoV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskBasicInfoV3 input)
        {
            if (input == null) return false;
            if (this.AvastarType != input.AvastarType || (this.AvastarType != null && !this.AvastarType.Equals(input.AvastarType))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CanChangeIgnoreMode != input.CanChangeIgnoreMode || (this.CanChangeIgnoreMode != null && !this.CanChangeIgnoreMode.Equals(input.CanChangeIgnoreMode))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanEditTemplateSwitch != input.CanEditTemplateSwitch || (this.CanEditTemplateSwitch != null && !this.CanEditTemplateSwitch.Equals(input.CanEditTemplateSwitch))) return false;
            if (this.CanExecute != input.CanExecute || (this.CanExecute != null && !this.CanExecute.Equals(input.CanExecute))) return false;
            if (this.CanRead != input.CanRead || (this.CanRead != null && !this.CanRead.Equals(input.CanRead))) return false;
            if (this.CheckParamList != input.CheckParamList || (this.CheckParamList != null && input.CheckParamList != null && !this.CheckParamList.SequenceEqual(input.CheckParamList))) return false;
            if (this.CheckParamMap != input.CheckParamMap || (this.CheckParamMap != null && !this.CheckParamMap.Equals(input.CheckParamMap))) return false;
            if (this.ConfigTemplateId != input.ConfigTemplateId || (this.ConfigTemplateId != null && !this.ConfigTemplateId.Equals(input.ConfigTemplateId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CriterionSets != input.CriterionSets || (this.CriterionSets != null && input.CriterionSets != null && !this.CriterionSets.SequenceEqual(input.CriterionSets))) return false;
            if (this.CustomParams != input.CustomParams || (this.CustomParams != null && input.CustomParams != null && !this.CustomParams.SequenceEqual(input.CustomParams))) return false;
            if (this.DefaultBranchName != input.DefaultBranchName || (this.DefaultBranchName != null && !this.DefaultBranchName.Equals(input.DefaultBranchName))) return false;
            if (this.FileEncoding != input.FileEncoding || (this.FileEncoding != null && !this.FileEncoding.Equals(input.FileEncoding))) return false;
            if (this.HwCloudRegion != input.HwCloudRegion || (this.HwCloudRegion != null && !this.HwCloudRegion.Equals(input.HwCloudRegion))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IncludePaths != input.IncludePaths || (this.IncludePaths != null && !this.IncludePaths.Equals(input.IncludePaths))) return false;
            if (this.IsSetMrWebhook != input.IsSetMrWebhook || (this.IsSetMrWebhook != null && !this.IsSetMrWebhook.Equals(input.IsSetMrWebhook))) return false;
            if (this.IsSetPushWebhook != input.IsSetPushWebhook || (this.IsSetPushWebhook != null && !this.IsSetPushWebhook.Equals(input.IsSetPushWebhook))) return false;
            if (this.IsSetWebhook != input.IsSetWebhook || (this.IsSetWebhook != null && !this.IsSetWebhook.Equals(input.IsSetWebhook))) return false;
            if (this.IsTemplateTask != input.IsTemplateTask || (this.IsTemplateTask != null && !this.IsTemplateTask.Equals(input.IsTemplateTask))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobTimeout != input.JobTimeout || (this.JobTimeout != null && !this.JobTimeout.Equals(input.JobTimeout))) return false;
            if (this.LastFinishedFullJobId != input.LastFinishedFullJobId || (this.LastFinishedFullJobId != null && !this.LastFinishedFullJobId.Equals(input.LastFinishedFullJobId))) return false;
            if (this.LastJob != input.LastJob || (this.LastJob != null && !this.LastJob.Equals(input.LastJob))) return false;
            if (this.LastReviser != input.LastReviser || (this.LastReviser != null && !this.LastReviser.Equals(input.LastReviser))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.ModelSets != input.ModelSets || (this.ModelSets != null && input.ModelSets != null && !this.ModelSets.SequenceEqual(input.ModelSets))) return false;
            if (this.MrCheckBranchStrategy != input.MrCheckBranchStrategy || (this.MrCheckBranchStrategy != null && !this.MrCheckBranchStrategy.Equals(input.MrCheckBranchStrategy))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NotificationConfig != input.NotificationConfig || (this.NotificationConfig != null && !this.NotificationConfig.Equals(input.NotificationConfig))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.RepoUrl != input.RepoUrl || (this.RepoUrl != null && !this.RepoUrl.Equals(input.RepoUrl))) return false;
            if (this.ReviewData != input.ReviewData || (this.ReviewData != null && input.ReviewData != null && !this.ReviewData.SequenceEqual(input.ReviewData))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.TaskGroupId != input.TaskGroupId || (this.TaskGroupId != null && !this.TaskGroupId.Equals(input.TaskGroupId))) return false;
            if (this.TaskIds != input.TaskIds || (this.TaskIds != null && input.TaskIds != null && !this.TaskIds.SequenceEqual(input.TaskIds))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.UseCache != input.UseCache || (this.UseCache != null && !this.UseCache.Equals(input.UseCache))) return false;
            if (this.UseWorkspaceNotificationConfig != input.UseWorkspaceNotificationConfig || (this.UseWorkspaceNotificationConfig != null && !this.UseWorkspaceNotificationConfig.Equals(input.UseWorkspaceNotificationConfig))) return false;
            if (this.VersionUpdateDelayDays != input.VersionUpdateDelayDays || (this.VersionUpdateDelayDays != null && input.VersionUpdateDelayDays != null && !this.VersionUpdateDelayDays.SequenceEqual(input.VersionUpdateDelayDays))) return false;
            if (this.WebhookCheckMode != input.WebhookCheckMode || (this.WebhookCheckMode != null && !this.WebhookCheckMode.Equals(input.WebhookCheckMode))) return false;
            if (this.Zone != input.Zone || (this.Zone != null && !this.Zone.Equals(input.Zone))) return false;

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
                if (this.AvastarType != null) hashCode = hashCode * 59 + this.AvastarType.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CanChangeIgnoreMode != null) hashCode = hashCode * 59 + this.CanChangeIgnoreMode.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanEditTemplateSwitch != null) hashCode = hashCode * 59 + this.CanEditTemplateSwitch.GetHashCode();
                if (this.CanExecute != null) hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanRead != null) hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CheckParamList != null) hashCode = hashCode * 59 + this.CheckParamList.GetHashCode();
                if (this.CheckParamMap != null) hashCode = hashCode * 59 + this.CheckParamMap.GetHashCode();
                if (this.ConfigTemplateId != null) hashCode = hashCode * 59 + this.ConfigTemplateId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CriterionSets != null) hashCode = hashCode * 59 + this.CriterionSets.GetHashCode();
                if (this.CustomParams != null) hashCode = hashCode * 59 + this.CustomParams.GetHashCode();
                if (this.DefaultBranchName != null) hashCode = hashCode * 59 + this.DefaultBranchName.GetHashCode();
                if (this.FileEncoding != null) hashCode = hashCode * 59 + this.FileEncoding.GetHashCode();
                if (this.HwCloudRegion != null) hashCode = hashCode * 59 + this.HwCloudRegion.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncludePaths != null) hashCode = hashCode * 59 + this.IncludePaths.GetHashCode();
                if (this.IsSetMrWebhook != null) hashCode = hashCode * 59 + this.IsSetMrWebhook.GetHashCode();
                if (this.IsSetPushWebhook != null) hashCode = hashCode * 59 + this.IsSetPushWebhook.GetHashCode();
                if (this.IsSetWebhook != null) hashCode = hashCode * 59 + this.IsSetWebhook.GetHashCode();
                if (this.IsTemplateTask != null) hashCode = hashCode * 59 + this.IsTemplateTask.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobTimeout != null) hashCode = hashCode * 59 + this.JobTimeout.GetHashCode();
                if (this.LastFinishedFullJobId != null) hashCode = hashCode * 59 + this.LastFinishedFullJobId.GetHashCode();
                if (this.LastJob != null) hashCode = hashCode * 59 + this.LastJob.GetHashCode();
                if (this.LastReviser != null) hashCode = hashCode * 59 + this.LastReviser.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.ModelSets != null) hashCode = hashCode * 59 + this.ModelSets.GetHashCode();
                if (this.MrCheckBranchStrategy != null) hashCode = hashCode * 59 + this.MrCheckBranchStrategy.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotificationConfig != null) hashCode = hashCode * 59 + this.NotificationConfig.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.RepoUrl != null) hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.ReviewData != null) hashCode = hashCode * 59 + this.ReviewData.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.TaskGroupId != null) hashCode = hashCode * 59 + this.TaskGroupId.GetHashCode();
                if (this.TaskIds != null) hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UseCache != null) hashCode = hashCode * 59 + this.UseCache.GetHashCode();
                if (this.UseWorkspaceNotificationConfig != null) hashCode = hashCode * 59 + this.UseWorkspaceNotificationConfig.GetHashCode();
                if (this.VersionUpdateDelayDays != null) hashCode = hashCode * 59 + this.VersionUpdateDelayDays.GetHashCode();
                if (this.WebhookCheckMode != null) hashCode = hashCode * 59 + this.WebhookCheckMode.GetHashCode();
                if (this.Zone != null) hashCode = hashCode * 59 + this.Zone.GetHashCode();
                return hashCode;
            }
        }
    }
}
