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
    /// Response Object
    /// </summary>
    public class ListConfigurationAggregatorsResponse : SdkResponse
    {

        /// <summary>
        /// 资源聚合器列表。
        /// </summary>
        [JsonProperty("configuration_aggregators", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigurationAggregatorResp> ConfigurationAggregators { get; set; }

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
            sb.Append("class ListConfigurationAggregatorsResponse {\n");
            sb.Append("  configurationAggregators: ").Append(ConfigurationAggregators).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationAggregatorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationAggregatorsResponse input)
        {
            if (input == null) return false;
            if (this.ConfigurationAggregators != input.ConfigurationAggregators || (this.ConfigurationAggregators != null && input.ConfigurationAggregators != null && !this.ConfigurationAggregators.SequenceEqual(input.ConfigurationAggregators))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ConfigurationAggregators != null) hashCode = hashCode * 59 + this.ConfigurationAggregators.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
