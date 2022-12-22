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
    /// 函数流执行请求body体
    /// </summary>
    public class FlowExecuteBody 
    {

        /// <summary>
        /// 函数执行时需要的Header
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Object Headers { get; set; }

        /// <summary>
        /// 定义函数执行时的入参，支持使用JSONPATH进行映射，以及指定默认值
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public Object Input { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecuteBody {\n");
            sb.Append("  headers: ").Append(Headers).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowExecuteBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowExecuteBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
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
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                return hashCode;
            }
        }
    }
}
