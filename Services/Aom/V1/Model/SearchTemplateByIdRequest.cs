using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SearchTemplateByIdRequest 
    {

        /// <summary>
        /// 方案id。
        /// </summary>
        [SDKProperty("template_id", IsPath = true)]
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板共享类型，默认为private。可选public private
        /// </summary>
        [SDKProperty("share_type", IsQuery = true)]
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchTemplateByIdRequest {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchTemplateByIdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchTemplateByIdRequest input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.ShareType != input.ShareType || (this.ShareType != null && !this.ShareType.Equals(input.ShareType))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.ShareType != null) hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                return hashCode;
            }
        }
    }
}
