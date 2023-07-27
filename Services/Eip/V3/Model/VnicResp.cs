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
    /// 弹性公网IP中的vnic对象，存储绑定PORT的相关信息
    /// </summary>
    public class VnicResp 
    {

        /// <summary>
        /// - 功能说明：PORT的内网地址
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// - 功能说明：PORT的device_id - 约束：存在PORT时，此字段associate_instance_id相同，都为实例ID
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// - 功能说明：PORT的device_owner - 约束：存在PORT时，此字段和associate_instance_type都可区分实例类型
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// - 功能说明：VTEP IP
        /// </summary>
        [JsonProperty("vtep", NullValueHandling = NullValueHandling.Ignore)]
        public string Vtep { get; set; }

        /// <summary>
        /// - 功能说明：VXLAN ID
        /// </summary>
        [JsonProperty("vni", NullValueHandling = NullValueHandling.Ignore)]
        public string Vni { get; set; }

        /// <summary>
        /// - 功能说明：PORT所在VPC的ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// - 功能说明：PORT的唯一标识
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// - 功能说明：端口profile信息
        /// </summary>
        [JsonProperty("port_profile", NullValueHandling = NullValueHandling.Ignore)]
        public string PortProfile { get; set; }

        /// <summary>
        /// - 功能说明：PORT的MAC信息
        /// </summary>
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }

        /// <summary>
        /// - 功能说明：PORT的使用者，不同于device_id的归属者。举例：vip port的device_owner为vip，但是这个port实际使用者可能是虚机或其他
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// - 功能说明：标记PORT使用者，与instance_id组合使用
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VnicResp {\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  vtep: ").Append(Vtep).Append("\n");
            sb.Append("  vni: ").Append(Vni).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  portProfile: ").Append(PortProfile).Append("\n");
            sb.Append("  mac: ").Append(Mac).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VnicResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VnicResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    (this.PrivateIpAddress != null &&
                    this.PrivateIpAddress.Equals(input.PrivateIpAddress))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceOwner == input.DeviceOwner ||
                    (this.DeviceOwner != null &&
                    this.DeviceOwner.Equals(input.DeviceOwner))
                ) && 
                (
                    this.Vtep == input.Vtep ||
                    (this.Vtep != null &&
                    this.Vtep.Equals(input.Vtep))
                ) && 
                (
                    this.Vni == input.Vni ||
                    (this.Vni != null &&
                    this.Vni.Equals(input.Vni))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.PortProfile == input.PortProfile ||
                    (this.PortProfile != null &&
                    this.PortProfile.Equals(input.PortProfile))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
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
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceOwner != null)
                    hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.Vtep != null)
                    hashCode = hashCode * 59 + this.Vtep.GetHashCode();
                if (this.Vni != null)
                    hashCode = hashCode * 59 + this.Vni.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PortProfile != null)
                    hashCode = hashCode * 59 + this.PortProfile.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
