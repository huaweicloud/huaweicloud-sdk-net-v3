using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源概要信息
    /// </summary>
    public class ResourceSummaryResponseItem 
    {

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 资源类型列表
        /// </summary>
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceSummaryResponseItemTypes> Types { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSummaryResponseItem {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  types: ").Append(Types).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSummaryResponseItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSummaryResponseItem input)
        {
            if (input == null) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Types != input.Types || (this.Types != null && input.Types != null && !this.Types.SequenceEqual(input.Types))) return false;

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
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Types != null) hashCode = hashCode * 59 + this.Types.GetHashCode();
                return hashCode;
            }
        }
    }
}
