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
    /// 工作流更新信息。
    /// </summary>
    public class WorkflowUpdate 
    {

        /// <summary>
        /// 工作流名称。填写1-64位，仅包含英文、数字、下划线（_）和中划线（-），并且以英文开头的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 工作流描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Workflow包含的数据输入项定义。
        /// </summary>
        [JsonProperty("data_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataRequirement> DataRequirements { get; set; }

        /// <summary>
        /// 工作流参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowParameter> Parameters { get; set; }

        /// <summary>
        /// 工作流存储信息。
        /// </summary>
        [JsonProperty("storages", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowStorage> Storages { get; set; }

        /// <summary>
        /// 工作流标签。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// SMN消息订阅开关。
        /// </summary>
        [JsonProperty("smn_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnSwitch { get; set; }

        /// <summary>
        /// 工作流节点。
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowStep> Steps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowUpdate {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dataRequirements: ").Append(DataRequirements).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  storages: ").Append(Storages).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  smnSwitch: ").Append(SmnSwitch).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowUpdate input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DataRequirements != input.DataRequirements || (this.DataRequirements != null && input.DataRequirements != null && !this.DataRequirements.SequenceEqual(input.DataRequirements))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Storages != input.Storages || (this.Storages != null && input.Storages != null && !this.Storages.SequenceEqual(input.Storages))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.SmnSwitch != input.SmnSwitch || (this.SmnSwitch != null && !this.SmnSwitch.Equals(input.SmnSwitch))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DataRequirements != null) hashCode = hashCode * 59 + this.DataRequirements.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Storages != null) hashCode = hashCode * 59 + this.Storages.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.SmnSwitch != null) hashCode = hashCode * 59 + this.SmnSwitch.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                return hashCode;
            }
        }
    }
}
