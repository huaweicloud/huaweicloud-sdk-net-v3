using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RankRiskRuleNew 
    {

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 优先级序号，从1开始越小优先级越高
        /// </summary>
        [JsonProperty("new_rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewRank { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankRiskRuleNew {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  newRank: ").Append(NewRank).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RankRiskRuleNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RankRiskRuleNew input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.NewRank != input.NewRank || (this.NewRank != null && !this.NewRank.Equals(input.NewRank))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NewRank != null) hashCode = hashCode * 59 + this.NewRank.GetHashCode();
                return hashCode;
            }
        }
    }
}
