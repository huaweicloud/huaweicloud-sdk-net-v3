using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 各项内容审核结果。
    /// </summary>
    public class CategorySuggestions 
    {

        /// <summary>
        /// 政治人物审核。
        /// </summary>
        [JsonProperty("politics", NullValueHandling = NullValueHandling.Ignore)]
        public string Politics { get; set; }

        /// <summary>
        /// 暴恐内容审核。
        /// </summary>
        [JsonProperty("terrorism", NullValueHandling = NullValueHandling.Ignore)]
        public string Terrorism { get; set; }

        /// <summary>
        /// 情色内容审核。
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public string Porn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategorySuggestions {\n");
            sb.Append("  politics: ").Append(Politics).Append("\n");
            sb.Append("  terrorism: ").Append(Terrorism).Append("\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CategorySuggestions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CategorySuggestions input)
        {
            if (input == null) return false;
            if (this.Politics != input.Politics || (this.Politics != null && !this.Politics.Equals(input.Politics))) return false;
            if (this.Terrorism != input.Terrorism || (this.Terrorism != null && !this.Terrorism.Equals(input.Terrorism))) return false;
            if (this.Porn != input.Porn || (this.Porn != null && !this.Porn.Equals(input.Porn))) return false;

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
                if (this.Politics != null) hashCode = hashCode * 59 + this.Politics.GetHashCode();
                if (this.Terrorism != null) hashCode = hashCode * 59 + this.Terrorism.GetHashCode();
                if (this.Porn != null) hashCode = hashCode * 59 + this.Porn.GetHashCode();
                return hashCode;
            }
        }
    }
}
