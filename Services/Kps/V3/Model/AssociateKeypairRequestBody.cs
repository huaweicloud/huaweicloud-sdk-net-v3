using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// 绑定密钥对描述消息体
    /// </summary>
    public class AssociateKeypairRequestBody 
    {

        /// <summary>
        /// SSH密钥对的名称
        /// </summary>
        [JsonProperty("keypair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeypairName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public EcsServerInfo Server { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateKeypairRequestBody {\n");
            sb.Append("  keypairName: ").Append(KeypairName).Append("\n");
            sb.Append("  server: ").Append(Server).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateKeypairRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateKeypairRequestBody input)
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
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
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
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                return hashCode;
            }
        }
    }
}
