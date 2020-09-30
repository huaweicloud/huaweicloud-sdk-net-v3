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
    /// Request Object
    /// </summary>
    public class ShowQuotaRequest 
    {
        /// <summary>
        /// Defines type
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly TypeEnum VPC = new TypeEnum("vpc");

            /// <summary>
            /// Enum SUBNET for value: subnet
            /// </summary>
            public static readonly TypeEnum SUBNET = new TypeEnum("subnet");

            /// <summary>
            /// Enum SECURITYGROUP for value: securityGroup
            /// </summary>
            public static readonly TypeEnum SECURITYGROUP = new TypeEnum("securityGroup");

            /// <summary>
            /// Enum SECURITYGROUPRULE for value: securityGroupRule
            /// </summary>
            public static readonly TypeEnum SECURITYGROUPRULE = new TypeEnum("securityGroupRule");

            /// <summary>
            /// Enum PUBLICIP for value: publicIp
            /// </summary>
            public static readonly TypeEnum PUBLICIP = new TypeEnum("publicIp");

            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly TypeEnum VPN = new TypeEnum("vpn");

            /// <summary>
            /// Enum VPNGW for value: vpngw
            /// </summary>
            public static readonly TypeEnum VPNGW = new TypeEnum("vpngw");

            /// <summary>
            /// Enum VPCPEER for value: vpcPeer
            /// </summary>
            public static readonly TypeEnum VPCPEER = new TypeEnum("vpcPeer");

            /// <summary>
            /// Enum FIREWALL for value: firewall
            /// </summary>
            public static readonly TypeEnum FIREWALL = new TypeEnum("firewall");

            /// <summary>
            /// Enum SHAREBANDWIDTH for value: shareBandwidth
            /// </summary>
            public static readonly TypeEnum SHAREBANDWIDTH = new TypeEnum("shareBandwidth");

            /// <summary>
            /// Enum SHAREBANDWIDTHIP for value: shareBandwidthIP
            /// </summary>
            public static readonly TypeEnum SHAREBANDWIDTHIP = new TypeEnum("shareBandwidthIP");

            /// <summary>
            /// Enum LOADBALANCER for value: loadbalancer
            /// </summary>
            public static readonly TypeEnum LOADBALANCER = new TypeEnum("loadbalancer");

            /// <summary>
            /// Enum LISTENER for value: listener
            /// </summary>
            public static readonly TypeEnum LISTENER = new TypeEnum("listener");

            /// <summary>
            /// Enum PHYSICALCONNECT for value: physicalConnect
            /// </summary>
            public static readonly TypeEnum PHYSICALCONNECT = new TypeEnum("physicalConnect");

            /// <summary>
            /// Enum VIRTUALINTERFACE for value: virtualInterface
            /// </summary>
            public static readonly TypeEnum VIRTUALINTERFACE = new TypeEnum("virtualInterface");

            /// <summary>
            /// Enum VPCCONTAINROUTETABLE for value: vpcContainRoutetable
            /// </summary>
            public static readonly TypeEnum VPCCONTAINROUTETABLE = new TypeEnum("vpcContainRoutetable");

            /// <summary>
            /// Enum ROUTETABLECONTAINROUTES for value: routetableContainRoutes
            /// </summary>
            public static readonly TypeEnum ROUTETABLECONTAINROUTES = new TypeEnum("routetableContainRoutes");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "vpc", VPC },
                { "subnet", SUBNET },
                { "securityGroup", SECURITYGROUP },
                { "securityGroupRule", SECURITYGROUPRULE },
                { "publicIp", PUBLICIP },
                { "vpn", VPN },
                { "vpngw", VPNGW },
                { "vpcPeer", VPCPEER },
                { "firewall", FIREWALL },
                { "shareBandwidth", SHAREBANDWIDTH },
                { "shareBandwidthIP", SHAREBANDWIDTHIP },
                { "loadbalancer", LOADBALANCER },
                { "listener", LISTENER },
                { "physicalConnect", PHYSICALCONNECT },
                { "virtualInterface", VIRTUALINTERFACE },
                { "vpcContainRoutetable", VPCCONTAINROUTETABLE },
                { "routetableContainRoutes", ROUTETABLECONTAINROUTES },
            };

            private string Value;

            private TypeEnum(string value)
            {
                this.Value = value;
            }

            public static TypeEnum FromValue(string value)
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
                return this.Value;
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotaRequest {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotaRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
