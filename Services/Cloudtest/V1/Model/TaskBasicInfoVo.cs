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
    /// 
    /// </summary>
    public class TaskBasicInfoVo 
    {

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("error_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("task_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskState { get; set; }

        /// <summary>
        /// 测试套类型
        /// </summary>
        [JsonProperty("test_suite_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestSuiteType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskBasicInfoVo {\n");
            sb.Append("  errorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  taskState: ").Append(TaskState).Append("\n");
            sb.Append("  testSuiteType: ").Append(TestSuiteType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskBasicInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskBasicInfoVo input)
        {
            if (input == null) return false;
            if (this.ErrorReason != input.ErrorReason || (this.ErrorReason != null && !this.ErrorReason.Equals(input.ErrorReason))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TaskState != input.TaskState || (this.TaskState != null && !this.TaskState.Equals(input.TaskState))) return false;
            if (this.TestSuiteType != input.TestSuiteType || (this.TestSuiteType != null && !this.TestSuiteType.Equals(input.TestSuiteType))) return false;

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
                if (this.ErrorReason != null) hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TaskState != null) hashCode = hashCode * 59 + this.TaskState.GetHashCode();
                if (this.TestSuiteType != null) hashCode = hashCode * 59 + this.TestSuiteType.GetHashCode();
                return hashCode;
            }
        }
    }
}
