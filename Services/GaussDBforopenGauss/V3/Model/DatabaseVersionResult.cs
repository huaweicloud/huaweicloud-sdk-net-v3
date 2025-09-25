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
    public class DatabaseVersionResult 
    {

        /// <summary>
        /// **参数解释**： 数据库三位引擎版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("software_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// **参数解释**： 数据库三位引擎版本对应的热补丁信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("hotfixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbHotfixInfoResult> Hotfixes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseVersionResult {\n");
            sb.Append("  softwareVersion: ").Append(SoftwareVersion).Append("\n");
            sb.Append("  hotfixes: ").Append(Hotfixes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseVersionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseVersionResult input)
        {
            if (input == null) return false;
            if (this.SoftwareVersion != input.SoftwareVersion || (this.SoftwareVersion != null && !this.SoftwareVersion.Equals(input.SoftwareVersion))) return false;
            if (this.Hotfixes != input.Hotfixes || (this.Hotfixes != null && input.Hotfixes != null && !this.Hotfixes.SequenceEqual(input.Hotfixes))) return false;

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
                if (this.SoftwareVersion != null) hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                if (this.Hotfixes != null) hashCode = hashCode * 59 + this.Hotfixes.GetHashCode();
                return hashCode;
            }
        }
    }
}
