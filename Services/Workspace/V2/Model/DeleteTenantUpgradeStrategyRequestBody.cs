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
    /// 批量删除升级策略请求
    /// </summary>
    public class DeleteTenantUpgradeStrategyRequestBody 
    {

        /// <summary>
        /// 策略ID列表
        /// </summary>
        [JsonProperty("strategy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StrategyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTenantUpgradeStrategyRequestBody {\n");
            sb.Append("  strategyIds: ").Append(StrategyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTenantUpgradeStrategyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTenantUpgradeStrategyRequestBody input)
        {
            if (input == null) return false;
            if (this.StrategyIds != input.StrategyIds || (this.StrategyIds != null && input.StrategyIds != null && !this.StrategyIds.SequenceEqual(input.StrategyIds))) return false;

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
                if (this.StrategyIds != null) hashCode = hashCode * 59 + this.StrategyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
