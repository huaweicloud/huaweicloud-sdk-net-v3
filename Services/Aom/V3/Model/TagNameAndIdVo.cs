using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TagNameAndIdVo 
    {

        /// <summary>
        /// 标签Id
        /// </summary>
        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TagId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TagName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagNameAndIdVo {\n");
            sb.Append("  tagId: ").Append(TagId).Append("\n");
            sb.Append("  tagName: ").Append(TagName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagNameAndIdVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagNameAndIdVo input)
        {
            if (input == null) return false;
            if (this.TagId != input.TagId || (this.TagId != null && !this.TagId.Equals(input.TagId))) return false;
            if (this.TagName != input.TagName || (this.TagName != null && !this.TagName.Equals(input.TagName))) return false;

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
                if (this.TagId != null) hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.TagName != null) hashCode = hashCode * 59 + this.TagName.GetHashCode();
                return hashCode;
            }
        }
    }
}
