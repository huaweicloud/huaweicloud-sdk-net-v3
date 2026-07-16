using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateWorkflowExecutionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：创建时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：执行记录名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：工作流执行ID。[获取方法请参见[获取Execution列表](ListWorkflowExecutions.xml)。](tag:hc)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// **参数解释**：执行记录描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：执行记录状态。 **取值范围**：枚举值如下： - init：初始化 - running：运行中 - completed：运行成功 - stopped：已停止 - abnormal：异常
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。获取方法请参见[查询工作空间列表](ListWorkspace.xml)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：Workflow工作流ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// **参数解释**：工作流名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workflow_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// **参数解释**：自定义场景ID，[获取方法请参见[查询工作流执行记录列表](CreateWorkflow.xml)](tag:hc)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("scene_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneId { get; set; }

        /// <summary>
        /// **参数解释**：自定义场景名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("scene_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneName { get; set; }

        /// <summary>
        /// **参数解释**：执行记录的step。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("steps_execution", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepExecutionResp> StepsExecution { get; set; }

        /// <summary>
        /// **参数解释**：子图。
        /// </summary>
        [JsonProperty("sub_graphs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowSubgraphResp> SubGraphs { get; set; }

        /// <summary>
        /// **参数解释**：执行的时长。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// **参数解释**：执行的事件。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Events { get; set; }

        /// <summary>
        /// **参数解释**：为执行记录设置的标签。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// **参数解释**：节点steps使用到的数据。
        /// </summary>
        [JsonProperty("data_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataRequirementResp> DataRequirements { get; set; }

        /// <summary>
        /// **参数解释**：节点steps使用到的参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowParameterResp> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowDagPoliciesResp Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWorkflowExecutionResponse {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  workflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  sceneId: ").Append(SceneId).Append("\n");
            sb.Append("  sceneName: ").Append(SceneName).Append("\n");
            sb.Append("  stepsExecution: ").Append(StepsExecution).Append("\n");
            sb.Append("  subGraphs: ").Append(SubGraphs).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  dataRequirements: ").Append(DataRequirements).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWorkflowExecutionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWorkflowExecutionResponse input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.WorkflowName != input.WorkflowName || (this.WorkflowName != null && !this.WorkflowName.Equals(input.WorkflowName))) return false;
            if (this.SceneId != input.SceneId || (this.SceneId != null && !this.SceneId.Equals(input.SceneId))) return false;
            if (this.SceneName != input.SceneName || (this.SceneName != null && !this.SceneName.Equals(input.SceneName))) return false;
            if (this.StepsExecution != input.StepsExecution || (this.StepsExecution != null && input.StepsExecution != null && !this.StepsExecution.SequenceEqual(input.StepsExecution))) return false;
            if (this.SubGraphs != input.SubGraphs || (this.SubGraphs != null && input.SubGraphs != null && !this.SubGraphs.SequenceEqual(input.SubGraphs))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.DataRequirements != input.DataRequirements || (this.DataRequirements != null && input.DataRequirements != null && !this.DataRequirements.SequenceEqual(input.DataRequirements))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && !this.Policies.Equals(input.Policies))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.WorkflowName != null) hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.SceneId != null) hashCode = hashCode * 59 + this.SceneId.GetHashCode();
                if (this.SceneName != null) hashCode = hashCode * 59 + this.SceneName.GetHashCode();
                if (this.StepsExecution != null) hashCode = hashCode * 59 + this.StepsExecution.GetHashCode();
                if (this.SubGraphs != null) hashCode = hashCode * 59 + this.SubGraphs.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.DataRequirements != null) hashCode = hashCode * 59 + this.DataRequirements.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
