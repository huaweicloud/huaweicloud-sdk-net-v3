using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStacksRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一ID，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 执行操作者的名字，将用做未来的审计工作。
        /// </summary>
        [SDKProperty("executor", IsQuery = true)]
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStacksRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStacksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStacksRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.Executor == input.Executor ||
                    (this.Executor != null &&
                    this.Executor.Equals(input.Executor))
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.Executor != null)
                    hashCode = hashCode * 59 + this.Executor.GetHashCode();
                return hashCode;
            }
        }
    }
}
