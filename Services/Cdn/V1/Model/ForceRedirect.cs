using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ForceRedirect 
    {

        /// <summary>
        /// 强制跳转开关。1打开。0关闭。
        /// </summary>
        [JsonProperty("switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Switch { get; set; }

        /// <summary>
        /// 强制跳转类型。http：强制跳转HTTP。https：强制跳转HTTPS。
        /// </summary>
        [JsonProperty("redirect_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForceRedirect {\n");
            sb.Append("  Switch: ").Append(Switch).Append("\n");
            sb.Append("  redirectType: ").Append(RedirectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForceRedirect);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ForceRedirect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Switch == input.Switch ||
                    (this.Switch != null &&
                    this.Switch.Equals(input.Switch))
                ) && 
                (
                    this.RedirectType == input.RedirectType ||
                    (this.RedirectType != null &&
                    this.RedirectType.Equals(input.RedirectType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Switch != null)
                    hashCode = hashCode * 59 + this.Switch.GetHashCode();
                if (this.RedirectType != null)
                    hashCode = hashCode * 59 + this.RedirectType.GetHashCode();
                return hashCode;
            }
        }
    }
}
