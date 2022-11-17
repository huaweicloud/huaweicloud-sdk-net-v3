using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数流节点执行详细信息
    /// </summary>
    public class NodeExecutionDetail 
    {

        /// <summary>
        /// 流程节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 流程节点名称
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 流程节点执行ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 节点执行记录
        /// </summary>
        [JsonProperty("executions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeExecution> Executions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeExecutionDetail {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  executions: ").Append(Executions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeExecutionDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeExecutionDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Executions == input.Executions ||
                    this.Executions != null &&
                    input.Executions != null &&
                    this.Executions.SequenceEqual(input.Executions)
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Executions != null)
                    hashCode = hashCode * 59 + this.Executions.GetHashCode();
                return hashCode;
            }
        }
    }
}
