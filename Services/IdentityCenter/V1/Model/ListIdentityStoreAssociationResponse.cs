using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListIdentityStoreAssociationResponse : SdkResponse
    {

        /// <summary>
        /// IAM身份中心服务实例关联的身份源配置信息
        /// </summary>
        [JsonProperty("identity_store_associations", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdentityStoreDto> IdentityStoreAssociations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIdentityStoreAssociationResponse {\n");
            sb.Append("  identityStoreAssociations: ").Append(IdentityStoreAssociations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIdentityStoreAssociationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIdentityStoreAssociationResponse input)
        {
            if (input == null) return false;
            if (this.IdentityStoreAssociations != input.IdentityStoreAssociations || (this.IdentityStoreAssociations != null && input.IdentityStoreAssociations != null && !this.IdentityStoreAssociations.SequenceEqual(input.IdentityStoreAssociations))) return false;

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
                if (this.IdentityStoreAssociations != null) hashCode = hashCode * 59 + this.IdentityStoreAssociations.GetHashCode();
                return hashCode;
            }
        }
    }
}
