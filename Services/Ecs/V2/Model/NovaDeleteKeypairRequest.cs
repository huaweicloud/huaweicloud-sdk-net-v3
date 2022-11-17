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
    public class NovaDeleteKeypairRequest 
    {

        /// <summary>
        /// 密钥名称。
        /// </summary>
        [SDKProperty("keypair_name", IsPath = true)]
        [JsonProperty("keypair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeypairName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaDeleteKeypairRequest {\n");
            sb.Append("  keypairName: ").Append(KeypairName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaDeleteKeypairRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaDeleteKeypairRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeypairName == input.KeypairName ||
                    (this.KeypairName != null &&
                    this.KeypairName.Equals(input.KeypairName))
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
                return hashCode;
            }
        }
    }
}
