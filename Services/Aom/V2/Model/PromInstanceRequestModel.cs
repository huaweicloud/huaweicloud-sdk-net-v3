using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PromInstanceRequestModel 
    {
        /// <summary>
        /// Prometheus实例类型（暂时不支持VPC、KUBERNETES）。
        /// </summary>
        /// <value>Prometheus实例类型（暂时不支持VPC、KUBERNETES）。</value>
        [JsonConverter(typeof(EnumClassConverter<PromTypeEnum>))]
        public class PromTypeEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly PromTypeEnum ECS = new PromTypeEnum("ECS");

            /// <summary>
            /// Enum VPC for value: VPC
            /// </summary>
            public static readonly PromTypeEnum VPC = new PromTypeEnum("VPC");

            /// <summary>
            /// Enum CCE for value: CCE
            /// </summary>
            public static readonly PromTypeEnum CCE = new PromTypeEnum("CCE");

            /// <summary>
            /// Enum REMOTE_WRITE for value: REMOTE_WRITE
            /// </summary>
            public static readonly PromTypeEnum REMOTE_WRITE = new PromTypeEnum("REMOTE_WRITE");

            /// <summary>
            /// Enum KUBERNETES for value: KUBERNETES
            /// </summary>
            public static readonly PromTypeEnum KUBERNETES = new PromTypeEnum("KUBERNETES");

            /// <summary>
            /// Enum CLOUD_SERVICE for value: CLOUD_SERVICE
            /// </summary>
            public static readonly PromTypeEnum CLOUD_SERVICE = new PromTypeEnum("CLOUD_SERVICE");

            /// <summary>
            /// Enum ACROSS_ACCOUNT for value: ACROSS_ACCOUNT
            /// </summary>
            public static readonly PromTypeEnum ACROSS_ACCOUNT = new PromTypeEnum("ACROSS_ACCOUNT");

            private static readonly Dictionary<string, PromTypeEnum> StaticFields =
            new Dictionary<string, PromTypeEnum>()
            {
                { "ECS", ECS },
                { "VPC", VPC },
                { "CCE", CCE },
                { "REMOTE_WRITE", REMOTE_WRITE },
                { "KUBERNETES", KUBERNETES },
                { "CLOUD_SERVICE", CLOUD_SERVICE },
                { "ACROSS_ACCOUNT", ACROSS_ACCOUNT },
            };

            private string _value;

            public PromTypeEnum()
            {

            }

            public PromTypeEnum(string value)
            {
                _value = value;
            }

            public static PromTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PromTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PromTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PromTypeEnum a, PromTypeEnum b)
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

            public static bool operator !=(PromTypeEnum a, PromTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Prometheus实例名称 名称不能以下划线或中划线开头结尾，只含有中文、英文、数字、下划线、中划线、长度1-100。
        /// </summary>
        [JsonProperty("prom_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PromName { get; set; }

        /// <summary>
        /// Prometheus实例类型（暂时不支持VPC、KUBERNETES）。
        /// </summary>
        [JsonProperty("prom_type", NullValueHandling = NullValueHandling.Ignore)]
        public PromTypeEnum PromType { get; set; }
        /// <summary>
        /// Prometheus实例版本号。
        /// </summary>
        [JsonProperty("prom_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PromVersion { get; set; }

        /// <summary>
        /// Prometheus实例所属的企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// Prometheus实例所属projectId。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromInstanceRequestModel {\n");
            sb.Append("  promName: ").Append(PromName).Append("\n");
            sb.Append("  promType: ").Append(PromType).Append("\n");
            sb.Append("  promVersion: ").Append(PromVersion).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromInstanceRequestModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PromInstanceRequestModel input)
        {
            if (input == null) return false;
            if (this.PromName != input.PromName || (this.PromName != null && !this.PromName.Equals(input.PromName))) return false;
            if (this.PromType != input.PromType) return false;
            if (this.PromVersion != input.PromVersion || (this.PromVersion != null && !this.PromVersion.Equals(input.PromVersion))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.PromName != null) hashCode = hashCode * 59 + this.PromName.GetHashCode();
                hashCode = hashCode * 59 + this.PromType.GetHashCode();
                if (this.PromVersion != null) hashCode = hashCode * 59 + this.PromVersion.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
