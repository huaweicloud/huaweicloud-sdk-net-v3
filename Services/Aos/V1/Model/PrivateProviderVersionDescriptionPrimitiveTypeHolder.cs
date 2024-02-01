using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivateProviderVersionDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有provider版本（provider version）的描述。可用于客户识别并管理私有provider的版本。注意：provider版本为不可更新（immutable），所以该字段不可更新，如果需要更新，请删除后重建
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProviderVersionDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateProviderVersionDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateProviderVersionDescriptionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionDescription == input.VersionDescription ||
                    (this.VersionDescription != null &&
                    this.VersionDescription.Equals(input.VersionDescription))
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
                if (this.VersionDescription != null)
                    hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
