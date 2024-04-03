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
    /// 实例port的信息
    /// </summary>
    public class InstanceVnicResp 
    {

        /// <summary>
        /// 实例port的ip地址
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// port的device_id
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// port的device_owner
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// port的vpc_id
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// port的uuid
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// port的mac地址
        /// </summary>
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }

        /// <summary>
        /// port的vtep地址
        /// </summary>
        [JsonProperty("vtep", NullValueHandling = NullValueHandling.Ignore)]
        public string Vtep { get; set; }

        /// <summary>
        /// port的vni
        /// </summary>
        [JsonProperty("vni", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vni { get; set; }

        /// <summary>
        /// port的实例id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// port的实例类型
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// port的profile
        /// </summary>
        [JsonProperty("port_profile", NullValueHandling = NullValueHandling.Ignore)]
        public string PortProfile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceVnicResp {\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  mac: ").Append(Mac).Append("\n");
            sb.Append("  vtep: ").Append(Vtep).Append("\n");
            sb.Append("  vni: ").Append(Vni).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  portProfile: ").Append(PortProfile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceVnicResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceVnicResp input)
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
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
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
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.PortProfile == input.PortProfile ||
                    (this.PortProfile != null &&
                    this.PortProfile.Equals(input.PortProfile))
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
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.Vtep != null)
                    hashCode = hashCode * 59 + this.Vtep.GetHashCode();
                if (this.Vni != null)
                    hashCode = hashCode * 59 + this.Vni.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.PortProfile != null)
                    hashCode = hashCode * 59 + this.PortProfile.GetHashCode();
                return hashCode;
            }
        }
    }
}
