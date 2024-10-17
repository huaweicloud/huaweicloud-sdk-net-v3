using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// GEIP绑定关系对象
    /// </summary>
    public class GeipBindingsInternalResp 
    {

        /// <summary>
        /// GEIP的uuid
        /// </summary>
        [JsonProperty("geip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipId { get; set; }

        /// <summary>
        /// GEIP的ip地址
        /// </summary>
        [JsonProperty("geip_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipIpAddress { get; set; }

        /// <summary>
        /// 中心站点or边缘站点，默认展示
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 绑定实例的类型
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 绑定实例的id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gcbandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BackboneBandwidthResp Gcbandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vnic", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceVnicResp Vnic { get; set; }

        /// <summary>
        /// GEIP实例的vn信息
        /// </summary>
        [JsonProperty("vn_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancevirtualListResp> VnList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeipBindingsInternalResp {\n");
            sb.Append("  geipId: ").Append(GeipId).Append("\n");
            sb.Append("  geipIpAddress: ").Append(GeipIpAddress).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  gcbandwidth: ").Append(Gcbandwidth).Append("\n");
            sb.Append("  vnic: ").Append(Vnic).Append("\n");
            sb.Append("  vnList: ").Append(VnList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeipBindingsInternalResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeipBindingsInternalResp input)
        {
            if (input == null) return false;
            if (this.GeipId != input.GeipId || (this.GeipId != null && !this.GeipId.Equals(input.GeipId))) return false;
            if (this.GeipIpAddress != input.GeipIpAddress || (this.GeipIpAddress != null && !this.GeipIpAddress.Equals(input.GeipIpAddress))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && !this.InstanceType.Equals(input.InstanceType))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Gcbandwidth != input.Gcbandwidth || (this.Gcbandwidth != null && !this.Gcbandwidth.Equals(input.Gcbandwidth))) return false;
            if (this.Vnic != input.Vnic || (this.Vnic != null && !this.Vnic.Equals(input.Vnic))) return false;
            if (this.VnList != input.VnList || (this.VnList != null && input.VnList != null && !this.VnList.SequenceEqual(input.VnList))) return false;

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
                if (this.GeipId != null) hashCode = hashCode * 59 + this.GeipId.GetHashCode();
                if (this.GeipIpAddress != null) hashCode = hashCode * 59 + this.GeipIpAddress.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Gcbandwidth != null) hashCode = hashCode * 59 + this.Gcbandwidth.GetHashCode();
                if (this.Vnic != null) hashCode = hashCode * 59 + this.Vnic.GetHashCode();
                if (this.VnList != null) hashCode = hashCode * 59 + this.VnList.GetHashCode();
                return hashCode;
            }
        }
    }
}
