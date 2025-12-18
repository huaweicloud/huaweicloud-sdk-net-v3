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
    public class ConfigurationUpdateReqV3 
    {

        /// <summary>
        /// **参数解释**：  修改参数组相关信息。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("update_para", NullValueHandling = NullValueHandling.Ignore)]
        public Object UpdatePara { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationUpdateReqV3 {\n");
            sb.Append("  updatePara: ").Append(UpdatePara).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationUpdateReqV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationUpdateReqV3 input)
        {
            if (input == null) return false;
            if (this.UpdatePara != input.UpdatePara || (this.UpdatePara != null && !this.UpdatePara.Equals(input.UpdatePara))) return false;

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
                if (this.UpdatePara != null) hashCode = hashCode * 59 + this.UpdatePara.GetHashCode();
                return hashCode;
            }
        }
    }
}
