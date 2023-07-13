using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.cts.v3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTrackerRequestBody 
    {
        /// <summary>
        /// 标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器(system)和数据类追踪器(data)。 数据类追踪器和管理类追踪器共同参数有：is_lts_enabled, obs_info; 管理类追踪器参数：is_support_trace_files_encryption, kms_id, is_support_validate, is_support_validate; 数据类追踪器参数：tracker_name, data_bucket。
        /// </summary>
        /// <value>标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器(system)和数据类追踪器(data)。 数据类追踪器和管理类追踪器共同参数有：is_lts_enabled, obs_info; 管理类追踪器参数：is_support_trace_files_encryption, kms_id, is_support_validate, is_support_validate; 数据类追踪器参数：tracker_name, data_bucket。</value>
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
        /// 标识追踪器类型。 目前支持系统追踪器类型有管理类追踪器(system)和数据类追踪器(data)。 数据类追踪器和管理类追踪器共同参数有：is_lts_enabled, obs_info; 管理类追踪器参数：is_support_trace_files_encryption, kms_id, is_support_validate, is_support_validate; 数据类追踪器参数：tracker_name, data_bucket。
        /// </summary>
        [JsonProperty("tracker_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerTypeEnum TrackerType { get; set; }
        /// <summary>
        /// 标识追踪器名称。 当\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时该参数为默认值\&quot;system\&quot;。 当\&quot;tracker_type\&quot;参数值为\&quot;data\&quot;时该参数需要指定追踪器名称\&quot;。
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 是否打开事件分析。
        /// </summary>
        [JsonProperty("is_lts_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLtsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 事件文件转储加密功能开关。 当\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时该参数值有效。 该参数必须与kms_id参数同时使用。
        /// </summary>
        [JsonProperty("is_support_trace_files_encryption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportTraceFilesEncryption { get; set; }

        /// <summary>
        /// 事件文件转储加密所采用的秘钥id（从KMS获取）。 当\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时该参数值有效。 当\&quot;is_support_trace_files_encryption\&quot;参数值为“是”时，此参数为必选项。
        /// </summary>
        [JsonProperty("kms_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsId { get; set; }

        /// <summary>
        /// 事件文件转储时是否打开事件文件校验。 当\&quot;tracker_type\&quot;参数值为\&quot;system\&quot;时该参数值有效。
        /// </summary>
        [JsonProperty("is_support_validate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportValidate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public DataBucket DataBucket { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrackerRequestBody {\n");
            sb.Append("  trackerType: ").Append(TrackerType).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  isLtsEnabled: ").Append(IsLtsEnabled).Append("\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  isSupportTraceFilesEncryption: ").Append(IsSupportTraceFilesEncryption).Append("\n");
            sb.Append("  kmsId: ").Append(KmsId).Append("\n");
            sb.Append("  isSupportValidate: ").Append(IsSupportValidate).Append("\n");
            sb.Append("  dataBucket: ").Append(DataBucket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrackerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrackerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackerType == input.TrackerType ||
                    (this.TrackerType != null &&
                    this.TrackerType.Equals(input.TrackerType))
                ) && 
                (
                    this.TrackerName == input.TrackerName ||
                    (this.TrackerName != null &&
                    this.TrackerName.Equals(input.TrackerName))
                ) && 
                (
                    this.IsLtsEnabled == input.IsLtsEnabled ||
                    (this.IsLtsEnabled != null &&
                    this.IsLtsEnabled.Equals(input.IsLtsEnabled))
                ) && 
                (
                    this.ObsInfo == input.ObsInfo ||
                    (this.ObsInfo != null &&
                    this.ObsInfo.Equals(input.ObsInfo))
                ) && 
                (
                    this.IsSupportTraceFilesEncryption == input.IsSupportTraceFilesEncryption ||
                    (this.IsSupportTraceFilesEncryption != null &&
                    this.IsSupportTraceFilesEncryption.Equals(input.IsSupportTraceFilesEncryption))
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
                if (this.TrackerType != null)
                    hashCode = hashCode * 59 + this.TrackerType.GetHashCode();
                if (this.TrackerName != null)
                    hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.IsLtsEnabled != null)
                    hashCode = hashCode * 59 + this.IsLtsEnabled.GetHashCode();
                if (this.ObsInfo != null)
                    hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.IsSupportTraceFilesEncryption != null)
                    hashCode = hashCode * 59 + this.IsSupportTraceFilesEncryption.GetHashCode();
                if (this.KmsId != null)
                    hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                if (this.IsSupportValidate != null)
                    hashCode = hashCode * 59 + this.IsSupportValidate.GetHashCode();
                if (this.DataBucket != null)
                    hashCode = hashCode * 59 + this.DataBucket.GetHashCode();
                return hashCode;
            }
        }
    }
}
