using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 删除桌面协同资源请求体。
    /// </summary>
    public class DeleteDesktopSubResourcesReq 
    {

        /// <summary>
        /// 桌面ID列表。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 待删除附属资源类型。DESKTOP_SHARER：桌面协同资源。
        /// </summary>
        [JsonProperty("sub_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceType { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDesktopSubResourcesReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  subResourceType: ").Append(SubResourceType).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDesktopSubResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDesktopSubResourcesReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.SubResourceType != input.SubResourceType || (this.SubResourceType != null && !this.SubResourceType.Equals(input.SubResourceType))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.SubResourceType != null) hashCode = hashCode * 59 + this.SubResourceType.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
