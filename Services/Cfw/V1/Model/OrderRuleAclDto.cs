using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// UpdateRuleAclDto
    /// </summary>
    public class OrderRuleAclDto 
    {

        /// <summary>
        /// 目标规则id，添加规则位于此规则之后，非置顶时不能为空，置顶时为空
        /// </summary>
        [JsonProperty("dest_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestRuleId { get; set; }

        /// <summary>
        /// 是否置顶，0代表非置顶，1代表置顶
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public int? Top { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRuleAclDto {\n");
            sb.Append("  destRuleId: ").Append(DestRuleId).Append("\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderRuleAclDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderRuleAclDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestRuleId == input.DestRuleId ||
                    (this.DestRuleId != null &&
                    this.DestRuleId.Equals(input.DestRuleId))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
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
                if (this.DestRuleId != null)
                    hashCode = hashCode * 59 + this.DestRuleId.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                return hashCode;
            }
        }
    }
}
