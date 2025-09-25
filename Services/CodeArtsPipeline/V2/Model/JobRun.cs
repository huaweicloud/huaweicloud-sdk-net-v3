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
    /// 任务运行信息
    /// </summary>
    public class JobRun 
    {

        /// <summary>
        /// **参数解释**： 任务ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 任务类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 序列号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释**： 是否异步。 **取值范围**： - true：异步。 - false：非异步。 
        /// </summary>
        [JsonProperty("async", NullValueHandling = NullValueHandling.Ignore)]
        public string Async { get; set; }

        /// <summary>
        /// **参数解释**： 任务名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 任务唯一标识。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释**： 依赖。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("depends_on", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependsOn { get; set; }

        /// <summary>
        /// **参数解释**： 运行条件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// **参数解释**： 执行资源。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数解释**： 是否选中。 **取值范围**： - true：选中。 - false：未选中。 
        /// </summary>
        [JsonProperty("is_select", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelect { get; set; }

        /// <summary>
        /// **参数解释**： 任务超时设置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        /// <summary>
        /// **参数解释**： 任务上次下发ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("last_dispatch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDispatchId { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： - INIT：初始化。 - QUEUED：排队。 - RUNNING：运行中。 - CANCELED：取消。 - COMPLETED：已完成。 - FAILED：失败。 - SKIPPED：跳过。 - IGNORED：忽略。 - PAUSED：暂停。 - SUSPEND：挂起。 - ASYNC_RUNNING：异步运行。 - ASYNC_FAILED：异步失败。 - UNSELECTED：未选择。 - REDISPATCH：重新调度。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 错误信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释**： 任务开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 任务结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 步骤。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepRun> Steps { get; set; }

        /// <summary>
        /// **参数解释**： 任务执行ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("exec_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobRun {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  async: ").Append(Async).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  dependsOn: ").Append(DependsOn).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  isSelect: ").Append(IsSelect).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  lastDispatchId: ").Append(LastDispatchId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  execId: ").Append(ExecId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobRun);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobRun input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Async != input.Async || (this.Async != null && !this.Async.Equals(input.Async))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.DependsOn != input.DependsOn || (this.DependsOn != null && input.DependsOn != null && !this.DependsOn.SequenceEqual(input.DependsOn))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.IsSelect != input.IsSelect || (this.IsSelect != null && !this.IsSelect.Equals(input.IsSelect))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.LastDispatchId != input.LastDispatchId || (this.LastDispatchId != null && !this.LastDispatchId.Equals(input.LastDispatchId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.ExecId != input.ExecId || (this.ExecId != null && !this.ExecId.Equals(input.ExecId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Async != null) hashCode = hashCode * 59 + this.Async.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DependsOn != null) hashCode = hashCode * 59 + this.DependsOn.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.IsSelect != null) hashCode = hashCode * 59 + this.IsSelect.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.LastDispatchId != null) hashCode = hashCode * 59 + this.LastDispatchId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.ExecId != null) hashCode = hashCode * 59 + this.ExecId.GetHashCode();
                return hashCode;
            }
        }
    }
}
