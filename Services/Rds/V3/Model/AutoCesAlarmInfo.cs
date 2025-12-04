using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoCesAlarmInfo 
    {

        /// <summary>
        /// **参数解释**：  告警记录唯一标识符。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  租户ID。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**：  租户名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释**：  用户ID。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**：  用户名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**：  项目ID。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：  项目名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释**：  数据库引擎名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// **参数解释**：  新实例是否默认开启自动告警。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("new_instance_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewInstanceDefault { get; set; }

        /// <summary>
        /// **参数解释**：  自动告警状态转换。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }

        /// <summary>
        /// **参数解释**：  告警规则唯一标识符。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// **参数解释**：  主题URN。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// **参数解释**：  记录被创建的时间戳。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：  记录最后一次被更新的时间戳。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoCesAlarmInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  newInstanceDefault: ").Append(NewInstanceDefault).Append("\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoCesAlarmInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoCesAlarmInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.NewInstanceDefault != input.NewInstanceDefault || (this.NewInstanceDefault != null && !this.NewInstanceDefault.Equals(input.NewInstanceDefault))) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.NewInstanceDefault != null) hashCode = hashCode * 59 + this.NewInstanceDefault.GetHashCode();
                if (this.SwitchStatus != null) hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
