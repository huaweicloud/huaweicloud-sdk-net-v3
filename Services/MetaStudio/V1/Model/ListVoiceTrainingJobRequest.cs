using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListVoiceTrainingJobRequest 
    {

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 过滤创建时间&lt;&#x3D;输入时间的记录。
        /// </summary>
        [SDKProperty("create_until", IsQuery = true)]
        [JsonProperty("create_until", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUntil { get; set; }

        /// <summary>
        /// 过滤创建时间&gt;&#x3D;输入时间的记录。
        /// </summary>
        [SDKProperty("create_since", IsQuery = true)]
        [JsonProperty("create_since", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateSince { get; set; }

        /// <summary>
        /// 过滤更新时间&lt;&#x3D;输入时间的记录。
        /// </summary>
        [SDKProperty("update_until", IsQuery = true)]
        [JsonProperty("update_until", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUntil { get; set; }

        /// <summary>
        /// 过滤更新时间&gt;&#x3D;输入时间的记录。
        /// </summary>
        [SDKProperty("update_since", IsQuery = true)]
        [JsonProperty("update_since", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateSince { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 任务状态，默认所有状态。 可多个状态查询，使用英文逗号分隔。 如state&#x3D;FAILED,WAITING
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 声音名称。
        /// </summary>
        [SDKProperty("voice_name", IsQuery = true)]
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }

        /// <summary>
        /// 任务标签。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 训练类型。 * BASIC: 基础版(20句话) * MIDDLE: 进阶版(100句话) * ADVANCE: 高级版 * THIRD_PARTY: 第三方出门问问训练版 * THIRD_PARTY_LJZN: 第三方逻辑智能训练版 * FLEXUS: Flexus版- --用的是大模型特征提取
        /// </summary>
        [SDKProperty("job_type", IsQuery = true)]
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 批次名称。
        /// </summary>
        [SDKProperty("batch_name", IsQuery = true)]
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 排序字段，当前支持：ceate_time/update_time
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序规则：desc(降序)/asc(升序)
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 是否是按需任务
        /// </summary>
        [SDKProperty("is_ondemand_resource", IsQuery = true)]
        [JsonProperty("is_ondemand_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOndemandResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVoiceTrainingJobRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  createUntil: ").Append(CreateUntil).Append("\n");
            sb.Append("  createSince: ").Append(CreateSince).Append("\n");
            sb.Append("  updateUntil: ").Append(UpdateUntil).Append("\n");
            sb.Append("  updateSince: ").Append(UpdateSince).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  isOndemandResource: ").Append(IsOndemandResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVoiceTrainingJobRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVoiceTrainingJobRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.CreateUntil != input.CreateUntil || (this.CreateUntil != null && !this.CreateUntil.Equals(input.CreateUntil))) return false;
            if (this.CreateSince != input.CreateSince || (this.CreateSince != null && !this.CreateSince.Equals(input.CreateSince))) return false;
            if (this.UpdateUntil != input.UpdateUntil || (this.UpdateUntil != null && !this.UpdateUntil.Equals(input.UpdateUntil))) return false;
            if (this.UpdateSince != input.UpdateSince || (this.UpdateSince != null && !this.UpdateSince.Equals(input.UpdateSince))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.IsOndemandResource != input.IsOndemandResource || (this.IsOndemandResource != null && !this.IsOndemandResource.Equals(input.IsOndemandResource))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.CreateUntil != null) hashCode = hashCode * 59 + this.CreateUntil.GetHashCode();
                if (this.CreateSince != null) hashCode = hashCode * 59 + this.CreateSince.GetHashCode();
                if (this.UpdateUntil != null) hashCode = hashCode * 59 + this.UpdateUntil.GetHashCode();
                if (this.UpdateSince != null) hashCode = hashCode * 59 + this.UpdateSince.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.VoiceName != null) hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.IsOndemandResource != null) hashCode = hashCode * 59 + this.IsOndemandResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
