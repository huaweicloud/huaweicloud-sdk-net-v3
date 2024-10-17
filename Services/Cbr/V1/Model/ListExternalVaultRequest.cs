using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListExternalVaultRequest 
    {
        /// <summary>
        /// [保护类型。取值为backup，replication和hybrid。](tag:hws,hws_hk) [保护类型。取值为backup和replication。](tag:ocb) [保护类型。取值为backup。](tag:g42,hk-g42,sbc,dt,fcs_vm,ctc,tm,tlf,cmcc,hcso_dt)
        /// </summary>
        /// <value>[保护类型。取值为backup，replication和hybrid。](tag:hws,hws_hk) [保护类型。取值为backup和replication。](tag:ocb) [保护类型。取值为backup。](tag:g42,hk-g42,sbc,dt,fcs_vm,ctc,tm,tlf,cmcc,hcso_dt)</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectTypeEnum>))]
        public class ProtectTypeEnum
        {
            /// <summary>
            /// Enum BACKUP_REPLICATION_HYBRID for value: backup;replication;hybrid
            /// </summary>
            public static readonly ProtectTypeEnum BACKUP_REPLICATION_HYBRID = new ProtectTypeEnum("backup;replication;hybrid");

            private static readonly Dictionary<string, ProtectTypeEnum> StaticFields =
            new Dictionary<string, ProtectTypeEnum>()
            {
                { "backup;replication;hybrid", BACKUP_REPLICATION_HYBRID },
            };

            private string _value;

            public ProtectTypeEnum()
            {

            }

            public ProtectTypeEnum(string value)
            {
                _value = value;
            }

            public static ProtectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectTypeEnum a, ProtectTypeEnum b)
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

            public static bool operator !=(ProtectTypeEnum a, ProtectTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 其他区域的项目ID
        /// </summary>
        [SDKProperty("external_project_id", IsQuery = true)]
        [JsonProperty("external_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalProjectId { get; set; }

        /// <summary>
        /// 每页显示条目数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移值
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// [保护类型。取值为backup，replication和hybrid。](tag:hws,hws_hk) [保护类型。取值为backup和replication。](tag:ocb) [保护类型。取值为backup。](tag:g42,hk-g42,sbc,dt,fcs_vm,ctc,tm,tlf,cmcc,hcso_dt)
        /// </summary>
        [SDKProperty("protect_type", IsQuery = true)]
        [JsonProperty("protect_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectTypeEnum ProtectType { get; set; }
        /// <summary>
        /// 区域ID
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [SDKProperty("objcet_type", IsQuery = true)]
        [JsonProperty("objcet_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjcetType { get; set; }

        /// <summary>
        /// [云类型。取值为public和hybrid。](tag:hws,hws_hk) [云类型。取值为public。](tag:g42,hk-g42,sbc,dt,fcs_vm,ctc,ocb,tm,tlf,cmcc,hcso_dt)
        /// </summary>
        [SDKProperty("cloud_type", IsQuery = true)]
        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudType { get; set; }

        /// <summary>
        /// 存储库ID，指定存储ID时其他过滤条件不生效。
        /// </summary>
        [SDKProperty("vault_id", IsQuery = true)]
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExternalVaultRequest {\n");
            sb.Append("  externalProjectId: ").Append(ExternalProjectId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  protectType: ").Append(ProtectType).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  objcetType: ").Append(ObjcetType).Append("\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListExternalVaultRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListExternalVaultRequest input)
        {
            if (input == null) return false;
            if (this.ExternalProjectId != input.ExternalProjectId || (this.ExternalProjectId != null && !this.ExternalProjectId.Equals(input.ExternalProjectId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.ProtectType != input.ProtectType) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ObjcetType != input.ObjcetType || (this.ObjcetType != null && !this.ObjcetType.Equals(input.ObjcetType))) return false;
            if (this.CloudType != input.CloudType || (this.CloudType != null && !this.CloudType.Equals(input.CloudType))) return false;
            if (this.VaultId != input.VaultId || (this.VaultId != null && !this.VaultId.Equals(input.VaultId))) return false;

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
                if (this.ExternalProjectId != null) hashCode = hashCode * 59 + this.ExternalProjectId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectType.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ObjcetType != null) hashCode = hashCode * 59 + this.ObjcetType.GetHashCode();
                if (this.CloudType != null) hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                if (this.VaultId != null) hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
