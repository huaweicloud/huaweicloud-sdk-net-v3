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
    /// Request Object
    /// </summary>
    public class DeleteTemplateGroupCollectionRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 模板组集合id 
        /// </summary>
        [SDKProperty("group_collection_id", IsQuery = true)]
        [JsonProperty("group_collection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupCollectionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTemplateGroupCollectionRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  groupCollectionId: ").Append(GroupCollectionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTemplateGroupCollectionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTemplateGroupCollectionRequest input)
        {
            if (input == null) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.GroupCollectionId != input.GroupCollectionId || (this.GroupCollectionId != null && !this.GroupCollectionId.Equals(input.GroupCollectionId))) return false;

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
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.GroupCollectionId != null) hashCode = hashCode * 59 + this.GroupCollectionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
