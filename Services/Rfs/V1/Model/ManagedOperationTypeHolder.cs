using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ManagedOperationTypeHolder 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("managed_operation", NullValueHandling = NullValueHandling.Ignore)]
        public ManagedOperation ManagedOperation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedOperationTypeHolder {\n");
            sb.Append("  managedOperation: ").Append(ManagedOperation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedOperationTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedOperationTypeHolder input)
        {
            if (input == null) return false;
            if (this.ManagedOperation != input.ManagedOperation || (this.ManagedOperation != null && !this.ManagedOperation.Equals(input.ManagedOperation))) return false;

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
                if (this.ManagedOperation != null) hashCode = hashCode * 59 + this.ManagedOperation.GetHashCode();
                return hashCode;
            }
        }
    }
}
