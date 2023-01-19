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
    public class CreateApplicationRequestBody 
    {

        /// <summary>
        /// 应用名。  最大支持64个字符，只能包含英文字母、下划线和数字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用平台。  目前仅支持HMS、APNS、APNS_SANDBOX。  HMS是为开发者提供的消息推送平台。  APNS和APNS_SANDBOX是用于推送iOS消息的服务平台。
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 对于HMS平台是APP ID，只能包含英文字母和数字，最大20个字符。 对于苹果APNS、APNS_SandBox平台是推送证书，大小不超过8K，且是Base64编码。
        /// </summary>
        [JsonProperty("platform_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformPrincipal { get; set; }

        /// <summary>
        /// 对于HMS平台是APP SECRET， 只能包含英文字母和数字，32到64个字符。  对于苹果APNS、APNS_SandBox平台是推送证书的私钥（private key）， 大小不超过8K，且是Base64编码。
        /// </summary>
        [JsonProperty("platform_credential", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformCredential { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  platformPrincipal: ").Append(PlatformPrincipal).Append("\n");
            sb.Append("  platformCredential: ").Append(PlatformCredential).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.PlatformPrincipal == input.PlatformPrincipal ||
                    (this.PlatformPrincipal != null &&
                    this.PlatformPrincipal.Equals(input.PlatformPrincipal))
                ) && 
                (
                    this.PlatformCredential == input.PlatformCredential ||
                    (this.PlatformCredential != null &&
                    this.PlatformCredential.Equals(input.PlatformCredential))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.PlatformPrincipal != null)
                    hashCode = hashCode * 59 + this.PlatformPrincipal.GetHashCode();
                if (this.PlatformCredential != null)
                    hashCode = hashCode * 59 + this.PlatformCredential.GetHashCode();
                return hashCode;
            }
        }
    }
}
