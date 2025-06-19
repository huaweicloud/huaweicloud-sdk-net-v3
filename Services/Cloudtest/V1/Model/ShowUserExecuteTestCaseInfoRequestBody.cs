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
    /// 查询时段内用例的执行情况请求体
    /// </summary>
    public class ShowUserExecuteTestCaseInfoRequestBody 
    {

        /// <summary>
        /// 起始偏移量，表示从此偏移量开始查询，offset大于等于0，小于等于20000
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量,最大支持100条
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用例执行时间段开始
        /// </summary>
        [JsonProperty("execute_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteStartTime { get; set; }

        /// <summary>
        /// 用例执行时间段截止
        /// </summary>
        [JsonProperty("execute_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserExecuteTestCaseInfoRequestBody {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  executeStartTime: ").Append(ExecuteStartTime).Append("\n");
            sb.Append("  executeEndTime: ").Append(ExecuteEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserExecuteTestCaseInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserExecuteTestCaseInfoRequestBody input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ExecuteStartTime != input.ExecuteStartTime || (this.ExecuteStartTime != null && !this.ExecuteStartTime.Equals(input.ExecuteStartTime))) return false;
            if (this.ExecuteEndTime != input.ExecuteEndTime || (this.ExecuteEndTime != null && !this.ExecuteEndTime.Equals(input.ExecuteEndTime))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ExecuteStartTime != null) hashCode = hashCode * 59 + this.ExecuteStartTime.GetHashCode();
                if (this.ExecuteEndTime != null) hashCode = hashCode * 59 + this.ExecuteEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
