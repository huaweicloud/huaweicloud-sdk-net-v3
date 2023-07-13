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
    /// 
    /// </summary>
    public class TemplateGroupCollection 
    {

        /// <summary>
        /// 模板组集合id&lt;br/&gt; 
        /// </summary>
        [JsonProperty("group_collection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupCollectionId { get; set; }

        /// <summary>
        /// 模板组集合名称&lt;br/&gt; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板介绍&lt;br/&gt; 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 转码组列表&lt;br/&gt; 
        /// </summary>
        [JsonProperty("template_group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateGroup> TemplateGroupList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateGroupCollection {\n");
            sb.Append("  groupCollectionId: ").Append(GroupCollectionId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  templateGroupList: ").Append(TemplateGroupList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateGroupCollection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateGroupCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupCollectionId == input.GroupCollectionId ||
                    (this.GroupCollectionId != null &&
                    this.GroupCollectionId.Equals(input.GroupCollectionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TemplateGroupList == input.TemplateGroupList ||
                    this.TemplateGroupList != null &&
                    input.TemplateGroupList != null &&
                    this.TemplateGroupList.SequenceEqual(input.TemplateGroupList)
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
                if (this.GroupCollectionId != null)
                    hashCode = hashCode * 59 + this.GroupCollectionId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TemplateGroupList != null)
                    hashCode = hashCode * 59 + this.TemplateGroupList.GetHashCode();
                return hashCode;
            }
        }
    }
}
