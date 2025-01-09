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
    /// 桌面EIP。
    /// </summary>
    public class Eips 
    {

        /// <summary>
        /// EIP的id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Eip地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 带宽大小。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// traffic（按流量计费），bandwidth（按带宽计费）。
        /// </summary>
        [JsonProperty("eip_charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string EipChargeMode { get; set; }

        /// <summary>
        /// 创建时间，格式为：yyyy-MM-ddTHH:mm:ssZ。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 绑定的桌面id。
        /// </summary>
        [JsonProperty("attached_desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedDesktopId { get; set; }

        /// <summary>
        /// 绑定的桌面名称。
        /// </summary>
        [JsonProperty("attached_desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedDesktopName { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eips {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  eipChargeMode: ").Append(EipChargeMode).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  attachedDesktopId: ").Append(AttachedDesktopId).Append("\n");
            sb.Append("  attachedDesktopName: ").Append(AttachedDesktopName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Eips);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Eips input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.EipChargeMode != input.EipChargeMode || (this.EipChargeMode != null && !this.EipChargeMode.Equals(input.EipChargeMode))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.AttachedDesktopId != input.AttachedDesktopId || (this.AttachedDesktopId != null && !this.AttachedDesktopId.Equals(input.AttachedDesktopId))) return false;
            if (this.AttachedDesktopName != input.AttachedDesktopName || (this.AttachedDesktopName != null && !this.AttachedDesktopName.Equals(input.AttachedDesktopName))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.EipChargeMode != null) hashCode = hashCode * 59 + this.EipChargeMode.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.AttachedDesktopId != null) hashCode = hashCode * 59 + this.AttachedDesktopId.GetHashCode();
                if (this.AttachedDesktopName != null) hashCode = hashCode * 59 + this.AttachedDesktopName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
