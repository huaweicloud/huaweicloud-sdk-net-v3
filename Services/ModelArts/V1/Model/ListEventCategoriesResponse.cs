using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEventCategoriesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：事件类型。
        /// </summary>
        [JsonProperty("event-categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventCategoriesResp> EventCategories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventCategoriesResponse {\n");
            sb.Append("  eventCategories: ").Append(EventCategories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventCategoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventCategoriesResponse input)
        {
            if (input == null) return false;
            if (this.EventCategories != input.EventCategories || (this.EventCategories != null && input.EventCategories != null && !this.EventCategories.SequenceEqual(input.EventCategories))) return false;

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
                if (this.EventCategories != null) hashCode = hashCode * 59 + this.EventCategories.GetHashCode();
                return hashCode;
            }
        }
    }
}
