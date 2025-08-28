using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GroupInfo 
    {
        /// <summary>
        /// 组角色类型。
        /// </summary>
        /// <value>组角色类型。</value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum RW for value: rw
            /// </summary>
            public static readonly RoleEnum RW = new RoleEnum("rw");

            /// <summary>
            /// Enum R for value: r
            /// </summary>
            public static readonly RoleEnum R = new RoleEnum("r");

            private static readonly Dictionary<string, RoleEnum> StaticFields =
            new Dictionary<string, RoleEnum>()
            {
                { "rw", RW },
                { "r", R },
            };

            private string _value;

            public RoleEnum()
            {

            }

            public RoleEnum(string value)
            {
                _value = value;
            }

            public static RoleEnum FromValue(string value)
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// CPU架构。
        /// </summary>
        /// <value>CPU架构。</value>
        [JsonConverter(typeof(EnumClassConverter<ArchitectureEnum>))]
        public class ArchitectureEnum
        {
            /// <summary>
            /// Enum X86 for value: X86
            /// </summary>
            public static readonly ArchitectureEnum X86 = new ArchitectureEnum("X86");

            /// <summary>
            /// Enum ARM for value: ARM
            /// </summary>
            public static readonly ArchitectureEnum ARM = new ArchitectureEnum("ARM");

            private static readonly Dictionary<string, ArchitectureEnum> StaticFields =
            new Dictionary<string, ArchitectureEnum>()
            {
                { "X86", X86 },
                { "ARM", ARM },
            };

            private string _value;

            public ArchitectureEnum()
            {

            }

            public ArchitectureEnum(string value)
            {
                _value = value;
            }

            public static ArchitectureEnum FromValue(string value)
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

                if (this.Equals(obj as ArchitectureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchitectureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchitectureEnum a, ArchitectureEnum b)
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

            public static bool operator !=(ArchitectureEnum a, ArchitectureEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 组角色类型。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// 组连接地址，如未开启负载均衡，则返回的是组内节点连接地址串。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 组ipv6连接地址。
        /// </summary>
        [JsonProperty("ipv6_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6Endpoint { get; set; }

        /// <summary>
        /// 是否开启负载均衡。
        /// </summary>
        [JsonProperty("is_load_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLoadBalance { get; set; }

        /// <summary>
        /// 是否默认组。
        /// </summary>
        [JsonProperty("is_default_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultGroup { get; set; }

        /// <summary>
        /// 单节点CPU核数。
        /// </summary>
        [JsonProperty("cpu_num_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuNumPerNode { get; set; }

        /// <summary>
        /// 单节点内存大小,单位G。
        /// </summary>
        [JsonProperty("mem_num_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemNumPerNode { get; set; }

        /// <summary>
        /// CPU架构。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
        /// <summary>
        /// 节点信息列表。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupNodeInfo> NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  ipv6Endpoint: ").Append(Ipv6Endpoint).Append("\n");
            sb.Append("  isLoadBalance: ").Append(IsLoadBalance).Append("\n");
            sb.Append("  isDefaultGroup: ").Append(IsDefaultGroup).Append("\n");
            sb.Append("  cpuNumPerNode: ").Append(CpuNumPerNode).Append("\n");
            sb.Append("  memNumPerNode: ").Append(MemNumPerNode).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Role != input.Role) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Ipv6Endpoint != input.Ipv6Endpoint || (this.Ipv6Endpoint != null && !this.Ipv6Endpoint.Equals(input.Ipv6Endpoint))) return false;
            if (this.IsLoadBalance != input.IsLoadBalance || (this.IsLoadBalance != null && !this.IsLoadBalance.Equals(input.IsLoadBalance))) return false;
            if (this.IsDefaultGroup != input.IsDefaultGroup || (this.IsDefaultGroup != null && !this.IsDefaultGroup.Equals(input.IsDefaultGroup))) return false;
            if (this.CpuNumPerNode != input.CpuNumPerNode || (this.CpuNumPerNode != null && !this.CpuNumPerNode.Equals(input.CpuNumPerNode))) return false;
            if (this.MemNumPerNode != input.MemNumPerNode || (this.MemNumPerNode != null && !this.MemNumPerNode.Equals(input.MemNumPerNode))) return false;
            if (this.Architecture != input.Architecture) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Ipv6Endpoint != null) hashCode = hashCode * 59 + this.Ipv6Endpoint.GetHashCode();
                if (this.IsLoadBalance != null) hashCode = hashCode * 59 + this.IsLoadBalance.GetHashCode();
                if (this.IsDefaultGroup != null) hashCode = hashCode * 59 + this.IsDefaultGroup.GetHashCode();
                if (this.CpuNumPerNode != null) hashCode = hashCode * 59 + this.CpuNumPerNode.GetHashCode();
                if (this.MemNumPerNode != null) hashCode = hashCode * 59 + this.MemNumPerNode.GetHashCode();
                hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
