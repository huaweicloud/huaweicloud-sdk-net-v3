using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFtArtifactsRequest 
    {

        /// <summary>
        /// 训练作业ID。获取方法请参见[查询训练作业列表](ListTrainingJobs.xml)。
        /// </summary>
        [SDKProperty("training_job_id", IsPath = true)]
        [JsonProperty("training_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// 步数。
        /// </summary>
        [SDKProperty("steps", IsQuery = true)]
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Steps { get; set; }

        /// <summary>
        /// 轮数。
        /// </summary>
        [SDKProperty("epoch", IsQuery = true)]
        [JsonProperty("epoch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Epoch { get; set; }

        /// <summary>
        /// loss值。
        /// </summary>
        [SDKProperty("loss", IsQuery = true)]
        [JsonProperty("loss", NullValueHandling = NullValueHandling.Ignore)]
        public double? Loss { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否按照创建时间排序。
        /// </summary>
        [SDKProperty("order_by_create_time_asc", IsQuery = true)]
        [JsonProperty("order_by_create_time_asc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderByCreateTimeAsc { get; set; }

        /// <summary>
        /// 返回的数据条目数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 数据条目偏移量。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFtArtifactsRequest {\n");
            sb.Append("  trainingJobId: ").Append(TrainingJobId).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  epoch: ").Append(Epoch).Append("\n");
            sb.Append("  loss: ").Append(Loss).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  orderByCreateTimeAsc: ").Append(OrderByCreateTimeAsc).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFtArtifactsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFtArtifactsRequest input)
        {
            if (input == null) return false;
            if (this.TrainingJobId != input.TrainingJobId || (this.TrainingJobId != null && !this.TrainingJobId.Equals(input.TrainingJobId))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && !this.Steps.Equals(input.Steps))) return false;
            if (this.Epoch != input.Epoch || (this.Epoch != null && !this.Epoch.Equals(input.Epoch))) return false;
            if (this.Loss != input.Loss || (this.Loss != null && !this.Loss.Equals(input.Loss))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.OrderByCreateTimeAsc != input.OrderByCreateTimeAsc || (this.OrderByCreateTimeAsc != null && !this.OrderByCreateTimeAsc.Equals(input.OrderByCreateTimeAsc))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.TrainingJobId != null) hashCode = hashCode * 59 + this.TrainingJobId.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Epoch != null) hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.Loss != null) hashCode = hashCode * 59 + this.Loss.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrderByCreateTimeAsc != null) hashCode = hashCode * 59 + this.OrderByCreateTimeAsc.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
