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
    /// 阶段运行信息
    /// </summary>
    public class StageRun 
    {

        /// <summary>
        /// **参数解释**： 阶段ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 阶段类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 阶段名称。 **取值范围**： 仅支持输入中文、大小写英文字母、数字、&#39;-&#39;、&#39;_&#39;、&#39;,&#39;、&#39;;&#39;、&#39;:&#39;、&#39;.&#39;、&#39;/&#39;、&#39;(&#39;、&#39;)&#39;、&#39;（&#39;、&#39;）&#39;及空格，其中空格不可在名称开头或结尾使用，且长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 阶段唯一标识。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释**： 是否总是运行。 **取值范围**： - true：总是运行。 - false：非总是运行。 
        /// </summary>
        [JsonProperty("run_always", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunAlways { get; set; }

        /// <summary>
        /// **参数解释**： 是否并行。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("parallel", NullValueHandling = NullValueHandling.Ignore)]
        public string Parallel { get; set; }

        /// <summary>
        /// **参数解释**： 是否选中。 **取值范围**： - true：选中。 - false：未选中。 
        /// </summary>
        [JsonProperty("is_select", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelect { get; set; }

        /// <summary>
        /// **参数解释**： 序列号。 **取值范围**： 大于等于0。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释**： 依赖阶段的identifier信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("depends_on", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependsOn { get; set; }

        /// <summary>
        /// **参数解释**： 运行条件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： - INIT：初始化。 - QUEUED：排队。 - RUNNING：运行中。 - CANCELED：取消。 - COMPLETED：已完成。 - FAILED：失败。 - SKIPPED：跳过。 - IGNORED：忽略。 - PAUSED：暂停。 - SUSPEND：挂起。 - ASYNC_RUNNING：异步运行。 - ASYNC_FAILED：异步失败。 - UNSELECTED：未选择。 - REDISPATCH：重新调度。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 阶段开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 阶段结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 阶段准入。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pre", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepRun> Pre { get; set; }

        /// <summary>
        /// **参数解释**： 阶段准出。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("post", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepRun> Post { get; set; }

        /// <summary>
        /// **参数解释**： 任务列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobRun> Jobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageRun {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  runAlways: ").Append(RunAlways).Append("\n");
            sb.Append("  parallel: ").Append(Parallel).Append("\n");
            sb.Append("  isSelect: ").Append(IsSelect).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  dependsOn: ").Append(DependsOn).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  pre: ").Append(Pre).Append("\n");
            sb.Append("  post: ").Append(Post).Append("\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StageRun);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StageRun input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.RunAlways != input.RunAlways || (this.RunAlways != null && !this.RunAlways.Equals(input.RunAlways))) return false;
            if (this.Parallel != input.Parallel || (this.Parallel != null && !this.Parallel.Equals(input.Parallel))) return false;
            if (this.IsSelect != input.IsSelect || (this.IsSelect != null && !this.IsSelect.Equals(input.IsSelect))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.DependsOn != input.DependsOn || (this.DependsOn != null && input.DependsOn != null && !this.DependsOn.SequenceEqual(input.DependsOn))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Pre != input.Pre || (this.Pre != null && input.Pre != null && !this.Pre.SequenceEqual(input.Pre))) return false;
            if (this.Post != input.Post || (this.Post != null && input.Post != null && !this.Post.SequenceEqual(input.Post))) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.RunAlways != null) hashCode = hashCode * 59 + this.RunAlways.GetHashCode();
                if (this.Parallel != null) hashCode = hashCode * 59 + this.Parallel.GetHashCode();
                if (this.IsSelect != null) hashCode = hashCode * 59 + this.IsSelect.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.DependsOn != null) hashCode = hashCode * 59 + this.DependsOn.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Pre != null) hashCode = hashCode * 59 + this.Pre.GetHashCode();
                if (this.Post != null) hashCode = hashCode * 59 + this.Post.GetHashCode();
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
