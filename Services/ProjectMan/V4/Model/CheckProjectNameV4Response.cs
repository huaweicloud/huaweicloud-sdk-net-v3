using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckProjectNameV4Response : SdkResponse
    {

        /// <summary>
        /// 是否存在相同的项目名称 true 存在， false 不存在
        /// </summary>
        [JsonProperty("exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckProjectNameV4Response {\n");
            sb.Append("  exist: ").Append(Exist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckProjectNameV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckProjectNameV4Response input)
        {
            if (input == null) return false;
            if (this.Exist != input.Exist || (this.Exist != null && !this.Exist.Equals(input.Exist))) return false;

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
                if (this.Exist != null) hashCode = hashCode * 59 + this.Exist.GetHashCode();
                return hashCode;
            }
        }
    }
}
