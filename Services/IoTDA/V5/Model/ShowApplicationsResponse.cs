using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowApplicationsResponse : SdkResponse
    {

        /// <summary>
        /// 资源空间信息列表。
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationDTO> Applications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowApplicationsResponse {\n");
            sb.Append("  applications: ").Append(Applications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowApplicationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowApplicationsResponse input)
        {
            if (input == null) return false;
            if (this.Applications != input.Applications || (this.Applications != null && input.Applications != null && !this.Applications.SequenceEqual(input.Applications))) return false;

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
                if (this.Applications != null) hashCode = hashCode * 59 + this.Applications.GetHashCode();
                return hashCode;
            }
        }
    }
}
