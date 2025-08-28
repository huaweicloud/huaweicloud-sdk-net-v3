using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 附件的额外信息。
    /// </summary>
    public class CentralNetworkAttachmentSpecificationValueInfo 
    {

        /// <summary>
        /// 企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("enterprise_router_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterTableId { get; set; }

        /// <summary>
        /// 连接的父资源ID，这里表示企业路由器ID。
        /// </summary>
        [JsonProperty("attachment_parent_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentParentInstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hosted_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public HostedCloudEnum HostedCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approved_state", NullValueHandling = NullValueHandling.Ignore)]
        public ApprovedStateEnum ApprovedState { get; set; }
        /// <summary>
        /// 审批拒绝创建附件的原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkAttachmentSpecificationValueInfo {\n");
            sb.Append("  enterpriseRouterTableId: ").Append(EnterpriseRouterTableId).Append("\n");
            sb.Append("  attachmentParentInstanceId: ").Append(AttachmentParentInstanceId).Append("\n");
            sb.Append("  hostedCloud: ").Append(HostedCloud).Append("\n");
            sb.Append("  approvedState: ").Append(ApprovedState).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkAttachmentSpecificationValueInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkAttachmentSpecificationValueInfo input)
        {
            if (input == null) return false;
            if (this.EnterpriseRouterTableId != input.EnterpriseRouterTableId || (this.EnterpriseRouterTableId != null && !this.EnterpriseRouterTableId.Equals(input.EnterpriseRouterTableId))) return false;
            if (this.AttachmentParentInstanceId != input.AttachmentParentInstanceId || (this.AttachmentParentInstanceId != null && !this.AttachmentParentInstanceId.Equals(input.AttachmentParentInstanceId))) return false;
            if (this.HostedCloud != input.HostedCloud) return false;
            if (this.ApprovedState != input.ApprovedState) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;

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
                if (this.EnterpriseRouterTableId != null) hashCode = hashCode * 59 + this.EnterpriseRouterTableId.GetHashCode();
                if (this.AttachmentParentInstanceId != null) hashCode = hashCode * 59 + this.AttachmentParentInstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.HostedCloud.GetHashCode();
                hashCode = hashCode * 59 + this.ApprovedState.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
