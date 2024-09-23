using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 两个账号（发起者和接收者）之间为了能安全地建立关系，所需要交换的信息。例如，当管理账号（发起者）邀请另一个账号（接收者）加入其组织时，两个账号一系列邀请（握手）请求和响应交换信息。
    /// </summary>
    public class HandshakeDto 
    {

        /// <summary>
        /// 邀请（握手）的唯一标识符（ID）。源账号在发起邀请（握手）时创建ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 邀请（握手）的统一资源名称。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// 邀请（握手）请求被接受、取消、拒绝或到期的日期和时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 提出邀请（握手）请求的日期和时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 邀请（握手）过期的日期和时间。
        /// </summary>
        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// 组织管理账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("management_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// 组织管理账号的名称。
        /// </summary>
        [JsonProperty("management_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountName { get; set; }

        /// <summary>
        /// 组织的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 给收件账号所有者的邮件中的附加信息。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public TargetDto Target { get; set; }

        /// <summary>
        /// 邀请（握手）的当前状态, pending：邀请中；accepted：接受邀请；cancelled：取消邀请；declined：拒绝邀请；expired：邀请过期。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandshakeDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  managementAccountId: ").Append(ManagementAccountId).Append("\n");
            sb.Append("  managementAccountName: ").Append(ManagementAccountName).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HandshakeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HandshakeDto input)
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
                    this.Urn == input.Urn ||
                    (this.Urn != null &&
                    this.Urn.Equals(input.Urn))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpiredAt == input.ExpiredAt ||
                    (this.ExpiredAt != null &&
                    this.ExpiredAt.Equals(input.ExpiredAt))
                ) && 
                (
                    this.ManagementAccountId == input.ManagementAccountId ||
                    (this.ManagementAccountId != null &&
                    this.ManagementAccountId.Equals(input.ManagementAccountId))
                ) && 
                (
                    this.ManagementAccountName == input.ManagementAccountName ||
                    (this.ManagementAccountName != null &&
                    this.ManagementAccountName.Equals(input.ManagementAccountName))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Urn != null)
                    hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpiredAt != null)
                    hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.ManagementAccountId != null)
                    hashCode = hashCode * 59 + this.ManagementAccountId.GetHashCode();
                if (this.ManagementAccountName != null)
                    hashCode = hashCode * 59 + this.ManagementAccountName.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
