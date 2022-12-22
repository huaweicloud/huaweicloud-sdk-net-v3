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
    public class CreateTemplateGroupCollectionResponse : SdkResponse
    {

        /// <summary>
        /// 模板组集合ID&lt;br/&gt; 
        /// </summary>
        [JsonProperty("group_collection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupCollectionId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateGroupCollectionResponse {\n");
            sb.Append("  groupCollectionId: ").Append(GroupCollectionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemplateGroupCollectionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemplateGroupCollectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupCollectionId == input.GroupCollectionId ||
                    (this.GroupCollectionId != null &&
                    this.GroupCollectionId.Equals(input.GroupCollectionId))
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
                return hashCode;
            }
        }
    }
}
