using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigTemplatesListInfo 
    {
        /// <summary>
        /// 产品类型。 取值范围如下： - generic：普通版 - enterprise：企业版 
        /// </summary>
        /// <value>产品类型。 取值范围如下： - generic：普通版 - enterprise：企业版 </value>
        [JsonConverter(typeof(EnumClassConverter<ProductTypeEnum>))]
        public class ProductTypeEnum
        {
            /// <summary>
            /// Enum GENERIC for value: generic
            /// </summary>
            public static readonly ProductTypeEnum GENERIC = new ProductTypeEnum("generic");

            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly ProductTypeEnum ENTERPRISE = new ProductTypeEnum("enterprise");

            private static readonly Dictionary<string, ProductTypeEnum> StaticFields =
            new Dictionary<string, ProductTypeEnum>()
            {
                { "generic", GENERIC },
                { "enterprise", ENTERPRISE },
            };

            private string _value;

            public ProductTypeEnum()
            {

            }

            public ProductTypeEnum(string value)
            {
                _value = value;
            }

            public static ProductTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProductTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProductTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProductTypeEnum a, ProductTypeEnum b)
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

            public static bool operator !=(ProductTypeEnum a, ProductTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 存储类型。 取值范围如下： - DRAM - SSD 
        /// </summary>
        /// <value>存储类型。 取值范围如下： - DRAM - SSD </value>
        [JsonConverter(typeof(EnumClassConverter<StorageTypeEnum>))]
        public class StorageTypeEnum
        {
            /// <summary>
            /// Enum DRAM for value: DRAM
            /// </summary>
            public static readonly StorageTypeEnum DRAM = new StorageTypeEnum("DRAM");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly StorageTypeEnum SSD = new StorageTypeEnum("SSD");

            private static readonly Dictionary<string, StorageTypeEnum> StaticFields =
            new Dictionary<string, StorageTypeEnum>()
            {
                { "DRAM", DRAM },
                { "SSD", SSD },
            };

            private string _value;

            public StorageTypeEnum()
            {

            }

            public StorageTypeEnum(string value)
            {
                _value = value;
            }

            public static StorageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageTypeEnum a, StorageTypeEnum b)
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

            public static bool operator !=(StorageTypeEnum a, StorageTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 缓存实例类型。取值范围如下： - single：表示单机实例 - ha：表示主备实例 - cluster：表示cluster集群实例 - proxy：表示Proxy集群实例 [- ha_rw_split： 表示读写分离实例](tag:hws) 
        /// </summary>
        [JsonProperty("cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CacheMode { get; set; }

        /// <summary>
        /// 模板的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 缓存引擎：Redis[和Memcached](tag:hws,hws_hk,ocb,sbc,tm,ctc,cmcc)。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 缓存版本。  当缓存引擎为Redis时，取值为4.0或5.0。  [当缓存引擎为Memcached时，该字段为可选，取值为空。](tag:hws,hws_hk,ocb,sbc,tm,ctc,cmcc) 
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 产品类型。 取值范围如下： - generic：普通版 - enterprise：企业版 
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProductTypeEnum ProductType { get; set; }
        /// <summary>
        /// 存储类型。 取值范围如下： - DRAM - SSD 
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public StorageTypeEnum StorageType { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 模板创建时间，仅在自定义参数模板中有意义，格式例如：2023-05-10T11:09:35.802Z
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigTemplatesListInfo {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  cacheMode: ").Append(CacheMode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigTemplatesListInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigTemplatesListInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.CacheMode == input.CacheMode ||
                    (this.CacheMode != null &&
                    this.CacheMode.Equals(input.CacheMode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.CacheMode != null)
                    hashCode = hashCode * 59 + this.CacheMode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
