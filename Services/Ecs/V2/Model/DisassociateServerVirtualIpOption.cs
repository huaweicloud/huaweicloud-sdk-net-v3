using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DisassociateServerVirtualIpOption 
    {
        /// <summary>
        /// 云服务器添加网卡的信息。  约束：解绑虚拟IP时，subnet_id为空字符串
        /// </summary>
        /// <value>云服务器添加网卡的信息。  约束：解绑虚拟IP时，subnet_id为空字符串</value>
        [JsonConverter(typeof(EnumClassConverter<SubnetIdEnum>))]
        public class SubnetIdEnum
        {
            /// <summary>
            /// Enum EMPTY for value: 
            /// </summary>
            public static readonly SubnetIdEnum EMPTY = new SubnetIdEnum("");

            private static readonly Dictionary<string, SubnetIdEnum> StaticFields =
            new Dictionary<string, SubnetIdEnum>()
            {
                { "", EMPTY },
            };

            private string _value;

            public SubnetIdEnum()
            {

            }

            public SubnetIdEnum(string value)
            {
                _value = value;
            }

            public static SubnetIdEnum FromValue(string value)
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

                if (this.Equals(obj as SubnetIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubnetIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubnetIdEnum a, SubnetIdEnum b)
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

            public static bool operator !=(SubnetIdEnum a, SubnetIdEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 网卡即将配置的虚拟IP的地址。  约束：解绑虚拟IP时，ip_address为空字符串
        /// </summary>
        /// <value>网卡即将配置的虚拟IP的地址。  约束：解绑虚拟IP时，ip_address为空字符串</value>
        [JsonConverter(typeof(EnumClassConverter<IpAddressEnum>))]
        public class IpAddressEnum
        {
            /// <summary>
            /// Enum EMPTY for value: 
            /// </summary>
            public static readonly IpAddressEnum EMPTY = new IpAddressEnum("");

            private static readonly Dictionary<string, IpAddressEnum> StaticFields =
            new Dictionary<string, IpAddressEnum>()
            {
                { "", EMPTY },
            };

            private string _value;

            public IpAddressEnum()
            {

            }

            public IpAddressEnum(string value)
            {
                _value = value;
            }

            public static IpAddressEnum FromValue(string value)
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

                if (this.Equals(obj as IpAddressEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpAddressEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpAddressEnum a, IpAddressEnum b)
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

            public static bool operator !=(IpAddressEnum a, IpAddressEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器添加网卡的信息。  约束：解绑虚拟IP时，subnet_id为空字符串
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public SubnetIdEnum SubnetId { get; set; }
        /// <summary>
        /// 网卡即将配置的虚拟IP的地址。  约束：解绑虚拟IP时，ip_address为空字符串
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public IpAddressEnum IpAddress { get; set; }
        /// <summary>
        /// 虚拟IP的allowed_address_pairs属性是否添加网卡的IP/Mac对。
        /// </summary>
        [JsonProperty("reverse_binding", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReverseBinding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateServerVirtualIpOption {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  reverseBinding: ").Append(ReverseBinding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateServerVirtualIpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateServerVirtualIpOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.ReverseBinding == input.ReverseBinding ||
                    (this.ReverseBinding != null &&
                    this.ReverseBinding.Equals(input.ReverseBinding))
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
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.ReverseBinding != null)
                    hashCode = hashCode * 59 + this.ReverseBinding.GetHashCode();
                return hashCode;
            }
        }
    }
}
