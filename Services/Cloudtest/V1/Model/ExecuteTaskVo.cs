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
    public class ExecuteTaskVo 
    {

        /// <summary>
        /// 标志
        /// </summary>
        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flag { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_result_vo", NullValueHandling = NullValueHandling.Ignore)]
        public TaskResultVo TaskResultVo { get; set; }

        /// <summary>
        /// 更新用例
        /// </summary>
        [JsonProperty("update_case_uri_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpdateCaseUriList { get; set; }

        /// <summary>
        /// 用例结果列表
        /// </summary>
        [JsonProperty("test_case_result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestResultVo> TestCaseResultList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteTaskVo {\n");
            sb.Append("  flag: ").Append(Flag).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  taskResultVo: ").Append(TaskResultVo).Append("\n");
            sb.Append("  updateCaseUriList: ").Append(UpdateCaseUriList).Append("\n");
            sb.Append("  testCaseResultList: ").Append(TestCaseResultList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteTaskVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteTaskVo input)
        {
            if (input == null) return false;
            if (this.Flag != input.Flag || (this.Flag != null && !this.Flag.Equals(input.Flag))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.TaskResultVo != input.TaskResultVo || (this.TaskResultVo != null && !this.TaskResultVo.Equals(input.TaskResultVo))) return false;
            if (this.UpdateCaseUriList != input.UpdateCaseUriList || (this.UpdateCaseUriList != null && input.UpdateCaseUriList != null && !this.UpdateCaseUriList.SequenceEqual(input.UpdateCaseUriList))) return false;
            if (this.TestCaseResultList != input.TestCaseResultList || (this.TestCaseResultList != null && input.TestCaseResultList != null && !this.TestCaseResultList.SequenceEqual(input.TestCaseResultList))) return false;

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
                if (this.Flag != null) hashCode = hashCode * 59 + this.Flag.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.TaskResultVo != null) hashCode = hashCode * 59 + this.TaskResultVo.GetHashCode();
                if (this.UpdateCaseUriList != null) hashCode = hashCode * 59 + this.UpdateCaseUriList.GetHashCode();
                if (this.TestCaseResultList != null) hashCode = hashCode * 59 + this.TestCaseResultList.GetHashCode();
                return hashCode;
            }
        }
    }
}
