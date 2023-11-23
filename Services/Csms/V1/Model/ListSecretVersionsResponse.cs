using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSecretVersionsResponse : SdkResponse
    {

        /// <summary>
        /// version_metadata对象。
        /// </summary>
        [JsonProperty("version_metadatas", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionMetadata> VersionMetadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSecretVersionsResponse {\n");
            sb.Append("  versionMetadatas: ").Append(VersionMetadatas).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSecretVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSecretVersionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionMetadatas == input.VersionMetadatas ||
                    this.VersionMetadatas != null &&
                    input.VersionMetadatas != null &&
                    this.VersionMetadatas.SequenceEqual(input.VersionMetadatas)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.VersionMetadatas != null)
                    hashCode = hashCode * 59 + this.VersionMetadatas.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
