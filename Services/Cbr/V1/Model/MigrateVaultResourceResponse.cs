using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class MigrateVaultResourceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("migrated_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MigratedResources { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateVaultResourceResponse {\n");
            sb.Append("  migratedResources: ").Append(MigratedResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateVaultResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateVaultResourceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigratedResources == input.MigratedResources ||
                    this.MigratedResources != null &&
                    input.MigratedResources != null &&
                    this.MigratedResources.SequenceEqual(input.MigratedResources)
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
                if (this.MigratedResources != null)
                    hashCode = hashCode * 59 + this.MigratedResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
