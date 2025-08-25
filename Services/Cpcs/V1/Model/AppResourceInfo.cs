using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AppResourceInfo 
    {

        /// <summary>
        /// 当前租户在cpcs创建的简单应用数量
        /// </summary>
        [JsonProperty("app_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppResourceInfo {\n");
            sb.Append("  appNum: ").Append(AppNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppResourceInfo input)
        {
            if (input == null) return false;
            if (this.AppNum != input.AppNum || (this.AppNum != null && !this.AppNum.Equals(input.AppNum))) return false;

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
                if (this.AppNum != null) hashCode = hashCode * 59 + this.AppNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
