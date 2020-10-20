using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateLoadBalancerRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Auth-Project-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Project-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthProjectToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadBalancerRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerRequest {\n");
            sb.Append("  xAuthProjectToken: ").Append(XAuthProjectToken).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XAuthProjectToken == input.XAuthProjectToken ||
                    (this.XAuthProjectToken != null &&
                    this.XAuthProjectToken.Equals(input.XAuthProjectToken))
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
                if (this.XAuthProjectToken != null)
                    hashCode = hashCode * 59 + this.XAuthProjectToken.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
