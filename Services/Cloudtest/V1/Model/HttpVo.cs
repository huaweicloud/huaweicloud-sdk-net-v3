using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolReqVo Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolResVo Response { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpVo {\n");
            sb.Append("  request: ").Append(Request).Append("\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpVo input)
        {
            if (input == null) return false;
            if (this.Request != input.Request || (this.Request != null && !this.Request.Equals(input.Request))) return false;
            if (this.Response != input.Response || (this.Response != null && !this.Response.Equals(input.Response))) return false;

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
                if (this.Request != null) hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null) hashCode = hashCode * 59 + this.Response.GetHashCode();
                return hashCode;
            }
        }
    }
}
