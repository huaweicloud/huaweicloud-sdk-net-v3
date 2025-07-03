using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAkSksResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_ak_sk_models", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessAkskVO> AccessAkSkModels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAkSksResponse {\n");
            sb.Append("  accessAkSkModels: ").Append(AccessAkSkModels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAkSksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAkSksResponse input)
        {
            if (input == null) return false;
            if (this.AccessAkSkModels != input.AccessAkSkModels || (this.AccessAkSkModels != null && input.AccessAkSkModels != null && !this.AccessAkSkModels.SequenceEqual(input.AccessAkSkModels))) return false;

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
                if (this.AccessAkSkModels != null) hashCode = hashCode * 59 + this.AccessAkSkModels.GetHashCode();
                return hashCode;
            }
        }
    }
}
