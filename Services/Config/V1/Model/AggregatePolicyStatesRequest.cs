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
    /// 聚合合规评估结果请求体
    /// </summary>
    public class AggregatePolicyStatesRequest 
    {

        /// <summary>
        /// 资源聚合器ID
        /// </summary>
        [JsonProperty("aggregator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// 源帐号ID
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 用于对资源计数进行分组的键（DOMAIN）。
        /// </summary>
        [JsonProperty("group_by_key", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupByKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatePolicyStatesRequest {\n");
            sb.Append("  aggregatorId: ").Append(AggregatorId).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  groupByKey: ").Append(GroupByKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregatePolicyStatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AggregatePolicyStatesRequest input)
        {
            if (input == null) return false;
            if (this.AggregatorId != input.AggregatorId || (this.AggregatorId != null && !this.AggregatorId.Equals(input.AggregatorId))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.GroupByKey != input.GroupByKey || (this.GroupByKey != null && !this.GroupByKey.Equals(input.GroupByKey))) return false;

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
                if (this.AggregatorId != null) hashCode = hashCode * 59 + this.AggregatorId.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.GroupByKey != null) hashCode = hashCode * 59 + this.GroupByKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
