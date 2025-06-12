using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRecycleBinServersRequest 
    {
        /// <summary>
        /// Defines expectFields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ExpectFieldsEnum>))]
        public class ExpectFieldsEnum
        {
            /// <summary>
            /// Enum AVAILABLE_VALUES_POWER_STATE for value: Available values : power_state
            /// </summary>
            public static readonly ExpectFieldsEnum AVAILABLE_VALUES_POWER_STATE = new ExpectFieldsEnum("Available values : power_state");

            /// <summary>
            /// Enum HOST_STATUS for value: host_status
            /// </summary>
            public static readonly ExpectFieldsEnum HOST_STATUS = new ExpectFieldsEnum("host_status");

            /// <summary>
            /// Enum HOSTNAME for value: hostname
            /// </summary>
            public static readonly ExpectFieldsEnum HOSTNAME = new ExpectFieldsEnum("hostname");

            /// <summary>
            /// Enum HYPERVISOR_HOSTNAME for value: hypervisor_hostname
            /// </summary>
            public static readonly ExpectFieldsEnum HYPERVISOR_HOSTNAME = new ExpectFieldsEnum("hypervisor_hostname");

            /// <summary>
            /// Enum USER_DATA for value: user_data
            /// </summary>
            public static readonly ExpectFieldsEnum USER_DATA = new ExpectFieldsEnum("user_data");

            /// <summary>
            /// Enum KEY_NAME for value: key_name
            /// </summary>
            public static readonly ExpectFieldsEnum KEY_NAME = new ExpectFieldsEnum("key_name");

            /// <summary>
            /// Enum ROOT_DEVICE_NAME for value: root_device_name
            /// </summary>
            public static readonly ExpectFieldsEnum ROOT_DEVICE_NAME = new ExpectFieldsEnum("root_device_name");

            /// <summary>
            /// Enum VOLUMES_ATTACHED for value: volumes_attached
            /// </summary>
            public static readonly ExpectFieldsEnum VOLUMES_ATTACHED = new ExpectFieldsEnum("volumes_attached");

            /// <summary>
            /// Enum SECURITY_GROUPS for value: security_groups
            /// </summary>
            public static readonly ExpectFieldsEnum SECURITY_GROUPS = new ExpectFieldsEnum("security_groups");

            /// <summary>
            /// Enum ADDRESSES for value: addresses
            /// </summary>
            public static readonly ExpectFieldsEnum ADDRESSES = new ExpectFieldsEnum("addresses");

            /// <summary>
            /// Enum IMAGE for value: image
            /// </summary>
            public static readonly ExpectFieldsEnum IMAGE = new ExpectFieldsEnum("image");

            /// <summary>
            /// Enum METADATA for value: metadata
            /// </summary>
            public static readonly ExpectFieldsEnum METADATA = new ExpectFieldsEnum("metadata");

            /// <summary>
            /// Enum TAGS for value: tags
            /// </summary>
            public static readonly ExpectFieldsEnum TAGS = new ExpectFieldsEnum("tags");

            /// <summary>
            /// Enum SYSTEM_TAGS for value: system_tags
            /// </summary>
            public static readonly ExpectFieldsEnum SYSTEM_TAGS = new ExpectFieldsEnum("system_tags");

            /// <summary>
            /// Enum DEDICATED_HOST_ID for value: dedicated_host_id
            /// </summary>
            public static readonly ExpectFieldsEnum DEDICATED_HOST_ID = new ExpectFieldsEnum("dedicated_host_id");

            /// <summary>
            /// Enum ENTERPRISE_PROJECT_ID for value: enterprise_project_id
            /// </summary>
            public static readonly ExpectFieldsEnum ENTERPRISE_PROJECT_ID = new ExpectFieldsEnum("enterprise_project_id");

            /// <summary>
            /// Enum CPU_OPTIONS for value: cpu_options
            /// </summary>
            public static readonly ExpectFieldsEnum CPU_OPTIONS = new ExpectFieldsEnum("cpu_options");

            private static readonly Dictionary<string, ExpectFieldsEnum> StaticFields =
            new Dictionary<string, ExpectFieldsEnum>()
            {
                { "Available values : power_state", AVAILABLE_VALUES_POWER_STATE },
                { "host_status", HOST_STATUS },
                { "hostname", HOSTNAME },
                { "hypervisor_hostname", HYPERVISOR_HOSTNAME },
                { "user_data", USER_DATA },
                { "key_name", KEY_NAME },
                { "root_device_name", ROOT_DEVICE_NAME },
                { "volumes_attached", VOLUMES_ATTACHED },
                { "security_groups", SECURITY_GROUPS },
                { "addresses", ADDRESSES },
                { "image", IMAGE },
                { "metadata", METADATA },
                { "tags", TAGS },
                { "system_tags", SYSTEM_TAGS },
                { "dedicated_host_id", DEDICATED_HOST_ID },
                { "enterprise_project_id", ENTERPRISE_PROJECT_ID },
                { "cpu_options", CPU_OPTIONS },
            };

            private string _value;

            public ExpectFieldsEnum()
            {

            }

            public ExpectFieldsEnum(string value)
            {
                _value = value;
            }

            public static ExpectFieldsEnum FromValue(string value)
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

                if (this.Equals(obj as ExpectFieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExpectFieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExpectFieldsEnum a, ExpectFieldsEnum b)
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

            public static bool operator !=(ExpectFieldsEnum a, ExpectFieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 所有租户 管理员字段 1: 返回所有租户的VM 0: 返回当前租户的VM，如果为0，与不设置该查询字段的效果一致
        /// </summary>
        [SDKProperty("all_tenants", IsQuery = true)]
        [JsonProperty("all_tenants", NullValueHandling = NullValueHandling.Ignore)]
        public string AllTenants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("expect-fields", IsQuery = true)]
        [JsonProperty("expect-fields", NullValueHandling = NullValueHandling.Ignore)]
        public ExpectFieldsEnum ExpectFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ip_address", IsQuery = true)]
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tags_key", IsQuery = true)]
        [JsonProperty("tags_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagsKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecycleBinServersRequest {\n");
            sb.Append("  allTenants: ").Append(AllTenants).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  expectFields: ").Append(ExpectFields).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsKey: ").Append(TagsKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecycleBinServersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecycleBinServersRequest input)
        {
            if (input == null) return false;
            if (this.AllTenants != input.AllTenants || (this.AllTenants != null && !this.AllTenants.Equals(input.AllTenants))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ExpectFields != input.ExpectFields) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TagsKey != input.TagsKey || (this.TagsKey != null && input.TagsKey != null && !this.TagsKey.SequenceEqual(input.TagsKey))) return false;

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
                if (this.AllTenants != null) hashCode = hashCode * 59 + this.AllTenants.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                hashCode = hashCode * 59 + this.ExpectFields.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsKey != null) hashCode = hashCode * 59 + this.TagsKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
