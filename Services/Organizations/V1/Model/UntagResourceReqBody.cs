using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// UntagResource 操作的请求体。
    /// </summary>
    public class UntagResourceReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UntagResourceReqBody {\n");
            sb.Append("  tagKeys: ").Append(TagKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UntagResourceReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UntagResourceReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagKeys == input.TagKeys ||
                    this.TagKeys != null &&
                    input.TagKeys != null &&
                    this.TagKeys.SequenceEqual(input.TagKeys)
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
                if (this.TagKeys != null)
                    hashCode = hashCode * 59 + this.TagKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
