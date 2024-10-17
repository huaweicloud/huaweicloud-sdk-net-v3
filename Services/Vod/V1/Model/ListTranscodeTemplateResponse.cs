using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTranscodeTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 模板组信息&lt;br/&gt; 
        /// </summary>
        [JsonProperty("template_group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransTemplateRsp> TemplateGroupList { get; set; }

        /// <summary>
        /// 总记录条数&lt;br/&gt; 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTranscodeTemplateResponse {\n");
            sb.Append("  templateGroupList: ").Append(TemplateGroupList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTranscodeTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTranscodeTemplateResponse input)
        {
            if (input == null) return false;
            if (this.TemplateGroupList != input.TemplateGroupList || (this.TemplateGroupList != null && input.TemplateGroupList != null && !this.TemplateGroupList.SequenceEqual(input.TemplateGroupList))) return false;
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
                if (this.TemplateGroupList != null) hashCode = hashCode * 59 + this.TemplateGroupList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
