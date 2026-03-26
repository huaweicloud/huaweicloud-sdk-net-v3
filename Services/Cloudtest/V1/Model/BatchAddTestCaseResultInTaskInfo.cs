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
    public class BatchAddTestCaseResultInTaskInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public AddTestCaseResultInfo Result { get; set; }

        /// <summary>
        /// 任务uri
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 测试套结果URI
        /// </summary>
        [JsonProperty("task_result_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskResultUri { get; set; }

        /// <summary>
        /// 用例uri
        /// </summary>
        [JsonProperty("test_case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseUris { get; set; }

        /// <summary>
        /// 是否异步执行
        /// </summary>
        [JsonProperty("isAsyn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsyn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAddTestCaseResultInTaskInfo {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  taskResultUri: ").Append(TaskResultUri).Append("\n");
            sb.Append("  testCaseUris: ").Append(TestCaseUris).Append("\n");
            sb.Append("  isAsyn: ").Append(IsAsyn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAddTestCaseResultInTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAddTestCaseResultInTaskInfo input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.TaskResultUri != input.TaskResultUri || (this.TaskResultUri != null && !this.TaskResultUri.Equals(input.TaskResultUri))) return false;
            if (this.TestCaseUris != input.TestCaseUris || (this.TestCaseUris != null && !this.TestCaseUris.Equals(input.TestCaseUris))) return false;
            if (this.IsAsyn != input.IsAsyn || (this.IsAsyn != null && !this.IsAsyn.Equals(input.IsAsyn))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.TaskResultUri != null) hashCode = hashCode * 59 + this.TaskResultUri.GetHashCode();
                if (this.TestCaseUris != null) hashCode = hashCode * 59 + this.TestCaseUris.GetHashCode();
                if (this.IsAsyn != null) hashCode = hashCode * 59 + this.IsAsyn.GetHashCode();
                return hashCode;
            }
        }
    }
}
