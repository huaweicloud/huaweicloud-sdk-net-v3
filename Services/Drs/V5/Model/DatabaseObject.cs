using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据库库级对象。
    /// </summary>
    public class DatabaseObject 
    {
        /// <summary>
        /// 该数据库在实时同步场景下的类型。取值： - config：仅当该库作为数据过滤高级设置的关联库时，需要填写，此时该库以及该库下的schemas、tables“不会”被同步到目标库，name、all属性不生效，schemas、tables需要填写被关联的相关对象。（注意：如果需要同步该库级对象，则在下级对象中填写sync_type值为config。）
        /// </summary>
        /// <value>该数据库在实时同步场景下的类型。取值： - config：仅当该库作为数据过滤高级设置的关联库时，需要填写，此时该库以及该库下的schemas、tables“不会”被同步到目标库，name、all属性不生效，schemas、tables需要填写被关联的相关对象。（注意：如果需要同步该库级对象，则在下级对象中填写sync_type值为config。）</value>
        [JsonConverter(typeof(EnumClassConverter<SyncTypeEnum>))]
        public class SyncTypeEnum
        {
            /// <summary>
            /// Enum CONFIG for value: config
            /// </summary>
            public static readonly SyncTypeEnum CONFIG = new SyncTypeEnum("config");

            private static readonly Dictionary<string, SyncTypeEnum> StaticFields =
            new Dictionary<string, SyncTypeEnum>()
            {
                { "config", CONFIG },
            };

            private string _value;

            public SyncTypeEnum()
            {

            }

            public SyncTypeEnum(string value)
            {
                _value = value;
            }

            public static SyncTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SyncTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SyncTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SyncTypeEnum a, SyncTypeEnum b)
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

            public static bool operator !=(SyncTypeEnum a, SyncTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 该数据库在实时同步场景下的类型。取值： - config：仅当该库作为数据过滤高级设置的关联库时，需要填写，此时该库以及该库下的schemas、tables“不会”被同步到目标库，name、all属性不生效，schemas、tables需要填写被关联的相关对象。（注意：如果需要同步该库级对象，则在下级对象中填写sync_type值为config。）
        /// </summary>
        [JsonProperty("sync_type", NullValueHandling = NullValueHandling.Ignore)]
        public SyncTypeEnum SyncType { get; set; }
        /// <summary>
        /// 该数据库在目标库的名称（库名映射）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否整库迁移或同步。注意： 1.当该库下的模式、表、列需要做数据过滤、列过滤、列映射时，填false，否则填true； 2.当该库下的表需要做附加列时，需要填true，并且在表级对象的columns里填写附加列信息； 3.当该库下的表所包含的列作为数据过滤高级设置的关联列时，需要填true，并且在columns里填写关联列信息，在config_conditions填写数据过滤高级设置的配置条件；
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? All { get; set; }

        /// <summary>
        /// 需要迁移或同步的模式，当整库迁移或同步为false时需要填写。
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SchemaObject> Schemas { get; set; }

        /// <summary>
        /// 需要迁移或同步的表，当整库迁移或同步为false时需要填写。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TableObject> Tables { get; set; }

        /// <summary>
        /// 库下的表的数量，表的数量超过阈值就不显示。
        /// </summary>
        [JsonProperty("total_table_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTableNum { get; set; }

        /// <summary>
        /// 是否已同步
        /// </summary>
        [JsonProperty("is_synchronized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSynchronized { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseObject {\n");
            sb.Append("  syncType: ").Append(SyncType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  all: ").Append(All).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("  totalTableNum: ").Append(TotalTableNum).Append("\n");
            sb.Append("  isSynchronized: ").Append(IsSynchronized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SyncType == input.SyncType ||
                    (this.SyncType != null &&
                    this.SyncType.Equals(input.SyncType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.Schemas == input.Schemas ||
                    this.Schemas != null &&
                    input.Schemas != null &&
                    this.Schemas.SequenceEqual(input.Schemas)
                ) && 
                (
                    this.Tables == input.Tables ||
                    this.Tables != null &&
                    input.Tables != null &&
                    this.Tables.SequenceEqual(input.Tables)
                ) && 
                (
                    this.TotalTableNum == input.TotalTableNum ||
                    (this.TotalTableNum != null &&
                    this.TotalTableNum.Equals(input.TotalTableNum))
                ) && 
                (
                    this.IsSynchronized == input.IsSynchronized ||
                    (this.IsSynchronized != null &&
                    this.IsSynchronized.Equals(input.IsSynchronized))
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
                if (this.SyncType != null)
                    hashCode = hashCode * 59 + this.SyncType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.Schemas != null)
                    hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Tables != null)
                    hashCode = hashCode * 59 + this.Tables.GetHashCode();
                if (this.TotalTableNum != null)
                    hashCode = hashCode * 59 + this.TotalTableNum.GetHashCode();
                if (this.IsSynchronized != null)
                    hashCode = hashCode * 59 + this.IsSynchronized.GetHashCode();
                return hashCode;
            }
        }
    }
}
