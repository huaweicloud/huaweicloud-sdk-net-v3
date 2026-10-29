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
    public class SimpleTaskInfoV2 
    {

        /// <summary>
        /// **参数解释：** 任务下的默认分支任务的ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释：** 任务名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释：** 任务创建者的用户ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 任务的默认分支，非代码仓默认分支。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// **参数解释：** 任务创建时间。 **取值范围：** UTC格式，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 任务下所有分支任务、增量任务的最近检查时间。 **取值范围：** UTC格式，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。
        /// </summary>
        [JsonProperty("last_check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// **参数解释：** [密级ID,可见信息密级的ID，从页面接口GET https://{endpoint}/projects/v1/options的响应参数中获取，其中的code值即为密级ID。](tag:hcs_sm,hcs_sitesm)[该参数暂无业务意义，忽略。](tag:fcs) **取值范围：** [不涉及,取值根据用户配置的密级情况变化。](tag:hcs_sm,hcs_sitesm)[不涉及。](tag:fcs)
        /// </summary>
        [JsonProperty("sm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SmLevel { get; set; }

        /// <summary>
        /// **参数解释：** [密级英文名称，取值根据用户配置的密级情况变化。](tag:hcs_sm,hcs_sitesm)[该参数暂无业务意义，忽略。](tag:fcs) **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("sm_level_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string SmLevelNameEn { get; set; }

        /// <summary>
        /// **参数解释：** [密级中文名称，取值根据用户配置的密级情况变化。](tag:hcs_sm,hcs_sitesm)[该参数暂无业务意义，忽略。](tag:fcs) **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("sm_level_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SmLevelName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleTaskInfoV2 {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  lastCheckTime: ").Append(LastCheckTime).Append("\n");
            sb.Append("  smLevel: ").Append(SmLevel).Append("\n");
            sb.Append("  smLevelNameEn: ").Append(SmLevelNameEn).Append("\n");
            sb.Append("  smLevelName: ").Append(SmLevelName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleTaskInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleTaskInfoV2 input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.LastCheckTime != input.LastCheckTime || (this.LastCheckTime != null && !this.LastCheckTime.Equals(input.LastCheckTime))) return false;
            if (this.SmLevel != input.SmLevel || (this.SmLevel != null && !this.SmLevel.Equals(input.SmLevel))) return false;
            if (this.SmLevelNameEn != input.SmLevelNameEn || (this.SmLevelNameEn != null && !this.SmLevelNameEn.Equals(input.SmLevelNameEn))) return false;
            if (this.SmLevelName != input.SmLevelName || (this.SmLevelName != null && !this.SmLevelName.Equals(input.SmLevelName))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.LastCheckTime != null) hashCode = hashCode * 59 + this.LastCheckTime.GetHashCode();
                if (this.SmLevel != null) hashCode = hashCode * 59 + this.SmLevel.GetHashCode();
                if (this.SmLevelNameEn != null) hashCode = hashCode * 59 + this.SmLevelNameEn.GetHashCode();
                if (this.SmLevelName != null) hashCode = hashCode * 59 + this.SmLevelName.GetHashCode();
                return hashCode;
            }
        }
    }
}
