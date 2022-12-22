using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAccessCodeResponse : SdkResponse
    {

        /// <summary>
        /// 接入名，随机生成8位字符串
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 接入凭证。
        /// </summary>
        [JsonProperty("access_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessCodeResponse {\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  accessCode: ").Append(AccessCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccessCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccessCodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
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
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
