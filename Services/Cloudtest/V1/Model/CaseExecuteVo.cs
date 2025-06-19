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
    /// 需求关联用例执行率情况
    /// </summary>
    public class CaseExecuteVo 
    {

        /// <summary>
        /// 需求关联用例执行率
        /// </summary>
        [JsonProperty("execute_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteRate { get; set; }

        /// <summary>
        /// 需求关联已执行用例总数
        /// </summary>
        [JsonProperty("executed_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutedNumber { get; set; }

        /// <summary>
        /// 需求关联未执行用例总数
        /// </summary>
        [JsonProperty("not_executed_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotExecutedNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseExecuteVo {\n");
            sb.Append("  executeRate: ").Append(ExecuteRate).Append("\n");
            sb.Append("  executedNumber: ").Append(ExecutedNumber).Append("\n");
            sb.Append("  notExecutedNumber: ").Append(NotExecutedNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseExecuteVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseExecuteVo input)
        {
            if (input == null) return false;
            if (this.ExecuteRate != input.ExecuteRate || (this.ExecuteRate != null && !this.ExecuteRate.Equals(input.ExecuteRate))) return false;
            if (this.ExecutedNumber != input.ExecutedNumber || (this.ExecutedNumber != null && !this.ExecutedNumber.Equals(input.ExecutedNumber))) return false;
            if (this.NotExecutedNumber != input.NotExecutedNumber || (this.NotExecutedNumber != null && !this.NotExecutedNumber.Equals(input.NotExecutedNumber))) return false;

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
                if (this.ExecuteRate != null) hashCode = hashCode * 59 + this.ExecuteRate.GetHashCode();
                if (this.ExecutedNumber != null) hashCode = hashCode * 59 + this.ExecutedNumber.GetHashCode();
                if (this.NotExecutedNumber != null) hashCode = hashCode * 59 + this.NotExecutedNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
