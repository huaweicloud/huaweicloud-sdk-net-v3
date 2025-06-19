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
    /// 用例及任务信息
    /// </summary>
    public class RelateTaskTestCasesVo 
    {

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("test_case_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseNum { get; set; }

        /// <summary>
        /// 用例名
        /// </summary>
        [JsonProperty("test_case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 用例uri
        /// </summary>
        [JsonProperty("test_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseUri { get; set; }

        /// <summary>
        /// 任务uri
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonProperty("task_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskNum { get; set; }

        /// <summary>
        /// 任务创建人
        /// </summary>
        [JsonProperty("task_creator", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskCreator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelateTaskTestCasesVo {\n");
            sb.Append("  testCaseNum: ").Append(TestCaseNum).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  testCaseUri: ").Append(TestCaseUri).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskNum: ").Append(TaskNum).Append("\n");
            sb.Append("  taskCreator: ").Append(TaskCreator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelateTaskTestCasesVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelateTaskTestCasesVo input)
        {
            if (input == null) return false;
            if (this.TestCaseNum != input.TestCaseNum || (this.TestCaseNum != null && !this.TestCaseNum.Equals(input.TestCaseNum))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.TestCaseUri != input.TestCaseUri || (this.TestCaseUri != null && !this.TestCaseUri.Equals(input.TestCaseUri))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskNum != input.TaskNum || (this.TaskNum != null && !this.TaskNum.Equals(input.TaskNum))) return false;
            if (this.TaskCreator != input.TaskCreator || (this.TaskCreator != null && !this.TaskCreator.Equals(input.TaskCreator))) return false;

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
                if (this.TestCaseNum != null) hashCode = hashCode * 59 + this.TestCaseNum.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.TestCaseUri != null) hashCode = hashCode * 59 + this.TestCaseUri.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskNum != null) hashCode = hashCode * 59 + this.TaskNum.GetHashCode();
                if (this.TaskCreator != null) hashCode = hashCode * 59 + this.TaskCreator.GetHashCode();
                return hashCode;
            }
        }
    }
}
