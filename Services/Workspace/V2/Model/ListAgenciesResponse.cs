using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAgenciesResponse : SdkResponse
    {

        /// <summary>
        /// 委托信息。
        /// </summary>
        [JsonProperty("existing_agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgenciesInfo> ExistingAgencies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgenciesResponse {\n");
            sb.Append("  existingAgencies: ").Append(ExistingAgencies).Append("\n");
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
            if (input == null) return false;
            if (this.ExistingAgencies != input.ExistingAgencies || (this.ExistingAgencies != null && input.ExistingAgencies != null && !this.ExistingAgencies.SequenceEqual(input.ExistingAgencies))) return false;

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
                if (this.ExistingAgencies != null) hashCode = hashCode * 59 + this.ExistingAgencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
