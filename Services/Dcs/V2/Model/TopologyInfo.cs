using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 拓扑详情
    /// </summary>
    public class TopologyInfo 
    {
        /// <summary>
        /// **参数解释**： 节点主从角色。 **取值范围**： master：主节点 slave：从节点 proxy：proxy节点 
        /// </summary>
        /// <value>**参数解释**： 节点主从角色。 **取值范围**： master：主节点 slave：从节点 proxy：proxy节点 </value>
        [JsonConverter(typeof(EnumClassConverter<NodeTypeEnum>))]
        public class NodeTypeEnum
        {
            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly NodeTypeEnum MASTER = new NodeTypeEnum("master");

            /// <summary>
            /// Enum SLAVE for value: slave
            /// </summary>
            public static readonly NodeTypeEnum SLAVE = new NodeTypeEnum("slave");

            /// <summary>
            /// Enum PROXY for value: proxy
            /// </summary>
            public static readonly NodeTypeEnum PROXY = new NodeTypeEnum("proxy");

            private static readonly Dictionary<string, NodeTypeEnum> StaticFields =
            new Dictionary<string, NodeTypeEnum>()
            {
                { "master", MASTER },
                { "slave", SLAVE },
                { "proxy", PROXY },
            };

            private string _value;

            public NodeTypeEnum()
            {

            }

            public NodeTypeEnum(string value)
            {
                _value = value;
            }

            public static NodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 节点ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**： 节点名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// **参数解释**： 节点IP。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// **参数解释**： 节点端口。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释**： 节点主从角色。 **取值范围**： master：主节点 slave：从节点 proxy：proxy节点 
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// **参数解释**： 总内存，单位：MB。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("max_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxMemory { get; set; }

        /// <summary>
        /// **参数解释**： 已使用的内存，单位：MB。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("used_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedMemory { get; set; }

        /// <summary>
        /// **参数解释**： 每秒查询率。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public string Qps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandWidth Bandwidth { get; set; }

        /// <summary>
        /// **参数解释**： 该实例的DB数量。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("db_num", NullValueHandling = NullValueHandling.Ignore)]
        public string DbNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dbs", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpace Dbs { get; set; }

        /// <summary>
        /// **参数解释**： 关联IP。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("relation_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationIp { get; set; }

        /// <summary>
        /// **参数解释**： 关联端口。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("relation_port", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationPort { get; set; }

        /// <summary>
        /// **参数解释**： 分片ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 节点状态。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dims", NullValueHandling = NullValueHandling.Ignore)]
        public DimsInfo Dims { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopologyInfo {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  maxMemory: ").Append(MaxMemory).Append("\n");
            sb.Append("  usedMemory: ").Append(UsedMemory).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  dbNum: ").Append(DbNum).Append("\n");
            sb.Append("  dbs: ").Append(Dbs).Append("\n");
            sb.Append("  relationIp: ").Append(RelationIp).Append("\n");
            sb.Append("  relationPort: ").Append(RelationPort).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  dims: ").Append(Dims).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopologyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopologyInfo input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.NodeType != input.NodeType) return false;
            if (this.MaxMemory != input.MaxMemory || (this.MaxMemory != null && !this.MaxMemory.Equals(input.MaxMemory))) return false;
            if (this.UsedMemory != input.UsedMemory || (this.UsedMemory != null && !this.UsedMemory.Equals(input.UsedMemory))) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.DbNum != input.DbNum || (this.DbNum != null && !this.DbNum.Equals(input.DbNum))) return false;
            if (this.Dbs != input.Dbs || (this.Dbs != null && !this.Dbs.Equals(input.Dbs))) return false;
            if (this.RelationIp != input.RelationIp || (this.RelationIp != null && !this.RelationIp.Equals(input.RelationIp))) return false;
            if (this.RelationPort != input.RelationPort || (this.RelationPort != null && !this.RelationPort.Equals(input.RelationPort))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Dims != input.Dims || (this.Dims != null && !this.Dims.Equals(input.Dims))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.MaxMemory != null) hashCode = hashCode * 59 + this.MaxMemory.GetHashCode();
                if (this.UsedMemory != null) hashCode = hashCode * 59 + this.UsedMemory.GetHashCode();
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.DbNum != null) hashCode = hashCode * 59 + this.DbNum.GetHashCode();
                if (this.Dbs != null) hashCode = hashCode * 59 + this.Dbs.GetHashCode();
                if (this.RelationIp != null) hashCode = hashCode * 59 + this.RelationIp.GetHashCode();
                if (this.RelationPort != null) hashCode = hashCode * 59 + this.RelationPort.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Dims != null) hashCode = hashCode * 59 + this.Dims.GetHashCode();
                return hashCode;
            }
        }
    }
}
