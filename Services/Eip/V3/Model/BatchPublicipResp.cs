using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchPublicipResp 
    {

        /// <summary>
        /// 响应码
        /// </summary>
        [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicipResp Publicip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchPublicipResp {\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchPublicipResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchPublicipResp input)
        {
            if (input == null) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.Publicip != input.Publicip || (this.Publicip != null && !this.Publicip.Equals(input.Publicip))) return false;

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
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.Publicip != null) hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                return hashCode;
            }
        }
    }
}
