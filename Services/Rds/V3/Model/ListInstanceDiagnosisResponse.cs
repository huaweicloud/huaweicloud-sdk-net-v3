using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceDiagnosisResponse : SdkResponse
    {

        /// <summary>
        /// diagnosis info
        /// </summary>
        [JsonProperty("diagnosis", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisItemResult> Diagnosis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceDiagnosisResponse {\n");
            sb.Append("  diagnosis: ").Append(Diagnosis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceDiagnosisResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceDiagnosisResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Diagnosis == input.Diagnosis ||
                    this.Diagnosis != null &&
                    input.Diagnosis != null &&
                    this.Diagnosis.SequenceEqual(input.Diagnosis)
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
                if (this.Diagnosis != null)
                    hashCode = hashCode * 59 + this.Diagnosis.GetHashCode();
                return hashCode;
            }
        }
    }
}
