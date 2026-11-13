using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 创建Supabase应用请求体。
    /// </summary>
    public class CreateSupabaseApplicationRequestBody 
    {
        /// <summary>
        /// 部署模式。当前仅支持Single。
        /// </summary>
        /// <value>部署模式。当前仅支持Single。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ModeEnum SINGLE = new ModeEnum("Single");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Single", SINGLE },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例纳管方式。默认newly_instance。
        /// </summary>
        /// <value>实例纳管方式。默认newly_instance。</value>
        [JsonConverter(typeof(EnumClassConverter<ManageTypeEnum>))]
        public class ManageTypeEnum
        {
            /// <summary>
            /// Enum NEWLY_INSTANCE for value: newly_instance
            /// </summary>
            public static readonly ManageTypeEnum NEWLY_INSTANCE = new ManageTypeEnum("newly_instance");

            /// <summary>
            /// Enum EXISTED_INSTANCE for value: existed_instance
            /// </summary>
            public static readonly ManageTypeEnum EXISTED_INSTANCE = new ManageTypeEnum("existed_instance");

            private static readonly Dictionary<string, ManageTypeEnum> StaticFields =
            new Dictionary<string, ManageTypeEnum>()
            {
                { "newly_instance", NEWLY_INSTANCE },
                { "existed_instance", EXISTED_INSTANCE },
            };

            private string _value;

            public ManageTypeEnum()
            {

            }

            public ManageTypeEnum(string value)
            {
                _value = value;
            }

            public static ManageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ManageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ManageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ManageTypeEnum a, ManageTypeEnum b)
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

            public static bool operator !=(ManageTypeEnum a, ManageTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Supabase应用名称，4~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic_config", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseAppBasicConfig BasicConfig { get; set; }

        /// <summary>
        /// Supabase版本号，格式 x.y.z。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 部署模式。当前仅支持Single。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 规格码，格式 rds.supabase.{...}。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 可用区ID。Single模式下为1个可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 指定实例内网IP（可选）。IPv4格式。
        /// </summary>
        [JsonProperty("data_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVip { get; set; }

        /// <summary>
        /// 指定实例所属安全组（可选）。UUID格式。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 默认用户supabase的密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_component", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseStorageComponentConfig StorageComponent { get; set; }

        /// <summary>
        /// 实例纳管方式。默认newly_instance。
        /// </summary>
        [JsonProperty("manage_type", NullValueHandling = NullValueHandling.Ignore)]
        public ManageTypeEnum ManageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("managed_instance", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseInstanceCreateRequest ManagedInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("existing_instance", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseExistingInstanceRequest ExistingInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSupabaseApplicationRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  basicConfig: ").Append(BasicConfig).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  dataVip: ").Append(DataVip).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  storageComponent: ").Append(StorageComponent).Append("\n");
            sb.Append("  manageType: ").Append(ManageType).Append("\n");
            sb.Append("  managedInstance: ").Append(ManagedInstance).Append("\n");
            sb.Append("  existingInstance: ").Append(ExistingInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSupabaseApplicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSupabaseApplicationRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BasicConfig != input.BasicConfig || (this.BasicConfig != null && !this.BasicConfig.Equals(input.BasicConfig))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.DataVip != input.DataVip || (this.DataVip != null && !this.DataVip.Equals(input.DataVip))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.StorageComponent != input.StorageComponent || (this.StorageComponent != null && !this.StorageComponent.Equals(input.StorageComponent))) return false;
            if (this.ManageType != input.ManageType) return false;
            if (this.ManagedInstance != input.ManagedInstance || (this.ManagedInstance != null && !this.ManagedInstance.Equals(input.ManagedInstance))) return false;
            if (this.ExistingInstance != input.ExistingInstance || (this.ExistingInstance != null && !this.ExistingInstance.Equals(input.ExistingInstance))) return false;

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
                if (this.BasicConfig != null) hashCode = hashCode * 59 + this.BasicConfig.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.DataVip != null) hashCode = hashCode * 59 + this.DataVip.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.StorageComponent != null) hashCode = hashCode * 59 + this.StorageComponent.GetHashCode();
                hashCode = hashCode * 59 + this.ManageType.GetHashCode();
                if (this.ManagedInstance != null) hashCode = hashCode * 59 + this.ManagedInstance.GetHashCode();
                if (this.ExistingInstance != null) hashCode = hashCode * 59 + this.ExistingInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
