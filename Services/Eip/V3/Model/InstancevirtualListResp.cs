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
    /// GEIP实例的vn信息
    /// </summary>
    public class InstancevirtualListResp 
    {
        /// <summary>
        /// 功能说明：nexthops的转发模式  取值范围：&#39;ACTIVE-ACTIVE&#39;多活模式、&#39;ACTIVE-STANDBY&#39;主备模式
        /// </summary>
        /// <value>功能说明：nexthops的转发模式  取值范围：&#39;ACTIVE-ACTIVE&#39;多活模式、&#39;ACTIVE-STANDBY&#39;主备模式</value>
        [JsonConverter(typeof(EnumClassConverter<ForwardModeEnum>))]
        public class ForwardModeEnum
        {
            /// <summary>
            /// Enum ACTIVE_ACTIVE for value: ACTIVE-ACTIVE
            /// </summary>
            public static readonly ForwardModeEnum ACTIVE_ACTIVE = new ForwardModeEnum("ACTIVE-ACTIVE");

            /// <summary>
            /// Enum ACTIVE_STANDBY for value: ACTIVE-STANDBY
            /// </summary>
            public static readonly ForwardModeEnum ACTIVE_STANDBY = new ForwardModeEnum("ACTIVE-STANDBY");

            private static readonly Dictionary<string, ForwardModeEnum> StaticFields =
            new Dictionary<string, ForwardModeEnum>()
            {
                { "ACTIVE-ACTIVE", ACTIVE_ACTIVE },
                { "ACTIVE-STANDBY", ACTIVE_STANDBY },
            };

            private string _value;

            public ForwardModeEnum()
            {

            }

            public ForwardModeEnum(string value)
            {
                _value = value;
            }

            public static ForwardModeEnum FromValue(string value)
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

                if (this.Equals(obj as ForwardModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ForwardModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ForwardModeEnum a, ForwardModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ForwardModeEnum a, ForwardModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：nexthops在底层的负载均衡策略  取值范围：&#39;2_TUPLE&#39;二元组、&#39;3_TUPLE&#39;三元组、&#39;5_TUPLE&#39;五元组
        /// </summary>
        /// <value>功能说明：nexthops在底层的负载均衡策略  取值范围：&#39;2_TUPLE&#39;二元组、&#39;3_TUPLE&#39;三元组、&#39;5_TUPLE&#39;五元组</value>
        [JsonConverter(typeof(EnumClassConverter<HashModeEnum>))]
        public class HashModeEnum
        {
            /// <summary>
            /// Enum _2_TUPLE for value: 2_TUPLE
            /// </summary>
            public static readonly HashModeEnum _2_TUPLE = new HashModeEnum("2_TUPLE");

            /// <summary>
            /// Enum _3_TUPLE for value: 3_TUPLE
            /// </summary>
            public static readonly HashModeEnum _3_TUPLE = new HashModeEnum("3_TUPLE");

            /// <summary>
            /// Enum _5_TUPLE for value: 5_TUPLE
            /// </summary>
            public static readonly HashModeEnum _5_TUPLE = new HashModeEnum("5_TUPLE");

            private static readonly Dictionary<string, HashModeEnum> StaticFields =
            new Dictionary<string, HashModeEnum>()
            {
                { "2_TUPLE", _2_TUPLE },
                { "3_TUPLE", _3_TUPLE },
                { "5_TUPLE", _5_TUPLE },
            };

            private string _value;

            public HashModeEnum()
            {

            }

            public HashModeEnum(string value)
            {
                _value = value;
            }

            public static HashModeEnum FromValue(string value)
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

                if (this.Equals(obj as HashModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HashModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HashModeEnum a, HashModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HashModeEnum a, HashModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：下一跳所属网络类型  取值范围：&#39;VXLAN&#39;、&#39;VLAN&#39;
        /// </summary>
        /// <value>功能说明：下一跳所属网络类型  取值范围：&#39;VXLAN&#39;、&#39;VLAN&#39;</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VLAN for value: VLAN
            /// </summary>
            public static readonly TypeEnum VLAN = new TypeEnum("VLAN");

            /// <summary>
            /// Enum VXLAN for value: VXLAN
            /// </summary>
            public static readonly TypeEnum VXLAN = new TypeEnum("VXLAN");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VLAN", VLAN },
                { "VXLAN", VXLAN },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// virtualnexthop的uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// virtualnexthop的所有者
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 标识网关所在位置POD、AZ、REGION、GLOBAL
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 功能说明：nexthops的转发模式  取值范围：&#39;ACTIVE-ACTIVE&#39;多活模式、&#39;ACTIVE-STANDBY&#39;主备模式
        /// </summary>
        [JsonProperty("forward_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ForwardModeEnum ForwardMode { get; set; }
        /// <summary>
        /// 功能说明：网关所在集群信息，可为空  取值范围：0-36长度的字符串
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 功能说明：nexthops在底层的负载均衡策略  取值范围：&#39;2_TUPLE&#39;二元组、&#39;3_TUPLE&#39;三元组、&#39;5_TUPLE&#39;五元组
        /// </summary>
        [JsonProperty("hash_mode", NullValueHandling = NullValueHandling.Ignore)]
        public HashModeEnum HashMode { get; set; }
        /// <summary>
        /// 功能说明：下一跳所属网络类型  取值范围：&#39;VXLAN&#39;、&#39;VLAN&#39;
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 功能说明：网络id标识，与type组合使用  取值范围：type&#x3D;VXLAN时取值0-16777215,type&#x3D;VLAN时取值0-4095
        /// </summary>
        [JsonProperty("vni", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vni { get; set; }

        /// <summary>
        /// 下一跳信息列表
        /// </summary>
        [JsonProperty("nexthops", NullValueHandling = NullValueHandling.Ignore)]
        public List<NexthopDict> Nexthops { get; set; }

        /// <summary>
        /// 功能说明：VirtualNexthop对象创建时间，UTC格式
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 功能说明：VirtualNexthop对象更新时间，UTC格式
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancevirtualListResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  forwardMode: ").Append(ForwardMode).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  hashMode: ").Append(HashMode).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  vni: ").Append(Vni).Append("\n");
            sb.Append("  nexthops: ").Append(Nexthops).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstancevirtualListResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstancevirtualListResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.ForwardMode != input.ForwardMode) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.HashMode != input.HashMode) return false;
            if (this.Type != input.Type) return false;
            if (this.Vni != input.Vni || (this.Vni != null && !this.Vni.Equals(input.Vni))) return false;
            if (this.Nexthops != input.Nexthops || (this.Nexthops != null && input.Nexthops != null && !this.Nexthops.SequenceEqual(input.Nexthops))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.ForwardMode.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                hashCode = hashCode * 59 + this.HashMode.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vni != null) hashCode = hashCode * 59 + this.Vni.GetHashCode();
                if (this.Nexthops != null) hashCode = hashCode * 59 + this.Nexthops.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
