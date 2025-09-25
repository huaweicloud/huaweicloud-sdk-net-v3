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
    /// 步骤运行信息
    /// </summary>
    public class StepRun 
    {

        /// <summary>
        /// **参数解释**： 步骤名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 步骤插件名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public string Task { get; set; }

        /// <summary>
        /// **参数解释**： 插件业务类型。 **取值范围**： - Normal：通用。 - Build：构建。 - Test：测试。 - Check：代码检查。 - Deploy：部署。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 输入参数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepRunInputs> Inputs { get; set; }

        /// <summary>
        /// **参数解释**： 序列号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释**： 官方插件版本号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("official_task_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialTaskVersion { get; set; }

        /// <summary>
        /// **参数解释**： 唯一标识符。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释**： 是否可编辑。 **取值范围**： - true：可编辑。 - false：不可编辑。 
        /// </summary>
        [JsonProperty("multi_step_editable", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultiStepEditable { get; set; }

        /// <summary>
        /// **参数解释**： 步骤ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 扩展点ID列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("endpoint_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EndpointIds { get; set; }

        /// <summary>
        /// **参数解释**： 上次下发任务ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("last_dispatch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDispatchId { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： - RUNNING：运行中。 - CANCELED：取消。 - COMPLETED：已完成。 - FAILED：失败。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 错误消息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释**： 步骤开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 步骤结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepRun {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  officialTaskVersion: ").Append(OfficialTaskVersion).Append("\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  multiStepEditable: ").Append(MultiStepEditable).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  endpointIds: ").Append(EndpointIds).Append("\n");
            sb.Append("  lastDispatchId: ").Append(LastDispatchId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepRun);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepRun input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Task != input.Task || (this.Task != null && !this.Task.Equals(input.Task))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.OfficialTaskVersion != input.OfficialTaskVersion || (this.OfficialTaskVersion != null && !this.OfficialTaskVersion.Equals(input.OfficialTaskVersion))) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.MultiStepEditable != input.MultiStepEditable || (this.MultiStepEditable != null && !this.MultiStepEditable.Equals(input.MultiStepEditable))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.EndpointIds != input.EndpointIds || (this.EndpointIds != null && input.EndpointIds != null && !this.EndpointIds.SequenceEqual(input.EndpointIds))) return false;
            if (this.LastDispatchId != input.LastDispatchId || (this.LastDispatchId != null && !this.LastDispatchId.Equals(input.LastDispatchId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.OfficialTaskVersion != null) hashCode = hashCode * 59 + this.OfficialTaskVersion.GetHashCode();
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.MultiStepEditable != null) hashCode = hashCode * 59 + this.MultiStepEditable.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EndpointIds != null) hashCode = hashCode * 59 + this.EndpointIds.GetHashCode();
                if (this.LastDispatchId != null) hashCode = hashCode * 59 + this.LastDispatchId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
