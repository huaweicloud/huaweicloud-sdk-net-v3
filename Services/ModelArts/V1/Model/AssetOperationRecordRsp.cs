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
    /// **参数解释**：资产操作记录。
    /// </summary>
    public class AssetOperationRecordRsp 
    {
        /// <summary>
        /// **参数解释**：作业类型。 **取值范围**：枚举值: - PRETRAIN: 预训练 - SFT: 全量微调 - RFT: 强化微调 - RLHF: 强化学习 - QUANTIZATION: 量化 - MANUAL-EVALUATION: 人工评测 - AUTO-EVALUATION: 自动评测 - ONLINE-DEPLOY: 在线部署 - EDGE-DEPLOY: 边缘部署 - LORA: LoRA微调 - QLORA: Q-LoRA微调 - DATA-CLEANING: 数据清洗 - DATA-IMPORT: 数据导入 - DATA-ANNOTATION: 数据标注
        /// </summary>
        /// <value>**参数解释**：作业类型。 **取值范围**：枚举值: - PRETRAIN: 预训练 - SFT: 全量微调 - RFT: 强化微调 - RLHF: 强化学习 - QUANTIZATION: 量化 - MANUAL-EVALUATION: 人工评测 - AUTO-EVALUATION: 自动评测 - ONLINE-DEPLOY: 在线部署 - EDGE-DEPLOY: 边缘部署 - LORA: LoRA微调 - QLORA: Q-LoRA微调 - DATA-CLEANING: 数据清洗 - DATA-IMPORT: 数据导入 - DATA-ANNOTATION: 数据标注</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum PRETRAIN for value: PRETRAIN
            /// </summary>
            public static readonly JobTypeEnum PRETRAIN = new JobTypeEnum("PRETRAIN");

            /// <summary>
            /// Enum SFT for value: SFT
            /// </summary>
            public static readonly JobTypeEnum SFT = new JobTypeEnum("SFT");

            /// <summary>
            /// Enum RFT for value: RFT
            /// </summary>
            public static readonly JobTypeEnum RFT = new JobTypeEnum("RFT");

            /// <summary>
            /// Enum RLHF for value: RLHF
            /// </summary>
            public static readonly JobTypeEnum RLHF = new JobTypeEnum("RLHF");

            /// <summary>
            /// Enum QUANTIZATION for value: QUANTIZATION
            /// </summary>
            public static readonly JobTypeEnum QUANTIZATION = new JobTypeEnum("QUANTIZATION");

            /// <summary>
            /// Enum MANUAL_EVALUATION for value: MANUAL-EVALUATION
            /// </summary>
            public static readonly JobTypeEnum MANUAL_EVALUATION = new JobTypeEnum("MANUAL-EVALUATION");

            /// <summary>
            /// Enum AUTO_EVALUATION for value: AUTO-EVALUATION
            /// </summary>
            public static readonly JobTypeEnum AUTO_EVALUATION = new JobTypeEnum("AUTO-EVALUATION");

            /// <summary>
            /// Enum ONLINE_DEPLOY for value: ONLINE-DEPLOY
            /// </summary>
            public static readonly JobTypeEnum ONLINE_DEPLOY = new JobTypeEnum("ONLINE-DEPLOY");

            /// <summary>
            /// Enum EDGE_DEPLOY for value: EDGE-DEPLOY
            /// </summary>
            public static readonly JobTypeEnum EDGE_DEPLOY = new JobTypeEnum("EDGE-DEPLOY");

            /// <summary>
            /// Enum LORA for value: LORA
            /// </summary>
            public static readonly JobTypeEnum LORA = new JobTypeEnum("LORA");

            /// <summary>
            /// Enum QLORA for value: QLORA
            /// </summary>
            public static readonly JobTypeEnum QLORA = new JobTypeEnum("QLORA");

            /// <summary>
            /// Enum DATA_CLEANING for value: DATA-CLEANING
            /// </summary>
            public static readonly JobTypeEnum DATA_CLEANING = new JobTypeEnum("DATA-CLEANING");

            /// <summary>
            /// Enum DATA_IMPORT for value: DATA-IMPORT
            /// </summary>
            public static readonly JobTypeEnum DATA_IMPORT = new JobTypeEnum("DATA-IMPORT");

            /// <summary>
            /// Enum DATA_ANNOTATION for value: DATA-ANNOTATION
            /// </summary>
            public static readonly JobTypeEnum DATA_ANNOTATION = new JobTypeEnum("DATA-ANNOTATION");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "PRETRAIN", PRETRAIN },
                { "SFT", SFT },
                { "RFT", RFT },
                { "RLHF", RLHF },
                { "QUANTIZATION", QUANTIZATION },
                { "MANUAL-EVALUATION", MANUAL_EVALUATION },
                { "AUTO-EVALUATION", AUTO_EVALUATION },
                { "ONLINE-DEPLOY", ONLINE_DEPLOY },
                { "EDGE-DEPLOY", EDGE_DEPLOY },
                { "LORA", LORA },
                { "QLORA", QLORA },
                { "DATA-CLEANING", DATA_CLEANING },
                { "DATA-IMPORT", DATA_IMPORT },
                { "DATA-ANNOTATION", DATA_ANNOTATION },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：关联任务状态。 **取值范围**：枚举值: - INIT: 初始化 - RUNNING: 运行中 - STOPPED: 已停止 - FAILED: 失败 - SUCCEED: 成功 - DELETED: 已删除
        /// </summary>
        /// <value>**参数解释**：关联任务状态。 **取值范围**：枚举值: - INIT: 初始化 - RUNNING: 运行中 - STOPPED: 已停止 - FAILED: 失败 - SUCCEED: 成功 - DELETED: 已删除</value>
        [JsonConverter(typeof(EnumClassConverter<JobStatusEnum>))]
        public class JobStatusEnum
        {
            /// <summary>
            /// Enum INIT for value: INIT
            /// </summary>
            public static readonly JobStatusEnum INIT = new JobStatusEnum("INIT");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly JobStatusEnum RUNNING = new JobStatusEnum("RUNNING");

            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            public static readonly JobStatusEnum STOPPED = new JobStatusEnum("STOPPED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly JobStatusEnum FAILED = new JobStatusEnum("FAILED");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly JobStatusEnum SUCCEED = new JobStatusEnum("SUCCEED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly JobStatusEnum DELETED = new JobStatusEnum("DELETED");

            private static readonly Dictionary<string, JobStatusEnum> StaticFields =
            new Dictionary<string, JobStatusEnum>()
            {
                { "INIT", INIT },
                { "RUNNING", RUNNING },
                { "STOPPED", STOPPED },
                { "FAILED", FAILED },
                { "SUCCEED", SUCCEED },
                { "DELETED", DELETED },
            };

            private string _value;

            public JobStatusEnum()
            {

            }

            public JobStatusEnum(string value)
            {
                _value = value;
            }

            public static JobStatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as JobStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobStatusEnum a, JobStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(JobStatusEnum a, JobStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：操作记录ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// **参数解释**：华为云项目ID，获取方法请参见[获取项目ID和名称](modelarts_03_0147.xml)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID，[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。]未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：作业类型。 **取值范围**：枚举值: - PRETRAIN: 预训练 - SFT: 全量微调 - RFT: 强化微调 - RLHF: 强化学习 - QUANTIZATION: 量化 - MANUAL-EVALUATION: 人工评测 - AUTO-EVALUATION: 自动评测 - ONLINE-DEPLOY: 在线部署 - EDGE-DEPLOY: 边缘部署 - LORA: LoRA微调 - QLORA: Q-LoRA微调 - DATA-CLEANING: 数据清洗 - DATA-IMPORT: 数据导入 - DATA-ANNOTATION: 数据标注
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// **参数解释**：关联任务ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：关联任务名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// **参数解释**：关联任务状态。 **取值范围**：枚举值: - INIT: 初始化 - RUNNING: 运行中 - STOPPED: 已停止 - FAILED: 失败 - SUCCEED: 成功 - DELETED: 已删除
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public JobStatusEnum JobStatus { get; set; }
        /// <summary>
        /// **参数解释**：操作用户ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**：操作用户的用户名。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**：资产ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// **参数解释**：来源服务。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// **参数解释**：资产编码。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// **参数解释**：资产名称，支持英文字母，数字，中划线，下划线，点，空格，中文汉字。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**：资产版本。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// **参数解释**：操作记录创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：操作记录更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释**：任务是否删除（true: 已删除，false: 未删除）。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// **参数解释**：服务操作详情。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// **参数解释**：预留扩展信息字段。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("record_extend_message", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordExtendMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetOperationRecordRsp {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  isDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("  recordExtendMessage: ").Append(RecordExtendMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetOperationRecordRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetOperationRecordRsp input)
        {
            if (input == null) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.JobType != input.JobType) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.JobStatus != input.JobStatus) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.IsDeleted != input.IsDeleted || (this.IsDeleted != null && !this.IsDeleted.Equals(input.IsDeleted))) return false;
            if (this.Details != input.Details || (this.Details != null && !this.Details.Equals(input.Details))) return false;
            if (this.RecordExtendMessage != input.RecordExtendMessage || (this.RecordExtendMessage != null && !this.RecordExtendMessage.Equals(input.RecordExtendMessage))) return false;

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
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.IsDeleted != null) hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.Details != null) hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.RecordExtendMessage != null) hashCode = hashCode * 59 + this.RecordExtendMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
