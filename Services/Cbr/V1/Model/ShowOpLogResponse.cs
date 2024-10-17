using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOpLogResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operation_log", NullValueHandling = NullValueHandling.Ignore)]
        public OperationLog OperationLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOpLogResponse {\n");
            sb.Append("  operationLog: ").Append(OperationLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOpLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOpLogResponse input)
        {
            if (input == null) return false;
            if (this.OperationLog != input.OperationLog || (this.OperationLog != null && !this.OperationLog.Equals(input.OperationLog))) return false;

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
                if (this.OperationLog != null) hashCode = hashCode * 59 + this.OperationLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
