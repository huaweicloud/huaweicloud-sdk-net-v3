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
    /// 热key记录结构体
    /// </summary>
    public class HotkeysBody 
    {
        /// <summary>
        /// key类型
        /// </summary>
        /// <value>key类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly TypeEnum STRING = new TypeEnum("string");

            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly TypeEnum LIST = new TypeEnum("list");

            /// <summary>
            /// Enum SET for value: set
            /// </summary>
            public static readonly TypeEnum SET = new TypeEnum("set");

            /// <summary>
            /// Enum ZSET for value: zset
            /// </summary>
            public static readonly TypeEnum ZSET = new TypeEnum("zset");

            /// <summary>
            /// Enum HASH for value: hash
            /// </summary>
            public static readonly TypeEnum HASH = new TypeEnum("hash");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "string", STRING },
                { "list", LIST },
                { "set", SET },
                { "zset", ZSET },
                { "hash", HASH },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// key名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// key类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 热key所在的分片，仅在实例类型为集群时支持,格式为ip:port
        /// </summary>
        [JsonProperty("shard", NullValueHandling = NullValueHandling.Ignore)]
        public string Shard { get; set; }

        /// <summary>
        /// 热key所在的db
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public int? Db { get; set; }

        /// <summary>
        /// key的value大小。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// key大小的单位。type为string时，单位是：byte；type为list/set/zset/hash时，单位是：count
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 表示某个key在一段时间的访问频度，会随着访问的频率而变化。  该值并不是简单的访问频率值，而是一个基于概率的对数计数器结果，最大为255(可表示100万次访问)，超过255后如果继续频繁访问该值并不会继续增大，同时默认如果每过一分钟没有访问，该值会衰减1。 
        /// </summary>
        [JsonProperty("freq", NullValueHandling = NullValueHandling.Ignore)]
        public int? Freq { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotkeysBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  shard: ").Append(Shard).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  freq: ").Append(Freq).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotkeysBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotkeysBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Shard == input.Shard ||
                    (this.Shard != null &&
                    this.Shard.Equals(input.Shard))
                ) && 
                (
                    this.Db == input.Db ||
                    (this.Db != null &&
                    this.Db.Equals(input.Db))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Freq == input.Freq ||
                    (this.Freq != null &&
                    this.Freq.Equals(input.Freq))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Shard != null)
                    hashCode = hashCode * 59 + this.Shard.GetHashCode();
                if (this.Db != null)
                    hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Freq != null)
                    hashCode = hashCode * 59 + this.Freq.GetHashCode();
                return hashCode;
            }
        }
    }
}
