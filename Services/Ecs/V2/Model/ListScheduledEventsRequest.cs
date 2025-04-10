using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScheduledEventsRequest 
    {

        /// <summary>
        /// 从marker指定的事件的下一条数据开始查询。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 事件状态
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> State { get; set; }

        /// <summary>
        /// 事件发布开始时间
        /// </summary>
        [SDKProperty("publish_since", IsQuery = true)]
        [JsonProperty("publish_since", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishSince { get; set; }

        /// <summary>
        /// 事件发布截至时间
        /// </summary>
        [SDKProperty("publish_until", IsQuery = true)]
        [JsonProperty("publish_until", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishUntil { get; set; }

        /// <summary>
        /// 每页显示的条目数量
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
            sb.Append("class ListScheduledEventsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  publishSince: ").Append(PublishSince).Append("\n");
            sb.Append("  publishUntil: ").Append(PublishUntil).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduledEventsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduledEventsRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && input.InstanceId != null && !this.InstanceId.SequenceEqual(input.InstanceId))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.State != input.State || (this.State != null && input.State != null && !this.State.SequenceEqual(input.State))) return false;
            if (this.PublishSince != input.PublishSince || (this.PublishSince != null && !this.PublishSince.Equals(input.PublishSince))) return false;
            if (this.PublishUntil != input.PublishUntil || (this.PublishUntil != null && !this.PublishUntil.Equals(input.PublishUntil))) return false;
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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PublishSince != null) hashCode = hashCode * 59 + this.PublishSince.GetHashCode();
                if (this.PublishUntil != null) hashCode = hashCode * 59 + this.PublishUntil.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
