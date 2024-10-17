using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrecheckDisasterRecoveryOperationBody 
    {

        /// <summary>
        /// 指定预校验的具体容灾操作。
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disaster_recovery_instance", NullValueHandling = NullValueHandling.Ignore)]
        public PrecheckDisasterRecoveryInstance DisasterRecoveryInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckDisasterRecoveryOperationBody {\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  disasterRecoveryInstance: ").Append(DisasterRecoveryInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckDisasterRecoveryOperationBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckDisasterRecoveryOperationBody input)
        {
            if (input == null) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.DisasterRecoveryInstance != input.DisasterRecoveryInstance || (this.DisasterRecoveryInstance != null && !this.DisasterRecoveryInstance.Equals(input.DisasterRecoveryInstance))) return false;

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
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.DisasterRecoveryInstance != null) hashCode = hashCode * 59 + this.DisasterRecoveryInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
