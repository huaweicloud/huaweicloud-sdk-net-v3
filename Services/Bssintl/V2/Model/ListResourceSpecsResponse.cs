using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResourceSpecsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// |参数名称：资源规格信息列表| |参数的约束及描述：资源规格信息列表|
        /// </summary>
        [JsonProperty("cloud_service_basics", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloudServiceBasic> CloudServiceBasics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceSpecsResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  cloudServiceBasics: ").Append(CloudServiceBasics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceSpecsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceSpecsResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.CloudServiceBasics != input.CloudServiceBasics || (this.CloudServiceBasics != null && input.CloudServiceBasics != null && !this.CloudServiceBasics.SequenceEqual(input.CloudServiceBasics))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.CloudServiceBasics != null) hashCode = hashCode * 59 + this.CloudServiceBasics.GetHashCode();
                return hashCode;
            }
        }
    }
}
