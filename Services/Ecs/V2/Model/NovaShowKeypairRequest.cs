using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class NovaShowKeypairRequest 
    {

        /// <summary>
        /// 密钥名称信息。
        /// </summary>
        [SDKProperty("keypair_name", IsPath = true)]
        [JsonProperty("keypair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeypairName { get; set; }

        /// <summary>
        /// 微版本头
        /// </summary>
        [SDKProperty("OpenStack-API-Version", IsHeader = true)]
        [JsonProperty("OpenStack-API-Version", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenStackAPIVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaShowKeypairRequest {\n");
            sb.Append("  keypairName: ").Append(KeypairName).Append("\n");
            sb.Append("  openStackAPIVersion: ").Append(OpenStackAPIVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaShowKeypairRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaShowKeypairRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeypairName == input.KeypairName ||
                    (this.KeypairName != null &&
                    this.KeypairName.Equals(input.KeypairName))
                ) && 
                (
                    this.OpenStackAPIVersion == input.OpenStackAPIVersion ||
                    (this.OpenStackAPIVersion != null &&
                    this.OpenStackAPIVersion.Equals(input.OpenStackAPIVersion))
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
                if (this.KeypairName != null)
                    hashCode = hashCode * 59 + this.KeypairName.GetHashCode();
                if (this.OpenStackAPIVersion != null)
                    hashCode = hashCode * 59 + this.OpenStackAPIVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
