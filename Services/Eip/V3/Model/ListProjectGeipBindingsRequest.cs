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
    /// Request Object
    /// </summary>
    public class ListProjectGeipBindingsRequest 
    {

        /// <summary>
        /// 形式为\\\&quot;fields&#x3D;geip_id&amp;fields&#x3D;geip_ip_address&amp;...\\\&quot;，支持字段：geip_id/geip_ip_address/instance_type/instance_id/vnic/vn_list/public_border_group/gcbandwidth/version/created_at/updated_at/instance_vpc_id
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string Fields { get; set; }

        /// <summary>
        /// GEIP的uuid
        /// </summary>
        [SDKProperty("geip_id", IsQuery = true)]
        [JsonProperty("geip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipId { get; set; }

        /// <summary>
        /// GEIP的ip地址
        /// </summary>
        [SDKProperty("geip_ip_address", IsQuery = true)]
        [JsonProperty("geip_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipIpAddress { get; set; }

        /// <summary>
        /// GEIP所处的出口位置
        /// </summary>
        [SDKProperty("public_border_group", IsQuery = true)]
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 绑定的实例类型
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 绑定的实例id
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 绑定的实例vpcid
        /// </summary>
        [SDKProperty("instance_vpc_id", IsQuery = true)]
        [JsonProperty("instance_vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVpcId { get; set; }

        /// <summary>
        /// 骨干带宽的uuid
        /// </summary>
        [SDKProperty("gcbandwidth.id", IsQuery = true)]
        [JsonProperty("gcbandwidth.id", NullValueHandling = NullValueHandling.Ignore)]
        public string GcbandwidthId { get; set; }

        /// <summary>
        /// 骨干带宽的状态
        /// </summary>
        [SDKProperty("gcbandwidth.admin_status", IsQuery = true)]
        [JsonProperty("gcbandwidth.admin_status", NullValueHandling = NullValueHandling.Ignore)]
        public string GcbandwidthAdminStatus { get; set; }

        /// <summary>
        /// 骨干带宽的大小
        /// </summary>
        [SDKProperty("gcbandwidth.size", IsQuery = true)]
        [JsonProperty("gcbandwidth.size", NullValueHandling = NullValueHandling.Ignore)]
        public int? GcbandwidthSize { get; set; }

        /// <summary>
        /// 描述网络等级，从高到低分为铂金、金、银、铜
        /// </summary>
        [SDKProperty("gcbandwidth.sla_level", IsQuery = true)]
        [JsonProperty("gcbandwidth.sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public string GcbandwidthSlaLevel { get; set; }

        /// <summary>
        /// 线路质量金银铜对应的DSCP值
        /// </summary>
        [SDKProperty("gcbandwidth.dscp", IsQuery = true)]
        [JsonProperty("gcbandwidth.dscp", NullValueHandling = NullValueHandling.Ignore)]
        public int? GcbandwidthDscp { get; set; }

        /// <summary>
        /// 绑定实例的ip地址
        /// </summary>
        [SDKProperty("vnic.private_ip_address", IsQuery = true)]
        [JsonProperty("vnic.private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicPrivateIpAddress { get; set; }

        /// <summary>
        /// 绑定实例所在的vpcid
        /// </summary>
        [SDKProperty("vnic.vpc_id", IsQuery = true)]
        [JsonProperty("vnic.vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicVpcId { get; set; }

        /// <summary>
        /// 绑定实例port的uuid
        /// </summary>
        [SDKProperty("vnic.port_id", IsQuery = true)]
        [JsonProperty("vnic.port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicPortId { get; set; }

        /// <summary>
        /// 绑定实例port对应的实例id
        /// </summary>
        [SDKProperty("vnic.device_id", IsQuery = true)]
        [JsonProperty("vnic.device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicDeviceId { get; set; }

        /// <summary>
        /// 绑定实例port对应的实例所有者
        /// </summary>
        [SDKProperty("vnic.device_owner", IsQuery = true)]
        [JsonProperty("vnic.device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicDeviceOwner { get; set; }

        /// <summary>
        /// 绑定实例port对应的实例所有者的前缀
        /// </summary>
        [SDKProperty("vnic.device_owner_prefixlike", IsQuery = true)]
        [JsonProperty("vnic.device_owner_prefixlike", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicDeviceOwnerPrefixlike { get; set; }

        /// <summary>
        /// 绑定实例port对应的实例类型
        /// </summary>
        [SDKProperty("vnic.instance_type", IsQuery = true)]
        [JsonProperty("vnic.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicInstanceType { get; set; }

        /// <summary>
        /// 绑定实例port对应的实例id
        /// </summary>
        [SDKProperty("vnic.instance_id", IsQuery = true)]
        [JsonProperty("vnic.instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VnicInstanceId { get; set; }

        /// <summary>
        /// 排序，形式为\&quot;sort_key&#x3D;geip_id&amp;sort_dir&#x3D;asc\&quot;  支持字段：geip_id/version/public_border_group/ geip_ip_address/created_at/updated_at
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序方向  取值范围：asc、desc
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 每页返回的个数取值范围：0~[2000]，其中2000为局点差异项，具体取值由局点决定
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectGeipBindingsRequest {\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  geipId: ").Append(GeipId).Append("\n");
            sb.Append("  geipIpAddress: ").Append(GeipIpAddress).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceVpcId: ").Append(InstanceVpcId).Append("\n");
            sb.Append("  gcbandwidthId: ").Append(GcbandwidthId).Append("\n");
            sb.Append("  gcbandwidthAdminStatus: ").Append(GcbandwidthAdminStatus).Append("\n");
            sb.Append("  gcbandwidthSize: ").Append(GcbandwidthSize).Append("\n");
            sb.Append("  gcbandwidthSlaLevel: ").Append(GcbandwidthSlaLevel).Append("\n");
            sb.Append("  gcbandwidthDscp: ").Append(GcbandwidthDscp).Append("\n");
            sb.Append("  vnicPrivateIpAddress: ").Append(VnicPrivateIpAddress).Append("\n");
            sb.Append("  vnicVpcId: ").Append(VnicVpcId).Append("\n");
            sb.Append("  vnicPortId: ").Append(VnicPortId).Append("\n");
            sb.Append("  vnicDeviceId: ").Append(VnicDeviceId).Append("\n");
            sb.Append("  vnicDeviceOwner: ").Append(VnicDeviceOwner).Append("\n");
            sb.Append("  vnicDeviceOwnerPrefixlike: ").Append(VnicDeviceOwnerPrefixlike).Append("\n");
            sb.Append("  vnicInstanceType: ").Append(VnicInstanceType).Append("\n");
            sb.Append("  vnicInstanceId: ").Append(VnicInstanceId).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectGeipBindingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectGeipBindingsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    (this.Fields != null &&
                    this.Fields.Equals(input.Fields))
                ) && 
                (
                    this.GeipId == input.GeipId ||
                    (this.GeipId != null &&
                    this.GeipId.Equals(input.GeipId))
                ) && 
                (
                    this.GeipIpAddress == input.GeipIpAddress ||
                    (this.GeipIpAddress != null &&
                    this.GeipIpAddress.Equals(input.GeipIpAddress))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceVpcId == input.InstanceVpcId ||
                    (this.InstanceVpcId != null &&
                    this.InstanceVpcId.Equals(input.InstanceVpcId))
                ) && 
                (
                    this.GcbandwidthId == input.GcbandwidthId ||
                    (this.GcbandwidthId != null &&
                    this.GcbandwidthId.Equals(input.GcbandwidthId))
                ) && 
                (
                    this.GcbandwidthAdminStatus == input.GcbandwidthAdminStatus ||
                    (this.GcbandwidthAdminStatus != null &&
                    this.GcbandwidthAdminStatus.Equals(input.GcbandwidthAdminStatus))
                ) && 
                (
                    this.GcbandwidthSize == input.GcbandwidthSize ||
                    (this.GcbandwidthSize != null &&
                    this.GcbandwidthSize.Equals(input.GcbandwidthSize))
                ) && 
                (
                    this.GcbandwidthSlaLevel == input.GcbandwidthSlaLevel ||
                    (this.GcbandwidthSlaLevel != null &&
                    this.GcbandwidthSlaLevel.Equals(input.GcbandwidthSlaLevel))
                ) && 
                (
                    this.GcbandwidthDscp == input.GcbandwidthDscp ||
                    (this.GcbandwidthDscp != null &&
                    this.GcbandwidthDscp.Equals(input.GcbandwidthDscp))
                ) && 
                (
                    this.VnicPrivateIpAddress == input.VnicPrivateIpAddress ||
                    (this.VnicPrivateIpAddress != null &&
                    this.VnicPrivateIpAddress.Equals(input.VnicPrivateIpAddress))
                ) && 
                (
                    this.VnicVpcId == input.VnicVpcId ||
                    (this.VnicVpcId != null &&
                    this.VnicVpcId.Equals(input.VnicVpcId))
                ) && 
                (
                    this.VnicPortId == input.VnicPortId ||
                    (this.VnicPortId != null &&
                    this.VnicPortId.Equals(input.VnicPortId))
                ) && 
                (
                    this.VnicDeviceId == input.VnicDeviceId ||
                    (this.VnicDeviceId != null &&
                    this.VnicDeviceId.Equals(input.VnicDeviceId))
                ) && 
                (
                    this.VnicDeviceOwner == input.VnicDeviceOwner ||
                    (this.VnicDeviceOwner != null &&
                    this.VnicDeviceOwner.Equals(input.VnicDeviceOwner))
                ) && 
                (
                    this.VnicDeviceOwnerPrefixlike == input.VnicDeviceOwnerPrefixlike ||
                    (this.VnicDeviceOwnerPrefixlike != null &&
                    this.VnicDeviceOwnerPrefixlike.Equals(input.VnicDeviceOwnerPrefixlike))
                ) && 
                (
                    this.VnicInstanceType == input.VnicInstanceType ||
                    (this.VnicInstanceType != null &&
                    this.VnicInstanceType.Equals(input.VnicInstanceType))
                ) && 
                (
                    this.VnicInstanceId == input.VnicInstanceId ||
                    (this.VnicInstanceId != null &&
                    this.VnicInstanceId.Equals(input.VnicInstanceId))
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.SortDir == input.SortDir ||
                    (this.SortDir != null &&
                    this.SortDir.Equals(input.SortDir))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.GeipId != null)
                    hashCode = hashCode * 59 + this.GeipId.GetHashCode();
                if (this.GeipIpAddress != null)
                    hashCode = hashCode * 59 + this.GeipIpAddress.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceVpcId != null)
                    hashCode = hashCode * 59 + this.InstanceVpcId.GetHashCode();
                if (this.GcbandwidthId != null)
                    hashCode = hashCode * 59 + this.GcbandwidthId.GetHashCode();
                if (this.GcbandwidthAdminStatus != null)
                    hashCode = hashCode * 59 + this.GcbandwidthAdminStatus.GetHashCode();
                if (this.GcbandwidthSize != null)
                    hashCode = hashCode * 59 + this.GcbandwidthSize.GetHashCode();
                if (this.GcbandwidthSlaLevel != null)
                    hashCode = hashCode * 59 + this.GcbandwidthSlaLevel.GetHashCode();
                if (this.GcbandwidthDscp != null)
                    hashCode = hashCode * 59 + this.GcbandwidthDscp.GetHashCode();
                if (this.VnicPrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.VnicPrivateIpAddress.GetHashCode();
                if (this.VnicVpcId != null)
                    hashCode = hashCode * 59 + this.VnicVpcId.GetHashCode();
                if (this.VnicPortId != null)
                    hashCode = hashCode * 59 + this.VnicPortId.GetHashCode();
                if (this.VnicDeviceId != null)
                    hashCode = hashCode * 59 + this.VnicDeviceId.GetHashCode();
                if (this.VnicDeviceOwner != null)
                    hashCode = hashCode * 59 + this.VnicDeviceOwner.GetHashCode();
                if (this.VnicDeviceOwnerPrefixlike != null)
                    hashCode = hashCode * 59 + this.VnicDeviceOwnerPrefixlike.GetHashCode();
                if (this.VnicInstanceType != null)
                    hashCode = hashCode * 59 + this.VnicInstanceType.GetHashCode();
                if (this.VnicInstanceId != null)
                    hashCode = hashCode * 59 + this.VnicInstanceId.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null)
                    hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
