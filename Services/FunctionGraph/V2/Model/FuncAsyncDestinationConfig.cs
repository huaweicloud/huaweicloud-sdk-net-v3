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
    /// 函数异步调用目标参数配置。
    /// </summary>
    public class FuncAsyncDestinationConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("on_success", NullValueHandling = NullValueHandling.Ignore)]
        public FuncDestinationConfig OnSuccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("on_failure", NullValueHandling = NullValueHandling.Ignore)]
        public FuncDestinationConfig OnFailure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuncAsyncDestinationConfig {\n");
            sb.Append("  onSuccess: ").Append(OnSuccess).Append("\n");
            sb.Append("  onFailure: ").Append(OnFailure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuncAsyncDestinationConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuncAsyncDestinationConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnSuccess == input.OnSuccess ||
                    (this.OnSuccess != null &&
                    this.OnSuccess.Equals(input.OnSuccess))
                ) && 
                (
                    this.OnFailure == input.OnFailure ||
                    (this.OnFailure != null &&
                    this.OnFailure.Equals(input.OnFailure))
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
                if (this.OnSuccess != null)
                    hashCode = hashCode * 59 + this.OnSuccess.GetHashCode();
                if (this.OnFailure != null)
                    hashCode = hashCode * 59 + this.OnFailure.GetHashCode();
                return hashCode;
            }
        }
    }
}
