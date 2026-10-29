using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LTSAccessConfigInfoRespon200 
    {
        /// <summary>
        /// **参数解释：** 委托接入类型。 **约束限制：** 不涉及。 **取值范围：** - AGENCYACCESS：委托接入。
        /// </summary>
        /// <value>**参数解释：** 委托接入类型。 **约束限制：** 不涉及。 **取值范围：** - AGENCYACCESS：委托接入。</value>
        [JsonConverter(typeof(EnumClassConverter<AccessConfigTypeEnum>))]
        public class AccessConfigTypeEnum
        {
            /// <summary>
            /// Enum AGENT for value: Agent
            /// </summary>
            public static readonly AccessConfigTypeEnum AGENT = new AccessConfigTypeEnum("Agent");

            /// <summary>
            /// Enum CRD for value: CRD
            /// </summary>
            public static readonly AccessConfigTypeEnum CRD = new AccessConfigTypeEnum("CRD");

            /// <summary>
            /// Enum AGENCYACCESS for value: AGENCYACCESS
            /// </summary>
            public static readonly AccessConfigTypeEnum AGENCYACCESS = new AccessConfigTypeEnum("AGENCYACCESS");

            /// <summary>
            /// Enum K8S_CCE for value: K8S_CCE
            /// </summary>
            public static readonly AccessConfigTypeEnum K8S_CCE = new AccessConfigTypeEnum("K8S_CCE");

            /// <summary>
            /// Enum K8S_CUSTOM for value: K8S_CUSTOM
            /// </summary>
            public static readonly AccessConfigTypeEnum K8S_CUSTOM = new AccessConfigTypeEnum("K8S_CUSTOM");

            /// <summary>
            /// Enum CLOUD_STREAM_AGENCY for value: CLOUD_STREAM_AGENCY
            /// </summary>
            public static readonly AccessConfigTypeEnum CLOUD_STREAM_AGENCY = new AccessConfigTypeEnum("CLOUD_STREAM_AGENCY");

            private static readonly Dictionary<string, AccessConfigTypeEnum> StaticFields =
            new Dictionary<string, AccessConfigTypeEnum>()
            {
                { "Agent", AGENT },
                { "CRD", CRD },
                { "AGENCYACCESS", AGENCYACCESS },
                { "K8S_CCE", K8S_CCE },
                { "K8S_CUSTOM", K8S_CUSTOM },
                { "CLOUD_STREAM_AGENCY", CLOUD_STREAM_AGENCY },
            };

            private string _value;

            public AccessConfigTypeEnum()
            {

            }

            public AccessConfigTypeEnum(string value)
            {
                _value = value;
            }

            public static AccessConfigTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessConfigTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessConfigTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessConfigTypeEnum a, AccessConfigTypeEnum b)
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

            public static bool operator !=(AccessConfigTypeEnum a, AccessConfigTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 跨账号日志接入id
        /// </summary>
        [JsonProperty("access_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessConfigId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 跨账号日志接入名称
        /// </summary>
        [JsonProperty("access_config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessConfigName { get; set; }

        /// <summary>
        /// **参数解释：** 委托接入类型。 **约束限制：** 不涉及。 **取值范围：** - AGENCYACCESS：委托接入。
        /// </summary>
        [JsonProperty("access_config_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigTypeEnum AccessConfigType { get; set; }
        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志组名称
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("agency_log_access", NullValueHandling = NullValueHandling.Ignore)]
        public PreviewAgencyLogAccessReqBody AgencyLogAccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LTSAccessConfigInfoRespon200 {\n");
            sb.Append("  accessConfigId: ").Append(AccessConfigId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  accessConfigName: ").Append(AccessConfigName).Append("\n");
            sb.Append("  accessConfigType: ").Append(AccessConfigType).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  agencyLogAccess: ").Append(AgencyLogAccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LTSAccessConfigInfoRespon200);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LTSAccessConfigInfoRespon200 input)
        {
            if (input == null) return false;
            if (this.AccessConfigId != input.AccessConfigId || (this.AccessConfigId != null && !this.AccessConfigId.Equals(input.AccessConfigId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AccessConfigName != input.AccessConfigName || (this.AccessConfigName != null && !this.AccessConfigName.Equals(input.AccessConfigName))) return false;
            if (this.AccessConfigType != input.AccessConfigType) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.AgencyLogAccess != input.AgencyLogAccess || (this.AgencyLogAccess != null && !this.AgencyLogAccess.Equals(input.AgencyLogAccess))) return false;

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
                if (this.AccessConfigId != null) hashCode = hashCode * 59 + this.AccessConfigId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AccessConfigName != null) hashCode = hashCode * 59 + this.AccessConfigName.GetHashCode();
                hashCode = hashCode * 59 + this.AccessConfigType.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.AgencyLogAccess != null) hashCode = hashCode * 59 + this.AgencyLogAccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
