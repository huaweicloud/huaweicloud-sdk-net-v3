using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 返回值
    /// </summary>
    public class ListOfficialTemplateResult 
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalSize { get; set; }

        /// <summary>
        /// 模版列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateList> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfficialTemplateResult {\n");
            sb.Append("  totalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOfficialTemplateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOfficialTemplateResult input)
        {
            if (input == null) return false;
            if (this.TotalSize != input.TotalSize || (this.TotalSize != null && !this.TotalSize.Equals(input.TotalSize))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;

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
                if (this.TotalSize != null) hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
