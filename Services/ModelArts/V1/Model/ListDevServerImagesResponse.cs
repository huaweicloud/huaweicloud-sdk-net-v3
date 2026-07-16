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
    public class ListDevServerImagesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：当前页数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public int? Current { get; set; }

        /// <summary>
        /// **参数解释**：Lite Server镜像列表。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerImageResponse> Data { get; set; }

        /// <summary>
        /// **参数解释**：总的页数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pages { get; set; }

        /// <summary>
        /// **参数解释**：每一页的数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// **参数解释**：总的记录数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDevServerImagesResponse {\n");
            sb.Append("  current: ").Append(Current).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  pages: ").Append(Pages).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDevServerImagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDevServerImagesResponse input)
        {
            if (input == null) return false;
            if (this.Current != input.Current || (this.Current != null && !this.Current.Equals(input.Current))) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;
            if (this.Pages != input.Pages || (this.Pages != null && !this.Pages.Equals(input.Pages))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Current != null) hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Pages != null) hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
