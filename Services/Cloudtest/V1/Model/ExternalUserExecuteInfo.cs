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
    /// 用户用例执行信息
    /// </summary>
    public class ExternalUserExecuteInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Executor { get; set; }

        /// <summary>
        /// 执行用例数
        /// </summary>
        [JsonProperty("execute_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalUserExecuteInfo {\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  executeCount: ").Append(ExecuteCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalUserExecuteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalUserExecuteInfo input)
        {
            if (input == null) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;
            if (this.ExecuteCount != input.ExecuteCount || (this.ExecuteCount != null && !this.ExecuteCount.Equals(input.ExecuteCount))) return false;

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
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.ExecuteCount != null) hashCode = hashCode * 59 + this.ExecuteCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
