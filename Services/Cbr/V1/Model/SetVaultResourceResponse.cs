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
    public class SetVaultResourceResponse : SdkResponse
    {

        /// <summary>
        /// 本次设置的资源id列表。
        /// </summary>
        [JsonProperty("set_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SetResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetVaultResourceResponse {\n");
            sb.Append("  setResourceIds: ").Append(SetResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetVaultResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetVaultResourceResponse input)
        {
            if (input == null) return false;
            if (this.SetResourceIds != input.SetResourceIds || (this.SetResourceIds != null && input.SetResourceIds != null && !this.SetResourceIds.SequenceEqual(input.SetResourceIds))) return false;

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
                if (this.SetResourceIds != null) hashCode = hashCode * 59 + this.SetResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
