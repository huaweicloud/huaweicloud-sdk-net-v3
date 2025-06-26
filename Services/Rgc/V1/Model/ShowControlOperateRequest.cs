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
    /// Request Object
    /// </summary>
    public class ShowControlOperateRequest 
    {

        /// <summary>
        /// 操作控制策略的请求ID。
        /// </summary>
        [SDKProperty("operation_control_status_id", IsPath = true)]
        [JsonProperty("operation_control_status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationControlStatusId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowControlOperateRequest {\n");
            sb.Append("  operationControlStatusId: ").Append(OperationControlStatusId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowControlOperateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowControlOperateRequest input)
        {
            if (input == null) return false;
            if (this.OperationControlStatusId != input.OperationControlStatusId || (this.OperationControlStatusId != null && !this.OperationControlStatusId.Equals(input.OperationControlStatusId))) return false;

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
                if (this.OperationControlStatusId != null) hashCode = hashCode * 59 + this.OperationControlStatusId.GetHashCode();
                return hashCode;
            }
        }
    }
}
