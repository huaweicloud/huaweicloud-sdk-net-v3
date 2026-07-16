using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PoolStatusScope 
    {

        /// <summary>
        /// **参数解释**：资源池的业务类型。 **取值范围**：可选值如下： - Train：训练任务。 - Infer：推理任务。 - Notebook：Notebook作业。
        /// </summary>
        [JsonProperty("scopeType", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeType { get; set; }

        /// <summary>
        /// **参数解释**：资源池业务类型状态。 **取值范围**：可选值如下： - Enabling：启动中。 - Enabled：已启动。 - Disabling：关闭中。 - Disabled：已关闭。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatusScope {\n");
            sb.Append("  scopeType: ").Append(ScopeType).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatusScope);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatusScope input)
        {
            if (input == null) return false;
            if (this.ScopeType != input.ScopeType || (this.ScopeType != null && !this.ScopeType.Equals(input.ScopeType))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;

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
                if (this.ScopeType != null) hashCode = hashCode * 59 + this.ScopeType.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
