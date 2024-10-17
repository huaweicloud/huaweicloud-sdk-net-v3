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
    public class ModifyTemplateGroupCollection 
    {

        /// <summary>
        /// 模板组集合名称&lt;br/&gt; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板组集合ID&lt;br/&gt; 
        /// </summary>
        [JsonProperty("collection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionId { get; set; }

        /// <summary>
        /// 模板组集合介绍&lt;br/&gt; 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板组列表&lt;br/&gt; 
        /// </summary>
        [JsonProperty("template_group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateGroupList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTemplateGroupCollection {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  collectionId: ").Append(CollectionId).Append("\n");
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
            return this.Equals(input as ModifyTemplateGroupCollection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTemplateGroupCollection input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CollectionId != input.CollectionId || (this.CollectionId != null && !this.CollectionId.Equals(input.CollectionId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.TemplateGroupList != input.TemplateGroupList || (this.TemplateGroupList != null && input.TemplateGroupList != null && !this.TemplateGroupList.SequenceEqual(input.TemplateGroupList))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CollectionId != null) hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TemplateGroupList != null) hashCode = hashCode * 59 + this.TemplateGroupList.GetHashCode();
                return hashCode;
            }
        }
    }
}
