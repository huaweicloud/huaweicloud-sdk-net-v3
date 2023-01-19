using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// interfaceAttachments字段数据结构说明
    /// </summary>
    public class InterfaceAttachments 
    {
        /// <summary>
        /// 网卡端口状态。取值为：ACTIVE、BUILD、DOWN
        /// </summary>
        /// <value>网卡端口状态。取值为：ACTIVE、BUILD、DOWN</value>
        [JsonConverter(typeof(EnumClassConverter<PortStateEnum>))]
        public class PortStateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly PortStateEnum ACTIVE = new PortStateEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly PortStateEnum BUILD = new PortStateEnum("BUILD");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly PortStateEnum DOWN = new PortStateEnum("DOWN");

            private static readonly Dictionary<string, PortStateEnum> StaticFields =
            new Dictionary<string, PortStateEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILD", BUILD },
                { "DOWN", DOWN },
            };

            private string _value;

            public PortStateEnum()
            {

            }

            public PortStateEnum(string value)
            {
                _value = value;
            }

            public static PortStateEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as PortStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PortStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PortStateEnum a, PortStateEnum b)
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

            public static bool operator !=(PortStateEnum a, PortStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 网卡端口状态。取值为：ACTIVE、BUILD、DOWN
        /// </summary>
        [JsonProperty("port_state", NullValueHandling = NullValueHandling.Ignore)]
        public PortStateEnum PortState { get; set; }
        /// <summary>
        /// 网卡私网IP信息列表，详情请参见表3 fixed_ips字段数据结构说明。
        /// </summary>
        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FixedIps> FixedIps { get; set; }

        /// <summary>
        /// 网卡端口所属子网的网络ID（network_id）。
        /// </summary>
        [JsonProperty("net_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NetId { get; set; }

        /// <summary>
        /// 网卡端口ID。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PortId { get; set; }

        /// <summary>
        /// 网卡Mac地址信息
        /// </summary>
        [JsonProperty("mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddr { get; set; }

        /// <summary>
        /// 从guest os中，网卡的驱动类型
        /// </summary>
        [JsonProperty("driver_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverMode { get; set; }

        /// <summary>
        /// 弹性网卡在Linux GuestOS里的BDF号
        /// </summary>
        [JsonProperty("pci_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PciAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterfaceAttachments {\n");
            sb.Append("  portState: ").Append(PortState).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  netId: ").Append(NetId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  macAddr: ").Append(MacAddr).Append("\n");
            sb.Append("  driverMode: ").Append(DriverMode).Append("\n");
            sb.Append("  pciAddress: ").Append(PciAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterfaceAttachments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterfaceAttachments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortState == input.PortState ||
                    (this.PortState != null &&
                    this.PortState.Equals(input.PortState))
                ) && 
                (
                    this.FixedIps == input.FixedIps ||
                    this.FixedIps != null &&
                    input.FixedIps != null &&
                    this.FixedIps.SequenceEqual(input.FixedIps)
                ) && 
                (
                    this.NetId == input.NetId ||
                    (this.NetId != null &&
                    this.NetId.Equals(input.NetId))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.MacAddr == input.MacAddr ||
                    (this.MacAddr != null &&
                    this.MacAddr.Equals(input.MacAddr))
                ) && 
                (
                    this.DriverMode == input.DriverMode ||
                    (this.DriverMode != null &&
                    this.DriverMode.Equals(input.DriverMode))
                ) && 
                (
                    this.PciAddress == input.PciAddress ||
                    (this.PciAddress != null &&
                    this.PciAddress.Equals(input.PciAddress))
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
                if (this.PortState != null)
                    hashCode = hashCode * 59 + this.PortState.GetHashCode();
                if (this.FixedIps != null)
                    hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.NetId != null)
                    hashCode = hashCode * 59 + this.NetId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.MacAddr != null)
                    hashCode = hashCode * 59 + this.MacAddr.GetHashCode();
                if (this.DriverMode != null)
                    hashCode = hashCode * 59 + this.DriverMode.GetHashCode();
                if (this.PciAddress != null)
                    hashCode = hashCode * 59 + this.PciAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
