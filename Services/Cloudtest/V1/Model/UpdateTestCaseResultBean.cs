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
    /// 测试用例状态信息，数组长度小于等于50
    /// </summary>
    public class UpdateTestCaseResultBean 
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
        /// 用例结束执行的时间戳，在执行结束时该字段必传
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 执行用例持续时长ms，更新状态时改字段必传
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// 用于记录该次结果执行的备注信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestCaseResultBean {\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  executeId: ").Append(ExecuteId).Append("\n");
            sb.Append("  resultId: ").Append(ResultId).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestCaseResultBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestCaseResultBean input)
        {
            if (input == null) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.ExecuteId != input.ExecuteId || (this.ExecuteId != null && !this.ExecuteId.Equals(input.ExecuteId))) return false;
            if (this.ResultId != input.ResultId || (this.ResultId != null && !this.ResultId.Equals(input.ResultId))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
