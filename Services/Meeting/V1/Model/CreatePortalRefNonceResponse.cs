using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreatePortalRefNonceResponse : SdkResponse
    {

        /// <summary>
        /// 用于跳转登录的nonce信息。同一个nonce只能使用一次。 &gt; 通过链接https://meeting.huaweicloud.com/?lang&#x3D;zh-CN&amp;nonce&#x3D;xxxxxxxxxxxxx#/login进行免登陆跳转。 
        /// </summary>
        [JsonProperty("nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string Nonce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePortalRefNonceResponse {\n");
            sb.Append("  nonce: ").Append(Nonce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePortalRefNonceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePortalRefNonceResponse input)
        {
            if (input == null) return false;
            if (this.Nonce != input.Nonce || (this.Nonce != null && !this.Nonce.Equals(input.Nonce))) return false;

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
                if (this.Nonce != null) hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                return hashCode;
            }
        }
    }
}
