using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreInstanceFromCollectionRequestBody 
    {

        /// <summary>
        /// 数据库信息。
        /// </summary>
        [JsonProperty("restore_collections", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreInstanceFromCollectionRequestBodyRestoreCollections> RestoreCollections { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInstanceFromCollectionRequestBody {\n");
            sb.Append("  restoreCollections: ").Append(RestoreCollections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInstanceFromCollectionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInstanceFromCollectionRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreCollections == input.RestoreCollections ||
                    this.RestoreCollections != null &&
                    input.RestoreCollections != null &&
                    this.RestoreCollections.SequenceEqual(input.RestoreCollections)
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
                if (this.RestoreCollections != null)
                    hashCode = hashCode * 59 + this.RestoreCollections.GetHashCode();
                return hashCode;
            }
        }
    }
}
