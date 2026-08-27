using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量解绑供应商从模型组请求。
    /// </summary>
    public class BatchDeleteProvidersReq 
    {

        /// <summary>
        /// 供应商id列表。
        /// </summary>
        [JsonProperty("provider_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProviderIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteProvidersReq {\n");
            sb.Append("  providerIds: ").Append(ProviderIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteProvidersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteProvidersReq input)
        {
            if (input == null) return false;
            if (this.ProviderIds != input.ProviderIds || (this.ProviderIds != null && input.ProviderIds != null && !this.ProviderIds.SequenceEqual(input.ProviderIds))) return false;

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
                if (this.ProviderIds != null) hashCode = hashCode * 59 + this.ProviderIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
