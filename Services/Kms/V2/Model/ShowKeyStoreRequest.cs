using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowKeyStoreRequest 
    {

        /// <summary>
        /// 密钥库ID
        /// </summary>
        [SDKProperty("keystore_id", IsPath = true)]
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKeyStoreRequest {\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKeyStoreRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKeyStoreRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeystoreId == input.KeystoreId ||
                    (this.KeystoreId != null &&
                    this.KeystoreId.Equals(input.KeystoreId))
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
                if (this.KeystoreId != null)
                    hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                return hashCode;
            }
        }
    }
}
