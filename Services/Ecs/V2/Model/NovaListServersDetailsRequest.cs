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
    public class NovaListServersDetailsRequest 
    {
        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly SortKeyEnum CREATED_AT = new SortKeyEnum("created_at");

            /// <summary>
            /// Enum AVAILABILITY_ZONE for value: availability_zone
            /// </summary>
            public static readonly SortKeyEnum AVAILABILITY_ZONE = new SortKeyEnum("availability_zone");

            /// <summary>
            /// Enum DISPLAY_NAME for value: display_name
            /// </summary>
            public static readonly SortKeyEnum DISPLAY_NAME = new SortKeyEnum("display_name");

            /// <summary>
            /// Enum HOST for value: host
            /// </summary>
            public static readonly SortKeyEnum HOST = new SortKeyEnum("host");

            /// <summary>
            /// Enum INSTANCE_TYPE_ID for value: instance_type_id
            /// </summary>
            public static readonly SortKeyEnum INSTANCE_TYPE_ID = new SortKeyEnum("instance_type_id");

            /// <summary>
            /// Enum KEY_NAME for value: key_name
            /// </summary>
            public static readonly SortKeyEnum KEY_NAME = new SortKeyEnum("key_name");

            /// <summary>
            /// Enum PROJECT_ID for value: project_id
            /// </summary>
            public static readonly SortKeyEnum PROJECT_ID = new SortKeyEnum("project_id");

            /// <summary>
            /// Enum USER_ID for value: user_id
            /// </summary>
            public static readonly SortKeyEnum USER_ID = new SortKeyEnum("user_id");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly SortKeyEnum UPDATED_AT = new SortKeyEnum("updated_at");

            /// <summary>
            /// Enum UUID for value: uuid
            /// </summary>
            public static readonly SortKeyEnum UUID = new SortKeyEnum("uuid");

            /// <summary>
            /// Enum VM_STATE for value: vm_state
            /// </summary>
            public static readonly SortKeyEnum VM_STATE = new SortKeyEnum("vm_state");

            public static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                {"created_at", CREATED_AT},
                {"availability_zone", AVAILABILITY_ZONE},
                {"display_name", DISPLAY_NAME},
                {"host", HOST},
                {"instance_type_id", INSTANCE_TYPE_ID},
                {"key_name", KEY_NAME},
                {"project_id", PROJECT_ID},
                {"user_id", USER_ID},
                {"updated_at", UPDATED_AT},
                {"uuid", UUID},
                {"vm_state", VM_STATE},
            };

            private string Value;

            public SortKeyEnum(string Value)
            {
                this.Value = Value;
            }

            public static SortKeyEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly StatusEnum BUILD = new StatusEnum("BUILD");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum HARD_REBOOT for value: HARD_REBOOT
            /// </summary>
            public static readonly StatusEnum HARD_REBOOT = new StatusEnum("HARD_REBOOT");

            /// <summary>
            /// Enum MIGRATING for value: MIGRATING
            /// </summary>
            public static readonly StatusEnum MIGRATING = new StatusEnum("MIGRATING");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly StatusEnum REBOOT = new StatusEnum("REBOOT");

            /// <summary>
            /// Enum RESIZE for value: RESIZE
            /// </summary>
            public static readonly StatusEnum RESIZE = new StatusEnum("RESIZE");

            /// <summary>
            /// Enum REVERT_RESIZE for value: REVERT_RESIZE
            /// </summary>
            public static readonly StatusEnum REVERT_RESIZE = new StatusEnum("REVERT_RESIZE");

            /// <summary>
            /// Enum SHELVED for value: SHELVED
            /// </summary>
            public static readonly StatusEnum SHELVED = new StatusEnum("SHELVED");

            /// <summary>
            /// Enum SHELVED_OFFLOADED for value: SHELVED_OFFLOADED
            /// </summary>
            public static readonly StatusEnum SHELVED_OFFLOADED = new StatusEnum("SHELVED_OFFLOADED");

            /// <summary>
            /// Enum SHUTOFF for value: SHUTOFF
            /// </summary>
            public static readonly StatusEnum SHUTOFF = new StatusEnum("SHUTOFF");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly StatusEnum UNKNOWN = new StatusEnum("UNKNOWN");

            /// <summary>
            /// Enum VERIFY_RESIZE for value: VERIFY_RESIZE
            /// </summary>
            public static readonly StatusEnum VERIFY_RESIZE = new StatusEnum("VERIFY_RESIZE");

            public static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                {"ACTIVE", ACTIVE},
                {"BUILD", BUILD},
                {"DELETED", DELETED},
                {"ERROR", ERROR},
                {"HARD_REBOOT", HARD_REBOOT},
                {"MIGRATING", MIGRATING},
                {"REBOOT", REBOOT},
                {"RESIZE", RESIZE},
                {"REVERT_RESIZE", REVERT_RESIZE},
                {"SHELVED", SHELVED},
                {"SHELVED_OFFLOADED", SHELVED_OFFLOADED},
                {"SHUTOFF", SHUTOFF},
                {"UNKNOWN", UNKNOWN},
                {"VERIFY_RESIZE", VERIFY_RESIZE},
            };

            private string Value;

            public StatusEnum(string Value)
            {
                this.Value = Value;
            }

            public static StatusEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 
        /// </summary>
        [SDKProperty("changes-since", IsQuery = true)]
        [JsonProperty("changes-since", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangesSince { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("flavor", IsQuery = true)]
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("image", IsQuery = true)]
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ip", IsQuery = true)]
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

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
        [SDKProperty("not-tags", IsQuery = true)]
        [JsonProperty("not-tags", NullValueHandling = NullValueHandling.Ignore)]
        public string NotTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("reservation_id", IsQuery = true)]
        [JsonProperty("reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("OpenStack-API-Version", IsHeader = true)]
        [JsonProperty("OpenStack-API-Version", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenStackAPIVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaListServersDetailsRequest {\n");
            sb.Append("  changesSince: ").Append(ChangesSince).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  reservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  openStackAPIVersion: ").Append(OpenStackAPIVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaListServersDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaListServersDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangesSince == input.ChangesSince ||
                    (this.ChangesSince != null &&
                    this.ChangesSince.Equals(input.ChangesSince))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    (this.NotTags != null &&
                    this.NotTags.Equals(input.NotTags))
                ) && 
                (
                    this.ReservationId == input.ReservationId ||
                    (this.ReservationId != null &&
                    this.ReservationId.Equals(input.ReservationId))
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.OpenStackAPIVersion == input.OpenStackAPIVersion ||
                    (this.OpenStackAPIVersion != null &&
                    this.OpenStackAPIVersion.Equals(input.OpenStackAPIVersion))
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
                if (this.ChangesSince != null)
                    hashCode = hashCode * 59 + this.ChangesSince.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.ReservationId != null)
                    hashCode = hashCode * 59 + this.ReservationId.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.OpenStackAPIVersion != null)
                    hashCode = hashCode * 59 + this.OpenStackAPIVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
