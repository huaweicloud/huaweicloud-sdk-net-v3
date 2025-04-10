using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAuthorizationTokenResponse : SdkResponse
    {

        /// <summary>
        /// 认证信息
        /// </summary>
        [JsonProperty("auths", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, AuthInfo> Auths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Swr-Dockerlogin", IsHeader = true)]
        [JsonProperty("X-Swr-Dockerlogin", NullValueHandling = NullValueHandling.Ignore)]
        public string XSwrDockerlogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("x-swr-expireat", IsHeader = true)]
        [JsonProperty("x-swr-expireat", NullValueHandling = NullValueHandling.Ignore)]
        public string XSwrExpireat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAuthorizationTokenResponse {\n");
            sb.Append("  auths: ").Append(Auths).Append("\n");
            sb.Append("  xSwrDockerlogin: ").Append(XSwrDockerlogin).Append("\n");
            sb.Append("  xSwrExpireat: ").Append(XSwrExpireat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAuthorizationTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAuthorizationTokenResponse input)
        {
            if (input == null) return false;
            if (this.Auths != input.Auths || (this.Auths != null && input.Auths != null && !this.Auths.SequenceEqual(input.Auths))) return false;
            if (this.XSwrDockerlogin != input.XSwrDockerlogin || (this.XSwrDockerlogin != null && !this.XSwrDockerlogin.Equals(input.XSwrDockerlogin))) return false;
            if (this.XSwrExpireat != input.XSwrExpireat || (this.XSwrExpireat != null && !this.XSwrExpireat.Equals(input.XSwrExpireat))) return false;

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
                if (this.Auths != null) hashCode = hashCode * 59 + this.Auths.GetHashCode();
                if (this.XSwrDockerlogin != null) hashCode = hashCode * 59 + this.XSwrDockerlogin.GetHashCode();
                if (this.XSwrExpireat != null) hashCode = hashCode * 59 + this.XSwrExpireat.GetHashCode();
                return hashCode;
            }
        }
    }
}
