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
    public class DeleteDesktopVolumesRequest 
    {

        /// <summary>
        /// CBC接口回调时，请求头里带上的业务ID
        /// </summary>
        [SDKProperty("Service-Transaction-Id", IsHeader = true)]
        [JsonProperty("Service-Transaction-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTransactionId { get; set; }

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [SDKProperty("desktop_id", IsPath = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteVolumesReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDesktopVolumesRequest {\n");
            sb.Append("  serviceTransactionId: ").Append(ServiceTransactionId).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDesktopVolumesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDesktopVolumesRequest input)
        {
            if (input == null) return false;
            if (this.ServiceTransactionId != input.ServiceTransactionId || (this.ServiceTransactionId != null && !this.ServiceTransactionId.Equals(input.ServiceTransactionId))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
