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
    public class ShowConfigurationAggregatorResponse : SdkResponse
    {

        /// <summary>
        /// 资源聚合器名称。
        /// </summary>
        [JsonProperty("aggregator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// 资源聚合器ID。
        /// </summary>
        [JsonProperty("aggregator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// 资源聚合器标识符。
        /// </summary>
        [JsonProperty("aggregator_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorUrn { get; set; }

        /// <summary>
        /// 聚合器类型。
        /// </summary>
        [JsonProperty("aggregator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_aggregation_sources", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAggregationSource AccountAggregationSources { get; set; }

        /// <summary>
        /// 资源聚合器更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 资源聚合器创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationAggregatorResponse {\n");
            sb.Append("  aggregatorName: ").Append(AggregatorName).Append("\n");
            sb.Append("  aggregatorId: ").Append(AggregatorId).Append("\n");
            sb.Append("  aggregatorUrn: ").Append(AggregatorUrn).Append("\n");
            sb.Append("  aggregatorType: ").Append(AggregatorType).Append("\n");
            sb.Append("  accountAggregationSources: ").Append(AccountAggregationSources).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationAggregatorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationAggregatorResponse input)
        {
            if (input == null) return false;
            if (this.AggregatorName != input.AggregatorName || (this.AggregatorName != null && !this.AggregatorName.Equals(input.AggregatorName))) return false;
            if (this.AggregatorId != input.AggregatorId || (this.AggregatorId != null && !this.AggregatorId.Equals(input.AggregatorId))) return false;
            if (this.AggregatorUrn != input.AggregatorUrn || (this.AggregatorUrn != null && !this.AggregatorUrn.Equals(input.AggregatorUrn))) return false;
            if (this.AggregatorType != input.AggregatorType || (this.AggregatorType != null && !this.AggregatorType.Equals(input.AggregatorType))) return false;
            if (this.AccountAggregationSources != input.AccountAggregationSources || (this.AccountAggregationSources != null && !this.AccountAggregationSources.Equals(input.AccountAggregationSources))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.AggregatorName != null) hashCode = hashCode * 59 + this.AggregatorName.GetHashCode();
                if (this.AggregatorId != null) hashCode = hashCode * 59 + this.AggregatorId.GetHashCode();
                if (this.AggregatorUrn != null) hashCode = hashCode * 59 + this.AggregatorUrn.GetHashCode();
                if (this.AggregatorType != null) hashCode = hashCode * 59 + this.AggregatorType.GetHashCode();
                if (this.AccountAggregationSources != null) hashCode = hashCode * 59 + this.AccountAggregationSources.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
