using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 子任务参数
    /// </summary>
    public class TemplateState 
    {

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 任务名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板任务ID
        /// </summary>
        [JsonProperty("module_or_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleOrTemplateId { get; set; }

        /// <summary>
        /// 模板任务名字
        /// </summary>
        [JsonProperty("module_or_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleOrTemplateName { get; set; }

        /// <summary>
        /// 任务在流水线页面展示名字
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 流水线可挂载任务类型
        /// </summary>
        [JsonProperty("dsl_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DslMethod { get; set; }

        /// <summary>
        /// 任务参数，map类型数据
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Parameters { get; set; }

        /// <summary>
        /// 是否手动执行
        /// </summary>
        [JsonProperty("is_manual_execution", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsManualExecution { get; set; }

        /// <summary>
        /// 任务参数是否校验
        /// </summary>
        [JsonProperty("job_parameter_validate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? JobParameterValidate { get; set; }

        /// <summary>
        /// 是否显示代码仓URL
        /// </summary>
        [JsonProperty("is_show_codehub_url", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShowCodehubUrl { get; set; }

        /// <summary>
        /// 是否执行
        /// </summary>
        [JsonProperty("is_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExecute { get; set; }

        /// <summary>
        /// 执行任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 执行任务名字
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务所属项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 控制阶段下任务的串并行（type是task的execution_mode值为null，type是stage的execution_mode可选parallel（并行）或者serial（串行））
        /// </summary>
        [JsonProperty("execution_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateState {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  moduleOrTemplateId: ").Append(ModuleOrTemplateId).Append("\n");
            sb.Append("  moduleOrTemplateName: ").Append(ModuleOrTemplateName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  dslMethod: ").Append(DslMethod).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  isManualExecution: ").Append(IsManualExecution).Append("\n");
            sb.Append("  jobParameterValidate: ").Append(JobParameterValidate).Append("\n");
            sb.Append("  isShowCodehubUrl: ").Append(IsShowCodehubUrl).Append("\n");
            sb.Append("  isExecute: ").Append(IsExecute).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  executionMode: ").Append(ExecutionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateState input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ModuleOrTemplateId != input.ModuleOrTemplateId || (this.ModuleOrTemplateId != null && !this.ModuleOrTemplateId.Equals(input.ModuleOrTemplateId))) return false;
            if (this.ModuleOrTemplateName != input.ModuleOrTemplateName || (this.ModuleOrTemplateName != null && !this.ModuleOrTemplateName.Equals(input.ModuleOrTemplateName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.DslMethod != input.DslMethod || (this.DslMethod != null && !this.DslMethod.Equals(input.DslMethod))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.IsManualExecution != input.IsManualExecution || (this.IsManualExecution != null && !this.IsManualExecution.Equals(input.IsManualExecution))) return false;
            if (this.JobParameterValidate != input.JobParameterValidate || (this.JobParameterValidate != null && !this.JobParameterValidate.Equals(input.JobParameterValidate))) return false;
            if (this.IsShowCodehubUrl != input.IsShowCodehubUrl || (this.IsShowCodehubUrl != null && !this.IsShowCodehubUrl.Equals(input.IsShowCodehubUrl))) return false;
            if (this.IsExecute != input.IsExecute || (this.IsExecute != null && !this.IsExecute.Equals(input.IsExecute))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ExecutionMode != input.ExecutionMode || (this.ExecutionMode != null && !this.ExecutionMode.Equals(input.ExecutionMode))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ModuleOrTemplateId != null) hashCode = hashCode * 59 + this.ModuleOrTemplateId.GetHashCode();
                if (this.ModuleOrTemplateName != null) hashCode = hashCode * 59 + this.ModuleOrTemplateName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DslMethod != null) hashCode = hashCode * 59 + this.DslMethod.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.IsManualExecution != null) hashCode = hashCode * 59 + this.IsManualExecution.GetHashCode();
                if (this.JobParameterValidate != null) hashCode = hashCode * 59 + this.JobParameterValidate.GetHashCode();
                if (this.IsShowCodehubUrl != null) hashCode = hashCode * 59 + this.IsShowCodehubUrl.GetHashCode();
                if (this.IsExecute != null) hashCode = hashCode * 59 + this.IsExecute.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ExecutionMode != null) hashCode = hashCode * 59 + this.ExecutionMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
