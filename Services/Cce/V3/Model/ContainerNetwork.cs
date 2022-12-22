using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Container network parameters.
    /// </summary>
    public class ContainerNetwork 
    {
        /// <summary>
        /// 容器网络类型（只可选择其一） - overlay_l2：容器隧道网络，通过OVS（OpenVSwitch）为容器构建的overlay_l2网络。 - vpc-router：VPC网络，使用ipvlan和自定义VPC路由为容器构建的Underlay的l2网络。 [- eni：云原生网络2.0，深度整合VPC原生ENI弹性网卡能力，采用VPC网段分配容器地址，支持ELB直通容器，享有高性能，创建CCE Turbo集群时指定。](tag:hws,hws_hk,dt) 
        /// </summary>
        /// <value>容器网络类型（只可选择其一） - overlay_l2：容器隧道网络，通过OVS（OpenVSwitch）为容器构建的overlay_l2网络。 - vpc-router：VPC网络，使用ipvlan和自定义VPC路由为容器构建的Underlay的l2网络。 [- eni：云原生网络2.0，深度整合VPC原生ENI弹性网卡能力，采用VPC网段分配容器地址，支持ELB直通容器，享有高性能，创建CCE Turbo集群时指定。](tag:hws,hws_hk,dt) </value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum OVERLAY_L2 for value: overlay_l2
            /// </summary>
            public static readonly ModeEnum OVERLAY_L2 = new ModeEnum("overlay_l2");

            /// <summary>
            /// Enum VPC_ROUTER for value: vpc-router
            /// </summary>
            public static readonly ModeEnum VPC_ROUTER = new ModeEnum("vpc-router");

            /// <summary>
            /// Enum ENI for value: eni
            /// </summary>
            public static readonly ModeEnum ENI = new ModeEnum("eni");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "overlay_l2", OVERLAY_L2 },
                { "vpc-router", VPC_ROUTER },
                { "eni", ENI },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容器网络类型（只可选择其一） - overlay_l2：容器隧道网络，通过OVS（OpenVSwitch）为容器构建的overlay_l2网络。 - vpc-router：VPC网络，使用ipvlan和自定义VPC路由为容器构建的Underlay的l2网络。 [- eni：云原生网络2.0，深度整合VPC原生ENI弹性网卡能力，采用VPC网段分配容器地址，支持ELB直通容器，享有高性能，创建CCE Turbo集群时指定。](tag:hws,hws_hk,dt) 
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 容器网络网段，建议使用网段10.0.0.0/12~19，172.16.0.0/16~19，192.168.0.0/16~19，如存在网段冲突，将会报错。  此参数在集群创建后不可更改，请谨慎选择。（已废弃，如填写cidrs将忽略该cidr） 
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 容器网络网段列表。1.21及新版本集群使用cidrs字段，当集群网络类型为vpc-router类型时，支持多个容器网段；1.21之前版本若使用cidrs字段，则取值cidrs数组中的第一个cidr元素作为容器网络网段地址。  此参数在集群创建后不可更改，请谨慎选择。 
        /// </summary>
        [JsonProperty("cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContainerCIDR> Cidrs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerNetwork {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  cidrs: ").Append(Cidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContainerNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContainerNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.Cidrs == input.Cidrs ||
                    this.Cidrs != null &&
                    input.Cidrs != null &&
                    this.Cidrs.SequenceEqual(input.Cidrs)
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.Cidrs != null)
                    hashCode = hashCode * 59 + this.Cidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
