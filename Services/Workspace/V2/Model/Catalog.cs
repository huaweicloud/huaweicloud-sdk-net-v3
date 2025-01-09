using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 分类信息描述。
    /// </summary>
    public class Catalog 
    {

        /// <summary>
        /// 唯一标识ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分类描述(中文)。
        /// </summary>
        [JsonProperty("catalog_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogZh { get; set; }

        /// <summary>
        /// 分类描述(英文)。
        /// </summary>
        [JsonProperty("catalog_en", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogEn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Catalog {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  catalogZh: ").Append(CatalogZh).Append("\n");
            sb.Append("  catalogEn: ").Append(CatalogEn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Catalog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Catalog input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CatalogZh != input.CatalogZh || (this.CatalogZh != null && !this.CatalogZh.Equals(input.CatalogZh))) return false;
            if (this.CatalogEn != input.CatalogEn || (this.CatalogEn != null && !this.CatalogEn.Equals(input.CatalogEn))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CatalogZh != null) hashCode = hashCode * 59 + this.CatalogZh.GetHashCode();
                if (this.CatalogEn != null) hashCode = hashCode * 59 + this.CatalogEn.GetHashCode();
                return hashCode;
            }
        }
    }
}
