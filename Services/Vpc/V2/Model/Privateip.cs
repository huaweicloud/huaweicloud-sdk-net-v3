using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Privateip 
    {
        /// <summary>
        /// 私有IP的状态  - ACTIVE：活动的  - DOWN：不可用
        /// </summary>
        /// <value>私有IP的状态  - ACTIVE：活动的  - DOWN：不可用</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "DOWN", DOWN },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 私有IP的使用者，空表示未使用 取值范围：network:dhcp，network:router_interface_distributed，compute:xxx(xxx对应具体的az名称，例如compute:aa-bb-cc表示是被aa-bb-cc上的虚拟机使用) 约束：此处的取值范围只是本服务支持的类型，其他类型未做标注
        /// </summary>
        /// <value>私有IP的使用者，空表示未使用 取值范围：network:dhcp，network:router_interface_distributed，compute:xxx(xxx对应具体的az名称，例如compute:aa-bb-cc表示是被aa-bb-cc上的虚拟机使用) 约束：此处的取值范围只是本服务支持的类型，其他类型未做标注</value>
        [JsonConverter(typeof(EnumClassConverter<DeviceOwnerEnum>))]
        public class DeviceOwnerEnum
        {
            /// <summary>
            /// Enum NETWORK_DHCP for value: network:dhcp
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_DHCP = new DeviceOwnerEnum("network:dhcp");

            /// <summary>
            /// Enum NETWORK_ROUTER_INTERFACE_DISTRIBUTED for value: network:router_interface_distributed
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_ROUTER_INTERFACE_DISTRIBUTED = new DeviceOwnerEnum("network:router_interface_distributed");

            /// <summary>
            /// Enum COMPUTE_XXX for value: compute:xxx
            /// </summary>
            public static readonly DeviceOwnerEnum COMPUTE_XXX = new DeviceOwnerEnum("compute:xxx");

            private static readonly Dictionary<string, DeviceOwnerEnum> StaticFields =
            new Dictionary<string, DeviceOwnerEnum>()
            {
                { "network:dhcp", NETWORK_DHCP },
                { "network:router_interface_distributed", NETWORK_ROUTER_INTERFACE_DISTRIBUTED },
                { "compute:xxx", COMPUTE_XXX },
            };

            private string Value;

            public DeviceOwnerEnum(string value)
            {
                Value = value;
            }

            public static DeviceOwnerEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DeviceOwnerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeviceOwnerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeviceOwnerEnum a, DeviceOwnerEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DeviceOwnerEnum a, DeviceOwnerEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 私有IP的状态  - ACTIVE：活动的  - DOWN：不可用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 私有IP ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分配IP的子网标识
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 私有IP的使用者，空表示未使用 取值范围：network:dhcp，network:router_interface_distributed，compute:xxx(xxx对应具体的az名称，例如compute:aa-bb-cc表示是被aa-bb-cc上的虚拟机使用) 约束：此处的取值范围只是本服务支持的类型，其他类型未做标注
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceOwnerEnum DeviceOwner { get; set; }
        /// <summary>
        /// 申请到的私有IP
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Privateip {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Privateip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Privateip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.DeviceOwner == input.DeviceOwner ||
                    (this.DeviceOwner != null &&
                    this.DeviceOwner.Equals(input.DeviceOwner))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.DeviceOwner != null)
                    hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
