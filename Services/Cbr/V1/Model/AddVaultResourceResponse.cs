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
    public class AddVaultResourceResponse : SdkResponse
    {

        /// <summary>
        /// 已添加的资源ID列表
        /// </summary>
        [JsonProperty("add_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddVaultResourceResponse {\n");
            sb.Append("  addResourceIds: ").Append(AddResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddVaultResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddVaultResourceResponse input)
        {
            if (input == null) return false;
            if (this.AddResourceIds != input.AddResourceIds || (this.AddResourceIds != null && input.AddResourceIds != null && !this.AddResourceIds.SequenceEqual(input.AddResourceIds))) return false;

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
                if (this.AddResourceIds != null) hashCode = hashCode * 59 + this.AddResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
