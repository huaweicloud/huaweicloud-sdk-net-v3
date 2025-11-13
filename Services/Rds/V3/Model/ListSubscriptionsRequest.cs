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
    /// Request Object
    /// </summary>
    public class ListSubscriptionsRequest 
    {

        /// <summary>
        /// 语言。默认en-us。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 发布id。不为空则查询该发布下的订阅；为空（null）则查询实例本地订阅。
        /// </summary>
        [SDKProperty("publication_id", IsQuery = true)]
        [JsonProperty("publication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationId { get; set; }

        /// <summary>
        /// 订阅服务器来源  true：订阅服务器为云上实例  false：订阅服务器非云上实例  不传该参数（null）：全部订阅
        /// </summary>
        [SDKProperty("is_cloud", IsQuery = true)]
        [JsonProperty("is_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCloud { get; set; }

        /// <summary>
        /// 发布名（模糊匹配）
        /// </summary>
        [SDKProperty("publication_name", IsQuery = true)]
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }

        /// <summary>
        /// 订阅数据库名（模糊匹配）
        /// </summary>
        [SDKProperty("subscription_db_name", IsQuery = true)]
        [JsonProperty("subscription_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionDbName { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  publicationId: ").Append(PublicationId).Append("\n");
            sb.Append("  isCloud: ").Append(IsCloud).Append("\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("  subscriptionDbName: ").Append(SubscriptionDbName).Append("\n");
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
            return this.Equals(input as ListSubscriptionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.PublicationId != input.PublicationId || (this.PublicationId != null && !this.PublicationId.Equals(input.PublicationId))) return false;
            if (this.IsCloud != input.IsCloud || (this.IsCloud != null && !this.IsCloud.Equals(input.IsCloud))) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;
            if (this.SubscriptionDbName != input.SubscriptionDbName || (this.SubscriptionDbName != null && !this.SubscriptionDbName.Equals(input.SubscriptionDbName))) return false;
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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.PublicationId != null) hashCode = hashCode * 59 + this.PublicationId.GetHashCode();
                if (this.IsCloud != null) hashCode = hashCode * 59 + this.IsCloud.GetHashCode();
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                if (this.SubscriptionDbName != null) hashCode = hashCode * 59 + this.SubscriptionDbName.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
