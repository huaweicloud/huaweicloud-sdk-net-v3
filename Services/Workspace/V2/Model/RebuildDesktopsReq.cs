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
    /// 重建系统盘的请求。
    /// </summary>
    public class RebuildDesktopsReq 
    {

        /// <summary>
        /// 计算机id列表。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 镜像类型。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// os类型。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 立即重建时给用户预留的保存数据的时间（单位：分钟）。
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// 下发重建系统盘任务时，给用户发送的提示信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 订单ID，包周期桌面重建系统盘，涉及收费镜像时需传。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0。\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RebuildDesktopsReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RebuildDesktopsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RebuildDesktopsReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
