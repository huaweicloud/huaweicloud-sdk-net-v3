using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStagePluginsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 结果集。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("full_stage_plugins_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullStagePluginsRelationVOFullStagePluginsItemList> FullStagePluginsItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStagePluginsResponse {\n");
            sb.Append("  fullStagePluginsItemList: ").Append(FullStagePluginsItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStagePluginsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStagePluginsResponse input)
        {
            if (input == null) return false;
            if (this.FullStagePluginsItemList != input.FullStagePluginsItemList || (this.FullStagePluginsItemList != null && input.FullStagePluginsItemList != null && !this.FullStagePluginsItemList.SequenceEqual(input.FullStagePluginsItemList))) return false;

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
                if (this.FullStagePluginsItemList != null) hashCode = hashCode * 59 + this.FullStagePluginsItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
