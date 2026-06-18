using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTenantRepoEncryptionSettingResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 加密主密钥key的状态。 **取值范围：** 1表示待激活状态,2 表示启用状态,3 表示禁用状态,4 表示计划删除状态,5 表示等待导入状态。
        /// </summary>
        /// <value>**参数解释：** 加密主密钥key的状态。 **取值范围：** 1表示待激活状态,2 表示启用状态,3 表示禁用状态,4 表示计划删除状态,5 表示等待导入状态。</value>
        [JsonConverter(typeof(EnumClassConverter<KeyStateEnum>))]
        public class KeyStateEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly KeyStateEnum _1 = new KeyStateEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly KeyStateEnum _2 = new KeyStateEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly KeyStateEnum _3 = new KeyStateEnum("3");

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            public static readonly KeyStateEnum _4 = new KeyStateEnum("4");

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            public static readonly KeyStateEnum _5 = new KeyStateEnum("5");

            private static readonly Dictionary<string, KeyStateEnum> StaticFields =
            new Dictionary<string, KeyStateEnum>()
            {
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
                { "4", _4 },
                { "5", _5 },
            };

            private string _value;

            public KeyStateEnum()
            {

            }

            public KeyStateEnum(string value)
            {
                _value = value;
            }

            public static KeyStateEnum FromValue(string value)
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

                if (this.Equals(obj as KeyStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyStateEnum a, KeyStateEnum b)
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

            public static bool operator !=(KeyStateEnum a, KeyStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 租户id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释：** 加密类型。 **取值范围：** KMS表示开启KMS加密，normal或者null表示未开启KMS加密。
        /// </summary>
        [JsonProperty("encryption_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启租户下默认加密设置。
        /// </summary>
        [JsonProperty("default_encryption_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultEncryptionEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 加密主密钥的名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("cmk_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkKeyName { get; set; }

        /// <summary>
        /// **参数解释：** 加密主密钥的id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("cmk_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkKeyId { get; set; }

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 加密主密钥key的状态。 **取值范围：** 1表示待激活状态,2 表示启用状态,3 表示禁用状态,4 表示计划删除状态,5 表示等待导入状态。
        /// </summary>
        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public KeyStateEnum KeyState { get; set; }
        /// <summary>
        /// **参数解释：** 当前region 。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释：** region类型。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("region_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantRepoEncryptionSettingResponse {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  encryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  defaultEncryptionEnabled: ").Append(DefaultEncryptionEnabled).Append("\n");
            sb.Append("  cmkKeyName: ").Append(CmkKeyName).Append("\n");
            sb.Append("  cmkKeyId: ").Append(CmkKeyId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  regionType: ").Append(RegionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantRepoEncryptionSettingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantRepoEncryptionSettingResponse input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.EncryptionType != input.EncryptionType || (this.EncryptionType != null && !this.EncryptionType.Equals(input.EncryptionType))) return false;
            if (this.DefaultEncryptionEnabled != input.DefaultEncryptionEnabled || (this.DefaultEncryptionEnabled != null && !this.DefaultEncryptionEnabled.Equals(input.DefaultEncryptionEnabled))) return false;
            if (this.CmkKeyName != input.CmkKeyName || (this.CmkKeyName != null && !this.CmkKeyName.Equals(input.CmkKeyName))) return false;
            if (this.CmkKeyId != input.CmkKeyId || (this.CmkKeyId != null && !this.CmkKeyId.Equals(input.CmkKeyId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.KeyState != input.KeyState) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegionType != input.RegionType || (this.RegionType != null && !this.RegionType.Equals(input.RegionType))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.EncryptionType != null) hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.DefaultEncryptionEnabled != null) hashCode = hashCode * 59 + this.DefaultEncryptionEnabled.GetHashCode();
                if (this.CmkKeyName != null) hashCode = hashCode * 59 + this.CmkKeyName.GetHashCode();
                if (this.CmkKeyId != null) hashCode = hashCode * 59 + this.CmkKeyId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegionType != null) hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
