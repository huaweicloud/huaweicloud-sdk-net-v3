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
    public class RemoveVaultResourceResponse : SdkResponse
    {

        /// <summary>
        /// 移除的资源ID
        /// </summary>
        [JsonProperty("remove_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RemoveResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveVaultResourceResponse {\n");
            sb.Append("  removeResourceIds: ").Append(RemoveResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoveVaultResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoveVaultResourceResponse input)
        {
            if (input == null) return false;
            if (this.RemoveResourceIds != input.RemoveResourceIds || (this.RemoveResourceIds != null && input.RemoveResourceIds != null && !this.RemoveResourceIds.SequenceEqual(input.RemoveResourceIds))) return false;

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
                if (this.RemoveResourceIds != null) hashCode = hashCode * 59 + this.RemoveResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
