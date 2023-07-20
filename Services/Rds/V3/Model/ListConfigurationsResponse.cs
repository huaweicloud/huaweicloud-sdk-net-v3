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
    public class ListConfigurationsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configurations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigurationSummary> Configurations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigurationsResponse {\n");
            sb.Append("  configurations: ").Append(Configurations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
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
                if (this.Configurations != null)
                    hashCode = hashCode * 59 + this.Configurations.GetHashCode();
                return hashCode;
            }
        }
    }
}
