using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAppTemplatesRequest 
    {

        /// <summary>
        /// 本次查询起始位置，默认值0
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 本次查询最大返回的数据条数，最大值500，默认值100
        /// </summary>
        [SDKProperty("maxitems", IsQuery = true)]
        [JsonProperty("maxitems", NullValueHandling = NullValueHandling.Ignore)]
        public string Maxitems { get; set; }

        /// <summary>
        /// 模板执行运行时
        /// </summary>
        [SDKProperty("runtime", IsQuery = true)]
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        /// <summary>
        /// 模板类别
        /// </summary>
        [SDKProperty("category", IsQuery = true)]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 模板语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAppTemplatesRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  maxitems: ").Append(Maxitems).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAppTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAppTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Maxitems != input.Maxitems || (this.Maxitems != null && !this.Maxitems.Equals(input.Maxitems))) return false;
            if (this.Runtime != input.Runtime || (this.Runtime != null && !this.Runtime.Equals(input.Runtime))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Maxitems != null) hashCode = hashCode * 59 + this.Maxitems.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
