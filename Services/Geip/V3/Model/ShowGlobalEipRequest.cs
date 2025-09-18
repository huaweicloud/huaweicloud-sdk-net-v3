using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowGlobalEipRequest 
    {
        /// <summary>
        /// Defines fields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly FieldsEnum ID = new FieldsEnum("id");

            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly FieldsEnum NAME = new FieldsEnum("name");

            /// <summary>
            /// Enum DESCRIPTION for value: description
            /// </summary>
            public static readonly FieldsEnum DESCRIPTION = new FieldsEnum("description");

            /// <summary>
            /// Enum DOMAIN_ID for value: domain_id
            /// </summary>
            public static readonly FieldsEnum DOMAIN_ID = new FieldsEnum("domain_id");

            /// <summary>
            /// Enum ACCESS_SITE for value: access_site
            /// </summary>
            public static readonly FieldsEnum ACCESS_SITE = new FieldsEnum("access_site");

            /// <summary>
            /// Enum GEIP_POOL_NAME for value: geip_pool_name
            /// </summary>
            public static readonly FieldsEnum GEIP_POOL_NAME = new FieldsEnum("geip_pool_name");

            /// <summary>
            /// Enum ISP for value: isp
            /// </summary>
            public static readonly FieldsEnum ISP = new FieldsEnum("isp");

            /// <summary>
            /// Enum IP_VERSION for value: ip_version
            /// </summary>
            public static readonly FieldsEnum IP_VERSION = new FieldsEnum("ip_version");

            /// <summary>
            /// Enum IP_ADDRESS for value: ip_address
            /// </summary>
            public static readonly FieldsEnum IP_ADDRESS = new FieldsEnum("ip_address");

            /// <summary>
            /// Enum IPV6_ADDRESS for value: ipv6_address
            /// </summary>
            public static readonly FieldsEnum IPV6_ADDRESS = new FieldsEnum("ipv6_address");

            /// <summary>
            /// Enum FREEZEN for value: freezen
            /// </summary>
            public static readonly FieldsEnum FREEZEN = new FieldsEnum("freezen");

            /// <summary>
            /// Enum FREEZEN_INFO for value: freezen_info
            /// </summary>
            public static readonly FieldsEnum FREEZEN_INFO = new FieldsEnum("freezen_info");

            /// <summary>
            /// Enum POLLUTED for value: polluted
            /// </summary>
            public static readonly FieldsEnum POLLUTED = new FieldsEnum("polluted");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly FieldsEnum STATUS = new FieldsEnum("status");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly FieldsEnum CREATED_AT = new FieldsEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly FieldsEnum UPDATED_AT = new FieldsEnum("updated_at");

            /// <summary>
            /// Enum INTERNET_BANDWIDTH_INFO for value: internet_bandwidth_info
            /// </summary>
            public static readonly FieldsEnum INTERNET_BANDWIDTH_INFO = new FieldsEnum("internet_bandwidth_info");

            /// <summary>
            /// Enum GLOBAL_CONNECTION_BANDWIDTH_INFO for value: global_connection_bandwidth_info
            /// </summary>
            public static readonly FieldsEnum GLOBAL_CONNECTION_BANDWIDTH_INFO = new FieldsEnum("global_connection_bandwidth_info");

            /// <summary>
            /// Enum ASSOCIATE_INSTANCE_INFO for value: associate_instance_info
            /// </summary>
            public static readonly FieldsEnum ASSOCIATE_INSTANCE_INFO = new FieldsEnum("associate_instance_info");

            /// <summary>
            /// Enum IS_PRE_PAID for value: is_pre_paid
            /// </summary>
            public static readonly FieldsEnum IS_PRE_PAID = new FieldsEnum("is_pre_paid");

            /// <summary>
            /// Enum TAGS for value: tags
            /// </summary>
            public static readonly FieldsEnum TAGS = new FieldsEnum("tags");

            /// <summary>
            /// Enum SYS_TAGS for value: sys_tags
            /// </summary>
            public static readonly FieldsEnum SYS_TAGS = new FieldsEnum("sys_tags");

            /// <summary>
            /// Enum ENTERPRISE_PROJECT_ID for value: enterprise_project_id
            /// </summary>
            public static readonly FieldsEnum ENTERPRISE_PROJECT_ID = new FieldsEnum("enterprise_project_id");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "id", ID },
                { "name", NAME },
                { "description", DESCRIPTION },
                { "domain_id", DOMAIN_ID },
                { "access_site", ACCESS_SITE },
                { "geip_pool_name", GEIP_POOL_NAME },
                { "isp", ISP },
                { "ip_version", IP_VERSION },
                { "ip_address", IP_ADDRESS },
                { "ipv6_address", IPV6_ADDRESS },
                { "freezen", FREEZEN },
                { "freezen_info", FREEZEN_INFO },
                { "polluted", POLLUTED },
                { "status", STATUS },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "internet_bandwidth_info", INTERNET_BANDWIDTH_INFO },
                { "global_connection_bandwidth_info", GLOBAL_CONNECTION_BANDWIDTH_INFO },
                { "associate_instance_info", ASSOCIATE_INSTANCE_INFO },
                { "is_pre_paid", IS_PRE_PAID },
                { "tags", TAGS },
                { "sys_tags", SYS_TAGS },
                { "enterprise_project_id", ENTERPRISE_PROJECT_ID },
            };

            private string _value;

            public FieldsEnum()
            {

            }

            public FieldsEnum(string value)
            {
                _value = value;
            }

            public static FieldsEnum FromValue(string value)
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

                if (this.Equals(obj as FieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldsEnum a, FieldsEnum b)
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

            public static bool operator !=(FieldsEnum a, FieldsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("global_eip_id", IsPath = true)]
        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldsEnum> Fields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGlobalEipRequest {\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGlobalEipRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGlobalEipRequest input)
        {
            if (input == null) return false;
            if (this.GlobalEipId != input.GlobalEipId || (this.GlobalEipId != null && !this.GlobalEipId.Equals(input.GlobalEipId))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;

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
                if (this.GlobalEipId != null) hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}
