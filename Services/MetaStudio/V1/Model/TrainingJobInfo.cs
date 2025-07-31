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
    /// 任务信息
    /// </summary>
    public class TrainingJobInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobType JobType { get; set; }
        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 用户id。
        /// </summary>
        [JsonProperty("app_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUserId { get; set; }

        /// <summary>
        /// 音色名称。该名称会作为资产库中音色模型资产名称。
        /// </summary>
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }

        /// <summary>
        /// 性别。 * FEMALE: 女性 * MALE: 是男性
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 语言。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public JobState State { get; set; }
        /// <summary>
        /// 本次任务中该状态出现的次数
        /// </summary>
        [JsonProperty("reject_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? RejectTimes { get; set; }

        /// <summary>
        /// 当任务状态为成功时呈现,音色模型在资产库中的id。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 当任务失败时呈现,失败错误码。
        /// </summary>
        [JsonProperty("job_failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string JobFailedCode { get; set; }

        /// <summary>
        /// 当任务失败时呈现,失败原因。
        /// </summary>
        [JsonProperty("job_failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string JobFailedReason { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 任务状态更新时间。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastupdateTime { get; set; }

        /// <summary>
        /// 用户授权书连接。
        /// </summary>
        [JsonProperty("voice_authorization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAuthorizationUrl { get; set; }

        /// <summary>
        /// 用户原始输入数据url。
        /// </summary>
        [JsonProperty("training_input_source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingInputSourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public CreateType CreateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public JobTag Tag { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 形象制作任务id
        /// </summary>
        [JsonProperty("dhtms_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DhtmsJobId { get; set; }

        /// <summary>
        /// 批次名称
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allocated_resource", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceTrainingAllocatedResource AllocatedResource { get; set; }

        /// <summary>
        /// 模型输出语言类型
        /// </summary>
        [JsonProperty("output_language", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputLanguage { get; set; }

        /// <summary>
        /// 任务是否重做
        /// </summary>
        [JsonProperty("is_remake", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRemake { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assess_result", NullValueHandling = NullValueHandling.Ignore)]
        public AssessResult AssessResult { get; set; }

        /// <summary>
        /// 是否是按需任务
        /// </summary>
        [JsonProperty("is_ondemand_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOndemandResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingJobInfo {\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  appUserId: ").Append(AppUserId).Append("\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  rejectTimes: ").Append(RejectTimes).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  jobFailedCode: ").Append(JobFailedCode).Append("\n");
            sb.Append("  jobFailedReason: ").Append(JobFailedReason).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("  voiceAuthorizationUrl: ").Append(VoiceAuthorizationUrl).Append("\n");
            sb.Append("  trainingInputSourceUrl: ").Append(TrainingInputSourceUrl).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  dhtmsJobId: ").Append(DhtmsJobId).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  allocatedResource: ").Append(AllocatedResource).Append("\n");
            sb.Append("  outputLanguage: ").Append(OutputLanguage).Append("\n");
            sb.Append("  isRemake: ").Append(IsRemake).Append("\n");
            sb.Append("  assessResult: ").Append(AssessResult).Append("\n");
            sb.Append("  isOndemandResource: ").Append(IsOndemandResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrainingJobInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrainingJobInfo input)
        {
            if (input == null) return false;
            if (this.JobType != input.JobType) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.AppUserId != input.AppUserId || (this.AppUserId != null && !this.AppUserId.Equals(input.AppUserId))) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.State != input.State) return false;
            if (this.RejectTimes != input.RejectTimes || (this.RejectTimes != null && !this.RejectTimes.Equals(input.RejectTimes))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.JobFailedCode != input.JobFailedCode || (this.JobFailedCode != null && !this.JobFailedCode.Equals(input.JobFailedCode))) return false;
            if (this.JobFailedReason != input.JobFailedReason || (this.JobFailedReason != null && !this.JobFailedReason.Equals(input.JobFailedReason))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;
            if (this.VoiceAuthorizationUrl != input.VoiceAuthorizationUrl || (this.VoiceAuthorizationUrl != null && !this.VoiceAuthorizationUrl.Equals(input.VoiceAuthorizationUrl))) return false;
            if (this.TrainingInputSourceUrl != input.TrainingInputSourceUrl || (this.TrainingInputSourceUrl != null && !this.TrainingInputSourceUrl.Equals(input.TrainingInputSourceUrl))) return false;
            if (this.CreateType != input.CreateType) return false;
            if (this.Tag != input.Tag) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.DhtmsJobId != input.DhtmsJobId || (this.DhtmsJobId != null && !this.DhtmsJobId.Equals(input.DhtmsJobId))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.AllocatedResource != input.AllocatedResource || (this.AllocatedResource != null && !this.AllocatedResource.Equals(input.AllocatedResource))) return false;
            if (this.OutputLanguage != input.OutputLanguage || (this.OutputLanguage != null && !this.OutputLanguage.Equals(input.OutputLanguage))) return false;
            if (this.IsRemake != input.IsRemake || (this.IsRemake != null && !this.IsRemake.Equals(input.IsRemake))) return false;
            if (this.AssessResult != input.AssessResult || (this.AssessResult != null && !this.AssessResult.Equals(input.AssessResult))) return false;
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
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.AppUserId != null) hashCode = hashCode * 59 + this.AppUserId.GetHashCode();
                if (this.VoiceName != null) hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.RejectTimes != null) hashCode = hashCode * 59 + this.RejectTimes.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.JobFailedCode != null) hashCode = hashCode * 59 + this.JobFailedCode.GetHashCode();
                if (this.JobFailedReason != null) hashCode = hashCode * 59 + this.JobFailedReason.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                if (this.VoiceAuthorizationUrl != null) hashCode = hashCode * 59 + this.VoiceAuthorizationUrl.GetHashCode();
                if (this.TrainingInputSourceUrl != null) hashCode = hashCode * 59 + this.TrainingInputSourceUrl.GetHashCode();
                hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.DhtmsJobId != null) hashCode = hashCode * 59 + this.DhtmsJobId.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.AllocatedResource != null) hashCode = hashCode * 59 + this.AllocatedResource.GetHashCode();
                if (this.OutputLanguage != null) hashCode = hashCode * 59 + this.OutputLanguage.GetHashCode();
                if (this.IsRemake != null) hashCode = hashCode * 59 + this.IsRemake.GetHashCode();
                if (this.AssessResult != null) hashCode = hashCode * 59 + this.AssessResult.GetHashCode();
                if (this.IsOndemandResource != null) hashCode = hashCode * 59 + this.IsOndemandResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
