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
    public class VarOverridesPrimitiveTypeHolder 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("var_overrides", NullValueHandling = NullValueHandling.Ignore)]
        public VarOverridesPrimitiveTypeHolderVarOverrides VarOverrides { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VarOverridesPrimitiveTypeHolder {\n");
            sb.Append("  varOverrides: ").Append(VarOverrides).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VarOverridesPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VarOverridesPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.VarOverrides != input.VarOverrides || (this.VarOverrides != null && !this.VarOverrides.Equals(input.VarOverrides))) return false;

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
                if (this.VarOverrides != null) hashCode = hashCode * 59 + this.VarOverrides.GetHashCode();
                return hashCode;
            }
        }
    }
}
