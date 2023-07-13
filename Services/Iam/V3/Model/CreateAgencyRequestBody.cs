using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateAgencyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("agency", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAgencyOption Agency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgencyRequestBody {\n");
            sb.Append("  agency: ").Append(Agency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAgencyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAgencyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agency == input.Agency ||
                    (this.Agency != null &&
                    this.Agency.Equals(input.Agency))
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
                if (this.Agency != null)
                    hashCode = hashCode * 59 + this.Agency.GetHashCode();
                return hashCode;
            }
        }
    }
}
