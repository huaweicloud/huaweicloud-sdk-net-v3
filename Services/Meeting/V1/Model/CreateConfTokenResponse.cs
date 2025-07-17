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
    public class CreateConfTokenResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public TokenInfo Data { get; set; }

        /// <summary>
        /// 企业通讯录查询临时Token。
        /// </summary>
        [JsonProperty("addressToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressToken { get; set; }

        /// <summary>
        /// 华为云会议Portal地址。
        /// </summary>
        [JsonProperty("gloablPublicIP", NullValueHandling = NullValueHandling.Ignore)]
        public string GloablPublicIP { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConfTokenResponse {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  addressToken: ").Append(AddressToken).Append("\n");
            sb.Append("  gloablPublicIP: ").Append(GloablPublicIP).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConfTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConfTokenResponse input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.AddressToken != input.AddressToken || (this.AddressToken != null && !this.AddressToken.Equals(input.AddressToken))) return false;
            if (this.GloablPublicIP != input.GloablPublicIP || (this.GloablPublicIP != null && !this.GloablPublicIP.Equals(input.GloablPublicIP))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.AddressToken != null) hashCode = hashCode * 59 + this.AddressToken.GetHashCode();
                if (this.GloablPublicIP != null) hashCode = hashCode * 59 + this.GloablPublicIP.GetHashCode();
                return hashCode;
            }
        }
    }
}
