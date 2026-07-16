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
    /// 
    /// </summary>
    public class Workflow 
    {

        /// <summary>
        /// Workflow工作流名称，1到64位只包含中英文、数字、空格、下划线（_）和中划线（-），并且以中英文开头。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Workflow工作流ID。创建工作流时后台自动生成。
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Workflow工作流的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Workflow工作流的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Workflow工作流包含的步骤定义。
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowStep> Steps { get; set; }

        /// <summary>
        /// 创建Workflow工作流的用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 工作空间ID。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Workflow需要的数据。
        /// </summary>
        [JsonProperty("data_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataRequirement> DataRequirements { get; set; }

        /// <summary>
        /// Workflow包含的数据。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> Data { get; set; }

        /// <summary>
        /// Workflow包含的参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowParameter> Parameters { get; set; }

        /// <summary>
        /// 从指定Workflow工作流进行复制。通过复制来创建Workflow时必填。
        /// </summary>
        [JsonProperty("source_workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceWorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gallery_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowGallerySubscription GallerySubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latest_execution", NullValueHandling = NullValueHandling.Ignore)]
        public ExecutionBrief LatestExecution { get; set; }

        /// <summary>
        /// 工作流的已运行次数。
        /// </summary>
        [JsonProperty("run_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunCount { get; set; }

        /// <summary>
        /// 当前工作流的必选参数是否都已填完。
        /// </summary>
        [JsonProperty("param_ready", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParamReady { get; set; }

        /// <summary>
        /// 工作流来源，可选值为ai_gallery，表示工作流是从AI Gallery导入的。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Workflow包含的统一存储定义。
        /// </summary>
        [JsonProperty("storages", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowStorage> Storages { get; set; }

        /// <summary>
        /// 为Workflow工作流设置的标签。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 工作流绑定的资产。
        /// </summary>
        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowAsset> Assets { get; set; }

        /// <summary>
        /// 工作流包含的子图。
        /// </summary>
        [JsonProperty("sub_graphs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowSubgraph> SubGraphs { get; set; }

        /// <summary>
        /// 计费工作流使用的拓展字段。
        /// </summary>
        [JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Extend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowPolicy Policy { get; set; }

        /// <summary>
        /// 工作流SMN消息订阅开关，默认为false，表示关闭消息订阅开关。
        /// </summary>
        [JsonProperty("with_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithSubscription { get; set; }

        /// <summary>
        /// SMN开关。
        /// </summary>
        [JsonProperty("smn_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnSwitch { get; set; }

        /// <summary>
        /// SMN消息订阅ID。
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 自动学习模板ID。
        /// </summary>
        [JsonProperty("exeml_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExemlTemplateId { get; set; }

        /// <summary>
        /// 最近一次修改的时间。
        /// </summary>
        [JsonProperty("last_modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowServicePackege Package { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workflow {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  dataRequirements: ").Append(DataRequirements).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  sourceWorkflowId: ").Append(SourceWorkflowId).Append("\n");
            sb.Append("  gallerySubscription: ").Append(GallerySubscription).Append("\n");
            sb.Append("  latestExecution: ").Append(LatestExecution).Append("\n");
            sb.Append("  runCount: ").Append(RunCount).Append("\n");
            sb.Append("  paramReady: ").Append(ParamReady).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  storages: ").Append(Storages).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  assets: ").Append(Assets).Append("\n");
            sb.Append("  subGraphs: ").Append(SubGraphs).Append("\n");
            sb.Append("  extend: ").Append(Extend).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  withSubscription: ").Append(WithSubscription).Append("\n");
            sb.Append("  smnSwitch: ").Append(SmnSwitch).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  exemlTemplateId: ").Append(ExemlTemplateId).Append("\n");
            sb.Append("  lastModifiedAt: ").Append(LastModifiedAt).Append("\n");
            sb.Append("  package: ").Append(Package).Append("\n");
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
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.DataRequirements != input.DataRequirements || (this.DataRequirements != null && input.DataRequirements != null && !this.DataRequirements.SequenceEqual(input.DataRequirements))) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.SourceWorkflowId != input.SourceWorkflowId || (this.SourceWorkflowId != null && !this.SourceWorkflowId.Equals(input.SourceWorkflowId))) return false;
            if (this.GallerySubscription != input.GallerySubscription || (this.GallerySubscription != null && !this.GallerySubscription.Equals(input.GallerySubscription))) return false;
            if (this.LatestExecution != input.LatestExecution || (this.LatestExecution != null && !this.LatestExecution.Equals(input.LatestExecution))) return false;
            if (this.RunCount != input.RunCount || (this.RunCount != null && !this.RunCount.Equals(input.RunCount))) return false;
            if (this.ParamReady != input.ParamReady || (this.ParamReady != null && !this.ParamReady.Equals(input.ParamReady))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Storages != input.Storages || (this.Storages != null && input.Storages != null && !this.Storages.SequenceEqual(input.Storages))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Assets != input.Assets || (this.Assets != null && input.Assets != null && !this.Assets.SequenceEqual(input.Assets))) return false;
            if (this.SubGraphs != input.SubGraphs || (this.SubGraphs != null && input.SubGraphs != null && !this.SubGraphs.SequenceEqual(input.SubGraphs))) return false;
            if (this.Extend != input.Extend || (this.Extend != null && input.Extend != null && !this.Extend.SequenceEqual(input.Extend))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.WithSubscription != input.WithSubscription || (this.WithSubscription != null && !this.WithSubscription.Equals(input.WithSubscription))) return false;
            if (this.SmnSwitch != input.SmnSwitch || (this.SmnSwitch != null && !this.SmnSwitch.Equals(input.SmnSwitch))) return false;
            if (this.SubscriptionId != input.SubscriptionId || (this.SubscriptionId != null && !this.SubscriptionId.Equals(input.SubscriptionId))) return false;
            if (this.ExemlTemplateId != input.ExemlTemplateId || (this.ExemlTemplateId != null && !this.ExemlTemplateId.Equals(input.ExemlTemplateId))) return false;
            if (this.LastModifiedAt != input.LastModifiedAt || (this.LastModifiedAt != null && !this.LastModifiedAt.Equals(input.LastModifiedAt))) return false;
            if (this.Package != input.Package || (this.Package != null && !this.Package.Equals(input.Package))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.DataRequirements != null) hashCode = hashCode * 59 + this.DataRequirements.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.SourceWorkflowId != null) hashCode = hashCode * 59 + this.SourceWorkflowId.GetHashCode();
                if (this.GallerySubscription != null) hashCode = hashCode * 59 + this.GallerySubscription.GetHashCode();
                if (this.LatestExecution != null) hashCode = hashCode * 59 + this.LatestExecution.GetHashCode();
                if (this.RunCount != null) hashCode = hashCode * 59 + this.RunCount.GetHashCode();
                if (this.ParamReady != null) hashCode = hashCode * 59 + this.ParamReady.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Storages != null) hashCode = hashCode * 59 + this.Storages.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Assets != null) hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.SubGraphs != null) hashCode = hashCode * 59 + this.SubGraphs.GetHashCode();
                if (this.Extend != null) hashCode = hashCode * 59 + this.Extend.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.WithSubscription != null) hashCode = hashCode * 59 + this.WithSubscription.GetHashCode();
                if (this.SmnSwitch != null) hashCode = hashCode * 59 + this.SmnSwitch.GetHashCode();
                if (this.SubscriptionId != null) hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.ExemlTemplateId != null) hashCode = hashCode * 59 + this.ExemlTemplateId.GetHashCode();
                if (this.LastModifiedAt != null) hashCode = hashCode * 59 + this.LastModifiedAt.GetHashCode();
                if (this.Package != null) hashCode = hashCode * 59 + this.Package.GetHashCode();
                return hashCode;
            }
        }
    }
}
