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
    /// Request Object
    /// </summary>
    public class ShowOpLogRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("operation_log_id", IsPath = true)]
        [JsonProperty("operation_log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationLogId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOpLogRequest {\n");
            sb.Append("  operationLogId: ").Append(OperationLogId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOpLogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOpLogRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationLogId == input.OperationLogId ||
                    (this.OperationLogId != null &&
                    this.OperationLogId.Equals(input.OperationLogId))
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
                if (this.OperationLogId != null)
                    hashCode = hashCode * 59 + this.OperationLogId.GetHashCode();
                return hashCode;
            }
        }
    }
}
