using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowVersionResponse : SdkResponse
    {

        /// <summary>
        /// API版本信息列表
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<APIVersionDetail> Versions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVersionResponse {\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVersionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                return hashCode;
            }
        }
    }
}
