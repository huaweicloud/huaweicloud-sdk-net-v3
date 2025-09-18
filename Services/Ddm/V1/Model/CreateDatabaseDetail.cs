using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// databases参数说明
    /// </summary>
    public class CreateDatabaseDetail 
    {
        /// <summary>
        /// 逻辑库的拆分模式。 - cluster表示逻辑库是拆分模式。 - single表示逻辑库是非拆分模式。
        /// </summary>
        /// <value>逻辑库的拆分模式。 - cluster表示逻辑库是拆分模式。 - single表示逻辑库是非拆分模式。</value>
        [JsonConverter(typeof(EnumClassConverter<ShardModeEnum>))]
        public class ShardModeEnum
        {
            /// <summary>
            /// Enum CLUSTER for value: cluster
            /// </summary>
            public static readonly ShardModeEnum CLUSTER = new ShardModeEnum("cluster");

            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly ShardModeEnum SINGLE = new ShardModeEnum("single");

            private static readonly Dictionary<string, ShardModeEnum> StaticFields =
            new Dictionary<string, ShardModeEnum>()
            {
                { "cluster", CLUSTER },
                { "single", SINGLE },
            };

            private string _value;

            public ShardModeEnum()
            {

            }

            public ShardModeEnum(string value)
            {
                _value = value;
            }

            public static ShardModeEnum FromValue(string value)
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

                if (this.Equals(obj as ShardModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShardModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ShardModeEnum a, ShardModeEnum b)
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

            public static bool operator !=(ShardModeEnum a, ShardModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 逻辑库名称，需要满足以下条件：  - 长度为2-48个字符。 - 必须以小写字母开头。 - 可以包含小写字母、数字、下划线，不能包含大写字母和其它特殊字符。 - 禁用关键字：  \&quot;information_schema\&quot;、\&quot;mysql\&quot;、\&quot;performance_schema\&quot;、\&quot;sys\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 逻辑库的拆分模式。 - cluster表示逻辑库是拆分模式。 - single表示逻辑库是非拆分模式。
        /// </summary>
        [JsonProperty("shard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ShardModeEnum ShardMode { get; set; }
        /// <summary>
        /// 同一种工作模式下逻辑库分片的数量。 - shard_unit不为空， shard_unit与关联rds数量的乘积 - shard_unit为空，大于关联的RDS数量，小于等于关联rds数量*64。
        /// </summary>
        [JsonProperty("shard_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// 单个RDS上的逻辑库分片数。非必选  - 非拆分逻辑库，固定为1。 - 拆分逻辑库，大于等于1，小于等于64。
        /// </summary>
        [JsonProperty("shard_unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardUnit { get; set; }

        /// <summary>
        /// 逻辑库关联的RDS。
        /// </summary>
        [JsonProperty("used_rds", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseInstabcesParam> UsedRds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatabaseDetail {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shardMode: ").Append(ShardMode).Append("\n");
            sb.Append("  shardNumber: ").Append(ShardNumber).Append("\n");
            sb.Append("  shardUnit: ").Append(ShardUnit).Append("\n");
            sb.Append("  usedRds: ").Append(UsedRds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatabaseDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatabaseDetail input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ShardMode != input.ShardMode) return false;
            if (this.ShardNumber != input.ShardNumber || (this.ShardNumber != null && !this.ShardNumber.Equals(input.ShardNumber))) return false;
            if (this.ShardUnit != input.ShardUnit || (this.ShardUnit != null && !this.ShardUnit.Equals(input.ShardUnit))) return false;
            if (this.UsedRds != input.UsedRds || (this.UsedRds != null && input.UsedRds != null && !this.UsedRds.SequenceEqual(input.UsedRds))) return false;

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
                hashCode = hashCode * 59 + this.ShardMode.GetHashCode();
                if (this.ShardNumber != null) hashCode = hashCode * 59 + this.ShardNumber.GetHashCode();
                if (this.ShardUnit != null) hashCode = hashCode * 59 + this.ShardUnit.GetHashCode();
                if (this.UsedRds != null) hashCode = hashCode * 59 + this.UsedRds.GetHashCode();
                return hashCode;
            }
        }
    }
}
