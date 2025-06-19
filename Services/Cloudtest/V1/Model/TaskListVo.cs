using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class TaskListVo 
    {

        /// <summary>
        /// 测试任务集合
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskVo> Tasks { get; set; }

        /// <summary>
        /// 正在执行任务数
        /// </summary>
        [JsonProperty("running_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskListVo {\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("  runningCount: ").Append(RunningCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskListVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskListVo input)
        {
            if (input == null) return false;
            if (this.Tasks != input.Tasks || (this.Tasks != null && input.Tasks != null && !this.Tasks.SequenceEqual(input.Tasks))) return false;
            if (this.RunningCount != input.RunningCount || (this.RunningCount != null && !this.RunningCount.Equals(input.RunningCount))) return false;

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
                if (this.Tasks != null) hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.RunningCount != null) hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
