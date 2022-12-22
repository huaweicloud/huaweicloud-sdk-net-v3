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
    public class ListApplicationEndpointsRequest 
    {

        /// <summary>
        /// Application的唯一资源标识，可通过[查询Application](https://support.huaweicloud.com/api-smn/ListApplications.html)获取该标识。
        /// </summary>
        [SDKProperty("application_urn", IsPath = true)]
        [JsonProperty("application_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUrn { get; set; }

        /// <summary>
        /// 偏移量。  偏移量为一个大于0小于资源总个数的整数，表示查询该偏移量后面的所有的资源，默认值为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的数量限制。  取值范围：1~100，取值一般为10，20，50。功能说明：每页返回的资源个数。默认值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 设备是否可用，值为true或false字符串。
        /// </summary>
        [SDKProperty("enabled", IsQuery = true)]
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        /// <summary>
        /// 设备token，最大长度512个字节。
        /// </summary>
        [SDKProperty("token", IsQuery = true)]
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 用户数据，最大长度2048个字节。
        /// </summary>
        [SDKProperty("user_data", IsQuery = true)]
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationEndpointsRequest {\n");
            sb.Append("  applicationUrn: ").Append(ApplicationUrn).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationEndpointsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationEndpointsRequest input)
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
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                return hashCode;
            }
        }
    }
}
