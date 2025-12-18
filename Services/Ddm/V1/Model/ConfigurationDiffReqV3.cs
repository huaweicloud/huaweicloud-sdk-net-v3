using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationDiffReqV3 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diff_para", NullValueHandling = NullValueHandling.Ignore)]
        public ParaGroupDiff DiffPara { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationDiffReqV3 {\n");
            sb.Append("  diffPara: ").Append(DiffPara).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationDiffReqV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationDiffReqV3 input)
        {
            if (input == null) return false;
            if (this.DiffPara != input.DiffPara || (this.DiffPara != null && !this.DiffPara.Equals(input.DiffPara))) return false;

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
                if (this.DiffPara != null) hashCode = hashCode * 59 + this.DiffPara.GetHashCode();
                return hashCode;
            }
        }
    }
}
