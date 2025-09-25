using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckGroupDeployKeyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 部署秘钥在上层代码组或项目是否配置。 **取值范围：** - true，上层代码组或项目已配置该密钥。 - false，上层代码组或项目未配置该密钥。
        /// </summary>
        [JsonProperty("exists", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exists { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckGroupDeployKeyResponse {\n");
            sb.Append("  exists: ").Append(Exists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckGroupDeployKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckGroupDeployKeyResponse input)
        {
            if (input == null) return false;
            if (this.Exists != input.Exists || (this.Exists != null && !this.Exists.Equals(input.Exists))) return false;

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
                if (this.Exists != null) hashCode = hashCode * 59 + this.Exists.GetHashCode();
                return hashCode;
            }
        }
    }
}
