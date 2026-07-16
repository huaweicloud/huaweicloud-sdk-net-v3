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
    public class BillingResource 
    {

        /// <summary>
        /// **参数解释：** 计费码。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释：** 计费单元。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("unit_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingResource {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  unitNum: ").Append(UnitNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillingResource input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.UnitNum != input.UnitNum || (this.UnitNum != null && !this.UnitNum.Equals(input.UnitNum))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.UnitNum != null) hashCode = hashCode * 59 + this.UnitNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
