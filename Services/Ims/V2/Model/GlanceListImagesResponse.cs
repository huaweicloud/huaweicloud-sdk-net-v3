using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GlanceListImagesResponse : SdkResponse
    {

        /// <summary>
        /// 查询首页的URL。
        /// </summary>
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public string First { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlanceShowImageListResponseBody> Images { get; set; }

        /// <summary>
        /// 描述镜像列表模式的URL。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 查询下一页的URL。当查询镜像列表最后一页时，不存在next。
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceListImagesResponse {\n");
            sb.Append("  first: ").Append(First).Append("\n");
            sb.Append("  images: ").Append(Images).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  next: ").Append(Next).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceListImagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceListImagesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
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
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                return hashCode;
            }
        }
    }
}
