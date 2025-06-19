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
    /// 测试用例执行信息，数组长度小于等于50
    /// </summary>
    public class TestCaseExecuteBean 
    {

        /// <summary>
        /// 测试用例唯一标识，列表中不允许存在重复的id，固定长度32位字符
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }

        /// <summary>
        /// 注册服务执行id，该值不允许重复，不超过32位字符
        /// </summary>
        [JsonProperty("execute_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteId { get; set; }

        /// <summary>
        /// 测试用例结果，（0-成功，1-失败，5-执行中，6-停止）
        /// </summary>
        [JsonProperty("result_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultId { get; set; }

        /// <summary>
        /// 用例开始执行的时间戳，在执行开始时该字段必传
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseExecuteBean {\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  executeId: ").Append(ExecuteId).Append("\n");
            sb.Append("  resultId: ").Append(ResultId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseExecuteBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseExecuteBean input)
        {
            if (input == null) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.ExecuteId != input.ExecuteId || (this.ExecuteId != null && !this.ExecuteId.Equals(input.ExecuteId))) return false;
            if (this.ResultId != input.ResultId || (this.ResultId != null && !this.ResultId.Equals(input.ResultId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;

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
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                if (this.ExecuteId != null) hashCode = hashCode * 59 + this.ExecuteId.GetHashCode();
                if (this.ResultId != null) hashCode = hashCode * 59 + this.ResultId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
