using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProgressDetailV2 
    {

        /// <summary>
        /// **参数解释:** 检查进度百分比。 **取值范围:** 检查中、检查成功时，为0%-100%； 检查失败、任务中止、未检查时，为null。
        /// </summary>
        [JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string Ratio { get; set; }

        /// <summary>
        /// **参数解释:** 检查执行状态。 **取值范围:** - running：检查中。 - success：检查成功。 - null：检查失败、任务中止、未检查。
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressDetailV2 {\n");
            sb.Append("  ratio: ").Append(Ratio).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgressDetailV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgressDetailV2 input)
        {
            if (input == null) return false;
            if (this.Ratio != input.Ratio || (this.Ratio != null && !this.Ratio.Equals(input.Ratio))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;

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
                if (this.Ratio != null) hashCode = hashCode * 59 + this.Ratio.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                return hashCode;
            }
        }
    }
}
