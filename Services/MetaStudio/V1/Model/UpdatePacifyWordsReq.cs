using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 修改安抚话术请求。
    /// </summary>
    public class UpdatePacifyWordsReq 
    {

        /// <summary>
        /// 安抚话术。
        /// </summary>
        [JsonProperty("pacify_words", NullValueHandling = NullValueHandling.Ignore)]
        public string PacifyWords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePacifyWordsReq {\n");
            sb.Append("  pacifyWords: ").Append(PacifyWords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePacifyWordsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePacifyWordsReq input)
        {
            if (input == null) return false;
            if (this.PacifyWords != input.PacifyWords || (this.PacifyWords != null && !this.PacifyWords.Equals(input.PacifyWords))) return false;

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
                if (this.PacifyWords != null) hashCode = hashCode * 59 + this.PacifyWords.GetHashCode();
                return hashCode;
            }
        }
    }
}
