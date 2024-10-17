using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// 资源共享邀请的详细信息。
    /// </summary>
    public class ResourceShareInvitation 
    {

        /// <summary>
        /// 接收资源共享邀请的账号ID。
        /// </summary>
        [JsonProperty("receiver_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverAccountId { get; set; }

        /// <summary>
        /// 资源共享实例的ID。
        /// </summary>
        [JsonProperty("resource_share_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// 资源共享实例的名称。
        /// </summary>
        [JsonProperty("resource_share_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareName { get; set; }

        /// <summary>
        /// 资源共享邀请的ID。
        /// </summary>
        [JsonProperty("resource_share_invitation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareInvitationId { get; set; }

        /// <summary>
        /// 发送资源共享邀请的账号ID。
        /// </summary>
        [JsonProperty("sender_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderAccountId { get; set; }

        /// <summary>
        /// 资源共享邀请的当前状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建邀请的时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 最后一次更新邀请的时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceShareInvitation {\n");
            sb.Append("  receiverAccountId: ").Append(ReceiverAccountId).Append("\n");
            sb.Append("  resourceShareId: ").Append(ResourceShareId).Append("\n");
            sb.Append("  resourceShareName: ").Append(ResourceShareName).Append("\n");
            sb.Append("  resourceShareInvitationId: ").Append(ResourceShareInvitationId).Append("\n");
            sb.Append("  senderAccountId: ").Append(SenderAccountId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ResourceShareInvitation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceShareInvitation input)
        {
            if (input == null) return false;
            if (this.ReceiverAccountId != input.ReceiverAccountId || (this.ReceiverAccountId != null && !this.ReceiverAccountId.Equals(input.ReceiverAccountId))) return false;
            if (this.ResourceShareId != input.ResourceShareId || (this.ResourceShareId != null && !this.ResourceShareId.Equals(input.ResourceShareId))) return false;
            if (this.ResourceShareName != input.ResourceShareName || (this.ResourceShareName != null && !this.ResourceShareName.Equals(input.ResourceShareName))) return false;
            if (this.ResourceShareInvitationId != input.ResourceShareInvitationId || (this.ResourceShareInvitationId != null && !this.ResourceShareInvitationId.Equals(input.ResourceShareInvitationId))) return false;
            if (this.SenderAccountId != input.SenderAccountId || (this.SenderAccountId != null && !this.SenderAccountId.Equals(input.SenderAccountId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
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
                if (this.ReceiverAccountId != null) hashCode = hashCode * 59 + this.ReceiverAccountId.GetHashCode();
                if (this.ResourceShareId != null) hashCode = hashCode * 59 + this.ResourceShareId.GetHashCode();
                if (this.ResourceShareName != null) hashCode = hashCode * 59 + this.ResourceShareName.GetHashCode();
                if (this.ResourceShareInvitationId != null) hashCode = hashCode * 59 + this.ResourceShareInvitationId.GetHashCode();
                if (this.SenderAccountId != null) hashCode = hashCode * 59 + this.SenderAccountId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
