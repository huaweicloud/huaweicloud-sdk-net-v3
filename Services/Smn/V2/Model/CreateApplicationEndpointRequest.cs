using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateApplicationEndpointRequest 
    {

        /// <summary>
        /// Application的唯一资源标识，可通过[查询Application](smn_api_57004.xml)获取该标识。
        /// </summary>
        [SDKProperty("application_urn", IsPath = true)]
        [JsonProperty("application_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateApplicationEndpointRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationEndpointRequest {\n");
            sb.Append("  applicationUrn: ").Append(ApplicationUrn).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationEndpointRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationUrn == input.ApplicationUrn ||
                    (this.ApplicationUrn != null &&
                    this.ApplicationUrn.Equals(input.ApplicationUrn))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.ApplicationUrn != null)
                    hashCode = hashCode * 59 + this.ApplicationUrn.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
