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
    public class TaskResultDetailVo 
    {

        /// <summary>
        /// 处理人名称
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 用例结果统计信息
        /// </summary>
        [JsonProperty("case_result_statics", NullValueHandling = NullValueHandling.Ignore)]
        public Object CaseResultStatics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_result", NullValueHandling = NullValueHandling.Ignore)]
        public TaskResultVo TaskResult { get; set; }

        /// <summary>
        /// 实际的数据类型：单个对象，集合 或 NULL
        /// </summary>
        [JsonProperty("test_result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskResultVo> TestResultList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskResultDetailVo {\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  caseResultStatics: ").Append(CaseResultStatics).Append("\n");
            sb.Append("  taskResult: ").Append(TaskResult).Append("\n");
            sb.Append("  testResultList: ").Append(TestResultList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskResultDetailVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskResultDetailVo input)
        {
            if (input == null) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.CaseResultStatics != input.CaseResultStatics || (this.CaseResultStatics != null && !this.CaseResultStatics.Equals(input.CaseResultStatics))) return false;
            if (this.TaskResult != input.TaskResult || (this.TaskResult != null && !this.TaskResult.Equals(input.TaskResult))) return false;
            if (this.TestResultList != input.TestResultList || (this.TestResultList != null && input.TestResultList != null && !this.TestResultList.SequenceEqual(input.TestResultList))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.CaseResultStatics != null) hashCode = hashCode * 59 + this.CaseResultStatics.GetHashCode();
                if (this.TaskResult != null) hashCode = hashCode * 59 + this.TaskResult.GetHashCode();
                if (this.TestResultList != null) hashCode = hashCode * 59 + this.TestResultList.GetHashCode();
                return hashCode;
            }
        }
    }
}
