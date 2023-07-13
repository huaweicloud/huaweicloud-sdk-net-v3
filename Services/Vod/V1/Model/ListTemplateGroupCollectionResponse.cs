using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTemplateGroupCollectionResponse : SdkResponse
    {

        /// <summary>
        /// 模板组集合信息&lt;br/&gt; 
        /// </summary>
        [JsonProperty("template_group_collection_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateGroupCollection> TemplateGroupCollectionList { get; set; }

        /// <summary>
        /// 总记录条数&lt;br/&gt; 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplateGroupCollectionResponse {\n");
            sb.Append("  templateGroupCollectionList: ").Append(TemplateGroupCollectionList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTemplateGroupCollectionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTemplateGroupCollectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateGroupCollectionList == input.TemplateGroupCollectionList ||
                    this.TemplateGroupCollectionList != null &&
                    input.TemplateGroupCollectionList != null &&
                    this.TemplateGroupCollectionList.SequenceEqual(input.TemplateGroupCollectionList)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.TemplateGroupCollectionList != null)
                    hashCode = hashCode * 59 + this.TemplateGroupCollectionList.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
