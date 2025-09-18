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
    /// 
    /// </summary>
    public class UpdateTrackerRequestBody 
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

            public static bool operator !=(TrackerTypeEnum a, TrackerTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，更新追踪器会自动创建一个云服务委托：cts_admin_trust。
        /// </summary>
        /// <value>云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，更新追踪器会自动创建一个云服务委托：cts_admin_trust。</value>
        [JsonConverter(typeof(EnumClassConverter<AgencyNameEnum>))]
        public class AgencyNameEnum
        {
            /// <summary>
            /// Enum CTS_ADMIN_TRUST for value: cts_admin_trust
            /// </summary>
            public static readonly AgencyNameEnum CTS_ADMIN_TRUST = new AgencyNameEnum("cts_admin_trust");

            private static readonly Dictionary<string, AgencyNameEnum> StaticFields =
            new Dictionary<string, AgencyNameEnum>()
            {
                { "cts_admin_trust", CTS_ADMIN_TRUST },
            };

            private string _value;

            public AgencyNameEnum()
            {

            }

            public AgencyNameEnum(string value)
            {
                _value = value;
            }

            public static AgencyNameEnum FromValue(string value)
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

                if (this.Equals(obj as AgencyNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgencyNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgencyNameEnum a, AgencyNameEnum b)
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

            public static bool operator !=(AgencyNameEnum a, AgencyNameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 标识追踪器状态，该接口中可修改的状态包括正常（enabled）和停止（disabled）。如果选择修改状态为停止，则修改成功后追踪器停止记录事件。
        /// </summary>
        /// <value>标识追踪器状态，该接口中可修改的状态包括正常（enabled）和停止（disabled）。如果选择修改状态为停止，则修改成功后追踪器停止记录事件。</value>
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
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
        /// 云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，更新追踪器会自动创建一个云服务委托：cts_admin_trust。
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyNameEnum AgencyName { get; set; }
        /// <summary>
        /// 标识追踪器状态，该接口中可修改的状态包括正常（enabled）和停止（disabled）。如果选择修改状态为停止，则修改成功后追踪器停止记录事件。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 是否应用到我的组织。 只针对管理类追踪器。设置为true时，ORG组织下所有成员当前区域的审计日志会转储到该追踪器配置的OBS桶或者LTS日志流，但是事件列表界面不支持查看其它组织成员的审计日志。
        /// </summary>
        [JsonProperty("is_organization_tracker", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOrganizationTracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("management_event_selector", NullValueHandling = NullValueHandling.Ignore)]
        public ManagementEventSelector ManagementEventSelector { get; set; }

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
            sb.Append("class UpdateTrackerRequestBody {\n");
            sb.Append("  trackerType: ").Append(TrackerType).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isOrganizationTracker: ").Append(IsOrganizationTracker).Append("\n");
            sb.Append("  managementEventSelector: ").Append(ManagementEventSelector).Append("\n");
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
            return this.Equals(input as UpdateTrackerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrackerRequestBody input)
        {
            if (input == null) return false;
            if (this.TrackerType != input.TrackerType) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;
            if (this.AgencyName != input.AgencyName) return false;
            if (this.Status != input.Status) return false;
            if (this.IsOrganizationTracker != input.IsOrganizationTracker || (this.IsOrganizationTracker != null && !this.IsOrganizationTracker.Equals(input.IsOrganizationTracker))) return false;
            if (this.ManagementEventSelector != input.ManagementEventSelector || (this.ManagementEventSelector != null && !this.ManagementEventSelector.Equals(input.ManagementEventSelector))) return false;
            if (this.IsLtsEnabled != input.IsLtsEnabled || (this.IsLtsEnabled != null && !this.IsLtsEnabled.Equals(input.IsLtsEnabled))) return false;
            if (this.ObsInfo != input.ObsInfo || (this.ObsInfo != null && !this.ObsInfo.Equals(input.ObsInfo))) return false;
            if (this.IsSupportTraceFilesEncryption != input.IsSupportTraceFilesEncryption || (this.IsSupportTraceFilesEncryption != null && !this.IsSupportTraceFilesEncryption.Equals(input.IsSupportTraceFilesEncryption))) return false;
            if (this.KmsId != input.KmsId || (this.KmsId != null && !this.KmsId.Equals(input.KmsId))) return false;
            if (this.IsSupportValidate != input.IsSupportValidate || (this.IsSupportValidate != null && !this.IsSupportValidate.Equals(input.IsSupportValidate))) return false;
            if (this.DataBucket != input.DataBucket || (this.DataBucket != null && !this.DataBucket.Equals(input.DataBucket))) return false;

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
                hashCode = hashCode * 59 + this.TrackerType.GetHashCode();
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsOrganizationTracker != null) hashCode = hashCode * 59 + this.IsOrganizationTracker.GetHashCode();
                if (this.ManagementEventSelector != null) hashCode = hashCode * 59 + this.ManagementEventSelector.GetHashCode();
                if (this.IsLtsEnabled != null) hashCode = hashCode * 59 + this.IsLtsEnabled.GetHashCode();
                if (this.ObsInfo != null) hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.IsSupportTraceFilesEncryption != null) hashCode = hashCode * 59 + this.IsSupportTraceFilesEncryption.GetHashCode();
                if (this.KmsId != null) hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                if (this.IsSupportValidate != null) hashCode = hashCode * 59 + this.IsSupportValidate.GetHashCode();
                if (this.DataBucket != null) hashCode = hashCode * 59 + this.DataBucket.GetHashCode();
                return hashCode;
            }
        }
    }
}
