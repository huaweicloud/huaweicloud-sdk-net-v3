using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TagsVO 
    {

        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TagId { get; set; }

        /// <summary>
        /// 标签键
        /// </summary>
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("tag_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TagValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagsVO {\n");
            sb.Append("  tagId: ").Append(TagId).Append("\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("  tagValue: ").Append(TagValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagsVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.TagKey == input.TagKey ||
                    (this.TagKey != null &&
                    this.TagKey.Equals(input.TagKey))
                ) && 
                (
                    this.TagValue == input.TagValue ||
                    (this.TagValue != null &&
                    this.TagValue.Equals(input.TagValue))
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
                if (this.TagId != null)
                    hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.TagKey != null)
                    hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                if (this.TagValue != null)
                    hashCode = hashCode * 59 + this.TagValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
