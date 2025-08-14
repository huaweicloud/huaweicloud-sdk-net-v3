using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListExternalIdPConfigurationsForDirectoryResponse : SdkResponse
    {

        /// <summary>
        /// 外部身份提供商配置信息
        /// </summary>
        [JsonProperty("associations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalIdpConfigurationDto> Associations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExternalIdPConfigurationsForDirectoryResponse {\n");
            sb.Append("  associations: ").Append(Associations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListExternalIdPConfigurationsForDirectoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListExternalIdPConfigurationsForDirectoryResponse input)
        {
            if (input == null) return false;
            if (this.Associations != input.Associations || (this.Associations != null && input.Associations != null && !this.Associations.SequenceEqual(input.Associations))) return false;

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
                if (this.Associations != null) hashCode = hashCode * 59 + this.Associations.GetHashCode();
                return hashCode;
            }
        }
    }
}
