using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 变更服务工作流工作流元数据。
    /// </summary>
    public class Workflow 
    {

        /// <summary>
        /// 工作流id，唯一标识，根据project_id和workflow_name生成。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 工作流名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 工作流类型，可以为cron、manual
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 工作流描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 标签键和值列表，标签键值对数量范围是0至20。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 工作流创建时间，为utc时间毫秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 工作流创人，从接口调用传入的token中获取。
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 工作流更新时间，为utc时间毫秒数。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 工作流更新人，从接口调用传入的token中获取。
        /// </summary>
        [JsonProperty("update_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 任务执行时需要的参数列表。
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Input { get; set; }

        /// <summary>
        /// 最近一次执行id，也是工作流id
        /// </summary>
        [JsonProperty("last_execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecutionId { get; set; }

        /// <summary>
        /// 任务状态，包含success，fail,executing
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 工作流的引用。
        /// </summary>
        [JsonProperty("citation_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CitationUrns { get; set; }

        /// <summary>
        /// 最近一次执行结束时间，为utc时间毫秒数
        /// </summary>
        [JsonProperty("last_execution_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastExecutionEndTime { get; set; }

        /// <summary>
        /// 最近一次执行开始时间，为utc时间毫秒数
        /// </summary>
        [JsonProperty("last_execution_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastExecutionStartTime { get; set; }

        /// <summary>
        /// 引用，参数引用
        /// </summary>
        [JsonProperty("quote", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Quote { get; set; }

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 服务场景分类
        /// </summary>
        [JsonProperty("service_scenario", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceScenario { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// functiongraph返回的PROJECT_ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// functiongraph返回的WORKFLOW_ID
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务节点
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Node> Nodes { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        [JsonProperty("edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EditTime { get; set; }

        /// <summary>
        /// 执行动作细粒度权限
        /// </summary>
        [JsonProperty("execution_action_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExecutionActionRules { get; set; }

        /// <summary>
        /// 云服务权限
        /// </summary>
        [JsonProperty("execution_permission", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExecutionPermission { get; set; }

        /// <summary>
        /// 全局参数
        /// </summary>
        [JsonProperty("global_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> GlobalParameters { get; set; }

        /// <summary>
        /// 逻辑删除
        /// </summary>
        [JsonProperty("is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelete { get; set; }

        /// <summary>
        /// 任务步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Step> Steps { get; set; }

        /// <summary>
        /// 任务输出
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        /// <summary>
        /// 触发器id
        /// </summary>
        [JsonProperty("trigger_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// 触发器状态
        /// </summary>
        [JsonProperty("trigger_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerStatus { get; set; }

        /// <summary>
        /// 审批id
        /// </summary>
        [JsonProperty("approve_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApproveId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template_i18n", NullValueHandling = NullValueHandling.Ignore)]
        public WorkFlowModel TemplateI18n { get; set; }

        /// <summary>
        /// 任务所属的企业项目
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 任务最后一次执行人
        /// </summary>
        [JsonProperty("last_execute_by", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecuteBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workflow {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateBy: ").Append(UpdateBy).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  lastExecutionId: ").Append(LastExecutionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  citationUrns: ").Append(CitationUrns).Append("\n");
            sb.Append("  lastExecutionEndTime: ").Append(LastExecutionEndTime).Append("\n");
            sb.Append("  lastExecutionStartTime: ").Append(LastExecutionStartTime).Append("\n");
            sb.Append("  quote: ").Append(Quote).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  serviceScenario: ").Append(ServiceScenario).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  editTime: ").Append(EditTime).Append("\n");
            sb.Append("  executionActionRules: ").Append(ExecutionActionRules).Append("\n");
            sb.Append("  executionPermission: ").Append(ExecutionPermission).Append("\n");
            sb.Append("  globalParameters: ").Append(GlobalParameters).Append("\n");
            sb.Append("  isDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  triggerId: ").Append(TriggerId).Append("\n");
            sb.Append("  triggerStatus: ").Append(TriggerStatus).Append("\n");
            sb.Append("  approveId: ").Append(ApproveId).Append("\n");
            sb.Append("  templateI18n: ").Append(TemplateI18n).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  lastExecuteBy: ").Append(LastExecuteBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Workflow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Workflow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.CreateBy == input.CreateBy ||
                    (this.CreateBy != null &&
                    this.CreateBy.Equals(input.CreateBy))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.UpdateBy == input.UpdateBy ||
                    (this.UpdateBy != null &&
                    this.UpdateBy.Equals(input.UpdateBy))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    input.Input != null &&
                    this.Input.SequenceEqual(input.Input)
                ) && 
                (
                    this.LastExecutionId == input.LastExecutionId ||
                    (this.LastExecutionId != null &&
                    this.LastExecutionId.Equals(input.LastExecutionId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CitationUrns == input.CitationUrns ||
                    this.CitationUrns != null &&
                    input.CitationUrns != null &&
                    this.CitationUrns.SequenceEqual(input.CitationUrns)
                ) && 
                (
                    this.LastExecutionEndTime == input.LastExecutionEndTime ||
                    (this.LastExecutionEndTime != null &&
                    this.LastExecutionEndTime.Equals(input.LastExecutionEndTime))
                ) && 
                (
                    this.LastExecutionStartTime == input.LastExecutionStartTime ||
                    (this.LastExecutionStartTime != null &&
                    this.LastExecutionStartTime.Equals(input.LastExecutionStartTime))
                ) && 
                (
                    this.Quote == input.Quote ||
                    this.Quote != null &&
                    input.Quote != null &&
                    this.Quote.SequenceEqual(input.Quote)
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ServiceScenario == input.ServiceScenario ||
                    (this.ServiceScenario != null &&
                    this.ServiceScenario.Equals(input.ServiceScenario))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.TaskStatus == input.TaskStatus ||
                    (this.TaskStatus != null &&
                    this.TaskStatus.Equals(input.TaskStatus))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.EditTime == input.EditTime ||
                    (this.EditTime != null &&
                    this.EditTime.Equals(input.EditTime))
                ) && 
                (
                    this.ExecutionActionRules == input.ExecutionActionRules ||
                    this.ExecutionActionRules != null &&
                    input.ExecutionActionRules != null &&
                    this.ExecutionActionRules.SequenceEqual(input.ExecutionActionRules)
                ) && 
                (
                    this.ExecutionPermission == input.ExecutionPermission ||
                    this.ExecutionPermission != null &&
                    input.ExecutionPermission != null &&
                    this.ExecutionPermission.SequenceEqual(input.ExecutionPermission)
                ) && 
                (
                    this.GlobalParameters == input.GlobalParameters ||
                    this.GlobalParameters != null &&
                    input.GlobalParameters != null &&
                    this.GlobalParameters.SequenceEqual(input.GlobalParameters)
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    (this.IsDelete != null &&
                    this.IsDelete.Equals(input.IsDelete))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.TriggerId == input.TriggerId ||
                    (this.TriggerId != null &&
                    this.TriggerId.Equals(input.TriggerId))
                ) && 
                (
                    this.TriggerStatus == input.TriggerStatus ||
                    (this.TriggerStatus != null &&
                    this.TriggerStatus.Equals(input.TriggerStatus))
                ) && 
                (
                    this.ApproveId == input.ApproveId ||
                    (this.ApproveId != null &&
                    this.ApproveId.Equals(input.ApproveId))
                ) && 
                (
                    this.TemplateI18n == input.TemplateI18n ||
                    (this.TemplateI18n != null &&
                    this.TemplateI18n.Equals(input.TemplateI18n))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.LastExecuteBy == input.LastExecuteBy ||
                    (this.LastExecuteBy != null &&
                    this.LastExecuteBy.Equals(input.LastExecuteBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateBy != null)
                    hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateBy != null)
                    hashCode = hashCode * 59 + this.UpdateBy.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.LastExecutionId != null)
                    hashCode = hashCode * 59 + this.LastExecutionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CitationUrns != null)
                    hashCode = hashCode * 59 + this.CitationUrns.GetHashCode();
                if (this.LastExecutionEndTime != null)
                    hashCode = hashCode * 59 + this.LastExecutionEndTime.GetHashCode();
                if (this.LastExecutionStartTime != null)
                    hashCode = hashCode * 59 + this.LastExecutionStartTime.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ServiceScenario != null)
                    hashCode = hashCode * 59 + this.ServiceScenario.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.TaskStatus != null)
                    hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.EditTime != null)
                    hashCode = hashCode * 59 + this.EditTime.GetHashCode();
                if (this.ExecutionActionRules != null)
                    hashCode = hashCode * 59 + this.ExecutionActionRules.GetHashCode();
                if (this.ExecutionPermission != null)
                    hashCode = hashCode * 59 + this.ExecutionPermission.GetHashCode();
                if (this.GlobalParameters != null)
                    hashCode = hashCode * 59 + this.GlobalParameters.GetHashCode();
                if (this.IsDelete != null)
                    hashCode = hashCode * 59 + this.IsDelete.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.TriggerId != null)
                    hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
                if (this.TriggerStatus != null)
                    hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.ApproveId != null)
                    hashCode = hashCode * 59 + this.ApproveId.GetHashCode();
                if (this.TemplateI18n != null)
                    hashCode = hashCode * 59 + this.TemplateI18n.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.LastExecuteBy != null)
                    hashCode = hashCode * 59 + this.LastExecuteBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
