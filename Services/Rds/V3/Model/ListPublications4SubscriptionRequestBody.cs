using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 可选的rds实例列表及其发布。
    /// </summary>
    public class ListPublications4SubscriptionRequestBody 
    {

        /// <summary>
        /// 发布实例id。若不为空，优先查该实例下的发布。
        /// </summary>
        [JsonProperty("publication_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationInstanceId { get; set; }

        /// <summary>
        /// 发布实例名称（模糊匹配）。
        /// </summary>
        [JsonProperty("publication_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationInstanceName { get; set; }

        /// <summary>
        /// 发布名称（模糊匹配）。
        /// </summary>
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，不能为负数，最小值为1，最大值为1000。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublications4SubscriptionRequestBody {\n");
            sb.Append("  publicationInstanceId: ").Append(PublicationInstanceId).Append("\n");
            sb.Append("  publicationInstanceName: ").Append(PublicationInstanceName).Append("\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublications4SubscriptionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublications4SubscriptionRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicationInstanceId != input.PublicationInstanceId || (this.PublicationInstanceId != null && !this.PublicationInstanceId.Equals(input.PublicationInstanceId))) return false;
            if (this.PublicationInstanceName != input.PublicationInstanceName || (this.PublicationInstanceName != null && !this.PublicationInstanceName.Equals(input.PublicationInstanceName))) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.PublicationInstanceId != null) hashCode = hashCode * 59 + this.PublicationInstanceId.GetHashCode();
                if (this.PublicationInstanceName != null) hashCode = hashCode * 59 + this.PublicationInstanceName.GetHashCode();
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
