using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowReferResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("referer", NullValueHandling = NullValueHandling.Ignore)]
        public RefererRsp Referer { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReferResponse {\n");
            sb.Append("  referer: ").Append(Referer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReferResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReferResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Referer == input.Referer ||
                    (this.Referer != null &&
                    this.Referer.Equals(input.Referer))
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
                if (this.Referer != null)
                    hashCode = hashCode * 59 + this.Referer.GetHashCode();
                return hashCode;
            }
        }
    }
}
