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
    /// 错误处理策略详情
    /// </summary>
    public class OnError 
    {

        /// <summary>
        /// 错误匹配表达式，用来过滤需要处理的异常
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// 下一步骤节点ID
        /// </summary>
        [JsonProperty("transition", NullValueHandling = NullValueHandling.Ignore)]
        public string Transition { get; set; }

        /// <summary>
        /// 重试策略名称
        /// </summary>
        [JsonProperty("retry_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryRef { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnError {\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  transition: ").Append(Transition).Append("\n");
            sb.Append("  retryRef: ").Append(RetryRef).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnError);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Transition == input.Transition ||
                    (this.Transition != null &&
                    this.Transition.Equals(input.Transition))
                ) && 
                (
                    this.RetryRef == input.RetryRef ||
                    (this.RetryRef != null &&
                    this.RetryRef.Equals(input.RetryRef))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Transition != null)
                    hashCode = hashCode * 59 + this.Transition.GetHashCode();
                if (this.RetryRef != null)
                    hashCode = hashCode * 59 + this.RetryRef.GetHashCode();
                return hashCode;
            }
        }
    }
}
