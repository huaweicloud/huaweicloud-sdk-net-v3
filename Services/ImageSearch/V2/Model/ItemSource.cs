using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 数据的元信息，不同数据包含的字段可能不同。
    /// </summary>
    public class ItemSource 
    {

        /// <summary>
        /// 数据描述信息。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 数据自定义字符标签。
        /// </summary>
        [JsonProperty("custom_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CustomTags { get; set; }

        /// <summary>
        /// 数据自定义数值标签。
        /// </summary>
        [JsonProperty("custom_num_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double?> CustomNumTags { get; set; }

        /// <summary>
        /// 数据关键词列表。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemSource {\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  customTags: ").Append(CustomTags).Append("\n");
            sb.Append("  customNumTags: ").Append(CustomNumTags).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.CustomTags == input.CustomTags ||
                    this.CustomTags != null &&
                    input.CustomTags != null &&
                    this.CustomTags.SequenceEqual(input.CustomTags)
                ) && 
                (
                    this.CustomNumTags == input.CustomNumTags ||
                    this.CustomNumTags != null &&
                    input.CustomNumTags != null &&
                    this.CustomNumTags.SequenceEqual(input.CustomNumTags)
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
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
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.CustomTags != null)
                    hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomNumTags != null)
                    hashCode = hashCode * 59 + this.CustomNumTags.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                return hashCode;
            }
        }
    }
}
