using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgenciesPrimitiveTypeHolder 
    {

        /// <summary>
        /// 委托授权的信息。
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agency> Agencies { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenciesPrimitiveTypeHolder {\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgenciesPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgenciesPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agencies == input.Agencies ||
                    this.Agencies != null &&
                    input.Agencies != null &&
                    this.Agencies.SequenceEqual(input.Agencies)
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
                if (this.Agencies != null)
                    hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
