using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ViewRow 
    {

        /// <summary>
        /// 视图行，包含多个视图，展示的时候根据实际的长度适配。
        /// </summary>
        [JsonProperty("view_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ViewBase> ViewList { get; set; }

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewRow {\n");
            sb.Append("  viewList: ").Append(ViewList).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ViewRow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ViewRow input)
        {
            if (input == null) return false;
            if (this.ViewList != input.ViewList || (this.ViewList != null && input.ViewList != null && !this.ViewList.SequenceEqual(input.ViewList))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;

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
                if (this.ViewList != null) hashCode = hashCode * 59 + this.ViewList.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }
}
