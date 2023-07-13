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
    /// Response Object
    /// </summary>
    public class ListAgenciesResponse : SdkResponse
    {

        /// <summary>
        /// 委托信息列表。
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgencyResult> Agencies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgenciesResponse {\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgenciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgenciesResponse input)
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
