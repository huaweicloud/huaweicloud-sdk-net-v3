using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 功能说明：线路规格编码UUID。
    /// </summary>
    public class GcbSpecCodeId 
    {

        /// <summary>
        /// 功能说明：线路规格编码UUID。
        /// </summary>
        [JsonProperty("spec_code_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbSpecCodeId {\n");
            sb.Append("  specCodeId: ").Append(SpecCodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbSpecCodeId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbSpecCodeId input)
        {
            if (input == null) return false;
            if (this.SpecCodeId != input.SpecCodeId || (this.SpecCodeId != null && !this.SpecCodeId.Equals(input.SpecCodeId))) return false;

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
                if (this.SpecCodeId != null) hashCode = hashCode * 59 + this.SpecCodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
