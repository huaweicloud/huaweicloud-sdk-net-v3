using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 组织成员日志汇聚配置
    /// </summary>
    public class UpdatelogConvergeConfig 
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 组织成员账号id
        /// </summary>
        [JsonProperty("member_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberAccountId { get; set; }

        /// <summary>
        /// 组织成员项目id
        /// </summary>
        [JsonProperty("member_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberProjectId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 管理员或者委托管理员账号id
        /// </summary>
        [JsonProperty("management_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// 管理员或者委托管理员项目id
        /// </summary>
        [JsonProperty("management_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementProjectId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 日志汇聚配置
        /// </summary>
        [JsonProperty("log_mapping_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogMappingConfig> LogMappingConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatelogConvergeConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memberAccountId: ").Append(MemberAccountId).Append("\n");
            sb.Append("  memberProjectId: ").Append(MemberProjectId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  managementAccountId: ").Append(ManagementAccountId).Append("\n");
            sb.Append("  managementProjectId: ").Append(ManagementProjectId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  logMappingConfig: ").Append(LogMappingConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatelogConvergeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatelogConvergeConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemberAccountId == input.MemberAccountId ||
                    (this.MemberAccountId != null &&
                    this.MemberAccountId.Equals(input.MemberAccountId))
                ) && 
                (
                    this.MemberProjectId == input.MemberProjectId ||
                    (this.MemberProjectId != null &&
                    this.MemberProjectId.Equals(input.MemberProjectId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ManagementAccountId == input.ManagementAccountId ||
                    (this.ManagementAccountId != null &&
                    this.ManagementAccountId.Equals(input.ManagementAccountId))
                ) && 
                (
                    this.ManagementProjectId == input.ManagementProjectId ||
                    (this.ManagementProjectId != null &&
                    this.ManagementProjectId.Equals(input.ManagementProjectId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.LogMappingConfig == input.LogMappingConfig ||
                    this.LogMappingConfig != null &&
                    input.LogMappingConfig != null &&
                    this.LogMappingConfig.SequenceEqual(input.LogMappingConfig)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemberAccountId != null)
                    hashCode = hashCode * 59 + this.MemberAccountId.GetHashCode();
                if (this.MemberProjectId != null)
                    hashCode = hashCode * 59 + this.MemberProjectId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ManagementAccountId != null)
                    hashCode = hashCode * 59 + this.ManagementAccountId.GetHashCode();
                if (this.ManagementProjectId != null)
                    hashCode = hashCode * 59 + this.ManagementProjectId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.LogMappingConfig != null)
                    hashCode = hashCode * 59 + this.LogMappingConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
