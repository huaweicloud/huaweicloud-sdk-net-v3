using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowChannelStatisticRequest 
    {

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-Internal访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-Internal", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-Internal", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowInternal { get; set; }

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-External访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-External", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-External", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowExternal { get; set; }

        /// <summary>
        /// 每页记录数，取值范围[1,100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量。表示从此偏移量开始查询，offset大于等于0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ShowChannelStatisticReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowChannelStatisticRequest {\n");
            sb.Append("  accessControlAllowInternal: ").Append(AccessControlAllowInternal).Append("\n");
            sb.Append("  accessControlAllowExternal: ").Append(AccessControlAllowExternal).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowChannelStatisticRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowChannelStatisticRequest input)
        {
            if (input == null) return false;
            if (this.AccessControlAllowInternal != input.AccessControlAllowInternal || (this.AccessControlAllowInternal != null && !this.AccessControlAllowInternal.Equals(input.AccessControlAllowInternal))) return false;
            if (this.AccessControlAllowExternal != input.AccessControlAllowExternal || (this.AccessControlAllowExternal != null && !this.AccessControlAllowExternal.Equals(input.AccessControlAllowExternal))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.AccessControlAllowInternal != null) hashCode = hashCode * 59 + this.AccessControlAllowInternal.GetHashCode();
                if (this.AccessControlAllowExternal != null) hashCode = hashCode * 59 + this.AccessControlAllowExternal.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
