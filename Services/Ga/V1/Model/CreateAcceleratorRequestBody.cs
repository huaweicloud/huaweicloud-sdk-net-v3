using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// create Accelerator request
    /// </summary>
    public class CreateAcceleratorRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accelerator", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAcceleratorOption Accelerator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAcceleratorRequestBody {\n");
            sb.Append("  accelerator: ").Append(Accelerator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAcceleratorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAcceleratorRequestBody input)
        {
            if (input == null) return false;
            if (this.Accelerator != input.Accelerator || (this.Accelerator != null && !this.Accelerator.Equals(input.Accelerator))) return false;

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
                if (this.Accelerator != null) hashCode = hashCode * 59 + this.Accelerator.GetHashCode();
                return hashCode;
            }
        }
    }
}
