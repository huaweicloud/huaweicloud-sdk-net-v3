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
    /// **参数解释**  小版本升级成功后，确认是否完成升级请求体。  **约束限制**  不涉及。
    /// </summary>
    public class UpgradeDbVersionFinalConfirmRequestBody 
    {

        /// <summary>
        /// **参数解释**  要进行的操作。confirm表示确认完成升级，rollback表示要回滚至原始版本  **取值范围**  confirm,rollback  **约束限制**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**  回滚时是否强制回滚  **取值范围**  true,false  **约束限制**  不涉及  **默认取值**  false
        /// </summary>
        [JsonProperty("force_rollback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRollback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeDbVersionFinalConfirmRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  forceRollback: ").Append(ForceRollback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeDbVersionFinalConfirmRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeDbVersionFinalConfirmRequestBody input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.ForceRollback != input.ForceRollback || (this.ForceRollback != null && !this.ForceRollback.Equals(input.ForceRollback))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ForceRollback != null) hashCode = hashCode * 59 + this.ForceRollback.GetHashCode();
                return hashCode;
            }
        }
    }
}
