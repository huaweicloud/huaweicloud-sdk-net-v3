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
    /// Request Object
    /// </summary>
    public class ListOfficialTemplateRequest 
    {

        /// <summary>
        /// 检索的模板的名字模糊查询
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 分页页码， 表示从此页开始查询
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <summary>
        /// 每页显示的条目数量，page_size小于等于100
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfficialTemplateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOfficialTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOfficialTemplateRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
