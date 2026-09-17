using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释：** 查询缓存的返回结果。
    /// </summary>
    public class ListCacheDatasResposeResult 
    {

        /// <summary>
        /// **参数解释：** 全部字段。
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldVO> Fields { get; set; }

        /// <summary>
        /// **参数解释：** 表头显示字段。
        /// </summary>
        [JsonProperty("visibleFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldVO> VisibleFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCacheDatasResposeResult {\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  visibleFields: ").Append(VisibleFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCacheDatasResposeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCacheDatasResposeResult input)
        {
            if (input == null) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.VisibleFields != input.VisibleFields || (this.VisibleFields != null && input.VisibleFields != null && !this.VisibleFields.SequenceEqual(input.VisibleFields))) return false;

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
                if (this.Fields != null) hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.VisibleFields != null) hashCode = hashCode * 59 + this.VisibleFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
