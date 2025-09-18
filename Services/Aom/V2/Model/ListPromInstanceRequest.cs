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
    /// Request Object
    /// </summary>
    public class ListPromInstanceRequest 
    {
        /// <summary>
        /// Prometheus实例类型（暂时不支持VPC、KUBERNETES）。
        /// </summary>
        /// <value>Prometheus实例类型（暂时不支持VPC、KUBERNETES）。</value>
        [JsonConverter(typeof(EnumClassConverter<PromTypeEnum>))]
        public class PromTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: default
            /// </summary>
            public static readonly PromTypeEnum DEFAULT = new PromTypeEnum("default");

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
                { "default", DEFAULT },
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

            public static bool operator !=(PromTypeEnum a, PromTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// cce集群开关。
        /// </summary>
        /// <value>cce集群开关。</value>
        [JsonConverter(typeof(EnumClassConverter<CceClusterEnableEnum>))]
        public class CceClusterEnableEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly CceClusterEnableEnum TRUE = new CceClusterEnableEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly CceClusterEnableEnum FALSE = new CceClusterEnableEnum("false");

            private static readonly Dictionary<string, CceClusterEnableEnum> StaticFields =
            new Dictionary<string, CceClusterEnableEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public CceClusterEnableEnum()
            {

            }

            public CceClusterEnableEnum(string value)
            {
                _value = value;
            }

            public static CceClusterEnableEnum FromValue(string value)
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

                if (this.Equals(obj as CceClusterEnableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CceClusterEnableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CceClusterEnableEnum a, CceClusterEnableEnum b)
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

            public static bool operator !=(CceClusterEnableEnum a, CceClusterEnableEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Prometheus实例状态。
        /// </summary>
        /// <value>Prometheus实例状态。</value>
        [JsonConverter(typeof(EnumClassConverter<PromStatusEnum>))]
        public class PromStatusEnum
        {
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly PromStatusEnum DELETED = new PromStatusEnum("DELETED");

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly PromStatusEnum NORMAL = new PromStatusEnum("NORMAL");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly PromStatusEnum ALL = new PromStatusEnum("ALL");

            private static readonly Dictionary<string, PromStatusEnum> StaticFields =
            new Dictionary<string, PromStatusEnum>()
            {
                { "DELETED", DELETED },
                { "NORMAL", NORMAL },
                { "ALL", ALL },
            };

            private string _value;

            public PromStatusEnum()
            {

            }

            public PromStatusEnum(string value)
            {
                _value = value;
            }

            public static PromStatusEnum FromValue(string value)
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

                if (this.Equals(obj as PromStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PromStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PromStatusEnum a, PromStatusEnum b)
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

            public static bool operator !=(PromStatusEnum a, PromStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Prometheus实例id(prom_id与prom_type同时存在时，仅prom_id生效)。
        /// </summary>
        [SDKProperty("prom_id", IsQuery = true)]
        [JsonProperty("prom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromId { get; set; }

        /// <summary>
        /// Prometheus实例类型（暂时不支持VPC、KUBERNETES）。
        /// </summary>
        [SDKProperty("prom_type", IsQuery = true)]
        [JsonProperty("prom_type", NullValueHandling = NullValueHandling.Ignore)]
        public PromTypeEnum PromType { get; set; }
        /// <summary>
        /// cce集群开关。
        /// </summary>
        [SDKProperty("cce_cluster_enable", IsQuery = true)]
        [JsonProperty("cce_cluster_enable", NullValueHandling = NullValueHandling.Ignore)]
        public CceClusterEnableEnum CceClusterEnable { get; set; }
        /// <summary>
        /// Prometheus实例状态。
        /// </summary>
        [SDKProperty("prom_status", IsQuery = true)]
        [JsonProperty("prom_status", NullValueHandling = NullValueHandling.Ignore)]
        public PromStatusEnum PromStatus { get; set; }
        /// <summary>
        /// 企业项目id。 - 查询单个企业项目下实例，填写企业项目id。 - 查询所有企业项目下实例，填写“all_granted_eps”。
        /// </summary>
        [SDKProperty("Enterprise-Project-Id", IsHeader = true)]
        [JsonProperty("Enterprise-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPromInstanceRequest {\n");
            sb.Append("  promId: ").Append(PromId).Append("\n");
            sb.Append("  promType: ").Append(PromType).Append("\n");
            sb.Append("  cceClusterEnable: ").Append(CceClusterEnable).Append("\n");
            sb.Append("  promStatus: ").Append(PromStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPromInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPromInstanceRequest input)
        {
            if (input == null) return false;
            if (this.PromId != input.PromId || (this.PromId != null && !this.PromId.Equals(input.PromId))) return false;
            if (this.PromType != input.PromType) return false;
            if (this.CceClusterEnable != input.CceClusterEnable) return false;
            if (this.PromStatus != input.PromStatus) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.PromId != null) hashCode = hashCode * 59 + this.PromId.GetHashCode();
                hashCode = hashCode * 59 + this.PromType.GetHashCode();
                hashCode = hashCode * 59 + this.CceClusterEnable.GetHashCode();
                hashCode = hashCode * 59 + this.PromStatus.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
