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
    /// Response Object
    /// </summary>
    public class CreateUrlAuthchainResponse : SdkResponse
    {

        /// <summary>
        /// 生成的鉴权串列表
        /// </summary>
        [JsonProperty("keychain", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keychain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUrlAuthchainResponse {\n");
            sb.Append("  keychain: ").Append(Keychain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUrlAuthchainResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUrlAuthchainResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keychain == input.Keychain ||
                    this.Keychain != null &&
                    input.Keychain != null &&
                    this.Keychain.SequenceEqual(input.Keychain)
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
                if (this.Keychain != null)
                    hashCode = hashCode * 59 + this.Keychain.GetHashCode();
                return hashCode;
            }
        }
    }
}
