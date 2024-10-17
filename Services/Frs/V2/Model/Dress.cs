using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Dress 
    {

        /// <summary>
        /// 是否带眼镜： • yes：带眼镜 • dark：带墨镜 • none：未戴眼镜 • unknown：未知
        /// </summary>
        [JsonProperty("glass", NullValueHandling = NullValueHandling.Ignore)]
        public string Glass { get; set; }

        /// <summary>
        /// 是否戴帽子： • yes：戴帽子 • none：未戴帽子 • unknown：未知
        /// </summary>
        [JsonProperty("hat", NullValueHandling = NullValueHandling.Ignore)]
        public string Hat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dress {\n");
            sb.Append("  glass: ").Append(Glass).Append("\n");
            sb.Append("  hat: ").Append(Hat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Dress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Dress input)
        {
            if (input == null) return false;
            if (this.Glass != input.Glass || (this.Glass != null && !this.Glass.Equals(input.Glass))) return false;
            if (this.Hat != input.Hat || (this.Hat != null && !this.Hat.Equals(input.Hat))) return false;

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
                if (this.Glass != null) hashCode = hashCode * 59 + this.Glass.GetHashCode();
                if (this.Hat != null) hashCode = hashCode * 59 + this.Hat.GetHashCode();
                return hashCode;
            }
        }
    }
}
