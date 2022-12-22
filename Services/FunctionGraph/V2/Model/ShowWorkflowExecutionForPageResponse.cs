using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWorkflowExecutionForPageResponse : SdkResponse
    {

        /// <summary>
        /// 返回所有满足条件的对象个数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// 返回对象的大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 函数流返回体信息
        /// </summary>
        [JsonProperty("executions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowExecutionBriefV2> Executions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkflowExecutionForPageResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  executions: ").Append(Executions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkflowExecutionForPageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkflowExecutionForPageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Executions == input.Executions ||
                    this.Executions != null &&
                    input.Executions != null &&
                    this.Executions.SequenceEqual(input.Executions)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Executions != null)
                    hashCode = hashCode * 59 + this.Executions.GetHashCode();
                return hashCode;
            }
        }
    }
}
