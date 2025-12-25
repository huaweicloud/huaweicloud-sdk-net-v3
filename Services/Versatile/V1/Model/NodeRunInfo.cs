using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeRunInfo 
    {
        /// <summary>
        /// 工作流节点状态
        /// </summary>
        /// <value>工作流节点状态</value>
        [JsonConverter(typeof(EnumClassConverter<NodeStatusEnum>))]
        public class NodeStatusEnum
        {
            /// <summary>
            /// Enum NODE_STARTED for value: node_started
            /// </summary>
            public static readonly NodeStatusEnum NODE_STARTED = new NodeStatusEnum("node_started");

            /// <summary>
            /// Enum NODE_WAIT for value: node_wait
            /// </summary>
            public static readonly NodeStatusEnum NODE_WAIT = new NodeStatusEnum("node_wait");

            /// <summary>
            /// Enum NODE_FINISHED for value: node_finished
            /// </summary>
            public static readonly NodeStatusEnum NODE_FINISHED = new NodeStatusEnum("node_finished");

            private static readonly Dictionary<string, NodeStatusEnum> StaticFields =
            new Dictionary<string, NodeStatusEnum>()
            {
                { "node_started", NODE_STARTED },
                { "node_wait", NODE_WAIT },
                { "node_finished", NODE_FINISHED },
            };

            private string _value;

            public NodeStatusEnum()
            {

            }

            public NodeStatusEnum(string value)
            {
                _value = value;
            }

            public static NodeStatusEnum FromValue(string value)
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

                if (this.Equals(obj as NodeStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeStatusEnum a, NodeStatusEnum b)
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

            public static bool operator !=(NodeStatusEnum a, NodeStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [JsonProperty("parent_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// 工作流节点状态
        /// </summary>
        [JsonProperty("node_status", NullValueHandling = NullValueHandling.Ignore)]
        public NodeStatusEnum NodeStatus { get; set; }
        /// <summary>
        /// 父工作流节点id
        /// </summary>
        [JsonProperty("parent_workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentWorkflowId { get; set; }

        /// <summary>
        /// 循环次数
        /// </summary>
        [JsonProperty("loop_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? LoopIndex { get; set; }

        /// <summary>
        /// 上层循环节点id
        /// </summary>
        [JsonProperty("loop_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoopNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 输入参数：debug才设置
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Inputs { get; set; }

        /// <summary>
        /// 输出参数：debug才设置
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Outputs { get; set; }

        /// <summary>
        /// 消息节点或提问器节点的输出
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// 节点特有的输出，如：大模型原始回复debug才设置
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// 开始时间，13位时间戳 workflow_started,node_started必填
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间，13位时间戳 workflow_finished,node_finished必填
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 真正启动的时间，13位时间戳
        /// </summary>
        [JsonProperty("startup_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartupTime { get; set; }

        /// <summary>
        /// 预热时间，如大模型节点表示首token时间
        /// </summary>
        [JsonProperty("prefill_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrefillTime { get; set; }

        /// <summary>
        /// execution id
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inner_error", NullValueHandling = NullValueHandling.Ignore)]
        public NodeRunInfoInnerError InnerError { get; set; }

        /// <summary>
        /// 记忆变量
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Memory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeRunInfo {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  parentNodeId: ").Append(ParentNodeId).Append("\n");
            sb.Append("  nodeStatus: ").Append(NodeStatus).Append("\n");
            sb.Append("  parentWorkflowId: ").Append(ParentWorkflowId).Append("\n");
            sb.Append("  loopIndex: ").Append(LoopIndex).Append("\n");
            sb.Append("  loopNodeId: ").Append(LoopNodeId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startupTime: ").Append(StartupTime).Append("\n");
            sb.Append("  prefillTime: ").Append(PrefillTime).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  innerError: ").Append(InnerError).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeRunInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeRunInfo input)
        {
            if (input == null) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.ParentNodeId != input.ParentNodeId || (this.ParentNodeId != null && !this.ParentNodeId.Equals(input.ParentNodeId))) return false;
            if (this.NodeStatus != input.NodeStatus) return false;
            if (this.ParentWorkflowId != input.ParentWorkflowId || (this.ParentWorkflowId != null && !this.ParentWorkflowId.Equals(input.ParentWorkflowId))) return false;
            if (this.LoopIndex != input.LoopIndex || (this.LoopIndex != null && !this.LoopIndex.Equals(input.LoopIndex))) return false;
            if (this.LoopNodeId != input.LoopNodeId || (this.LoopNodeId != null && !this.LoopNodeId.Equals(input.LoopNodeId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.Messages != input.Messages || (this.Messages != null && input.Messages != null && !this.Messages.SequenceEqual(input.Messages))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StartupTime != input.StartupTime || (this.StartupTime != null && !this.StartupTime.Equals(input.StartupTime))) return false;
            if (this.PrefillTime != input.PrefillTime || (this.PrefillTime != null && !this.PrefillTime.Equals(input.PrefillTime))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.InnerError != input.InnerError || (this.InnerError != null && !this.InnerError.Equals(input.InnerError))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && input.Memory != null && !this.Memory.SequenceEqual(input.Memory))) return false;

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
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ParentNodeId != null) hashCode = hashCode * 59 + this.ParentNodeId.GetHashCode();
                hashCode = hashCode * 59 + this.NodeStatus.GetHashCode();
                if (this.ParentWorkflowId != null) hashCode = hashCode * 59 + this.ParentWorkflowId.GetHashCode();
                if (this.LoopIndex != null) hashCode = hashCode * 59 + this.LoopIndex.GetHashCode();
                if (this.LoopNodeId != null) hashCode = hashCode * 59 + this.LoopNodeId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Messages != null) hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartupTime != null) hashCode = hashCode * 59 + this.StartupTime.GetHashCode();
                if (this.PrefillTime != null) hashCode = hashCode * 59 + this.PrefillTime.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.InnerError != null) hashCode = hashCode * 59 + this.InnerError.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                return hashCode;
            }
        }
    }
}
