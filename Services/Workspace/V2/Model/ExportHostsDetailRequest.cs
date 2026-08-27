using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ExportHostsDetailRequest 
    {
        /// <summary>
        /// 云办公主机状态，available-可用的，fault-错误的，released-释放的。
        /// </summary>
        /// <value>云办公主机状态，available-可用的，fault-错误的，released-释放的。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StateEnum AVAILABLE = new StateEnum("available");

            /// <summary>
            /// Enum FAULT for value: fault
            /// </summary>
            public static readonly StateEnum FAULT = new StateEnum("fault");

            /// <summary>
            /// Enum RELEASED for value: released
            /// </summary>
            public static readonly StateEnum RELEASED = new StateEnum("released");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "available", AVAILABLE },
                { "fault", FAULT },
                { "released", RELEASED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - instance_total 云办公主机上的实例总数 - available_vcpus 云办公主机可用的vCPU核数 - available_memory 云办公主机可用的内存大小
        /// </summary>
        /// <value>排序字段名称，需要结合sort_type字段一起使用。 - instance_total 云办公主机上的实例总数 - available_vcpus 云办公主机可用的vCPU核数 - available_memory 云办公主机可用的内存大小</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum INSTANCE_TOTAL for value: instance_total
            /// </summary>
            public static readonly SortFieldEnum INSTANCE_TOTAL = new SortFieldEnum("instance_total");

            /// <summary>
            /// Enum AVAILABLE_VCPUS for value: available_vcpus
            /// </summary>
            public static readonly SortFieldEnum AVAILABLE_VCPUS = new SortFieldEnum("available_vcpus");

            /// <summary>
            /// Enum AVAILABLE_MEMORY for value: available_memory
            /// </summary>
            public static readonly SortFieldEnum AVAILABLE_MEMORY = new SortFieldEnum("available_memory");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "instance_total", INSTANCE_TOTAL },
                { "available_vcpus", AVAILABLE_VCPUS },
                { "available_memory", AVAILABLE_MEMORY },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        /// <value>排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortTypeEnum()
            {

            }

            public SortTypeEnum(string value)
            {
                _value = value;
            }

            public static SortTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SortTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortTypeEnum a, SortTypeEnum b)
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 语言。  - zh_CN：中文 - en_US：英文
        /// </summary>
        /// <value>语言。  - zh_CN：中文 - en_US：英文</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh_CN
            /// </summary>
            public static readonly LanguageEnum ZH_CN = new LanguageEnum("zh_CN");

            /// <summary>
            /// Enum EN_US for value: en_US
            /// </summary>
            public static readonly LanguageEnum EN_US = new LanguageEnum("en_US");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh_CN", ZH_CN },
                { "en_US", EN_US },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
            }

            public static LanguageEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云办公主机名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云办公主机所属区域。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 云办公主机的id。
        /// </summary>
        [SDKProperty("host_id", IsQuery = true)]
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [SDKProperty("host_type", IsQuery = true)]
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HostType { get; set; }

        /// <summary>
        /// 云办公主机类型名称。
        /// </summary>
        [SDKProperty("host_type_name", IsQuery = true)]
        [JsonProperty("host_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostTypeName { get; set; }

        /// <summary>
        /// 云办公主机状态，available-可用的，fault-错误的，released-释放的。
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 每页显示的数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 上一页显示的最后记录的id，与offset同时使用时不生效。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 过滤指定时间起状态变更的专属主机。 日期和时间戳的格式为ISO 8601：CCYY-MM-DDThh:mm:ss±hh:mm 如果包含“hh:mm”值，则将时区作为UTC的偏移量返回。例如，“2015-08-27T09:49:58-05:00”。如果您省略时区，则假定为UTC时区。
        /// </summary>
        [SDKProperty("changes_since", IsQuery = true)]
        [JsonProperty("changes_since", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangesSince { get; set; }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - instance_total 云办公主机上的实例总数 - available_vcpus 云办公主机可用的vCPU核数 - available_memory 云办公主机可用的内存大小
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }
        /// <summary>
        /// 语言。  - zh_CN：中文 - en_US：英文
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportHostsDetailRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  hostTypeName: ").Append(HostTypeName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  changesSince: ").Append(ChangesSince).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportHostsDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportHostsDetailRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.HostType != input.HostType || (this.HostType != null && !this.HostType.Equals(input.HostType))) return false;
            if (this.HostTypeName != input.HostTypeName || (this.HostTypeName != null && !this.HostTypeName.Equals(input.HostTypeName))) return false;
            if (this.State != input.State) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.ChangesSince != input.ChangesSince || (this.ChangesSince != null && !this.ChangesSince.Equals(input.ChangesSince))) return false;
            if (this.SortField != input.SortField) return false;
            if (this.SortType != input.SortType) return false;
            if (this.Language != input.Language) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.HostId != null) hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.HostType != null) hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.HostTypeName != null) hashCode = hashCode * 59 + this.HostTypeName.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.ChangesSince != null) hashCode = hashCode * 59 + this.ChangesSince.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                hashCode = hashCode * 59 + this.SortType.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
