using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionMemoryContextInfoResult 
    {

        /// <summary>
        /// **参数解释**: 内存上下文名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("context_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContextName { get; set; }

        /// <summary>
        /// **参数解释**: 会话上下文数量。 **取值范围**: 大于等于0。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// **参数解释**: 会话上下文总大小。 **取值范围**: 大于等于0。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionMemoryContextInfoResult {\n");
            sb.Append("  contextName: ").Append(ContextName).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionMemoryContextInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionMemoryContextInfoResult input)
        {
            if (input == null) return false;
            if (this.ContextName != input.ContextName || (this.ContextName != null && !this.ContextName.Equals(input.ContextName))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                if (this.ContextName != null) hashCode = hashCode * 59 + this.ContextName.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
