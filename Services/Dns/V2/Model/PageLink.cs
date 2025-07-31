using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// **参数解释：** 指向当前页或者其他页的链接。当查询需要分页时，需要包含一个next链接指向下一页。 **取值范围：** 不涉及。
    /// </summary>
    public class PageLink 
    {

        /// <summary>
        /// **参数解释：** 当前页面的链接。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }

        /// <summary>
        /// **参数解释：** 下一页的链接。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageLink {\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("  next: ").Append(Next).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageLink);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageLink input)
        {
            if (input == null) return false;
            if (this.Self != input.Self || (this.Self != null && !this.Self.Equals(input.Self))) return false;
            if (this.Next != input.Next || (this.Next != null && !this.Next.Equals(input.Next))) return false;

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
                if (this.Self != null) hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Next != null) hashCode = hashCode * 59 + this.Next.GetHashCode();
                return hashCode;
            }
        }
    }
}
