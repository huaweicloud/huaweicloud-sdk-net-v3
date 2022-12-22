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
    /// 
    /// </summary>
    public class ListApplicationEndpointAttributesResponseBodyAttributes 
    {

        /// <summary>
        /// 设备是否可用。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        /// <summary>
        /// 设备token。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 用户数据。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationEndpointAttributesResponseBodyAttributes {\n");
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
            return this.Equals(input as ListApplicationEndpointAttributesResponseBodyAttributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationEndpointAttributesResponseBodyAttributes input)
        {
            if (input == null)
                return false;

            return 
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
