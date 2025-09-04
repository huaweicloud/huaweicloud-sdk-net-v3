using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateAppServersRequest 
    {

        /// <summary>
        /// 交易组件调用时下发的关联ID。
        /// </summary>
        [SDKProperty("X-Linked-Id", IsHeader = true)]
        [JsonProperty("X-Linked-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XLinkedId { get; set; }

        /// <summary>
        /// CBC接口回调时，请求头里带上的业务ID 包周期场景必填 按需场景无。
        /// </summary>
        [SDKProperty("Service-Transaction-Id", IsHeader = true)]
        [JsonProperty("Service-Transaction-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAppServerReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppServersRequest {\n");
            sb.Append("  xLinkedId: ").Append(XLinkedId).Append("\n");
            sb.Append("  serviceTransactionId: ").Append(ServiceTransactionId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppServersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppServersRequest input)
        {
            if (input == null) return false;
            if (this.XLinkedId != input.XLinkedId || (this.XLinkedId != null && !this.XLinkedId.Equals(input.XLinkedId))) return false;
            if (this.ServiceTransactionId != input.ServiceTransactionId || (this.ServiceTransactionId != null && !this.ServiceTransactionId.Equals(input.ServiceTransactionId))) return false;
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
                if (this.XLinkedId != null) hashCode = hashCode * 59 + this.XLinkedId.GetHashCode();
                if (this.ServiceTransactionId != null) hashCode = hashCode * 59 + this.ServiceTransactionId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
