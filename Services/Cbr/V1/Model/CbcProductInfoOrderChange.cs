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
    /// 
    /// </summary>
    public class CbcProductInfoOrderChange 
    {
        /// <summary>
        /// 用户购买云服务产品的资源规格 Enum: [vault.backup.server.normal，vault.backup.turbo.normal, vault.backup.database.normal，vault.backup.volume.normal，vault.backup.rds.normal，vault.replication.server.normal，vault.hybrid.server.normal]
        /// </summary>
        /// <value>用户购买云服务产品的资源规格 Enum: [vault.backup.server.normal，vault.backup.turbo.normal, vault.backup.database.normal，vault.backup.volume.normal，vault.backup.rds.normal，vault.replication.server.normal，vault.hybrid.server.normal]</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceSpecCodeEnum>))]
        public class ResourceSpecCodeEnum
        {
            /// <summary>
            /// Enum VAULT_BACKUP_SERVER_NORMAL for value: vault.backup.server.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_BACKUP_SERVER_NORMAL = new ResourceSpecCodeEnum("vault.backup.server.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_TURBO_NORMAL for value: vault.backup.turbo.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_BACKUP_TURBO_NORMAL = new ResourceSpecCodeEnum("vault.backup.turbo.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_DATABASE_NORMAL for value: vault.backup.database.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_BACKUP_DATABASE_NORMAL = new ResourceSpecCodeEnum("vault.backup.database.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_VOLUME_NORMAL for value: vault.backup.volume.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_BACKUP_VOLUME_NORMAL = new ResourceSpecCodeEnum("vault.backup.volume.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_RDS_NORMAL for value: vault.backup.rds.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_BACKUP_RDS_NORMAL = new ResourceSpecCodeEnum("vault.backup.rds.normal");

            /// <summary>
            /// Enum VAULT_REPLICATION_SERVER_NORMAL for value: vault.replication.server.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_REPLICATION_SERVER_NORMAL = new ResourceSpecCodeEnum("vault.replication.server.normal");

            /// <summary>
            /// Enum VAULT_HYBRID_SERVER_NORMAL for value: vault.hybrid.server.normal
            /// </summary>
            public static readonly ResourceSpecCodeEnum VAULT_HYBRID_SERVER_NORMAL = new ResourceSpecCodeEnum("vault.hybrid.server.normal");

            private static readonly Dictionary<string, ResourceSpecCodeEnum> StaticFields =
            new Dictionary<string, ResourceSpecCodeEnum>()
            {
                { "vault.backup.server.normal", VAULT_BACKUP_SERVER_NORMAL },
                { "vault.backup.turbo.normal", VAULT_BACKUP_TURBO_NORMAL },
                { "vault.backup.database.normal", VAULT_BACKUP_DATABASE_NORMAL },
                { "vault.backup.volume.normal", VAULT_BACKUP_VOLUME_NORMAL },
                { "vault.backup.rds.normal", VAULT_BACKUP_RDS_NORMAL },
                { "vault.replication.server.normal", VAULT_REPLICATION_SERVER_NORMAL },
                { "vault.hybrid.server.normal", VAULT_HYBRID_SERVER_NORMAL },
            };

            private string _value;

            public ResourceSpecCodeEnum()
            {

            }

            public ResourceSpecCodeEnum(string value)
            {
                _value = value;
            }

            public static ResourceSpecCodeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceSpecCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceSpecCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceSpecCodeEnum a, ResourceSpecCodeEnum b)
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

            public static bool operator !=(ResourceSpecCodeEnum a, ResourceSpecCodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 产品标识，通过订购询价接口获得，长度限制：1-64，只能由字母、数字、“_”、“-”组成。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 资源容量大小，取值范围：10-10485760
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 资源容量度量标识，枚举值17：GB
        /// </summary>
        [JsonProperty("resource_size_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSizeMeasureId { get; set; }

        /// <summary>
        /// 用户购买云服务产品的资源规格 Enum: [vault.backup.server.normal，vault.backup.turbo.normal, vault.backup.database.normal，vault.backup.volume.normal，vault.backup.rds.normal，vault.replication.server.normal，vault.hybrid.server.normal]
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceSpecCodeEnum ResourceSpecCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbcProductInfoOrderChange {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  resourceSizeMeasureId: ").Append(ResourceSizeMeasureId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcProductInfoOrderChange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcProductInfoOrderChange input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ResourceSize != input.ResourceSize || (this.ResourceSize != null && !this.ResourceSize.Equals(input.ResourceSize))) return false;
            if (this.ResourceSizeMeasureId != input.ResourceSizeMeasureId || (this.ResourceSizeMeasureId != null && !this.ResourceSizeMeasureId.Equals(input.ResourceSizeMeasureId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ResourceSize != null) hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ResourceSizeMeasureId != null) hashCode = hashCode * 59 + this.ResourceSizeMeasureId.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
