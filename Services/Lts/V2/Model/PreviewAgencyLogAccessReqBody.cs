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
    public class PreviewAgencyLogAccessReqBody 
    {
        /// <summary>
        /// 日志访问类型
        /// </summary>
        /// <value>日志访问类型</value>
        [JsonConverter(typeof(EnumClassConverter<AgencyAccessTypeEnum>))]
        public class AgencyAccessTypeEnum
        {
            /// <summary>
            /// Enum AGENCYACCESS for value: AGENCYACCESS
            /// </summary>
            public static readonly AgencyAccessTypeEnum AGENCYACCESS = new AgencyAccessTypeEnum("AGENCYACCESS");

            private static readonly Dictionary<string, AgencyAccessTypeEnum> StaticFields =
            new Dictionary<string, AgencyAccessTypeEnum>()
            {
                { "AGENCYACCESS", AGENCYACCESS },
            };

            private string _value;

            public AgencyAccessTypeEnum()
            {

            }

            public AgencyAccessTypeEnum(string value)
            {
                _value = value;
            }

            public static AgencyAccessTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AgencyAccessTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgencyAccessTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgencyAccessTypeEnum a, AgencyAccessTypeEnum b)
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

            public static bool operator !=(AgencyAccessTypeEnum a, AgencyAccessTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志访问类型
        /// </summary>
        [JsonProperty("agency_access_type", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyAccessTypeEnum AgencyAccessType { get; set; }
        /// <summary>
        /// 跨账号日志接入配置名称
        /// </summary>
        [JsonProperty("agency_log_access", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyLogAccess { get; set; }

        /// <summary>
        /// 委托日志流名称
        /// </summary>
        [JsonProperty("log_agencyStream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogAgencyStreamName { get; set; }

        /// <summary>
        /// 委托日志流id
        /// </summary>
        [JsonProperty("log_agencyStream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogAgencyStreamId { get; set; }

        /// <summary>
        /// 委托日志组名称
        /// </summary>
        [JsonProperty("log_agencyGroup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogAgencyGroupName { get; set; }

        /// <summary>
        /// 委托日志组id
        /// </summary>
        [JsonProperty("log_agencyGroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogAgencyGroupId { get; set; }

        /// <summary>
        /// 被委托日志流名称
        /// </summary>
        [JsonProperty("log_beAgencystream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogBeAgencystreamName { get; set; }

        /// <summary>
        /// 被委托日志流id
        /// </summary>
        [JsonProperty("log_beAgencystream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogBeAgencystreamId { get; set; }

        /// <summary>
        /// 被委托日志组名称
        /// </summary>
        [JsonProperty("log_beAgencygroup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogBeAgencygroupName { get; set; }

        /// <summary>
        /// 被委托日志组id
        /// </summary>
        [JsonProperty("log_beAgencygroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogBeAgencygroupId { get; set; }

        /// <summary>
        /// 被委托项目id
        /// </summary>
        [JsonProperty("be_agency_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeAgencyProjectId { get; set; }

        /// <summary>
        /// 委托项目id
        /// </summary>
        [JsonProperty("agency_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyProjectId { get; set; }

        /// <summary>
        /// 委托账号名称
        /// </summary>
        [JsonProperty("agency_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyDomainName { get; set; }

        /// <summary>
        /// 委托名称
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewAgencyLogAccessReqBody {\n");
            sb.Append("  agencyAccessType: ").Append(AgencyAccessType).Append("\n");
            sb.Append("  agencyLogAccess: ").Append(AgencyLogAccess).Append("\n");
            sb.Append("  logAgencyStreamName: ").Append(LogAgencyStreamName).Append("\n");
            sb.Append("  logAgencyStreamId: ").Append(LogAgencyStreamId).Append("\n");
            sb.Append("  logAgencyGroupName: ").Append(LogAgencyGroupName).Append("\n");
            sb.Append("  logAgencyGroupId: ").Append(LogAgencyGroupId).Append("\n");
            sb.Append("  logBeAgencystreamName: ").Append(LogBeAgencystreamName).Append("\n");
            sb.Append("  logBeAgencystreamId: ").Append(LogBeAgencystreamId).Append("\n");
            sb.Append("  logBeAgencygroupName: ").Append(LogBeAgencygroupName).Append("\n");
            sb.Append("  logBeAgencygroupId: ").Append(LogBeAgencygroupId).Append("\n");
            sb.Append("  beAgencyProjectId: ").Append(BeAgencyProjectId).Append("\n");
            sb.Append("  agencyProjectId: ").Append(AgencyProjectId).Append("\n");
            sb.Append("  agencyDomainName: ").Append(AgencyDomainName).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreviewAgencyLogAccessReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreviewAgencyLogAccessReqBody input)
        {
            if (input == null) return false;
            if (this.AgencyAccessType != input.AgencyAccessType) return false;
            if (this.AgencyLogAccess != input.AgencyLogAccess || (this.AgencyLogAccess != null && !this.AgencyLogAccess.Equals(input.AgencyLogAccess))) return false;
            if (this.LogAgencyStreamName != input.LogAgencyStreamName || (this.LogAgencyStreamName != null && !this.LogAgencyStreamName.Equals(input.LogAgencyStreamName))) return false;
            if (this.LogAgencyStreamId != input.LogAgencyStreamId || (this.LogAgencyStreamId != null && !this.LogAgencyStreamId.Equals(input.LogAgencyStreamId))) return false;
            if (this.LogAgencyGroupName != input.LogAgencyGroupName || (this.LogAgencyGroupName != null && !this.LogAgencyGroupName.Equals(input.LogAgencyGroupName))) return false;
            if (this.LogAgencyGroupId != input.LogAgencyGroupId || (this.LogAgencyGroupId != null && !this.LogAgencyGroupId.Equals(input.LogAgencyGroupId))) return false;
            if (this.LogBeAgencystreamName != input.LogBeAgencystreamName || (this.LogBeAgencystreamName != null && !this.LogBeAgencystreamName.Equals(input.LogBeAgencystreamName))) return false;
            if (this.LogBeAgencystreamId != input.LogBeAgencystreamId || (this.LogBeAgencystreamId != null && !this.LogBeAgencystreamId.Equals(input.LogBeAgencystreamId))) return false;
            if (this.LogBeAgencygroupName != input.LogBeAgencygroupName || (this.LogBeAgencygroupName != null && !this.LogBeAgencygroupName.Equals(input.LogBeAgencygroupName))) return false;
            if (this.LogBeAgencygroupId != input.LogBeAgencygroupId || (this.LogBeAgencygroupId != null && !this.LogBeAgencygroupId.Equals(input.LogBeAgencygroupId))) return false;
            if (this.BeAgencyProjectId != input.BeAgencyProjectId || (this.BeAgencyProjectId != null && !this.BeAgencyProjectId.Equals(input.BeAgencyProjectId))) return false;
            if (this.AgencyProjectId != input.AgencyProjectId || (this.AgencyProjectId != null && !this.AgencyProjectId.Equals(input.AgencyProjectId))) return false;
            if (this.AgencyDomainName != input.AgencyDomainName || (this.AgencyDomainName != null && !this.AgencyDomainName.Equals(input.AgencyDomainName))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;

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
                hashCode = hashCode * 59 + this.AgencyAccessType.GetHashCode();
                if (this.AgencyLogAccess != null) hashCode = hashCode * 59 + this.AgencyLogAccess.GetHashCode();
                if (this.LogAgencyStreamName != null) hashCode = hashCode * 59 + this.LogAgencyStreamName.GetHashCode();
                if (this.LogAgencyStreamId != null) hashCode = hashCode * 59 + this.LogAgencyStreamId.GetHashCode();
                if (this.LogAgencyGroupName != null) hashCode = hashCode * 59 + this.LogAgencyGroupName.GetHashCode();
                if (this.LogAgencyGroupId != null) hashCode = hashCode * 59 + this.LogAgencyGroupId.GetHashCode();
                if (this.LogBeAgencystreamName != null) hashCode = hashCode * 59 + this.LogBeAgencystreamName.GetHashCode();
                if (this.LogBeAgencystreamId != null) hashCode = hashCode * 59 + this.LogBeAgencystreamId.GetHashCode();
                if (this.LogBeAgencygroupName != null) hashCode = hashCode * 59 + this.LogBeAgencygroupName.GetHashCode();
                if (this.LogBeAgencygroupId != null) hashCode = hashCode * 59 + this.LogBeAgencygroupId.GetHashCode();
                if (this.BeAgencyProjectId != null) hashCode = hashCode * 59 + this.BeAgencyProjectId.GetHashCode();
                if (this.AgencyProjectId != null) hashCode = hashCode * 59 + this.AgencyProjectId.GetHashCode();
                if (this.AgencyDomainName != null) hashCode = hashCode * 59 + this.AgencyDomainName.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
