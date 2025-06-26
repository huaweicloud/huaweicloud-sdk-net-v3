using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class EnableControlResponse : SdkResponse
    {

        /// <summary>
        /// 控制策略的操作ID。
        /// </summary>
        [JsonProperty("control_operate_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlOperateRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableControlResponse {\n");
            sb.Append("  controlOperateRequestId: ").Append(ControlOperateRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableControlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableControlResponse input)
        {
            if (input == null) return false;
            if (this.ControlOperateRequestId != input.ControlOperateRequestId || (this.ControlOperateRequestId != null && !this.ControlOperateRequestId.Equals(input.ControlOperateRequestId))) return false;

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
                if (this.ControlOperateRequestId != null) hashCode = hashCode * 59 + this.ControlOperateRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
