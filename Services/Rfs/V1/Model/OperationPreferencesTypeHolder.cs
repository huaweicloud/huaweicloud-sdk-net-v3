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
    public class OperationPreferencesTypeHolder 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operation_preferences", NullValueHandling = NullValueHandling.Ignore)]
        public OperationPreferences OperationPreferences { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationPreferencesTypeHolder {\n");
            sb.Append("  operationPreferences: ").Append(OperationPreferences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationPreferencesTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationPreferencesTypeHolder input)
        {
            if (input == null) return false;
            if (this.OperationPreferences != input.OperationPreferences || (this.OperationPreferences != null && !this.OperationPreferences.Equals(input.OperationPreferences))) return false;

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
                if (this.OperationPreferences != null) hashCode = hashCode * 59 + this.OperationPreferences.GetHashCode();
                return hashCode;
            }
        }
    }
}
