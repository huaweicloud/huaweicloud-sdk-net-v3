using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHandshakesResponse : SdkResponse
    {

        /// <summary>
        /// 邀请（握手）对象的列表，其中包含与指定账号关联的每个邀请（握手）的详细信息。
        /// </summary>
        [JsonProperty("handshakes", NullValueHandling = NullValueHandling.Ignore)]
        public List<HandshakeDto> Handshakes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHandshakesResponse {\n");
            sb.Append("  handshakes: ").Append(Handshakes).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHandshakesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHandshakesResponse input)
        {
            if (input == null) return false;
            if (this.Handshakes != input.Handshakes || (this.Handshakes != null && input.Handshakes != null && !this.Handshakes.SequenceEqual(input.Handshakes))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.Handshakes != null) hashCode = hashCode * 59 + this.Handshakes.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
