using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 规格变更请求体
    /// </summary>
    public class ChangeFlavorReq 
    {

        /// <summary>
        /// 目标规格类型。 取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。
        /// </summary>
        [JsonProperty("spec_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeFlavorReq {\n");
            sb.Append("  specType: ").Append(SpecType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeFlavorReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeFlavorReq input)
        {
            if (input == null) return false;
            if (this.SpecType != input.SpecType || (this.SpecType != null && !this.SpecType.Equals(input.SpecType))) return false;

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
                if (this.SpecType != null) hashCode = hashCode * 59 + this.SpecType.GetHashCode();
                return hashCode;
            }
        }
    }
}
