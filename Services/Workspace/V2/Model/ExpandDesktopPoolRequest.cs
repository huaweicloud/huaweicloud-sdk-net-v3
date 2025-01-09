using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ExpandDesktopPoolRequest 
    {

        /// <summary>
        /// CBC接口回调时，请求头里带上的业务ID
        /// </summary>
        [SDKProperty("Service-Transaction-Id", IsHeader = true)]
        [JsonProperty("Service-Transaction-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTransactionId { get; set; }

        /// <summary>
        /// 桌面池ID。
        /// </summary>
        [SDKProperty("pool_id", IsPath = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ExpandDesktopPoolReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandDesktopPoolRequest {\n");
            sb.Append("  serviceTransactionId: ").Append(ServiceTransactionId).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpandDesktopPoolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpandDesktopPoolRequest input)
        {
            if (input == null) return false;
            if (this.ServiceTransactionId != input.ServiceTransactionId || (this.ServiceTransactionId != null && !this.ServiceTransactionId.Equals(input.ServiceTransactionId))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ServiceTransactionId != null) hashCode = hashCode * 59 + this.ServiceTransactionId.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
