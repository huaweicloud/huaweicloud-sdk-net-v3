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
    public class DeleteHbaConfRequestBody 
    {

        /// <summary>
        /// **参数解释**: 需要删除的hba配置信息。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hba_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<HbaConfOption> HbaConfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHbaConfRequestBody {\n");
            sb.Append("  hbaConfs: ").Append(HbaConfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHbaConfRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteHbaConfRequestBody input)
        {
            if (input == null) return false;
            if (this.HbaConfs != input.HbaConfs || (this.HbaConfs != null && input.HbaConfs != null && !this.HbaConfs.SequenceEqual(input.HbaConfs))) return false;

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
                if (this.HbaConfs != null) hashCode = hashCode * 59 + this.HbaConfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
