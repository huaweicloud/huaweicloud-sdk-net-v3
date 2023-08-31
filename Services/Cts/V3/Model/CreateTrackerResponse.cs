using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateTrackerResponse : SdkResponse
    {
        /// <summary>
        /// 标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器（system）和数据类追踪器（data）。
        /// </summary>
        /// <value>标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器（system）和数据类追踪器（data）。</value>
        [JsonConverter(typeof(EnumClassConverter<TrackerTypeEnum>))]
        public class TrackerTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: system
            /// </summary>
            public static readonly TrackerTypeEnum SYSTEM = new TrackerTypeEnum("system");

            /// <summary>
            /// Enum DATA for value: data
            /// </summary>
            public static readonly TrackerTypeEnum DATA = new TrackerTypeEnum("data");

            private static readonly Dictionary<string, TrackerTypeEnum> StaticFields =
            new Dictionary<string, TrackerTypeEnum>()
            {
                { "system", SYSTEM },
                { "data", DATA },
            };

            private string _value;

            public TrackerTypeEnum()
            {

            }

            public TrackerTypeEnum(string value)
            {
                _value = value;
            }

            public static TrackerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TrackerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TrackerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TrackerTypeEnum a, TrackerTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TrackerTypeEnum a, TrackerTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 标识追踪器状态，包括正常（enabled），停止（disabled）和异常（error）三种状态，状态为异常时需通过明细（detail）字段说明错误来源。
        /// </summary>
        /// <value>标识追踪器状态，包括正常（enabled），停止（disabled）和异常（error）三种状态，状态为异常时需通过明细（detail）字段说明错误来源。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: enabled
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("enabled");

            /// <summary>
            /// Enum DISABLED for value: disabled
            /// </summary>
            public static readonly StatusEnum DISABLED = new StatusEnum("disabled");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "enabled", ENABLED },
                { "disabled", DISABLED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 追踪器唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 追踪器创建时间戳。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 事件文件转储加密所采用的秘钥id（从KMS获取）。 当\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;和\&quot;is_support_trace_files_encryption\&quot;参数值为“是”时，此参数为必选项。
        /// </summary>
        [JsonProperty("kms_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsId { get; set; }

        /// <summary>
        /// 是否打开事件文件校验。当前环境仅\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时支持该功能。
        /// </summary>
        [JsonProperty("is_support_validate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportValidate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lts", NullValueHandling = NullValueHandling.Ignore)]
        public Lts Lts { get; set; }

        /// <summary>
        /// 标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器（system）和数据类追踪器（data）。
        /// </summary>
        [JsonProperty("tracker_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerTypeEnum TrackerType { get; set; }
        /// <summary>
        /// 账号ID，参见《云审计服务API参考》“获取账号ID和项目ID”章节。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 标识追踪器名称，当前版本默认为“system”。
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 标识追踪器状态，包括正常（enabled），停止（disabled）和异常（error）三种状态，状态为异常时需通过明细（detail）字段说明错误来源。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 该参数仅在追踪器状态异常时返回，用于标识追踪器异常的原因，包括桶策略异常（bucketPolicyError），桶不存在（noBucket）和欠费或冻结（arrears）三种原因。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// 事件文件转储加密功能开关。 该参数必须与kms_id参数同时使用。 当前环境仅\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时支持该功能。
        /// </summary>
        [JsonProperty("is_support_trace_files_encryption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportTraceFilesEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public DataBucketQuery DataBucket { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrackerResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  kmsId: ").Append(KmsId).Append("\n");
            sb.Append("  isSupportValidate: ").Append(IsSupportValidate).Append("\n");
            sb.Append("  lts: ").Append(Lts).Append("\n");
            sb.Append("  trackerType: ").Append(TrackerType).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  isSupportTraceFilesEncryption: ").Append(IsSupportTraceFilesEncryption).Append("\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  dataBucket: ").Append(DataBucket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrackerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrackerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.KmsId == input.KmsId ||
                    (this.KmsId != null &&
                    this.KmsId.Equals(input.KmsId))
                ) && 
                (
                    this.IsSupportValidate == input.IsSupportValidate ||
                    (this.IsSupportValidate != null &&
                    this.IsSupportValidate.Equals(input.IsSupportValidate))
                ) && 
                (
                    this.Lts == input.Lts ||
                    (this.Lts != null &&
                    this.Lts.Equals(input.Lts))
                ) && 
                (
                    this.TrackerType == input.TrackerType ||
                    (this.TrackerType != null &&
                    this.TrackerType.Equals(input.TrackerType))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TrackerName == input.TrackerName ||
                    (this.TrackerName != null &&
                    this.TrackerName.Equals(input.TrackerName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.IsSupportTraceFilesEncryption == input.IsSupportTraceFilesEncryption ||
                    (this.IsSupportTraceFilesEncryption != null &&
                    this.IsSupportTraceFilesEncryption.Equals(input.IsSupportTraceFilesEncryption))
                ) && 
                (
                    this.ObsInfo == input.ObsInfo ||
                    (this.ObsInfo != null &&
                    this.ObsInfo.Equals(input.ObsInfo))
                ) && 
                (
                    this.DataBucket == input.DataBucket ||
                    (this.DataBucket != null &&
                    this.DataBucket.Equals(input.DataBucket))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.KmsId != null)
                    hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                if (this.IsSupportValidate != null)
                    hashCode = hashCode * 59 + this.IsSupportValidate.GetHashCode();
                if (this.Lts != null)
                    hashCode = hashCode * 59 + this.Lts.GetHashCode();
                if (this.TrackerType != null)
                    hashCode = hashCode * 59 + this.TrackerType.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TrackerName != null)
                    hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.IsSupportTraceFilesEncryption != null)
                    hashCode = hashCode * 59 + this.IsSupportTraceFilesEncryption.GetHashCode();
                if (this.ObsInfo != null)
                    hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.DataBucket != null)
                    hashCode = hashCode * 59 + this.DataBucket.GetHashCode();
                return hashCode;
            }
        }
    }
}
