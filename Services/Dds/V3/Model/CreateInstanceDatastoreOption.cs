using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class CreateInstanceDatastoreOption 
    {
        /// <summary>
        /// 数据库版本类型。支持DDS社区版和增强版。 取值： - 取“DDS-Community”，表示创建社区版实例。 - 取“DDS-Enhanced”，表示创建增强版实例。
        /// </summary>
        /// <value>数据库版本类型。支持DDS社区版和增强版。 取值： - 取“DDS-Community”，表示创建社区版实例。 - 取“DDS-Enhanced”，表示创建增强版实例。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum DDS_COMMUNITY for value: DDS-Community
            /// </summary>
            public static readonly TypeEnum DDS_COMMUNITY = new TypeEnum("DDS-Community");

            /// <summary>
            /// Enum DDS_ENHANCED for value: DDS-Enhanced
            /// </summary>
            public static readonly TypeEnum DDS_ENHANCED = new TypeEnum("DDS-Enhanced");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "DDS-Community", DDS_COMMUNITY },
                { "DDS-Enhanced", DDS_ENHANCED },
            };

            private string Value;

            private TypeEnum(string value)
            {
                this.Value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 存储引擎。DDS社区版支持WiredTiger存储引擎，DDS增强版支持RocksDB存储引擎。 取值： - 社区版引擎取“wiredTiger”。 - 增强版引擎取“rocksDB”。
        /// </summary>
        /// <value>存储引擎。DDS社区版支持WiredTiger存储引擎，DDS增强版支持RocksDB存储引擎。 取值： - 社区版引擎取“wiredTiger”。 - 增强版引擎取“rocksDB”。</value>
        [JsonConverter(typeof(EnumClassConverter<StorageEngineEnum>))]
        public class StorageEngineEnum
        {
            /// <summary>
            /// Enum WIREDTIGER for value: wiredTiger
            /// </summary>
            public static readonly StorageEngineEnum WIREDTIGER = new StorageEngineEnum("wiredTiger");

            /// <summary>
            /// Enum ROCKSDB for value: rocksDB
            /// </summary>
            public static readonly StorageEngineEnum ROCKSDB = new StorageEngineEnum("rocksDB");

            private static readonly Dictionary<string, StorageEngineEnum> StaticFields =
            new Dictionary<string, StorageEngineEnum>()
            {
                { "wiredTiger", WIREDTIGER },
                { "rocksDB", ROCKSDB },
            };

            private string Value;

            private StorageEngineEnum(string value)
            {
                this.Value = value;
            }

            public static StorageEngineEnum FromValue(string value)
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

                if (this.Equals(obj as StorageEngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageEngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StorageEngineEnum a, StorageEngineEnum b)
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

            public static bool operator !=(StorageEngineEnum a, StorageEngineEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库版本类型。支持DDS社区版和增强版。 取值： - 取“DDS-Community”，表示创建社区版实例。 - 取“DDS-Enhanced”，表示创建增强版实例。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 数据库版本。DDS社区版支持3.4、3.2和4.0版本，DDS增强版仅支持3.4版本。 取值： - 社区版引擎取“3.4”、“3.2”或“4.0”。 - 增强版引擎取“3.4”。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 存储引擎。DDS社区版支持WiredTiger存储引擎，DDS增强版支持RocksDB存储引擎。 取值： - 社区版引擎取“wiredTiger”。 - 增强版引擎取“rocksDB”。
        /// </summary>
        [JsonProperty("storage_engine", NullValueHandling = NullValueHandling.Ignore)]
        public StorageEngineEnum StorageEngine { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceDatastoreOption {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  storageEngine: ").Append(StorageEngine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceDatastoreOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceDatastoreOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.StorageEngine == input.StorageEngine ||
                    (this.StorageEngine != null &&
                    this.StorageEngine.Equals(input.StorageEngine))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.StorageEngine != null)
                    hashCode = hashCode * 59 + this.StorageEngine.GetHashCode();
                return hashCode;
            }
        }
    }
}
