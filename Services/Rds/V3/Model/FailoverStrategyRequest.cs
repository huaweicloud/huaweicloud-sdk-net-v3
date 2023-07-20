using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FailoverStrategyRequest 
    {

        /// <summary>
        /// 可用性策略，可选择如下方式： - reliability：可靠性优先，数据库应该尽可能保障数据的可靠性，即数据丢失量最少。对于数据一致性要求较高的业务，建议选择该策略。 - availability：可用性优先，数据库应该可快恢复服务，即可用时间最长。对于数据库在线时间要求较高的业务，建议选择该策略。
        /// </summary>
        [JsonProperty("repairStrategy", NullValueHandling = NullValueHandling.Ignore)]
        public string RepairStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailoverStrategyRequest {\n");
            sb.Append("  repairStrategy: ").Append(RepairStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailoverStrategyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailoverStrategyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RepairStrategy == input.RepairStrategy ||
                    (this.RepairStrategy != null &&
                    this.RepairStrategy.Equals(input.RepairStrategy))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RepairStrategy != null)
                    hashCode = hashCode * 59 + this.RepairStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
