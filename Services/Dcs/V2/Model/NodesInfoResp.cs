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
    /// 
    /// </summary>
    public class NodesInfoResp 
    {
        /// <summary>
        /// 节点状态，所有值如下: - Creating：创建中。 - Active：运行中。 - Inactive：故障。 - Deleting：删除中。 - AddSharding：添加分片中。 
        /// </summary>
        /// <value>节点状态，所有值如下: - Creating：创建中。 - Active：运行中。 - Inactive：故障。 - Deleting：删除中。 - AddSharding：添加分片中。 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: Creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("Creating");

            /// <summary>
            /// Enum ACTIVE for value: Active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("Active");

            /// <summary>
            /// Enum INACTIVE for value: Inactive
            /// </summary>
            public static readonly StatusEnum INACTIVE = new StatusEnum("Inactive");

            /// <summary>
            /// Enum DELETING for value: Deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("Deleting");

            /// <summary>
            /// Enum ADDSHARDING for value: AddSharding
            /// </summary>
            public static readonly StatusEnum ADDSHARDING = new StatusEnum("AddSharding");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Creating", CREATING },
                { "Active", ACTIVE },
                { "Inactive", INACTIVE },
                { "Deleting", DELETING },
                { "AddSharding", ADDSHARDING },
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
        /// 节点角色，所有值如下: - redis-server：Redis server节点。 - redis-proxy：proxy节点。 
        /// </summary>
        /// <value>节点角色，所有值如下: - redis-server：Redis server节点。 - redis-proxy：proxy节点。 </value>
        [JsonConverter(typeof(EnumClassConverter<NodeRoleEnum>))]
        public class NodeRoleEnum
        {
            /// <summary>
            /// Enum REDIS_SERVER for value: redis-server
            /// </summary>
            public static readonly NodeRoleEnum REDIS_SERVER = new NodeRoleEnum("redis-server");

            /// <summary>
            /// Enum REDIS_PROXY for value: redis-proxy
            /// </summary>
            public static readonly NodeRoleEnum REDIS_PROXY = new NodeRoleEnum("redis-proxy");

            private static readonly Dictionary<string, NodeRoleEnum> StaticFields =
            new Dictionary<string, NodeRoleEnum>()
            {
                { "redis-server", REDIS_SERVER },
                { "redis-proxy", REDIS_PROXY },
            };

            private string Value;

            public NodeRoleEnum(string value)
            {
                Value = value;
            }

            public static NodeRoleEnum FromValue(string value)
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

                if (this.Equals(obj as NodeRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NodeRoleEnum a, NodeRoleEnum b)
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

            public static bool operator !=(NodeRoleEnum a, NodeRoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 节点主从角色: - master：主 - slave：从 - proxy: proxy实例节点角色为\&quot;proxy\&quot; 
        /// </summary>
        /// <value>节点主从角色: - master：主 - slave：从 - proxy: proxy实例节点角色为\&quot;proxy\&quot; </value>
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

            private string Value;

            public NodeTypeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 逻辑节点ID
        /// </summary>
        [JsonProperty("logical_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicalNodeId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点状态，所有值如下: - Creating：创建中。 - Active：运行中。 - Inactive：故障。 - Deleting：删除中。 - AddSharding：添加分片中。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 可用区code
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 节点角色，所有值如下: - redis-server：Redis server节点。 - redis-proxy：proxy节点。 
        /// </summary>
        [JsonProperty("node_role", NullValueHandling = NullValueHandling.Ignore)]
        public NodeRoleEnum NodeRole { get; set; }
        /// <summary>
        /// 节点主从角色: - master：主 - slave：从 - proxy: proxy实例节点角色为\&quot;proxy\&quot; 
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// 节点的IP
        /// </summary>
        [JsonProperty("node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIp { get; set; }

        /// <summary>
        /// 节点的port
        /// </summary>
        [JsonProperty("node_port", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePort { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 节点权重
        /// </summary>
        [JsonProperty("priority_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriorityWeight { get; set; }

        /// <summary>
        /// 节点的IP是否可直接访问
        /// </summary>
        [JsonProperty("is_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAccess { get; set; }

        /// <summary>
        /// 分片ID
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 分片名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否从只读域名中摘除IP
        /// </summary>
        [JsonProperty("is_remove_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRemoveIp { get; set; }

        /// <summary>
        /// 副本id
        /// </summary>
        [JsonProperty("replication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationId { get; set; }

        /// <summary>
        /// 副本对应的监控指标维度信息。可用于调用云监控服务的查询监控数据指标相关接口 - 副本的监控维度为多维度，返回数组中包含两个维度信息。从云监控查询监控数据时，要按多维度传递指标维度参数，才能查询到监控指标值 - 第一个维度为副本父维度信息 维度名称为dcs_instance_id，维度值对应副本所在的实例ID - 第二个维度，维度名称为dcs_cluster_redis_node,维度值为副本的监控对象ID，与副本ID和节点ID不同。 
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceReplicationDimensionsInfo> Dimensions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodesInfoResp {\n");
            sb.Append("  logicalNodeId: ").Append(LogicalNodeId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  nodeRole: ").Append(NodeRole).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  nodeIp: ").Append(NodeIp).Append("\n");
            sb.Append("  nodePort: ").Append(NodePort).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  priorityWeight: ").Append(PriorityWeight).Append("\n");
            sb.Append("  isAccess: ").Append(IsAccess).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  isRemoveIp: ").Append(IsRemoveIp).Append("\n");
            sb.Append("  replicationId: ").Append(ReplicationId).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodesInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodesInfoResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogicalNodeId == input.LogicalNodeId ||
                    (this.LogicalNodeId != null &&
                    this.LogicalNodeId.Equals(input.LogicalNodeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.NodeRole == input.NodeRole ||
                    (this.NodeRole != null &&
                    this.NodeRole.Equals(input.NodeRole))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.NodePort == input.NodePort ||
                    (this.NodePort != null &&
                    this.NodePort.Equals(input.NodePort))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.PriorityWeight == input.PriorityWeight ||
                    (this.PriorityWeight != null &&
                    this.PriorityWeight.Equals(input.PriorityWeight))
                ) && 
                (
                    this.IsAccess == input.IsAccess ||
                    (this.IsAccess != null &&
                    this.IsAccess.Equals(input.IsAccess))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.IsRemoveIp == input.IsRemoveIp ||
                    (this.IsRemoveIp != null &&
                    this.IsRemoveIp.Equals(input.IsRemoveIp))
                ) && 
                (
                    this.ReplicationId == input.ReplicationId ||
                    (this.ReplicationId != null &&
                    this.ReplicationId.Equals(input.ReplicationId))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
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
                if (this.LogicalNodeId != null)
                    hashCode = hashCode * 59 + this.LogicalNodeId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.NodeRole != null)
                    hashCode = hashCode * 59 + this.NodeRole.GetHashCode();
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.NodePort != null)
                    hashCode = hashCode * 59 + this.NodePort.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.PriorityWeight != null)
                    hashCode = hashCode * 59 + this.PriorityWeight.GetHashCode();
                if (this.IsAccess != null)
                    hashCode = hashCode * 59 + this.IsAccess.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.IsRemoveIp != null)
                    hashCode = hashCode * 59 + this.IsRemoveIp.GetHashCode();
                if (this.ReplicationId != null)
                    hashCode = hashCode * 59 + this.ReplicationId.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
