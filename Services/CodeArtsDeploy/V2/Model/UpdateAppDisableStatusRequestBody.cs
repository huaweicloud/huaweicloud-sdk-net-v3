using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 禁用/取消禁用应用请求体
    /// </summary>
    public class UpdateAppDisableStatusRequestBody 
    {

        /// <summary>
        /// 是否禁用， true禁用， false取消禁用
        /// </summary>
        [JsonProperty("is_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppDisableStatusRequestBody {\n");
            sb.Append("  isDisable: ").Append(IsDisable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAppDisableStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAppDisableStatusRequestBody input)
        {
            if (input == null) return false;
            if (this.IsDisable != input.IsDisable || (this.IsDisable != null && !this.IsDisable.Equals(input.IsDisable))) return false;

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
                if (this.IsDisable != null) hashCode = hashCode * 59 + this.IsDisable.GetHashCode();
                return hashCode;
            }
        }
    }
}
